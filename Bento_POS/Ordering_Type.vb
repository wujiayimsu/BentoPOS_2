Imports System.Text.RegularExpressions
Public Class frmOrdering_Type
    Private DB As New DBAccess
    Dim rs As New Resizer

    '*********************************************Left Panel*********************************************************'
    Sub TableNumber(Sender As Object)
        Dim strTableNumber As String = Sender.text
        Dim frmOrderPage As New frmOrdering
        Dim intCustomerID As Integer
        Dim intInteger As Integer

        intCustomerID = InputBox("Please Enter Customer ID in Below", "YumYum Bento - Dine in")
        If Not Integer.TryParse(txtCustomerID.Text, intInteger) = True Then
            frmOrderPage.lblOrderType.Text = Sender.text
            frmOrderPage.lblCustomerID.Text = ("Customer ID " & intCustomerID)
            frmOrderPage.ShowDialog()
        Else
            MsgBox("You provided an invalid value",
                   MsgBoxStyle.OkOnly Or MsgBoxStyle.Information,
                   "YumYum Bento - Dine in")
        End If



        If intCustomerID Then
            If ExistingCustomer() = True Then
                frmOrderPage.lblOrderType.Text = Sender.text
                frmOrderPage.lblCustomerID.Text = ("Customer ID " & intCustomerID)
                frmOrderPage.ShowDialog()
            End If
        End If



    End Sub

    Private Sub btnDineIn_Click(sender As Object, e As EventArgs) Handles btnDineIn.Click
        pnl_btnDineIn.Height = btnDineIn.Height
        pnl_btnDineIn.Top = btnDineIn.Top
        pnlDineIn.Visible = True
        pnlTakeOut.Visible = False
        pnlHome.Visible = False


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
        pnlHome.Visible = False

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
        pnlHome.Visible = True
        pnlDineIn.Visible = False
        pnlTakeOut.Visible = False

        rs.FindAllControls(Me)

    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        pnlHome.Visible = True
        pnlDineIn.Visible = False
        pnlTakeOut.Visible = False
    End Sub

    Private Sub frmOrdering_Type_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub

    Private Function ValidationCustomerInfo() As Boolean
        '---------------------------------validate for txtCustomerID--------------------------------------------------'
        Dim intInteger As Integer
        If String.IsNullOrWhiteSpace(txtCustomerID.Text) = False Then
            If Not Integer.TryParse(txtCustomerID.Text, intInteger) = True Then
                MessageBox.Show("Customer ID must be integer")
                txtCustomerID.SelectAll()
                txtCustomerID.Focus()
                Return False
            End If
        Else
            MessageBox.Show("Customer Id is required.")
            txtCustomerID.SelectAll()
            txtCustomerID.Focus()
            Return False
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
            MessageBox.Show("Customer ID does NOT exists, Please create first")
            Return False
        Else
            For Each rows In dtCustomer.Rows
                txtFirstName.Text = rows("first_name")
                txtLastName.Text = rows("last_name")
                txtPhone.Text = rows("phone")
            Next
        End If

        Return True
    End Function
End Class