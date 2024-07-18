Public Class FCelulares
#Region "Rutinas"
    Private Function Repetido(ByVal proveedor As String, ByVal cbproveedor As ComboBox) As Boolean
        'Verifica que no haya un proveedor repetido en el combobox
        Dim existe As Boolean = False
        For pos = 0 To cbproveedor.Items.Count - 1
            If cbproveedor.Items(pos) = proveedor Then
                existe = True
            End If
        Next
        Return existe
    End Function
    Private Sub CargarDatosRT()
        'Carga todos los datos del rich text al arreglo de basedatos
        Dim marca, modelo, almacenamiento, condicion, moneda, fecha, proveedor As String
        Dim precio, codigo, cantidad As Integer
        Dim i As Integer = 0
        Dim pos As Integer = -1
        While i < RTDatos.Lines.Count - 1
            proveedor = RTDatos.Lines(i)
            codigo = RTDatos.Lines(i + 1)
            marca = RTDatos.Lines(i + 2)
            modelo = RTDatos.Lines(i + 3)
            condicion = RTDatos.Lines(i + 4)
            almacenamiento = RTDatos.Lines(i + 5)
            moneda = RTDatos.Lines(i + 6)
            precio = RTDatos.Lines(i + 7)
            cantidad = RTDatos.Lines(i + 8)
            fecha = RTDatos.Lines(i + 9)
            pos += 1
            Insertar(proveedor, codigo, fecha, marca, modelo, almacenamiento, condicion, cantidad, precio, moneda)
            AgregarItems(proveedor, moneda, almacenamiento, marca, i)
            i += 10
        End While

    End Sub
    Private Sub Listar()
        Dim i, x, fin As Integer
        Dim almacenamiento As String = CBAlmacenamiento.Text
        Dim todosLosItems As String
        Dim marca, moneda As String
        Dim proveedorSTR As String = CBProveedor.Text
        If RBTodos.Checked Then
            marca = RBTodos.Text
        ElseIf RBSamsung.Checked Then
            marca = RBSamsung.Text.ToUpper
        ElseIf RBApple.Checked Then
            marca = RBApple.Text.ToUpper
        Else
            marca = RBXiaomi.Text.ToUpper
        End If
        If RBTodoMoneda.Checked Then
            moneda = RBTodoMoneda.Text
        ElseIf RBPeso.Checked Then
            moneda = "$"
        Else
            moneda = "U$D"
        End If

        fin = UltimoLugarDelArreglo()
        LBCelulares.Items.Clear()
        For x = 0 To fin
            If Not Repetido(Proveedor(x), CBProveedor) Then
                CBProveedor.Items.Add(Proveedor(x))
            End If
        Next
        For i = 0 To fin
            todosLosItems = AgregarItems(proveedorSTR, moneda, almacenamiento, marca, i)
            If todosLosItems <> "" Then LBCelulares.Items().Add(todosLosItems)
        Next i
    End Sub
    Private Sub Actualizar()
        Listar()
        LTotal.Text = "Cantidad de celulares en la lista:  " & LBCelulares.Items.Count
    End Sub
#End Region
#Region "Eventos"
    Private Sub BAgregar_Click(sender As Object, e As EventArgs) Handles BAgregar.Click
        Dim celular As Form
        If Not HayLugarDisponible() Then
            MsgBox("No hay lugares disponible ¿Desea agrandar la capacidad?", MsgBoxStyle.Exclamation, "ERROR")
        Else

            celular = New FAgregar
            celular.ShowDialog()
            Dim datos As String = DatosRT()
            RTDatos.Text = datos
            RTDatos.SaveFile("datos.rtf")

            Actualizar()
        End If
    End Sub
    Private Sub RBTodos_CheckedChanged(sender As Object, e As EventArgs) Handles RBTodos.CheckedChanged
        Actualizar()
    End Sub

    Private Sub RBSamsung_CheckedChanged(sender As Object, e As EventArgs) Handles RBSamsung.CheckedChanged
        Actualizar()
    End Sub

    Private Sub RBApple_CheckedChanged(sender As Object, e As EventArgs) Handles RBApple.CheckedChanged
        Actualizar()
    End Sub

    Private Sub RBXiaomi_CheckedChanged(sender As Object, e As EventArgs) Handles RBXiaomi.CheckedChanged
        Actualizar()
    End Sub

    Private Sub CBAlmacenamiento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBAlmacenamiento.SelectedIndexChanged
        Actualizar()
    End Sub

    Private Sub BEliminar_Click(sender As Object, e As EventArgs)
        FEliminar.ShowDialog()
        Dim datos As String = DatosRT()
        RTDatos.Text = datos
        Actualizar()
    End Sub

    Private Sub FCelulares_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RTDatos.LoadFile("datos.rtf")
        CargarDatosRT()
        CBAlmacenamiento.SelectedIndex = 0
        CBProveedor.SelectedIndex = 0
        Actualizar()
    End Sub

    Private Sub BGuardar_Click(sender As Object, e As EventArgs) Handles BGuardar.Click
        If DialogGuardar.ShowDialog() = DialogResult.OK Then
            RTDatos.SaveFile(DialogGuardar.FileName)
        End If
    End Sub

    Private Sub BCerrar_Click(sender As Object, e As EventArgs) Handles BCerrar.Click
        Select Case MsgBox("¿Realmente desea salir?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Consulta")
            Case MsgBoxResult.Yes : Close()
        End Select

    End Sub

    Private Sub BAbrir_Click(sender As Object, e As EventArgs) Handles BAbrir.Click
        If DialogAbrir.ShowDialog() = DialogResult.OK Then
            RTDatos.LoadFile(DialogAbrir.FileName)
            Inicializar()
            CargarDatosRT()
            Actualizar()
        End If

    End Sub

    Private Sub LinkLAcercaDe_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLAcercaDe.LinkClicked
        FAcercaDe.ShowDialog()
    End Sub

    Private Sub BResetar_Click(sender As Object, e As EventArgs) Handles BResetar.Click

        Select Case MsgBox("¿Está seguro que desea resetear todos los campos ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Información")
            Case MsgBoxResult.Yes
                CBAlmacenamiento.SelectedIndex = 0
                CBProveedor.SelectedIndex = 0
                RBTodoMoneda.Checked = True
                RBTodos.Checked = True
                Inicializar()
                RTDatos.Clear()
                LBCelulares.Items.Clear()
                CargarDatosRT()
                Actualizar()
                MsgBox("Para que se guarden los datos en el archivo presionar ""Guardar datos en otro archivo""", MsgBoxStyle.Information, "Información")
        End Select
    End Sub

    Private Sub RBTodoMoneda_CheckedChanged(sender As Object, e As EventArgs) Handles RBTodoMoneda.CheckedChanged
        Actualizar()
    End Sub

    Private Sub RBPeso_CheckedChanged(sender As Object, e As EventArgs) Handles RBPeso.CheckedChanged
        Actualizar()
    End Sub

    Private Sub RBDolar_CheckedChanged(sender As Object, e As EventArgs) Handles RBDolar.CheckedChanged
        Actualizar()
    End Sub

    Private Sub CBProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBProveedor.SelectedIndexChanged
        Actualizar()
    End Sub
#End Region
End Class
