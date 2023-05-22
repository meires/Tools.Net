Public Class ColourConvertionForm

    Dim iDrawingColourIndex As Integer

    Dim bMouseOver As Boolean

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.



    End Sub

    Private Sub ColourConvertionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try


            RValueTextBox.Text = RGBResultLabel.BackColor.R

            GValueTextBox.Text = RGBResultLabel.BackColor.G

            BValueTextBox.Text = RGBResultLabel.BackColor.B

            AlpaTrackBar.Value = RGBResultLabel.BackColor.A


            DrawingPicture()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub FormDefault()

        Try

            RValueTextBox.Text = 0
            GValueTextBox.Text = 0
            BValueTextBox.Text = 0

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ColourValueTextBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles RValueTextBox.KeyPress, GValueTextBox.KeyPress, BValueTextBox.KeyPress
        Try

            If Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57 Then
                e.Handled = False
            ElseIf Asc(e.KeyChar) = 7 Or Asc(e.KeyChar) = 8 Then
                e.Handled = False
            ElseIf Asc(e.KeyChar) = 13 Then
                Dim tb As TextBox
                tb = CType(sender, TextBox)

                Me.SelectNextControl(tb, True, True, True, True)
                e.Handled = True

            Else

                e.Handled = True

            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub ColourValueTextBox_Leave(sender As Object, e As EventArgs) Handles RValueTextBox.Leave, GValueTextBox.Leave, BValueTextBox.Leave
        RefreshColour()
    End Sub

    Private Sub AlpaTrackBar_ValueChanged(sender As Object, e As EventArgs) Handles AlpaTrackBar.ValueChanged

        AlphaTextBox.Text = AlpaTrackBar.Value

        RefreshColour()
    End Sub

    Private Sub RefreshColour()

        Try

            Dim oColour As Color

            oColour = Color.FromArgb(AlpaTrackBar.Value, RValueTextBox.Text, GValueTextBox.Text, BValueTextBox.Text)

            RGBResultLabel.BackColor = oColour


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ColorValueTextBox_Enter(sender As Object, e As EventArgs) Handles RValueTextBox.Enter, GValueTextBox.Enter, BValueTextBox.Enter

        Dim obj As TextBox

        Try

            obj = sender

            obj.SelectAll()


        Catch ex As Exception

        End Try

    End Sub

    Private Sub DrawingPicture()

        Try

            Dim oImg As Bitmap

            oImg = New Bitmap(ColourPictureBox.Width, ColourPictureBox.Height)

            'oImg = CType(ColourPictureBox.Image, Bitmap)

            Dim objPicGraphics As Graphics = Graphics.FromImage(oImg)
            'Dim ObjPenLine As Pen
            Dim ObjBrush As Brush

            objPicGraphics.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBilinear


            Dim iX, iY As Integer
            'Dim iGreen As Integer

            For iX = 0 To 255

                For iY = 0 To 255

                    If iDrawingColourIndex = 0 Then
                        ObjBrush = New SolidBrush(Color.FromArgb(255, iX, iY, iY))
                    ElseIf iDrawingColourIndex = 1 Then
                        ObjBrush = New SolidBrush(Color.FromArgb(255, iX, iY, iX))
                    ElseIf iDrawingColourIndex = 2 Then
                        ObjBrush = New SolidBrush(Color.FromArgb(255, iY, iX, iY))
                    ElseIf iDrawingColourIndex = 3 Then
                        ObjBrush = New SolidBrush(Color.FromArgb(255, iY, iY, iX))
                    Else
                        ObjBrush = New SolidBrush(Color.FromArgb(255, iX, iX, iY))
                    End If



                    objPicGraphics.FillRectangle(ObjBrush, New Rectangle(New Point(iX, iY), New Size(1, 1)))

                Next

            Next


            ColourPictureBox.Image = oImg

        Catch ex As Exception

        End Try

    End Sub

    Private Sub RedrawColourButton_Click(sender As Object, e As EventArgs) Handles RedrawColourButton.Click

        Try

            iDrawingColourIndex += 1

            If iDrawingColourIndex > 4 Then

                iDrawingColourIndex = 0

            End If

            DrawingPicture()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ColourPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles ColourPictureBox.MouseMove

        Dim myBmp As Bitmap '= New Bitmap(TimeLinePictureBox.Width, TimeLinePictureBox.Height)
        Dim posColorOrigin As Color

        Try

            If Not bMouseOver Then Exit Try

            myBmp = CType(ColourPictureBox.Image, Bitmap)

            posColorOrigin = myBmp.GetPixel(e.X, e.Y)

            RFromColourTextBox.Text = posColorOrigin.R
            GFromColourTextBox.Text = posColorOrigin.G
            BFromColourTextBox.Text = posColorOrigin.B

            RGBHexTextBox.Text = "#" & Hex(posColorOrigin.R) & Hex(posColorOrigin.G) & Hex(posColorOrigin.B)

            RGBResultFromColorLabel.BackColor = posColorOrigin


        Catch ex As Exception

        End Try

    End Sub

    Private Sub ColourPictureBox_MouseEnter(sender As Object, e As EventArgs) Handles ColourPictureBox.MouseEnter

        Try

            bMouseOver = True

        Catch ex As Exception

        End Try

    End Sub

    Private Sub ColourPictureBox_Click(sender As Object, e As EventArgs) Handles ColourPictureBox.Click
        bMouseOver = False
    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class