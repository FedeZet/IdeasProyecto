Public Class Utiliza

    Private _idO As Integer
    Private _idR As Integer
    Private _cuantos As Integer

    Public Property idO() As Integer
        Get
            ' Return the value stored in the field.
            Return _idO
        End Get
        Set(ByVal Value As Integer)
            ' Store the value in the field.
            _idO = Value
        End Set
    End Property

    Public Property idR() As Integer
        Get
            ' Return the value stored in the field.
            Return _idR
        End Get
        Set(ByVal Value As Integer)
            ' Store the value in the field.
            _idR = Value
        End Set
    End Property

    Public Property Cuantos() As Integer
        Get
            ' Return the value stored in the field.
            Return _cuantos
        End Get
        Set(ByVal Value As Integer)
            ' Store the value in the field.
            _cuantos = Value
        End Set
    End Property


    Public Sub New(ByVal IdO As Integer, ByVal IdR As Integer, ByVal cuantos As Integer)
        Me._idO = IdO
        Me._idR = IdR
        Me._cuantos = cuantos
    End Sub

    Public Sub New(ByVal IdO As Integer)
        Me._idO = IdO
    End Sub


    Public Function agregar()
        Dim obj As DAOUtiliza = New DAOUtiliza
        Return obj.agregar(Me)

    End Function

    'Public Function buscar() As MySql.Data.MySqlClient.MySqlDataReader
    '    Dim obj As DAOUtiliza = New DAOUtiliza
    '    Return obj.buscarUtiliza(Me)
    'End Function

    Public Function obtenerUtilizados() As MySql.Data.MySqlClient.MySqlDataReader
        Dim obj As DAOUtiliza = New DAOUtiliza
        Return obj.obtenerUtilizados(Me)
    End Function

    'Public Function modificar()
    '    Dim obj As DAOUtiliza = New DAOUtiliza
    '    Return obj.modificarRepuesto(Me)
    'End Function

    Public Function eliminar()
        Dim obj As DAOUtiliza = New DAOUtiliza
        Return obj.eliminarUtiliza(Me)
    End Function
End Class
