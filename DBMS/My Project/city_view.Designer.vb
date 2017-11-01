<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class city_view
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(city_view))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cities_box = New System.Windows.Forms.ListBox()
        Me.logout_link = New System.Windows.Forms.Label()
        Me.city_user_name = New System.Windows.Forms.Label()
        Me.set_park = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.set_monuments = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.set_worship = New System.Windows.Forms.Button()
        Me.set_hotel = New System.Windows.Forms.Button()
        Me.city_about_box = New System.Windows.Forms.RichTextBox()
        Me.city_name = New System.Windows.Forms.Label()
        Me.city_pic = New System.Windows.Forms.PictureBox()
        Me.home_link = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.city_pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackgroundImage = CType(resources.GetObject("SplitContainer1.Panel1.BackgroundImage"), System.Drawing.Image)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cities_box)
        Me.SplitContainer1.Panel1.Controls.Add(Me.logout_link)
        Me.SplitContainer1.Panel1.Controls.Add(Me.city_user_name)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel2.BackgroundImage = CType(resources.GetObject("SplitContainer1.Panel2.BackgroundImage"), System.Drawing.Image)
        Me.SplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Panel2.Controls.Add(Me.set_park)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.set_monuments)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.set_worship)
        Me.SplitContainer1.Panel2.Controls.Add(Me.set_hotel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.city_about_box)
        Me.SplitContainer1.Panel2.Controls.Add(Me.city_name)
        Me.SplitContainer1.Panel2.Controls.Add(Me.city_pic)
        Me.SplitContainer1.Panel2.Controls.Add(Me.home_link)
        Me.SplitContainer1.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SplitContainer1.Panel2.ForeColor = System.Drawing.Color.Red
        Me.SplitContainer1.Size = New System.Drawing.Size(1021, 508)
        Me.SplitContainer1.SplitterDistance = 210
        Me.SplitContainer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 34)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cities"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cities_box
        '
        Me.cities_box.BackColor = System.Drawing.SystemColors.ControlLight
        Me.cities_box.ForeColor = System.Drawing.Color.Red
        Me.cities_box.FormattingEnabled = True
        Me.cities_box.Location = New System.Drawing.Point(0, 87)
        Me.cities_box.Name = "cities_box"
        Me.cities_box.Size = New System.Drawing.Size(209, 420)
        Me.cities_box.TabIndex = 1
        '
        'logout_link
        '
        Me.logout_link.AutoSize = True
        Me.logout_link.BackColor = System.Drawing.SystemColors.HotTrack
        Me.logout_link.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout_link.ForeColor = System.Drawing.Color.White
        Me.logout_link.Location = New System.Drawing.Point(3, 28)
        Me.logout_link.Name = "logout_link"
        Me.logout_link.Size = New System.Drawing.Size(55, 17)
        Me.logout_link.TabIndex = 1
        Me.logout_link.Text = "LogOut"
        '
        'city_user_name
        '
        Me.city_user_name.BackColor = System.Drawing.SystemColors.HotTrack
        Me.city_user_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.city_user_name.ForeColor = System.Drawing.Color.White
        Me.city_user_name.Location = New System.Drawing.Point(3, 3)
        Me.city_user_name.Name = "city_user_name"
        Me.city_user_name.Size = New System.Drawing.Size(206, 25)
        Me.city_user_name.TabIndex = 0
        Me.city_user_name.Text = "Label1"
        Me.city_user_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'set_park
        '
        Me.set_park.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.set_park.Location = New System.Drawing.Point(619, 376)
        Me.set_park.Name = "set_park"
        Me.set_park.Size = New System.Drawing.Size(120, 23)
        Me.set_park.TabIndex = 11
        Me.set_park.Text = "Amusement parks"
        Me.set_park.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.Label2.Location = New System.Drawing.Point(227, 330)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(370, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Explore this city? Check out these categories"
        '
        'set_monuments
        '
        Me.set_monuments.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.set_monuments.Location = New System.Drawing.Point(475, 376)
        Me.set_monuments.Name = "set_monuments"
        Me.set_monuments.Size = New System.Drawing.Size(103, 23)
        Me.set_monuments.TabIndex = 8
        Me.set_monuments.Text = "Monuments"
        Me.set_monuments.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button3.Location = New System.Drawing.Point(290, 376)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(154, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Natural attractions"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'set_worship
        '
        Me.set_worship.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.set_worship.Location = New System.Drawing.Point(133, 376)
        Me.set_worship.Name = "set_worship"
        Me.set_worship.Size = New System.Drawing.Size(130, 23)
        Me.set_worship.TabIndex = 6
        Me.set_worship.Text = "Places of Worship"
        Me.set_worship.UseVisualStyleBackColor = False
        '
        'set_hotel
        '
        Me.set_hotel.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.set_hotel.Location = New System.Drawing.Point(30, 376)
        Me.set_hotel.Name = "set_hotel"
        Me.set_hotel.Size = New System.Drawing.Size(75, 23)
        Me.set_hotel.TabIndex = 5
        Me.set_hotel.Text = "Hotels"
        Me.set_hotel.UseVisualStyleBackColor = False
        '
        'city_about_box
        '
        Me.city_about_box.BackColor = System.Drawing.SystemColors.Info
        Me.city_about_box.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.city_about_box.ForeColor = System.Drawing.Color.DarkRed
        Me.city_about_box.Location = New System.Drawing.Point(185, 115)
        Me.city_about_box.Name = "city_about_box"
        Me.city_about_box.ReadOnly = True
        Me.city_about_box.Size = New System.Drawing.Size(619, 172)
        Me.city_about_box.TabIndex = 3
        Me.city_about_box.Text = ""
        '
        'city_name
        '
        Me.city_name.AutoSize = True
        Me.city_name.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.city_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.city_name.ForeColor = System.Drawing.Color.MidnightBlue
        Me.city_name.Location = New System.Drawing.Point(3, 87)
        Me.city_name.Name = "city_name"
        Me.city_name.Size = New System.Drawing.Size(77, 25)
        Me.city_name.TabIndex = 2
        Me.city_name.Text = "Label2"
        Me.city_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'city_pic
        '
        Me.city_pic.BackColor = System.Drawing.Color.Transparent
        Me.city_pic.Location = New System.Drawing.Point(1, 115)
        Me.city_pic.Name = "city_pic"
        Me.city_pic.Size = New System.Drawing.Size(178, 172)
        Me.city_pic.TabIndex = 1
        Me.city_pic.TabStop = False
        '
        'home_link
        '
        Me.home_link.BackColor = System.Drawing.SystemColors.HotTrack
        Me.home_link.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.home_link.ForeColor = System.Drawing.Color.White
        Me.home_link.Location = New System.Drawing.Point(3, 3)
        Me.home_link.Name = "home_link"
        Me.home_link.Size = New System.Drawing.Size(804, 46)
        Me.home_link.TabIndex = 0
        Me.home_link.Text = "Travel Info System"
        Me.home_link.UseVisualStyleBackColor = False
        '
        'city_view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(1021, 508)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MaximizeBox = False
        Me.Name = "city_view"
        Me.Text = "City"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.city_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents city_user_name As Label
    Friend WithEvents home_link As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cities_box As ListBox
    Friend WithEvents logout_link As Label
    Friend WithEvents city_pic As PictureBox
    Friend WithEvents city_name As Label
    Friend WithEvents city_about_box As RichTextBox
    Friend WithEvents set_park As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents set_monuments As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents set_worship As Button
    Friend WithEvents set_hotel As Button
End Class
