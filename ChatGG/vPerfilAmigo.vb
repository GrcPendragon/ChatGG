Public Class vPerfilAmigo
    Private px, py As Integer
    Private mover As Boolean = False
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        'lblNombreCompleto.text =
        'lblUser.text =
        'imgAvatar.Image =
    End Sub
    Private Sub btnCerrarVentana_Click(sender As Object, e As EventArgs) Handles btnCerrarVentana.Click
        Me.Close()
    End Sub
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

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
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        'Funcion eliminar amistad
    End Sub
End Class