<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Teachers
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
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.LabelExp = New System.Windows.Forms.Label()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.LabelCounter = New System.Windows.Forms.Label()
        Me.LabelTeacher = New System.Windows.Forms.Label()
        Me.CBoxTeacher = New System.Windows.Forms.ComboBox()
        Me.GridStudents = New System.Windows.Forms.DataGridView()
        Me.LabelId = New System.Windows.Forms.Label()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.LabelEmail = New System.Windows.Forms.Label()
        Me.LabelCity = New System.Windows.Forms.Label()
        Me.LabelFaculty = New System.Windows.Forms.Label()
        Me.LabelSubject = New System.Windows.Forms.Label()
        Me.LabelType = New System.Windows.Forms.Label()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.PanelBottom.SuspendLayout()
        CType(Me.GridStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelBottom
        '
        Me.PanelBottom.BackColor = System.Drawing.Color.Black
        Me.PanelBottom.Controls.Add(Me.ButtonDelete)
        Me.PanelBottom.Controls.Add(Me.LabelExp)
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBottom.Location = New System.Drawing.Point(0, 465)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(955, 70)
        Me.PanelBottom.TabIndex = 13
        '
        'LabelExp
        '
        Me.LabelExp.AutoSize = True
        Me.LabelExp.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelExp.ForeColor = System.Drawing.Color.White
        Me.LabelExp.Location = New System.Drawing.Point(77, 13)
        Me.LabelExp.Name = "LabelExp"
        Me.LabelExp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.LabelExp.Size = New System.Drawing.Size(0, 17)
        Me.LabelExp.TabIndex = 8
        Me.LabelExp.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LabelTitle
        '
        Me.LabelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.Location = New System.Drawing.Point(392, 62)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(169, 33)
        Me.LabelTitle.TabIndex = 22
        Me.LabelTitle.Text = "TEACHERS"
        '
        'LabelTotal
        '
        Me.LabelTotal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Enabled = False
        Me.LabelTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotal.Location = New System.Drawing.Point(73, 129)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(46, 20)
        Me.LabelTotal.TabIndex = 23
        Me.LabelTotal.Text = "Total"
        '
        'LabelCounter
        '
        Me.LabelCounter.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelCounter.AutoSize = True
        Me.LabelCounter.Enabled = False
        Me.LabelCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCounter.Location = New System.Drawing.Point(125, 129)
        Me.LabelCounter.Name = "LabelCounter"
        Me.LabelCounter.Size = New System.Drawing.Size(18, 20)
        Me.LabelCounter.TabIndex = 24
        Me.LabelCounter.Text = "0"
        '
        'LabelTeacher
        '
        Me.LabelTeacher.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelTeacher.AutoSize = True
        Me.LabelTeacher.Enabled = False
        Me.LabelTeacher.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTeacher.Location = New System.Drawing.Point(220, 129)
        Me.LabelTeacher.Name = "LabelTeacher"
        Me.LabelTeacher.Size = New System.Drawing.Size(70, 20)
        Me.LabelTeacher.TabIndex = 25
        Me.LabelTeacher.Text = "Teacher"
        '
        'CBoxTeacher
        '
        Me.CBoxTeacher.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CBoxTeacher.FormattingEnabled = True
        Me.CBoxTeacher.Items.AddRange(New Object() {"Engineering", "Administration", "Computer Science", "Philosophy", "Law", "Psychology"})
        Me.CBoxTeacher.Location = New System.Drawing.Point(296, 129)
        Me.CBoxTeacher.Name = "CBoxTeacher"
        Me.CBoxTeacher.Size = New System.Drawing.Size(175, 24)
        Me.CBoxTeacher.TabIndex = 26
        '
        'GridStudents
        '
        Me.GridStudents.AllowUserToAddRows = False
        Me.GridStudents.AllowUserToResizeColumns = False
        Me.GridStudents.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GridStudents.BackgroundColor = System.Drawing.SystemColors.Control
        Me.GridStudents.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridStudents.Location = New System.Drawing.Point(59, 171)
        Me.GridStudents.Name = "GridStudents"
        Me.GridStudents.ReadOnly = True
        Me.GridStudents.RowHeadersWidth = 51
        Me.GridStudents.RowTemplate.Height = 24
        Me.GridStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridStudents.Size = New System.Drawing.Size(839, 151)
        Me.GridStudents.TabIndex = 27
        '
        'LabelId
        '
        Me.LabelId.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelId.AutoSize = True
        Me.LabelId.Enabled = False
        Me.LabelId.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelId.Location = New System.Drawing.Point(73, 349)
        Me.LabelId.Name = "LabelId"
        Me.LabelId.Size = New System.Drawing.Size(26, 20)
        Me.LabelId.TabIndex = 28
        Me.LabelId.Text = "ID"
        '
        'LabelName
        '
        Me.LabelName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelName.AutoSize = True
        Me.LabelName.Enabled = False
        Me.LabelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.Location = New System.Drawing.Point(73, 386)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(53, 20)
        Me.LabelName.TabIndex = 29
        Me.LabelName.Text = "Name"
        '
        'LabelEmail
        '
        Me.LabelEmail.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelEmail.AutoSize = True
        Me.LabelEmail.Enabled = False
        Me.LabelEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEmail.Location = New System.Drawing.Point(73, 424)
        Me.LabelEmail.Name = "LabelEmail"
        Me.LabelEmail.Size = New System.Drawing.Size(51, 20)
        Me.LabelEmail.TabIndex = 30
        Me.LabelEmail.Text = "Email"
        '
        'LabelCity
        '
        Me.LabelCity.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelCity.AutoSize = True
        Me.LabelCity.Enabled = False
        Me.LabelCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCity.Location = New System.Drawing.Point(239, 349)
        Me.LabelCity.Name = "LabelCity"
        Me.LabelCity.Size = New System.Drawing.Size(38, 20)
        Me.LabelCity.TabIndex = 31
        Me.LabelCity.Text = "City"
        '
        'LabelFaculty
        '
        Me.LabelFaculty.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelFaculty.AutoSize = True
        Me.LabelFaculty.Enabled = False
        Me.LabelFaculty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFaculty.Location = New System.Drawing.Point(239, 386)
        Me.LabelFaculty.Name = "LabelFaculty"
        Me.LabelFaculty.Size = New System.Drawing.Size(63, 20)
        Me.LabelFaculty.TabIndex = 32
        Me.LabelFaculty.Text = "Faculty"
        '
        'LabelSubject
        '
        Me.LabelSubject.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelSubject.AutoSize = True
        Me.LabelSubject.Enabled = False
        Me.LabelSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSubject.Location = New System.Drawing.Point(239, 424)
        Me.LabelSubject.Name = "LabelSubject"
        Me.LabelSubject.Size = New System.Drawing.Size(65, 20)
        Me.LabelSubject.TabIndex = 33
        Me.LabelSubject.Text = "Subject"
        '
        'LabelType
        '
        Me.LabelType.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelType.AutoSize = True
        Me.LabelType.Enabled = False
        Me.LabelType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelType.Location = New System.Drawing.Point(433, 349)
        Me.LabelType.Name = "LabelType"
        Me.LabelType.Size = New System.Drawing.Size(45, 20)
        Me.LabelType.TabIndex = 34
        Me.LabelType.Text = "Type"
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonDelete.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.ButtonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.ForeColor = System.Drawing.Color.White
        Me.ButtonDelete.Location = New System.Drawing.Point(834, 13)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(109, 45)
        Me.ButtonDelete.TabIndex = 10
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'Teachers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 535)
        Me.Controls.Add(Me.LabelType)
        Me.Controls.Add(Me.LabelSubject)
        Me.Controls.Add(Me.LabelFaculty)
        Me.Controls.Add(Me.LabelCity)
        Me.Controls.Add(Me.LabelEmail)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.LabelId)
        Me.Controls.Add(Me.GridStudents)
        Me.Controls.Add(Me.CBoxTeacher)
        Me.Controls.Add(Me.LabelTeacher)
        Me.Controls.Add(Me.LabelCounter)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.PanelBottom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Teachers"
        Me.Text = "Teachers"
        Me.PanelBottom.ResumeLayout(False)
        Me.PanelBottom.PerformLayout()
        CType(Me.GridStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelBottom As Panel
    Friend WithEvents LabelExp As Label
    Friend WithEvents LabelTitle As Label
    Friend WithEvents LabelTotal As Label
    Friend WithEvents LabelCounter As Label
    Friend WithEvents LabelTeacher As Label
    Friend WithEvents CBoxTeacher As ComboBox
    Friend WithEvents GridStudents As DataGridView
    Friend WithEvents LabelId As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents LabelEmail As Label
    Friend WithEvents LabelCity As Label
    Friend WithEvents LabelFaculty As Label
    Friend WithEvents LabelSubject As Label
    Friend WithEvents LabelType As Label
    Friend WithEvents ButtonDelete As Button
End Class
