Imports System.Threading
Public Class Ahorcado

    Dim palabras(30) As String
    Public palabra As String
    Dim cantidad As Integer
    Dim etiqueta As Label
    Dim letra As String
    Dim etiqueta1 As Label
    Dim co As Integer
    Dim resta As Integer = 1
    Dim aux As Integer = 0
    Dim falla As Integer
    Dim victoria, segundos As Integer
    Dim intentos As Integer = 7

    Public Sub generarPalabra()
        'Alcalineos
        palabras(0) = "hidrogeno"
        palabras(1) = "litio"
        palabras(2) = "sodio"
        palabras(3) = "potasio"

        'Alcalineoterreos
        palabras(4) = "berilio"
        palabras(5) = "magnesio"
        palabras(6) = "calcio"
        palabras(7) = "bario"

        'Elementos de transicion

        palabras(8) = "hierro"
        palabras(9) = "cobalto"
        palabras(10) = "niquel"
        palabras(11) = "zinc"
        palabras(12) = "manganeso"
        palabras(13) = "titanio"
        palabras(14) = "cobre"
        'familia del boro
        palabras(15) = "boro"
        palabras(16) = "aluminio"
        'familia del carbono
        palabras(17) = "carbono"
        'familia del nitrogeno
        palabras(18) = "nitrogeno"
        palabras(19) = "fosforo"
        'oxigeno
        palabras(20) = "oxigeno"
        palabras(21) = "azufre"
        ''
        palabras(22) = "fluor"
        palabras(23) = "cloro"
        palabras(24) = "bromo"
        palabras(25) = "yodo"
        'gases nobles
        palabras(26) = "helio"
        palabras(27) = "neon"
        palabras(28) = "argon"
        palabras(29) = "kripton"
        palabras(30) = "xenon"

        Randomize()
        palabra = (palabras(30 * Rnd()))
        victoria = Len(palabra)
        Dim posetiqueta As Integer = 10
        Dim i As Integer

        cantidad = Len(palabra)
        For i = 1 To cantidad Step 1


            etiqueta = New Label
            etiqueta.Text = "___"
            etiqueta.BackColor = Color.Transparent
            etiqueta.AutoSize = True
            etiqueta.Width = 30
            etiqueta.Location = New Point(posetiqueta, 240)
            Me.Controls.Add(etiqueta)

            posetiqueta += 30
        Next


    End Sub



    Private Sub validar()

        co = Len(palabra)
        Dim cont As Integer
        cont = Len(palabra)
        Dim temp As String
        Dim dibujo, cabeza, muerto As Graphics

        dibujo = PictureBox7.CreateGraphics
        cabeza = PictureBox8.CreateGraphics
        muerto = PictureBox9.CreateGraphics

        falla = aux + 1


        Do Until cont = 0


            temp = palabra(cont - 1)
            cont = cont - 1
            If temp = letra Then

                etiqueta1 = New Label
                etiqueta1.Text = temp
                etiqueta1.BackColor = Color.Transparent
                etiqueta1.Font = New Font("Microsoft Sans Sarif", etiqueta1.Font.Size + 5, FontStyle.Bold)
                etiqueta1.Width = 20
                etiqueta1.Location = New Point(12 + (cont * 30), 215)
                Me.Controls.Add(etiqueta1)
                falla = 0
                victoria = victoria - 1

            End If



        Loop

        If victoria = 0 Then

            Me.Hide()
            Dim ganador As New felicidades
            co = 0
            If co = 0 Then

                ganador.Show()
                Timer1.Stop()


                resta += 1

            End If
            victoria = 1
        End If



        Select Case falla


            Case 1

                Label3.Visible = True
                Label4.Visible = True
                Label5.Visible = True
                Label6.Visible = True
                Label8.Text = 6
                cabeza.DrawEllipse(Pens.Black, 20, 0, 30, 35)
                aux = 1
                Timer1.Start()
            Case 2
                Label8.Text = 5
                dibujo.DrawLine(Pens.Black, 35, 30, 35, 80)
                aux = 2

            Case 3
                Label8.Text = 4
                dibujo.DrawLine(Pens.Black, 35, 50, 50, 40)
                aux = 3
            Case 4
                Label8.Text = 3
                dibujo.DrawLine(Pens.Black, 35, 50, 20, 40)
                aux = 4
            Case 5
                Label8.Text = 2
                dibujo.DrawLine(Pens.Black, 35, 80, 50, 90)
                aux = 5
            Case 6
                Label8.Text = 1
                dibujo.DrawLine(Pens.Black, 35, 80, 20, 90)
                aux = 6
            Case 7
                PictureBox7.Image = Nothing
                cabeza.DrawLine(Pens.Red, 0, 40, 70, 40)
                muerto.DrawLine(Pens.Black, 5, 5, 45, 10)
                muerto.DrawLine(Pens.Black, 50, 15, 70, 15)
                muerto.DrawLine(Pens.Black, 50, 20, 70, 25)
                muerto.DrawLine(Pens.Black, 36, 25, 50, 25)
                muerto.DrawLine(Pens.Black, 36, 40, 45, 20)

                Dim respuesta As New gracias_por_participar
                respuesta.Show()
                Timer1.Stop()
                MsgBox("La palabra era: " + palabra)
                Me.Hide()


        End Select



    End Sub


    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Application.Exit()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Timer1.Stop()
        Dim inicio As New Inicio
        inicio.Show()
        Me.Hide()

    End Sub


    Private Sub juego_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label3.Visible = False
        Label4.Visible = False
        Label5.Visible = False
        Label6.Visible = False
        PictureBox10.Visible = True
        PictureBox5.Visible = False

        Dim musica As Integer
        Randomize()

        musica = (4 * Rnd())
        generarPalabra()

    End Sub



    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
        Dim advertencia As New Ahorcado
        advertencia.Show()

        Dim opcion As New Ahorcado

    End Sub

    Private Sub Q_Click(sender As Object, e As EventArgs) Handles Q.Click
        Q.Enabled = False
        letra = "q"
        validar()
    End Sub

    Private Sub W_Click(sender As Object, e As EventArgs) Handles W.Click
        W.Enabled = False
        letra = "w"
        validar()


    End Sub

    Private Sub E_Click(sender As Object, e As EventArgs) Handles EE.Click
        EE.Enabled = False
        letra = "e"
        validar()


    End Sub

    Private Sub R_Click(sender As Object, e As EventArgs) Handles R.Click
        R.Enabled = False
        letra = "r"
        validar()


    End Sub

    Private Sub T_Click(sender As Object, e As EventArgs) Handles T.Click
        T.Enabled = False
        letra = "t"
        validar()


    End Sub

    Private Sub Y_Click(sender As Object, e As EventArgs) Handles Y.Click
        Y.Enabled = False
        letra = "y"
        validar()


    End Sub

    Private Sub U_Click(sender As Object, e As EventArgs) Handles U.Click
        U.Enabled = False
        letra = "u"
        validar()


    End Sub

    Private Sub I_Click(sender As Object, e As EventArgs) Handles I.Click
        I.Enabled = False
        letra = "i"
        validar()


    End Sub

    Private Sub O_Click(sender As Object, e As EventArgs) Handles O.Click
        O.Enabled = False
        letra = "o"
        validar()


    End Sub

    Private Sub P_Click(sender As Object, e As EventArgs) Handles P.Click
        P.Enabled = False
        letra = "p"
        validar()

    End Sub

    Private Sub A_Click(sender As Object, e As EventArgs) Handles A.Click
        A.Enabled = False
        letra = "a"
        validar()


    End Sub

    Private Sub S_Click(sender As Object, e As EventArgs) Handles S.Click
        S.Enabled = False
        letra = "s"
        validar()


    End Sub

    Private Sub D_Click(sender As Object, e As EventArgs) Handles D.Click
        D.Enabled = False
        letra = "d"
        validar()


    End Sub

    Private Sub F_Click(sender As Object, e As EventArgs) Handles F.Click
        F.Enabled = False
        letra = "f"
        validar()


    End Sub

    Private Sub G_Click(sender As Object, e As EventArgs) Handles G.Click
        G.Enabled = False
        letra = "g"
        validar()


    End Sub

    Private Sub H_Click(sender As Object, e As EventArgs) Handles H.Click
        H.Enabled = False
        letra = "h"
        validar()


    End Sub

    Private Sub J_Click(sender As Object, e As EventArgs) Handles J.Click
        J.Enabled = False
        letra = "j"
        validar()


    End Sub

    Private Sub K_Click(sender As Object, e As EventArgs) Handles K.Click
        K.Enabled = False
        letra = "k"
        validar()


    End Sub

    Private Sub L_Click(sender As Object, e As EventArgs) Handles L.Click
        L.Enabled = False
        letra = "l"
        validar()


    End Sub

    Private Sub Z_Click(sender As Object, e As EventArgs) Handles Z.Click
        Z.Enabled = False
        letra = "z"
        validar()



    End Sub

    Private Sub X_Click(sender As Object, e As EventArgs) Handles X.Click
        X.Enabled = False
        letra = "x"
        validar()



    End Sub

    Private Sub C_Click(sender As Object, e As EventArgs) Handles C.Click
        C.Enabled = False
        letra = "c"
        validar()



    End Sub

    Private Sub V_Click(sender As Object, e As EventArgs) Handles V.Click
        V.Enabled = False
        letra = "v"
        validar()



    End Sub

    Private Sub B_Click(sender As Object, e As EventArgs) Handles B.Click
        B.Enabled = False
        letra = "b"
        validar()



    End Sub

    Private Sub N_Click(sender As Object, e As EventArgs) Handles N.Click
        N.Enabled = False
        letra = "n"
        validar()



    End Sub

    Private Sub M_Click(sender As Object, e As EventArgs) Handles M.Click
        M.Enabled = False
        letra = "m"
        validar()



    End Sub

    Private Sub Ñ_Click(sender As Object, e As EventArgs) Handles Ñ.Click
        Ñ.Enabled = False
        letra = "ñ"
        validar()


    End Sub

    Public Sub cerrarJuego()
        Inicio.Show()
        Me.Hide()

    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text -= 1

        If Label3.Text = 0 Then
            Me.Hide()
            Dim perdedor As New gracias_por_participar
            perdedor.Show()

        End If

        If Label3.Text = 10 Then
            Label3.ForeColor = Color.Red
        End If

    End Sub


    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        My.Computer.Audio.Stop()
        PictureBox10.Visible = False
        PictureBox5.Visible = True

    End Sub

    Private Sub PictureBox5_Click_1(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim musica As Integer
        Randomize()
        musica = (4 * Rnd())
        PictureBox5.Visible = False
        PictureBox10.Visible = True

    End Sub

    Private Sub PictureBox6_Click_1(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Timer1.Stop()
        Dim juego As New Ahorcado
        juego.Show()
        Me.Hide()

    End Sub


End Class