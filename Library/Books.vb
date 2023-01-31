Imports System.Data
Imports System.Data.OleDb

Public Class Books
    Private Sub Books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Books()
    End Sub
    Public Commands As New OleDbCommand
    Private Sub Add_Books()
        Try
            Commands.Connection = connection
            Commands = New OleDbCommand("INSERT INTO Libros (Invoice, Nombre, Autor, Descripcion, Sucursal)" & Chr(13) &
            "VALUES (Invoice, Nombre, Autor, Descripcion, Sucursal)", connection)

            Commands.Parameters.AddWithValue("@Invoice", TxtInvoice.Text)
            Commands.Parameters.AddWithValue("@Name", TxtName.Text)
            Commands.Parameters.AddWithValue("@Author", TxtAuthor.Text)
            Commands.Parameters.AddWithValue("@Description", TxtDescription2.Text)
            Commands.Parameters.AddWithValue("@Sale_branch", CBoxBranch.Text)

            Commands.ExecuteNonQuery()
        Catch ex As Exception

            MsgBox("Error! " & ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub

    Private Sub Load_Books()
        Try

            Dim Package As New DataSet

            Dim SqlQuery As String

            Dim Adapter As New OleDbDataAdapter

            SqlQuery = "SELECT * FROM Libros"

            Adapter = New OleDbDataAdapter(SqlQuery, connection)

            Package.Tables.Add("Libros")

            Adapter.Fill(Package.Tables("Libros"))

            GridBooks.DataSource = Package.Tables("Libros")

            LabelCounter.Text = GridBooks.Rows.Count


        Catch ex As Exception

            MsgBox("Error! " & ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub

    Private Sub ButtonEnter_Click(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        If TxtInvoice.Text = Nothing Or
            TxtName.Text = Nothing Or
            TxtAuthor.Text = Nothing Or
            TxtDescription2.Text = Nothing Or
            CBoxBranch.Text = "Select a branch" Then

            MsgBox("There can be no blank fields", MsgBoxStyle.Critical, "Add Book")

        Else

            Dim Response As DialogResult = MessageBox.Show("A new register will be added, do you want to continue?", "Add Book", MessageBoxButtons.YesNo)

            If Response = DialogResult.Yes Then

                Add_Books()
                Load_Books()
                Clear_Values()

            ElseIf Response = DialogResult.No Then
            End If
        End If
    End Sub

    Private Sub Clear_Values()
        TxtInvoice.Clear()
        TxtName.Clear()
        TxtAuthor.Clear()
        TxtDescription2.Clear()
        CBoxBranch.Text = "Select a branch"
        GridBooks.ClearSelection()
    End Sub

    Private Sub ButtonRestart_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        Clear_Values()
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Try

            If GridBooks.SelectedRows.Count = 0 Then

                MsgBox("There is no selected row!", MsgBoxStyle.Critical, "Delete Book")

            End If

        Catch ex As Exception

            MsgBox("Error! " & ex.Message, MsgBoxStyle.Critical)

        End Try

        Dim Response As DialogResult = MessageBox.Show("The register will be deleted, do you want to continue?", "Delete Book", MessageBoxButtons.YesNo)

        If Response = DialogResult.Yes Then
            Dim Command As New OleDbCommand
            For Each row As DataGridViewRow In GridBooks.SelectedRows
                Dim Invoice As Double = row.Cells("Invoice").Value
                Command.Connection = connection
                Command.CommandText = "DELETE FROM Libros WHERE Invoice =" & Invoice
                Command.ExecuteNonQuery()
            Next
            Load_Books()
        ElseIf Response = DialogResult.No Then
        End If
    End Sub

    Private Sub Update_Books()
        Try
            Dim Command As New OleDbCommand
            Dim Invoice As Double
            Invoice = TxtInvoice.Text
            Command.Connection = connection
            Command.CommandText = "UPDATE Libros SET Nombre = '" & TxtName.Text &
                "', Autor = '" & TxtAuthor.Text &
                "', Descripcion = '" & TxtDescription2.Text &
                "', Sucursal = '" & CBoxBranch.Text &
                "' WHERE Invoice = " & Invoice

            Command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error! " & ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        If TxtInvoice.Text = Nothing Or
            TxtName.Text = Nothing Or
            TxtAuthor.Text = Nothing Or
            TxtDescription2.Text = Nothing Or
            CBoxBranch.Text = "Select a branch" Then

            MsgBox("There can be no blank fields", MsgBoxStyle.Critical, "Update Book")

        Else
            Dim Response As DialogResult = MessageBox.Show("The register will be updated, do you want to continue?", "Update Book", MessageBoxButtons.YesNo)

            If Response = DialogResult.Yes Then
                Update_Books()
                Load_Books()
                Clear_Values()

            ElseIf Response = DialogResult.No Then
            End If
        End If
    End Sub

    Private Sub Validate_Invoice()
        Try
            Dim Adapter As New OleDbDataAdapter
            Dim Packet As New DataSet
            Dim SQLQuery As String
            Dim Register As Long

            SQLQuery = "SELECT * FROM Libros WHERE Invoice = " & TxtInvoice.Text
            Adapter = New OleDbDataAdapter(SQLQuery, connection)

            Adapter.Fill(Packet, "Libros")
            Register = Packet.Tables("Libros").Rows.Count
            If Register <> 0 Then

                MsgBox("The invoice is already in our registers, please try again.", MsgBoxStyle.Critical, "Book Inovice")
                TxtInvoice.Focus()

            End If

        Catch ex As Exception

            MsgBox("Error! " & ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub

    Private Sub TxtInvoice_Leave(sender As Object, e As EventArgs) Handles TxtInvoice.Leave
        Validate_Invoice()
    End Sub

    Private Sub Double_click_row()
        Try
            For Each row As DataGridViewRow In GridBooks.SelectedRows
                Dim Invoice As Double = row.Cells("Invoice").Value
                Dim Name As String = row.Cells("Nombre").Value
                Dim Author As String = row.Cells("Autor").Value
                Dim Description As String = row.Cells("Descripcion").Value
                Dim Branch As String = row.Cells("Sucursal").Value

                TxtInvoice.Text = Invoice
                TxtName.Text = Name
                TxtAuthor.Text = Author
                TxtDescription2.Text = Description
                CBoxBranch.Text = Branch
            Next

        Catch ex As Exception

            MsgBox("Error! " & ex.Message, MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub GridBooks_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridBooks.CellDoubleClick
        Double_click_row()
        ButtonEnter.Visible = True
    End Sub

    Private Sub CBoxBranch_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CBoxBranch.KeyPress
        e.KeyChar = ""
    End Sub
End Class