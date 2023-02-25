<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtNumeroTelefono = New System.Windows.Forms.TextBox()
        Me.btnEnviarDatos = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCantidadContactos = New System.Windows.Forms.TextBox()
        Me.btnCantidadContactos = New System.Windows.Forms.Button()
        Me.dgvDatosFormulario = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMBRE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroDeTelefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechaDeNacimiento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ErrorProvider4 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvDatosFormulario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(119, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(119, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Numero de telefono"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(119, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha de nacimiento"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(294, 84)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(249, 26)
        Me.txtNombre.TabIndex = 3
        '
        'txtNumeroTelefono
        '
        Me.txtNumeroTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroTelefono.Location = New System.Drawing.Point(294, 120)
        Me.txtNumeroTelefono.Name = "txtNumeroTelefono"
        Me.txtNumeroTelefono.Size = New System.Drawing.Size(249, 26)
        Me.txtNumeroTelefono.TabIndex = 4
        '
        'btnEnviarDatos
        '
        Me.btnEnviarDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEnviarDatos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEnviarDatos.Location = New System.Drawing.Point(562, 139)
        Me.btnEnviarDatos.Name = "btnEnviarDatos"
        Me.btnEnviarDatos.Size = New System.Drawing.Size(135, 43)
        Me.btnEnviarDatos.TabIndex = 6
        Me.btnEnviarDatos.Text = "Enviar datos"
        Me.btnEnviarDatos.UseVisualStyleBackColor = False
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'ErrorProvider3
        '
        Me.ErrorProvider3.ContainerControl = Me
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ErrorProvider3.SetIconAlignment(Me.Label5, System.Windows.Forms.ErrorIconAlignment.BottomLeft)
        Me.Label5.Location = New System.Drawing.Point(187, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(423, 25)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Ingresa una cantidad de perfiles para crear"
        Me.Label5.UseMnemonic = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtCantidadContactos)
        Me.Panel1.Controls.Add(Me.btnCantidadContactos)
        Me.Panel1.Location = New System.Drawing.Point(3, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(793, 441)
        Me.Panel1.TabIndex = 12
        '
        'txtCantidadContactos
        '
        Me.txtCantidadContactos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadContactos.Location = New System.Drawing.Point(270, 197)
        Me.txtCantidadContactos.Name = "txtCantidadContactos"
        Me.txtCantidadContactos.Size = New System.Drawing.Size(249, 26)
        Me.txtCantidadContactos.TabIndex = 15
        '
        'btnCantidadContactos
        '
        Me.btnCantidadContactos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCantidadContactos.Location = New System.Drawing.Point(340, 229)
        Me.btnCantidadContactos.Name = "btnCantidadContactos"
        Me.btnCantidadContactos.Size = New System.Drawing.Size(113, 38)
        Me.btnCantidadContactos.TabIndex = 16
        Me.btnCantidadContactos.Text = "Confirmar"
        Me.btnCantidadContactos.UseVisualStyleBackColor = False
        '
        'dgvDatosFormulario
        '
        Me.dgvDatosFormulario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvDatosFormulario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.NOMBRE, Me.NumeroDeTelefono, Me.FechaDeNacimiento, Me.Edad})
        Me.dgvDatosFormulario.Location = New System.Drawing.Point(117, 196)
        Me.dgvDatosFormulario.Name = "dgvDatosFormulario"
        Me.dgvDatosFormulario.Size = New System.Drawing.Size(580, 210)
        Me.dgvDatosFormulario.TabIndex = 17
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 50
        '
        'NOMBRE
        '
        Me.NOMBRE.HeaderText = "Nombre"
        Me.NOMBRE.Name = "NOMBRE"
        Me.NOMBRE.ReadOnly = True
        Me.NOMBRE.Width = 120
        '
        'NumeroDeTelefono
        '
        Me.NumeroDeTelefono.HeaderText = "Numero de telefono"
        Me.NumeroDeTelefono.Name = "NumeroDeTelefono"
        Me.NumeroDeTelefono.ReadOnly = True
        Me.NumeroDeTelefono.Width = 120
        '
        'FechaDeNacimiento
        '
        Me.FechaDeNacimiento.HeaderText = "Fecha de nacimiento"
        Me.FechaDeNacimiento.Name = "FechaDeNacimiento"
        Me.FechaDeNacimiento.ReadOnly = True
        Me.FechaDeNacimiento.Width = 120
        '
        'Edad
        '
        Me.Edad.HeaderText = "Edad"
        Me.Edad.Name = "Edad"
        Me.Edad.ReadOnly = True
        Me.Edad.Width = 120
        '
        'ErrorProvider4
        '
        Me.ErrorProvider4.ContainerControl = Me
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(294, 156)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(249, 26)
        Me.dtpFechaNacimiento.TabIndex = 13
        Me.dtpFechaNacimiento.Value = New Date(2023, 2, 23, 1, 31, 34, 0)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtpFechaNacimiento)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.dgvDatosFormulario)
        Me.Controls.Add(Me.txtNumeroTelefono)
        Me.Controls.Add(Me.btnEnviarDatos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvDatosFormulario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtNumeroTelefono As TextBox
    Friend WithEvents btnEnviarDatos As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents ErrorProvider3 As ErrorProvider
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCantidadContactos As TextBox
    Friend WithEvents ErrorProvider4 As ErrorProvider
    Friend WithEvents btnCantidadContactos As Button
    Friend WithEvents dgvDatosFormulario As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents NOMBRE As DataGridViewTextBoxColumn
    Friend WithEvents NumeroDeTelefono As DataGridViewTextBoxColumn
    Friend WithEvents FechaDeNacimiento As DataGridViewTextBoxColumn
    Friend WithEvents Edad As DataGridViewTextBoxColumn
    Friend WithEvents dtpFechaNacimiento As DateTimePicker
End Class
