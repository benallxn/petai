Imports System.Data.OleDb

Public Class NewAccForm
    Dim provider As String
    Dim dataFile As String
    Dim connString As String
    Dim con As OleDbConnection = New OleDbConnection

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()
        logonform.Visible = True
    End Sub

    Private Sub btncreate_Click(sender As Object, e As EventArgs) Handles btncreate.Click

        provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\usernpass.accdb"
        connString = provider
        con.ConnectionString = connString
        con.Open()
        Dim str As String
        str = "INSERT INTO usernames([Username],[Password],[FullName]) Values (?,?,?)"
        Dim cmd As OleDbCommand = New OleDbCommand(str, con)
        cmd.Parameters.Add(New OleDbParameter("Username", CType(txtusername.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("Password", CType(txtpassword.Text, String)))
        cmd.Parameters.Add(New OleDbParameter("FullName", CType(txtfirstname.Text, String)))
        'stores the user input in the database
        MsgBox("Account Created!")

        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            con.Close()
            txtfirstname.Clear()
            txtusername.Clear()
            txtpassword.Clear()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        Me.Close()
        formstore.Show()
    End Sub

    Private Sub NewAccForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class