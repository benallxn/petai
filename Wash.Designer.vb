<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Wash
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.WashPic = New System.Windows.Forms.PictureBox()
        Me.btnlather = New System.Windows.Forms.Button()
        Me.btnrinse = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.lblHygeine = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.lblclean = New System.Windows.Forms.Label()
        CType(Me.WashPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WashPic
        '
        Me.WashPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.WashPic.Image = Global.Petai.My.Resources.Resources.Liz_Love_State1
        Me.WashPic.Location = New System.Drawing.Point(12, 12)
        Me.WashPic.Name = "WashPic"
        Me.WashPic.Size = New System.Drawing.Size(185, 193)
        Me.WashPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WashPic.TabIndex = 0
        Me.WashPic.TabStop = False
        '
        'btnlather
        '
        Me.btnlather.Location = New System.Drawing.Point(205, 12)
        Me.btnlather.Name = "btnlather"
        Me.btnlather.Size = New System.Drawing.Size(75, 23)
        Me.btnlather.TabIndex = 1
        Me.btnlather.Text = "Lather"
        Me.btnlather.UseVisualStyleBackColor = True
        '
        'btnrinse
        '
        Me.btnrinse.Location = New System.Drawing.Point(205, 41)
        Me.btnrinse.Name = "btnrinse"
        Me.btnrinse.Size = New System.Drawing.Size(75, 23)
        Me.btnrinse.TabIndex = 2
        Me.btnrinse.Text = "Rinse"
        Me.btnrinse.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(205, 182)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 3
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'lblHygeine
        '
        Me.lblHygeine.AutoSize = True
        Me.lblHygeine.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHygeine.Location = New System.Drawing.Point(12, 231)
        Me.lblHygeine.Name = "lblHygeine"
        Me.lblHygeine.Size = New System.Drawing.Size(128, 20)
        Me.lblHygeine.TabIndex = 4
        Me.lblHygeine.Text = "HYGIENE: 0/100"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.Location = New System.Drawing.Point(208, 99)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(72, 13)
        Me.lbl.TabIndex = 5
        Me.lbl.Text = "Now Rinse!"
        '
        'lblclean
        '
        Me.lblclean.AutoSize = True
        Me.lblclean.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclean.Location = New System.Drawing.Point(195, 237)
        Me.lblclean.Name = "lblclean"
        Me.lblclean.Size = New System.Drawing.Size(85, 13)
        Me.lblclean.TabIndex = 6
        Me.lblclean.Text = "Totally Clean!"
        '
        'Wash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Aquamarine
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.lblclean)
        Me.Controls.Add(Me.lbl)
        Me.Controls.Add(Me.lblHygeine)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnrinse)
        Me.Controls.Add(Me.btnlather)
        Me.Controls.Add(Me.WashPic)
        Me.Name = "Wash"
        Me.Text = "Wash"
        CType(Me.WashPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents WashPic As System.Windows.Forms.PictureBox
    Friend WithEvents btnlather As System.Windows.Forms.Button
    Friend WithEvents btnrinse As System.Windows.Forms.Button
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents lblHygeine As System.Windows.Forms.Label
    Friend WithEvents lbl As Label
    Friend WithEvents lblclean As Label
End Class
