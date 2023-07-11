Public Class Pharmacist
    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles BtnDashboard.Click
        UC_P_Dashboard11.Visible = True
        UC_P_Dashboard11.BringToFront()


    End Sub

    Private Sub Pharmacist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UC_P_Dashboard11.Visible = False
        UC_P_Addmedicine11.Visible = False
        UC_P_ViewMedicine11.Visible = False
        UC_P_Updatemedicine11.Visible = False
        UC_P_ValidityMedicine1.Visible = False
        UC_P_Sellmedicine11.Visible = False
        BtnDashboard.PerformClick()

    End Sub

    Private Sub BtnViewmedicine_Click(sender As Object, e As EventArgs) Handles BtnViewmedicine.Click
        UC_P_ViewMedicine11.Visible = True
        BtnViewmedicine.BringToFront()

        UC_P_ViewMedicine11.Show()
        UC_P_ViewMedicine11.BringToFront()




    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles BtnAddmedicine.Click
        UC_P_Dashboard11.Visible = True
        ' BtnDashboard.BringToFront()
        UC_P_Addmedicine11.Show()
        UC_P_Addmedicine11.BringToFront()


    End Sub

    Private Sub BtnUpdateMedicine_Click(sender As Object, e As EventArgs) Handles BtnUpdateMedicine.Click
        UC_P_Updatemedicine11.Visible = True
        BtnUpdateMedicine.BringToFront()
        UC_P_Updatemedicine11.Show()
        UC_P_Updatemedicine11.BringToFront()


    End Sub

    Private Sub BtnValidityCheck_Click(sender As Object, e As EventArgs) Handles BtnValidityCheck.Click
        UC_P_ValidityMedicine1.Visible = True
        BtnValidityCheck.BringToFront()
        UC_P_ValidityMedicine1.Show()
        UC_P_ValidityMedicine1.BringToFront()

    End Sub

    Private Sub BtnSellmedicine_Click(sender As Object, e As EventArgs) Handles BtnSellmedicine.Click
        UC_P_Sellmedicine11.Visible = True
        BtnSellmedicine.BringToFront()
        UC_P_Sellmedicine11.Show()
        UC_P_Sellmedicine11.BringToFront()


    End Sub

    Private Sub UC_P_Sellmedicine11_Load(sender As Object, e As EventArgs) Handles UC_P_Sellmedicine11.Load

    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class