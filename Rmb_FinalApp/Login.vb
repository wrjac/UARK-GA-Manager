Public Class LoginScreen



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Form1.Show()
        'Me.Hide()

        If ComboBox1.SelectedIndex = 0 Then
            Advisor.Show()
            Me.Hide()

        ElseIf ComboBox1.SelectedIndex = 1 Then
            Review.Show()
            Me.Hide()

        ElseIf ComboBox1.SelectedIndex = 2 Then
            Committee_Review.Show()
            Me.Hide()
        ElseIf ComboBox1.SelectedIndex = 3 Then
            GARequestForm.Show()
            Me.Hide()
        ElseIf ComboBox1.SelectedIndex = 4 Then
            GAForm.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
