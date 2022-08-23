<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome
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
        Me.LabelType = New System.Windows.Forms.Label()
        Me.ButtonMin = New System.Windows.Forms.Button()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.LabelWelcome = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.LabelExp = New System.Windows.Forms.Label()
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.TimerOpen = New System.Windows.Forms.Timer(Me.components)
        Me.TimerClose = New System.Windows.Forms.Timer(Me.components)
        Me.LabelLoading = New System.Windows.Forms.Label()
        Me.PanelTitle.SuspendLayout()
        Me.PanelBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTitle
        '
        Me.PanelTitle.BackColor = System.Drawing.Color.Black
        Me.PanelTitle.Controls.Add(Me.LabelType)
        Me.PanelTitle.Controls.Add(Me.ButtonMin)
        Me.PanelTitle.Controls.Add(Me.ButtonClose)
        Me.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTitle.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(800, 45)
        Me.PanelTitle.TabIndex = 1
        '
        'LabelType
        '
        Me.LabelType.AutoSize = True
        Me.LabelType.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.LabelType.Location = New System.Drawing.Point(21, 13)
        Me.LabelType.Name = "LabelType"
        Me.LabelType.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelType.Size = New System.Drawing.Size(43, 17)
        Me.LabelType.TabIndex = 10
        Me.LabelType.Text = "Type"
        Me.LabelType.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ButtonMin
        '
        Me.ButtonMin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonMin.DialogResult = System.Windows.Forms.DialogResult.Ignore
        Me.ButtonMin.FlatAppearance.BorderSize = 0
        Me.ButtonMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.ButtonMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMin.ForeColor = System.Drawing.Color.White
        Me.ButtonMin.Location = New System.Drawing.Point(712, 0)
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
        Me.ButtonClose.Location = New System.Drawing.Point(755, 0)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(45, 45)
        Me.ButtonClose.TabIndex = 0
        Me.ButtonClose.Text = "X"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'LabelWelcome
        '
        Me.LabelWelcome.AutoSize = True
        Me.LabelWelcome.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWelcome.ForeColor = System.Drawing.Color.Black
        Me.LabelWelcome.Location = New System.Drawing.Point(309, 72)
        Me.LabelWelcome.Name = "LabelWelcome"
        Me.LabelWelcome.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelWelcome.Size = New System.Drawing.Size(119, 28)
        Me.LabelWelcome.TabIndex = 4
        Me.LabelWelcome.Text = "Welcome"
        Me.LabelWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(627, 347)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(161, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Computer Science"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.BackColor = System.Drawing.Color.Black
        Me.LabelName.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.ForeColor = System.Drawing.Color.White
        Me.LabelName.Location = New System.Drawing.Point(21, 13)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelName.Size = New System.Drawing.Size(50, 17)
        Me.LabelName.TabIndex = 6
        Me.LabelName.Text = "Name"
        Me.LabelName.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelEmail
        '
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.BackColor = System.Drawing.Color.Transparent
        Me.LabelEmail.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmail.ForeColor = System.Drawing.Color.White
        Me.LabelEmail.Location = New System.Drawing.Point(23, 41)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelEmail.Size = New System.Drawing.Size(48, 17)
        Me.LabelEmail.TabIndex = 7
        Me.LabelEmail.Text = "Email"
        Me.LabelEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelExp
        '
        Me.LabelExp.AutoSize = True
        Me.LabelExp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelExp.ForeColor = System.Drawing.Color.White
        Me.LabelExp.Location = New System.Drawing.Point(77, 13)
        Me.LabelExp.Name = "LabelExp"
        Me.LabelExp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelExp.Size = New System.Drawing.Size(89, 17)
        Me.LabelExp.TabIndex = 8
        Me.LabelExp.Text = "Expediente"
        Me.LabelExp.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PanelBottom
        '
        Me.PanelBottom.BackColor = System.Drawing.Color.Black
        Me.PanelBottom.Controls.Add(Me.ButtonEnter)
        Me.PanelBottom.Controls.Add(Me.LabelName)
        Me.PanelBottom.Controls.Add(Me.LabelExp)
        Me.PanelBottom.Controls.Add(Me.LabelEmail)
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBottom.Location = New System.Drawing.Point(0, 380)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(800, 70)
        Me.PanelBottom.TabIndex = 10
        '
        'ButtonEnter
        '
        Me.ButtonEnter.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.ButtonEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ButtonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEnter.ForeColor = System.Drawing.Color.White
        Me.ButtonEnter.Location = New System.Drawing.Point(675, 13)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(109, 45)
        Me.ButtonEnter.TabIndex = 0
        Me.ButtonEnter.Text = "Enter"
        Me.ButtonEnter.UseVisualStyleBackColor = True
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(197, 251)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(364, 23)
        Me.ProgressBar.TabIndex = 11
        Me.ProgressBar.Value = 50
        '
        'TimerOpen
        '
        Me.TimerOpen.Interval = 10
        '
        'TimerClose
        '
        Me.TimerClose.Interval = 25
        '
        'LabelLoading
        '
        Me.LabelLoading.AutoSize = True
        Me.LabelLoading.BackColor = System.Drawing.Color.Transparent
        Me.LabelLoading.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelLoading.ForeColor = System.Drawing.Color.Black
        Me.LabelLoading.Location = New System.Drawing.Point(345, 231)
        Me.LabelLoading.Name = "LabelLoading"
        Me.LabelLoading.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelLoading.Size = New System.Drawing.Size(26, 17)
        Me.LabelLoading.TabIndex = 9
        Me.LabelLoading.Text = "10"
        Me.LabelLoading.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Welcome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LabelLoading)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.PanelBottom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelWelcome)
        Me.Controls.Add(Me.PanelTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Welcome"
        Me.Text = "Welcome"
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        Me.PanelBottom.ResumeLayout(False)
        Me.PanelBottom.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelTitle As Panel
    Friend WithEvents ButtonMin As Button
    Friend WithEvents ButtonClose As Button
    Friend WithEvents LabelWelcome As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelExp As Label
    Friend WithEvents LabelType As Label
    Friend WithEvents PanelBottom As Panel
    Friend WithEvents ButtonEnter As Button
    Friend WithEvents ProgressBar As ProgressBar
    Friend WithEvents TimerOpen As Timer
    Friend WithEvents TimerClose As Timer
    Friend WithEvents LabelLoading As Label
End Class
