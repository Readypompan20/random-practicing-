Public Class Surplus_Storage

    ': several Public Property variables holding the attributes from the dataset
    Public Property name As String
    Public Property value As Short
    Public Property unitOfMeasurement As String

    ': creates a list of Surplus Storage objects for the user
    Public Shared Property Surplus_StorageList As New List(Of Surplus_Storage)
    Public Sub New()
        ': constrctor for the Surplus_Storage class
    End Sub

End Class
