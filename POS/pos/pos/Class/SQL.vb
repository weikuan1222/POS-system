Imports System.Data.OleDb
Imports pos.Print
Imports pos.UserInputCheck

Public Class Connect
    Public BackEndUserInputCheck As New BackEndUserInputCheck
    Public Function Connect()

        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database/PosDB.accdb")
        Return con

    End Function
End Class

Public Class CheckSQL
    Inherits Connect

    Public Function CheckUser(username, password)

        Try
            BackEndUserInputCheck.NoInputSymbol(username)
            BackEndUserInputCheck.NoInputSymbol(password)

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

    Public Function CheckBill(DateTimePicker1, DateTimePicker2, user)
        BackEndUserInputCheck.NoInputSymbol(user)
        Dim SQL As New OleDbDataAdapter
        Dim con As New OleDbConnection
        Dim dt As New DataTable
        Dim adminornot As Integer
        con = Connect()
        con.Open()
        Dim sqlcheckisadmin As OleDbCommand = New OleDbCommand("SELECT IsAdmin FROM tblUser WHERE UserName = '" & user & "' ", con)
        Dim isAdmin As OleDbDataReader = sqlcheckisadmin.ExecuteReader()
        While (isAdmin.Read())
            adminornot = isAdmin.GetValue(0)
        End While

        If (adminornot = 0) Then
            SQL = New OleDbDataAdapter("SELECT * FROM tblReport where UserName = '" & user & "' And DateandTime between #" & DateTimePicker1.Value.Date & "# and #" & DateTimePicker2.Value.Date & "# order by DateandTime desc", con)
            SQL.Fill(dt)
            con.Close()
        ElseIf (adminornot = 1) Then
            SQL = New OleDbDataAdapter("SELECT * FROM tblReport where DateandTime between #" & DateTimePicker1.Value.Date & "# and #" & DateTimePicker2.Value.Date & "# order by DateandTime desc", con)
            SQL.Fill(dt)
            con.Close()

        End If



        Return dt


    End Function

    Public Function ShowInitialCash()
        Dim SQL As New OleDbDataAdapter
        Dim con As New OleDbConnection
        Dim da As New DataTable
        con = Connect()
        con.Open()
        SQL = New OleDbDataAdapter("SELECT InitialCash FROM tblInitialCash WHERE  DateandTime =#" & Today & "#", con)
        SQL.Fill(da)
        con.Close()
        Return da

    End Function

    Public Function CloseCounter()
        Dim SQL As New OleDbDataAdapter
        Dim con As New OleDbConnection
        Dim dt As New DataTable
        con = Connect()
        con.Open()
        SQL = New OleDbDataAdapter("SELECT * FROM tblReport WHERE DateandTime =#" & Today & "#", con)
        SQL.Fill(dt)
        con.Close()
        Return dt
    End Function

    Public Function CheckInitialCash()
        Try
            Dim con = Connect()
            Dim cmd As OleDbCommand = New OleDbCommand("SELECT ID FROM tblInitialCash WHERE DateandTime = Date()", con)
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


End Class

Public Class AddSQL
    Inherits Connect

    Public Function AddBill(txtUser, txtBill, txtAmount, txtRemark, txtPrice, txtChange)
        BackEndUserInputCheck.NoInputSymbol(txtUser)
        BackEndUserInputCheck.OnlyInputNumber(txtBill)
        BackEndUserInputCheck.OnlyInputNumber(txtAmount)
        BackEndUserInputCheck.NoInputSymbol(txtRemark)
        BackEndUserInputCheck.OnlyInputNumber(txtPrice)
        BackEndUserInputCheck.OnlyInputNumber(txtChange)

        Dim SQL
        Dim con = Connect()


        Try

                SQL = "INSERT INTO tblReport ([UserName], [Bill], [Amount], [Remark], [Price], [Change]) values(@txtUser,@txtBill,@txtAmount,@txtRemark,@txtPrice,@txtChange)"
                Dim SQLInsert As OleDbCommand = New OleDbCommand(SQL, con)
                Dim print = New Print
                SQLInsert.Parameters.AddWithValue("@txtUser", txtUser)
                SQLInsert.Parameters.AddWithValue("@txtBill", txtBill)
                SQLInsert.Parameters.AddWithValue("@txtAmount", txtAmount)
                SQLInsert.Parameters.AddWithValue("@txtRemark", txtRemark)
                SQLInsert.Parameters.AddWithValue("@txtPrice", txtPrice)
                SQLInsert.Parameters.AddWithValue("@txtChange", txtChange)
                con.Open()
                SQLInsert.ExecuteNonQuery()
                con.Close()
                MsgBox("Data Saved!")

                'print.Print(txtBill, txtAmount, txtRemark, txtPrice, txtChange, txtUser, txtDate)
            Catch ex As Exception
                MsgBox(ex.Message)
                End
            End Try








    End Function

    Public Function AddInitialCash(txtCash)
        BackEndUserInputCheck.OnlyInputNumber(txtCash)
        Dim SQL
        Dim con = Connect()
        If (txtCash = "") Then
            txtCash = 0
        End If


        Try
            SQL = "INSERT INTO tblInitialCash ([InitialCash]) values(@txtCash)"
            Dim SQLInsert As OleDbCommand = New OleDbCommand(SQL, con)
            SQLInsert.Parameters.AddWithValue("@txtCash", txtCash)
            con.Open()
            SQLInsert.ExecuteNonQuery()
            con.Close()
            MsgBox("Insert Successfully!")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function

End Class

Public Class ChangeSQL
    Inherits Connect


End Class