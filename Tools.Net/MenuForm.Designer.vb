<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuForm))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ColourConversionButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DateAndTimeButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.NetButton = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.EncryptionButton = New System.Windows.Forms.Button()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.WMITableButton = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.PLCButton = New System.Windows.Forms.Button()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.SMSButton = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(325, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ColourConversionButton)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(142, 61)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Apperance and Style"
        '
        'ColourConversionButton
        '
        Me.ColourConversionButton.BackColor = System.Drawing.Color.Purple
        Me.ColourConversionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ColourConversionButton.ForeColor = System.Drawing.Color.White
        Me.ColourConversionButton.Location = New System.Drawing.Point(15, 20)
        Me.ColourConversionButton.Name = "ColourConversionButton"
        Me.ColourConversionButton.Size = New System.Drawing.Size(115, 27)
        Me.ColourConversionButton.TabIndex = 0
        Me.ColourConversionButton.Text = "Colour"
        Me.ColourConversionButton.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateAndTimeButton)
        Me.GroupBox2.Location = New System.Drawing.Point(160, 38)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(142, 61)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Convertion"
        '
        'DateAndTimeButton
        '
        Me.DateAndTimeButton.BackColor = System.Drawing.Color.Purple
        Me.DateAndTimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DateAndTimeButton.ForeColor = System.Drawing.Color.White
        Me.DateAndTimeButton.Location = New System.Drawing.Point(15, 20)
        Me.DateAndTimeButton.Name = "DateAndTimeButton"
        Me.DateAndTimeButton.Size = New System.Drawing.Size(115, 27)
        Me.DateAndTimeButton.TabIndex = 0
        Me.DateAndTimeButton.Text = "Date and Time"
        Me.DateAndTimeButton.UseVisualStyleBackColor = False
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.Maroon
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.ForeColor = System.Drawing.Color.White
        Me.CloseButton.Location = New System.Drawing.Point(204, 306)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(98, 25)
        Me.CloseButton.TabIndex = 12
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.NetButton)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 105)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(142, 61)
        Me.GroupBox3.TabIndex = 13
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Network & Interface"
        '
        'NetButton
        '
        Me.NetButton.BackColor = System.Drawing.Color.Purple
        Me.NetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NetButton.ForeColor = System.Drawing.Color.White
        Me.NetButton.Location = New System.Drawing.Point(15, 20)
        Me.NetButton.Name = "NetButton"
        Me.NetButton.Size = New System.Drawing.Size(115, 27)
        Me.NetButton.TabIndex = 0
        Me.NetButton.Text = "Network"
        Me.NetButton.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.EncryptionButton)
        Me.GroupBox4.Location = New System.Drawing.Point(160, 105)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(142, 61)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Security"
        '
        'EncryptionButton
        '
        Me.EncryptionButton.BackColor = System.Drawing.Color.Purple
        Me.EncryptionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EncryptionButton.ForeColor = System.Drawing.Color.White
        Me.EncryptionButton.Location = New System.Drawing.Point(15, 20)
        Me.EncryptionButton.Name = "EncryptionButton"
        Me.EncryptionButton.Size = New System.Drawing.Size(115, 27)
        Me.EncryptionButton.TabIndex = 0
        Me.EncryptionButton.Text = "Encryption"
        Me.EncryptionButton.UseVisualStyleBackColor = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.WMITableButton)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 172)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(142, 61)
        Me.GroupBox5.TabIndex = 15
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "PC Information"
        '
        'WMITableButton
        '
        Me.WMITableButton.BackColor = System.Drawing.Color.Purple
        Me.WMITableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.WMITableButton.ForeColor = System.Drawing.Color.White
        Me.WMITableButton.Location = New System.Drawing.Point(15, 20)
        Me.WMITableButton.Name = "WMITableButton"
        Me.WMITableButton.Size = New System.Drawing.Size(115, 27)
        Me.WMITableButton.TabIndex = 0
        Me.WMITableButton.Text = "WMI Table"
        Me.WMITableButton.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.PLCButton)
        Me.GroupBox6.Location = New System.Drawing.Point(160, 172)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(142, 61)
        Me.GroupBox6.TabIndex = 15
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "PLC "
        '
        'PLCButton
        '
        Me.PLCButton.BackColor = System.Drawing.Color.Purple
        Me.PLCButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PLCButton.ForeColor = System.Drawing.Color.White
        Me.PLCButton.Location = New System.Drawing.Point(15, 20)
        Me.PLCButton.Name = "PLCButton"
        Me.PLCButton.Size = New System.Drawing.Size(115, 27)
        Me.PLCButton.TabIndex = 0
        Me.PLCButton.Text = "PLC Play"
        Me.PLCButton.UseVisualStyleBackColor = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.SMSButton)
        Me.GroupBox7.Location = New System.Drawing.Point(12, 239)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(142, 61)
        Me.GroupBox7.TabIndex = 16
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Modem"
        '
        'SMSButton
        '
        Me.SMSButton.BackColor = System.Drawing.Color.Purple
        Me.SMSButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SMSButton.ForeColor = System.Drawing.Color.White
        Me.SMSButton.Location = New System.Drawing.Point(15, 20)
        Me.SMSButton.Name = "SMSButton"
        Me.SMSButton.Size = New System.Drawing.Size(115, 27)
        Me.SMSButton.TabIndex = 0
        Me.SMSButton.Text = "SMS"
        Me.SMSButton.UseVisualStyleBackColor = False
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Button1)
        Me.GroupBox8.Location = New System.Drawing.Point(160, 239)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(142, 61)
        Me.GroupBox8.TabIndex = 17
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Speech"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Purple
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(15, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 27)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Audio"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(325, 350)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MenuForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ColourConversionButton As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents DateAndTimeButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents NetButton As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents EncryptionButton As Button
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents WMITableButton As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents PLCButton As Button
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents SMSButton As Button
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Button1 As Button
End Class
