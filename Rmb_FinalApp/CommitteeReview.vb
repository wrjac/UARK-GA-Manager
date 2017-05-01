Imports System.Data
Imports System.Data.OleDb
Public Class Committee_Review
    Dim bindingsource As BindingSource
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reviewdataconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
        Dim con As OleDbCommand = New OleDbCommand()
        Dim reviewdataset As New DataSet()
        con.Connection = reviewdataconnection
        Dim customerdirectoryadapter As New OleDbDataAdapter("select Applicantrank,  concat(ApplicantFirstName, ' ', ApplicantLastName) As ApplicantName, ApplicantProgram, interviewdate, applicantscore, recommendation, reviewcomments, interviewscore, interviewcomments from applicant a
	INNER JOIN review r
ON r.ApplicantID = a.applicantid
ORDER BY applicantrank asc;", reviewdataconnection)
        reviewdataconnection.Open()
        customerdirectoryadapter.Fill(reviewdataset)
        CommitteeDataGrid.DataSource = reviewdataset.Tables(0).DefaultView
        reviewdataconnection.Close()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 And ComboBox3.Text <> "PMIS" And ComboBox3.Text <> "MIS" Then
            Dim customerdirectoryconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
            Dim customerinformationdataset As New DataSet()
            Dim customerdirectoryadapter As New OleDbDataAdapter("select Applicantrank,  concat(ApplicantFirstName, ' ', ApplicantLastName) As ApplicantName, ApplicantProgram, interviewdate, applicantscore, recommendation, reviewcomments, interviewscore, interviewcomments from applicant a
	INNER JOIN review r
ON r.ApplicantID = a.applicantid
Where MemberID = 301
ORDER BY applicantrank asc;", customerdirectoryconnection)

            customerdirectoryconnection.Open()
            customerdirectoryadapter.Fill(customerinformationdataset)
            bindingsource = New BindingSource()
            bindingsource.DataSource = customerinformationdataset.Tables(0).DefaultView
            CommitteeDataGrid.DataSource = bindingsource
            bindingsource.ResetBindings(False)
            Dim CustomerIDCommand As New OleDbCommand("select Applicantrank,  concat(ApplicantFirstName, ' ', ApplicantLastName) As ApplicantName, ApplicantProgram, interviewdate, applicantscore, recommendation, reviewcomments, interviewscore, interviewcomments from applicant a
	INNER JOIN review r
ON r.ApplicantID = a.applicantid
Where MemberID = 301
ORDER BY applicantrank asc;", customerdirectoryconnection)
        ElseIf ComboBox1.SelectedIndex = 1 And ComboBox3.Text <> "PMIS" And ComboBox3.Text <> "MIS" Then
            Dim customerdirectoryconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
            Dim customerinformationdataset As New DataSet()
            Dim customerdirectoryadapter As New OleDbDataAdapter("select Applicantrank,  concat(ApplicantFirstName, ' ', ApplicantLastName) As ApplicantName, ApplicantProgram, interviewdate, applicantscore, recommendation, reviewcomments, interviewscore, interviewcomments from applicant a
	INNER JOIN review r
ON r.ApplicantID = a.applicantid
Where MemberID = 302
ORDER BY applicantrank asc;", customerdirectoryconnection)

            customerdirectoryconnection.Open()
            customerdirectoryadapter.Fill(customerinformationdataset)
            bindingsource = New BindingSource()
            bindingsource.DataSource = customerinformationdataset.Tables(0).DefaultView
            CommitteeDataGrid.DataSource = bindingsource
            bindingsource.ResetBindings(False)
            Dim CustomerIDCommand As New OleDbCommand("select Applicantrank,  concat(ApplicantFirstName, ' ', ApplicantLastName) As ApplicantName, ApplicantProgram, interviewdate, applicantscore, recommendation, reviewcomments, interviewscore, interviewcomments from applicant a
	INNER JOIN review r
ON r.ApplicantID = a.applicantid
Where MemberID = 302
ORDER BY applicantrank asc;", customerdirectoryconnection)
        ElseIf ComboBox1.SelectedIndex = 2 And ComboBox3.Text <> "PMIS" And ComboBox3.Text <> "MIS" Then
            Dim customerdirectoryconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
            Dim customerinformationdataset As New DataSet()
            Dim customerdirectoryadapter As New OleDbDataAdapter("select Applicantrank,  concat(ApplicantFirstName, ' ', ApplicantLastName) As ApplicantName, ApplicantProgram, interviewdate, applicantscore, recommendation, reviewcomments, interviewscore, interviewcomments from applicant a
	INNER JOIN review r
ON r.ApplicantID = a.applicantid
Where MemberID = 303
ORDER BY applicantrank asc;", customerdirectoryconnection)

            customerdirectoryconnection.Open()
            customerdirectoryadapter.Fill(customerinformationdataset)
            bindingsource = New BindingSource()
            bindingsource.DataSource = customerinformationdataset.Tables(0).DefaultView
            CommitteeDataGrid.DataSource = bindingsource
            bindingsource.ResetBindings(False)
            Dim CustomerIDCommand As New OleDbCommand("select Applicantrank,  concat(ApplicantFirstName, ' ', ApplicantLastName) As ApplicantName, ApplicantProgram, interviewdate, applicantscore, recommendation, reviewcomments, interviewscore, interviewcomments from applicant a
	INNER JOIN review r
ON r.ApplicantID = a.applicantid
Where MemberID = 303
ORDER BY applicantrank asc;", customerdirectoryconnection)

        ElseIf ComboBox1.SelectedIndex = 3 And ComboBox3.Text <> "PMIS" And ComboBox3.Text <> "MIS" Then
            Dim customerdirectoryconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
            Dim customerinformationdataset As New DataSet()
            Dim customerdirectoryadapter As New OleDbDataAdapter("select Applicantrank,  concat(ApplicantFirstName, ' ', ApplicantLastName) As ApplicantName, ApplicantProgram, interviewdate, applicantscore, recommendation, reviewcomments, interviewscore, interviewcomments from applicant a
	INNER JOIN review r
ON r.ApplicantID = a.applicantid
Where MemberID = 304
ORDER BY applicantrank asc;", customerdirectoryconnection)

            customerdirectoryconnection.Open()
            customerdirectoryadapter.Fill(customerinformationdataset)
            bindingsource = New BindingSource()
            bindingsource.DataSource = customerinformationdataset.Tables(0).DefaultView
            CommitteeDataGrid.DataSource = bindingsource
            bindingsource.ResetBindings(False)
            Dim CustomerIDCommand As New OleDbCommand("select Applicantrank,  concat(ApplicantFirstName, ' ', ApplicantLastName) As ApplicantName, ApplicantProgram, interviewdate, applicantscore, recommendation, reviewcomments, interviewscore, interviewcomments from applicant a
	INNER JOIN review r
ON r.ApplicantID = a.applicantid
Where MemberID = 304
ORDER BY applicantrank asc;", customerdirectoryconnection)

        ElseIf ComboBox1.SelectedIndex = 4 And ComboBox3.Text <> "PMIS" And ComboBox3.Text <> "MIS" Then
            Dim customerdirectoryconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
            Dim customerinformationdataset As New DataSet()
            Dim customerdirectoryadapter As New OleDbDataAdapter("select Applicantrank,  concat(ApplicantFirstName, ' ', ApplicantLastName) As ApplicantName, ApplicantProgram, interviewdate, applicantscore, recommendation, reviewcomments, interviewscore, interviewcomments from applicant a
	INNER JOIN review r
ON r.ApplicantID = a.applicantid
Where MemberID = 305
ORDER BY applicantrank asc;", customerdirectoryconnection)

            customerdirectoryconnection.Open()
            customerdirectoryadapter.Fill(customerinformationdataset)
            bindingsource = New BindingSource()
            bindingsource.DataSource = customerinformationdataset.Tables(0).DefaultView
            CommitteeDataGrid.DataSource = bindingsource
            bindingsource.ResetBindings(False)
            Dim CustomerIDCommand As New OleDbCommand("select Applicantrank,  concat(ApplicantFirstName, ' ', ApplicantLastName) As ApplicantName, ApplicantProgram, interviewdate, applicantscore, recommendation, reviewcomments, interviewscore, interviewcomments from applicant a
	INNER JOIN review r
ON r.ApplicantID = a.applicantid
Where MemberID = 305
ORDER BY applicantrank asc;", customerdirectoryconnection)
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        If ComboBox3.SelectedIndex = 0 Then
            Dim customerdirectoryconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
            Dim customerinformationdataset As New DataSet()
            Dim customerdirectoryadapter As New OleDbDataAdapter("select Applicantrank,  concat(ApplicantFirstName, ' ', ApplicantLastName) As ApplicantName, ApplicantProgram, interviewdate, applicantscore, recommendation, reviewcomments, interviewscore, interviewcomments from applicant a
	INNER JOIN review r
ON r.ApplicantID = a.applicantid
Where applicantprogram = 'PMIS' and memberID = '" & Trim(ComboBox1.Text) & "'
ORDER BY applicantrank asc;", customerdirectoryconnection)

            customerdirectoryconnection.Open()
            customerdirectoryadapter.Fill(customerinformationdataset)
            bindingsource = New BindingSource()
            bindingsource.DataSource = customerinformationdataset.Tables(0).DefaultView
            CommitteeDataGrid.DataSource = bindingsource
            bindingsource.ResetBindings(False)
            Dim CustomerIDCommand As New OleDbCommand("select Applicantrank,  concat(ApplicantFirstName, ' ', ApplicantLastName) As ApplicantName, ApplicantProgram, interviewdate, applicantscore, recommendation, reviewcomments, interviewscore, interviewcomments from applicant a
	INNER JOIN review r
ON r.ApplicantID = a.applicantid
Where applicantprogram = 'PMIS' and memberID = '" & Trim(ComboBox1.Text) & "'
ORDER BY applicantrank asc;", customerdirectoryconnection)

        Else


        End If

        If ComboBox3.SelectedIndex = 1 Then
            Dim customerdirectoryconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
            Dim customerinformationdataset As New DataSet()
            Dim customerdirectoryadapter As New OleDbDataAdapter("select Applicantrank,  concat(ApplicantFirstName, ' ', ApplicantLastName) As ApplicantName, ApplicantProgram, interviewdate, applicantscore, recommendation, reviewcomments, interviewscore, interviewcomments from applicant a
	INNER JOIN review r
ON r.ApplicantID = a.applicantid
Where applicantprogram = 'MIS' and memberID = '" & Trim(ComboBox1.Text) & "'
ORDER BY applicantrank asc;", customerdirectoryconnection)

            customerdirectoryconnection.Open()
            customerdirectoryadapter.Fill(customerinformationdataset)
            bindingsource = New BindingSource()
            bindingsource.DataSource = customerinformationdataset.Tables(0).DefaultView
            CommitteeDataGrid.DataSource = bindingsource
            bindingsource.ResetBindings(False)
            Dim CustomerIDCommand As New OleDbCommand("select Applicantrank,  concat(ApplicantFirstName, ' ', ApplicantLastName) As ApplicantName, ApplicantProgram, interviewdate, applicantscore, recommendation, reviewcomments, interviewscore, interviewcomments from applicant a
	INNER JOIN review r
ON r.ApplicantID = a.applicantid
Where applicantprogram = 'MIS' and memberID = '" & Trim(ComboBox1.Text) & "'
ORDER BY applicantrank asc;", customerdirectoryconnection)

        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

    End Sub

    Private Sub CommitteeDataGrid_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles CommitteeDataGrid.CellEnter

        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            'Populate the textbox(s) to the specified column's value
            ComboBox2.Text = CommitteeDataGrid.Rows(e.RowIndex).Cells(1).Value.ToString()
            Reviewtextbox.Text = CommitteeDataGrid.Rows(e.RowIndex).Cells(6).Value.ToString()
            Interviewtextbox.Text = CommitteeDataGrid.Rows(e.RowIndex).Cells(8).Value.ToString()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Review.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Advisor.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Success! Student is added to admitted student")
    End Sub

    Private Sub DirectorGAFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DirectorGAFormToolStripMenuItem.Click
        DirectorGAForm.Show()
    End Sub
End Class