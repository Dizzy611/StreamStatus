Public Class ModlistForm
    Private Sub ModlistForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        If My.Settings.ModList IsNot Nothing Then
            For Each i As String In My.Settings.ModList
                MainModList.Items.Add(My.Settings.ModList(i))
            Next
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not String.IsNullOrWhiteSpace(ModTextBox.Text) Then
            My.Settings.ModList.Add("test")
            MainModList.Items.Add(Me.ModTextBox.Text)
            Me.ModTextBox.Text = ""
        End If
    End Sub
End Class