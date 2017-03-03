<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserManagement
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.tabAddNewUser = New MetroFramework.Controls.MetroTabPage()
        Me.tabUserMasterlist = New MetroFramework.Controls.MetroTabPage()
        Me.tabUserRoles = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.tabAddNewUser)
        Me.MetroTabControl1.Controls.Add(Me.tabUserMasterlist)
        Me.MetroTabControl1.Controls.Add(Me.tabUserRoles)
        Me.MetroTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(1054, 541)
        Me.MetroTabControl1.TabIndex = 8
        Me.MetroTabControl1.UseSelectable = True
        '
        'tabAddNewUser
        '
        Me.tabAddNewUser.HorizontalScrollbarBarColor = True
        Me.tabAddNewUser.HorizontalScrollbarHighlightOnWheel = False
        Me.tabAddNewUser.HorizontalScrollbarSize = 10
        Me.tabAddNewUser.Location = New System.Drawing.Point(4, 38)
        Me.tabAddNewUser.Name = "tabAddNewUser"
        Me.tabAddNewUser.Size = New System.Drawing.Size(1046, 499)
        Me.tabAddNewUser.TabIndex = 0
        Me.tabAddNewUser.Text = "Add New User"
        Me.tabAddNewUser.VerticalScrollbarBarColor = True
        Me.tabAddNewUser.VerticalScrollbarHighlightOnWheel = False
        Me.tabAddNewUser.VerticalScrollbarSize = 10
        '
        'tabUserMasterlist
        '
        Me.tabUserMasterlist.HorizontalScrollbarBarColor = True
        Me.tabUserMasterlist.HorizontalScrollbarHighlightOnWheel = False
        Me.tabUserMasterlist.HorizontalScrollbarSize = 10
        Me.tabUserMasterlist.Location = New System.Drawing.Point(4, 35)
        Me.tabUserMasterlist.Name = "tabUserMasterlist"
        Me.tabUserMasterlist.Size = New System.Drawing.Size(1046, 502)
        Me.tabUserMasterlist.TabIndex = 2
        Me.tabUserMasterlist.Text = "User Masterlist"
        Me.tabUserMasterlist.VerticalScrollbarBarColor = True
        Me.tabUserMasterlist.VerticalScrollbarHighlightOnWheel = False
        Me.tabUserMasterlist.VerticalScrollbarSize = 10
        '
        'tabUserRoles
        '
        Me.tabUserRoles.HorizontalScrollbarBarColor = True
        Me.tabUserRoles.HorizontalScrollbarHighlightOnWheel = False
        Me.tabUserRoles.HorizontalScrollbarSize = 10
        Me.tabUserRoles.Location = New System.Drawing.Point(4, 35)
        Me.tabUserRoles.Name = "tabUserRoles"
        Me.tabUserRoles.Size = New System.Drawing.Size(1046, 502)
        Me.tabUserRoles.TabIndex = 1
        Me.tabUserRoles.Text = "User Roles"
        Me.tabUserRoles.VerticalScrollbarBarColor = True
        Me.tabUserRoles.VerticalScrollbarHighlightOnWheel = False
        Me.tabUserRoles.VerticalScrollbarSize = 10
        '
        'frmUserManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Name = "frmUserManagement"
        Me.Size = New System.Drawing.Size(1054, 541)
        Me.MetroTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tabAddNewUser As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabUserMasterlist As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabUserRoles As MetroFramework.Controls.MetroTabPage
End Class
