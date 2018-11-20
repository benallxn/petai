<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class logonform
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnnewacc = New System.Windows.Forms.Button()
        Me.logonbtn = New System.Windows.Forms.Button()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.koalapic = New System.Windows.Forms.PictureBox()
        CType(Me.koalapic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'btnnewacc
        '
        Me.btnnewacc.Location = New System.Drawing.Point(15, 102)
        Me.btnnewacc.Name = "btnnewacc"
        Me.btnnewacc.Size = New System.Drawing.Size(75, 43)
        Me.btnnewacc.TabIndex = 2
        Me.btnnewacc.Text = "Create New Account"
        Me.btnnewacc.UseVisualStyleBackColor = True
        '
        'logonbtn
        '
        Me.logonbtn.Location = New System.Drawing.Point(107, 102)
        Me.logonbtn.Name = "logonbtn"
        Me.logonbtn.Size = New System.Drawing.Size(75, 43)
        Me.logonbtn.TabIndex = 3
        Me.logonbtn.Text = "Log On"
        Me.logonbtn.UseVisualStyleBackColor = True
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(82, 67)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(100, 20)
        Me.txtpassword.TabIndex = 4
        Me.txtpassword.UseSystemPasswordChar = True
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(82, 41)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(100, 20)
        Me.txtusername.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(84, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 22)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Welcome!"
        '
        'koalapic
        '
        Me.koalapic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.koalapic.Image = Global.Petai.My.Resources.Resources.K_Love_State
        Me.koalapic.Location = New System.Drawing.Point(198, 41)
        Me.koalapic.Name = "koalapic"
        Me.koalapic.Size = New System.Drawing.Size(100, 104)
        Me.koalapic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.koalapic.TabIndex = 6
        Me.koalapic.TabStop = False
        '
        'logonform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Goldenrod
        Me.ClientSize = New System.Drawing.Size(311, 160)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.koalapic)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.logonbtn)
        Me.Controls.Add(Me.btnnewacc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "logonform"
        Me.Text = "Log On"
        CType(Me.koalapic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnnewacc As System.Windows.Forms.Button
    Friend WithEvents logonbtn As System.Windows.Forms.Button
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents koalapic As System.Windows.Forms.PictureBox
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
