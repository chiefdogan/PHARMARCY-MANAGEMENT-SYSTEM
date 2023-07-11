Imports System.Data.OleDb
Public Class UC_AddUser1
    Public dbProvider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Public con As New OleDbConnection
    Public dbsource As String = "Data source= " & Application.StartupPath & "\Pharmacy.accdb;"
    Private Sub UC_AddUser1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = dbsource & dbProvider

    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        If txtFullname.Text = Nothing Or txtEmail.Text = Nothing Or txtMobile.Text = Nothing Or txtPassword.Text = Nothing Or txtUsername.Text = Nothing Or txtDate.Text = Nothing Or txtUserrole.Text = Nothing Then
            MessageBox.Show("Please Enter Empty Detalils to continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End If

        If con.State = ConnectionState.Closed Then
            con.Open()

        End If

        Using cmd As New OleDbCommand("SELECT COUNT(*) FROM users WHERE  [userrole] = @userrole AND [fullname] = @fullname AND [DOB] = @DOB  AND [email] = @email AND [username] = @username AND [password] = @password  ", con)
            cmd.Parameters.AddWithValue("@userrole", OleDbType.VarChar).Value = txtUserrole.Text.Trim
            cmd.Parameters.AddWithValue("@fullname", OleDbType.VarChar).Value = txtFullname.Text.Trim
            cmd.Parameters.AddWithValue("@DOB", OleDbType.VarChar).Value = txtDate.Text.Trim
            cmd.Parameters.AddWithValue("@email", OleDbType.VarChar).Value = txtEmail.Text.Trim
            cmd.Parameters.AddWithValue("@username", OleDbType.VarChar).Value = txtUsername.Text.Trim
            cmd.Parameters.AddWithValue("@password", OleDbType.VarChar).Value = txtPassword.Text.Trim

            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If count > 0 Then

                MessageBox.Show("Opps, username has already taken", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtEmail.Clear()
                txtFullname.Clear()
                txtMobile.Clear()
                txtPassword.Clear()
                txtUsername.Clear()
                txtUserrole.SelectedValue = False

                Exit Sub

            End If

        End Using

        Using create As New OleDbCommand("Insert into [users]([userrole],[fullname],[DOB],[email],[username],[password]) Values ('" & txtUserrole.Text & "','" & txtFullname.Text & "','" & txtDate.Text & "','" & txtEmail.Text & "','" & txtUsername.Text & "','" & txtPassword.Text & "')", con)

            create.Parameters.AddWithValue("@userrole", OleDbType.VarChar).Value = txtUserrole.Text.Trim
            create.Parameters.AddWithValue("@fullname", OleDbType.VarChar).Value = txtFullname.Text.Trim
            create.Parameters.AddWithValue("@eDOB", OleDbType.VarChar).Value = txtDate.Text.Trim
            create.Parameters.AddWithValue("@email", OleDbType.VarChar).Value = txtEmail.Text.Trim
            create.Parameters.AddWithValue("@username", OleDbType.VarChar).Value = txtUsername.Text.Trim
            create.Parameters.AddWithValue("@password", OleDbType.VarChar).Value = txtPassword.Text.Trim

            If create.ExecuteNonQuery Then

                MessageBox.Show("Account created successfully!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtEmail.Clear()
                txtFullname.Clear()
                txtUsername.Clear()
                txtMobile.Clear()
                txtPassword.Clear()
                txtDate.ResetText()
                txtUserrole.SelectedIndex = -1

            End If
        End Using
        con.Close()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtEmail.Clear()
        txtFullname.Clear()
        txtUsername.Clear()
        txtMobile.Clear()
        txtPassword.Clear()
        txtDate.ResetText()
        txtUserrole.SelectedIndex = -1

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        'Dim adp As OleDbDataAdapter = New OleDbDataAdapter("select * from users where username='" + txtUsername.Text, con)
        'Dim ds As DataSet = New DataSet()
        'adp.Fill(ds)

        'Dim tables As DataTableCollection = (ds.Tables)
        'If tables(0).Rows.Count = 0 Then
        '    PictureBox1.ImageLocation = "C:\Users\lenovo\Desktop\trial\yes.jpg"
        'Else
        '    PictureBox1.ImageLocation = "C:\Users\lenovo\Desktop\trial\no.jpg"

        'End If
    End Sub
End Class
