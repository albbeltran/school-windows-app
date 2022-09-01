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

    Dim LocationX As Integer
    Dim LocationY As Integer
    Dim WidthSize As Integer
    Dim HeightSize As Integer

    Private Sub Max()

        LocationX = Me.Location.X
        LocationY = Me.Location.Y
        WidthSize = Me.Size.Width
        HeightSize = Me.Size.Height

        ButtonMax.Visible = False
        ButtonRestore.Visible = True

        Me.Size = Screen.PrimaryScreen.WorkingArea.Size
        Me.Location = Screen.PrimaryScreen.WorkingArea.Location

    End Sub

    Private Sub ButtonMax_Click(sender As Object, e As EventArgs) Handles ButtonMax.Click
        Max()
    End Sub

    Private Sub ButtonRestore_Click(sender As Object, e As EventArgs) Handles ButtonRestore.Click
        Me.Size = New Size(WidthSize, HeightSize)
        Me.Location = New Point(LocationX, LocationY)

        ButtonMax.Visible = True
        ButtonRestore.Visible = False
    End Sub

    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        TimerClose.Start()
    End Sub

    Private Sub ButtonMin_Click(sender As Object, e As EventArgs) Handles ButtonMin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub TimerClose_Tick(sender As Object, e As EventArgs) Handles TimerClose.Tick
        Me.Opacity -= 0.1

        If Me.Opacity = 0 Then
            TimerClose.Stop()
            Me.Close()
        End If
    End Sub

    Private Sub TimerHour_Tick(sender As Object, e As EventArgs) Handles TimerHour.Tick
        LabelHour.Text = DateTime.Now.ToString("HH:mm:ss")
        LabelDate.Text = DateTime.Now.ToLongDateString
    End Sub
End Class