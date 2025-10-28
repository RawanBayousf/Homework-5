Public Class Form1
    Private Sub Libel1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ClockToolStripMenuitem_lick(sender As Object, e As EventArgs) Handles ClockToolStripMenuItem.Click

    End Sub

    Private Sub DateToolStripmenultem_click(sender As Object, e As EventArgs) Handles DateToolStripMenuItem.Click
        Label1.Text = DateString
        Timer1.Stop()
    End Sub

    Private Sub ClockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClockToolStripMenuItem.Click

    End Sub

    Private Sub NowToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Label1.Text = Now.ToString
        Timer1.Stop()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Stop()
    End Sub

    Private Sub DateStringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DateStringToolStripMenuItem.Click
        Label1.Text = DateString
        Timer1.Stop()
    End Sub

    Private Sub YearDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YearDateToolStripMenuItem.Click
        Label1.Text = Year(Now).ToString
        Timer1.Stop()
    End Sub

    Private Sub MonthDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonthDateToolStripMenuItem.Click
        Label1.Text = Month(Now).ToString
        Timer1.Stop()
    End Sub

    Private Sub WeakdayDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WeakdayDateToolStripMenuItem.Click
        Label1.Text = Weekday(Now).ToString
        Timer1.Stop()
    End Sub

    Private Sub TimeStringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeStringToolStripMenuItem.Click
        Label1.Text = TimeString
        Timer1.Start()
    End Sub

    Private Sub HourDaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HourDaToolStripMenuItem.Click
        Label1.Text = Hour(Now).ToString
        Timer1.Stop()
    End Sub

    Private Sub MinuteDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinuteDateToolStripMenuItem.Click
        Label1.Text = Minute(Now).ToString
        Timer1.Stop()
    End Sub

    Private Sub SecondDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SecondDateToolStripMenuItem.Click
        Label1.Text = Second(Now).ToString
        Timer1.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = TimeString
    End Sub

    Private Sub NowToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles NowToolStripMenuItem.Click
        Label1.Text = Now.ToString
        Timer1.Stop()
    End Sub
End Class
