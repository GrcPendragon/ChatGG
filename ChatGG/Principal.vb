Public Class Principal
    Private px, py As Integer
    Private mover As Boolean = False
    Private bd As New Consulta
    Private nombre, apellidos, user, rutaImg, sql As String
    Private tabla As New DataTable
    Sub New()
        InitializeComponent()
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'La ventana que desees mostrar
        Dim ventanaIni As New vInicioSesion
        If ventanaIni.ShowDialog = vbCancel Then
            Me.Close()
        End If
        Me.user = ventanaIni.user
        sql = "Select * from user where user = '" & Me.user & "'"
        tabla = bd.seleccionar(sql)
        btnPerfil.Text = tabla(0).Item(1) & " " & tabla(0).Item(2)
    End Sub
    Private Sub btnCerrarVentana_Click(sender As Object, e As EventArgs) Handles btnCerrarVentana.Click
        Me.Close()
    End Sub

    Private Sub btnMaximizar_Click(sender As Object, e As EventArgs) Handles btnMaximizar.Click
        If Me.WindowState = FormWindowState.Normal Then

            Me.WindowState = FormWindowState.Maximized
            btnMaximizar.Image = imgLstImagenes.Images(0)

        Else
            Me.WindowState = FormWindowState.Normal
            btnMaximizar.Image = imgLstImagenes.Images(1)

        End If
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

    Private Sub btnAmigo_Click(sender As Object, e As EventArgs) Handles btnAmigo.Click
        Dim f = New vChat()

        f.TopLevel = False
        f.Parent = SplitContainer1.Panel2
        f.Show()
        f.Dock = DockStyle.Fill
    End Sub

    Private Sub btnAgregarUser_Click(sender As Object, e As EventArgs) Handles btnAgregarUser.Click
        'Dim f = New vRegistro()

        'f.TopLevel = False
        'f.Parent = SplitContainer1.Panel2
        'f.Show()
        'vAddAmigo.ShowDialog()
        Dim f = New Consulta()
    End Sub




End Class
