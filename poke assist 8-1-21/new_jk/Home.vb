Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim myGrahics = Me.CreateGraphics
        Dim ourPen1 As Pen
        Dim ourPen2 As Pen

        ourPen1 = New Pen(Brushes.DarkKhaki, 30)
        ourPen2 = New Pen(Brushes.Black, 30)



        myGrahics.DrawRectangle(ourPen1, New Rectangle(New Point(80, 90), New Size(10, 250)))

        myGrahics.DrawRectangle(ourPen2, New Rectangle(New Point(120, 150), New Size(100, 5)))


        myGrahics.DrawRectangle(ourPen1, New Rectangle(New Point(456, 67), New Size(10, 250)))
    End Sub

    Private Sub Home_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'Dim myGrahics = Me.CreateGraphics()

        ''first vertical line
        'myGrahics.DrawLine(New Pen(Color.Gray, 1), New Point(2, 230), New Point(830, 230))
        ''horizontal
        'myGrahics.DrawLine(New Pen(Color.Gray, 1), New Point(263, 9), New Point(263, 428))
        ''second horizontal line
        'myGrahics.DrawLine(New Pen(Color.Gray, 1), New Point(532, 9), New Point(532, 428))
        ''third vertical line
        'myGrahics.DrawLine(New Pen(Color.Gray, 1), New Point(830, 9), New Point(830, 428))


    End Sub
End Class