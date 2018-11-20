<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Walkiies
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
        Me.btndone = New System.Windows.Forms.Button()
        Me.btnright = New System.Windows.Forms.Button()
        Me.btnup = New System.Windows.Forms.Button()
        Me.btndown = New System.Windows.Forms.Button()
        Me.btnleft = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.walkpic = New System.Windows.Forms.PictureBox()
        Me.funlabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.walkpic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btndone
        '
        Me.btndone.BackColor = System.Drawing.Color.LightYellow
        Me.btndone.Location = New System.Drawing.Point(295, 318)
        Me.btndone.Name = "btndone"
        Me.btndone.Size = New System.Drawing.Size(78, 23)
        Me.btndone.TabIndex = 1
        Me.btndone.Text = "DONE"
        Me.btndone.UseVisualStyleBackColor = False
        '
        'btnright
        '
        Me.btnright.BackColor = System.Drawing.Color.LightYellow
        Me.btnright.Location = New System.Drawing.Point(190, 318)
        Me.btnright.Name = "btnright"
        Me.btnright.Size = New System.Drawing.Size(75, 23)
        Me.btnright.TabIndex = 2
        Me.btnright.Text = "Right"
        Me.btnright.UseVisualStyleBackColor = False
        '
        'btnup
        '
        Me.btnup.BackColor = System.Drawing.Color.Ivory
        Me.btnup.Location = New System.Drawing.Point(109, 289)
        Me.btnup.Name = "btnup"
        Me.btnup.Size = New System.Drawing.Size(75, 23)
        Me.btnup.TabIndex = 3
        Me.btnup.Text = "Up"
        Me.btnup.UseVisualStyleBackColor = False
        '
        'btndown
        '
        Me.btndown.BackColor = System.Drawing.Color.Ivory
        Me.btndown.Location = New System.Drawing.Point(109, 318)
        Me.btndown.Name = "btndown"
        Me.btndown.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btndown.Size = New System.Drawing.Size(75, 23)
        Me.btndown.TabIndex = 4
        Me.btndown.Text = "Down"
        Me.btndown.UseVisualStyleBackColor = False
        '
        'btnleft
        '
        Me.btnleft.BackColor = System.Drawing.Color.Ivory
        Me.btnleft.Location = New System.Drawing.Point(28, 318)
        Me.btnleft.Name = "btnleft"
        Me.btnleft.Size = New System.Drawing.Size(75, 23)
        Me.btnleft.TabIndex = 5
        Me.btnleft.Text = "Left"
        Me.btnleft.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Petai.My.Resources.Resources._1_rock_texture
        Me.PictureBox4.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(346, 30)
        Me.PictureBox4.TabIndex = 9
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Petai.My.Resources.Resources._1_rock_texture
        Me.PictureBox3.Location = New System.Drawing.Point(342, 0)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 283)
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Petai.My.Resources.Resources._1_rock_texture
        Me.PictureBox2.Location = New System.Drawing.Point(0, 275)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(382, 82)
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Petai.My.Resources.Resources._1_rock_texture
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(33, 283)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'walkpic
        '
        Me.walkpic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.walkpic.Image = Global.Petai.My.Resources.Resources.H_Normal_State
        Me.walkpic.Location = New System.Drawing.Point(164, 122)
        Me.walkpic.Name = "walkpic"
        Me.walkpic.Size = New System.Drawing.Size(60, 63)
        Me.walkpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.walkpic.TabIndex = 0
        Me.walkpic.TabStop = False
        '
        'funlabel
        '
        Me.funlabel.AutoSize = True
        Me.funlabel.BackColor = System.Drawing.Color.LightYellow
        Me.funlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.funlabel.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.funlabel.Location = New System.Drawing.Point(39, 9)
        Me.funlabel.Name = "funlabel"
        Me.funlabel.Size = New System.Drawing.Size(81, 19)
        Me.funlabel.TabIndex = 10
        Me.funlabel.Text = "Fun: 0/100"
        '
        'Walkiies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.BackgroundImage = Global.Petai.My.Resources.Resources.grass
        Me.ClientSize = New System.Drawing.Size(378, 353)
        Me.Controls.Add(Me.funlabel)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnleft)
        Me.Controls.Add(Me.btndown)
        Me.Controls.Add(Me.btnup)
        Me.Controls.Add(Me.btnright)
        Me.Controls.Add(Me.btndone)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.walkpic)
        Me.Name = "Walkiies"
        Me.Text = "Walk"
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.walkpic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents walkpic As System.Windows.Forms.PictureBox
    Friend WithEvents btndone As System.Windows.Forms.Button
    Friend WithEvents btnright As Button
    Friend WithEvents btnup As Button
    Friend WithEvents btndown As Button
    Friend WithEvents btnleft As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents funlabel As Label
End Class
