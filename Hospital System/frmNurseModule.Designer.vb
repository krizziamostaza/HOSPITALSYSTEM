<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNurseModule
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
        Me.tabIntakeOutputRecord = New MetroFramework.Controls.MetroTabPage()
        Me.tabProgressNote = New MetroFramework.Controls.MetroTabPage()
        Me.tabVitalSign = New MetroFramework.Controls.MetroTabPage()
        Me.tabPatientHistory = New MetroFramework.Controls.MetroTabPage()
        Me.tabDischargeSummary = New MetroFramework.Controls.MetroTabPage()
        Me.txtSubTotal = New MetroFramework.Controls.MetroTextBox()
        Me.btnPrint = New MetroFramework.Controls.MetroButton()
        Me.btnAddMedication = New MetroFramework.Controls.MetroButton()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.txtTotalItems = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.txtDate = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.txtInvoiceNumber = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtPatientName = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.txtPatientID = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.tabPatientMedication = New MetroFramework.Controls.MetroTabPage()
        Me.btnRemove = New MetroFramework.Controls.MetroButton()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.colMedicineName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colInstruction = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAdvice = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDays = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colQty = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPreparedBy = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MetroPanel1.SuspendLayout()
        Me.MetroTabControl1.SuspendLayout()
        Me.tabPatientMedication.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabIntakeOutputRecord
        '
        Me.tabIntakeOutputRecord.HorizontalScrollbarBarColor = True
        Me.tabIntakeOutputRecord.HorizontalScrollbarHighlightOnWheel = False
        Me.tabIntakeOutputRecord.HorizontalScrollbarSize = 10
        Me.tabIntakeOutputRecord.Location = New System.Drawing.Point(4, 38)
        Me.tabIntakeOutputRecord.Name = "tabIntakeOutputRecord"
        Me.tabIntakeOutputRecord.Size = New System.Drawing.Size(1046, 499)
        Me.tabIntakeOutputRecord.TabIndex = 2
        Me.tabIntakeOutputRecord.Text = "Intake/Output Record"
        Me.tabIntakeOutputRecord.VerticalScrollbarBarColor = True
        Me.tabIntakeOutputRecord.VerticalScrollbarHighlightOnWheel = False
        Me.tabIntakeOutputRecord.VerticalScrollbarSize = 10
        '
        'tabProgressNote
        '
        Me.tabProgressNote.HorizontalScrollbarBarColor = True
        Me.tabProgressNote.HorizontalScrollbarHighlightOnWheel = False
        Me.tabProgressNote.HorizontalScrollbarSize = 10
        Me.tabProgressNote.Location = New System.Drawing.Point(4, 38)
        Me.tabProgressNote.Name = "tabProgressNote"
        Me.tabProgressNote.Size = New System.Drawing.Size(1046, 499)
        Me.tabProgressNote.TabIndex = 1
        Me.tabProgressNote.Text = "Progress Note"
        Me.tabProgressNote.VerticalScrollbarBarColor = True
        Me.tabProgressNote.VerticalScrollbarHighlightOnWheel = False
        Me.tabProgressNote.VerticalScrollbarSize = 10
        '
        'tabVitalSign
        '
        Me.tabVitalSign.HorizontalScrollbarBarColor = True
        Me.tabVitalSign.HorizontalScrollbarHighlightOnWheel = False
        Me.tabVitalSign.HorizontalScrollbarSize = 10
        Me.tabVitalSign.Location = New System.Drawing.Point(4, 38)
        Me.tabVitalSign.Name = "tabVitalSign"
        Me.tabVitalSign.Size = New System.Drawing.Size(1046, 499)
        Me.tabVitalSign.TabIndex = 5
        Me.tabVitalSign.Text = "Vital Sign"
        Me.tabVitalSign.VerticalScrollbarBarColor = True
        Me.tabVitalSign.VerticalScrollbarHighlightOnWheel = False
        Me.tabVitalSign.VerticalScrollbarSize = 10
        '
        'tabPatientHistory
        '
        Me.tabPatientHistory.HorizontalScrollbarBarColor = True
        Me.tabPatientHistory.HorizontalScrollbarHighlightOnWheel = False
        Me.tabPatientHistory.HorizontalScrollbarSize = 10
        Me.tabPatientHistory.Location = New System.Drawing.Point(4, 38)
        Me.tabPatientHistory.Name = "tabPatientHistory"
        Me.tabPatientHistory.Size = New System.Drawing.Size(1046, 499)
        Me.tabPatientHistory.TabIndex = 3
        Me.tabPatientHistory.Text = "PatientHistory"
        Me.tabPatientHistory.VerticalScrollbarBarColor = True
        Me.tabPatientHistory.VerticalScrollbarHighlightOnWheel = False
        Me.tabPatientHistory.VerticalScrollbarSize = 10
        '
        'tabDischargeSummary
        '
        Me.tabDischargeSummary.HorizontalScrollbarBarColor = True
        Me.tabDischargeSummary.HorizontalScrollbarHighlightOnWheel = False
        Me.tabDischargeSummary.HorizontalScrollbarSize = 10
        Me.tabDischargeSummary.Location = New System.Drawing.Point(4, 38)
        Me.tabDischargeSummary.Name = "tabDischargeSummary"
        Me.tabDischargeSummary.Size = New System.Drawing.Size(1046, 499)
        Me.tabDischargeSummary.TabIndex = 4
        Me.tabDischargeSummary.Text = "Discharge Summary"
        Me.tabDischargeSummary.VerticalScrollbarBarColor = True
        Me.tabDischargeSummary.VerticalScrollbarHighlightOnWheel = False
        Me.tabDischargeSummary.VerticalScrollbarSize = 10
        '
        'txtSubTotal
        '
        '
        '
        '
        Me.txtSubTotal.CustomButton.Image = Nothing
        Me.txtSubTotal.CustomButton.Location = New System.Drawing.Point(232, 1)
        Me.txtSubTotal.CustomButton.Name = ""
        Me.txtSubTotal.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtSubTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtSubTotal.CustomButton.TabIndex = 1
        Me.txtSubTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtSubTotal.CustomButton.UseSelectable = True
        Me.txtSubTotal.CustomButton.Visible = False
        Me.txtSubTotal.Enabled = False
        Me.txtSubTotal.Lines = New String(-1) {}
        Me.txtSubTotal.Location = New System.Drawing.Point(10, 251)
        Me.txtSubTotal.MaxLength = 32767
        Me.txtSubTotal.Name = "txtSubTotal"
        Me.txtSubTotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtSubTotal.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtSubTotal.SelectedText = ""
        Me.txtSubTotal.SelectionLength = 0
        Me.txtSubTotal.SelectionStart = 0
        Me.txtSubTotal.ShortcutsEnabled = True
        Me.txtSubTotal.Size = New System.Drawing.Size(254, 23)
        Me.txtSubTotal.TabIndex = 13
        Me.txtSubTotal.UseSelectable = True
        Me.txtSubTotal.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtSubTotal.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(406, 6)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(110, 23)
        Me.btnPrint.TabIndex = 5
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseSelectable = True
        '
        'btnAddMedication
        '
        Me.btnAddMedication.Location = New System.Drawing.Point(287, 6)
        Me.btnAddMedication.Name = "btnAddMedication"
        Me.btnAddMedication.Size = New System.Drawing.Size(110, 23)
        Me.btnAddMedication.TabIndex = 4
        Me.btnAddMedication.Text = "Medication"
        Me.btnAddMedication.UseSelectable = True
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.txtSubTotal)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel8)
        Me.MetroPanel1.Controls.Add(Me.txtTotalItems)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel1.Controls.Add(Me.txtDate)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel4)
        Me.MetroPanel1.Controls.Add(Me.txtInvoiceNumber)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel1.Controls.Add(Me.txtPatientName)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel1.Controls.Add(Me.txtPatientID)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(0, 3)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(281, 499)
        Me.MetroPanel1.TabIndex = 3
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(4, 229)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(60, 19)
        Me.MetroLabel8.TabIndex = 12
        Me.MetroLabel8.Text = "Bed No.:"
        '
        'txtTotalItems
        '
        '
        '
        '
        Me.txtTotalItems.CustomButton.Image = Nothing
        Me.txtTotalItems.CustomButton.Location = New System.Drawing.Point(232, 1)
        Me.txtTotalItems.CustomButton.Name = ""
        Me.txtTotalItems.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTotalItems.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTotalItems.CustomButton.TabIndex = 1
        Me.txtTotalItems.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTotalItems.CustomButton.UseSelectable = True
        Me.txtTotalItems.CustomButton.Visible = False
        Me.txtTotalItems.Enabled = False
        Me.txtTotalItems.Lines = New String(-1) {}
        Me.txtTotalItems.Location = New System.Drawing.Point(9, 203)
        Me.txtTotalItems.MaxLength = 32767
        Me.txtTotalItems.Name = "txtTotalItems"
        Me.txtTotalItems.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalItems.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTotalItems.SelectedText = ""
        Me.txtTotalItems.SelectionLength = 0
        Me.txtTotalItems.SelectionStart = 0
        Me.txtTotalItems.ShortcutsEnabled = True
        Me.txtTotalItems.Size = New System.Drawing.Size(254, 23)
        Me.txtTotalItems.TabIndex = 11
        Me.txtTotalItems.UseSelectable = True
        Me.txtTotalItems.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTotalItems.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(3, 181)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(48, 19)
        Me.MetroLabel5.TabIndex = 10
        Me.MetroLabel5.Text = "Room:"
        '
        'txtDate
        '
        '
        '
        '
        Me.txtDate.CustomButton.Image = Nothing
        Me.txtDate.CustomButton.Location = New System.Drawing.Point(232, 1)
        Me.txtDate.CustomButton.Name = ""
        Me.txtDate.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtDate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDate.CustomButton.TabIndex = 1
        Me.txtDate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDate.CustomButton.UseSelectable = True
        Me.txtDate.CustomButton.Visible = False
        Me.txtDate.Enabled = False
        Me.txtDate.Lines = New String(-1) {}
        Me.txtDate.Location = New System.Drawing.Point(10, 155)
        Me.txtDate.MaxLength = 32767
        Me.txtDate.Name = "txtDate"
        Me.txtDate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDate.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDate.SelectedText = ""
        Me.txtDate.SelectionLength = 0
        Me.txtDate.SelectionStart = 0
        Me.txtDate.ShortcutsEnabled = True
        Me.txtDate.Size = New System.Drawing.Size(254, 23)
        Me.txtDate.TabIndex = 9
        Me.txtDate.UseSelectable = True
        Me.txtDate.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDate.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(4, 133)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(115, 19)
        Me.MetroLabel4.TabIndex = 8
        Me.MetroLabel4.Text = "Incharged Doctor:"
        '
        'txtInvoiceNumber
        '
        '
        '
        '
        Me.txtInvoiceNumber.CustomButton.Image = Nothing
        Me.txtInvoiceNumber.CustomButton.Location = New System.Drawing.Point(232, 1)
        Me.txtInvoiceNumber.CustomButton.Name = ""
        Me.txtInvoiceNumber.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtInvoiceNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtInvoiceNumber.CustomButton.TabIndex = 1
        Me.txtInvoiceNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtInvoiceNumber.CustomButton.UseSelectable = True
        Me.txtInvoiceNumber.CustomButton.Visible = False
        Me.txtInvoiceNumber.Enabled = False
        Me.txtInvoiceNumber.Lines = New String(-1) {}
        Me.txtInvoiceNumber.Location = New System.Drawing.Point(10, 110)
        Me.txtInvoiceNumber.MaxLength = 32767
        Me.txtInvoiceNumber.Name = "txtInvoiceNumber"
        Me.txtInvoiceNumber.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInvoiceNumber.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtInvoiceNumber.SelectedText = ""
        Me.txtInvoiceNumber.SelectionLength = 0
        Me.txtInvoiceNumber.SelectionStart = 0
        Me.txtInvoiceNumber.ShortcutsEnabled = True
        Me.txtInvoiceNumber.Size = New System.Drawing.Size(254, 23)
        Me.txtInvoiceNumber.TabIndex = 7
        Me.txtInvoiceNumber.UseSelectable = True
        Me.txtInvoiceNumber.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtInvoiceNumber.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(4, 88)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(112, 19)
        Me.MetroLabel3.TabIndex = 6
        Me.MetroLabel3.Text = "Date Time Admit:"
        '
        'txtPatientName
        '
        '
        '
        '
        Me.txtPatientName.CustomButton.Image = Nothing
        Me.txtPatientName.CustomButton.Location = New System.Drawing.Point(232, 1)
        Me.txtPatientName.CustomButton.Name = ""
        Me.txtPatientName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPatientName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPatientName.CustomButton.TabIndex = 1
        Me.txtPatientName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPatientName.CustomButton.UseSelectable = True
        Me.txtPatientName.CustomButton.Visible = False
        Me.txtPatientName.Enabled = False
        Me.txtPatientName.Lines = New String(-1) {}
        Me.txtPatientName.Location = New System.Drawing.Point(10, 65)
        Me.txtPatientName.MaxLength = 32767
        Me.txtPatientName.Name = "txtPatientName"
        Me.txtPatientName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPatientName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPatientName.SelectedText = ""
        Me.txtPatientName.SelectionLength = 0
        Me.txtPatientName.SelectionStart = 0
        Me.txtPatientName.ShortcutsEnabled = True
        Me.txtPatientName.Size = New System.Drawing.Size(254, 23)
        Me.txtPatientName.TabIndex = 5
        Me.txtPatientName.UseSelectable = True
        Me.txtPatientName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPatientName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(4, 43)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(91, 19)
        Me.MetroLabel2.TabIndex = 4
        Me.MetroLabel2.Text = "Patient Name:"
        '
        'txtPatientID
        '
        '
        '
        '
        Me.txtPatientID.CustomButton.Image = Nothing
        Me.txtPatientID.CustomButton.Location = New System.Drawing.Point(131, 1)
        Me.txtPatientID.CustomButton.Name = ""
        Me.txtPatientID.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPatientID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPatientID.CustomButton.TabIndex = 1
        Me.txtPatientID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPatientID.CustomButton.UseSelectable = True
        Me.txtPatientID.CustomButton.Visible = False
        Me.txtPatientID.Enabled = False
        Me.txtPatientID.Lines = New String(-1) {}
        Me.txtPatientID.Location = New System.Drawing.Point(111, 9)
        Me.txtPatientID.MaxLength = 32767
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPatientID.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPatientID.SelectedText = ""
        Me.txtPatientID.SelectionLength = 0
        Me.txtPatientID.SelectionStart = 0
        Me.txtPatientID.ShortcutsEnabled = True
        Me.txtPatientID.Size = New System.Drawing.Size(153, 23)
        Me.txtPatientID.TabIndex = 3
        Me.txtPatientID.UseSelectable = True
        Me.txtPatientID.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPatientID.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(4, 9)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(64, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Patient ID"
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.tabPatientMedication)
        Me.MetroTabControl1.Controls.Add(Me.tabIntakeOutputRecord)
        Me.MetroTabControl1.Controls.Add(Me.tabProgressNote)
        Me.MetroTabControl1.Controls.Add(Me.tabVitalSign)
        Me.MetroTabControl1.Controls.Add(Me.tabPatientHistory)
        Me.MetroTabControl1.Controls.Add(Me.tabDischargeSummary)
        Me.MetroTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(1054, 541)
        Me.MetroTabControl1.TabIndex = 7
        Me.MetroTabControl1.UseSelectable = True
        '
        'tabPatientMedication
        '
        Me.tabPatientMedication.Controls.Add(Me.btnRemove)
        Me.tabPatientMedication.Controls.Add(Me.ListView1)
        Me.tabPatientMedication.Controls.Add(Me.btnPrint)
        Me.tabPatientMedication.Controls.Add(Me.btnAddMedication)
        Me.tabPatientMedication.Controls.Add(Me.MetroPanel1)
        Me.tabPatientMedication.HorizontalScrollbarBarColor = True
        Me.tabPatientMedication.HorizontalScrollbarHighlightOnWheel = False
        Me.tabPatientMedication.HorizontalScrollbarSize = 10
        Me.tabPatientMedication.Location = New System.Drawing.Point(4, 38)
        Me.tabPatientMedication.Name = "tabPatientMedication"
        Me.tabPatientMedication.Size = New System.Drawing.Size(1046, 499)
        Me.tabPatientMedication.TabIndex = 0
        Me.tabPatientMedication.Text = "Patient Medication"
        Me.tabPatientMedication.VerticalScrollbarBarColor = True
        Me.tabPatientMedication.VerticalScrollbarHighlightOnWheel = False
        Me.tabPatientMedication.VerticalScrollbarSize = 10
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(937, 476)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(110, 23)
        Me.btnRemove.TabIndex = 7
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseSelectable = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colMedicineName, Me.colInstruction, Me.colAdvice, Me.colDays, Me.colQty, Me.colPreparedBy})
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(287, 36)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(759, 433)
        Me.ListView1.TabIndex = 6
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'colMedicineName
        '
        Me.colMedicineName.Text = "Medicine Name"
        Me.colMedicineName.Width = 162
        '
        'colInstruction
        '
        Me.colInstruction.Text = "Instruction"
        Me.colInstruction.Width = 155
        '
        'colAdvice
        '
        Me.colAdvice.Text = "Advice"
        Me.colAdvice.Width = 179
        '
        'colDays
        '
        Me.colDays.Text = "Days"
        '
        'colQty
        '
        Me.colQty.Text = "Qty."
        Me.colQty.Width = 52
        '
        'colPreparedBy
        '
        Me.colPreparedBy.Text = "Prepared By"
        Me.colPreparedBy.Width = 126
        '
        'frmNurseModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Name = "frmNurseModule"
        Me.Size = New System.Drawing.Size(1054, 541)
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.MetroTabControl1.ResumeLayout(False)
        Me.tabPatientMedication.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabIntakeOutputRecord As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabProgressNote As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabVitalSign As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabPatientHistory As MetroFramework.Controls.MetroTabPage
    Friend WithEvents tabDischargeSummary As MetroFramework.Controls.MetroTabPage
    Friend WithEvents txtSubTotal As MetroFramework.Controls.MetroTextBox
    Friend WithEvents btnPrint As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAddMedication As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtTotalItems As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtDate As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtInvoiceNumber As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Public WithEvents txtPatientName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Public WithEvents txtPatientID As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tabPatientMedication As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btnRemove As MetroFramework.Controls.MetroButton
    Friend WithEvents ListView1 As ListView
    Friend WithEvents colMedicineName As ColumnHeader
    Friend WithEvents colInstruction As ColumnHeader
    Friend WithEvents colAdvice As ColumnHeader
    Friend WithEvents colDays As ColumnHeader
    Friend WithEvents colQty As ColumnHeader
    Friend WithEvents colPreparedBy As ColumnHeader
End Class
