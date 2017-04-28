Public Class Form1
    Dim SQL As New SQLconn
    Private Sub BankAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BankAccountToolStripMenuItem.Click
        Dim oForm As Review
        oForm = New Review()
        oForm.Show()
        oForm = Nothing
        SQL.SqlCon.Close()
    End Sub

    Private Sub CashReceiptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CashReceiptToolStripMenuItem.Click
    End Sub

    Private Sub B_Exit_Click(sender As Object, e As EventArgs) Handles B_Exit.Click
        SQL.SqlCon.Close()
        Application.Exit()
    End Sub

    Private Sub OrderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OrderToolStripMenuItem.Click
        Roster.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        SQL.SqlCon.Close()
        Me.Close()
    End Sub

    Private Sub GraphToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub QueryToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ClassMasterListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClassMasterListToolStripMenuItem.Click
        Display_Classes.Show()
    End Sub

    Private Sub SeniorSurveyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeniorSurveyToolStripMenuItem.Click
        Form2.Show()
    End Sub
End Class
