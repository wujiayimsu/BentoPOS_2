'Programmmed by Jiayi Wu
Public Class frmOrdering
    Private DB As New DBAccess
    Dim rs As New Resizer
    Dim intOrderID As Integer
    Dim dtOrderItem As New DataTable



    Private Sub frmOdering_Load(sender As Object, e As EventArgs) Handles Me.Load
        CreatebtnFoodCategory()
        UpdatelblOrderID()
        ButtomFiguresDisplay()
        rs.FindAllControls(Me)

        lblSplit.Text = String.Empty
        lblSplitAmt.Text = String.Empty
    End Sub

    '*********************************************Add buttons for pnlMenuCategory*********************************************************'
    Sub CreatebtnFoodCategory()
        Dim dtMenuCategory As New DataTable
        DB.ExecuteQuery("SELECT * FROM menu_category")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        dtMenuCategory = DB.DBDataTable

        Try
            For Each row In dtMenuCategory.Rows
                Dim btnCategoryGroup As New Button

                AddHandler btnCategoryGroup.Click, Sub() CategorySelection(btnCategoryGroup)

                btnCategoryGroup.Text = row("name")
                btnCategoryGroup.Size = New Size(120, 36)
                btnCategoryGroup.Font = New System.Drawing.Font("Calibri", 11)

                pnlMenuCategory.Controls.Add(btnCategoryGroup)
            Next
        Catch ex As Exception
            MessageBox.Show("error")
        End Try

    End Sub


    '*********************************************Add buttons for pnlMenuItem*********************************************************'
    Sub CategorySelection(sender As Object)
        Dim strCategorySelected = sender.text
        Dim dtMenuitem As New DataTable


        pnlMenuItem.Controls.Clear()

        DB.AddParam("@name", strCategorySelected)
        DB.ExecuteQuery("select * from menu_category as C join menu as m on c.category_id = m.category_id where name = ?")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        dtMenuitem = DB.DBDataTable

        Try
            For Each row In dtMenuitem.Rows
                Dim btnMenuItemGroup As New Button

                AddHandler btnMenuItemGroup.Click, Sub() MenuItemSelection(btnMenuItemGroup)

                btnMenuItemGroup.Text = row("item_name")
                btnMenuItemGroup.Size = New Size(120, 35)
                btnMenuItemGroup.Font = New System.Drawing.Font("Calibri", 10)

                pnlMenuItem.Controls.Add(btnMenuItemGroup)

            Next

        Catch ex As Exception
            MessageBox.Show("error")
        End Try
    End Sub


    '*********************************************Add Ordering items TO the list box*********************************************************'
    Public Sub MenuItemSelection(Sender As Object)

        '''''''Display ordering item name, quantity and price; Quantity default to one
        Dim strMenuItem As String = Sender.text
        Dim dtMenuItemPrice As DataTable

        lstOrderItem.Items.Add(strMenuItem)
        lstQuantity.Items.Add("1")

        DB.AddParam("@item_name", strMenuItem)
        DB.ExecuteQuery("SELECT * FROM menu where item_name = ?")
        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        dtMenuItemPrice = DB.DBDataTable
        lstPrice.Items.Add(dtMenuItemPrice.Rows(0).Item("price").ToString)
        lstItemID.Items.Add(dtMenuItemPrice.Rows(0).Item("item_id".ToString))

        ButtomFiguresDisplay()
    End Sub

    '******************************Button Figure Display*******************************************'
    Public Sub ButtomFiguresDisplay()
        ItemCount()
        SubtotalDisplay()
        tax()
        DiscountedAmt()
        Total()
    End Sub

    Sub ItemCount()
        Dim Sum As Integer
        Dim i As Integer

        For i = 0 To lstQuantity.Items.Count - 1
            If lstOrderItem.Items(i) = strline Then
                Sum = Sum
            Else
                Sum = Sum + Val(lstQuantity.Items(i))
            End If
        Next
        lblItemCount.Text = Sum.ToString

    End Sub
    Sub SubtotalDisplay()
        Dim LineTotal As Double = 0.00
        Dim i As Integer
        Dim dblSubTotal As Double = 0.00

        For i = 0 To lstOrderItem.Items.Count - 1
            If lstOrderItem.Items(i) = strline Then
                dblSubTotal = dblSubTotal
            Else
                LineTotal = lstQuantity.Items(i) * lstPrice.Items(i)
                dblSubTotal += LineTotal
            End If
        Next
        lblSubTotal.Text = dblSubTotal

    End Sub
    Sub tax()
        Dim dblTaxRate As Decimal = 0.06
        Dim decTax As Decimal


        lblTax.Text = (CDbl(lblSubTotal.Text) * dblTaxRate).ToString("N2")
        decTax = CDec(lblTax.Text)
    End Sub
    Sub Total()
        Dim decTotal As Decimal

        decTotal = CDec(lblSubTotal.Text) + CDec(lblTax.Text) + CDec(lblDiscAmt.Text)
        lblTotal.Text = decTotal.ToString("N2")

    End Sub
    Sub DiscountedAmt()
        Dim decDiscountAmt As Decimal = 0.00

        decDiscountAmt = CDec(lblSubTotal.Text) * decDiscountRate
        lblDiscAmt.Text = ("-" & decDiscountAmt.ToString("N2"))
        If decDiscountAmt = 0 Then
            lblDiscountRateInfo.Visible = False
            Label7.ForeColor = Color.Black
            lblDiscAmt.ForeColor = Color.Black
        Else
            lblDiscountRateInfo.Visible = True
            lblDiscAmt.ForeColor = Color.Firebrick
            Label7.ForeColor = Color.Firebrick
            lblDiscountRateInfo.Text = ("*Discount Applied at " & FormatPercent(decDiscountRate))
        End If

    End Sub

    Public Sub UpdatelblOrderID()
        DB.ExecuteQuery("SELECT order_id FROM customer_order ORDER BY order_id DESC")
        intOrderID = DB.RecordCount + 1
        lblOrderID.Text = ("Order ID " & intOrderID.ToString)
        frmOrdering_Type.lblOrderID.Text = ("Order ID    " & intOrderID.ToString)


    End Sub


    '*********************************************Button Functions*********************************************************'
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstOrderItem.Items.Clear()
        lstPrice.Items.Clear()
        lstQuantity.Items.Clear()
        lstItemID.Items.Clear()
        decDiscountRate = 0.00
        ButtomFiguresDisplay()
    End Sub

    Private Sub btnLine_Click(sender As Object, e As EventArgs) Handles btnLine.Click
        lstOrderItem.Items.Add(strline)
        lstQuantity.Items.Add(strline)
        lstPrice.Items.Add(strline)
        lstItemID.Items.Add(strline)
    End Sub

    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        If lstOrderItem.SelectedIndex < 0 Then
            MessageBox.Show("Please select the item to remove")
        Else
            Dim strSelectedIndex As String = lstOrderItem.SelectedIndex.ToString()
            lstOrderItem.Items.RemoveAt(strSelectedIndex)
            lstQuantity.Items.RemoveAt(strSelectedIndex)
            lstPrice.Items.RemoveAt(strSelectedIndex)
            lstItemID.Items.RemoveAt(strSelectedIndex)
        End If

        ButtomFiguresDisplay()

    End Sub

    Private Sub btnDuplicate_Click(sender As Object, e As EventArgs) Handles btnDuplicate.Click
        If lstOrderItem.SelectedIndex < 0 Then
            MessageBox.Show("Please select the item to duplicate")
        Else
            If lstOrderItem.SelectedItem = strline Then
                MessageBox.Show("Line can not be duplicated")
            Else
                Dim intSelectedIndex As Integer = lstOrderItem.SelectedIndex
                Dim intQuantity As Integer = CInt(lstQuantity.Items(intSelectedIndex))
                intQuantity += 1
                lstQuantity.Items(intSelectedIndex) = intQuantity
            End If
        End If
        ButtomFiguresDisplay()

    End Sub

    Private Sub btnDiscount_Click_1(sender As Object, e As EventArgs) Handles btnDiscount.Click

        If CDec(lblDiscAmt.Text) = 0 Then
            Dim frmDiscount As New frmOrder_discount
            frmDiscount.ShowDialog()
            ButtomFiguresDisplay()
        Else
            decDiscountRate = 0.00
            ButtomFiguresDisplay()
        End If
    End Sub

    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click

        If CDec(lblTotal.Text) = 0 Then
            MessageBox.Show("No Item was selected")

        Else
            If strPayMethod = String.Empty Then
                Dim frmPay As New Order_Payment
                frmPay.ShowDialog()
                ButtomFiguresDisplay()
                lblPaymentMeth.Text = strPayMethod
            Else
                InsertCustomerOrder()
                InsertOrderItem()
                lblPaymentMeth.Text = strPayMethod
                InsertPayment()
                MessageBox.Show("Order Complete!")
                btnClear.PerformClick()
                btnExit.PerformClick()
            End If
        End If

    End Sub


    '************************************************** INSERT INTO SQL  ***********************************************************'
    Public Sub InsertCustomerOrder()
        Dim strComplete As String = "complete"

        If String.IsNullOrEmpty(frmOrdering_Type.txtCustomerID.Text) Then
            DB.AddParam("@customer_id", DBNull.Value)
        Else
            DB.AddParam("@customer_id", frmOrdering_Type.txtCustomerID.Text)
        End If

        DB.AddParam("@staff_id", "3")
        DB.AddParam("@order_status", strComplete)
        DB.AddParam("@order_type", lblOrderType.Text)

        DB.ExecuteQuery("INSERT INTO customer_order(customer_id, staff_id, order_status, order_type) VALUES(?, ?, ?, ?)")
        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        MessageBox.Show("customer order table inserted")
    End Sub
    Public Sub InsertOrderItem()

        For item = 0 To lstItemID.Items.Count - 1

            DB.AddParam("@order_id", intOrderID)
            DB.AddParam("@item_id", lstItemID.Items(item))
            DB.AddParam("quantity", lstQuantity.Items(item))

            DB.ExecuteQuery("INSERT INTO order_item(order_id, item_id, quantity) VALUES(?, ?, ?)")
            If DB.DBException <> String.Empty Then
                MessageBox.Show(DB.DBException)
                Exit Sub
            End If
        Next
        MessageBox.Show("order item table inserted")

    End Sub

    Public Sub InsertPayment()
        DB.AddParam("order_id", intOrderID)   '1 param
        DB.AddParam("total_price", CDec(lblTotal.Text))    '2 param
        DB.AddParam("tax", CDec(lblTax.Text))    '3 param

        If CDec(lblDiscAmt.Text) <= 0 Then
            DB.AddParam("@discount_id", DBNull.Value)   '4 param
            DB.AddParam("@discounted_total", "0.00")    '5 param
        Else
            DB.AddParam("@discount_id", frmOrder_discount.intDiscountID)
            DB.AddParam("@discounted_total", CDec(lblDiscAmt.Text))
        End If

        DB.AddParam("@amount_paid", CDec(lblTotal.Text))     '6 param
        DB.AddParam("payment_method", lblPaymentMeth.Text)      '7 param

        DB.ExecuteQuery("INSERT INTO payment(order_id, total_price, tax, discount_id, discounted_total, amount_paid, payment_method) VALUES (?,?,?,?,?,?,?)")
        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        MessageBox.Show("payment table inserted")
    End Sub




    '*********************************************  OTHER FUNCTIONS   *********************************************************'

    Sub SelectedAll()
        If lstOrderItem.SelectedIndex > -1 Then
            Dim intSelect As Integer = lstOrderItem.SelectedIndex
            lstPrice.SelectedIndex = intSelect
            lstQuantity.SelectedIndex = intSelect
            lstItemID.SelectedIndex = intSelect
        End If


    End Sub

    Private Sub lstOrderItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstOrderItem.SelectedIndexChanged
        SelectedAll()
    End Sub

    Private Sub lstPrice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPrice.SelectedIndexChanged
        SelectedAll()
    End Sub

    Private Sub lstQuantity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstQuantity.SelectedIndexChanged
        SelectedAll()
    End Sub
    Private Sub lstItemID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstItemID.SelectedIndexChanged
        SelectedAll()
    End Sub

    Private Sub frmOdering_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub

End Class