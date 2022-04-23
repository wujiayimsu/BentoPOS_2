<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrder_discount
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
        Me.pnlButtonGroup = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlDiscountInfo = New System.Windows.Forms.Panel()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnApply = New System.Windows.Forms.Button()
        Me.pnlRibbon = New System.Windows.Forms.Panel()
        Me.lblDeveloper = New System.Windows.Forms.Label()
        Me.pnlDiscountInfo.SuspendLayout()
        Me.pnlRibbon.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlButtonGroup
        '
        Me.pnlButtonGroup.Location = New System.Drawing.Point(34, 282)
        Me.pnlButtonGroup.Name = "pnlButtonGroup"
        Me.pnlButtonGroup.Size = New System.Drawing.Size(444, 157)
        Me.pnlButtonGroup.TabIndex = 0
        '
        'pnlDiscountInfo
        '
        Me.pnlDiscountInfo.Controls.Add(Me.lblDescription)
        Me.pnlDiscountInfo.Controls.Add(Me.lblDiscount)
        Me.pnlDiscountInfo.Controls.Add(Me.Label2)
        Me.pnlDiscountInfo.Controls.Add(Me.Label1)
        Me.pnlDiscountInfo.Location = New System.Drawing.Point(34, 169)
        Me.pnlDiscountInfo.Name = "pnlDiscountInfo"
        Me.pnlDiscountInfo.Size = New System.Drawing.Size(444, 107)
        Me.pnlDiscountInfo.TabIndex = 2
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescription.Location = New System.Drawing.Point(182, 49)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(0, 19)
        Me.lblDescription.TabIndex = 61
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscount.Location = New System.Drawing.Point(182, 14)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(0, 19)
        Me.lblDiscount.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(82, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 19)
        Me.Label2.TabIndex = 58
        Me.Label2.Text = "Description: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(95, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 19)
        Me.Label1.TabIndex = 57
        Me.Label1.Text = "Discount : "
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnClear.BackgroundImage = Global.ReadSearch.My.Resources.Resources.YumPink
        Me.btnClear.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(201, 108)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(110, 40)
        Me.btnClear.TabIndex = 70
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Firebrick
        Me.btnExit.BackgroundImage = Global.ReadSearch.My.Resources.Resources.YumBrown
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnExit.Location = New System.Drawing.Point(378, 106)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 45)
        Me.btnExit.TabIndex = 67
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnApply
        '
        Me.btnApply.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnApply.BackgroundImage = Global.ReadSearch.My.Resources.Resources.YumGreen
        Me.btnApply.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnApply.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnApply.Location = New System.Drawing.Point(34, 108)
        Me.btnApply.Name = "btnApply"
        Me.btnApply.Size = New System.Drawing.Size(100, 40)
        Me.btnApply.TabIndex = 69
        Me.btnApply.Text = "APPLY"
        Me.btnApply.UseVisualStyleBackColor = False
        '
        'pnlRibbon
        '
        Me.pnlRibbon.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.pnlRibbon.BackgroundImage = Global.ReadSearch.My.Resources.Resources.Yum_logo
        Me.pnlRibbon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.pnlRibbon.Controls.Add(Me.lblDeveloper)
        Me.pnlRibbon.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlRibbon.Location = New System.Drawing.Point(0, 0)
        Me.pnlRibbon.Name = "pnlRibbon"
        Me.pnlRibbon.Size = New System.Drawing.Size(510, 100)
        Me.pnlRibbon.TabIndex = 1
        '
        'lblDeveloper
        '
        Me.lblDeveloper.AutoSize = True
        Me.lblDeveloper.Dock = System.Windows.Forms.DockStyle.Right
        Me.lblDeveloper.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeveloper.ForeColor = System.Drawing.Color.White
        Me.lblDeveloper.Location = New System.Drawing.Point(398, 0)
        Me.lblDeveloper.Name = "lblDeveloper"
        Me.lblDeveloper.Size = New System.Drawing.Size(112, 19)
        Me.lblDeveloper.TabIndex = 52
        Me.lblDeveloper.Text = "Jiayi Wu@2022"
        '
        'frmOrder_discount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 459)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnApply)
        Me.Controls.Add(Me.pnlDiscountInfo)
        Me.Controls.Add(Me.pnlRibbon)
        Me.Controls.Add(Me.pnlButtonGroup)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.Name = "frmOrder_discount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Discount"
        Me.pnlDiscountInfo.ResumeLayout(False)
        Me.pnlDiscountInfo.PerformLayout()
        Me.pnlRibbon.ResumeLayout(False)
        Me.pnlRibbon.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlButtonGroup As FlowLayoutPanel
    Friend WithEvents pnlRibbon As Panel
    Friend WithEvents lblDeveloper As Label
    Friend WithEvents pnlDiscountInfo As Panel
    Friend WithEvents lblDescription As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnApply As Button
    Friend WithEvents btnClear As Button
End Class
