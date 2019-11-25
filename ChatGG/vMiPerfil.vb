Public Class vMiPerfil
    Private px, py As Integer
    Private mover As Boolean = False
    Dim cargo As Boolean = False
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

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
    Private Sub pnlSuperior_MouseUp(sender As Object, e As MouseEventArgs) Handles pnlSuperior.MouseUp
        mover = False
    End Sub
    Private Sub pnlSuperior_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlSuperior.MouseDown
        px = e.X
        py = e.Y
        mover = True
    End Sub

    Private Sub txtNombre_OnValueChanged(sender As Object, e As EventArgs) Handles txtNombre.OnValueChanged
        If cargo Then
            btnGuardar.Enabled = True
        End If
    End Sub

    Private Sub txtApellidos_OnValueChanged(sender As Object, e As EventArgs) Handles txtApellidos.OnValueChanged
        If cargo Then
            btnGuardar.Enabled = True
        End If
    End Sub

    Private Sub txtUser_OnValueChanged(sender As Object, e As EventArgs) Handles txtUser.OnValueChanged
        If cargo Then
            btnGuardar.Enabled = True
        End If
    End Sub
    Private Sub txtPass_OnValueChanged(sender As Object, e As EventArgs) Handles txtPass.OnValueChanged
        If cargo Then
            btnGuardar.Enabled = True
        End If
    End Sub

    Private Sub btnAvatar_Click(sender As Object, e As EventArgs) Handles btnAvatar.Click
        btnAvatar.Image = Image.FromFile("C:\Users\mg213\Documents\Proyectos\ChatGG\ChatGG\bin\Debug\img\User_V2.png")
        btnAvatar.BackgroundImage = btnAvatar.Image
    End Sub

    Private Sub btnAvatar_BackgroundImageChanged(sender As Object, e As EventArgs) Handles btnAvatar.BackgroundImageChanged
        If cargo Then
            btnGuardar.Enabled = True
        End If
    End Sub

    Private Sub vMiPerfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargo = True
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        'hacer update a la base de datos
    End Sub
End Class