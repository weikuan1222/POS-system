Imports System.Data.OleDb
Imports pos.CheckSQL
Public Class CloseCounter
    Private Sub CloseCounter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Dim CheckSQL = New CheckSQL
        dt = CheckSQL.CloseCounter()

        DataGridView1.DataSource = dt.DefaultView


        Dim colsum As Decimal = 0
        Dim initialcash As Decimal = 0
        Dim total As Decimal = 0
        For i = 0 To DataGridView1.Rows.Count - 1
            initialcash += DataGridView1.Rows(i).Cells(2).Value
            total = initialcash + colsum
        Next
        Label2.Text = initialcash
        Label4.Text = colsum
        Label6.Text = total

    End Sub

    Private Sub CloseCounter_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
        Login.Show()

    End Sub
End Class