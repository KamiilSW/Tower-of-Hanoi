Imports System.Runtime.InteropServices

Public Class Form1

    <DllImport("user32.dll", CharSet:=CharSet.Auto, ExactSpelling:=True)> Public Shared Function GetAsyncKeyState(ByVal vkey As Long) As Long
    End Function

    Public Shared Function LeftMouseIsDown() As Boolean
        Return GetAsyncKeyState(Keys.LButton) > 0 And &H8000
    End Function

    Dim x As Integer
    Dim y As Integer
    Private Sub PictureBox14_MouseDown(sender As Object, e As EventArgs)
        Do
            x = MousePosition.X - 230
            y = MousePosition.Y - 240
            PictureBox14.Location = New Point(x, y)
            LeftMouseIsDown()

        Loop Until LeftMouseIsDown() = False

        PictureBox14.Location = New Point(x, y) 'Moves PictureBox to base of Tower 2

        Tower2()
        Exit Sub

    End Sub
    Dim ArrayTower1() As String
    Dim ArrayTower2() As String
    Dim ArrayTower3() As String

    Function Tower1Array() As String
        For i = 1 To 8
            If i = 1 And PictureBox14.Location.Y = 725 Then
                ArrayTower1(i) = "814"
            ElseIf i = 1 And PictureBox14.Location.Y = 752 Then
                ArrayTower1(i) = "714"

            ElseIf i = 1 And PictureBox14.Location.Y = 779 Then
                ArrayTower1(i) = "614"

            ElseIf i = 1 And PictureBox14.Location.Y = 806 Then
                ArrayTower1(i) = "514"

            ElseIf i = 1 And PictureBox14.Location.Y = 833 Then
                ArrayTower1(i) = "414"

            ElseIf i = 1 And PictureBox14.Location.Y = 860 Then
                ArrayTower1(i) = "314"

            ElseIf i = 1 And PictureBox14.Location.Y = 887 Then
                ArrayTower1(i) = "214"

            ElseIf i = 1 And PictureBox14.Location.Y = 914 Then
                ArrayTower1(i) = "114"

            ElseIf i = 2 And PictureBox13.Location.Y = 725 Then
                ArrayTower1(i) = "813"

            ElseIf i = 2 And PictureBox13.Location.Y = 752 Then
                ArrayTower1(i) = "713"

            ElseIf i = 2 And PictureBox13.Location.Y = 779 Then
                ArrayTower1(i) = "613"

            ElseIf i = 2 And PictureBox13.Location.Y = 806 Then
                ArrayTower1(i) = "513"

            ElseIf i = 2 And PictureBox13.Location.Y = 833 Then
                ArrayTower1(i) = "413"

            ElseIf i = 2 And PictureBox13.Location.Y = 860 Then
                ArrayTower1(i) = "313"

            ElseIf i = 2 And PictureBox13.Location.Y = 887 Then
                ArrayTower1(i) = "213"

            ElseIf i = 2 And PictureBox13.Location.Y = 914 Then
                ArrayTower1(i) = "113"

            ElseIf i = 3 And PictureBox12.Location.Y = 725 Then
                ArrayTower1(i) = "812"

            ElseIf i = 3 And PictureBox12.Location.Y = 752 Then
                ArrayTower1(i) = "712"

            ElseIf i = 3 And PictureBox12.Location.Y = 779 Then
                ArrayTower1(i) = "612"

            ElseIf i = 3 And PictureBox12.Location.Y = 806 Then
                ArrayTower1(i) = "512"

            ElseIf i = 3 And PictureBox12.Location.Y = 833 Then
                ArrayTower1(i) = "412"

            ElseIf i = 3 And PictureBox12.Location.Y = 860 Then
                ArrayTower1(i) = "312"

            ElseIf i = 3 And PictureBox12.Location.Y = 887 Then
                ArrayTower1(i) = "212"

            ElseIf i = 3 And PictureBox12.Location.Y = 914 Then
                ArrayTower1(i) = "112"

            ElseIf i = 4 And PictureBox11.Location.Y = 725 Then
                ArrayTower1(i) = "811"

            ElseIf i = 4 And PictureBox11.Location.Y = 752 Then
                ArrayTower1(i) = "711"

            ElseIf i = 4 And PictureBox11.Location.Y = 779 Then
                ArrayTower1(i) = "611"

            ElseIf i = 4 And PictureBox11.Location.Y = 806 Then
                ArrayTower1(i) = "511"

            ElseIf i = 4 And PictureBox11.Location.Y = 833 Then
                ArrayTower1(i) = "411"

            ElseIf i = 4 And PictureBox11.Location.Y = 860 Then
                ArrayTower1(i) = "311"

            ElseIf i = 4 And PictureBox11.Location.Y = 887 Then
                ArrayTower1(i) = "211"

            ElseIf i = 4 And PictureBox11.Location.Y = 914 Then
                ArrayTower1(i) = "111"

            ElseIf i = 5 And PictureBox10.Location.Y = 725 Then
                ArrayTower1(i) = "810"

            ElseIf i = 5 And PictureBox10.Location.Y = 752 Then
                ArrayTower1(i) = "710"

            ElseIf i = 5 And PictureBox10.Location.Y = 779 Then
                ArrayTower1(i) = "610"

            ElseIf i = 5 And PictureBox10.Location.Y = 806 Then
                ArrayTower1(i) = "510"

            ElseIf i = 5 And PictureBox10.Location.Y = 833 Then
                ArrayTower1(i) = "410"

            ElseIf i = 5 And PictureBox10.Location.Y = 860 Then
                ArrayTower1(i) = "310"

            ElseIf i = 5 And PictureBox10.Location.Y = 887 Then
                ArrayTower1(i) = "210"

            ElseIf i = 5 And PictureBox10.Location.Y = 914 Then
                ArrayTower1(i) = "110"

            ElseIf i = 6 And PictureBox9.Location.Y = 725 Then
                ArrayTower1(i) = "89"

            ElseIf i = 6 And PictureBox9.Location.Y = 752 Then
                ArrayTower1(i) = "79"

            ElseIf i = 6 And PictureBox9.Location.Y = 779 Then
                ArrayTower1(i) = "69"

            ElseIf i = 6 And PictureBox9.Location.Y = 806 Then
                ArrayTower1(i) = "59"

            ElseIf i = 6 And PictureBox9.Location.Y = 833 Then
                ArrayTower1(i) = "49"

            ElseIf i = 6 And PictureBox9.Location.Y = 860 Then
                ArrayTower1(i) = "39"

            ElseIf i = 6 And PictureBox9.Location.Y = 887 Then
                ArrayTower1(i) = "29"

            ElseIf i = 6 And PictureBox9.Location.Y = 914 Then
                ArrayTower1(i) = "19"

            ElseIf i = 7 And PictureBox8.Location.Y = 725 Then
                ArrayTower1(i) = "88"

            ElseIf i = 7 And PictureBox8.Location.Y = 752 Then
                ArrayTower1(i) = "78"

            ElseIf i = 7 And PictureBox8.Location.Y = 779 Then
                ArrayTower1(i) = "68"

            ElseIf i = 7 And PictureBox8.Location.Y = 806 Then
                ArrayTower1(i) = "58"

            ElseIf i = 7 And PictureBox8.Location.Y = 833 Then
                ArrayTower1(i) = "48"

            ElseIf i = 7 And PictureBox8.Location.Y = 860 Then
                ArrayTower1(i) = "38"

            ElseIf i = 7 And PictureBox8.Location.Y = 887 Then
                ArrayTower1(i) = "28"

            ElseIf i = 7 And PictureBox8.Location.Y = 914 Then
                ArrayTower1(i) = "18"
            End If

        Next
        Return True
    End Function
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
