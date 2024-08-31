Public Class Lavarropa
    Inherits Electro
    Public Property Capacidad As Integer
    Public Property CargaSuperior As Boolean
    Public Property Consumo As Integer

    ' Constructor
    Public Sub New(modelo As String, descripcion As String, capacidad As Integer, cargaSuperior As Boolean, consumo As Integer)
        ' Llamada al constructor de la clase base
        MyBase.New(modelo, descripcion)
        Me.Capacidad = capacidad
        Me.CargaSuperior = cargaSuperior
        Me.Consumo = consumo

    End Sub

    Public Function PrecioDeVenta() As Single
        If Me.GetStock() > 100 Then
            Return Me.GetPrecioDeCompra
        Else
            Dim PrecioDeVentaModificado As Single = Me.GetPrecioDeCompra + (Me.GetPrecioDeCompra * 1.2)
            Return PrecioDeVentaModificado
        End If
    End Function
End Class
