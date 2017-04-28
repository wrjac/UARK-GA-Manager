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
        Dim adapter2 As New OleDbDataAdapter("select * from Tasks", reviewdataconnection)



        con.Connection = reviewdataconnection
        reviewdataconnection.Open()
        adapter2.Fill(tasksdataset)
        TasksDataGrid.DataSource = tasksdataset.Tables(0).DefaultView
        reviewdataconnection.Close()

    End Sub
End Class