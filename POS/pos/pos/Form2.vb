Option Strict Off
Option Explicit On
Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Imports System.IO

Public Class Form2

    Inherits System.Windows.Forms.Form

    Public Const GENERIC_WRITE = &H40000000
    Public Const OPEN_EXISTING = 3
    Public Const FILE_SHARE_WRITE = &H2


    Dim LPTPORT As String
    Dim hPort As Integer

    Public Declare Function CreateFile Lib "kernel32" Alias "CreateFileA" (
    ByVal lpFileName As String, ByVal dwDesiredAccess As Integer,
    ByVal dwShareMode As Integer,
    <MarshalAs(UnmanagedType.Struct)> ByRef lpSecurityAttributes As SECURITY_ATTRIBUTES,
    ByVal dwCreationDisposition As Integer, ByVal dwFlagsAndAttributes As Integer,
    ByVal hTemplateFile As Integer) As Integer

    Public Declare Function CloseHandle Lib "kernel32" Alias "CloseHandle" (ByVal hObject As Integer) As Integer
    Dim retval As Integer
    <StructLayout(LayoutKind.Sequential)> Public Structure SECURITY_ATTRIBUTES
        Private nLength As Integer
        Private lpSecurityDescriptor As Integer
        Private bInheritHandle As Integer
    End Structure

    Public Property loginuser As String
    Dim pro As String
    Dim connstring As String
    Dim command As String
    Dim myconnection As OleDbConnection = New OleDbConnection

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

    Public Sub CashDrawer()
        Dim intFileNo As Integer = FreeFile()
        FileOpen(1, "c:\escapes.txt", OpenMode.Output)
        PrintLine(1, Chr(27) & Chr(112) & Chr(0) & Chr(25) & Chr(250))
        FileClose(1)
        Shell("print /d:LPT1 c:\escapes.txt", vbNormalFocus)
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUser.Text = loginuser
        txtDate.Text = Date.Now.ToString("dd-MM-yy")

        pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\usr\Documents\test2.accdb"
        connstring = pro
        myconnection.ConnectionString = connstring

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtBill.Text = ""
        txtAmount.Text = ""
        txtRemark.Text = ""
    End Sub

    Private Sub btnCash_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        rbtCash.AppendText("Order Summary" & vbNewLine & vbNewLine)
        rbtCash.AppendText("Bill" & vbTab & vbTab & txtBill.Text & vbNewLine)
        rbtCash.AppendText("Amount" & vbTab & vbTab & txtAmount.Text & vbNewLine)
        rbtCash.AppendText("Remark" & vbTab & vbTab & txtRemark.Text & vbNewLine)


        pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\usr\Documents\test2.accdb"
        connstring = pro
        myconnection.ConnectionString = connstring
        myconnection.Open()
        command = "INSERT INTO tblReport ([UserName], [Bill], [Date and Time], [Amount], [Remark]) values ('" & txtUser.Text & "', '" & txtBill.Text & "', '" & txtDate.Text & "', '" & txtAmount.Text & "', '" & txtRemark.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(command, myconnection)
        cmd.Parameters.Add(New OleDbParameter("UserName", CType(txtUser.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Bill", CType(txtBill.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Date and Time", CType(txtDate.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Amount", CType(txtAmount.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Remark", CType(txtRemark.Text, String)))

        If (txtBill.Text = "") Then
            MsgBox("Please insert Bill number")
        ElseIf (txtAmount.Text = "") Then
            MsgBox("Please insert amount")
        ElseIf (txtRemark.Text = "") Then
            MsgBox("Please insert remark")
        Else
            MsgBox("Data Saved!")
            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                myconnection.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

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
        arrWidth = {60, 50, 50} 'array for column width | array untuk lebar kolom
        arrFormat = {c.MidLeft, c.MidRight, c.MidRight} 'array alignment 
        arrFormat = {c.MidLeft, c.MidRight, c.MidRight} 'array alignment 
        arrFormat = {c.MidLeft, c.MidRight, c.MidRight} 'array alignment 
        arrFormat = {c.MidLeft, c.MidRight, c.MidRight} 'array alignment 
        arrFormat = {c.MidLeft, c.MidRight, c.MidRight} 'array alignment 

        'column header split by ; | nama kolom dipisah dengan ;
        Printer.Print("bill;amount;remark", arrWidth, arrFormat)
        Printer.SetFont("Courier New", 8, FontStyle.Regular) 'Setting Font
        Printer.Print("------------------------------------") 'line

        For r = 0 To dtItem.Rows.Count - 1
            Printer.Print(dtItem.Rows(r).Item("bill") & ";" & dtItem.Rows(r).Item("amount") & ";" & dtItem.Rows(r).Item("remark"))
        Next

        Printer.Print("------------------------------------")
        arrWidth = {130, 120} 'array for column width | array untuk lebar kolom
        arrFormat = {c.MidLeft, c.MidRight} 'array alignment 

        Printer.Print("Cashier;" & txtUser.Text, arrWidth, arrFormat)
        Printer.Print("Date;" & txtDate.Text, arrWidth, arrFormat)

        'Release the job for actual printing
        Printer.DoPrint()


    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Me.Hide()
        Form3.Show()

    End Sub
End Class