Public Class Electro
    Private modelo As String
    Private descripcion As String
    Private stock As Integer ' Cambiado de String a Integer
    Private PrecioDeCompra As Single

    ' Constructor
    Public Sub New(Modelo As String, descripcion As String)
        Me.modelo = Modelo
        Me.descripcion = descripcion
        Me.stock = 0
        Me.PrecioDeCompra = 0.0F
    End Sub

    ' Propiedades públicas
    Public Property GetModelo() As String
        Get
            Return Me.modelo
        End Get
        Set(value As String)
            Me.modelo = value
        End Set
    End Property

    Public Property GetDescripcion() As String
        Get
            Return Me.descripcion
        End Get
        Set(value As String)
            Me.descripcion = value
        End Set
    End Property

    Public ReadOnly Property GetPrecioDeCompra() As Single
        Get
            Return Me.PrecioDeCompra
        End Get
    End Property

    Public ReadOnly Property GetStock() As Integer
        Get
            Return Me.stock
        End Get
    End Property


    Public Sub Comprar(Cantidad As Integer, PrecioUnitario As Integer)
        Me.stock += Cantidad
        Me.PrecioDeCompra = PrecioUnitario
    End Sub

    Public Function Vender(Cantidad As Integer) As Boolean
        If Me.stock >= Cantidad Then
            Me.stock -= Cantidad
            Return True
        Else
            Return False
        End If
    End Function

    Public Function PrecioDeVenta() As Single
        Dim PrecioDeVentaModificado As Single = Me.PrecioDeCompra + (Me.PrecioDeCompra * 1.2)
        Return PrecioDeVentaModificado
    End Function
End Class
