Public Class Form1

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles file.Click

    End Sub

    Private Sub NewFromToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewFromToolStripMenuItem.Click
        Dim n As New Form2
        Me.IsMdiContainer = True
        n.MdiParent = Me
        n.Show()

    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click

        Dim openFileDialog As New OpenFileDialog()

        openFileDialog.Title = "Select a File"
        openFileDialog.Filter = "All Files|*.*|Text Files|*.txt"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim selectedFilePath As String = openFileDialog.FileName
            MessageBox.Show("Selected File: " & selectedFilePath)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
