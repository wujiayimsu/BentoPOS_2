Public Class databaseTest
    Private DB As New DBAccess
    Private Sub databaseTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'DB.ExecuteQuery("SELECT * FROM CUSTOMER")

        'If DB.DBException <> String.Empty Then
        'MessageBox.Show(DB.DBException)
        'Exit Sub
        'End If

        'DBDataGridView.DataSource = DB.DBDataTable
        'RecordToolStripStatusLabel.Text = "Record #: " & DB.RecordCount.ToString

        SearchCustomer(TextBox1.Text)

    End Sub
    Private Sub SearchCustomer(TextBox1 As String)
        DB.AddParam("@item_name", TextBox1)   '1st parameter

        DB.ExecuteQuery("SELECT PRICE FROM menu where item_name = ?")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        DataGridView1.DataSource = DB.DBDataTable


    End Sub

    Private Sub TextBox1_KeyUp(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyUp
        SearchCustomer(TextBox1.Text)
    End Sub

End Class