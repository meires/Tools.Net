<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PLCForm
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
        Me.PortNumberCheckedListBox = New System.Windows.Forms.CheckedListBox()
        Me.OpenConnectionButton = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ip4 = New System.Windows.Forms.TextBox()
        Me.ip3 = New System.Windows.Forms.TextBox()
        Me.ip2 = New System.Windows.Forms.TextBox()
        Me.UsePortAddressTextBox = New System.Windows.Forms.TextBox()
        Me.PortBaseTextBox = New System.Windows.Forms.TextBox()
        Me.ip1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PortNumberCheckedListBox)
        Me.GroupBox1.Controls.Add(Me.OpenConnectionButton)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ip4)
        Me.GroupBox1.Controls.Add(Me.ip3)
        Me.GroupBox1.Controls.Add(Me.ip2)
        Me.GroupBox1.Controls.Add(Me.UsePortAddressTextBox)
        Me.GroupBox1.Controls.Add(Me.PortBaseTextBox)
        Me.GroupBox1.Controls.Add(Me.ip1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(278, 249)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PLC Information"
        '
        'PortNumberCheckedListBox
        '
        Me.PortNumberCheckedListBox.FormattingEnabled = True
        Me.PortNumberCheckedListBox.Items.AddRange(New Object() {"1280", "1281", "1282", "1283", "1284", "1285", "1286", "1287"})
        Me.PortNumberCheckedListBox.Location = New System.Drawing.Point(100, 54)
        Me.PortNumberCheckedListBox.Name = "PortNumberCheckedListBox"
        Me.PortNumberCheckedListBox.Size = New System.Drawing.Size(154, 100)
        Me.PortNumberCheckedListBox.TabIndex = 4
        '
        'OpenConnectionButton
        '
        Me.OpenConnectionButton.BackColor = System.Drawing.Color.Green
        Me.OpenConnectionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OpenConnectionButton.ForeColor = System.Drawing.Color.White
        Me.OpenConnectionButton.Location = New System.Drawing.Point(100, 212)
        Me.OpenConnectionButton.Name = "OpenConnectionButton"
        Me.OpenConnectionButton.Size = New System.Drawing.Size(154, 26)
        Me.OpenConnectionButton.TabIndex = 7
        Me.OpenConnectionButton.Text = "Open Connection"
        Me.OpenConnectionButton.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Local Port Use"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Port Base"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "IP Address"
        '
        'ip4
        '
        Me.ip4.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ip4.Location = New System.Drawing.Point(220, 28)
        Me.ip4.Name = "ip4"
        Me.ip4.Size = New System.Drawing.Size(34, 20)
        Me.ip4.TabIndex = 3
        Me.ip4.Text = "000"
        Me.ip4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ip3
        '
        Me.ip3.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ip3.Location = New System.Drawing.Point(180, 28)
        Me.ip3.Name = "ip3"
        Me.ip3.Size = New System.Drawing.Size(34, 20)
        Me.ip3.TabIndex = 2
        Me.ip3.Text = "000"
        Me.ip3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ip2
        '
        Me.ip2.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ip2.Location = New System.Drawing.Point(140, 28)
        Me.ip2.Name = "ip2"
        Me.ip2.Size = New System.Drawing.Size(34, 20)
        Me.ip2.TabIndex = 1
        Me.ip2.Text = "000"
        Me.ip2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'UsePortAddressTextBox
        '
        Me.UsePortAddressTextBox.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsePortAddressTextBox.Location = New System.Drawing.Point(100, 186)
        Me.UsePortAddressTextBox.Name = "UsePortAddressTextBox"
        Me.UsePortAddressTextBox.Size = New System.Drawing.Size(48, 20)
        Me.UsePortAddressTextBox.TabIndex = 6
        Me.UsePortAddressTextBox.Text = "0000"
        Me.UsePortAddressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PortBaseTextBox
        '
        Me.PortBaseTextBox.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PortBaseTextBox.Location = New System.Drawing.Point(100, 160)
        Me.PortBaseTextBox.Name = "PortBaseTextBox"
        Me.PortBaseTextBox.Size = New System.Drawing.Size(48, 20)
        Me.PortBaseTextBox.TabIndex = 5
        Me.PortBaseTextBox.Text = "0000"
        Me.PortBaseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ip1
        '
        Me.ip1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ip1.Location = New System.Drawing.Point(100, 28)
        Me.ip1.Name = "ip1"
        Me.ip1.Size = New System.Drawing.Size(34, 20)
        Me.ip1.TabIndex = 0
        Me.ip1.Text = "000"
        Me.ip1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PLCForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(919, 616)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "PLCForm"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.Text = "PLCForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PortNumberCheckedListBox As CheckedListBox
    Friend WithEvents OpenConnectionButton As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ip4 As TextBox
    Friend WithEvents ip3 As TextBox
    Friend WithEvents ip2 As TextBox
    Friend WithEvents UsePortAddressTextBox As TextBox
    Friend WithEvents PortBaseTextBox As TextBox
    Friend WithEvents ip1 As TextBox
End Class
