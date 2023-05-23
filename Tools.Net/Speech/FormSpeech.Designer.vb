<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSpeech
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.VGNSRadioButton = New System.Windows.Forms.RadioButton()
        Me.VGNeutralRadioButton = New System.Windows.Forms.RadioButton()
        Me.VGFemaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.VGMaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.btnSpeech = New System.Windows.Forms.Button()
        Me.SpeechRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MsgLabel = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BrowseButton = New System.Windows.Forms.Button()
        Me.AudioFilePathTextBox = New System.Windows.Forms.TextBox()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.VGNSRadioButton)
        Me.GroupBox1.Controls.Add(Me.VGNeutralRadioButton)
        Me.GroupBox1.Controls.Add(Me.VGFemaleRadioButton)
        Me.GroupBox1.Controls.Add(Me.VGMaleRadioButton)
        Me.GroupBox1.Controls.Add(Me.btnSpeech)
        Me.GroupBox1.Controls.Add(Me.SpeechRichTextBox)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(423, 201)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Text to Speech"
        '
        'VGNSRadioButton
        '
        Me.VGNSRadioButton.AutoSize = True
        Me.VGNSRadioButton.Checked = True
        Me.VGNSRadioButton.Location = New System.Drawing.Point(20, 97)
        Me.VGNSRadioButton.Name = "VGNSRadioButton"
        Me.VGNSRadioButton.Size = New System.Drawing.Size(135, 17)
        Me.VGNSRadioButton.TabIndex = 2
        Me.VGNSRadioButton.TabStop = True
        Me.VGNSRadioButton.Tag = "0"
        Me.VGNSRadioButton.Text = "Voice Gender : Not Set"
        Me.VGNSRadioButton.UseVisualStyleBackColor = True
        '
        'VGNeutralRadioButton
        '
        Me.VGNeutralRadioButton.AutoSize = True
        Me.VGNeutralRadioButton.Location = New System.Drawing.Point(20, 164)
        Me.VGNeutralRadioButton.Name = "VGNeutralRadioButton"
        Me.VGNeutralRadioButton.Size = New System.Drawing.Size(133, 17)
        Me.VGNeutralRadioButton.TabIndex = 2
        Me.VGNeutralRadioButton.Tag = "3"
        Me.VGNeutralRadioButton.Text = "Voice Gender : Neutral"
        Me.VGNeutralRadioButton.UseVisualStyleBackColor = True
        '
        'VGFemaleRadioButton
        '
        Me.VGFemaleRadioButton.AutoSize = True
        Me.VGFemaleRadioButton.Location = New System.Drawing.Point(20, 141)
        Me.VGFemaleRadioButton.Name = "VGFemaleRadioButton"
        Me.VGFemaleRadioButton.Size = New System.Drawing.Size(133, 17)
        Me.VGFemaleRadioButton.TabIndex = 2
        Me.VGFemaleRadioButton.Tag = "2"
        Me.VGFemaleRadioButton.Text = "Voice Gender : Female"
        Me.VGFemaleRadioButton.UseVisualStyleBackColor = True
        '
        'VGMaleRadioButton
        '
        Me.VGMaleRadioButton.AutoSize = True
        Me.VGMaleRadioButton.Location = New System.Drawing.Point(20, 120)
        Me.VGMaleRadioButton.Name = "VGMaleRadioButton"
        Me.VGMaleRadioButton.Size = New System.Drawing.Size(122, 17)
        Me.VGMaleRadioButton.TabIndex = 2
        Me.VGMaleRadioButton.Tag = "1"
        Me.VGMaleRadioButton.Text = "Voice Gender : Male"
        Me.VGMaleRadioButton.UseVisualStyleBackColor = True
        '
        'btnSpeech
        '
        Me.btnSpeech.Location = New System.Drawing.Point(270, 154)
        Me.btnSpeech.Name = "btnSpeech"
        Me.btnSpeech.Size = New System.Drawing.Size(138, 36)
        Me.btnSpeech.TabIndex = 1
        Me.btnSpeech.Text = "Speech"
        Me.btnSpeech.UseVisualStyleBackColor = True
        '
        'SpeechRichTextBox
        '
        Me.SpeechRichTextBox.Location = New System.Drawing.Point(7, 20)
        Me.SpeechRichTextBox.Name = "SpeechRichTextBox"
        Me.SpeechRichTextBox.Size = New System.Drawing.Size(401, 71)
        Me.SpeechRichTextBox.TabIndex = 0
        Me.SpeechRichTextBox.Text = ""
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(79, 54)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(102, 28)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Start Record"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(187, 54)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 28)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Stop Record"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MsgLabel
        '
        Me.MsgLabel.Location = New System.Drawing.Point(89, 320)
        Me.MsgLabel.Name = "MsgLabel"
        Me.MsgLabel.Size = New System.Drawing.Size(264, 25)
        Me.MsgLabel.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.BrowseButton)
        Me.GroupBox2.Controls.Add(Me.AudioFilePathTextBox)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 219)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(424, 98)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Recording Audio"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(381, 25)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(37, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Play"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "File Location"
        '
        'BrowseButton
        '
        Me.BrowseButton.Location = New System.Drawing.Point(315, 26)
        Me.BrowseButton.Name = "BrowseButton"
        Me.BrowseButton.Size = New System.Drawing.Size(60, 23)
        Me.BrowseButton.TabIndex = 4
        Me.BrowseButton.Text = "Browse"
        Me.BrowseButton.UseVisualStyleBackColor = True
        '
        'AudioFilePathTextBox
        '
        Me.AudioFilePathTextBox.Location = New System.Drawing.Point(79, 28)
        Me.AudioFilePathTextBox.Name = "AudioFilePathTextBox"
        Me.AudioFilePathTextBox.Size = New System.Drawing.Size(230, 20)
        Me.AudioFilePathTextBox.TabIndex = 3
        '
        'FormSpeech
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 354)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MsgLabel)
        Me.Name = "FormSpeech"
        Me.Text = "FormSpeech"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnSpeech As Button
    Friend WithEvents SpeechRichTextBox As RichTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents MsgLabel As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BrowseButton As Button
    Friend WithEvents AudioFilePathTextBox As TextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents Button3 As Button
    Friend WithEvents VGMaleRadioButton As RadioButton
    Friend WithEvents VGNSRadioButton As RadioButton
    Friend WithEvents VGNeutralRadioButton As RadioButton
    Friend WithEvents VGFemaleRadioButton As RadioButton
End Class
