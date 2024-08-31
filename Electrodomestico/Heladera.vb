Public Class Heladera
    Inherits Electro
    Public Property Capacidad As Integer
    Public Property ConFreezer As Boolean
    Public Property Consumo As Integer
    Public Property Color As String
    Public Sub New(Modelo As String, descripcion As String, capacidad As Integer, confreezer As Boolean, consumo As String, color As String)

        MyBase.New(Modelo, descripcion)
        Me.Capacidad = capacidad
        Me.ConFreezer = confreezer
        Me.Consumo = consumo
        Me.Color = color
    End Sub

    Public Function PrecioDeVenta() As Single
        Dim PrecioDeVentaModificado As Single = Me.GetPrecioDeCompra + (Me.GetPrecioDeCompra * 1.4)
        Return PrecioDeVentaModificado
    End Function
End Class
