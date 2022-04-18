Public Class Ordering_Type
    '*********************************************Left Panel*********************************************************'
    Sub TableNumber(Sender As Object)
        Dim strTableNumber As String = Sender.text
        Dim frmOrdering As New frmOrdering

        frmOrdering.lblTableNo.Text = Sender.text
        frmOrdering.ShowDialog()
    End Sub
    Private Sub btnDineIn_Click(sender As Object, e As EventArgs) Handles btnDineIn.Click
        pnl_btnDineIn.Height = btnDineIn.Height
        pnl_btnDineIn.Top = btnDineIn.Top
        pnlDineIn.Visible = True
        pnlTakeOut.Visible = False


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
    End Sub



    '*********************************************Take Out Panel *********************************************************'
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim frmOrdering As New frmOrdering
        frmOrdering.lblTableNo.Text = txtFirstName.Text
        frmOrdering.ShowDialog()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstName.Clear()
        txtLastName.Clear()
        txtPhone.Clear()
    End Sub







End Class