Public Class SQLInjection
    Public Function PreventSQLInjection(username, password)
        Dim checkresult As String = PreventSQLInjection(username, password)
        If Not System.Text.RegularExpressions.Regex.IsMatch(password.Text, "^[a-zA-Z0-9]*$") Then
            MessageBox.Show("You may only enter letters and integer", "Error")
        End If
    End Function
End Class
