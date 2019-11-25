<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vAddAmigo
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vAddAmigo))
        Me.pnlSuperior = New System.Windows.Forms.Panel()
        Me.lblTitulo = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnMinimizar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnCerrarVentana = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtNombre = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.btnAgregar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.pnlSuperior.SuspendLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrarVentana, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSuperior
        '
        Me.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.pnlSuperior.Controls.Add(Me.lblTitulo)
        Me.pnlSuperior.Controls.Add(Me.btnMinimizar)
        Me.pnlSuperior.Controls.Add(Me.btnCerrarVentana)
        Me.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSuperior.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlSuperior.Location = New System.Drawing.Point(0, 0)
        Me.pnlSuperior.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlSuperior.Name = "pnlSuperior"
        Me.pnlSuperior.Size = New System.Drawing.Size(400, 50)
        Me.pnlSuperior.TabIndex = 3
        '
        'lblTitulo
        '
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblTitulo.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(131, 50)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Agregar amigo"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.ImageActive = Nothing
        Me.btnMinimizar.InitialImage = Nothing
        Me.btnMinimizar.Location = New System.Drawing.Point(330, 0)
        Me.btnMinimizar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(35, 35)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMinimizar.TabIndex = 3
        Me.btnMinimizar.TabStop = False
        Me.btnMinimizar.Zoom = 10
        '
        'btnCerrarVentana
        '
        Me.btnCerrarVentana.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnCerrarVentana.Image = CType(resources.GetObject("btnCerrarVentana.Image"), System.Drawing.Image)
        Me.btnCerrarVentana.ImageActive = Nothing
        Me.btnCerrarVentana.Location = New System.Drawing.Point(365, 0)
        Me.btnCerrarVentana.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCerrarVentana.Name = "btnCerrarVentana"
        Me.btnCerrarVentana.Size = New System.Drawing.Size(35, 35)
        Me.btnCerrarVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCerrarVentana.TabIndex = 1
        Me.btnCerrarVentana.TabStop = False
        Me.btnCerrarVentana.Zoom = 10
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 150)
        Me.Panel1.TabIndex = 4
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(50, 25)
        Me.BunifuCustomLabel1.Margin = New System.Windows.Forms.Padding(50, 25, 50, 25)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(236, 16)
        Me.BunifuCustomLabel1.TabIndex = 31
        Me.BunifuCustomLabel1.Text = "Ingrese el usuario que desea agregar:"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.White
        Me.txtNombre.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNombre.BorderColorIdle = System.Drawing.Color.Silver
        Me.txtNombre.BorderColorMouseHover = System.Drawing.Color.Gray
        Me.txtNombre.BorderThickness = 3
        Me.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNombre.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.Black
        Me.txtNombre.isPassword = False
        Me.txtNombre.Location = New System.Drawing.Point(50, 44)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(50, 25, 50, 25)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(308, 30)
        Me.txtNombre.TabIndex = 30
        Me.txtNombre.Text = "#"
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnAgregar
        '
        Me.btnAgregar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnAgregar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregar.BorderRadius = 0
        Me.btnAgregar.ButtonText = "Agegar amigo"
        Me.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregar.DisabledColor = System.Drawing.Color.Gray
        Me.btnAgregar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnAgregar.Iconimage = Nothing
        Me.btnAgregar.Iconimage_right = Nothing
        Me.btnAgregar.Iconimage_right_Selected = Nothing
        Me.btnAgregar.Iconimage_Selected = Nothing
        Me.btnAgregar.IconMarginLeft = 0
        Me.btnAgregar.IconMarginRight = 0
        Me.btnAgregar.IconRightVisible = True
        Me.btnAgregar.IconRightZoom = 0R
        Me.btnAgregar.IconVisible = True
        Me.btnAgregar.IconZoom = 90.0R
        Me.btnAgregar.IsTab = False
        Me.btnAgregar.Location = New System.Drawing.Point(267, 102)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnAgregar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnAgregar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnAgregar.Padding = New System.Windows.Forms.Padding(50)
        Me.btnAgregar.selected = False
        Me.btnAgregar.Size = New System.Drawing.Size(121, 30)
        Me.btnAgregar.TabIndex = 24
        Me.btnAgregar.Text = "Agegar amigo"
        Me.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAgregar.Textcolor = System.Drawing.Color.White
        Me.btnAgregar.TextFont = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'vAddAmigo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 200)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "vAddAmigo"
        Me.Text = "Form1"
        Me.pnlSuperior.ResumeLayout(False)
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrarVentana, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlSuperior As Panel
    Friend WithEvents lblTitulo As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnMinimizar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnCerrarVentana As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAgregar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtNombre As Bunifu.Framework.UI.BunifuMetroTextbox
End Class
