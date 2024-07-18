<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FAgregar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FAgregar))
        Me.CBMarca = New System.Windows.Forms.ComboBox()
        Me.TModelo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NUDCant = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MTPrecio = New System.Windows.Forms.MaskedTextBox()
        Me.RBPeso = New System.Windows.Forms.RadioButton()
        Me.RBDolar = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.CBAlmacenamiento = New System.Windows.Forms.ComboBox()
        Me.CheckUsado = New System.Windows.Forms.CheckBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BModificar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LTotal = New System.Windows.Forms.Label()
        Me.GBVerDatos = New System.Windows.Forms.GroupBox()
        Me.Numer = New System.Windows.Forms.Label()
        Me.MTCodigo = New System.Windows.Forms.MaskedTextBox()
        Me.BVerDatos = New System.Windows.Forms.Button()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBProveedor = New System.Windows.Forms.ComboBox()
        CType(Me.NUDCant, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GBVerDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'CBMarca
        '
        Me.CBMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBMarca.FormattingEnabled = True
        Me.CBMarca.Items.AddRange(New Object() {"SAMSUNG", "APPLE", "XIAOMI"})
        Me.CBMarca.Location = New System.Drawing.Point(76, 114)
        Me.CBMarca.Name = "CBMarca"
        Me.CBMarca.Size = New System.Drawing.Size(135, 21)
        Me.CBMarca.TabIndex = 1
        '
        'TModelo
        '
        Me.TModelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TModelo.Location = New System.Drawing.Point(76, 142)
        Me.TModelo.Name = "TModelo"
        Me.TModelo.Size = New System.Drawing.Size(135, 20)
        Me.TModelo.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(119, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Memoria de almacenamiento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Marca:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 145)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Modelo:"
        '
        'NUDCant
        '
        Me.NUDCant.Location = New System.Drawing.Point(74, 172)
        Me.NUDCant.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NUDCant.Name = "NUDCant"
        Me.NUDCant.Size = New System.Drawing.Size(34, 20)
        Me.NUDCant.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cantidad:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Precio:"
        '
        'MTPrecio
        '
        Me.MTPrecio.Location = New System.Drawing.Point(60, 22)
        Me.MTPrecio.Mask = "999000"
        Me.MTPrecio.Name = "MTPrecio"
        Me.MTPrecio.Size = New System.Drawing.Size(52, 20)
        Me.MTPrecio.TabIndex = 9
        Me.MTPrecio.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.MTPrecio.ValidatingType = GetType(Integer)
        '
        'RBPeso
        '
        Me.RBPeso.AutoSize = True
        Me.RBPeso.Checked = True
        Me.RBPeso.Location = New System.Drawing.Point(118, 25)
        Me.RBPeso.Name = "RBPeso"
        Me.RBPeso.Size = New System.Drawing.Size(97, 17)
        Me.RBPeso.TabIndex = 10
        Me.RBPeso.TabStop = True
        Me.RBPeso.Text = "Peso Argentino"
        Me.RBPeso.UseVisualStyleBackColor = True
        '
        'RBDolar
        '
        Me.RBDolar.AutoSize = True
        Me.RBDolar.Location = New System.Drawing.Point(219, 25)
        Me.RBDolar.Name = "RBDolar"
        Me.RBDolar.Size = New System.Drawing.Size(103, 17)
        Me.RBDolar.TabIndex = 11
        Me.RBDolar.Text = "Dolar Americano"
        Me.RBDolar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MTPrecio)
        Me.GroupBox1.Controls.Add(Me.RBDolar)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.RBPeso)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 206)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(338, 65)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'BAgregar
        '
        Me.BAgregar.Location = New System.Drawing.Point(28, 409)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(338, 29)
        Me.BAgregar.TabIndex = 21
        Me.BAgregar.Text = "Agregar"
        Me.BAgregar.UseVisualStyleBackColor = True
        '
        'CBAlmacenamiento
        '
        Me.CBAlmacenamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBAlmacenamiento.FormattingEnabled = True
        Me.CBAlmacenamiento.Items.AddRange(New Object() {"8 GB", "16 GB", "32 GB", "64 GB", "128 GB", "256 GB"})
        Me.CBAlmacenamiento.Location = New System.Drawing.Point(270, 171)
        Me.CBAlmacenamiento.Name = "CBAlmacenamiento"
        Me.CBAlmacenamiento.Size = New System.Drawing.Size(63, 21)
        Me.CBAlmacenamiento.TabIndex = 23
        '
        'CheckUsado
        '
        Me.CheckUsado.AutoSize = True
        Me.CheckUsado.Location = New System.Drawing.Point(217, 144)
        Me.CheckUsado.Name = "CheckUsado"
        Me.CheckUsado.Size = New System.Drawing.Size(57, 17)
        Me.CheckUsado.TabIndex = 24
        Me.CheckUsado.Text = "Usado"
        Me.CheckUsado.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button2.Location = New System.Drawing.Point(28, 444)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(338, 36)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'BModificar
        '
        Me.BModificar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BModificar.Enabled = False
        Me.BModificar.Location = New System.Drawing.Point(17, 277)
        Me.BModificar.Name = "BModificar"
        Me.BModificar.Size = New System.Drawing.Size(337, 29)
        Me.BModificar.TabIndex = 34
        Me.BModificar.Text = "Modificar"
        Me.BModificar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.CBProveedor)
        Me.Panel1.Controls.Add(Me.LTotal)
        Me.Panel1.Controls.Add(Me.GBVerDatos)
        Me.Panel1.Controls.Add(Me.BEliminar)
        Me.Panel1.Controls.Add(Me.CBMarca)
        Me.Panel1.Controls.Add(Me.TModelo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BModificar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.NUDCant)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.CBAlmacenamiento)
        Me.Panel1.Controls.Add(Me.CheckUsado)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(363, 391)
        Me.Panel1.TabIndex = 39
        '
        'LTotal
        '
        Me.LTotal.AutoSize = True
        Me.LTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTotal.Location = New System.Drawing.Point(16, 355)
        Me.LTotal.Name = "LTotal"
        Me.LTotal.Size = New System.Drawing.Size(61, 24)
        Me.LTotal.TabIndex = 44
        Me.LTotal.Text = "Total: "
        '
        'GBVerDatos
        '
        Me.GBVerDatos.Controls.Add(Me.Numer)
        Me.GBVerDatos.Controls.Add(Me.MTCodigo)
        Me.GBVerDatos.Controls.Add(Me.BVerDatos)
        Me.GBVerDatos.Location = New System.Drawing.Point(10, 9)
        Me.GBVerDatos.Name = "GBVerDatos"
        Me.GBVerDatos.Size = New System.Drawing.Size(344, 63)
        Me.GBVerDatos.TabIndex = 43
        Me.GBVerDatos.TabStop = False
        '
        'Numer
        '
        Me.Numer.AutoSize = True
        Me.Numer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Numer.Location = New System.Drawing.Point(3, 16)
        Me.Numer.Name = "Numer"
        Me.Numer.Size = New System.Drawing.Size(86, 25)
        Me.Numer.TabIndex = 39
        Me.Numer.Text = "Código:"
        '
        'MTCodigo
        '
        Me.MTCodigo.Location = New System.Drawing.Point(112, 19)
        Me.MTCodigo.Mask = "0000"
        Me.MTCodigo.Name = "MTCodigo"
        Me.MTCodigo.Size = New System.Drawing.Size(32, 20)
        Me.MTCodigo.TabIndex = 40
        Me.MTCodigo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.MTCodigo.ValidatingType = GetType(Integer)
        '
        'BVerDatos
        '
        Me.BVerDatos.Location = New System.Drawing.Point(184, 16)
        Me.BVerDatos.Name = "BVerDatos"
        Me.BVerDatos.Size = New System.Drawing.Size(150, 29)
        Me.BVerDatos.TabIndex = 41
        Me.BVerDatos.Text = "Ver Datos"
        Me.BVerDatos.UseVisualStyleBackColor = True
        '
        'BEliminar
        '
        Me.BEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BEliminar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BEliminar.Enabled = False
        Me.BEliminar.Location = New System.Drawing.Point(17, 323)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(337, 29)
        Me.BEliminar.TabIndex = 42
        Me.BEliminar.Text = "Eliminar"
        Me.BEliminar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(2, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Distribuidora:"
        '
        'CBProveedor
        '
        Me.CBProveedor.FormattingEnabled = True
        Me.CBProveedor.IntegralHeight = False
        Me.CBProveedor.Location = New System.Drawing.Point(76, 78)
        Me.CBProveedor.Name = "CBProveedor"
        Me.CBProveedor.Size = New System.Drawing.Size(267, 21)
        Me.CBProveedor.TabIndex = 46
        '
        'FAgregar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(390, 502)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BAgregar)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FAgregar"
        Me.Text = "Agregar"
        CType(Me.NUDCant, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GBVerDatos.ResumeLayout(False)
        Me.GBVerDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents MTPrecio As MaskedTextBox
    Friend WithEvents RBPeso As RadioButton
    Friend WithEvents RBDolar As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BAgregar As Button
    Friend WithEvents CBAlmacenamiento As ComboBox
    Friend WithEvents CheckUsado As CheckBox
    Friend WithEvents Button2 As Button
    Friend WithEvents BModificar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BVerDatos As Button
    Friend WithEvents Numer As Label
    Private WithEvents CBMarca As ComboBox
    Private WithEvents TModelo As TextBox
    Private WithEvents NUDCant As NumericUpDown
    Private WithEvents MTCodigo As MaskedTextBox
    Friend WithEvents BEliminar As Button
    Friend WithEvents GBVerDatos As GroupBox
    Friend WithEvents LTotal As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CBProveedor As ComboBox
End Class
