Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim score As Integer = txt1.Text
        Dim message As String

        Select Case score
            Case 80 To 100
                message = "Your grade is between 80-100 and your pointer in 4.00"

            Case 75 To 79
                message = "Your grade is between 79-75 and your pointer in 3.67"

            Case 70 To 74
                message = "Your grade is between 74-70 and your pointer in 3.33"

            Case 65 To 69
                message = "Your grade is between 69-65 and your pointer in 3.00"

            Case 60 To 64
                message = "Your grade is between 60-64 and your pointer in 2.67"

            Case 56 To 59
                message = "Your grade is between 59-55 and your pointer in 2.33"

            Case 50 To 54
                message = "Your grade is between 50-54 and your pointer in 2.00"

            Case 47 To 49
                message = "Your grade is between 47-49 and your pointer in 1.67"

            Case 44 To 46
                message = "Your grade is between 44-46 and your pointer in 1.33"

            Case 40 To 43
                message = "Your grade is between 40-43 and your pointer in 1.00"

            Case 30 To 39
                message = "Your grade is between 30-39 and your pointer in 0.67"

            Case 20 To 29
                message = "Your grade is between 20-29 and your pointer in 0.33"

            Case 0 To 19
                message = "Your grade is between 0-19 and your pointer in 0.67"


        End Select
        MessageBox.Show(message, "Your Grade & pointer", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
    End Sub
End Class
