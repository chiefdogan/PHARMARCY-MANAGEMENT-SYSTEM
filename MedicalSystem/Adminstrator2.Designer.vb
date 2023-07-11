<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adminstrator2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Adminstrator2))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtLabelID = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.BtnLogout = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnProfile = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnViewuser = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnAddUser = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnDashboard = New Guna.UI2.WinForms.Guna2Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.UC_Profile11 = New MedicalSystem.UC_Profile1()
        Me.UC_AddUser11 = New MedicalSystem.UC_AddUser1()
        Me.UC_Dashboard11 = New MedicalSystem.UC_Dashboard1()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse2 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse3 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2Elipse4 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Panel1.Controls.Add(Me.txtLabelID)
        Me.Panel1.Controls.Add(Me.BtnLogout)
        Me.Panel1.Controls.Add(Me.BtnProfile)
        Me.Panel1.Controls.Add(Me.BtnViewuser)
        Me.Panel1.Controls.Add(Me.BtnAddUser)
        Me.Panel1.Controls.Add(Me.BtnDashboard)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(280, 789)
        Me.Panel1.TabIndex = 0
        '
        'txtLabelID
        '
        Me.txtLabelID.BackColor = System.Drawing.Color.Transparent
        Me.txtLabelID.Location = New System.Drawing.Point(143, 743)
        Me.txtLabelID.Name = "txtLabelID"
        Me.txtLabelID.Size = New System.Drawing.Size(49, 15)
        Me.txtLabelID.TabIndex = 7
        Me.txtLabelID.Text = "username"
        '
        'BtnLogout
        '
        Me.BtnLogout.BackColor = System.Drawing.Color.DarkTurquoise
        Me.BtnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnLogout.FillColor = System.Drawing.Color.DarkTurquoise
        Me.BtnLogout.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.ForeColor = System.Drawing.Color.White
        Me.BtnLogout.Image = CType(resources.GetObject("BtnLogout.Image"), System.Drawing.Image)
        Me.BtnLogout.ImageSize = New System.Drawing.Size(45, 45)
        Me.BtnLogout.Location = New System.Drawing.Point(58, 662)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(180, 45)
        Me.BtnLogout.TabIndex = 6
        Me.BtnLogout.Text = "Log Out"
        '
        'BtnProfile
        '
        Me.BtnProfile.BackColor = System.Drawing.Color.DarkTurquoise
        Me.BtnProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnProfile.FillColor = System.Drawing.Color.DarkTurquoise
        Me.BtnProfile.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProfile.ForeColor = System.Drawing.Color.White
        Me.BtnProfile.Image = CType(resources.GetObject("BtnProfile.Image"), System.Drawing.Image)
        Me.BtnProfile.ImageSize = New System.Drawing.Size(45, 45)
        Me.BtnProfile.Location = New System.Drawing.Point(58, 569)
        Me.BtnProfile.Name = "BtnProfile"
        Me.BtnProfile.Size = New System.Drawing.Size(180, 45)
        Me.BtnProfile.TabIndex = 5
        Me.BtnProfile.Text = "Profile"
        '
        'BtnViewuser
        '
        Me.BtnViewuser.BackColor = System.Drawing.Color.DarkTurquoise
        Me.BtnViewuser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnViewuser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnViewuser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnViewuser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnViewuser.FillColor = System.Drawing.Color.DarkTurquoise
        Me.BtnViewuser.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnViewuser.ForeColor = System.Drawing.Color.White
        Me.BtnViewuser.Image = CType(resources.GetObject("BtnViewuser.Image"), System.Drawing.Image)
        Me.BtnViewuser.ImageSize = New System.Drawing.Size(45, 45)
        Me.BtnViewuser.Location = New System.Drawing.Point(58, 481)
        Me.BtnViewuser.Name = "BtnViewuser"
        Me.BtnViewuser.Size = New System.Drawing.Size(180, 45)
        Me.BtnViewuser.TabIndex = 4
        Me.BtnViewuser.Text = "View User"
        '
        'BtnAddUser
        '
        Me.BtnAddUser.BackColor = System.Drawing.Color.DarkTurquoise
        Me.BtnAddUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnAddUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnAddUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnAddUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnAddUser.FillColor = System.Drawing.Color.DarkTurquoise
        Me.BtnAddUser.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddUser.ForeColor = System.Drawing.Color.White
        Me.BtnAddUser.Image = CType(resources.GetObject("BtnAddUser.Image"), System.Drawing.Image)
        Me.BtnAddUser.ImageSize = New System.Drawing.Size(45, 45)
        Me.BtnAddUser.Location = New System.Drawing.Point(58, 372)
        Me.BtnAddUser.Name = "BtnAddUser"
        Me.BtnAddUser.Size = New System.Drawing.Size(180, 45)
        Me.BtnAddUser.TabIndex = 3
        Me.BtnAddUser.Text = "Add User"
        '
        'BtnDashboard
        '
        Me.BtnDashboard.BackColor = System.Drawing.Color.DarkTurquoise
        Me.BtnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.BtnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.BtnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.BtnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.BtnDashboard.FillColor = System.Drawing.Color.DarkTurquoise
        Me.BtnDashboard.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDashboard.ForeColor = System.Drawing.Color.White
        Me.BtnDashboard.Image = CType(resources.GetObject("BtnDashboard.Image"), System.Drawing.Image)
        Me.BtnDashboard.ImageSize = New System.Drawing.Size(45, 45)
        Me.BtnDashboard.Location = New System.Drawing.Point(58, 272)
        Me.BtnDashboard.Name = "BtnDashboard"
        Me.BtnDashboard.Size = New System.Drawing.Size(180, 45)
        Me.BtnDashboard.TabIndex = 2
        Me.BtnDashboard.Text = "Dashboard"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 210)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 33)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Adminstrator"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(41, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(197, 195)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel2.Controls.Add(Me.UC_Profile11)
        Me.Panel2.Controls.Add(Me.UC_AddUser11)
        Me.Panel2.Controls.Add(Me.UC_Dashboard11)
        Me.Panel2.Location = New System.Drawing.Point(278, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1040, 789)
        Me.Panel2.TabIndex = 1
        '
        'UC_Profile11
        '
        Me.UC_Profile11.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.UC_Profile11.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UC_Profile11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.UC_Profile11.Location = New System.Drawing.Point(0, 0)
        Me.UC_Profile11.Margin = New System.Windows.Forms.Padding(10, 9, 10, 9)
        Me.UC_Profile11.Name = "UC_Profile11"
        Me.UC_Profile11.Size = New System.Drawing.Size(1040, 789)
        Me.UC_Profile11.TabIndex = 3
        '
        'UC_AddUser11
        '
        Me.UC_AddUser11.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.UC_AddUser11.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UC_AddUser11.Location = New System.Drawing.Point(0, 0)
        Me.UC_AddUser11.Margin = New System.Windows.Forms.Padding(8)
        Me.UC_AddUser11.Name = "UC_AddUser11"
        Me.UC_AddUser11.Size = New System.Drawing.Size(1040, 789)
        Me.UC_AddUser11.TabIndex = 1
        '
        'UC_Dashboard11
        '
        Me.UC_Dashboard11.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.UC_Dashboard11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UC_Dashboard11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.UC_Dashboard11.Location = New System.Drawing.Point(0, 0)
        Me.UC_Dashboard11.Margin = New System.Windows.Forms.Padding(5)
        Me.UC_Dashboard11.Name = "UC_Dashboard11"
        Me.UC_Dashboard11.Size = New System.Drawing.Size(1059, 1004)
        Me.UC_Dashboard11.TabIndex = 0
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
        'Adminstrator2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1311, 788)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Adminstrator2"
        Me.Text = "Adminstrator2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnDashboard As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnLogout As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnProfile As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnViewuser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnAddUser As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents UC_Dashboard11 As UC_Dashboard1
    Friend WithEvents Guna2Elipse2 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents UC_AddUser11 As UC_AddUser1
    Friend WithEvents Guna2Elipse3 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents UC_ViewUserl11 As UC_ViewUserl1
    Friend WithEvents Guna2Elipse4 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents UC_Profile11 As UC_Profile1
    Friend WithEvents txtLabelID As Guna.UI2.WinForms.Guna2HtmlLabel
End Class
