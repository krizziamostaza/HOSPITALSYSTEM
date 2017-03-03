<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServicesProducts
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
        Me.MetroLabel1 = New MetroFramework.Controls.MetroLabel()
        Me.comboParticularType = New MetroFramework.Controls.MetroComboBox()
        Me.comboParticularCategory = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel2 = New MetroFramework.Controls.MetroLabel()
        Me.comboParticularItem = New MetroFramework.Controls.MetroComboBox()
        Me.MetroLabel3 = New MetroFramework.Controls.MetroLabel()
        Me.txtQuantity = New MetroFramework.Controls.MetroTextBox()
        Me.txtPrice = New MetroFramework.Controls.MetroTextBox()
        Me.MetroLabel5 = New MetroFramework.Controls.MetroLabel()
        Me.MetroLabel6 = New MetroFramework.Controls.MetroLabel()
        Me.btnCancel = New MetroFramework.Controls.MetroButton()
        Me.btnAdd = New MetroFramework.Controls.MetroButton()
        Me.SuspendLayout()
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.Location = New System.Drawing.Point(61, 40)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(39, 19)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Type:"
        '
        'comboParticularType
        '
        Me.comboParticularType.FormattingEnabled = True
        Me.comboParticularType.ItemHeight = 23
        Me.comboParticularType.Location = New System.Drawing.Point(200, 37)
        Me.comboParticularType.Name = "comboParticularType"
        Me.comboParticularType.Size = New System.Drawing.Size(211, 29)
        Me.comboParticularType.TabIndex = 2
        Me.comboParticularType.UseSelectable = True
        '
        'comboParticularCategory
        '
        Me.comboParticularCategory.FormattingEnabled = True
        Me.comboParticularCategory.ItemHeight = 23
        Me.comboParticularCategory.Location = New System.Drawing.Point(200, 81)
        Me.comboParticularCategory.Name = "comboParticularCategory"
        Me.comboParticularCategory.Size = New System.Drawing.Size(211, 29)
        Me.comboParticularCategory.TabIndex = 4
        Me.comboParticularCategory.UseSelectable = True
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.Location = New System.Drawing.Point(61, 85)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(126, 19)
        Me.MetroLabel2.TabIndex = 3
        Me.MetroLabel2.Text = "Particular Category:"
        '
        'comboParticularItem
        '
        Me.comboParticularItem.FormattingEnabled = True
        Me.comboParticularItem.ItemHeight = 23
        Me.comboParticularItem.Location = New System.Drawing.Point(200, 126)
        Me.comboParticularItem.Name = "comboParticularItem"
        Me.comboParticularItem.Size = New System.Drawing.Size(211, 29)
        Me.comboParticularItem.TabIndex = 6
        Me.comboParticularItem.UseSelectable = True
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.Location = New System.Drawing.Point(61, 129)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(97, 19)
        Me.MetroLabel3.TabIndex = 5
        Me.MetroLabel3.Text = "Particular Item:"
        '
        'txtQuantity
        '
        '
        '
        '
        Me.txtQuantity.CustomButton.Image = Nothing
        Me.txtQuantity.CustomButton.Location = New System.Drawing.Point(189, 1)
        Me.txtQuantity.CustomButton.Name = ""
        Me.txtQuantity.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtQuantity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtQuantity.CustomButton.TabIndex = 1
        Me.txtQuantity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtQuantity.CustomButton.UseSelectable = True
        Me.txtQuantity.CustomButton.Visible = False
        Me.txtQuantity.Lines = New String(-1) {}
        Me.txtQuantity.Location = New System.Drawing.Point(200, 180)
        Me.txtQuantity.MaxLength = 32767
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQuantity.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtQuantity.SelectedText = ""
        Me.txtQuantity.SelectionLength = 0
        Me.txtQuantity.SelectionStart = 0
        Me.txtQuantity.ShortcutsEnabled = True
        Me.txtQuantity.Size = New System.Drawing.Size(211, 23)
        Me.txtQuantity.TabIndex = 7
        Me.txtQuantity.UseSelectable = True
        Me.txtQuantity.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtQuantity.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'txtPrice
        '
        '
        '
        '
        Me.txtPrice.CustomButton.Image = Nothing
        Me.txtPrice.CustomButton.Location = New System.Drawing.Point(189, 1)
        Me.txtPrice.CustomButton.Name = ""
        Me.txtPrice.CustomButton.Size = New System.Drawing.Size(21, 21)
        Me.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPrice.CustomButton.TabIndex = 1
        Me.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPrice.CustomButton.UseSelectable = True
        Me.txtPrice.CustomButton.Visible = False
        Me.txtPrice.Lines = New String(-1) {}
        Me.txtPrice.Location = New System.Drawing.Point(200, 229)
        Me.txtPrice.MaxLength = 32767
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrice.SelectedText = ""
        Me.txtPrice.SelectionLength = 0
        Me.txtPrice.SelectionStart = 0
        Me.txtPrice.ShortcutsEnabled = True
        Me.txtPrice.Size = New System.Drawing.Size(211, 23)
        Me.txtPrice.TabIndex = 8
        Me.txtPrice.UseSelectable = True
        Me.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPrice.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel)
        '
        'MetroLabel5
        '
        Me.MetroLabel5.AutoSize = True
        Me.MetroLabel5.Location = New System.Drawing.Point(61, 228)
        Me.MetroLabel5.Name = "MetroLabel5"
        Me.MetroLabel5.Size = New System.Drawing.Size(41, 19)
        Me.MetroLabel5.TabIndex = 10
        Me.MetroLabel5.Text = "Price:"
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.Location = New System.Drawing.Point(62, 181)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(35, 19)
        Me.MetroLabel6.TabIndex = 9
        Me.MetroLabel6.Text = "Qty.:"
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(280, 327)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(94, 23)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseSelectable = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(380, 327)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(102, 23)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseSelectable = True
        '
        'frmServicesProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(494, 371)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.MetroLabel5)
        Me.Controls.Add(Me.MetroLabel6)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.comboParticularItem)
        Me.Controls.Add(Me.MetroLabel3)
        Me.Controls.Add(Me.comboParticularCategory)
        Me.Controls.Add(Me.MetroLabel2)
        Me.Controls.Add(Me.comboParticularType)
        Me.Controls.Add(Me.MetroLabel1)
        Me.Name = "frmServicesProducts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Services and Products"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroLabel1 As MetroFramework.Controls.MetroLabel
    Friend WithEvents comboParticularType As MetroFramework.Controls.MetroComboBox
    Friend WithEvents comboParticularCategory As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel2 As MetroFramework.Controls.MetroLabel
    Friend WithEvents comboParticularItem As MetroFramework.Controls.MetroComboBox
    Friend WithEvents MetroLabel3 As MetroFramework.Controls.MetroLabel
    Friend WithEvents txtQuantity As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPrice As MetroFramework.Controls.MetroTextBox
    Friend WithEvents MetroLabel5 As MetroFramework.Controls.MetroLabel
    Friend WithEvents MetroLabel6 As MetroFramework.Controls.MetroLabel
    Friend WithEvents btnCancel As MetroFramework.Controls.MetroButton
    Friend WithEvents btnAdd As MetroFramework.Controls.MetroButton
End Class
