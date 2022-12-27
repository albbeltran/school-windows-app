'// Libraries to manage the database
Imports System.Data
Imports System.Data.OleDb

Public Class Products
    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Show_Products()
    End Sub

    Private Sub Show_Products()
        Try

            '// Saves the students table and columns
            Dim Package As New DataSet

            '// Does the SQL query with the students table
            Dim SqlQuery As String

            '// Connect the database with the SQL query
            Dim Adapter As New OleDbDataAdapter

            SqlQuery = "SELECT * FROM Productos"

            Adapter = New OleDbDataAdapter(SqlQuery, connection)

            '// Save the students data in the packet variable table
            Package.Tables.Add("Products")

            '// Fill the informations from Students table in the package
            Adapter.Fill(Package.Tables("Products"))

            '// Show the information
            GridProducts.DataSource = Package.Tables("Products")

            '// Count the datagrid registers
            LabelCounter.Text = GridProducts.Rows.Count

            '// Changes the columns default size
            GridProducts.Columns("ID").Width = 90
            GridProducts.Columns("No_Invoice").Width = 100
            GridProducts.Columns("Product_Name").Width = 100
            GridProducts.Columns("Laboratory").Width = 80
            GridProducts.Columns("Cost_Price").Width = 120
            GridProducts.Columns("Final_Price").Width = 140

            GridProducts.Columns("Cost_Price").DefaultCellStyle.Format = "C2"
            GridProducts.Columns("Final_Price").DefaultCellStyle.Format = "C2"

        Catch ex As Exception

            MsgBox("Error! " & ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub

    Private Sub Load_Laboratory()
        Try

            '// Save the column information of the table
            Dim Table As New DataTable

            '// Query to get the faculty column
            Dim SqlQuery As String = "SELECT Laboratory FROM Productos"

            '// Connect the SQL query with the database connection
            Dim Adapter As New OleDbDataAdapter(SqlQuery, connection)

            '// Fill the information to the table variable
            Adapter.Fill(Table)

            '// Show the information in the combobox
            CBoxLaboratory.DataSource = Table
            CBoxLaboratory.DisplayMember = "Laboratory"

        Catch ex As Exception

            MsgBox("Error! " & ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub
End Class