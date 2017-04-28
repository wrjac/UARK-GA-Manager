Imports System.Data
Imports System.Data.OleDb
Public Class Roster
    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter

    End Sub

    Private Sub Roster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reviewdataconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
        Dim con As OleDbCommand = New OleDbCommand()
        Dim reviewdataset As New DataSet()
        con.Connection = reviewdataconnection
        Dim customerdirectoryadapter As New OleDbDataAdapter("select a.AdmittedID, c.ClassID, ClassName, ClassTerm, AdmittedStudentStatus from class c
inner join enroll e
on c.classid = e .classid
inner join admitted a
on e.admittedid = a.admittedid", reviewdataconnection)


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
        Dim customerdirectoryadapter As New OleDbDataAdapter("select a.AdmittedID, c.ClassID, ClassName, ClassTerm, AdmittedStudentStatus from class c
inner join enroll e
on c.classid = e .classid
inner join admitted a
on e.admittedid = a.admittedid
Where c.classID like '%" & TextBox1.Text & "%'", customerdirectoryconnection)
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
        Dim customerdirectoryadapter As New OleDbDataAdapter("select a.AdmittedID, c.ClassID, ClassName, ClassTerm, AdmittedStudentStatus from class c
inner join enroll e
on c.classid = e .classid
inner join admitted a
on e.admittedid = a.admittedid", reviewdataconnection)


        reviewdataconnection.Open()
        customerdirectoryadapter.Fill(reviewdataset)
        DataGridView1.DataSource = reviewdataset.Tables(0).DefaultView
        reviewdataconnection.Close()

        TextBox1.Clear()
    End Sub
End Class