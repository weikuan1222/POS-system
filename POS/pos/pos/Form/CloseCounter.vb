Imports System.Data.OleDb
Imports pos.CheckSQL
Public Class CloseCounter

    Inherits System.Windows.Forms.Form
    Dim ToForm = New ToForm
    Dim ToParent = New ToParent
    Public Property loginuser As String
    Private Sub CloseCounter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt, da As New DataTable
        Dim CheckSQL = New CheckSQL
        da = CheckSQL.ShowInitialCash()
        dt = CheckSQL.CloseCounter()

        DataGridView1.DataSource = dt.DefaultView
        DataGridView2.DataSource = da.DefaultView


        Dim colsum As Decimal = 0
        Dim initialcash As Decimal = 0
        Dim total As Decimal = 0
        For r = 0 To DataGridView2.Rows.Count - 1
            colsum += DataGridView2.Rows(r).Cells(0).Value
        Next
        Label4.Text = colsum
        For i = 0 To DataGridView1.Rows.Count - 1
            initialcash += DataGridView1.Rows(i).Cells(4).Value
            total = initialcash + colsum
        Next
        Label2.Text = initialcash
        Label6.Text = total

    End Sub

    Private Sub CloseCounter_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
        Login.Show()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim obj As New Operation
        obj.loginuser = loginuser
        obj.Show()
        Me.Hide()
    End Sub

End Class