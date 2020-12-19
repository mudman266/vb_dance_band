<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSongSet
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lstAvailableSongs = New System.Windows.Forms.ListView()
        Me.btnSort = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(564, 346)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(224, 79)
        Me.btnBack.TabIndex = 0
        Me.btnBack.Text = "Back to Main"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lstAvailableSongs
        '
        Me.lstAvailableSongs.HideSelection = False
        Me.lstAvailableSongs.Location = New System.Drawing.Point(12, 12)
        Me.lstAvailableSongs.Name = "lstAvailableSongs"
        Me.lstAvailableSongs.Size = New System.Drawing.Size(485, 426)
        Me.lstAvailableSongs.TabIndex = 1
        Me.lstAvailableSongs.UseCompatibleStateImageBehavior = False
        '
        'btnSort
        '
        Me.btnSort.Location = New System.Drawing.Point(564, 244)
        Me.btnSort.Name = "btnSort"
        Me.btnSort.Size = New System.Drawing.Size(224, 79)
        Me.btnSort.TabIndex = 2
        Me.btnSort.Text = "Sort List"
        Me.btnSort.UseVisualStyleBackColor = True
        '
        'frmSongSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnSort)
        Me.Controls.Add(Me.lstAvailableSongs)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "frmSongSet"
        Me.Text = "Song Set"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lstAvailableSongs As ListView
    Friend WithEvents btnSort As Button
End Class
