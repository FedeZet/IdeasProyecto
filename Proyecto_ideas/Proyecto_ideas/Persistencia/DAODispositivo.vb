Public Class DAODispositivo
    Public Function guardar(ByVal obj As Dispositivo)
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "INSERT INTO dispositivo(modelo,bateria,sim,cargador,tapa,estuche,tmemoria,pin,idC) VALUES ('" + obj.Modelo + "'," + obj.Bateria.ToString + "," + obj.Sim.ToString + "," + obj.Cargador.ToString + "," + obj.Tapa.ToString + "," + obj.Estuche.ToString + "," + obj.Tmemoria.ToString + "," + obj.Pin.ToString + "," + obj.IdC.ToString + ")"
        objConexion.ejecutar(sentencia, False)
        Return True
    End Function

    Public Function obtenerDispositivo() As MySql.Data.MySqlClient.MySqlDataReader
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "SELECT * FROM dispositivo"
        Return objConexion.ejecutar(sentencia, True)
    End Function

    Public Function modificarDispositivo(ByVal obj As Dispositivo)
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "UPDATE dispositivo SET modelo = '" + obj.Modelo + "' , bateria = " + obj.Bateria.ToString + " , sim = " + obj.Sim.ToString + " , cargador = " + obj.Cargador.ToString + " , tapa = " + obj.Tapa.ToString + " , estuche = " + obj.Estuche.ToString + " , tmemoria = " + obj.Tmemoria.ToString + " , pin = " + obj.Pin.ToString + " , idC = " + obj.IdC.ToString + " WHERE idD = " + obj.IdDispositivo.ToString + ";"
        objConexion.ejecutar(sentencia, False)
        Return True
    End Function

    Public Function eliminarDispositivo(ByVal obj As Dispositivo)
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "DELETE FROM dispositivo WHERE idD = " + obj.IdDispositivo.ToString + ";"
        objConexion.ejecutar(sentencia, False)
        Return True
    End Function

    Public Function buscarDispositivo(ByVal obj As Dispositivo) As MySql.Data.MySqlClient.MySqlDataReader
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "SELECT * FROM dispositivo WHERE modelo LIKE '" + obj.Modelo + "%';"
        Return objConexion.ejecutar(sentencia, True)
    End Function

    Public Function buscarDispositivoCli(ByVal obj As Dispositivo) As MySql.Data.MySqlClient.MySqlDataReader
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "SELECT * FROM dispositivo WHERE dispositivo.idC = " + obj.IdC.ToString + ";"
        Return objConexion.ejecutar(sentencia, True)
    End Function
End Class
