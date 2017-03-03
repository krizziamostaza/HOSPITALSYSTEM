Public Class frmMain

    Public bMgmt As New frmBillingManagement
    Public pMgmt As New frmPatientManagement
    Public rMgmt As New frmRoomManagement
    Public nModule As New frmNurseModule
    Public uMgmt As New frmUserManagement


    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Panel1.Controls.Add(pMgmt)
        pMgmt.Dock = DockStyle.Fill
        pMgmt.Show()

        lblTimeDate.Text = dateTime
        lblUsername.Text = frmLogin.username
    End Sub

    Private Sub btnPatientMgmt_Click_1(sender As Object, e As EventArgs) Handles btnPatientMgmt.Click
        Panel1.Controls.Remove(bMgmt)
        Panel1.Controls.Remove(rMgmt)
        Panel1.Controls.Remove(nModule)
        Panel1.Controls.Remove(uMgmt)
        Panel1.Controls.Add(pMgmt)
        pMgmt.Dock = DockStyle.Fill
        pMgmt.Show()
    End Sub

    Private Sub btnRoomManagement_Click(sender As Object, e As EventArgs) Handles btnRoomManagement.Click
        Panel1.Controls.Remove(bMgmt)
        Panel1.Controls.Remove(pMgmt)
        Panel1.Controls.Remove(nModule)
        Panel1.Controls.Remove(uMgmt)
        Panel1.Controls.Add(rMgmt)
        rMgmt.Dock = DockStyle.Fill
        rMgmt.Show()
    End Sub

    Private Sub btnBillingManagement_Click_1(sender As Object, e As EventArgs) Handles btnBillingManagement.Click
        Panel1.Controls.Remove(pMgmt)
        Panel1.Controls.Remove(rMgmt)
        Panel1.Controls.Remove(nModule)
        Panel1.Controls.Remove(uMgmt)
        Panel1.Controls.Add(bMgmt)
        bMgmt.Dock = DockStyle.Fill
        bMgmt.Show()
    End Sub

    Private Sub btnNurseModule_Click(sender As Object, e As EventArgs) Handles btnNurseModule.Click
        Panel1.Controls.Remove(pMgmt)
        Panel1.Controls.Remove(rMgmt)
        Panel1.Controls.Remove(bMgmt)
        Panel1.Controls.Remove(uMgmt)
        Panel1.Controls.Add(nModule)
        nModule.Dock = DockStyle.Fill
        nModule.Show()

    End Sub

    Private Sub btnUserManagement_Click(sender As Object, e As EventArgs) Handles btnUserManagement.Click
        Panel1.Controls.Remove(pMgmt)
        Panel1.Controls.Remove(rMgmt)
        Panel1.Controls.Remove(bMgmt)
        Panel1.Controls.Remove(nModule)
        Panel1.Controls.Add(uMgmt)
        uMgmt.Dock = DockStyle.Fill
        uMgmt.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ContextMenuStrip1.Show(Control.MousePosition)
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        frmLogin.Show()
        Me.Close()

    End Sub
End Class
