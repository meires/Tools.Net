Imports System.Net.Sockets

Public Class PLCForm


    Dim ePLC As eP
    Private Structure eP

        Dim oPLC As TcpClient

        Dim PLCStream As NetworkStream

        Dim IPAddress As String

        Dim PortNumber As List(Of Long)

        Dim PortBase As Long

        Dim LocalPortNumber As Long

    End Structure

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub PLCForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            ClearComponent()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ClearComponent()

        Try

            ip1.Text = String.Empty
            ip2.Text = String.Empty
            ip3.Text = String.Empty
            ip4.Text = String.Empty

            For i = 0 To PortNumberCheckedListBox.Items.Count - 1

                PortNumberCheckedListBox.SetItemChecked(i, True)

            Next

            PortBaseTextBox.Text = "1279"
            UsePortAddressTextBox.Text = "88"

            ip1.Focus()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ip_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ip1.KeyPress, ip4.KeyPress, ip3.KeyPress, ip2.KeyPress

        Dim tb As TextBox
        tb = CType(sender, TextBox)

        If Asc(e.KeyChar) = 13 Then

            Me.SelectNextControl(tb, True, True, False, True)

        End If
        e.Handled = False
    End Sub

    Private Sub OpenConnectionButton_Click(sender As Object, e As EventArgs) Handles OpenConnectionButton.Click

        Try

            ePLC.IPAddress = ip1.Text & "." & ip2.Text & "." & ip3.Text & "." & ip4.Text
            ePLC.PortNumber = New List(Of Long)
            For i = 0 To PortNumberCheckedListBox.CheckedItems.Count - 1

                ePLC.PortNumber.Add(PortNumberCheckedListBox.CheckedItems(i).ToString)


            Next

            ePLC.PortBase = PortBaseTextBox.Text
            ePLC.LocalPortNumber = UsePortAddressTextBox.Text

            ePLC.oPLC = New TcpClient


            ePLC.oPLC.Connect(ePLC.IPAddress, ePLC.PortNumber(0))

            ePLC.PLCStream.ReadTimeout = 5

            ePLC.PLCStream = ePLC.oPLC.GetStream

            ePLC.oPLC.Close()



        Catch ex As Exception

        End Try

    End Sub
End Class