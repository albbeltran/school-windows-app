<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.ButtonRestore = New System.Windows.Forms.Button()
        Me.ButtonMax = New System.Windows.Forms.Button()
        Me.ButtonMin = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonBooks = New System.Windows.Forms.Button()
        Me.ButtonTeachers = New System.Windows.Forms.Button()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.ButtonSignOut = New System.Windows.Forms.Button()
        Me.ButtonProducts = New System.Windows.Forms.Button()
        Me.ButtonSubjects = New System.Windows.Forms.Button()
        Me.ButtonStudents = New System.Windows.Forms.Button()
        Me.ButtonHome = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.TimerOpen = New System.Windows.Forms.Timer(Me.components)
        Me.TimerClose = New System.Windows.Forms.Timer(Me.components)
        Me.LabelHour = New System.Windows.Forms.Label()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.TimerHour = New System.Windows.Forms.Timer(Me.components)
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.ButtonMusic = New System.Windows.Forms.Button()
        Me.PanelTitle.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTitle
        '
        Me.PanelTitle.BackColor = System.Drawing.Color.Black
        Me.PanelTitle.Controls.Add(Me.ButtonRestore)
        Me.PanelTitle.Controls.Add(Me.ButtonMax)
        Me.PanelTitle.Controls.Add(Me.ButtonMin)
        Me.PanelTitle.Controls.Add(Me.ButtonClose)
        Me.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitle.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(1031, 45)
        Me.PanelTitle.TabIndex = 2
        '
        'ButtonRestore
        '
        Me.ButtonRestore.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonRestore.DialogResult = System.Windows.Forms.DialogResult.Ignore
        Me.ButtonRestore.FlatAppearance.BorderSize = 0
        Me.ButtonRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.ButtonRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRestore.ForeColor = System.Drawing.Color.White
        Me.ButtonRestore.Location = New System.Drawing.Point(941, 0)
        Me.ButtonRestore.Name = "ButtonRestore"
        Me.ButtonRestore.Size = New System.Drawing.Size(45, 45)
        Me.ButtonRestore.TabIndex = 3
        Me.ButtonRestore.Text = "R"
        Me.ButtonRestore.UseVisualStyleBackColor = True
        Me.ButtonRestore.Visible = False
        '
        'ButtonMax
        '
        Me.ButtonMax.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonMax.DialogResult = System.Windows.Forms.DialogResult.Ignore
        Me.ButtonMax.FlatAppearance.BorderSize = 0
        Me.ButtonMax.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.ButtonMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMax.ForeColor = System.Drawing.Color.White
        Me.ButtonMax.Location = New System.Drawing.Point(941, 0)
        Me.ButtonMax.Name = "ButtonMax"
        Me.ButtonMax.Size = New System.Drawing.Size(45, 45)
        Me.ButtonMax.TabIndex = 2
        Me.ButtonMax.Text = "+"
        Me.ButtonMax.UseVisualStyleBackColor = True
        '
        'ButtonMin
        '
        Me.ButtonMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonMin.DialogResult = System.Windows.Forms.DialogResult.Ignore
        Me.ButtonMin.FlatAppearance.BorderSize = 0
        Me.ButtonMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ButtonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMin.ForeColor = System.Drawing.Color.White
        Me.ButtonMin.Location = New System.Drawing.Point(899, 0)
        Me.ButtonMin.Name = "ButtonMin"
        Me.ButtonMin.Size = New System.Drawing.Size(45, 45)
        Me.ButtonMin.TabIndex = 1
        Me.ButtonMin.Text = "-"
        Me.ButtonMin.UseVisualStyleBackColor = True
        '
        'ButtonClose
        '
        Me.ButtonClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonClose.DialogResult = System.Windows.Forms.DialogResult.Ignore
        Me.ButtonClose.FlatAppearance.BorderSize = 0
        Me.ButtonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OrangeRed
        Me.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClose.ForeColor = System.Drawing.Color.White
        Me.ButtonClose.Location = New System.Drawing.Point(986, 0)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(45, 45)
        Me.ButtonClose.TabIndex = 0
        Me.ButtonClose.Text = "X"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.ButtonMusic)
        Me.Panel1.Controls.Add(Me.ButtonBooks)
        Me.Panel1.Controls.Add(Me.ButtonTeachers)
        Me.Panel1.Controls.Add(Me.LabelEmail)
        Me.Panel1.Controls.Add(Me.LabelName)
        Me.Panel1.Controls.Add(Me.ButtonSignOut)
        Me.Panel1.Controls.Add(Me.ButtonProducts)
        Me.Panel1.Controls.Add(Me.ButtonSubjects)
        Me.Panel1.Controls.Add(Me.ButtonStudents)
        Me.Panel1.Controls.Add(Me.ButtonHome)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 504)
        Me.Panel1.TabIndex = 3
        '
        'ButtonBooks
        '
        Me.ButtonBooks.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonBooks.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonBooks.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonBooks.FlatAppearance.BorderSize = 0
        Me.ButtonBooks.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.ButtonBooks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ButtonBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonBooks.ForeColor = System.Drawing.Color.White
        Me.ButtonBooks.Image = Global.Requirements_Engineering.My.Resources.Resources.hide_icon
        Me.ButtonBooks.Location = New System.Drawing.Point(0, 325)
        Me.ButtonBooks.Name = "ButtonBooks"
        Me.ButtonBooks.Size = New System.Drawing.Size(200, 45)
        Me.ButtonBooks.TabIndex = 10
        Me.ButtonBooks.Text = "Books"
        Me.ButtonBooks.UseVisualStyleBackColor = True
        '
        'ButtonTeachers
        '
        Me.ButtonTeachers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonTeachers.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonTeachers.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonTeachers.FlatAppearance.BorderSize = 0
        Me.ButtonTeachers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.ButtonTeachers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ButtonTeachers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonTeachers.ForeColor = System.Drawing.Color.White
        Me.ButtonTeachers.Image = Global.Requirements_Engineering.My.Resources.Resources.hide_icon
        Me.ButtonTeachers.Location = New System.Drawing.Point(0, 280)
        Me.ButtonTeachers.Name = "ButtonTeachers"
        Me.ButtonTeachers.Size = New System.Drawing.Size(200, 45)
        Me.ButtonTeachers.TabIndex = 9
        Me.ButtonTeachers.Text = "Teachers"
        Me.ButtonTeachers.UseVisualStyleBackColor = True
        '
        'LabelEmail
        '
        Me.LabelEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmail.ForeColor = System.Drawing.Color.Cyan
        Me.LabelEmail.Location = New System.Drawing.Point(12, 436)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(46, 20)
        Me.LabelEmail.TabIndex = 7
        Me.LabelEmail.Text = "Email"
        '
        'LabelName
        '
        Me.LabelName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LabelName.AutoSize = True
        Me.LabelName.Font = New System.Drawing.Font("Microsoft YaHei", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.ForeColor = System.Drawing.Color.Cyan
        Me.LabelName.Location = New System.Drawing.Point(12, 416)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(49, 20)
        Me.LabelName.TabIndex = 6
        Me.LabelName.Text = "Name"
        '
        'ButtonSignOut
        '
        Me.ButtonSignOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSignOut.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButtonSignOut.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonSignOut.FlatAppearance.BorderSize = 0
        Me.ButtonSignOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.ButtonSignOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ButtonSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSignOut.ForeColor = System.Drawing.Color.White
        Me.ButtonSignOut.Image = Global.Requirements_Engineering.My.Resources.Resources.hide_icon
        Me.ButtonSignOut.Location = New System.Drawing.Point(0, 459)
        Me.ButtonSignOut.Name = "ButtonSignOut"
        Me.ButtonSignOut.Size = New System.Drawing.Size(200, 45)
        Me.ButtonSignOut.TabIndex = 5
        Me.ButtonSignOut.Text = "Exit"
        Me.ButtonSignOut.UseVisualStyleBackColor = True
        '
        'ButtonProducts
        '
        Me.ButtonProducts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonProducts.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonProducts.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonProducts.FlatAppearance.BorderSize = 0
        Me.ButtonProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.ButtonProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ButtonProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonProducts.ForeColor = System.Drawing.Color.White
        Me.ButtonProducts.Image = Global.Requirements_Engineering.My.Resources.Resources.hide_icon
        Me.ButtonProducts.Location = New System.Drawing.Point(0, 235)
        Me.ButtonProducts.Name = "ButtonProducts"
        Me.ButtonProducts.Size = New System.Drawing.Size(200, 45)
        Me.ButtonProducts.TabIndex = 4
        Me.ButtonProducts.Text = "Products"
        Me.ButtonProducts.UseVisualStyleBackColor = True
        '
        'ButtonSubjects
        '
        Me.ButtonSubjects.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSubjects.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonSubjects.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonSubjects.FlatAppearance.BorderSize = 0
        Me.ButtonSubjects.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.ButtonSubjects.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ButtonSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSubjects.ForeColor = System.Drawing.Color.White
        Me.ButtonSubjects.Image = Global.Requirements_Engineering.My.Resources.Resources.hide_icon
        Me.ButtonSubjects.Location = New System.Drawing.Point(0, 190)
        Me.ButtonSubjects.Name = "ButtonSubjects"
        Me.ButtonSubjects.Size = New System.Drawing.Size(200, 45)
        Me.ButtonSubjects.TabIndex = 3
        Me.ButtonSubjects.Text = "Subjects"
        Me.ButtonSubjects.UseVisualStyleBackColor = True
        '
        'ButtonStudents
        '
        Me.ButtonStudents.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonStudents.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonStudents.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonStudents.FlatAppearance.BorderSize = 0
        Me.ButtonStudents.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.ButtonStudents.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ButtonStudents.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonStudents.ForeColor = System.Drawing.Color.White
        Me.ButtonStudents.Image = Global.Requirements_Engineering.My.Resources.Resources.hide_icon
        Me.ButtonStudents.Location = New System.Drawing.Point(0, 145)
        Me.ButtonStudents.Name = "ButtonStudents"
        Me.ButtonStudents.Size = New System.Drawing.Size(200, 45)
        Me.ButtonStudents.TabIndex = 2
        Me.ButtonStudents.Text = "Students"
        Me.ButtonStudents.UseVisualStyleBackColor = True
        '
        'ButtonHome
        '
        Me.ButtonHome.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonHome.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonHome.FlatAppearance.BorderSize = 0
        Me.ButtonHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.ButtonHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonHome.ForeColor = System.Drawing.Color.White
        Me.ButtonHome.Image = Global.Requirements_Engineering.My.Resources.Resources.hide_icon
        Me.ButtonHome.Location = New System.Drawing.Point(0, 100)
        Me.ButtonHome.Name = "ButtonHome"
        Me.ButtonHome.Size = New System.Drawing.Size(200, 45)
        Me.ButtonHome.TabIndex = 1
        Me.ButtonHome.Text = "Home"
        Me.ButtonHome.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBoxLogo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 100)
        Me.Panel2.TabIndex = 0
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBoxLogo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxLogo.BackgroundImage = CType(resources.GetObject("PictureBoxLogo.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxLogo.Location = New System.Drawing.Point(51, 6)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(94, 84)
        Me.PictureBoxLogo.TabIndex = 2
        Me.PictureBoxLogo.TabStop = False
        '
        'TimerOpen
        '
        Me.TimerOpen.Interval = 15
        '
        'TimerClose
        '
        Me.TimerClose.Interval = 25
        '
        'LabelHour
        '
        Me.LabelHour.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelHour.AutoSize = True
        Me.LabelHour.Font = New System.Drawing.Font("Microsoft YaHei", 25.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHour.ForeColor = System.Drawing.Color.DarkCyan
        Me.LabelHour.Location = New System.Drawing.Point(507, 261)
        Me.LabelHour.Name = "LabelHour"
        Me.LabelHour.Size = New System.Drawing.Size(195, 57)
        Me.LabelHour.TabIndex = 8
        Me.LabelHour.Text = "00:00:00"
        '
        'LabelDate
        '
        Me.LabelDate.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelDate.AutoSize = True
        Me.LabelDate.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDate.ForeColor = System.Drawing.Color.DarkCyan
        Me.LabelDate.Location = New System.Drawing.Point(409, 321)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(385, 39)
        Me.LabelDate.TabIndex = 9
        Me.LabelDate.Text = "Tuesday, August 30, 2022"
        '
        'TimerHour
        '
        Me.TimerHour.Enabled = True
        '
        'PanelContainer
        '
        Me.PanelContainer.Controls.Add(Me.LabelHour)
        Me.PanelContainer.Controls.Add(Me.LabelDate)
        Me.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContainer.Location = New System.Drawing.Point(0, 0)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1031, 549)
        Me.PanelContainer.TabIndex = 10
        '
        'ButtonMusic
        '
        Me.ButtonMusic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonMusic.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonMusic.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonMusic.FlatAppearance.BorderSize = 0
        Me.ButtonMusic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.ButtonMusic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ButtonMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMusic.ForeColor = System.Drawing.Color.White
        Me.ButtonMusic.Image = Global.Requirements_Engineering.My.Resources.Resources.hide_icon
        Me.ButtonMusic.Location = New System.Drawing.Point(0, 370)
        Me.ButtonMusic.Name = "ButtonMusic"
        Me.ButtonMusic.Size = New System.Drawing.Size(200, 45)
        Me.ButtonMusic.TabIndex = 11
        Me.ButtonMusic.Text = "Music"
        Me.ButtonMusic.UseVisualStyleBackColor = True
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 549)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelTitle)
        Me.Controls.Add(Me.PanelContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main"
        Me.PanelTitle.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelContainer.ResumeLayout(False)
        Me.PanelContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelTitle As Panel
    Friend WithEvents ButtonMin As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBoxLogo As PictureBox
    Friend WithEvents ButtonSubjects As Button
    Friend WithEvents ButtonStudents As Button
    Friend WithEvents ButtonHome As Button
    Friend WithEvents ButtonSignOut As Button
    Friend WithEvents ButtonProducts As Button
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents ButtonMax As Button
    Friend WithEvents TimerOpen As Timer
    Friend WithEvents TimerClose As Timer
    Friend WithEvents ButtonRestore As Button
    Friend WithEvents LabelHour As Label
    Friend WithEvents LabelDate As Label
    Friend WithEvents TimerHour As Timer
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents ButtonTeachers As Button
    Friend WithEvents ButtonBooks As Button
    Friend WithEvents ButtonMusic As Button
End Class
