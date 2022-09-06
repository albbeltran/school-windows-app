<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Students
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
        Me.LabelParcial1 = New System.Windows.Forms.Label()
        Me.TxtP1 = New System.Windows.Forms.TextBox()
        Me.TxtP2 = New System.Windows.Forms.TextBox()
        Me.LabelP2 = New System.Windows.Forms.Label()
        Me.TxtP3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtP4 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPromedio = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.LabelExp = New System.Windows.Forms.Label()
        Me.PanelBottom.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.Location = New System.Drawing.Point(334, 21)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(128, 32)
        Me.LabelTitle.TabIndex = 1
        Me.LabelTitle.Text = "Students"
        '
        'LabelParcial1
        '
        Me.LabelParcial1.AutoSize = True
        Me.LabelParcial1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelParcial1.Location = New System.Drawing.Point(50, 95)
        Me.LabelParcial1.Name = "LabelParcial1"
        Me.LabelParcial1.Size = New System.Drawing.Size(75, 20)
        Me.LabelParcial1.TabIndex = 2
        Me.LabelParcial1.Text = "Parcial 1"
        '
        'TxtP1
        '
        Me.TxtP1.Location = New System.Drawing.Point(54, 118)
        Me.TxtP1.Name = "TxtP1"
        Me.TxtP1.Size = New System.Drawing.Size(100, 22)
        Me.TxtP1.TabIndex = 3
        '
        'TxtP2
        '
        Me.TxtP2.Location = New System.Drawing.Point(54, 184)
        Me.TxtP2.Name = "TxtP2"
        Me.TxtP2.Size = New System.Drawing.Size(100, 22)
        Me.TxtP2.TabIndex = 5
        '
        'LabelP2
        '
        Me.LabelP2.AutoSize = True
        Me.LabelP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelP2.Location = New System.Drawing.Point(50, 161)
        Me.LabelP2.Name = "LabelP2"
        Me.LabelP2.Size = New System.Drawing.Size(80, 20)
        Me.LabelP2.TabIndex = 4
        Me.LabelP2.Text = "Parcial  2"
        '
        'TxtP3
        '
        Me.TxtP3.Location = New System.Drawing.Point(54, 249)
        Me.TxtP3.Name = "TxtP3"
        Me.TxtP3.Size = New System.Drawing.Size(100, 22)
        Me.TxtP3.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Parcial 3"
        '
        'TxtP4
        '
        Me.TxtP4.Location = New System.Drawing.Point(54, 316)
        Me.TxtP4.Name = "TxtP4"
        Me.TxtP4.Size = New System.Drawing.Size(100, 22)
        Me.TxtP4.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Parcial 4"
        '
        'TxtPromedio
        '
        Me.TxtPromedio.Location = New System.Drawing.Point(627, 316)
        Me.TxtPromedio.Name = "TxtPromedio"
        Me.TxtPromedio.ReadOnly = True
        Me.TxtPromedio.Size = New System.Drawing.Size(100, 22)
        Me.TxtPromedio.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(627, 293)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "PROMEDIO"
        '
        'PanelBottom
        '
        Me.PanelBottom.BackColor = System.Drawing.Color.Black
        Me.PanelBottom.Controls.Add(Me.ButtonEnter)
        Me.PanelBottom.Controls.Add(Me.LabelExp)
        Me.PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBottom.Location = New System.Drawing.Point(0, 380)
        Me.PanelBottom.Name = "PanelBottom"
        Me.PanelBottom.Size = New System.Drawing.Size(800, 70)
        Me.PanelBottom.TabIndex = 12
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
        'Students
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PanelBottom)
        Me.Controls.Add(Me.TxtPromedio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtP4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtP3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtP2)
        Me.Controls.Add(Me.LabelP2)
        Me.Controls.Add(Me.TxtP1)
        Me.Controls.Add(Me.LabelParcial1)
        Me.Controls.Add(Me.LabelTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Students"
        Me.Text = "Students"
        Me.PanelBottom.ResumeLayout(False)
        Me.PanelBottom.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTitle As Label
    Friend WithEvents LabelParcial1 As Label
    Friend WithEvents TxtP1 As TextBox
    Friend WithEvents TxtP2 As TextBox
    Friend WithEvents LabelP2 As Label
    Friend WithEvents TxtP3 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtP4 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPromedio As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelBottom As Panel
    Friend WithEvents ButtonEnter As Button
    Friend WithEvents LabelExp As Label
End Class
