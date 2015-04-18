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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LastEventLabel = New System.Windows.Forms.Label()
        Me.LastEvent = New System.Windows.Forms.TextBox()
        Me.Mods = New System.Windows.Forms.ListView()
        Me.Modification = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AddMod = New System.Windows.Forms.Button()
        Me.DeleteMod = New System.Windows.Forms.Button()
        Me.ModListLabel = New System.Windows.Forms.Label()
        Me.NewMod = New System.Windows.Forms.TextBox()
        Me.Party = New System.Windows.Forms.Label()
        Me.Location = New System.Windows.Forms.Label()
        Me.CommitChangesButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DiscNum
        '
        Me.DiscNum.AutoSize = True
        Me.DiscNum.Location = New System.Drawing.Point(34, 28)
        Me.DiscNum.Name = "DiscNum"
        Me.DiscNum.Size = New System.Drawing.Size(60, 17)
        Me.DiscNum.TabIndex = 0
        Me.DiscNum.Text = "Disc X/3"
        '
        'LocationLabel
        '
        Me.LocationLabel.AutoSize = True
        Me.LocationLabel.Location = New System.Drawing.Point(34, 45)
        Me.LocationLabel.Name = "LocationLabel"
        Me.LocationLabel.Size = New System.Drawing.Size(70, 17)
        Me.LocationLabel.TabIndex = 2
        Me.LocationLabel.Text = "Location: "
        '
        'Time
        '
        Me.Time.AutoSize = True
        Me.Time.Location = New System.Drawing.Point(34, 62)
        Me.Time.Name = "Time"
        Me.Time.Size = New System.Drawing.Size(418, 17)
        Me.Time.TabIndex = 3
        Me.Time.Text = "Time: Local (HH:MM:SS) Stream (HH:MM:SS) Game (HH:MM:SS)"
        '
        'PartyLabel
        '
        Me.PartyLabel.AutoSize = True
        Me.PartyLabel.Location = New System.Drawing.Point(100, 28)
        Me.PartyLabel.Name = "PartyLabel"
        Me.PartyLabel.Size = New System.Drawing.Size(45, 17)
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
        Me.Status.Location = New System.Drawing.Point(536, 113)
        Me.Status.Name = "Status"
        Me.Status.Size = New System.Drawing.Size(61, 17)
        Me.Status.TabIndex = 14
        Me.Status.Text = "Stopped"
        '
        'StartButton
        '
        Me.StartButton.Location = New System.Drawing.Point(503, 8)
        Me.StartButton.Name = "StartButton"
        Me.StartButton.Size = New System.Drawing.Size(125, 48)
        Me.StartButton.TabIndex = 22
        Me.StartButton.Text = "Start"
        Me.StartButton.UseVisualStyleBackColor = True
        '
        'StopButton
        '
        Me.StopButton.Location = New System.Drawing.Point(503, 62)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(125, 48)
        Me.StopButton.TabIndex = 23
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Live Info:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 17)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "User Defined Info:"
        '
        'LastEventLabel
        '
        Me.LastEventLabel.AutoSize = True
        Me.LastEventLabel.Location = New System.Drawing.Point(37, 130)
        Me.LastEventLabel.Name = "LastEventLabel"
        Me.LastEventLabel.Size = New System.Drawing.Size(75, 17)
        Me.LastEventLabel.TabIndex = 26
        Me.LastEventLabel.Text = "Last Event"
        '
        'LastEvent
        '
        Me.LastEvent.Location = New System.Drawing.Point(118, 127)
        Me.LastEvent.Name = "LastEvent"
        Me.LastEvent.Size = New System.Drawing.Size(383, 22)
        Me.LastEvent.TabIndex = 27
        '
        'Mods
        '
        Me.Mods.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Modification})
        Me.Mods.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.Mods.Location = New System.Drawing.Point(245, 185)
        Me.Mods.Name = "Mods"
        Me.Mods.Size = New System.Drawing.Size(383, 105)
        Me.Mods.TabIndex = 28
        Me.Mods.UseCompatibleStateImageBehavior = False
        Me.Mods.View = System.Windows.Forms.View.Details
        '
        'Modification
        '
        Me.Modification.Text = "Modification"
        Me.Modification.Width = 382
        '
        'AddMod
        '
        Me.AddMod.Location = New System.Drawing.Point(118, 157)
        Me.AddMod.Name = "AddMod"
        Me.AddMod.Size = New System.Drawing.Size(121, 45)
        Me.AddMod.TabIndex = 29
        Me.AddMod.Text = "Add"
        Me.AddMod.UseVisualStyleBackColor = True
        '
        'DeleteMod
        '
        Me.DeleteMod.Location = New System.Drawing.Point(118, 208)
        Me.DeleteMod.Name = "DeleteMod"
        Me.DeleteMod.Size = New System.Drawing.Size(121, 45)
        Me.DeleteMod.TabIndex = 30
        Me.DeleteMod.Text = "Delete"
        Me.DeleteMod.UseVisualStyleBackColor = True
        '
        'ModListLabel
        '
        Me.ModListLabel.AutoSize = True
        Me.ModListLabel.Location = New System.Drawing.Point(178, 256)
        Me.ModListLabel.Name = "ModListLabel"
        Me.ModListLabel.Size = New System.Drawing.Size(61, 17)
        Me.ModListLabel.TabIndex = 31
        Me.ModListLabel.Text = "Mod List"
        '
        'NewMod
        '
        Me.NewMod.Location = New System.Drawing.Point(245, 157)
        Me.NewMod.Name = "NewMod"
        Me.NewMod.Size = New System.Drawing.Size(383, 22)
        Me.NewMod.TabIndex = 32
        '
        'Party
        '
        Me.Party.AutoSize = True
        Me.Party.Location = New System.Drawing.Point(151, 28)
        Me.Party.Name = "Party"
        Me.Party.Size = New System.Drawing.Size(0, 17)
        Me.Party.TabIndex = 33
        '
        'Location
        '
        Me.Location.AutoSize = True
        Me.Location.Location = New System.Drawing.Point(101, 45)
        Me.Location.Name = "Location"
        Me.Location.Size = New System.Drawing.Size(0, 17)
        Me.Location.TabIndex = 34
        '
        'CommitChangesButton
        '
        Me.CommitChangesButton.Location = New System.Drawing.Point(16, 256)
        Me.CommitChangesButton.Name = "CommitChangesButton"
        Me.CommitChangesButton.Size = New System.Drawing.Size(140, 23)
        Me.CommitChangesButton.TabIndex = 35
        Me.CommitChangesButton.Text = "Commit Changes"
        Me.CommitChangesButton.UseVisualStyleBackColor = True
        '
        'StatusUpdateGUIFrontend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 302)
        Me.Controls.Add(Me.CommitChangesButton)
        Me.Controls.Add(Me.Location)
        Me.Controls.Add(Me.Party)
        Me.Controls.Add(Me.NewMod)
        Me.Controls.Add(Me.ModListLabel)
        Me.Controls.Add(Me.DeleteMod)
        Me.Controls.Add(Me.AddMod)
        Me.Controls.Add(Me.Mods)
        Me.Controls.Add(Me.LastEvent)
        Me.Controls.Add(Me.LastEventLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StopButton)
        Me.Controls.Add(Me.StartButton)
        Me.Controls.Add(Me.Status)
        Me.Controls.Add(Me.PartyLabel)
        Me.Controls.Add(Me.Time)
        Me.Controls.Add(Me.LocationLabel)
        Me.Controls.Add(Me.DiscNum)
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LastEventLabel As System.Windows.Forms.Label
    Friend WithEvents LastEvent As System.Windows.Forms.TextBox
    Friend WithEvents Mods As System.Windows.Forms.ListView
    Friend WithEvents Modification As System.Windows.Forms.ColumnHeader
    Friend WithEvents AddMod As System.Windows.Forms.Button
    Friend WithEvents DeleteMod As System.Windows.Forms.Button
    Friend WithEvents ModListLabel As System.Windows.Forms.Label
    Friend WithEvents NewMod As System.Windows.Forms.TextBox
    Friend WithEvents Party As System.Windows.Forms.Label
    Friend WithEvents Location As System.Windows.Forms.Label
    Friend WithEvents CommitChangesButton As System.Windows.Forms.Button

End Class
