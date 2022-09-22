<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Subjects
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
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.LabelSemester = New System.Windows.Forms.Label()
        Me.CBoxSemester = New System.Windows.Forms.ComboBox()
        Me.LabelDescription = New System.Windows.Forms.Label()
        Me.TxtDescription = New System.Windows.Forms.TextBox()
        Me.CBoxFaculty = New System.Windows.Forms.ComboBox()
        Me.LabelFaculty = New System.Windows.Forms.Label()
        Me.GridSubjects = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Semester = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Faculty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        CType(Me.GridSubjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Perpetua Titling MT", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.Location = New System.Drawing.Point(403, 32)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(142, 33)
        Me.LabelTitle.TabIndex = 0
        Me.LabelTitle.Text = "SUBJECTS"
        '
        'TxtID
        '
        Me.TxtID.Location = New System.Drawing.Point(89, 116)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(100, 22)
        Me.TxtID.TabIndex = 1
        Me.TxtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelID
        '
        Me.LabelID.AutoSize = True
        Me.LabelID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelID.Location = New System.Drawing.Point(57, 116)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(26, 20)
        Me.LabelID.TabIndex = 3
        Me.LabelID.Text = "ID"
        '
        'LabelName
        '
        Me.LabelName.AutoSize = True
        Me.LabelName.Enabled = False
        Me.LabelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.Location = New System.Drawing.Point(273, 116)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(53, 20)
        Me.LabelName.TabIndex = 5
        Me.LabelName.Text = "Name"
        '
        'TxtName
        '
        Me.TxtName.Location = New System.Drawing.Point(332, 114)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(249, 22)
        Me.TxtName.TabIndex = 4
        Me.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelSemester
        '
        Me.LabelSemester.AutoSize = True
        Me.LabelSemester.Enabled = False
        Me.LabelSemester.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSemester.Location = New System.Drawing.Point(657, 114)
        Me.LabelSemester.Name = "LabelSemester"
        Me.LabelSemester.Size = New System.Drawing.Size(81, 20)
        Me.LabelSemester.TabIndex = 7
        Me.LabelSemester.Text = "Semester"
        Me.LabelSemester.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CBoxSemester
        '
        Me.CBoxSemester.FormattingEnabled = True
        Me.CBoxSemester.Items.AddRange(New Object() {"1. Semester", "2. Semester", "3. Semester", "4. Semester", "5. Semester", "6. Semester", "7. Semester", "8. Semester", "9. Semester"})
        Me.CBoxSemester.Location = New System.Drawing.Point(744, 114)
        Me.CBoxSemester.Name = "CBoxSemester"
        Me.CBoxSemester.Size = New System.Drawing.Size(185, 24)
        Me.CBoxSemester.TabIndex = 8
        '
        'LabelDescription
        '
        Me.LabelDescription.AutoSize = True
        Me.LabelDescription.Enabled = False
        Me.LabelDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDescription.Location = New System.Drawing.Point(55, 174)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.Size = New System.Drawing.Size(95, 20)
        Me.LabelDescription.TabIndex = 10
        Me.LabelDescription.Text = "Description"
        '
        'TxtDescription
        '
        Me.TxtDescription.Location = New System.Drawing.Point(156, 174)
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(249, 22)
        Me.TxtDescription.TabIndex = 9
        Me.TxtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBoxFaculty
        '
        Me.CBoxFaculty.FormattingEnabled = True
        Me.CBoxFaculty.Items.AddRange(New Object() {"Engineering", "Administration", "Computer Science", "Philosophy", "Law", "Psychology"})
        Me.CBoxFaculty.Location = New System.Drawing.Point(546, 172)
        Me.CBoxFaculty.Name = "CBoxFaculty"
        Me.CBoxFaculty.Size = New System.Drawing.Size(175, 24)
        Me.CBoxFaculty.TabIndex = 12
        '
        'LabelFaculty
        '
        Me.LabelFaculty.AutoSize = True
        Me.LabelFaculty.Enabled = False
        Me.LabelFaculty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFaculty.Location = New System.Drawing.Point(477, 172)
        Me.LabelFaculty.Name = "LabelFaculty"
        Me.LabelFaculty.Size = New System.Drawing.Size(63, 20)
        Me.LabelFaculty.TabIndex = 11
        Me.LabelFaculty.Text = "Faculty"
        Me.LabelFaculty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GridSubjects
        '
        Me.GridSubjects.AllowUserToAddRows = False
        Me.GridSubjects.BackgroundColor = System.Drawing.SystemColors.Control
        Me.GridSubjects.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridSubjects.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Name, Me.Semester, Me.Description, Me.Faculty})
        Me.GridSubjects.Location = New System.Drawing.Point(61, 265)
        Me.GridSubjects.Name = "GridSubjects"
        Me.GridSubjects.ReadOnly = True
        Me.GridSubjects.RowHeadersWidth = 51
        Me.GridSubjects.RowTemplate.Height = 24
        Me.GridSubjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridSubjects.Size = New System.Drawing.Size(868, 185)
        Me.GridSubjects.TabIndex = 13
        '
        'ID
        '
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Width = 125
        '
        'Name
        '
        Me.Name.HeaderText = "Name"
        Me.Name.MinimumWidth = 6
        Me.Name.Name = "Name"
        Me.Name.ReadOnly = True
        Me.Name.Width = 125
        '
        'Semester
        '
        Me.Semester.HeaderText = "Semester"
        Me.Semester.MinimumWidth = 6
        Me.Semester.Name = "Semester"
        Me.Semester.ReadOnly = True
        Me.Semester.Width = 125
        '
        'Description
        '
        Me.Description.HeaderText = "Description"
        Me.Description.MinimumWidth = 6
        Me.Description.Name = "Description"
        Me.Description.ReadOnly = True
        Me.Description.Width = 125
        '
        'Faculty
        '
        Me.Faculty.HeaderText = "Faculty"
        Me.Faculty.MinimumWidth = 6
        Me.Faculty.Name = "Faculty"
        Me.Faculty.ReadOnly = True
        Me.Faculty.Width = 125
        '
        'PanelBottom
        '
        Me.PanelBottom.BackColor = System.Drawing.Color.Black
        Me.PanelBottom.Controls.Add(Me.ButtonDelete)
        Me.PanelBottom.Controls.Add(Me.ButtonClear)
        Me.PanelBottom.Controls.Add(Me.ButtonEnter)
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBottom.Location = New System.Drawing.Point(0, 483)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(982, 70)
        Me.PanelBottom.TabIndex = 14
        '
        'ButtonDelete
        '
        Me.ButtonDelete.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.ButtonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.ForeColor = System.Drawing.Color.White
        Me.ButtonDelete.Location = New System.Drawing.Point(581, 13)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(109, 45)
        Me.ButtonDelete.TabIndex = 2
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.ButtonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClear.ForeColor = System.Drawing.Color.White
        Me.ButtonClear.Location = New System.Drawing.Point(713, 13)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(109, 45)
        Me.ButtonClear.TabIndex = 1
        Me.ButtonClear.Text = "Enter"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonEnter
        '
        Me.ButtonEnter.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.ButtonEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ButtonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEnter.ForeColor = System.Drawing.Color.White
        Me.ButtonEnter.Location = New System.Drawing.Point(842, 13)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(109, 45)
        Me.ButtonEnter.TabIndex = 0
        Me.ButtonEnter.Text = "Enter"
        Me.ButtonEnter.UseVisualStyleBackColor = True
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(59, 223)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(91, 22)
        Me.TxtTotal.TabIndex = 15
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Subjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 553)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.PanelBottom)
        Me.Controls.Add(Me.GridSubjects)
        Me.Controls.Add(Me.CBoxFaculty)
        Me.Controls.Add(Me.LabelFaculty)
        Me.Controls.Add(Me.LabelDescription)
        Me.Controls.Add(Me.TxtDescription)
        Me.Controls.Add(Me.CBoxSemester)
        Me.Controls.Add(Me.LabelSemester)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.LabelID)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.LabelTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Subjects"
        Me.Text = "Subjects"
        CType(Me.GridSubjects, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBottom.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTitle As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents LabelID As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents LabelSemester As Label
    Friend WithEvents CBoxSemester As ComboBox
    Friend WithEvents LabelDescription As Label
    Friend WithEvents TxtDescription As TextBox
    Friend WithEvents CBoxFaculty As ComboBox
    Friend WithEvents LabelFaculty As Label
    Friend WithEvents GridSubjects As DataGridView
    Friend WithEvents PanelBottom As Panel
    Friend WithEvents ButtonEnter As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Name As DataGridViewTextBoxColumn
    Friend WithEvents Semester As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents Faculty As DataGridViewTextBoxColumn
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents TxtTotal As TextBox
End Class
