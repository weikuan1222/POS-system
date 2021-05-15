Option Strict Off
Option Explicit On
Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Imports System.IO
Imports pos.AddSQL

Public Class Operation

    Inherits System.Windows.Forms.Form

    Public Property loginuser As String
    Dim StoreName As String = "RECEIPT"

    'for item sales | untuk item penjualan
    Dim dtItem As DataTable
    Dim arrWidth() As Integer
    Dim arrFormat() As StringFormat

    'declaring printing format class
    Dim c As New PrintingFormat

    Sub Data_Load()

        dtItem = New DataTable
        With dtItem.Columns
            .Add("bill", Type.GetType("System.String"))
            .Add("amount", Type.GetType("System.String"))
            .Add("remark", Type.GetType("System.String"))
        End With

        Dim ItemRow As DataRow

        ItemRow = dtItem.NewRow()
        ItemRow("bill") = txtBill.Text
        ItemRow("amount") = txtAmount.Text
        ItemRow("remark") = txtRemark.Text
        dtItem.Rows.Add(ItemRow)
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtBill.Text = ""
        txtAmount.Text = ""
        txtRemark.Text = ""
    End Sub

    Private Sub btnCash_Click(sender As Object, e As EventArgs) Handles btnPrint.Click


        If (txtBill.Text = "") Then
            MsgBox("Please insert Bill number")
        ElseIf (txtAmount.Text = "") Then
            MsgBox("Please insert amount")
        ElseIf (txtRemark.Text = "") Then
            MsgBox("Please insert remark")
        Else
            rbtCash.AppendText("Order Summary" & vbNewLine & vbNewLine)
            rbtCash.AppendText("Bill" & vbTab & vbTab & txtBill.Text & vbNewLine)
            rbtCash.AppendText("Amount" & vbTab & vbTab & txtAmount.Text & vbNewLine)
            rbtCash.AppendText("Remark" & vbTab & vbTab & txtRemark.Text & vbNewLine)

            txtUser.Text = loginuser
            txtDate.Text = Date.Now.ToString("dd-MM-yy")

            Dim AddSQL = New AddSQL
            AddSQL.AddBill(txtUser.Text, txtBill.Text, txtDate.Text, txtAmount.Text, txtRemark.Text)

        End If






    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Data_Load()

        Printer.NewPrint()

        'Setting Font
        Printer.SetFont("Courier New", 11, FontStyle.Bold)
        Printer.Print(StoreName) 'Store Name | Nama Toko


        'spacing
        Printer.Print(" ")

        Printer.Print(" ") 'spacing
        Printer.SetFont("Courier New", 8, FontStyle.Bold) 'Setting Font
        arrWidth = {130, 120} 'array for column width | array untuk lebar kolom
        arrFormat = {c.MidLeft, c.MidRight} 'array alignment 

        Printer.Print("Bill No." & txtBill.Text, arrWidth, arrFormat)
        Printer.Print("Amount:" & txtAmount.Text, arrWidth, arrFormat)
        Printer.Print("Remark:" & txtRemark.Text, arrWidth, arrFormat)

        Printer.Print("------------------------------------")
        arrWidth = {130, 120} 'array for column width | array untuk lebar kolom
        arrFormat = {c.MidLeft, c.MidRight} 'array alignment 

        Printer.Print("Cashier:" & txtUser.Text, arrWidth, arrFormat)
        Printer.Print("Date:" & txtDate.Text, arrWidth, arrFormat)

        'Release the job for actual printing
        Printer.DoPrint()


    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim obj As New Report
        obj.loginuser = loginuser
        obj.Show()
        Me.Hide()


    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub Operation_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Application.Exit()

    End Sub


End Class
