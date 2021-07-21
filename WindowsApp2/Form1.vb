Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Try
            Dim i As Integer
            Dim resultValue As Integer
            i = 100

            resultValue = i / 0
            MessageBox.Show("The result is " & resultValue)
        Catch ex As Exception
            MessageBox.Show("Exception catch here ..")
        Finally
            MessageBox.Show("Finally block executed")

        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
