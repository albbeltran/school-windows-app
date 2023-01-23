<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Subjects
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.GridSubjects = New System.Windows.Forms.DataGridView()
        Me.LabelCounter = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.semestre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.facultad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelBottom.SuspendLayout()
        CType(Me.GridSubjects, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelTitle
        '
        Me.LabelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.Location = New System.Drawing.Point(406, 56)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(164, 33)
        Me.LabelTitle.TabIndex = 0
        Me.LabelTitle.Text = "SUBJECTS"
        '
        'TxtID
        '
        Me.TxtID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtID.Location = New System.Drawing.Point(89, 116)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(100, 22)
        Me.TxtID.TabIndex = 1
        Me.TxtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelID
        '
        Me.LabelID.Anchor = System.Windows.Forms.AnchorStyles.Top
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
        Me.LabelName.Anchor = System.Windows.Forms.AnchorStyles.Top
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
        Me.TxtName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtName.Location = New System.Drawing.Point(332, 114)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(249, 22)
        Me.TxtName.TabIndex = 4
        Me.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelSemester
        '
        Me.LabelSemester.Anchor = System.Windows.Forms.AnchorStyles.Top
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
        Me.CBoxSemester.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CBoxSemester.FormattingEnabled = True
        Me.CBoxSemester.Items.AddRange(New Object() {"1. Semester", "2. Semester", "3. Semester", "4. Semester", "5. Semester", "6. Semester", "7. Semester", "8. Semester", "9. Semester"})
        Me.CBoxSemester.Location = New System.Drawing.Point(744, 114)
        Me.CBoxSemester.Name = "CBoxSemester"
        Me.CBoxSemester.Size = New System.Drawing.Size(185, 24)
        Me.CBoxSemester.TabIndex = 8
        '
        'LabelDescription
        '
        Me.LabelDescription.Anchor = System.Windows.Forms.AnchorStyles.Top
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
        Me.TxtDescription.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtDescription.Location = New System.Drawing.Point(156, 174)
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(249, 22)
        Me.TxtDescription.TabIndex = 9
        Me.TxtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBoxFaculty
        '
        Me.CBoxFaculty.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CBoxFaculty.FormattingEnabled = True
        Me.CBoxFaculty.Items.AddRange(New Object() {"Engineering", "Administration", "Computer Science", "Philosophy", "Law", "Psychology"})
        Me.CBoxFaculty.Location = New System.Drawing.Point(546, 172)
        Me.CBoxFaculty.Name = "CBoxFaculty"
        Me.CBoxFaculty.Size = New System.Drawing.Size(175, 24)
        Me.CBoxFaculty.TabIndex = 12
        '
        'LabelFaculty
        '
        Me.LabelFaculty.Anchor = System.Windows.Forms.AnchorStyles.Top
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
        Me.ButtonDelete.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonDelete.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.ButtonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.ForeColor = System.Drawing.Color.White
        Me.ButtonDelete.Location = New System.Drawing.Point(609, 13)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(109, 45)
        Me.ButtonDelete.TabIndex = 2
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'ButtonClear
        '
        Me.ButtonClear.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonClear.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.ButtonClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ButtonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonClear.ForeColor = System.Drawing.Color.White
        Me.ButtonClear.Location = New System.Drawing.Point(736, 13)
        Me.ButtonClear.Name = "ButtonClear"
        Me.ButtonClear.Size = New System.Drawing.Size(109, 45)
        Me.ButtonClear.TabIndex = 1
        Me.ButtonClear.Text = "Clear"
        Me.ButtonClear.UseVisualStyleBackColor = True
        '
        'ButtonEnter
        '
        Me.ButtonEnter.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonEnter.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.ButtonEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ButtonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEnter.ForeColor = System.Drawing.Color.White
        Me.ButtonEnter.Location = New System.Drawing.Point(861, 13)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(109, 45)
        Me.ButtonEnter.TabIndex = 0
        Me.ButtonEnter.Text = "Enter"
        Me.ButtonEnter.UseVisualStyleBackColor = True
        '
        'GridSubjects
        '
        Me.GridSubjects.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GridSubjects.BackgroundColor = System.Drawing.SystemColors.Control
        Me.GridSubjects.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridSubjects.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nombre, Me.semestre, Me.descripcion, Me.facultad})
        Me.GridSubjects.Location = New System.Drawing.Point(61, 296)
        Me.GridSubjects.Name = "GridSubjects"
        Me.GridSubjects.RowHeadersWidth = 51
        Me.GridSubjects.RowTemplate.Height = 24
        Me.GridSubjects.Size = New System.Drawing.Size(868, 150)
        Me.GridSubjects.TabIndex = 16
        '
        'LabelCounter
        '
        Me.LabelCounter.AutoSize = True
        Me.LabelCounter.Enabled = False
        Me.LabelCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCounter.Location = New System.Drawing.Point(126, 234)
        Me.LabelCounter.Name = "LabelCounter"
        Me.LabelCounter.Size = New System.Drawing.Size(18, 20)
        Me.LabelCounter.TabIndex = 20
        Me.LabelCounter.Text = "0"
        '
        'LabelTotal
        '
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Enabled = False
        Me.LabelTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotal.Location = New System.Drawing.Point(57, 234)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(46, 20)
        Me.LabelTotal.TabIndex = 19
        Me.LabelTotal.Text = "Total"
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.MinimumWidth = 6
        Me.id.Name = "id"
        Me.id.Width = 125
        '
        'nombre
        '
        Me.nombre.HeaderText = "Name"
        Me.nombre.MinimumWidth = 6
        Me.nombre.Name = "nombre"
        Me.nombre.Width = 125
        '
        'semestre
        '
        Me.semestre.HeaderText = "Semester"
        Me.semestre.MinimumWidth = 6
        Me.semestre.Name = "semestre"
        Me.semestre.Width = 125
        '
        'descripcion
        '
        Me.descripcion.HeaderText = "Description"
        Me.descripcion.MinimumWidth = 6
        Me.descripcion.Name = "descripcion"
        Me.descripcion.Width = 125
        '
        'facultad
        '
        Me.facultad.HeaderText = "Faculty"
        Me.facultad.MinimumWidth = 6
        Me.facultad.Name = "facultad"
        Me.facultad.Width = 125
        '
        'Subjects
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(982, 553)
        Me.Controls.Add(Me.LabelCounter)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.GridSubjects)
        Me.Controls.Add(Me.PanelBottom)
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
        Me.PanelBottom.ResumeLayout(False)
        CType(Me.GridSubjects, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PanelBottom As Panel
    Friend WithEvents ButtonEnter As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents GridSubjects As DataGridView
    Friend WithEvents LabelCounter As Label
    Friend WithEvents LabelTotal As Label
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents nombre As DataGridViewTextBoxColumn
    Friend WithEvents semestre As DataGridViewTextBoxColumn
    Friend WithEvents descripcion As DataGridViewTextBoxColumn
    Friend WithEvents facultad As DataGridViewTextBoxColumn
End Class
