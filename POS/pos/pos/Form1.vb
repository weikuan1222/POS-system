Imports System.Data.OleDb
Public Class Form1
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\usr\Documents\test2.accdb")
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM tblUser WHERE UserName = '" & username.Text & "' AND [Password] = '" & password.Text & "' ", con)
        Dim user As String = ""

        Dim pass As String = ""
        Dim obj As New Form2
        obj.loginuser = username.Text

        con.Open()

        Dim sdr As OleDbDataReader = cmd.ExecuteReader()

        If (sdr.Read() = True) Then

            user = sdr("UserName")

            pass = sdr("Password")

            MessageBox.Show("Login Successfully!")
            obj.Show()
            Me.Hide()
        Else

            MessageBox.Show("Invalid username or password!")

            username.Text = ""
            password.Text = ""
            username.Select()
        End If
        con.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

