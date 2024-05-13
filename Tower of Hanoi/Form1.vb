Public Class Form1
    Dim MouseIsDown As Boolean = False
    Dim x As Integer
    Dim y As Integer
    Private Sub PictureBox14_MouseDown(sender As Object, e As EventArgs) Handles PictureBox14.MouseDown
        MouseIsDown = True
        Do
            x = MousePosition.X - 205
            y = MousePosition.Y - 230
            PictureBox14.Location = New Point(x, y)
            IsMouseDown()
        Loop Until MouseIsDown = False
    End Sub
    Function IsMouseDown() As Boolean
        If MouseButtons.Left = False Then
            MouseIsDown = False
            Return False
        Else
            MouseIsDown = True
            Return True
        End If
    End Function
End Class
