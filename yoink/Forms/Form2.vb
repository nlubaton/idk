Public Class Form2
    ' Update labels based on input '
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fullName.Text = returneeForm.fNameInput.Text + " " + returneeForm.lNameInput.Text
        matricID.Text = returneeForm.mIdInput.Text
        studCourse.Text = returneeForm.courseSelect.selectedValue
        phoneNumber.Text = returneeForm.phoneNumInput.Text
        studTemp.Text = returneeForm.bodyTempInput.Text

        If returneeForm.symptomCheck1.Checked = False Then
            symptom1.Text = "❌ Fever"
        Else
            symptom1.Text = "✔️ Fever"
        End If
        If returneeForm.symptomCheck2.Checked = False Then
            symptom2.Text = "❌ Cough"
        Else
            symptom2.Text = "✔️ Cough"
        End If
        If returneeForm.symptomCheck3.Checked = False Then
            symptom3.Text = "❌ Sore Throat"
        Else
            symptom3.Text = "✔️ Sore Throat"
        End If
        If returneeForm.symptomCheck4.Checked = False Then
            symptom4.Text = "❌ Lost of sense"
        Else
            symptom4.Text = "✔️ Lost of sense"
        End If
        If returneeForm.symptomCheck5.Checked = False Then
            symptom5.Text = "❌ None of the above"
        Else
            symptom5.Text = "✔️ None of the above"
        End If

        If returneeForm.question2Switch.Value = False Then
            symptom7.Text = "No"
        Else
            symptom7.Text = "Yes"
        End If
        If returneeForm.question3Switch.Value = False Then
            symptom8.Text = "No"
        Else
            symptom8.Text = "Yes"
        End If

        ' Declare action '
        If returneeForm.symptomCheck1.Checked = True Or returneeForm.symptomCheck2.Checked = True Or returneeForm.symptomCheck3.Checked = True Or returneeForm.symptomCheck4.Checked = True Or CDbl(returneeForm.bodyTempInput.Text) > 37.7 Then
            actionTake.Text = "You are advised to quarantine yourself before coming to campus."
        Else
            actionTake.Text = "You are welcome to come to campus as soon as possible."
        End If

    End Sub

    ' Return to initial form '
    Private Sub returnButton_Click(sender As Object, e As EventArgs) Handles returnButton.Click
        Me.Close()
        returneeForm.Show()
    End Sub
End Class