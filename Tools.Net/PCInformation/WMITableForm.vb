Imports System.Management
Imports System.Text

Public Class WMITableForm

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub WMITableForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WMIDataGridView.Rows.Clear()
    End Sub

    Private Sub WMIButton_Click(sender As Object, e As EventArgs) Handles WMIButton.Click

        Dim iRow, icol As Integer

        Try

            Me.Cursor = Cursors.WaitCursor

            Dim mcInfo As New ManagementClass(WMIComboBox.Text)

            Dim mcInfoCol As ManagementObjectCollection =
               mcInfo.GetInstances()

            Dim pdInfo As PropertyDataCollection = mcInfo.Properties

            WMIDataGridView.Rows.Clear()
            WMIDataGridView.Columns.Clear()

            For Each objMng As ManagementObject In mcInfoCol

                WMIDataGridView.Columns.Add("c" & icol, "NAME")

                WMIDataGridView.Columns.Add("c" & icol + 1, "VALUE")

                If icol Mod 4 = 2 Then
                    WMIDataGridView.Columns("c" & icol).DefaultCellStyle.BackColor = Color.LightCyan
                    WMIDataGridView.Columns("c" & icol + 1).DefaultCellStyle.BackColor = Color.LightCyan
                End If



                iRow = 0
                For Each prop As PropertyData In pdInfo

                    Try


                        If iRow > WMIDataGridView.Rows.Count - 1 Then
                            WMIDataGridView.Rows.Add()

                            iRow = WMIDataGridView.Rows.Count - 1
                        End If


                        WMIDataGridView.Rows(iRow).Cells("c" & icol).Value = prop.Name
                        WMIDataGridView.Rows(iRow).Cells("c" & icol + 1).Value = objMng.Properties(prop.Name).Value

                        iRow += 1

                    Catch

                    End Try

                Next

                icol += 2

            Next

        Catch

        Finally
            Me.Cursor = Cursors.Default
        End Try


    End Sub



End Class