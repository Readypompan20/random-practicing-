Public Class Profit_Contribution

    ': several Public Property variables holding the attributes from the dataset
    Public Property name As String
    Public Property value As Single
    Public Property unitOfMeasurement As String

    ': creates a list of Profit_Contribution objects for the user
    ': ProfitCont is short for "profit contribution"
    Public Shared Property ProfitContList As New List(Of Profit_Contribution)
    Public Sub New()
            ': constrctor for the Profit_Contribution class
        End Sub
End Class
