Module BaseDatos
#Region "Estructuras"
    Structure TipoCelular
        Dim proveedor As String
        Dim Almacenamiento As String
        Dim marca As String
        Dim modelo As String
        Dim cantidad As Integer
        Dim Precio As Integer
        Dim Moneda As String
        Dim Codigo As Integer
        Dim Fecha As String
        Dim condicion As String
    End Structure
#End Region
#Region "Variables Globales"
    Dim ultimo As Integer = -1
    Dim tope As Integer = 1000
    Dim arStock(tope) As TipoCelular

#End Region
#Region "Privado"
    Private Function BuscarPos(proveedor As String, marca As String, modelo As String, almacenamiento As String, condicion As String) As Integer
        Dim pos As Integer = -1
        If ultimo > -1 Then
            pos = 0
            While pos <= ultimo AndAlso (arStock(pos).proveedor <> proveedor OrElse arStock(pos).marca <> marca OrElse arStock(pos).modelo <> modelo OrElse
                    arStock(pos).Almacenamiento <> almacenamiento OrElse arStock(pos).condicion <> condicion)
                pos += 1
            End While
            If pos > ultimo Then
                pos = -1
            End If

        End If
        Return pos
    End Function
#End Region
#Region "Consultar datos"

    Public Function Proveedor(pos As Integer) As String
        Return arStock(pos).proveedor
    End Function

    Public Function DatosRT() As String
        'Datos Para cargar el richtext
        Dim i As Integer
        Dim datos As String = ""
        For i = 0 To ultimo
            datos &= arStock(i).proveedor & vbNewLine & arStock(i).Codigo & vbNewLine & arStock(i).marca &
                        vbNewLine & arStock(i).modelo & vbNewLine & arStock(i).condicion & vbNewLine & arStock(i).Almacenamiento &
                       vbNewLine & arStock(i).Moneda & vbNewLine & arStock(i).Precio &
                      vbNewLine & arStock(i).cantidad & vbNewLine & arStock(i).Fecha & vbNewLine
        Next
        Return datos
    End Function
    Public Function BuscarPosPorCodigo(codigo As Integer) As Integer
        Dim pos As Integer = -1
        If ultimo > -1 Then
            pos = 0
            While pos <= ultimo AndAlso arStock(pos).Codigo <> codigo
                pos += 1
            End While
            If pos > ultimo Then
                pos = -1
            End If
        End If

        Return pos
    End Function
    Public Sub MostrarDatos(ByRef proveedor As String, pos As Integer, ByRef marca As String, ByRef modelo As String, ByRef almacenamiento As String, ByRef condicion As String, ByRef cantidad As Integer,
                       ByRef precio As Integer, ByRef moneda As String)
        'Muestra los datos del formulario agregar en caso de que quiera modificar o eliminar  
        proveedor = arStock(pos).proveedor
        marca = arStock(pos).marca
        modelo = arStock(pos).modelo
        almacenamiento = arStock(pos).Almacenamiento
        condicion = arStock(pos).condicion
        cantidad = arStock(pos).cantidad
        precio = arStock(pos).Precio
        moneda = arStock(pos).Moneda
    End Sub
    Public Sub ModificarDatos(pos As Integer, proveedor As String, marca As String, modelo As String, almacenamiento As String, condicion As String, cantidad As Integer,
                        precio As Integer, moneda As String)

        arStock(pos).proveedor = proveedor
        arStock(pos).marca = marca
        arStock(pos).modelo = modelo
        arStock(pos).Almacenamiento = almacenamiento
        arStock(pos).condicion = condicion
        arStock(pos).cantidad = cantidad
        arStock(pos).Precio = precio
        arStock(pos).Moneda = moneda
        arStock(pos).Fecha = DateTime.Now
    End Sub
    Public Function UltimoLugarDelArreglo() As Integer
        Return ultimo
    End Function
    Public Function HayLugarDisponible() As Boolean
        Return ultimo < tope
    End Function
    Public Function CantidadTotal() As Integer
        Return ultimo + 1
    End Function
    Public Function Existe(proveedor As String, marca As String, modelo As String, almacenamiento As String, condicion As String) As Boolean
        Dim pos As Integer
        pos = BuscarPos(proveedor, marca, modelo, almacenamiento, condicion)
        Return pos > -1
    End Function
    Public Function GenerarCodigo() As Integer
        Dim codigo As Integer
        Dim existeCodigo As Boolean
        Dim nrorandom As New System.Random

        Do
            codigo = nrorandom.Next(1000, 9999)
            existeCodigo = False
            For x = 0 To ultimo
                If arStock(x).Codigo = codigo Then
                    existeCodigo = True
                End If
            Next
        Loop Until Not existeCodigo
        Return codigo
    End Function
    Public Sub Inicializar()
        ultimo = -1
    End Sub
    Public Sub Insertar(proveedor As String, codigo As Integer, fecha As String, marca As String, modelo As String, almacenamiento As String, condicion As String, cantidad As Integer,
                        precio As Integer, moneda As String)
        Dim pos As Integer


        Dim celular As TipoCelular
        celular.proveedor = proveedor.Trim.ToUpper
        celular.marca = marca
        celular.modelo = modelo
        celular.Almacenamiento = almacenamiento
        celular.condicion = condicion
        celular.cantidad = cantidad
        celular.Precio = precio
        celular.Codigo = codigo
        Select Case moneda
            Case "Peso Argentino", "$"
                moneda = "$"
            Case Else
                moneda = "U$D"
        End Select
        celular.Moneda = moneda
        celular.Fecha = fecha


        pos = ultimo
        While pos >= 0 AndAlso arStock(pos).proveedor > celular.proveedor
            arStock(pos + 1) = arStock(pos)
            pos -= 1
        End While
        arStock(pos + 1) = celular
        ultimo += 1

    End Sub
    Public Function AgregarItems(proveedor As String, moneda As String, almacenamiento As String, marca As String, i As Integer) As String
        'Completa los datos del combobox
        Dim Items As String = ""
        If (almacenamiento = "Todos" OrElse arStock(i).Almacenamiento = almacenamiento) And (marca = "Todos" OrElse arStock(i).marca = marca) And
            (proveedor = "Todos" OrElse arStock(i).proveedor = proveedor) And (moneda = "Todos" OrElse arStock(i).Moneda = moneda) Then
            Items = "Proveedor: " & arStock(i).proveedor & " | Código: " & arStock(i).Codigo & "  |  " & arStock(i).marca &
                       " " & arStock(i).modelo & " (" & arStock(i).condicion & ")  |  Almacenamiento interno: " & arStock(i).Almacenamiento &
                      " | Precio: " & arStock(i).Moneda & " " & arStock(i).Precio &
                     "  |  " & arStock(i).cantidad & " Unidades" & " |  Última Modificación: " & arStock(i).Fecha
        End If

        Return Items
    End Function
    Public Sub Eliminar(codigo As Integer)
        Dim Existe As Boolean = False
        Dim pos As Integer
        pos = BuscarPosPorCodigo(codigo)
        If pos >= 0 Then
            For i = pos To (ultimo - 1)
                arStock(i) = arStock(i + 1)
            Next

            ultimo -= 1
        End If
    End Sub

#End Region
End Module
