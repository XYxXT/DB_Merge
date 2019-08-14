<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DBMerge
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DBMerge))
        Me.DBFile_Lb = New System.Windows.Forms.Label()
        Me.FileList_Lbx = New System.Windows.Forms.ListBox()
        Me.Start_Btn = New System.Windows.Forms.Button()
        Me.State_Lb = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DBFile_Lb
        '
        Me.DBFile_Lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DBFile_Lb.Location = New System.Drawing.Point(11, 21)
        Me.DBFile_Lb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DBFile_Lb.Name = "DBFile_Lb"
        Me.DBFile_Lb.Size = New System.Drawing.Size(323, 32)
        Me.DBFile_Lb.TabIndex = 0
        '
        'FileList_Lbx
        '
        Me.FileList_Lbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FileList_Lbx.FormattingEnabled = True
        Me.FileList_Lbx.ItemHeight = 24
        Me.FileList_Lbx.Location = New System.Drawing.Point(11, 73)
        Me.FileList_Lbx.Margin = New System.Windows.Forms.Padding(2)
        Me.FileList_Lbx.Name = "FileList_Lbx"
        Me.FileList_Lbx.Size = New System.Drawing.Size(387, 268)
        Me.FileList_Lbx.TabIndex = 1
        '
        'Start_Btn
        '
        Me.Start_Btn.BackgroundImage = Global.DBMerge.My.Resources.Resources.start
        Me.Start_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Start_Btn.Location = New System.Drawing.Point(338, 9)
        Me.Start_Btn.Margin = New System.Windows.Forms.Padding(2)
        Me.Start_Btn.Name = "Start_Btn"
        Me.Start_Btn.Size = New System.Drawing.Size(60, 60)
        Me.Start_Btn.TabIndex = 2
        Me.Start_Btn.UseVisualStyleBackColor = True
        '
        'State_Lb
        '
        Me.State_Lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.State_Lb.Location = New System.Drawing.Point(12, 354)
        Me.State_Lb.Name = "State_Lb"
        Me.State_Lb.Size = New System.Drawing.Size(386, 29)
        Me.State_Lb.TabIndex = 4
        '
        'DBMerge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 392)
        Me.Controls.Add(Me.State_Lb)
        Me.Controls.Add(Me.Start_Btn)
        Me.Controls.Add(Me.FileList_Lbx)
        Me.Controls.Add(Me.DBFile_Lb)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DBMerge"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DB MERGE"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DBFile_Lb As Label
    Friend WithEvents FileList_Lbx As ListBox
    Friend WithEvents Start_Btn As Button
    Friend WithEvents State_Lb As Label
End Class
