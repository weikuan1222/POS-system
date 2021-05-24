Imports System.Data.OleDb
Imports pos.CheckSQL
Public Class Report
    Public Property loginuser As String

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim obj As New Operation
        obj.loginuser = loginuser
        obj.Show()
        Me.Hide()

    End Sub
    Private Sub Report_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Application.Exit()

    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim dt As New DataTable
        Dim CheckSQL = New CheckSQL
        dt = CheckSQL.CheckBill(DateTimePicker1, DateTimePicker2, loginuser)

        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "MM/dd/yyyy"

        DateTimePicker2.Format = DateTimePickerFormat.Custom
        DateTimePicker2.CustomFormat = "MM/dd/yyyy"



        DataGridView1.DataSource = dt.DefaultView
    End Sub
End Class