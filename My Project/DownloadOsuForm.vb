Public Class DownloadOsuForm

    Sub New()
        InitializeComponent()
    End Sub

    Sub ChangeProgressBar(Value As Integer)
        OsuDownloadProgressBar.Value = Value
        OsuDownloadLabel.Text = "Osu Downloading..."
    End Sub

End Class
