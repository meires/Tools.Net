Public Class Encryption

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub Encryption_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub EncryptButton_Click(sender As Object, e As EventArgs) Handles EncryptButton.Click

        Try

            EncryptResultTextBox.Text = Crypto.Encrypt(EncryptSourceTextBox.Text, KeyTextBox.Text)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub



    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    Private Sub DecryptButton_Click(sender As Object, e As EventArgs) Handles DecryptButton.Click
        Try

            DecryptResultTextBox.Text = Crypto.Decrypt(DecryptSourceTextBox.Text, KeyTextBox.Text)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try

            Clipboard.Clear()

            Clipboard.SetText(EncryptResultTextBox.Text, TextDataFormat.Text)

        Catch ex As System.Runtime.InteropServices.ExternalException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try

            Clipboard.Clear()

            Clipboard.SetText(DecryptResultTextBox.Text, TextDataFormat.Text)

        Catch ex As System.Runtime.InteropServices.ExternalException
            MsgBox(ex.Message)
        End Try
    End Sub
End Class