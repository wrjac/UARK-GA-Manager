Imports System.Data
Imports System.Data.OleDb
Public Class DirectorGAForm
    Private Sub DirectorGAForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reviewdataconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
        Dim con As OleDbCommand = New OleDbCommand()
        Dim tasksdataset As New DataSet()
        Dim gassignmentdataset As New DataSet()
        Dim availablesupervisorsdataset As New DataSet()
        Dim availablegasdataset As New DataSet()
        Dim adapter2 As New OleDbDataAdapter("select * from GAForm", reviewdataconnection)
        Dim gaskillsadapter As New OleDbDataAdapter("select * from ga", reviewdataconnection)
        Dim availablesupervisorsadapter As New OleDbDataAdapter("select s.SupervisorID, concat(SuperVisorFname, ' ', SuperVisorLName) AS SupervisorName from gassignment gass RIGHT JOIN supervisor s on s.supervisorid = gass.supervisorid where GASS.SupervisorID IS NULL", reviewdataconnection)
        Dim availablegastudentsadapter As New OleDbDataAdapter("select g.gaid, concat(ap.ApplicantFirstName, ' ', ap.ApplicantLastName) As GAName from gassignment gass RIGHT JOIN ga g on gass.gaid= g.gaid JOIN admitted a on g.admittedid = a.admittedid JOIN applicant ap on ap.applicantid = a.applicantid WHERE gass.gaid IS NULL", reviewdataconnection)




        con.Connection = reviewdataconnection
        reviewdataconnection.Open()
        adapter2.Fill(tasksdataset)
        gaskillsadapter.Fill(gassignmentdataset)
        availablesupervisorsadapter.Fill(availablesupervisorsdataset)
        availablegastudentsadapter.Fill(availablegasdataset)
        DataGridView1.DataSource = tasksdataset.Tables(0).DefaultView
        DataGridView2.DataSource = gassignmentdataset.Tables(0).DefaultView
        DataGridView3.DataSource = availablesupervisorsdataset.Tables(0).DefaultView
        DataGridView4.DataSource = availablegasdataset.Tables(0).DefaultView
        reviewdataconnection.Close()

    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            'Populate the textbox(s) to the specified column's value
            RichTextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString()
            TextBox6.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString()
            TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(5).Value.ToString()
            TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(6).Value.ToString()
            TextBox5.Text = DataGridView1.Rows(e.RowIndex).Cells(7).Value.ToString()
            TextBox7.Text = DataGridView1.Rows(e.RowIndex).Cells(8).Value.ToString()
            TextBox9.Text = DataGridView1.Rows(e.RowIndex).Cells(9).Value.ToString()
            RichTextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(10).Value.ToString()
            TextBox8.Text = DataGridView1.Rows(e.RowIndex).Cells(11).Value.ToString()
            TextBox10.Text = DataGridView1.Rows(e.RowIndex).Cells(12).Value.ToString()
            TextBox11.Text = DataGridView1.Rows(e.RowIndex).Cells(13).Value.ToString()
            TextBox12.Text = DataGridView1.Rows(e.RowIndex).Cells(14).Value.ToString()
            RichTextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(15).Value.ToString()
            TextBox4.Text = DataGridView1.Rows(e.RowIndex).Cells(16).Value.ToString()
        End If
    End Sub

    Private Sub DataGridView2_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellEnter
        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            'Populate the textbox(s) to the specified column's value
            RichTextBox6.Text = DataGridView2.Rows(e.RowIndex).Cells(2).Value.ToString()
            TextBox20.Text = DataGridView2.Rows(e.RowIndex).Cells(3).Value.ToString()
            TextBox21.Text = DataGridView2.Rows(e.RowIndex).Cells(4).Value.ToString()
            TextBox19.Text = DataGridView2.Rows(e.RowIndex).Cells(5).Value.ToString()
            TextBox14.Text = DataGridView2.Rows(e.RowIndex).Cells(6).Value.ToString()
            TextBox15.Text = DataGridView2.Rows(e.RowIndex).Cells(7).Value.ToString()
            TextBox17.Text = DataGridView2.Rows(e.RowIndex).Cells(8).Value.ToString()
            RichTextBox4.Text = DataGridView2.Rows(e.RowIndex).Cells(9).Value.ToString()
            TextBox16.Text = DataGridView2.Rows(e.RowIndex).Cells(10).Value.ToString()
            TextBox18.Text = DataGridView2.Rows(e.RowIndex).Cells(11).Value.ToString()
            TextBox33.Text = DataGridView2.Rows(e.RowIndex).Cells(12).Value.ToString()
            RichTextBox5.Text = DataGridView2.Rows(e.RowIndex).Cells(13).Value.ToString()
        End If
    End Sub

    Private Sub DataGridView3_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellEnter
        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            'Populate the textbox(s) to the specified column's value
            TextBox22.Text = DataGridView3.Rows(e.RowIndex).Cells(0).Value.ToString()
            TextBox23.Text = DataGridView3.Rows(e.RowIndex).Cells(1).Value.ToString()
        End If
    End Sub

    Private Sub DataGridView4_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView4.CellEnter
        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            'Populate the textbox(s) to the specified column's value
            TextBox24.Text = DataGridView4.Rows(e.RowIndex).Cells(0).Value.ToString()
            TextBox25.Text = DataGridView4.Rows(e.RowIndex).Cells(1).Value.ToString()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim reviewdataconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
        Dim con As OleDbCommand = New OleDbCommand()
        Dim tasksdataset As New DataSet()
        Dim adapter2 As New OleDbDataAdapter("select * from gaform where SupervisorID LIKE'" & Trim(TextBox1.Text) & "%'", reviewdataconnection)
        con.Connection = reviewdataconnection
            reviewdataconnection.Open()
            adapter2.Fill(tasksdataset)
        DataGridView1.DataSource = tasksdataset.Tables(0).DefaultView
        reviewdataconnection.Close()
    End Sub

    Private Sub TextBox13_TextChanged(sender As Object, e As EventArgs) Handles TextBox13.TextChanged
        Dim reviewdataconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
        Dim con As OleDbCommand = New OleDbCommand()
        Dim tasksdataset As New DataSet()
        Dim adapter2 As New OleDbDataAdapter("select * from ga where gaid LIKE'" & Trim(TextBox13.Text) & "%'", reviewdataconnection)
        con.Connection = reviewdataconnection
        reviewdataconnection.Open()
        adapter2.Fill(tasksdataset)
        DataGridView2.DataSource = tasksdataset.Tables(0).DefaultView
        reviewdataconnection.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim Sqlstr As String
            Dim Connectionstring As String = "Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$"
            Sqlstr = "insert into GAssignment values (?, ?, ?, ?, ?)"
            Dim sqlconnection As New OleDbConnection(Connectionstring)
            Dim con As OleDbCommand = New OleDbCommand(Sqlstr, sqlconnection)
            sqlconnection.Open()

            'Begin SQL statements

            con.Parameters.AddWithValue("GAID", Trim(TextBox24.Text))
            con.Parameters.AddWithValue("SupervisorID", Trim(TextBox22.Text))
            con.Parameters.AddWithValue("MemberID", 305)
            con.Parameters.AddWithValue("Semester", Trim(TextBox31.Text))
            con.Parameters.AddWithValue("Hours", Trim(TextBox30.Text))
            con.ExecuteNonQuery()
            MessageBox.Show("Done! To see the changes, please click the Refresh button On the form.")
        Catch ex As Exception
            MsgBox("The insertion failed. Please report the following error to the administrator:" & Environment.NewLine & vbCrLf & ex.Message)
            Exit Sub
        End Try
    End Sub
End Class