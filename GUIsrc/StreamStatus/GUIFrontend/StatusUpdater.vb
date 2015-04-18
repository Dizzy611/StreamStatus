' Copyright (C) 2015 Dylan J. Morrison <insidious@gmail.com>
' This work is free. You can redistribute it and/or modify
' it under the terms of the Do What The Fuck You Want To 
' Public License, Version 2, as published by Sam Hocevar.
' See http://www.wtfpl.net/ for more details.

Imports System.Xml
Public Class StatusUpdater
    Public Function TimeToUnix(ByVal dteDate As Date) As String
        If dteDate.IsDaylightSavingTime = True Then
            dteDate = DateAdd(DateInterval.Hour, -1, dteDate)
        End If
        dteDate = DateAdd(DateInterval.Hour, 6, dteDate) 'We're UTC-6, so add 6 to get UTC (which is what the PHP file is expecting as a unix time)
        TimeToUnix = DateDiff(DateInterval.Second, #1/1/1970#, dteDate)
    End Function
    Dim Started As Boolean = False
    Dim StartTime As Integer = 0
    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        ' If we've already started the stream, don't update the stream start time. If we
        ' haven't, or if somebody's recently hit reset, update the start time.
        If Started = False Then
            ' Debugging
            Console.WriteLine(DateTime.Now.ToString)
            Console.WriteLine(TimeToUnix(DateTime.Now))
            StartTime = Convert.ToInt32(TimeToUnix(DateTime.Now))
            Console.WriteLine(StartTime)
            Started = True
        End If
        Dim Settings As XmlWriterSettings = New XmlWriterSettings()
        Settings.Indent = True
        Using writer As XmlWriter = XmlWriter.Create(".\status.xml", Settings)
            Dim GameTime As Integer
            GameTime = (Convert.ToInt32(GameTimeHours.Text) * 3600) + (Convert.ToInt32(GameTimeMinutes.Text) * 60) + Convert.ToInt32(GameTimeSeconds.Text)
            writer.WriteStartDocument()
            writer.WriteStartElement("status")                                    ' <status>
            writer.WriteElementString("disc", Disc.Value.ToString)                '    <disc>1</disc>
            writer.WriteElementString("location", Location.Text)                  '    <location>God Knows</location>
            writer.WriteElementString("timestarted", StartTime.ToString)          '    <timestarted>1428292404</timestarted>
            writer.WriteElementString("gametime", GameTime.ToString)              '    <gametime>79324</gametime>
            writer.WriteElementString("lastevent", LastEvent.Text)                '    <lastevent>I Picked a Booger</lastevent>
            writer.WriteElementString("mods", Mods.Text)                          '    <mods>Reunion R03b, 7thHeaven</mods>
            writer.WriteStartElement("party")                                     '    <party>
            writer.WriteStartElement("member")                                    '       <member>
            writer.WriteElementString("name", PartyMember1Name.Text)              '          <name>Bozo</name>
            writer.WriteElementString("level", PartyMember1Level.Value.ToString)  '          <level>4</level>
            writer.WriteEndElement()                                              '       </member>
            If Not String.IsNullOrEmpty(PartyMember2Name.Text) Then               '    [...] (more members, meet at the next comment :P)
                writer.WriteStartElement("member")
                writer.WriteElementString("name", PartyMember2Name.Text)
                writer.WriteElementString("level", PartyMember2Level.Value.ToString)
                writer.WriteEndElement()
            End If
            If Not String.IsNullOrEmpty(PartyMember3Name.Text) Then
                writer.WriteStartElement("member")
                writer.WriteElementString("name", PartyMember3Name.Text)
                writer.WriteElementString("level", PartyMember3Level.Value.ToString)
                writer.WriteEndElement()
            End If
            writer.WriteEndElement()                                              '    </party>
            writer.WriteEndElement()                                              ' </status>
            writer.WriteEndDocument()
        End Using
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        If Started = True Then
            Started = False
            StartTime = 0
        End If
    End Sub
End Class
