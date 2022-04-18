'Programmed by Jiayi Wu
Public Class CustomerForm
    Private DB As New DBAccess

    Private Sub CustomerForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        'DB.ExecuteQuery("SELECT * FROM CUSTOMER")

        'If DB.DBException <> String.Empty Then
        'MessageBox.Show(DB.DBException)
        'Exit Sub
        'End If

        'DBDataGridView.DataSource = DB.DBDataTable
        'RecordToolStripStatusLabel.Text = "Record #: " & DB.RecordCount.ToString

        SearchCustomer(txtFirstName.Text, txtLastName.Text)
    End Sub

    Private Sub SearchCustomer(FirstName As String, LastName As String)
        DB.AddParam("@firstname", FirstName & "%")   '1st parameter
        'DB.AddParam("@lastname", LastName & "%")     '2nd parameter

        DB.ExecuteQuery("SELECT * FROM customer WHERE first_name LIKE ? AND last_name LIKE ?")


        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        DBDataGridView.DataSource = DB.DBDataTable
        RecordToolStripStatusLabel.Text = "Record #: " & DB.RecordCount.ToString
    End Sub

    Private Sub txtFirstName_KeyUp(sender As Object, e As KeyEventArgs) Handles txtFirstName.KeyUp
        SearchCustomer(txtFirstName.Text, txtLastName.Text)
    End Sub

    Private Sub txtLastName_KeyUp(sender As Object, e As KeyEventArgs) Handles txtLastName.KeyUp
        SearchCustomer(txtFirstName.Text, txtLastName.Text)
    End Sub


End Class
