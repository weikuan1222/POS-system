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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtBill = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtChange = New System.Windows.Forms.TextBox()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSwitch = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnReport
        '
        Me.btnReport.Font = New System.Drawing.Font("Arial Narrow", 12.8!, System.Drawing.FontStyle.Bold)
        Me.btnReport.Location = New System.Drawing.Point(376, 24)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(176, 37)
        Me.btnReport.TabIndex = 36
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'rbtCash
        '
        Me.rbtCash.Enabled = False
        Me.rbtCash.Location = New System.Drawing.Point(859, 175)
        Me.rbtCash.Name = "rbtCash"
        Me.rbtCash.Size = New System.Drawing.Size(249, 251)
        Me.rbtCash.TabIndex = 34
        Me.rbtCash.Text = ""
        '
        'txtUser
        '
        Me.txtUser.Enabled = False
        Me.txtUser.Location = New System.Drawing.Point(914, 43)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(116, 25)
        Me.txtUser.TabIndex = 32
        '
        'txtDate
        '
        Me.txtDate.Enabled = False
        Me.txtDate.Location = New System.Drawing.Point(914, 87)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(116, 25)
        Me.txtDate.TabIndex = 31
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial Narrow", 12.8!, System.Drawing.FontStyle.Bold)
        Me.btnExit.Location = New System.Drawing.Point(12, 24)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(176, 37)
        Me.btnExit.TabIndex = 30
        Me.btnExit.Text = "Close Counter"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Arial Narrow", 14.8!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.Location = New System.Drawing.Point(606, 473)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(146, 60)
        Me.btnCancel.TabIndex = 30
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Arial Narrow", 14.8!, System.Drawing.FontStyle.Bold)
        Me.btnPrint.Location = New System.Drawing.Point(285, 473)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(146, 60)
        Me.btnPrint.TabIndex = 29
        Me.btnPrint.Text = "Cash"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'txtRemark
        '
        Me.txtRemark.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold)
        Me.txtRemark.Location = New System.Drawing.Point(434, 244)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(284, 45)
        Me.txtRemark.TabIndex = 27
        '
        'txtPrice
        '
        Me.txtPrice.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold)
        Me.txtPrice.Location = New System.Drawing.Point(434, 173)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(284, 45)
        Me.txtPrice.TabIndex = 26
        '
        'txtBill
        '
        Me.txtBill.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold)
        Me.txtBill.Location = New System.Drawing.Point(434, 105)
        Me.txtBill.Name = "txtBill"
        Me.txtBill.Size = New System.Drawing.Size(284, 45)
        Me.txtBill.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(283, 243)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 40)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Remark:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(316, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 40)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Price:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(339, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 40)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Bill:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 24.8!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(425, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 49)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Main Page"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.rbtCash)
        Me.Panel2.Controls.Add(Me.txtUser)
        Me.Panel2.Controls.Add(Me.txtDate)
        Me.Panel2.Controls.Add(Me.txtChange)
        Me.Panel2.Controls.Add(Me.txtAmount)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.btnCancel)
        Me.Panel2.Controls.Add(Me.txtBill)
        Me.Panel2.Controls.Add(Me.btnPrint)
        Me.Panel2.Controls.Add(Me.txtPrice)
        Me.Panel2.Controls.Add(Me.txtRemark)
        Me.Panel2.Location = New System.Drawing.Point(235, 68)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1158, 600)
        Me.Panel2.TabIndex = 38
        '
        'txtChange
        '
        Me.txtChange.Enabled = False
        Me.txtChange.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold)
        Me.txtChange.Location = New System.Drawing.Point(434, 375)
        Me.txtChange.Name = "txtChange"
        Me.txtChange.Size = New System.Drawing.Size(284, 45)
        Me.txtChange.TabIndex = 40
        '
        'txtAmount
        '
        Me.txtAmount.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold)
        Me.txtAmount.Location = New System.Drawing.Point(434, 310)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(284, 45)
        Me.txtAmount.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(282, 378)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 40)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Change:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(279, 310)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 40)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Amount:"
        '
        'btnSwitch
        '
        Me.btnSwitch.Font = New System.Drawing.Font("Arial Narrow", 12.8!, System.Drawing.FontStyle.Bold)
        Me.btnSwitch.Location = New System.Drawing.Point(194, 25)
        Me.btnSwitch.Name = "btnSwitch"
        Me.btnSwitch.Size = New System.Drawing.Size(176, 37)
        Me.btnSwitch.TabIndex = 41
        Me.btnSwitch.Text = "SwitchUser"
        Me.btnSwitch.UseVisualStyleBackColor = True
        '
        'Operation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1554, 888)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSwitch)
        Me.Controls.Add(Me.btnReport)
        Me.Name = "Operation"
        Me.Text = "Form2"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnReport As Button
    Friend WithEvents rbtCash As RichTextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnPrint As Button
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtBill As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtChange As TextBox
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSwitch As Button
End Class
