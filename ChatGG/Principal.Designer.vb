﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.pnlSuperior = New System.Windows.Forms.Panel()
        Me.lblTitulo = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.imgLogo = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMaximizar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnCerrarVentana = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lstImagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.pnl1 = New System.Windows.Forms.Panel()
        Me.btnCerrar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.pnlAmigos = New System.Windows.Forms.Panel()
        Me.Separator = New Bunifu.Framework.UI.BunifuSeparator()
        Me.pnlConectados = New System.Windows.Forms.Panel()
        Me.btnRecargar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnAgregarUser = New Bunifu.Framework.UI.BunifuImageButton()
        Me.lblAmigos = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.btnPerfil = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pnlSuperior.SuspendLayout()
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrarVentana, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.pnl1.SuspendLayout()
        Me.pnlConectados.SuspendLayout()
        CType(Me.btnRecargar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnAgregarUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlSuperior
        '
        Me.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.pnlSuperior.Controls.Add(Me.lblTitulo)
        Me.pnlSuperior.Controls.Add(Me.imgLogo)
        Me.pnlSuperior.Controls.Add(Me.btnMinimizar)
        Me.pnlSuperior.Controls.Add(Me.btnMaximizar)
        Me.pnlSuperior.Controls.Add(Me.btnCerrarVentana)
        Me.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlSuperior.ForeColor = System.Drawing.SystemColors.ControlText
        Me.pnlSuperior.Location = New System.Drawing.Point(0, 0)
        Me.pnlSuperior.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlSuperior.Name = "pnlSuperior"
        Me.pnlSuperior.Size = New System.Drawing.Size(800, 50)
        Me.pnlSuperior.TabIndex = 0
        '
        'lblTitulo
        '
        Me.lblTitulo.Font = New System.Drawing.Font("Franklin Gothic Book", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.White
        Me.lblTitulo.Location = New System.Drawing.Point(53, 9)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(100, 41)
        Me.lblTitulo.TabIndex = 1
        Me.lblTitulo.Text = "CHAT GG"
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'imgLogo
        '
        Me.imgLogo.Image = CType(resources.GetObject("imgLogo.Image"), System.Drawing.Image)
        Me.imgLogo.Location = New System.Drawing.Point(0, 0)
        Me.imgLogo.Margin = New System.Windows.Forms.Padding(0)
        Me.imgLogo.Name = "imgLogo"
        Me.imgLogo.Size = New System.Drawing.Size(50, 50)
        Me.imgLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgLogo.TabIndex = 4
        Me.imgLogo.TabStop = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimizar.Image = CType(resources.GetObject("btnMinimizar.Image"), System.Drawing.Image)
        Me.btnMinimizar.ImageActive = Nothing
        Me.btnMinimizar.InitialImage = Nothing
        Me.btnMinimizar.Location = New System.Drawing.Point(695, 0)
        Me.btnMinimizar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(35, 35)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMinimizar.TabIndex = 3
        Me.btnMinimizar.TabStop = False
        Me.btnMinimizar.Zoom = 10
        '
        'btnMaximizar
        '
        Me.btnMaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMaximizar.Image = CType(resources.GetObject("btnMaximizar.Image"), System.Drawing.Image)
        Me.btnMaximizar.ImageActive = Nothing
        Me.btnMaximizar.InitialImage = Nothing
        Me.btnMaximizar.Location = New System.Drawing.Point(730, 0)
        Me.btnMaximizar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(35, 35)
        Me.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMaximizar.TabIndex = 2
        Me.btnMaximizar.TabStop = False
        Me.btnMaximizar.Zoom = 10
        '
        'btnCerrarVentana
        '
        Me.btnCerrarVentana.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.btnCerrarVentana.Image = CType(resources.GetObject("btnCerrarVentana.Image"), System.Drawing.Image)
        Me.btnCerrarVentana.ImageActive = Nothing
        Me.btnCerrarVentana.Location = New System.Drawing.Point(765, 0)
        Me.btnCerrarVentana.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCerrarVentana.Name = "btnCerrarVentana"
        Me.btnCerrarVentana.Size = New System.Drawing.Size(35, 35)
        Me.btnCerrarVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnCerrarVentana.TabIndex = 1
        Me.btnCerrarVentana.TabStop = False
        Me.btnCerrarVentana.Zoom = 10
        '
        'lstImagenes
        '
        Me.lstImagenes.ImageStream = CType(resources.GetObject("lstImagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.lstImagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.lstImagenes.Images.SetKeyName(0, "restore_window.png")
        Me.lstImagenes.Images.SetKeyName(1, "maximize_Window.png")
        Me.lstImagenes.Images.SetKeyName(2, "user_H.png")
        Me.lstImagenes.Images.SetKeyName(3, "user_M.png")
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 50)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(147, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.pnl1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pnlConectados)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnPerfil)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 550)
        Me.SplitContainer1.SplitterDistance = 230
        Me.SplitContainer1.TabIndex = 1
        '
        'pnl1
        '
        Me.pnl1.AutoScroll = True
        Me.pnl1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.pnl1.Controls.Add(Me.btnCerrar)
        Me.pnl1.Controls.Add(Me.pnlAmigos)
        Me.pnl1.Controls.Add(Me.Separator)
        Me.pnl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnl1.Location = New System.Drawing.Point(0, 140)
        Me.pnl1.Name = "pnl1"
        Me.pnl1.Padding = New System.Windows.Forms.Padding(5, 0, 5, 5)
        Me.pnl1.Size = New System.Drawing.Size(230, 410)
        Me.pnl1.TabIndex = 3
        '
        'btnCerrar
        '
        Me.btnCerrar.Activecolor = System.Drawing.Color.Silver
        Me.btnCerrar.BackColor = System.Drawing.Color.White
        Me.btnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCerrar.BorderRadius = 0
        Me.btnCerrar.ButtonText = "Cerrar Sesion"
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.DisabledColor = System.Drawing.Color.Gray
        Me.btnCerrar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnCerrar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnCerrar.Iconimage = Nothing
        Me.btnCerrar.Iconimage_right = Nothing
        Me.btnCerrar.Iconimage_right_Selected = Nothing
        Me.btnCerrar.Iconimage_Selected = Nothing
        Me.btnCerrar.IconMarginLeft = 0
        Me.btnCerrar.IconMarginRight = 0
        Me.btnCerrar.IconRightVisible = True
        Me.btnCerrar.IconRightZoom = 0R
        Me.btnCerrar.IconVisible = True
        Me.btnCerrar.IconZoom = 80.0R
        Me.btnCerrar.IsTab = False
        Me.btnCerrar.Location = New System.Drawing.Point(5, 373)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Normalcolor = System.Drawing.Color.White
        Me.btnCerrar.OnHovercolor = System.Drawing.Color.Silver
        Me.btnCerrar.OnHoverTextColor = System.Drawing.Color.Black
        Me.btnCerrar.Padding = New System.Windows.Forms.Padding(0, 5, 0, 0)
        Me.btnCerrar.selected = False
        Me.btnCerrar.Size = New System.Drawing.Size(220, 32)
        Me.btnCerrar.TabIndex = 8
        Me.btnCerrar.Text = "Cerrar Sesion"
        Me.btnCerrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnCerrar.Textcolor = System.Drawing.Color.Black
        Me.btnCerrar.TextFont = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'pnlAmigos
        '
        Me.pnlAmigos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlAmigos.AutoScroll = True
        Me.pnlAmigos.Location = New System.Drawing.Point(5, 10)
        Me.pnlAmigos.Margin = New System.Windows.Forms.Padding(3, 10, 3, 50)
        Me.pnlAmigos.Name = "pnlAmigos"
        Me.pnlAmigos.Padding = New System.Windows.Forms.Padding(0, 10, 0, 0)
        Me.pnlAmigos.Size = New System.Drawing.Size(220, 350)
        Me.pnlAmigos.TabIndex = 7
        '
        'Separator
        '
        Me.Separator.BackColor = System.Drawing.Color.Transparent
        Me.Separator.Dock = System.Windows.Forms.DockStyle.Top
        Me.Separator.LineColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Separator.LineThickness = 1
        Me.Separator.Location = New System.Drawing.Point(5, 0)
        Me.Separator.Name = "Separator"
        Me.Separator.Size = New System.Drawing.Size(220, 10)
        Me.Separator.TabIndex = 5
        Me.Separator.Transparency = 255
        Me.Separator.Vertical = False
        '
        'pnlConectados
        '
        Me.pnlConectados.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.pnlConectados.Controls.Add(Me.btnRecargar)
        Me.pnlConectados.Controls.Add(Me.btnAgregarUser)
        Me.pnlConectados.Controls.Add(Me.lblAmigos)
        Me.pnlConectados.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlConectados.Location = New System.Drawing.Point(0, 90)
        Me.pnlConectados.Margin = New System.Windows.Forms.Padding(0)
        Me.pnlConectados.Name = "pnlConectados"
        Me.pnlConectados.Padding = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.pnlConectados.Size = New System.Drawing.Size(230, 50)
        Me.pnlConectados.TabIndex = 2
        '
        'btnRecargar
        '
        Me.btnRecargar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRecargar.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnRecargar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRecargar.Image = CType(resources.GetObject("btnRecargar.Image"), System.Drawing.Image)
        Me.btnRecargar.ImageActive = Nothing
        Me.btnRecargar.Location = New System.Drawing.Point(145, 5)
        Me.btnRecargar.Margin = New System.Windows.Forms.Padding(0)
        Me.btnRecargar.Name = "btnRecargar"
        Me.btnRecargar.Size = New System.Drawing.Size(40, 40)
        Me.btnRecargar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnRecargar.TabIndex = 4
        Me.btnRecargar.TabStop = False
        Me.btnRecargar.Zoom = 10
        '
        'btnAgregarUser
        '
        Me.btnAgregarUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregarUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnAgregarUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarUser.Image = CType(resources.GetObject("btnAgregarUser.Image"), System.Drawing.Image)
        Me.btnAgregarUser.ImageActive = Nothing
        Me.btnAgregarUser.InitialImage = Nothing
        Me.btnAgregarUser.Location = New System.Drawing.Point(185, 5)
        Me.btnAgregarUser.Margin = New System.Windows.Forms.Padding(0)
        Me.btnAgregarUser.Name = "btnAgregarUser"
        Me.btnAgregarUser.Size = New System.Drawing.Size(40, 40)
        Me.btnAgregarUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnAgregarUser.TabIndex = 3
        Me.btnAgregarUser.TabStop = False
        Me.btnAgregarUser.Zoom = 10
        '
        'lblAmigos
        '
        Me.lblAmigos.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblAmigos.Font = New System.Drawing.Font("Franklin Gothic Book", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmigos.ForeColor = System.Drawing.Color.White
        Me.lblAmigos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblAmigos.Location = New System.Drawing.Point(0, 5)
        Me.lblAmigos.Name = "lblAmigos"
        Me.lblAmigos.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.lblAmigos.Size = New System.Drawing.Size(125, 40)
        Me.lblAmigos.TabIndex = 0
        Me.lblAmigos.Text = "Amigos: "
        Me.lblAmigos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPerfil
        '
        Me.btnPerfil.Activecolor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnPerfil.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPerfil.BorderRadius = 0
        Me.btnPerfil.ButtonText = "Fausto Garcia"
        Me.btnPerfil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPerfil.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnPerfil.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnPerfil.Iconcolor = System.Drawing.Color.Transparent
        Me.btnPerfil.Iconimage = CType(resources.GetObject("btnPerfil.Iconimage"), System.Drawing.Image)
        Me.btnPerfil.Iconimage_right = Nothing
        Me.btnPerfil.Iconimage_right_Selected = Nothing
        Me.btnPerfil.Iconimage_Selected = Nothing
        Me.btnPerfil.IconMarginLeft = 0
        Me.btnPerfil.IconMarginRight = 0
        Me.btnPerfil.IconRightVisible = True
        Me.btnPerfil.IconRightZoom = 0R
        Me.btnPerfil.IconVisible = True
        Me.btnPerfil.IconZoom = 90.0R
        Me.btnPerfil.IsTab = False
        Me.btnPerfil.Location = New System.Drawing.Point(0, 0)
        Me.btnPerfil.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPerfil.Name = "btnPerfil"
        Me.btnPerfil.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnPerfil.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPerfil.OnHoverTextColor = System.Drawing.Color.White
        Me.btnPerfil.selected = False
        Me.btnPerfil.Size = New System.Drawing.Size(230, 90)
        Me.btnPerfil.TabIndex = 1
        Me.btnPerfil.Text = "Fausto Garcia"
        Me.btnPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnPerfil.Textcolor = System.Drawing.Color.White
        Me.btnPerfil.TextFont = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.pnlSuperior)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.pnlSuperior.ResumeLayout(False)
        CType(Me.imgLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrarVentana, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.pnl1.ResumeLayout(False)
        Me.pnlConectados.ResumeLayout(False)
        CType(Me.btnRecargar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnAgregarUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlSuperior As Panel
    Friend WithEvents btnCerrarVentana As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnMinimizar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnMaximizar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lstImagenes As ImageList
    Friend WithEvents lblTitulo As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents imgLogo As PictureBox
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents btnPerfil As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents pnlConectados As Panel
    Friend WithEvents btnAgregarUser As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents lblAmigos As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents pnl1 As Panel
    Friend WithEvents Separator As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents pnlAmigos As Panel
    Friend WithEvents btnRecargar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnCerrar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Timer1 As Timer
End Class
