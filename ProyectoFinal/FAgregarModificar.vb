Public Class FAgregar

#Region "Variables globales"
    Dim Modpos, Modcodigo As Integer
#End Region
#Region "Rutinas"
    Private Function Repetido(ByVal proveedor As String, ByVal cbproveedor As ComboBox) As Boolean
        Dim existe As Boolean = False
        For pos = 0 To cbproveedor.Items.Count - 1
            If cbproveedor.Items(pos) = proveedor Then
                existe = True
            End If
        Next
        Return existe
    End Function
#End Region
#Region "Eventos"
    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        Dim proveedor As String = CBProveedor.Text
        Dim marca As String = CBMarca.Text
        Dim modelo As String = TModelo.Text
        Dim condicion As String = "Nuevo"
        Dim cantidad As Integer = NUDCant.Value
        Dim almacenamiento As String = CBAlmacenamiento.Text
        Dim precio As Integer
        Dim moneda, codigo As String


        Dim fecha As String = DateTime.Now

        codigo = GenerarCodigo()
        If Existe(proveedor, marca, modelo, almacenamiento, condicion) Then
            MsgBox("El celular ingresado ya se encuentra en nuestra base de datos", MsgBoxStyle.Exclamation, "ERROR")
            TModelo.Focus()
        Else
            If CBMarca.Text = "" Then
                MsgBox("Debe completar el campo ""Marca""", MsgBoxStyle.Critical, "ERROR")
                CBMarca.Focus()
            ElseIf TModelo.Text = "" Then
                MsgBox("Debe completar el campo ""Modelo""", MsgBoxStyle.Critical, "ERROR")
                TModelo.Focus()
            ElseIf MTPrecio.Text = "" Then
                MsgBox("Debe completar el campo ""Precio""", MsgBoxStyle.Critical, "ERROR")
                MTPrecio.Focus()

            Else
                precio = MTPrecio.Text
                If CheckUsado.Checked Then
                    condicion = "Usado"
                Else
                    condicion = "Nuevo"
                End If
                If RBPeso.Checked Then
                    moneda = RBPeso.Text
                Else
                    moneda = RBDolar.Text
                End If
                Insertar(proveedor, codigo, fecha, marca, modelo, almacenamiento, condicion, cantidad, precio, moneda)
                MsgBox("El celular ha sido agregado", MsgBoxStyle.Information, "AGREGADO")
                DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub
    Private Sub FAgregar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim total As String = CantidadTotal()
        Dim ultimo As Integer = UltimoLugarDelArreglo()
        Dim i As Integer
        CBAlmacenamiento.SelectedIndex = 0
        CBMarca.SelectedIndex = 0

        LTotal.Text = "Total: " & total
        If ultimo > -1 Then
            For i = 0 To ultimo
                If Not Repetido(Proveedor(i), CBProveedor) Then CBProveedor.Items.Add(Proveedor(i))
            Next
            CBProveedor.SelectedIndex = 0
        End If
        If UltimoLugarDelArreglo() = -1 Then
            GBVerDatos.Enabled = False
        Else
            GBVerDatos.Enabled = True
        End If

    End Sub
    Private Sub BVerDatos_Click(sender As Object, e As EventArgs) Handles BVerDatos.Click

        Dim marca As String = ""
        Dim modelo As String = ""
        Dim condicion As String = ""
        Dim cantidad As Integer
        Dim almacenamiento As String = ""
        Dim precio As Integer
        Dim moneda As String = ""
        Dim proveedor As String = ""
        If MTCodigo.Text <> "" Then
            Modcodigo = MTCodigo.Text
            Modpos = BuscarPosPorCodigo(Modcodigo)
            If Modpos = -1 Then
                MsgBox("No existe dicho código en nuestra base de datos", MsgBoxStyle.Exclamation, "ERROR")
            Else

                MostrarDatos(proveedor, Modpos, marca, modelo, almacenamiento, condicion, cantidad, precio, moneda)


                CBMarca.SelectedIndex = CBMarca.Items.IndexOf(marca)
                CBAlmacenamiento.SelectedIndex = CBAlmacenamiento.Items.IndexOf(almacenamiento)
                TModelo.Text = modelo
                If condicion = CheckUsado.Text Then
                    CheckUsado.Checked = True
                Else
                    CheckUsado.Checked = False
                End If
                NUDCant.Value = cantidad
                MTPrecio.Text = precio
                If moneda = "U$D" Then
                    RBDolar.Checked = True
                Else
                    RBPeso.Checked = True
                End If
                BModificar.Enabled = True
                BEliminar.Enabled = True
            End If
        Else
            MsgBox("Debe ingresar un código si desea modificar los datos de algún celular", MsgBoxStyle.Exclamation, "ERROR")
        End If
    End Sub
    Private Sub BEliminar_Click(sender As Object, e As EventArgs) Handles BEliminar.Click
        Dim codigo, rta As Integer

        If MTCodigo.Text = "" Then
            MsgBox("El campo está vacio", MsgBoxStyle.Exclamation, "ERROR")
            MTCodigo.Focus()

        Else
            rta = MsgBox("¿Está seguro que desea eliminar este elemento?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Consulta")
            If rta = MsgBoxResult.Yes Then
                codigo = MTCodigo.Text
                Eliminar(codigo)
                MsgBox("Se ha eliminado el celular", MsgBoxStyle.Information, "Información")
                DialogResult = Windows.Forms.DialogResult.OK
            End If

        End If
    End Sub
    Private Sub BModificar_Click(sender As Object, e As EventArgs) Handles BModificar.Click
        Dim marca, modelo, almacenamiento, condicion, moneda As String
        Dim precio, cantidad As Integer
        Dim proveedor As String = CBProveedor.Text.Trim
        marca = CBMarca.Text
        modelo = TModelo.Text.Trim
        almacenamiento = CBAlmacenamiento.Text
        precio = MTPrecio.Text
        If CheckUsado.Checked Then
            condicion = "Usado"
        Else
            condicion = "Nuevo"
        End If
        If RBPeso.Checked Then
            moneda = RBPeso.Text
        Else
            moneda = RBDolar.Text
        End If
        Select Case moneda
            Case "Peso Argentino"
                moneda = "$"
            Case Else
                moneda = "U$D"
        End Select
        cantidad = NUDCant.Value

        ModificarDatos(Modpos, proveedor, marca, modelo, almacenamiento, condicion, cantidad, precio, moneda)
        MsgBox("Datos Modificados", MsgBoxStyle.Information, "Información")
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub
#End Region
End Class