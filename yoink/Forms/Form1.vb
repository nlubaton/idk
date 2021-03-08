Public Class Form1
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Close()
    End Sub
    Private Sub fNameInput_Leave(sender As Object, e As EventArgs) Handles fNameInput.Leave
        If fNameInput.Text = "" Then fNameInput.Text = "First"
    End Sub
    Private Sub fNameInput_Enter(sender As Object, e As EventArgs) Handles fNameInput.Enter
        fNameInput.Text = ""
    End Sub
    Private Sub lNameInput_Enter(sender As Object, e As EventArgs) Handles lNameInput.Enter
        lNameInput.Text = ""
    End Sub
    Private Sub lNameInput_Leave(sender As Object, e As EventArgs) Handles lNameInput.Leave
        If lNameInput.Text = "" Then lNameInput.Text = "Last"
    End Sub
    Private Sub mIdInput_Enter(sender As Object, e As EventArgs) Handles mIdInput.Enter
        mIdInput.Text = ""
    End Sub

    Private Sub phoneNumInput_Enter(sender As Object, e As EventArgs) Handles phoneNumInput.Enter
        phoneNumInput.Text = ""
    End Sub


End Class
