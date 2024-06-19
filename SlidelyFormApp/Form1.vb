Public Class Form1
    Public Sub New()
        InitializeComponent()
        Me.KeyPreview = True
    End Sub

    Private Sub Form1_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles MyBase.PreviewKeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            ButtonViewSubmissions.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            ButtonNewSubmissions.PerformClick()
        End If
    End Sub
End Class
