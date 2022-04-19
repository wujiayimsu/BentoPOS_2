﻿Public Class frmOrder_discount
    Private DB As New DBAccess
    Dim dtDiscount As New DataTable
    Private Sub order_discount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateDiscountbtn()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnApply.Click
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

        dtDiscount = DB.DBDataTable

        Try
            For Each row In dtDiscount.Rows
                Dim btnDiscountGroup As New Button

                AddHandler btnDiscountGroup.Click, Sub() DiscountDisplay(btnDiscountGroup)

                btnDiscountGroup.Text = row("description")
                btnDiscountGroup.Size = New Size(120, 36)
                btnDiscountGroup.Font = New System.Drawing.Font("Calibri", 11)
                btnDiscountGroup.BackColor = ColorTranslator.FromWin32(RGB(244, 196, 108))
                pnlButtonGroup.Controls.Add(btnDiscountGroup)
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

        dtDiscount = DB.DBDataTable

        Try
            For Each row In dtDiscount.Rows
                strDiscount = row("discount")
                lblDiscount.Text = strDiscount
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
End Class