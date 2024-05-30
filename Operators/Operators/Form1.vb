Public Class Form1
    Private Sub TableLayoutPanel2_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim numberOne As Integer
        Dim numberTwo As Integer

        'check if integer values were entered
        If Integer.TryParse(txtNumber1.Text, numberOne) AndAlso Integer.TryParse(txtNumber1.Text, numberTwo) Then
            If numberOne > 0 And numberTwo > 0 Then
                lblEvaluationText.Text += "Number One and Number Two are positive numbers" & vbCrLf
            End If

            If numberOne >= numberTwo Then
                lblEvaluationText.Text += "Number One is Greater Than Or Equal to Number Two" & vbCrLf
            End If

            If numberOne = numberTwo Then
                lblEvaluationText.Text += "The numbers are equal"
            End If
        Else
            lblEvaluationText.Text = "Invalid Text Entered!"
        End If
    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel1.Paint

    End Sub
End Class
