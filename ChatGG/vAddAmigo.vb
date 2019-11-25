Public Class vAddAmigo
    Private px, py As Integer
    Private mover As Boolean = False

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
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        'Consulta de insertar
    End Sub
End Class