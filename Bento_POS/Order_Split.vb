Public Class Order_Split
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblSplitCount.Text = String.Empty
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        intSplitCount = lblSplitCount.Text
        Me.Close()
        frmOrdering.Focus()
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        lblSplitCount.Text = 1
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        lblSplitCount.Text = 2
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        lblSplitCount.Text = 3
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        lblSplitCount.Text = 4
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        lblSplitCount.Text = 5
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        lblSplitCount.Text = 6
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        lblSplitCount.Text = 7
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        lblSplitCount.Text = 8
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        lblSplitCount.Text = 9
    End Sub
End Class