Public Class Walkiies
    Dim fun As Integer
    Private Sub Btndone_Click(sender As Object, e As EventArgs) Handles btndone.Click

        Me.Close()
        MainScreen.Show()
    End Sub

    Private Sub btnup_Click(sender As Object, e As EventArgs) Handles btnup.Click
        walkpic.Top = walkpic.Top - 10
        If fun < 100 Then
            fun = fun + 5
            funlabel.Text = "Fun: " & fun & "/100"
            CheckIf100()
        End If
    End Sub

    Private Sub btndown_Click(sender As Object, e As EventArgs) Handles btndown.Click
        walkpic.Top = walkpic.Top + 10
        If fun < 100 Then
            fun = fun + 5
            funlabel.Text = "Fun: " & fun & "/100"
            CheckIf100()
        End If
    End Sub

    Private Sub btnleft_Click(sender As Object, e As EventArgs) Handles btnleft.Click
        walkpic.Left = walkpic.Left - 10
        If fun < 100 Then
            fun = fun + 5
            funlabel.Text = "Fun: " & fun & "/100"
            CheckIf100()
        End If
    End Sub

    Private Sub btnright_Click(sender As Object, e As EventArgs) Handles btnright.Click
        walkpic.Left = walkpic.Left + 10
        If fun < 100 Then
            fun = fun + 5
            funlabel.Text = "Fun: " & fun & "/100"
            CheckIf100()
        End If
    End Sub

    Private Sub Walkiies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btndone.Enabled = False
        MsgBox("Walk Your animal around the field! Avoid the rocks and Click 'Done' when you're finished.")
    End Sub

    Private Sub CheckIf100()
        If fun = 100 Then
            funlabel.Text = "Animal Fully satisfied!"
            btndone.Enabled = True
        End If
    End Sub

End Class