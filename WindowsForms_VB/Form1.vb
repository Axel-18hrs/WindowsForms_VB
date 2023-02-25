Imports System.Diagnostics.Contracts
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private nn As Integer = 0
    Private index As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel1.Visible = True
        dgvDatosFormulario.Visible = False
    End Sub
    ' este boton es el que envia los datos al DataGridView
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEnviarDatos.Click
        Dim personas(nn) As Contacto
        Dim cantidad As Integer = CInt(txtCantidadContactos.Text)

        Try
            If Not txtNombre.Text = Nothing Or Not txtNumeroTelefono.Text = Nothing Then
                Dim person = New Contacto With
               {
               .Nombre = txtNombre.Text,
               .Telefono = txtNumeroTelefono.Text,
               .FechaNacimiento = dtpFechaNacimiento.Text
               }
                personas(nn) = person

                Me.dgvDatosFormulario.Rows.Add(nn + 1, UCase(personas(nn).Nombre), personas(nn).Telefono, personas(nn).FechaNacimiento, personas(nn).Edad)
                nn += 1
            End If

            ' validaciones que generan un ErrorProvider
            If String.IsNullOrEmpty(txtNombre.Text) Or txtNombre.Text = Nothing Then
                ErrorProvider1.SetError(txtNombre, "Debe ingresar un nombre.")
            End If
            If String.IsNullOrEmpty(txtNumeroTelefono.Text) Or txtNumeroTelefono.Text = Nothing Then
                ErrorProvider2.SetError(txtNumeroTelefono, "Debe ingresar un numero.")
            End If
            'If String.IsNullOrEmpty(dtpFechaNacimiento.Text) Then
            '    ErrorProvider3.SetError(dtpFechaNacimiento, "Debe ingresar esta fecha en el formato correcto.")
            'End If
            ' mensage de advertencia por los errores al rellenar los textbox/datos
            If (txtNombre.Text = Nothing Or txtNumeroTelefono.Text = Nothing) Then
                MessageBox.Show("Debe ingresar todos los datos correctamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception


        End Try
        ' validaciones para remover los ErrorProvider y desactivar boton txtEnviarDatos
        If Not String.IsNullOrWhiteSpace(txtNombre.Text) Then
            ErrorProvider1.Clear()
        End If
        If Not String.IsNullOrWhiteSpace(txtNumeroTelefono.Text) Then
            ErrorProvider2.Clear()
        End If
        'If Not String.IsNullOrWhiteSpace(dtpFechaNacimiento.Text) Then
        '    ErrorProvider3.Clear()
        'End If
        If nn = index Then
            btnEnviarDatos.Enabled = False
        End If
        txtNombre.Clear()
        txtNumeroTelefono.Clear()
        dtpFechaNacimiento.ResetText()

    End Sub
    ' este boton es el que define la cantidad de veces que se va a instanciar la clase Contacto en un arreglo de clase
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnCantidadContactos.Click

        Try
            index = txtCantidadContactos.Text
            btnEnviarDatos.Enabled = True
            dgvDatosFormulario.Visible = True

        Catch ex As Exception
            If Not IsNumeric(txtCantidadContactos.Text) Or IsNothing(txtCantidadContactos.Text) Then
                ErrorProvider4.SetError(txtCantidadContactos, "Debe ingresar un numero.")
                MessageBox.Show("Debe ingresar un numero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End Try
        If IsNumeric(txtCantidadContactos.Text) Then
            ErrorProvider4.Clear()
            Panel1.Visible = False
            txtCantidadContactos.Visible = False
            Label5.Visible = False
            btnCantidadContactos.Visible = False
        End If

    End Sub

End Class
