<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatusUpdateGUIFrontend
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
        Me.components = New System.ComponentModel.Container()
        Me.DiscNum = New System.Windows.Forms.Label()
        Me.LocationLabel = New System.Windows.Forms.Label()
        Me.Time = New System.Windows.Forms.Label()
        Me.PartyLabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Status = New System.Windows.Forms.Label()
        Me.StartButton = New System.Windows.Forms.Button()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Party = New System.Windows.Forms.Label()
        Me.Location = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'DiscNum
        '
        Me.DiscNum.AutoSize = True
        Me.DiscNum.Location = New System.Drawing.Point(26, 23)
        Me.DiscNum.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.DiscNum.Name = "DiscNum"
        Me.DiscNum.Size = New System.Drawing.Size(49, 13)
        Me.DiscNum.TabIndex = 0
        Me.DiscNum.Text = "Disc X/3"
        '
        'LocationLabel
        '
        Me.LocationLabel.AutoSize = True
        Me.LocationLabel.Location = New System.Drawing.Point(26, 37)
        Me.LocationLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LocationLabel.Name = "LocationLabel"
        Me.LocationLabel.Size = New System.Drawing.Size(54, 13)
        Me.LocationLabel.TabIndex = 2
        Me.LocationLabel.Text = "Location: "
        '
        'Time
        '
        Me.Time.AutoSize = True
        Me.Time.Location = New System.Drawing.Point(26, 50)
        Me.Time.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(318, 13)
        Me.Time.TabIndex = 3
        Me.Time.Text = "Time: Local (HH:MM:SS) Stream (HH:MM:SS) Game (HH:MM:SS)"
        '
        'PartyLabel
        '
        Me.PartyLabel.AutoSize = True
        Me.PartyLabel.Location = New System.Drawing.Point(75, 23)
        Me.PartyLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.PartyLabel.Name = "PartyLabel"
        Me.PartyLabel.Size = New System.Drawing.Size(34, 13)
        Me.PartyLabel.TabIndex = 6
        Me.PartyLabel.Text = "Party:"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Status
        '
        Me.Status.AutoSize = True
        Me.Status.Location = New System.Drawing.Point(402, 92)
        Me.Status.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(47, 13)
        Me.Status.TabIndex = 14
        Me.Status.Text = "Stopped"
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(377, 6)
        Me.StartButton.Margin = New System.Windows.Forms.Padding(2)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(94, 39)
        Me.StartButton.TabIndex = 22
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.Location = New System.Drawing.Point(377, 50)
        Me.StopButton.Margin = New System.Windows.Forms.Padding(2)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(94, 39)
        Me.StopButton.TabIndex = 23
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Live Info:"
        '
        'Party
        '
        Me.Party.AutoSize = True
        Me.Party.Location = New System.Drawing.Point(113, 23)
        Me.Party.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Party.Name = "Party"
        Me.Party.Size = New System.Drawing.Size(0, 13)
        Me.Party.TabIndex = 33
        '
        'Location
        '
        Me.Location.AutoSize = True
        Me.Location.Location = New System.Drawing.Point(76, 37)
        Me.Location.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Location.Name = "Location"
        Me.Location.Size = New System.Drawing.Size(0, 13)
        Me.Location.TabIndex = 34
        '
        'StatusUpdateGUIFrontend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 113)
        Me.Controls.Add(Me.Location)
        Me.Controls.Add(Me.Party)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.PartyLabel)
        Me.Controls.Add(Me.Time)
        Me.Controls.Add(Me.LocationLabel)
        Me.Controls.Add(Me.DiscNum)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "StatusUpdateGUIFrontend"
        Me.Text = "FF7 Stream Status Overlay: Live Updater"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DiscNum As System.Windows.Forms.Label
    Friend WithEvents LocationLabel As System.Windows.Forms.Label
    Friend WithEvents Time As System.Windows.Forms.Label
    Friend WithEvents PartyLabel As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Status As System.Windows.Forms.Label
    Friend WithEvents StartButton As System.Windows.Forms.Button
    Friend WithEvents StopButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Party As System.Windows.Forms.Label
    Friend WithEvents Location As System.Windows.Forms.Label

End Class
