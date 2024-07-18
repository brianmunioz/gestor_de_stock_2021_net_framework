Public Class FEliminar
    Public FELCodigo As Integer

    Private Sub BAceptar_Click(sender As Object, e As EventArgs) Handles BAceptar.Click
        Dim codigo As Integer

        If MTCodigo.Text = "" Then
            MsgBox("El campo está vacio", MsgBoxStyle.Exclamation, "ERROR")
            MTCodigo.Focus()

        Else
            codigo = MTCodigo.Text
            Eliminar(codigo)

            DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub

    Private Sub FEliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    'Private Sub MTCodigo_Leave(sender As Object, e As EventArgs) Handles MTCodigo.Leave
    '    If MTCodigo.Text = "" Then
    '        MsgBox("El campo está vacio", MsgBoxStyle.Exclamation, "ERROR")
    '        MTCodigo.Focus()
    '    End If
    'End Sub
End Class