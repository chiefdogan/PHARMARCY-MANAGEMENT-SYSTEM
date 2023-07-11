Imports System.Data.OleDb
Public Class Adminstrator2
    Public conn As New OleDbConnection
    Public cmd As New OleDbCommand
    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        ' Form1 = New Form

        Me.Hide()

        Form1.Show()

        Form1.con.Close()





    End Sub

    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles BtnDashboard.Click
        UC_Dashboard11.Visible = True
        UC_Dashboard11.BringToFront()

    End Sub

    Private Sub Adminstrator2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UC_Dashboard11.Visible = False
        UC_AddUser11.Visible = False
        UC_ViewUserl11.Visible = False
        UC_Profile11.Visible = False
        BtnDashboard.PerformClick()


    End Sub

    Private Sub BtnAddUser_Click(sender As Object, e As EventArgs) Handles BtnAddUser.Click
        UC_AddUser11.Visible = True
        UC_AddUser11.BringToFront()

    End Sub

    Private Sub BtnViewuser_Click(sender As Object, e As EventArgs) Handles BtnViewuser.Click
        UC_ViewUserl11.Visible = True
        UC_ViewUserl11.BringToFront()


    End Sub

    Private Sub BtnProfile_Click(sender As Object, e As EventArgs) Handles BtnProfile.Click
        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0; Data source= " & Application.StartupPath & "\Pharmacy.accdb;")
        conn.Open()

        Dim strsql As String
        strsql = "SELECT userrole,fullname, DOB,email,username,password FROM users WHERE [ID] = " & Me.txtLabelID.Text & ""
        Dim cmd As New OleDbCommand(strsql, conn)
        ' cmd.Parameters.AddWithValue("@username", OleDbType.VarChar).Value = Form1.textUsername.Text.Trim

        Dim Myreader As OleDbDataReader
        Myreader = cmd.ExecuteReader
        myreader.Read()

        UC_Profile11.txtUserrole.Text = myreader("userrole")
        UC_Profile11.txtFullname.Text = myreader("fullname")
        UC_Profile11.txtDate.Text = myreader("DOB")
        UC_Profile11.txtEmail.Text = myreader("email")
        UC_Profile11.txtMobile.Text = myreader("username")
        UC_Profile11.txtPassword.Text = myreader("password")

        UC_Profile11.Visible = True
        UC_Profile11.BringToFront()

        conn.Close()

        'Dim conn As New OleDbConnection
        'conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0; Data source=C:\Users\lenovo\source\repos\MedicalSystem\Pharmacy.accdb")
        'conn.Open()

        'Dim myreader As OleDbDataReader
        'Using cmd As New OleDbCommand("SELECT userrole,fullname, DOB,email,username,password FROM users WHERE [ID] =@ID  ", conn)
        '    cmd.Parameters.AddWithValue("@ID", OleDbType.Integer).Value = Me.txtLabelID.Text.Trim


        '    Dim count = (cmd.ExecuteScalar())



        '    myreader = cmd.ExecuteReader
        '    myreader.Read()
        '    UC_Profile11.txtUserrole.Text = myreader("userrole")
        '    UC_Profile11.txtFullname.Text = myreader("fullname")
        '    UC_Profile11.txtDate.Text = myreader("DOB")
        '    UC_Profile11.txtEmail.Text = myreader("email")
        '    UC_Profile11.txtMobile.Text = myreader("username")
        '    UC_Profile11.txtPassword.Text = myreader("password")



        '    Exit Sub


        '    conn.Close()
        'End Using

    End Sub

    Private Sub UC_Profile11_Load(sender As Object, e As EventArgs) Handles UC_Profile11.Load
        txtLabelID.Visible = False
        Dim conn As New OleDbConnection
        conn.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;  Data source= " & Application.StartupPath & "\Pharmacy.accdb;")
        conn.Open()

        'Dim ID As String
        'ID = "SELECT ID FROM users WHERE [username] = @username " + Form1.textUsername.Text.TrimStart + ""
        'ID.Parameters.AddWithValue("@Reg_no", OleDbType.VarChar).Value = txtReg_no.Text.Trim
        'Dim cmd As New OleDbCommand(ID, conn)

        Dim myreader As OleDbDataReader
        Using cmd As New OleDbCommand("SELECT ID FROM users WHERE [username] = @username  ", conn)
            cmd.Parameters.AddWithValue("@username", OleDbType.VarChar).Value = Form1.textUsername.Text.Trim


            Dim count = Convert.ToInt32(cmd.ExecuteScalar())

            If count > 0 Then

                myreader = cmd.ExecuteReader
                myreader.Read()
                Me.txtLabelID.Text = myreader("ID")



                Exit Sub

            End If
            conn.Close()
        End Using

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class