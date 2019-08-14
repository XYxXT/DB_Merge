Module U_System
    Public Function IsDebug()
        Return System.Diagnostics.Debugger.IsAttached
    End Function
    Public Function IsFile(ByVal filePath As String)
        filePath = filePath.Replace("/", "\")
        Dim spl() As String = filePath.Split("\")
        Return spl(spl.Length - 1).Contains(".")
    End Function
End Module
