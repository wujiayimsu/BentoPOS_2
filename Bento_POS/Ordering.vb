'Programmmed by Jiayi Wu
Public Class frmOrdering
    Private DB As New DBAccess

    Private Sub FilmForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        CreateFoodCategory()

    End Sub

    Sub CreateFoodCategory()
        Dim dtMenuCategory As New DataTable
        DB.ExecuteQuery("SELECT * FROM menu_category")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        dtMenuCategory = DB.DBDataTable

        Try
            For Each row In dtMenuCategory.Rows
                Dim btnCategoryGroup As New Button

                AddHandler btnCategoryGroup.Click, Sub() CategorySelection(btnCategoryGroup)

                btnCategoryGroup.Text = row("name")
                btnCategoryGroup.Size = New Size(120, 36)
                btnCategoryGroup.Font = New System.Drawing.Font("Calibri", 11)

                PanelMenuCategory.Controls.Add(btnCategoryGroup)
            Next
        Catch ex As Exception
            MessageBox.Show("error")
        End Try

    End Sub

    Sub CategorySelection(sender As Object)
        Dim strCategorySelected = sender.text
        Dim dtMenuitem As New DataTable


        PanelMenuItem.Controls.Clear()

        DB.AddParam("@name", strCategorySelected)
        DB.ExecuteQuery("select * from menu_category as C join menu as m on c.category_id = m.category_id where name = ?")

        If DB.DBException <> String.Empty Then
            MessageBox.Show(DB.DBException)
            Exit Sub
        End If

        dtMenuitem = DB.DBDataTable

        Try
            For Each row In dtMenuitem.Rows
                Dim btnMenuItemGroup As New Button

                btnMenuItemGroup.Text = row("item_name")
                btnMenuItemGroup.Size = New Size(120, 35)
                btnMenuItemGroup.Font = New System.Drawing.Font("Calibri", 10)

                PanelMenuItem.Controls.Add(btnMenuItemGroup)

            Next

        Catch ex As Exception
            MessageBox.Show("error")
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub



End Class