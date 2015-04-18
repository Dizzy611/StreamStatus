' Copyright (C) 2015 Dylan J. Morrison <insidious@gmail.com>
' This work is free. You can redistribute it and/or modify
' it under the terms of the Do What The Fuck You Want To 
' Public License, Version 2, as published by Sam Hocevar.
' See http://www.wtfpl.net/ for more details.

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StatusUpdater
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Disc = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Location = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LastEvent = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GameTimeHours = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GameTimeMinutes = New System.Windows.Forms.TextBox()
        Me.GameTimeSeconds = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PartyMember1Name = New System.Windows.Forms.TextBox()
        Me.PartyMember1Level = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PartyMember2Name = New System.Windows.Forms.TextBox()
        Me.PartyMember2Level = New System.Windows.Forms.NumericUpDown()
        Me.PartyMember3Name = New System.Windows.Forms.TextBox()
        Me.PartyMember3Level = New System.Windows.Forms.NumericUpDown()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Mods = New System.Windows.Forms.TextBox()
        CType(Me.Disc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartyMember1Level, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartyMember2Level, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PartyMember3Level, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Disc"
        '
        'Disc
        '
        Me.Disc.Location = New System.Drawing.Point(55, 13)
        Me.Disc.Maximum = New Decimal(New Integer() {3, 0, 0, 0})
        Me.Disc.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Disc.Name = "Disc"
        Me.Disc.Size = New System.Drawing.Size(32, 22)
        Me.Disc.TabIndex = 1
        Me.Disc.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Location"
        '
        'Location
        '
        Me.Location.Location = New System.Drawing.Point(95, 38)
        Me.Location.Name = "Location"
        Me.Location.Size = New System.Drawing.Size(219, 22)
        Me.Location.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Last Event"
        '
        'LastEvent
        '
        Me.LastEvent.Location = New System.Drawing.Point(95, 64)
        Me.LastEvent.Name = "LastEvent"
        Me.LastEvent.Size = New System.Drawing.Size(219, 22)
        Me.LastEvent.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Game Time"
        '
        'GameTimeHours
        '
        Me.GameTimeHours.Location = New System.Drawing.Point(95, 92)
        Me.GameTimeHours.MaxLength = 2
        Me.GameTimeHours.Name = "GameTimeHours"
        Me.GameTimeHours.Size = New System.Drawing.Size(28, 22)
        Me.GameTimeHours.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(120, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(12, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = ":"
        '
        'GameTimeMinutes
        '
        Me.GameTimeMinutes.Location = New System.Drawing.Point(130, 93)
        Me.GameTimeMinutes.MaxLength = 2
        Me.GameTimeMinutes.Name = "GameTimeMinutes"
        Me.GameTimeMinutes.Size = New System.Drawing.Size(28, 22)
        Me.GameTimeMinutes.TabIndex = 9
        '
        'GameTimeSeconds
        '
        Me.GameTimeSeconds.Location = New System.Drawing.Point(164, 92)
        Me.GameTimeSeconds.MaxLength = 2
        Me.GameTimeSeconds.Name = "GameTimeSeconds"
        Me.GameTimeSeconds.Size = New System.Drawing.Size(28, 22)
        Me.GameTimeSeconds.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(155, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(12, 17)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Party"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 163)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 17)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Name"
        '
        'PartyMember1Name
        '
        Me.PartyMember1Name.Location = New System.Drawing.Point(16, 184)
        Me.PartyMember1Name.Name = "PartyMember1Name"
        Me.PartyMember1Name.Size = New System.Drawing.Size(100, 22)
        Me.PartyMember1Name.TabIndex = 14
        '
        'PartyMember1Level
        '
        Me.PartyMember1Level.Location = New System.Drawing.Point(123, 183)
        Me.PartyMember1Level.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.PartyMember1Level.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PartyMember1Level.Name = "PartyMember1Level"
        Me.PartyMember1Level.Size = New System.Drawing.Size(38, 22)
        Me.PartyMember1Level.TabIndex = 15
        Me.PartyMember1Level.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(123, 162)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(42, 17)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Level"
        '
        'PartyMember2Name
        '
        Me.PartyMember2Name.Location = New System.Drawing.Point(16, 213)
        Me.PartyMember2Name.Name = "PartyMember2Name"
        Me.PartyMember2Name.Size = New System.Drawing.Size(100, 22)
        Me.PartyMember2Name.TabIndex = 17
        '
        'PartyMember2Level
        '
        Me.PartyMember2Level.Location = New System.Drawing.Point(123, 213)
        Me.PartyMember2Level.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.PartyMember2Level.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PartyMember2Level.Name = "PartyMember2Level"
        Me.PartyMember2Level.Size = New System.Drawing.Size(38, 22)
        Me.PartyMember2Level.TabIndex = 18
        Me.PartyMember2Level.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'PartyMember3Name
        '
        Me.PartyMember3Name.Location = New System.Drawing.Point(16, 242)
        Me.PartyMember3Name.Name = "PartyMember3Name"
        Me.PartyMember3Name.Size = New System.Drawing.Size(100, 22)
        Me.PartyMember3Name.TabIndex = 19
        '
        'PartyMember3Level
        '
        Me.PartyMember3Level.Location = New System.Drawing.Point(122, 241)
        Me.PartyMember3Level.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.PartyMember3Level.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.PartyMember3Level.Name = "PartyMember3Level"
        Me.PartyMember3Level.Size = New System.Drawing.Size(38, 22)
        Me.PartyMember3Level.TabIndex = 20
        Me.PartyMember3Level.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(188, 211)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(75, 23)
        Me.UpdateButton.TabIndex = 21
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'ResetButton
        '
        Me.ResetButton.Location = New System.Drawing.Point(188, 240)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(96, 23)
        Me.ResetButton.TabIndex = 22
        Me.ResetButton.Text = "Reset Timer"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 284)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(42, 17)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Mods"
        '
        'Mods
        '
        Me.Mods.Location = New System.Drawing.Point(12, 304)
        Me.Mods.Name = "Mods"
        Me.Mods.Size = New System.Drawing.Size(297, 22)
        Me.Mods.TabIndex = 24
        '
        'StatusUpdater
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(321, 337)
        Me.Controls.Add(Me.Mods)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.PartyMember3Level)
        Me.Controls.Add(Me.PartyMember3Name)
        Me.Controls.Add(Me.PartyMember2Level)
        Me.Controls.Add(Me.PartyMember2Name)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PartyMember1Level)
        Me.Controls.Add(Me.PartyMember1Name)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GameTimeSeconds)
        Me.Controls.Add(Me.GameTimeMinutes)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GameTimeHours)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LastEvent)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Location)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Disc)
        Me.Controls.Add(Me.Label1)
        Me.Name = "StatusUpdater"
        Me.Text = "Status Updater"
        CType(Me.Disc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartyMember1Level, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartyMember2Level, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PartyMember3Level, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Disc As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Location As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LastEvent As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GameTimeHours As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GameTimeMinutes As System.Windows.Forms.TextBox
    Friend WithEvents GameTimeSeconds As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PartyMember1Name As System.Windows.Forms.TextBox
    Friend WithEvents PartyMember1Level As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PartyMember2Name As System.Windows.Forms.TextBox
    Friend WithEvents PartyMember2Level As System.Windows.Forms.NumericUpDown
    Friend WithEvents PartyMember3Name As System.Windows.Forms.TextBox
    Friend WithEvents PartyMember3Level As System.Windows.Forms.NumericUpDown
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents ResetButton As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Mods As System.Windows.Forms.TextBox

End Class
