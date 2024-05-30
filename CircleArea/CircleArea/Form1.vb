Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim radius As Integer
        radius = Val(txtRadiusInput.Text)
        lblArea.Text = calculateArea(radius)

    End Sub

    Function calculateArea(radius As Integer)
        Const PI As Double = 3.14
        Return Math.Round(PI * radius * radius, 2)
    End Function
End Class
