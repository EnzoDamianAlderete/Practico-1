Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Obtener el contenido de los dos TextBox
        Dim texto1 As String = TextBox1.Text
        Dim texto2 As String = TextBox3.Text

        ' Concatenar los textos
        Dim resultado As String = texto1 & " " & texto2

        ' Mostrar el resultado en el tercer TextBox
        TextBox2.Text = resultado
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox2.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        End
    End Sub
End Class
