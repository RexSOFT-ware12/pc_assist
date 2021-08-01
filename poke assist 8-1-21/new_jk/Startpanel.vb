Public Class Startpanel

    Private Sub Startpanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Startpanel_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        ''assign the createGraphics function to the graphics variable
        Dim myGrahics = Me.CreateGraphics

        ''creating objects with the pen class
        Dim ourPen1 As Pen
        Dim ourPen2 As Pen

        ourPen1 = New Pen(Brushes.White, 80)
        ourPen2 = New Pen(Brushes.Black, 50)


        'using myGraphics variable to draw a rectangle with x and y cordinates
        myGrahics.DrawRectangle(ourPen1, New Rectangle(New Point(531, 90), New Size(10, 170)))

        myGrahics.DrawRectangle(ourPen2, New Rectangle(New Point(607, 120), New Size(100, 5)))






        ''grid lines 

        ''first horizontal line
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

    Private Sub Startpanel_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        ''assign the createGraphics function to the graphics variable
        Dim myGrahics = Me.CreateGraphics

        ''creating objects with the pen class
        Dim ourPen1 As Pen
        Dim ourPen2 As Pen

        ourPen1 = New Pen(Brushes.White, 80)
        ourPen2 = New Pen(Brushes.Black, 50)


        'using myGraphics variable to draw a rectangle with x and y cordinates
        myGrahics.DrawRectangle(ourPen1, New Rectangle(New Point(531, 100), New Size(10, 170)))

        myGrahics.DrawRectangle(ourPen2, New Rectangle(New Point(607, 120), New Size(100, 5)))



        ''grid lines 

        ''first horizontal line
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

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim myDocs = My.Computer.FileSystem.SpecialDirectories.MyDocuments

        Dim dataDir = IO.Path.Combine(myDocs, "Data")


        If Not IO.Directory.Exists(dataDir) Then IO.Directory.CreateDirectory(dataDir)

        SaveFileDialog1.InitialDirectory = dataDir


        SaveFileDialog1.ShowDialog()

    End Sub
End Class