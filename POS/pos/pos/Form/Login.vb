Imports System.Data.OleDb
Imports pos.CheckSQL
Imports pos.AutoObjectAdjustment
Public Class Login
    Dim AutoObjectAdjustment = New AutoObjectAdjustment

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

    Private Sub Login_SizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged


        AutoObjectAdjustment.PanelCenterToForm(LoginPn, Me)
        AutoObjectAdjustment.ObjectWidthCenterToParent(Label1)
        AutoObjectAdjustment.ObjectWidthCenterToParent(Panel1)
        AutoObjectAdjustment.ObjectWidthCenterToParent(Panel2)
        AutoObjectAdjustment.ObjectWidthCenterToParent(btnLogin)

    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.WindowState = FormWindowState.Maximized

    End Sub

    Private Sub Username_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles username.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            btnLogin.PerformClick()
        End If
    End Sub

    Private Sub Password_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles password.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            btnLogin.PerformClick()
        End If
    End Sub



End Class

