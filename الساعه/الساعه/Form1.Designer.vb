<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ClockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DateStringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.YearDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WeakdayDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimeStringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HourDaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MinuteDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SecondDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClockToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(480, 38)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClockToolStripMenuItem
        '
        Me.ClockToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateToolStripMenuItem, Me.TimeToolStripMenuItem, Me.NowToolStripMenuItem})
        Me.ClockToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Desktop
        Me.ClockToolStripMenuItem.Name = "ClockToolStripMenuItem"
        Me.ClockToolStripMenuItem.Size = New System.Drawing.Size(78, 34)
        Me.ClockToolStripMenuItem.Text = "Clock"
        '
        'DateToolStripMenuItem
        '
        Me.DateToolStripMenuItem.BackColor = System.Drawing.Color.Lavender
        Me.DateToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateStringToolStripMenuItem, Me.YearDateToolStripMenuItem, Me.MonthDateToolStripMenuItem, Me.WeakdayDateToolStripMenuItem})
        Me.DateToolStripMenuItem.Name = "DateToolStripMenuItem"
        Me.DateToolStripMenuItem.Size = New System.Drawing.Size(181, 34)
        Me.DateToolStripMenuItem.Text = "&Date"
        '
        'DateStringToolStripMenuItem
        '
        Me.DateStringToolStripMenuItem.Name = "DateStringToolStripMenuItem"
        Me.DateStringToolStripMenuItem.Size = New System.Drawing.Size(241, 34)
        Me.DateStringToolStripMenuItem.Text = "DateString"
        '
        'YearDateToolStripMenuItem
        '
        Me.YearDateToolStripMenuItem.Name = "YearDateToolStripMenuItem"
        Me.YearDateToolStripMenuItem.Size = New System.Drawing.Size(241, 34)
        Me.YearDateToolStripMenuItem.Text = "Year(Date)"
        '
        'MonthDateToolStripMenuItem
        '
        Me.MonthDateToolStripMenuItem.Name = "MonthDateToolStripMenuItem"
        Me.MonthDateToolStripMenuItem.Size = New System.Drawing.Size(241, 34)
        Me.MonthDateToolStripMenuItem.Text = "Month(Date)"
        '
        'WeakdayDateToolStripMenuItem
        '
        Me.WeakdayDateToolStripMenuItem.Name = "WeakdayDateToolStripMenuItem"
        Me.WeakdayDateToolStripMenuItem.Size = New System.Drawing.Size(241, 34)
        Me.WeakdayDateToolStripMenuItem.Text = "Weekday(Date)"
        '
        'TimeToolStripMenuItem
        '
        Me.TimeToolStripMenuItem.BackColor = System.Drawing.Color.Lavender
        Me.TimeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TimeStringToolStripMenuItem, Me.HourDaToolStripMenuItem, Me.MinuteDateToolStripMenuItem, Me.SecondDateToolStripMenuItem})
        Me.TimeToolStripMenuItem.Name = "TimeToolStripMenuItem"
        Me.TimeToolStripMenuItem.Size = New System.Drawing.Size(181, 34)
        Me.TimeToolStripMenuItem.Text = "&Time"
        '
        'TimeStringToolStripMenuItem
        '
        Me.TimeStringToolStripMenuItem.Name = "TimeStringToolStripMenuItem"
        Me.TimeStringToolStripMenuItem.Size = New System.Drawing.Size(226, 34)
        Me.TimeStringToolStripMenuItem.Text = "TimeString"
        '
        'HourDaToolStripMenuItem
        '
        Me.HourDaToolStripMenuItem.Name = "HourDaToolStripMenuItem"
        Me.HourDaToolStripMenuItem.Size = New System.Drawing.Size(226, 34)
        Me.HourDaToolStripMenuItem.Text = "Hour(Time)"
        '
        'MinuteDateToolStripMenuItem
        '
        Me.MinuteDateToolStripMenuItem.Name = "MinuteDateToolStripMenuItem"
        Me.MinuteDateToolStripMenuItem.Size = New System.Drawing.Size(226, 34)
        Me.MinuteDateToolStripMenuItem.Text = "Minute(Time)"
        '
        'SecondDateToolStripMenuItem
        '
        Me.SecondDateToolStripMenuItem.Name = "SecondDateToolStripMenuItem"
        Me.SecondDateToolStripMenuItem.Size = New System.Drawing.Size(226, 34)
        Me.SecondDateToolStripMenuItem.Text = "Second(Time)"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Label1.Location = New System.Drawing.Point(34, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(399, 60)
        Me.Label1.TabIndex = 1
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'NowToolStripMenuItem
        '
        Me.NowToolStripMenuItem.BackColor = System.Drawing.Color.Lavender
        Me.NowToolStripMenuItem.Name = "NowToolStripMenuItem"
        Me.NowToolStripMenuItem.Size = New System.Drawing.Size(181, 34)
        Me.NowToolStripMenuItem.Text = "Now"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(480, 361)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.ForeColor = System.Drawing.SystemColors.Highlight
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ClockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DateStringToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents YearDateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonthDateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WeakdayDateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimeStringToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HourDaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MinuteDateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SecondDateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NowToolStripMenuItem As ToolStripMenuItem
End Class
