Imports System.Threading
Public Class Principal
    Private px, py As Integer
    Private mover As Boolean = False
    Private bd As New Consulta
    Private sql As String
    Public user, amigo, idYo As String
    Public tabla, tablaYo, tablaAmigos As New DataTable
    Friend WithEvents botones As Bunifu.Framework.UI.BunifuFlatButton
    Sub New()
        InitializeComponent()
    End Sub
    'Carga de Ventana
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'La ventana que desees mostrar
        Dim ventanaIni As New vInicioSesion
        If ventanaIni.ShowDialog <> vbOK Then
            Me.Close()
        Else
            Me.user = ventanaIni.user
            sql = "Select * from user where user = '" & Me.user & "'"
            tablaYo = bd.seleccionar(sql)
            btnPerfil.Text = tablaYo(0).Item(1) & " " & tablaYo(0).Item(2)
            btnPerfil.Iconimage = lstImagenes.Images(Convert.ToInt32(tablaYo(0).Item(5).ToString))
            idYo = tablaYo(0).Item(0).ToString
            sql = "Select * From contactos Where user = " + idYo + " Or amigoDe = " + idYo
            tablaAmigos = bd.seleccionar(sql)
            For i = 0 To tablaAmigos.Rows.Count - 1
                botones = New Bunifu.Framework.UI.BunifuFlatButton
                If tablaAmigos(i).Item(1) = idYo Then
                    sql = "Select * From user Where id = " + tablaAmigos(i).Item(2).ToString
                Else
                    sql = "Select * From user Where id = " + tablaAmigos(i).Item(1).ToString
                End If
                tabla = bd.seleccionar(sql)
                botones.Text = tabla(0).Item(1) + " " + tabla(0).Item(2)
                botones.Dock = DockStyle.Top
                botones.Name = tabla(0).Item(3).ToString
                valoresBtn(botones, tabla(0).Item(5).ToString)

                AddHandler botones.Click, AddressOf btnAmigo_Click
                pnlAmigos.Controls.Add(botones)
            Next
        End If
    End Sub
    'Abrir Perfil
    Private Sub btnPerfil_Click(sender As Object, e As EventArgs) Handles btnPerfil.Click
        Dim ventana As New vMiPerfil(tablaYo)
        If ventana.ShowDialog() = vbOK Then
            Me.user = ventana.user
            sql = "Select * from user where user = '" & Me.user & "'"
            tablaYo = bd.seleccionar(sql)
            btnPerfil.Text = tablaYo(0).Item(1) & " " & tablaYo(0).Item(2)
            btnPerfil.Iconimage = lstImagenes.Images(Convert.ToInt32(tablaYo(0).Item(5).ToString))
        End If
    End Sub
    'Evento para abrir Chat
    Private Sub btnAmigo_Click(sender As Object, e As EventArgs) Handles botones.Click
        For i = 0 To SplitContainer1.Panel2.Controls.Count - 1
            Dim ctrl As Windows.Forms.Control = SplitContainer1.Panel2.Controls(i)
            SplitContainer1.Panel2.Controls.Remove(ctrl)
            ctrl.Dispose()
        Next

        amigo = CType(sender, Bunifu.Framework.UI.BunifuFlatButton).Name

        Dim chat = New vChat(amigo, idYo)

        chat.TopLevel = False
        chat.Parent = SplitContainer1.Panel2
        chat.Show()
        chat.Dock = DockStyle.Fill
    End Sub
    'Agregar Usuario
    Private Sub btnAgregarUser_Click(sender As Object, e As EventArgs) Handles btnAgregarUser.Click
        Dim ventana As New vAddAmigo(idYo)
        If ventana.ShowDialog = vbOK Then
            MsgBox("Ahora tienes una nueva amistad")
        End If
    End Sub
    Sub valoresBtn(ByRef boton As Bunifu.Framework.UI.BunifuFlatButton, sex As String)
        boton.Textcolor = Color.Black
        boton.Activecolor = Color.Silver
        boton.BackColor = Color.White
        boton.Iconimage = lstImagenes.Images(Convert.ToInt32(sex))
        boton.IconZoom = 80
        boton.Normalcolor = Color.White
        boton.OnHovercolor = Color.Silver
        boton.TextAlign = ContentAlignment.MiddleCenter
    End Sub
    Private Sub btnRecargar_Click(sender As Object, e As EventArgs) Handles btnRecargar.Click
        For i = 0 To pnlAmigos.Controls.Count - 1
            Dim ctrl As Bunifu.Framework.UI.BunifuFlatButton = pnlAmigos.Controls(0)
            pnlAmigos.Controls.Remove(ctrl)
            ctrl.Dispose()
        Next
        sql = "Select * From contactos Where user = " + idYo + " Or amigoDe = " + idYo
        tablaAmigos = bd.seleccionar(sql)
        For i = 0 To tablaAmigos.Rows.Count - 1
            botones = New Bunifu.Framework.UI.BunifuFlatButton
            If tablaAmigos(i).Item(1) = idYo Then
                sql = "Select * From user Where id = " + tablaAmigos(i).Item(2).ToString
            Else
                sql = "Select * From user Where id = " + tablaAmigos(i).Item(1).ToString
            End If
            tabla = bd.seleccionar(sql)
            botones.Text = tabla(0).Item(1) + " " + tabla(0).Item(2)
            botones.Dock = DockStyle.Top
            botones.Name = tabla(0).Item(3).ToString
            valoresBtn(botones, tabla(0).Item(5).ToString)

            AddHandler botones.Click, AddressOf btnAmigo_Click
            pnlAmigos.Controls.Add(botones)
        Next
    End Sub
    'Cerrar Sesion
    Private Sub Principal_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        sql = "Update user Set activo = false Where user = '" & user & "'"
        bd.actualizar(sql)
    End Sub
    'Metodos de Control Box
    Private Sub btnCerrarVentana_Click(sender As Object, e As EventArgs) Handles btnCerrarVentana.Click
        Me.Close()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        btnCerrarVentana_Click(Nothing, Nothing)
        Principal_Load(Nothing, Nothing)


    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        If Me.WindowState = FormWindowState.Normal Then

            Me.WindowState = FormWindowState.Maximized
            btnMaximizar.Image = lstImagenes.Images(0)

        Else
            Me.WindowState = FormWindowState.Normal
            btnMaximizar.Image = lstImagenes.Images(1)

        End If
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub 'Fin Metodos de Control Box

    'Metodos para arrastras Ventana
    Private Sub pnlSuperior_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlSuperior.MouseMove
        If mover Then
            Me.Location = Me.PointToScreen(New Point(MousePosition.X - Me.Location.X - px, MousePosition.Y - Me.Location.Y - py))
        End If
    End Sub
    Private Sub pnlSuperior_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlSuperior.MouseDown
        px = e.X
        py = e.Y
        mover = True
    End Sub
    Private Sub pnlSuperior_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlSuperior.MouseUp
        mover = False
    End Sub 'Fin Metodos para agregar Ventana
End Class
