Option Strict On

Public Class Form1

    Private Sub btnFirstName_Click(sender As System.Object, e As System.EventArgs) Handles btnFirstName.Click, MyBase.Click
        Dim FullName As String
        'Read the input from the user
        FullName = txtFullName.Text

        'Trim the input so as to remove leading spaces
        Dim fullnameTrimmed As String
        fullnameTrimmed = FullName.Trim()

        'Find the index of first space
        Dim idxSpace As Integer
        idxSpace = FullName.IndexOf(" ")

        'Extract the first name
        Dim firstname As String
        firstname = FullName.Substring(0, idxSpace)

        'Display the result to the user
        txtFirstName.Text = firstname


    End Sub
End Class
