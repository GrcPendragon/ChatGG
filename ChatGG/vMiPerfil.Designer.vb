<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vMiPerfil
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vMiPerfil))
        Me.pnlSuperior = New System.Windows.Forms.Panel()
        Me.lblTitulo = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnMinimizar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnCerrarVentana = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BunifuCustomLabel4 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtPass = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtApellidos = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtNombre = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.btnAvatar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtUser = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.btnGuardar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.opnImg = New System.Windows.Forms.OpenFileDialog()
        Me.pnlSuperior.SuspendLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrarVentana, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.btnAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitulo.Size = New System.Drawing.Size(78, 50)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Mi Perfil"
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
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel4)
        Me.Panel1.Controls.Add(Me.txtPass)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.Panel1.Controls.Add(Me.txtApellidos)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.btnAvatar)
        Me.Panel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.Panel1.Controls.Add(Me.txtUser)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 250)
        Me.Panel1.TabIndex = 4
        '
        'BunifuCustomLabel4
        '
        Me.BunifuCustomLabel4.AutoSize = True
        Me.BunifuCustomLabel4.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel4.Font = New System.Drawing.Font("Franklin Gothic Book", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel4.Location = New System.Drawing.Point(207, 125)
        Me.BunifuCustomLabel4.Name = "BunifuCustomLabel4"
        Me.BunifuCustomLabel4.Size = New System.Drawing.Size(75, 15)
        Me.BunifuCustomLabel4.TabIndex = 33
        Me.BunifuCustomLabel4.Text = "Contraseña:"
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
        Me.txtPass.Location = New System.Drawing.Point(207, 144)
        Me.txtPass.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(168, 30)
        Me.txtPass.TabIndex = 32
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel2
        '
        Me.BunifuCustomLabel2.AutoSize = True
        Me.BunifuCustomLabel2.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel2.Font = New System.Drawing.Font("Franklin Gothic Book", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(251, 56)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(72, 15)
        Me.BunifuCustomLabel2.TabIndex = 31
        Me.BunifuCustomLabel2.Text = "Apellido(s):"
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
        Me.txtApellidos.Location = New System.Drawing.Point(250, 75)
        Me.txtApellidos.Margin = New System.Windows.Forms.Padding(4, 4, 25, 4)
        Me.txtApellidos.Name = "txtApellidos"
        Me.txtApellidos.Size = New System.Drawing.Size(125, 30)
        Me.txtApellidos.TabIndex = 30
        Me.txtApellidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Franklin Gothic Book", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(123, 56)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(69, 15)
        Me.BunifuCustomLabel1.TabIndex = 29
        Me.BunifuCustomLabel1.Text = "Nombre(s):"
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
        Me.txtNombre.Location = New System.Drawing.Point(121, 75)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 4, 25, 4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(125, 30)
        Me.txtNombre.TabIndex = 28
        Me.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnAvatar
        '
        Me.btnAvatar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAvatar.BackColor = System.Drawing.Color.White
        Me.btnAvatar.BackgroundImage = CType(resources.GetObject("btnAvatar.BackgroundImage"), System.Drawing.Image)
        Me.btnAvatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAvatar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnAvatar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAvatar.Image = CType(resources.GetObject("btnAvatar.Image"), System.Drawing.Image)
        Me.btnAvatar.ImageActive = Nothing
        Me.btnAvatar.InitialImage = Nothing
        Me.btnAvatar.Location = New System.Drawing.Point(34, 25)
        Me.btnAvatar.Margin = New System.Windows.Forms.Padding(25, 25, 3, 20)
        Me.btnAvatar.Name = "btnAvatar"
        Me.btnAvatar.Size = New System.Drawing.Size(80, 80)
        Me.btnAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnAvatar.TabIndex = 27
        Me.btnAvatar.TabStop = False
        Me.btnAvatar.Zoom = 10
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Franklin Gothic Book", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(35, 125)
        Me.BunifuCustomLabel3.Name = "BunifuCustomLabel3"
        Me.BunifuCustomLabel3.Size = New System.Drawing.Size(55, 15)
        Me.BunifuCustomLabel3.TabIndex = 26
        Me.BunifuCustomLabel3.Text = "Usuario:"
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
        Me.txtUser.Location = New System.Drawing.Point(34, 144)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(168, 30)
        Me.txtUser.TabIndex = 25
        Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'btnGuardar
        '
        Me.btnGuardar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnGuardar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnGuardar.BorderRadius = 0
        Me.btnGuardar.ButtonText = "Guardar cambios"
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.DisabledColor = System.Drawing.Color.Gray
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnGuardar.Iconimage = Nothing
        Me.btnGuardar.Iconimage_right = Nothing
        Me.btnGuardar.Iconimage_right_Selected = Nothing
        Me.btnGuardar.Iconimage_Selected = Nothing
        Me.btnGuardar.IconMarginLeft = 0
        Me.btnGuardar.IconMarginRight = 0
        Me.btnGuardar.IconRightVisible = True
        Me.btnGuardar.IconRightZoom = 0R
        Me.btnGuardar.IconVisible = True
        Me.btnGuardar.IconZoom = 90.0R
        Me.btnGuardar.IsTab = False
        Me.btnGuardar.Location = New System.Drawing.Point(254, 208)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnGuardar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGuardar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnGuardar.Padding = New System.Windows.Forms.Padding(50)
        Me.btnGuardar.selected = False
        Me.btnGuardar.Size = New System.Drawing.Size(121, 30)
        Me.btnGuardar.TabIndex = 24
        Me.btnGuardar.Text = "Guardar cambios"
        Me.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnGuardar.Textcolor = System.Drawing.Color.White
        Me.btnGuardar.TextFont = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'opnImg
        '
        Me.opnImg.Filter = "Imagenes JPG|*.jpg|Imagenes PNG|*.png"
        Me.opnImg.Title = "Cargar imagen"
        '
        'vMiPerfil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 300)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "vMiPerfil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        Me.pnlSuperior.ResumeLayout(False)
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrarVentana, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.btnAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSuperior As Panel
    Friend WithEvents lblTitulo As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnMinimizar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnCerrarVentana As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtApellidos As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtNombre As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents btnAvatar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtUser As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents btnGuardar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuCustomLabel4 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtPass As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents opnImg As OpenFileDialog
End Class
