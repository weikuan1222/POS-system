<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Operation
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.rbtCash = New System.Windows.Forms.RichTextBox()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.txtBill = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnReport
        '
        Me.btnReport.Font = New System.Drawing.Font("Arial Narrow", 12.8!, System.Drawing.FontStyle.Bold)
        Me.btnReport.Location = New System.Drawing.Point(9, 111)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(116, 37)
        Me.btnReport.TabIndex = 36
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'rbtCash
        '
        Me.rbtCash.Enabled = False
        Me.rbtCash.Location = New System.Drawing.Point(109, 149)
        Me.rbtCash.Name = "rbtCash"
        Me.rbtCash.Size = New System.Drawing.Size(249, 251)
        Me.rbtCash.TabIndex = 34
        Me.rbtCash.Text = ""
        '
        'txtUser
        '
        Me.txtUser.Enabled = False
        Me.txtUser.Location = New System.Drawing.Point(164, 17)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(116, 25)
        Me.txtUser.TabIndex = 32
        '
        'txtDate
        '
        Me.txtDate.Enabled = False
        Me.txtDate.Location = New System.Drawing.Point(164, 61)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(116, 25)
        Me.txtDate.TabIndex = 31
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial Narrow", 12.8!, System.Drawing.FontStyle.Bold)
        Me.btnBack.Location = New System.Drawing.Point(9, 58)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(116, 37)
        Me.btnBack.TabIndex = 30
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Arial Narrow", 14.8!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.Location = New System.Drawing.Point(367, 340)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(146, 60)
        Me.btnCancel.TabIndex = 29
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Arial Narrow", 14.8!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.Location = New System.Drawing.Point(96, 340)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(146, 60)
        Me.btnPrint.TabIndex = 28
        Me.btnPrint.Text = "Cash"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'txtRemark
        '
        Me.txtRemark.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold)
        Me.txtRemark.Location = New System.Drawing.Point(260, 239)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(284, 45)
        Me.txtRemark.TabIndex = 27
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold)
        Me.txtAmount.Location = New System.Drawing.Point(260, 169)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(284, 45)
        Me.txtAmount.TabIndex = 26
        '
        'txtBill
        '
        Me.txtBill.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold)
        Me.txtBill.Location = New System.Drawing.Point(260, 100)
        Me.txtBill.Name = "txtBill"
        Me.txtBill.Size = New System.Drawing.Size(284, 45)
        Me.txtBill.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(104, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 40)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Remark:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(104, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 40)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Amount:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(164, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 40)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Bill:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 24.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(199, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 49)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Main Page"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1554, 24)
        Me.MenuStrip1.TabIndex = 33
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.rbtCash)
        Me.Panel1.Controls.Add(Me.txtUser)
        Me.Panel1.Controls.Add(Me.txtDate)
        Me.Panel1.Location = New System.Drawing.Point(952, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(590, 465)
        Me.Panel1.TabIndex = 37
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnReport)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btnBack)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.txtBill)
        Me.Panel2.Controls.Add(Me.btnPrint)
        Me.Panel2.Controls.Add(Me.txtAmount)
        Me.Panel2.Controls.Add(Me.txtRemark)
        Me.Panel2.Location = New System.Drawing.Point(0, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(590, 465)
        Me.Panel2.TabIndex = 38
        '
        'Operation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1554, 888)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Operation"
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReport As Button
    Friend WithEvents rbtCash As RichTextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents txtBill As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
