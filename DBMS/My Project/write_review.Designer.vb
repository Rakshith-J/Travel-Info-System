<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class write_review
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
        Me.review_box = New System.Windows.Forms.RichTextBox()
        Me.review_category = New System.Windows.Forms.TextBox()
        Me.select_1 = New System.Windows.Forms.RadioButton()
        Me.select_2 = New System.Windows.Forms.RadioButton()
        Me.select_3 = New System.Windows.Forms.RadioButton()
        Me.select_4 = New System.Windows.Forms.RadioButton()
        Me.select_5 = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'review_box
        '
        Me.review_box.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.review_box.Location = New System.Drawing.Point(12, 116)
        Me.review_box.Name = "review_box"
        Me.review_box.Size = New System.Drawing.Size(555, 134)
        Me.review_box.TabIndex = 0
        Me.review_box.Text = ""
        '
        'review_category
        '
        Me.review_category.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.review_category.Location = New System.Drawing.Point(74, 24)
        Me.review_category.Name = "review_category"
        Me.review_category.ReadOnly = True
        Me.review_category.Size = New System.Drawing.Size(100, 21)
        Me.review_category.TabIndex = 6
        '
        'select_1
        '
        Me.select_1.AutoSize = True
        Me.select_1.Location = New System.Drawing.Point(258, 65)
        Me.select_1.Name = "select_1"
        Me.select_1.Size = New System.Drawing.Size(31, 17)
        Me.select_1.TabIndex = 7
        Me.select_1.TabStop = True
        Me.select_1.Text = "1"
        Me.select_1.UseVisualStyleBackColor = True
        '
        'select_2
        '
        Me.select_2.AutoSize = True
        Me.select_2.Location = New System.Drawing.Point(308, 65)
        Me.select_2.Name = "select_2"
        Me.select_2.Size = New System.Drawing.Size(31, 17)
        Me.select_2.TabIndex = 8
        Me.select_2.TabStop = True
        Me.select_2.Text = "2"
        Me.select_2.UseVisualStyleBackColor = True
        '
        'select_3
        '
        Me.select_3.AutoSize = True
        Me.select_3.Location = New System.Drawing.Point(356, 65)
        Me.select_3.Name = "select_3"
        Me.select_3.Size = New System.Drawing.Size(31, 17)
        Me.select_3.TabIndex = 9
        Me.select_3.TabStop = True
        Me.select_3.Text = "3"
        Me.select_3.UseVisualStyleBackColor = True
        '
        'select_4
        '
        Me.select_4.AutoSize = True
        Me.select_4.Location = New System.Drawing.Point(403, 65)
        Me.select_4.Name = "select_4"
        Me.select_4.Size = New System.Drawing.Size(31, 17)
        Me.select_4.TabIndex = 10
        Me.select_4.TabStop = True
        Me.select_4.Text = "4"
        Me.select_4.UseVisualStyleBackColor = True
        '
        'select_5
        '
        Me.select_5.AutoSize = True
        Me.select_5.Location = New System.Drawing.Point(451, 65)
        Me.select_5.Name = "select_5"
        Me.select_5.Size = New System.Drawing.Size(31, 17)
        Me.select_5.TabIndex = 11
        Me.select_5.TabStop = True
        Me.select_5.Text = "5"
        Me.select_5.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(9, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 15)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Category : "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(133, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Rate your experience"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(12, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Write your review below : "
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Green
        Me.Button1.Location = New System.Drawing.Point(478, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'write_review
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 266)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.select_5)
        Me.Controls.Add(Me.select_4)
        Me.Controls.Add(Me.select_3)
        Me.Controls.Add(Me.select_2)
        Me.Controls.Add(Me.select_1)
        Me.Controls.Add(Me.review_category)
        Me.Controls.Add(Me.review_box)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "write_review"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Review"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents review_box As RichTextBox
    Friend WithEvents review_category As TextBox
    Friend WithEvents select_1 As RadioButton
    Friend WithEvents select_2 As RadioButton
    Friend WithEvents select_3 As RadioButton
    Friend WithEvents select_4 As RadioButton
    Friend WithEvents select_5 As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
