Public Class Trivia
    ''ArrayList de las preguntas con sus respuestas
    ''Se validaran de la siguiente manera:
    ''Pregunta(1) == Respuesta(1)
    Dim Pregunta(20), Respuesta(20) As String
    Dim Random
    Dim PosicionX = {184, 235}
    Dim PosicionY = {109, 298}
    Dim LR As Integer
    ''Agregamos preguntas erroneas clasificadas para evitar la incoherencia
    ''Clasificadas por tipo de pregunta
    Public Erroneas(40) As String

    Private Sub Label2_Click(sender As Object, e As EventArgs)
        MsgBox("Respuseta correcta")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        'RndPregunta()
        Me.Close()
        Inicio.validarVidas()
        Inicio.btnGenerar.Enabled = True
        Inicio.Show()
    End Sub

    Sub revolver()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        cambiarColores()
        Inicio.correcto += 1
        MsgBox("Respuseta correcta")
        Inicio.validarVidas()
        Inicio.btnGenerar.Enabled = True
        Me.Close()
        Inicio.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cambiarColores()
        MsgBox("Incorrecto, ANIMO")
        Inicio.incorrecto += 1
        Me.Close()
        Inicio.validarVidas()
        Inicio.btnGenerar.Enabled = True
        If (Inicio.incorrecto = 3) Then
            gracias_por_participar.Show()
            Inicio.incorrecto = 0
            Inicio.Close()
        Else
            Inicio.Show()
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cambiarColores()
        MsgBox("Incorrecto, ANIMO")
        Inicio.incorrecto += 1
        Inicio.validarVidas()
        Inicio.btnGenerar.Enabled = True
        Me.Close()
        If (Inicio.incorrecto = 3) Then
            gracias_por_participar.Show()
            Inicio.incorrecto = 0
            Inicio.Close()
        Else
            Inicio.Show()
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cambiarColores()
        MsgBox("Incorrecto, ANIMO")
        Inicio.incorrecto += 1
        Inicio.validarVidas()
        Inicio.btnGenerar.Enabled = True
        Me.Close()
        If (Inicio.incorrecto = 3) Then
            gracias_por_participar.Show()
            Inicio.incorrecto = 0
            Inicio.Close()
        Else
            Inicio.Show()
        End If
    End Sub

    Private Sub Trivia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button2.Select()
        Button3.Select()
        Button4.Select()
        Button5.Select()
        Trivia()
        RndPregunta()
        revolver()
        Randomize()
        LR = Int((4 * Rnd()))
        OrdenButtonRandom()
    End Sub

    Private Sub Trivia()
        ''Preguntas
        ''Autores o personas
        Pregunta(1) = "¿Quién descubrió el Hidrogeno?"
        Pregunta(2) = "¿Quién gano el premio nobel de quimica en el año de 1908?"
        Pregunta(3) = "¿Quién es conciderado el padre de la quimica moderna?"
        Pregunta(4) = "¿Quién invento la pasteurización,"
        Pregunta(5) = "¿Quimico qué nacio en el año 1766?"

        ''Calculo numerico
        Pregunta(6) = "Se conoce que 50.15 g de un elemento corresponden a 0.25 moles. ¿De qué elemento se trata?"
        Pregunta(7) = "¿Cuál es el primer elemento en la tabla periódica?"
        Pregunta(8) = "A temperatura ambiente, ¿cuál es el único metal que está en forma líquida?"
        Pregunta(9) = "¿K es el símbolo químico para qué elemento?"
        Pregunta(10) = "¿Cuál es el tercer gas más común encontrado en el aire que respiramos?"

        ''Compuestos
        Pregunta(11) = "De los siguientes compuestos ¿cuál será insoluble en agua?"
        Pregunta(12) = "Es la fórmula correcta del sulfato de potasio."
        Pregunta(13) = "Elige al compuesto que esté formado por enlaces de tipo iónico."
        Pregunta(14) = "Este compuesto está formado por un metal del periodo 4 y un no metal del grupo 15."
        Pregunta(15) = "De los siguientes compuestos, ¿cuál está formado por enlaces covalentes?"

        ''Prguntas directas
        Pregunta(16) = "El Argón , el Kriptón y el Xenón son:"
        Pregunta(17) = "¿El Na pertenece a la familia de los?"
        Pregunta(18) = "Cómo se llama el centro de un átomo"
        Pregunta(19) = "Es un ejemplo de un compuesto."
        Pregunta(20) = "Es uno de los líquidos empleados para construir termómetros"

        ''Respuestas
        Respuesta(1) = "Sir. Henry Cavendish"
        Respuesta(2) = "Ernest Rutherford"
        Respuesta(3) = "Antoine Laurent"
        Respuesta(4) = "Louis Pasteur"
        Respuesta(5) = "John Dalton"

        Respuesta(6) = "Mercurio"
        Respuesta(7) = "Hidrogeno"
        Respuesta(8) = "Mercurio"
        Respuesta(9) = "Potasio"
        Respuesta(10) = "Argón"

        Respuesta(11) = "CH4"
        Respuesta(12) = "K2SO4"
        Respuesta(13) = "NaF"
        Respuesta(14) = "K3N"
        Respuesta(15) = "NH3"

        Respuesta(16) = "Gases Nobles"
        Respuesta(17) = "Metales alcalineos"
        Respuesta(18) = "Nucleo"
        Respuesta(19) = "Agua"
        Respuesta(20) = "Mercurio"

        ''Distracciones
        Erroneas(1) = "Dimitri Mendeleiev"
        Erroneas(2) = "Lothar Meyer"
        Erroneas(3) = "Henry Moseley"
        Erroneas(4) = "Elio Raymundo"
        Erroneas(5) = "Marie Curie"
        Erroneas(6) = "Michael Faraday"
        Erroneas(7) = "Linus Pauling"
        Erroneas(8) = "Isaac Newton"
        Erroneas(9) = "Hector Arreaza"

        Erroneas(10) = "Uranio"
        Erroneas(11) = "Bromo"
        Erroneas(12) = "Bismuto"
        Erroneas(13) = "Helio"
        Erroneas(14) = "Kripton"
        Erroneas(15) = "Oro"
        Erroneas(16) = "Plata"
        Erroneas(17) = "Bronce"
        Erroneas(18) = "Efelio"

        Erroneas(19) = "KCl"
        Erroneas(20) = "NaOH"
        Erroneas(21) = "K2CaO"
        Erroneas(22) = "Hg2I"
        Erroneas(23) = "KH"
        Erroneas(24) = "K(NO3)2"
        Erroneas(25) = "KNO3"
        Erroneas(26) = "HCl"
        Erroneas(27) = "CH3"

        Erroneas(28) = "Protones"
        Erroneas(29) = "Electrones"
        Erroneas(30) = "Elementos de transicion"
        Erroneas(31) = "Calor"
        Erroneas(32) = "Azucar"
        Erroneas(33) = "Neutrones"
        Erroneas(34) = "Fam. del Boro"
        Erroneas(35) = "Alogenos"
        Erroneas(36) = "Anfigenos"
    End Sub

    Private Sub RndPregunta()
        Randomize()
        Random = Int((19 * Rnd()) + 1)
        Me.TextBox1.Text = Pregunta(Random)
        Me.Button2.Text = Respuesta(Random)

        If (Random >= 1 And Random < 6) Then
            Dim RA1, RA2, RA3
            Randomize()
            RA1 = Int((8 * Rnd()) + 1)
            Randomize()
            RA2 = Int((8 * Rnd()) + 1)
            Randomize()
            RA3 = Int((8 * Rnd()) + 1)
            Me.Button3.Text = Erroneas(RA1)
            Me.Button4.Text = Erroneas(RA2)
            Me.Button5.Text = Erroneas(RA3)
        End If
        If (Random >= 6 And Random < 11) Then
            Dim RB1, RB2, RB3
            Randomize()
            RB1 = Int((8 * Rnd()) + 10)
            Randomize()
            RB2 = Int((8 * Rnd()) + 10)
            Randomize()
            RB3 = Int((8 * Rnd()) + 10)
            Me.Button3.Text = Erroneas(RB1)
            Me.Button4.Text = Erroneas(RB2)
            Me.Button5.Text = Erroneas(RB3)
        End If
        If (Random >= 11 And Random < 16) Then
            Dim RC1, RC2, RC3
            Randomize()
            RC1 = Int((8 * Rnd()) + 19)
            Randomize()
            RC2 = Int((8 * Rnd()) + 19)
            Randomize()
            RC3 = Int((8 * Rnd()) + 19)
            Me.Button3.Text = Erroneas(RC1)
            Me.Button4.Text = Erroneas(RC2)
            Me.Button5.Text = Erroneas(RC3)
        End If
        If (Random >= 16 And Random <= 20) Then
            Dim RD1, RD2, RD3
            Randomize()
            RD1 = Int((8 * Rnd()) + 28)
            Randomize()
            RD2 = Int((8 * Rnd()) + 28)
            Randomize()
            RD3 = Int((8 * Rnd()) + 28)
            Me.Button3.Text = Erroneas(RD1)
            Me.Button4.Text = Erroneas(RD2)
            Me.Button5.Text = Erroneas(RD3)
        End If


    End Sub

    Private Sub OrdenButtonRandom()
        Dim L1 As New Point(75, 200)
        Dim L2 As New Point(75, 230)
        Dim L3 As New Point(75, 260)
        Dim L4 As New Point(75, 290)
        Select Case LR
            Case 0
                Button2.Location = L1
                Button3.Location = L2
                Button4.Location = L3
                Button5.Location = L4
            Case 1
                Button2.Location = L4
                Button3.Location = L3
                Button4.Location = L2
                Button5.Location = L1
            Case 2
                Button2.Location = L2
                Button3.Location = L4
                Button4.Location = L1
                Button5.Location = L3
            Case 3
                Button2.Location = L3
                Button3.Location = L1
                Button4.Location = L2
                Button5.Location = L4
        End Select
    End Sub

    Sub cambiarColores()
        Button2.BackColor = Color.GreenYellow
        Button3.BackColor = Color.OrangeRed
        Button4.BackColor = Color.OrangeRed
        Button5.BackColor = Color.OrangeRed
    End Sub
End Class