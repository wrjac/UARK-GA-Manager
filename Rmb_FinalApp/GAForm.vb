Imports System.Data
Imports System.Data.OleDb
Public Class GAForm
    Private Sub GAForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cb As ComboBox
        Dim cbs = GroupBox1.Controls.OfType(Of ComboBox)()

        Dim reviewdataconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
        Dim con As OleDbCommand = New OleDbCommand()
        Dim reviewdataset As New DataSet()
        Dim tasksdataset As New DataSet()
        Dim customerdirectoryadapter As New OleDbDataAdapter("select g.GAID, concat(ApplicantFirstName, ' ', ApplicantLastName) AS GAName, Semester, concat(SupervisorFName, ' ' , SupervisorLName) AS SupervisorName, Hours  from GAssignment g JOIN committee c on c.memberid = g.memberid JOIN supervisor s on s.supervisorid = g.supervisorid JOIN GA ga on ga.gaid = g.gaid join admitted a on ga.admittedid = a.admittedid join applicant ap on ap.applicantid = a.applicantid", reviewdataconnection)
        Dim adapter2 As New OleDbDataAdapter("select * from Tasks", reviewdataconnection)

        For Each cb In cbs
            cb.SelectedIndex = 0
        Next

        con.Connection = reviewdataconnection
        reviewdataconnection.Open()
        customerdirectoryadapter.Fill(reviewdataset)
        DataGridView1.DataSource = reviewdataset.Tables(0).DefaultView

        adapter2.Fill(tasksdataset)
        DataGridView2.DataSource = tasksdataset.Tables(0).DefaultView
        reviewdataconnection.Close()



    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        Try
            Dim reviewdataconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
            Dim con As OleDbCommand = New OleDbCommand()
            Dim tasksdataset As New DataSet()
            Dim Defaultdataset As New DataSet()
            Dim adapter2 As New OleDbDataAdapter("select * from Tasks where GAID = '" & TextBox7.Text & "' OR Taskstatus = '" & ComboBox12.Text & "'", reviewdataconnection)
            Dim defaultadapter As New OleDbDataAdapter("select * from tasks", reviewdataconnection)

            con.Connection = reviewdataconnection
            reviewdataconnection.Open()

            If TextBox7.Text = "" Then
                defaultadapter.Fill(Defaultdataset)
                DataGridView2.DataSource = Defaultdataset.Tables(0).DefaultView
            ElseIf TextBox7.Text <> "" Then

                adapter2.Fill(tasksdataset)
                DataGridView2.DataSource = tasksdataset.Tables(0).DefaultView
                reviewdataconnection.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Please make sure the query has no special characters or non-ASCII characters.")
            Exit Sub
        End Try
    End Sub

    Private Sub DataGridView2_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellEnter

        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            'Populate the textbox(s) to the specified column's value
            TextBox6.Text = DataGridView2.Rows(e.RowIndex).Cells(3).Value.ToString()
            RichTextBox1.Text = DataGridView2.Rows(e.RowIndex).Cells(4).Value.ToString()
            TextBox9.Text = DataGridView2.Rows(e.RowIndex).Cells(5).Value.ToString()
            TextBox10.Text = DataGridView2.Rows(e.RowIndex).Cells(6).Value.ToString()
            ComboBox9.Text = DataGridView2.Rows(e.RowIndex).Cells(7).Value.ToString()
            TextBox8.Text = DataGridView2.Rows(e.RowIndex).Cells(8).Value.ToString()
            ComboBox7.Text = DataGridView2.Rows(e.RowIndex).Cells(9).Value.ToString()
            ComboBox11.Text = DataGridView2.Rows(e.RowIndex).Cells(10).Value.ToString()
            RichTextBox2.Text = DataGridView2.Rows(e.RowIndex).Cells(11).Value.ToString()
        End If
    End Sub

    Private Sub ComboBox12_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox12.SelectedIndexChanged
        If ComboBox12.SelectedIndex <> -1 And TextBox7.Text <> "" Then
            Dim reviewdataconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
            Dim con As OleDbCommand = New OleDbCommand()
            Dim tasksdataset As New DataSet()
            Dim Defaultdataset As New DataSet()
            Dim adapter2 As New OleDbDataAdapter("select * from Tasks where GAID = '" & TextBox7.Text & "' AND TaskStatus = '" & ComboBox12.Text & "'", reviewdataconnection)


            con.Connection = reviewdataconnection
            reviewdataconnection.Open()
            adapter2.Fill(tasksdataset)
            DataGridView2.DataSource = tasksdataset.Tables(0).DefaultView
            reviewdataconnection.Close()
        Else
            Dim reviewdataconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
            Dim con As OleDbCommand = New OleDbCommand()
            Dim tasksdataset As New DataSet()
            Dim Defaultdataset As New DataSet()
            Dim adapter2 As New OleDbDataAdapter("select * from Tasks where taskstatus = '" & ComboBox12.Text & "'", reviewdataconnection)


            con.Connection = reviewdataconnection
            reviewdataconnection.Open()
            adapter2.Fill(tasksdataset)
            DataGridView2.DataSource = tasksdataset.Tables(0).DefaultView
            reviewdataconnection.Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim Sqlstr As String
            Dim Connectionstring As String = "Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$"
            Sqlstr = "UPDATE tasks SET TaskHoursCompleted = ?, TaskStatus = ?, Comments = ? WHERE GAID = ? "
            Dim sqlconnection As New OleDbConnection(Connectionstring)
            Dim con As OleDbCommand = New OleDbCommand(Sqlstr, sqlconnection)
            sqlconnection.Open()

            'Begin SQL statements

            con.Parameters.AddWithValue("TaskHoursCompleted", Trim(TextBox10.Text))
            con.Parameters.AddWithValue("TaskStatus", Trim(ComboBox11.Text))
            con.Parameters.AddWithValue("Comments", Trim(RichTextBox2.Text))
            con.Parameters.AddWithValue("GAID", Trim(TextBox7.Text))

            con.ExecuteNonQuery()
            MessageBox.Show("Done! To see the changes, please click the Refresh button On the form.")
        Catch ex As Exception
            MsgBox("Please fill out all fields and make sure that you are using the GA ID assigned to you. If this fails, however, please report the following error to the administrator:" & Environment.NewLine & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text <> "" Then
            Dim reviewdataconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
            Dim con As OleDbCommand = New OleDbCommand()
            Dim tasksdataset As New DataSet()
            Dim Defaultdataset As New DataSet()
            Dim adapter2 As New OleDbDataAdapter("select g.GAID, concat(ApplicantFirstName, ' ', ApplicantLastName) AS GAName, Semester, concat(SupervisorFName, ' ' , SupervisorLName) AS SupervisorName, Hours  from GAssignment g JOIN committee c on c.memberid = g.memberid JOIN supervisor s on s.supervisorid = g.supervisorid JOIN GA ga on ga.gaid = g.gaid join admitted a on ga.admittedid = a.admittedid join applicant ap on ap.applicantid = a.applicantid where g.GAID = '" & TextBox2.Text & "'", reviewdataconnection)


            con.Connection = reviewdataconnection
            reviewdataconnection.Open()
            adapter2.Fill(tasksdataset)
            DataGridView1.DataSource = tasksdataset.Tables(0).DefaultView
            reviewdataconnection.Close()
        Else
            Dim reviewdataconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
            Dim con As OleDbCommand = New OleDbCommand()
            Dim tasksdataset As New DataSet()
            Dim Defaultdataset As New DataSet()
            Dim adapter2 As New OleDbDataAdapter("select g.GAID, concat(ApplicantFirstName, ' ', ApplicantLastName) AS GAName, Semester, concat(SupervisorFName, ' ' , SupervisorLName) AS SupervisorName, Hours  from GAssignment g JOIN committee c on c.memberid = g.memberid JOIN supervisor s on s.supervisorid = g.supervisorid JOIN GA ga on ga.gaid = g.gaid join admitted a on ga.admittedid = a.admittedid join applicant ap on ap.applicantid = a.applicantid", reviewdataconnection)


            con.Connection = reviewdataconnection
            reviewdataconnection.Open()
            adapter2.Fill(tasksdataset)
            DataGridView1.DataSource = tasksdataset.Tables(0).DefaultView
            reviewdataconnection.Close()
        End If
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text <> "" Then
            Dim reviewdataconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
            Dim con As OleDbCommand = New OleDbCommand()
            Dim tasksdataset As New DataSet()
            Dim Defaultdataset As New DataSet()
            Dim adapter2 As New OleDbDataAdapter("select g.GAID, concat(ApplicantFirstName, ' ', ApplicantLastName) AS GAName, Semester, concat(SupervisorFName, ' ' , SupervisorLName) AS SupervisorName, Hours  from GAssignment g JOIN committee c on c.memberid = g.memberid JOIN supervisor s on s.supervisorid = g.supervisorid JOIN GA ga on ga.gaid = g.gaid join admitted a on ga.admittedid = a.admittedid join applicant ap on ap.applicantid = a.applicantid where Semester LIKE '" & TextBox4.Text & "%'", reviewdataconnection)


            con.Connection = reviewdataconnection
            reviewdataconnection.Open()
            adapter2.Fill(tasksdataset)
            DataGridView1.DataSource = tasksdataset.Tables(0).DefaultView
            reviewdataconnection.Close()
        Else
            Dim reviewdataconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
            Dim con As OleDbCommand = New OleDbCommand()
            Dim tasksdataset As New DataSet()
            Dim Defaultdataset As New DataSet()
            Dim adapter2 As New OleDbDataAdapter("select g.GAID, concat(ApplicantFirstName, ' ', ApplicantLastName) AS GAName, Semester, concat(SupervisorFName, ' ' , SupervisorLName) AS SupervisorName, Hours  from GAssignment g JOIN committee c on c.memberid = g.memberid JOIN supervisor s on s.supervisorid = g.supervisorid JOIN GA ga on ga.gaid = g.gaid join admitted a on ga.admittedid = a.admittedid join applicant ap on ap.applicantid = a.applicantid", reviewdataconnection)


            con.Connection = reviewdataconnection
            reviewdataconnection.Open()
            adapter2.Fill(tasksdataset)
            DataGridView1.DataSource = tasksdataset.Tables(0).DefaultView
            reviewdataconnection.Close()
        End If
    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            'Populate the textbox(s) to the specified column's value
            TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString()
            RichTextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString()
            TextBox5.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim Sqlstr As String
            Dim Connectionstring As String = "Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$"
            Sqlstr = "insert into GA values (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
            Dim sqlconnection As New OleDbConnection(Connectionstring)
            Dim con As OleDbCommand = New OleDbCommand(Sqlstr, sqlconnection)
            sqlconnection.Open()

            'Begin SQL statements

            con.Parameters.AddWithValue("AdmittedID", Trim(TextBox1.Text))
            con.Parameters.AddWithValue("Availability", Trim(RichTextBox6.Text))
            con.Parameters.AddWithValue("TimeManagementSkills", Trim(ComboBox3.Text))
            con.Parameters.AddWithValue("SpokenEnglishSkills", Trim(ComboBox10.Text))
            con.Parameters.AddWithValue("MultitaskingSkills", Trim(ComboBox4.Text))
            con.Parameters.AddWithValue("SpreadsheetSkills", Trim(ComboBox1.Text))
            con.Parameters.AddWithValue("DatabaseSkills", Trim(ComboBox2.Text))
            con.Parameters.AddWithValue("ProgrammingSkills", Trim(ComboBox6.Text))
            con.Parameters.AddWithValue("ProgrammingLanguages", Trim(RichTextBox4.Text))
            con.Parameters.AddWithValue("SAPSkills", Trim(ComboBox5.Text))
            con.Parameters.AddWithValue("WritingSkills", Trim(ComboBox8.Text))
            con.Parameters.AddWithValue("EditingSkills", Trim(ComboBox13.Text))
            con.Parameters.AddWithValue("OtherSkills", Trim(RichTextBox5.Text))


            con.ExecuteNonQuery()
            MessageBox.Show("Done! To see the changes, please click the Refresh button On the form.")
        Catch ex As Exception
            MsgBox("Please fill out all fields and make sure that you are using the GA ID assigned to you. If this fails, however, please report the following error to the administrator:" & Environment.NewLine & vbCrLf & ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub Refresh_Click(sender As Object, e As EventArgs) Handles Refresh.Click
        Dim reviewdataconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
        Dim con As OleDbCommand = New OleDbCommand()
        Dim reviewdataset As New DataSet()
        Dim tasksdataset As New DataSet()
        Dim customerdirectoryadapter As New OleDbDataAdapter("select g.GAID, concat(ApplicantFirstName, ' ', ApplicantLastName) AS GAName, Semester, concat(SupervisorFName, ' ' , SupervisorLName) AS SupervisorName, Hours  from GAssignment g JOIN committee c on c.memberid = g.memberid JOIN supervisor s on s.supervisorid = g.supervisorid JOIN GA ga on ga.gaid = g.gaid join admitted a on ga.admittedid = a.admittedid join applicant ap on ap.applicantid = a.applicantid", reviewdataconnection)
        Dim adapter2 As New OleDbDataAdapter("select * from Tasks", reviewdataconnection)

        con.Connection = reviewdataconnection
        reviewdataconnection.Open()
        customerdirectoryadapter.Fill(reviewdataset)
        DataGridView1.DataSource = reviewdataset.Tables(0).DefaultView

        adapter2.Fill(tasksdataset)
        DataGridView2.DataSource = tasksdataset.Tables(0).DefaultView
        reviewdataconnection.Close()

    End Sub
End Class