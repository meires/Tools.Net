Public Class DateFunctionForm

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub DateFunctionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try

            bdDateTimePicker.MaxDate = Now

            bdDateTimePicker.Value = DateAdd(DateInterval.Year, -30, Now)

        Catch ex As Exception

        End Try

    End Sub

    Private Sub Cal1Button_Click(sender As Object, e As EventArgs) Handles Cal1Button.Click
        Try

            Dim StartDAte As DateTime
            Dim EndDate As DateTime

            StartDAte = CDate(Format(DateTimePicker1.Value, "yyyy-MM-dd ") & startTextBox1.Text)
            EndDate = CDate(Format(DateTimePicker2.Value, "yyyy-MM-dd ") & EndTextBox2.Text)

            yyLabel5.Text = CStr(Microsoft.VisualBasic.DateDiff(DateInterval.Year, StartDAte, EndDate))
            mmLabel6.Text = CStr(Microsoft.VisualBasic.DateDiff(DateInterval.Month, StartDAte, EndDate))
            ddLabel7.Text = CStr(Microsoft.VisualBasic.DateDiff(DateInterval.Day, StartDAte, EndDate))
            hhLabel11.Text = CStr(Microsoft.VisualBasic.DateDiff(DateInterval.Hour, StartDAte, EndDate))
            nnLabel13.Text = CStr(Microsoft.VisualBasic.DateDiff(DateInterval.Minute, StartDAte, EndDate))
            ssLabel15.Text = CStr(Microsoft.VisualBasic.DateDiff(DateInterval.Second, StartDAte, EndDate))

        Catch ex As Exception

        End Try
    End Sub

    Private Sub bdButton_Click(sender As Object, e As EventArgs) Handles bdButton.Click


        Try


            Dim birthday As DateTime = bdDateTimePicker.Value

            Dim intYears As Integer = DateDiff(DateInterval.Year, birthday, Today())
            If DateAdd(DateInterval.Year, intYears, birthday) > Today() Then intYears -= 1

            birthday = DateAdd(DateInterval.Year, intYears, birthday)

            Dim intMonths As Integer = DateDiff(DateInterval.Month, birthday, Today)
            If DateAdd(DateInterval.Month, intMonths, birthday) > Today Then intMonths -= 1

            birthday = DateAdd(DateInterval.Month, intMonths, birthday)

            Dim intDays As Integer = DateDiff(DateInterval.Day, birthday, Today)

            bdYearLabel.Text = intYears
            bdMonthLabel.Text = intMonths
            bdDayLabel.Text = intDays

        Catch ex As Exception

        End Try

    End Sub

    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub
End Class