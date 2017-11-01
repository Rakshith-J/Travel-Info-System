Imports MySql.Data.MySqlClient
Imports System.IO

Public Class place_view
    Dim cn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim cur_category As String
    Public cur_place As String
    Dim cur_city As String
    Public review_cat As String
    Public place_id As Int16
    Dim place_website As String
    Private Sub place_view_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        user_id.Text = city_view.city_user_name.Text
        cur_category = city_view.selected_category
        cur_city = city_view.cur_city
        cur_place = "bangalore palace"
        populate_places()
        load_place()
    End Sub

    Private Sub connect()
        cn.ConnectionString = "server = localhost; userid=exp; password=exp.12345; database=dbms;"
        cn.Open()
    End Sub

    Private Sub populate_places()
        Dim reader As MySqlDataReader
        Dim Item As String
        cmd.Connection = cn
        cmd.CommandText = "SELECT place_name FROM places where city_name = @cityname AND category = @plcat order by place_name;"
        cmd.Parameters.AddWithValue("@cityname", cur_city)
        cmd.Parameters.AddWithValue("@plcat", cur_category)
        cmd.Prepare()
        reader = cmd.ExecuteReader()
        If reader.HasRows Then
            Do While reader.Read()
                Item = reader.Item("place_name")
                places_box.Items.Add(New ListViewItem(Item).Text.ToUpper)
            Loop
        End If
        reader.Close()
    End Sub

    Public Sub load_place()
        Dim place_address As String
        Dim place_about As String
        Dim place_phone As String
        Dim place_website As String
        Dim place_rating As String
        Dim place_expense As String
        Dim place_timing As String
        Dim citytag As String
        Dim reader As MySqlDataReader

        cmd.Connection = cn
        cmd.CommandText = "SELECT city_name FROM places where place_name = @placename"
        cmd.Parameters.AddWithValue("@placename", cur_place)
        cmd.Prepare()
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            citytag = reader.GetString(0)
            cur_city = citytag
        End If
        cmd.Parameters.Clear()
        reader.Close()
        cmd.CommandText = "SELECT place_about FROM places where place_name = @placename"
        cmd.Parameters.AddWithValue("@placename", cur_place)
        cmd.Prepare()
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            place_about = reader.GetString(0)
        End If
        cmd.Parameters.Clear()
        reader.Close()
        cmd.CommandText = "SELECT place_id FROM places where place_name = @placename"
        cmd.Parameters.AddWithValue("@placename", cur_place)
        cmd.Prepare()
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            place_id = reader.GetString(0)
        End If
        cmd.Parameters.Clear()
        reader.Close()
        cmd.CommandText = "SELECT avg_rating FROM places where place_name = @placename"
        cmd.Parameters.AddWithValue("@placename", cur_place)
        cmd.Prepare()
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            place_rating = reader.GetString(0)
        End If
        cmd.Parameters.Clear()
        reader.Close()
        cmd.CommandText = "SELECT address FROM places where place_name = @placename"
        cmd.Parameters.AddWithValue("@placename", cur_place)
        cmd.Prepare()
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            place_address = reader.GetString(0)
        End If
        cmd.Parameters.Clear()
        reader.Close()
        cmd.CommandText = "SELECT phone FROM places where place_name = @placename"
        cmd.Parameters.AddWithValue("@placename", cur_place)
        cmd.Prepare()
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            place_phone = reader.GetString(0)
        End If
        cmd.Parameters.Clear()
        reader.Close()
        cmd.CommandText = "SELECT website FROM places where place_name = @placename"
        cmd.Parameters.AddWithValue("@placename", cur_place)
        cmd.Prepare()
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            place_website = reader.GetString(0)
        End If
        cmd.Parameters.Clear()
        reader.Close()
        cmd.CommandText = "SELECT place_timings FROM places where place_name = @placename"
        cmd.Parameters.AddWithValue("@placename", cur_place)
        cmd.Prepare()
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            place_timing = reader.GetString(0)
        End If
        cmd.Parameters.Clear()
        reader.Close()
        cmd.CommandText = "SELECT expense FROM places where place_name = @placename"
        cmd.Parameters.AddWithValue("@placename", cur_place)
        cmd.Prepare()
        reader = cmd.ExecuteReader()
        If reader.Read() Then
            place_expense = reader.GetString(0)
        End If
        cmd.Parameters.Clear()
        reader.Close()

        place_name_label.Text = cur_place.ToUpper + " - " + citytag.ToUpper
        place_about_box.Text = "' " + place_about + " '"
        address_box.Text = place_address
        website_label.Text = "Website: " + place_website
        phone_label.Text = "Phone: " + place_phone
        expense_label.Text = "Estimated expense (excluding travel):" + place_expense
        timings_label.Text = place_timing
        rating_label.Text = "Average rating : " + place_rating + "/5"
        loadimage()
    End Sub

    Private Sub loadimage()
        Dim reader As MySqlDataReader
        cmd.Connection = cn
        cmd.CommandText = "SELECT place_img FROM places where place_name = @placename;"
        cmd.Parameters.AddWithValue("@placename", cur_place)
        reader = cmd.ExecuteReader
        While reader.Read
            Dim byteImage() As Byte = reader("place_img")
            Dim pic As New System.IO.MemoryStream(byteImage)
            place_pic.Image = Image.FromStream(pic)
            place_pic.SizeMode = PictureBoxSizeMode.Zoom
        End While
        reader.Close()
        cmd.Parameters.Clear()
    End Sub

    Private Sub logout_link_Click(sender As Object, e As EventArgs) Handles logout_link.Click
        My.Forms.login.Show()
        My.Forms.place_view.Close()
    End Sub

    Private Sub places_box_SelectedIndexChanged(sender As Object, e As EventArgs) Handles places_box.SelectedIndexChanged
        Dim curItem As String = places_box.SelectedItem.ToString()
        cur_place = curItem
        load_place()
    End Sub

    Private Sub search_button_Click(sender As Object, e As EventArgs) Handles search_button.Click
        Dim search_text As String
        Dim reader As MySqlDataReader
        Dim Item As String
        places_box.Items.Clear()
        search_text = "%" + search_box.Text.ToLower() + "%"
        cmd.Connection = cn
        cmd.CommandText = "SELECT place_name FROM places where place_name LIKE @searchname"
        cmd.Parameters.AddWithValue("@searchname", search_text)
        cmd.Prepare()
        reader = cmd.ExecuteReader()
        If reader.HasRows Then
            Do While reader.Read()
                Item = reader.Item("place_name")
                places_box.Items.Add(New ListViewItem(Item).Text.ToUpper)
            Loop
        Else
            MsgBox("No results found")
        End If
        cmd.Parameters.Clear()
        reader.Close()
    End Sub

    Private Sub home_link_Click(sender As Object, e As EventArgs) Handles home_link.Click
        My.Forms.homepage.Show()
        homepage.user_name.Text = user_id.Text
        My.Forms.place_view.Close()
    End Sub

    Private Sub write_review_button_Click(sender As Object, e As EventArgs) Handles write_review_button.Click
        review_cat = "review"
        My.Forms.write_review.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Forms.view_comments.Show()
    End Sub

    Private Sub report_link_Click(sender As Object, e As EventArgs) Handles report_link.Click
        review_cat = "report"
        My.Forms.write_review.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        My.Forms.uploadimage.Show()
    End Sub

    Private Sub slideshow_Click(sender As Object, e As EventArgs) Handles slideshow.Click
        My.Forms.Slideshow.Show()
    End Sub
End Class