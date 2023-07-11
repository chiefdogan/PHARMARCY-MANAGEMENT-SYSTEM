Module Module1
    Public usertype As String
    Public userId As String
    Public sql As String
    Public dt As New DataTable
    Public da As New OleDb.OleDbDataAdapter
    Public Function myDBmodule() As OleDb.OleDbConnection
        Return New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" &
                                         Application.StartupPath & "\pharmacy.accdb;Persist Security Info=True")
    End Function
    Dim con As OleDb.OleDbConnection = myDBmodule()
    Public Sub myselectstatements(ByVal sql As String, ByVal dtg As DataGridView)
        Try
            con.Open()
            Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter(sql, con)
            Dim dt As New DataTable
            da.Fill(dt)
            dtg.DataSource = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()

    End Sub
    Public Sub mysql(ByVal sql As String)
        Try
            con.Open()
            da = New OleDb.OleDbDataAdapter(sql, con)
            dt = New DataTable
            da.Fill(dt)
        Catch ex As Exception
            MsgBox(ex.Message)
            Return
        End Try
        con.Close()
    End Sub
    Public Sub loginSub(ByVal username As TextBox, ByVal pass As TextBox)
        Try
            con.Open()
            Dim da As OleDb.OleDbDataAdapter = New OleDb.OleDbDataAdapter _
            ("SELECT * FROM users WHERE username='" & username.Text & "' and pass='" & pass.Text & "'", con)
            Dim dt As New DataTable
            da.Fill(dt)

            If dt.Rows.Count > 0 Then
                usertype = dt.Rows(0).Item("password")
                userId = dt.Rows(0).Item("username")
                MsgBox("Welcome " & usertype)
                Form1.BtnLogin.Text = "Logout"





            Else
                MsgBox("Account does not exist! Please contact Administrator", MsgBoxStyle.Exclamation, "Not Exist")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()
    End Sub
End Module
