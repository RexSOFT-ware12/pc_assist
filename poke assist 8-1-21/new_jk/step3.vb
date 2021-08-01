Public Class step3
    Private Sub step3_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub step3_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Dim myGrahics = Me.CreateGraphics

        'creating objects with the pen class
        Dim ourPen1 As Pen
        Dim ourPen2 As Pen

        ourPen1 = New Pen(Brushes.White, 80)
        ourPen2 = New Pen(Brushes.Red, 50)



        myGrahics.DrawRectangle(ourPen1, New Rectangle(New Point(531, 200), New Size(10, 170)))

        myGrahics.DrawRectangle(ourPen2, New Rectangle(New Point(607, 290), New Size(80, 5)))




    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub step3_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim myGrahics = Me.CreateGraphics

        'creating objects with the pen class
        Dim ourPen1 As Pen
        Dim ourPen2 As Pen

        ourPen1 = New Pen(Brushes.White, 80)
        ourPen2 = New Pen(Brushes.Red, 50)




        myGrahics.DrawRectangle(ourPen1, New Rectangle(New Point(531, 200), New Size(10, 170)))

        myGrahics.DrawRectangle(ourPen2, New Rectangle(New Point(607, 290), New Size(80, 5)))




    End Sub
End Class