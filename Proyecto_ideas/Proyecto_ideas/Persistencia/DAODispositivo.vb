Public Class DAODispositivo

    Public Function guardar(ByVal obj As Dispositivo)

        Dim dao = New ConectorBD()

        Dim sentencia As String
        sentencia = "insert into dispositivo(modelo,bateria,sim,cargador,tapa,estuche,T_Memoria,pin) values('" + obj.Modelo + "'," + obj.Bateria.ToString + "," + obj.Sim.ToString + "," + obj.Cargador.ToString + "," + obj.Tapa.ToString + "," + obj.Estuche.ToString + "," + obj.Tmemoria.ToString + "," + obj.Pin.ToString + ")"
        dao.ejecutar(sentencia, False)

        Return True
    End Function

End Class
