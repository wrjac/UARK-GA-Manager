Imports System.Data
Imports System.Data.OleDb
Public Class Advisor
    Private Sub Advisor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim reviewdataconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
        Dim con As OleDbCommand = New OleDbCommand()
        Dim reviewdataset As New DataSet()
        con.Connection = reviewdataconnection
        Dim studentcmd As OleDbCommand = New OleDbCommand()
        Dim dr As OleDbDataReader

        reviewdataconnection.Open()
        studentcmd.Connection = reviewdataconnection

        studentcmd.CommandText = "select e.admittedid, e.enrollid, c.classid, classname, classhours, classgrade, enrolldate, admittedstudentstatus from Enroll e
JOIN CLASS C
on e.classid = c.classid
JOIN ADMITTED A
on a.admittedid = e.admittedid "
        dr = studentcmd.ExecuteReader()

        Do While dr.Read = True
            StudentComboBox.Items.Add(dr.GetValue(0)).ToString()
        Loop
        reviewdataconnection.Close()
        StudentComboBox.SelectedIndex = 0




    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Display_Classes.Show()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        AdvisorComboBox.ResetText()
        ProgramComboBox.ResetText()
        StudentComboBox.ResetText()

        EnrollTextBox.Clear()
        ClassIDTextBox.Clear()
        ClassNameTextBox.Clear()
        HoursTextBox.Clear()
        GradeTextBox.Clear()
        EnrollDateTextBox.Clear()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Try
        '    Dim Sqlstr As String
        '    Dim Connectionstring As String = "Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$"
        '    Sqlstr = "insert into Review values (?, ?, ?, ?, ?, ?, ?)"
        '    Dim sqlconnection As New OleDbConnection(Connectionstring)
        '    Dim con As OleDbCommand = New OleDbCommand(Sqlstr, sqlconnection)
        '    sqlconnection.Open()

        '    'Begin SQL statements
        '    con.Parameters.AddWithValue("InterviewDate", (InterviewDateTimePicker.Value.ToString))
        '    con.Parameters.AddWithValue("ApplicantScore", Trim(ApplicantScoreTextBox.Text))
        '    con.Parameters.AddWithValue("Reccomendation", Trim(RecComboBox.Text))
        '    con.Parameters.AddWithValue("ReviewComments", Trim(ReviewCommentsTextBox.Text))
        '    con.Parameters.AddWithValue("InterviewScore", Trim(InterviewScoreTextBox.Text))
        '    con.Parameters.AddWithValue("InterviewComments", Trim(InterviewCommentsTextBox.Text))

        '    con.ExecuteNonQuery()
        '    MessageBox.Show("Done! To see the changes, please click the Refresh button On the form.")
        'Catch ex As Exception
        '    MsgBox("Please fill out all fields and make sure that you are using the Member ID assigned to you. If this fails, however, please report the following error to the administrator:" & Environment.NewLine & vbCrLf & ex.Message)
        'End Try
    End Sub

    Private Sub AdvisorComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AdvisorComboBox.SelectedIndexChanged
        If AdvisorComboBox.SelectedIndex = 0 Then
            StudentComboBox.Items.Clear()
            Dim reviewdataconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
            Dim con As OleDbCommand = New OleDbCommand()
            Dim studentcmd As OleDbCommand = New OleDbCommand()
            Dim dr As OleDbDataReader
            reviewdataconnection.Open()
            studentcmd.Connection = reviewdataconnection

            studentcmd.CommandText = "select e.admittedid, e.enrollid, c.classid, classname, classhours, classgrade, enrolldate, admittedstudentstatus from Enroll e
JOIN CLASS C
on e.classid = c.classid
JOIN ADMITTED A
on a.admittedid = e.admittedid
WHERE advisorid = 710"
            dr = studentcmd.ExecuteReader()

            Do While dr.Read = True
                StudentComboBox.Items.Add(dr.GetValue(0)).ToString()
            Loop
            reviewdataconnection.Close()
            StudentComboBox.SelectedIndex = 0
        End If

        If AdvisorComboBox.SelectedIndex = 1 Then
            StudentComboBox.Items.Clear()
            Dim reviewdataconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
            Dim con As OleDbCommand = New OleDbCommand()
            Dim studentcmd As OleDbCommand = New OleDbCommand()
            Dim dr As OleDbDataReader
            reviewdataconnection.Open()
            studentcmd.Connection = reviewdataconnection

            studentcmd.CommandText = "select e.admittedid, e.enrollid, c.classid, classname, classhours, classgrade, enrolldate, admittedstudentstatus from Enroll e
JOIN CLASS C
on e.classid = c.classid
JOIN ADMITTED A
on a.admittedid = e.admittedid
Where AdvisorID = 720"
            dr = studentcmd.ExecuteReader()

            Do While dr.Read = True
                StudentComboBox.Items.Add(dr.GetValue(0)).ToString()
            Loop
            reviewdataconnection.Close()
            StudentComboBox.SelectedIndex = 0
        End If
    End Sub

    Private Sub StudentComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StudentComboBox.SelectedIndexChanged
        Dim reviewdataconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
        Dim con As OleDbCommand = New OleDbCommand()
        Dim reviewdataset As New DataSet()
        con.Connection = reviewdataconnection
        Dim studentcmd As OleDbCommand = New OleDbCommand()
        Dim dr As OleDbDataReader

        Dim customerdirectoryadapter As New OleDbDataAdapter("select e.admittedid, e.enrollid, c.classid, classname, classhours, classgrade, enrolldate, admittedstudentstatus from Enroll e
JOIN CLASS C
on e.classid = c.classid
JOIN ADMITTED A
on a.admittedid = e.admittedid
WHERE e.admittedid = '" & StudentComboBox.Text & "'", reviewdataconnection)
        reviewdataconnection.Open()
        customerdirectoryadapter.Fill(reviewdataset)
        DataGridView1.DataSource = reviewdataset.Tables(0).DefaultView
        reviewdataconnection.Close()

    End Sub

    Private Sub ProgramComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProgramComboBox.SelectedIndexChanged
        Dim reviewdataconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
        Dim con As OleDbCommand = New OleDbCommand()
        Dim reviewdataset As New DataSet()
        con.Connection = reviewdataconnection
        Dim customerdirectoryadapter As New OleDbDataAdapter("select e.admittedid, e.enrollid, c.classid, classname, classhours, classgrade, enrolldate, admittedstudentstatus from Enroll e
JOIN CLASS C
on e.classid = c.classid
JOIN ADMITTED A
on a.admittedid = e.admittedid where admittedstudentstatus = '" & ProgramComboBox.Text & "' and advisorid = '" & AdvisorComboBox.Text & "'", reviewdataconnection)
        reviewdataconnection.Open()
        customerdirectoryadapter.Fill(reviewdataset)
        DataGridView1.DataSource = reviewdataset.Tables(0).DefaultView
        reviewdataconnection.Close()
    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter

        EnrollTextBox.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
        ClassIDTextBox.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
        ClassNameTextBox.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
        HoursTextBox.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
        GradeTextBox.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString()
        EnrollDateTextBox.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString()
    End Sub
End Class