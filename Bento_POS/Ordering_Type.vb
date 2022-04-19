Public Class frmOrdering_Type
    Private DB As New DBAccess

    '*********************************************Left Panel*********************************************************'
    Sub TableNumber(Sender As Object)
        Dim strTableNumber As String = Sender.text
        Dim frmOrdering As New frmOrdering

        frmOrdering.lblTableNo.Text = Sender.text
        frmOrdering.ShowDialog()
    End Sub

    Sub pnlDinein_load()

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

        SearchOpenOrder("0pen", "to go")
    End Sub

    Sub SearchOpenOrder(strStatus As String, strType As String)

        Dim dtOpenOrder As New DataTable
        strStatus = "open"

        DB.AddParam("@order_status", strStatus)
        DB.AddParam("@order_type", strType)
        DB.ExecuteQuery("SELECT c.customer_id, c.first_name, c.last_name, o.order_id, o.order_status, o.order_type FROM customer AS c JOIN customer_order AS o ON c.customer_id=o.customer_id WHERE order_status = ? AND order_type =?")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        dtOpenOrder = DB.DBDataTable

        Try
            For Each row In dtOpenOrder.Rows
                Dim btnOpenOrder As New Button

                btnOpenOrder.Text = (row("order_id") & " - " & row("first_name"))
                btnOpenOrder.Size = New Size(120, 35)
                btnOpenOrder.Font = New System.Drawing.Font("Calibri", 10, FontStyle.Bold)

                pnlOpenTakeOut.Controls.Add(btnOpenOrder)

            Next

        Catch ex As Exception
            MessageBox.Show("error")
        End Try
    End Sub
    Sub LoadOpenOrder(sender As Object)

    End Sub

    '*********************************************Take Out Panel *********************************************************'
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim frmOrdering As New frmOrdering

        If txtFirstName.Text = String.Empty Then
            MessageBox.Show("First Name is required")
            txtFirstName.Focus()
        Else
            frmOrdering.lblTableNo.Text = txtFirstName.Text
            frmOrdering.ShowDialog()
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstName.Clear()
        txtLastName.Clear()
        txtPhone.Clear()
    End Sub

    Private Sub frmOrdering_Type_Load(sender As Object, e As EventArgs) Handles Me.Load
        pnlHome.Visible = True
        pnlDineIn.Visible = False
        pnlTakeOut.Visible = False
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        pnlHome.Visible = True
        pnlDineIn.Visible = False
        pnlTakeOut.Visible = False
    End Sub
End Class