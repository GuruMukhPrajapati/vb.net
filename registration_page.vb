Private Sub Button_Click()

Try 
    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\college.accdb")

    Dim cmd As New OleDbCommand("INSERT INTO login VALUES (?, ?, ?, ?, ?)", con)
    cmd.Parameters.AddWithValue("?", TextBox1.Text)
    cmd.Parameters.AddWithValue("?", TextBox2.Text)
    cmd.Parameters.AddWithValue("?", TextBox3.Text)
    cmd.Parameters.AddWithValue("?", TextBox4.SelectedValue)
    cmd.Parameters.AddWithValue("?", TextBox5.Text)

    cmd.Connection = con
    con.Open()
    cmd.ExecuteNonQuery()
    con.Close()

Catch ex As Exception
    Label6.Text = ex.Message
End Try

End Sub
