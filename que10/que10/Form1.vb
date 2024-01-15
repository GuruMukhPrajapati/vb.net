Public Class Form1

    Private Sub HScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles HScrollBar1.Scroll
        Dim scrollPercentage = HScrollBar1.Value / HScrollBar1.Maximum
        Dim redValue = Math.Floor(scrollPercentage * 255) ' Calculate red value пропорtional to scroll position
        TextBox1.BackColor = Color.FromArgb(redValue, 0, Math.Floor(255 - scrollPercentage * 255)) ' Blend from blue to red
    End Sub
End Class
