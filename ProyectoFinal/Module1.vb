Module Base_Datos
#Region "Estructuras"
    Private Structure TipoCelular
        Dim Almacenamiento As String
        Dim marca As String
        Dim modelo As String
        Dim cantidad As Integer
        Dim Precio As Integer
        Dim Moneda As String
        Dim Codigo As Integer
        Dim Fecha As String
    End Structure
#End Region
#Region "Variables Globales"
    Dim ultimo As Integer = -1
    Dim tope As Integer = 20
    Dim arStock(tope) As TipoCelular

#End Region
#Region "Privados"
    Private Function BuscarPos(modelo As String, marca As String, almacenamiento As String) As Integer
        Dim pos As Integer = -1
        If ultimo > -1 Then
            pos = 0
            While pos <= 0 AndAlso arStock(pos).modelo <> modelo AndAlso arStock(pos).marca <> marca AndAlso arStock(pos).Almacenamiento <> almacenamiento
                pos += 1
            End While
            If pos > ultimo Then
                pos = -1
            End If

            Return pos

        End If
    End Function

#End Region
#Region "Publicos"
    Public Sub EliminarCelular(codigo As Integer)
        Dim pos As Integer
        pos = BuscarPos(modelo, marca, almacenamiento)
        arStock(pos) = arStock(ultimo)
        ultimo -= 1
    End Sub
    Private Function ExisteNuevo(ByVal arreglo() As TipoCelular, ByVal ultimo As Integer) As Boolean
        Dim Existe As Boolean = False
        Dim i As Integer = 0
        If ultimo > -1 Then
            While Not Existe And i <= ultimo
                If arreglo(ultimo).marca = FAgregar.SECMarca And
                    arreglo(ultimo).modelo.ToUpper.Trim = FAgregar.SECModelo.ToUpper.Trim And
                    arreglo(ultimo).Almacenamiento = FAgregar.SECAlmacenamiento Then
                    Existe = True
                Else
                    i += 1
                End If
            End While
        End If
        Return Existe
    End Function
    Private Sub AgregarCelular(ByRef arreglo() As TipoCelular, ByRef ultimo As Integer, ByVal tope As Integer)
        Dim existe As Boolean
        existe = ExisteNuevo(arStock, ultimo)

        If ultimo < tope And Not existe Then
            ultimo += 1
            arreglo(ultimo).Almacenamiento = FAgregar.SECAlmacenamiento
            arreglo(ultimo).modelo = FAgregar.SECModelo
            arreglo(ultimo).cantidad = FAgregar.SECcantidad
            arreglo(ultimo).Precio = FAgregar.SECPrecio
            arreglo(ultimo).Codigo = ultimo + 1
            arreglo(ultimo).marca = FAgregar.SECMarca
            arreglo(ultimo).Fecha = DateTime.Now
            arreglo(ultimo).Moneda = FAgregar.SECMoneda
            GBMarca.Enabled = True
            CBAlmacenamiento.Enabled = True
            CheckOrdenado.Enabled = True
        End If
    End Sub
    Private Sub AgregarItems(ByVal arreglo() As TipoCelular, ByVal ultimo As Integer)
        Dim i As Integer
        Dim chequeado, moneda As String

        LBCelulares.Items.Clear()
        If RBTodos.Checked Then
            chequeado = RBTodos.Text
        ElseIf RBSamsung.Checked Then
            chequeado = RBSamsung.Text.ToUpper
        ElseIf RBApple.Checked Then
            chequeado = RBApple.Text.ToUpper
        Else
            chequeado = RBXiaomi.Text.ToUpper
        End If


        For i = 0 To ultimo

            If CBAlmacenamiento.Text = "Todos" OrElse arreglo(i).Almacenamiento = CBAlmacenamiento.Text Then
                If chequeado = RBTodos.Text Then

                    Select Case arreglo(i).Moneda
                        Case "Peso Argentino"
                            moneda = "$"
                        Case Else
                            moneda = "U$D"
                    End Select

                    LBCelulares.Items.Add("Código: " & arreglo(i).Codigo & "  |  " & arreglo(i).marca &
                         " " & arreglo(i).modelo & "  |  Almacenamiento interno: " & arreglo(i).Almacenamiento &
                        " | Precio: " & moneda & " " & arreglo(i).Precio &
                       "  |  " & arreglo(i).cantidad & " Unidades" & "   |             Última Modificación: " & arreglo(i).Fecha
                        )
                ElseIf arreglo(i).marca = chequeado Then

                    Select Case arreglo(i).Moneda
                        Case "Peso Argentino"
                            moneda = "$"
                        Case Else
                            moneda = "U$D"
                    End Select
                    LBCelulares.Items.Add("Código: " & arreglo(i).Codigo & " |" & arreglo(i).marca &
                         " " & arreglo(i).modelo & " |Almacenamiento interno: " & arreglo(i).Almacenamiento &
                        " |Precio: " & moneda & " " & arreglo(i).Precio &
                       " |" & arreglo(i).cantidad & " Unidades" & "  |Ultima Modificación: " & arreglo(i).Fecha
                        )
                End If
            End If
        Next i
        LTotal.Text = "Total: " & LBCelulares.Items.Count
    End Sub



#End Region


End Module
