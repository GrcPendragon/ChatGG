Public Class vInicioSesion
    Private px, py As Integer
    Private mover As Boolean = False
    Private sql As String
    Private bd As New Consulta
    Public user As String
    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        Dim pass As String

        user = txtUser.Text
        pass = txtPass.Text
        sql = "Select * from user where user = '" & user & "' and pass = '" & pass & "'"
        If bd.seleccionar(sql).Rows.Count = 1 Then 'Consulta
            Me.DialogResult = DialogResult.OK
        Else
            MsgBox("Usuario y/o contraseña incorrecos.")
        End If
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

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnCerrarVentana_Click(sender As Object, e As EventArgs) Handles btnCerrarVentana.Click
        Me.DialogResult = DialogResult.Cancel
    End Sub
End Class