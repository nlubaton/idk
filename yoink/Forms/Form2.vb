Imports MySql.Data.MySqlClient

Public Class Form2
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Dim q1s1 As String
    Dim q1s2 As String
    Dim q1s3 As String
    Dim q1s4 As String
    Dim q1s0 As String
    Dim q2 As String
    Dim q3 As String
    Dim studentEntry As String

    ' Update labels based on input '
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fullName.Text = returneeForm.fNameInput.Text + " " + returneeForm.lNameInput.Text
        matricID.Text = returneeForm.mIdInput.Text
        studCourse.Text = returneeForm.courseSelect.selectedValue
        phoneNumber.Text = returneeForm.phoneNumInput.Text
        studTemp.Text = returneeForm.bodyTempInput.Text

        If returneeForm.symptomCheck1.Checked = False Then
            symptom1.Text = "❌ Fever"
            q1s1 = "no"
        Else
            symptom1.Text = "✔️ Fever"
            q1s1 = "yes"
        End If
        If returneeForm.symptomCheck2.Checked = False Then
            symptom2.Text = "❌ Cough"
            q1s2 = "no"
        Else
            symptom2.Text = "✔️ Cough"
            q1s2 = "yes"
        End If
        If returneeForm.symptomCheck3.Checked = False Then
            symptom3.Text = "❌ Sore Throat"
            q1s3 = "no"
        Else
            symptom3.Text = "✔️ Sore Throat"
            q1s3 = "yes"
        End If
        If returneeForm.symptomCheck4.Checked = False Then
            symptom4.Text = "❌ Lost of sense"
            q1s4 = "no"
        Else
            symptom4.Text = "✔️ Lost of sense"
            q1s4 = "yes"
        End If
        If returneeForm.symptomCheck5.Checked = False Then
            symptom5.Text = "❌ None of the above"
            q1s0 = "no"
        Else
            symptom5.Text = "✔️ None of the above"
            q1s0 = "yes"
        End If

        If returneeForm.question2Switch.Value = False Then
            symptom7.Text = "No"
            q2 = "no"
        Else
            symptom7.Text = "Yes"
            q2 = "yes"
        End If
        If returneeForm.question3Switch.Value = False Then
            symptom8.Text = "No"
            q3 = "no"
        Else
            symptom8.Text = "Yes"
            q3 = "yes"
        End If

        ' Declare action '
        If returneeForm.symptomCheck1.Checked = True Or returneeForm.symptomCheck2.Checked = True Or returneeForm.symptomCheck3.Checked = True Or returneeForm.symptomCheck4.Checked = True Or CDbl(returneeForm.bodyTempInput.Text) > 37.7 Or returneeForm.question2Switch.Value = True Or returneeForm.question3Switch.Value = True Then
            actionTake.Text = "You are not allowed to return to campus!"
            studentEntry = "denied"
        Else
            actionTake.Text = "You are welcome to come to campus as soon as possible."
            studentEntry = "allowed"
        End If

    End Sub

    ' Return to initial form '
    Private Sub returnButton_Click(sender As Object, e As EventArgs) Handles returnButton.Click
        Me.Close()
        returneeForm.Show()
    End Sub

    Private Sub saveDatabase_Click(sender As Object, e As EventArgs) Handles saveDatabase.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;userid=root;password=alpine;database=vb_as3"
        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO vb_as3.student (student_id, student_firstname, student_lastname, student_phone, student_temp, student_course, student_symptom_fever, student_symptom_cough, student_symptom_sorethroat, student_symptom_nosense, student_symptom_none, student_poicontact, student_quarantine, student_entry) VALUE ('" & returneeForm.mIdInput.Text & "', '" & returneeForm.fNameInput.Text & "', '" & returneeForm.lNameInput.Text & "', '" & returneeForm.phoneNumInput.Text & "', '" & returneeForm.bodyTempInput.Text & "', '" & returneeForm.courseSelect.selectedValue & "', '" & q1s1 & "', '" & q1s2 & "', '" & q1s3 & "', '" & q1s4 & "', '" & q1s0 & "', '" & q2 & "', '" & q3 & "', '" & studentEntry & "')"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Data saved to database!")
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
End Class