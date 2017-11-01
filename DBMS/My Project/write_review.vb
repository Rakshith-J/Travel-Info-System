Imports MySql.Data.MySqlClient
Public Class write_review
    Dim cn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim rating As Int16
    Dim qtype As String
    Private Sub write_review_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        review_category.Text = place_view.review_cat.ToUpper()
        checkuser()
    End Sub

    Private Sub connect()
        cn.ConnectionString = "server = localhost; userid=exp; password=exp.12345; database=dbms;"
        cn.Open()
    End Sub

    Private Sub select_1_CheckedChanged(sender As Object, e As EventArgs) Handles select_1.CheckedChanged
        rating = 1
    End Sub

    Private Sub select_2_CheckedChanged(sender As Object, e As EventArgs) Handles select_2.CheckedChanged
        rating = 2
    End Sub

    Private Sub select_3_CheckedChanged(sender As Object, e As EventArgs) Handles select_3.CheckedChanged
        rating = 3
    End Sub

    Private Sub select_4_CheckedChanged(sender As Object, e As EventArgs) Handles select_4.CheckedChanged
        rating = 4
    End Sub

    Private Sub select_5_CheckedChanged(sender As Object, e As EventArgs) Handles select_5.CheckedChanged
        rating = 5
    End Sub

    Private Sub checkuser()
        Dim reader As MySqlDataReader
        cmd.Connection = cn
        cmd.CommandText = "SELECT * from reviews WHERE place_name=@placename AND user_id=@userid;"
        cmd.Parameters.AddWithValue("@userid", place_view.user_id.Text)
        cmd.Parameters.AddWithValue("@placename", place_view.cur_place.ToLower)
        cmd.Prepare()
        reader = cmd.ExecuteReader()
        If reader.HasRows() Then
            qtype = "update"
        Else qtype = "new"
        End If
        cmd.Parameters.Clear()
        reader.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cmd.Connection = cn
        If qtype = "new" Then
            cmd.CommandText = "INSERT INTO reviews(user_id,place_name,rating,review,review_category,place_id)values(@userid,@placename,@rating,@review,@reviewcategory,@id);"
            cmd.Parameters.AddWithValue("@userid", place_view.user_id.Text)
            cmd.Parameters.AddWithValue("@placename", place_view.cur_place.ToLower)
            cmd.Parameters.AddWithValue("@rating", rating)
            cmd.Parameters.AddWithValue("@review", review_box.Text)
            cmd.Parameters.AddWithValue("@reviewcategory", review_category.Text.ToLower)
            cmd.Parameters.AddWithValue("@id", place_view.place_id)
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
            cmd.CommandText = "UPDATE places SET review_number = review_number+1 WHERE place_name=@placename;"
            cmd.Parameters.AddWithValue("@placename", place_view.cur_place.ToLower)
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
        Else
            cmd.CommandText = "UPDATE reviews SET review=@review,rating=@rating WHERE place_name=@placename AND user_id=@userid;"
            cmd.Parameters.AddWithValue("@rating", rating)
            cmd.Parameters.AddWithValue("@userid", place_view.user_id.Text)
            cmd.Parameters.AddWithValue("@placename", place_view.cur_place.ToLower)
            cmd.Parameters.AddWithValue("@review", review_box.Text)
            cmd.ExecuteNonQuery()
            cmd.Parameters.Clear()
        End If
        cmd.CommandText = "UPDATE places SET avg_rating = (select AVG(rating) from reviews WHERE place_name=@placename) WHERE place_name=@placename;"
        cmd.Parameters.AddWithValue("@placename", place_view.cur_place.ToLower)
        cmd.ExecuteNonQuery()
        cmd.Parameters.Clear()
        My.Forms.write_review.Close()
    End Sub
End Class