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

    '#######################validation part needed to be add in here#####################################'
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim frmOrdering As New frmOrdering

        If ValidationCustomerInfo() = True Then
            If ExistingCustomer() = True Then
                frmOrdering.lblFirstName.Text = txtFirstName.Text
                frmOrdering.lblOrderType.Text = "TO GO"
                frmOrdering.lblCustomerID.Text = ("Customer ID " & txtCustomerID.Text)
                frmOrdering.ShowDialog()
            End If
        End If


    End Sub
    '#######################validation part needed to be add in here#####################################'
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
            'do nothing

        Else
            For Each rows In dtCustomer.Rows
                txtFirstName.Text = rows("first_name")
                txtLastName.Text = rows("last_name")
                txtPhone.Text = rows("phone")
            Next
        End If

        Return True
    End Function

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        pnl_btnHistory.Height = btnHistory.Height
        pnl_btnHistory.Top = btnHistory.Top
        pnlDineIn.Visible = False
        pnlTakeOut.Visible = False
        pnlHistory.Visible = True


        DB.ExecuteQuery("select c.order_id as 'Order ID', c.customer_id as 'Customer ID', m.item_name as 'Item', m.price as 'Price', o.quantity as 'Order Quantity',p.payment_id as 'Payment ID',p.payment_method as 'Payment Method', p.amount_paid as 'Amount Paid',c.order_date as 'Order Date',c.order_time as 'Order Time'
from customer_order as c
left join order_item as o on c.order_id = o.order_id
left join menu as m on o.item_id = m.item_id
left join payment as p on p.order_id = c.order_id
order by c.order_id asc")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        dgvHistory.DataSource = DB.DBDataTable


    End Sub
End Class