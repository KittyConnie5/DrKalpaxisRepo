Public Class ClassCalculation
    Private mdecSubTotal As Decimal
    Private mdecCurrentBalTotal As Decimal
    Private mdecAcctsTotal As Decimal

    Public ReadOnly Property SubTotalAmount() As Decimal
        Get
            Return mdecSubTotal
        End Get
    End Property
    Public ReadOnly Property CurrentBalAmount() As Decimal
        Get
            Return mdecCurrentBalTotal
        End Get
    End Property
    Public ReadOnly Property TotalAcctsRec() As Decimal
        Get
            Return mdecAcctsTotal
        End Get
    End Property
    Public Sub CalculateSubTotal(ByVal decPreviousTotal As Decimal, ByVal decChargeTotal As Decimal)
        'compute subtotal
        mdecSubTotal = (decPreviousTotal + decChargeTotal)
    End Sub
    Public Sub CalculateCurrentBalTotal(ByVal decSubTotal As Decimal, ByVal decPymtAdj As Decimal)
        'compute subtotal
        mdecCurrentBalTotal = (decSubTotal - decPymtAdj)
    End Sub
    Public Sub CalculateAcctsRecTotal(ByVal decSubTotal As Decimal, ByVal decPymtAdj As Decimal)
        'compute subtotal
        mdecAcctsTotal = (decSubTotal - decPymtAdj)
    End Sub
End Class
