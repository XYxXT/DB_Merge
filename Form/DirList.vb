Public Class DirList
#Region "VARIABLE"
#End Region
#Region "FORM"
    Private Sub DirList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartConfig()
        InitForm()
        LoadData()
    End Sub
#End Region
#Region "DATA"
    Private Sub InitForm()
        FtpServer_Tbx.Text = FTPServer
    End Sub
    Private Sub LoadData()
        DirList_Lbx.Items.Clear()
        Dim dirs As List(Of String) = Ftp_GetFileList(FtpServer_Tbx.Text & FTPPath, True)
        DirList_Lbx.Items.AddRange(dirs.ToArray)
    End Sub
#End Region
#Region "CONTROL"
#Region "   BUTTON"
    Private Sub Search_Btn_Click(sender As Object, e As EventArgs) Handles Search_Btn.Click
        LoadData()
    End Sub
    Private Sub DirSelected_Btn_Click(sender As Object, e As EventArgs) Handles DirSelected_Btn.Click
        If Trim(DirSelected_Lb.Text) <> "" Then FTPServer = FtpServer_Tbx.Text : DBMerge.DBFile = DirSelected_Lb.Text : DBMerge.ShowDialog()
    End Sub
#End Region
#Region "   TEXT BOX"
#End Region
#Region "   DATAGRIDVIEW"
#End Region
#Region "   LIST BOX"
    Private Sub DirList_Lbx_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DirList_Lbx.SelectedIndexChanged
        DirSelected_Lb.Text = DirList_Lbx.SelectedItem
    End Sub
#End Region
#End Region
End Class
