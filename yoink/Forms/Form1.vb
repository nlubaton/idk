Public Class returneeForm
    ' Close button '
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Close()
    End Sub

    ' First name input '
    Private Sub fNameInput_Leave(sender As Object, e As EventArgs) Handles fNameInput.Leave
        If fNameInput.Text = "" Then fNameInput.Text = "First"
    End Sub
    Private Sub fNameInput_Enter(sender As Object, e As EventArgs) Handles fNameInput.Enter
        fNameInput.Text = ""
    End Sub

    ' Last name input '
    Private Sub lNameInput_Enter(sender As Object, e As EventArgs) Handles lNameInput.Enter
        lNameInput.Text = ""
    End Sub
    Private Sub lNameInput_Leave(sender As Object, e As EventArgs) Handles lNameInput.Leave
        If lNameInput.Text = "" Then lNameInput.Text = "Last"
    End Sub

    ' Clear button '
    Private Sub clearButton_Click(sender As Object, e As EventArgs) Handles clearButton.Click
        fNameInput.Text = "First"
        lNameInput.Text = "Last"
        mIdInput.Text = ""
        phoneNumInput.Text = ""
        bodyTempInput.Text = ""
        courseSelect.selectedIndex = 0
        symptomCheck1.Checked = False
        symptomCheck2.Checked = False
        symptomCheck3.Checked = False
        symptomCheck4.Checked = False
        symptomCheck5.Checked = False
        question2Switch.Value = False
        question3Switch.Value = False

    End Sub

    ' Send button '
    Private Sub sendButton_Click(sender As Object, e As EventArgs) Handles sendButton.Click
        If fNameInput.Text = "" Or lNameInput.Text = "" Or mIdInput.Text = "" Or phoneNumInput.Text = "" Or bodyTempInput.Text = "" Or courseSelect.selectedIndex = 0 Then
            Form3.ShowDialog()
        Else
            If symptomCheck1.Checked = False And symptomCheck2.Checked = False And symptomCheck3.Checked = False And symptomCheck4.Checked = False And symptomCheck5.Checked = False Then
                symptomCheck5.Checked = True
            End If

            Me.Hide()
            Form2.Show()
        End If
    End Sub

    ' Symptoms functions '
    Private Sub symptomCheck5_OnChange(sender As Object, e As EventArgs) Handles symptomCheck5.OnChange
        symptomCheck1.Checked = False
        symptomCheck2.Checked = False
        symptomCheck3.Checked = False
        symptomCheck4.Checked = False
    End Sub
    Private Sub symptomCheck1_OnChange(sender As Object, e As EventArgs) Handles symptomCheck1.OnChange
        symptomCheck5.Checked = False
    End Sub
    Private Sub symptomCheck2_OnChange(sender As Object, e As EventArgs) Handles symptomCheck2.OnChange
        symptomCheck5.Checked = False
    End Sub
    Private Sub symptomCheck3_OnChange(sender As Object, e As EventArgs) Handles symptomCheck3.OnChange
        symptomCheck5.Checked = False
    End Sub
    Private Sub symptomCheck4_OnChange(sender As Object, e As EventArgs) Handles symptomCheck4.OnChange
        symptomCheck5.Checked = False
    End Sub

End Class
