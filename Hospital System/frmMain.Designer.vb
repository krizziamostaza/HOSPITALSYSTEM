<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblUsername = New MetroFramework.Controls.MetroLabel()
        Me.lblTimeDate = New MetroFramework.Controls.MetroLabel()
        Me.MetroButton6 = New MetroFramework.Controls.MetroButton()
        Me.btnPatientMgmt = New MetroFramework.Controls.MetroButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnBillingManagement = New MetroFramework.Controls.MetroButton()
        Me.btnAdministrator = New MetroFramework.Controls.MetroButton()
        Me.btnNurseModule = New MetroFramework.Controls.MetroButton()
        Me.btnRoomManagement = New MetroFramework.Controls.MetroButton()
        Me.btnUserManagement = New MetroFramework.Controls.MetroButton()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(1020, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(16, 16)
        Me.Button1.TabIndex = 28
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblUsername
        '
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.lblUsername.ForeColor = System.Drawing.Color.Transparent
        Me.lblUsername.Location = New System.Drawing.Point(929, 46)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(140, 22)
        Me.lblUsername.TabIndex = 27
        Me.lblUsername.Text = "MetroLabel1"
        '
        'lblTimeDate
        '
        Me.lblTimeDate.BackColor = System.Drawing.Color.Transparent
        Me.lblTimeDate.ForeColor = System.Drawing.Color.Transparent
        Me.lblTimeDate.Location = New System.Drawing.Point(929, 27)
        Me.lblTimeDate.Name = "lblTimeDate"
        Me.lblTimeDate.Size = New System.Drawing.Size(140, 22)
        Me.lblTimeDate.TabIndex = 26
        Me.lblTimeDate.Text = "MetroLabel1"
        '
        'MetroButton6
        '
        Me.MetroButton6.Location = New System.Drawing.Point(790, 27)
        Me.MetroButton6.Name = "MetroButton6"
        Me.MetroButton6.Size = New System.Drawing.Size(123, 40)
        Me.MetroButton6.TabIndex = 25
        Me.MetroButton6.Text = "Reports Generation"
        Me.MetroButton6.UseSelectable = True
        '
        'btnPatientMgmt
        '
        Me.btnPatientMgmt.Location = New System.Drawing.Point(16, 27)
        Me.btnPatientMgmt.Name = "btnPatientMgmt"
        Me.btnPatientMgmt.Size = New System.Drawing.Size(123, 40)
        Me.btnPatientMgmt.TabIndex = 19
        Me.btnPatientMgmt.Text = "Patient Management"
        Me.btnPatientMgmt.UseSelectable = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(15, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1054, 541)
        Me.Panel1.TabIndex = 18
        '
        'btnBillingManagement
        '
        Me.btnBillingManagement.Location = New System.Drawing.Point(274, 27)
        Me.btnBillingManagement.Name = "btnBillingManagement"
        Me.btnBillingManagement.Size = New System.Drawing.Size(123, 40)
        Me.btnBillingManagement.TabIndex = 21
        Me.btnBillingManagement.Text = "Billing Management"
        Me.btnBillingManagement.UseSelectable = True
        '
        'btnAdministrator
        '
        Me.btnAdministrator.Location = New System.Drawing.Point(661, 27)
        Me.btnAdministrator.Name = "btnAdministrator"
        Me.btnAdministrator.Size = New System.Drawing.Size(123, 40)
        Me.btnAdministrator.TabIndex = 24
        Me.btnAdministrator.Text = "Administrator"
        Me.btnAdministrator.UseSelectable = True
        '
        'btnNurseModule
        '
        Me.btnNurseModule.Location = New System.Drawing.Point(403, 27)
        Me.btnNurseModule.Name = "btnNurseModule"
        Me.btnNurseModule.Size = New System.Drawing.Size(123, 40)
        Me.btnNurseModule.TabIndex = 22
        Me.btnNurseModule.Text = "Nurse Module"
        Me.btnNurseModule.UseSelectable = True
        '
        'btnRoomManagement
        '
        Me.btnRoomManagement.Location = New System.Drawing.Point(145, 27)
        Me.btnRoomManagement.Name = "btnRoomManagement"
        Me.btnRoomManagement.Size = New System.Drawing.Size(123, 40)
        Me.btnRoomManagement.TabIndex = 20
        Me.btnRoomManagement.Text = "Room Management"
        Me.btnRoomManagement.UseSelectable = True
        '
        'btnUserManagement
        '
        Me.btnUserManagement.Location = New System.Drawing.Point(532, 27)
        Me.btnUserManagement.Name = "btnUserManagement"
        Me.btnUserManagement.Size = New System.Drawing.Size(123, 40)
        Me.btnUserManagement.TabIndex = 23
        Me.btnUserManagement.Text = "User Management"
        Me.btnUserManagement.UseSelectable = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogoutToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(118, 26)
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(117, 22)
        Me.LogoutToolStripMenuItem.Text = "Log-out"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1084, 641)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.lblTimeDate)
        Me.Controls.Add(Me.MetroButton6)
        Me.Controls.Add(Me.btnPatientMgmt)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBillingManagement)
        Me.Controls.Add(Me.btnAdministrator)
        Me.Controls.Add(Me.btnNurseModule)
        Me.Controls.Add(Me.btnRoomManagement)
        Me.Controls.Add(Me.btnUserManagement)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Hospital Billing and Information System"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lblUsername As MetroFramework.Controls.MetroLabel
    Friend WithEvents lblTimeDate As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroButton6 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnPatientMgmt As MetroFramework.Controls.MetroButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBillingManagement As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAdministrator As MetroFramework.Controls.MetroButton
    Friend WithEvents btnNurseModule As MetroFramework.Controls.MetroButton
    Friend WithEvents btnRoomManagement As MetroFramework.Controls.MetroButton
    Friend WithEvents btnUserManagement As MetroFramework.Controls.MetroButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
End Class
