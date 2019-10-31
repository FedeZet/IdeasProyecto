Imports MySql.Data.MySqlClient

Public Class ManDispositivo
    Dim hashDispositivo As Hashtable = New Hashtable
    Private Shared instancia As ManDispositivo

    Public Function crearDispositivo(ByVal modelo As String, ByVal bateria As Boolean, ByVal sim As Boolean, ByVal cargador As Boolean, ByVal tapa As Boolean, ByVal estuche As Boolean, ByVal tmemoria As Boolean, ByVal pin As Integer, ByVal idC As Integer)
        Dim objDispositivo As Dispositivo = New Dispositivo(modelo, bateria, sim, cargador, tapa, estuche, tmemoria, pin, idC)
        objDispositivo.guardar()
        Return True
    End Function

    Public Function obtenerDispositivo() As Hashtable
        hashDispositivo.Clear()
        Dim datareader As MySqlDataReader = Dispositivo.obtenerDispositivo()
        Dim objD As Dispositivo = Nothing
        While datareader.Read()
            objD = New Dispositivo(datareader("idD"), datareader("modelo"), datareader("bateria"), datareader("sim"), datareader("cargador"), datareader("tapa"), datareader("estuche"), datareader("tmemoria"), datareader("pin"), datareader("idC"))
            Me.hashDispositivo.Add(objD.IdDispositivo, objD)
        End While
        Return Me.hashDispositivo
    End Function

    Public Function modificarDispositivo(ByVal idDispositivo As Integer, ByVal modelo As String, ByVal bateria As Boolean, ByVal sim As Boolean, ByVal cargador As Boolean, ByVal tapa As Boolean, ByVal estuche As Boolean, ByVal tmemoria As Boolean, ByVal pin As Integer, ByVal idC As Integer)
        Dim objD As Dispositivo = New Dispositivo(idDispositivo, modelo, bateria, sim, cargador, tapa, estuche, tmemoria, pin, idC)
        objD.modificar()
        Return True
    End Function

    Public Function eliminarDispositivo(ByVal idDispositivo As Integer)
        Dim objD As Dispositivo = New Dispositivo(idDispositivo)
        objD.eliminar()
        Return True
    End Function

    Public Function buscarDispositivo(ByVal modelo As String)
        hashDispositivo.Clear()
        Dim objD As Dispositivo = New Dispositivo(modelo)
        Dim datareader As MySqlDataReader = objD.buscar
        While datareader.Read()
            objD = New Dispositivo(datareader("idD"), datareader("modelo"), datareader("bateria"), datareader("sim"), datareader("cargador"), datareader("tapa"), datareader("estuche"), datareader("tmemoria"), datareader("pin"), datareader("idC"))
            Me.hashDispositivo.Add(objD.Modelo, objD)
        End While
        Return Me.hashDispositivo
    End Function

    Public Function buscarDispositivoCli(ByVal idC As Integer)
        hashDispositivo.Clear()
        Dim objD As Dispositivo = New Dispositivo(idC)
        Dim datareader As MySqlDataReader = objD.buscarCli
        While datareader.Read()
            objD = New Dispositivo(datareader("idD"), datareader("modelo"), datareader("bateria"), datareader("sim"), datareader("cargador"), datareader("tapa"), datareader("estuche"), datareader("tmemoria"), datareader("pin"), datareader("idC"))
            Me.hashDispositivo.Add(objD.Modelo, objD)
        End While
        Return Me.hashDispositivo
    End Function

    Public Shared Function getInstancia()
        If instancia Is Nothing Then
            instancia = New ManDispositivo
        End If
        Return instancia
    End Function
End Class
