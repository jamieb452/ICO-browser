Public Class Form1

    Private Sub TextBox1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles searchbox.KeyUp
        If e.KeyCode = Keys.Enter Then
            icobrowser.Navigate(searchbox.Text)
        End If
    End Sub


    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        icobrowser.GoBack()
    End Sub

    Private Sub forward_Click(sender As Object, e As EventArgs) Handles forward.Click
        icobrowser.GoHome()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        icobrowser.Navigate("google.com")
    End Sub

    Private Sub searchbox_Click(sender As Object, e As EventArgs) Handles searchbox.Click

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
End Class
