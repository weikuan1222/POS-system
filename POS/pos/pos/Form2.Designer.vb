<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.PrinterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(38, 155)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(116, 24)
        Me.btnReport.TabIndex = 36
        Me.btnReport.Text = "Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(689, 180)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 24)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Print"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'rbtCash
        '
        Me.rbtCash.Location = New System.Drawing.Point(628, 210)
        Me.rbtCash.Name = "rbtCash"
        Me.rbtCash.Size = New System.Drawing.Size(249, 267)
        Me.rbtCash.TabIndex = 34
        Me.rbtCash.Text = ""
        '
        'txtUser
        '
        Me.txtUser.Enabled = False
        Me.txtUser.Location = New System.Drawing.Point(591, 99)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(116, 22)
        Me.txtUser.TabIndex = 32
        '
        'txtDate
        '
        Me.txtDate.Enabled = False
        Me.txtDate.Location = New System.Drawing.Point(591, 127)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(116, 22)
        Me.txtDate.TabIndex = 31
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(38, 125)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(116, 24)
        Me.btnBack.TabIndex = 30
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(410, 353)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(116, 24)
        Me.btnCancel.TabIndex = 29
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(165, 353)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(116, 24)
        Me.btnPrint.TabIndex = 28
        Me.btnPrint.Text = "Cash"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(289, 299)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(195, 22)
        Me.txtRemark.TabIndex = 27
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(289, 243)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(195, 22)
        Me.txtAmount.TabIndex = 26
        '
        'txtBill
        '
        Me.txtBill.Location = New System.Drawing.Point(289, 189)
        Me.txtBill.Name = "txtBill"
        Me.txtBill.Size = New System.Drawing.Size(195, 22)
        Me.txtBill.TabIndex = 25
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(200, 302)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 17)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Remark:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(200, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Amount:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(230, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 17)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Bill:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(309, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 32)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Main Page"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrinterToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1237, 28)
        Me.MenuStrip1.TabIndex = 33
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PrinterToolStripMenuItem
        '
        Me.PrinterToolStripMenuItem.Name = "PrinterToolStripMenuItem"
        Me.PrinterToolStripMenuItem.Size = New System.Drawing.Size(66, 24)
        Me.PrinterToolStripMenuItem.Text = "Printer"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1237, 522)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.rbtCash)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.txtRemark)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.txtBill)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReport As Button
    Friend WithEvents Button1 As Button
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
    Friend WithEvents PrinterToolStripMenuItem As ToolStripMenuItem
End Class
