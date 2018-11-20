Public Class Wash
    Dim hygiene As Integer
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
        MainScreen.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles WashPic.Click

    End Sub

    Private Sub Wash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnrinse.Enabled = False
        lbl.Visible = False
        lblclean.Visible = False
        btnclose.Enabled = False

    End Sub

    Private Sub btnlather_Click(sender As Object, e As EventArgs) Handles btnlather.Click
        hygiene = hygiene + 10
        lblHygeine.Text = "HYGIENE: " & hygiene & "/100"
        btnrinse.Enabled = True
        btnlather.Enabled = False
        lbl.Visible = True
        If hygiene = 100 Then
            btnlather.Enabled = False
            btnrinse.Enabled = False
            lblclean.Visible = True
            btnclose.Enabled = True
        End If
    End Sub

    Private Sub btnrinse_Click(sender As Object, e As EventArgs) Handles btnrinse.Click
        hygiene = hygiene + 10
        lblHygeine.Text = "HYGIENE: " & hygiene & "/100"
        btnlather.Enabled = True
        btnrinse.Enabled = False
        lbl.Visible = False
        If hygiene = 100 Then
            btnlather.Enabled = False
            btnrinse.Enabled = False
            lblclean.Visible = True
            btnclose.Enabled = True

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblclean.Click

    End Sub

    Private Sub lblHygeine_Click(sender As Object, e As EventArgs) Handles lblHygeine.Click

    End Sub
End Class