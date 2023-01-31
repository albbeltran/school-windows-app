<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Songs
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
        Me.TxtAlbum = New System.Windows.Forms.TextBox()
        Me.PanelBottom = New System.Windows.Forms.Panel()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.ButtonClear = New System.Windows.Forms.Button()
        Me.ButtonEnter = New System.Windows.Forms.Button()
        Me.GridMusic = New System.Windows.Forms.DataGridView()
        Me.LabelCounter = New System.Windows.Forms.Label()
        Me.LabelTotal = New System.Windows.Forms.Label()
        Me.LabelSongs = New System.Windows.Forms.Label()
        Me.TxtSongs = New System.Windows.Forms.TextBox()
        Me.CBoxGenrer = New System.Windows.Forms.ComboBox()
        Me.LabelGenrer = New System.Windows.Forms.Label()
        Me.LabelArtist = New System.Windows.Forms.Label()
        Me.LabelAlbum = New System.Windows.Forms.Label()
        Me.TxtArtist = New System.Windows.Forms.TextBox()
        Me.LabelID = New System.Windows.Forms.Label()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.LabelYear = New System.Windows.Forms.Label()
        Me.TxtYear = New System.Windows.Forms.TextBox()
        Me.PanelBottom.SuspendLayout()
        CType(Me.GridMusic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtAlbum
        '
        Me.TxtAlbum.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtAlbum.Location = New System.Drawing.Point(405, 119)
        Me.TxtAlbum.Name = "TxtAlbum"
        Me.TxtAlbum.Size = New System.Drawing.Size(190, 22)
        Me.TxtAlbum.TabIndex = 64
        Me.TxtAlbum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.PanelBottom.TabIndex = 63
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ButtonUpdate.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.ButtonUpdate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray
        Me.ButtonUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.ButtonUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUpdate.ForeColor = System.Drawing.Color.White
        Me.ButtonUpdate.Location = New System.Drawing.Point(529, 13)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(109, 45)
        Me.ButtonUpdate.TabIndex = 3
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
        'GridMusic
        '
        Me.GridMusic.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.GridMusic.AllowUserToAddRows = False
        Me.GridMusic.AllowUserToResizeColumns = False
        Me.GridMusic.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GridMusic.BackgroundColor = System.Drawing.SystemColors.Control
        Me.GridMusic.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridMusic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridMusic.Location = New System.Drawing.Point(93, 288)
        Me.GridMusic.Name = "GridMusic"
        Me.GridMusic.ReadOnly = True
        Me.GridMusic.RowHeadersWidth = 51
        Me.GridMusic.RowTemplate.Height = 24
        Me.GridMusic.Size = New System.Drawing.Size(850, 150)
        Me.GridMusic.TabIndex = 62
        '
        'LabelCounter
        '
        Me.LabelCounter.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelCounter.AutoSize = True
        Me.LabelCounter.Enabled = False
        Me.LabelCounter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCounter.Location = New System.Drawing.Point(157, 233)
        Me.LabelCounter.Name = "LabelCounter"
        Me.LabelCounter.Size = New System.Drawing.Size(18, 20)
        Me.LabelCounter.TabIndex = 61
        Me.LabelCounter.Text = "0"
        '
        'LabelTotal
        '
        Me.LabelTotal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelTotal.AutoSize = True
        Me.LabelTotal.Enabled = False
        Me.LabelTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotal.Location = New System.Drawing.Point(88, 233)
        Me.LabelTotal.Name = "LabelTotal"
        Me.LabelTotal.Size = New System.Drawing.Size(46, 20)
        Me.LabelTotal.TabIndex = 60
        Me.LabelTotal.Text = "Total"
        '
        'LabelSongs
        '
        Me.LabelSongs.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelSongs.AutoSize = True
        Me.LabelSongs.Enabled = False
        Me.LabelSongs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSongs.Location = New System.Drawing.Point(86, 177)
        Me.LabelSongs.Name = "LabelSongs"
        Me.LabelSongs.Size = New System.Drawing.Size(70, 20)
        Me.LabelSongs.TabIndex = 59
        Me.LabelSongs.Text = "# Songs"
        '
        'TxtSongs
        '
        Me.TxtSongs.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtSongs.Location = New System.Drawing.Point(162, 177)
        Me.TxtSongs.Name = "TxtSongs"
        Me.TxtSongs.Size = New System.Drawing.Size(162, 22)
        Me.TxtSongs.TabIndex = 58
        Me.TxtSongs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CBoxGenrer
        '
        Me.CBoxGenrer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.CBoxGenrer.FormattingEnabled = True
        Me.CBoxGenrer.Items.AddRange(New Object() {"Pop", "Rock", "Hip-Hop & Rap", "Country", "Metal", "Reggae", "Latinal", "Trap"})
        Me.CBoxGenrer.Location = New System.Drawing.Point(461, 177)
        Me.CBoxGenrer.Name = "CBoxGenrer"
        Me.CBoxGenrer.Size = New System.Drawing.Size(191, 24)
        Me.CBoxGenrer.TabIndex = 57
        '
        'LabelGenrer
        '
        Me.LabelGenrer.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelGenrer.AutoSize = True
        Me.LabelGenrer.Enabled = False
        Me.LabelGenrer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelGenrer.Location = New System.Drawing.Point(392, 177)
        Me.LabelGenrer.Name = "LabelGenrer"
        Me.LabelGenrer.Size = New System.Drawing.Size(61, 20)
        Me.LabelGenrer.TabIndex = 56
        Me.LabelGenrer.Text = "Genrer"
        Me.LabelGenrer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelArtist
        '
        Me.LabelArtist.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelArtist.AutoSize = True
        Me.LabelArtist.Enabled = False
        Me.LabelArtist.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelArtist.Location = New System.Drawing.Point(683, 115)
        Me.LabelArtist.Name = "LabelArtist"
        Me.LabelArtist.Size = New System.Drawing.Size(49, 20)
        Me.LabelArtist.TabIndex = 55
        Me.LabelArtist.Text = "Artist"
        Me.LabelArtist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelAlbum
        '
        Me.LabelAlbum.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelAlbum.AutoSize = True
        Me.LabelAlbum.Enabled = False
        Me.LabelAlbum.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAlbum.Location = New System.Drawing.Point(337, 119)
        Me.LabelAlbum.Name = "LabelAlbum"
        Me.LabelAlbum.Size = New System.Drawing.Size(56, 20)
        Me.LabelAlbum.TabIndex = 54
        Me.LabelAlbum.Text = "Album"
        '
        'TxtArtist
        '
        Me.TxtArtist.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtArtist.Location = New System.Drawing.Point(753, 113)
        Me.TxtArtist.Name = "TxtArtist"
        Me.TxtArtist.Size = New System.Drawing.Size(190, 22)
        Me.TxtArtist.TabIndex = 53
        Me.TxtArtist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelID
        '
        Me.LabelID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelID.AutoSize = True
        Me.LabelID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelID.Location = New System.Drawing.Point(88, 119)
        Me.LabelID.Name = "LabelID"
        Me.LabelID.Size = New System.Drawing.Size(26, 20)
        Me.LabelID.TabIndex = 52
        Me.LabelID.Text = "ID"
        '
        'TxtID
        '
        Me.TxtID.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtID.Location = New System.Drawing.Point(120, 119)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(135, 22)
        Me.TxtID.TabIndex = 51
        Me.TxtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LabelTitle
        '
        Me.LabelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitle.Location = New System.Drawing.Point(428, 50)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(107, 33)
        Me.LabelTitle.TabIndex = 50
        Me.LabelTitle.Text = "MUSIC"
        '
        'LabelYear
        '
        Me.LabelYear.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelYear.AutoSize = True
        Me.LabelYear.Enabled = False
        Me.LabelYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelYear.Location = New System.Drawing.Point(705, 179)
        Me.LabelYear.Name = "LabelYear"
        Me.LabelYear.Size = New System.Drawing.Size(43, 20)
        Me.LabelYear.TabIndex = 66
        Me.LabelYear.Text = "Year"
        '
        'TxtYear
        '
        Me.TxtYear.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtYear.Location = New System.Drawing.Point(753, 179)
        Me.TxtYear.Name = "TxtYear"
        Me.TxtYear.Size = New System.Drawing.Size(190, 22)
        Me.TxtYear.TabIndex = 65
        Me.TxtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Songs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 535)
        Me.Controls.Add(Me.LabelYear)
        Me.Controls.Add(Me.TxtYear)
        Me.Controls.Add(Me.TxtAlbum)
        Me.Controls.Add(Me.PanelBottom)
        Me.Controls.Add(Me.GridMusic)
        Me.Controls.Add(Me.LabelCounter)
        Me.Controls.Add(Me.LabelTotal)
        Me.Controls.Add(Me.LabelSongs)
        Me.Controls.Add(Me.TxtSongs)
        Me.Controls.Add(Me.CBoxGenrer)
        Me.Controls.Add(Me.LabelGenrer)
        Me.Controls.Add(Me.LabelArtist)
        Me.Controls.Add(Me.LabelAlbum)
        Me.Controls.Add(Me.TxtArtist)
        Me.Controls.Add(Me.LabelID)
        Me.Controls.Add(Me.TxtID)
        Me.Controls.Add(Me.LabelTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Songs"
        Me.Text = "Songs"
        Me.PanelBottom.ResumeLayout(False)
        CType(Me.GridMusic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtAlbum As TextBox
    Friend WithEvents PanelBottom As Panel
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonEnter As Button
    Friend WithEvents GridMusic As DataGridView
    Friend WithEvents LabelCounter As Label
    Friend WithEvents LabelTotal As Label
    Friend WithEvents LabelSongs As Label
    Friend WithEvents TxtSongs As TextBox
    Friend WithEvents CBoxGenrer As ComboBox
    Friend WithEvents LabelGenrer As Label
    Friend WithEvents LabelArtist As Label
    Friend WithEvents LabelAlbum As Label
    Friend WithEvents TxtArtist As TextBox
    Friend WithEvents LabelID As Label
    Friend WithEvents TxtID As TextBox
    Friend WithEvents LabelTitle As Label
    Friend WithEvents LabelYear As Label
    Friend WithEvents TxtYear As TextBox
    Friend WithEvents ButtonUpdate As Button
End Class
