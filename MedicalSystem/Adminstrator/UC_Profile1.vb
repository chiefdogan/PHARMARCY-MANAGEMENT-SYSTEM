Imports System.Data.OleDb
Public Class UC_Profile1

    Public dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Public con As New OleDbConnection
    Public dt As DataTable
    Public dbsource As String = "Data source= " & Application.StartupPath & "\Pharmacy.accdb;"
    Public ds As New DataSet
    Public da As New OleDbDataAdapter
    Public sql As String


    Private Sub Guna2TextBox4_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged

    End Sub

    Private Sub UC_Profile1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = dbsource & dbProvider
        'Dim conn As New OleDbConnection
        'conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0; Data source=C:\Users\lenovo\source\repos\MedicalSystem\Pharmacy.accdb")
        'conn.Open()

        'Dim strsql As String
        'strsql = "SELECT userrole,fullname, DOB,email,username,password FROM users WHERE ID =3 "
        'Dim cmd As New OleDbCommand(strsql, conn)
        'Dim myreader As OleDbDataReader
        'myreader = cmd.ExecuteReader
        'myreader.Read()

        'txtUserrole.Text = myreader("userrole")
        'txtFullname.Text = myreader("fullname")
        'txtDate.Text = myreader("DOB")
        'txtEmail.Text = myreader("email")
        'txtMobile.Text = myreader("username")
        'txtPassword.Text = myreader("password")

        'conn.Close()

        'da = New OleDbDataAdapter(sql, dbsource)
        'ds.Tables.Add(dt)
        'da.Fill(dt)
        'cmd.CommandType = CommandType.Text
        '        cmd.Connection = con
        '        con.Open()
        '        Using sdr As SqlDataReader = cmd.ExecuteReader()
        '            sdr.Read()
        '    txtUserrole.Text = da("userrole").ToString()
        '    txtFullname.Text = sdr("fullname").ToString()
        '            txtDate.Text = sdr("DOB").ToString()
        '            txtEmail.Text = sdr("email").ToString()
        '            txtMobile.Text = sdr("username").ToString()
        '            txtPassword.Text = sdr("password").ToString()
        '        End Using
        '        con.Close()
        '    End Using
        'End Using
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtEmail.Clear()
        txtFullname.Clear()
        txtMobile.Clear()
        txtPassword.Clear()
        txtDate.CustomFormat = False
        txtUserrole.ResetText()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click


        If con.State = ConnectionState.Closed Then
            con.Open()

        End If

        Using create As New OleDbCommand("update [users] set [username]='" & txtMobile.Text & "',[userrole] ='" & txtUserrole.Text & "', [fullname]='" & txtFullname.Text & "', [DOB]='" & txtDate.Text & "', [email]='" & txtEmail.Text & "', [password]='" & txtPassword.Text & "'", con)

            If txtFullname.Text = Nothing And txtPassword.Text = Nothing Then

                MessageBox.Show("Please enter empty details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
            create.Parameters.AddWithValue("@userrole", OleDbType.VarChar).Value = txtUserrole.Text.Trim
            create.Parameters.AddWithValue("@fullname", OleDbType.VarChar).Value = txtFullname.Text.Trim
            create.Parameters.AddWithValue("@eDOB", OleDbType.VarChar).Value = txtDate.Text.Trim
            create.Parameters.AddWithValue("@email", OleDbType.VarChar).Value = txtEmail.Text.Trim
            create.Parameters.AddWithValue("@username", OleDbType.VarChar).Value = txtMobile.Text.Trim
            create.Parameters.AddWithValue("@password", OleDbType.VarChar).Value = txtPassword.Text.Trim

            If create.ExecuteNonQuery Then


                MessageBox.Show("Your Account  updated  successfully!! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtEmail.Clear()
                txtFullname.Clear()
                txtMobile.Clear()
                txtPassword.Clear()
                txtDate.CustomFormat = False
                txtUserrole.ResetText()
            End If

        End Using

        con.Close()
    End Sub

    Private Sub btnShow_MouseDown(sender As Object, e As MouseEventArgs) Handles btnShow.MouseDown
        btnShow.Visible = True
        btnShow.Enabled = True

        btnShow.Focus()

        btnHide.Visible = False

    End Sub

    Private Sub btnHide_MouseDown(sender As Object, e As MouseEventArgs) Handles btnHide.MouseDown
        btnHide.Visible = True
        btnHide.Enabled = True

        btnHide.Focus()

        btnShow.Visible = False
        btnShow.Enabled = False
        'txtPassword.InputMask = "Clear"
    End Sub
End Class
