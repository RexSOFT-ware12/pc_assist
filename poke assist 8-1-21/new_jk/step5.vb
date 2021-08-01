Public Class step5
    Private Sub step6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      
    End Sub

    Private Sub step6_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
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


        myGrahics.DrawRectangle(ourPen3, New Rectangle(New Point(358, 220), New Size(110, 3)))

        myGrahics.DrawRectangle(ourPen2, New Rectangle(New Point(358, 320), New Size(110, 3)))







    End Sub

    Private Sub step6_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
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


        myGrahics.DrawRectangle(ourPen3, New Rectangle(New Point(358, 220), New Size(110, 3)))

        myGrahics.DrawRectangle(ourPen2, New Rectangle(New Point(358, 320), New Size(110, 3)))




    End Sub
End Class