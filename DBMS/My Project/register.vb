Imports MySql.Data.MySqlClient
Public Class register_page
    Dim cn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Private Sub register_page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "server = localhost; userid=exp; password=exp.12345; database=dbms;"
        cn.Open()
        password.Enabled = False
        rpassword.Enabled = False
        userId.Enabled = True
    End Sub

    Private Sub check_Click(sender As Object, e As EventArgs) Handles check.Click
        Dim user As String
        Dim input As String
        Dim rd As MySqlDataReader
        input = userId.Text
        cmd.Connection = cn
        cmd.CommandText = "SELECT userid  FROM userdb where userid = @input ;"
        cmd.Parameters.AddWithValue("@input", input)
        rd = cmd.ExecuteReader()
        If rd.Read Then
            user = rd.GetString(0)
        End If
        rd.Close()
        If String.IsNullOrEmpty(user) Then
            MsgBox("You can now set your password")
            password.Enabled = True
            rpassword.Enabled = True
        Else
            MsgBox("User record exists !! Login or use a different Id")
            userId.Clear()
        End If
        cmd.Parameters.Clear()
    End Sub

    Private Sub register_but_Click(sender As Object, e As EventArgs) Handles register_but.Click
        Dim pass As String
        Dim rpass As String
        Dim name As String
        Dim user As String
        Dim securityq As String
        Dim securitya As String
        pass = password.Text
        rpass = rpassword.Text
        securityq = ListBox1.SelectedItem.ToString()
        securitya = answer.Text()
        If pass.Length() < 5 Then
            MsgBox("Enter a password of length >= 5")
            password.Clear()
            rpassword.Clear()
        ElseIf String.Compare(pass, rpass) <> 0 Then
            MsgBox("Re enter correct password")
            rpassword.Clear()
        Else
            user = userId.Text
            name = uname.Text
            cmd.Connection = cn
            cmd.CommandText = "INSERT INTO userdb(userid,name,passwords,securityq,securitya)values(@userid,@name,@password,@question,@answer);"
            cmd.Parameters.AddWithValue("@userid", user)
            cmd.Parameters.AddWithValue("@name", name)
            cmd.Parameters.AddWithValue("@password", pass)
            cmd.Parameters.AddWithValue("@question", securityq)
            cmd.Parameters.AddWithValue("@answer", securitya)
            cmd.ExecuteNonQuery()
            MsgBox("You can now login again !!")
            My.Forms.login.Show()
            My.Forms.register_page.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.login.Show()
        My.Forms.register_page.Close()
    End Sub
End Class