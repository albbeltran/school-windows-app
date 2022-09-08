<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RecoverPassword
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
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.ButtonMin = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.LabelUser = New System.Windows.Forms.Label()
        Me.CBox_User = New System.Windows.Forms.ComboBox()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.TxtBox_Email = New System.Windows.Forms.TextBox()
        Me.TimerOpen = New System.Windows.Forms.Timer(Me.components)
        Me.TimerClose = New System.Windows.Forms.Timer(Me.components)
        Me.PanelTitle.SuspendLayout()
        Me.PanelBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTitle
        '
        Me.PanelTitle.BackColor = System.Drawing.Color.Black
        Me.PanelTitle.Controls.Add(Me.LabelTitle)
        Me.PanelTitle.Controls.Add(Me.ButtonMin)
        Me.PanelTitle.Controls.Add(Me.ButtonClose)
        Me.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitle.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(430, 45)
        Me.PanelTitle.TabIndex = 1
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.ForeColor = System.Drawing.Color.White
        Me.LabelTitle.Location = New System.Drawing.Point(127, 9)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(194, 23)
        Me.LabelTitle.TabIndex = 2
        Me.LabelTitle.Text = "Recover Password"
        '
        'ButtonMin
        '
        Me.ButtonMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonMin.DialogResult = System.Windows.Forms.DialogResult.Ignore
        Me.ButtonMin.FlatAppearance.BorderSize = 0
        Me.ButtonMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.ButtonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMin.ForeColor = System.Drawing.Color.White
        Me.ButtonMin.Location = New System.Drawing.Point(342, 0)
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
        Me.ButtonClose.Location = New System.Drawing.Point(385, 0)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(45, 45)
        Me.ButtonClose.TabIndex = 0
        Me.ButtonClose.Text = "X"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'PanelBottom
        '
        Me.PanelBottom.BackColor = System.Drawing.Color.Black
        Me.PanelBottom.Controls.Add(Me.ButtonEnter)
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBottom.Location = New System.Drawing.Point(0, 730)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(430, 70)
        Me.PanelBottom.TabIndex = 9
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
        'LabelUser
        '
        Me.LabelUser.AutoSize = True
        Me.LabelUser.BackColor = System.Drawing.Color.Transparent
        Me.LabelUser.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelUser.ForeColor = System.Drawing.Color.Black
        Me.LabelUser.Location = New System.Drawing.Point(70, 210)
        Me.LabelUser.Name = "LabelUser"
        Me.LabelUser.Size = New System.Drawing.Size(43, 17)
        Me.LabelUser.TabIndex = 10
        Me.LabelUser.Text = "User"
        '
        'CBox_User
        '
        Me.CBox_User.FormattingEnabled = True
        Me.CBox_User.Items.AddRange(New Object() {"Alex", "John Doe"})
        Me.CBox_User.Location = New System.Drawing.Point(73, 241)
        Me.CBox_User.Name = "CBox_User"
        Me.CBox_User.Size = New System.Drawing.Size(275, 24)
        Me.CBox_User.TabIndex = 11
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.BackColor = System.Drawing.Color.Transparent
        Me.LabelPassword.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelPassword.ForeColor = System.Drawing.Color.Black
        Me.LabelPassword.Location = New System.Drawing.Point(70, 319)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(48, 17)
        Me.LabelPassword.TabIndex = 12
        Me.LabelPassword.Text = "Email"
        '
        'TxtBox_Email
        '
        Me.TxtBox_Email.Location = New System.Drawing.Point(73, 349)
        Me.TxtBox_Email.Name = "TxtBox_Email"
        Me.TxtBox_Email.ReadOnly = True
        Me.TxtBox_Email.Size = New System.Drawing.Size(275, 22)
        Me.TxtBox_Email.TabIndex = 13
        '
        'TimerOpen
        '
        Me.TimerOpen.Interval = 25
        '
        'TimerClose
        '
        Me.TimerClose.Interval = 25
        '
        'RecoverPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 800)
        Me.Controls.Add(Me.TxtBox_Email)
        Me.Controls.Add(Me.LabelPassword)
        Me.Controls.Add(Me.CBox_User)
        Me.Controls.Add(Me.LabelUser)
        Me.Controls.Add(Me.PanelBottom)
        Me.Controls.Add(Me.PanelTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RecoverPassword"
        Me.Text = "RecoverPassword"
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        Me.PanelBottom.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelTitle As Panel
    Friend WithEvents LabelTitle As Label
    Friend WithEvents ButtonMin As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents PanelBottom As Panel
    Friend WithEvents ButtonEnter As Button
    Public WithEvents LabelUser As Label
    Friend WithEvents CBox_User As ComboBox
    Friend WithEvents LabelPassword As Label
    Friend WithEvents TxtBox_Email As TextBox
    Friend WithEvents TimerOpen As Timer
    Friend WithEvents TimerClose As Timer
End Class
