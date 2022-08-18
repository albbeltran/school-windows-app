'-------LIBRARIES OR DLL---------'
Imports System.Runtime.InteropServices

Public Class sign_in
    Private Sub LabelTitle_Click(sender As Object, e As EventArgs) Handles LabelTitle.Click

    End Sub

    Private Sub LabelPassword_Click(sender As Object, e As EventArgs) Handles LabelPassword.Click

    End Sub

    Private Sub PictureBoxLogo_Click(sender As Object, e As EventArgs) Handles PictureBoxLogo.Click

    End Sub

    Private Sub TxtBox_Password_TextChanged(sender As Object, e As EventArgs) Handles TxtBox_Password.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub LinkLabel_Recover_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel_Recover.LinkClicked

    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Me.Close()
    End Sub

    Private Sub ButtonMin_Click(sender As Object, e As EventArgs) Handles ButtonMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub sign_in_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBox_User.Text = "Select User"
        TxtBox_Password.Text = "quack20"
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
        If CBox_User.Text = "John Doe" And TxtBox_Password.Text = "quack20" Then
            Me.Hide()
            Welcome.Show()
        End If
    End Sub
End Class