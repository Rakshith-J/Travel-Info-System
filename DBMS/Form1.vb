Imports MySql.Data.MySqlClient
Public Class login
    Dim cn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Public user_id As String
    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "server = localhost; userid=exp; password=exp.12345; database=dbms;"
        cn.Open()
        passwd.Enabled = True
        userid.Enabled = True
    End Sub

    Private Sub login_button_Click_1(sender As Object, e As EventArgs) Handles login_button.Click
        Dim input As String
        Dim pass As String
        Dim user As String
        Dim rd As MySqlDataReader
        input = passwd.Text
        pass = Nothing
        input = passwd.Text
            user = userid.Text
        cmd.Connection = cn
        If check_Click() = 1 Then
            cmd.CommandText = "SELECT passwords from userdb where userid = @userid ;"
            cmd.Parameters.AddWithValue("@userid", user)
            cmd.Prepare()
            rd = cmd.ExecuteReader
            If rd.Read Then
                pass = rd.GetString(0)
            End If
            rd.Close()
            cmd.Parameters.Clear()
            If String.Compare(pass, input) = 0 Then
                user_id = userid.Text
                MsgBox("Welcome back " & user & "!")
                My.Forms.homepage.Show()
                My.Forms.login.Close()
            Else
                MsgBox("Incorrect password.Enter again")
                passwd.Clear()
            End If
        End If
    End Sub

    Function check_Click() As Int16
        Dim user As String
        Dim input As String
        Dim rd As MySqlDataReader
        input = userid.Text
        cmd.Connection = cn
        cmd.CommandText = "SELECT userid  FROM userdb where userid = @input ;"
        cmd.Parameters.AddWithValue("@input", input)
        rd = cmd.ExecuteReader
        If rd.Read Then
            user = rd.GetString(0)
        End If
        cmd.Parameters.Clear()
        rd.Close()
        If String.IsNullOrEmpty(user) Then
            MsgBox("Enter valid userID")
            userid.Clear()
            passwd.Clear()
            Return 0
        End If
        Return 1
    End Function

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        My.Forms.register_page.Show()
        My.Forms.login.Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        My.Forms.forgot_pass.Show()
        My.Forms.login.Close()
    End Sub

End Class
