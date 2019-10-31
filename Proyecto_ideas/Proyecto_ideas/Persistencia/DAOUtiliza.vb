Public Class DAOUtiliza

    Public Function agregar(ByVal obj As Utiliza)
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "INSERT INTO utiliza(idO, idR, cuantos) VALUES (" + obj.idO.ToString + ", " + obj.idR.ToString + "," + obj.Cuantos.ToString + ")"
        objConexion.ejecutar(sentencia, False)
        Return True
    End Function

    Public Function obtenerUtilizados(ByVal obj As Utiliza) As MySql.Data.MySqlClient.MySqlDataReader
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "SELECT * FROM utiliza where idO = " + obj.idO.ToString
        Return objConexion.ejecutar(sentencia, True)
    End Function

    'Public Function modificarUtiliza(ByVal obj As Utiliza)
    '    Dim sentencia As String
    '    Dim objConexion As ConectorBD = New ConectorBD
    '    sentencia = "UPDATE repuesto SET nombreR = '" + obj.Nombre + "' , cantidad = " + obj.Cantidad.ToString + ", costoRepuesto= " + obj.costo.ToString + " WHERE idR = " + obj.IdRepuesto.ToString + ";"
    '    objConexion.ejecutar(sentencia, False)
    '    Return True
    'End Function

    Public Function eliminarUtiliza(ByVal obj As Utiliza)
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "DELETE FROM utiliza WHERE idO = " + obj.idO.ToString + ";"
        objConexion.ejecutar(sentencia, False)
        Return True
    End Function

    Public Function eliminarRepuestoUtilizado(ByVal obj As Utiliza)
        Dim sentencia As String
        Dim objConexion As ConectorBD = New ConectorBD
        sentencia = "DELETE FROM utiliza WHERE idR = " + obj.idR.ToString + ";"
        objConexion.ejecutar(sentencia, False)
        Return True
    End Function

    'Public Function buscarUtiliza(ByVal obj As Utiliza) As MySql.Data.MySqlClient.MySqlDataReader
    '    Dim sentencia As String
    '    Dim objConexion As ConectorBD = New ConectorBD
    '    sentencia = "select * from repuesto where nombreR like '%" + obj.Cuantos + "%';"
    '    Return objConexion.ejecutar(sentencia, True)
    'End Function

End Class
