Public Class frmMain
    Private _FILENAME = "c:\school\csc-139\chapter8\songs.txt"
    Public Shared SONGS(,)
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Prepare the reader
        Dim objReader As IO.StreamReader
        objReader = My.Computer.FileSystem.OpenTextFileReader(_FILENAME)

        'Populate the 2D array
        Dim i = 0
        Do While objReader.Peek() <> -1
            ReDim Preserve SONGS(2, i)
            SONGS(0, i) = objReader.ReadLine
            SONGS(1, i) = objReader.ReadLine
            SONGS(2, i) = objReader.ReadLine
            i += 1
        Loop

        'Populate the listbox
        lstAvailableSongs.View = View.Details
        lstAvailableSongs.FullRowSelect = True
        lstAvailableSongs.Columns.Add("Song Name", 300, HorizontalAlignment.Center)
        lstAvailableSongs.Columns.Add("Genre", 100, HorizontalAlignment.Center)
        lstAvailableSongs.Columns.Add("Track Length", 100, HorizontalAlignment.Center)
        Controls.Add(lstAvailableSongs)
        lstAvailableSongs.Dock = DockStyle.Fill
        Dim arrLVItem(SONGS.GetUpperBound(1)) As ListViewItem
        For i = 0 To SONGS.GetUpperBound(1)
            arrLVItem(i) = New ListViewItem
            arrLVItem(i).SubItems(0).Text = (SONGS(0, i))
            arrLVItem(i).SubItems.Add(SONGS(1, i))
            arrLVItem(i).SubItems.Add(SONGS(2, i))
        Next
        lstAvailableSongs.Items.AddRange(arrLVItem)
    End Sub

    Private Sub Update_Genre(sender As Object, e As EventArgs) Handles cmbGenres.SelectedIndexChanged
        lstAvailableSongs.Clear()
        lstAvailableSongs.View = View.Details
        lstAvailableSongs.FullRowSelect = True
        lstAvailableSongs.Columns.Add("Song Name", 300, HorizontalAlignment.Center)
        lstAvailableSongs.Columns.Add("Genre", 100, HorizontalAlignment.Center)
        lstAvailableSongs.Columns.Add("Track Length", 100, HorizontalAlignment.Center)
        Controls.Add(lstAvailableSongs)
        lstAvailableSongs.Dock = DockStyle.Fill
        Dim arrLVItem(0) As ListViewItem
        Dim j = 0
        For i = 0 To SONGS.GetUpperBound(1)
            If SONGS(1, i) = cmbGenres.SelectedItem.ToString Then
                lstAvailableSongs.Items.Add(New ListViewItem({SONGS(0, i), SONGS(1, i), SONGS(2, i)}))
                j += 1
            End If
        Next
    End Sub

    Private Sub DisplaySongSetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisplaySongSetToolStripMenuItem.Click
        Me.Hide()
        frmSongSet.Show()
    End Sub
End Class
