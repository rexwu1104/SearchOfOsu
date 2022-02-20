Imports SearcherScreen = SearchOfOsu.My.SearcherScreen

Public Class SearcherOfOsu

    Private ReadOnly SS As New SearcherScreen()
    Private DOF As New DownloadOsuForm()
    Private Songs As New List(Of Osu.SongsData)()

    Sub New()

        InitializeComponent()

        SS.Bigest(Me)

    End Sub

    Private Sub Downloader_OnDownloadData(sender As Osu.OsuDownloader, e As Osu.OsuDownloader.DownloadDataEventArgs) Handles Downloader.DownloadData

        DOF.ChangeProgressBar(e.Present)

    End Sub

    Private Sub Dowloader_OnDownloadComplete(sender As Osu.OsuDownloader, e As Osu.OsuDownloader.DownloadDataEventArgs) Handles Downloader.DownloadComplete

        DOF.ChangeProgressBar(e.Present)
        DOF.OsuDownloadLabel.Text = "Osu Download Success"
        DOF.OsuDownloadLabel.Location = New Point(115, 190)

    End Sub

    Private Sub BrowseButton_Click(sender As Button, e As EventArgs) Handles BrowseButton.Click

        Dim BrowserStatus = OsuDirectoryBrowser.ShowDialog()

        If BrowserStatus = DialogResult.OK Then
            OsuDirectoryPath.Text = OsuDirectoryBrowser.SelectedPath

            ' 如果在此資料夾，Osu 的資料找不到會回報給使用者，他的 Osu 已遺失
            ' 並且詢問是否幫使用者下載 Osu
            ' 是的話，就下載並安裝
            ' 不是的話，就不執行任何動作
        End If

    End Sub

    Private Async Sub DetectButton_Click(sender As Object, e As EventArgs) Handles DetectButton.Click

        Dim Detecter As New Osu.DetectClass()
        Dim UserDirectoryName = Detecter.DetectUserDirectory()

        If UserDirectoryName = "No User" Then
            MsgBox("I can't find any User.")
        Else
            Dim OsuDirectoryName = Detecter.DetectOsuDirectory(UserDirectoryName)

            If OsuDirectoryName = "No Osu" Then

                MsgBox("You don't download the Osu in defalut directory.")
                Dim Result = MsgBox("Download Osu now?", MsgBoxStyle.YesNo, "Download Osu")

                If Result = MsgBoxResult.Yes Then

                    DOF.Icon = New Icon("osu!.ico")
                    DOF.Show()
                    Visible = False

                    OsuDirectoryPath.Text = Await Downloader.DownloadOsu(UserDirectoryName)

                    Visible = True
                    MsgBox("Download Success.")
                    DOF.Close()

                    DOF = New DownloadOsuForm()

                End If

            Else

                OsuDirectoryPath.Text = OsuDirectoryName

                SongList.ClearSelected()
                SongList.ResetText()

                For Each SongDirectory In Detecter.DetectSongs(OsuDirectoryName)
                    Dim Song = Detecter.DetectSongInfo(SongDirectory)
                    Songs.Add(Song)

                    SongList.Items.Add(Song.Title)
                Next

            End If

        End If

    End Sub

    Private Sub SongList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SongList.SelectedIndexChanged

        Dim Name = SongList.Text
        Dim DataContent = Songs.Find(Function(V) V.Title = Name)

        Dim Content = ""

        Content += DataContent.Title + "

"
        For Each Song In DataContent.SongList
            Content += "    [" + Song.Version + "]: " + Song.Title + "
"
        Next
        'Content += "\r\tAR: " + DataContent.AR.ToString("F1") + "\n"
        'Content += "\r\tHP: " + DataContent.HP.ToString("F1") + "\n"
        'Content += "\r\tCS: " + DataContent.CS.ToString("F1") + "\n"
        'Content += "\r\tOD: " + DataContent.OD.ToString("F1") + "\n"

        MsgBox(Content)

    End Sub

    Friend WithEvents Downloader As New Osu.OsuDownloader()

End Class
