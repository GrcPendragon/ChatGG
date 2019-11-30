Public Class vAddAmigo
    Private px, py As Integer
    Private mover As Boolean = False
    Private user As Integer
    Sub New(user As Integer)
        InitializeComponent()
        Me.user = user
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim amigoDe, sql As String
        Dim bd As New Consulta
        Dim tabla As New DataTable
        amigoDe = txtUser.Text
        If amigoDe <> "" Then
            sql = "Select * from user where user = '" & amigoDe & "'"
            tabla = bd.seleccionar(sql)
            If tabla.Rows.Count <> 0 Then
                Dim idAmigo As Integer
                idAmigo = tabla(0).Item(0)
                sql = "Select * from contactos where user = " + user.ToString + " And amigoDe = " + idAmigo.ToString + " Or user = " + idAmigo.ToString + " And amigoDe = " + user.ToString
                tabla = bd.seleccionar(sql)
                If tabla.Rows.Count = 0 Then

                    sql = "Insert into contactos values (''," + user.ToString + "," + idAmigo.ToString + ")"
                    bd.insertar(sql)
                    Me.DialogResult = vbOK
                Else
                    MsgBox("Ya tienes amistad con este usuario")
                End If
            Else
                MsgBox("El usuario no existe")
            End If
        Else
            MsgBox("Ingrese el nombre de usuario")
        End If
    End Sub
    'Metodos de Control Box
    Private Sub btnCerrarVentana_Click(sender As Object, e As EventArgs) Handles btnCerrarVentana.Click
        Me.DialogResult = vbCancel
    End Sub
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    'Metodos arrastrar ventana
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