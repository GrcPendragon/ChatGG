Public Class vInicioSesion
    Private px, py As Integer
    Private mover As Boolean = False
    Private sql As String
    Private bd As New Consulta
    Public user As String
    Private Sub btnIniciarSesion_Click(sender As Object, e As EventArgs) Handles btnIniciarSesion.Click
        Dim pass As String

        user = txtUser.Text
        pass = Encriptar(txtPass.Text, "Lupe", False)

        sql = "Select * from user where user = '" & user & "' and pass = '" & pass & "'"
        If bd.seleccionar(sql).Rows.Count = 1 Then 'Consulta
            sql = "Update user Set activo = true where user = '" & user & "'"
            bd.actualizar(sql)
            Me.DialogResult = DialogResult.OK
        Else
            MsgBox("Usuario y/o contraseña incorrecos.")
        End If
    End Sub
    Private Sub lblRegistro_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblRegistro.LinkClicked
        Dim ventana As New vRegistro()
        ventana.ShowDialog()
    End Sub
    'Metodos para arrastrar la ventana
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
    'Control box
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub btnCerrarVentana_Click(sender As Object, e As EventArgs) Handles btnCerrarVentana.Click
        Me.DialogResult = DialogResult.Cancel
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