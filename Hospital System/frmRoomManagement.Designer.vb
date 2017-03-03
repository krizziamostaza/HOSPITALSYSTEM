<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRoomManagement
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
        Me.colRoomRates = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colRoomType2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colRoomNumber2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MetroButton1 = New MetroFramework.Controls.MetroButton()
        Me.btnEditRoom = New MetroFramework.Controls.MetroButton()
        Me.btnDeleteRoom = New MetroFramework.Controls.MetroButton()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.colTotalBeds2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tabRoomMaster = New MetroFramework.Controls.MetroTabPage()
        Me.colUnOccupiedBeds = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colOccupiedBeds = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTotalBeds = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colRoomType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colRoomNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cmbRoomType = New MetroFramework.Controls.MetroComboBox()
        Me.listRoom = New System.Windows.Forms.ListView()
        Me.colDateAdmit = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPatientName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPatientID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colBedNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.tabRoomEnquiry = New MetroFramework.Controls.MetroTabPage()
        Me.MetroTabControl1 = New MetroFramework.Controls.MetroTabControl()
        Me.tabRoomMaster.SuspendLayout()
        Me.tabRoomEnquiry.SuspendLayout()
        Me.MetroTabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'colRoomRates
        '
        Me.colRoomRates.Text = "Room Rates"
        Me.colRoomRates.Width = 136
        '
        'colRoomType2
        '
        Me.colRoomType2.Text = "Room Type"
        Me.colRoomType2.Width = 145
        '
        'colRoomNumber2
        '
        Me.colRoomNumber2.Text = "Room Number"
        Me.colRoomNumber2.Width = 109
        '
        'MetroButton1
        '
        Me.MetroButton1.Location = New System.Drawing.Point(0, 4)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.Size = New System.Drawing.Size(137, 29)
        Me.MetroButton1.TabIndex = 10
        Me.MetroButton1.Text = "Add New Room"
        Me.MetroButton1.UseSelectable = True
        '
        'btnEditRoom
        '
        Me.btnEditRoom.Location = New System.Drawing.Point(821, 476)
        Me.btnEditRoom.Name = "btnEditRoom"
        Me.btnEditRoom.Size = New System.Drawing.Size(110, 23)
        Me.btnEditRoom.TabIndex = 9
        Me.btnEditRoom.Text = "Edit Room"
        Me.btnEditRoom.UseSelectable = True
        '
        'btnDeleteRoom
        '
        Me.btnDeleteRoom.Location = New System.Drawing.Point(937, 476)
        Me.btnDeleteRoom.Name = "btnDeleteRoom"
        Me.btnDeleteRoom.Size = New System.Drawing.Size(110, 23)
        Me.btnDeleteRoom.TabIndex = 8
        Me.btnDeleteRoom.Text = "Delete Room"
        Me.btnDeleteRoom.UseSelectable = True
        '
        'ListView2
        '
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colRoomNumber2, Me.colRoomType2, Me.colTotalBeds2, Me.colRoomRates})
        Me.ListView2.FullRowSelect = True
        Me.ListView2.Location = New System.Drawing.Point(0, 38)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(1047, 432)
        Me.ListView2.TabIndex = 6
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'colTotalBeds2
        '
        Me.colTotalBeds2.Text = "Total Beds"
        Me.colTotalBeds2.Width = 125
        '
        'tabRoomMaster
        '
        Me.tabRoomMaster.Controls.Add(Me.MetroButton1)
        Me.tabRoomMaster.Controls.Add(Me.btnEditRoom)
        Me.tabRoomMaster.Controls.Add(Me.btnDeleteRoom)
        Me.tabRoomMaster.Controls.Add(Me.ListView2)
        Me.tabRoomMaster.HorizontalScrollbarBarColor = True
        Me.tabRoomMaster.HorizontalScrollbarHighlightOnWheel = False
        Me.tabRoomMaster.HorizontalScrollbarSize = 10
        Me.tabRoomMaster.Location = New System.Drawing.Point(4, 38)
        Me.tabRoomMaster.Name = "tabRoomMaster"
        Me.tabRoomMaster.Size = New System.Drawing.Size(1046, 499)
        Me.tabRoomMaster.TabIndex = 1
        Me.tabRoomMaster.Text = "Room Master"
        Me.tabRoomMaster.VerticalScrollbarBarColor = True
        Me.tabRoomMaster.VerticalScrollbarHighlightOnWheel = False
        Me.tabRoomMaster.VerticalScrollbarSize = 10
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
        'cmbRoomType
        '
        Me.cmbRoomType.FormattingEnabled = True
        Me.cmbRoomType.ItemHeight = 23
        Me.cmbRoomType.Location = New System.Drawing.Point(0, 4)
        Me.cmbRoomType.Name = "cmbRoomType"
        Me.cmbRoomType.Size = New System.Drawing.Size(137, 29)
        Me.cmbRoomType.TabIndex = 6
        Me.cmbRoomType.UseSelectable = True
        '
        'listRoom
        '
        Me.listRoom.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colRoomNumber, Me.colRoomType, Me.colTotalBeds, Me.colOccupiedBeds, Me.colUnOccupiedBeds})
        Me.listRoom.FullRowSelect = True
        Me.listRoom.GridLines = True
        Me.listRoom.Location = New System.Drawing.Point(0, 38)
        Me.listRoom.Name = "listRoom"
        Me.listRoom.Size = New System.Drawing.Size(1047, 216)
        Me.listRoom.TabIndex = 5
        Me.listRoom.UseCompatibleStateImageBehavior = False
        Me.listRoom.View = System.Windows.Forms.View.Details
        '
        'colDateAdmit
        '
        Me.colDateAdmit.Text = "Date Admit"
        Me.colDateAdmit.Width = 136
        '
        'colPatientName
        '
        Me.colPatientName.Text = "Patient Name"
        Me.colPatientName.Width = 236
        '
        'colPatientID
        '
        Me.colPatientID.Text = "Patient ID"
        Me.colPatientID.Width = 216
        '
        'colBedNo
        '
        Me.colBedNo.Text = "Bed No."
        Me.colBedNo.Width = 146
        '
        'colStatus
        '
        Me.colStatus.Text = "Status"
        Me.colStatus.Width = 112
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colStatus, Me.colBedNo, Me.colPatientID, Me.colPatientName, Me.colDateAdmit})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(0, 260)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1046, 239)
        Me.ListView1.TabIndex = 7
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'tabRoomEnquiry
        '
        Me.tabRoomEnquiry.Controls.Add(Me.ListView1)
        Me.tabRoomEnquiry.Controls.Add(Me.cmbRoomType)
        Me.tabRoomEnquiry.Controls.Add(Me.listRoom)
        Me.tabRoomEnquiry.HorizontalScrollbarBarColor = True
        Me.tabRoomEnquiry.HorizontalScrollbarHighlightOnWheel = False
        Me.tabRoomEnquiry.HorizontalScrollbarSize = 10
        Me.tabRoomEnquiry.Location = New System.Drawing.Point(4, 38)
        Me.tabRoomEnquiry.Name = "tabRoomEnquiry"
        Me.tabRoomEnquiry.Size = New System.Drawing.Size(1046, 499)
        Me.tabRoomEnquiry.TabIndex = 0
        Me.tabRoomEnquiry.Text = "Room Enquiry"
        Me.tabRoomEnquiry.VerticalScrollbarBarColor = True
        Me.tabRoomEnquiry.VerticalScrollbarHighlightOnWheel = False
        Me.tabRoomEnquiry.VerticalScrollbarSize = 10
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Controls.Add(Me.tabRoomEnquiry)
        Me.MetroTabControl1.Controls.Add(Me.tabRoomMaster)
        Me.MetroTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.Size = New System.Drawing.Size(1054, 541)
        Me.MetroTabControl1.TabIndex = 6
        Me.MetroTabControl1.UseSelectable = True
        '
        'frmRoomManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Name = "frmRoomManagement"
        Me.Size = New System.Drawing.Size(1054, 541)
        Me.tabRoomMaster.ResumeLayout(False)
        Me.tabRoomEnquiry.ResumeLayout(False)
        Me.MetroTabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents colRoomRates As ColumnHeader
    Friend WithEvents colRoomType2 As ColumnHeader
    Friend WithEvents colRoomNumber2 As ColumnHeader
    Friend WithEvents MetroButton1 As MetroFramework.Controls.MetroButton
    Friend WithEvents btnEditRoom As MetroFramework.Controls.MetroButton
    Friend WithEvents btnDeleteRoom As MetroFramework.Controls.MetroButton
    Friend WithEvents ListView2 As ListView
    Friend WithEvents colTotalBeds2 As ColumnHeader
    Friend WithEvents tabRoomMaster As MetroFramework.Controls.MetroTabPage
    Friend WithEvents colUnOccupiedBeds As ColumnHeader
    Friend WithEvents colOccupiedBeds As ColumnHeader
    Friend WithEvents colTotalBeds As ColumnHeader
    Friend WithEvents colRoomType As ColumnHeader
    Friend WithEvents colRoomNumber As ColumnHeader
    Friend WithEvents cmbRoomType As MetroFramework.Controls.MetroComboBox
    Friend WithEvents listRoom As ListView
    Friend WithEvents colDateAdmit As ColumnHeader
    Friend WithEvents colPatientName As ColumnHeader
    Friend WithEvents colPatientID As ColumnHeader
    Friend WithEvents colBedNo As ColumnHeader
    Friend WithEvents colStatus As ColumnHeader
    Friend WithEvents ListView1 As ListView
    Friend WithEvents tabRoomEnquiry As MetroFramework.Controls.MetroTabPage
    Friend WithEvents MetroTabControl1 As MetroFramework.Controls.MetroTabControl
End Class
