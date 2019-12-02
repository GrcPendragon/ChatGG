Public Class vPerfilAmigo
    Private px, py As Integer
    Private mover As Boolean = False
    Private idYo, idAmigo, sql As String
    Private bd As New Consulta
    Private tabla As DataTable
    Sub New()
        InitializeComponent()
    End Sub
    Private Sub vPerfilAmigo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ventana As New Principal
        sql = "Select * From user Where user = '" + ventana.amigo + "'"
        tabla = bd.seleccionar(sql)
        imgAvatar.Image = ventana.lstImagenes.Images(Convert.ToInt32(tabla(0).Item(5).ToString))
        lblTitulo.Text = "Perfil de: " + tabla(0).Item(1)
        lblNombreCompleto.Text = tabla(0).Item(1) + " " + tabla(0).Item(2)
        lblGenero.Text = "Genero: " + tabla(0).Item(5).ToString
        lblUser.Text = "Usuario: " + tabla(0).Item(3).ToString
        idAmigo = tabla(0).Item(0).ToString
        idYo = ventana.idYo
    End Sub
    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        sql = "Delete From contactos Where user = '" + idYo + "' And amigoDe = '" + idAmigo + "' Or user = '" + idAmigo + "' And amigoDe = '" + idYo + "'"
        bd.eliminar(sql)
        sql = "Delete From mensaje Where user1 = '" + idYo + "' And user2 = '" + idAmigo + "' Or user1 = '" + idAmigo + "' And user2 = '" + idYo + "'"
        bd.eliminar(sql)
    End Sub
    'Metodos de Control Box
    Private Sub btnCerrarVentana_Click(sender As Object, e As EventArgs) Handles btnCerrarVentana.Click
        Me.Close()
    End Sub
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    'Metodos arrastras la ventana
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
    End Sub
End Class