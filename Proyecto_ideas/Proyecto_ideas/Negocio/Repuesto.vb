Public Class Repuesto

    Private _idRepuesto As String
    Private _nombre As String
    Private _cantidad As Integer


    Public Property IdRepuesto() As String
        Get
            ' Return the value stored in the field.
            Return _idRepuesto
        End Get
        Set(ByVal Value As String)
            ' Store the value in the field.
            _idRepuesto = Value
        End Set
    End Property

    Public Property Nombre() As String
        Get
            ' Return the value stored in the field.
            Return _nombre
        End Get
        Set(ByVal Value As String)
            ' Store the value in the field.
            _nombre = Value
        End Set
    End Property

    Public Property Cantidad() As Integer
        Get
            ' Return the value stored in the field.
            Return _cantidad
        End Get
        Set(ByVal Value As Integer)
            ' Store the value in the field.
            _cantidad = Value
        End Set
    End Property

    Public Sub New(ByVal idRepuesto As Integer, ByVal nombreRepuesto As String, ByVal cantidadRepuesto As Integer)
        Me._idRepuesto = idRepuesto
        Me._nombre = nombreRepuesto
        Me._cantidad = cantidadRepuesto
    End Sub

    Public Function agregar()
        Dim obj As DAORepuesto = New DAORepuesto
        Return obj.agregar(Me)

    End Function
End Class
