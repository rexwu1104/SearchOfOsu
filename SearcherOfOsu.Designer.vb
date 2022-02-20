<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SearcherOfOsu
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請勿使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.OsuDirectoryLabel = New System.Windows.Forms.Label()
        Me.OsuDirectoryPath = New System.Windows.Forms.TextBox()
        Me.BrowseButton = New System.Windows.Forms.Button()
        Me.OsuDirectoryBrowser = New System.Windows.Forms.FolderBrowserDialog()
        Me.SongList = New System.Windows.Forms.ListBox()
        Me.DetectButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'OsuDirectoryLabel
        '
        Me.OsuDirectoryLabel.AutoSize = True
        Me.OsuDirectoryLabel.Font = New System.Drawing.Font("新細明體", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.OsuDirectoryLabel.Location = New System.Drawing.Point(111, 98)
        Me.OsuDirectoryLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.OsuDirectoryLabel.Name = "OsuDirectoryLabel"
        Me.OsuDirectoryLabel.Size = New System.Drawing.Size(185, 32)
        Me.OsuDirectoryLabel.TabIndex = 0
        Me.OsuDirectoryLabel.Text = "Osu Directory"
        '
        'OsuDirectoryPath
        '
        Me.OsuDirectoryPath.Location = New System.Drawing.Point(304, 101)
        Me.OsuDirectoryPath.Margin = New System.Windows.Forms.Padding(4)
        Me.OsuDirectoryPath.Name = "OsuDirectoryPath"
        Me.OsuDirectoryPath.Size = New System.Drawing.Size(329, 30)
        Me.OsuDirectoryPath.TabIndex = 1
        '
        'BrowseButton
        '
        Me.BrowseButton.Location = New System.Drawing.Point(641, 97)
        Me.BrowseButton.Margin = New System.Windows.Forms.Padding(4)
        Me.BrowseButton.Name = "BrowseButton"
        Me.BrowseButton.Size = New System.Drawing.Size(149, 41)
        Me.BrowseButton.TabIndex = 2
        Me.BrowseButton.Text = "browse"
        Me.BrowseButton.UseVisualStyleBackColor = True
        '
        'SongList
        '
        Me.SongList.FormattingEnabled = True
        Me.SongList.ItemHeight = 23
        Me.SongList.Location = New System.Drawing.Point(119, 169)
        Me.SongList.Margin = New System.Windows.Forms.Padding(4)
        Me.SongList.Name = "SongList"
        Me.SongList.Size = New System.Drawing.Size(461, 533)
        Me.SongList.TabIndex = 3
        '
        'DetectButton
        '
        Me.DetectButton.Location = New System.Drawing.Point(798, 98)
        Me.DetectButton.Margin = New System.Windows.Forms.Padding(4)
        Me.DetectButton.Name = "DetectButton"
        Me.DetectButton.Size = New System.Drawing.Size(149, 41)
        Me.DetectButton.TabIndex = 4
        Me.DetectButton.Text = "detect"
        Me.DetectButton.UseVisualStyleBackColor = True
        '
        'SearcherOfOsu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1545, 896)
        Me.Controls.Add(Me.DetectButton)
        Me.Controls.Add(Me.SongList)
        Me.Controls.Add(Me.BrowseButton)
        Me.Controls.Add(Me.OsuDirectoryPath)
        Me.Controls.Add(Me.OsuDirectoryLabel)
        Me.Margin = New System.Windows.Forms.Padding(1, 4, 1, 4)
        Me.Name = "SearcherOfOsu"
        Me.Text = "Searcher Of Osu (SO2)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OsuDirectoryLabel As Label
    Friend WithEvents OsuDirectoryPath As TextBox
    Friend WithEvents BrowseButton As Button
    Friend WithEvents OsuDirectoryBrowser As FolderBrowserDialog
    Friend WithEvents SongList As ListBox
    Friend WithEvents DetectButton As Button
End Class
