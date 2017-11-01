Imports MySql.Data.MySqlClient
Public Class forgot_pass
    Dim cn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim user_id As String
    Private Sub forgot_pass_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "server = localhost; userid=exp; password=exp.12345; database=dbms;"
        cn.Open()
        passwd_box.Enabled = False
        rpasswd_box.Enabled = False
        passwd_box.Visible = False
        rpasswd_box.Visible = False
        Label4.Visible = False
        Label5.Visible = False
    End Sub

    Private Sub check_Click(sender As Object, e As EventArgs) Handles check.Click
        Dim securityq As String
        Dim securitya As String
        Dim rd As MySqlDataReader
        user_id = user_id_box.Text
        cmd.Connection = cn
        cmd.CommandText = "SELECT securityq,securitya from userdb where userid = @id;"
        cmd.Parameters.AddWithValue("@id", user_id)
        rd = cmd.ExecuteReader()
        If rd.Read() Then
            securityq = rd.GetString(0)
            securitya = rd.GetString(1)
        End If
        If securityq.Equals(ListBox1.SelectedItem.ToString()) And securitya.Equals(answer_box.Text) Then
            passwd_box.Enabled = True
            rpasswd_box.Enabled = True
            passwd_box.Visible = True
            rpasswd_box.Visible = True
            Label4.Visible = True
            Label5.Visible = True
        Else
            MsgBox("Wrong credentials !!")
            answer_box.Clear()
        End If
        rd.Close()
        cmd.Parameters.Clear()
    End Sub

    Private Sub submit_Click(sender As Object, e As EventArgs) Handles submit.Click
        user_id = user_id_box.Text
        cmd.Connection = cn
        If passwd_box.Text.Equals(rpasswd_box.Text) Then
            cmd.CommandText = "UPDATE userdb set passwords = @passwd where userid = @id;"
            cmd.Parameters.AddWithValue("@id", user_id)
            cmd.Parameters.AddWithValue("@passwd", passwd_box.Text)
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
            MsgBox("Changes saved " + user_id + "!!")
            My.Forms.login.Show()
            My.Forms.forgot_pass.Close()
        Else
            MsgBox("passwords did not match !!")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Forms.login.Show()
        My.Forms.forgot_pass.Close()
    End Sub
End Class