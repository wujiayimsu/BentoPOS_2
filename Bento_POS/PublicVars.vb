Module PublicVars
    Private DB As New DBAccess
    Public strline As String = ("-----------------------------------------------------------------")
    Public decDiscountRate As Decimal
    Public dtLoadOrder As New DataTable

    Public Sub SearchOpenTOGO(strStatus As String, strType As String)
        frmOrdering_Type.pnlOpenTakeOut.Controls.Clear()

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

                AddHandler btnOpenOrder.Click, Sub() SearchOpenTOGO_2(btnOpenOrder)

                btnOpenOrder.Text = (row("order_id") & " - " & row("first_name"))
                btnOpenOrder.Size = New Size(120, 35)
                btnOpenOrder.Font = New System.Drawing.Font("Calibri", 10, FontStyle.Bold)

                frmOrdering_Type.pnlOpenTakeOut.Controls.Add(btnOpenOrder)

            Next

        Catch ex As Exception
            MessageBox.Show("error")
        End Try
    End Sub

    Public Sub SearchOpenTOGO_2(sender As Object)

        Dim strSender As String = sender.text
        Dim strFirstName As String
        Dim strOrderID As String
        Dim strArr(1) As String

        strArr = strSender.Split(" - ")
        strOrderID = strArr(0)
        strFirstName = strArr(1)

        DB.AddParam("@first_name", strFirstName)
        DB.AddParam("@order_id", strOrderID)
        DB.ExecuteQuery("SELECT c.customer_id, c.first_name, o.order_id, o.order_status, o.order_type, i.item_id, m.item_name, i.quantity, m.price From customer As c Join customer_order As o On c.customer_id=o.customer_id Join order_item As i On o.order_id = i.order_id Join menu As m On i.item_id = m.item_id Where order_status = 'open' AND order_type ='to go' AND o.order_id = ? AND c.first_name = ?")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        dtLoadOrder = DB.DBDataTable

    End Sub
    Public Sub LoadOpenOrder()

        Try
            frmOrdering.ShowDialog()
            For Each row In dtLoadOrder.Rows
                frmOrdering.lstOrderItem.Items.Add(dtLoadOrder.Rows("item_name"))
                frmOrdering.lstPrice.Items.Add(dtLoadOrder.Rows("price"))
                frmOrdering.lstQuantity.Items.Add(dtLoadOrder.Rows("quantity"))
                frmOrdering.ButtomFiguresDisplay()
            Next


        Catch ex As Exception
            MessageBox.Show("error")
        End Try

    End Sub
End Module
