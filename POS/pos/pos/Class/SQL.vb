﻿Imports System.Data.OleDb
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

    Public Function CheckBill(DateTimePicker1, DateTimePicker2)
        Dim SQL As New OleDbDataAdapter
        Dim con As New OleDbConnection
        Dim dt As New DataTable
        con = Connect()
        con.Open()
        SQL = New OleDbDataAdapter("SELECT * FROM tblReport where DateandTime between #" & DateTimePicker1.ToString("MM/dd/yyyy") & "# and #" & DateTimePicker2.ToString("MM/dd/yyyy") & "# order by DateandTime desc", con)
        SQL.Fill(dt)
        con.Close()
        Return dt


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

    Public Function ShowInitialCase(Label4)
        Try
            Dim con As New OleDbConnection
            con = Connect()
            con.Open()
            Dim cmd As OleDbCommand = New OleDbCommand("SELECT InitialCash FROM tblinitialCash WHERE DateandTime =#" & Today & "#", con)
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            If (dr.Read()) Then
                Label4.text = ["InitialCash"].ToString()
            End If
            con.Close()
        Catch ex As Exception
            MsgBox("Error:" & vbCrLf & ex.Message)
            End
        End Try
    End Function

    Public Function CheckInitialCash(txtCash)
        Try
            Dim con = Connect()
            Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM tblInitialCash WHERE InitialCash = '" & txtCash & "' ", con)
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

    Public Function AddBill(txtUser, txtBill, txtDate, txtAmount, txtRemark, txtPrice, txtChange)
        Dim SQL
        Dim con = Connect()

        Try

            SQL = "INSERT INTO tblReport ([UserName], [Bill], [DateandTime], [Amount], [Remark], [Price], [Change]) values(@txtUser,@txtBill,@txtDate,@txtAmount,@txtRemark,@txtPrice,@txtChange)"
            Dim SQLInsert As OleDbCommand = New OleDbCommand(SQL, con)
            Dim print = New Print
            SQLInsert.Parameters.AddWithValue("@txtUser", txtUser)
            SQLInsert.Parameters.AddWithValue("@txtBill", txtBill)
            SQLInsert.Parameters.AddWithValue("@txtDate", txtDate)
            SQLInsert.Parameters.AddWithValue("@txtAmount", txtAmount)
            SQLInsert.Parameters.AddWithValue("@txtRemark", txtRemark)
            SQLInsert.Parameters.AddWithValue("@txtPrice", txtPrice)
            SQLInsert.Parameters.AddWithValue("@txtChange", txtChange)
            con.Open()
            SQLInsert.ExecuteNonQuery()
            con.Close()
            MsgBox("Data Saved!")
            print.Print(txtBill, txtAmount, txtRemark, txtPrice, txtChange, txtUser, txtDate)
        Catch ex As Exception
            MsgBox(ex.Message)
            End
        End Try



    End Function

    Public Function AddInitialCash(txtCash)
        Dim SQL
        Dim con = Connect()

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
