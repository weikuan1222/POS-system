
Imports System.Text.RegularExpressions
Public Class FrontEndUserInputCheck
    Public Function NoInputSymbol(e, btn)
        If (e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return)) Then
            Return btn.PerformClick()
        ElseIf (e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back)) Then
            Return e.KeyChar
        ElseIf Not System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, "^[a-zA-Z0-9]*$") Then
            Return ""

        Else
            Return e.KeyChar
        End If
    End Function

    Public Function OnlyInputNumber(e, btn)
        If (e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return)) Then
            Return btn.PerformClick()
        ElseIf (e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Back)) Then
            Return e.KeyChar
        ElseIf Not System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar, "^[0-9]*$") Then
            Return ""

        Else
            Return e.KeyChar
        End If



    End Function

End Class

Public Class BackEndUserInputCheck

    Public Function NoInputSymbol(txt)
        If Not System.Text.RegularExpressions.Regex.IsMatch(txt, "^[a-zA-Z0-9]*$") Then

            End

        Else

        End If
    End Function

    Public Function OnlyInputNumber(txt)
        If Not System.Text.RegularExpressions.Regex.IsMatch(txt, "^[0-9]*$") Then

            End
        Else

        End If



    End Function

End Class