Imports System.Data.OleDb


Public Class formstore
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim con As OleDbConnection = New OleDbConnection
    Dim animal As String
    Public cash As Integer




    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Hide()
        MainScreen.Show()
    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        cash = cash - 100
        lblmoney.Text = "Money & " & cash
        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\usernpass.accdb"
        connString = provider
        con.ConnectionString = connString
        con.Open()
        Dim str As String
        str = "INSERT INTO usernames([Current_Animal]) Values (?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, con)
        cmd.Parameters.Add(New OleDbParameter("Current_Animal", CType(animal, String)))
        Me.Hide()
        MainScreen.Show()

    End Sub

    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PictureBox15.Click
        animal = "guineapig"
        cash = cash - 100
        lblmoney.Text = "Money & " & cash
        Me.Hide()
        MainScreen.Show()

    End Sub

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PictureBox16.Click
        animal = "hamster"
        cash = cash - 100
        lblmoney.Text = "Money & " & cash
        Me.Hide()
        MainScreen.Show()

    End Sub

    Private Sub PictureBox17_Click(sender As Object, e As EventArgs) Handles PictureBox17.Click
        animal = "cat"
        cash = cash - 100
        lblmoney.Text = "Money & " & cash
        Me.Hide()
        MainScreen.Show()

    End Sub

    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        animal = "dog"
        cash = cash - 100
        lblmoney.Text = "Money & " & cash
        Me.Hide()
        MainScreen.Show()

    End Sub

    Private Sub PictureBox12_Click(sender As Object, e As EventArgs) Handles PictureBox12.Click
        animal = "koala"
        cash = cash - 100
        lblmoney.Text = "Money & " & cash
        Me.Hide()
        MainScreen.Show()

    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PictureBox13.Click
        animal = "snake"
        cash = cash - 100
        lblmoney.Text = "Money & " & cash
        Me.Hide()
        MainScreen.Show()

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        animal = "crocodile"
        cash = cash - 100
        lblmoney.Text = "Money & " & cash
        Me.Hide()
        MainScreen.Show()

    End Sub

    Private Sub PictureBox18_Click(sender As Object, e As EventArgs) Handles PictureBox18.Click
        animal = "lizard"
        cash = cash - 100
        lblmoney.Text = "Money & " & cash
        Me.Hide()
        MainScreen.Show()

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        animal = "monkey"
        cash = cash - 100
        lblmoney.Text = "Money & " & cash
        Me.Hide()
        MainScreen.Show()

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        animal = "lemur"
        cash = cash - 100
        lblmoney.Text = "Money & " & cash
        Me.Hide()
        MainScreen.Show()

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        animal = "raccoon"
        cash = cash - 100
        lblmoney.Text = "Money & " & cash
        Me.Hide()
        MainScreen.Show()

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        animal = "rabbit"
        cash = cash - 100
        lblmoney.Text = "Money & " & cash
        Me.Hide()
        MainScreen.Show()

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        animal = "rabbit"
        cash = cash - 100
        lblmoney.Text = "Money & " & cash
        Me.Hide()
        MainScreen.Show()

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        animal = "rabbit"
        cash = cash - 100
        lblmoney.Text = "Money & " & cash
        Me.Hide()
        MainScreen.Show()

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        animal = "rabbit"
        cash = cash - 100
        lblmoney.Text = "Money & " & cash
        Me.Hide()
        MainScreen.Show()

    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click
        animal = "rabbit"
        cash = cash - 100
        lblmoney.Text = "Money & " & cash
        Me.Hide()
        MainScreen.Show()

    End Sub

    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles PictureBox19.Click
        animal = "rabbit"
        cash = cash - 100
        lblmoney.Text = "Money & " & cash
        Me.Hide()
        MainScreen.Show()
    End Sub

    Private Sub formstore_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class