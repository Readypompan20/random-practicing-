Public Class Storage_Capacity

    ': several Public Property variables holding the attributes from the dataset
    Public Property name As String
    Public Property value As Short
    Public Property unitOfMeasurement As String

    ': creates a list of Stockout substitution group objects for the user
    ': storage_cap is short for "storage capacity"
    Public Shared Property Storage_CapList As New List(Of Storage_Capacity)
    Public Sub New()
        ': constrctor for the Storage_Capacity class
    End Sub

End Class
