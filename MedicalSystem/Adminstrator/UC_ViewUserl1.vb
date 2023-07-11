Imports System.Data.OleDb
Imports MedicalSystem.UC_Profile1
Public Class UC_ViewUserl1
    Public dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Public con As New OleDbConnection
    Public dt As DataTable
    Public dbsource As String = "Data source= " & Application.StartupPath & "\Pharmacy.accdb;"
    Public ds As New DataSet
    Public da As New OleDbDataAdapter
    Public dr As OleDbDataReader
    Public sql As String
    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles userDataGridView.CellContentClick

    End Sub

    Private Sub UC_ViewUserl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = dbProvider & dbsource
        Dim adp As New OleDbDataAdapter("select * from users", con)
        Dim ds As DataSet = New DataSet()
        adp.Fill(ds)
        userDataGridView.DataSource = ds.Tables(0)
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If MessageBox.Show("Do you really want to Delete this Record?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Dim i As Integer = userDataGridView.SelectedRows(0).Index
            Me.userDataGridView.Rows.RemoveAt(i)
            Me.userDataGridView.Rows.RemoveAt(i)

            Me.TableAdapterManager.UpdateAll(Me.PharmacyDataSet)

            MessageBox.Show("Record Deleted")

        End If
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSearcUser.TextChanged
        con.ConnectionString = dbProvider & dbsource
        Dim adp As New OleDbDataAdapter("select * from users where username like'" + txtSearcUser.Text + "%'", con)
        Dim ds As DataSet = New DataSet()
        'Dim dr As OleDbDataReader
        adp.Fill(ds)
        userDataGridView.DataSource = ds.Tables(0)

    End Sub
End Class
