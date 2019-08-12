Imports System.IO

Module Start
    Public Sub StartConfig()
        ConnectionFile = "PSW_Manager.db"
        ConnectionString = String.Format(ConnectionString, ConnectionFile)
    End Sub
End Module
