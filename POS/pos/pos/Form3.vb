Imports System.Data.OleDb
Public Class Form3
    Dim command As New OleDbDataAdapter
    Dim dt As New DataTable
    Dim con As New OleDbConnection
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\usr\Documents\test2.accdb"
        con.Open()
        command = New OleDbDataAdapter("SELECT * FROM tblReport", con)
        command.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
        con.Close()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Form2.Show()

    End Sub
End Class