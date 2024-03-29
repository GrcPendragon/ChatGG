﻿Imports MySql.Data.MySqlClient
Public Class Consulta
    Private cadenaCon As String = "server=192.185.131.131;user=pandatec_grc;password=kirascorp9;database=pandatec_Chat;"

    Private conexion As MySqlConnection
    Private adaptador As MySqlDataAdapter

    Dim datos As DataSet

    Public Sub New()
        conexion = New MySqlConnection(cadenaCon)
        adaptador = New MySqlDataAdapter
    End Sub
    Sub insertar(sql As String)
        conexion.Open()
        adaptador.InsertCommand = conexion.CreateCommand
        adaptador.InsertCommand.CommandText = sql
        adaptador.InsertCommand.ExecuteNonQuery()
        conexion.Close()
    End Sub

    Function seleccionar(sql As String) As DataTable
        Dim tabla As New DataTable

        conexion.Open()
        adaptador.SelectCommand = conexion.CreateCommand
        adaptador.SelectCommand.CommandText = sql
        adaptador.SelectCommand.ExecuteNonQuery()
        adaptador.Fill(tabla)
        conexion.Close()
        Return tabla
    End Function
    Sub actualizar(sql As String)
        conexion.Open()
        adaptador.UpdateCommand = conexion.CreateCommand
        adaptador.UpdateCommand.CommandText = sql
        adaptador.UpdateCommand.ExecuteNonQuery()
        conexion.Close()
    End Sub
    Sub eliminar(sql As String)
        conexion.Open()
        adaptador.DeleteCommand = conexion.CreateCommand
        adaptador.DeleteCommand.CommandText = sql
        adaptador.DeleteCommand.ExecuteNonQuery()
        conexion.Close()
    End Sub
    Sub abrirConexion()
        conexion.Open()
    End Sub
    Sub cerrarConexion()
        conexion.Close()
    End Sub
    Sub insertChat(sql As String)

        adaptador.InsertCommand = conexion.CreateCommand
        adaptador.InsertCommand.CommandText = sql
        adaptador.InsertCommand.ExecuteNonQuery()

    End Sub
    Function selectChat(sql As String) As DataTable
        Dim tabla As New DataTable

        adaptador.SelectCommand = conexion.CreateCommand
        adaptador.SelectCommand.CommandText = sql
        adaptador.SelectCommand.ExecuteNonQuery()
        adaptador.Fill(tabla)
        Return tabla

    End Function
End Class
