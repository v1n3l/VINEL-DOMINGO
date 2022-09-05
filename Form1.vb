Imports System.Data
Imports System.Net
Imports Npgsql
Public Class Form1
    Dim lv As ListViewItem
    Dim selected As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openCon()
    End Sub
    Private Sub PoplistView()
        ListView1.Clear()

        With ListView1
            .View = View.Details
            .GridLines = True
            .Columns.Add("ID", 40)
            .Columns.Add("Last Name", 110)
            .Columns.Add("Fist name", 110)
            .Columns.Add("Middle name", 110)
            .Columns.Add("Address", 150)
            .Columns.Add("Gender", 110)
            .Columns.Add("Contact no", 110)
            .Columns.Add("Course", 110)
        End With
    End Sub
End Class
