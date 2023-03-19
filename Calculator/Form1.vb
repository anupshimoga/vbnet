Public Class Form1
    Dim firstNum, secondNum, resultNum As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtFirst.Text <> "" And txtSecond.Text <> "" Then
            firstNum = CDbl(txtFirst.Text)
            secondNum = CDbl(txtSecond.Text)
            resultNum = firstNum - secondNum
            txtOutput.Text = resultNum
        Else
            MessageBox.Show("Please enter the both numbers")
        End If

    End Sub

    Private Sub txtFirst_TextChanged(sender As Object, e As EventArgs) Handles txtFirst.TextChanged
        txtOutput.Clear()
    End Sub

    Private Sub txtSecond_TextChanged(sender As Object, e As EventArgs) Handles txtSecond.TextChanged
        txtOutput.Clear()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtFirst.Text <> "" And txtSecond.Text <> "" Then
            firstNum = CDbl(txtFirst.Text)
            secondNum = CDbl(txtSecond.Text)
            resultNum = firstNum + secondNum
            txtOutput.Text = resultNum
        Else
            MessageBox.Show("Please enter the both numbers")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If txtFirst.Text <> "" And txtSecond.Text <> "" Then
            firstNum = CDbl(txtFirst.Text)
            secondNum = CDbl(txtSecond.Text)
            resultNum = firstNum * secondNum
            txtOutput.Text = resultNum
        Else
            MessageBox.Show("Please enter the both numbers")
        End If
    End Sub
End Class
