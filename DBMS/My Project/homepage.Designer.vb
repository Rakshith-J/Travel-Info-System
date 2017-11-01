<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class homepage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(homepage))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.citiesbox = New System.Windows.Forms.ListBox()
        Me.login_link = New System.Windows.Forms.Label()
        Me.user_name = New System.Windows.Forms.Label()
        Me.info_box = New System.Windows.Forms.RichTextBox()
        Me.home_link = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
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
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.SplitContainer1.Panel1.BackgroundImage = CType(resources.GetObject("SplitContainer1.Panel1.BackgroundImage"), System.Drawing.Image)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.citiesbox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.login_link)
        Me.SplitContainer1.Panel1.Controls.Add(Me.user_name)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.SplitContainer1.Panel2.BackgroundImage = CType(resources.GetObject("SplitContainer1.Panel2.BackgroundImage"), System.Drawing.Image)
        Me.SplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.SplitContainer1.Panel2.Controls.Add(Me.info_box)
        Me.SplitContainer1.Panel2.Controls.Add(Me.home_link)
        Me.SplitContainer1.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SplitContainer1.Panel2.ForeColor = System.Drawing.Color.Red
        Me.SplitContainer1.Size = New System.Drawing.Size(1016, 520)
        Me.SplitContainer1.SplitterDistance = 193
        Me.SplitContainer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(-3, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cities"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'citiesbox
        '
        Me.citiesbox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.citiesbox.ForeColor = System.Drawing.Color.Red
        Me.citiesbox.FormattingEnabled = True
        Me.citiesbox.Location = New System.Drawing.Point(0, 84)
        Me.citiesbox.Name = "citiesbox"
        Me.citiesbox.Size = New System.Drawing.Size(198, 433)
        Me.citiesbox.TabIndex = 1
        '
        'login_link
        '
        Me.login_link.BackColor = System.Drawing.SystemColors.HotTrack
        Me.login_link.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.login_link.ForeColor = System.Drawing.Color.White
        Me.login_link.Location = New System.Drawing.Point(3, 25)
        Me.login_link.Name = "login_link"
        Me.login_link.Size = New System.Drawing.Size(57, 22)
        Me.login_link.TabIndex = 1
        Me.login_link.Text = "Logout"
        '
        'user_name
        '
        Me.user_name.BackColor = System.Drawing.SystemColors.HotTrack
        Me.user_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user_name.ForeColor = System.Drawing.Color.White
        Me.user_name.Location = New System.Drawing.Point(3, 0)
        Me.user_name.Name = "user_name"
        Me.user_name.Size = New System.Drawing.Size(195, 25)
        Me.user_name.TabIndex = 1
        Me.user_name.Text = "Label1"
        Me.user_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'info_box
        '
        Me.info_box.BackColor = System.Drawing.Color.SkyBlue
        Me.info_box.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.info_box.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.info_box.Location = New System.Drawing.Point(7, 84)
        Me.info_box.Name = "info_box"
        Me.info_box.ReadOnly = True
        Me.info_box.Size = New System.Drawing.Size(804, 298)
        Me.info_box.TabIndex = 1
        Me.info_box.Text = ""
        '
        'home_link
        '
        Me.home_link.BackColor = System.Drawing.SystemColors.HotTrack
        Me.home_link.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.home_link.ForeColor = System.Drawing.Color.White
        Me.home_link.Location = New System.Drawing.Point(-2, 0)
        Me.home_link.Name = "home_link"
        Me.home_link.Size = New System.Drawing.Size(821, 47)
        Me.home_link.TabIndex = 0
        Me.home_link.Text = "Travel Info System"
        Me.home_link.UseVisualStyleBackColor = False
        '
        'homepage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1016, 520)
        Me.Controls.Add(Me.SplitContainer1)
        Me.MaximizeBox = False
        Me.Name = "homepage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "home"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents user_name As Label
    Friend WithEvents home_link As Button
    Friend WithEvents login_link As Label
    Friend WithEvents citiesbox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents info_box As RichTextBox
End Class
