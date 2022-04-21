Public Class Form1
    Dim num1 As Decimal
    Dim num2 As Decimal
    Dim resul As Decimal
    Dim operador As String
    Dim bandera As Integer
    Dim memoria As Decimal
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = TextBox1.Text & Button1.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = TextBox1.Text & Button2.Text

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = TextBox1.Text & Button3.Text

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = TextBox1.Text & Button6.Text

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = TextBox1.Text & Button5.Text

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = TextBox1.Text & Button4.Text

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = TextBox1.Text & Button9.Text

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = TextBox1.Text & Button8.Text

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = TextBox1.Text & Button7.Text

    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TextBox1.Text = ""
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = TextBox1.Text & Button12.Text
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = TextBox1.Text & Button11.Text
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        num1 = TextBox1.Text
        TextBox1.Text = ""
        operador = "+"
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        num1 = TextBox1.Text
        TextBox1.Text = ""
        operador = "-"
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        num1 = TextBox1.Text
        TextBox1.Text = ""
        operador = "*"
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        num1 = TextBox1.Text
        TextBox1.Text = ""
        operador = "/"
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        num2 = TextBox1.Text
        Select Case operador
            Case "+"
                resul = num1 + num2

            Case "-"
                resul = num1 - num2
            Case "*"
                resul = num1 * num2
            Case "/"
                resul = num1 / num2
            Case Else
                MsgBox("error")
        End Select
        TextBox1.Text = resul

    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        TextBox1.Text = resul
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        TextBox2.Text = ""
        RichTextBox1.Text = ""
        TextBox2.Focus()


    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Dim numero As Integer
        Dim contador As Integer = 0

        If TextBox2.Text <> "" Then
            numero = Val(TextBox2.Text)
            Do
                contador += 1
                If (numero Mod contador) = 0 Then
                    RichTextBox1.Text = RichTextBox1.Text & contador & ","
                End If

            Loop Until (contador = numero)

        Else
            MsgBox("ingrese un numero")

        End If

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Dim num As Integer
        Dim i As Integer
        Dim total As Integer
        num = Val(TextBox3.Text)

        For i = 1 To 10
            total = num * i
            RichTextBox2.Text = RichTextBox2.Text & total & vbCrLf

        Next

    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        TextBox3.Text = ""
        RichTextBox2.Text = ""
        TextBox3.Focus()

    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Dim resul As Decimal
        If ComboBox1.SelectedItem = "Volumen" Then
            resul = Val(TextBox4.Text) / Val(TextBox5.Text)
            TextBox6.Text = Math.Round(resul, 2)
        ElseIf ComboBox1.SelectedItem = "Kilogramos" Then

            resul = Val(TextBox4.Text) * Val(TextBox5.Text)
            TextBox6.Text = Math.Round(resul, 2)
        Else
            resul = Val(TextBox4.Text) / Val(TextBox5.Text)
            TextBox6.Text = Math.Round(resul, 4)


        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Volumen" Then
            Label4.Text = "Ingrese los Kilogramos "
            Label5.Text = "Ingrese la densidad"
            Label6.Text = "Volumen"
            Label7.Text = "Kg/m3"
        ElseIf ComboBox1.SelectedItem = "Kilogramos" Then
            Label4.Text = "Ingrese el Volumen "
            Label5.Text = "Ingrese la densidad"
            Label6.Text = "Kilogramos"
            Label7.Text = "Kg/m3"
        Else
            Label4.Text = "Ingrese los kilogramos "
            Label5.Text = "Ingrese el volumen"
            Label6.Text = "Kg/m3"
            Label7.Text = "litros"

        End If
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Label4.Text = ""
        Label5.Text = ""
        Label6.Text = ""
        Label7.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox4.Focus()
    End Sub


End Class
