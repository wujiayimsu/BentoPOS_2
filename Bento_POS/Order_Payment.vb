'Programmed by JiayiWu
Public Class Order_Payment
    Private DB As DBAccess


    Private Sub btnCash_Click(sender As Object, e As EventArgs) Handles btnCash.Click
        lblPayMethod.Text = "CASH"

    End Sub

    Private Sub btnCard_Click(sender As Object, e As EventArgs) Handles btnCard.Click
        lblPayMethod.Text = "CARD"
    End Sub

    Private Sub Order_Payment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPayMethod.Text = String.Empty
        'lblSubTotal.Text = CDec(frmOrdering.dblSubTotal)
        'lblTax.Text = frmOrdering.decTax
        'lblDiscAmt.Text = frmOrdering.decDiscountAmt
        'lblTotal.Text = frmOrdering.decTotal

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        If lblPayMethod.Text = String.Empty Then
            MessageBox.Show("Please Select At Least One Payment Method")
        Else
            strPayMethod = lblPayMethod.Text
            Me.Close()
            frmOrdering.Focus()
        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class