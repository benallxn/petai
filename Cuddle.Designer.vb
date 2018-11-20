<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cuddle
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
        Me.AnimalPic = New System.Windows.Forms.PictureBox()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.infolbl = New System.Windows.Forms.Label()
        CType(Me.AnimalPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AnimalPic
        '
        Me.AnimalPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AnimalPic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnimalPic.Image = Global.Petai.My.Resources.Resources.GP_Love_State
        Me.AnimalPic.Location = New System.Drawing.Point(34, 38)
        Me.AnimalPic.Name = "AnimalPic"
        Me.AnimalPic.Size = New System.Drawing.Size(224, 212)
        Me.AnimalPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AnimalPic.TabIndex = 0
        Me.AnimalPic.TabStop = False
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(34, 256)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 1
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(145, 261)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Affection:"
        '
        'infolbl
        '
        Me.infolbl.AutoSize = True
        Me.infolbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.infolbl.Location = New System.Drawing.Point(50, 9)
        Me.infolbl.Name = "infolbl"
        Me.infolbl.Size = New System.Drawing.Size(198, 13)
        Me.infolbl.TabIndex = 3
        Me.infolbl.Text = "Click On Your Animal to Stroke It!"
        '
        'Cuddle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(294, 302)
        Me.Controls.Add(Me.infolbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.AnimalPic)
        Me.Name = "Cuddle"
        Me.Text = "Cuddle"
        CType(Me.AnimalPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AnimalPic As System.Windows.Forms.PictureBox
    Friend WithEvents btnclose As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents infolbl As Label
End Class
