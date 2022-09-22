Public Class Subjects
    Private Sub Subjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Clear_Values()
    End Sub

    Private Sub ButtonEnter_Click(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        Try
            If TxtID.Text = Nothing Or
                TxtName.Text = Nothing Or
                TxtDescription.Text = Nothing Or
                CBoxSemester.Text = "Select Semester" Or
                CBoxFaculty.Text = "Select Faculty" Then

                MsgBox("There are empty fields!", MsgBoxStyle.Critical, "Subjects")

            Else
                GridSubjects.Rows.Add(TxtID.Text, TxtName.Text, CBoxSemester.Text, TxtDescription.Text, CBoxFaculty.Text)
                Clear_Values()
            End If

        Catch ex As Exception

            MsgBox("Error! " & ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub

    Private Sub CBoxSemester_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CBoxSemester.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub CBoxFaculty_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CBoxFaculty.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub Clear_Values()
        TxtID.Clear()
        TxtName.Clear()
        TxtDescription.Clear()
        CBoxSemester.Text = "Select Semester"
        CBoxFaculty.Text = "Select Faculty"
        GridSubjects.ClearSelection()
        TxtTotal.Text = GridSubjects.Rows.Count
    End Sub

    Private Sub ButtonClear_Click(sender As Object, e As EventArgs) Handles ButtonClear.Click
        Clear_Values()
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Try

            If GridSubjects.SelectedRows.Count = 0 Then

                MsgBox("There is no selected row!", MsgBoxStyle.Critical, "Subjects")

            Else
                GridSubjects.Rows.Remove(GridSubjects.CurrentRow)
            End If

        Catch ex As Exception

            MsgBox("Error! " & ex.Message, MsgBoxStyle.Critical)

        End Try
    End Sub
End Class