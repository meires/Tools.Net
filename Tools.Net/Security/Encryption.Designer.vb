<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Encryption
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Encryption))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.EncryptButton = New System.Windows.Forms.Button()
        Me.EncryptResultTextBox = New System.Windows.Forms.TextBox()
        Me.EncryptSourceTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.KeyTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DecryptButton = New System.Windows.Forms.Button()
        Me.DecryptResultTextBox = New System.Windows.Forms.TextBox()
        Me.DecryptSourceTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.EncryptButton)
        Me.GroupBox1.Controls.Add(Me.EncryptResultTextBox)
        Me.GroupBox1.Controls.Add(Me.EncryptSourceTextBox)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 89)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 172)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Encrypt"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.BackgroundImage = Global.Tools.Net.My.Resources.Resources.new_seo_37_512
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Location = New System.Drawing.Point(333, 128)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(30, 31)
        Me.Button2.TabIndex = 3
        Me.Button2.UseVisualStyleBackColor = False
        '
        'EncryptButton
        '
        Me.EncryptButton.BackColor = System.Drawing.Color.Purple
        Me.EncryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EncryptButton.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EncryptButton.ForeColor = System.Drawing.Color.White
        Me.EncryptButton.Location = New System.Drawing.Point(22, 75)
        Me.EncryptButton.Name = "EncryptButton"
        Me.EncryptButton.Size = New System.Drawing.Size(304, 28)
        Me.EncryptButton.TabIndex = 2
        Me.EncryptButton.Text = "ENCRYPT"
        Me.EncryptButton.UseVisualStyleBackColor = False
        '
        'EncryptResultTextBox
        '
        Me.EncryptResultTextBox.Location = New System.Drawing.Point(22, 133)
        Me.EncryptResultTextBox.Name = "EncryptResultTextBox"
        Me.EncryptResultTextBox.Size = New System.Drawing.Size(305, 22)
        Me.EncryptResultTextBox.TabIndex = 1
        '
        'EncryptSourceTextBox
        '
        Me.EncryptSourceTextBox.Location = New System.Drawing.Point(22, 46)
        Me.EncryptSourceTextBox.Name = "EncryptSourceTextBox"
        Me.EncryptSourceTextBox.Size = New System.Drawing.Size(305, 22)
        Me.EncryptSourceTextBox.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(19, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "RESULT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TEXT WANT TO ENCRYPT"
        '
        'KeyTextBox
        '
        Me.KeyTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.KeyTextBox.Location = New System.Drawing.Point(34, 37)
        Me.KeyTextBox.Name = "KeyTextBox"
        Me.KeyTextBox.Size = New System.Drawing.Size(305, 22)
        Me.KeyTextBox.TabIndex = 1
        Me.KeyTextBox.Text = " "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(31, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "KEY"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.DecryptButton)
        Me.GroupBox2.Controls.Add(Me.DecryptResultTextBox)
        Me.GroupBox2.Controls.Add(Me.DecryptSourceTextBox)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(402, 89)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(384, 172)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Decrypt"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.BackgroundImage = Global.Tools.Net.My.Resources.Resources.new_seo_37_512
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(333, 128)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 31)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DecryptButton
        '
        Me.DecryptButton.BackColor = System.Drawing.Color.Purple
        Me.DecryptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DecryptButton.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DecryptButton.ForeColor = System.Drawing.Color.White
        Me.DecryptButton.Location = New System.Drawing.Point(22, 75)
        Me.DecryptButton.Name = "DecryptButton"
        Me.DecryptButton.Size = New System.Drawing.Size(304, 28)
        Me.DecryptButton.TabIndex = 2
        Me.DecryptButton.Text = "DECRYPT"
        Me.DecryptButton.UseVisualStyleBackColor = False
        '
        'DecryptResultTextBox
        '
        Me.DecryptResultTextBox.Location = New System.Drawing.Point(22, 133)
        Me.DecryptResultTextBox.Name = "DecryptResultTextBox"
        Me.DecryptResultTextBox.Size = New System.Drawing.Size(305, 22)
        Me.DecryptResultTextBox.TabIndex = 1
        '
        'DecryptSourceTextBox
        '
        Me.DecryptSourceTextBox.Location = New System.Drawing.Point(22, 46)
        Me.DecryptSourceTextBox.Name = "DecryptSourceTextBox"
        Me.DecryptSourceTextBox.Size = New System.Drawing.Size(305, 22)
        Me.DecryptSourceTextBox.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(19, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 14)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "RESULT"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 14)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ENCRYPTED TEXT"
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.Maroon
        Me.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CloseButton.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseButton.ForeColor = System.Drawing.Color.White
        Me.CloseButton.Location = New System.Drawing.Point(687, 267)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(98, 25)
        Me.CloseButton.TabIndex = 13
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = False
        '
        'Encryption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(797, 302)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.KeyTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Encryption"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Encryption"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents EncryptButton As Button
    Friend WithEvents KeyTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents EncryptResultTextBox As TextBox
    Friend WithEvents EncryptSourceTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents DecryptButton As Button
    Friend WithEvents DecryptResultTextBox As TextBox
    Friend WithEvents DecryptSourceTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents CloseButton As Button
End Class
