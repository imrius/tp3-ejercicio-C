Public Class Form1
    Dim suma As Integer = 0
    Dim mayor As Integer = Integer.MinValue
    Dim menor As Integer = Integer.MaxValue
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num As Integer
        If Integer.TryParse(TextBox1.Text, num) Then
            If num = -999 Then
                TextBox1.Enabled = False
                Button1.Enabled = False
            Else
                suma = suma + num
                If num > mayor Then
                    mayor = num
                End If
                If num < menor Then
                    menor = num
                End If
            End If
        End If
        TextBox1.Clear()
        TextBox1.Focus()
    End Sub

End Class
