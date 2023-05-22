<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ColourConvertionForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ColourConvertionForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RValueTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GValueTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BValueTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.RGBResultLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.AlpaTrackBar = New System.Windows.Forms.TrackBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.AlphaTextBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RGBResultFromColorLabel = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.RFromColourTextBox = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GFromColourTextBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RGBHexTextBox = New System.Windows.Forms.TextBox()
        Me.BFromColourTextBox = New System.Windows.Forms.TextBox()
        Me.RedrawColourButton = New System.Windows.Forms.Button()
        Me.ColourPictureBox = New System.Windows.Forms.PictureBox()
        Me.CloseButton = New System.Windows.Forms.Button()
        CType(Me.AlpaTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ColourPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Red Green Blue (RGB) Value to Colour"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Red (R)"
        '
        'RValueTextBox
        '
        Me.RValueTextBox.ForeColor = System.Drawing.Color.Maroon
        Me.RValueTextBox.Location = New System.Drawing.Point(128, 73)
        Me.RValueTextBox.MaxLength = 3
        Me.RValueTextBox.Name = "RValueTextBox"
        Me.RValueTextBox.Size = New System.Drawing.Size(42, 20)
        Me.RValueTextBox.TabIndex = 0
        Me.RValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(184, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Green (G)"
        '
        'GValueTextBox
        '
        Me.GValueTextBox.ForeColor = System.Drawing.Color.Green
        Me.GValueTextBox.Location = New System.Drawing.Point(251, 73)
        Me.GValueTextBox.MaxLength = 3
        Me.GValueTextBox.Name = "GValueTextBox"
        Me.GValueTextBox.Size = New System.Drawing.Size(42, 20)
        Me.GValueTextBox.TabIndex = 1
        Me.GValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(313, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Blue (B)"
        '
        'BValueTextBox
        '
        Me.BValueTextBox.ForeColor = System.Drawing.Color.Navy
        Me.BValueTextBox.Location = New System.Drawing.Point(380, 73)
        Me.BValueTextBox.MaxLength = 3
        Me.BValueTextBox.Name = "BValueTextBox"
        Me.BValueTextBox.Size = New System.Drawing.Size(42, 20)
        Me.BValueTextBox.TabIndex = 2
        Me.BValueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(453, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Result →"
        '
        'RGBResultLabel
        '
        Me.RGBResultLabel.BackColor = System.Drawing.SystemColors.HotTrack
        Me.RGBResultLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RGBResultLabel.Location = New System.Drawing.Point(532, 73)
        Me.RGBResultLabel.Name = "RGBResultLabel"
        Me.RGBResultLabel.Size = New System.Drawing.Size(49, 20)
        Me.RGBResultLabel.TabIndex = 3
        Me.RGBResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(169, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "* Value in Decimal 0 to 255"
        '
        'AlpaTrackBar
        '
        Me.AlpaTrackBar.Location = New System.Drawing.Point(140, 108)
        Me.AlpaTrackBar.Maximum = 255
        Me.AlpaTrackBar.Name = "AlpaTrackBar"
        Me.AlpaTrackBar.Size = New System.Drawing.Size(294, 45)
        Me.AlpaTrackBar.TabIndex = 5
        Me.AlpaTrackBar.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(73, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Alpha (A)"
        '
        'AlphaTextBox
        '
        Me.AlphaTextBox.Enabled = False
        Me.AlphaTextBox.ForeColor = System.Drawing.Color.Green
        Me.AlphaTextBox.Location = New System.Drawing.Point(440, 119)
        Me.AlphaTextBox.MaxLength = 3
        Me.AlphaTextBox.Name = "AlphaTextBox"
        Me.AlphaTextBox.ReadOnly = True
        Me.AlphaTextBox.Size = New System.Drawing.Size(42, 20)
        Me.AlphaTextBox.TabIndex = 7
        Me.AlphaTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(27, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(139, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Select Colour to Value"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.AlpaTrackBar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.AlphaTextBox)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.RValueTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.GValueTextBox)
        Me.GroupBox1.Controls.Add(Me.RGBResultLabel)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.BValueTextBox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(633, 167)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RGBResultFromColorLabel)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.RFromColourTextBox)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.GFromColourTextBox)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.RGBHexTextBox)
        Me.GroupBox2.Controls.Add(Me.BFromColourTextBox)
        Me.GroupBox2.Controls.Add(Me.RedrawColourButton)
        Me.GroupBox2.Controls.Add(Me.ColourPictureBox)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 196)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(633, 339)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        '
        'RGBResultFromColorLabel
        '
        Me.RGBResultFromColorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.RGBResultFromColorLabel.Location = New System.Drawing.Point(244, 308)
        Me.RGBResultFromColorLabel.Name = "RGBResultFromColorLabel"
        Me.RGBResultFromColorLabel.Size = New System.Drawing.Size(42, 20)
        Me.RGBResultFromColorLabel.TabIndex = 17
        Me.RGBResultFromColorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(325, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Red (R)"
        '
        'RFromColourTextBox
        '
        Me.RFromColourTextBox.ForeColor = System.Drawing.Color.Maroon
        Me.RFromColourTextBox.Location = New System.Drawing.Point(380, 46)
        Me.RFromColourTextBox.MaxLength = 3
        Me.RFromColourTextBox.Name = "RFromColourTextBox"
        Me.RFromColourTextBox.Size = New System.Drawing.Size(42, 20)
        Me.RFromColourTextBox.TabIndex = 11
        Me.RFromColourTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(313, 75)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Green (G)"
        '
        'GFromColourTextBox
        '
        Me.GFromColourTextBox.ForeColor = System.Drawing.Color.Green
        Me.GFromColourTextBox.Location = New System.Drawing.Point(380, 72)
        Me.GFromColourTextBox.MaxLength = 3
        Me.GFromColourTextBox.Name = "GFromColourTextBox"
        Me.GFromColourTextBox.Size = New System.Drawing.Size(42, 20)
        Me.GFromColourTextBox.TabIndex = 14
        Me.GFromColourTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(313, 127)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Hex (RGB)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(319, 101)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(55, 13)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Blue (B)"
        '
        'RGBHexTextBox
        '
        Me.RGBHexTextBox.ForeColor = System.Drawing.Color.Black
        Me.RGBHexTextBox.Location = New System.Drawing.Point(380, 124)
        Me.RGBHexTextBox.MaxLength = 3
        Me.RGBHexTextBox.Name = "RGBHexTextBox"
        Me.RGBHexTextBox.Size = New System.Drawing.Size(70, 20)
        Me.RGBHexTextBox.TabIndex = 16
        Me.RGBHexTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BFromColourTextBox
        '
        Me.BFromColourTextBox.ForeColor = System.Drawing.Color.Navy
        Me.BFromColourTextBox.Location = New System.Drawing.Point(380, 98)
        Me.BFromColourTextBox.MaxLength = 3
        Me.BFromColourTextBox.Name = "BFromColourTextBox"
        Me.BFromColourTextBox.Size = New System.Drawing.Size(42, 20)
        Me.BFromColourTextBox.TabIndex = 16
        Me.BFromColourTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'RedrawColourButton
        '
        Me.RedrawColourButton.Location = New System.Drawing.Point(30, 307)
        Me.RedrawColourButton.Name = "RedrawColourButton"
        Me.RedrawColourButton.Size = New System.Drawing.Size(104, 23)
        Me.RedrawColourButton.TabIndex = 10
        Me.RedrawColourButton.Text = "Redraw Color"
        Me.RedrawColourButton.UseVisualStyleBackColor = True
        '
        'ColourPictureBox
        '
        Me.ColourPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ColourPictureBox.Location = New System.Drawing.Point(30, 45)
        Me.ColourPictureBox.Name = "ColourPictureBox"
        Me.ColourPictureBox.Size = New System.Drawing.Size(256, 256)
        Me.ColourPictureBox.TabIndex = 9
        Me.ColourPictureBox.TabStop = False
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.Maroon
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.ForeColor = System.Drawing.Color.White
        Me.CloseButton.Location = New System.Drawing.Point(544, 541)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(98, 25)
        Me.CloseButton.TabIndex = 11
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'ColourConvertionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(657, 576)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ColourConvertionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ColourConvertionForm"
        CType(Me.AlpaTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ColourPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RValueTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GValueTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BValueTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents RGBResultLabel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents AlpaTrackBar As TrackBar
    Friend WithEvents Label6 As Label
    Friend WithEvents AlphaTextBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ColourPictureBox As PictureBox
    Friend WithEvents RedrawColourButton As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents RFromColourTextBox As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents GFromColourTextBox As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents BFromColourTextBox As TextBox
    Friend WithEvents RGBResultFromColorLabel As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents RGBHexTextBox As TextBox
    Friend WithEvents CloseButton As Button
End Class
