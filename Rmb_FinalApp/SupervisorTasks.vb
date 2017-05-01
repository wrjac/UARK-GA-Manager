Imports System.Data
Imports System.Data.OleDb
Public Class SupervisorTasks

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim cb As ComboBox
            Dim rtb As RichTextBox
            Dim tb As TextBox

            Dim cbs = GroupBox1.Controls.OfType(Of ComboBox)()
            Dim rtbs = GroupBox1.Controls.OfType(Of RichTextBox)()
            Dim tbs = GroupBox1.Controls.OfType(Of TextBox)()

            Dim Sqlstr As String
            Dim Connectionstring As String = "Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$"
            Sqlstr = "insert into Tasks values (?, ?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"
            Dim sqlconnection As New OleDbConnection(Connectionstring)
            Dim con As OleDbCommand = New OleDbCommand(Sqlstr, sqlconnection)
            sqlconnection.Open()

            'Begin SQL statements

            con.Parameters.AddWithValue("GAID", Trim(TextBox1.Text))
            con.Parameters.AddWithValue("SupervisorID", Trim(TextBox7.Text))
            con.Parameters.AddWithValue("TaskName", Trim(TextBox6.Text))
            con.Parameters.AddWithValue("TaskDescription", Trim(RichTextBox1.Text))
            con.Parameters.AddWithValue("TaskHoursAnticipated", Trim(TextBox9.Text))
            con.Parameters.AddWithValue("TaskHoursCompleted", vbNullString)
            con.Parameters.AddWithValue("TaskCategory", Trim(ComboBox9.Text))
            con.Parameters.AddWithValue("TaskDueDate", Trim(DateTimePicker1.Value.ToString()))
            con.Parameters.AddWithValue("TaskPriority", Trim(ComboBox7.Text))
            con.Parameters.AddWithValue("TaskStatus", vbNullString)
            con.Parameters.AddWithValue("TaskCommments", vbNullString)








            con.ExecuteNonQuery()
            MessageBox.Show("Done! To see the changes, please click the Refresh button On the form.")

            For Each cb In cbs
                cb.SelectedIndex = -1
            Next

            For Each rtb In rtbs
                rtb.Clear()
            Next

            For Each tb In tbs
                tb.Clear()
            Next

        Catch ex As Exception
            MsgBox("Please fill out all fields and make sure that you are using the GA ID assigned to you. If this fails, however, please report the following error to the administrator:" & Environment.NewLine & vbCrLf & ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub SupervisorTasks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reviewdataconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
        Dim con As OleDbCommand = New OleDbCommand()
        Dim tasksdataset As New DataSet()
        Dim gassignmentdataset As New DataSet()
        Dim adapter2 As New OleDbDataAdapter("select * from Tasks", reviewdataconnection)
        Dim gassignmentadapter As New OleDbDataAdapter("select g.GAID, concat(ApplicantFirstName, ' ', ApplicantLastName) AS GAName, Semester, s.SupervisorID, concat(SupervisorFName, ' ' , SupervisorLName) AS SupervisorName, Hours, ga.availability  from GAssignment g JOIN committee c on c.memberid = g.memberid JOIN supervisor s on s.supervisorid = g.supervisorid JOIN GA ga on ga.gaid = g.gaid join admitted a on ga.admittedid = a.admittedid join applicant ap on ap.applicantid = a.applicantid", reviewdataconnection)





        con.Connection = reviewdataconnection
        reviewdataconnection.Open()
        adapter2.Fill(tasksdataset)
        gassignmentadapter.Fill(gassignmentdataset)
        TasksDataGrid.DataSource = tasksdataset.Tables(0).DefaultView
        Gassignmentdatagridview.DataSource = gassignmentdataset.Tables(0).DefaultView
        reviewdataconnection.Close()



    End Sub

    Private Sub TasksDataGrid_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles TasksDataGrid.CellEnter

        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            'Populate the textbox(s) to the specified column's value
            TextBox5.Text = TasksDataGrid.Rows(e.RowIndex).Cells(3).Value.ToString()
            RichTextBox3.Text = TasksDataGrid.Rows(e.RowIndex).Cells(4).Value.ToString()
            TextBox3.Text = TasksDataGrid.Rows(e.RowIndex).Cells(5).Value.ToString()
            TextBox10.Text = TasksDataGrid.Rows(e.RowIndex).Cells(6).Value.ToString()
            TextBox15.Text = TasksDataGrid.Rows(e.RowIndex).Cells(7).Value.ToString()
            TextBox4.Text = TasksDataGrid.Rows(e.RowIndex).Cells(8).Value.ToString()
            TextBox16.Text = TasksDataGrid.Rows(e.RowIndex).Cells(9).Value.ToString()
            TextBox17.Text = TasksDataGrid.Rows(e.RowIndex).Cells(10).Value.ToString()
            RichTextBox2.Text = TasksDataGrid.Rows(e.RowIndex).Cells(11).Value.ToString()


        End If

    End Sub

    Private Sub ComboBox12_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox12.SelectedIndexChanged
        Dim reviewdataconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
        Dim con As OleDbCommand = New OleDbCommand()
        Dim tasksdataset As New DataSet()
        Dim adapter2 As New OleDbDataAdapter("select * from Tasks where taskstatus = '" & ComboBox12.Text & "' OR TaskID = '" & Trim(TextBox2.Text) & "'", reviewdataconnection)
        Dim defaultadapter As New OleDbDataAdapter("select * from tasks where taskid = '" & Trim(TextBox2.Text) & "'", reviewdataconnection)

        If ComboBox12.SelectedIndex <> 0 Then
            con.Connection = reviewdataconnection
            reviewdataconnection.Open()
            adapter2.Fill(tasksdataset)
            TasksDataGrid.DataSource = tasksdataset.Tables(0).DefaultView
            reviewdataconnection.Close()
        Else
            con.Connection = reviewdataconnection
            reviewdataconnection.Open()
            defaultadapter.Fill(tasksdataset)
            TasksDataGrid.DataSource = tasksdataset.Tables(0).DefaultView
            reviewdataconnection.Close()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Try
            Dim reviewdataconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
            Dim con As OleDbCommand = New OleDbCommand()
            Dim tasksdataset As New DataSet()
            Dim adapter2 As New OleDbDataAdapter("select * from tasks where gaid = '" & Trim(TextBox2.Text) & "'", reviewdataconnection)
            Dim defaultadapter As New OleDbDataAdapter("Select * from tasks", reviewdataconnection)

            con.Connection = reviewdataconnection
            reviewdataconnection.Open()

            If TextBox2.Text <> "" Then
                adapter2.Fill(tasksdataset)
                TasksDataGrid.DataSource = tasksdataset.Tables(0).DefaultView
            ElseIf TextBox2.Text = "" Then
                defaultadapter.Fill(tasksdataset)
                TasksDataGrid.DataSource = tasksdataset.Tables(0).DefaultView
            End If
        Catch ex As Exception
            MessageBox.Show("Please make sure the query has no special characters or non-ASCII characters.")
            Exit Sub
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim Sqlstr As String
            Dim Connectionstring As String = "Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$"
            Sqlstr = "UPDATE tasks SET TaskHoursCompleted = ?, TaskStatus = ?, Comments = ? WHERE GAID = ? "
            Dim sqlconnection As New OleDbConnection(Connectionstring)
            Dim con As OleDbCommand = New OleDbCommand(Sqlstr, sqlconnection)
            sqlconnection.Open()

            'Begin SQL statements

            con.Parameters.AddWithValue("TaskHoursCompleted", Trim(TextBox10.Text))
            con.Parameters.AddWithValue("TaskStatus", Trim(TextBox17.Text))
            con.Parameters.AddWithValue("Comments", Trim(RichTextBox2.Text))
            con.Parameters.AddWithValue("GAID", Trim(TextBox2.Text))

            con.ExecuteNonQuery()
            MessageBox.Show("Done! To see the changes, please click the Refresh button On the form.")
        Catch ex As Exception
            MsgBox("Please fill out all fields and make sure that you are using the GA ID assigned to you. If this fails, however, please report the following error to the administrator:" & Environment.NewLine & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub Gassignmentdatagridview_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Gassignmentdatagridview.CellEnter
        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            'Populate the textbox(s) to the specified column's value
            TextBox13.Text = Gassignmentdatagridview.Rows(e.RowIndex).Cells(4).Value.ToString()
            RichTextBox4.Text = Gassignmentdatagridview.Rows(e.RowIndex).Cells(1).Value.ToString()
            TextBox11.Text = Gassignmentdatagridview.Rows(e.RowIndex).Cells(5).Value.ToString()
            RichTextBox5.Text = Gassignmentdatagridview.Rows(e.RowIndex).Cells(6).Value.ToString()
        End If

    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged
        Dim reviewdataconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
        Dim con As OleDbCommand = New OleDbCommand()
        Dim tasksdataset As New DataSet()
        Dim Defaultdataset As New DataSet()
        Dim gassignmentadapter As New OleDbDataAdapter("select g.GAID, concat(ApplicantFirstName, ' ', ApplicantLastName) AS GAName, Semester, s.SupervisorID, concat(SupervisorFName, ' ' , SupervisorLName) AS SupervisorName, Hours, ga.availability  from GAssignment g JOIN committee c on c.memberid = g.memberid JOIN supervisor s on s.supervisorid = g.supervisorid JOIN GA ga on ga.gaid = g.gaid join admitted a on ga.admittedid = a.admittedid join applicant ap on ap.applicantid = a.applicantid  where Semester LIKE '" & TextBox12.Text & "%' OR s.SupervisorID LIKE'" & TextBox14.Text & "'", reviewdataconnection)


        con.Connection = reviewdataconnection
        reviewdataconnection.Open()
        gassignmentadapter.Fill(tasksdataset)
        Gassignmentdatagridview.DataSource = tasksdataset.Tables(0).DefaultView
        reviewdataconnection.Close()
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged

        Dim reviewdataconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
            Dim con As OleDbCommand = New OleDbCommand()
            Dim tasksdataset As New DataSet()
            Dim Defaultdataset As New DataSet()
            Dim gassignmentadapter As New OleDbDataAdapter("select g.GAID, concat(ApplicantFirstName, ' ', ApplicantLastName) AS GAName, Semester, s.SupervisorID, concat(SupervisorFName, ' ' , SupervisorLName) AS SupervisorName, Hours, ga.availability  from GAssignment g JOIN committee c on c.memberid = g.memberid JOIN supervisor s on s.supervisorid = g.supervisorid JOIN GA ga on ga.gaid = g.gaid join admitted a on ga.admittedid = a.admittedid join applicant ap on ap.applicantid = a.applicantid  where s.SupervisorID LIKE '" & TextBox14.Text & "%' OR Semester LIKE '" & TextBox12.Text & "'", reviewdataconnection)


            con.Connection = reviewdataconnection
            reviewdataconnection.Open()
            gassignmentadapter.Fill(tasksdataset)
            Gassignmentdatagridview.DataSource = tasksdataset.Tables(0).DefaultView
        reviewdataconnection.Close()
    End Sub
End Class