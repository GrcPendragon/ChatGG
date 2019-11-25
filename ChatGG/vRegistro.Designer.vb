<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class vRegistro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vRegistro))
        Me.pnlSuperior = New System.Windows.Forms.Panel()
        Me.lblTitulo = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnMinimizar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnCerrarVentana = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnAvatar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnRegistrar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.BunifuCustomLabel5 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtPassRepet = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtPass = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtUser = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtApellidos = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtNombre = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.pnlSuperior.SuspendLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrarVentana, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel1.SuspendLayout()
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
        Me.pnlSuperior.Size = New System.Drawing.Size(350, 50)
        Me.pnlSuperior.TabIndex = 2
        '
        'lblTitulo
        '
        Me.lblTitulo.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblTitulo.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(0, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(100, 50)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Registrar"
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
        Me.btnMinimizar.Location = New System.Drawing.Point(280, 0)
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
        Me.btnCerrarVentana.Location = New System.Drawing.Point(315, 0)
        Me.btnCerrarVentana.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCerrarVentana.Name = "btnCerrarVentana"
        Me.btnCerrarVentana.Size = New System.Drawing.Size(35, 35)
        Me.btnCerrarVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCerrarVentana.TabIndex = 1
        Me.btnCerrarVentana.TabStop = False
        Me.btnCerrarVentana.Zoom = 10
        '
        'btnAvatar
        '
        Me.btnAvatar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAvatar.BackColor = System.Drawing.Color.White
        Me.btnAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAvatar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnAvatar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAvatar.Image = CType(resources.GetObject("btnAvatar.Image"), System.Drawing.Image)
        Me.btnAvatar.ImageActive = Nothing
        Me.btnAvatar.InitialImage = Nothing
        Me.btnAvatar.Location = New System.Drawing.Point(125, 50)
        Me.btnAvatar.Margin = New System.Windows.Forms.Padding(3, 3, 3, 20)
        Me.btnAvatar.Name = "btnAvatar"
        Me.btnAvatar.Size = New System.Drawing.Size(80, 80)
        Me.btnAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAvatar.TabIndex = 3
        Me.btnAvatar.TabStop = False
        Me.btnAvatar.Zoom = 10
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnRegistrar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegistrar.BorderRadius = 0
        Me.btnRegistrar.ButtonText = "Registrar"
        Me.btnRegistrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrar.DisabledColor = System.Drawing.Color.Gray
        Me.btnRegistrar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnRegistrar.Iconimage = Nothing
        Me.btnRegistrar.Iconimage_right = Nothing
        Me.btnRegistrar.Iconimage_right_Selected = Nothing
        Me.btnRegistrar.Iconimage_Selected = Nothing
        Me.btnRegistrar.IconMarginLeft = 0
        Me.btnRegistrar.IconMarginRight = 0
        Me.btnRegistrar.IconRightVisible = True
        Me.btnRegistrar.IconRightZoom = 0R
        Me.btnRegistrar.IconVisible = True
        Me.btnRegistrar.IconZoom = 90.0R
        Me.btnRegistrar.IsTab = False
        Me.btnRegistrar.Location = New System.Drawing.Point(125, 443)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnRegistrar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRegistrar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnRegistrar.selected = False
        Me.btnRegistrar.Size = New System.Drawing.Size(80, 30)
        Me.btnRegistrar.TabIndex = 4
        Me.btnRegistrar.Text = "Registrar"
        Me.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnRegistrar.Textcolor = System.Drawing.Color.White
        Me.btnRegistrar.TextFont = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.BunifuCustomLabel5)
        Me.MetroPanel1.Controls.Add(Me.BunifuCustomLabel4)
        Me.MetroPanel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.MetroPanel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.MetroPanel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.MetroPanel1.Controls.Add(Me.txtPassRepet)
        Me.MetroPanel1.Controls.Add(Me.txtPass)
        Me.MetroPanel1.Controls.Add(Me.txtUser)
        Me.MetroPanel1.Controls.Add(Me.txtApellidos)
        Me.MetroPanel1.Controls.Add(Me.txtNombre)
        Me.MetroPanel1.Controls.Add(Me.btnRegistrar)
        Me.MetroPanel1.Controls.Add(Me.btnAvatar)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(0, 50)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Padding = New System.Windows.Forms.Padding(50, 0, 50, 0)
        Me.MetroPanel1.Size = New System.Drawing.Size(350, 550)
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'BunifuCustomLabel5
        '
        Me.BunifuCustomLabel5.AutoSize = True
        Me.BunifuCustomLabel5.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel5.Font = New System.Drawing.Font("Franklin Gothic Book", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel5.Location = New System.Drawing.Point(53, 150)
        Me.BunifuCustomLabel5.Name = "BunifuCustomLabel5"
        Me.BunifuCustomLabel5.Size = New System.Drawing.Size(69, 15)
        Me.BunifuCustomLabel5.TabIndex = 21
        Me.BunifuCustomLabel5.Text = "Nombre(s):"
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Franklin Gothic Book", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(53, 208)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(72, 15)
        Me.BunifuCustomLabel4.TabIndex = 20
        Me.BunifuCustomLabel4.Text = "Apellido(s):"
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Franklin Gothic Book", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(53, 266)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(55, 15)
        Me.BunifuCustomLabel3.TabIndex = 19
        Me.BunifuCustomLabel3.Text = "Usuario:"
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Franklin Gothic Book", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(53, 324)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(79, 15)
        Me.BunifuCustomLabel2.TabIndex = 18
        Me.BunifuCustomLabel2.Text = "Contraseña: "
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Franklin Gothic Book", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(53, 382)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(124, 15)
        Me.BunifuCustomLabel1.TabIndex = 17
        Me.BunifuCustomLabel1.Text = "Repetir contraseña: "
        '
        'txtPassRepet
        '
        Me.txtPassRepet.BackColor = System.Drawing.Color.White
        Me.txtPassRepet.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPassRepet.BorderColorIdle = System.Drawing.Color.Silver
        Me.txtPassRepet.BorderColorMouseHover = System.Drawing.Color.Gray
        Me.txtPassRepet.BorderThickness = 3
        Me.txtPassRepet.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassRepet.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassRepet.ForeColor = System.Drawing.Color.Black
        Me.txtPassRepet.isPassword = True
        Me.txtPassRepet.Location = New System.Drawing.Point(54, 401)
        Me.txtPassRepet.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassRepet.Name = "txtPassRepet"
        Me.txtPassRepet.Size = New System.Drawing.Size(242, 35)
        Me.txtPassRepet.TabIndex = 16
        Me.txtPassRepet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtPass
        '
        Me.txtPass.BackColor = System.Drawing.Color.White
        Me.txtPass.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPass.BorderColorIdle = System.Drawing.Color.Silver
        Me.txtPass.BorderColorMouseHover = System.Drawing.Color.Gray
        Me.txtPass.BorderThickness = 3
        Me.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.Black
        Me.txtPass.isPassword = True
        Me.txtPass.Location = New System.Drawing.Point(54, 343)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(242, 35)
        Me.txtPass.TabIndex = 15
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtUser
        '
        Me.txtUser.BackColor = System.Drawing.Color.White
        Me.txtUser.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUser.BorderColorIdle = System.Drawing.Color.Silver
        Me.txtUser.BorderColorMouseHover = System.Drawing.Color.Gray
        Me.txtUser.BorderThickness = 3
        Me.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUser.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.ForeColor = System.Drawing.Color.Black
        Me.txtUser.isPassword = False
        Me.txtUser.Location = New System.Drawing.Point(54, 285)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(242, 35)
        Me.txtUser.TabIndex = 14
        Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'txtApellidos
        '
        Me.txtApellidos.BackColor = System.Drawing.Color.White
        Me.txtApellidos.BorderColorFocused = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtApellidos.BorderColorIdle = System.Drawing.Color.Silver
        Me.txtApellidos.BorderColorMouseHover = System.Drawing.Color.Gray
        Me.txtApellidos.BorderThickness = 3
        Me.txtApellidos.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtApellidos.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellidos.ForeColor = System.Drawing.Color.Black
        Me.txtApellidos.isPassword = False
        Me.txtApellidos.Location = New System.Drawing.Point(54, 227)
        Me.txtApellidos.Margin = New System.Windows.Forms.Padding(4)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(242, 35)
        Me.txtApellidos.TabIndex = 13
        Me.txtApellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.txtNombre.Location = New System.Drawing.Point(54, 169)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(242, 35)
        Me.txtNombre.TabIndex = 12
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'vRegistro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(350, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.pnlSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "vRegistro"
        Me.pnlSuperior.ResumeLayout(False)
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrarVentana, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSuperior As Panel
    Friend WithEvents lblTitulo As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnMinimizar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnCerrarVentana As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnAvatar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnRegistrar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents txtNombre As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel5 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtPassRepet As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtPass As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtUser As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtApellidos As Bunifu.Framework.UI.BunifuMetroTextbox
End Class
