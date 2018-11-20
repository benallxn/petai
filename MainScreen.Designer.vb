<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainScreen
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
        Me.components = New System.ComponentModel.Container()
        Me.btnfeed = New System.Windows.Forms.Button()
        Me.btncuddle = New System.Windows.Forms.Button()
        Me.btnwash = New System.Windows.Forms.Button()
        Me.btnwalk = New System.Windows.Forms.Button()
        Me.btnwater = New System.Windows.Forms.Button()
        Me.haplabeltext = New System.Windows.Forms.Label()
        Me.haplabel = New System.Windows.Forms.Label()
        Me.Llabel = New System.Windows.Forms.Label()
        Me.Clabel = New System.Windows.Forms.Label()
        Me.Tlabel = New System.Windows.Forms.Label()
        Me.HLabel = New System.Windows.Forms.Label()
        Me.htxt = New System.Windows.Forms.Label()
        Me.ttxt = New System.Windows.Forms.Label()
        Me.hytxt = New System.Windows.Forms.Label()
        Me.ltxt = New System.Windows.Forms.Label()
        Me.ftxt = New System.Windows.Forms.Label()
        Me.Flabel = New System.Windows.Forms.Label()
        Me.GroupBoxNeeds = New System.Windows.Forms.GroupBox()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.SavePic = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.fishbowlpic = New System.Windows.Forms.PictureBox()
        Me.AnimalPic = New System.Windows.Forms.PictureBox()
        Me.FoodTimer = New System.Windows.Forms.Timer(Me.components)
        Me.ThirstTimer = New System.Windows.Forms.Timer(Me.components)
        Me.WashTimer = New System.Windows.Forms.Timer(Me.components)
        Me.LoveTimer = New System.Windows.Forms.Timer(Me.components)
        Me.FunTimer = New System.Windows.Forms.Timer(Me.components)
        Me.cashtimer = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBoxNeeds.SuspendLayout()
        CType(Me.SavePic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fishbowlpic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnimalPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnfeed
        '
        Me.btnfeed.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfeed.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnfeed.Location = New System.Drawing.Point(118, 268)
        Me.btnfeed.Name = "btnfeed"
        Me.btnfeed.Size = New System.Drawing.Size(107, 38)
        Me.btnfeed.TabIndex = 1
        Me.btnfeed.Text = "Feed"
        Me.btnfeed.UseVisualStyleBackColor = True
        '
        'btncuddle
        '
        Me.btncuddle.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncuddle.ForeColor = System.Drawing.Color.DarkGreen
        Me.btncuddle.Location = New System.Drawing.Point(457, 268)
        Me.btncuddle.Name = "btncuddle"
        Me.btncuddle.Size = New System.Drawing.Size(107, 38)
        Me.btncuddle.TabIndex = 2
        Me.btncuddle.Text = "Cuddle"
        Me.btncuddle.UseVisualStyleBackColor = True
        '
        'btnwash
        '
        Me.btnwash.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnwash.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnwash.Location = New System.Drawing.Point(231, 268)
        Me.btnwash.Name = "btnwash"
        Me.btnwash.Size = New System.Drawing.Size(107, 38)
        Me.btnwash.TabIndex = 3
        Me.btnwash.Text = "Wash"
        Me.btnwash.UseVisualStyleBackColor = True
        '
        'btnwalk
        '
        Me.btnwalk.Font = New System.Drawing.Font("Forte", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnwalk.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnwalk.Location = New System.Drawing.Point(344, 268)
        Me.btnwalk.Name = "btnwalk"
        Me.btnwalk.Size = New System.Drawing.Size(107, 38)
        Me.btnwalk.TabIndex = 4
        Me.btnwalk.Text = "Walk"
        Me.btnwalk.UseVisualStyleBackColor = True
        '
        'btnwater
        '
        Me.btnwater.Font = New System.Drawing.Font("Forte", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnwater.ForeColor = System.Drawing.Color.DarkGreen
        Me.btnwater.Location = New System.Drawing.Point(5, 268)
        Me.btnwater.Name = "btnwater"
        Me.btnwater.Size = New System.Drawing.Size(107, 38)
        Me.btnwater.TabIndex = 5
        Me.btnwater.Text = "Refill Water"
        Me.btnwater.UseVisualStyleBackColor = True
        '
        'haplabeltext
        '
        Me.haplabeltext.AutoSize = True
        Me.haplabeltext.Font = New System.Drawing.Font("Forte", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.haplabeltext.ForeColor = System.Drawing.Color.DarkGreen
        Me.haplabeltext.Location = New System.Drawing.Point(344, 244)
        Me.haplabeltext.Name = "haplabeltext"
        Me.haplabeltext.Size = New System.Drawing.Size(101, 21)
        Me.haplabeltext.TabIndex = 7
        Me.haplabeltext.Text = "Happiness:"
        '
        'haplabel
        '
        Me.haplabel.AutoSize = True
        Me.haplabel.Font = New System.Drawing.Font("Forte", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.haplabel.ForeColor = System.Drawing.Color.DarkGreen
        Me.haplabel.Location = New System.Drawing.Point(498, 244)
        Me.haplabel.Name = "haplabel"
        Me.haplabel.Size = New System.Drawing.Size(66, 21)
        Me.haplabel.TabIndex = 8
        Me.haplabel.Text = "60/100"
        '
        'Llabel
        '
        Me.Llabel.AutoSize = True
        Me.Llabel.Font = New System.Drawing.Font("Forte", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Llabel.Location = New System.Drawing.Point(160, 134)
        Me.Llabel.Name = "Llabel"
        Me.Llabel.Size = New System.Drawing.Size(70, 32)
        Me.Llabel.TabIndex = 9
        Me.Llabel.Text = "/100"
        '
        'Clabel
        '
        Me.Clabel.AutoSize = True
        Me.Clabel.Font = New System.Drawing.Font("Forte", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clabel.Location = New System.Drawing.Point(160, 102)
        Me.Clabel.Name = "Clabel"
        Me.Clabel.Size = New System.Drawing.Size(70, 32)
        Me.Clabel.TabIndex = 10
        Me.Clabel.Text = "/100"
        '
        'Tlabel
        '
        Me.Tlabel.AutoSize = True
        Me.Tlabel.Font = New System.Drawing.Font("Forte", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tlabel.Location = New System.Drawing.Point(160, 70)
        Me.Tlabel.Name = "Tlabel"
        Me.Tlabel.Size = New System.Drawing.Size(70, 32)
        Me.Tlabel.TabIndex = 11
        Me.Tlabel.Text = "/100"
        '
        'HLabel
        '
        Me.HLabel.AutoSize = True
        Me.HLabel.Font = New System.Drawing.Font("Forte", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HLabel.Location = New System.Drawing.Point(160, 38)
        Me.HLabel.Name = "HLabel"
        Me.HLabel.Size = New System.Drawing.Size(70, 32)
        Me.HLabel.TabIndex = 12
        Me.HLabel.Text = "/100"
        '
        'htxt
        '
        Me.htxt.AutoSize = True
        Me.htxt.Font = New System.Drawing.Font("Forte", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.htxt.Location = New System.Drawing.Point(10, 39)
        Me.htxt.Name = "htxt"
        Me.htxt.Size = New System.Drawing.Size(104, 32)
        Me.htxt.TabIndex = 13
        Me.htxt.Text = "Hunger"
        '
        'ttxt
        '
        Me.ttxt.AutoSize = True
        Me.ttxt.Font = New System.Drawing.Font("Forte", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttxt.Location = New System.Drawing.Point(10, 71)
        Me.ttxt.Name = "ttxt"
        Me.ttxt.Size = New System.Drawing.Size(83, 32)
        Me.ttxt.TabIndex = 14
        Me.ttxt.Text = "Thirst"
        '
        'hytxt
        '
        Me.hytxt.AutoSize = True
        Me.hytxt.Font = New System.Drawing.Font("Forte", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hytxt.Location = New System.Drawing.Point(10, 103)
        Me.hytxt.Name = "hytxt"
        Me.hytxt.Size = New System.Drawing.Size(114, 32)
        Me.hytxt.TabIndex = 15
        Me.hytxt.Text = "Hygeine"
        '
        'ltxt
        '
        Me.ltxt.AutoSize = True
        Me.ltxt.Font = New System.Drawing.Font("Forte", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltxt.Location = New System.Drawing.Point(10, 135)
        Me.ltxt.Name = "ltxt"
        Me.ltxt.Size = New System.Drawing.Size(67, 32)
        Me.ltxt.TabIndex = 16
        Me.ltxt.Text = "Love"
        '
        'ftxt
        '
        Me.ftxt.AutoSize = True
        Me.ftxt.Font = New System.Drawing.Font("Forte", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ftxt.Location = New System.Drawing.Point(10, 167)
        Me.ftxt.Name = "ftxt"
        Me.ftxt.Size = New System.Drawing.Size(60, 32)
        Me.ftxt.TabIndex = 17
        Me.ftxt.Text = "Fun"
        '
        'Flabel
        '
        Me.Flabel.AutoSize = True
        Me.Flabel.Font = New System.Drawing.Font("Forte", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Flabel.Location = New System.Drawing.Point(160, 166)
        Me.Flabel.Name = "Flabel"
        Me.Flabel.Size = New System.Drawing.Size(70, 32)
        Me.Flabel.TabIndex = 18
        Me.Flabel.Text = "/100"
        '
        'GroupBoxNeeds
        '
        Me.GroupBoxNeeds.BackColor = System.Drawing.Color.LightGreen
        Me.GroupBoxNeeds.Controls.Add(Me.Flabel)
        Me.GroupBoxNeeds.Controls.Add(Me.ftxt)
        Me.GroupBoxNeeds.Controls.Add(Me.ltxt)
        Me.GroupBoxNeeds.Controls.Add(Me.hytxt)
        Me.GroupBoxNeeds.Controls.Add(Me.ttxt)
        Me.GroupBoxNeeds.Controls.Add(Me.htxt)
        Me.GroupBoxNeeds.Controls.Add(Me.HLabel)
        Me.GroupBoxNeeds.Controls.Add(Me.Tlabel)
        Me.GroupBoxNeeds.Controls.Add(Me.Clabel)
        Me.GroupBoxNeeds.Controls.Add(Me.Llabel)
        Me.GroupBoxNeeds.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBoxNeeds.Font = New System.Drawing.Font("Forte", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxNeeds.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBoxNeeds.Location = New System.Drawing.Point(5, 12)
        Me.GroupBoxNeeds.Name = "GroupBoxNeeds"
        Me.GroupBoxNeeds.Size = New System.Drawing.Size(278, 217)
        Me.GroupBoxNeeds.TabIndex = 19
        Me.GroupBoxNeeds.TabStop = False
        Me.GroupBoxNeeds.Text = "NEEDS"
        '
        'lblMoney
        '
        Me.lblMoney.AutoSize = True
        Me.lblMoney.Font = New System.Drawing.Font("Forte", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoney.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblMoney.Location = New System.Drawing.Point(5, 244)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(80, 21)
        Me.lblMoney.TabIndex = 20
        Me.lblMoney.Text = "Money: "
        '
        'SavePic
        '
        Me.SavePic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.SavePic.Image = Global.Petai.My.Resources.Resources.SaveGame
        Me.SavePic.Location = New System.Drawing.Point(289, 89)
        Me.SavePic.Name = "SavePic"
        Me.SavePic.Size = New System.Drawing.Size(68, 67)
        Me.SavePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SavePic.TabIndex = 23
        Me.SavePic.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox3.Image = Global.Petai.My.Resources.Resources.Shop
        Me.PictureBox3.Location = New System.Drawing.Point(289, 162)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(68, 67)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 22
        Me.PictureBox3.TabStop = False
        '
        'fishbowlpic
        '
        Me.fishbowlpic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.fishbowlpic.Image = Global.Petai.My.Resources.Resources.fishbowl
        Me.fishbowlpic.Location = New System.Drawing.Point(289, 12)
        Me.fishbowlpic.Name = "fishbowlpic"
        Me.fishbowlpic.Size = New System.Drawing.Size(68, 71)
        Me.fishbowlpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.fishbowlpic.TabIndex = 21
        Me.fishbowlpic.TabStop = False
        '
        'AnimalPic
        '
        Me.AnimalPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.AnimalPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AnimalPic.Image = Global.Petai.My.Resources.Resources.Uni_Normal_State
        Me.AnimalPic.Location = New System.Drawing.Point(363, 11)
        Me.AnimalPic.Name = "AnimalPic"
        Me.AnimalPic.Size = New System.Drawing.Size(201, 199)
        Me.AnimalPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AnimalPic.TabIndex = 0
        Me.AnimalPic.TabStop = False
        '
        'FoodTimer
        '
        Me.FoodTimer.Enabled = True
        Me.FoodTimer.Interval = 1000
        '
        'ThirstTimer
        '
        Me.ThirstTimer.Enabled = True
        Me.ThirstTimer.Interval = 1500
        '
        'WashTimer
        '
        Me.WashTimer.Enabled = True
        Me.WashTimer.Interval = 1200
        '
        'LoveTimer
        '
        Me.LoveTimer.Enabled = True
        Me.LoveTimer.Interval = 2500
        '
        'FunTimer
        '
        Me.FunTimer.Enabled = True
        Me.FunTimer.Interval = 2000
        '
        'cashtimer
        '
        Me.cashtimer.Enabled = True
        Me.cashtimer.Interval = 1000
        '
        'MainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGreen
        Me.ClientSize = New System.Drawing.Size(585, 318)
        Me.Controls.Add(Me.SavePic)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.fishbowlpic)
        Me.Controls.Add(Me.lblMoney)
        Me.Controls.Add(Me.GroupBoxNeeds)
        Me.Controls.Add(Me.haplabel)
        Me.Controls.Add(Me.haplabeltext)
        Me.Controls.Add(Me.btnwater)
        Me.Controls.Add(Me.btnwalk)
        Me.Controls.Add(Me.btnwash)
        Me.Controls.Add(Me.btncuddle)
        Me.Controls.Add(Me.btnfeed)
        Me.Controls.Add(Me.AnimalPic)
        Me.DoubleBuffered = True
        Me.Name = "MainScreen"
        Me.Text = "Main Screen"
        Me.GroupBoxNeeds.ResumeLayout(False)
        Me.GroupBoxNeeds.PerformLayout()
        CType(Me.SavePic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fishbowlpic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnimalPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnfeed As System.Windows.Forms.Button
    Friend WithEvents btncuddle As System.Windows.Forms.Button
    Friend WithEvents btnwash As System.Windows.Forms.Button
    Friend WithEvents btnwalk As System.Windows.Forms.Button
    Friend WithEvents btnwater As System.Windows.Forms.Button
    Friend WithEvents haplabeltext As System.Windows.Forms.Label
    Friend WithEvents haplabel As System.Windows.Forms.Label
    Friend WithEvents Llabel As System.Windows.Forms.Label
    Friend WithEvents Clabel As System.Windows.Forms.Label
    Friend WithEvents Tlabel As System.Windows.Forms.Label
    Friend WithEvents HLabel As System.Windows.Forms.Label
    Friend WithEvents htxt As System.Windows.Forms.Label
    Friend WithEvents ttxt As System.Windows.Forms.Label
    Friend WithEvents hytxt As System.Windows.Forms.Label
    Friend WithEvents ltxt As System.Windows.Forms.Label
    Friend WithEvents ftxt As System.Windows.Forms.Label
    Friend WithEvents Flabel As System.Windows.Forms.Label
    Friend WithEvents GroupBoxNeeds As System.Windows.Forms.GroupBox
    Friend WithEvents lblMoney As System.Windows.Forms.Label
    Friend WithEvents fishbowlpic As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents SavePic As System.Windows.Forms.PictureBox
    Public WithEvents FoodTimer As Timer
    Public WithEvents ThirstTimer As Timer
    Public WithEvents WashTimer As Timer
    Public WithEvents LoveTimer As Timer
    Public WithEvents FunTimer As Timer
    Public WithEvents AnimalPic As PictureBox
    Friend WithEvents cashtimer As Timer
End Class
