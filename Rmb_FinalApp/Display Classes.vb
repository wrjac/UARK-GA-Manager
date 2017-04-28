Imports System.Data
Imports System.Data.OleDb
Public Class Display_Classes
    Private Sub Display_Classes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reviewdataconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
        Dim con As OleDbCommand = New OleDbCommand()
        Dim reviewdataset As New DataSet()
        con.Connection = reviewdataconnection
        Dim customerdirectoryadapter As New OleDbDataAdapter("select * from class", reviewdataconnection)


        reviewdataconnection.Open()
        customerdirectoryadapter.Fill(reviewdataset)
        DataGridView1.DataSource = reviewdataset.Tables(0).DefaultView
        reviewdataconnection.Close()
    End Sub

    Private Sub InsertButton_Click(sender As Object, e As EventArgs) Handles InsertButton.Click



        Try
            Dim Sqlstr As String
            Dim Connectionstring As String = "Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$"
            Sqlstr = "insert into class values (?, ?, ?, ?)"
            Dim sqlconnection As New OleDbConnection(Connectionstring)
            Dim con As OleDbCommand = New OleDbCommand(Sqlstr, sqlconnection)
            sqlconnection.Open()

            If ClassNameTextBox.Text & ClassIDTextBox.Text & ClassTermTextBox.Text & ClassHoursTextBox.Text = "" Then
                MessageBox.Show("All fields are required.")
                Return


            End If

            'Begin SQL statements
            con.Parameters.AddWithValue("ClassID", Trim(ClassIDTextBox.Text))
            Try
                con.Parameters.AddWithValue("ClassName", Trim(ClassNameTextBox.Text))
            Catch ex As Exception
                MsgBox("The class name can only be 10 characters long.")
            End Try
            con.Parameters.AddWithValue("ClassTerm", Trim(ClassTermTextBox.Text))
            con.Parameters.AddWithValue("ClassHours", Trim(ClassHoursTextBox.Text))

            con.ExecuteNonQuery()
            MessageBox.Show("Done! To see the changes, please click the Refresh button On the form.")
        Catch ex As Exception
            MsgBox("Please fill out all fields And make sure that you are Using the Member ID assigned To you. If this fails, however, please report the following Error To the administrator:" & Environment.NewLine & vbCrLf & ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim customerdirectoryconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
        Dim con As OleDbCommand = New OleDbCommand()
        Dim customerinformationdataset As New DataSet()
        con.Connection = customerdirectoryconnection
        Dim customerdirectoryadapter As New OleDbDataAdapter("select * from class where classid like '%" & TextBox1.Text & "%'", customerdirectoryconnection)
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
        Dim customerdirectoryadapter As New OleDbDataAdapter("select * from class", reviewdataconnection)


        reviewdataconnection.Open()
        customerdirectoryadapter.Fill(reviewdataset)
        DataGridView1.DataSource = reviewdataset.Tables(0).DefaultView
        reviewdataconnection.Close()
        TextBox1.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Roster.Show()
    End Sub
End Class