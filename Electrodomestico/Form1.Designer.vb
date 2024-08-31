<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        gpb_producto = New GroupBox()
        GroupBox2 = New GroupBox()
        rb_otro = New RadioButton()
        rb_heladera = New RadioButton()
        rb_lavarropas = New RadioButton()
        Label2 = New Label()
        txt_descripcion = New TextBox()
        Label1 = New Label()
        txt_modelo = New TextBox()
        Label4 = New Label()
        txt_capacidad = New TextBox()
        Label3 = New Label()
        rb_CargaFrontal = New RadioButton()
        rb_CargaSuperior = New RadioButton()
        Label5 = New Label()
        txt_consumo = New TextBox()
        gpb_alta = New GroupBox()
        rb_SinFreezer = New RadioButton()
        rb_Freezer = New RadioButton()
        cbo_color = New ComboBox()
        btn_alta = New Button()
        Label7 = New Label()
        Label6 = New Label()
        gpb_comprar = New GroupBox()
        Label12 = New Label()
        btn_comprar = New Button()
        txt_PrecioDeCompra = New TextBox()
        txt_cantidadCompra = New TextBox()
        Label10 = New Label()
        Label9 = New Label()
        txt_stock = New TextBox()
        Label8 = New Label()
        gpb_venta = New GroupBox()
        Label13 = New Label()
        btn_vender = New Button()
        txt_PrecioVenta = New TextBox()
        txt_cantidadVenta = New TextBox()
        Label14 = New Label()
        gpb_producto.SuspendLayout()
        gpb_alta.SuspendLayout()
        gpb_comprar.SuspendLayout()
        gpb_venta.SuspendLayout()
        SuspendLayout()
        ' 
        ' gpb_producto
        ' 
        gpb_producto.Controls.Add(GroupBox2)
        gpb_producto.Controls.Add(rb_otro)
        gpb_producto.Controls.Add(rb_heladera)
        gpb_producto.Controls.Add(rb_lavarropas)
        gpb_producto.Controls.Add(Label2)
        gpb_producto.Controls.Add(txt_descripcion)
        gpb_producto.Controls.Add(Label1)
        gpb_producto.Controls.Add(txt_modelo)
        gpb_producto.Location = New Point(14, 14)
        gpb_producto.Margin = New Padding(4, 3, 4, 3)
        gpb_producto.Name = "gpb_producto"
        gpb_producto.Padding = New Padding(4, 3, 4, 3)
        gpb_producto.Size = New Size(556, 220)
        gpb_producto.TabIndex = 0
        gpb_producto.TabStop = False
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Location = New Point(564, 0)
        GroupBox2.Margin = New Padding(4, 3, 4, 3)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Padding = New Padding(4, 3, 4, 3)
        GroupBox2.Size = New Size(342, 220)
        GroupBox2.TabIndex = 7
        GroupBox2.TabStop = False
        GroupBox2.Text = "GroupBox1"
        ' 
        ' rb_otro
        ' 
        rb_otro.AutoSize = True
        rb_otro.Location = New Point(360, 168)
        rb_otro.Margin = New Padding(4, 3, 4, 3)
        rb_otro.Name = "rb_otro"
        rb_otro.Size = New Size(49, 19)
        rb_otro.TabIndex = 6
        rb_otro.TabStop = True
        rb_otro.Text = "Otro"
        rb_otro.UseVisualStyleBackColor = True
        ' 
        ' rb_heladera
        ' 
        rb_heladera.AutoSize = True
        rb_heladera.Location = New Point(225, 168)
        rb_heladera.Margin = New Padding(4, 3, 4, 3)
        rb_heladera.Name = "rb_heladera"
        rb_heladera.Size = New Size(72, 19)
        rb_heladera.TabIndex = 5
        rb_heladera.TabStop = True
        rb_heladera.Text = "Heladera"
        rb_heladera.UseVisualStyleBackColor = True
        ' 
        ' rb_lavarropas
        ' 
        rb_lavarropas.AutoSize = True
        rb_lavarropas.Location = New Point(51, 168)
        rb_lavarropas.Margin = New Padding(4, 3, 4, 3)
        rb_lavarropas.Name = "rb_lavarropas"
        rb_lavarropas.Size = New Size(82, 19)
        rb_lavarropas.TabIndex = 4
        rb_lavarropas.TabStop = True
        rb_lavarropas.Text = "Lavarropas"
        rb_lavarropas.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(18, 80)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 15)
        Label2.TabIndex = 3
        Label2.Text = "Descripcion"
        ' 
        ' txt_descripcion
        ' 
        txt_descripcion.Location = New Point(106, 80)
        txt_descripcion.Margin = New Padding(4, 3, 4, 3)
        txt_descripcion.Name = "txt_descripcion"
        txt_descripcion.Size = New Size(116, 23)
        txt_descripcion.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(18, 25)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(48, 15)
        Label1.TabIndex = 1
        Label1.Text = "Modelo"
        ' 
        ' txt_modelo
        ' 
        txt_modelo.Location = New Point(106, 22)
        txt_modelo.Margin = New Padding(4, 3, 4, 3)
        txt_modelo.Name = "txt_modelo"
        txt_modelo.Size = New Size(116, 23)
        txt_modelo.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(18, 30)
        Label4.Margin = New Padding(4, 0, 4, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 15)
        Label4.TabIndex = 1
        Label4.Text = "Color"
        ' 
        ' txt_capacidad
        ' 
        txt_capacidad.Location = New Point(106, 80)
        txt_capacidad.Margin = New Padding(4, 3, 4, 3)
        txt_capacidad.Multiline = True
        txt_capacidad.Name = "txt_capacidad"
        txt_capacidad.Size = New Size(58, 22)
        txt_capacidad.TabIndex = 2
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(18, 83)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(63, 15)
        Label3.TabIndex = 3
        Label3.Text = "Capacidad"
        ' 
        ' rb_CargaFrontal
        ' 
        rb_CargaFrontal.AutoSize = True
        rb_CargaFrontal.Location = New Point(172, 183)
        rb_CargaFrontal.Margin = New Padding(4, 3, 4, 3)
        rb_CargaFrontal.Name = "rb_CargaFrontal"
        rb_CargaFrontal.Size = New Size(74, 19)
        rb_CargaFrontal.TabIndex = 5
        rb_CargaFrontal.TabStop = True
        rb_CargaFrontal.Text = "C. frontal"
        rb_CargaFrontal.UseVisualStyleBackColor = True
        rb_CargaFrontal.Visible = False
        ' 
        ' rb_CargaSuperior
        ' 
        rb_CargaSuperior.AutoSize = True
        rb_CargaSuperior.Location = New Point(308, 183)
        rb_CargaSuperior.Margin = New Padding(4, 3, 4, 3)
        rb_CargaSuperior.Name = "rb_CargaSuperior"
        rb_CargaSuperior.Size = New Size(82, 19)
        rb_CargaSuperior.TabIndex = 6
        rb_CargaSuperior.TabStop = True
        rb_CargaSuperior.Text = "C. superior"
        rb_CargaSuperior.UseVisualStyleBackColor = True
        rb_CargaSuperior.Visible = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(18, 136)
        Label5.Margin = New Padding(4, 0, 4, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(59, 15)
        Label5.TabIndex = 7
        Label5.Text = "Consumo"
        ' 
        ' txt_consumo
        ' 
        txt_consumo.Location = New Point(106, 128)
        txt_consumo.Margin = New Padding(4, 3, 4, 3)
        txt_consumo.Name = "txt_consumo"
        txt_consumo.Size = New Size(116, 23)
        txt_consumo.TabIndex = 8
        ' 
        ' gpb_alta
        ' 
        gpb_alta.Controls.Add(rb_SinFreezer)
        gpb_alta.Controls.Add(rb_Freezer)
        gpb_alta.Controls.Add(cbo_color)
        gpb_alta.Controls.Add(btn_alta)
        gpb_alta.Controls.Add(Label7)
        gpb_alta.Controls.Add(Label6)
        gpb_alta.Controls.Add(txt_consumo)
        gpb_alta.Controls.Add(Label5)
        gpb_alta.Controls.Add(rb_CargaSuperior)
        gpb_alta.Controls.Add(rb_CargaFrontal)
        gpb_alta.Controls.Add(Label3)
        gpb_alta.Controls.Add(txt_capacidad)
        gpb_alta.Controls.Add(Label4)
        gpb_alta.Location = New Point(14, 253)
        gpb_alta.Margin = New Padding(4, 3, 4, 3)
        gpb_alta.Name = "gpb_alta"
        gpb_alta.Padding = New Padding(4, 3, 4, 3)
        gpb_alta.Size = New Size(556, 220)
        gpb_alta.TabIndex = 7
        gpb_alta.TabStop = False
        ' 
        ' rb_SinFreezer
        ' 
        rb_SinFreezer.AutoSize = True
        rb_SinFreezer.Location = New Point(308, 183)
        rb_SinFreezer.Margin = New Padding(4, 3, 4, 3)
        rb_SinFreezer.Name = "rb_SinFreezer"
        rb_SinFreezer.Size = New Size(79, 19)
        rb_SinFreezer.TabIndex = 13
        rb_SinFreezer.TabStop = True
        rb_SinFreezer.Text = "Sin freezer"
        rb_SinFreezer.UseVisualStyleBackColor = True
        rb_SinFreezer.Visible = False
        ' 
        ' rb_Freezer
        ' 
        rb_Freezer.AutoSize = True
        rb_Freezer.Location = New Point(172, 183)
        rb_Freezer.Margin = New Padding(4, 3, 4, 3)
        rb_Freezer.Name = "rb_Freezer"
        rb_Freezer.Size = New Size(85, 19)
        rb_Freezer.TabIndex = 12
        rb_Freezer.TabStop = True
        rb_Freezer.Text = "Con freezer"
        rb_Freezer.UseVisualStyleBackColor = True
        rb_Freezer.Visible = False
        ' 
        ' cbo_color
        ' 
        cbo_color.DisplayMember = "1"
        cbo_color.DropDownStyle = ComboBoxStyle.DropDownList
        cbo_color.FormattingEnabled = True
        cbo_color.Location = New Point(106, 30)
        cbo_color.Margin = New Padding(4, 3, 4, 3)
        cbo_color.Name = "cbo_color"
        cbo_color.Size = New Size(103, 23)
        cbo_color.TabIndex = 1
        ' 
        ' btn_alta
        ' 
        btn_alta.Location = New Point(443, 30)
        btn_alta.Margin = New Padding(4, 3, 4, 3)
        btn_alta.Name = "btn_alta"
        btn_alta.Size = New Size(88, 46)
        btn_alta.TabIndex = 11
        btn_alta.Text = "Alta"
        btn_alta.UseVisualStyleBackColor = True
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(246, 136)
        Label7.Margin = New Padding(4, 0, 4, 0)
        Label7.Name = "Label7"
        Label7.Size = New Size(32, 15)
        Label7.TabIndex = 10
        Label7.Text = "Watt"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(184, 83)
        Label6.Margin = New Padding(4, 0, 4, 0)
        Label6.Name = "Label6"
        Label6.Size = New Size(21, 15)
        Label6.TabIndex = 9
        Label6.Text = "KG"
        ' 
        ' gpb_comprar
        ' 
        gpb_comprar.Controls.Add(Label12)
        gpb_comprar.Controls.Add(btn_comprar)
        gpb_comprar.Controls.Add(txt_PrecioDeCompra)
        gpb_comprar.Controls.Add(txt_cantidadCompra)
        gpb_comprar.Controls.Add(Label10)
        gpb_comprar.Controls.Add(Label9)
        gpb_comprar.Controls.Add(txt_stock)
        gpb_comprar.Controls.Add(Label8)
        gpb_comprar.Location = New Point(584, 14)
        gpb_comprar.Margin = New Padding(4, 3, 4, 3)
        gpb_comprar.Name = "gpb_comprar"
        gpb_comprar.Padding = New Padding(4, 3, 4, 3)
        gpb_comprar.Size = New Size(328, 239)
        gpb_comprar.TabIndex = 8
        gpb_comprar.TabStop = False
        gpb_comprar.Text = "Compra"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Location = New Point(7, 147)
        Label12.Margin = New Padding(4, 0, 4, 0)
        Label12.Name = "Label12"
        Label12.Size = New Size(86, 15)
        Label12.TabIndex = 13
        Label12.Text = "Precio Compra"
        ' 
        ' btn_comprar
        ' 
        btn_comprar.Location = New Point(100, 186)
        btn_comprar.Margin = New Padding(4, 3, 4, 3)
        btn_comprar.Name = "btn_comprar"
        btn_comprar.Size = New Size(125, 46)
        btn_comprar.TabIndex = 12
        btn_comprar.Text = "Compra"
        btn_comprar.UseVisualStyleBackColor = True
        ' 
        ' txt_PrecioDeCompra
        ' 
        txt_PrecioDeCompra.Location = New Point(122, 143)
        txt_PrecioDeCompra.Margin = New Padding(4, 3, 4, 3)
        txt_PrecioDeCompra.Name = "txt_PrecioDeCompra"
        txt_PrecioDeCompra.Size = New Size(82, 23)
        txt_PrecioDeCompra.TabIndex = 5
        ' 
        ' txt_cantidadCompra
        ' 
        txt_cantidadCompra.Location = New Point(122, 98)
        txt_cantidadCompra.Margin = New Padding(4, 3, 4, 3)
        txt_cantidadCompra.Name = "txt_cantidadCompra"
        txt_cantidadCompra.Size = New Size(82, 23)
        txt_cantidadCompra.TabIndex = 4
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(23, 105)
        Label10.Margin = New Padding(4, 0, 4, 0)
        Label10.Name = "Label10"
        Label10.Size = New Size(55, 15)
        Label10.TabIndex = 3
        Label10.Text = "Cantidad"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(239, 40)
        Label9.Margin = New Padding(4, 0, 4, 0)
        Label9.Name = "Label9"
        Label9.Size = New Size(56, 15)
        Label9.TabIndex = 2
        Label9.Text = "Unidades"
        ' 
        ' txt_stock
        ' 
        txt_stock.Location = New Point(122, 37)
        txt_stock.Margin = New Padding(4, 3, 4, 3)
        txt_stock.Name = "txt_stock"
        txt_stock.ReadOnly = True
        txt_stock.Size = New Size(82, 23)
        txt_stock.TabIndex = 1
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(23, 40)
        Label8.Margin = New Padding(4, 0, 4, 0)
        Label8.Name = "Label8"
        Label8.Size = New Size(42, 15)
        Label8.TabIndex = 0
        Label8.Text = "STOCK"
        ' 
        ' gpb_venta
        ' 
        gpb_venta.Controls.Add(Label13)
        gpb_venta.Controls.Add(btn_vender)
        gpb_venta.Controls.Add(txt_PrecioVenta)
        gpb_venta.Controls.Add(txt_cantidadVenta)
        gpb_venta.Controls.Add(Label14)
        gpb_venta.Location = New Point(584, 260)
        gpb_venta.Margin = New Padding(4, 3, 4, 3)
        gpb_venta.Name = "gpb_venta"
        gpb_venta.Padding = New Padding(4, 3, 4, 3)
        gpb_venta.Size = New Size(328, 220)
        gpb_venta.TabIndex = 9
        gpb_venta.TabStop = False
        gpb_venta.Text = "Venta"
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Location = New Point(16, 88)
        Label13.Margin = New Padding(4, 0, 4, 0)
        Label13.Name = "Label13"
        Label13.Size = New Size(72, 15)
        Label13.TabIndex = 18
        Label13.Text = "Precio Venta"
        ' 
        ' btn_vender
        ' 
        btn_vender.Location = New Point(93, 157)
        btn_vender.Margin = New Padding(4, 3, 4, 3)
        btn_vender.Name = "btn_vender"
        btn_vender.Size = New Size(125, 46)
        btn_vender.TabIndex = 17
        btn_vender.Text = "Vender"
        btn_vender.UseVisualStyleBackColor = True
        ' 
        ' txt_PrecioVenta
        ' 
        txt_PrecioVenta.Location = New Point(120, 88)
        txt_PrecioVenta.Margin = New Padding(4, 3, 4, 3)
        txt_PrecioVenta.Name = "txt_PrecioVenta"
        txt_PrecioVenta.ReadOnly = True
        txt_PrecioVenta.Size = New Size(82, 23)
        txt_PrecioVenta.TabIndex = 16
        ' 
        ' txt_cantidadVenta
        ' 
        txt_cantidadVenta.Location = New Point(120, 43)
        txt_cantidadVenta.Margin = New Padding(4, 3, 4, 3)
        txt_cantidadVenta.Name = "txt_cantidadVenta"
        txt_cantidadVenta.Size = New Size(82, 23)
        txt_cantidadVenta.TabIndex = 15
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Location = New Point(16, 51)
        Label14.Margin = New Padding(4, 0, 4, 0)
        Label14.Name = "Label14"
        Label14.Size = New Size(55, 15)
        Label14.TabIndex = 14
        Label14.Text = "Cantidad"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(933, 519)
        Controls.Add(gpb_venta)
        Controls.Add(gpb_comprar)
        Controls.Add(gpb_alta)
        Controls.Add(gpb_producto)
        Margin = New Padding(4, 3, 4, 3)
        Name = "Form1"
        gpb_producto.ResumeLayout(False)
        gpb_producto.PerformLayout()
        gpb_alta.ResumeLayout(False)
        gpb_alta.PerformLayout()
        gpb_comprar.ResumeLayout(False)
        gpb_comprar.PerformLayout()
        gpb_venta.ResumeLayout(False)
        gpb_venta.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents gpb_producto As GroupBox
    Friend WithEvents rb_otro As RadioButton
    Friend WithEvents rb_heladera As RadioButton
    Friend WithEvents rb_lavarropas As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_descripcion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_modelo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_capacidad As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents rb_CargaFrontal As RadioButton
    Friend WithEvents rb_CargaSuperior As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_consumo As TextBox
    Friend WithEvents gpb_alta As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_alta As Button
    Friend WithEvents cbo_color As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents gpb_comprar As GroupBox
    Friend WithEvents gpb_venta As GroupBox
    Friend WithEvents Label12 As Label
    Friend WithEvents btn_comprar As Button
    Friend WithEvents txt_PrecioDeCompra As TextBox
    Friend WithEvents txt_cantidadCompra As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txt_stock As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents btn_vender As Button
    Friend WithEvents txt_PrecioVenta As TextBox
    Friend WithEvents txt_cantidadVenta As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents rb_SinFreezer As RadioButton
    Friend WithEvents rb_Freezer As RadioButton
End Class
