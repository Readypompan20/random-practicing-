Public Class Seat

    Public Property SeatType As String   ': Seat type is "window", "aisle", "middle"
    Public Property SeatPrice As Single
    Public Property FlightNumber As String
    Public Property SeatRow As Integer
    Public Property SeatPosition As Integer
    Public Property SeatNumber As String   ': Seat Number is a text such as "A3"




    Public Shared Property SeatList As New List(Of Seat)
    Public Sub New()
        ': Default Constructor of a Seat Object with default parameter values
    End Sub

End Class
