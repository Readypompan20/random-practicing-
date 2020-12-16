'The LogIn class works closely with the Welcome form to allow the uesr to log in
Public Class LogIn
    ' several Public Property variables holding the attributes from the dataset
    Public Property username As String
        Public Property password As String

    ': creates a list of LogIn objects for the user
    Public Shared Property LogInList As New List(Of LogIn)
    Public Sub New()
        ': constrctor for the LogIn class
    End Sub
End Class
