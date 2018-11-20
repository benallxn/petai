Imports System.Data.OleDb
Imports System.Data.SqlClient

Public Class MainScreen
    Dim currentfish As String = "Goldfish"
    Dim currentanimal As String = "hamster"
    Dim thirst As Integer = 100
    Dim hunger As Integer = 100
    Dim clean As Integer = 100
    Dim love As Integer = 100
    Dim fun As Integer = 100
    Dim username As String = "ballan125"
    Dim cash As Integer
    Dim happiness As Integer
    Dim currentmoneyrate As Integer
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim con As OleDbConnection = New OleDbConnection

    Private Sub CalcHappiness()
        happiness = (hunger + thirst + fun + clean + love) / 5
        haplabel.Text = happiness & "/ 100"
        If happiness = 40 Then
            MsgBox("Your animal is very unhappy! Play with it to get it back!")
            Walkiies.Show()
            fun = 100
            Me.Hide()

        End If
    End Sub

    Private Sub GenerateMoney() Handles cashtimer.Tick
        CalcHappiness()
        If happiness > 80 Then
            cash = cash + 10
            lblMoney.Text = "Money: £" & cash
        Else
            cashtimer.Stop()
        End If

    End Sub

    Private Sub DepleteHunger() Handles FoodTimer.Tick
        ' This integer variable keeps track of the 
        ' current hunger value.
        If hunger > 0 Then
            ' Display the hunger
            ' by updating the hunger label.
            hunger -= 1
            HLabel.Text = hunger & " /100"
            If hunger = 20 Then
                MsgBox("Your animal is starving! Please feed it!")
            End If
            CalcHappiness()
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
            Clabel.Text = clean & " /100"
            CalcHappiness()
        Else
            WashTimer.Stop()
        End If

    End Sub

    Private Sub DepleteThirst() Handles ThirstTimer.Tick
        ' This integer variable keeps track of the 
        ' current thirst value.
        If thirst > 0 Then
            ' Display the thirst
            ' by updating the thirst label.
            thirst -= 1
            Tlabel.Text = thirst & " /100"
            CalcHappiness()
            If thirst = 20 Then
                MsgBox("Your animal is parched! Please refill its bowl.")
            End If
        Else
            ThirstTimer.Stop()
        End If
    End Sub

    Private Sub DepleteFun() Handles FunTimer.Tick
        ' This integer variable keeps track of the 
        ' current fun value.
        If fun > 0 Then
            ' Display the fun
            ' by updating the fun label.
            fun -= 1
            Flabel.Text = fun & " /100"
            CalcHappiness()
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
            Llabel.Text = love & " /100"
            CalcHappiness()
        Else
            LoveTimer.Stop()
        End If
    End Sub

    Private Sub MainScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\usernpass.accdb"
        connString = provider
        con.ConnectionString = connString
        con.Open()
        Try
            Dim MoneySQL As New OleDbCommand("SELECT Cash FROM Save WHERE @username = username")
            Dim myreader As OleDbDataReader = MoneySQL.ExecuteReader(CommandBehavior.Default)
            myreader.Read()
            Dim cashqu As Object = 0
            If myreader.HasRows Then
                myreader.Read()
                cashqu = myreader(cashqu)
                cashqu = cash
                lblMoney.Text = "Money: " & cash
            End If
            If cashqu = Nothing Then
                MsgBox("Cash Connection Failed, Money Set to $1000", MsgBoxStyle.Critical)

            End If

            myreader.Close()
        Catch ex As Exception

        End Try
        'retrieves the user's current animal from the database along with its sprite.
        Dim myconnection As OleDbConnection
        myconnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\usernpass.accdb")
        Dim mycommand As OleDbCommand
        mycommand = New OleDbCommand("SELECT Animal, MoneyRate, Sprite, FROM Animals WHERE AnimalName = " & currentanimal, myconnection)
        Dim Animal As New OleDbParameter("AnimalName", SqlDbType.VarChar)
        Dim MoneyRate As New OleDbParameter("MoneyRate", SqlDbType.Float)
        Dim Sprite As New OleDbParameter("Sprite", SqlDbType.Image)
        Animal.Value = currentanimal
        MoneyRate.Value = currentmoneyrate
        mycommand.Parameters.Add(Animal)
        mycommand.Parameters.Add(MoneyRate)
        mycommand.Parameters.Add(Sprite)
        mycommand.Connection.Open()
        Dim animalreader As OleDbDataReader = mycommand.ExecuteReader(CommandBehavior.Default)

        'Try
        '    Dim Playedbefore As New OleDbCommand("SELECT Save.[Current Animal]
        'FROM Save; WHERE username = @username")
        '    Dim myreader2 As OleDbDataReader = mycommand.ExecuteReader(CommandBehavior.Default)
        '    myreader2.Read()
        '    'Checks if player currently owns an animal, if not they are taken to the store.
        '    If myreader2.IsDBNull(10) = True Then
        '        formstore.Show()
        '        Me.Hide()
        '        con.Close()

        '    End If
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)
        'End Try
    End Sub



    Private Sub btnwater_Click(sender As Object, e As EventArgs) Handles btnwater.Click

        If thirst < 80 Then
            thirst = thirst + 20
        Else : thirst = 100
        End If

        If cash > 10 Then
            cash = cash - 10
        Else : cash = 0
        End If

        Tlabel.Text = thirst & "/100"
        CalcHappiness()

    End Sub

    Private Sub btnhunger_Click(sender As Object, e As EventArgs) Handles btnfeed.Click
        If hunger < 80 Then
            hunger = hunger + 20
        Else : hunger = 100
        End If

        If cash > 20 Then
            cash = cash - 20
        Else : cash = 0
        End If

        HLabel.Text = hunger & "/100"
        CalcHappiness()

        lblMoney.Text = "Money: £" & cash
    End Sub

    Private Sub btnwash_Click(sender As Object, e As EventArgs) Handles btnwash.Click
        If clean < 25 Then
            clean = clean + 75
        Else : clean = 100
        End If
        Clabel.Text = clean & "/100"
        CalcHappiness()

        Me.Hide()
        Wash.Show()
    End Sub

    Private Sub btnwalk_Click(sender As Object, e As EventArgs) Handles btnwalk.Click
        If fun < 50 Then
            fun = fun + 50
        Else : fun = 100
        End If
        Flabel.Text = fun & "/100"
        CalcHappiness()

        Walkiies.Show()
        Me.Hide()
    End Sub

    Private Sub btncuddle_Click(sender As Object, e As EventArgs) Handles btncuddle.Click
        If love < 50 Then
            love = love + 50
        Else : love = 100
        End If

        Llabel.Text = love & "/100"
        CalcHappiness()

        Me.Hide()
        Cuddle.Show()
    End Sub

    Private Sub fishbowl_Click(sender As Object, e As EventArgs) Handles fishbowlpic.Click
        Fishbowl.Show()
        Me.Hide()
    End Sub

    Private Sub store_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        formstore.Show()
        Me.Hide()
    End Sub

    Private Sub FoodTimer_Tick(sender As Object, e As EventArgs) Handles FoodTimer.Tick
        FoodTimer.Start()
        Dim F As Integer = 1000
        If FoodTimer.Equals(F) Then
            hunger = hunger - 1
            F = F + 1000
            HLabel.Text = (hunger & "/100")
        End If
    End Sub

    Private Sub saveicon_Click(sender As Object, e As EventArgs) Handles SavePic.Click
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\usernpass.accdb"
        connString = provider
        con.Close()
        con.ConnectionString = connString
        con.Open()
        Dim str As String
        str = "Update save set Cash = " & cash & ", Happiness = " & happiness & ", Hunger = " & hunger & ", Thirst = " & thirst & ", Love = " & love & ", Hygiene = " & clean & ", Animal = " & currentanimal & "Fishbowl = " & currentfish

        Dim cmd As OleDbCommand = New OleDbCommand(str, con)
        'Dim check As String

        'check = "SELECT Username FROM Save WHERE Username = " & username & ""

        'Dim cmd2 As OleDbCommand = New OleDbCommand(check, con)

        MsgBox("A Save file already exists for this user, do you wish to overwrite it?")
        cmd.Parameters.Add(New OleDbParameter("Cash", CType(cash, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Happiness", CType(happiness, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Hunger", CType(hunger, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Thirst", CType(thirst, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Love", CType(love, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Hygiene", CType(clean, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Animal", CType(currentanimal, String)))
        cmd.Parameters.Add(New OleDbParameter("Fishbowl", CType(currentfish, String)))

        MsgBox("Saved Successfully")

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        cmd.Parameters.Add(New OleDbParameter("Username", CType(username, String)))
        cmd.Parameters.Add(New OleDbParameter("Cash", CType(cash, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Happiness", CType(happiness, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Hunger", CType(hunger, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Thirst", CType(thirst, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Love", CType(love, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Hygiene", CType(clean, Integer)))
        cmd.Parameters.Add(New OleDbParameter("Animal", CType(currentanimal, String)))


        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            MsgBox("Saved Successfully")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)


        End Try
        con.Close()
    End Sub

    Private Sub moneylbl_Click(sender As Object, e As EventArgs) Handles lblMoney.Click
        cash = cash + currentmoneyrate
    End Sub
End Class