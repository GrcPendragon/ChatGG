Public Class vRegistro
    Private px, py As Integer
    Private mover As Boolean = False
    Public nombre, apellidos, user, pass As String
    Public avatar As Image
    Private Sub btnCerrarVentana_Click(sender As Object, e As EventArgs) Handles btnCerrarVentana.Click
        Me.Close()

    End Sub
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub vRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub pnlSuperior_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlSuperior.MouseMove
        If mover Then
            Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - px, Me.MousePosition.Y - Me.Location.Y - py))
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
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        nombre = txtNombre.Text
        apellidos = txtApellidos.Text
        user = txtUser.Text
        pass = txtPass.Text
        If txtPassRepet.Text = pass Then
            'registrar
        Else
            MsgBox("Las contraseñas no coinciden.")
        End If
    End Sub
End Class