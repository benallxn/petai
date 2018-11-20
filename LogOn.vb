Imports System.Data.OleDb
Imports System.IO

Public Class logonform

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles logonbtn.Click
        'a presence check to ensure all fields are completed
        If txtpassword.Text = "" Or txtusername.Text = "" Then
            MsgBox("Please Complete All Fields!")
        Else
            Try
                Dim myconnection As OleDbConnection
                myconnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\usernpass.accdb")
                Dim mycommand As OleDbCommand
                mycommand = New OleDbCommand("SELECT username, password FROM usernames WHERE username = @username AND password = @password", myconnection)
                Dim uname As New OleDbParameter("@username", SqlDbType.VarChar)
                Dim uPassword As New OleDbParameter("@Password", SqlDbType.VarChar)
                uname.Value = txtusername.Text
                uPassword.Value = txtpassword.Text
                mycommand.Parameters.Add(uname)
                mycommand.Parameters.Add(uPassword)
                mycommand.Connection.Open()
                Dim myreader As OleDbDataReader = mycommand.ExecuteReader(CommandBehavior.Default)
                'checks user input against database
                Dim login As Object = 0
                If myreader.HasRows Then
                    myreader.Read()
                    login = myreader(login)
                End If
                If login = Nothing Then
                    MsgBox("Login has failed, Try Again.", MsgBoxStyle.Critical)
                    txtusername.Clear()
                    txtpassword.Clear()
                    txtusername.Focus()

                Else
                    myreader.Close()
                    MsgBox("Successfully Logged In!", MsgBoxStyle.Information)
                    txtusername.Text = ""
                    txtpassword.Text = ""
                    Me.Hide()
                    MainScreen.Show()

                End If

                mycommand.Dispose()
                myconnection.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK)

            End Try

        End If
    End Sub

    Private Sub btnnewacc_Click(sender As Object, e As EventArgs) Handles btnnewacc.Click
        NewAccForm.Visible = True
        Me.Visible = False
    End Sub

    Private Sub logonform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
