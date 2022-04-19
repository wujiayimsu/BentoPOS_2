'Programmmed by Jiayi Wu
Public Class frmOrdering
    Private DB As New DBAccess
    Dim strline As String = ("-----------------------------------------------------------------")

    Private Sub FilmForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        CreatebtnFoodCategory()
        ButtomFiguresDisplay()

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
    Sub MenuItemSelection(Sender As Object)

        '''''''Display ordering item name, quantity and price; Quantity default to one
        Dim strMenuItem As String = Sender.text
        Dim dtMenuItemPrice As DataTable

        lstOrderItem.Items.Add(strMenuItem)
        lstQuantity.Items.Add("1")

        DB.AddParam("@item_name", strMenuItem)
        DB.ExecuteQuery("SELECT price FROM menu where item_name = ?")
        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        dtMenuItemPrice = DB.DBDataTable
        lstPrice.Items.Add(dtMenuItemPrice.Rows(0).Item("price").ToString)

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
        Dim dblSubTotal As Double = 0.00
        Dim i As Integer

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
        lblTax.Text = (CDbl(lblSubTotal.Text) * dblTaxRate).ToString("N2")

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
        lblDiscountRateInfo.Text = decDiscountRate.ToString("N2")
    End Sub


    '*********************************************Button Functions*********************************************************'
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstOrderItem.Items.Clear()
        lstPrice.Items.Clear()
        lstQuantity.Items.Clear()
        ButtomFiguresDisplay()
    End Sub


    Private Sub btnLine_Click(sender As Object, e As EventArgs) Handles btnLine.Click
        lstOrderItem.Items.Add(strline)
        lstQuantity.Items.Add(strline)
        lstPrice.Items.Add(strline)
    End Sub

    Private Sub btnRemoveItem_Click(sender As Object, e As EventArgs) Handles btnRemoveItem.Click
        If lstOrderItem.SelectedIndex < 0 Then
            MessageBox.Show("Please select the item to remove")
        Else
            Dim strSelectedIndex As String = lstOrderItem.SelectedIndex.ToString()
            lstOrderItem.Items.RemoveAt(strSelectedIndex)
            lstQuantity.Items.RemoveAt(strSelectedIndex)
            lstPrice.Items.RemoveAt(strSelectedIndex)
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

    Sub SelectedAll()
        Dim intSelect As Integer = lstOrderItem.SelectedIndex
        lstPrice.SelectedIndex = intSelect
        lstQuantity.SelectedIndex = intSelect

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

    Private Sub btnDiscount_Click_1(sender As Object, e As EventArgs) Handles btnDiscount.Click
        Dim frmDiscount As New frmOrder_discount

        frmDiscount.ShowDialog()

    End Sub
End Class