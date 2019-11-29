Imports System.IO

Public Class vRegistro
    Private px, py As Integer
    Private mover As Boolean = False
    Private rutaImg As String
    Public nombre, apellidos, user, pass, sql As String
    Public avatar As Byte()

    Dim bd As Consulta
    Private Sub vRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bd = New Consulta
    End Sub
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        Dim binario As New MemoryStream
        'MsgBox(Imaging.ImageFormat.Jpeg.ToString)
        'btnAvatar.Image.Save(binario, btnAvatar.Image.RawFormat)
        'avatar = binario.GetBuffer
        nombre = txtNombre.Text
        apellidos = txtApellidos.Text
        user = txtUser.Text
        pass = txtPass.Text

        If txtPassRepet.Text = pass Then
            sql = "Select * from user where id = '" & user & "'"
            If bd.seleccionar(sql).Rows.Count = 0 Then
                sql = "Insert into user values ('','" + nombre + "','" + apellidos + "','" + user + "','" + pass + "','" + rutaImg + "',false)"
                bd.insertar(sql)
            Else
                MsgBox("El usuario ya existe")
            End If
        Else
            MsgBox("Las contraseñas no coinciden.")
        End If
    End Sub

    Private Sub btnAvatar_Click(sender As Object, e As EventArgs) Handles btnAvatar.Click
        If opnImagen.ShowDialog = vbOK Then
            If opnImagen.FileName <> "" Then
                rutaImg = opnImagen.FileName
                btnAvatar.Image = Image.FromFile(rutaImg)
            End If
        End If
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
End Class