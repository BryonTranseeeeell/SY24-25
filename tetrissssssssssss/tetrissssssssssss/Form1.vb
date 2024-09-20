Imports System.Security.Cryptography

Public Class form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        follow(enemy, 10)
    End Sub

    Sub follow(e As PictureBox, s As Integer)
        If enemy.Location.Y > avatar.Location.Y Then
            move(enemy, 0, -5)
        Else
            move(enemy, 0, 5)
        End If
        If enemy.Location.X > avatar.Location.X Then
            move(enemy, -5, 0)
        Else
            move(enemy, 5, 0)
        End If
        If enemy.Location.Y > avatar.Location.Y Then
            move(enemy2, 0, -5)
        Else
            move(enemy2, 0, 5)
        End If
        If enemy.Location.X > avatar.Location.X Then
            move(enemy2, -5, 0)
        Else
            move(enemy2, 5, 0)
        End If
    End Sub


    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.A Then
            move(avatar, -15, 0)
        End If
        If e.KeyCode = Keys.Right Or e.KeyCode = Keys.D Then
            move(avatar, 15, 0)
        End If
        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.S Then
            move(avatar, 0, 15)
        End If
        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.W Then
            move(avatar, 0, -15)
        End If
        If e.KeyCode = Keys.Space Then
            avatar.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        End If
        avatar.Refresh()

    End Sub
    Sub move(p As PictureBox, xdir As Integer, ydir As Integer)
        p.Location += New Point(xdir, ydir)

    End Sub
End Class
