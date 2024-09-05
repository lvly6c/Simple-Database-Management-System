Module modConnection
    Public dbCon As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source = " & Application.StartupPath & "\dbName.mdb")
End Module
