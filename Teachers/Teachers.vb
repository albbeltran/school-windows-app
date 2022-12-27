'// Libraries to manage the database
Imports System.Data
Imports System.Data.OleDb

Public Class Teachers
    Private Sub Teachers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Show_Teachers()
        Show_Teacher()
    End Sub

    Private Sub Show_Teachers()
        Try

            '// Saves the students table and columns
            Dim Package As New DataSet

            '// Does the SQL query with the students table
            Dim SqlQuery As String

            '// Connect the database with the SQL query
            Dim Adapter As New OleDbDataAdapter

            SqlQuery = "SELECT * FROM Docentes"

            Adapter = New OleDbDataAdapter(SqlQuery, connection)

            '// Save the students data in the packet variable table
            Package.Tables.Add("Teachers")

            '// Fill the informations from Students table in the package
            Adapter.Fill(Package.Tables("Teachers"))

            '// Show the information
            GridStudents.DataSource = Package.Tables("Teachers")

            '// Count the datagrid registers
            LabelCounter.Text = GridStudents.Rows.Count

            '// Changes the columns default size
            GridStudents.Columns("Folio").Width = 90
            GridStudents.Columns("Nombre").Width = 100
            GridStudents.Columns("Correo").Width = 140
            GridStudents.Columns("Ciudad").Width = 120
            GridStudents.Columns("Facultad").Width = 120
            GridStudents.Columns("Materia").Width = 120
            GridStudents.Columns("Tipo").Width = 100

        Catch ex As Exception

            MsgBox("Error! " & ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub

    Private Sub Show_Teacher()
        Try

            '// Save the column information of the table
            Dim Table As New DataTable

            '// Query to get the faculty column
            Dim SqlQuery As String = "SELECT Nombre FROM Docentes"

            '// Connect the SQL query with the database connection
            Dim Adapter As New OleDbDataAdapter(SqlQuery, connection)

            '// Fill the information to the table variable
            Adapter.Fill(Table)

            '// Show the information in the combobox
            CBoxTeacher.DataSource = Table
            CBoxTeacher.DisplayMember = "Nombre"

        Catch ex As Exception

            MsgBox("Error! " & ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub

    Private Sub CBoxTeacher_IndexChanged(sender As Object, e As EventArgs) Handles CBoxTeacher.SelectedIndexChanged

        Load_Teacher_Data()

    End Sub

    Private Sub Load_Teacher_Data()
        Try

            Dim SQLQuery As String
            Dim Adapter As OleDbDataAdapter
            Dim Register As DataSet
            Dim List As Long

            SQLQuery = "SELECT Folio, Nombre, Correo, Ciudad, Facultad, Materia, Tipo FROM Docentes WHERE Nombre = '" & CBoxTeacher.Text & "'"
            Adapter = New OleDbDataAdapter(SQLQuery, connection)
            Register = New DataSet

            Adapter.Fill(Register, "Docentes")
            List = Register.Tables("Docentes").Rows.Count

            If List <> 0 Then

                LabelId.Text = Register.Tables("Docentes").Rows(0).Item("Folio")
                LabelName.Text = Register.Tables("Docentes").Rows(0).Item("Nombre")
                LabelEmail.Text = Register.Tables("Docentes").Rows(0).Item("Correo")
                LabelCity.Text = Register.Tables("Docentes").Rows(0).Item("Ciudad")
                LabelFaculty.Text = Register.Tables("Docentes").Rows(0).Item("Facultad")
                LabelSubject.Text = Register.Tables("Docentes").Rows(0).Item("Materia")
                LabelType.Text = Register.Tables("Docentes").Rows(0).Item("Tipo")

            Else

            End If


        Catch ex As Exception

            MsgBox("Error! " & ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub
End Class