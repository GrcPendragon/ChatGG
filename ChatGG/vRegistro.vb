Public Class vRegistro
    Private px, py As Integer
    Private mover As Boolean = False
    Private rutaDefault As String = "C:\ChatGG\fotos\"
    Private rutaImg As String
    Public nombre, apellidos, user, pass, genero, sql As String

    Dim bd As Consulta
    Private Sub vRegistro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bd = New Consulta
    End Sub
    Private Sub btnRegistrar_Click(sender As Object, e As EventArgs) Handles btnRegistrar.Click
        nombre = txtNombre.Text
        apellidos = txtApellidos.Text
        user = txtUser.Text
        pass = txtPass.Text

        If txtPassRepet.Text = pass Then
            sql = "Select * from user where id = '" & user & "'"
            If bd.seleccionar(sql).Rows.Count = 0 Then
                pass = Encriptar(txtPass.Text, "Lupe", False)
                sql = "Insert into user values ('','" + nombre + "','" + apellidos + "','" + user + "','" + pass + "','" + genero + "',false)"
                bd.insertar(sql)
                Me.Close()
            Else
                MsgBox("El usuario ya existe")
            End If
        Else
            MsgBox("Las contraseñas no coinciden.")
        End If
    End Sub
    Private Sub rdbHombre_CheckedChanged(sender As Object, e As EventArgs) Handles rdbHombre.CheckedChanged
        Dim ventana As New Principal
        If rdbHombre.Checked Then
            imgAvatar.Image = ventana.lstImagenes.Images(2)
            genero = "2"
        Else
            imgAvatar.Image = ventana.lstImagenes.Images(3)
            genero = "3"
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

    'Metodo de Encriptacion
    Public Function Encriptar(Texto As String, Llave As String, Mode As Boolean) As String
        'Si Mode es falso, encripta, si es verdadero, desencripta

        Dim p As Int32, j As Int32, NuChr As Int32
        Dim letraTexto As String, letraLlave As String, Salida As String = ""

        For j = 0 To Len(Texto) - 1
            letraTexto = Texto.Chars(j)
            If p = Len(Llave) - 1 Then
                p = 0
            End If
            letraLlave = Llave.Chars(p)
            p += 1
            If Mode = False Then 'si es falso, encripta, si es verdadero, desencripta
                NuChr = Asc(letraTexto) + Asc(letraLlave)
                If NuChr > 255 Then
                    NuChr = NuChr - 255
                End If
            Else
                NuChr = Asc(letraTexto) - Asc(letraLlave)
                If NuChr < 0 Then
                    NuChr = NuChr + 255
                End If
            End If
            Salida &= Chr(NuChr)
        Next
        Return Salida
    End Function
End Class