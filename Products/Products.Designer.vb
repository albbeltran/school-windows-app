<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Products
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
        Me.CBoxLaboratory = New System.Windows.Forms.ComboBox()
        Me.LabelFaculty = New System.Windows.Forms.Label()
        Me.LabelDescription = New System.Windows.Forms.Label()
        Me.TxtDescription = New System.Windows.Forms.TextBox()
        Me.CBoxSemester = New System.Windows.Forms.ComboBox()
        Me.LabelSemester = New System.Windows.Forms.Label()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LabelCounter = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.GridProducts = New System.Windows.Forms.DataGridView()
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.LabelExp = New System.Windows.Forms.Label()
        CType(Me.GridProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelTitle
        '
        Me.LabelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Perpetua Titling MT", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.Location = New System.Drawing.Point(408, 59)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(192, 33)
        Me.LabelTitle.TabIndex = 1
        Me.LabelTitle.Text = "PRODUCTOS"
        '
        'CBoxLaboratory
        '
        Me.CBoxLaboratory.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CBoxLaboratory.FormattingEnabled = True
        Me.CBoxLaboratory.Items.AddRange(New Object() {"Palmolive", "Natura", "Nivea"})
        Me.CBoxLaboratory.Location = New System.Drawing.Point(185, 182)
        Me.CBoxLaboratory.Name = "CBoxLaboratory"
        Me.CBoxLaboratory.Size = New System.Drawing.Size(175, 24)
        Me.CBoxLaboratory.TabIndex = 25
        '
        'LabelFaculty
        '
        Me.LabelFaculty.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelFaculty.AutoSize = True
        Me.LabelFaculty.Enabled = False
        Me.LabelFaculty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFaculty.Location = New System.Drawing.Point(90, 182)
        Me.LabelFaculty.Name = "LabelFaculty"
        Me.LabelFaculty.Size = New System.Drawing.Size(89, 20)
        Me.LabelFaculty.TabIndex = 24
        Me.LabelFaculty.Text = "Laboratory"
        Me.LabelFaculty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelDescription
        '
        Me.LabelDescription.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelDescription.AutoSize = True
        Me.LabelDescription.Enabled = False
        Me.LabelDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDescription.Location = New System.Drawing.Point(441, 182)
        Me.LabelDescription.Name = "LabelDescription"
        Me.LabelDescription.Size = New System.Drawing.Size(88, 20)
        Me.LabelDescription.TabIndex = 23
        Me.LabelDescription.Text = "Price Cost"
        '
        'TxtDescription
        '
        Me.TxtDescription.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtDescription.Location = New System.Drawing.Point(542, 182)
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(113, 22)
        Me.TxtDescription.TabIndex = 22
        Me.TxtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBoxSemester
        '
        Me.CBoxSemester.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CBoxSemester.FormattingEnabled = True
        Me.CBoxSemester.Items.AddRange(New Object() {"1. Semester", "2. Semester", "3. Semester", "4. Semester", "5. Semester", "6. Semester", "7. Semester", "8. Semester", "9. Semester"})
        Me.CBoxSemester.Location = New System.Drawing.Point(759, 125)
        Me.CBoxSemester.Name = "CBoxSemester"
        Me.CBoxSemester.Size = New System.Drawing.Size(185, 24)
        Me.CBoxSemester.TabIndex = 21
        '
        'LabelSemester
        '
        Me.LabelSemester.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelSemester.AutoSize = True
        Me.LabelSemester.Enabled = False
        Me.LabelSemester.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSemester.Location = New System.Drawing.Point(700, 125)
        Me.LabelSemester.Name = "LabelSemester"
        Me.LabelSemester.Size = New System.Drawing.Size(53, 20)
        Me.LabelSemester.TabIndex = 20
        Me.LabelSemester.Text = "Name"
        Me.LabelSemester.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelName
        '
        Me.LabelName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelName.AutoSize = True
        Me.LabelName.Enabled = False
        Me.LabelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.Location = New System.Drawing.Point(290, 125)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(91, 20)
        Me.LabelName.TabIndex = 19
        Me.LabelName.Text = "No. Invoice"
        '
        'TxtName
        '
        Me.TxtName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtName.Location = New System.Drawing.Point(387, 125)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(249, 22)
        Me.TxtName.TabIndex = 18
        Me.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelID
        '
        Me.LabelID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelID.AutoSize = True
        Me.LabelID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelID.Location = New System.Drawing.Point(89, 127)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(26, 20)
        Me.LabelID.TabIndex = 17
        Me.LabelID.Text = "ID"
        '
        'TxtID
        '
        Me.TxtID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtID.Location = New System.Drawing.Point(121, 127)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(100, 22)
        Me.TxtID.TabIndex = 16
        Me.TxtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(730, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Price Cost"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TextBox1.Location = New System.Drawing.Point(831, 182)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(113, 22)
        Me.TextBox1.TabIndex = 27
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelCounter
        '
        Me.LabelCounter.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelCounter.AutoSize = True
        Me.LabelCounter.Enabled = False
        Me.LabelCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCounter.Location = New System.Drawing.Point(158, 241)
        Me.LabelCounter.Name = "LabelCounter"
        Me.LabelCounter.Size = New System.Drawing.Size(18, 20)
        Me.LabelCounter.TabIndex = 30
        Me.LabelCounter.Text = "0"
        '
        'LabelTotal
        '
        Me.LabelTotal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Enabled = False
        Me.LabelTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotal.Location = New System.Drawing.Point(89, 241)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(46, 20)
        Me.LabelTotal.TabIndex = 29
        Me.LabelTotal.Text = "Total"
        '
        'GridProducts
        '
        Me.GridProducts.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.GridProducts.AllowUserToAddRows = False
        Me.GridProducts.AllowUserToResizeColumns = False
        Me.GridProducts.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GridProducts.BackgroundColor = System.Drawing.SystemColors.Control
        Me.GridProducts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridProducts.Location = New System.Drawing.Point(93, 301)
        Me.GridProducts.Name = "GridProducts"
        Me.GridProducts.RowHeadersWidth = 51
        Me.GridProducts.RowTemplate.Height = 24
        Me.GridProducts.Size = New System.Drawing.Size(850, 150)
        Me.GridProducts.TabIndex = 31
        '
        'PanelBottom
        '
        Me.PanelBottom.BackColor = System.Drawing.Color.Black
        Me.PanelBottom.Controls.Add(Me.ButtonEnter)
        Me.PanelBottom.Controls.Add(Me.LabelExp)
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBottom.Location = New System.Drawing.Point(0, 465)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(1031, 70)
        Me.PanelBottom.TabIndex = 32
        '
        'ButtonEnter
        '
        Me.ButtonEnter.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonEnter.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.ButtonEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ButtonEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEnter.ForeColor = System.Drawing.Color.White
        Me.ButtonEnter.Location = New System.Drawing.Point(835, 13)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(109, 45)
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
        'Products
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 535)
        Me.Controls.Add(Me.PanelBottom)
        Me.Controls.Add(Me.GridProducts)
        Me.Controls.Add(Me.LabelCounter)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.CBoxLaboratory)
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
        Me.Name = "Products"
        Me.Text = "Products"
        CType(Me.GridProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBottom.ResumeLayout(False)
        Me.PanelBottom.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTitle As Label
    Friend WithEvents CBoxLaboratory As ComboBox
    Friend WithEvents LabelFaculty As Label
    Friend WithEvents LabelDescription As Label
    Friend WithEvents TxtDescription As TextBox
    Friend WithEvents CBoxSemester As ComboBox
    Friend WithEvents LabelSemester As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents LabelID As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LabelCounter As Label
    Friend WithEvents LabelTotal As Label
    Friend WithEvents GridProducts As DataGridView
    Friend WithEvents PanelBottom As Panel
    Friend WithEvents ButtonEnter As Button
    Friend WithEvents LabelExp As Label
End Class
