Public Class Form1
    ' variables
    Dim a As Integer
    Dim b As Integer
    Dim c As Integer
    Dim d, x, X1, X2, real, imag As Double
    Dim result

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        a = Val(input_a.Text)
        b = Val(input_b.Text)
        c = Val(input_c.Text)
        d = (b ^ 2) - (4 * a * c)

        If a = 0 Then
            result = "Undefined"
        Else
            Select Case d
                Case < 0
                    real = -b / (2 * a)
                    imag = (-d)^0.5 / (2 * a)
                    result = "X1: " + real.ToString + "+" + imag.ToString + "i" + ", X2: " + real.ToString + "-" + imag.ToString + "i"
                Case = 0
                    x = -b / (2 * a)
                    result = "x: " + x.ToString + " twice"
                Case Else
                    X1 = (-b + (d ^ 0.5)) / (2 * a)
                    X2 = (-b - (d ^ 0.5)) / (2 * a)
                    result = "X1: " + X1.ToString + ", X2: " + X2.ToString
            End Select

            MsgBox(result)
        End If
    End Sub

    'allow numbers only function
    'Private Sub input_c_KeyPress(sender As Object, e As KeyPressEventArgs) Handles input_c.KeyPress, input_b.KeyPress, input_a.KeyPress
    'Dim Ch As Char = e.KeyChar
    'If Not Char.IsDigit(Ch) AndAlso Asc(Ch) <> 8 Then
    '       e.Handled = True
    'End If
    'End Sub

    Private Sub result_X1_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub input_a_TextChanged(sender As Object, e As EventArgs) Handles input_a.TextChanged

    End Sub
End Class
