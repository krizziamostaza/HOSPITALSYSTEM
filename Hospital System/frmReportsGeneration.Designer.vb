<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReportsGeneration
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
        Me.tabPatientMasterlistReport = New MetroFramework.Controls.MetroTabPage()
        Me.tabIndividualPatientReport = New MetroFramework.Controls.MetroTabPage()
        Me.tabAdmittedPatientReport = New MetroFramework.Controls.MetroTabPage()
        Me.tabDischargePatientReport = New MetroFramework.Controls.MetroTabPage()
        Me.tabDailySalesReport = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.tabPatientMasterlistReport)
        Me.MetroTabControl1.Controls.Add(Me.tabIndividualPatientReport)
        Me.MetroTabControl1.Controls.Add(Me.tabAdmittedPatientReport)
        Me.MetroTabControl1.Controls.Add(Me.tabDischargePatientReport)
        Me.MetroTabControl1.Controls.Add(Me.tabDailySalesReport)
        Me.MetroTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(1054, 541)
        Me.MetroTabControl1.TabIndex = 9
        Me.MetroTabControl1.UseSelectable = True
        '
        'tabPatientMasterlistReport
        '
        Me.tabPatientMasterlistReport.HorizontalScrollbarBarColor = True
        Me.tabPatientMasterlistReport.HorizontalScrollbarHighlightOnWheel = False
        Me.tabPatientMasterlistReport.HorizontalScrollbarSize = 10
        Me.tabPatientMasterlistReport.Location = New System.Drawing.Point(4, 38)
        Me.tabPatientMasterlistReport.Name = "tabPatientMasterlistReport"
        Me.tabPatientMasterlistReport.Size = New System.Drawing.Size(1046, 499)
        Me.tabPatientMasterlistReport.TabIndex = 0
        Me.tabPatientMasterlistReport.Text = "Patient Masterlist Report"
        Me.tabPatientMasterlistReport.VerticalScrollbarBarColor = True
        Me.tabPatientMasterlistReport.VerticalScrollbarHighlightOnWheel = False
        Me.tabPatientMasterlistReport.VerticalScrollbarSize = 10
        '
        'tabIndividualPatientReport
        '
        Me.tabIndividualPatientReport.HorizontalScrollbarBarColor = True
        Me.tabIndividualPatientReport.HorizontalScrollbarHighlightOnWheel = False
        Me.tabIndividualPatientReport.HorizontalScrollbarSize = 10
        Me.tabIndividualPatientReport.Location = New System.Drawing.Point(4, 35)
        Me.tabIndividualPatientReport.Name = "tabIndividualPatientReport"
        Me.tabIndividualPatientReport.Size = New System.Drawing.Size(1046, 502)
        Me.tabIndividualPatientReport.TabIndex = 2
        Me.tabIndividualPatientReport.Text = "IndividualPatientReport"
        Me.tabIndividualPatientReport.VerticalScrollbarBarColor = True
        Me.tabIndividualPatientReport.VerticalScrollbarHighlightOnWheel = False
        Me.tabIndividualPatientReport.VerticalScrollbarSize = 10
        '
        'tabAdmittedPatientReport
        '
        Me.tabAdmittedPatientReport.HorizontalScrollbarBarColor = True
        Me.tabAdmittedPatientReport.HorizontalScrollbarHighlightOnWheel = False
        Me.tabAdmittedPatientReport.HorizontalScrollbarSize = 10
        Me.tabAdmittedPatientReport.Location = New System.Drawing.Point(4, 35)
        Me.tabAdmittedPatientReport.Name = "tabAdmittedPatientReport"
        Me.tabAdmittedPatientReport.Size = New System.Drawing.Size(1046, 502)
        Me.tabAdmittedPatientReport.TabIndex = 1
        Me.tabAdmittedPatientReport.Text = "Admitted Patient Report"
        Me.tabAdmittedPatientReport.VerticalScrollbarBarColor = True
        Me.tabAdmittedPatientReport.VerticalScrollbarHighlightOnWheel = False
        Me.tabAdmittedPatientReport.VerticalScrollbarSize = 10
        '
        'tabDischargePatientReport
        '
        Me.tabDischargePatientReport.HorizontalScrollbarBarColor = True
        Me.tabDischargePatientReport.HorizontalScrollbarHighlightOnWheel = False
        Me.tabDischargePatientReport.HorizontalScrollbarSize = 10
        Me.tabDischargePatientReport.Location = New System.Drawing.Point(4, 35)
        Me.tabDischargePatientReport.Name = "tabDischargePatientReport"
        Me.tabDischargePatientReport.Size = New System.Drawing.Size(1046, 502)
        Me.tabDischargePatientReport.TabIndex = 3
        Me.tabDischargePatientReport.Text = "Discharged Patient Report"
        Me.tabDischargePatientReport.VerticalScrollbarBarColor = True
        Me.tabDischargePatientReport.VerticalScrollbarHighlightOnWheel = False
        Me.tabDischargePatientReport.VerticalScrollbarSize = 10
        '
        'tabDailySalesReport
        '
        Me.tabDailySalesReport.HorizontalScrollbarBarColor = True
        Me.tabDailySalesReport.HorizontalScrollbarHighlightOnWheel = False
        Me.tabDailySalesReport.HorizontalScrollbarSize = 10
        Me.tabDailySalesReport.Location = New System.Drawing.Point(4, 35)
        Me.tabDailySalesReport.Name = "tabDailySalesReport"
        Me.tabDailySalesReport.Size = New System.Drawing.Size(1046, 502)
        Me.tabDailySalesReport.TabIndex = 4
        Me.tabDailySalesReport.Text = "Daily Sales Report"
        Me.tabDailySalesReport.VerticalScrollbarBarColor = True
        Me.tabDailySalesReport.VerticalScrollbarHighlightOnWheel = False
        Me.tabDailySalesReport.VerticalScrollbarSize = 10
        '
        'frmReportsGeneration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Name = "frmReportsGeneration"
        Me.Size = New System.Drawing.Size(1054, 541)
        Me.MetroTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tabPatientMasterlistReport As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabIndividualPatientReport As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabAdmittedPatientReport As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabDischargePatientReport As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabDailySalesReport As MetroFramework.Controls.MetroTabPage
End Class
