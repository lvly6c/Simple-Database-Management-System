Public Class frmConnection
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        Try
            If dbCon.State = ConnectionState.Closed Then
                dbCon.Open()
            End If
            MsgBox("Database opened!", MsgBoxStyle.Information, "Success")
            btnConnect.Enabled = False
            btnDisconnect.Enabled = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        Try
            If dbCon.State = ConnectionState.Open Then
                dbCon.Close()
            End If
            MsgBox("Database has been closed!", MsgBoxStyle.Information, "Success")
            btnConnect.Enabled = True
            btnDisconnect.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class