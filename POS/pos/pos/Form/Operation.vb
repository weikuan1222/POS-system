Option Strict Off
Option Explicit On
Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Imports System.IO
Imports pos.AddSQL
Imports pos.AutoObjectAdjustment

Public Class Operation

    Inherits System.Windows.Forms.Form
    Dim ToForm = New ToForm
    Dim ToParent = New ToParent
    Public Property loginuser As String

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Login.username.Text = ""
        Login.password.Text = ""

        Dim obj As New CloseCounter
        obj.loginuser = loginuser
        obj.Show()
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtBill.Text = ""
        txtAmount.Text = ""
        txtRemark.Text = ""
        txtPrice.Text = ""
        txtChange.Text = ""
    End Sub

    Private Sub btnCash_Click(sender As Object, e As EventArgs) Handles btnPrint.Click


        If (txtBill.Text = "") Then
            MsgBox("Please insert Bill number")
        ElseIf (txtAmount.Text = "") Then
            MsgBox("Please insert price")
        ElseIf (txtPrice.Text = "") Then
            MsgBox("Please insert amount")
        ElseIf (txtPrice.Text < txtAmount.Text) Then
            MsgBox("Not enough value please insert again")
        Else
            txtChange.Text = txtPrice.Text - txtAmount.Text

            rbtCash.AppendText("Order Summary" & vbNewLine & vbNewLine)
            rbtCash.AppendText("Bill" & vbTab & vbTab & txtBill.Text & vbNewLine)
            rbtCash.AppendText("Price" & vbTab & vbTab & txtAmount.Text & vbNewLine)
            rbtCash.AppendText("Remark" & vbTab & vbTab & txtRemark.Text & vbNewLine)
            rbtCash.AppendText("Amount" & vbTab & vbTab & txtPrice.Text & vbNewLine)
            rbtCash.AppendText("Change" & vbTab & vbTab & txtChange.Text & vbNewLine)

            txtUser.Text = loginuser
            txtDate.Text = Date.Now.ToString("MM/dd/yyyy")

            Dim AddSQL = New AddSQL
            AddSQL.AddBill(txtUser.Text, txtBill.Text, txtAmount.Text, txtRemark.Text, txtPrice.Text, txtChange.Text)
        End If
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim obj As New Report
        obj.loginuser = loginuser
        obj.Show()
        Me.Hide()


    End Sub


    Private Sub Operation_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Application.Exit()

    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.WindowState = FormWindowState.Maximized

    End Sub


    Private Sub Login_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged




    End Sub

    Private Sub btnSwitch_Click(sender As Object, e As EventArgs) Handles btnSwitch.Click
        Me.Hide()
        Login.Show()

    End Sub

End Class
