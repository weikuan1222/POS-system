Option Strict Off
Option Explicit On
Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Imports System.IO






Public Class Print


    Public Function Print(txtBill, txtAmount, txtRemark, txtPrice, txtChange, txtUser, txtDate)
        Dim StoreName As String = "RECEIPT"
        Dim arrWidth() As Integer
        Dim arrFormat() As StringFormat
        Dim PrintFormat As New PrintingFormat

        Printer.NewPrint()

        'Setting Font
        Printer.SetFont("Courier New", 11, FontStyle.Bold)
        Printer.Print(StoreName) 'Store Name | Nama Toko


        'spacing
        Printer.Print(" ")

        Printer.Print(" ") 'spacing
        Printer.SetFont("Courier New", 8, FontStyle.Bold) 'Setting Font
        arrWidth = {130, 120} 'array for column width | array untuk lebar kolom
        arrFormat = {PrintFormat.MidLeft, PrintFormat.MidRight} 'array alignment 

        Printer.Print("Bill No." & txtBill, arrWidth, arrFormat)
        Printer.Print("Price: RM" & txtAmount, arrWidth, arrFormat)
        Printer.Print("Remark:" & txtRemark, arrWidth, arrFormat)
        Printer.Print("Amount: RM" & txtPrice, arrWidth, arrFormat)
        Printer.Print("Change: RM" & txtChange, arrWidth, arrFormat)

        Printer.Print("------------------------------------")
        arrWidth = {130, 120} 'array for column width | array untuk lebar kolom
        arrFormat = {PrintFormat.MidLeft, PrintFormat.MidRight} 'array alignment 

        Printer.Print("Cashier:" & txtUser, arrWidth, arrFormat)
        Printer.Print("Date:" & txtDate, arrWidth, arrFormat)

        'Release the job for actual printing
        Printer.DoPrint()

    End Function



End Class
