Imports Microsoft.Office.Interop


Public Class Form1



    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Label2.Text = "oubnoi"
        txtlp.Text = "1"

        Dim s As Slot1 = New Slot1()
        Panel4.Controls.Clear()
        s.TopLevel = False
        s.Size = Panel3.Size
        s.Dock = DockStyle.Fill
        Panel4.Controls.Add(s)
        s.Show()
        btnPre.Visible = True
        btnPre.Enabled = False

        'set the enabled property to true
        btnNext.Visible = True
        Button2.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim s As selection = New selection()
        Panel4.Controls.Clear()
        s.TopLevel = False
        s.Size = Panel3.Size
        s.Dock = DockStyle.Fill
        Panel4.Controls.Add(s)
        s.Show()
        Label2.Text = ""
        btnPre.Visible = False

        'set the enabled property to true
        btnNext.Visible = False
        Button2.Enabled = True

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click



        'set the visible property to true  
        Label2.Visible = True

        'clears the text value form the TextBox 
        txtlp.Clear()

        'convert the daatatype of the TextBox which is a string to double
        Dim counting As Double = Val(txtlp.Text)

        counting += 1

        'assigning the value of counting to txtlp 
        txtlp.Text = counting

        'set the enabled property to true
        btnNext.Enabled = True

        'set the enabled property to true
        btnNext.Visible = True

        'set the enabled property to true
        btnPre.Visible = True

        btnPre.Enabled = False

        'check the condition if the value of the control(txtlp.Text) is greater than 0
        If txtlp.Text > 0 Then
            Button2.Enabled = False
        End If

        'this section loads the Startpanel form into the Panel4 control
        Dim s As Slot1 = New Slot1()
        Panel4.Controls.Clear()
        Label2.Text = exWS.Cells(17, 2).value.ToString
        s.TopLevel = False
        s.Size = Panel3.Size
        s.Dock = DockStyle.Fill
        Panel4.Controls.Add(s)
        s.Show()

    End Sub

    Dim xlApp As Excel.Application = New Excel.Application()
    Dim exWB As Excel.Workbook = xlApp.Workbooks.Open("C:\Users\Roland\Downloads\poke assist 8-1-21\build.xlsx")

    Dim exWS As Excel.Worksheet = exWB.ActiveSheet



    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Dim instan() As Process = Process.GetProcessesByName("EXCEL.EXE")
        For Each inst As System.Diagnostics.Process In instan
            inst.Kill()
        Next

        Dim cur As Cursor = Cursors.WaitCursor
        Me.Cursor = cur
        'set the enabled property of the control to true
        '  btnPre.Enabled = True

        'convert the daatatype of the TextBox which is a string to double
        Dim counting As Double = Val(txtlp.Text)

        'increasing the value of the txtlp by 1 which will be used to loop through the forms
        counting += 1

        'assigning the value of counting to txtlp 
        txtlp.Text = counting

        'check if the value txtlp control is equal to 2. if through then it loads the step2 form

        btnPre.Enabled = True

        If txtlp.Text = 2 Then
            Panel4.Controls.Clear()

            Label2.Text = exWS.Cells(16, 2).value.ToString

            Dim ses As Slot1 = New Slot1()
            ses.TopLevel = False
            ses.Dock = DockStyle.Fill
            Panel4.Controls.Add(ses)
            ses.Show()




            Dim instances() As Process = Process.GetProcessesByName("EXCEL.EXE")
            For Each instance As System.Diagnostics.Process In instances
                instance.Kill()
            Next


            Dim cu As Cursor = Cursors.Hand
            Me.Cursor = cu

            btnPre.Enabled = True

        End If


        If txtlp.Text = 3 Then
            Panel4.Controls.Clear()

            Label2.Text = exWS.Cells(17, 2).value.ToString

            Dim ses As Slot1 = New Slot1()
            ses.TopLevel = False
            ses.Dock = DockStyle.Fill
            Panel4.Controls.Add(ses)
            ses.Show()


            ses.Label1.Visible = True


            Dim instances() As Process = Process.GetProcessesByName("Excel.EXE")
            For Each instance As System.Diagnostics.Process In instances
                instance.Kill()
            Next

            Dim cu As Cursor = Cursors.Hand
            Me.Cursor = cu

        End If

        If txtlp.Text = 4 Then
            Panel4.Controls.Clear()

            Label2.Text = exWS.Cells(18, 2).value.ToString

            Dim ses As Slot1 = New Slot1()
            ses.TopLevel = False
            ses.Dock = DockStyle.Fill
            Panel4.Controls.Add(ses)
            ses.Show()



            Dim instances() As Process = Process.GetProcessesByName("Excel.EXE")
            For Each instance As System.Diagnostics.Process In instances
                instance.Kill()
            Next

            Dim cu As Cursor = Cursors.Hand
            Me.Cursor = cu

        End If

        If txtlp.Text = 5 Then
            Panel4.Controls.Clear()

            Label2.Text = exWS.Cells(19, 2).value.ToString

            Dim ses As Slot1 = New Slot1()
            ses.TopLevel = False
            ses.Dock = DockStyle.Fill
            Panel4.Controls.Add(ses)
            ses.Show()



            Dim instances() As Process = Process.GetProcessesByName("EXCEL.EXE")
            For Each instance As System.Diagnostics.Process In instances
                instance.Kill()
            Next

            Dim cu As Cursor = Cursors.Hand
            Me.Cursor = cu

        End If

        If txtlp.Text = 6 Then
            Panel4.Controls.Clear()

            Label2.Text = exWS.Cells(20, 2).value.ToString


            Dim ses As Slot1 = New Slot1()
            ses.TopLevel = False
            ses.Dock = DockStyle.Fill
            Panel4.Controls.Add(ses)
            ses.Show()

            ses.Label1.Visible = True


            Dim instances() As Process = Process.GetProcessesByName("EXCEL.EXE")
            For Each instance As System.Diagnostics.Process In instances
                instance.Kill()
            Next

            Dim cu As Cursor = Cursors.Hand
            Me.Cursor = cu

        End If

        If txtlp.Text = 7 Then
            Panel4.Controls.Clear()

            Label2.Text = exWS.Cells(21, 2).value.ToString

            Dim ses As Slot1 = New Slot1()
            ses.TopLevel = False
            ses.Dock = DockStyle.Fill
            Panel4.Controls.Add(ses)
            ses.Show()



            Dim instances() As Process = Process.GetProcessesByName("EXCEL.EXE")
            For Each instance As System.Diagnostics.Process In instances
                instance.Kill()
            Next

            Dim cu As Cursor = Cursors.Hand
            Me.Cursor = cu

        End If

        If txtlp.Text = 8 Then
            Panel4.Controls.Clear()

            Label2.Text = exWS.Cells(22, 2).value.ToString

            Dim ses As Slot1 = New Slot1()
            ses.TopLevel = False
            ses.Dock = DockStyle.Fill
            Panel4.Controls.Add(ses)
            ses.Show()



            Dim instances() As Process = Process.GetProcessesByName("EXCEL.EXE")
            For Each instance As System.Diagnostics.Process In instances
                instance.Kill()
            Next

            Dim cu As Cursor = Cursors.Hand
            Me.Cursor = cu

        End If

        If txtlp.Text = 9 Then
            Panel4.Controls.Clear()

            Label2.Text = exWS.Cells(23, 2).value.ToString

            Dim ses As Slot1 = New Slot1()
            ses.TopLevel = False
            ses.Dock = DockStyle.Fill
            Panel4.Controls.Add(ses)
            ses.Show()




            Dim instances() As Process = Process.GetProcessesByName("EXCEL.EXE")
            For Each instance As System.Diagnostics.Process In instances
                instance.Kill()
            Next

            Dim cu As Cursor = Cursors.Hand
            Me.Cursor = cu

        End If

        If txtlp.Text = 10 Then
            Panel4.Controls.Clear()

            Label2.Text = ""

            Dim ses As Slot2 = New Slot2()
            ses.TopLevel = False
            ses.Dock = DockStyle.Fill
            Panel4.Controls.Add(ses)
            ses.Show()

            Dim instances() As Process = Process.GetProcessesByName("EXCEL.EXE")
            For Each instance As System.Diagnostics.Process In instances
                instance.Kill()
            Next

            btnPre.Enabled = True
            btnNext.Enabled = False

            Dim cu As Cursor = Cursors.Hand
            Me.Cursor = cu

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtlp_TextChanged(sender As Object, e As EventArgs) Handles txtlp.TextChanged

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub btnPre_Click(sender As Object, e As EventArgs) Handles btnPre.Click

        Dim instan() As Process = Process.GetProcessesByName("EXCEL.EXE")
        For Each inst As System.Diagnostics.Process In instan
            inst.Kill()
        Next


        Dim cur As Cursor = Cursors.WaitCursor
        Me.Cursor = cur
        'convert the daatatype of the TextBox which is a string to double
        Dim counting As Double = Val(txtlp.Text)

        'increasing the value of the txtlp by 1 which will be used to loop through the forms
        counting -= 1

        'assigning the value of counting to txtlp 
        txtlp.Text = counting

        btnNext.Enabled = True

        If txtlp.Text = 9 Then
            Panel4.Controls.Clear()
            Label2.Text = exWS.Cells(23, 2).value.ToString
            Dim ses As Slot1 = New Slot1()
            ses.TopLevel = False
            ses.Dock = DockStyle.Fill
            Panel4.Controls.Add(ses)
            ses.Show()



            Dim instances() As Process = Process.GetProcessesByName("EXCEL.EXE")
            For Each instance As System.Diagnostics.Process In instances
                instance.Kill()
            Next

            Dim cu As Cursor = Cursors.Hand
            Me.Cursor = cu

        End If

        If txtlp.Text = 8 Then
            Panel4.Controls.Clear()
            Label2.Text = exWS.Cells(23, 2).value.ToString
            Dim ses As Slot1 = New Slot1()
            ses.TopLevel = False
            ses.Dock = DockStyle.Fill
            Panel4.Controls.Add(ses)
            ses.Show()




            Dim instances() As Process = Process.GetProcessesByName("EXCEL.EXE")
            For Each instance As System.Diagnostics.Process In instances
                instance.Kill()
            Next

            Dim cu As Cursor = Cursors.Hand
            Me.Cursor = cu

        End If

        If txtlp.Text = 7 Then
            Panel4.Controls.Clear()
            Label2.Text = exWS.Cells(22, 2).value.ToString
            Dim ses As Slot1 = New Slot1()
            ses.TopLevel = False
            ses.Dock = DockStyle.Fill
            Panel4.Controls.Add(ses)
            ses.Show()




            Dim instances() As Process = Process.GetProcessesByName("EXCEL.EXE")
            For Each instance As System.Diagnostics.Process In instances
                instance.Kill()
            Next

            Dim cu As Cursor = Cursors.Hand
            Me.Cursor = cu

        End If

        If txtlp.Text = 6 Then
            Panel4.Controls.Clear()
            Label2.Text = exWS.Cells(21, 2).value.ToString
            Dim ses As Slot1 = New Slot1()
            ses.TopLevel = False
            ses.Dock = DockStyle.Fill
            Panel4.Controls.Add(ses)
            ses.Show()



            Dim instances() As Process = Process.GetProcessesByName("EXCEL.EXE")
            For Each instance As System.Diagnostics.Process In instances
                instance.Kill()
            Next

            Dim cu As Cursor = Cursors.Hand
            Me.Cursor = cu

        End If

        If txtlp.Text = 5 Then
            Panel4.Controls.Clear()
            Label2.Text = exWS.Cells(20, 2).value.ToString
            Dim ses As Slot1 = New Slot1()
            ses.TopLevel = False
            ses.Dock = DockStyle.Fill
            Panel4.Controls.Add(ses)
            ses.Show()




            Dim instances() As Process = Process.GetProcessesByName("EXCEL.EXE")
            For Each instance As System.Diagnostics.Process In instances
                instance.Kill()
            Next

            Dim cu As Cursor = Cursors.Hand
            Me.Cursor = cu

        End If

        If txtlp.Text = 4 Then
            Panel4.Controls.Clear()
            Label2.Text = exWS.Cells(19, 2).value.ToString
            Dim ses As Slot1 = New Slot1()
            ses.TopLevel = False
            ses.Dock = DockStyle.Fill
            Panel4.Controls.Add(ses)
            ses.Show()




            Dim instances() As Process = Process.GetProcessesByName("EXCEL.EXE")
            For Each instance As System.Diagnostics.Process In instances
                instance.Kill()
            Next

            Dim cu As Cursor = Cursors.Hand
            Me.Cursor = cu

        End If

        If txtlp.Text = 3 Then
            Panel4.Controls.Clear()
            Label2.Text = exWS.Cells(18, 2).value.ToString
            Dim ses As Slot1 = New Slot1()
            ses.TopLevel = False
            ses.Dock = DockStyle.Fill
            Panel4.Controls.Add(ses)
            ses.Show()



            Dim instances() As Process = Process.GetProcessesByName("EXCEL.EXE")
            For Each instance As System.Diagnostics.Process In instances
                instance.Kill()
            Next

            Dim cu As Cursor = Cursors.Hand
            Me.Cursor = cu

        End If

        If txtlp.Text = 2 Then
            Panel4.Controls.Clear()
            Label2.Text = exWS.Cells(17, 2).value.ToString
            Dim ses As Slot1 = New Slot1()
            ses.TopLevel = False
            ses.Dock = DockStyle.Fill
            Panel4.Controls.Add(ses)
            ses.Show()


            ses.Label1.Visible = True

            Dim instances() As Process = Process.GetProcessesByName("EXCEL.EXE")
            For Each instance As System.Diagnostics.Process In instances
                instance.Kill()
            Next

            Dim cu As Cursor = Cursors.Hand
            Me.Cursor = cu

            btnPre.Enabled = False

        End If
    End Sub

    Private Sub Form1_Closing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim instan() As Process = Process.GetProcessesByName("EXCEL.EXE")
        For Each instanc As System.Diagnostics.Process In instan
            instanc.Kill()
        Next

        If MessageBox.Show(" Are you sure you want to quit", "Are you sure?", MessageBoxButtons.YesNoCancel) <> DialogResult.Yes Then
            e.Cancel = True
            Dim instances() As Process = Process.GetProcessesByName("build.EXE")
            For Each instance As System.Diagnostics.Process In instances
                instance.Kill()
            Next


            xlApp.Quit()
            exWB.Close()


            System.Runtime.InteropServices.Marshal.ReleaseComObject(exWB)
            System.Runtime.InteropServices.Marshal.FinalReleaseComObject(xlApp)

            System.Runtime.InteropServices.Marshal.CleanupUnusedObjectsInCurrentContext()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
