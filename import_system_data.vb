Import System.Data
Import System.Data.OleDb

Public class FROM1 

    Private Sub Button1_Click()

        Try
            Dim connstring As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & "Data Source=E:\ace.accdb;"
            Dim qrystring As String = "SELECT * FROM login WHERE rna = '" & TextBox1.Text & "';"
            Dim objconn As New OleDbConnection(connstring)
            Dim objcmd As New OleDbCommand(qrystring, objconn)
            Dim myreader As OleDbDataReader

            objconn.Open()

            Dim gotuser As Boolean = False

            myreader = objcmd.ExecuteReader()

            While myreader.Read()
                If myreader.GetString(0).ToString() = TextBox1.Text And myreader.GetString(2).ToString() = TextBox2.Text Then
                    gotuser = True
                    Form2.Label2.Text = myreader.GetString(1).ToString()
                End If
            End While

            If Not gotuser Then
                Label3.Text = "Invalid username & password, please try again"
            Else
                Form2.Show()
                Me.Hide()
            End If

            myreader.Close()
            objconn.Close()

        Catch ex As Exception
            Label3.Text = ex.ToString()
        End Try

    End Sub

End Class

