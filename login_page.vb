Imports System.Data
Imports System.Data.OleDb

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\college.accdb;"
        Dim queryString As String = "SELECT uname, pass, sta, usname FROM login WHERE uname='" & uname.Text & "'"
        Dim objConn As New OleDbConnection(conString)
        Dim objCmd As New OleDbCommand(queryString, objConn)
        Dim myReader As OleDbDataReader

        Try
            Dim gotUser As Boolean = False
            objConn.Open()
            myReader = objCmd.ExecuteReader()

            While myReader.Read()
                If myReader("uname").ToString() = uname.Text AndAlso myReader("pass").ToString() = pass.Text Then
                    gotUser = True
                End If
            End While

            myReader.Close()

            If Not gotUser Then
                lbl.Text = "Invalid username and password. Please try again!"
                Form2.Show()
                Me.Close()
            End If
        Catch ex As Exception
            lbl.Text = ex.ToString()
        Finally
            objConn.Close()
        End Try
    End Sub

End Class
