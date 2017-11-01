Imports MySql.Data.MySqlClient
Imports System.IO

Public Class city_view
    Dim cn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Public selected_category As String
    Public cur_city As String

    Private Sub city_view_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        city_user_name.Text = homepage.user_name.Text
        cur_city = homepage.selected_city
        populate_cities()
        load_form()
    End Sub

    Private Sub load_form()
        load_city()
    End Sub

    Private Sub connect()
        cn.ConnectionString = "server = localhost; userid=exp; password=exp.12345; database=dbms;"
        cn.Open()
    End Sub

    Private Sub home_link_Click(sender As Object, e As EventArgs) Handles home_link.Click
        My.Forms.homepage.Show()
        homepage.user_name.Text = city_user_name.Text
        My.Forms.city_view.Close()
    End Sub

    Private Sub logout_link_Click(sender As Object, e As EventArgs) Handles logout_link.Click
        My.Forms.login.Show()
        My.Forms.city_view.Close()
    End Sub

    Public Sub load_city()
        Dim city_id As Int32
        Dim city_state As String
        Dim city_about As String
        Dim reader As MySqlDataReader
        cmd.Connection = cn
        cmd.CommandText = "SELECT state FROM city where city_name = @cityname;"
        cmd.Parameters.AddWithValue("@cityname", cur_city)
        cmd.Prepare()
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            city_state = reader.GetString(0)
        End If
        cmd.Parameters.Clear()
        reader.Close()
        cmd.CommandText = "SELECT city_about FROM city where city_name = @cityname;"
        cmd.Parameters.AddWithValue("@cityname", cur_city)
        cmd.Prepare()
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            city_about = reader.GetString(0)
        End If
        cmd.Parameters.Clear()
        reader.Close()
        cmd.CommandText = "SELECT city_id FROM city where city_name = @cityname;"
        cmd.Parameters.AddWithValue("@cityname", cur_city)
        cmd.Prepare()
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            city_id = reader.GetInt32(0)
        End If
        cmd.Parameters.Clear()
        reader.Close()
        city_name.Text = cur_city.ToUpper + " - " + city_state.ToUpper
        city_about_box.Text = "' " + city_about + " '"
        'SqlBlob2File()
        loadimage()
    End Sub

    Private Sub populate_cities()
        Dim reader As MySqlDataReader
        Dim Item As String
        cmd.Connection = cn
        cmd.CommandText = "SELECT city_name FROM city order by city_name;"
        cmd.Prepare()
        reader = cmd.ExecuteReader()
        If reader.HasRows Then
            Do While reader.Read()
                Item = reader.Item("city_name")
                cities_box.Items.Add(New ListViewItem(Item).Text.ToUpper)
            Loop
        End If
        reader.Close()
    End Sub

    Private Sub cities_box_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cities_box.SelectedIndexChanged
        Dim curItem As String = cities_box.SelectedItem.ToString()
        cur_city = curItem
        load_form()
    End Sub

    Private Sub SqlBlob2File()
        Dim reader As MySqlDataReader
        Dim rawData() As Byte
        Dim FileSize As UInt32
        Dim fs As FileStream

        Try
            cmd.Connection = cn
            cmd.CommandText = "SELECT city_img,LENGTH(city_img) FROM city where city_name = @cityname;"
            cmd.Parameters.AddWithValue("@cityname", cur_city)
            reader = cmd.ExecuteReader

            If Not reader.HasRows Then Throw New Exception("There are no BLOBs to save")
            reader.Read()

            FileSize = reader.GetUInt32(reader.GetOrdinal("LENGTH(city_img)"))
            rawData = New Byte(FileSize) {}

            reader.GetBytes(reader.GetOrdinal("city_img"), 0, rawData, 0, FileSize)

            fs = New FileStream("F:\Travelinfo\city\" + cur_city + ".png", FileMode.OpenOrCreate, FileAccess.Write)
            fs.Write(rawData, 0, FileSize)
            fs.Close()

            'MessageBox.Show("File successfully written to disk!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)

            reader.Close()
            cmd.Parameters.Clear()
        Catch ex As Exception
            MessageBox.Show("There was an error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub loadimage()

        Dim reader As MySqlDataReader
        cmd.Connection = cn
        cmd.CommandText = "SELECT city_img FROM city where city_name = @cityname;"
        cmd.Parameters.AddWithValue("@cityname", cur_city)
        reader = cmd.ExecuteReader
        While reader.Read
            Dim byteImage() As Byte = reader("city_img")
            Dim pic As New System.IO.MemoryStream(byteImage)
            city_pic.Image = Image.FromStream(pic)
            city_pic.SizeMode = PictureBoxSizeMode.Zoom
        End While
        reader.Close()
        cmd.Parameters.Clear()
    End Sub

    Private Sub set_hotel_Click(sender As Object, e As EventArgs) Handles set_hotel.Click
        selected_category = "h"
        My.Forms.place_view.Show()
        My.Forms.city_view.Close()
    End Sub

    Private Sub set_worship_Click(sender As Object, e As EventArgs) Handles set_worship.Click
        selected_category = "pow"
        My.Forms.place_view.Show()
        My.Forms.city_view.Close()
    End Sub

    Private Sub set_monuments_Click(sender As Object, e As EventArgs) Handles set_monuments.Click
        selected_category = "m"
        My.Forms.place_view.Show()
        My.Forms.city_view.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        selected_category = "na"
        My.Forms.place_view.Show()
        My.Forms.city_view.Close()
    End Sub

    Private Sub set_park_Click(sender As Object, e As EventArgs) Handles set_park.Click
        selected_category = "ap"
        My.Forms.place_view.Show()
        My.Forms.city_view.Close()
    End Sub
End Class