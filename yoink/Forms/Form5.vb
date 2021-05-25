Imports MySql.Data.MySqlClient

Public Class Form5
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Close()
        Form4.Show()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString =
        "server=localhost;userid=root;password=alpine;database=vb_as3"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Dim READER As MySqlDataReader
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
End Class