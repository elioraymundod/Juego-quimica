Public Class gracias_por_participar
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Inicio.Show()
        Me.Hide()

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs)
        Dim Ahorcado As New Ahorcado
        Ahorcado.Show()
        Me.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()
    End Sub

    Private Sub gracias_por_participar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class