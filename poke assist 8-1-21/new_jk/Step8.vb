Public Class Step8
    Private Sub Step8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Step8_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'assign the createGraphics function to the graphics variable
        Dim myGrahics = Me.CreateGraphics

        'creating objects with the pen class
        Dim ourPen1 As Pen
        Dim ourPen2 As Pen
        Dim ourPen3 As Pen

        ourPen1 = New Pen(Brushes.White, 80)
        ourPen2 = New Pen(Brushes.Red, 50)
        ourPen3 = New Pen(Brushes.Black, 50)


        'using myGraphics variable to draw a rectangle with x and y cordinates

        myGrahics.DrawRectangle(ourPen1, New Rectangle(New Point(531, 200), New Size(10, 170)))


        myGrahics.DrawRectangle(ourPen3, New Rectangle(New Point(604, 220), New Size(110, 3)))

        myGrahics.DrawRectangle(ourPen2, New Rectangle(New Point(604, 320), New Size(110, 3)))





    End Sub

    Private Sub Step8_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint

        'assign the createGraphics function to the graphics variable
        Dim myGrahics = Me.CreateGraphics

        'creating objects with the pen class
        Dim ourPen1 As Pen
        Dim ourPen2 As Pen
        Dim ourPen3 As Pen

        ourPen1 = New Pen(Brushes.White, 80)
        ourPen2 = New Pen(Brushes.Red, 50)
        ourPen3 = New Pen(Brushes.Black, 50)


        'using myGraphics variable to draw a rectangle with x and y cordinates

        myGrahics.DrawRectangle(ourPen1, New Rectangle(New Point(531, 200), New Size(10, 170)))


        myGrahics.DrawRectangle(ourPen3, New Rectangle(New Point(604, 220), New Size(110, 3)))

        myGrahics.DrawRectangle(ourPen2, New Rectangle(New Point(604, 320), New Size(110, 3)))



        ' myGrahics.DrawRectangle(ourPen1, New Rectangle(New Point(456, 90), New Size(10, 120)))


        'grid lines 

        'first horizontal line
        'myGrahics.DrawLine(New Pen(Color.Gray, 2), New Point(660, 205), New Point(997, 203))

        ''second horixaontal line
        'myGrahics.DrawLine(New Pen(Color.Gray, 2), New Point(660, 321), New Point(997, 321))


        ''thrid horizontal
        'myGrahics.DrawLine(New Pen(Color.Gray, 2), New Point(660, 456), New Point(997, 456))

        ''first vertical line
        'myGrahics.DrawLine(New Pen(Color.Gray, 2), New Point(660, 205), New Point(660, 456))

        ''second vertical line
        'myGrahics.DrawLine(New Pen(Color.Gray, 2), New Point(890, 203), New Point(890, 456))

        ''third vertical line
        'myGrahics.DrawLine(New Pen(Color.Gray, 2), New Point(997, 203), New Point(997, 456))

        ''fourth vertical line
        'myGrahics.DrawLine(New Pen(Color.Gray, 2), New Point(775, 203), New Point(775, 456))

    End Sub
End Class