Imports MySql.Data.MySqlClient
Public Class view_comments
    Dim cn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim userid As String
    Dim place_name As String
    Private Sub view_comments_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        populate_reviews()
    End Sub

    Private Sub connect()
        cn.ConnectionString = "server = localhost; userid=exp; password=exp.12345; database=dbms;"
        cn.Open()
    End Sub

    Private Sub populate_reviews()
        Dim reader As MySqlDataReader
        Dim Item As String
        Dim cat As String
        Dim reviews As String
        reviews = " "
        cat = "review"
        cmd.Connection = cn
        userid = place_view.user_id.Text
        place_name = place_view.cur_place.ToLower()
        cmd.CommandText = "SELECT  review FROM reviews where place_name = @placename AND review_category = @cat order by rating desc;"
        cmd.Parameters.AddWithValue("@placename", place_name)
        'cmd.Parameters.AddWithValue("@userid", userid)
        cmd.Parameters.AddWithValue("@cat", cat)
        cmd.Prepare()
        reader = cmd.ExecuteReader()
        If reader.HasRows Then
            Do While reader.Read()
                Item = reader.Item("review")
                reviews = reviews + "' " + Item + " '" + "  - " + userid + Environment.NewLine
            Loop
        End If
        comments_box.Text = reviews
        reader.Close()
        cmd.Parameters.Clear()
    End Sub

End Class