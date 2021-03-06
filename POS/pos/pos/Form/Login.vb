Imports System.Data.OleDb
Imports pos.CheckSQL
Imports pos.AutoObjectAdjustment
Imports System.Text.RegularExpressions


Public Class Login
    Dim ToForm = New ToForm
    Dim ToParent = New ToParent
    Dim FrontEndUserInputCheck = New FrontEndUserInputCheck
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


            Dim TodayInitial = CheckSQL.CheckInitialCash()
            If (TodayInitial = "Sucessful") Then
                Dim obj As New Operation
                obj.loginuser = username.Text
                obj.Show()
                Me.Hide()
            Else
                Dim obj As New InitialCash
                obj.loginuser = username.Text
                obj.Show()

            End If


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


        ToForm.CenterTo(LoginPn, Me)
        ToParent.WidthCenterTo(Label1)
        ToParent.WidthCenterTo(Panel1)
        ToParent.WidthCenterTo(Panel2)
        ToParent.WidthCenterTo(btnLogin)

    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles Me.Load

        Me.WindowState = FormWindowState.Maximized
        username.Focus()

    End Sub

    Private Sub Username_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles username.KeyPress

        e.KeyChar = FrontEndUserInputCheck.NoInputSymbol(e, btnLogin)

    End Sub

    Private Sub Password_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles password.KeyPress
        e.KeyChar = FrontEndUserInputCheck.NoInputSymbol(e, btnLogin)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub




End Class

