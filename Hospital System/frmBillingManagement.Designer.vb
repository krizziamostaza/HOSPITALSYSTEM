<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBillingManagement
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
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tabPOS = New MetroFramework.Controls.MetroTabPage()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.btnPrintBillingStatement = New MetroFramework.Controls.MetroButton()
        Me.btnPayment = New MetroFramework.Controls.MetroButton()
        Me.btnSave = New MetroFramework.Controls.MetroButton()
        Me.btnAddItem = New MetroFramework.Controls.MetroButton()
        Me.btnDoctorsFee = New MetroFramework.Controls.MetroButton()
        Me.btnSelectPatient = New MetroFramework.Controls.MetroButton()
        Me.listBilling = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.txtTotalAmount = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.txtDiscount = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.txtSubTotal = New MetroFramework.Controls.MetroTextBox()
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
        Me.tabBillingList = New MetroFramework.Controls.MetroTabPage()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.tabPOS.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        Me.MetroPanel1.SuspendLayout()
        Me.tabBillingList.SuspendLayout()
        Me.MetroTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Amount"
        Me.ColumnHeader5.Width = 113
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Qty."
        Me.ColumnHeader3.Width = 68
        '
        'tabPOS
        '
        Me.tabPOS.Controls.Add(Me.MetroPanel2)
        Me.tabPOS.Controls.Add(Me.listBilling)
        Me.tabPOS.Controls.Add(Me.MetroPanel1)
        Me.tabPOS.HorizontalScrollbarBarColor = True
        Me.tabPOS.HorizontalScrollbarHighlightOnWheel = False
        Me.tabPOS.HorizontalScrollbarSize = 10
        Me.tabPOS.Location = New System.Drawing.Point(4, 38)
        Me.tabPOS.Name = "tabPOS"
        Me.tabPOS.Size = New System.Drawing.Size(1046, 500)
        Me.tabPOS.TabIndex = 0
        Me.tabPOS.Text = "POS"
        Me.tabPOS.VerticalScrollbarBarColor = True
        Me.tabPOS.VerticalScrollbarHighlightOnWheel = False
        Me.tabPOS.VerticalScrollbarSize = 10
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.btnPrintBillingStatement)
        Me.MetroPanel2.Controls.Add(Me.btnPayment)
        Me.MetroPanel2.Controls.Add(Me.btnSave)
        Me.MetroPanel2.Controls.Add(Me.btnAddItem)
        Me.MetroPanel2.Controls.Add(Me.btnDoctorsFee)
        Me.MetroPanel2.Controls.Add(Me.btnSelectPatient)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(288, 445)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(758, 51)
        Me.MetroPanel2.TabIndex = 4
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'btnPrintBillingStatement
        '
        Me.btnPrintBillingStatement.Location = New System.Drawing.Point(608, 16)
        Me.btnPrintBillingStatement.Name = "btnPrintBillingStatement"
        Me.btnPrintBillingStatement.Size = New System.Drawing.Size(110, 23)
        Me.btnPrintBillingStatement.TabIndex = 7
        Me.btnPrintBillingStatement.Text = "Print Billing"
        Me.btnPrintBillingStatement.UseSelectable = True
        '
        'btnPayment
        '
        Me.btnPayment.Location = New System.Drawing.Point(489, 16)
        Me.btnPayment.Name = "btnPayment"
        Me.btnPayment.Size = New System.Drawing.Size(110, 23)
        Me.btnPayment.TabIndex = 6
        Me.btnPayment.Text = "Payment"
        Me.btnPayment.UseSelectable = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(370, 16)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(110, 23)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseSelectable = True
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(251, 16)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(110, 23)
        Me.btnAddItem.TabIndex = 4
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseSelectable = True
        '
        'btnDoctorsFee
        '
        Me.btnDoctorsFee.Location = New System.Drawing.Point(132, 16)
        Me.btnDoctorsFee.Name = "btnDoctorsFee"
        Me.btnDoctorsFee.Size = New System.Drawing.Size(110, 23)
        Me.btnDoctorsFee.TabIndex = 3
        Me.btnDoctorsFee.Text = "Doctor's Fee"
        Me.btnDoctorsFee.UseSelectable = True
        '
        'btnSelectPatient
        '
        Me.btnSelectPatient.Location = New System.Drawing.Point(13, 16)
        Me.btnSelectPatient.Name = "btnSelectPatient"
        Me.btnSelectPatient.Size = New System.Drawing.Size(110, 23)
        Me.btnSelectPatient.TabIndex = 2
        Me.btnSelectPatient.Text = "Select Patient"
        Me.btnSelectPatient.UseSelectable = True
        '
        'listBilling
        '
        Me.listBilling.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.listBilling.FullRowSelect = True
        Me.listBilling.GridLines = True
        Me.listBilling.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.listBilling.Location = New System.Drawing.Point(288, 3)
        Me.listBilling.Name = "listBilling"
        Me.listBilling.Size = New System.Drawing.Size(758, 435)
        Me.listBilling.TabIndex = 3
        Me.listBilling.UseCompatibleStateImageBehavior = False
        Me.listBilling.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No."
        Me.ColumnHeader1.Width = 80
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Particular Name"
        Me.ColumnHeader2.Width = 373
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Rate"
        Me.ColumnHeader4.Width = 106
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.txtTotalAmount)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel6)
        Me.MetroPanel1.Controls.Add(Me.txtDiscount)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel7)
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
        Me.MetroPanel1.Size = New System.Drawing.Size(281, 493)
        Me.MetroPanel1.TabIndex = 2
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'txtTotalAmount
        '
        '
        '
        '
        Me.txtTotalAmount.CustomButton.Image = Nothing
        Me.txtTotalAmount.CustomButton.Location = New System.Drawing.Point(232, 1)
        Me.txtTotalAmount.CustomButton.Name = ""
        Me.txtTotalAmount.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtTotalAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtTotalAmount.CustomButton.TabIndex = 1
        Me.txtTotalAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtTotalAmount.CustomButton.UseSelectable = True
        Me.txtTotalAmount.CustomButton.Visible = False
        Me.txtTotalAmount.Enabled = False
        Me.txtTotalAmount.Lines = New String(-1) {}
        Me.txtTotalAmount.Location = New System.Drawing.Point(9, 344)
        Me.txtTotalAmount.MaxLength = 32767
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTotalAmount.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtTotalAmount.SelectedText = ""
        Me.txtTotalAmount.SelectionLength = 0
        Me.txtTotalAmount.SelectionStart = 0
        Me.txtTotalAmount.ShortcutsEnabled = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(254, 23)
        Me.txtTotalAmount.TabIndex = 17
        Me.txtTotalAmount.UseSelectable = True
        Me.txtTotalAmount.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtTotalAmount.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel6.Location = New System.Drawing.Point(3, 322)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(103, 19)
        Me.MetroLabel6.TabIndex = 16
        Me.MetroLabel6.Text = "Total Amount:"
        '
        'txtDiscount
        '
        '
        '
        '
        Me.txtDiscount.CustomButton.Image = Nothing
        Me.txtDiscount.CustomButton.Location = New System.Drawing.Point(232, 1)
        Me.txtDiscount.CustomButton.Name = ""
        Me.txtDiscount.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtDiscount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtDiscount.CustomButton.TabIndex = 1
        Me.txtDiscount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtDiscount.CustomButton.UseSelectable = True
        Me.txtDiscount.CustomButton.Visible = False
        Me.txtDiscount.Enabled = False
        Me.txtDiscount.Lines = New String(-1) {}
        Me.txtDiscount.Location = New System.Drawing.Point(10, 296)
        Me.txtDiscount.MaxLength = 32767
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtDiscount.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtDiscount.SelectedText = ""
        Me.txtDiscount.SelectionLength = 0
        Me.txtDiscount.SelectionStart = 0
        Me.txtDiscount.ShortcutsEnabled = True
        Me.txtDiscount.Size = New System.Drawing.Size(254, 23)
        Me.txtDiscount.TabIndex = 15
        Me.txtDiscount.UseSelectable = True
        Me.txtDiscount.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtDiscount.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(4, 274)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(61, 19)
        Me.MetroLabel7.TabIndex = 14
        Me.MetroLabel7.Text = "Discount:"
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
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(4, 229)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(65, 19)
        Me.MetroLabel8.TabIndex = 12
        Me.MetroLabel8.Text = "Sub Total:"
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
        Me.MetroLabel5.Size = New System.Drawing.Size(74, 19)
        Me.MetroLabel5.TabIndex = 10
        Me.MetroLabel5.Text = "Total Items:"
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
        Me.MetroLabel4.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel4.TabIndex = 8
        Me.MetroLabel4.Text = "Date:"
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
        Me.MetroLabel3.Size = New System.Drawing.Size(106, 19)
        Me.MetroLabel3.TabIndex = 6
        Me.MetroLabel3.Text = "Invoice Number:"
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
        'tabBillingList
        '
        Me.tabBillingList.Controls.Add(Me.ListView2)
        Me.tabBillingList.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tabBillingList.HorizontalScrollbarBarColor = True
        Me.tabBillingList.HorizontalScrollbarHighlightOnWheel = False
        Me.tabBillingList.HorizontalScrollbarSize = 10
        Me.tabBillingList.Location = New System.Drawing.Point(4, 38)
        Me.tabBillingList.Name = "tabBillingList"
        Me.tabBillingList.Size = New System.Drawing.Size(1046, 499)
        Me.tabBillingList.TabIndex = 1
        Me.tabBillingList.Text = "Billing List"
        Me.tabBillingList.VerticalScrollbarBarColor = True
        Me.tabBillingList.VerticalScrollbarHighlightOnWheel = False
        Me.tabBillingList.VerticalScrollbarSize = 10
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9})
        Me.ListView2.FullRowSelect = True
        Me.ListView2.Location = New System.Drawing.Point(3, 3)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(1044, 435)
        Me.ListView2.TabIndex = 4
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Billing ID"
        Me.ColumnHeader6.Width = 93
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Patient ID"
        Me.ColumnHeader7.Width = 94
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Patient Name"
        Me.ColumnHeader8.Width = 112
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "Bill Date"
        Me.ColumnHeader9.Width = 90
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.tabPOS)
        Me.MetroTabControl1.Controls.Add(Me.tabBillingList)
        Me.MetroTabControl1.Location = New System.Drawing.Point(0, 1)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(1054, 542)
        Me.MetroTabControl1.TabIndex = 6
        Me.MetroTabControl1.UseSelectable = True
        '
        'frmBillingManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Name = "frmBillingManagement"
        Me.Size = New System.Drawing.Size(1054, 543)
        Me.tabPOS.ResumeLayout(False)
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        Me.tabBillingList.ResumeLayout(False)
        Me.MetroTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents ColumnHeader5 As ColumnHeader
    Public WithEvents ColumnHeader3 As ColumnHeader
    Public WithEvents tabPOS As MetroFramework.Controls.MetroTabPage
    Public WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Public WithEvents btnPrintBillingStatement As MetroFramework.Controls.MetroButton
    Public WithEvents btnPayment As MetroFramework.Controls.MetroButton
    Public WithEvents btnSave As MetroFramework.Controls.MetroButton
    Public WithEvents btnAddItem As MetroFramework.Controls.MetroButton
    Public WithEvents btnDoctorsFee As MetroFramework.Controls.MetroButton
    Public WithEvents btnSelectPatient As MetroFramework.Controls.MetroButton
    Public WithEvents listBilling As ListView
    Public WithEvents ColumnHeader1 As ColumnHeader
    Public WithEvents ColumnHeader2 As ColumnHeader
    Public WithEvents ColumnHeader4 As ColumnHeader
    Public WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Public WithEvents txtTotalAmount As MetroFramework.Controls.MetroTextBox
    Public WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Public WithEvents txtDiscount As MetroFramework.Controls.MetroTextBox
    Public WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Public WithEvents txtSubTotal As MetroFramework.Controls.MetroTextBox
    Public WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Public WithEvents txtTotalItems As MetroFramework.Controls.MetroTextBox
    Public WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Public WithEvents txtDate As MetroFramework.Controls.MetroTextBox
    Public WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Public WithEvents txtInvoiceNumber As MetroFramework.Controls.MetroTextBox
    Public WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Public WithEvents txtPatientName As MetroFramework.Controls.MetroTextBox
    Public WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Public WithEvents txtPatientID As MetroFramework.Controls.MetroTextBox
    Public WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Public WithEvents tabBillingList As MetroFramework.Controls.MetroTabPage
    Public WithEvents ListView2 As ListView
    Public WithEvents ColumnHeader6 As ColumnHeader
    Public WithEvents ColumnHeader7 As ColumnHeader
    Public WithEvents ColumnHeader8 As ColumnHeader
    Public WithEvents ColumnHeader9 As ColumnHeader
    Public WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
End Class
