
Imports System.Data.OleDb

Public Class Form1
    Public con As New OleDbConnection
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs) Handles textUsername.TextChanged

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Application.Exit()

    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        textUsername.Clear()
        textpassword.Clear()
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        If con.State = ConnectionState.Closed Then

            con.Open()

            Dim logincmd As New OleDbCommand("SELECT * FROM users where [username]='" & textUsername.Text & "' and [password]='" & textpassword.Text & "'", con)
            Dim loginrd As OleDbDataReader = logincmd.ExecuteReader




            'Dim role As New DataSet = ds.tables[0].Rows[0][1].Tostring()


            If (loginrd.Read() = True And textpassword.Text = "Admin") Then

                Me.Hide()
                Adminstrator2.Show()
                textUsername.Clear()
                textpassword.Clear()
                MsgBox("Login Successfully!!" & vbNewLine & " You are logged in  our system " & vbTab & MsgBoxStyle.Information)
            ElseIf (loginrd.Read() = True) Then
                Me.Hide()
                Pharmacist.Show()
                textUsername.Clear()
                textpassword.Clear()
            Else
                MsgBox("Your not Not in database")
                If (loginrd.Read() = False) Then

                End If

                con.Close()
            End If
        End If









        'If textUsername.Text = "Admin" And textpassword.Text = "1234" Then
        '    Me.Hide()
        '    Adminstrator2.Show()

        'ElseIf textUsername.Text = "Admin" And textpassword.Text = "1234" Then
        '    MsgBox("Please Enter:Username & Password")

        'Else
        '    MessageBox.Show("Wrong Username or Password", "Incorrent", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        textUsername.Clear()
        textpassword.Clear()
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;  Data source= " & Application.StartupPath & "\Pharmacy.accdb;"

    End Sub
End Class
