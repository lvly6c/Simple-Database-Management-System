Public Class frmAddNew
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            If dbCon.State = ConnectionState.Closed Then
                dbCon.Open()
            End If
            Dim cmd As New OleDb.OleDbCommand("INSERT INTO tableName(txtIDNumber,txtFirstName,txtLastName)VALUES('" & txtIDNumber.Text & "', '" & txtFirstName.Text & "', '" & txtLastName.Text & "')", dbCon)
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            dbCon.Close()
            Dim tanong = MsgBox("Save success! Add new data?", MsgBoxStyle.YesNo, "Query")
            If tanong = vbYes Then
                txtIDNumber.Text = vbNullString
                txtLastName.Text = vbNullString
                txtFirstName.Text = vbNullString
                txtIDNumber.Focus()
            Else
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class