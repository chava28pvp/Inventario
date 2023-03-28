<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.lblCompra = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuNuevo = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConsultar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAgregar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuModificar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEliminar = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSalir = New System.Windows.Forms.ToolStripMenuItem()
        Me.dtpCompra = New System.Windows.Forms.DateTimePicker()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Stencil", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(162, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(602, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INVENTARIO DE FRUTAS Y VERDURAS GOMEZ"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(326, 262)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(197, 22)
        Me.txtPrecio.TabIndex = 30
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(326, 224)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(197, 22)
        Me.txtCantidad.TabIndex = 29
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(326, 181)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(197, 22)
        Me.txtNombre.TabIndex = 28
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(326, 150)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(197, 22)
        Me.txtId.TabIndex = 27
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.Location = New System.Drawing.Point(85, 150)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(36, 23)
        Me.lblId.TabIndex = 26
        Me.lblId.Text = "Id:"
        '
        'lblCompra
        '
        Me.lblCompra.AutoSize = True
        Me.lblCompra.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompra.Location = New System.Drawing.Point(85, 305)
        Me.lblCompra.Name = "lblCompra"
        Me.lblCompra.Size = New System.Drawing.Size(168, 23)
        Me.lblCompra.TabIndex = 25
        Me.lblCompra.Text = "Ultima compra:"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.Location = New System.Drawing.Point(85, 262)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(80, 23)
        Me.lblPrecio.TabIndex = 24
        Me.lblPrecio.Text = "Precio:"
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCantidad.Location = New System.Drawing.Point(85, 224)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(111, 23)
        Me.lblCantidad.TabIndex = 23
        Me.lblCantidad.Text = "Cantidad:"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Lucida Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(85, 181)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(214, 23)
        Me.lblNombre.TabIndex = 22
        Me.lblNombre.Text = "Producto (Nombre):"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNuevo, Me.mnuConsultar, Me.mnuAgregar, Me.mnuModificar, Me.mnuEliminar, Me.mnuSalir})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(923, 31)
        Me.MenuStrip1.TabIndex = 32
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuNuevo
        '
        Me.mnuNuevo.Name = "mnuNuevo"
        Me.mnuNuevo.Size = New System.Drawing.Size(74, 27)
        Me.mnuNuevo.Text = "Nuevo"
        '
        'mnuConsultar
        '
        Me.mnuConsultar.Name = "mnuConsultar"
        Me.mnuConsultar.Size = New System.Drawing.Size(97, 27)
        Me.mnuConsultar.Text = "Consultar"
        '
        'mnuAgregar
        '
        Me.mnuAgregar.Name = "mnuAgregar"
        Me.mnuAgregar.Size = New System.Drawing.Size(85, 27)
        Me.mnuAgregar.Text = "Agregar"
        Me.mnuAgregar.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'mnuModificar
        '
        Me.mnuModificar.Name = "mnuModificar"
        Me.mnuModificar.Size = New System.Drawing.Size(95, 27)
        Me.mnuModificar.Text = "Modificar"
        '
        'mnuEliminar
        '
        Me.mnuEliminar.Name = "mnuEliminar"
        Me.mnuEliminar.Size = New System.Drawing.Size(85, 27)
        Me.mnuEliminar.Text = "Eliminar"
        '
        'mnuSalir
        '
        Me.mnuSalir.Name = "mnuSalir"
        Me.mnuSalir.Size = New System.Drawing.Size(56, 27)
        Me.mnuSalir.Text = "Salir"
        '
        'dtpCompra
        '
        Me.dtpCompra.Location = New System.Drawing.Point(326, 305)
        Me.dtpCompra.Name = "dtpCompra"
        Me.dtpCompra.Size = New System.Drawing.Size(200, 22)
        Me.dtpCompra.TabIndex = 33
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 538)
        Me.Controls.Add(Me.dtpCompra)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.lblCompra)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents lblCompra As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuNuevo As ToolStripMenuItem
    Friend WithEvents mnuConsultar As ToolStripMenuItem
    Friend WithEvents mnuAgregar As ToolStripMenuItem
    Friend WithEvents mnuModificar As ToolStripMenuItem
    Friend WithEvents mnuEliminar As ToolStripMenuItem
    Friend WithEvents mnuSalir As ToolStripMenuItem
    Friend WithEvents dtpCompra As DateTimePicker
End Class
