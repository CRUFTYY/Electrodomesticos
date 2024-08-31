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
            Dim Modelo As String = txt_modelo.Text
            Dim Descripcion As String = txt_descripcion.Text



            If rb_heladera.Checked Then
                CrearHeladera()
            End If

            If rb_lavarropas.Checked Then
                CrearLavarropas
            End If

            If rb_otro.Checked Then
                CrearOtro()
            End If
            ActivarCompra()


        Catch ex As Exception

        End Try
    End Sub

    Private Function CrearHeladera()
        Dim modelo As String = txt_modelo.Text
        Dim descripcion As String = txt_descripcion.Text
        Dim capacidad As Integer = Integer.Parse(txt_capacidad.Text)
        Dim conFreezer As Boolean = rb_Freezer.Checked
        Dim consumo As Integer = Integer.Parse(txt_consumo.Text)
        Dim color As String = cbo_color.Text

        rb_Freezer.Visible = True
        rb_SinFreezer.Visible = True

        Return New Heladera(modelo, descripcion, capacidad, conFreezer, consumo, color)
    End Function

    Private Function CrearLavarropas()
        Dim modelo As String = txt_modelo.Text
        Dim descripcion As String = txt_descripcion.Text
        Dim capacidad As Integer = Integer.Parse(txt_capacidad.Text)
        Dim cargaSuperior As Boolean = rb_CargaSuperior.Checked
        Dim consumo As Integer = Integer.Parse(txt_consumo.Text)

        rb_CargaFrontal.Enabled = True
        rb_CargaSuperior.Enabled = True

        Return New Lavarropa(modelo, descripcion, capacidad, cargaSuperior, consumo)
    End Function

    Private Function CrearOtro() As Electro
        Dim modelo As String = txt_modelo.Text
        Dim descripcion As String = txt_descripcion.Text

        Return New Otro(modelo, descripcion)
    End Function


    Private Sub ActivarAlta()
        If Not (String.IsNullOrEmpty(txt_modelo.Text) And String.IsNullOrEmpty(txt_descripcion.Text)) And (rb_CargaFrontal.Checked Or rb_heladera.Checked Or rb_lavarropas.Checked Or rb_otro.Checked) Then
            gpb_alta.Enabled = True
            gpb_producto.Enabled = False
        End If
    End Sub

    Private Sub ActivarCompra()
        If Not (String.IsNullOrEmpty(txt_capacidad.Text) And String.IsNullOrEmpty(txt_consumo.Text)) And (rb_CargaFrontal.Checked Or rb_CargaSuperior.Checked Or rb_SinFreezer.Checked Or rb_Freezer.Checked) Then
            gpb_venta.Enabled = True
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
End Class
