<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sign_in
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sign_in))
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.ButtonMin = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.LabelUser = New System.Windows.Forms.Label()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.CBox_User = New System.Windows.Forms.ComboBox()
        Me.TxtBox_Password = New System.Windows.Forms.TextBox()
        Me.LinkLabel_Recover = New System.Windows.Forms.LinkLabel()
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TimerOpen = New System.Windows.Forms.Timer(Me.components)
        Me.TimerClose = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonShowPass = New System.Windows.Forms.Button()
        Me.ButtonHidePass = New System.Windows.Forms.Button()
        Me.PictureBoxLogo = New System.Windows.Forms.PictureBox()
        Me.PanelTitle.SuspendLayout()
        Me.PanelBottom.SuspendLayout()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelTitle
        '
        Me.PanelTitle.BackColor = System.Drawing.Color.Black
        Me.PanelTitle.Controls.Add(Me.ButtonMin)
        Me.PanelTitle.Controls.Add(Me.ButtonClose)
        Me.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitle.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(409, 45)
        Me.PanelTitle.TabIndex = 0
        '
        'ButtonMin
        '
        Me.ButtonMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonMin.DialogResult = System.Windows.Forms.DialogResult.Ignore
        Me.ButtonMin.FlatAppearance.BorderSize = 0
        Me.ButtonMin.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ButtonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMin.ForeColor = System.Drawing.Color.White
        Me.ButtonMin.Location = New System.Drawing.Point(321, 0)
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
        Me.ButtonClose.Location = New System.Drawing.Point(364, 0)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(45, 45)
        Me.ButtonClose.TabIndex = 0
        Me.ButtonClose.Text = "X"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'LabelUser
        '
        Me.LabelUser.AutoSize = True
        Me.LabelUser.BackColor = System.Drawing.Color.Transparent
        Me.LabelUser.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUser.ForeColor = System.Drawing.Color.Black
        Me.LabelUser.Location = New System.Drawing.Point(61, 339)
        Me.LabelUser.Name = "LabelUser"
        Me.LabelUser.Size = New System.Drawing.Size(43, 19)
        Me.LabelUser.TabIndex = 3
        Me.LabelUser.Text = "User"
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.BackColor = System.Drawing.Color.Transparent
        Me.LabelPassword.Font = New System.Drawing.Font("Arial Narrow", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPassword.ForeColor = System.Drawing.Color.Black
        Me.LabelPassword.Location = New System.Drawing.Point(60, 400)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(71, 22)
        Me.LabelPassword.TabIndex = 4
        Me.LabelPassword.Text = "Password"
        '
        'CBox_User
        '
        Me.CBox_User.FormattingEnabled = True
        Me.CBox_User.Items.AddRange(New Object() {"Alex", "John Doe"})
        Me.CBox_User.Location = New System.Drawing.Point(64, 359)
        Me.CBox_User.Name = "CBox_User"
        Me.CBox_User.Size = New System.Drawing.Size(275, 24)
        Me.CBox_User.TabIndex = 5
        '
        'TxtBox_Password
        '
        Me.TxtBox_Password.Location = New System.Drawing.Point(64, 425)
        Me.TxtBox_Password.Name = "TxtBox_Password"
        Me.TxtBox_Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtBox_Password.Size = New System.Drawing.Size(275, 22)
        Me.TxtBox_Password.TabIndex = 6
        '
        'LinkLabel_Recover
        '
        Me.LinkLabel_Recover.AutoSize = True
        Me.LinkLabel_Recover.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel_Recover.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel_Recover.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel_Recover.Location = New System.Drawing.Point(98, 476)
        Me.LinkLabel_Recover.Name = "LinkLabel_Recover"
        Me.LinkLabel_Recover.Size = New System.Drawing.Size(196, 20)
        Me.LinkLabel_Recover.TabIndex = 7
        Me.LinkLabel_Recover.TabStop = True
        Me.LinkLabel_Recover.Text = "Did you forget your password?"
        '
        'PanelBottom
        '
        Me.PanelBottom.BackColor = System.Drawing.Color.Black
        Me.PanelBottom.Controls.Add(Me.ButtonEnter)
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBottom.Location = New System.Drawing.Point(0, 730)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(409, 70)
        Me.PanelBottom.TabIndex = 8
        '
        'ButtonEnter
        '
        Me.ButtonEnter.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.ButtonEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ButtonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEnter.ForeColor = System.Drawing.Color.White
        Me.ButtonEnter.Location = New System.Drawing.Point(278, 13)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(109, 45)
        Me.ButtonEnter.TabIndex = 0
        Me.ButtonEnter.Text = "Enter"
        Me.ButtonEnter.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(171, 273)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(74, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Sign In"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TimerOpen
        '
        Me.TimerOpen.Interval = 25
        '
        'TimerClose
        '
        Me.TimerClose.Interval = 25
        '
        'ButtonShowPass
        '
        Me.ButtonShowPass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonShowPass.BackColor = System.Drawing.Color.Transparent
        Me.ButtonShowPass.BackgroundImage = Global.Requirements_Engineering.My.Resources.Resources.show_icon
        Me.ButtonShowPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonShowPass.DialogResult = System.Windows.Forms.DialogResult.Ignore
        Me.ButtonShowPass.FlatAppearance.BorderSize = 0
        Me.ButtonShowPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.ButtonShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonShowPass.ForeColor = System.Drawing.Color.Black
        Me.ButtonShowPass.Location = New System.Drawing.Point(311, 428)
        Me.ButtonShowPass.Name = "ButtonShowPass"
        Me.ButtonShowPass.Size = New System.Drawing.Size(19, 16)
        Me.ButtonShowPass.TabIndex = 16
        Me.ButtonShowPass.UseVisualStyleBackColor = False
        Me.ButtonShowPass.Visible = False
        '
        'ButtonHidePass
        '
        Me.ButtonHidePass.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonHidePass.BackColor = System.Drawing.Color.Transparent
        Me.ButtonHidePass.BackgroundImage = Global.Requirements_Engineering.My.Resources.Resources.hide_icon
        Me.ButtonHidePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ButtonHidePass.DialogResult = System.Windows.Forms.DialogResult.Ignore
        Me.ButtonHidePass.FlatAppearance.BorderSize = 0
        Me.ButtonHidePass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.ButtonHidePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonHidePass.ForeColor = System.Drawing.Color.Black
        Me.ButtonHidePass.Location = New System.Drawing.Point(311, 428)
        Me.ButtonHidePass.Name = "ButtonHidePass"
        Me.ButtonHidePass.Size = New System.Drawing.Size(19, 16)
        Me.ButtonHidePass.TabIndex = 3
        Me.ButtonHidePass.UseVisualStyleBackColor = False
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.PictureBoxLogo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxLogo.BackgroundImage = CType(resources.GetObject("PictureBoxLogo.BackgroundImage"), System.Drawing.Image)
        Me.PictureBoxLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBoxLogo.Location = New System.Drawing.Point(118, 72)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(176, 182)
        Me.PictureBoxLogo.TabIndex = 1
        Me.PictureBoxLogo.TabStop = False
        '
        'sign_in
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(409, 800)
        Me.Controls.Add(Me.ButtonShowPass)
        Me.Controls.Add(Me.ButtonHidePass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PanelBottom)
        Me.Controls.Add(Me.LinkLabel_Recover)
        Me.Controls.Add(Me.TxtBox_Password)
        Me.Controls.Add(Me.CBox_User)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.LabelUser)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Controls.Add(Me.PanelTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "sign_in"
        Me.Text = "sign_in"
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelBottom.ResumeLayout(False)
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelTitle As Panel
    Friend WithEvents ButtonMin As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents PictureBoxLogo As PictureBox
    Public WithEvents LabelUser As Label
    Friend WithEvents LabelPassword As Label
    Friend WithEvents CBox_User As ComboBox
    Friend WithEvents TxtBox_Password As TextBox
    Friend WithEvents LinkLabel_Recover As LinkLabel
    Friend WithEvents PanelBottom As Panel
    Friend WithEvents ButtonEnter As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonHidePass As Button
    Friend WithEvents ButtonShowPass As Button
    Friend WithEvents TimerOpen As Timer
    Friend WithEvents TimerClose As Timer
End Class
