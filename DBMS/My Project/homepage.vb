Imports MySql.Data.MySqlClient
Public Class homepage
    Dim cn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Public selected_city As String
    Private Sub homepage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connect()
        user_name.Text = login.user_id
        info_box.Text = "Whenever tourists want to visit any particular place in India its hard to get all the information regarding that place .Hence tourists (especially foreign tourists) will miss out on ‘the not so famous but equally beautiful’ tourist attractions in India. Our travel info system seeks to be a comprehensive one stop solution to provide all the travel information related to a place. Hence tourists can plan their trips effectively with a good source of information about their destination. The information about a place includes few lines of‘About the place’, cost estimate of the place , pictures of the place, average user rating of the place, contact details of organization in charge of the place and so on. It also provides ratings to the places in the cities so that the tourists can have an informed decision and plan their trips better .This system will also develop a competitive attitude among the management of the tourist attractions and thus help improve its overall quality.Such an organized system would also help increase foreign tourist arrivals in India thus help the Indian tourism industry inline with the governments ambitious 'Incredible India' initiative."
        populate_cities()
    End Sub

    Private Sub connect()
        cn.ConnectionString = "server = localhost; userid=exp; password=exp.12345; database=dbms;"
        cn.Open()
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
                citiesbox.Items.Add(New ListViewItem(Item).Text.ToUpper)
            Loop
        End If
        reader.Close()
    End Sub

    Private Sub login_link_Click(sender As Object, e As EventArgs) Handles login_link.Click
        My.Forms.login.Show()
        My.Forms.homepage.Close()
    End Sub

    Private Sub citiesbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles citiesbox.SelectedIndexChanged
        Dim curItem As String = citiesbox.SelectedItem.ToString()
        selected_city = curItem
        My.Forms.city_view.Show()
        My.Forms.homepage.Close()
    End Sub
End Class