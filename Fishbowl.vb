Public Class Fishbowl
    Dim thirst As Integer = 60
    Dim hunger As Integer = 60
    Dim clean As Integer = 60
    Dim love As Integer = 60
    Dim fun As Integer = 60
    Dim happiness As Integer = (thirst + hunger + fun + love + clean) / 5
    Dim moneyrate As Integer
    Dim cash As Integer
    Private Sub Fishbowl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BackToLand(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        MainScreen.Show()
    End Sub

    Private Sub VisitStore(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        formstore.Show()

    End Sub

    Private Sub cleantank(sender As Object, e As EventArgs) Handles WashTankBtn.Click
        If clean < 80 Then
            clean = clean + 20
        Else : clean = 100
        End If
        clabel.Text = clean & "/100"
        happiness = (thirst + hunger + fun + love + clean) / 5
        haplabel.Text = happiness & "/100"
    End Sub

    Private Sub feed(sender As Object, e As EventArgs) Handles FishFeedBtn.Click
        If hunger < 80 Then
            hunger = hunger + 20
        Else : hunger = 100
        End If

        If cash > 20 Then
            cash = cash - 20
        Else : cash = 0
        End If

        hlabel.Text = hunger & "/100"
        happiness = (thirst + hunger + fun + love + clean) / 5
        haplabel.Text = happiness & "/100"
        Label13.Text = cash & "£"
    End Sub

    Private Sub cuddle(sender As Object, e As EventArgs) Handles CuddleBtn.Click

        If love < 80 Then
            love = love + 20
        Else : love = 100
        End If

        llabel.Text = love & "/100"
        happiness = (thirst + hunger + fun + love + clean) / 5
        haplabel.Text = happiness & "/100"

    End Sub

    Private Sub DepleteHunger() Handles FoodTimer.Tick
        ' This integer variable keeps track of the 
        ' current hunger value.
        If hunger > 0 Then
            ' Display the hunger
            ' by updating the hunger label.
            hunger -= 1
            hlabel.Text = hunger & " /100"
            happiness = (thirst + hunger + fun + love + clean) / 5
            haplabel.Text = (happiness & "/100")
        Else
            FoodTimer.Stop()
        End If

    End Sub

    Private Sub DepleteHygiene() Handles WashTimer.Tick
        ' This integer variable keeps track of the 
        ' current hygiene value.
        If clean > 0 Then
            ' Display the Hygiene
            ' by updating the hygiene label.
            clean -= 1
            clabel.Text = clean & " /100"
            happiness = (thirst + hunger + fun + love + clean) / 5
            haplabel.Text = (happiness & "/100")
        Else
            WashTimer.Stop()
        End If

    End Sub


    Private Sub DepleteFun() Handles FunTimer.Tick
        ' This integer variable keeps track of the 
        ' current fun value.
        If fun > 0 Then
            ' Display the fun
            ' by updating the fun label.
            fun -= 1
            flabel.Text = fun & " /100"
            happiness = (thirst + hunger + fun + love + clean) / 5
            haplabel.Text = (happiness & "/100")
        Else
            FunTimer.Stop()
        End If
    End Sub

    Private Sub DepleteLove() Handles LoveTimer.Tick
        ' This integer variable keeps track of the 
        ' love value.
        If love > 0 Then
            ' Display the love
            ' by updating the love label.
            love -= 1
            llabel.Text = love & " /100"
            happiness = (thirst + hunger + fun + love + clean) / 5
            haplabel.Text = (happiness & "/100")
        Else
            LoveTimer.Stop()
        End If
    End Sub

    Private Sub WatchSwim(sender As Object, e As EventArgs) Handles WatchSwimBtn.Click
        If fun < 90 Then
            fun = fun + 10
        Else
            fun = 100
        End If




    End Sub
End Class