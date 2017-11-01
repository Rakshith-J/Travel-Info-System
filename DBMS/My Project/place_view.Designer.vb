<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class place_view
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(place_view))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.report_link = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.logout_link = New System.Windows.Forms.Label()
        Me.user_id = New System.Windows.Forms.Label()
        Me.places_box = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.write_review_button = New System.Windows.Forms.Button()
        Me.address_box = New System.Windows.Forms.RichTextBox()
        Me.search_button = New System.Windows.Forms.Button()
        Me.search_box = New System.Windows.Forms.TextBox()
        Me.website_label = New System.Windows.Forms.Label()
        Me.address_label = New System.Windows.Forms.Label()
        Me.phone_label = New System.Windows.Forms.Label()
        Me.expense_label = New System.Windows.Forms.Label()
        Me.timings_label = New System.Windows.Forms.Label()
        Me.rating_label = New System.Windows.Forms.Label()
        Me.place_about_box = New System.Windows.Forms.RichTextBox()
        Me.place_pic = New System.Windows.Forms.PictureBox()
        Me.place_name_label = New System.Windows.Forms.Label()
        Me.home_link = New System.Windows.Forms.Button()
        Me.slideshow = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.place_pic, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.SplitContainer1.Panel1.BackgroundImage = CType(resources.GetObject("SplitContainer1.Panel1.BackgroundImage"), System.Drawing.Image)
        Me.SplitContainer1.Panel1.Controls.Add(Me.report_link)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.logout_link)
        Me.SplitContainer1.Panel1.Controls.Add(Me.user_id)
        Me.SplitContainer1.Panel1.Controls.Add(Me.places_box)
        Me.SplitContainer1.Panel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SplitContainer1.Panel1.ForeColor = System.Drawing.Color.White
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackgroundImage = CType(resources.GetObject("SplitContainer1.Panel2.BackgroundImage"), System.Drawing.Image)
        Me.SplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Panel2.Controls.Add(Me.slideshow)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.write_review_button)
        Me.SplitContainer1.Panel2.Controls.Add(Me.address_box)
        Me.SplitContainer1.Panel2.Controls.Add(Me.search_button)
        Me.SplitContainer1.Panel2.Controls.Add(Me.search_box)
        Me.SplitContainer1.Panel2.Controls.Add(Me.website_label)
        Me.SplitContainer1.Panel2.Controls.Add(Me.address_label)
        Me.SplitContainer1.Panel2.Controls.Add(Me.phone_label)
        Me.SplitContainer1.Panel2.Controls.Add(Me.expense_label)
        Me.SplitContainer1.Panel2.Controls.Add(Me.timings_label)
        Me.SplitContainer1.Panel2.Controls.Add(Me.rating_label)
        Me.SplitContainer1.Panel2.Controls.Add(Me.place_about_box)
        Me.SplitContainer1.Panel2.Controls.Add(Me.place_pic)
        Me.SplitContainer1.Panel2.Controls.Add(Me.place_name_label)
        Me.SplitContainer1.Panel2.Controls.Add(Me.home_link)
        Me.SplitContainer1.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SplitContainer1.Panel2.ForeColor = System.Drawing.Color.White
        Me.SplitContainer1.Size = New System.Drawing.Size(1041, 486)
        Me.SplitContainer1.SplitterDistance = 213
        Me.SplitContainer1.TabIndex = 0
        '
        'report_link
        '
        Me.report_link.BackColor = System.Drawing.SystemColors.HotTrack
        Me.report_link.Location = New System.Drawing.Point(47, 27)
        Me.report_link.Name = "report_link"
        Me.report_link.Size = New System.Drawing.Size(168, 23)
        Me.report_link.TabIndex = 15
        Me.report_link.Text = "Report error"
        Me.report_link.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(-2, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(217, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Places"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'logout_link
        '
        Me.logout_link.BackColor = System.Drawing.SystemColors.HotTrack
        Me.logout_link.Location = New System.Drawing.Point(2, 27)
        Me.logout_link.Name = "logout_link"
        Me.logout_link.Size = New System.Drawing.Size(49, 23)
        Me.logout_link.TabIndex = 1
        Me.logout_link.Text = "Logout"
        Me.logout_link.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'user_id
        '
        Me.user_id.BackColor = System.Drawing.SystemColors.HotTrack
        Me.user_id.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user_id.ForeColor = System.Drawing.Color.White
        Me.user_id.Location = New System.Drawing.Point(2, 0)
        Me.user_id.Name = "user_id"
        Me.user_id.Size = New System.Drawing.Size(212, 27)
        Me.user_id.TabIndex = 1
        Me.user_id.Text = "Label1"
        Me.user_id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'places_box
        '
        Me.places_box.BackColor = System.Drawing.SystemColors.ControlLight
        Me.places_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.places_box.ForeColor = System.Drawing.Color.Red
        Me.places_box.FormattingEnabled = True
        Me.places_box.Location = New System.Drawing.Point(1, 97)
        Me.places_box.Name = "places_box"
        Me.places_box.Size = New System.Drawing.Size(214, 420)
        Me.places_box.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.MediumBlue
        Me.Label3.Location = New System.Drawing.Point(480, 449)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(225, 15)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Have a good picture of this place?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.ForestGreen
        Me.Label2.Location = New System.Drawing.Point(711, 449)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Upload here"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(696, 298)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 23)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "View reviews"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'write_review_button
        '
        Me.write_review_button.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.write_review_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.write_review_button.Location = New System.Drawing.Point(516, 298)
        Me.write_review_button.Name = "write_review_button"
        Me.write_review_button.Size = New System.Drawing.Size(183, 23)
        Me.write_review_button.TabIndex = 13
        Me.write_review_button.Text = "Write a review"
        Me.write_review_button.UseVisualStyleBackColor = False
        '
        'address_box
        '
        Me.address_box.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.address_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address_box.ForeColor = System.Drawing.Color.MediumBlue
        Me.address_box.Location = New System.Drawing.Point(61, 365)
        Me.address_box.Name = "address_box"
        Me.address_box.ReadOnly = True
        Me.address_box.Size = New System.Drawing.Size(760, 36)
        Me.address_box.TabIndex = 12
        Me.address_box.Text = ""
        '
        'search_button
        '
        Me.search_button.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.search_button.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_button.Location = New System.Drawing.Point(734, 59)
        Me.search_button.Name = "search_button"
        Me.search_button.Size = New System.Drawing.Size(75, 23)
        Me.search_button.TabIndex = 11
        Me.search_button.Text = "Search"
        Me.search_button.UseVisualStyleBackColor = False
        '
        'search_box
        '
        Me.search_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search_box.Location = New System.Drawing.Point(637, 59)
        Me.search_box.Name = "search_box"
        Me.search_box.Size = New System.Drawing.Size(100, 23)
        Me.search_box.TabIndex = 10
        '
        'website_label
        '
        Me.website_label.AutoSize = True
        Me.website_label.BackColor = System.Drawing.Color.Transparent
        Me.website_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.website_label.ForeColor = System.Drawing.Color.MediumBlue
        Me.website_label.Location = New System.Drawing.Point(4, 401)
        Me.website_label.Name = "website_label"
        Me.website_label.Size = New System.Drawing.Size(51, 15)
        Me.website_label.TabIndex = 9
        Me.website_label.Text = "Label6"
        '
        'address_label
        '
        Me.address_label.AutoSize = True
        Me.address_label.BackColor = System.Drawing.Color.Transparent
        Me.address_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address_label.ForeColor = System.Drawing.Color.MediumBlue
        Me.address_label.Location = New System.Drawing.Point(4, 365)
        Me.address_label.Name = "address_label"
        Me.address_label.Size = New System.Drawing.Size(62, 15)
        Me.address_label.TabIndex = 8
        Me.address_label.Text = "Address:"
        '
        'phone_label
        '
        Me.phone_label.AutoSize = True
        Me.phone_label.BackColor = System.Drawing.Color.Transparent
        Me.phone_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phone_label.ForeColor = System.Drawing.Color.MediumBlue
        Me.phone_label.Location = New System.Drawing.Point(3, 350)
        Me.phone_label.Name = "phone_label"
        Me.phone_label.Size = New System.Drawing.Size(51, 15)
        Me.phone_label.TabIndex = 7
        Me.phone_label.Text = "Label4"
        '
        'expense_label
        '
        Me.expense_label.AutoSize = True
        Me.expense_label.BackColor = System.Drawing.Color.Transparent
        Me.expense_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.expense_label.ForeColor = System.Drawing.Color.MediumBlue
        Me.expense_label.Location = New System.Drawing.Point(3, 335)
        Me.expense_label.Name = "expense_label"
        Me.expense_label.Size = New System.Drawing.Size(51, 15)
        Me.expense_label.TabIndex = 6
        Me.expense_label.Text = "Label3"
        '
        'timings_label
        '
        Me.timings_label.AutoSize = True
        Me.timings_label.BackColor = System.Drawing.Color.Transparent
        Me.timings_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.timings_label.ForeColor = System.Drawing.Color.MediumBlue
        Me.timings_label.Location = New System.Drawing.Point(3, 320)
        Me.timings_label.Name = "timings_label"
        Me.timings_label.Size = New System.Drawing.Size(51, 15)
        Me.timings_label.TabIndex = 5
        Me.timings_label.Text = "Label2"
        '
        'rating_label
        '
        Me.rating_label.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rating_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rating_label.ForeColor = System.Drawing.Color.DarkBlue
        Me.rating_label.Location = New System.Drawing.Point(662, 112)
        Me.rating_label.Name = "rating_label"
        Me.rating_label.Size = New System.Drawing.Size(147, 16)
        Me.rating_label.TabIndex = 4
        Me.rating_label.Text = "Label2"
        '
        'place_about_box
        '
        Me.place_about_box.BackColor = System.Drawing.SystemColors.Info
        Me.place_about_box.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.place_about_box.ForeColor = System.Drawing.Color.DarkRed
        Me.place_about_box.Location = New System.Drawing.Point(172, 131)
        Me.place_about_box.Name = "place_about_box"
        Me.place_about_box.ReadOnly = True
        Me.place_about_box.Size = New System.Drawing.Size(637, 161)
        Me.place_about_box.TabIndex = 3
        Me.place_about_box.Text = ""
        '
        'place_pic
        '
        Me.place_pic.BackColor = System.Drawing.Color.Transparent
        Me.place_pic.Location = New System.Drawing.Point(3, 131)
        Me.place_pic.Name = "place_pic"
        Me.place_pic.Size = New System.Drawing.Size(172, 161)
        Me.place_pic.TabIndex = 2
        Me.place_pic.TabStop = False
        '
        'place_name_label
        '
        Me.place_name_label.AutoSize = True
        Me.place_name_label.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.place_name_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.place_name_label.ForeColor = System.Drawing.Color.DarkBlue
        Me.place_name_label.Location = New System.Drawing.Point(3, 82)
        Me.place_name_label.Name = "place_name_label"
        Me.place_name_label.Size = New System.Drawing.Size(72, 24)
        Me.place_name_label.TabIndex = 1
        Me.place_name_label.Text = "Label2"
        '
        'home_link
        '
        Me.home_link.BackColor = System.Drawing.SystemColors.HotTrack
        Me.home_link.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.home_link.Location = New System.Drawing.Point(3, 3)
        Me.home_link.Name = "home_link"
        Me.home_link.Size = New System.Drawing.Size(812, 50)
        Me.home_link.TabIndex = 0
        Me.home_link.Text = "Travel Info System"
        Me.home_link.UseVisualStyleBackColor = False
        '
        'slideshow
        '
        Me.slideshow.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.slideshow.Location = New System.Drawing.Point(28, 294)
        Me.slideshow.Name = "slideshow"
        Me.slideshow.Size = New System.Drawing.Size(109, 23)
        Me.slideshow.TabIndex = 17
        Me.slideshow.Text = "View more images"
        Me.slideshow.UseVisualStyleBackColor = False
        '
        'place_view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 486)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MaximizeBox = False
        Me.Name = "place_view"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Place"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.place_pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents home_link As Button
    Friend WithEvents places_box As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents logout_link As Label
    Friend WithEvents user_id As Label
    Friend WithEvents place_name_label As Label
    Friend WithEvents place_about_box As RichTextBox
    Friend WithEvents place_pic As PictureBox
    Friend WithEvents website_label As Label
    Friend WithEvents address_label As Label
    Friend WithEvents phone_label As Label
    Friend WithEvents expense_label As Label
    Friend WithEvents timings_label As Label
    Friend WithEvents rating_label As Label
    Friend WithEvents search_button As Button
    Friend WithEvents search_box As TextBox
    Friend WithEvents address_box As RichTextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents write_review_button As Button
    Friend WithEvents report_link As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents slideshow As Button
End Class
