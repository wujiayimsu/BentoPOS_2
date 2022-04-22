<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Order_Payment
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
        Me.pnlRibbon = New System.Windows.Forms.Panel()
        Me.lblDeveloper = New System.Windows.Forms.Label()
        Me.btnCard = New System.Windows.Forms.Button()
        Me.btnCash = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblPayMethod = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pnlRibbon.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.pnlRibbon.Size = New System.Drawing.Size(361, 100)
        Me.pnlRibbon.TabIndex = 2
        '
        'lblDeveloper
        '
        Me.lblDeveloper.AutoSize = True
        Me.lblDeveloper.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDeveloper.ForeColor = System.Drawing.Color.White
        Me.lblDeveloper.Location = New System.Drawing.Point(282, 0)
        Me.lblDeveloper.Name = "lblDeveloper"
        Me.lblDeveloper.Size = New System.Drawing.Size(79, 13)
        Me.lblDeveloper.TabIndex = 52
        Me.lblDeveloper.Text = "Jiayi Wu@2022"
        '
        'btnCard
        '
        Me.btnCard.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnCard.FlatAppearance.BorderSize = 0
        Me.btnCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCard.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCard.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCard.Location = New System.Drawing.Point(0, 119)
        Me.btnCard.Name = "btnCard"
        Me.btnCard.Size = New System.Drawing.Size(105, 40)
        Me.btnCard.TabIndex = 70
        Me.btnCard.Text = "CARD"
        Me.btnCard.UseVisualStyleBackColor = False
        '
        'btnCash
        '
        Me.btnCash.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(119, Byte), Integer), CType(CType(142, Byte), Integer))
        Me.btnCash.FlatAppearance.BorderSize = 0
        Me.btnCash.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray
        Me.btnCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCash.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCash.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnCash.Location = New System.Drawing.Point(0, 51)
        Me.btnCash.Name = "btnCash"
        Me.btnCash.Size = New System.Drawing.Size(105, 40)
        Me.btnCash.TabIndex = 71
        Me.btnCash.Text = "CASH"
        Me.btnCash.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnExit.BackgroundImage = Global.ReadSearch.My.Resources.Resources.YumBrown
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnExit.Location = New System.Drawing.Point(273, 106)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(76, 33)
        Me.btnExit.TabIndex = 81
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblPayMethod
        '
        Me.lblPayMethod.AutoSize = True
        Me.lblPayMethod.Font = New System.Drawing.Font("Calibri", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPayMethod.Location = New System.Drawing.Point(184, 198)
        Me.lblPayMethod.Name = "lblPayMethod"
        Me.lblPayMethod.Size = New System.Drawing.Size(139, 39)
        Me.lblPayMethod.TabIndex = 89
        Me.lblPayMethod.Text = "METHOD"
        Me.lblPayMethod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnEnter.BackgroundImage = Global.ReadSearch.My.Resources.Resources.YumGreen
        Me.btnEnter.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnEnter.Location = New System.Drawing.Point(182, 108)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(85, 31)
        Me.btnEnter.TabIndex = 90
        Me.btnEnter.Text = "ENTER"
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(195, Byte), Integer), CType(CType(108, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCash)
        Me.Panel1.Controls.Add(Me.btnCard)
        Me.Panel1.Location = New System.Drawing.Point(0, 100)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(105, 207)
        Me.Panel1.TabIndex = 88
        '
        'Order_Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 308)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblPayMethod)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlRibbon)
        Me.Name = "Order_Payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order_Payment"
        Me.pnlRibbon.ResumeLayout(False)
        Me.pnlRibbon.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlRibbon As Panel
    Friend WithEvents lblDeveloper As Label
    Friend WithEvents btnCard As Button
    Friend WithEvents btnCash As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblPayMethod As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents Panel1 As Panel
End Class
