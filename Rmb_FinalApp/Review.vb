Imports System.Data
Imports System.Data.OleDb
Public Class Review
    Dim SQL As New SQLconn
    Private Bank_data As DataTable
    Dim account_num As Int32

    Private Sub F_Bankaccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim reviewdataconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
        Dim con As OleDbCommand = New OleDbCommand()
        Dim reviewdataset As New DataSet()
        con.Connection = reviewdataconnection
        Dim customerdirectoryadapter As New OleDbDataAdapter("SELECT a.ApplicantID, ApplicantFirstName, ApplicantLastName, ApplicantEmail, ApplicantProgram, TestName, TestDate, VQScore, VerbalScore, QuantScore, Degree, Major, GPA, SchoolName, convert(varchar, StartDate) AS 'StartDate', convert(varchar, EndDate) AS 'End Date' FROM Applicant a
JOIN GradTest g
On g.ApplicantID = a.ApplicantID
JOIN transcript t
On t.ApplicantID = a.ApplicantID", reviewdataconnection)
        reviewdataconnection.Open()
        customerdirectoryadapter.Fill(reviewdataset)
        ReviewDataGrid.DataSource = reviewdataset.Tables(0).DefaultView
        reviewdataconnection.Close()
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click
        '    Dim Data As New List(Of String())
        '    For Each r As DataGridViewRow In ReviewDataGrid.Rows
        '        If r.Cells(0).Value IsNot Nothing Then
        '            Data.Add(r.Cells(0).Value.ToString().Split(","c))
        '        End If
        '    Next
        Try
            Dim Sqlstr As String
            Dim Connectionstring As String = "Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$"
            Sqlstr = "insert into Review values (?, ?, ?, ?, ?, ?, ?, ?)"
            Dim sqlconnection As New OleDbConnection(Connectionstring)
            Dim con As OleDbCommand = New OleDbCommand(Sqlstr, sqlconnection)
            sqlconnection.Open()

            'Begin SQL statements
            con.Parameters.AddWithValue("SELECT MemberID from Committee where MemberId= '" & Trim(CommitteeIDTextBox.Text) & "'", Trim(CommitteeIDTextBox.Text))
            con.Parameters.AddWithValue("SELECT ApplicantID from Applicant where ApplicantId= '" & Trim(ApplicantIDTextBox.Text) & "'", Trim(ApplicantIDTextBox.Text))
            con.Parameters.AddWithValue("InterviewDate", (InterviewDateTimePicker.Value.ToString))
            con.Parameters.AddWithValue("ApplicantScore", Trim(ApplicantScoreTextBox.Text))
            con.Parameters.AddWithValue("Reccomendation", Trim(RecComboBox.Text))
            con.Parameters.AddWithValue("ReviewComments", Trim(ReviewCommentsTextBox.Text))
            con.Parameters.AddWithValue("InterviewScore", Trim(InterviewScoreTextBox.Text))
            con.Parameters.AddWithValue("InterviewComments", Trim(InterviewCommentsTextBox.Text))

            con.ExecuteNonQuery()
            MessageBox.Show("Done! To see the changes, please click the Refresh button On the form.")
        Catch ex As Exception
            MsgBox("Please fill out all fields and make sure that you are using the Member ID assigned to you. If this fails, however, please report the following error to the administrator:" & Environment.NewLine & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub CommitteeFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CommitteeFormToolStripMenuItem.Click
        Committee_Review.Show()
    End Sub



    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles LastNameTextBox.TextChanged

    End Sub

    Private Sub MISButton_Click(sender As Object, e As EventArgs) Handles MISButton.Click
        Dim reviewdataconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
        Dim con As OleDbCommand = New OleDbCommand()
        Dim reviewdataset As New DataSet()
        con.Connection = reviewdataconnection
        Dim customerdirectoryadapter As New OleDbDataAdapter("SELECT a.ApplicantID, ApplicantFirstName, ApplicantLastName, ApplicantEmail, ApplicantProgram, TestName, TestDate, VQScore, VerbalScore, QuantScore, Degree, Major, GPA, SchoolName, convert(varchar, StartDate) AS 'StartDate', convert(varchar, EndDate) AS 'EndDate' FROM Applicant a
JOIN GradTest g
On g.ApplicantID = a.ApplicantID
JOIN transcript t
On t.ApplicantID = a.ApplicantID
WHERE ApplicantProgram = 'MIS' ", reviewdataconnection)


        reviewdataconnection.Open()
        customerdirectoryadapter.Fill(reviewdataset)
        ReviewDataGrid.DataSource = reviewdataset.Tables(0).DefaultView
        reviewdataconnection.Close()

    End Sub

    Private Sub PMISButton_Click(sender As Object, e As EventArgs) Handles PMISButton.Click
        Dim reviewdataconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
        Dim con As OleDbCommand = New OleDbCommand()
        Dim reviewdataset As New DataSet()
        con.Connection = reviewdataconnection
        Dim customerdirectoryadapter As New OleDbDataAdapter("SELECT a.ApplicantID, ApplicantFirstName, ApplicantLastName, ApplicantEmail, ApplicantProgram, TestName, TestDate, VQScore, VerbalScore, QuantScore, Degree, Major, GPA, SchoolName, convert(varchar, StartDate) AS 'StartDate', convert(varchar, EndDate) AS 'EndDate' FROM Applicant a
JOIN GradTest g
On g.ApplicantID = a.ApplicantID
JOIN transcript t
On t.ApplicantID = a.ApplicantID
WHERE ApplicantProgram = 'PMIS' ", reviewdataconnection)
        reviewdataconnection.Open()
        customerdirectoryadapter.Fill(reviewdataset)
        ReviewDataGrid.DataSource = reviewdataset.Tables(0).DefaultView
        reviewdataconnection.Close()



    End Sub

    Private Sub ReviewDataGrid_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles ReviewDataGrid.CellEnter
        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            ApplicantIDTextBox.Text = ReviewDataGrid.Rows(ReviewDataGrid.CurrentCell.RowIndex).Cells(0).Value.ToString()
            FirstNameTextBox.Text = ReviewDataGrid.Rows(ReviewDataGrid.CurrentCell.RowIndex).Cells(1).Value.ToString()
            LastNameTextBox.Text = ReviewDataGrid.Rows(ReviewDataGrid.CurrentCell.RowIndex).Cells(2).Value.ToString()
            EMailTextBox.Text = ReviewDataGrid.Rows(ReviewDataGrid.CurrentCell.RowIndex).Cells(3).Value.ToString()
            ProgramTextBox.Text = ReviewDataGrid.Rows(ReviewDataGrid.CurrentCell.RowIndex).Cells(4).Value.ToString()
            TestNameTextBox.Text = ReviewDataGrid.Rows(ReviewDataGrid.CurrentCell.RowIndex).Cells(5).Value.ToString()
            TestDateTextBox.Text = ReviewDataGrid.Rows(ReviewDataGrid.CurrentCell.RowIndex).Cells(6).Value.ToString()
            VQScoreTextBox.Text = ReviewDataGrid.Rows(ReviewDataGrid.CurrentCell.RowIndex).Cells(7).Value.ToString()
            VerbalScoreTextBox.Text = ReviewDataGrid.Rows(ReviewDataGrid.CurrentCell.RowIndex).Cells(8).Value.ToString()
            QuantScoreTextBox.Text = ReviewDataGrid.Rows(ReviewDataGrid.CurrentCell.RowIndex).Cells(9).Value.ToString()
            DegreeTextBox.Text = ReviewDataGrid.Rows(ReviewDataGrid.CurrentCell.RowIndex).Cells(10).Value.ToString()
            MajorTextBox.Text = ReviewDataGrid.Rows(ReviewDataGrid.CurrentCell.RowIndex).Cells(11).Value.ToString()
            GPATextBox.Text = ReviewDataGrid.Rows(ReviewDataGrid.CurrentCell.RowIndex).Cells(12).Value.ToString()
            SchoolNameTextBox.Text = ReviewDataGrid.Rows(ReviewDataGrid.CurrentCell.RowIndex).Cells(13).Value.ToString()
            StartTextBox.Text = ReviewDataGrid.Rows(ReviewDataGrid.CurrentCell.RowIndex).Cells(14).Value.ToString()

            EndDateTextBox.Text = ReviewDataGrid.Rows(ReviewDataGrid.CurrentCell.RowIndex).Cells(15).Value.ToString()
        End If

    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click

        Dim reviewdataconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
        Dim con As OleDbCommand = New OleDbCommand()
        Dim reviewdataset As New DataSet()
        con.Connection = reviewdataconnection
        Dim customerdirectoryadapter As New OleDbDataAdapter("SELECT a.ApplicantID, ApplicantFirstName, ApplicantLastName, ApplicantEmail, ApplicantProgram, TestName, TestDate, VQScore, VerbalScore, QuantScore, Degree, Major, GPA, SchoolName, convert(varchar, StartDate) AS 'StartDate', convert(varchar, EndDate) AS 'End Date' FROM Applicant a
JOIN GradTest g
On g.ApplicantID = a.ApplicantID
JOIN transcript t
On t.ApplicantID = a.ApplicantID", reviewdataconnection)
        reviewdataconnection.Open()
        customerdirectoryadapter.Fill(reviewdataset)
        ReviewDataGrid.DataSource = reviewdataset.Tables(0).DefaultView
        reviewdataconnection.Close()
    End Sub
End Class