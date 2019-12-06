Imports System.Threading
Public Class vChat
    Private bd As New Consulta
    Dim Amigo, idYo, idAmigo, user, fecha, sql As String
    Dim tabla, tablaMensajes As DataTable
    Dim finTabla As Integer
    Private Sub vChat_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        bd.cerrarConexion()
    End Sub
    Sub New()
        InitializeComponent()
    End Sub
    Sub New(Amigo As String, idYo As String)
        InitializeComponent()
        Me.Amigo = Amigo
        Me.idYo = idYo
    End Sub
    Private Sub vChat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ventana As New Principal
        CheckForIllegalCrossThreadCalls = False
        sql = "Select * From user Where user = '" + Amigo + "'"
        tabla = bd.seleccionar(sql)
        imgAmigo.Image = ventana.lstImagenes.Images(Convert.ToInt32(tabla(0).Item(5).ToString))
        lblAmigo.Text = tabla(0).Item(1).ToString
        idAmigo = tabla(0).Item(0).ToString
        '=====Se cargaron los datos necesarios de ambos usuarios=====
        '=====Se empiezan a cargar los mensajes en el chat=====
        sql = "Select * From mensaje Where user1 = " + idYo + " And user2 = " + idAmigo + " Or user1 = " + idAmigo + " And user2 = " + idYo + " Order By fecha Asc"
        tablaMensajes = bd.seleccionar(sql)
        For i = 0 To tablaMensajes.Rows.Count - 1
            If tablaMensajes(i).Item(1).ToString = idYo Then
                user = "Me: "
            Else
                user = tabla(0).Item(1).ToString + ": "
            End If
            txtChat.Text = txtChat.Text + user + tablaMensajes(i).Item(3).ToString() + "[" + tablaMensajes(i).Item(4) + "]" + vbCrLf
        Next
        txtChat.SelectionStart = Len(txtChat.Text)
        txtChat.ScrollToCaret()
        txtChat.Select()
        finTabla = tablaMensajes.Rows.Count - 1
        Timer1.Enabled = True
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        sql = "Select * From mensaje Where user1 = " + idYo + " And user2 = " + idAmigo + " Or user1 = " + idAmigo + " And user2 = " + idYo + " Order By fecha Asc"
        tablaMensajes = bd.seleccionar(sql)
        If finTabla < tablaMensajes.Rows.Count - 1 Then
            For i = finTabla + 1 To tablaMensajes.Rows.Count - 1
                If tablaMensajes(i).Item(1).ToString = idYo Then
                    Exit For
                Else
                    user = tabla(0).Item(1).ToString + ": "
                End If
                txtChat.Text = txtChat.Text + user + tablaMensajes(i).Item(3).ToString() + "[" + tablaMensajes(i).Item(4) + "]" + vbCrLf
            Next
            txtChat.SelectionStart = Len(txtChat.Text)
            txtChat.ScrollToCaret()
            txtChat.Select()
            finTabla = tablaMensajes.Rows.Count - 1
        End If

    End Sub
    Private Sub txtMensaje_KeyUp(sender As Object, e As KeyEventArgs) Handles txtMensaje.KeyUp
        If e.KeyCode = Keys.Enter Then
            If txtMensaje.Text <> "" Then
                If txtMensaje.Text <> vbCrLf Then
                    btnEnviar_Click(Nothing, Nothing)
                    txtMensaje.Clear()
                Else
                    txtMensaje.Text = ""
                End If
            End If
        End If
    End Sub
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Dim bdInsert As New Consulta
        fecha = DateTime.Now().ToString("yyyy-MM-dd hh:mm:ss")
        If txtChat.Text = "" Then
            txtChat.Text = txtChat.Text + "Me: " + txtMensaje.Text + "[" + fecha + "]" + vbCrLf
        Else
            txtChat.Text = txtChat.Text + vbLf + "Me: " + txtMensaje.Text + "[" + fecha + "]" + vbCrLf
        End If
        sql = "Insert Into mensaje values(''," + idYo + "," + idAmigo + ",'" + txtMensaje.Text + "','" + fecha + "')"

        bdInsert.insertar(sql)
    End Sub
End Class