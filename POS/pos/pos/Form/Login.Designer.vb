<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.password = New System.Windows.Forms.TextBox()
        Me.username = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LoginPn = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.LoginPn.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.AutoSize = True
        Me.btnLogin.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold)
        Me.btnLogin.Location = New System.Drawing.Point(238, 349)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(142, 58)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(12, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 40)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Password  :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(169, 40)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "User Name:"
        '
        'password
        '
        Me.password.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold)
        Me.password.Location = New System.Drawing.Point(192, 9)
        Me.password.Name = "password"
        Me.password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.password.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.password.Size = New System.Drawing.Size(300, 45)
        Me.password.TabIndex = 2
        '
        'username
        '
        Me.username.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold)
        Me.username.Location = New System.Drawing.Point(192, 9)
        Me.username.Name = "username"
        Me.username.Size = New System.Drawing.Size(300, 45)
        Me.username.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(230, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(196, 46)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Login Page"
        '
        'LoginPn
        '
        Me.LoginPn.AutoSize = True
        Me.LoginPn.Controls.Add(Me.btnExit)
        Me.LoginPn.Controls.Add(Me.Panel2)
        Me.LoginPn.Controls.Add(Me.Panel1)
        Me.LoginPn.Controls.Add(Me.Label1)
        Me.LoginPn.Controls.Add(Me.btnLogin)
        Me.LoginPn.Location = New System.Drawing.Point(199, 39)
        Me.LoginPn.Name = "LoginPn"
        Me.LoginPn.Size = New System.Drawing.Size(609, 444)
        Me.LoginPn.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.password)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Location = New System.Drawing.Point(72, 228)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(500, 60)
        Me.Panel2.TabIndex = 13
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.username)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(72, 140)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 60)
        Me.Panel1.TabIndex = 12
        '
        'btnExit
        '
        Me.btnExit.AutoSize = True
        Me.btnExit.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold)
        Me.btnExit.Location = New System.Drawing.Point(422, 349)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(142, 58)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 614)
        Me.Controls.Add(Me.LoginPn)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.LoginPn.ResumeLayout(False)
        Me.LoginPn.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents password As TextBox
    Friend WithEvents username As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LoginPn As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExit As Button
End Class
