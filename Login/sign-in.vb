'-------LIBRARIES OR DLL---------
Imports System.Runtime.InteropServices

Public Class sign_in
    '// PUBLIC AND PRIVATE VARIABLES

    Public User_Name As String
    Public User_Email As String
    Public User_Type As String
    Public User_Password As String
    Public User_Exp As Double

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        TimerClose.Start()
    End Sub

    Private Sub ButtonMin_Click(sender As Object, e As EventArgs) Handles ButtonMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub sign_in_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Link()
        CBox_User.Text = "Select User"
        CBox_User.SelectedIndex = 0
        If CBox_User.Text = "Alex" Then
            TxtBox_Password.Text = User_Password
        ElseIf CBox_User.Text = "John Doe" Then
            TxtBox_Password.Text = User_Password
        End If
        Me.Opacity = 0
        TimerOpen.Start()
    End Sub

    Private Sub ButtonEnter_Click(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        enter_process()
    End Sub

    Private Sub CBoxUser_IndexChanged(sender As Object, e As EventArgs) Handles CBox_User.SelectedIndexChanged
        User_Name = CBox_User.Text

        If User_Name = "John Doe" Then

            User_Email = "johndoe@gmail.com"
            User_Type = "Admin"
            User_Exp = "268986"

        ElseIf User_Name = "Alex" Then

            User_Email = "alex@gmail.com"
            User_Type = "User"
            User_Exp = "318035"

        End If

        If User_Name = "Alex" Then
            User_Password = "quack10"
        ElseIf CBox_User.Text = "John Doe" Then
            User_Password = "quack20"
        End If
    End Sub

    Private Sub ButtonHidePass_Click(sender As Object, e As EventArgs) Handles ButtonHidePass.Click
        '// Asignar asterisco a la contraseña y ocultar el icono de ButtonHide
        TxtBox_Password.PasswordChar = "*"
        ButtonHidePass.Visible = False
        ButtonShowPass.Visible = True
    End Sub

    Private Sub ButtonShowPass_Click(sender As Object, e As EventArgs) Handles ButtonShowPass.Click
        '// Quitar simbolos de la contraseña y ocultar el icono de ButtonShow
        TxtBox_Password.PasswordChar = ""
        ButtonHidePass.Visible = True
        ButtonShowPass.Visible = False
    End Sub

    Private Sub CBox_User_KeyPress(sender As Object, e As KeyPressEventArgs) Handles CBox_User.KeyPress
        e.KeyChar = ""
    End Sub

    Private Sub TxtBox_Password_KeyDown(sender As Object, e As KeyEventArgs) Handles TxtBox_Password.KeyDown
        If e.KeyCode = Keys.Enter Then
            enter_process()
        End If
    End Sub

    '// PUBLIC AND PRIVATE PROCESS

    Private Sub enter_process()
        If CBox_User.Text = "John Doe" And TxtBox_Password.Text = "quack20" Or CBox_User.Text = "Alex" And TxtBox_Password.Text = "quack10" Then
            Me.Hide()
            Welcome.ShowDialog()
            Main.Show()
        Else

            MsgBox("Incorrect password/user, try again.", MsgBoxStyle.Critical, "Login")
            TxtBox_Password.Clear()
            TxtBox_Password.Focus()
        End If

        '// Error message structure on emergent window
        '// MSGBOX, message, window styles, window title 
        '// Styles: critical, okonly, yes/no
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

    Private Sub LinkLabel_Recover_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel_Recover.LinkClicked
        Me.Hide()
        RecoverPassword.Show()
    End Sub
End Class