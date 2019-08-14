Imports System.IO

Public Class DBMerge
#Region "VARIABLE"
    Public DBFile As String
    Dim DBFilePath As String
    Dim FileList As List(Of String)
#End Region
#Region "FORM"
    Private Sub DBMerge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitForm()
        LoadData()
    End Sub
#End Region
#Region "DATA"
    Private Sub InitForm()
        DBFile_Lb.Text = DBFile
        DBFilePath = FTPServer & FTPPath & DBFile & "/"
        If Not Ftp_FileExist(DBFilePath & DBFile & ".db") Then MsgBox("FILE " & DBFile & ".db NO EXIST") : Close()
        State_Lb.Text = ""
    End Sub
    Private Sub LoadData()
        FileList = Ftp_GetFileList(DBFilePath)
        FileList.RemoveAt(0)
        FileList_Lbx.Items.AddRange(FileList.ToArray)
    End Sub
#End Region
#Region "CONTROL"
#Region "   BUTTON"
    Private Sub Start_Btn_Click(sender As Object, e As EventArgs) Handles Start_Btn.Click
        Ftp_Download(DBFilePath & DBFile & ".db", DBFile & ".db")
        For i = 0 To FileList.Count - 1 Step 1
            FileList_Lbx.SelectedIndex = i
            MergeDB(DBFilePath & FileList(i))
        Next
        Ftp_DeleteFile(DBFilePath & DBFile & ".db")
        Ftp_Upload(DBFilePath & DBFile & ".db", DBFile & ".db")
        File.Delete(DBFile & ".db")
    End Sub
#End Region
#Region "   TEXT BOX"
#End Region
#Region "   DATAGRIDVIEW"
#End Region
#Region "   LIST BOX"
#End Region
#End Region
#Region "ACTIONS"
    Private Sub MergeDB(ByVal dbPath As String)
        Ftp_Download(dbPath, DBFile & "_tmp.db")
        State_Lb.Text = dbPath & " is downloaded"

        SqliteConnectionString = String.Format(SqliteConnectionPatern, DBFile & "_tmp.db")
        SqliteOpen()
        Dim tableNames_dt As DataTable
        SqliteDbDt(tableNames_dt, "SELECT name FROM sqlite_sequence")

        Dim newTables(tableNames_dt.Rows.Count - 1) As DataTable
        For i = 0 To tableNames_dt.Rows.Count - 1 Step 1
            SqliteDbDt(newTables(i), "SELECT * FROM " & tableNames_dt.Rows(i).Item("name"))
            newTables(i).Columns.Add("x", GetType(String))
            newTables(i).Columns("x").DefaultValue = ""
        Next
        SqliteClose()

        SqliteConnectionString = String.Format(SqliteConnectionPatern, DBFile & ".db")
        SqliteOpen()
        Dim oldTables(tableNames_dt.Rows.Count - 1) As DataTable
        For i = 0 To tableNames_dt.Rows.Count - 1 Step 1
            State_Lb.Text = "MERGE TABLE " & tableNames_dt.Rows(i).Item("name")
            SqliteDbDt(oldTables(i), "SELECT * FROM " & tableNames_dt.Rows(i).Item("name"))

            For r = 0 To newTables(i).Rows.Count - 1 Step 1
                If r = oldTables(i).Rows.Count Then
                    While r < newTables(i).Rows.Count
                        newTables(i).Rows(r).Item("x") = "N"
                        r += 1
                    End While
                    SqliteDtBd(newTables(i), tableNames_dt.Rows(i).Item("name"))
                    Exit For
                ElseIf oldTables(i).Rows(r).Item(0) <> newTables(i).Rows(r).Item(0) Or
                   oldTables(i).Rows(r).Item(1) <> newTables(i).Rows(r).Item(1) Then
                    While r < newTables(i).Rows.Count
                        newTables(i).Rows(r).Item("x") = "N"
                        r += 1
                    End While
                    SqliteDtBd(newTables(i), tableNames_dt.Rows(i).Item("name"))
                    Exit For
                End If
            Next
        Next


        SqliteClose()

        Ftp_DeleteFile(dbPath)
        File.Delete(DBFile & "_tmp.db")
        State_Lb.Text = dbPath & " is delete"
    End Sub
#End Region
End Class