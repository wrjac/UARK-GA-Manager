Imports System.Data
Imports System.Data.OleDb
Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reviewdataconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
        Dim con As OleDbCommand = New OleDbCommand()
        Dim reviewdataset As New DataSet()
        con.Connection = reviewdataconnection
        Dim customerdirectoryadapter As New OleDbDataAdapter("select * from degreeaudit", reviewdataconnection)
        EnrollIDTextBox.Hide()
        MemberIDTextbox.Hide()

        reviewdataconnection.Open()
        customerdirectoryadapter.Fill(reviewdataset)
        DataGridView1.DataSource = reviewdataset.Tables(0).DefaultView
        reviewdataconnection.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim customerdirectoryconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
        Dim con As OleDbCommand = New OleDbCommand()
        Dim customerinformationdataset As New DataSet()
        con.Connection = customerdirectoryconnection
        Dim customerdirectoryadapter As New OleDbDataAdapter("select  * from degreeaudit Where enrollid like '%" & TextBox1.Text & "%'", customerdirectoryconnection)
        customerdirectoryconnection.Open()
        customerdirectoryadapter.Fill(customerinformationdataset)
        DataGridView1.DataSource = customerinformationdataset.Tables(0).DefaultView
        customerdirectoryconnection.Close()
    End Sub

    Private Sub RefreshButton_Click(sender As Object, e As EventArgs) Handles RefreshButton.Click
        Dim reviewdataconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
        Dim con As OleDbCommand = New OleDbCommand()
        Dim reviewdataset As New DataSet()
        con.Connection = reviewdataconnection
        Dim customerdirectoryadapter As New OleDbDataAdapter("select * from degreeaudit", reviewdataconnection)


        reviewdataconnection.Open()
        customerdirectoryadapter.Fill(reviewdataset)
        DataGridView1.DataSource = reviewdataset.Tables(0).DefaultView
        reviewdataconnection.Close()
    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        Randomize()
        'This is a terrible workaround, but we never set our PKs to auto_increment in our database.

        If e.ColumnIndex >= 0 AndAlso e.RowIndex >= 0 Then
            EnrollIDTextBox.Text = CInt(Int((10000 * Rnd()) + 1)).ToString()
            MemberIDTextbox.Text = CInt(Int((10000 * Rnd()) + 1)).ToString()
            AdmittedGraduationStatusTextBox.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(2).Value.ToString()
            GPATextBox.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(3).Value.ToString()
            AdmittedJobTextBox.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(4).Value.ToString()
            AdmittedSalaryTextBox.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(5).Value.ToString()
            AlumniStatusTextBox.Text = DataGridView1.Rows(DataGridView1.CurrentCell.RowIndex).Cells(6).Value.ToString()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Sqlstr As String
        Dim Connectionstring As String = "Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$"
        Sqlstr = "insert into degreeAudit values (?, ?, ?, ?, ?, ?, ?, ?)"
        Dim sqlconnection As New OleDbConnection(Connectionstring)
        Dim con As OleDbCommand = New OleDbCommand(Sqlstr, sqlconnection)
        sqlconnection.Open()
        Try
            'Begin SQL statements
            con.Parameters.AddWithValue("EnrollID", (EnrollIDTextBox.Text))
            con.Parameters.AddWithValue("MemberID", Trim(MemberIDTextbox.Text))
            con.Parameters.AddWithValue("AdmittedGraduationStatus", Trim(AdmittedGraduationStatusTextBox.Text))
            con.Parameters.AddWithValue("GPA", Trim(GPATextBox.Text))
            con.Parameters.AddWithValue("AdmittedJob", Trim(AdmittedJobTextBox.Text))
            con.Parameters.AddWithValue("AdmittedSalary", Trim(AdmittedSalaryTextBox.Text))
            con.Parameters.AddWithValue("AlumniStatus", Trim(AlumniStatusTextBox.Text))

            con.ExecuteNonQuery()
            MessageBox.Show("Done! To see the changes, please click the Refresh button On the form.")
        Catch ex As Exception
            MsgBox("Please fill out all fields and make sure that you are using the Member ID assigned to you. If this fails, however, please report the following error to the administrator:" & Environment.NewLine & vbCrLf & ex.Message)
        End Try
    End Sub
End Class