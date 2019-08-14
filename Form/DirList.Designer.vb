<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DirList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DirList))
        Me.FtpServer_Tbx = New System.Windows.Forms.TextBox()
        Me.Search_Btn = New System.Windows.Forms.Button()
        Me.DirList_Lbx = New System.Windows.Forms.ListBox()
        Me.DirSelected_Lb = New System.Windows.Forms.Label()
        Me.DirSelected_Btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FtpServer_Tbx
        '
        Me.FtpServer_Tbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FtpServer_Tbx.Location = New System.Drawing.Point(15, 28)
        Me.FtpServer_Tbx.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FtpServer_Tbx.Multiline = True
        Me.FtpServer_Tbx.Name = "FtpServer_Tbx"
        Me.FtpServer_Tbx.Size = New System.Drawing.Size(391, 40)
        Me.FtpServer_Tbx.TabIndex = 0
        Me.FtpServer_Tbx.Text = "127.0.0.1"
        '
        'Search_Btn
        '
        Me.Search_Btn.BackgroundImage = Global.DBMerge.My.Resources.Resources.search
        Me.Search_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Search_Btn.Location = New System.Drawing.Point(412, 14)
        Me.Search_Btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Search_Btn.Name = "Search_Btn"
        Me.Search_Btn.Size = New System.Drawing.Size(80, 74)
        Me.Search_Btn.TabIndex = 1
        Me.Search_Btn.UseVisualStyleBackColor = True
        '
        'DirList_Lbx
        '
        Me.DirList_Lbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DirList_Lbx.FormattingEnabled = True
        Me.DirList_Lbx.ItemHeight = 30
        Me.DirList_Lbx.Location = New System.Drawing.Point(15, 92)
        Me.DirList_Lbx.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DirList_Lbx.Name = "DirList_Lbx"
        Me.DirList_Lbx.Size = New System.Drawing.Size(476, 244)
        Me.DirList_Lbx.TabIndex = 2
        '
        'DirSelected_Lb
        '
        Me.DirSelected_Lb.BackColor = System.Drawing.Color.White
        Me.DirSelected_Lb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DirSelected_Lb.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DirSelected_Lb.Location = New System.Drawing.Point(15, 369)
        Me.DirSelected_Lb.Name = "DirSelected_Lb"
        Me.DirSelected_Lb.Size = New System.Drawing.Size(391, 40)
        Me.DirSelected_Lb.TabIndex = 3
        '
        'DirSelected_Btn
        '
        Me.DirSelected_Btn.BackgroundImage = Global.DBMerge.My.Resources.Resources.merge
        Me.DirSelected_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.DirSelected_Btn.Location = New System.Drawing.Point(412, 352)
        Me.DirSelected_Btn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DirSelected_Btn.Name = "DirSelected_Btn"
        Me.DirSelected_Btn.Size = New System.Drawing.Size(80, 74)
        Me.DirSelected_Btn.TabIndex = 4
        Me.DirSelected_Btn.UseVisualStyleBackColor = True
        '
        'DirList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(507, 439)
        Me.Controls.Add(Me.DirSelected_Btn)
        Me.Controls.Add(Me.DirSelected_Lb)
        Me.Controls.Add(Me.DirList_Lbx)
        Me.Controls.Add(Me.Search_Btn)
        Me.Controls.Add(Me.FtpServer_Tbx)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DirList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DIR LIST"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FtpServer_Tbx As TextBox
    Friend WithEvents Search_Btn As Button
    Friend WithEvents DirList_Lbx As ListBox
    Friend WithEvents DirSelected_Lb As Label
    Friend WithEvents DirSelected_Btn As Button
End Class
