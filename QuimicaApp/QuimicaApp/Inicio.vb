Imports System.Threading
Public Class Inicio

    Public numero, temp, correcto, incorrecto As Integer
    Dim posicionActual As Integer
    Dim listo As Boolean = False
    Dim extra As Boolean = False


    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnGenerar.Enabled = True
        nombre.Enabled = False
        nombre.Text = Instrucciones.Usuario

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Label24.Visible = False
        Randomize()
        numero = (9 * Rnd()) + 1
        Contador.Text = numero.ToString()
        temp = numero
        posicionActual += numero
        moverPlayer()

    End Sub



    Sub moverPlayer()
        btnGenerar.Enabled = False
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        validarVidas()

        If posicionActual = 1 Then
            Player.Left += 5
            If (Player.Left = 25) Then
                Timer1.Stop()
                generarDesafio()
            End If

        ElseIf posicionActual = 2 Then
            Player.Left += 25
            If (Player.Left >= 970) Then
                Timer1.Stop()
                generarDesafio()
            End If

        Else
            Player.Left += 50
            If (Player.Left > 1110) Then
                Timer1.Stop()
                Timer2.Start()

            End If
        End If


    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        validarVidas()

        If (posicionActual = 3) Then
            Player1.Left += 5
            If (Player1.Left = 25) Then
                Timer2.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 4 Then
            Player1.Left += 10
            If (Player1.Left >= 80) Then
                Timer2.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 5 Then
            Player1.Left += 20
            If (Player1.Left >= 700) Then
                Timer2.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 6 Then
            Player1.Left += 20
            If (Player1.Left >= 750) Then
                Timer2.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 7 Then
            Player1.Left += 20
            If (Player1.Left >= 800) Then
                Timer2.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 8 Then
            Player1.Left += 20
            If (Player1.Left >= 860) Then
                Timer2.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 9 Then
            Player1.Left += 20
            If (Player1.Left >= 920) Then
                Timer2.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 10 Then
            Player1.Left += 20
            If (Player1.Left >= 970) Then
                Timer2.Stop()
                generarDesafio()
            End If
        Else
            Player1.Left += 50
            If (Player1.Left > 1110) Then
                Timer2.Stop()
                Timer3.Start()

            End If
        End If


    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        validarVidas()

        If (posicionActual = 11) Then
            Player2.Left += 5
            If (Player2.Left = 25) Then
                Timer3.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 12 Then
            Player2.Left += 10
            If (Player2.Left >= 80) Then
                Timer3.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 13 Then
            Player2.Left += 20
            If (Player2.Left >= 700) Then
                Timer3.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 14 Then
            Player2.Left += 20
            If (Player2.Left >= 750) Then
                Timer3.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 15 Then
            Player2.Left += 20
            If (Player2.Left >= 800) Then
                Timer3.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 16 Then
            Player2.Left += 20
            If (Player2.Left >= 860) Then
                Timer3.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 17 Then
            Player2.Left += 20
            If (Player2.Left >= 920) Then
                Timer3.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 18 Then
            Player2.Left += 20
            If (Player2.Left >= 970) Then
                Timer3.Stop()
                generarDesafio()
            End If
        Else
            Player2.Left += 50
            If (Player2.Left > 1110) Then
                Timer3.Stop()
                Timer4.Start()

            End If
        End If

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        validarVidas()

        If (posicionActual = 19) Then
            Player3.Left += 5
            If (Player3.Left = 25) Then
                Timer4.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 20 Then
            Player3.Left += 20
            If (Player3.Left >= 80) Then
                Timer4.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 21 Then
            Player3.Left += 20
            If (Player3.Left >= 140) Then
                Timer4.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 22 Then
            Player3.Left += 20
            If (Player3.Left >= 195) Then
                Timer4.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 23 Then
            Player3.Left += 20
            If (Player3.Left >= 250) Then
                Timer4.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 24 Then
            Player3.Left += 20
            If (Player3.Left >= 305) Then
                Timer4.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 25 Then
            Player3.Left += 20
            If (Player3.Left >= 360) Then
                Timer4.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 26 Then
            Player3.Left += 20
            If (Player3.Left >= 415) Then
                Timer4.Stop()
                generarDesafio()
            End If
        ElseIf (posicionActual = 27) Then
            Player3.Left += 20
            If (Player3.Left >= 470) Then
                Timer4.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 28 Then
            Player3.Left += 20
            If (Player3.Left >= 525) Then
                Timer4.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 29 Then
            Player3.Left += 20
            If (Player3.Left >= 580) Then
                Timer4.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 30 Then
            Player3.Left += 20
            If (Player3.Left >= 635) Then
                Timer4.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 31 Then
            Player3.Left += 20
            If (Player3.Left >= 690) Then
                Timer4.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 32 Then
            Player3.Left += 20
            If (Player3.Left >= 745) Then
                Timer4.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 33 Then
            Player3.Left += 20
            If (Player3.Left >= 800) Then
                Timer4.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 34 Then
            Player3.Left += 20
            If (Player3.Left >= 855) Then
                Timer4.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 35 Then
            Player3.Left += 20
            If (Player3.Left >= 920) Then
                Timer4.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 36 Then
            Player3.Left += 20
            If (Player3.Left >= 970) Then
                Timer4.Stop()
                generarDesafio()
            End If
        Else
            Player3.Left += 50
            If (Player3.Left > 1110) Then
                Timer4.Stop()
                Timer5.Start()
            End If

        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        validarVidas()

        If (posicionActual = 37) Then
            Player4.Left += 5
            If (Player4.Left = 25) Then
                Timer5.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 38 Then
            Player4.Left += 20
            If (Player4.Left >= 80) Then
                Timer5.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 39 Then
            Player4.Left += 20
            If (Player4.Left >= 140) Then
                Timer5.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 40 Then
            Player4.Left += 20
            If (Player4.Left >= 195) Then
                Timer5.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 41 Then
            Player4.Left += 20
            If (Player4.Left >= 250) Then
                Timer5.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 42 Then
            Player4.Left += 20
            If (Player4.Left >= 305) Then
                Timer5.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 43 Then
            Player4.Left += 20
            If (Player4.Left >= 360) Then
                Timer5.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 44 Then
            Player4.Left += 20
            If (Player4.Left >= 415) Then
                Timer5.Stop()
                generarDesafio()
            End If
        ElseIf (posicionActual = 45) Then
            Player4.Left += 20
            If (Player4.Left >= 470) Then
                Timer5.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 46 Then
            Player4.Left += 20
            If (Player4.Left >= 525) Then
                Timer5.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 47 Then
            Player4.Left += 20
            If (Player4.Left >= 580) Then
                Timer5.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 48 Then
            Player4.Left += 20
            If (Player4.Left >= 635) Then
                Timer5.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 49 Then
            Player4.Left += 20
            If (Player4.Left >= 690) Then
                Timer5.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 50 Then
            Player4.Left += 20
            If (Player4.Left >= 745) Then
                Timer5.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 51 Then
            Player4.Left += 20
            If (Player4.Left >= 800) Then
                Timer5.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 52 Then
            Player4.Left += 20
            If (Player4.Left >= 855) Then
                Timer5.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 53 Then
            Player4.Left += 20
            If (Player4.Left >= 920) Then
                Timer5.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 54 Then
            Player4.Left += 20
            If (Player4.Left >= 970) Then
                Timer5.Stop()
                generarDesafio()
            End If
        Else
            Player4.Left += 50
            If (Player4.Left > 1110) Then
                Timer5.Stop()
                Timer6.Start()
            End If
        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        validarVidas()

        If (posicionActual = 55) Then
            Player5.Left += 5
            If (Player5.Left = 25) Then
                Timer6.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 56 Then
            Player5.Left += 20
            If (Player5.Left >= 80) Then
                Timer6.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 57 Then
            Player5.Left += 20
            If (Player5.Left >= 140) Then
                Timer6.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 58 Then
            Player5.Left += 20
            If (Player5.Left >= 195) Then
                Timer6.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 59 Then
            Player5.Left += 20
            If (Player5.Left >= 250) Then
                Timer6.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 60 Then
            Player5.Left += 20
            If (Player5.Left >= 305) Then
                Timer6.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 61 Then
            Player5.Left += 20
            If (Player5.Left >= 360) Then
                Timer6.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 62 Then
            Player5.Left += 20
            If (Player5.Left >= 415) Then
                Timer6.Stop()
                generarDesafio()
            End If
        ElseIf (posicionActual = 63) Then
            Player5.Left += 20
            If (Player5.Left >= 470) Then
                Timer6.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 64 Then
            Player5.Left += 20
            If (Player5.Left >= 525) Then
                Timer6.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 65 Then
            Player5.Left += 20
            If (Player5.Left >= 580) Then
                Timer6.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 66 Then
            Player5.Left += 20
            If (Player5.Left >= 635) Then
                Timer6.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 67 Then
            Player5.Left += 20
            If (Player5.Left >= 690) Then
                Timer6.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 68 Then
            Player5.Left += 20
            If (Player5.Left >= 745) Then
                Timer6.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 69 Then
            Player5.Left += 20
            If (Player5.Left >= 800) Then
                Timer6.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 70 Then
            Player5.Left += 20
            If (Player5.Left >= 855) Then
                Timer6.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 71 Then
            Player5.Left += 20
            If (Player5.Left >= 920) Then
                Timer6.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 72 Then
            Player5.Left += 20
            If (Player5.Left >= 970) Then
                Timer6.Stop()
                generarDesafio()
            End If
        Else
            Player5.Left += 50
            If (Player5.Left > 1110) Then
                Timer6.Stop()
                Timer7.Start()
            End If
        End If
    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        validarVidas()

        If (posicionActual = 73) Then
            Player6.Left += 5
            If (Player6.Left = 25) Then
                Timer7.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 74 Then
            Player6.Left += 20
            If (Player6.Left >= 80) Then
                Timer7.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 75 Then
            Player6.Left += 20
            If (Player6.Left >= 140) Then
                Timer7.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 76 Then
            Player6.Left += 20
            If (Player6.Left >= 195) Then
                Timer7.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 77 Then
            Player6.Left += 20
            If (Player6.Left >= 250) Then
                Timer7.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 78 Then
            Player6.Left += 20
            If (Player6.Left >= 305) Then
                Timer7.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 79 Then
            Player6.Left += 20
            If (Player6.Left >= 360) Then
                Timer7.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 80 Then
            Player6.Left += 20
            If (Player6.Left >= 415) Then
                Timer7.Stop()
                generarDesafio()
            End If
        ElseIf (posicionActual = 81) Then
            Player6.Left += 20
            If (Player6.Left >= 470) Then
                Timer7.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 82 Then
            Player6.Left += 20
            If (Player6.Left >= 525) Then
                Timer7.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 83 Then
            Player6.Left += 20
            If (Player6.Left >= 580) Then
                Timer7.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 84 Then
            Player6.Left += 20
            If (Player6.Left >= 635) Then
                Timer7.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 85 Then
            Player6.Left += 20
            If (Player6.Left >= 690) Then
                Timer7.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 86 Then
            Player6.Left += 20
            If (Player6.Left >= 745) Then
                Timer7.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 87 Then
            Player6.Left += 20
            If (Player6.Left >= 800) Then
                Timer7.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 88 Then
            Player6.Left += 20
            If (Player6.Left >= 855) Then
                Timer7.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 89 Then
            Player6.Left += 20
            If (Player6.Left >= 920) Then
                Timer7.Stop()
                generarDesafio()
            End If
        ElseIf posicionActual = 90 Then
            Player6.Left += 20
            If (Player6.Left >= 970) Then
                Timer7.Stop()
                generarDesafio()
            End If
        Else
            Player6.Left += 50
            If (Player6.Left > 1110) Then
                Timer7.Stop()
                Player6.Location = New Point(908, 488)
                MsgBox("Felicidades, ya puedes jugar el ahorcado!!!")
                btnGenerar.Enabled = False
                Candado.Visible = False
                extra = True

            End If
        End If
    End Sub

    Private Sub PictureBox54_Click(sender As Object, e As EventArgs)
        jugarAhorcado()
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        jugarAhorcado()
    End Sub

    Private Sub PictureBox55_Click(sender As Object, e As EventArgs) Handles PictureBox55.Click
        jugarAhorcado()
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click
        jugarAhorcado()
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click
        jugarAhorcado()
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click
        jugarAhorcado()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        jugarAhorcado()
    End Sub

    Private Sub Label22_Click(sender As Object, e As EventArgs) Handles Label22.Click
        jugarAhorcado()
    End Sub

    Private Sub PictureBox54_Click_1(sender As Object, e As EventArgs) Handles Candado.Click
        jugarAhorcado()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        jugarAhorcado()
    End Sub

    Private Sub PictureBox45_Click(sender As Object, e As EventArgs) Handles PictureBox45.Click
        jugarAhorcado()
    End Sub

    Private Sub PictureBox24_Click(sender As Object, e As EventArgs) Handles PictureBox24.Click
        Label24.Visible = True
    End Sub

    Private Sub Label24_Click(sender As Object, e As EventArgs) Handles Label24.Click
        Application.Exit()
    End Sub

    Sub jugarAhorcado()
        If extra = False Then
            MsgBox("Aun no has desbloqueado este modo de juego, gana el juego para desbloquearlo.")
        Else
            Me.Close()
            Ahorcado.Show()

        End If
    End Sub

    Sub generarDesafio()
        Thread.Sleep(500)

        Trivia.Show()
    End Sub

    Public Sub validarVidas()
        If (incorrecto = 1) Then
            v3.Visible = False

        ElseIf incorrecto = 2 Then
            v2.Visible = False

        ElseIf incorrecto = 3 Then
            v1.Visible = False
            posicionActual = 0

        End If
    End Sub
End Class