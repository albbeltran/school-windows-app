Imports System.Data
Imports System.Data.OleDb

Public Class Songs
    Private Sub Songs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Load_Albums()
    End Sub
    Public Commands As New OleDbCommand
    Private Sub Add_Album()
        Try
            Commands.Connection = connection
            Commands = New OleDbCommand("INSERT INTO Musica (ID, Album, Artista, Numero_Canciones, Genero, Año)" & Chr(13) &
            "VALUES (ID, Album, Artista, Numero_Canciones, Genero, Año)", connection)

            Commands.Parameters.AddWithValue("@ID", TxtID.Text)
            Commands.Parameters.AddWithValue("@Album", TxtAlbum.Text)
            Commands.Parameters.AddWithValue("@Artist", TxtArtist.Text)
            Commands.Parameters.AddWithValue("@Songs", TxtSongs.Text)
            Commands.Parameters.AddWithValue("@Genrer", CBoxGenrer.Text)
            Commands.Parameters.AddWithValue("@Year", TxtYear.Text)

            Commands.ExecuteNonQuery()
        Catch ex As Exception

            MsgBox("Error! " & ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub

    Private Sub Load_Albums()
        Try

            Dim Package As New DataSet

            Dim SqlQuery As String

            Dim Adapter As New OleDbDataAdapter

            SqlQuery = "SELECT * FROM Musica"

            Adapter = New OleDbDataAdapter(SqlQuery, connection)

            Package.Tables.Add("Musica")

            Adapter.Fill(Package.Tables("Musica"))

            GridMusic.DataSource = Package.Tables("Musica")

            LabelCounter.Text = GridMusic.Rows.Count

            GridMusic.Columns("ID").Width = 100
            GridMusic.Columns("Album").Width = 100
            GridMusic.Columns("Artista").Width = 120
            GridMusic.Columns("Numero_Canciones").Width = 80
            GridMusic.Columns("Genero").Width = 100
            GridMusic.Columns("Año").Width = 80


        Catch ex As Exception

            MsgBox("Error! " & ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub

    Private Sub ButtonEnter_Click(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        If TxtID.Text = Nothing Or
            TxtAlbum.Text = Nothing Or
            TxtArtist.Text = Nothing Or
            TxtSongs.Text = Nothing Or
            CBoxGenrer.Text = "Select a genrer" Or
            TxtYear.Text = Nothing Then

            MsgBox("There can be no blank fields", MsgBoxStyle.Critical, "Music")

        Else

            Dim Response As DialogResult = MessageBox.Show("A new register will be added, do you want to continue?", "Music", MessageBoxButtons.YesNo)

            If Response = DialogResult.Yes Then

                Add_Album()
                Load_Albums()
                Clear_Values()

            ElseIf Response = DialogResult.No Then
            End If
        End If
    End Sub

    Private Sub Clear_Values()
        TxtID.Clear()
        TxtAlbum.Clear()
        TxtArtist.Clear()
        TxtSongs.Clear()
        CBoxGenrer.Text = "Select a genrer"
        TxtYear.Clear()
        GridMusic.ClearSelection()
    End Sub

    Private Sub ButtonRestart_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        Clear_Values()
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Try

            If GridMusic.SelectedRows.Count = 0 Then

                MsgBox("There is no selected row!", MsgBoxStyle.Critical, "Music")

            End If

        Catch ex As Exception

            MsgBox("Error! " & ex.Message, MsgBoxStyle.Critical)

        End Try

        Dim Response As DialogResult = MessageBox.Show("The register will be deleted, do you want to continue?", "Music", MessageBoxButtons.YesNo)

        If Response = DialogResult.Yes Then
            Dim command As New OleDbCommand
            For Each row As DataGridViewRow In GridMusic.SelectedRows
                Dim ID As Double = row.Cells("ID").Value
                command.Connection = connection
                command.CommandText = "DELETE FROM Musica WHERE ID =" & ID
                command.ExecuteNonQuery()
            Next
            Load_Albums()
        ElseIf Response = DialogResult.No Then
        End If
    End Sub

    Private Sub Update_Album()
        Try
            Dim Command As New OleDbCommand
            Dim ID As Double
            ID = TxtID.Text
            Command.Connection = connection
            Command.CommandText = "UPDATE Musica SET Album='" & TxtAlbum.Text &
                "', Artista='" & TxtArtist.Text &
                "', Numero_Canciones='" & TxtSongs.Text &
                "', Genero='" & CBoxGenrer.Text &
                "', Año='" & TxtYear.Text &
                "' WHERE ID" & ID
            Command.ExecuteNonQuery()

        Catch ex As Exception

            MsgBox("Error! " & ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        Update_Album()
    End Sub

    Private Sub Validate_ID()
        Try
            Dim Adapter As New OleDbDataAdapter
            Dim Packet As New DataSet
            Dim SQLQuery As String
            Dim Register As Long

            SQLQuery = "SELECT * FROM Musica WHERE ID = " & TxtID.Text
            Adapter = New OleDbDataAdapter(SQLQuery, connection)

            Adapter.Fill(Packet, "Musica")
            Register = Packet.Tables("Musica").Rows.Count
            If Register <> 0 Then

                MsgBox("The invoice is already in our registers, please try again.", MsgBoxStyle.Critical, "Musica")
                TxtID.Focus()

            End If

        Catch ex As Exception

            MsgBox("Error! " & ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub
    Private Sub TxtID_Leave(sender As Object, e As EventArgs) Handles TxtID.Leave
        Validate_ID()
    End Sub

    Private Sub Cell_Double_Click()
        Try
            For Each row As DataGridViewRow In GridMusic.SelectedRows
                Dim ID As Double = row.Cells("ID").Value
                Dim Album As String = row.Cells("Album").Value
                Dim Artist As String = row.Cells("Artist").Value
                Dim Songs As String = row.Cells("Songs").Value
                Dim Genrer As String = row.Cells("Genrer").Value
                Dim Year As String = row.Cells("Year").Value

                TxtID.Text = ID
                TxtAlbum.Text = Album
                TxtArtist.Text = Artist
                TxtSongs.Text = Songs
                CBoxGenrer.Text = Genrer
                TxtYear.Text = Year
            Next

        Catch ex As Exception

            MsgBox("Error! " & ex.Message, MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub GridMusic_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridMusic.CellDoubleClick
        Cell_Double_Click()
        ButtonEnter.Visible = True
    End Sub

    Private Sub CBoxGenrer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CBoxGenrer.KeyPress
        e.KeyChar = ""
    End Sub
End Class