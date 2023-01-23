'-------LIBRARIES OR DLL---------'
Imports System.Runtime.InteropServices

Public Class Main
    Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LabelName.Text = sign_in.User_Name
        LabelEmail.Text = sign_in.User_Email

        ButtonHome.FlatAppearance.BorderSize = 2
        ButtonHome.FlatAppearance.BorderColor = Color.Aqua

        Max()
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
            Application.Exit()
        End If
    End Sub

    Private Sub TimerHour_Tick(sender As Object, e As EventArgs) Handles TimerHour.Tick
        LabelHour.Text = DateTime.Now.ToString("HH:mm:ss")
        LabelDate.Text = DateTime.Now.ToLongDateString
    End Sub

    Dim ActiveForm As Form = Nothing

    Sub Open_Form_Panel_Container(ByVal ChildForm As Form)

        If ActiveForm IsNot Nothing Then
            ActiveForm.Close()
        End If

        ActiveForm = ChildForm '// Secondary form becomes the active
        ChildForm.TopLevel = False
        ChildForm.FormBorderStyle = FormBorderStyle.None
        ChildForm.Dock = DockStyle.Fill '// Take the size of the parent container
        PanelContainer.Controls.Add(ChildForm) '// Add the selected form to the panel
        PanelContainer.Tag = ChildForm '// Allows interaction
        ChildForm.BringToFront() '// Send the selected form to the center
        ChildForm.Show()
    End Sub

    Private Sub ButtonHome_Click(sender As Object, e As EventArgs) Handles ButtonHome.Click
        BackOriginalColors()
        ButtonHome.FlatAppearance.BorderSize = 1
        ButtonHome.FlatAppearance.BorderColor = Color.Aqua
        LabelHour.Visible = True
        LabelDate.Visible = True

        If ActiveForm IsNot Nothing Then
            ActiveForm.Close()
        End If
    End Sub

    Private Sub BackOriginalColors()
        ButtonHome.FlatAppearance.BorderSize = 0
        ButtonStudents.FlatAppearance.BorderSize = 0
        ButtonSubjects.FlatAppearance.BorderSize = 0
        ButtonProducts.FlatAppearance.BorderSize = 0
        ButtonTeachers.FlatAppearance.BorderSize = 0
        ButtonBooks.FlatAppearance.BorderSize = 0
        ButtonMusic.FlatAppearance.BorderSize = 0
    End Sub

    Private Sub ButtonProducts_Click(sender As Object, e As EventArgs) Handles ButtonProducts.Click
        BackOriginalColors()
        Open_Form_Panel_Container(New Products)
        ButtonProducts.FlatAppearance.BorderSize = 1
        ButtonProducts.FlatAppearance.BorderColor = Color.Aqua
        LabelHour.Visible = False
        LabelDate.Visible = False
    End Sub

    Private Sub ButtonStudents_Click(sender As Object, e As EventArgs) Handles ButtonStudents.Click
        BackOriginalColors()
        Open_Form_Panel_Container(New Students)
        ButtonStudents.FlatAppearance.BorderSize = 1
        ButtonStudents.FlatAppearance.BorderColor = Color.Aqua
        LabelHour.Visible = False
        LabelDate.Visible = False
    End Sub

    Private Sub ButtonSubjects_Click(sender As Object, e As EventArgs) Handles ButtonSubjects.Click
        BackOriginalColors()
        Open_Form_Panel_Container(New Subjects)
        ButtonSubjects.FlatAppearance.BorderSize = 1
        ButtonSubjects.FlatAppearance.BorderColor = Color.Aqua
        LabelHour.Visible = False
        LabelDate.Visible = False
    End Sub

    Private Sub ButtonTeachers_Click(sender As Object, e As EventArgs) Handles ButtonTeachers.Click
        BackOriginalColors()
        Open_Form_Panel_Container(New Teachers)
        ButtonTeachers.FlatAppearance.BorderSize = 1
        ButtonTeachers.FlatAppearance.BorderColor = Color.Aqua
        LabelHour.Visible = False
        LabelDate.Visible = False
    End Sub

    Private Sub ButtonBooks_Click(sender As Object, e As EventArgs) Handles ButtonBooks.Click
        BackOriginalColors()
        Open_Form_Panel_Container(New Books)
        ButtonBooks.FlatAppearance.BorderSize = 1
        ButtonBooks.FlatAppearance.BorderColor = Color.Aqua
        LabelHour.Visible = False
        LabelDate.Visible = False
    End Sub

    Private Sub ButtonMusic_Click(sender As Object, e As EventArgs) Handles ButtonMusic.Click
        BackOriginalColors()
        Open_Form_Panel_Container(New Songs)
        ButtonMusic.FlatAppearance.BorderSize = 1
        ButtonMusic.FlatAppearance.BorderColor = Color.Aqua
        LabelHour.Visible = False
        LabelDate.Visible = False
    End Sub
End Class