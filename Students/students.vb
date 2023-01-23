'// Libraries to manage the database
Imports System.Data
Imports System.Data.OleDb

Public Class Students
    Private Sub Students_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Show_Students()
        Load_Faculty()
    End Sub

    Private Sub Show_Students()
        Try

            '// Saves the students table and columns
            Dim Package As New DataSet

            '// Does the SQL query with the students table
            Dim SqlQuery As String

            '// Connect the database with the SQL query
            Dim Adapter As New OleDbDataAdapter

            SqlQuery = "SELECT * FROM Alumnos"

            Adapter = New OleDbDataAdapter(SqlQuery, connection)

            '// Save the students data in the packet variable table
            Package.Tables.Add("Students")

            '// Fill the informations from Students table in the package
            Adapter.Fill(Package.Tables("Students"))

            '// Show the information
            GridStudents.DataSource = Package.Tables("Students")

            '// Count the datagrid registers
            LabelCounter.Text = GridStudents.Rows.Count

            '// Changes the columns default size
            GridStudents.Columns("Expediente").Width = 90
            GridStudents.Columns("Nombre").Width = 100
            GridStudents.Columns("Apellido").Width = 100
            GridStudents.Columns("Genero").Width = 80
            GridStudents.Columns("Facultad").Width = 120
            GridStudents.Columns("Correo").Width = 140

        Catch ex As Exception

            MsgBox("Error! " & ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub

    '// PROCESS TO SHOW A COLUMN IN A COMBOBOX

    Private Sub Load_Faculty()
        Try

            '// Save the column information of the table
            Dim Table As New DataTable

            '// Query to get the faculty column
            Dim SqlQuery As String = "SELECT Facultad FROM Alumnos"

            '// Connect the SQL query with the database connection
            Dim Adapter As New OleDbDataAdapter(SqlQuery, connection)

            '// Fill the information to the table variable
            Adapter.Fill(Table)

            '// Show the information in the combobox
            CBoxFaculty.DataSource = Table
            CBoxFaculty.DisplayMember = "Facultad"

        Catch ex As Exception

            MsgBox("Error! " & ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub

    Private Sub LabelTitle_Click(sender As Object, e As EventArgs) Handles LabelTitle.Click

    End Sub
End Class