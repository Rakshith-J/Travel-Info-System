Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Threading

Public Class Slideshow
    Dim cn As New MySqlConnection
    Dim cmd As New MySqlCommand
    Dim placeId As Integer
    Private ImageIndex As Integer = -1
    Private ImageDir As IO.FileInfo()
    Private Sub Slideshow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cn.ConnectionString = "server = localhost; userid=exp; password=exp.12345; database=dbms;"
        cn.Open()
        cmd.Connection = cn
        placeId = place_view.place_id
        GetImages()
    End Sub

    Private Sub GetImages()
        Dim reader As MySqlDataReader
        Dim userid As String
        cmd.CommandText = "Select userid,picture FROM pictures where place_id=@id"
        cmd.Parameters.AddWithValue("@id", placeId)
        Dim fs As FileStream
        Dim bw As BinaryWriter
        Dim BufferSize As Integer = 1024
        Dim ImageData(BufferSize - 1) As Byte
        Dim nBytesReturned, StartIndex As Long
        reader = cmd.ExecuteReader(CommandBehavior.SequentialAccess)

        If (Directory.Exists("Images") = False) Then
            Directory.CreateDirectory("Images")
        End If

        If (Directory.Exists("Images/" + placeId.ToString()) = False) Then
            Directory.CreateDirectory("Images/" + placeId.ToString())
        End If

        If reader.Read = False Then
            MsgBox("No other images found in our database")
            My.Forms.Slideshow.Close()
        Else
            While (reader.Read())
                userid = reader.GetString("userid")
                fs = New FileStream("Images/" + placeId.ToString() + "/" + userid.ToString() + ".jpg", FileMode.OpenOrCreate, FileAccess.Write)
                bw = New BinaryWriter(fs)

                StartIndex = 0
                nBytesReturned = reader.GetBytes(1, StartIndex, ImageData, 0, BufferSize)

                While (nBytesReturned = BufferSize)
                    bw.Write(ImageData)
                    bw.Flush()
                    StartIndex += BufferSize
                    nBytesReturned = reader.GetBytes(1, StartIndex, ImageData, 0, BufferSize)
                End While

                bw.Close()
                fs.Close()
            End While
        End If
        reader.Close()
        cmd.Parameters.Clear()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        GetnextImage()
    End Sub

    Private Sub GetnextImage()
        If Not ImageDir Is Nothing Then
            If ImageIndex < ImageDir.Length - 1 Then
                ImageIndex += 1
                PictureBox1.ImageLocation = ImageDir(ImageIndex).FullName
            ElseIf ImageIndex = ImageDir.Length - 1 Then
                ImageIndex = 0
                PictureBox1.ImageLocation = ImageDir(ImageIndex).FullName
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Button1.Text = "Start Slideshow") Then
            Button1.Text = "Stop Slideshow"
            Button1.ForeColor = Color.Red
            Dim di As New IO.DirectoryInfo("Images/" + placeId.ToString())
            ImageDir = di.GetFiles("*.jpg").ToArray
            Dim dra As IO.FileInfo
            PictureBox1.Dock = DockStyle.Fill
            PictureBox1.BackColor = Color.Black
            PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Timer1.Enabled = True
            GetnextImage()
        Else
            Timer1.Enabled = False
            Button1.Text = "Start Slideshow"
            Button1.ForeColor = Color.LimeGreen
        End If
    End Sub
End Class