'-------LIBRARIES OR DLL---------'
Imports System.Runtime.InteropServices

Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelName.Text = sign_in.User_Name
        LabelType.Text = sign_in.User_Type

        ButtonHome.FlatAppearance.BorderSize = 2
        ButtonHome.FlatAppearance.BorderColor = Color.Aqua
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

    Private Sub ButtonSignOut_Click(sender As Object, e As EventArgs) Handles ButtonSignOut.Click
        Me.Close()
        sign_in.Show()
    End Sub

    Private Sub ButtonMax_Click(sender As Object, e As EventArgs) Handles ButtonMax.Click

    End Sub
End Class