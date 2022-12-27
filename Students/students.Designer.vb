<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Students
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
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.LabelExp = New System.Windows.Forms.Label()
        Me.GridStudents = New System.Windows.Forms.DataGridView()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.LabelCounter = New System.Windows.Forms.Label()
        Me.LabelFaculty = New System.Windows.Forms.Label()
        Me.CBoxFaculty = New System.Windows.Forms.ComboBox()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.PanelBottom.SuspendLayout()
        CType(Me.GridStudents, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelBottom
        '
        Me.PanelBottom.BackColor = System.Drawing.Color.Black
        Me.PanelBottom.Controls.Add(Me.ButtonEnter)
        Me.PanelBottom.Controls.Add(Me.LabelExp)
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBottom.Location = New System.Drawing.Point(0, 423)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(861, 70)
        Me.PanelBottom.TabIndex = 12
        '
        'ButtonEnter
        '
        Me.ButtonEnter.Dock = System.Windows.Forms.DockStyle.Right
        Me.ButtonEnter.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.ButtonEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ButtonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEnter.ForeColor = System.Drawing.Color.White
        Me.ButtonEnter.Location = New System.Drawing.Point(752, 0)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(109, 70)
        Me.ButtonEnter.TabIndex = 0
        Me.ButtonEnter.Text = "Enter"
        Me.ButtonEnter.UseVisualStyleBackColor = True
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
        'GridStudents
        '
        Me.GridStudents.AllowUserToAddRows = False
        Me.GridStudents.AllowUserToResizeColumns = False
        Me.GridStudents.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GridStudents.BackgroundColor = System.Drawing.SystemColors.Control
        Me.GridStudents.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridStudents.Location = New System.Drawing.Point(39, 174)
        Me.GridStudents.Name = "GridStudents"
        Me.GridStudents.ReadOnly = True
        Me.GridStudents.RowHeadersWidth = 51
        Me.GridStudents.RowTemplate.Height = 24
        Me.GridStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridStudents.Size = New System.Drawing.Size(779, 185)
        Me.GridStudents.TabIndex = 14
        '
        'LabelTotal
        '
        Me.LabelTotal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Enabled = False
        Me.LabelTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotal.Location = New System.Drawing.Point(35, 146)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(46, 20)
        Me.LabelTotal.TabIndex = 17
        Me.LabelTotal.Text = "Total"
        '
        'LabelCounter
        '
        Me.LabelCounter.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelCounter.AutoSize = True
        Me.LabelCounter.Enabled = False
        Me.LabelCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCounter.Location = New System.Drawing.Point(104, 146)
        Me.LabelCounter.Name = "LabelCounter"
        Me.LabelCounter.Size = New System.Drawing.Size(18, 20)
        Me.LabelCounter.TabIndex = 18
        Me.LabelCounter.Text = "0"
        '
        'LabelFaculty
        '
        Me.LabelFaculty.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelFaculty.AutoSize = True
        Me.LabelFaculty.Enabled = False
        Me.LabelFaculty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFaculty.Location = New System.Drawing.Point(207, 146)
        Me.LabelFaculty.Name = "LabelFaculty"
        Me.LabelFaculty.Size = New System.Drawing.Size(63, 20)
        Me.LabelFaculty.TabIndex = 19
        Me.LabelFaculty.Text = "Faculty"
        '
        'CBoxFaculty
        '
        Me.CBoxFaculty.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CBoxFaculty.FormattingEnabled = True
        Me.CBoxFaculty.Items.AddRange(New Object() {"Engineering", "Administration", "Computer Science", "Philosophy", "Law", "Psychology"})
        Me.CBoxFaculty.Location = New System.Drawing.Point(287, 144)
        Me.CBoxFaculty.Name = "CBoxFaculty"
        Me.CBoxFaculty.Size = New System.Drawing.Size(175, 24)
        Me.CBoxFaculty.TabIndex = 20
        '
        'LabelTitle
        '
        Me.LabelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Perpetua Titling MT", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.Location = New System.Drawing.Point(361, 56)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(160, 33)
        Me.LabelTitle.TabIndex = 21
        Me.LabelTitle.Text = "STUDENTS"
        '
        'Students
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 493)
        Me.Controls.Add(Me.LabelTitle)
        Me.Controls.Add(Me.CBoxFaculty)
        Me.Controls.Add(Me.LabelFaculty)
        Me.Controls.Add(Me.LabelCounter)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.GridStudents)
        Me.Controls.Add(Me.PanelBottom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Students"
        Me.Text = "Students"
        Me.PanelBottom.ResumeLayout(False)
        Me.PanelBottom.PerformLayout()
        CType(Me.GridStudents, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PanelBottom As Panel
    Friend WithEvents ButtonEnter As Button
    Friend WithEvents LabelExp As Label
    Friend WithEvents GridStudents As DataGridView
    Friend WithEvents LabelTotal As Label
    Friend WithEvents LabelCounter As Label
    Friend WithEvents LabelFaculty As Label
    Friend WithEvents CBoxFaculty As ComboBox
    Friend WithEvents LabelTitle As Label
End Class
