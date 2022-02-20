<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DownloadOsuForm
    Inherits System.Windows.Forms.Form

    'UserControl 覆寫 Dispose 以清除元件清單。
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
        Me.OsuDownloadProgressBar = New System.Windows.Forms.ProgressBar()
        Me.OsuDownloadLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OsuDownloadProgressBar
        '
        Me.OsuDownloadProgressBar.Location = New System.Drawing.Point(73, 262)
        Me.OsuDownloadProgressBar.Margin = New System.Windows.Forms.Padding(4)
        Me.OsuDownloadProgressBar.Name = "OsuDownloadProgressBar"
        Me.OsuDownloadProgressBar.Size = New System.Drawing.Size(342, 38)
        Me.OsuDownloadProgressBar.TabIndex = 0
        '
        'OsuDownloadLabel
        '
        Me.OsuDownloadLabel.AutoSize = True
        Me.OsuDownloadLabel.Font = New System.Drawing.Font("新細明體", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.OsuDownloadLabel.Location = New System.Drawing.Point(133, 190)
        Me.OsuDownloadLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.OsuDownloadLabel.Name = "OsuDownloadLabel"
        Me.OsuDownloadLabel.Size = New System.Drawing.Size(224, 28)
        Me.OsuDownloadLabel.TabIndex = 1
        Me.OsuDownloadLabel.Text = "Osu Downloading..."
        '
        'DownloadOsuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 512)
        Me.Controls.Add(Me.OsuDownloadLabel)
        Me.Controls.Add(Me.OsuDownloadProgressBar)
        Me.Margin = New System.Windows.Forms.Padding(1, 4, 1, 4)
        Me.Name = "DownloadOsuForm"
        Me.Text = "Downloading Osu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OsuDownloadProgressBar As ProgressBar
    Friend WithEvents OsuDownloadLabel As Label
End Class
