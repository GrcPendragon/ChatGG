<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class vChat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(vChat))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtChat = New System.Windows.Forms.RichTextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblAmigo = New Bunifu.Framework.UI.BunifuCustomLabel()
        Me.imgAmigo = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnEnviar = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.txtMensaje = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.imgAmigo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 600)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.txtChat)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 50)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Padding = New System.Windows.Forms.Padding(50, 10, 50, 10)
        Me.Panel4.Size = New System.Drawing.Size(800, 450)
        Me.Panel4.TabIndex = 4
        '
        'txtChat
        '
        Me.txtChat.BackColor = System.Drawing.Color.White
        Me.txtChat.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtChat.Font = New System.Drawing.Font("Franklin Gothic Book", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChat.Location = New System.Drawing.Point(50, 10)
        Me.txtChat.Name = "txtChat"
        Me.txtChat.ReadOnly = True
        Me.txtChat.Size = New System.Drawing.Size(700, 430)
        Me.txtChat.TabIndex = 0
        Me.txtChat.Text = ""
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.lblAmigo)
        Me.Panel3.Controls.Add(Me.imgAmigo)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Padding = New System.Windows.Forms.Padding(5)
        Me.Panel3.Size = New System.Drawing.Size(800, 50)
        Me.Panel3.TabIndex = 2
        '
        'lblAmigo
        '
        Me.lblAmigo.AutoSize = True
        Me.lblAmigo.Font = New System.Drawing.Font("Franklin Gothic Book", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmigo.Location = New System.Drawing.Point(51, 15)
        Me.lblAmigo.Margin = New System.Windows.Forms.Padding(3, 15, 0, 15)
        Me.lblAmigo.Name = "lblAmigo"
        Me.lblAmigo.Size = New System.Drawing.Size(54, 20)
        Me.lblAmigo.TabIndex = 1
        Me.lblAmigo.Text = "Lupita"
        '
        'imgAmigo
        '
        Me.imgAmigo.Dock = System.Windows.Forms.DockStyle.Left
        Me.imgAmigo.Image = CType(resources.GetObject("imgAmigo.Image"), System.Drawing.Image)
        Me.imgAmigo.Location = New System.Drawing.Point(5, 5)
        Me.imgAmigo.Name = "imgAmigo"
        Me.imgAmigo.Size = New System.Drawing.Size(40, 40)
        Me.imgAmigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgAmigo.TabIndex = 0
        Me.imgAmigo.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.btnEnviar)
        Me.Panel2.Controls.Add(Me.txtMensaje)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 500)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(50, 10, 50, 10)
        Me.Panel2.Size = New System.Drawing.Size(800, 100)
        Me.Panel2.TabIndex = 1
        '
        'btnEnviar
        '
        Me.btnEnviar.Activecolor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.btnEnviar.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnEnviar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEnviar.BorderRadius = 0
        Me.btnEnviar.ButtonText = ""
        Me.btnEnviar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnviar.DisabledColor = System.Drawing.Color.Gray
        Me.btnEnviar.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnEnviar.Iconcolor = System.Drawing.Color.Transparent
        Me.btnEnviar.Iconimage = CType(resources.GetObject("btnEnviar.Iconimage"), System.Drawing.Image)
        Me.btnEnviar.Iconimage_right = Nothing
        Me.btnEnviar.Iconimage_right_Selected = Nothing
        Me.btnEnviar.Iconimage_Selected = Nothing
        Me.btnEnviar.IconMarginLeft = 0
        Me.btnEnviar.IconMarginRight = 0
        Me.btnEnviar.IconRightVisible = True
        Me.btnEnviar.IconRightZoom = 0R
        Me.btnEnviar.IconVisible = True
        Me.btnEnviar.IconZoom = 90.0R
        Me.btnEnviar.IsTab = False
        Me.btnEnviar.Location = New System.Drawing.Point(670, 10)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Normalcolor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnEnviar.OnHovercolor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnEnviar.OnHoverTextColor = System.Drawing.Color.White
        Me.btnEnviar.selected = False
        Me.btnEnviar.Size = New System.Drawing.Size(80, 80)
        Me.btnEnviar.TabIndex = 1
        Me.btnEnviar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEnviar.Textcolor = System.Drawing.Color.White
        Me.btnEnviar.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtMensaje
        '
        Me.txtMensaje.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMensaje.BackColor = System.Drawing.Color.White
        Me.txtMensaje.Font = New System.Drawing.Font("Franklin Gothic Book", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMensaje.Location = New System.Drawing.Point(53, 12)
        Me.txtMensaje.Multiline = True
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(611, 75)
        Me.txtMensaje.TabIndex = 0
        '
        'vChat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "vChat"
        Me.Text = "vChat"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.imgAmigo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtMensaje As TextBox
    Friend WithEvents btnEnviar As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblAmigo As Bunifu.Framework.UI.BunifuCustomLabel
    Friend WithEvents imgAmigo As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtChat As RichTextBox
End Class
