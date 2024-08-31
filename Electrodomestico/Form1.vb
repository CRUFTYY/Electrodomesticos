Public Class Form1
    Private electro As Electro
    Private lavarropas As Lavarropa
    Private heladera As Heladera

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbo_color.Items.AddRange({"Amarillo", "Magenta", "Oro", "Rojo"})
        cbo_color.SelectedIndex = 0

        gpb_alta.Enabled = False
        gpb_comprar.Enabled = False
        gpb_venta.Enabled = False

    End Sub

    Private Sub txt_capacidad_Keypress(sender As Object, e As KeyPressEventArgs) Handles txt_capacidad.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_consumo_Keypress(sender As Object, e As KeyPressEventArgs) Handles txt_consumo.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_alta_Click(sender As Object, e As EventArgs) Handles btn_alta.Click
        Try
            If rb_heladera.Checked Then
                heladera = CrearHeladera()
            ElseIf rb_lavarropas.Checked Then
                lavarropas = CrearLavarropas()
            ElseIf rb_otro.Checked Then
                electro = CrearOtro()
            End If

            ActivarCompra()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Function CrearHeladera()
        Dim modelo As String = txt_modelo.Text
        Dim descripcion As String = txt_descripcion.Text
        Dim capacidad As Integer = Val(txt_capacidad.Text)
        Dim conFreezer As Boolean = rb_Freezer.Checked
        Dim consumo As Integer = Val(txt_consumo.Text)
        Dim color As String = cbo_color.Text

        rb_Freezer.Visible = True
        rb_SinFreezer.Visible = True

        Return New Heladera(modelo, descripcion, capacidad, conFreezer, consumo, color)
    End Function

    Private Function CrearLavarropas()
        Dim modelo As String = txt_modelo.Text
        Dim descripcion As String = txt_descripcion.Text
        Dim capacidad As Integer = Val(txt_capacidad.Text)
        Dim cargaSuperior As Boolean = rb_CargaSuperior.Checked
        Dim consumo As Integer = Val(txt_consumo.Text)

        rb_CargaFrontal.Visible = True
        rb_CargaSuperior.Visible = True

        Return New Lavarropa(modelo, descripcion, capacidad, cargaSuperior, consumo)
    End Function

    Private Function CrearOtro() As Electro
        Dim modelo As String = txt_modelo.Text
        Dim descripcion As String = txt_descripcion.Text

        rb_CargaFrontal.Checked = True

        Return New Otro(modelo, descripcion)
    End Function

    Private Sub btn_comprar_Click(sender As Object, e As EventArgs) Handles btn_comprar.Click
        ' Convierte los valores de los TextBox a los tipos adecuados
        Dim cantidad As Integer
        Dim precioUnitario As Single

        ' Usa TryParse para manejar conversiones con errores
        If Integer.TryParse(txt_cantidadCompra.Text, cantidad) AndAlso Single.TryParse(txt_PrecioDeCompra.Text, precioUnitario) Then
            ' Verifica si la cantidad es mayor que 0
            If cantidad > 0 Then
                ' Actualiza el stock y realiza la compra
                If rb_lavarropas.Checked AndAlso lavarropas IsNot Nothing Then
                    lavarropas.Comprar(cantidad, precioUnitario)
                    txt_stock.Text = lavarropas.GetStock.ToString()
                    txt_PrecioVenta.Text = lavarropas.PrecioDeVenta().ToString()

                ElseIf rb_heladera.Checked AndAlso heladera IsNot Nothing Then
                    heladera.Comprar(cantidad, precioUnitario)
                    txt_stock.Text = heladera.GetStock.ToString()
                    txt_PrecioVenta.Text = heladera.PrecioDeVenta().ToString()


                ElseIf rb_otro.Checked AndAlso electro IsNot Nothing Then
                    electro.Comprar(cantidad, precioUnitario)
                    txt_stock.Text = electro.GetStock.ToString()
                    txt_PrecioVenta.Text = electro.PrecioDeVenta().ToString()

                End If
                gpb_venta.Enabled = cantidad > 0
            End If
        End If
    End Sub


    Private Sub ActivarAlta()
        If Not (String.IsNullOrEmpty(txt_modelo.Text) And Not String.IsNullOrEmpty(txt_descripcion.Text)) And (rb_CargaFrontal.Checked Or rb_heladera.Checked Or rb_lavarropas.Checked Or rb_otro.Checked) Then
            If rb_heladera.Checked Then
                CrearHeladera()
            End If

            If rb_lavarropas.Checked Then
                CrearLavarropas()
            End If

            If rb_otro.Checked Then
                CrearOtro()
            End If
            gpb_alta.Enabled = True
            gpb_producto.Enabled = False
        End If

    End Sub

    Private Sub ActivarCompra()
        If Not (String.IsNullOrEmpty(txt_capacidad.Text) And Not String.IsNullOrEmpty(txt_consumo.Text)) And (rb_CargaFrontal.Checked Or rb_CargaSuperior.Checked Or rb_SinFreezer.Checked Or rb_Freezer.Checked) Then
            gpb_comprar.Enabled = True
            gpb_alta.Enabled = False
        Else
            MsgBox("Debe completar todos los items antes de continuar.")
        End If
    End Sub

    Private Sub rb_lavarropas_CheckedChanged(sender As Object, e As EventArgs) Handles rb_lavarropas.CheckedChanged
        ActivarAlta()
    End Sub

    Private Sub rb_heladera_CheckedChanged(sender As Object, e As EventArgs) Handles rb_heladera.CheckedChanged
        ActivarAlta()
    End Sub

    Private Sub rb_otro_CheckedChanged(sender As Object, e As EventArgs) Handles rb_otro.CheckedChanged
        ActivarAlta()
    End Sub

    Private Sub txt_descripcion_TextChanged(sender As Object, e As EventArgs) Handles txt_descripcion.TextChanged
        ActivarAlta()
    End Sub

    Private Sub txt_modelo_TextChanged(sender As Object, e As EventArgs) Handles txt_modelo.TextChanged
        ActivarAlta()
    End Sub

    Private Sub txt_stock_TextChanged(sender As Object, e As EventArgs) Handles txt_stock.TextChanged

    End Sub

    Private Sub txt_cantidadCompra_Keypress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidadCompra.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_PrecioDeCompra_Keypress(sender As Object, e As KeyPressEventArgs) Handles txt_PrecioDeCompra.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cantidadVenta_Keypress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidadVenta.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btn_vender_Click(sender As Object, e As EventArgs) Handles btn_vender.Click
        Dim cantidad As Integer = txt_cantidadVenta.Text

        ' Verifica si la cantidad es mayor que 0
        If cantidad > 0 Then
            Dim ventaExitosa As Boolean = False

            If rb_lavarropas.Checked AndAlso lavarropas IsNot Nothing Then
                ventaExitosa = lavarropas.Vender(cantidad)
                txt_stock.Text = lavarropas.GetStock.ToString()


            ElseIf rb_heladera.Checked AndAlso heladera IsNot Nothing Then
                ventaExitosa = heladera.Vender(cantidad)
                txt_stock.Text = heladera.GetStock.ToString()

            ElseIf rb_otro.Checked AndAlso electro IsNot Nothing Then
                ventaExitosa = electro.Vender(cantidad)
                txt_stock.Text = electro.GetStock.ToString()
            End If
            gpb_venta.Enabled = Not txt_stock.Text <= 0
            ' Muestra el resultado de la venta
            If ventaExitosa Then
                MessageBox.Show("Venta realizada con éxito.")
            Else
                MessageBox.Show("No hay suficiente stock para realizar la venta.")
            End If

        Else
            gpb_venta.Enabled = False
        End If

    End Sub


    Private Sub txt_PrecioVenta_TextChanged(sender As Object, e As EventArgs) Handles txt_PrecioVenta.TextChanged
        Dim cantidad As Integer = txt_cantidadCompra.Text
        Dim precioUnitario As Single = txt_PrecioDeCompra.Text

        If rb_lavarropas.Checked AndAlso lavarropas IsNot Nothing Then
            lavarropas.PrecioDeVenta()

        ElseIf rb_heladera.Checked AndAlso heladera IsNot Nothing Then
            heladera.PrecioDeVenta()

        ElseIf rb_otro.Checked AndAlso electro IsNot Nothing Then
            electro.PrecioDeVenta()
        End If
    End Sub
End Class
