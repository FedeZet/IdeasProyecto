Imports MySql.Data.MySqlClient
Public Class ConectorBD
    Private stringConexion As String
    Private Shared instancia As ConectorBD
    Private objConexion As MySqlConnection

    Public Sub New()
        Me.stringConexion = "server=localhost;Database=ideas;uid=root;pwd= "
        Me.objConexion = New MySqlConnection(Me.stringConexion)
    End Sub

    Public Sub Conectar()
        Try
            Me.objConexion.Open()
            'Borrar siguiente línea
            'MsgBox("Conexión exitosa.")
        Catch ex As Exception
            MsgBox("Conexión falló.")
        End Try
    End Sub
    Public Function ejecutar(ByVal sql As String, ByVal seleccion As Boolean) As MySqlDataReader
        Me.Conectar()
        Dim cmd As MySqlCommand = New MySqlCommand(sql, Me.objConexion)
        If seleccion = False Then
            cmd.ExecuteNonQuery()
            Return Nothing
        End If
        Return cmd.ExecuteReader()

    End Function

    Public Shared Function getInstancia()
        If instancia Is Nothing Then
            instancia = New ConectorBD
        End If
        Return instancia
    End Function
End Class