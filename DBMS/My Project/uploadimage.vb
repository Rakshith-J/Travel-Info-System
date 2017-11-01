Imports MySql.Data.MySqlClient
Imports System.IO
Public Class uploadimage
    Dim cmd As New MySqlCommand
    Dim cn As New MySqlConnection
    Private Sub browse_Click(sender As Object, e As EventArgs) Handles browse.Click
        Dim opf As New OpenFileDialog
        opf.Filter = "Choose image(*JPG;*PNG;*GIF)|*jpg;*png;*gif"
        If opf.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(opf.FileName)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub uploadimage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "server = localhost; userid=exp; password=exp.12345; database=dbms;"
        cn.Open()
        cmd.Connection = cn
    End Sub

    Private Sub upload_Click(sender As Object, e As EventArgs) Handles upload.Click
        Dim mem As New MemoryStream
        If IsNothing(PictureBox1.Image) Then
            MsgBox("Please select an image")
        Else
            PictureBox1.Image.Save(mem, PictureBox1.Image.RawFormat)
        cmd.CommandText = "Insert into pictures(userid,place_id,picture) values(@id,@place,@pic);"
        cmd.Parameters.AddWithValue("@id", place_view.user_id.Text)
        cmd.Parameters.AddWithValue("@place", place_view.place_id)
        cmd.Parameters.Add("@pic", MySqlDbType.Blob).Value = mem.ToArray
        If cmd.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Uploaded")
                My.Forms.uploadimage.Close()
            Else
                MessageBox.Show("ERROR !!! retry")
            End If
        End If
    End Sub
End Class