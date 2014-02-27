Imports System.Data.SqlClient
Public Class Suachuanhacc
    Dim da As SqlDataAdapter
    Private Sub Suachuanhacc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Dim conn As New SqlConnection(DataProvider.GetConnString())
        conn.Open()
        Dim cmd As New SqlCommand()
        cmd.CommandText = "nhaCC_select2"
        cmd.CommandType = CommandType.StoredProcedure
        cmd.Connection = conn
        da = New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Private Sub autoupdate()
        Dim dt2 As New DataTable
        dt2 = DataGridView1.DataSource
        Dim auto As New SqlCommandBuilder
        auto = New SqlCommandBuilder(da)
        da.Update(dt2)
    End Sub

    Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
        autoupdate()
    End Sub

    Private Sub DataGridView1_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles DataGridView1.RowsRemoved
        autoupdate()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        autoupdate()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        autoupdate()
    End Sub
End Class