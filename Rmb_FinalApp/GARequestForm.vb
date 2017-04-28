Imports System.Data
Imports System.Data.OleDb
Public Class GARequestForm


    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub GARequestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GASpreadsheetComboBox.SelectedIndex = 0
        GADatabaseComboBox.SelectedIndex = 0
        GAHoursNeededComboBox.SelectedIndex = 0
        GASAPSkillsComboBox.SelectedIndex = 0
        GAProgrammingSkillsComboBox.SelectedIndex = 0
        GAWritingSkillsComboBox.SelectedIndex = 0
        GAEditingSkillsComboBox.SelectedIndex = 0
        GASpeakingSkillsComboBox.SelectedIndex = 0

    End Sub

    Private Sub GAHoursNeededComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles GAHoursNeededComboBox.SelectedIndexChanged

    End Sub

    Private Sub SubmitButton_Click_1(sender As Object, e As EventArgs) Handles SubmitButton.Click
        Try
            Dim Sqlstr As String
            Dim Connectionstring As String = "Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$"
            Sqlstr = "insert into GAForm values (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
            Dim sqlconnection As New OleDbConnection(Connectionstring)
            Dim con As OleDbCommand = New OleDbCommand(Sqlstr, sqlconnection)
            sqlconnection.Open()

            'Begin SQL statements

            con.Parameters.AddWithValue("SupervisorID", Trim(SupervisorIDTextBox.Text))
            con.Parameters.AddWithValue("GANeeds", Trim(GANeedsTextBox.Text))
            con.Parameters.AddWithValue("Semester", Trim(SemesterTextBox.Text))
            con.Parameters.AddWithValue("GAQuantity", Trim(GAQuantityTextBox.Text))
            con.Parameters.AddWithValue("GAConcentrationDesired", Trim(ConcentrationPreferredComboBox.Text))
            con.Parameters.AddWithValue("GAHoursNeeded", Trim(GAHoursNeededComboBox.Text))
            con.Parameters.AddWithValue("GASpreadsheets", Trim(GASpreadsheetComboBox.Text))
            con.Parameters.AddWithValue("GADatabase", Trim(GADatabaseComboBox.Text))
            con.Parameters.AddWithValue("GAProgrammingSkills", Trim(GAProgrammingSkillsComboBox.Text))
            con.Parameters.AddWithValue("GAProgrammingLanguages", Trim(GAProgramsTextBox.Text))
            con.Parameters.AddWithValue("GAPSAPSkills", Trim(GASAPSkillsComboBox.Text))
            con.Parameters.AddWithValue("GAWritingSkills", Trim(GAWritingSkillsComboBox.Text))
            con.Parameters.AddWithValue("GAEditingSkills", Trim(GAEditingSkillsComboBox.Text))
            con.Parameters.AddWithValue("GASpeakingSkills", Trim(GASpeakingSkillsComboBox.Text))
            con.Parameters.AddWithValue("GAComments", Trim(GACommentsTextBox.Text))
            con.Parameters.AddWithValue("GAOtherSkills", Trim(OtherSkillsTextBox.Text))




            con.ExecuteNonQuery()
            MessageBox.Show("Done! To see the changes, please click the Refresh button On the form.")
        Catch ex As Exception
            MsgBox("Please fill out all fields and make sure that you are using the Supervisor ID assigned to you. If this fails, however, please report the following error to the administrator:" & Environment.NewLine & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub AssignTasksToGraduateAssistanttsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AssignTasksToGraduateAssistanttsToolStripMenuItem.Click
        SupervisorTasks.Show()
    End Sub
End Class
