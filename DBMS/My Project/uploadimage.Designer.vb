﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uploadimage
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.browse = New System.Windows.Forms.Button()
        Me.upload = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightGray
        Me.PictureBox1.Location = New System.Drawing.Point(12, 25)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(401, 231)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'browse
        '
        Me.browse.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.browse.Location = New System.Drawing.Point(435, 48)
        Me.browse.Name = "browse"
        Me.browse.Size = New System.Drawing.Size(69, 30)
        Me.browse.TabIndex = 1
        Me.browse.Text = "Browse"
        Me.browse.UseVisualStyleBackColor = False
        '
        'upload
        '
        Me.upload.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.upload.Location = New System.Drawing.Point(435, 218)
        Me.upload.Name = "upload"
        Me.upload.Size = New System.Drawing.Size(75, 23)
        Me.upload.TabIndex = 2
        Me.upload.Text = "Upload"
        Me.upload.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(519, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Note : 1 user can upload maximum of 1 picture. Picture will be removed if found i" &
    "rrelevant."
        '
        'uploadimage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(534, 268)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.upload)
        Me.Controls.Add(Me.browse)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "uploadimage"
        Me.Text = "Upload Image"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents browse As Button
    Friend WithEvents upload As Button
    Friend WithEvents Label1 As Label
End Class
