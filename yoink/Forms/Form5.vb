Imports MySql.Data.MySqlClient

Public Class Form5
    Dim MysqlConn As MySqlConnection
	Dim COMMAND As MySqlCommand
	'Close button'
	Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Close()
        Form4.Show()
    End Sub

	'Load table on form load'
	Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		MysqlConn = New MySqlConnection
		MysqlConn.ConnectionString =
		"server=localhost;userid=root;password=alpine;database=vb_as3"
		Dim SDA As New MySqlDataAdapter
		Dim dbDataSet As New DataTable
		Dim bSource As New BindingSource
		Try
			MysqlConn.Open()
			Dim Query As String
			Query = "SELECT student_id AS Matric, student_firstname AS First, student_lastname AS Last, student_phone AS Phone, student_temp AS Temperature, student_course AS Course, student_symptom_fever AS Fever, student_symptom_cough AS Cough, student_symptom_sorethroat AS Sore_Throat, student_symptom_nosense AS No_Sense, student_symptom_none AS None, student_poicontact AS POI, student_quarantine AS Quarantined, student_entry AS Entry
						FROM student"
			COMMAND = New MySqlCommand(Query, MysqlConn)
			SDA.SelectCommand = COMMAND
			SDA.Fill(dbDataSet)
			bSource.DataSource = dbDataSet
			DataGridView1.DataSource = bSource
			SDA.Update(dbDataSet)

		Catch ex As Exception
			MessageBox.Show(ex.Message)
		Finally
			MysqlConn.Dispose()
		End Try
	End Sub
	'Load table on button click'
	Private Sub loadTable_Click(sender As Object, e As EventArgs) Handles loadTable.Click
		MysqlConn = New MySqlConnection
		MysqlConn.ConnectionString =
		"server=localhost;userid=root;password=alpine;database=vb_as3"
		Dim SDA As New MySqlDataAdapter
		Dim dbDataSet As New DataTable
		Dim bSource As New BindingSource
		Try
			MysqlConn.Open()
			Dim Query As String
			Query = "SELECT student_id AS Matric, student_firstname AS First, student_lastname AS Last, student_phone AS Phone, student_temp AS Temperature, student_course AS Course, student_symptom_fever AS Fever, student_symptom_cough AS Cough, student_symptom_sorethroat AS Sore_Throat, student_symptom_nosense AS No_Sense, student_symptom_none AS None, student_poicontact AS POI, student_quarantine AS Quarantined, student_entry AS Entry
						FROM student"
			COMMAND = New MySqlCommand(Query, MysqlConn)
			SDA.SelectCommand = COMMAND
			SDA.Fill(dbDataSet)
			bSource.DataSource = dbDataSet
			DataGridView1.DataSource = bSource
			SDA.Update(dbDataSet)

		Catch ex As Exception
			MessageBox.Show(ex.Message)
		Finally
			MysqlConn.Dispose()
		End Try
	End Sub
	'Load textbox on data select'
	Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
		If e.RowIndex >= 0 Then
			Dim row As DataGridViewRow
			row = Me.DataGridView1.Rows(e.RowIndex)

			firstName.Text = row.Cells("First").Value.ToString
			lastName.Text = row.Cells("Last").Value.ToString
			phoneNum.Text = row.Cells("Phone").Value.ToString
			mId.Text = row.Cells("Matric").Value.ToString
			studCourse.Text = row.Cells("Course").Value.ToString
			campusEntry.selectedValue = row.Cells("Entry").Value.ToString
		End If
	End Sub


End Class