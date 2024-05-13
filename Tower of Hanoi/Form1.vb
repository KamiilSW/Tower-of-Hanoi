Imports System.Runtime.InteropServices 'Need to import...

Public Class Form1

    <DllImport("user32.dll", CharSet:=CharSet.Auto, ExactSpelling:=True)> Public Shared Function GetAsyncKeyState(ByVal vkey As Long) As Long
    End Function

    Public Shared Function LeftMouseIsDown() As Boolean
        Return GetAsyncKeyState(Keys.LButton) > 0 And &H8000
    End Function

    Dim x As Integer
    Dim y As Integer
    Private Sub PictureBox14_MouseDown(sender As Object, e As EventArgs) Handles PictureBox14.MouseDown
        Dim MouseIsDown As Boolean = True
        Do
            x = MousePosition.X - 230
            y = MousePosition.Y - 240
            PictureBox14.Location = New Point(x, y)
            LeftMouseIsDown()

        Loop Until LeftMouseIsDown() = False

        PictureBox14.Location = New Point(x, y)
        Tower2()
        Exit Sub

    End Sub

    Function Tower2() As Boolean
        If (PictureBox14.Location.X > 534 And PictureBox14.Location.X < 880) Or (PictureBox14.Location.Y < 734 And PictureBox14.Location.Y > 376) Then
            PictureBox14.Location = New Point(648, 683)
            Return True
        Else
            PictureBox14.Location = New Point(197, 544)
            Return False
        End If
    End Function

End Class
