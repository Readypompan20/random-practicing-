Public Class Sales_Flavor

    ': several Public Property variables holding the attributes from the dataset
    Public Property name As String
    Public Property value As Short
    Public Property unitOfMeasurement As String

    ': creates a list of Sales flavor objects for the user
    Public Shared Property Sales_FlavorList As New List(Of Sales_Flavor)
    Public Sub New()
        ': constrctor for the Sales_Flavor class
    End Sub
End Class
