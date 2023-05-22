
Imports System.Management
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Object
Imports System.IO


Module NetworkModule


    Public Function setupNetwork(phyAddr As String, ipAddr As String, netmask As String, gateway As String, dns1 As String, dns2 As String) As Boolean
        Dim result As Boolean = False



        Dim objMC As ManagementClass = New ManagementClass("Win32_NetworkAdapterConfiguration")
        Dim objMOC As ManagementObjectCollection = objMC.GetInstances()




        For Each objMO As ManagementObject In objMOC
            If (Not CBool(objMO("IPEnabled"))) Then
                Continue For
            End If



            Try
                Dim objNewIP As ManagementBaseObject = Nothing
                Dim objSetIP As ManagementBaseObject = Nothing
                Dim objNewGate As ManagementBaseObject = Nothing
                'Dim objSetDNS As ManagementBaseObject = Nothing

                objNewIP = objMO.GetMethodParameters("EnableStatic")
                objNewGate = objMO.GetMethodParameters("SetGateways")


                'Set DefaultGateway
                objNewGate("DefaultIPGateway") = New String() {gateway}
                objNewGate("GatewayCostMetric") = New Integer() {1}


                'Set IPAddress and Subnet Mask
                objNewIP("IPAddress") = New String() {ipAddr}
                objNewIP("SubnetMask") = New String() {netmask}



                objSetIP = objMO.InvokeMethod("EnableStatic", objNewIP, Nothing)
                objSetIP = objMO.InvokeMethod("SetGateways", objNewGate, Nothing)



                Console.WriteLine("Updated IPAddress, SubnetMask and Default Gateway")


            Catch ex As Exception
                MessageBox.Show("Unable to Set IP : " & ex.Message & vbCrLf & ex.StackTrace)

            End Try

        Next objMO


        ''this is where you will need to change your dns1 and dns2 - if you want to 
        'Try
        '    Dim c1 As String = ComboBox1.Text



        '    Try
        '        Process.Start("cmd", "/c Netsh Interface ip set dns """ & c1 & """ static " & dns1)
        '        Process.Start("cmd", "/c Netsh Interface ip add dns """ & c1 & """ index=2 " & dns2)
        '    Catch ex As Exception

        '    End Try




        'Catch ex As Exception

        'End Try



        Return result

    End Function

    'set computers host name
    Public Function setHostname(hostname As String) As Boolean
        Dim result As Boolean = False

        Dim path As New ManagementPath

        path.Server = System.Net.Dns.GetHostName
        path.NamespacePath = "root\CIMV2"
        path.RelativePath = "Win32_Computersystem.Name='" & path.Server & "'"

        Dim objMO As New ManagementObject(path)
        Dim params() As Object = {hostname}
        objMO.InvokeMethod("Rename", params)
        result = True

        Return result

    End Function


    Public Function ParsingMac(sMac As String) As String

        Dim sRet As String

        Try

            sRet = String.Empty
            If Len(sMac) >= 2 Then


                For i = 1 To Len(sMac)

                    If i Mod 2 = 0 And i <> 12 Then

                        sRet += Strings.Mid(sMac, i, 1) & "."

                    Else

                        sRet += Strings.Mid(sMac, i, 1)

                    End If


                Next


            End If


        Catch ex As Exception
            sRet = String.Empty
        End Try

        Return sRet

    End Function



End Module
