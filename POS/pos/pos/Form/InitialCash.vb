Option Strict Off
Option Explicit On
Imports System.Data.OleDb
Imports System.Runtime.InteropServices
Imports System.IO
Imports pos.AddSQL
Imports pos.AutoObjectAdjustment

Public Class InitialCash
    Public Property loginuser As String

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim AddSQL = New AddSQL
        Dim CheckSQL = New CheckSQL
        Dim Result
        AddSQL.AddInitialCash(txtCash.Text)

        Dim obj As New Operation
        obj.loginuser = loginuser
        obj.Show()
        Login.Hide()
        Me.Hide()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Login.username.Text = ""
        Login.password.Text = ""

        Me.Close()
        Login.Show()
    End Sub

    Private Sub InitialCash_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub

    Private Sub txtCash_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCash.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            btnConfirm.PerformClick()
        End If
    End Sub
End Class