'-------LIBRARIES OR DLL---------'
Imports System.Runtime.InteropServices

Public Class sign_in
    Private Sub LabelTitle_Click(sender As Object, e As EventArgs) Handles LabelTitle.Click

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonMin_Click(sender As Object, e As EventArgs) Handles ButtonMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub sign_in_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBox_User.Text = "Select User"
        CBox_User.SelectedIndex = 0
        If CBox_User.Text = "Alex" Then
            TxtBox_Password.Text = "quack10"
        ElseIf CBox_User.Text = "John Doe" Then
            TxtBox_Password.Text = "quack20"
        End If
    End Sub

    '//**************************************************************
    '// LIBRARIES AND EVENTS TO MOVE THE FORM
    '//**************************************************************
    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub

    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub PanelTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelTitle.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub sign_in_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub PanelBottom_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelBottom.MouseDown
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub ButtonEnter_Click(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        If CBox_User.Text = "John Doe" And TxtBox_Password.Text = "quack20" Or CBox_User.Text = "Alex" And TxtBox_Password.Text = "quack10" Then
            Me.Hide()
            Welcome.Show()

        Else

            MsgBox("Incorrect password/user, try again.", MsgBoxStyle.Critical, "Login")
            TxtBox_Password.Clear()
            TxtBox_Password.Focus()
        End If

        '// Error message structure on emergent window'
        '// MSGBOX, message, window styles, window title '
        '// Styles: critical, okonly, yes/no'
    End Sub

    Private Sub CBoxUser_IndexChanged(sender As Object, e As EventArgs) Handles CBox_User.SelectedIndexChanged
        If CBox_User.Text = "John Doe" Then

            LabelEmail.Text = "johndoe@gmail.com"
            LabelType.Text = "Admin"
            LabelExp.Text = "268986"

        ElseIf CBox_User.Text = "Alex" Then

            LabelEmail.Text = "alex@gmail.com"
            LabelType.Text = "User"
            LabelExp.Text = "318035"

        End If

        If CBox_User.Text = "Alex" Then
            TxtBox_Password.Text = "quack10"
        ElseIf CBox_User.Text = "John Doe" Then
            TxtBox_Password.Text = "quack20"
        End If
    End Sub
End Class