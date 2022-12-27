'-------LIBRARIES OR DLL---------'
Imports System.Runtime.InteropServices

Public Class Welcome
    Private Sub Welcome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelName.Text = sign_in.User_Name
        LabelEmail.Text = sign_in.User_Email
        LabelAge.Text = sign_in.User_Age
        LabelSector.Text = sign_in.User_Sector
        LabelGender.Text = sign_in.User_Gender

        Me.Opacity = 0
        ProgressBar.Value = 0
        TimerOpen.Start()
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        TimerClose.Start()
    End Sub

    Private Sub ButtonMin_Click(sender As Object, e As EventArgs) Handles ButtonMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ButtonEnter_Click(sender As Object, e As EventArgs) Handles ButtonEnter.Click
        MsgBox("The password is: " & sign_in.User_Key, MsgBoxStyle.OkOnly, "Welcome")
    End Sub

    Private Sub TimerOpen_Tick(sender As Object, e As EventArgs) Handles TimerOpen.Tick

        ProgressBar.Value += 1
        LabelLoading.Text = ProgressBar.Value & "%"

        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
        End If

        If ProgressBar.Value = 100 Then
            TimerOpen.Stop()
            TimerClose.Start()
        End If
    End Sub

    Private Sub TimerClose_Tick(sender As Object, e As EventArgs) Handles TimerClose.Tick
        Me.Opacity -= 0.1

        If Me.Opacity = 0 Then
            TimerClose.Stop()
            Me.Close()
        End If
    End Sub
End Class