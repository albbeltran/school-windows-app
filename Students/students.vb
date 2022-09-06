Public Class Students
    Private Sub Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ButtonEnter_Click(sender As Object, e As EventArgs) Handles ButtonEnter.Click

        Try

            If TxtP1.Text = Nothing Or
                    TxtP2.Text = Nothing Or
                    TxtP3.Text = Nothing Or
                    TxtP4.Text = Nothing Then

                MsgBox("There are empty fields!", MsgBoxStyle.Critical, "Students")

            Else

                Dim Parcial1 As Double
                Dim Parcial2 As Double
                Dim Parcial3 As Double
                Dim Parcial4 As Double
                Dim Promedio As Double

                Parcial1 = TxtP1.Text
                Parcial2 = TxtP2.Text
                Parcial3 = TxtP3.Text
                Parcial4 = TxtP4.Text

                Promedio = (Parcial1 + Parcial2 + Parcial3 + Parcial4) / 4
                TxtPromedio.Text = Promedio

                MsgBox("Your grade is: " & Promedio, MsgBoxStyle.OkOnly, "Students")

                ClearTxt()
            End If
        Catch ex As Exception

            MsgBox("Error! " & ex.Message, MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub ClearTxt()
        TxtP1.Clear()
        TxtP2.Clear()
        TxtP3.Clear()
        TxtP4.Clear()
    End Sub
End Class