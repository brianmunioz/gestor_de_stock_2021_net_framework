<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FCelulares
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FCelulares))
        Me.RBSamsung = New System.Windows.Forms.RadioButton()
        Me.RBApple = New System.Windows.Forms.RadioButton()
        Me.RBXiaomi = New System.Windows.Forms.RadioButton()
        Me.RBTodos = New System.Windows.Forms.RadioButton()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.BCerrar = New System.Windows.Forms.Button()
        Me.LBCelulares = New System.Windows.Forms.ListBox()
        Me.LTotal = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RTDatos = New System.Windows.Forms.RichTextBox()
        Me.DialogGuardar = New System.Windows.Forms.SaveFileDialog()
        Me.DialogAbrir = New System.Windows.Forms.OpenFileDialog()
        Me.CBAlmacenamiento = New System.Windows.Forms.ComboBox()
        Me.GBMarca = New System.Windows.Forms.GroupBox()
        Me.BResetar = New System.Windows.Forms.Button()
        Me.BAbrir = New System.Windows.Forms.Button()
        Me.BGuardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLAcercaDe = New System.Windows.Forms.LinkLabel()
        Me.GBMoneda = New System.Windows.Forms.GroupBox()
        Me.RBTodoMoneda = New System.Windows.Forms.RadioButton()
        Me.RBPeso = New System.Windows.Forms.RadioButton()
        Me.RBDolar = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.CBProveedor = New System.Windows.Forms.ComboBox()
        Me.GBMarca.SuspendLayout()
        Me.GBMoneda.SuspendLayout()
        Me.SuspendLayout()
        '
        'RBSamsung
        '
        Me.RBSamsung.AutoSize = True
        Me.RBSamsung.Location = New System.Drawing.Point(79, 19)
        Me.RBSamsung.Name = "RBSamsung"
        Me.RBSamsung.Size = New System.Drawing.Size(69, 17)
        Me.RBSamsung.TabIndex = 0
        Me.RBSamsung.Text = "Samsung"
        Me.RBSamsung.UseVisualStyleBackColor = True
        '
        'RBApple
        '
        Me.RBApple.AutoSize = True
        Me.RBApple.Location = New System.Drawing.Point(154, 19)
        Me.RBApple.Name = "RBApple"
        Me.RBApple.Size = New System.Drawing.Size(52, 17)
        Me.RBApple.TabIndex = 1
        Me.RBApple.Text = "Apple"
        Me.RBApple.UseVisualStyleBackColor = True
        '
        'RBXiaomi
        '
        Me.RBXiaomi.AutoSize = True
        Me.RBXiaomi.Location = New System.Drawing.Point(212, 19)
        Me.RBXiaomi.Name = "RBXiaomi"
        Me.RBXiaomi.Size = New System.Drawing.Size(56, 17)
        Me.RBXiaomi.TabIndex = 2
        Me.RBXiaomi.Text = "Xiaomi"
        Me.RBXiaomi.UseVisualStyleBackColor = True
        '
        'RBTodos
        '
        Me.RBTodos.AutoSize = True
        Me.RBTodos.Checked = True
        Me.RBTodos.Location = New System.Drawing.Point(18, 19)
        Me.RBTodos.Name = "RBTodos"
        Me.RBTodos.Size = New System.Drawing.Size(55, 17)
        Me.RBTodos.TabIndex = 3
        Me.RBTodos.TabStop = True
        Me.RBTodos.Text = "Todos"
        Me.RBTodos.UseVisualStyleBackColor = True
        '
        'BAgregar
        '
        Me.BAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BAgregar.Location = New System.Drawing.Point(1077, 53)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(130, 41)
        Me.BAgregar.TabIndex = 4
        Me.BAgregar.Text = "Agregar /&Modificar"
        Me.BAgregar.UseVisualStyleBackColor = False
        '
        'BCerrar
        '
        Me.BCerrar.BackColor = System.Drawing.SystemColors.Control
        Me.BCerrar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BCerrar.Location = New System.Drawing.Point(0, 337)
        Me.BCerrar.Name = "BCerrar"
        Me.BCerrar.Size = New System.Drawing.Size(1220, 32)
        Me.BCerrar.TabIndex = 8
        Me.BCerrar.Text = "&Cerrar"
        Me.BCerrar.UseVisualStyleBackColor = False
        '
        'LBCelulares
        '
        Me.LBCelulares.FormattingEnabled = True
        Me.LBCelulares.Location = New System.Drawing.Point(20, 53)
        Me.LBCelulares.Name = "LBCelulares"
        Me.LBCelulares.Size = New System.Drawing.Size(1051, 238)
        Me.LBCelulares.TabIndex = 9
        '
        'LTotal
        '
        Me.LTotal.AutoSize = True
        Me.LTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTotal.Location = New System.Drawing.Point(16, 296)
        Me.LTotal.Name = "LTotal"
        Me.LTotal.Size = New System.Drawing.Size(284, 24)
        Me.LTotal.TabIndex = 11
        Me.LTotal.Text = "Cantidad de celulares en la lista: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(17, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Almacenamiento Interno:"
        '
        'RTDatos
        '
        Me.RTDatos.Location = New System.Drawing.Point(863, 122)
        Me.RTDatos.Name = "RTDatos"
        Me.RTDatos.Size = New System.Drawing.Size(109, 96)
        Me.RTDatos.TabIndex = 14
        Me.RTDatos.Text = ""
        Me.RTDatos.Visible = False
        '
        'DialogGuardar
        '
        Me.DialogGuardar.FileName = "datos.rtf"
        Me.DialogGuardar.Filter = ".rtf|*.rtf*"
        Me.DialogGuardar.InitialDirectory = "final/bin/debug"
        Me.DialogGuardar.RestoreDirectory = True
        '
        'DialogAbrir
        '
        Me.DialogAbrir.InitialDirectory = "/final/bin/debug"
        '
        'CBAlmacenamiento
        '
        Me.CBAlmacenamiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBAlmacenamiento.FormattingEnabled = True
        Me.CBAlmacenamiento.IntegralHeight = False
        Me.CBAlmacenamiento.Items.AddRange(New Object() {"Todos", "8 GB", "16 GB", "32 GB", "64 GB", "128 GB", "256 GB"})
        Me.CBAlmacenamiento.Location = New System.Drawing.Point(144, 20)
        Me.CBAlmacenamiento.Name = "CBAlmacenamiento"
        Me.CBAlmacenamiento.Size = New System.Drawing.Size(121, 21)
        Me.CBAlmacenamiento.TabIndex = 26
        '
        'GBMarca
        '
        Me.GBMarca.BackColor = System.Drawing.Color.Transparent
        Me.GBMarca.Controls.Add(Me.RBTodos)
        Me.GBMarca.Controls.Add(Me.RBSamsung)
        Me.GBMarca.Controls.Add(Me.RBApple)
        Me.GBMarca.Controls.Add(Me.RBXiaomi)
        Me.GBMarca.Location = New System.Drawing.Point(271, 5)
        Me.GBMarca.Name = "GBMarca"
        Me.GBMarca.Size = New System.Drawing.Size(269, 42)
        Me.GBMarca.TabIndex = 15
        Me.GBMarca.TabStop = False
        Me.GBMarca.Text = "Marca"
        '
        'BResetar
        '
        Me.BResetar.Location = New System.Drawing.Point(1077, 251)
        Me.BResetar.Name = "BResetar"
        Me.BResetar.Size = New System.Drawing.Size(130, 40)
        Me.BResetar.TabIndex = 28
        Me.BResetar.Text = "&Resetear"
        Me.BResetar.UseVisualStyleBackColor = True
        '
        'BAbrir
        '
        Me.BAbrir.Location = New System.Drawing.Point(1077, 100)
        Me.BAbrir.Name = "BAbrir"
        Me.BAbrir.Size = New System.Drawing.Size(130, 49)
        Me.BAbrir.TabIndex = 29
        Me.BAbrir.Text = "&Abrir datos de otro archivo"
        Me.BAbrir.UseVisualStyleBackColor = True
        '
        'BGuardar
        '
        Me.BGuardar.Location = New System.Drawing.Point(1077, 155)
        Me.BGuardar.Name = "BGuardar"
        Me.BGuardar.Size = New System.Drawing.Size(130, 49)
        Me.BGuardar.TabIndex = 30
        Me.BGuardar.Text = "&Guardar datos en otro archivo"
        Me.BGuardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(940, 300)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 24)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Acerca de "
        '
        'LinkLAcercaDe
        '
        Me.LinkLAcercaDe.AutoSize = True
        Me.LinkLAcercaDe.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLAcercaDe.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLAcercaDe.LinkColor = System.Drawing.Color.Red
        Me.LinkLAcercaDe.Location = New System.Drawing.Point(1036, 296)
        Me.LinkLAcercaDe.Name = "LinkLAcercaDe"
        Me.LinkLAcercaDe.Size = New System.Drawing.Size(157, 29)
        Me.LinkLAcercaDe.TabIndex = 32
        Me.LinkLAcercaDe.TabStop = True
        Me.LinkLAcercaDe.Text = "Tech Stocks"
        '
        'GBMoneda
        '
        Me.GBMoneda.BackColor = System.Drawing.Color.Transparent
        Me.GBMoneda.Controls.Add(Me.RBTodoMoneda)
        Me.GBMoneda.Controls.Add(Me.RBPeso)
        Me.GBMoneda.Controls.Add(Me.RBDolar)
        Me.GBMoneda.Location = New System.Drawing.Point(546, 5)
        Me.GBMoneda.Name = "GBMoneda"
        Me.GBMoneda.Size = New System.Drawing.Size(273, 42)
        Me.GBMoneda.TabIndex = 16
        Me.GBMoneda.TabStop = False
        Me.GBMoneda.Text = "Moneda"
        '
        'RBTodoMoneda
        '
        Me.RBTodoMoneda.AutoSize = True
        Me.RBTodoMoneda.Checked = True
        Me.RBTodoMoneda.Location = New System.Drawing.Point(8, 19)
        Me.RBTodoMoneda.Name = "RBTodoMoneda"
        Me.RBTodoMoneda.Size = New System.Drawing.Size(55, 17)
        Me.RBTodoMoneda.TabIndex = 3
        Me.RBTodoMoneda.TabStop = True
        Me.RBTodoMoneda.Text = "Todos"
        Me.RBTodoMoneda.UseVisualStyleBackColor = True
        '
        'RBPeso
        '
        Me.RBPeso.AutoSize = True
        Me.RBPeso.Location = New System.Drawing.Point(69, 19)
        Me.RBPeso.Name = "RBPeso"
        Me.RBPeso.Size = New System.Drawing.Size(97, 17)
        Me.RBPeso.TabIndex = 0
        Me.RBPeso.Text = "Peso Argentino"
        Me.RBPeso.UseVisualStyleBackColor = True
        '
        'RBDolar
        '
        Me.RBDolar.AutoSize = True
        Me.RBDolar.Location = New System.Drawing.Point(171, 19)
        Me.RBDolar.Name = "RBDolar"
        Me.RBDolar.Size = New System.Drawing.Size(103, 17)
        Me.RBDolar.TabIndex = 1
        Me.RBDolar.Text = "Dolar Americano"
        Me.RBDolar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(826, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Proveedor:"
        '
        'CBProveedor
        '
        Me.CBProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBProveedor.FormattingEnabled = True
        Me.CBProveedor.IntegralHeight = False
        Me.CBProveedor.Items.AddRange(New Object() {"Todos"})
        Me.CBProveedor.Location = New System.Drawing.Point(891, 23)
        Me.CBProveedor.Name = "CBProveedor"
        Me.CBProveedor.Size = New System.Drawing.Size(180, 21)
        Me.CBProveedor.TabIndex = 35
        '
        'FCelulares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1220, 369)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CBProveedor)
        Me.Controls.Add(Me.GBMoneda)
        Me.Controls.Add(Me.LinkLAcercaDe)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BGuardar)
        Me.Controls.Add(Me.BAbrir)
        Me.Controls.Add(Me.BResetar)
        Me.Controls.Add(Me.GBMarca)
        Me.Controls.Add(Me.RTDatos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CBAlmacenamiento)
        Me.Controls.Add(Me.LTotal)
        Me.Controls.Add(Me.LBCelulares)
        Me.Controls.Add(Me.BCerrar)
        Me.Controls.Add(Me.BAgregar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FCelulares"
        Me.Text = "Tech Stocks"
        Me.GBMarca.ResumeLayout(False)
        Me.GBMarca.PerformLayout()
        Me.GBMoneda.ResumeLayout(False)
        Me.GBMoneda.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RBSamsung As RadioButton
    Friend WithEvents RBApple As RadioButton
    Friend WithEvents RBXiaomi As RadioButton
    Friend WithEvents RBTodos As RadioButton
    Friend WithEvents BAgregar As Button
    Friend WithEvents BCerrar As Button
    Friend WithEvents LBCelulares As ListBox
    Friend WithEvents LTotal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RTDatos As RichTextBox
    Friend WithEvents CBAlmacenamiento As ComboBox
    Friend WithEvents GBMarca As GroupBox
    Friend WithEvents BResetar As Button
    Friend WithEvents BAbrir As Button
    Friend WithEvents BGuardar As Button
    Private WithEvents DialogGuardar As SaveFileDialog
    Private WithEvents DialogAbrir As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLAcercaDe As LinkLabel
    Friend WithEvents GBMoneda As GroupBox
    Friend WithEvents RBTodoMoneda As RadioButton
    Friend WithEvents RBPeso As RadioButton
    Friend WithEvents RBDolar As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents CBProveedor As ComboBox
End Class
