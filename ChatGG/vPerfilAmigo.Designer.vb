<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vPerfilAmigo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vPerfilAmigo))
        Me.pnlSuperior = New System.Windows.Forms.Panel()
        Me.lblTitulo = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnMinimizar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnCerrarVentana = New Bunifu.Framework.UI.BunifuImageButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.imgAvatar = New System.Windows.Forms.PictureBox()
        Me.lblNombreCompleto = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.lblUser = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnEliminar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.pnlSuperior.SuspendLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrarVentana, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.imgAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitulo.Size = New System.Drawing.Size(58, 50)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "Perfil"
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
        Me.Panel1.Controls.Add(Me.imgAvatar)
        Me.Panel1.Controls.Add(Me.lblNombreCompleto)
        Me.Panel1.Controls.Add(Me.lblUser)
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 150)
        Me.Panel1.TabIndex = 4
        '
        'imgAvatar
        '
        Me.imgAvatar.Image = CType(resources.GetObject("imgAvatar.Image"), System.Drawing.Image)
        Me.imgAvatar.Location = New System.Drawing.Point(34, 25)
        Me.imgAvatar.Name = "imgAvatar"
        Me.imgAvatar.Size = New System.Drawing.Size(80, 80)
        Me.imgAvatar.TabIndex = 34
        Me.imgAvatar.TabStop = False
        '
        'lblNombreCompleto
        '
        Me.lblNombreCompleto.AutoSize = True
        Me.lblNombreCompleto.BackColor = System.Drawing.Color.White
        Me.lblNombreCompleto.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCompleto.Location = New System.Drawing.Point(120, 65)
        Me.lblNombreCompleto.Name = "lblNombreCompleto"
        Me.lblNombreCompleto.Size = New System.Drawing.Size(144, 21)
        Me.lblNombreCompleto.TabIndex = 29
        Me.lblNombreCompleto.Text = "Ximena Contreras"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.Color.White
        Me.lblUser.Font = New System.Drawing.Font("Franklin Gothic Book", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(32, 108)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(82, 21)
        Me.lblUser.TabIndex = 26
        Me.lblUser.Text = "#MiNovia"
        '
        'btnEliminar
        '
        Me.btnEliminar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnEliminar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEliminar.BorderRadius = 0
        Me.btnEliminar.ButtonText = "Eliminar amigo"
        Me.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminar.DisabledColor = System.Drawing.Color.Gray
        Me.btnEliminar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnEliminar.Iconimage = Nothing
        Me.btnEliminar.Iconimage_right = Nothing
        Me.btnEliminar.Iconimage_right_Selected = Nothing
        Me.btnEliminar.Iconimage_Selected = Nothing
        Me.btnEliminar.IconMarginLeft = 0
        Me.btnEliminar.IconMarginRight = 0
        Me.btnEliminar.IconRightVisible = True
        Me.btnEliminar.IconRightZoom = 0R
        Me.btnEliminar.IconVisible = True
        Me.btnEliminar.IconZoom = 90.0R
        Me.btnEliminar.IsTab = False
        Me.btnEliminar.Location = New System.Drawing.Point(267, 108)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnEliminar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEliminar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnEliminar.Padding = New System.Windows.Forms.Padding(50)
        Me.btnEliminar.selected = False
        Me.btnEliminar.Size = New System.Drawing.Size(121, 30)
        Me.btnEliminar.TabIndex = 24
        Me.btnEliminar.Text = "Eliminar amigo"
        Me.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnEliminar.Textcolor = System.Drawing.Color.White
        Me.btnEliminar.TextFont = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'vPerfilAmigo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 200)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.pnlSuperior)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "vPerfilAmigo"
        Me.Text = "Form1"
        Me.pnlSuperior.ResumeLayout(False)
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrarVentana, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.imgAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pnlSuperior As Panel
    Friend WithEvents lblTitulo As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnMinimizar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnCerrarVentana As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblNombreCompleto As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents lblUser As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents btnEliminar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents imgAvatar As PictureBox
End Class
