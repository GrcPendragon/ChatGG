<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCerrarVentana = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMaximizar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.btnMinimizar = New Bunifu.Framework.UI.BunifuImageButton()
        Me.imgLstImagenes = New System.Windows.Forms.ImageList(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.btnCerrarVentana, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnMinimizar)
        Me.Panel1.Controls.Add(Me.btnMaximizar)
        Me.Panel1.Controls.Add(Me.btnCerrarVentana)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 54)
        Me.Panel1.TabIndex = 0
        '
        'btnCerrarVentana
        '
        Me.btnCerrarVentana.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrarVentana.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnCerrarVentana.BackgroundImage = CType(resources.GetObject("btnCerrarVentana.BackgroundImage"), System.Drawing.Image)
        Me.btnCerrarVentana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCerrarVentana.ImageActive = Nothing
        Me.btnCerrarVentana.Location = New System.Drawing.Point(748, 7)
        Me.btnCerrarVentana.Name = "btnCerrarVentana"
        Me.btnCerrarVentana.Size = New System.Drawing.Size(40, 40)
        Me.btnCerrarVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCerrarVentana.TabIndex = 1
        Me.btnCerrarVentana.TabStop = False
        Me.btnCerrarVentana.Zoom = 10
        '
        'btnMaximizar
        '
        Me.btnMaximizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnMaximizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMaximizar.Image = CType(resources.GetObject("btnMaximizar.Image"), System.Drawing.Image)
        Me.btnMaximizar.ImageActive = Nothing
        Me.btnMaximizar.InitialImage = Nothing
        Me.btnMaximizar.Location = New System.Drawing.Point(702, 7)
        Me.btnMaximizar.Name = "btnMaximizar"
        Me.btnMaximizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.btnMaximizar.TabIndex = 2
        Me.btnMaximizar.TabStop = False
        Me.btnMaximizar.Zoom = 10
        '
        'btnMinimizar
        '
        Me.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnMinimizar.BackgroundImage = CType(resources.GetObject("btnMinimizar.BackgroundImage"), System.Drawing.Image)
        Me.btnMinimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMinimizar.ImageActive = Nothing
        Me.btnMinimizar.Location = New System.Drawing.Point(656, 7)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(40, 40)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimizar.TabIndex = 3
        Me.btnMinimizar.TabStop = False
        Me.btnMinimizar.Zoom = 10
        '
        'imgLstImagenes
        '
        Me.imgLstImagenes.ImageStream = CType(resources.GetObject("imgLstImagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgLstImagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.imgLstImagenes.Images.SetKeyName(0, "restore_window.png")
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(216, 171)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(276, 148)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Principal"
        Me.Panel1.ResumeLayout(False)
        CType(Me.btnCerrarVentana, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCerrarVentana As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnMinimizar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents btnMaximizar As Bunifu.Framework.UI.BunifuImageButton
    Friend WithEvents imgLstImagenes As ImageList
    Friend WithEvents PictureBox1 As PictureBox
End Class
