<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FEliminar
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
        Me.BAceptar = New System.Windows.Forms.Button()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.MTCodigo = New System.Windows.Forms.MaskedTextBox()
        Me.Numer = New System.Windows.Forms.Label()
        Me.GBEliminarDesdeCodigo = New System.Windows.Forms.GroupBox()
        Me.GBEliminarDesdeCodigo.SuspendLayout()
        Me.SuspendLayout()
        '
        'BAceptar
        '
        Me.BAceptar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BAceptar.Location = New System.Drawing.Point(12, 104)
        Me.BAceptar.Name = "BAceptar"
        Me.BAceptar.Size = New System.Drawing.Size(103, 29)
        Me.BAceptar.TabIndex = 11
        Me.BAceptar.Text = "Aceptar"
        Me.BAceptar.UseVisualStyleBackColor = True
        '
        'BCancelar
        '
        Me.BCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BCancelar.Location = New System.Drawing.Point(155, 104)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(99, 29)
        Me.BCancelar.TabIndex = 12
        Me.BCancelar.Text = "Cancelar"
        Me.BCancelar.UseVisualStyleBackColor = True
        '
        'MTCodigo
        '
        Me.MTCodigo.Location = New System.Drawing.Point(98, 26)
        Me.MTCodigo.Mask = "0000"
        Me.MTCodigo.Name = "MTCodigo"
        Me.MTCodigo.Size = New System.Drawing.Size(33, 20)
        Me.MTCodigo.TabIndex = 25
        Me.MTCodigo.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.MTCodigo.ValidatingType = GetType(Integer)
        '
        'Numer
        '
        Me.Numer.AutoSize = True
        Me.Numer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Numer.Location = New System.Drawing.Point(6, 21)
        Me.Numer.Name = "Numer"
        Me.Numer.Size = New System.Drawing.Size(86, 25)
        Me.Numer.TabIndex = 24
        Me.Numer.Text = "Código:"
        '
        'GBEliminarDesdeCodigo
        '
        Me.GBEliminarDesdeCodigo.Controls.Add(Me.Numer)
        Me.GBEliminarDesdeCodigo.Controls.Add(Me.MTCodigo)
        Me.GBEliminarDesdeCodigo.Location = New System.Drawing.Point(55, 12)
        Me.GBEliminarDesdeCodigo.Name = "GBEliminarDesdeCodigo"
        Me.GBEliminarDesdeCodigo.Size = New System.Drawing.Size(158, 66)
        Me.GBEliminarDesdeCodigo.TabIndex = 32
        Me.GBEliminarDesdeCodigo.TabStop = False
        Me.GBEliminarDesdeCodigo.Text = "Eliminar"
        '
        'FEliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(266, 153)
        Me.Controls.Add(Me.GBEliminarDesdeCodigo)
        Me.Controls.Add(Me.BCancelar)
        Me.Controls.Add(Me.BAceptar)
        Me.Name = "FEliminar"
        Me.Text = "Eliminar"
        Me.GBEliminarDesdeCodigo.ResumeLayout(False)
        Me.GBEliminarDesdeCodigo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BAceptar As Button
    Friend WithEvents BCancelar As Button
    Friend WithEvents Numer As Label
    Friend WithEvents GBEliminarDesdeCodigo As GroupBox
    Private WithEvents MTCodigo As MaskedTextBox
End Class
