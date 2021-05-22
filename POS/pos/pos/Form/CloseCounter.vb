Imports System.Data.OleDb
Imports pos.CheckSQL
Public Class CloseCounter
    Private Sub CloseCounter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Dim CheckSQL = New CheckSQL
        Dim colsum As Decimal
        Dim cash As Decimal
        Dim total As Decimal

        dt = CheckSQL.CloseCounter()

        DataGridView1.DataSource = dt.DefaultView
        For Each R As DataGridViewRow In DataGridView1.Rows
            colsum += R.Cells(4).Value
            total = colsum + cash
        Next
        Label2.Text = colsum
        Label4.Text = ""
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