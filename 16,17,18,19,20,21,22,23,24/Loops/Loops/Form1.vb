Public Class Form1
    Private Sub btnForNextLoop_Click(sender As Object, e As EventArgs) Handles btnForNextLoop.Click
        'Clear the list
        ClearList()
        For intOuterLoop As Integer = 1 To 7
            'Process a nested (inner) loop
            For intInnerLoop As Integer = 1 To 3
                lstData.Items.Add(intOuterLoop.ToString &
                ", " & intInnerLoop.ToString)
            Next
        Next

    End Sub

    Private Sub ClearList()
        'Clear the list
        lstData.Items.Clear()
    End Sub

    Private Sub btnDOloop_Click(sender As Object, e As EventArgs) Handles btnDOloop.Click
        'Declare variables
        Dim objRandom As New Random
        Dim intRandomNumber As Integer = 0
        'Clear the list
        ClearList()
        'Process the loop while intRandomNumber < 15
        Do While intRandomNumber < 15
            'Get a random number between 0 and 24
            intRandomNumber = objRandom.Next(25)
            'Add the number to the list
            lstData.Items.Add(intRandomNumber.ToString)
        Loop


    End Sub
End Class
