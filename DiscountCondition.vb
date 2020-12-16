Public Class DiscountCondition
    ' several Public Property variables holding the attributes from the dataset
    Public Property name As String
    Public Property value As Short
    Public Property unitOfMeasurement As String

    ': creates a list of DiscountCondition objects for the user
    ': DiscCond is short for "discount condiditon"
    Public Shared Property DiscCondList As New List(Of DiscountCondition)
    Public Sub New()
        ': constrctor for the DiscountCondition class
    End Sub
End Class
