Public Class frmMain
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "&Edit" Then
            btnEdit.Text = "&Save"
            btnDelete.Text = "&Cancel"
            btnAdd.Enabled = False
            txtFirstName.ReadOnly = False
            txtLastName.ReadOnly = False
        Else
            btnAdd.Enabled = True
            btnEdit.Text = "&Edit"
            btnDelete.Text = "&Delete"
            txtFirstName.ReadOnly = True
            txtLastName.ReadOnly = True
            Try
                If dbCon.State = ConnectionState.Closed Then
                    dbCon.Open()
                End If
                Dim cmd As New OleDb.OleDbCommand("UPDATE tableName SET txtFirstName = '" & txtFirstName.Text & "', txtLastName = '" & txtLastName.Text & "' WHERE txtIDNumber = '" & txtIDNumber.Text & "'", dbCon)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MsgBox("Data updated!", MsgBoxStyle.Information, "Success")
                dbCon.Close()
                refreshDB()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If btnDelete.Text = "&Delete" Then
            Try
                If dbCon.State = ConnectionState.Closed Then
                    dbCon.Open()
                End If
                Dim cmd As New OleDb.OleDbCommand("DELETE FROM tableName WHERE txtIDNumber = '" & txtIDNumber.Text & "'", dbCon)
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                MsgBox("Delete success", MsgBoxStyle.Information, "Data delete")
                refreshDB()
                dbCon.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            btnAdd.Enabled = True
            btnEdit.Text = "&Edit"
            btnDelete.Text = "&Delete"
            txtFirstName.ReadOnly = True
            txtLastName.ReadOnly = True
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAddNew.ShowDialog()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        refreshDB()
    End Sub

    Private Sub refreshDB()
        Try
            If dbCon.State = ConnectionState.Closed Then
                dbCon.Open()
            End If
            Dim daCon As New OleDb.OleDbDataAdapter("SELECT * FROM tableName", dbCon)
            Dim dtCon As New DataTable
            daCon.Fill(dtCon)
            DataGridView1.DataSource = dtCon
            dbCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        txtIDNumber.Text = DataGridView1.Item(0, i).Value
        txtFirstName.Text = DataGridView1.Item(1, i).Value
        txtLastName.Text = DataGridView1.Item(2, i).Value
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            If dbCon.State = ConnectionState.Closed Then
                dbCon.Open()
            End If
            Dim daCon As New OleDb.OleDbDataAdapter("SELECT * FROM tableName WHERE txtIDNumber LIKE '%" & txtSearch.Text & "%'", dbCon)
            Dim dtCon As New DataTable
            daCon.Fill(dtCon)
            DataGridView1.DataSource = dtCon
        Catch ex As Exception

        End Try
    End Sub
End Class
