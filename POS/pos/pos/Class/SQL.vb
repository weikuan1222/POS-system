Imports System.Data.OleDb
Imports pos.Print
Public Class Connect
    Public Function Connect()

        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database/PosDB.accdb")
        Return con

    End Function
End Class

Public Class CheckSQL
    Inherits Connect

    Public Function CheckUser(username, password)

        Try
            Dim con = Connect()
            Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM tblUser WHERE UserName = '" & username & "' AND [Password] = '" & password & "' ", con)
            con.Open()
            If (cmd.ExecuteReader().Read() = True) Then

                Return ("Sucessful")
            Else
                Return ("Not Sucessful")
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message)
            End
        End Try

    End Function

    Public Function CheckBill()

        Dim SQL As New OleDbDataAdapter
        Dim con As New OleDbConnection
        Dim dt As New DataTable
        con = Connect()
        con.Open()
        SQL = New OleDbDataAdapter("SELECT * FROM tblReport", con)
        SQL.Fill(dt)
        con.Close()
        Return dt


    End Function


End Class

Public Class AddSQL
    Inherits Connect

    Public Function AddBill(txtUser, txtBill, txtDate, txtAmount, txtRemark)
        Dim SQL
        Dim con = Connect()

        Try

            SQL = "INSERT INTO tblReport ([UserName], [Bill], [Date and Time], [Amount], [Remark]) values(@txtUser,@txtBill,@txtDate,@txtAmount,@txtRemark)"
            Dim SQLInsert As OleDbCommand = New OleDbCommand(SQL, con)
            Dim print = New Print
            SQLInsert.Parameters.AddWithValue("@txtUser", txtUser)
            SQLInsert.Parameters.AddWithValue("@txtBill", txtBill)
            SQLInsert.Parameters.AddWithValue("@txtDate", txtDate)
            SQLInsert.Parameters.AddWithValue("@txtAmount", txtAmount)
            SQLInsert.Parameters.AddWithValue("@txtRemark", txtRemark)
            con.Open()
            SQLInsert.ExecuteNonQuery()
            con.Close()
            MsgBox("Data Saved!")
            print.Print(txtBill, txtAmount, txtRemark, txtUser, txtDate)
        Catch ex As Exception
                MsgBox(ex.Message)
            End
        End Try



    End Function

End Class

Public Class ChangeSQL
    Inherits Connect


End Class