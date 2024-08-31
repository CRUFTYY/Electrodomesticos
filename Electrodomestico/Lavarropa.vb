Public Class Lavarropa
    Public Property Capacidad As Integer
    Public Property CargaSuperior As Boolean
    Public Property Consumo As Integer

    ' Constructor
    Public Sub New(modelo As String, descripcion As String, capacidad As Integer, cargaSuperior As Boolean, consumo As Integer)
        ' Llamada al constructor de la clase base
        MyBase.New()
        Me.Capacidad = capacidad
        Me.CargaSuperior = cargaSuperior
        Me.Consumo = consumo

    End Sub
End Class
