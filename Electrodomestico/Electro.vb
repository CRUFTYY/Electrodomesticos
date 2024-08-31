Public Class Electro
    Private modelo As String
    Private descripcion As String
    Private stock As String 'readonly
    Private PrecioDeCompra As Single 'readonly

    Public Sub New(Modelo As String, descripcion As String)
        Me.modelo = Modelo
        Me.descripcion = descripcion
        Me.stock = 0
        Me.PrecioDeCompra = 0.0F 'la F signifca que es Single 

    End Sub

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

    Public Property GetPrecioDeCompra() As Single
        Get
            Return Me.modelo
        End Get
        Set(value As Single)
            Me.modelo = value
        End Set
    End Property

    Public ReadOnly Property GetStock() As Integer
        Get
            Return Me.stock
        End Get
    End Property


    Public Sub comprar(Cantidad As Integer, PrecioUnitario As Integer)
        Me.stock += Cantidad
        Me.PrecioDeCompra = PrecioUnitario
    End Sub

    Public Function vender(Cantidad As Integer) As Boolean

        If stock >= stock Then
            stock -= Cantidad
            Return True
        Else

            Return False
        End If

    End Function

    Public Function PrecioDeVenta() As Single
        Dim PrecioDeVentaModificado As Single = Me.PrecioDeCompra * 1.2
        Return PrecioDeVentaModificado
    End Function


End Class
