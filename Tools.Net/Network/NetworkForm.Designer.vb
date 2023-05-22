<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NetworkForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ipAddressLabel = New System.Windows.Forms.Label()
        Me.HostNameLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NetDataGridView = New System.Windows.Forms.DataGridView()
        Me.netName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.netMAC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.netIP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NetDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.ipAddressLabel)
        Me.GroupBox1.Controls.Add(Me.HostNameLabel)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.NetDataGridView)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(488, 277)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Network Information"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(82, 222)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(82, 199)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = ":"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 222)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "IP Address"
        '
        'ipAddressLabel
        '
        Me.ipAddressLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ipAddressLabel.Location = New System.Drawing.Point(97, 221)
        Me.ipAddressLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ipAddressLabel.Name = "ipAddressLabel"
        Me.ipAddressLabel.Size = New System.Drawing.Size(132, 19)
        Me.ipAddressLabel.TabIndex = 1
        Me.ipAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HostNameLabel
        '
        Me.HostNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.HostNameLabel.Location = New System.Drawing.Point(97, 199)
        Me.HostNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.HostNameLabel.Name = "HostNameLabel"
        Me.HostNameLabel.Size = New System.Drawing.Size(132, 19)
        Me.HostNameLabel.TabIndex = 1
        Me.HostNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 199)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Host Name"
        '
        'NetDataGridView
        '
        Me.NetDataGridView.AllowUserToAddRows = False
        Me.NetDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.NetDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.NetDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NetDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.netName, Me.netMAC, Me.netIP})
        Me.NetDataGridView.Location = New System.Drawing.Point(6, 19)
        Me.NetDataGridView.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.NetDataGridView.Name = "NetDataGridView"
        Me.NetDataGridView.ReadOnly = True
        Me.NetDataGridView.RowHeadersVisible = False
        Me.NetDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.NetDataGridView.Size = New System.Drawing.Size(474, 164)
        Me.NetDataGridView.TabIndex = 0
        '
        'netName
        '
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.netName.DefaultCellStyle = DataGridViewCellStyle2
        Me.netName.HeaderText = "Name"
        Me.netName.Name = "netName"
        Me.netName.ReadOnly = True
        Me.netName.Width = 190
        '
        'netMAC
        '
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.netMAC.DefaultCellStyle = DataGridViewCellStyle3
        Me.netMAC.HeaderText = "MAC"
        Me.netMAC.Name = "netMAC"
        Me.netMAC.ReadOnly = True
        Me.netMAC.Width = 110
        '
        'netIP
        '
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.netIP.DefaultCellStyle = DataGridViewCellStyle4
        Me.netIP.HeaderText = "IP Address"
        Me.netIP.Name = "netIP"
        Me.netIP.ReadOnly = True
        Me.netIP.Width = 120
        '
        'NetworkForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(509, 471)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Calibri", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2, 4, 2, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NetworkForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NetworkForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NetDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents NetDataGridView As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ipAddressLabel As Label
    Friend WithEvents HostNameLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents netName As DataGridViewTextBoxColumn
    Friend WithEvents netMAC As DataGridViewTextBoxColumn
    Friend WithEvents netIP As DataGridViewTextBoxColumn
End Class
