Imports System.Data.OleDb
Imports pos.CheckSQL
Public Class Login


    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim CheckSQL = New CheckSQL
        Dim Result

        Try
            Result = CheckSQL.CheckUser(username.Text, password.Text)

        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message)
            End
        End Try

        If (Result = "Sucessful") Then
            MessageBox.Show("Login Successfully!")
            Dim obj As New Operation
            obj.loginuser = username.Text
            obj.Show()
            Me.Hide()

        Else

            MessageBox.Show("Invalid username or password!")
            username.Text = ""
            password.Text = ""
            username.Select()

        End If



    End Sub

    Private Sub Login_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Application.Exit()

    End Sub




End Class

