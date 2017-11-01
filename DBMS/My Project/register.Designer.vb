<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class register_page
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(register_page))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.check = New System.Windows.Forms.Button()
        Me.uname = New System.Windows.Forms.TextBox()
        Me.userId = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.TextBox()
        Me.rpassword = New System.Windows.Forms.TextBox()
        Me.register_but = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.answer = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(430, 135)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(426, 171)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "UserId : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(406, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(346, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Re-Enter password : "
        '
        'check
        '
        Me.check.Location = New System.Drawing.Point(593, 168)
        Me.check.Name = "check"
        Me.check.Size = New System.Drawing.Size(75, 23)
        Me.check.TabIndex = 9
        Me.check.Text = "Check"
        Me.check.UseVisualStyleBackColor = True
        '
        'uname
        '
        Me.uname.Location = New System.Drawing.Point(487, 132)
        Me.uname.Name = "uname"
        Me.uname.Size = New System.Drawing.Size(100, 20)
        Me.uname.TabIndex = 10
        '
        'userId
        '
        Me.userId.Location = New System.Drawing.Point(487, 170)
        Me.userId.Name = "userId"
        Me.userId.Size = New System.Drawing.Size(100, 20)
        Me.userId.TabIndex = 11
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(487, 209)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(100, 20)
        Me.password.TabIndex = 12
        Me.password.UseSystemPasswordChar = True
        '
        'rpassword
        '
        Me.rpassword.Location = New System.Drawing.Point(487, 247)
        Me.rpassword.Name = "rpassword"
        Me.rpassword.Size = New System.Drawing.Size(100, 20)
        Me.rpassword.TabIndex = 13
        Me.rpassword.UseSystemPasswordChar = True
        '
        'register_but
        '
        Me.register_but.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.register_but.ForeColor = System.Drawing.Color.LimeGreen
        Me.register_but.Location = New System.Drawing.Point(733, 441)
        Me.register_but.Name = "register_but"
        Me.register_but.Size = New System.Drawing.Size(103, 23)
        Me.register_but.TabIndex = 14
        Me.register_but.Text = "Register"
        Me.register_but.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"What is your favourite sports team ?", "What is your mother's maiden name ?", "Who is your favourite personality ?", "What is your pet name ?", "What is your favourite color ?"})
        Me.ListBox1.Location = New System.Drawing.Point(487, 273)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(314, 43)
        Me.ListBox1.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(289, 283)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(198, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Select your security question :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(357, 332)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(130, 15)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Enter your answer :"
        '
        'answer
        '
        Me.answer.Location = New System.Drawing.Point(487, 331)
        Me.answer.Name = "answer"
        Me.answer.Size = New System.Drawing.Size(100, 20)
        Me.answer.TabIndex = 19
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(842, 441)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Back to login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'register_page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1022, 516)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.answer)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.register_but)
        Me.Controls.Add(Me.rpassword)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.userId)
        Me.Controls.Add(Me.uname)
        Me.Controls.Add(Me.check)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "register_page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents check As Button
    Friend WithEvents uname As TextBox
    Friend WithEvents userId As TextBox
    Friend WithEvents password As TextBox
    Friend WithEvents rpassword As TextBox
    Friend WithEvents register_but As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents answer As TextBox
    Friend WithEvents Button1 As Button
End Class
