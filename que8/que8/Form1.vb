Public Class Form1

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim selected_items As String = ""
        Dim payment As String = ""

        If CheckBox1.Checked Then selected_items &= CheckBox1.Text & ", "
        If CheckBox2.Checked Then selected_items &= CheckBox2.Text

        If RadioButton1.Checked Then payment = RadioButton1.Text
        If RadioButton2.Checked Then payment = RadioButton2.Text

        Label4.Text = "Selected items: " & selected_items & vbCrLf & "Payment: " & payment

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
