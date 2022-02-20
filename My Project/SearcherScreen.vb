Namespace My

    Public Class SearcherScreen

        Public Sub Bigest(Form As SearcherOfOsu)

            Dim ScreenWidth = Screen.PrimaryScreen.Bounds.Width
            Dim ScreenHeight = Screen.PrimaryScreen.Bounds.Height
            Form.ClientSize = New Size(ScreenWidth, ScreenHeight)

        End Sub

    End Class

End Namespace
