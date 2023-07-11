Imports System.Data.OleDb

Module ModConnection
    Public cur As Form
    Public dt As DataTable
    Public conn As OleDbConnection
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public sqL As String
    Public Sub ConnDB()
        Try

            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data source= " & Application.StartupPath & "\Pharmacy.accdb;")
            'conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\lenovo\source\repos\MedicalSystem\Pharmacy.accdb;")
            conn.Open()
        Catch ex As Exception
            MsgBox("Failed in Connecting to database")
        End Try
    End Sub
    Public Function getDataTable(ByVal SQL As String) As DataTable
        ConnDB()
        Dim cmd As New OleDbCommand(SQL, conn)
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter(cmd)
        da.Fill(dt)
        Return dt
    End Function
End Module
