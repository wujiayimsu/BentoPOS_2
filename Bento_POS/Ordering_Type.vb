Imports System.Text.RegularExpressions
Public Class frmOrdering_Type
    Private DB As New DBAccess
    Dim rs As New Resizer

    '*********************************************Left Panel*********************************************************'
    Sub TableNumber(Sender As Object)
        Dim strTableNumber As String = Sender.text
        Dim frmOrderPage As New frmOrdering

        frmOrderPage.lblOrderType.Text = Sender.text
        frmOrderPage.lblCustomerID.Text = String.Empty
        frmOrdering.lblFirstName.Text = String.Empty
        frmOrderPage.ShowDialog()



    End Sub

    Private Sub btnDineIn_Click(sender As Object, e As EventArgs) Handles btnDineIn.Click
        pnl_btnDineIn.Height = btnDineIn.Height
        pnl_btnDineIn.Top = btnDineIn.Top
        pnlDineIn.Visible = True
        pnlTakeOut.Visible = False
        pnlHistory.Visible = False


        AddHandler btnTable1.Click, Sub() TableNumber(btnTable1)
        AddHandler btnTable2.Click, Sub() TableNumber(btnTable2)
        AddHandler btnTable3.Click, Sub() TableNumber(btnTable3)
        AddHandler btnTable4.Click, Sub() TableNumber(btnTable4)
        AddHandler btnTable5.Click, Sub() TableNumber(btnTable5)
        AddHandler btnTable6.Click, Sub() TableNumber(btnTable6)
        AddHandler btnTable7.Click, Sub() TableNumber(btnTable7)
        AddHandler btnTable8.Click, Sub() TableNumber(btnTable8)
    End Sub

    Private Sub btnTakeOut_Click(sender As Object, e As EventArgs) Handles btnTakeOut.Click
        pnl__btnTakeOut.Height = btnTakeOut.Height
        pnl__btnTakeOut.Top = btnTakeOut.Top
        pnlDineIn.Visible = False
        pnlTakeOut.Visible = True
        pnlHistory.Visible = False

        frmOrdering.UpdatelblOrderID()

        SearchOpenTOGO("0pen", "to go")
    End Sub

    '*********************************************Take Out Panel *********************************************************'
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim frmOrdering As New frmOrdering

        If ValidationCustomerInfo() = True Then
            If ExistingCustomer() = True Then
                frmOrdering.lblFirstName.Text = txtFirstName.Text
                frmOrdering.lblOrderType.Text = "TO GO"
                frmOrdering.lblCustomerID.Text = ("Customer ID " & txtCustomerID.Text)
                frmOrdering.ShowDialog()
            Else
                'do nothing
            End If
        End If


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstName.Clear()
        txtLastName.Clear()
        txtPhone.Clear()
        txtCustomerID.Clear()
    End Sub

    Private Sub frmOrdering_Type_Load(sender As Object, e As EventArgs) Handles Me.Load
        pnlDineIn.Visible = False
        pnlTakeOut.Visible = False
        pnlHistory.Visible = False
        rs.FindAllControls(Me)


    End Sub

    Private Sub frmOrdering_Type_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub

    Private Function ValidationCustomerInfo() As Boolean
        '---------------------------------validate for txtCustomerID--------------------------------------------------'
        Dim intInteger As Integer

        If String.IsNullOrEmpty(txtCustomerID.Text) = True Then
            'do nothing
        Else
            If Integer.TryParse(txtCustomerID.Text, intInteger) = False Then
                MessageBox.Show("Customer ID Must be Integer")
                txtCustomerID.SelectAll()
                txtCustomerID.Focus()
                Return False
            Else
                'do nothing
            End If
        End If

        Return True
    End Function

    Private Function ExistingCustomer() As Boolean

        Dim dtCustomer As New DataTable
        DB.AddParam("@customer_id", txtCustomerID.Text)
        DB.ExecuteQuery("SELECT * FROM customer WHERE customer_id = ?")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Function
        End If

        dtCustomer = DB.DBDataTable

        If DB.RecordCount < 1 Then
            'go throught and do nothing
            txtCustomerID.Clear()
        Else
            For Each rows In dtCustomer.Rows
                txtFirstName.Text = rows("first_name")
                txtLastName.Text = rows("last_name")
                txtPhone.Text = rows("phone")
            Next
        End If

        Return True
    End Function
    '--------------------------------------------------- History Panel----------------------------------------------------------------'
    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        pnl_btnHistory.Height = btnHistory.Height
        pnl_btnHistory.Top = btnHistory.Top
        pnlDineIn.Visible = False
        pnlTakeOut.Visible = False
        pnlHistory.Visible = True

        btnHistryLoad()


    End Sub
    '**************************************************** History ***********************************************************'

    Private Sub SearchOrder(strCustomerID As String, strFirstname As String, strOrderID As String)

        DB.AddParam("@customer_id", strCustomerID & "%")
        DB.AddParam("@first_name", strFirstname & "%")
        DB.AddParam("@order_id", strOrderID & "%")


        DB.ExecuteQuery("SELECT distinct o.order_id as 'Order ID', c.customer_id as 'Customer ID', 
Cus.first_name as 'First Name', 
m.item_name as 'Item', m.price as 'Price', 
o.quantity as 'Order Quantity', p.total_price as 'Total', p.tax as 'Tax',
p.payment_method as 'Payment Method', p.amount_paid as 'Amount Paid',
c.order_date as 'Order Date' 
FROM order_item as o
left JOIN customer_order as c ON c.order_id = o.order_id 
left JOIN menu as m ON o.item_id = m.item_id 
left JOIN payment as p ON p.order_id = c.order_id 
left JOIN customer as Cus ON c.customer_id = Cus.customer_id 
WHERE c.customer_id LIKE ? and Cus.first_name LIKE? and o.order_id LIKE ?")


        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        dgvHistory.DataSource = DB.DBDataTable
    End Sub
    Private Sub btnHistryLoad()

        DB.ExecuteQuery("select co.order_id, co.customer_id, co.order_status, co.order_type, o.quantity, m.item_name,m.price, p.total_price,p.tax,p.discount_id,p.discounted_total,p.amount_paid,p.payment_method
from customer_order as co
left join order_item as o on co.order_id = o.order_id
left join menu as m on o.item_id = m.item_id
left join payment as p on co.order_id = p.order_id")


        '  DB.ExecuteQuery("SELECT co.order_date AS 'Date', co.order_id as 'Order ID', co.order_type as 'Order Type', co.customer_id as'Customer ID', c.first_name as 'Customer Name', co.order_status as 'Order Status' from customer_order as co LEFT join customer as c on co.customer_id = c.customer_id order by co.order_date desc;")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        dgvHistory.DataSource = DB.DBDataTable
    End Sub


    Private Sub txtCusID_History_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCusID_History.KeyUp
        SearchOrder(txtCusID_History.Text, txtFirstName_History.Text, txtOrderNumber.Text)
    End Sub

    Private Sub btnClear_History_Click(sender As Object, e As EventArgs) Handles btnClear_History.Click
        txtCusID_History.Clear()
        txtFirstName_History.Clear()
        txtOrderNumber.Clear()
        btnHistryLoad()

    End Sub

    Private Sub txtFirstName_History_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFirstName_History.KeyUp
        SearchOrder(txtCusID_History.Text, txtFirstName_History.Text, txtOrderNumber.Text)
    End Sub

    Private Sub txtOrderNumber_KeyUp(sender As Object, e As KeyEventArgs) Handles txtOrderNumber.KeyUp

        txtFirstName_History.Clear()
        txtCusID_History.Clear()
        SearchOrderIdOnly(txtOrderNumber.Text)

    End Sub

    Private Sub SearchOrderIdOnly(strOrderID As String)

        DB.AddParam("@order_id", strOrderID)

        DB.ExecuteQuery("SELECT distinct o.order_id as 'Order ID', c.customer_id as 'Customer ID', 
Cus.first_name as 'First Name', 
m.item_name as 'Item', m.price as 'Price', 
o.quantity as 'Order Quantity', p.total_price as 'Total', p.tax as 'Tax',
p.payment_id as 'Payment ID',p.payment_method as 'Payment Method', p.amount_paid as 'Amount Paid',
c.order_date as 'Order Date' 
FROM order_item as o
JOIN customer_order as c ON c.order_id = o.order_id 
left JOIN menu as m ON o.item_id = m.item_id 
left JOIN payment as p ON p.order_id = c.order_id 
left JOIN customer as Cus ON c.customer_id = Cus.customer_id 
WHERE o.order_id = ?")
        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        dgvHistory.DataSource = DB.DBDataTable
    End Sub

End Class