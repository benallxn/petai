Public Class Cuddle
    Dim love As Integer
    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
        MainScreen.Show()

    End Sub

    Private Sub Cuddle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnclose.Enabled = False

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub AnimalPic_Click(sender As Object, e As EventArgs) Handles AnimalPic.Click
        If love < 100 Then
            love = love + 10
            Label1.Text = "Affection: " & love & "/100"
        End If
        If love = 100 Then
            btnclose.Enabled = True

            Label1.Text = "Friendship Improved!"
        End If
    End Sub
End Class