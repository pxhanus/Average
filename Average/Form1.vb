'Patricia Hanus
'151009
'Average
'_________________________________________________________________
Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim num As Integer = Val(Me.txtNum.Text)
        Dim addNums As Integer
        Dim average As Double

        For count As Integer = 1 To num
            addNums += count
        Next

        average = addNums / num

        Me.lblAns.Text = "The average of the numbers from 1 to " & num & " is " & average
    End Sub
End Class
