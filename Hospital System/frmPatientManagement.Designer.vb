<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPatientManagement
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
        Me.components = New System.ComponentModel.Container()
        Me.MetroLabel25 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel1 = New MetroFramework.Controls.MetroPanel()
        Me.txtBloodGroup = New MetroFramework.Controls.MetroTextBox()
        Me.txtReligion = New MetroFramework.Controls.MetroTextBox()
        Me.txtCivilStatus = New MetroFramework.Controls.MetroTextBox()
        Me.txtGender = New MetroFramework.Controls.MetroTextBox()
        Me.txtBirthPlace = New MetroFramework.Controls.MetroTextBox()
        Me.txtBirthday = New MetroFramework.Controls.MetroTextBox()
        Me.txtMothersName = New MetroFramework.Controls.MetroTextBox()
        Me.txtFathersName = New MetroFramework.Controls.MetroTextBox()
        Me.txtMiddleName = New MetroFramework.Controls.MetroTextBox()
        Me.txtFirstName = New MetroFramework.Controls.MetroTextBox()
        Me.txtLastName = New MetroFramework.Controls.MetroTextBox()
        Me.txtPatientID = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel13 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel12 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel11 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel10 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel9 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel8 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel7 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel4 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel26 = New MetroFramework.Controls.MetroLabel()
        Me.txtInsuranceCompany = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.btnModifyPatient = New MetroFramework.Controls.MetroButton()
        Me.colPatientNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPatientLastName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPatientFirstName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPatientGender = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPatientRegistrationDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtPatientID1 = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.txtPatientName = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.txtRoomNumber = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.txtBedNumber = New MetroFramework.Components.MetroStyleManager(Me.components)
        Me.tabPatientMaster = New MetroFramework.Controls.MetroTabPage()
        Me.listPatientMaster = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPatientAge = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAction = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colDateAdmit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MetroLabel15 = New MetroFramework.Controls.MetroLabel()
        Me.colUnOccupiedBeds = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colOccupiedBeds = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTotalBeds = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colRoomType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colRoomNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MetroPanel4 = New MetroFramework.Controls.MetroPanel()
        Me.MetroTextBox21 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox20 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox19 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroTextBox18 = New MetroFramework.Controls.MetroTextBox()
        Me.txtPatientID2 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel19 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel20 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel21 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel24 = New MetroFramework.Controls.MetroLabel()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.tabAddPatient = New MetroFramework.Controls.MetroTabPage()
        Me.btnAddPatient = New MetroFramework.Controls.MetroButton()
        Me.MetroLabel14 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel3 = New MetroFramework.Controls.MetroPanel()
        Me.txtInsuranceCompany1 = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel30 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel31 = New MetroFramework.Controls.MetroLabel()
        Me.MetroPanel2 = New MetroFramework.Controls.MetroPanel()
        Me.txtPhoneNumber2 = New MetroFramework.Controls.MetroTextBox()
        Me.txtPhoneNumber1 = New MetroFramework.Controls.MetroTextBox()
        Me.txtAddress = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel22 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel23 = New MetroFramework.Controls.MetroLabel()
        Me.tabAdmitPatient = New MetroFramework.Controls.MetroTabPage()
        Me.btnAdmitPatient = New MetroFramework.Controls.MetroButton()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.colBedNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPatientID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPatientName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnCheckStatus = New MetroFramework.Controls.MetroButton()
        Me.listRoom = New System.Windows.Forms.ListView()
        Me.MetroPanel1.SuspendLayout()
        CType(Me.txtInsuranceCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPatientID1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPatientName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRoomNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBedNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPatientMaster.SuspendLayout()
        Me.MetroPanel4.SuspendLayout()
        Me.MetroTabControl1.SuspendLayout()
        Me.tabAddPatient.SuspendLayout()
        Me.MetroPanel3.SuspendLayout()
        Me.MetroPanel2.SuspendLayout()
        Me.tabAdmitPatient.SuspendLayout()
        Me.SuspendLayout()
        '
        'MetroLabel25
        '
        Me.MetroLabel25.AutoSize = True
        Me.MetroLabel25.Location = New System.Drawing.Point(4, 37)
        Me.MetroLabel25.Name = "MetroLabel25"
        Me.MetroLabel25.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel25.TabIndex = 3
        Me.MetroLabel25.Text = "Address:"
        '
        'MetroPanel1
        '
        Me.MetroPanel1.Controls.Add(Me.txtBloodGroup)
        Me.MetroPanel1.Controls.Add(Me.txtReligion)
        Me.MetroPanel1.Controls.Add(Me.txtCivilStatus)
        Me.MetroPanel1.Controls.Add(Me.txtGender)
        Me.MetroPanel1.Controls.Add(Me.txtBirthPlace)
        Me.MetroPanel1.Controls.Add(Me.txtBirthday)
        Me.MetroPanel1.Controls.Add(Me.txtMothersName)
        Me.MetroPanel1.Controls.Add(Me.txtFathersName)
        Me.MetroPanel1.Controls.Add(Me.txtMiddleName)
        Me.MetroPanel1.Controls.Add(Me.txtFirstName)
        Me.MetroPanel1.Controls.Add(Me.txtLastName)
        Me.MetroPanel1.Controls.Add(Me.txtPatientID)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel13)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel12)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel11)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel10)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel9)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel8)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel7)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel6)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel5)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel4)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel3)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel2)
        Me.MetroPanel1.Controls.Add(Me.MetroLabel1)
        Me.MetroPanel1.HorizontalScrollbarBarColor = True
        Me.MetroPanel1.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.HorizontalScrollbarSize = 10
        Me.MetroPanel1.Location = New System.Drawing.Point(0, 29)
        Me.MetroPanel1.Name = "MetroPanel1"
        Me.MetroPanel1.Size = New System.Drawing.Size(353, 422)
        Me.MetroPanel1.TabIndex = 2
        Me.MetroPanel1.VerticalScrollbarBarColor = True
        Me.MetroPanel1.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel1.VerticalScrollbarSize = 10
        '
        'txtBloodGroup
        '
        '
        '
        '
        Me.txtBloodGroup.CustomButton.Image = Nothing
        Me.txtBloodGroup.CustomButton.Location = New System.Drawing.Point(199, 1)
        Me.txtBloodGroup.CustomButton.Name = ""
        Me.txtBloodGroup.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBloodGroup.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBloodGroup.CustomButton.TabIndex = 1
        Me.txtBloodGroup.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBloodGroup.CustomButton.UseSelectable = True
        Me.txtBloodGroup.CustomButton.Visible = False
        Me.txtBloodGroup.Lines = New String(-1) {}
        Me.txtBloodGroup.Location = New System.Drawing.Point(120, 356)
        Me.txtBloodGroup.MaxLength = 32767
        Me.txtBloodGroup.Name = "txtBloodGroup"
        Me.txtBloodGroup.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBloodGroup.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBloodGroup.SelectedText = ""
        Me.txtBloodGroup.SelectionLength = 0
        Me.txtBloodGroup.SelectionStart = 0
        Me.txtBloodGroup.ShortcutsEnabled = True
        Me.txtBloodGroup.Size = New System.Drawing.Size(221, 23)
        Me.txtBloodGroup.TabIndex = 37
        Me.txtBloodGroup.UseSelectable = True
        Me.txtBloodGroup.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBloodGroup.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtReligion
        '
        '
        '
        '
        Me.txtReligion.CustomButton.Image = Nothing
        Me.txtReligion.CustomButton.Location = New System.Drawing.Point(199, 1)
        Me.txtReligion.CustomButton.Name = ""
        Me.txtReligion.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtReligion.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtReligion.CustomButton.TabIndex = 1
        Me.txtReligion.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtReligion.CustomButton.UseSelectable = True
        Me.txtReligion.CustomButton.Visible = False
        Me.txtReligion.Lines = New String(-1) {}
        Me.txtReligion.Location = New System.Drawing.Point(120, 327)
        Me.txtReligion.MaxLength = 32767
        Me.txtReligion.Name = "txtReligion"
        Me.txtReligion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReligion.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtReligion.SelectedText = ""
        Me.txtReligion.SelectionLength = 0
        Me.txtReligion.SelectionStart = 0
        Me.txtReligion.ShortcutsEnabled = True
        Me.txtReligion.Size = New System.Drawing.Size(221, 23)
        Me.txtReligion.TabIndex = 36
        Me.txtReligion.UseSelectable = True
        Me.txtReligion.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtReligion.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtCivilStatus
        '
        '
        '
        '
        Me.txtCivilStatus.CustomButton.Image = Nothing
        Me.txtCivilStatus.CustomButton.Location = New System.Drawing.Point(199, 1)
        Me.txtCivilStatus.CustomButton.Name = ""
        Me.txtCivilStatus.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtCivilStatus.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtCivilStatus.CustomButton.TabIndex = 1
        Me.txtCivilStatus.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtCivilStatus.CustomButton.UseSelectable = True
        Me.txtCivilStatus.CustomButton.Visible = False
        Me.txtCivilStatus.Lines = New String(-1) {}
        Me.txtCivilStatus.Location = New System.Drawing.Point(120, 298)
        Me.txtCivilStatus.MaxLength = 32767
        Me.txtCivilStatus.Name = "txtCivilStatus"
        Me.txtCivilStatus.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtCivilStatus.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtCivilStatus.SelectedText = ""
        Me.txtCivilStatus.SelectionLength = 0
        Me.txtCivilStatus.SelectionStart = 0
        Me.txtCivilStatus.ShortcutsEnabled = True
        Me.txtCivilStatus.Size = New System.Drawing.Size(221, 23)
        Me.txtCivilStatus.TabIndex = 35
        Me.txtCivilStatus.UseSelectable = True
        Me.txtCivilStatus.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtCivilStatus.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtGender
        '
        '
        '
        '
        Me.txtGender.CustomButton.Image = Nothing
        Me.txtGender.CustomButton.Location = New System.Drawing.Point(199, 1)
        Me.txtGender.CustomButton.Name = ""
        Me.txtGender.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtGender.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtGender.CustomButton.TabIndex = 1
        Me.txtGender.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtGender.CustomButton.UseSelectable = True
        Me.txtGender.CustomButton.Visible = False
        Me.txtGender.Lines = New String(-1) {}
        Me.txtGender.Location = New System.Drawing.Point(120, 269)
        Me.txtGender.MaxLength = 32767
        Me.txtGender.Name = "txtGender"
        Me.txtGender.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGender.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtGender.SelectedText = ""
        Me.txtGender.SelectionLength = 0
        Me.txtGender.SelectionStart = 0
        Me.txtGender.ShortcutsEnabled = True
        Me.txtGender.Size = New System.Drawing.Size(221, 23)
        Me.txtGender.TabIndex = 34
        Me.txtGender.UseSelectable = True
        Me.txtGender.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtGender.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtBirthPlace
        '
        '
        '
        '
        Me.txtBirthPlace.CustomButton.Image = Nothing
        Me.txtBirthPlace.CustomButton.Location = New System.Drawing.Point(199, 1)
        Me.txtBirthPlace.CustomButton.Name = ""
        Me.txtBirthPlace.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBirthPlace.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBirthPlace.CustomButton.TabIndex = 1
        Me.txtBirthPlace.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBirthPlace.CustomButton.UseSelectable = True
        Me.txtBirthPlace.CustomButton.Visible = False
        Me.txtBirthPlace.Lines = New String(-1) {}
        Me.txtBirthPlace.Location = New System.Drawing.Point(120, 240)
        Me.txtBirthPlace.MaxLength = 32767
        Me.txtBirthPlace.Name = "txtBirthPlace"
        Me.txtBirthPlace.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBirthPlace.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBirthPlace.SelectedText = ""
        Me.txtBirthPlace.SelectionLength = 0
        Me.txtBirthPlace.SelectionStart = 0
        Me.txtBirthPlace.ShortcutsEnabled = True
        Me.txtBirthPlace.Size = New System.Drawing.Size(221, 23)
        Me.txtBirthPlace.TabIndex = 33
        Me.txtBirthPlace.UseSelectable = True
        Me.txtBirthPlace.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBirthPlace.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtBirthday
        '
        '
        '
        '
        Me.txtBirthday.CustomButton.Image = Nothing
        Me.txtBirthday.CustomButton.Location = New System.Drawing.Point(199, 1)
        Me.txtBirthday.CustomButton.Name = ""
        Me.txtBirthday.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtBirthday.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBirthday.CustomButton.TabIndex = 1
        Me.txtBirthday.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBirthday.CustomButton.UseSelectable = True
        Me.txtBirthday.CustomButton.Visible = False
        Me.txtBirthday.Lines = New String(-1) {}
        Me.txtBirthday.Location = New System.Drawing.Point(120, 211)
        Me.txtBirthday.MaxLength = 32767
        Me.txtBirthday.Name = "txtBirthday"
        Me.txtBirthday.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBirthday.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBirthday.SelectedText = ""
        Me.txtBirthday.SelectionLength = 0
        Me.txtBirthday.SelectionStart = 0
        Me.txtBirthday.ShortcutsEnabled = True
        Me.txtBirthday.Size = New System.Drawing.Size(221, 23)
        Me.txtBirthday.TabIndex = 32
        Me.txtBirthday.UseSelectable = True
        Me.txtBirthday.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBirthday.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtMothersName
        '
        '
        '
        '
        Me.txtMothersName.CustomButton.Image = Nothing
        Me.txtMothersName.CustomButton.Location = New System.Drawing.Point(199, 1)
        Me.txtMothersName.CustomButton.Name = ""
        Me.txtMothersName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtMothersName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMothersName.CustomButton.TabIndex = 1
        Me.txtMothersName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMothersName.CustomButton.UseSelectable = True
        Me.txtMothersName.CustomButton.Visible = False
        Me.txtMothersName.Lines = New String(-1) {}
        Me.txtMothersName.Location = New System.Drawing.Point(120, 182)
        Me.txtMothersName.MaxLength = 32767
        Me.txtMothersName.Name = "txtMothersName"
        Me.txtMothersName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMothersName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMothersName.SelectedText = ""
        Me.txtMothersName.SelectionLength = 0
        Me.txtMothersName.SelectionStart = 0
        Me.txtMothersName.ShortcutsEnabled = True
        Me.txtMothersName.Size = New System.Drawing.Size(221, 23)
        Me.txtMothersName.TabIndex = 31
        Me.txtMothersName.UseSelectable = True
        Me.txtMothersName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMothersName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtFathersName
        '
        '
        '
        '
        Me.txtFathersName.CustomButton.Image = Nothing
        Me.txtFathersName.CustomButton.Location = New System.Drawing.Point(199, 1)
        Me.txtFathersName.CustomButton.Name = ""
        Me.txtFathersName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtFathersName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFathersName.CustomButton.TabIndex = 1
        Me.txtFathersName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFathersName.CustomButton.UseSelectable = True
        Me.txtFathersName.CustomButton.Visible = False
        Me.txtFathersName.Lines = New String(-1) {}
        Me.txtFathersName.Location = New System.Drawing.Point(120, 152)
        Me.txtFathersName.MaxLength = 32767
        Me.txtFathersName.Name = "txtFathersName"
        Me.txtFathersName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFathersName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFathersName.SelectedText = ""
        Me.txtFathersName.SelectionLength = 0
        Me.txtFathersName.SelectionStart = 0
        Me.txtFathersName.ShortcutsEnabled = True
        Me.txtFathersName.Size = New System.Drawing.Size(221, 23)
        Me.txtFathersName.TabIndex = 30
        Me.txtFathersName.UseSelectable = True
        Me.txtFathersName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFathersName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtMiddleName
        '
        '
        '
        '
        Me.txtMiddleName.CustomButton.Image = Nothing
        Me.txtMiddleName.CustomButton.Location = New System.Drawing.Point(199, 1)
        Me.txtMiddleName.CustomButton.Name = ""
        Me.txtMiddleName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtMiddleName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtMiddleName.CustomButton.TabIndex = 1
        Me.txtMiddleName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtMiddleName.CustomButton.UseSelectable = True
        Me.txtMiddleName.CustomButton.Visible = False
        Me.txtMiddleName.Lines = New String(-1) {}
        Me.txtMiddleName.Location = New System.Drawing.Point(120, 123)
        Me.txtMiddleName.MaxLength = 32767
        Me.txtMiddleName.Name = "txtMiddleName"
        Me.txtMiddleName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtMiddleName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtMiddleName.SelectedText = ""
        Me.txtMiddleName.SelectionLength = 0
        Me.txtMiddleName.SelectionStart = 0
        Me.txtMiddleName.ShortcutsEnabled = True
        Me.txtMiddleName.Size = New System.Drawing.Size(221, 23)
        Me.txtMiddleName.TabIndex = 29
        Me.txtMiddleName.UseSelectable = True
        Me.txtMiddleName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtMiddleName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtFirstName
        '
        '
        '
        '
        Me.txtFirstName.CustomButton.Image = Nothing
        Me.txtFirstName.CustomButton.Location = New System.Drawing.Point(199, 1)
        Me.txtFirstName.CustomButton.Name = ""
        Me.txtFirstName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtFirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFirstName.CustomButton.TabIndex = 1
        Me.txtFirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFirstName.CustomButton.UseSelectable = True
        Me.txtFirstName.CustomButton.Visible = False
        Me.txtFirstName.Lines = New String(-1) {}
        Me.txtFirstName.Location = New System.Drawing.Point(120, 93)
        Me.txtFirstName.MaxLength = 32767
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFirstName.SelectedText = ""
        Me.txtFirstName.SelectionLength = 0
        Me.txtFirstName.SelectionStart = 0
        Me.txtFirstName.ShortcutsEnabled = True
        Me.txtFirstName.Size = New System.Drawing.Size(221, 23)
        Me.txtFirstName.TabIndex = 28
        Me.txtFirstName.UseSelectable = True
        Me.txtFirstName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFirstName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtLastName
        '
        '
        '
        '
        Me.txtLastName.CustomButton.Image = Nothing
        Me.txtLastName.CustomButton.Location = New System.Drawing.Point(199, 1)
        Me.txtLastName.CustomButton.Name = ""
        Me.txtLastName.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtLastName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtLastName.CustomButton.TabIndex = 1
        Me.txtLastName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtLastName.CustomButton.UseSelectable = True
        Me.txtLastName.CustomButton.Visible = False
        Me.txtLastName.Lines = New String(-1) {}
        Me.txtLastName.Location = New System.Drawing.Point(120, 63)
        Me.txtLastName.MaxLength = 32767
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtLastName.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtLastName.SelectedText = ""
        Me.txtLastName.SelectionLength = 0
        Me.txtLastName.SelectionStart = 0
        Me.txtLastName.ShortcutsEnabled = True
        Me.txtLastName.Size = New System.Drawing.Size(221, 23)
        Me.txtLastName.TabIndex = 27
        Me.txtLastName.UseSelectable = True
        Me.txtLastName.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtLastName.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPatientID
        '
        Me.txtPatientID.BackColor = System.Drawing.SystemColors.Control
        '
        '
        '
        Me.txtPatientID.CustomButton.Image = Nothing
        Me.txtPatientID.CustomButton.Location = New System.Drawing.Point(199, 1)
        Me.txtPatientID.CustomButton.Name = ""
        Me.txtPatientID.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPatientID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPatientID.CustomButton.TabIndex = 1
        Me.txtPatientID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPatientID.CustomButton.UseSelectable = True
        Me.txtPatientID.CustomButton.Visible = False
        Me.txtPatientID.Enabled = False
        Me.txtPatientID.ForeColor = System.Drawing.Color.DimGray
        Me.txtPatientID.Lines = New String(-1) {}
        Me.txtPatientID.Location = New System.Drawing.Point(120, 33)
        Me.txtPatientID.MaxLength = 32767
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPatientID.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPatientID.SelectedText = ""
        Me.txtPatientID.SelectionLength = 0
        Me.txtPatientID.SelectionStart = 0
        Me.txtPatientID.ShortcutsEnabled = True
        Me.txtPatientID.Size = New System.Drawing.Size(221, 23)
        Me.txtPatientID.TabIndex = 26
        Me.txtPatientID.UseSelectable = True
        Me.txtPatientID.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPatientID.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel13
        '
        Me.MetroLabel13.AutoSize = True
        Me.MetroLabel13.Location = New System.Drawing.Point(4, 356)
        Me.MetroLabel13.Name = "MetroLabel13"
        Me.MetroLabel13.Size = New System.Drawing.Size(88, 19)
        Me.MetroLabel13.TabIndex = 25
        Me.MetroLabel13.Text = "Blood Group:"
        '
        'MetroLabel12
        '
        Me.MetroLabel12.AutoSize = True
        Me.MetroLabel12.Location = New System.Drawing.Point(4, 327)
        Me.MetroLabel12.Name = "MetroLabel12"
        Me.MetroLabel12.Size = New System.Drawing.Size(59, 19)
        Me.MetroLabel12.TabIndex = 23
        Me.MetroLabel12.Text = "Religion:"
        '
        'MetroLabel11
        '
        Me.MetroLabel11.AutoSize = True
        Me.MetroLabel11.Location = New System.Drawing.Point(4, 298)
        Me.MetroLabel11.Name = "MetroLabel11"
        Me.MetroLabel11.Size = New System.Drawing.Size(74, 19)
        Me.MetroLabel11.TabIndex = 21
        Me.MetroLabel11.Text = "Civil Status:"
        '
        'MetroLabel10
        '
        Me.MetroLabel10.AutoSize = True
        Me.MetroLabel10.Location = New System.Drawing.Point(4, 269)
        Me.MetroLabel10.Name = "MetroLabel10"
        Me.MetroLabel10.Size = New System.Drawing.Size(56, 19)
        Me.MetroLabel10.TabIndex = 19
        Me.MetroLabel10.Text = "Gender:"
        '
        'MetroLabel9
        '
        Me.MetroLabel9.AutoSize = True
        Me.MetroLabel9.Location = New System.Drawing.Point(4, 240)
        Me.MetroLabel9.Name = "MetroLabel9"
        Me.MetroLabel9.Size = New System.Drawing.Size(75, 19)
        Me.MetroLabel9.TabIndex = 17
        Me.MetroLabel9.Text = "Birth Place:"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.Location = New System.Drawing.Point(4, 211)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(61, 19)
        Me.MetroLabel8.TabIndex = 15
        Me.MetroLabel8.Text = "Birthday:"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.Location = New System.Drawing.Point(4, 182)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(112, 19)
        Me.MetroLabel7.TabIndex = 13
        Me.MetroLabel7.Text = "Mother's Name: *"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(4, 153)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(105, 19)
        Me.MetroLabel6.TabIndex = 11
        Me.MetroLabel6.Text = "Father's Name: *"
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(4, 124)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(103, 19)
        Me.MetroLabel5.TabIndex = 9
        Me.MetroLabel5.Text = "Middle Name: *"
        '
        'MetroLabel4
        '
        Me.MetroLabel4.AutoSize = True
        Me.MetroLabel4.Location = New System.Drawing.Point(4, 95)
        Me.MetroLabel4.Name = "MetroLabel4"
        Me.MetroLabel4.Size = New System.Drawing.Size(86, 19)
        Me.MetroLabel4.TabIndex = 7
        Me.MetroLabel4.Text = "First Name: *"
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(4, 66)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(84, 19)
        Me.MetroLabel3.TabIndex = 5
        Me.MetroLabel3.Text = "Last Name: *"
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(4, 37)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(67, 19)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "Patient ID:"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel1.Location = New System.Drawing.Point(4, 4)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(150, 19)
        Me.MetroLabel1.TabIndex = 2
        Me.MetroLabel1.Text = "Personal Information"
        '
        'MetroLabel26
        '
        Me.MetroLabel26.AutoSize = True
        Me.MetroLabel26.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel26.Location = New System.Drawing.Point(4, 4)
        Me.MetroLabel26.Name = "MetroLabel26"
        Me.MetroLabel26.Size = New System.Drawing.Size(143, 19)
        Me.MetroLabel26.TabIndex = 2
        Me.MetroLabel26.Text = "Contact Information"
        '
        'txtInsuranceCompany
        '
        Me.txtInsuranceCompany.Owner = Nothing
        '
        'btnModifyPatient
        '
        Me.btnModifyPatient.Location = New System.Drawing.Point(909, 470)
        Me.btnModifyPatient.Name = "btnModifyPatient"
        Me.btnModifyPatient.Size = New System.Drawing.Size(134, 23)
        Me.btnModifyPatient.TabIndex = 3
        Me.btnModifyPatient.Text = "Modify Patient"
        Me.btnModifyPatient.UseSelectable = True
        '
        'colPatientNumber
        '
        Me.colPatientNumber.Text = "Patient Number"
        Me.colPatientNumber.Width = 143
        '
        'colPatientLastName
        '
        Me.colPatientLastName.Text = "Last Name"
        Me.colPatientLastName.Width = 124
        '
        'colPatientFirstName
        '
        Me.colPatientFirstName.Text = "First Name"
        Me.colPatientFirstName.Width = 134
        '
        'colPatientGender
        '
        Me.colPatientGender.Text = "Patient Gender"
        Me.colPatientGender.Width = 141
        '
        'colPatientRegistrationDate
        '
        Me.colPatientRegistrationDate.Text = "Patient Registration Date"
        Me.colPatientRegistrationDate.Width = 202
        '
        'txtPatientID1
        '
        Me.txtPatientID1.Owner = Nothing
        '
        'txtPatientName
        '
        Me.txtPatientName.Owner = Nothing
        '
        'txtRoomNumber
        '
        Me.txtRoomNumber.Owner = Nothing
        '
        'txtBedNumber
        '
        Me.txtBedNumber.Owner = Nothing
        '
        'tabPatientMaster
        '
        Me.tabPatientMaster.Controls.Add(Me.listPatientMaster)
        Me.tabPatientMaster.Controls.Add(Me.btnModifyPatient)
        Me.tabPatientMaster.HorizontalScrollbarBarColor = True
        Me.tabPatientMaster.HorizontalScrollbarHighlightOnWheel = False
        Me.tabPatientMaster.HorizontalScrollbarSize = 10
        Me.tabPatientMaster.Location = New System.Drawing.Point(4, 38)
        Me.tabPatientMaster.Name = "tabPatientMaster"
        Me.tabPatientMaster.Size = New System.Drawing.Size(1192, 597)
        Me.tabPatientMaster.TabIndex = 1
        Me.tabPatientMaster.Text = "Patient Master"
        Me.tabPatientMaster.VerticalScrollbarBarColor = True
        Me.tabPatientMaster.VerticalScrollbarHighlightOnWheel = False
        Me.tabPatientMaster.VerticalScrollbarSize = 10
        '
        'listPatientMaster
        '
        Me.listPatientMaster.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.colPatientAge, Me.ColumnHeader5, Me.colAction})
        Me.listPatientMaster.FullRowSelect = True
        Me.listPatientMaster.GridLines = True
        Me.listPatientMaster.HideSelection = False
        Me.listPatientMaster.Location = New System.Drawing.Point(4, 2)
        Me.listPatientMaster.Name = "listPatientMaster"
        Me.listPatientMaster.Size = New System.Drawing.Size(1039, 462)
        Me.listPatientMaster.TabIndex = 4
        Me.listPatientMaster.UseCompatibleStateImageBehavior = False
        Me.listPatientMaster.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Patient Number"
        Me.ColumnHeader1.Width = 143
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Last Name"
        Me.ColumnHeader2.Width = 124
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "First Name"
        Me.ColumnHeader3.Width = 134
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Patient Gender"
        Me.ColumnHeader4.Width = 141
        '
        'colPatientAge
        '
        Me.colPatientAge.Text = "Patient Age"
        Me.colPatientAge.Width = 207
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Patient Registration Date"
        Me.ColumnHeader5.Width = 202
        '
        'colAction
        '
        Me.colAction.Text = "Action"
        '
        'colDateAdmit
        '
        Me.colDateAdmit.Text = "Date Admit"
        Me.colDateAdmit.Width = 136
        '
        'MetroLabel15
        '
        Me.MetroLabel15.AutoSize = True
        Me.MetroLabel15.Location = New System.Drawing.Point(4, 181)
        Me.MetroLabel15.Name = "MetroLabel15"
        Me.MetroLabel15.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel15.TabIndex = 10
        Me.MetroLabel15.Text = "Date:"
        '
        'colUnOccupiedBeds
        '
        Me.colUnOccupiedBeds.Text = "UnOccupied Beds"
        Me.colUnOccupiedBeds.Width = 168
        '
        'colOccupiedBeds
        '
        Me.colOccupiedBeds.Text = "Occupied Beds"
        Me.colOccupiedBeds.Width = 136
        '
        'colTotalBeds
        '
        Me.colTotalBeds.Text = "Total Beds"
        Me.colTotalBeds.Width = 125
        '
        'colRoomType
        '
        Me.colRoomType.Text = "Room Type"
        Me.colRoomType.Width = 145
        '
        'colRoomNumber
        '
        Me.colRoomNumber.Text = "Room Number"
        Me.colRoomNumber.Width = 109
        '
        'MetroPanel4
        '
        Me.MetroPanel4.Controls.Add(Me.MetroTextBox21)
        Me.MetroPanel4.Controls.Add(Me.MetroTextBox20)
        Me.MetroPanel4.Controls.Add(Me.MetroTextBox19)
        Me.MetroPanel4.Controls.Add(Me.MetroTextBox18)
        Me.MetroPanel4.Controls.Add(Me.txtPatientID2)
        Me.MetroPanel4.Controls.Add(Me.MetroLabel15)
        Me.MetroPanel4.Controls.Add(Me.MetroLabel19)
        Me.MetroPanel4.Controls.Add(Me.MetroLabel20)
        Me.MetroPanel4.Controls.Add(Me.MetroLabel21)
        Me.MetroPanel4.Controls.Add(Me.MetroLabel24)
        Me.MetroPanel4.HorizontalScrollbarBarColor = True
        Me.MetroPanel4.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel4.HorizontalScrollbarSize = 10
        Me.MetroPanel4.Location = New System.Drawing.Point(2, 2)
        Me.MetroPanel4.Name = "MetroPanel4"
        Me.MetroPanel4.Size = New System.Drawing.Size(281, 496)
        Me.MetroPanel4.TabIndex = 3
        Me.MetroPanel4.VerticalScrollbarBarColor = True
        Me.MetroPanel4.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel4.VerticalScrollbarSize = 10
        '
        'MetroTextBox21
        '
        '
        '
        '
        Me.MetroTextBox21.CustomButton.Image = Nothing
        Me.MetroTextBox21.CustomButton.Location = New System.Drawing.Point(240, 1)
        Me.MetroTextBox21.CustomButton.Name = ""
        Me.MetroTextBox21.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox21.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox21.CustomButton.TabIndex = 1
        Me.MetroTextBox21.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox21.CustomButton.UseSelectable = True
        Me.MetroTextBox21.CustomButton.Visible = False
        Me.MetroTextBox21.Lines = New String(-1) {}
        Me.MetroTextBox21.Location = New System.Drawing.Point(8, 203)
        Me.MetroTextBox21.MaxLength = 32767
        Me.MetroTextBox21.Name = "MetroTextBox21"
        Me.MetroTextBox21.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox21.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox21.SelectedText = ""
        Me.MetroTextBox21.SelectionLength = 0
        Me.MetroTextBox21.SelectionStart = 0
        Me.MetroTextBox21.ShortcutsEnabled = True
        Me.MetroTextBox21.Size = New System.Drawing.Size(262, 23)
        Me.MetroTextBox21.TabIndex = 33
        Me.MetroTextBox21.UseSelectable = True
        Me.MetroTextBox21.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox21.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTextBox20
        '
        '
        '
        '
        Me.MetroTextBox20.CustomButton.Image = Nothing
        Me.MetroTextBox20.CustomButton.Location = New System.Drawing.Point(240, 1)
        Me.MetroTextBox20.CustomButton.Name = ""
        Me.MetroTextBox20.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox20.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox20.CustomButton.TabIndex = 1
        Me.MetroTextBox20.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox20.CustomButton.UseSelectable = True
        Me.MetroTextBox20.CustomButton.Visible = False
        Me.MetroTextBox20.Lines = New String(-1) {}
        Me.MetroTextBox20.Location = New System.Drawing.Point(8, 155)
        Me.MetroTextBox20.MaxLength = 32767
        Me.MetroTextBox20.Name = "MetroTextBox20"
        Me.MetroTextBox20.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox20.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox20.SelectedText = ""
        Me.MetroTextBox20.SelectionLength = 0
        Me.MetroTextBox20.SelectionStart = 0
        Me.MetroTextBox20.ShortcutsEnabled = True
        Me.MetroTextBox20.Size = New System.Drawing.Size(262, 23)
        Me.MetroTextBox20.TabIndex = 32
        Me.MetroTextBox20.UseSelectable = True
        Me.MetroTextBox20.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox20.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTextBox19
        '
        '
        '
        '
        Me.MetroTextBox19.CustomButton.Image = Nothing
        Me.MetroTextBox19.CustomButton.Location = New System.Drawing.Point(240, 1)
        Me.MetroTextBox19.CustomButton.Name = ""
        Me.MetroTextBox19.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox19.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox19.CustomButton.TabIndex = 1
        Me.MetroTextBox19.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox19.CustomButton.UseSelectable = True
        Me.MetroTextBox19.CustomButton.Visible = False
        Me.MetroTextBox19.Lines = New String(-1) {}
        Me.MetroTextBox19.Location = New System.Drawing.Point(8, 110)
        Me.MetroTextBox19.MaxLength = 32767
        Me.MetroTextBox19.Name = "MetroTextBox19"
        Me.MetroTextBox19.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox19.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox19.SelectedText = ""
        Me.MetroTextBox19.SelectionLength = 0
        Me.MetroTextBox19.SelectionStart = 0
        Me.MetroTextBox19.ShortcutsEnabled = True
        Me.MetroTextBox19.Size = New System.Drawing.Size(262, 23)
        Me.MetroTextBox19.TabIndex = 31
        Me.MetroTextBox19.UseSelectable = True
        Me.MetroTextBox19.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox19.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroTextBox18
        '
        '
        '
        '
        Me.MetroTextBox18.CustomButton.Image = Nothing
        Me.MetroTextBox18.CustomButton.Location = New System.Drawing.Point(240, 1)
        Me.MetroTextBox18.CustomButton.Name = ""
        Me.MetroTextBox18.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.MetroTextBox18.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.MetroTextBox18.CustomButton.TabIndex = 1
        Me.MetroTextBox18.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.MetroTextBox18.CustomButton.UseSelectable = True
        Me.MetroTextBox18.CustomButton.Visible = False
        Me.MetroTextBox18.Lines = New String(-1) {}
        Me.MetroTextBox18.Location = New System.Drawing.Point(8, 65)
        Me.MetroTextBox18.MaxLength = 32767
        Me.MetroTextBox18.Name = "MetroTextBox18"
        Me.MetroTextBox18.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextBox18.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.MetroTextBox18.SelectedText = ""
        Me.MetroTextBox18.SelectionLength = 0
        Me.MetroTextBox18.SelectionStart = 0
        Me.MetroTextBox18.ShortcutsEnabled = True
        Me.MetroTextBox18.Size = New System.Drawing.Size(262, 23)
        Me.MetroTextBox18.TabIndex = 30
        Me.MetroTextBox18.UseSelectable = True
        Me.MetroTextBox18.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.MetroTextBox18.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPatientID2
        '
        '
        '
        '
        Me.txtPatientID2.CustomButton.Image = Nothing
        Me.txtPatientID2.CustomButton.Location = New System.Drawing.Point(174, 1)
        Me.txtPatientID2.CustomButton.Name = ""
        Me.txtPatientID2.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPatientID2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPatientID2.CustomButton.TabIndex = 1
        Me.txtPatientID2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPatientID2.CustomButton.UseSelectable = True
        Me.txtPatientID2.CustomButton.Visible = False
        Me.txtPatientID2.Enabled = False
        Me.txtPatientID2.Lines = New String(-1) {}
        Me.txtPatientID2.Location = New System.Drawing.Point(74, 9)
        Me.txtPatientID2.MaxLength = 32767
        Me.txtPatientID2.Name = "txtPatientID2"
        Me.txtPatientID2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPatientID2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPatientID2.SelectedText = ""
        Me.txtPatientID2.SelectionLength = 0
        Me.txtPatientID2.SelectionStart = 0
        Me.txtPatientID2.ShortcutsEnabled = True
        Me.txtPatientID2.Size = New System.Drawing.Size(196, 23)
        Me.txtPatientID2.TabIndex = 29
        Me.txtPatientID2.UseSelectable = True
        Me.txtPatientID2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPatientID2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel19
        '
        Me.MetroLabel19.AutoSize = True
        Me.MetroLabel19.Location = New System.Drawing.Point(4, 133)
        Me.MetroLabel19.Name = "MetroLabel19"
        Me.MetroLabel19.Size = New System.Drawing.Size(89, 19)
        Me.MetroLabel19.TabIndex = 8
        Me.MetroLabel19.Text = "Bed Number:"
        '
        'MetroLabel20
        '
        Me.MetroLabel20.AutoSize = True
        Me.MetroLabel20.Location = New System.Drawing.Point(4, 88)
        Me.MetroLabel20.Name = "MetroLabel20"
        Me.MetroLabel20.Size = New System.Drawing.Size(102, 19)
        Me.MetroLabel20.TabIndex = 6
        Me.MetroLabel20.Text = "Room Number:"
        '
        'MetroLabel21
        '
        Me.MetroLabel21.AutoSize = True
        Me.MetroLabel21.Location = New System.Drawing.Point(4, 43)
        Me.MetroLabel21.Name = "MetroLabel21"
        Me.MetroLabel21.Size = New System.Drawing.Size(91, 19)
        Me.MetroLabel21.TabIndex = 4
        Me.MetroLabel21.Text = "Patient Name:"
        '
        'MetroLabel24
        '
        Me.MetroLabel24.AutoSize = True
        Me.MetroLabel24.Location = New System.Drawing.Point(4, 9)
        Me.MetroLabel24.Name = "MetroLabel24"
        Me.MetroLabel24.Size = New System.Drawing.Size(64, 19)
        Me.MetroLabel24.TabIndex = 2
        Me.MetroLabel24.Text = "Patient ID"
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.tabAddPatient)
        Me.MetroTabControl1.Controls.Add(Me.tabAdmitPatient)
        Me.MetroTabControl1.Controls.Add(Me.tabPatientMaster)
        Me.MetroTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(1200, 639)
        Me.MetroTabControl1.TabIndex = 5
        Me.MetroTabControl1.UseSelectable = True
        '
        'tabAddPatient
        '
        Me.tabAddPatient.Controls.Add(Me.btnAddPatient)
        Me.tabAddPatient.Controls.Add(Me.MetroLabel14)
        Me.tabAddPatient.Controls.Add(Me.MetroPanel3)
        Me.tabAddPatient.Controls.Add(Me.MetroPanel2)
        Me.tabAddPatient.Controls.Add(Me.MetroPanel1)
        Me.tabAddPatient.ForeColor = System.Drawing.SystemColors.ControlText
        Me.tabAddPatient.HorizontalScrollbarBarColor = True
        Me.tabAddPatient.HorizontalScrollbarHighlightOnWheel = False
        Me.tabAddPatient.HorizontalScrollbarSize = 10
        Me.tabAddPatient.Location = New System.Drawing.Point(4, 38)
        Me.tabAddPatient.Name = "tabAddPatient"
        Me.tabAddPatient.Size = New System.Drawing.Size(1192, 597)
        Me.tabAddPatient.TabIndex = 0
        Me.tabAddPatient.Text = "Add Patient"
        Me.tabAddPatient.VerticalScrollbarBarColor = True
        Me.tabAddPatient.VerticalScrollbarHighlightOnWheel = False
        Me.tabAddPatient.VerticalScrollbarSize = 10
        '
        'btnAddPatient
        '
        Me.btnAddPatient.Location = New System.Drawing.Point(874, 467)
        Me.btnAddPatient.Name = "btnAddPatient"
        Me.btnAddPatient.Size = New System.Drawing.Size(159, 23)
        Me.btnAddPatient.TabIndex = 30
        Me.btnAddPatient.Text = "Add Patient"
        Me.btnAddPatient.UseSelectable = True
        '
        'MetroLabel14
        '
        Me.MetroLabel14.AutoSize = True
        Me.MetroLabel14.Location = New System.Drawing.Point(0, 4)
        Me.MetroLabel14.Name = "MetroLabel14"
        Me.MetroLabel14.Size = New System.Drawing.Size(119, 19)
        Me.MetroLabel14.TabIndex = 29
        Me.MetroLabel14.Text = "Required fields = *"
        '
        'MetroPanel3
        '
        Me.MetroPanel3.Controls.Add(Me.txtInsuranceCompany1)
        Me.MetroPanel3.Controls.Add(Me.MetroLabel30)
        Me.MetroPanel3.Controls.Add(Me.MetroLabel31)
        Me.MetroPanel3.HorizontalScrollbarBarColor = True
        Me.MetroPanel3.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.HorizontalScrollbarSize = 10
        Me.MetroPanel3.Location = New System.Drawing.Point(707, 29)
        Me.MetroPanel3.Name = "MetroPanel3"
        Me.MetroPanel3.Size = New System.Drawing.Size(339, 422)
        Me.MetroPanel3.TabIndex = 28
        Me.MetroPanel3.VerticalScrollbarBarColor = True
        Me.MetroPanel3.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel3.VerticalScrollbarSize = 10
        '
        'txtInsuranceCompany1
        '
        '
        '
        '
        Me.txtInsuranceCompany1.CustomButton.Image = Nothing
        Me.txtInsuranceCompany1.CustomButton.Location = New System.Drawing.Point(164, 1)
        Me.txtInsuranceCompany1.CustomButton.Name = ""
        Me.txtInsuranceCompany1.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtInsuranceCompany1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtInsuranceCompany1.CustomButton.TabIndex = 1
        Me.txtInsuranceCompany1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtInsuranceCompany1.CustomButton.UseSelectable = True
        Me.txtInsuranceCompany1.CustomButton.Visible = False
        Me.txtInsuranceCompany1.Lines = New String(-1) {}
        Me.txtInsuranceCompany1.Location = New System.Drawing.Point(140, 33)
        Me.txtInsuranceCompany1.MaxLength = 32767
        Me.txtInsuranceCompany1.Name = "txtInsuranceCompany1"
        Me.txtInsuranceCompany1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtInsuranceCompany1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtInsuranceCompany1.SelectedText = ""
        Me.txtInsuranceCompany1.SelectionLength = 0
        Me.txtInsuranceCompany1.SelectionStart = 0
        Me.txtInsuranceCompany1.ShortcutsEnabled = True
        Me.txtInsuranceCompany1.Size = New System.Drawing.Size(186, 23)
        Me.txtInsuranceCompany1.TabIndex = 29
        Me.txtInsuranceCompany1.UseSelectable = True
        Me.txtInsuranceCompany1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtInsuranceCompany1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel30
        '
        Me.MetroLabel30.AutoSize = True
        Me.MetroLabel30.Location = New System.Drawing.Point(4, 37)
        Me.MetroLabel30.Name = "MetroLabel30"
        Me.MetroLabel30.Size = New System.Drawing.Size(127, 19)
        Me.MetroLabel30.TabIndex = 3
        Me.MetroLabel30.Text = "Insurance Company:"
        '
        'MetroLabel31
        '
        Me.MetroLabel31.AutoSize = True
        Me.MetroLabel31.FontWeight = MetroFramework.MetroLabelWeight.Bold
        Me.MetroLabel31.Location = New System.Drawing.Point(4, 4)
        Me.MetroLabel31.Name = "MetroLabel31"
        Me.MetroLabel31.Size = New System.Drawing.Size(130, 19)
        Me.MetroLabel31.TabIndex = 2
        Me.MetroLabel31.Text = "Other Information"
        '
        'MetroPanel2
        '
        Me.MetroPanel2.Controls.Add(Me.txtPhoneNumber2)
        Me.MetroPanel2.Controls.Add(Me.txtPhoneNumber1)
        Me.MetroPanel2.Controls.Add(Me.txtAddress)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel22)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel23)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel25)
        Me.MetroPanel2.Controls.Add(Me.MetroLabel26)
        Me.MetroPanel2.HorizontalScrollbarBarColor = True
        Me.MetroPanel2.HorizontalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.HorizontalScrollbarSize = 10
        Me.MetroPanel2.Location = New System.Drawing.Point(359, 29)
        Me.MetroPanel2.Name = "MetroPanel2"
        Me.MetroPanel2.Size = New System.Drawing.Size(342, 422)
        Me.MetroPanel2.TabIndex = 27
        Me.MetroPanel2.VerticalScrollbarBarColor = True
        Me.MetroPanel2.VerticalScrollbarHighlightOnWheel = False
        Me.MetroPanel2.VerticalScrollbarSize = 10
        '
        'txtPhoneNumber2
        '
        '
        '
        '
        Me.txtPhoneNumber2.CustomButton.Image = Nothing
        Me.txtPhoneNumber2.CustomButton.Location = New System.Drawing.Point(188, 1)
        Me.txtPhoneNumber2.CustomButton.Name = ""
        Me.txtPhoneNumber2.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPhoneNumber2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPhoneNumber2.CustomButton.TabIndex = 1
        Me.txtPhoneNumber2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPhoneNumber2.CustomButton.UseSelectable = True
        Me.txtPhoneNumber2.CustomButton.Visible = False
        Me.txtPhoneNumber2.Lines = New String(-1) {}
        Me.txtPhoneNumber2.Location = New System.Drawing.Point(120, 153)
        Me.txtPhoneNumber2.MaxLength = 32767
        Me.txtPhoneNumber2.Name = "txtPhoneNumber2"
        Me.txtPhoneNumber2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhoneNumber2.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPhoneNumber2.SelectedText = ""
        Me.txtPhoneNumber2.SelectionLength = 0
        Me.txtPhoneNumber2.SelectionStart = 0
        Me.txtPhoneNumber2.ShortcutsEnabled = True
        Me.txtPhoneNumber2.Size = New System.Drawing.Size(210, 23)
        Me.txtPhoneNumber2.TabIndex = 29
        Me.txtPhoneNumber2.UseSelectable = True
        Me.txtPhoneNumber2.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPhoneNumber2.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPhoneNumber1
        '
        '
        '
        '
        Me.txtPhoneNumber1.CustomButton.Image = Nothing
        Me.txtPhoneNumber1.CustomButton.Location = New System.Drawing.Point(188, 1)
        Me.txtPhoneNumber1.CustomButton.Name = ""
        Me.txtPhoneNumber1.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPhoneNumber1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPhoneNumber1.CustomButton.TabIndex = 1
        Me.txtPhoneNumber1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPhoneNumber1.CustomButton.UseSelectable = True
        Me.txtPhoneNumber1.CustomButton.Visible = False
        Me.txtPhoneNumber1.Lines = New String(-1) {}
        Me.txtPhoneNumber1.Location = New System.Drawing.Point(120, 123)
        Me.txtPhoneNumber1.MaxLength = 32767
        Me.txtPhoneNumber1.Name = "txtPhoneNumber1"
        Me.txtPhoneNumber1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPhoneNumber1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPhoneNumber1.SelectedText = ""
        Me.txtPhoneNumber1.SelectionLength = 0
        Me.txtPhoneNumber1.SelectionStart = 0
        Me.txtPhoneNumber1.ShortcutsEnabled = True
        Me.txtPhoneNumber1.Size = New System.Drawing.Size(210, 23)
        Me.txtPhoneNumber1.TabIndex = 28
        Me.txtPhoneNumber1.UseSelectable = True
        Me.txtPhoneNumber1.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPhoneNumber1.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtAddress
        '
        '
        '
        '
        Me.txtAddress.CustomButton.Image = Nothing
        Me.txtAddress.CustomButton.Location = New System.Drawing.Point(132, 1)
        Me.txtAddress.CustomButton.Name = ""
        Me.txtAddress.CustomButton.Size = New System.Drawing.Size(77, 77)
        Me.txtAddress.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtAddress.CustomButton.TabIndex = 1
        Me.txtAddress.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtAddress.CustomButton.UseSelectable = True
        Me.txtAddress.CustomButton.Visible = False
        Me.txtAddress.Lines = New String(-1) {}
        Me.txtAddress.Location = New System.Drawing.Point(120, 33)
        Me.txtAddress.MaxLength = 32767
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtAddress.SelectedText = ""
        Me.txtAddress.SelectionLength = 0
        Me.txtAddress.SelectionStart = 0
        Me.txtAddress.ShortcutsEnabled = True
        Me.txtAddress.Size = New System.Drawing.Size(210, 79)
        Me.txtAddress.TabIndex = 27
        Me.txtAddress.UseSelectable = True
        Me.txtAddress.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtAddress.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel22
        '
        Me.MetroLabel22.AutoSize = True
        Me.MetroLabel22.Location = New System.Drawing.Point(4, 153)
        Me.MetroLabel22.Name = "MetroLabel22"
        Me.MetroLabel22.Size = New System.Drawing.Size(113, 19)
        Me.MetroLabel22.TabIndex = 9
        Me.MetroLabel22.Text = "Phone Number 2:"
        '
        'MetroLabel23
        '
        Me.MetroLabel23.AutoSize = True
        Me.MetroLabel23.Location = New System.Drawing.Point(4, 124)
        Me.MetroLabel23.Name = "MetroLabel23"
        Me.MetroLabel23.Size = New System.Drawing.Size(111, 19)
        Me.MetroLabel23.TabIndex = 7
        Me.MetroLabel23.Text = "Phone Number 1:"
        '
        'tabAdmitPatient
        '
        Me.tabAdmitPatient.Controls.Add(Me.btnAdmitPatient)
        Me.tabAdmitPatient.Controls.Add(Me.ListView1)
        Me.tabAdmitPatient.Controls.Add(Me.btnCheckStatus)
        Me.tabAdmitPatient.Controls.Add(Me.listRoom)
        Me.tabAdmitPatient.Controls.Add(Me.MetroPanel4)
        Me.tabAdmitPatient.HorizontalScrollbarBarColor = True
        Me.tabAdmitPatient.HorizontalScrollbarHighlightOnWheel = False
        Me.tabAdmitPatient.HorizontalScrollbarSize = 10
        Me.tabAdmitPatient.Location = New System.Drawing.Point(4, 38)
        Me.tabAdmitPatient.Name = "tabAdmitPatient"
        Me.tabAdmitPatient.Size = New System.Drawing.Size(1192, 597)
        Me.tabAdmitPatient.TabIndex = 2
        Me.tabAdmitPatient.Text = "Admit Patient"
        Me.tabAdmitPatient.VerticalScrollbarBarColor = True
        Me.tabAdmitPatient.VerticalScrollbarHighlightOnWheel = False
        Me.tabAdmitPatient.VerticalScrollbarSize = 10
        '
        'btnAdmitPatient
        '
        Me.btnAdmitPatient.Location = New System.Drawing.Point(933, 475)
        Me.btnAdmitPatient.Name = "btnAdmitPatient"
        Me.btnAdmitPatient.Size = New System.Drawing.Size(110, 23)
        Me.btnAdmitPatient.TabIndex = 7
        Me.btnAdmitPatient.Text = "Admit Patient"
        Me.btnAdmitPatient.UseSelectable = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colBedNo, Me.colPatientID, Me.colPatientName})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(289, 253)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(754, 216)
        Me.ListView1.TabIndex = 6
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'colBedNo
        '
        Me.colBedNo.Text = "Bed No."
        Me.colBedNo.Width = 95
        '
        'colPatientID
        '
        Me.colPatientID.Text = "Patient ID"
        Me.colPatientID.Width = 105
        '
        'colPatientName
        '
        Me.colPatientName.Text = "Patient Name"
        Me.colPatientName.Width = 145
        '
        'btnCheckStatus
        '
        Me.btnCheckStatus.Location = New System.Drawing.Point(933, 224)
        Me.btnCheckStatus.Name = "btnCheckStatus"
        Me.btnCheckStatus.Size = New System.Drawing.Size(110, 23)
        Me.btnCheckStatus.TabIndex = 5
        Me.btnCheckStatus.Text = "Check Status"
        Me.btnCheckStatus.UseSelectable = True
        '
        'listRoom
        '
        Me.listRoom.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colRoomNumber, Me.colRoomType, Me.colTotalBeds, Me.colOccupiedBeds, Me.colUnOccupiedBeds})
        Me.listRoom.FullRowSelect = True
        Me.listRoom.GridLines = True
        Me.listRoom.Location = New System.Drawing.Point(289, 2)
        Me.listRoom.Name = "listRoom"
        Me.listRoom.Size = New System.Drawing.Size(754, 216)
        Me.listRoom.TabIndex = 4
        Me.listRoom.UseCompatibleStateImageBehavior = False
        Me.listRoom.View = System.Windows.Forms.View.Details
        '
        'frmPatientManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Name = "frmPatientManagement"
        Me.Size = New System.Drawing.Size(1054, 541)
        Me.MetroPanel1.ResumeLayout(False)
        Me.MetroPanel1.PerformLayout()
        CType(Me.txtInsuranceCompany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPatientID1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPatientName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRoomNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBedNumber, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPatientMaster.ResumeLayout(False)
        Me.MetroPanel4.ResumeLayout(False)
        Me.MetroPanel4.PerformLayout()
        Me.MetroTabControl1.ResumeLayout(False)
        Me.tabAddPatient.ResumeLayout(False)
        Me.tabAddPatient.PerformLayout()
        Me.MetroPanel3.ResumeLayout(False)
        Me.MetroPanel3.PerformLayout()
        Me.MetroPanel2.ResumeLayout(False)
        Me.MetroPanel2.PerformLayout()
        Me.tabAdmitPatient.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MetroLabel25 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel1 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel13 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel12 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel11 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel10 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel9 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel8 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel7 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel4 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel26 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtInsuranceCompany As MetroFramework.Components.MetroStyleManager
    Friend WithEvents btnModifyPatient As MetroFramework.Controls.MetroButton
    Friend WithEvents colPatientNumber As ColumnHeader
    Friend WithEvents colPatientLastName As ColumnHeader
    Friend WithEvents colPatientFirstName As ColumnHeader
    Friend WithEvents colPatientGender As ColumnHeader
    Friend WithEvents colPatientRegistrationDate As ColumnHeader
    Public WithEvents txtPatientID1 As MetroFramework.Components.MetroStyleManager
    Public WithEvents txtPatientName As MetroFramework.Components.MetroStyleManager
    Friend WithEvents txtRoomNumber As MetroFramework.Components.MetroStyleManager
    Friend WithEvents txtBedNumber As MetroFramework.Components.MetroStyleManager
    Friend WithEvents tabPatientMaster As MetroFramework.Controls.MetroTabPage
    Friend WithEvents colDateAdmit As ColumnHeader
    Friend WithEvents MetroLabel15 As MetroFramework.Controls.MetroLabel
    Friend WithEvents colUnOccupiedBeds As ColumnHeader
    Friend WithEvents colOccupiedBeds As ColumnHeader
    Friend WithEvents colTotalBeds As ColumnHeader
    Friend WithEvents colRoomType As ColumnHeader
    Friend WithEvents colRoomNumber As ColumnHeader
    Friend WithEvents MetroPanel4 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel19 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel20 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel21 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel24 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
    Friend WithEvents tabAddPatient As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btnAddPatient As MetroFramework.Controls.MetroButton
    Friend WithEvents MetroLabel14 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel3 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel30 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel31 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroPanel2 As MetroFramework.Controls.MetroPanel
    Friend WithEvents MetroLabel22 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel23 As MetroFramework.Controls.MetroLabel
    Friend WithEvents tabAdmitPatient As MetroFramework.Controls.MetroTabPage
    Friend WithEvents btnAdmitPatient As MetroFramework.Controls.MetroButton
    Friend WithEvents ListView1 As ListView
    Friend WithEvents colBedNo As ColumnHeader
    Friend WithEvents colPatientID As ColumnHeader
    Friend WithEvents colPatientName As ColumnHeader
    Friend WithEvents btnCheckStatus As MetroFramework.Controls.MetroButton
    Friend WithEvents listRoom As ListView
    Friend WithEvents txtBloodGroup As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtReligion As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtCivilStatus As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtGender As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtBirthPlace As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtBirthday As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMothersName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtFathersName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtMiddleName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtFirstName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtLastName As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPatientID As MetroFramework.Controls.MetroTextBox
    Friend WithEvents listPatientMaster As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents colPatientAge As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents colAction As ColumnHeader
    Friend WithEvents MetroTextBox21 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox20 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox19 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroTextBox18 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPatientID2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtInsuranceCompany1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPhoneNumber2 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPhoneNumber1 As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtAddress As MetroFramework.Controls.MetroTextBox
End Class
