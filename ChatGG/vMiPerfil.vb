﻿Public Class vMiPerfil
    Private px, py As Integer
    Private mover As Boolean = False
    Dim cargo As Boolean = False
    Dim genero As String
    Private bd As New Consulta
    Private tabla As DataTable
    Public user, pass As String
    Sub New()
        InitializeComponent()
    End Sub
    Sub New(tabla As DataTable)
        InitializeComponent()
        Me.tabla = tabla
    End Sub
    Private Sub vMiPerfil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ventana As New Principal
        txtNombre.Text = tabla(0).Item(1)
        txtApellidos.Text = tabla(0).Item(2)
        txtUser.Text = tabla(0).Item(3)
        txtPass.Text = tabla(0).Item(4)
        genero = tabla(0).Item(5).ToString
        imgAvatar.Image = ventana.lstImagenes.Images(Convert.ToInt32(genero))
        If genero = "2" Then
            rdbHombre.Checked = True
        Else
            rdbMujer.Checked = True
        End If
        cargo = True
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
    Private Sub rdbHombre_CheckedChanged(sender As Object, e As EventArgs) Handles rdbHombre.CheckedChanged
        Dim ventana As New Principal
        If rdbHombre.Checked Then
            imgAvatar.Image = ventana.lstImagenes.Images(2)
            genero = "2"
        Else
            imgAvatar.Image = ventana.lstImagenes.Images(3)
            genero = "3"
        End If
        If cargo Then
            btnGuardar.Enabled = True
        End If
    End Sub
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim sql As String
        Dim id As Integer
        id = tabla(0).Item(0)
        If tabla(0).Item(4).ToString <> txtPass.Text Then
            txtPass.Text = Encriptar(txtPass.Text, "Lupe", False)
        End If
        pass = txtPass.Text
        sql = "Update user Set nombre = '" + txtNombre.Text + "', apellidos = '" + txtApellidos.Text + "', user = '" + txtUser.Text + "', pass = '" + pass + "', genero = '" + genero + "' Where id = " & id
        bd.actualizar(sql)
        user = txtUser.Text
        Me.DialogResult = vbOK
    End Sub
    'Metodos de Control Box
    Private Sub btnCerrarVentana_Click(sender As Object, e As EventArgs) Handles btnCerrarVentana.Click
        Me.DialogResult = vbCancel
    End Sub
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    'Metodos para arrastrar ventana
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