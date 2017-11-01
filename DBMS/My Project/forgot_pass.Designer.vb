<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class forgot_pass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(forgot_pass))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.user_id_box = New System.Windows.Forms.TextBox()
        Me.answer_box = New System.Windows.Forms.TextBox()
        Me.check = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.passwd_box = New System.Windows.Forms.TextBox()
        Me.rpasswd_box = New System.Windows.Forms.TextBox()
        Me.submit = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"What is your favourite sports team ?", "What is your mother's maiden name ?", "Who is your favourite personality ?", "What is your pet name ?", "What is your favourite color ?"})
        Me.ListBox1.Location = New System.Drawing.Point(483, 135)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(207, 43)
        Me.ListBox1.TabIndex = 0
        '
        'user_id_box
        '
        Me.user_id_box.Location = New System.Drawing.Point(483, 94)
        Me.user_id_box.Name = "user_id_box"
        Me.user_id_box.Size = New System.Drawing.Size(139, 20)
        Me.user_id_box.TabIndex = 1
        '
        'answer_box
        '
        Me.answer_box.Location = New System.Drawing.Point(483, 200)
        Me.answer_box.Name = "answer_box"
        Me.answer_box.Size = New System.Drawing.Size(100, 20)
        Me.answer_box.TabIndex = 2
        '
        'check
        '
        Me.check.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.check.ForeColor = System.Drawing.Color.Green
        Me.check.Location = New System.Drawing.Point(436, 239)
        Me.check.Name = "check"
        Me.check.Size = New System.Drawing.Size(75, 23)
        Me.check.TabIndex = 3
        Me.check.Text = "Submit"
        Me.check.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(379, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Enter your ID :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(275, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Select your security question : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(343, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Enter your answer : "
        '
        'passwd_box
        '
        Me.passwd_box.Location = New System.Drawing.Point(483, 299)
        Me.passwd_box.Name = "passwd_box"
        Me.passwd_box.Size = New System.Drawing.Size(100, 20)
        Me.passwd_box.TabIndex = 7
        Me.passwd_box.UseSystemPasswordChar = True
        '
        'rpasswd_box
        '
        Me.rpasswd_box.Location = New System.Drawing.Point(483, 340)
        Me.rpasswd_box.Name = "rpasswd_box"
        Me.rpasswd_box.Size = New System.Drawing.Size(100, 20)
        Me.rpasswd_box.TabIndex = 8
        Me.rpasswd_box.UseSystemPasswordChar = True
        '
        'submit
        '
        Me.submit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.submit.ForeColor = System.Drawing.Color.Green
        Me.submit.Location = New System.Drawing.Point(436, 385)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(75, 23)
        Me.submit.TabIndex = 9
        Me.submit.Text = "Save"
        Me.submit.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(329, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Enter new password : "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(337, 345)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(140, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Re-enter password : "
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(759, 422)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 23)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Back to login"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'forgot_pass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1037, 484)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.submit)
        Me.Controls.Add(Me.rpasswd_box)
        Me.Controls.Add(Me.passwd_box)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.check)
        Me.Controls.Add(Me.answer_box)
        Me.Controls.Add(Me.user_id_box)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "forgot_pass"
        Me.Text = "Reset password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents user_id_box As TextBox
    Friend WithEvents answer_box As TextBox
    Friend WithEvents check As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents passwd_box As TextBox
    Friend WithEvents rpasswd_box As TextBox
    Friend WithEvents submit As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
End Class
