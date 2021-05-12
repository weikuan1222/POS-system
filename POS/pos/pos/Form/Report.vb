Imports System.Data.OleDb
Imports pos.CheckSQL
Public Class Report
    Public Property loginuser As String


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As New DataTable
        Dim CheckSQL = New CheckSQL
        dt = CheckSQL.CheckBill()

        DataGridView1.DataSource = dt.DefaultView


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim obj As New Operation
        obj.loginuser = loginuser
        obj.Show()
        Me.Hide()

    End Sub
    Private Sub Report_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Application.Exit()

    End Sub

End Class