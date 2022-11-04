Public Class Form1
    Dim a, b, c As Integer
    Dim result
    Private Sub getResult()
        Dim d As Integer
        Dim real, imag, x, x1, x2 As Double
        d = (b ^ 2) - (4 * a * c)
        If a = 0 Then
            result = "Undefined"
        Else
            Select Case d
                Case < 0
                    real = -b / (2 * a)
                    imag = (-d ^ 0.5) / (2 * a)
                    result = "Real: " + real.ToString + " Imag: " + imag.ToString + "i"
                Case = 0
                    x = -b / (2 * a)
                    result = "x: " + x.ToString + " twice"
                Case Else
                    x1 = (-b + (d ^ 0.5)) / (2 * a)
                    x2 = (-b - (d ^ 0.5)) / (2 * a)
                    result = "X1: " + x1.ToString + " x2: " + x2.ToString
            End Select
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            'a = CInt(abox.Text)
            getResult()
            MsgBox(result)
        Catch ex As Exception

        End Try
    End Sub
End Class

Public Class Form2
    Dim score, grade
    Select Case score
    Case 0 To 39

    End Select
End Class
