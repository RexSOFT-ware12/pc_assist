Public Class step2
    Private Sub step2_Load(sender As Object, e As EventArgs) Handles MyBase.Load





    End Sub

    Private Sub step2_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        'assign the createGraphics function to the graphics variable
        Dim myGrahics = Me.CreateGraphics

        'creating objects with the pen class
        Dim ourPen1 As Pen
        Dim ourPen2 As Pen

        ourPen1 = New Pen(Brushes.White, 80)
        ourPen2 = New Pen(Brushes.Black, 50)


        'using myGraphics variable to draw a rectangle with x and y cordinates

        myGrahics.DrawRectangle(ourPen1, New Rectangle(New Point(531, 200), New Size(10, 170)))

        myGrahics.DrawRectangle(ourPen2, New Rectangle(New Point(365, 200), New Size(100, 5)))






    End Sub

    Private Sub step2_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        'assign the createGraphics function to the graphics variable
        Dim myGrahics = Me.CreateGraphics

        'creating objects with the pen class
        Dim ourPen1 As Pen
        Dim ourPen2 As Pen

        ourPen1 = New Pen(Brushes.White, 80)
        ourPen2 = New Pen(Brushes.Black, 50)


        'using myGraphics variable to draw a rectangle with x and y cordinates

        myGrahics.DrawRectangle(ourPen1, New Rectangle(New Point(531, 200), New Size(10, 170)))

        myGrahics.DrawRectangle(ourPen2, New Rectangle(New Point(365, 200), New Size(100, 5)))



    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub
End Class