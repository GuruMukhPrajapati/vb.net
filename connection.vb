Imports System.Data.OleDb

Protected Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs)
    Try
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\college.accdb")
        
        Dim cmd As New OleDbCommand("INSERT INTO freg VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)", con)
        cmd.Parameters.AddWithValue("?", fid.Text)
        cmd.Parameters.AddWithValue("?", fname.Text)
        cmd.Parameters.AddWithValue("?", qua.Text)
        cmd.Parameters.AddWithValue("?", gen.SelectedValue)
        cmd.Parameters.AddWithValue("?", dob.Text)
        cmd.Parameters.AddWithValue("?", add.Text)
        cmd.Parameters.AddWithValue("?", city.Text)
        cmd.Parameters.AddWithValue("?", state.Text)
        cmd.Parameters.AddWithValue("?", pin.Text)
        cmd.Parameters.AddWithValue("?", mob.Text)
        cmd.Parameters.AddWithValue("?", mail.Text)

        cmd.Connection = con
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    Catch ex As Exception
        lbl.Text = ex.Message
    End Try
End Sub
