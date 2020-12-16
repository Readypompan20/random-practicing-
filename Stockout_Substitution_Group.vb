Public Class Stockout_Substitution_Group

    ': several Public Property variables holding the attributes from the dataset
    Public Property name As String
    Public Property value As Short
    Public Property unitOfMeasurement As String

    ': creates a list of Stockout substitution group objects for the user
    ': stockout_SubGrp is short for "stockout sub group"
    Public Shared Property Stockout_SubGrpList As New List(Of Stockout_Substitution_Group)
    Public Sub New()
        ': constrctor for the Stockout_Substitution_Group class
    End Sub


End Class
