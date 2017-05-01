Imports System.Data
Imports System.Data.OleDb
Public Class DirectorGAForm
    Private Sub DirectorGAForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reviewdataconnection As New OleDbConnection("Provider=SQLNCLI11;Server=msenterprise.waltoncollege.uark.edu;Database=PROJECTS1720;User Id=PROJECTS1720;Password=RR60ci$")
        Dim con As OleDbCommand = New OleDbCommand()
        Dim tasksdataset As New DataSet()
        Dim gassignmentdataset As New DataSet()
        Dim adapter2 As New OleDbDataAdapter("select * from GAForm", reviewdataconnection)




        con.Connection = reviewdataconnection
        reviewdataconnection.Open()
        adapter2.Fill(tasksdataset)
        DataGridView1.DataSource = tasksdataset.Tables(0).DefaultView
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
End Class