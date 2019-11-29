<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class vInicioSesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vInicioSesion))
        Me.pnlSuperior = New System.Windows.Forms.Panel()
        Me.lblTitulo = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnMinimizar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnCerrarVentana = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnIniciarSesion = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.BunifuCustomLabel1 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BunifuCustomLabel3 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.BunifuCustomLabel2 = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.txtPass = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.txtUser = New Bunifu.Framework.UI.BunifuMetroTextbox()
        Me.pnlSuperior.SuspendLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrarVentana, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MetroPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitulo.Size = New System.Drawing.Size(114, 50)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Iniciar sesión"
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
        'btnIniciarSesion
        '
        Me.btnIniciarSesion.Activecolor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnIniciarSesion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnIniciarSesion.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnIniciarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnIniciarSesion.BorderRadius = 0
        Me.btnIniciarSesion.ButtonText = "Inicar sesión"
        Me.btnIniciarSesion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnIniciarSesion.DisabledColor = System.Drawing.Color.Gray
        Me.btnIniciarSesion.Iconcolor = System.Drawing.Color.Transparent
        Me.btnIniciarSesion.Iconimage = Nothing
        Me.btnIniciarSesion.Iconimage_right = Nothing
        Me.btnIniciarSesion.Iconimage_right_Selected = Nothing
        Me.btnIniciarSesion.Iconimage_Selected = Nothing
        Me.btnIniciarSesion.IconMarginLeft = 0
        Me.btnIniciarSesion.IconMarginRight = 0
        Me.btnIniciarSesion.IconRightVisible = True
        Me.btnIniciarSesion.IconRightZoom = 0R
        Me.btnIniciarSesion.IconVisible = True
        Me.btnIniciarSesion.IconZoom = 90.0R
        Me.btnIniciarSesion.IsTab = False
        Me.btnIniciarSesion.Location = New System.Drawing.Point(120, 242)
        Me.btnIniciarSesion.Name = "btnIniciarSesion"
        Me.btnIniciarSesion.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnIniciarSesion.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnIniciarSesion.OnHoverTextColor = System.Drawing.Color.White
        Me.btnIniciarSesion.selected = False
        Me.btnIniciarSesion.Size = New System.Drawing.Size(90, 30)
        Me.btnIniciarSesion.TabIndex = 4
        Me.btnIniciarSesion.Text = "Inicar sesión"
        Me.btnIniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnIniciarSesion.Textcolor = System.Drawing.Color.White
        Me.btnIniciarSesion.TextFont = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.BunifuCustomLabel1)
        Me.MetroPanel1.Controls.Add(Me.PictureBox1)
        Me.MetroPanel1.Controls.Add(Me.BunifuCustomLabel3)
        Me.MetroPanel1.Controls.Add(Me.BunifuCustomLabel2)
        Me.MetroPanel1.Controls.Add(Me.txtPass)
        Me.MetroPanel1.Controls.Add(Me.txtUser)
        Me.MetroPanel1.Controls.Add(Me.btnIniciarSesion)
        Me.MetroPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(0, 50)
        Me.MetroPanel1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 25)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Padding = New System.Windows.Forms.Padding(50, 0, 50, 25)
        Me.MetroPanel1.Size = New System.Drawing.Size(350, 300)
        Me.MetroPanel1.TabIndex = 0
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'BunifuCustomLabel1
        '
        Me.BunifuCustomLabel1.AutoSize = True
        Me.BunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuCustomLabel1.Font = New System.Drawing.Font("Franklin Gothic Book", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel1.Location = New System.Drawing.Point(51, 129)
        Me.BunifuCustomLabel1.Name = "BunifuCustomLabel1"
        Me.BunifuCustomLabel1.Size = New System.Drawing.Size(25, 26)
        Me.BunifuCustomLabel1.TabIndex = 21
        Me.BunifuCustomLabel1.Text = "#"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(125, 25)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 3, 3, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'BunifuCustomLabel3
        '
        Me.BunifuCustomLabel3.AutoSize = True
        Me.BunifuCustomLabel3.BackColor = System.Drawing.Color.White
        Me.BunifuCustomLabel3.Font = New System.Drawing.Font("Franklin Gothic Book", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BunifuCustomLabel3.Location = New System.Drawing.Point(53, 110)
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
        Me.BunifuCustomLabel2.Location = New System.Drawing.Point(53, 168)
        Me.BunifuCustomLabel2.Name = "BunifuCustomLabel2"
        Me.BunifuCustomLabel2.Size = New System.Drawing.Size(79, 15)
        Me.BunifuCustomLabel2.TabIndex = 18
        Me.BunifuCustomLabel2.Text = "Contraseña: "
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
        Me.txtPass.Location = New System.Drawing.Point(54, 187)
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
        Me.txtUser.Location = New System.Drawing.Point(75, 129)
        Me.txtUser.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(221, 35)
        Me.txtUser.TabIndex = 14
        Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'vInicioSesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(350, 350)
        Me.ControlBox = False
        Me.Controls.Add(Me.MetroPanel1)
        Me.Controls.Add(Me.pnlSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "vInicioSesion"
        Me.pnlSuperior.ResumeLayout(False)
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrarVentana, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlSuperior As Panel
    Friend WithEvents lblTitulo As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnMinimizar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnCerrarVentana As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnIniciarSesion As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents BunifuCustomLabel3 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents BunifuCustomLabel2 As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents txtPass As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents txtUser As Bunifu.Framework.UI.BunifuMetroTextbox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BunifuCustomLabel1 As Bunifu.Framework.UI.BunifuCustomLabel
End Class
