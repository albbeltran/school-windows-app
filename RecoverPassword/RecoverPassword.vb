'-------LIBRARIES OR DLL---------
Imports System.Runtime.InteropServices

Public Class RecoverPassword
    Private Sub RecoverPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CBox_User.Text = "Select User"
        CBox_User.SelectedIndex = 0
        If CBox_User.Text = "Alex" Then
            TxtBox_Email.Text = sign_in.User_Email
        ElseIf CBox_User.Text = "John Doe" Then
            TxtBox_Email.Text = sign_in.User_Email
        End If
        Me.Opacity = 0
        TimerOpen.Start()
    End Sub

    Private Sub TimerOpen_Tick(sender As Object, e As EventArgs) Handles TimerOpen.Tick
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        End If

        If Me.Opacity = 1 Then
            TimerOpen.Stop()
        End If
    End Sub

    Private Sub TimerClose_Tick(sender As Object, e As EventArgs) Handles TimerClose.Tick
        Me.Opacity -= 0.1

        If Me.Opacity = 0 Then
            TimerClose.Stop()
            Me.Close()
        End If
    End Sub

    Private Sub CBox_User_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBox_User.SelectedIndexChanged
        sign_in.User_Name = CBox_User.Text

        If sign_in.User_Name = "John Doe" Then

            sign_in.User_Email = "johndoe@gmail.com"
            sign_in.User_Type = "Admin"
            sign_in.User_Exp = "268986"

        ElseIf sign_in.User_Name = "Alex" Then

            sign_in.User_Email = "alex@gmail.com"
            sign_in.User_Type = "User"
            sign_in.User_Exp = "318035"

        End If

        If CBox_User.Text = "Alex" Then
            TxtBox_Email.Text = sign_in.User_Email
        ElseIf CBox_User.Text = "John Doe" Then
            TxtBox_Email.Text = sign_in.User_Email
        End If
    End Sub

    Private Sub ButtonMin_Click(sender As Object, e As EventArgs) Handles ButtonMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        TimerClose.Start()
        sign_in.Show()
    End Sub

    Private Sub ButtonEnter_Click(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        MsgBox("An email was sent to: " & sign_in.User_Email, MsgBoxStyle.OkOnly, "Recover password")
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
End Class