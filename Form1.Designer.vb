<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lstAvailableSongs = New System.Windows.Forms.ListView()
        Me.cmbGenres = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisplaySongSetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Bookman Old Style", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(540, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(196, 35)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Dance Band"
        '
        'lstAvailableSongs
        '
        Me.lstAvailableSongs.HideSelection = False
        Me.lstAvailableSongs.Location = New System.Drawing.Point(149, 186)
        Me.lstAvailableSongs.Name = "lstAvailableSongs"
        Me.lstAvailableSongs.Size = New System.Drawing.Size(621, 476)
        Me.lstAvailableSongs.TabIndex = 2
        Me.lstAvailableSongs.UseCompatibleStateImageBehavior = False
        Me.lstAvailableSongs.View = System.Windows.Forms.View.Details
        '
        'cmbGenres
        '
        Me.cmbGenres.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGenres.Font = New System.Drawing.Font("Bookman Old Style", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGenres.FormattingEnabled = True
        Me.cmbGenres.Items.AddRange(New Object() {"Rock", "Rap", "R&B", "Country", "Pop"})
        Me.cmbGenres.Location = New System.Drawing.Point(566, 89)
        Me.cmbGenres.Name = "cmbGenres"
        Me.cmbGenres.Size = New System.Drawing.Size(121, 29)
        Me.cmbGenres.TabIndex = 3
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisplaySongSetToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'DisplaySongSetToolStripMenuItem
        '
        Me.DisplaySongSetToolStripMenuItem.Name = "DisplaySongSetToolStripMenuItem"
        Me.DisplaySongSetToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DisplaySongSetToolStripMenuItem.Text = "Display Song Set"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 742)
        Me.Controls.Add(Me.cmbGenres)
        Me.Controls.Add(Me.lstAvailableSongs)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Dance Band"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lstAvailableSongs As ListView
    Friend WithEvents cmbGenres As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisplaySongSetToolStripMenuItem As ToolStripMenuItem
End Class
