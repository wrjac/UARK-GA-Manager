Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class SQLconn

    Public SqlCon As New SqlConnection With {.ConnectionString = "Server=msenterprise.waltoncollege.uark.edu;DATABASE=ISYS4283338;User Id=ISYS4283338;Pwd=JE86dk$;"}
    Public SqlCmd As SqlCommand
    Public SqlDA As SqlDataAdapter
    Public SqlDataSet As DataSet

    Public Function HasConnection() As Boolean
        Try
            SqlCon.Open()
            SqlCon.Close()

            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        SqlCon.Close()
    End Function


    Public Sub RunQuery(Query As String)
        Try
            SqlCon.Open()

            SqlCmd = New SqlCommand(Query, SqlCon)

            'load sql
            SqlDA = New SqlDataAdapter(SqlCmd)
            SqlDataSet = New DataSet
            SqlDA.Fill(SqlDataSet)

            SqlCon.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
            If SqlCon.State = ConnectionState.Open Then
                SqlCon.Close()
            End If
        End Try
        SqlCon.Close()
    End Sub
End Class
