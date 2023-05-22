Imports System.Net.NetworkInformation
Imports System.IO
Imports System.Management

Public Class NetworkForm

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub NetworkForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim i As Integer = 0

        Try

            Dim nics As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces
            If nics.Length < 0 Or nics Is Nothing Then
                MsgBox("No NICS")
                Exit Sub
            End If
            NetDataGridView.Rows.Clear()

            For Each netadapter As NetworkInterface In nics

                Dim intproperties As IPInterfaceProperties = netadapter.GetIPProperties()
                NetDataGridView.Rows.Add()
                NetDataGridView.Rows(i).Cells("NetName").Value = netadapter.Name
                NetDataGridView.Rows(i).Cells("NetMac").Value = ParsingMac(netadapter.GetPhysicalAddress.ToString)
                NetDataGridView.Rows(i).Cells("NetIP").Value = netadapter.GetIPv4Statistics.ToString
                i += 1

            Next

            GetIPv4Address()

        Catch ex As Exception

        End Try

    End Sub



    Private Function GetIPv4Address() As String

        Dim sReturn As String = String.Empty

        Try
            sReturn = String.Empty
            Dim strHostName As String = System.Net.Dns.GetHostName()
            Dim iphe As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(strHostName)

            For Each ipheal As System.Net.IPAddress In iphe.AddressList
                If ipheal.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                    sReturn = ipheal.ToString()
                End If
            Next

            HostNameLabel.Text = strHostName
            ipAddressLabel.Text = sReturn



        Catch ex As Exception

            sReturn = String.Empty

        End Try


        Return sReturn

    End Function


    Private Sub InformationLoad(MacAddr As String)

        Try

            'Dim objSearcher As New ManagementObjectSearcher("SELECT " & strProperty & " FROM " & strCollection)
            Dim objMC As ManagementClass = New ManagementClass("Win32_NetworkAdapterConfiguration")
            Dim objMOC As ManagementObjectCollection = objMC.GetInstances

            For Each objMO As ManagementObject In objMOC

                If (objMO("Caption")) = netName Then



                End If

            Next

        Catch ex As Exception

        End Try

    End Sub

    Private Sub NetNameComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)

        Try

            ' InformationLoad(NetNameComboBox.Text)

        Catch ex As Exception

        End Try

    End Sub
End Class