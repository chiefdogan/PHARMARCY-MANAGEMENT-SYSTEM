<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pharmacist
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pharmacist))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnViewmedicine = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Button6 = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnSellmedicine = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnValidityCheck = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnUpdateMedicine = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnAddmedicine = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnDashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UC_P_Sellmedicine11 = New MedicalSystem.UC_P_Sellmedicine1()
        Me.UC_P_ValidityMedicine1 = New MedicalSystem.UC_P_ValidityMedicine()
        Me.UC_P_Updatemedicine11 = New MedicalSystem.UC_P_Updatemedicine1()
        Me.UC_P_Addmedicine11 = New MedicalSystem.UC_P_Addmedicine1()
        Me.UC_P_Dashboard11 = New MedicalSystem.UC_P_Dashboard1()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse4 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse5 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse6 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Turquoise
        Me.Panel1.Controls.Add(Me.BtnViewmedicine)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Guna2Button6)
        Me.Panel1.Controls.Add(Me.BtnSellmedicine)
        Me.Panel1.Controls.Add(Me.BtnValidityCheck)
        Me.Panel1.Controls.Add(Me.BtnUpdateMedicine)
        Me.Panel1.Controls.Add(Me.BtnAddmedicine)
        Me.Panel1.Controls.Add(Me.BtnDashboard)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(330, 788)
        Me.Panel1.TabIndex = 0
        '
        'BtnViewmedicine
        '
        Me.BtnViewmedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnViewmedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnViewmedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnViewmedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnViewmedicine.FillColor = System.Drawing.Color.Turquoise
        Me.BtnViewmedicine.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnViewmedicine.ForeColor = System.Drawing.Color.White
        Me.BtnViewmedicine.Image = CType(resources.GetObject("BtnViewmedicine.Image"), System.Drawing.Image)
        Me.BtnViewmedicine.ImageSize = New System.Drawing.Size(45, 45)
        Me.BtnViewmedicine.Location = New System.Drawing.Point(61, 357)
        Me.BtnViewmedicine.Name = "BtnViewmedicine"
        Me.BtnViewmedicine.Size = New System.Drawing.Size(180, 45)
        Me.BtnViewmedicine.TabIndex = 8
        Me.BtnViewmedicine.Text = "View Medicine"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(72, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 37)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Pharmacist"
        '
        'Guna2Button6
        '
        Me.Guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button6.FillColor = System.Drawing.Color.Turquoise
        Me.Guna2Button6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button6.ForeColor = System.Drawing.Color.White
        Me.Guna2Button6.Image = CType(resources.GetObject("Guna2Button6.Image"), System.Drawing.Image)
        Me.Guna2Button6.ImageSize = New System.Drawing.Size(45, 45)
        Me.Guna2Button6.Location = New System.Drawing.Point(61, 721)
        Me.Guna2Button6.Name = "Guna2Button6"
        Me.Guna2Button6.Size = New System.Drawing.Size(180, 45)
        Me.Guna2Button6.TabIndex = 6
        Me.Guna2Button6.Text = "Log Out"
        '
        'BtnSellmedicine
        '
        Me.BtnSellmedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnSellmedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnSellmedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnSellmedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnSellmedicine.FillColor = System.Drawing.Color.Turquoise
        Me.BtnSellmedicine.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSellmedicine.ForeColor = System.Drawing.Color.White
        Me.BtnSellmedicine.Image = CType(resources.GetObject("BtnSellmedicine.Image"), System.Drawing.Image)
        Me.BtnSellmedicine.ImageSize = New System.Drawing.Size(45, 45)
        Me.BtnSellmedicine.Location = New System.Drawing.Point(61, 649)
        Me.BtnSellmedicine.Name = "BtnSellmedicine"
        Me.BtnSellmedicine.Size = New System.Drawing.Size(180, 45)
        Me.BtnSellmedicine.TabIndex = 5
        Me.BtnSellmedicine.Text = "Sell Medicine"
        '
        'BtnValidityCheck
        '
        Me.BtnValidityCheck.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnValidityCheck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnValidityCheck.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnValidityCheck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnValidityCheck.FillColor = System.Drawing.Color.Turquoise
        Me.BtnValidityCheck.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnValidityCheck.ForeColor = System.Drawing.Color.White
        Me.BtnValidityCheck.Image = CType(resources.GetObject("BtnValidityCheck.Image"), System.Drawing.Image)
        Me.BtnValidityCheck.ImageSize = New System.Drawing.Size(45, 45)
        Me.BtnValidityCheck.Location = New System.Drawing.Point(61, 580)
        Me.BtnValidityCheck.Name = "BtnValidityCheck"
        Me.BtnValidityCheck.Size = New System.Drawing.Size(238, 45)
        Me.BtnValidityCheck.TabIndex = 4
        Me.BtnValidityCheck.Text = "Medicine Validity Check"
        '
        'BtnUpdateMedicine
        '
        Me.BtnUpdateMedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnUpdateMedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnUpdateMedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnUpdateMedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnUpdateMedicine.FillColor = System.Drawing.Color.Turquoise
        Me.BtnUpdateMedicine.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdateMedicine.ForeColor = System.Drawing.Color.White
        Me.BtnUpdateMedicine.Image = CType(resources.GetObject("BtnUpdateMedicine.Image"), System.Drawing.Image)
        Me.BtnUpdateMedicine.ImageSize = New System.Drawing.Size(45, 45)
        Me.BtnUpdateMedicine.Location = New System.Drawing.Point(61, 508)
        Me.BtnUpdateMedicine.Name = "BtnUpdateMedicine"
        Me.BtnUpdateMedicine.Size = New System.Drawing.Size(180, 45)
        Me.BtnUpdateMedicine.TabIndex = 3
        Me.BtnUpdateMedicine.Text = "Modify Medicine"
        '
        'BtnAddmedicine
        '
        Me.BtnAddmedicine.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnAddmedicine.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnAddmedicine.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnAddmedicine.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnAddmedicine.FillColor = System.Drawing.Color.Turquoise
        Me.BtnAddmedicine.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddmedicine.ForeColor = System.Drawing.Color.White
        Me.BtnAddmedicine.Image = CType(resources.GetObject("BtnAddmedicine.Image"), System.Drawing.Image)
        Me.BtnAddmedicine.ImageSize = New System.Drawing.Size(45, 45)
        Me.BtnAddmedicine.Location = New System.Drawing.Point(61, 432)
        Me.BtnAddmedicine.Name = "BtnAddmedicine"
        Me.BtnAddmedicine.Size = New System.Drawing.Size(180, 45)
        Me.BtnAddmedicine.TabIndex = 2
        Me.BtnAddmedicine.Text = "Add Medicine"
        '
        'BtnDashboard
        '
        Me.BtnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnDashboard.FillColor = System.Drawing.Color.Turquoise
        Me.BtnDashboard.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDashboard.ForeColor = System.Drawing.Color.White
        Me.BtnDashboard.Image = CType(resources.GetObject("BtnDashboard.Image"), System.Drawing.Image)
        Me.BtnDashboard.ImageSize = New System.Drawing.Size(45, 45)
        Me.BtnDashboard.Location = New System.Drawing.Point(61, 286)
        Me.BtnDashboard.Name = "BtnDashboard"
        Me.BtnDashboard.Size = New System.Drawing.Size(180, 45)
        Me.BtnDashboard.TabIndex = 1
        Me.BtnDashboard.Text = "Dashboard"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(61, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(201, 184)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.Controls.Add(Me.UC_P_Sellmedicine11)
        Me.Panel2.Controls.Add(Me.UC_P_ValidityMedicine1)
        Me.Panel2.Controls.Add(Me.UC_P_Updatemedicine11)
        Me.Panel2.Controls.Add(Me.UC_P_Addmedicine11)
        Me.Panel2.Controls.Add(Me.UC_P_Dashboard11)
        Me.Panel2.Location = New System.Drawing.Point(330, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(981, 788)
        Me.Panel2.TabIndex = 1
        '
        'UC_P_Sellmedicine11
        '
        Me.UC_P_Sellmedicine11.BackColor = System.Drawing.Color.LightGreen
        Me.UC_P_Sellmedicine11.Location = New System.Drawing.Point(-33, -3)
        Me.UC_P_Sellmedicine11.Name = "UC_P_Sellmedicine11"
        Me.UC_P_Sellmedicine11.Size = New System.Drawing.Size(1014, 788)
        Me.UC_P_Sellmedicine11.TabIndex = 5
        '
        'UC_P_ValidityMedicine1
        '
        Me.UC_P_ValidityMedicine1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.UC_P_ValidityMedicine1.Location = New System.Drawing.Point(0, 0)
        Me.UC_P_ValidityMedicine1.Name = "UC_P_ValidityMedicine1"
        Me.UC_P_ValidityMedicine1.Size = New System.Drawing.Size(981, 788)
        Me.UC_P_ValidityMedicine1.TabIndex = 4
        '
        'UC_P_Updatemedicine11
        '
        Me.UC_P_Updatemedicine11.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.UC_P_Updatemedicine11.Location = New System.Drawing.Point(0, 0)
        Me.UC_P_Updatemedicine11.Name = "UC_P_Updatemedicine11"
        Me.UC_P_Updatemedicine11.Size = New System.Drawing.Size(981, 788)
        Me.UC_P_Updatemedicine11.TabIndex = 3
        '
        'UC_P_Addmedicine11
        '
        Me.UC_P_Addmedicine11.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.UC_P_Addmedicine11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UC_P_Addmedicine11.Location = New System.Drawing.Point(0, 0)
        Me.UC_P_Addmedicine11.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UC_P_Addmedicine11.Name = "UC_P_Addmedicine11"
        Me.UC_P_Addmedicine11.Size = New System.Drawing.Size(968, 678)
        Me.UC_P_Addmedicine11.TabIndex = 1
        '
        'UC_P_Dashboard11
        '
        Me.UC_P_Dashboard11.BackColor = System.Drawing.Color.PeachPuff
        Me.UC_P_Dashboard11.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UC_P_Dashboard11.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.UC_P_Dashboard11.Location = New System.Drawing.Point(0, 0)
        Me.UC_P_Dashboard11.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.UC_P_Dashboard11.Name = "UC_P_Dashboard11"
        Me.UC_P_Dashboard11.Size = New System.Drawing.Size(981, 788)
        Me.UC_P_Dashboard11.TabIndex = 0
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me.Panel2
        '
        'Guna2Elipse2
        '
        Me.Guna2Elipse2.TargetControl = Me.Panel2
        '
        'Guna2Elipse3
        '
        Me.Guna2Elipse3.TargetControl = Me.Panel2
        '
        'Guna2Elipse4
        '
        Me.Guna2Elipse4.TargetControl = Me.Panel2
        '
        'Guna2Elipse5
        '
        Me.Guna2Elipse5.TargetControl = Me.Panel2
        '
        'Pharmacist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1311, 788)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Pharmacist"
        Me.Text = "Pharmacist"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnDashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnViewmedicine As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2Button6 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnSellmedicine As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnValidityCheck As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnUpdateMedicine As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnAddmedicine As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents UC_P_Dashboard11 As UC_P_Dashboard1
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents UC_P_Addmedicine11 As UC_P_Addmedicine1
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents UC_P_ViewMedicine11 As UC_P_ViewMedicine1
    Friend WithEvents Guna2Elipse4 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents UC_P_Updatemedicine11 As UC_P_Updatemedicine1
    Friend WithEvents Guna2Elipse5 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents UC_P_ValidityMedicine1 As UC_P_ValidityMedicine
    Friend WithEvents Guna2Elipse6 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents UC_P_Sellmedicine11 As UC_P_Sellmedicine1
End Class
