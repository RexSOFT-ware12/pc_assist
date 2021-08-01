Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop
Public Class Slot1


    Private Sub Slot1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim xlApp As Excel.Application = New Excel.Application()
        Dim exWB As Excel.Workbook = xlApp.Workbooks.Open("C:\Users\Roland\Downloads\poke assist 8-1-21\build.xlsx")

        Dim exWS As Excel.Worksheet = exWB.ActiveSheet

        Label1.Text = exWS.Cells(18, 5).value.ToString


        Dim allColors As Color = Color.FromName(Label1.Text)
        Label1.BackColor = allColors
    End Sub
End Class
