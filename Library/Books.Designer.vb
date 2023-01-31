<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Books
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
        Me.GridBooks = New System.Windows.Forms.DataGridView()
        Me.LabelCounter = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDescription2 = New System.Windows.Forms.TextBox()
        Me.CBoxBranch = New System.Windows.Forms.ComboBox()
        Me.LabelFaculty = New System.Windows.Forms.Label()
        Me.LabelSemester = New System.Windows.Forms.Label()
        Me.LabelName = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.TxtInvoice = New System.Windows.Forms.TextBox()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.TxtAuthor = New System.Windows.Forms.TextBox()
        CType(Me.GridBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridBooks
        '
        Me.GridBooks.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.GridBooks.AllowUserToAddRows = False
        Me.GridBooks.AllowUserToDeleteRows = False
        Me.GridBooks.AllowUserToResizeColumns = False
        Me.GridBooks.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GridBooks.BackgroundColor = System.Drawing.SystemColors.Control
        Me.GridBooks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridBooks.Location = New System.Drawing.Point(93, 297)
        Me.GridBooks.Name = "GridBooks"
        Me.GridBooks.ReadOnly = True
        Me.GridBooks.RowHeadersWidth = 51
        Me.GridBooks.RowTemplate.Height = 24
        Me.GridBooks.Size = New System.Drawing.Size(850, 150)
        Me.GridBooks.TabIndex = 47
        '
        'LabelCounter
        '
        Me.LabelCounter.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelCounter.AutoSize = True
        Me.LabelCounter.Enabled = False
        Me.LabelCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCounter.Location = New System.Drawing.Point(157, 254)
        Me.LabelCounter.Name = "LabelCounter"
        Me.LabelCounter.Size = New System.Drawing.Size(18, 20)
        Me.LabelCounter.TabIndex = 46
        Me.LabelCounter.Text = "0"
        '
        'LabelTotal
        '
        Me.LabelTotal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Enabled = False
        Me.LabelTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotal.Location = New System.Drawing.Point(88, 254)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(46, 20)
        Me.LabelTotal.TabIndex = 45
        Me.LabelTotal.Text = "Total"
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 20)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Description"
        '
        'TxtDescription2
        '
        Me.TxtDescription2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtDescription2.Location = New System.Drawing.Point(187, 198)
        Me.TxtDescription2.Name = "TxtDescription2"
        Me.TxtDescription2.Size = New System.Drawing.Size(389, 22)
        Me.TxtDescription2.TabIndex = 43
        Me.TxtDescription2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBoxBranch
        '
        Me.CBoxBranch.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CBoxBranch.FormattingEnabled = True
        Me.CBoxBranch.Items.AddRange(New Object() {"Garibaldi", "Donceles", "Insurgentes", "Hidalgo"})
        Me.CBoxBranch.Location = New System.Drawing.Point(752, 198)
        Me.CBoxBranch.Name = "CBoxBranch"
        Me.CBoxBranch.Size = New System.Drawing.Size(191, 24)
        Me.CBoxBranch.TabIndex = 42
        '
        'LabelFaculty
        '
        Me.LabelFaculty.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelFaculty.AutoSize = True
        Me.LabelFaculty.Enabled = False
        Me.LabelFaculty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFaculty.Location = New System.Drawing.Point(683, 202)
        Me.LabelFaculty.Name = "LabelFaculty"
        Me.LabelFaculty.Size = New System.Drawing.Size(63, 20)
        Me.LabelFaculty.TabIndex = 41
        Me.LabelFaculty.Text = "Branch"
        Me.LabelFaculty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelSemester
        '
        Me.LabelSemester.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelSemester.AutoSize = True
        Me.LabelSemester.Enabled = False
        Me.LabelSemester.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSemester.Location = New System.Drawing.Point(683, 136)
        Me.LabelSemester.Name = "LabelSemester"
        Me.LabelSemester.Size = New System.Drawing.Size(53, 20)
        Me.LabelSemester.TabIndex = 37
        Me.LabelSemester.Text = "Name"
        Me.LabelSemester.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelName
        '
        Me.LabelName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelName.AutoSize = True
        Me.LabelName.Enabled = False
        Me.LabelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelName.Location = New System.Drawing.Point(337, 140)
        Me.LabelName.Name = "LabelName"
        Me.LabelName.Size = New System.Drawing.Size(58, 20)
        Me.LabelName.TabIndex = 36
        Me.LabelName.Text = "Author"
        '
        'TxtName
        '
        Me.TxtName.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtName.Location = New System.Drawing.Point(753, 134)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(190, 22)
        Me.TxtName.TabIndex = 35
        Me.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelID
        '
        Me.LabelID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelID.AutoSize = True
        Me.LabelID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelID.Location = New System.Drawing.Point(88, 140)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(61, 20)
        Me.LabelID.TabIndex = 34
        Me.LabelID.Text = "Invoice"
        '
        'TxtInvoice
        '
        Me.TxtInvoice.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtInvoice.Location = New System.Drawing.Point(155, 140)
        Me.TxtInvoice.Name = "TxtInvoice"
        Me.TxtInvoice.Size = New System.Drawing.Size(100, 22)
        Me.TxtInvoice.TabIndex = 33
        Me.TxtInvoice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelTitle
        '
        Me.LabelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.Location = New System.Drawing.Point(428, 71)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(115, 33)
        Me.LabelTitle.TabIndex = 32
        Me.LabelTitle.Text = "BOOKS"
        '
        'PanelBottom
        '
        Me.PanelBottom.BackColor = System.Drawing.Color.Black
        Me.PanelBottom.Controls.Add(Me.ButtonUpdate)
        Me.PanelBottom.Controls.Add(Me.ButtonDelete)
        Me.PanelBottom.Controls.Add(Me.ButtonClear)
        Me.PanelBottom.Controls.Add(Me.ButtonEnter)
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBottom.Location = New System.Drawing.Point(0, 465)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(1031, 70)
        Me.PanelBottom.TabIndex = 48
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.ButtonUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUpdate.ForeColor = System.Drawing.Color.White
        Me.ButtonUpdate.Location = New System.Drawing.Point(531, 13)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(109, 45)
        Me.ButtonUpdate.TabIndex = 4
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonDelete.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.ButtonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonDelete.ForeColor = System.Drawing.Color.White
        Me.ButtonDelete.Location = New System.Drawing.Point(658, 13)
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
        Me.ButtonClear.Location = New System.Drawing.Point(785, 13)
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
        Me.ButtonEnter.Location = New System.Drawing.Point(910, 13)
        Me.ButtonEnter.Name = "ButtonEnter"
        Me.ButtonEnter.Size = New System.Drawing.Size(109, 45)
        Me.ButtonEnter.TabIndex = 0
        Me.ButtonEnter.Text = "Enter"
        Me.ButtonEnter.UseVisualStyleBackColor = True
        '
        'TxtAuthor
        '
        Me.TxtAuthor.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtAuthor.Location = New System.Drawing.Point(405, 140)
        Me.TxtAuthor.Name = "TxtAuthor"
        Me.TxtAuthor.Size = New System.Drawing.Size(190, 22)
        Me.TxtAuthor.TabIndex = 49
        Me.TxtAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Books
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 535)
        Me.Controls.Add(Me.TxtAuthor)
        Me.Controls.Add(Me.PanelBottom)
        Me.Controls.Add(Me.GridBooks)
        Me.Controls.Add(Me.LabelCounter)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtDescription2)
        Me.Controls.Add(Me.CBoxBranch)
        Me.Controls.Add(Me.LabelFaculty)
        Me.Controls.Add(Me.LabelSemester)
        Me.Controls.Add(Me.LabelName)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.LabelID)
        Me.Controls.Add(Me.TxtInvoice)
        Me.Controls.Add(Me.LabelTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Books"
        Me.Text = "Books"
        CType(Me.GridBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBottom.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GridBooks As DataGridView
    Friend WithEvents LabelCounter As Label
    Friend WithEvents LabelTotal As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtDescription2 As TextBox
    Friend WithEvents CBoxBranch As ComboBox
    Friend WithEvents LabelFaculty As Label
    Friend WithEvents LabelSemester As Label
    Friend WithEvents LabelName As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents LabelID As Label
    Friend WithEvents TxtInvoice As TextBox
    Friend WithEvents LabelTitle As Label
    Friend WithEvents PanelBottom As Panel
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonEnter As Button
    Friend WithEvents TxtAuthor As TextBox
    Friend WithEvents ButtonUpdate As Button
End Class
