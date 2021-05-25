Imports MySql.Data.MySqlClient

Public Class Form4
	Dim MysqlConn As MySqlConnection
	Dim COMMAND As MySqlCommand
	Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
		Me.Close()
	End Sub

	Private Sub studentButton_Click(sender As Object, e As EventArgs) Handles studentButton.Click
		Me.Hide()
		returneeForm.Show()
	End Sub

	Private Sub staffButton_Click(sender As Object, e As EventArgs) Handles staffButton.Click
		MysqlConn = New MySqlConnection
		MysqlConn.ConnectionString =
		"server=localhost;userid=root;password=alpine;database=vb_as3"
		Dim READER As MySqlDataReader

		Try
			MysqlConn.Open()
			Dim Query As String
			Query = "SELECT * FROM vb_as3.staff WHERE staff_username = '" & usernameInput.Text & "' and staff_password = BINARY '" & passwordInput.Text & "' "
			COMMAND = New MySqlCommand(Query, MysqlConn)
			READER = COMMAND.ExecuteReader
			Dim count As Integer
			count = 0
			While READER.Read
				count = count + 1
			End While

			If count = 1 Then
				Me.Hide()
				Form5.Show()
			Else
				MessageBox.Show("Incorrect credentials")
			End If
			MysqlConn.Close()

		Catch ex As MySqlException
			MessageBox.Show(ex.Message)
		Finally
			MysqlConn.Dispose()
		End Try
	End Sub

	Private Sub usernameInput_Enter(sender As Object, e As EventArgs) Handles usernameInput.Enter
		usernameInput.Text = ""
	End Sub

	Private Sub usernameInput_Leave(sender As Object, e As EventArgs) Handles usernameInput.Leave
		If usernameInput.Text = "" Then usernameInput.Text = "Username"
	End Sub

	Private Sub passwordInput_Enter(sender As Object, e As EventArgs) Handles passwordInput.Enter
		passwordInput.Text = ""
	End Sub

	Private Sub passwordInput_Leave(sender As Object, e As EventArgs) Handles passwordInput.Leave
		If passwordInput.Text = "" Then passwordInput.Text = "Password"
	End Sub
End Class