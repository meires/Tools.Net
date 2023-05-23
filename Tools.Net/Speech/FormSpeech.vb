
Imports System.Speech.Synthesis

Imports System.Runtime.InteropServices
Imports System.Text

Public Class FormSpeech

    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal lpstrCommand As String, ByVal lpstrReturnString As String, ByVal uReturnLength As Integer, ByVal hwndCallback As Integer) As Integer


    Dim sp As SpeechSynthesizer = New SpeechSynthesizer()

    Dim iVoiceGender As Integer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        sp.SetOutputToDefaultAudioDevice()

        Dim oG As System.Globalization.CultureInfo




        sp.Rate = 0
    End Sub

    Private Sub FormSpeech_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            GroupBox1.Text += " (" & sp.State & ")"

        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnSpeech_Click(sender As Object, e As EventArgs) Handles btnSpeech.Click

        Try



            sp.SelectVoiceByHints(iVoiceGender, VoiceAge.NotSet, iVoiceGender, New System.Globalization.CultureInfo("id-ID"))


            sp.Speak(SpeechRichTextBox.Text)


        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mciSendString("open new Type waveaudio Alias capture", Nothing, 0, 0)
        mciSendString("record capture", "", 0, 0)

        MsgLabel.Text = "Recording..."
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mciSendString("save capture " & AudioFilePathTextBox.Text, Nothing, 0, 0)

        mciSendString("close capture", Nothing, 0, 0)

        MsgLabel.Text = "Stopped."
    End Sub

    Private Sub BrowseButton_Click(sender As Object, e As EventArgs) Handles BrowseButton.Click

        Try

            SaveFileDialog1.Filter = "Audio File (.wav)|*.wav"

            If SaveFileDialog1.ShowDialog = DialogResult.OK Then

                AudioFilePathTextBox.Text = SaveFileDialog1.FileName


            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Audio.Play(AudioFilePathTextBox.Text, AudioPlayMode.Background)
    End Sub

    Private Sub VGRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles VGNSRadioButton.CheckedChanged, VGNeutralRadioButton.CheckedChanged, VGMaleRadioButton.CheckedChanged, VGFemaleRadioButton.CheckedChanged

        Try

            If VGNSRadioButton.Checked Then

                iVoiceGender = 0

                Exit Sub

            End If

            If VGMaleRadioButton.Checked Then

                iVoiceGender = 1

                Exit Sub

            End If


            If VGFemaleRadioButton.Checked Then

                iVoiceGender = 2

                Exit Sub

            End If

            If VGNeutralRadioButton.Checked Then

                iVoiceGender = 3

                Exit Sub

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class