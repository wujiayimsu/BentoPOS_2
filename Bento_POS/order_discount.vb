Public Class frmOrder_discount
    Private DB As New DBAccess
    Public dtAllDiscount As New DataTable
    Public dtSingleDiscount As New DataTable
    Dim rs As New Resizer
    Private Sub order_discount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateDiscountbtn()
        rs.FindAllControls(Me)
    End Sub

    Private Sub btnApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        If lblDiscount.Text = String.Empty Then
            MessageBox.Show("Please select one discount to proceed")
        Else
            decDiscountRate = CDec(lblDiscount.Text)
            Me.Close()
            frmOrdering.ButtomFiguresDisplay()
        End If
    End Sub


    Sub CreateDiscountbtn()
        DB.ExecuteQuery("SELECT * FROM discount")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        dtAllDiscount = DB.DBDataTable

        Try
            For Each row In dtAllDiscount.Rows
                If row("is_active") = 1 Then
                    Dim btnDiscountGroup As New Button

                    AddHandler btnDiscountGroup.Click, Sub() DiscountDisplay(btnDiscountGroup)

                    btnDiscountGroup.Text = row("description")
                    btnDiscountGroup.Size = New Size(120, 36)
                    btnDiscountGroup.Font = New System.Drawing.Font("Calibri", 11, FontStyle.Bold)
                    btnDiscountGroup.BackColor = ColorTranslator.FromWin32(RGB(244, 196, 108))
                    pnlButtonGroup.Controls.Add(btnDiscountGroup)
                Else
                    'do nothing
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("error")
        End Try
    End Sub

    Sub DiscountDisplay(sender As Object)
        Dim strDescription As String = sender.text
        Dim strDiscount As String

        DB.AddParam("@description", sender.text)
        DB.ExecuteQuery("SELECT * FROM discount where description =?")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        dtSingleDiscount = DB.DBDataTable

        Try
            For Each row In dtSingleDiscount.Rows
                strDiscount = row("discount")
                lblDiscount.Text = strDiscount
                strDiscountID = row("discount_id")
                lblDiscountID.Text = strDiscountID

            Next
            lblDescription.Text = strDescription
        Catch ex As Exception
            MessageBox.Show("error")
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblDiscount.Text = String.Empty
        lblDescription.Text = String.Empty
    End Sub

    Private Sub frmOrder_discount_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        rs.ResizeAllControls(Me)
    End Sub
End Class