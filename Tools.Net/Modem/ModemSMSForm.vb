Imports System.Management
Imports System.Threading
Imports System.IO.Ports

Public Class ModemSMSForm
    Dim rcvdata As String = ""
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ModemSMSForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim ports() As String
        ports = Split(ModemsConnected(), "***")
        For i As Integer = 0 To ports.Length - 2
            ComboBox1.Items.Add(ports(i))

        Next

    End Sub
    Public Function ModemsConnected() As String
        Dim modems As String = ""
        Try
            Dim searcher As New ManagementObjectSearcher(
            "root\CIMV2",
            "SELECT * FROM Win32_POTSModem")

            For Each queryObj As ManagementObject In searcher.Get()
                If queryObj("Status") = "OK" Then
                    modems = modems & (queryObj("AttachedTo") & " - " & queryObj("Description") & "***")
                End If
            Next
        Catch err As ManagementException
            MessageBox.Show("An error occurred while querying for WMI data: " & err.Message)
            Return ""
        End Try
        Return modems
    End Function


    Private Sub ComboBox1_SelectedValueChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedValueChanged
        Label1.Text = Trim(Mid(ComboBox1.Text, 1, 5))
    End Sub

    Private Sub SerialPort1_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Dim datain As String = " "
        Dim numbytes As Integer = SerialPort1.BytesToRead
        For i As Integer = 1 To numbytes
            datain &= Chr(SerialPort1.ReadChar)

        Next
        test(datain)
    End Sub

    Private Sub test(ByVal indata As String)
        rcvdata &= indata

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            With SerialPort1
                .PortName = Label1.Text
                .BaudRate = 9600
                .Parity = IO.Ports.Parity.None
                .DataBits = 8
                .StopBits = IO.Ports.StopBits.One
                .Handshake = IO.Ports.Handshake.None
                .RtsEnable = True
                .ReceivedBytesThreshold = 1
                .NewLine = vbCrLf
                .ReadTimeout = 1000
                .Open()

            End With

            If SerialPort1.IsOpen Then
                StatusLabel.Text = "Connected"

            Else
                StatusLabel.Text = "Got Some Error"

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmdSend_Click(sender As Object, e As EventArgs) Handles cmdSend.Click
        Try
            With SerialPort1
                .Write("at" & vbCrLf)
                Threading.Thread.Sleep(1000)
                .Write("AT+cmgf = 1" & vbCrLf)
                Threading.Thread.Sleep(1000)
                .Write("at + cmgs = " & PhoneTextBox.Text & Chr(34) & vbCrLf)
                .Write(RichTextBox1.Text & Chr(13) & vbCrLf)
                Threading.Thread.Sleep(1000)
                MsgBox(rcvdata.ToString)

            End With

            If rcvdata.ToString.Contains(">") Then
                MsgBox("message sent")

            Else
                MsgBox("got some error")

            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub cmdRead_Click(sender As Object, e As EventArgs) Handles cmdRead.Click
        Try
            With SerialPort1

                rcvdata = ""
                .Write("AT" & vbCrLf)
                Threading.Thread.Sleep(1000)
                .Write("AT + cmgf = 1" & vbCrLf)
                Threading.Thread.Sleep(1000)
                .Write("AT + CGSN=" & vbCrLf)
                Threading.Thread.Sleep(1000)
                .Write("AT + CPMS = ?" & vbCrLf)
                Threading.Thread.Sleep(1000)
                .Write("AT + CMGL = ALL" & vbCrLf)
                Threading.Thread.Sleep(1000)
                MsgBox(rcvdata.ToString)




            End With
        Catch ex As Exception

        End Try
    End Sub
End Class