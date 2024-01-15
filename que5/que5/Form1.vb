Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("Apple")
        ListBox1.Items.Add("Banana")
        ListBox1.Items.Add("Cherry")
        ListBox1.Items.Add("Grapes")
        ListBox1.Items.Add("Orange")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        UpdateListBox()
    End Sub
    Private Sub UpdateListBox()
        Dim searchText As String = TextBox1.Text.ToLower()

        ListBox1.Items.Clear()

        For Each item As String In SampleItems
            If item.ToLower().Contains(searchText) Then
                ListBox1.Items.Add(item)
            End If
        Next
    End Sub
    Private ReadOnly SampleItems As String() = {"Apple", "Banana", "Cherry", "Grapes", "Orange"}
End Class
