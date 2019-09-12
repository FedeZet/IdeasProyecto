Imports MySql.Data.MySqlClient
Public Class ConectorBD
    Private stringConexion As String
    Private objConexion As MySqlConnection

    Public Sub New()
        Me.stringConexion = "server=localhost;Database=ideas;uid=root;pwd= "
        Me.objConexion = New MySqlConnection(Me.stringConexion)
    End Sub

    Public Sub Conectar()
        Try
            Me.objConexion.Open()
            'Borrar siguiente línea
            MsgBox("Conexión exitosa.")
        Catch ex As Exception
            MsgBox("Conexión falló.")
        End Try
End Class
