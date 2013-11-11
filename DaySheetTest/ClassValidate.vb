Option Strict On

Imports Microsoft.VisualBasic

Public Class ClassValidate
    Public Function checkzipcode(ByVal strIn As String) As Boolean
        'check inside for all digits
        If CheckIntegerSubstring(strIn) = False Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function CheckSSN(ByVal StrIn As String) As Boolean
        Return CheckIntegerSubstring(StrIn)
    End Function
    Public Function CheckPhone(ByVal StrIn As String) As Boolean
        Return CheckIntegerSubstring(StrIn)
    End Function

    Public Function CheckIntegerSubstring(ByVal strIn As String) As Boolean
        'check to see that each character is between 0-9
        Dim i As Integer
        Dim strOne As String

        For i = 0 To Len(strIn) - 1
            'get one char from the string
            strOne = strIn.Substring(i, 1)
            Select Case strOne
                'if char is 0-9, keep going
                Case "0" To "9"
                Case " "
                    'if char is anything else, stop and return false
                Case "'"
                    Return False
                Case Else
                    Return False
            End Select
        Next

        'if it makes it thru the loop, return true
        Return True
    End Function
    Public Function CheckMoney(ByVal strIn As String) As Boolean
        'check to see that each character is between 0-9
        Dim i As Integer
        Dim strOne As String

        For i = 0 To Len(strIn) - 1
            'get one char from the string
            strOne = strIn.Substring(i, 1)
            Select Case strOne
                'if char is 0-9, keep going
                Case "0" To "9"
                Case "."
                    'if char is anything else, stop and return false
                Case "'"
                    Return False
                Case Else
                    Return False
            End Select
        Next

        'if it makes it thru the loop, return true
        Return True
    End Function
    Public Function CheckAlphaNumeric(ByVal strIn As String) As Boolean
        'check to see that each character is between 0-9
        Dim i As Integer
        Dim strOne As String

        For i = 0 To Len(strIn) - 1
            'get one char from the string
            strOne = strIn.Substring(i, 1)
            Select Case strOne.ToLower
                'if char is 0-9, keep going
                Case "a" To "z"
                Case "0" To "9"
                Case " "
                Case "."
                Case Else
                    Return False
            End Select
        Next

        'if it makes it thru the loop, return true
        Return True
    End Function
    Public Function CheckComments(ByVal strIn As String) As Boolean
        'check to see that each character is between 0-9
        Dim i As Integer
        Dim strOne As String

        For i = 0 To Len(strIn) - 1
            'get one char from the string
            strOne = strIn.Substring(i, 1)
            Select Case strOne.ToLower
                'if char is 0-9, keep going
                Case "a" To "z"
                Case "0" To "9"
                Case " "
                Case "."
                Case "$"
                Case ","
                Case ":"
                Case ";"
                Case "-"
                Case Else
                    Return False
            End Select
        Next

        'if it makes it thru the loop, return true
        Return True
    End Function
  
    Public Function CheckLetterSubstring(ByVal strIn As String) As Boolean
        'check to see that each character is between 0-9
        Dim i As Integer
        Dim strOne As String

        For i = 0 To Len(strIn) - 1
            'get one char from the string
            strOne = strIn.Substring(i, 1)
            Select Case strOne.ToLower
                'if char is 0-9, keep going
                Case "a" To "z"
                Case " "
                Case "."
                Case "-"
                    'if char is anything else, stop and return false
                Case Else
                    Return False
            End Select
        Next
        'if it makes it thru the loop, return true
        Return True
    End Function
End Class
