﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOrdering
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
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.DateTimeUserStrip = New System.Windows.Forms.ToolStripStatusLabel()
        Me.pnlMenuItem = New System.Windows.Forms.FlowLayoutPanel()
        Me.pnlMenuCategory = New System.Windows.Forms.FlowLayoutPanel()
        Me.lstOrderItem = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblDiscAmt = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.lblItemCount = New System.Windows.Forms.Label()
        Me.pnlOrderItem = New System.Windows.Forms.Panel()
        Me.lstPrice = New System.Windows.Forms.ListBox()
        Me.lstQuantity = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnDuplicate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReceipt = New System.Windows.Forms.Button()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.btnSplitEqual = New System.Windows.Forms.Button()
        Me.btnHold = New System.Windows.Forms.Button()
        Me.btnLine = New System.Windows.Forms.Button()
        Me.btnNote = New System.Windows.Forms.Button()
        Me.btnDiscount = New System.Windows.Forms.Button()
        Me.btnSplitItem = New System.Windows.Forms.Button()
        Me.btnVoid = New System.Windows.Forms.Button()
        Me.btnRemoveItem = New System.Windows.Forms.Button()
        Me.btnSplitBill = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTableNo = New System.Windows.Forms.Label()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.pnlOrderItem.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateTimeUserStrip})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 692)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1139, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'DateTimeUserStrip
        '
        Me.DateTimeUserStrip.Name = "DateTimeUserStrip"
        Me.DateTimeUserStrip.Size = New System.Drawing.Size(119, 17)
        Me.DateTimeUserStrip.Text = "ToolStripStatusLabel1"
        '
        'pnlMenuItem
        '
        Me.pnlMenuItem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.pnlMenuItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMenuItem.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlMenuItem.Location = New System.Drawing.Point(608, 371)
        Me.pnlMenuItem.Name = "pnlMenuItem"
        Me.pnlMenuItem.Size = New System.Drawing.Size(512, 300)
        Me.pnlMenuItem.TabIndex = 9
        '
        'pnlMenuCategory
        '
        Me.pnlMenuCategory.BackColor = System.Drawing.Color.Transparent
        Me.pnlMenuCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlMenuCategory.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlMenuCategory.Location = New System.Drawing.Point(608, 165)
        Me.pnlMenuCategory.Name = "pnlMenuCategory"
        Me.pnlMenuCategory.Size = New System.Drawing.Size(512, 187)
        Me.pnlMenuCategory.TabIndex = 10
        '
        'lstOrderItem
        '
        Me.lstOrderItem.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstOrderItem.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstOrderItem.FormattingEnabled = True
        Me.lstOrderItem.ItemHeight = 19
        Me.lstOrderItem.Location = New System.Drawing.Point(0, 0)
        Me.lstOrderItem.Name = "lstOrderItem"
        Me.lstOrderItem.Size = New System.Drawing.Size(325, 437)
        Me.lstOrderItem.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 587)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 19)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Item:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(293, 587)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 19)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Sub Total: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(335, 607)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 19)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Tax: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(220, 627)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 19)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Discounted Amount: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(315, 649)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 26)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Total:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(370, 649)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(51, 26)
        Me.lblTotal.TabIndex = 43
        Me.lblTotal.Text = "0.00"
        '
        'lblDiscAmt
        '
        Me.lblDiscAmt.AutoSize = True
        Me.lblDiscAmt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDiscAmt.Location = New System.Drawing.Point(370, 629)
        Me.lblDiscAmt.Name = "lblDiscAmt"
        Me.lblDiscAmt.Size = New System.Drawing.Size(37, 19)
        Me.lblDiscAmt.TabIndex = 44
        Me.lblDiscAmt.Text = "0.00"
        '
        'lblTax
        '
        Me.lblTax.AutoSize = True
        Me.lblTax.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTax.Location = New System.Drawing.Point(370, 609)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(37, 19)
        Me.lblTax.TabIndex = 45
        Me.lblTax.Text = "0.00"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.AutoSize = True
        Me.lblSubTotal.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubTotal.Location = New System.Drawing.Point(370, 589)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(37, 19)
        Me.lblSubTotal.TabIndex = 46
        Me.lblSubTotal.Text = "0.00"
        '
        'lblItemCount
        '
        Me.lblItemCount.AutoSize = True
        Me.lblItemCount.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblItemCount.Location = New System.Drawing.Point(63, 588)
        Me.lblItemCount.Name = "lblItemCount"
        Me.lblItemCount.Size = New System.Drawing.Size(17, 19)
        Me.lblItemCount.TabIndex = 47
        Me.lblItemCount.Text = "0"
        '
        'pnlOrderItem
        '
        Me.pnlOrderItem.Controls.Add(Me.lstPrice)
        Me.pnlOrderItem.Controls.Add(Me.lstQuantity)
        Me.pnlOrderItem.Controls.Add(Me.lstOrderItem)
        Me.pnlOrderItem.Location = New System.Drawing.Point(16, 155)
        Me.pnlOrderItem.Name = "pnlOrderItem"
        Me.pnlOrderItem.Size = New System.Drawing.Size(440, 430)
        Me.pnlOrderItem.TabIndex = 53
        '
        'lstPrice
        '
        Me.lstPrice.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstPrice.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPrice.FormattingEnabled = True
        Me.lstPrice.ItemHeight = 19
        Me.lstPrice.Location = New System.Drawing.Point(373, 0)
        Me.lstPrice.Name = "lstPrice"
        Me.lstPrice.Size = New System.Drawing.Size(66, 437)
        Me.lstPrice.TabIndex = 33
        '
        'lstQuantity
        '
        Me.lstQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstQuantity.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstQuantity.FormatString = "N0"
        Me.lstQuantity.FormattingEnabled = True
        Me.lstQuantity.ItemHeight = 19
        Me.lstQuantity.Location = New System.Drawing.Point(321, 0)
        Me.lstQuantity.Name = "lstQuantity"
        Me.lstQuantity.Size = New System.Drawing.Size(52, 437)
        Me.lstQuantity.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 19)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Item Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(340, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 19)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Qty"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(399, 133)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 19)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Price"
        '
        'btnDuplicate
        '
        Me.btnDuplicate.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnDuplicate.BackgroundImage = Global.ReadSearch.My.Resources.Resources.YumYellow
        Me.btnDuplicate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDuplicate.ForeColor = System.Drawing.Color.Black
        Me.btnDuplicate.Location = New System.Drawing.Point(477, 391)
        Me.btnDuplicate.Name = "btnDuplicate"
        Me.btnDuplicate.Size = New System.Drawing.Size(110, 40)
        Me.btnDuplicate.TabIndex = 41
        Me.btnDuplicate.Text = "Duplicate"
        Me.btnDuplicate.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Firebrick
        Me.btnExit.BackgroundImage = Global.ReadSearch.My.Resources.Resources.YumBrown
        Me.btnExit.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnExit.Location = New System.Drawing.Point(1020, 99)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 45)
        Me.btnExit.TabIndex = 15
        Me.btnExit.Text = "EXIT"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnReceipt
        '
        Me.btnReceipt.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnReceipt.BackgroundImage = Global.ReadSearch.My.Resources.Resources.YumGreen
        Me.btnReceipt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceipt.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnReceipt.Location = New System.Drawing.Point(914, 104)
        Me.btnReceipt.Name = "btnReceipt"
        Me.btnReceipt.Size = New System.Drawing.Size(100, 40)
        Me.btnReceipt.TabIndex = 14
        Me.btnReceipt.Text = "RECEIPT"
        Me.btnReceipt.UseVisualStyleBackColor = False
        '
        'btnPay
        '
        Me.btnPay.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnPay.BackgroundImage = Global.ReadSearch.My.Resources.Resources.YumGreen
        Me.btnPay.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPay.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnPay.Location = New System.Drawing.Point(808, 104)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(100, 40)
        Me.btnPay.TabIndex = 13
        Me.btnPay.Text = "PAY"
        Me.btnPay.UseVisualStyleBackColor = False
        '
        'btnSplitEqual
        '
        Me.btnSplitEqual.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSplitEqual.BackgroundImage = Global.ReadSearch.My.Resources.Resources.YumPink
        Me.btnSplitEqual.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSplitEqual.ForeColor = System.Drawing.Color.Black
        Me.btnSplitEqual.Location = New System.Drawing.Point(477, 292)
        Me.btnSplitEqual.Name = "btnSplitEqual"
        Me.btnSplitEqual.Size = New System.Drawing.Size(110, 40)
        Me.btnSplitEqual.TabIndex = 30
        Me.btnSplitEqual.Text = "Split Equally"
        Me.btnSplitEqual.UseVisualStyleBackColor = False
        '
        'btnHold
        '
        Me.btnHold.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnHold.BackgroundImage = Global.ReadSearch.My.Resources.Resources.YumYellow
        Me.btnHold.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHold.ForeColor = System.Drawing.Color.Black
        Me.btnHold.Location = New System.Drawing.Point(477, 575)
        Me.btnHold.Name = "btnHold"
        Me.btnHold.Size = New System.Drawing.Size(110, 40)
        Me.btnHold.TabIndex = 29
        Me.btnHold.Text = "Hold"
        Me.btnHold.UseVisualStyleBackColor = False
        '
        'btnLine
        '
        Me.btnLine.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnLine.BackgroundImage = Global.ReadSearch.My.Resources.Resources.YumYellow
        Me.btnLine.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLine.ForeColor = System.Drawing.Color.Black
        Me.btnLine.Location = New System.Drawing.Point(477, 529)
        Me.btnLine.Name = "btnLine"
        Me.btnLine.Size = New System.Drawing.Size(110, 40)
        Me.btnLine.TabIndex = 28
        Me.btnLine.Text = "Line"
        Me.btnLine.UseVisualStyleBackColor = False
        '
        'btnNote
        '
        Me.btnNote.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnNote.BackgroundImage = Global.ReadSearch.My.Resources.Resources.YumYellow
        Me.btnNote.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNote.ForeColor = System.Drawing.Color.Black
        Me.btnNote.Location = New System.Drawing.Point(477, 483)
        Me.btnNote.Name = "btnNote"
        Me.btnNote.Size = New System.Drawing.Size(110, 40)
        Me.btnNote.TabIndex = 27
        Me.btnNote.Text = "Note"
        Me.btnNote.UseVisualStyleBackColor = False
        '
        'btnDiscount
        '
        Me.btnDiscount.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnDiscount.BackgroundImage = Global.ReadSearch.My.Resources.Resources.YumPink
        Me.btnDiscount.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiscount.ForeColor = System.Drawing.Color.Black
        Me.btnDiscount.Location = New System.Drawing.Point(477, 338)
        Me.btnDiscount.Name = "btnDiscount"
        Me.btnDiscount.Size = New System.Drawing.Size(110, 40)
        Me.btnDiscount.TabIndex = 26
        Me.btnDiscount.Text = "Discount"
        Me.btnDiscount.UseVisualStyleBackColor = False
        '
        'btnSplitItem
        '
        Me.btnSplitItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSplitItem.BackgroundImage = Global.ReadSearch.My.Resources.Resources.YumPink
        Me.btnSplitItem.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSplitItem.ForeColor = System.Drawing.Color.Black
        Me.btnSplitItem.Location = New System.Drawing.Point(477, 246)
        Me.btnSplitItem.Name = "btnSplitItem"
        Me.btnSplitItem.Size = New System.Drawing.Size(110, 40)
        Me.btnSplitItem.TabIndex = 25
        Me.btnSplitItem.Text = "Split Item"
        Me.btnSplitItem.UseVisualStyleBackColor = False
        '
        'btnVoid
        '
        Me.btnVoid.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnVoid.BackgroundImage = Global.ReadSearch.My.Resources.Resources.YumPink
        Me.btnVoid.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoid.ForeColor = System.Drawing.Color.Black
        Me.btnVoid.Location = New System.Drawing.Point(477, 152)
        Me.btnVoid.Name = "btnVoid"
        Me.btnVoid.Size = New System.Drawing.Size(110, 40)
        Me.btnVoid.TabIndex = 24
        Me.btnVoid.Text = "VOID  BILL"
        Me.btnVoid.UseVisualStyleBackColor = False
        '
        'btnRemoveItem
        '
        Me.btnRemoveItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnRemoveItem.BackgroundImage = Global.ReadSearch.My.Resources.Resources.YumYellow
        Me.btnRemoveItem.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemoveItem.ForeColor = System.Drawing.Color.Black
        Me.btnRemoveItem.Location = New System.Drawing.Point(477, 437)
        Me.btnRemoveItem.Name = "btnRemoveItem"
        Me.btnRemoveItem.Size = New System.Drawing.Size(110, 40)
        Me.btnRemoveItem.TabIndex = 22
        Me.btnRemoveItem.Text = "Remove Item"
        Me.btnRemoveItem.UseVisualStyleBackColor = False
        '
        'btnSplitBill
        '
        Me.btnSplitBill.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSplitBill.BackgroundImage = Global.ReadSearch.My.Resources.Resources.YumPink
        Me.btnSplitBill.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSplitBill.ForeColor = System.Drawing.Color.Black
        Me.btnSplitBill.Location = New System.Drawing.Point(477, 200)
        Me.btnSplitBill.Name = "btnSplitBill"
        Me.btnSplitBill.Size = New System.Drawing.Size(110, 40)
        Me.btnSplitBill.TabIndex = 17
        Me.btnSplitBill.Text = "Split Bill"
        Me.btnSplitBill.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnClear.BackgroundImage = Global.ReadSearch.My.Resources.Resources.YumYellow
        Me.btnClear.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Black
        Me.btnClear.Location = New System.Drawing.Point(477, 621)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(110, 40)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "CLEAR"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(131, Byte), Integer))
        Me.Panel2.BackgroundImage = Global.ReadSearch.My.Resources.Resources.Yum_ribbon
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lblTableNo)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1139, 93)
        Me.Panel2.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1061, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Jiayi Wu"
        '
        'lblTableNo
        '
        Me.lblTableNo.AutoSize = True
        Me.lblTableNo.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTableNo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTableNo.Location = New System.Drawing.Point(3, 60)
        Me.lblTableNo.Name = "lblTableNo"
        Me.lblTableNo.Size = New System.Drawing.Size(93, 23)
        Me.lblTableNo.TabIndex = 50
        Me.lblTableNo.Text = "TABLE NO."
        '
        'btnSend
        '
        Me.btnSend.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btnSend.BackgroundImage = Global.ReadSearch.My.Resources.Resources.YumGreen
        Me.btnSend.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSend.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.btnSend.Location = New System.Drawing.Point(702, 104)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(100, 40)
        Me.btnSend.TabIndex = 57
        Me.btnSend.Text = "SEND"
        Me.btnSend.UseVisualStyleBackColor = False
        '
        'frmOrdering
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1139, 714)
        Me.Controls.Add(Me.btnSend)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.pnlOrderItem)
        Me.Controls.Add(Me.lblItemCount)
        Me.Controls.Add(Me.lblSubTotal)
        Me.Controls.Add(Me.lblTax)
        Me.Controls.Add(Me.lblDiscAmt)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnDuplicate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReceipt)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnSplitEqual)
        Me.Controls.Add(Me.btnHold)
        Me.Controls.Add(Me.btnLine)
        Me.Controls.Add(Me.btnNote)
        Me.Controls.Add(Me.btnDiscount)
        Me.Controls.Add(Me.btnSplitItem)
        Me.Controls.Add(Me.btnVoid)
        Me.Controls.Add(Me.btnRemoveItem)
        Me.Controls.Add(Me.btnSplitBill)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlMenuCategory)
        Me.Controls.Add(Me.pnlMenuItem)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmOrdering"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "YumYum Bento"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.pnlOrderItem.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents DateTimeUserStrip As ToolStripStatusLabel
    Friend WithEvents pnlMenuItem As FlowLayoutPanel
    Friend WithEvents pnlMenuCategory As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnPay As Button
    Friend WithEvents btnReceipt As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSplitBill As Button
    Friend WithEvents btnRemoveItem As Button
    Friend WithEvents btnVoid As Button
    Friend WithEvents btnSplitItem As Button
    Friend WithEvents btnDiscount As Button
    Friend WithEvents btnNote As Button
    Friend WithEvents btnLine As Button
    Friend WithEvents btnHold As Button
    Friend WithEvents btnSplitEqual As Button
    Friend WithEvents lstOrderItem As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents btnDuplicate As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblDiscAmt As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSubTotal As Label
    Friend WithEvents lblItemCount As Label
    Friend WithEvents lblTableNo As Label
    Friend WithEvents pnlOrderItem As Panel
    Friend WithEvents lstPrice As ListBox
    Friend WithEvents lstQuantity As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSend As Button
End Class