Imports System.Diagnostics.Contracts
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim x As New Contacto()
            x.Nombre = TextBox1.Text
            x.Telefono = TextBox2.Text
            x.FechaNacimiento = DateTime.Parse(TextBox3.Text)
            MsgBox(x.ToString(), MsgBoxStyle.Information)

        Catch ex As Exception
            If (TextBox1.Text = Nothing Or TextBox2.Text = Nothing Or TextBox3.TextLength < 8 Or TextBox3.Text = Nothing) Then
                MsgBox("DEBES RESPETAR EL FORMATO Y NO DEJAR DATOS SIN LLENAR", MsgBoxStyle.Exclamation)

            End If
        End Try
    End Sub
End Class
