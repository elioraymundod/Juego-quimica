Public Class Instrucciones
    Public Usuario As String
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click



        Usuario = user.Text

        If Usuario = "" Or Usuario = " " Or Usuario = "  " Or Usuario = "   " Or Usuario = "    " Then
            MsgBox("Usuario vacio, por favor ingresa un usuario.")
        Else
            Me.Hide()
            Inicio.Show()

        End If

    End Sub
End Class