Public Class DB_Merge
#Region "VARIABLE"
    Dim id_password As Long
    Dim dt As DataTable
    Dim columnsName() As String, columnsType() As String
#End Region
#Region "FORM"
    Private Sub DB_Merge_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartConfig()
        InitForm()
        LoadData()
    End Sub
#End Region
#Region "DATA"
    Private Sub InitForm()
    End Sub
    Private Sub LoadData()
    End Sub
#End Region
#Region "CONTROL"
#Region "   BUTTON"
#End Region
#Region "   TEXT BOX"
#End Region
#Region "   DATAGRIDVIEW"
#End Region
#End Region
End Class
