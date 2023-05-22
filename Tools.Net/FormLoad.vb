Public Class LoadForm


	Public Sub New()

		' This call is required by the designer.
		InitializeComponent()

		' Add any initialization after the InitializeComponent() call.

	End Sub

	Private Sub LoadForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub

	Private Sub ContinueButton_Click(sender As Object, e As EventArgs) Handles ContinueButton.Click

		Me.Close()

	End Sub
End Class
