<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WMITableForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.WMIButton = New System.Windows.Forms.Button()
        Me.WMIComboBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.WMIDataGridView = New System.Windows.Forms.DataGridView()
        Me.cName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.WMIDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(5, 5)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(851, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(5, 611)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(851, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.WMIButton)
        Me.GroupBox1.Controls.Add(Me.WMIComboBox)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(5, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(851, 59)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'WMIButton
        '
        Me.WMIButton.Location = New System.Drawing.Point(347, 21)
        Me.WMIButton.Name = "WMIButton"
        Me.WMIButton.Size = New System.Drawing.Size(75, 23)
        Me.WMIButton.TabIndex = 2
        Me.WMIButton.Text = "Load"
        Me.WMIButton.UseVisualStyleBackColor = True
        '
        'WMIComboBox
        '
        Me.WMIComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.WMIComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.WMIComboBox.FormattingEnabled = True
        Me.WMIComboBox.Items.AddRange(New Object() {"", "Win32_1394Controller", "Win32_1394ControllerDevice", "Win32_AccountSID", "Win32_ActionCheck", "Win32_ActiveRoute", "Win32_AllocatedResource", "Win32_ApplicationCommandLine", "Win32_ApplicationService", "Win32_AssociatedProcessorMemory", "Win32_AutochkSetting", "Win32_BaseBoard", "Win32_Battery", "Win32_Binary", "Win32_BindImageAction", "Win32_BootConfiguration", "Win32_Bus Win32_CacheMemory", "Win32_CDROMDrive", "Win32_CheckCheck", "Win32_CIMLogicalDeviceCIMDataFile", "Win32_ClassicCOMApplicationClasses", "Win32_ClassicCOMClass", "Win32_ClassicCOMClassSetting", "Win32_ClassicCOMClassSettings", "Win32_ClassInforAction", "Win32_ClientApplicationSetting", "Win32_CodecFile", "Win32_COMApplicationSettings", "Win32_COMClassAutoEmulator", "Win32_ComClassEmulator", "Win32_ComponentCategory", "Win32_ComputerSystem", "Win32_ComputerSystemProcessor", "Win32_ComputerSystemProduct", "Win32_ComputerSystemWindowsProductActivationSetting", "Win32_Condition", "Win32_ConnectionShare", "Win32_ControllerHastHub", "Win32_CreateFolderAction", "Win32_CurrentProbe", "Win32_DCOMApplication", "Win32_DCOMApplicationAccessAllowedSetting", "Win32_DCOMApplicationLaunchAllowedSetting", "Win32_DCOMApplicationSetting", "Win32_DependentService", "Win32_Desktop", "Win32_DeviceBus", "Win32_DeviceMemoryAddress", "Win32_Directory", "Win32_DirectorySpecification", "Win32_DiskDrive", "Win32_DiskDrivePhysicalMedia", "Win32_DiskDriveToDiskPartition", "Win32_DiskPartition", "Win32_DiskQuota", "Win32_DisplayConfiguration", "Win32_DisplayControllerConfiguration", "Win32_DMAChanner", "Win32_DriverForDevice", "Win32_DuplicateFileAction", "Win32_Environment", "Win32_EnvironmentSpecification", "Win32_ExtensionInfoAction", "Win32_Fan", "Win32_FileSpecification", "Win32_FloppyDrive", "Win32_FontInfoAction", "Win32_Group", "Win32_GroupDomain", "Win32_GroupUser", "Win32_HeatPipe", "Win32_IDEControllerDevice", "Win32_ImplementedCategory", "Win32_InfraredDevice", "Win32_IniFileSpecification", "Win32_InstalledSoftwareElement", "Win32_IP4PersistedRouteTable", "Win32_IP4RouteTable", "Win32_IRQResource", "Win32_Keyboard", "Win32_LaunchCondition", "Win32_LoadOrderGroupServiceDependencies", "Win32_LoadOrderGroupServiceMembers", "Win32_LocalTime", "Win32_LoggedOnUser", "Win32_LogicalDisk", "Win32_LogicalDiskRootDirectory", "Win32_LogicalDiskToPartition", "Win32_LogicalFileAuditing", "Win32_LogicalFileGroup", "Win32_LogicalFileOwner", "Win32_LogicalFileSecuritySetting", "Win32_LogicalProgramGroup", "Win32_LogicalProgramGroupDirectory", "Win32_LogicalProgramGroupItem", "Win32_LogicalProgramGroupItemDataFile", "Win32_LogicalShareAccess", "Win32_LogicalShareAuditing", "Win32_LogicalShareSecuritySetting", "Win32_LogonSession", "Win32_MappedLogicalDisk", "Win32_MemoryArray", "Win32_MemoryArrayLocation", "Win32_MemoryDevice", "Win32_MemoryDeviceArray", "Win32_MemoryDeviceLocation", "Win32_MIMEInfoAction", "Win32_MotherboardDevice", "Win32_MoveFileAction", "Win32_NamedJobObjectActgInfo", "Win32_NamedJobObjectLimit", "Win32_NamedJobObjectLimitSetting", "Win32_NamedJobObjectProcess", "Win32_NamedJobObjectSecLimit", "Win32_NamedJobObjectSecLimitSetting", "Win32_NetworkAdapter", "Win32_NetworkAdapterConfiguration", "Win32_NetworkAdapterSetting", "Win32_NetworkClient", "Win32_NetworkConnection", "Win32_NetworkLoginProfile", "Win32_NetworkProtocol", "Win32_NTDomain", "Win32_NTLogEvnetLog", "Win32_NTLogEventUser", "Win32_ODBCAttribute", "Win32_ODBCDataSourceAttribute", "Win32_ODBCDataSourceSpecification", "Win32_ODBCDriverAttribute", "Win32_ODBCDriverSoftwareElement", "Win32_ODBCDriverSpecification", "Win32_ODBCTranslatorSpecification", "Win32_OnBoardDevice", "Win32_OperatingSystem", "Win32_OperatingSystemAutochkSetting", "Win32_OperatingSystemQFE", "Win32_OSRecoveryConfiguración", "Win32_PageFileElementSetting", "Win32_PageFileSetting", "Win32_PageFileUsage", "Win32_ParallelPort", "Win32_PatchFile", "Win32_PatchPackage", "Win32_PCMCIAControler", "Win32_PerfFormattedData_ASP_ActiveServerPages", "Win32_PerfFormattedData_ASPNET_ASPNET", "Win32_PerfFormattedData_ASPNET_ASPNETApplications", "Win32_PerfFormattedData_aspnet_state_ASPNETStateService", "Win32_PerfFormattedData_ContentIndex_IndexingService", "Win32_PerfFormattedData_DTSPipeline_SQLServerDTSPipeline", "Win32_PerfFormattedData_Fax_FaxServices", "Win32_PerfFormattedData_InetInfo_InternetInformationServicesGlobal", "Win32_PerfFormattedData_ISAPISearch_HttpIndexingService", "Win32_PerfFormattedData_MSDTC_DistributedTransactionCoordinator", "Win32_PerfFormattedData_NETCLRData_NETCLRData", "Win32_PerfFormattedData_NETCLRNetworking_NETCLRNetworking", "Win32_PerfFormattedData_NETDataProviderforOracle_NETCLRData", "Win32_PerfFormattedData_NETDataProviderforSqlServer_NETDataProviderforSqlServer", "Win32_PerfFormattedData_NETFramework_NETCLRExceptions", "Win32_PerfFormattedData_NETFramework_NETCLRInterop", "Win32_PerfFormattedData_NETFramework_NETCLRJit", "Win32_PerfFormattedData_NETFramework_NETCLRRemoting", "Win32_PerfFormattedData_NETFramework_NETCLRSecurity", "Win32_PerfFormattedData_Outlook_Outlook", "Win32_PerfFormattedData_PerfDisk_LogicalDisk", "Win32_PerfFormattedData_PerfDisk_PhysicalDisk", "Win32_PerfFormattedData_PerfNet_Browser", "Win32_PerfFormattedData_PerfNet_Redirector", "Win32_PerfFormattedData_PerfNet_Server", "Win32_PerfFormattedData_PerfNet_ServerWorkQueues", "Win32_PerfFormattedData_PerfOS_Cache", "Win32_PerfFormattedData_PerfOS_Memory", "Win32_PerfFormattedData_PerfOS_Objects", "Win32_PerfFormattedData_PerfOS_Processor", "Win32_PerfFormattedData_PerfOS_System", "Win32_PerfFormattedData_PerfProc_FullImage_Costly", "Win32_PerfFormattedData_PerfProc_Image_Costly", "Win32_PerfFormattedData_PerfProc_JobObject", "Win32_PerfFormattedData_PerfProc_JobObjectDetails", "Win32_PerfFormattedData_PerfProc_Process", "Win32_PerfFormattedData_PerfProc_ProcessAddressSpace_Costly", "Win32_PerfFormattedData_PerfProc_Thread", "Win32_PerfFormattedData_PerfProc_ThreadDetails_Costly", "Win32_PerfFormattedData_RemoteAccess_RASPort", "Win32_PerfFormattedData_RemoteAccess_RASTotal", "Win32_PerfFormattedData_RSVP_RSVPInterfaces", "Win32_PerfFormattedData_RSVP_RSVPService", "Win32_PerfFormattedData_Spooler_PrintQueue", "Win32_PerfFormattedData_TapiSrv_Telephony", "Win32_PerfFormattedData_Tcpip_ICMP", "Win32_PerfFormattedData_Tcpip_IP", "Win32_PerfFormattedData_Tcpip_NetworkInterface", "Win32_PerfFormattedData_Tcpip_TCP", "Win32_PerfFormattedData_Tcpip_UDP", "Win32_PerfFormattedData_TermService_TerminalServices", "Win32_PerfFormattedData_TermService_TerminalServicesSession", "Win32_PerfFormattedData_W3SVC_WebService", "Win32_PerfRawData_ASP_ActiveServerPages", "Win32_PerfRawData_ASPNET_114322_ASPNETAppsv114322", "Win32_PerfRawData_ASPNET_114322_ASPNETv114322", "Win32_PerfRawData_ASPNET_2040607_ASPNETAppsv2040607", "Win32_PerfRawData_ASPNET_2040607_ASPNETv2040607", "Win32_PerfRawData_ASPNET_ASPNET", "Win32_PerfRawData_ASPNET_ASPNETApplications", "Win32_PerfRawData_aspnet_state_ASPNETStateService", "Win32_PerfRawData_ContentFilter_IndexingServiceFilter", "Win32_PerfRawData_ContentIndex_IndexingService", "Win32_PerfRawData_DTSPipeline_SQLServerDTSPipeline", "Win32_PerfRawData_InetInfo_InternetInformationServicesGlobal", "Win32_PerfRawData_ISAPISearch_HttpIndexingService", "Win32_PerfRawData_MSDTC_DistributedTransactionCoordinator", "Win32_PerfRawData_NETCLRData_NETCLRData", "Win32_PerfRawData_NETCLRNetworking_NETCLRNetworking", "Win32_PerfRawData_NETDataProviderforOracle_NETCLRData", "Win32_PerfRawData_NETDataProviderforSqlServer_NETDataProviderforSqlServer", "Win32_PerfRawData_NETFramework_NETCLRExceptions", "Win32_PerfRawData_NETFramework_NETCLRInterop", "Win32_PerfRawData_NETFramework_NETCLRJit", "Win32_PerfRawData_NETFramework_NETCLRLoading", "Win32_PerfRawData_NETFramework_NETCLRLocksAndThreads", "Win32_PerfRawData_NETFramework_NETCLRRemoting", "Win32_PerfRawData_NETFramework_NETCLRSecurity", "Win32_PerfRawData_NTFSDRV_ControladordealmacenamientoNTFSdeSMTP", "Win32_PerfRawData_Outlook_Outlook", "Win32_PerfRawData_PerfDisk_LogicalDisk", "Win32_PerfRawData_PerfDisk_PhysicalDisk", "Win32_PerfRawData_PerfNet_Browser", "Win32_PerfRawData_PerfNet_Redirector", "Win32_PerfRawData_PerfNet_Server", "Win32_PerfRawData_PerfNet_ServerWorkQueues", "Win32_PerfRawData_PerfOS_Cache", "Win32_PerfRawData_PerfOS_Memory", "Win32_PerfRawData_PerfOS_Objects", "Win32_PerfRawData_PerfOS_Processor", "Win32_PerfRawData_PerfOS_System", "Win32_PerfRawData_PerfProc_FullImage_Costly", "Win32_PerfRawData_PerfProc_Image_Costly", "Win32_PerfRawData_PerfProc_JobObject", "Win32_PerfRawData_PerfProc_JobObjectDetails", "Win32_PerfRawData_PerfProc_Process", "Win32_PerfRawData_PerfProc_ProcessAddressSpace_Costly", "Win32_PerfRawData_PerfProc_Thread", "Win32_PerfRawData_PerfProc_ThreadDetails_Costly", "Win32_PerfRawData_RemoteAccess_RASPort", "Win32_PerfRawData_RemoteAccess_RASTotal", "Win32_PerfRawData_RSVP_RSVPInterfaces", "Win32_PerfRawData_RSVP_RSVPService", "Win32_PerfRawData_Spooler_PrintQueue", "Win32_PerfRawData_TapiSrv_Telephony", "Win32_PerfRawData_Tcpip_ICMP", "Win32_PerfRawData_Tcpip_IP", "Win32_PerfRawData_Tcpip_NBTConnection", "Win32_PerfRawData_Tcpip_NetworkInterface", "Win32_PerfRawData_Tcpip_TCP", "Win32_PerfRawData_TermService_TerminalServices", "Win32_PerfRawData_TermService_TerminalServicesSession", "Win32_PerfRawData_W3SVC_WebService", "Win32_PhysicalMedia", "Win32_PhysicalMemory", "Win32_PhysicalMemoryArray", "Win32_PhysicalMemoryLocation", "Win32_PingStatus", "Win32_PNPAllocatedResource", "Win32_PnPDevice", "Win32_PnPEntity", "Win32_PnPSignedDriver", "Win32_PnPSignedDriverCIMDataFile", "Win32_PointingDevice", "Win32_PortableBattery", "Win32_PortResource", "Win32_POTSModem", "Win32_POTSModemToSerialPort", "Win32_Printer", "Win32_PrinterConfiguration", "Win32_PrinterController", "Win32_PrinterDriver", "Win32_PrinterSetting", "Win32_PrinterShare", "Win32_PrintJob", "Win32_Process", "Win32_Processor", "Win32_Product", "Win32_ProductCheck", "Win32_ProductResource", "Win32_ProductSoftwareFeatures", "Win32_ProgIDSpecification", "Win32_ProgramGroup", "Win32_ProgramGroupContents", "Win32_Property", "Win32_ProtocolBinding", "Win32_Proxy", "Win32_PublishComponentAction", "Win32_QuickFixEngineering", "Win32_QuotaSetting", "Win32_Registry", "Win32_RegistryAction", "Win32_RemoveFileAction", "Win32_RemoveIniAction", "Win32_ReserveCost", "Win32_ScheduledJob", "Win32_SCSIController", "Win32_SCSIControllerDevice", "Win32_SecuritySettingOfLogicalShare", "Win32_SelfRegModuleAction", "Win32_SerialPort", "Win32_SerialPortConfiguration", "Win32_SerialPortSetting", "Win32_ServerConnection", "Win32_ServerSession", "Win32_Service", "Win32_ServiceControl", "Win32_ServiceSpecification", "Win32_ServiceSpecificationService", "Win32_SessionConnection", "Win32_SessionProcess", "Win32_Share", "Win32_ShareToDirectory", "Win32_ShortcutAction", "Win32_ShortcutFile", "Win32_SID", "Win32_SoftwareElement", "Win32_SoftwareElementAction", "Win32_SoftwareElementCheck", "Win32_SoftwareElementCondition", "Win32_SoftwareElementResource", "Win32_SoftwareFeature", "Win32_SoftwareFeatureAction", "Win32_SoftwareFeatureCheck", "Win32_SoftwareFeatureParent", "Win32_SoftwareFeatureSoftwareElements", "Win32_SoundDevice", "Win32_StartupCommand", "Win32_SubDirectory", "Win32_SystemAccount", "Win32_SystemBIOS", "Win32_SystemBootConfiguration", "Win32_SystemDesktop", "Win32_SystemDriver", "Win32_SystemDriverPNPEntity", "Win32_SystemEnclosure", "Win32_SystemLoadOrderGroups", "Win32_SystemLogicalMemoryConfiguration", "Win32_SystemNetworkConnections", "Win32_SystemOperatingSystem", "Win32_SystemPartitions", "Win32_SystemProcesses", "Win32_SystemProgramGroups", "Win32_SystemResources", "Win32_SystemServices", "Win32_SystemSlot", "Win32_SystemSystemDriver", "Win32_SystemTimeZone", "Win32_SystemUsers", "Win32_TCPIPPrinterPort", "Win32_TemperatureProbe", "Win32_Terminal", "Win32_TerminalService", "Win32_TerminalServiceSetting", "Win32_TerminalServiceToSetting", "Win32_TerminalTerminalSetting", "Win32_Thread", "Win32_TimeZone", "Win32_TSGeneralSetting", "Win32_TSNetworkAdapterListSetting", "Win32_TSNetworkAdapterSetting", "Win32_TSPermissionsSetting", "Win32_TSRemoteControlSetting", "Win32_TSSessionDirectory", "Win32_TSSessionDirectorySetting", "Win32_TSSessionSetting", "Win32_TypeLibraryAction", "Win32_UninterruptiblePowerSupply", "Win32_USBController", "Win32_USBControllerDevice", "Win32_USBHub", "Win32_UserAccount", "Win32_UserDesktop", "Win32_UserInDomain", "Win32_UTCTime", "Win32_VideoController", "Win32_VideoSettings", "Win32_VolumeQuotaSetting", "Win32_WindowsProductActivation", "Win32_WMIElementSetting", "Win32_WMISetting"})
        Me.WMIComboBox.Location = New System.Drawing.Point(82, 23)
        Me.WMIComboBox.Name = "WMIComboBox"
        Me.WMIComboBox.Size = New System.Drawing.Size(259, 21)
        Me.WMIComboBox.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WMI Class"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.WMIDataGridView)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(5, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(851, 523)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'WMIDataGridView
        '
        Me.WMIDataGridView.AllowUserToAddRows = False
        Me.WMIDataGridView.AllowUserToDeleteRows = False
        Me.WMIDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.WMIDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WMIDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cName, Me.cValue})
        Me.WMIDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WMIDataGridView.Location = New System.Drawing.Point(3, 17)
        Me.WMIDataGridView.Name = "WMIDataGridView"
        Me.WMIDataGridView.ReadOnly = True
        Me.WMIDataGridView.RowHeadersVisible = False
        Me.WMIDataGridView.Size = New System.Drawing.Size(845, 503)
        Me.WMIDataGridView.TabIndex = 0
        '
        'cName
        '
        Me.cName.HeaderText = "NAME"
        Me.cName.Name = "cName"
        Me.cName.ReadOnly = True
        Me.cName.Width = 130
        '
        'cValue
        '
        Me.cValue.HeaderText = "VALUE"
        Me.cValue.Name = "cValue"
        Me.cValue.ReadOnly = True
        Me.cValue.Width = 160
        '
        'WMITableForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(861, 638)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Calibri", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimizeBox = False
        Me.Name = "WMITableForm"
        Me.Padding = New System.Windows.Forms.Padding(5)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WMITableForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.WMIDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents WMIButton As Button
    Friend WithEvents WMIComboBox As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents WMIDataGridView As DataGridView
    Friend WithEvents cName As DataGridViewTextBoxColumn
    Friend WithEvents cValue As DataGridViewTextBoxColumn
End Class
