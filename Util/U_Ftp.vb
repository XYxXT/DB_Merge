Imports System.IO
Imports System.Net

Module U_Ftp
    Public FTPServer As String = "127.0.0.1"
    Public FTP_UserName As String = "admin"
    Public FTP_UserPSW As String = "admin"
    Public Sub Ftp_Download(ByVal ftpPath As String, ByVal localPath As String)
        If File.Exists(localPath) Then File.Delete(localPath)
        My.Computer.Network.DownloadFile("ftp://" & ftpPath, localPath, FTP_UserName, FTP_UserPSW)
    End Sub
    Public Sub Ftp_Upload(ByVal ftpPath As String, ByVal localPath As String)
        My.Computer.Network.UploadFile(localPath, "ftp://" & ftpPath, FTP_UserName, FTP_UserPSW, True, 500, FileIO.UICancelOption.DoNothing)
    End Sub
    Public Sub Ftp_DeleteFile(ByVal ftpPath As String)
        Dim request As FtpWebRequest = WebRequest.Create("ftp://" & ftpPath)
        request.Credentials = New NetworkCredential(FTP_UserName, FTP_UserPSW)
        request.Method = WebRequestMethods.Ftp.DeleteFile
        Dim response As FtpWebResponse = request.GetResponse
        response.Close()
    End Sub
    Public Function Ftp_FileExist(ByVal ftpPath As String)
        Dim request As FtpWebRequest = WebRequest.Create("ftp://" & ftpPath)
        request.Credentials = New NetworkCredential(FTP_UserName, FTP_UserPSW)
        request.Method = WebRequestMethods.Ftp.GetFileSize
        Dim response As FtpWebResponse
        Try
            response = request.GetResponse
            Return True
        Catch ex As WebException
            Return False
        End Try
    End Function
    Public Function Ftp_GetFileList(ByVal ftpPath As String, Optional ByVal onlyDir As Boolean = False) As List(Of String)
        Dim request = DirectCast(WebRequest.Create("ftp://" & ftpPath), FtpWebRequest)

        request.Method = WebRequestMethods.Ftp.ListDirectory
        request.Credentials = New NetworkCredential(FTP_UserName, FTP_UserPSW)

        Dim reader As New StreamReader(request.GetResponse().GetResponseStream())

        Dim lines As New List(Of String)
        Do
            Dim line = reader.ReadLine()
            If line Is Nothing Then Exit Do
            If onlyDir And IsFile(line) Then Continue Do
            lines.Add(line)
        Loop
        Return lines
    End Function


End Module
