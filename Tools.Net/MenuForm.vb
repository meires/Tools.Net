Public Class MenuForm


	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

		Dim oForm As System.Windows.Forms.Form
		oForm = New LoadForm
		oForm.ShowDialog()

	End Sub

	Private Sub MenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


	End Sub

	Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ColourConversionButton.Click
		Dim oForm As System.Windows.Forms.Form
		oForm = New ColourConvertionForm
		oForm.ShowDialog()
	End Sub

	Private Sub DateAndTimeButton_Click(sender As Object, e As EventArgs) Handles DateAndTimeButton.Click

		Dim oForm As System.Windows.Forms.Form
		oForm = New DateFunctionForm
		oForm.ShowDialog()

	End Sub

	Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
		Me.Close()
	End Sub

	Private Sub NetButton_Click(sender As Object, e As EventArgs) Handles NetButton.Click
		Dim oForm As System.Windows.Forms.Form
		oForm = New NetworkForm
		oForm.ShowDialog()
	End Sub

	Private Sub EncryptionButton_Click(sender As Object, e As EventArgs) Handles EncryptionButton.Click
		Dim oForm As System.Windows.Forms.Form
		oForm = New Encryption
		oForm.ShowDialog()
	End Sub

	Private Sub WMITableButton_Click(sender As Object, e As EventArgs) Handles WMITableButton.Click
		Dim oForm As System.Windows.Forms.Form
		oForm = New WMITableForm
		oForm.ShowDialog()
	End Sub

	Private Sub PLCButton_Click(sender As Object, e As EventArgs) Handles PLCButton.Click
		Dim oForm As System.Windows.Forms.Form
		oForm = New PLCForm
		oForm.ShowDialog()
	End Sub

	Private Sub SMSButton_Click(sender As Object, e As EventArgs) Handles SMSButton.Click
		Dim oForm As System.Windows.Forms.Form
		oForm = New ModemSMSForm
		oForm.ShowDialog()
	End Sub

	Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
		Dim oForm As System.Windows.Forms.Form
		oForm = New FormSpeech
		oForm.ShowDialog()
	End Sub
End Class