Imports System.Data.OleDb
Public Class frmServicesProducts

    Dim con As New OleDbConnection
    Dim con2 As New OleDbConnection

    Dim sql1 As String
    Dim sql2 As String
    Dim sql3 As String
    Dim sql4 As String


    Dim dt As New DataTable
    Dim dt1 As New DataTable
    Dim dt2 As New DataTable
    Dim dt3 As New DataTable
    Dim dt4 As New DataTable

    Dim ds As New DataSet
    Dim ds1 As New DataSet
    Dim ds2 As New DataSet
    Dim ds3 As New DataSet
    Dim ds4 As New DataSet

    Dim da As New OleDbDataAdapter
    Dim da1 As New OleDbDataAdapter
    Dim da2 As New OleDbDataAdapter
    Dim da3 As New OleDbDataAdapter

    Dim query As String
    Dim pricey As String

    Dim row As Integer = 0

    Dim itemTotal As Integer
    Dim subTotal As Integer
    Dim totalAmount As Integer
    Dim discount As String

    Public particularItem As String
    Public quantity As String
    Public price As String


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If comboParticularType.Text = "" Or comboParticularCategory.Text = "" Or comboParticularItem.Text = "" Or txtQuantity.Text = "" Or txtPrice.Text = "" Then
            MsgBox("All fields should be filled up.")
        Else
            particularItem = comboParticularItem.Text
            quantity = txtQuantity.Text
            price = txtPrice.Text


            Dim itemNo As Integer = bMgmt.listBilling.Items.Count
            Dim i As ListViewItem

            i = bMgmt.listBilling.Items.Add(itemNo + 1)
            i.SubItems.Add(particularItem)
            i.SubItems.Add(quantity)
            i.SubItems.Add(price)
            i.SubItems.Add(quantity * price)
        End If

        discount = bMgmt.txtDiscount.Text
        Dim TempNode As ListViewItem
        For Each TempNode In bMgmt.listBilling.Items
            itemTotal += TempNode.SubItems.Item(2).Text
            subTotal += TempNode.SubItems.Item(3).Text
        Next
        bMgmt.txtTotalItems.Text = itemTotal
        bMgmt.txtSubTotal.Text = subTotal
    End Sub

    Private Sub frmServicesProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        comboParticularType.Items.Add("Particular Bills")
        comboParticularType.Items.Add("Medicine Bills")

        con.ConnectionString = source
        con.Open()

        con.Close()
    End Sub

    Private Sub comboParticularType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboParticularType.SelectedIndexChanged

        ds.Tables.Clear()
        ds1.Tables.Clear()
        ds2.Tables.Clear()
        dt.Clear()
        dt1.Clear()
        dt2.Clear()

        comboParticularCategory.Items.Clear()
        comboParticularItem.Items.Clear()

        If comboParticularType.SelectedItem = "Particular Bills" Then
            particularBills()
        Else
            medicineBills()
        End If

    End Sub

    Private Sub particularBills()

        ds1.Tables.Add(dt1)
        da1 = New OleDbDataAdapter("SELECT * FROM [SERVICE]", con)
        da1.Fill(dt1)

        For Each myRow In dt1.Rows
            comboParticularCategory.Items.Add(myRow.Item(0))
            row += 0
        Next
    End Sub
    Private Sub medicineBills()
        ds2.Tables.Add(dt2)
        da2 = New OleDbDataAdapter("SELECT * FROM [MEDICINE]", con)
        da2.Fill(dt2)

        For Each myRow In dt2.Rows
            comboParticularCategory.Items.Add(myRow.Item(0))
            row += 0
        Next
    End Sub

    Private Sub comboParticularCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboParticularCategory.SelectedIndexChanged

        ds.Tables.Clear()
        dt.Reset()

        comboParticularItem.Items.Clear()

        If comboParticularCategory.SelectedItem = "Bacteriology" Then
            bacteriology()
        ElseIf comboParticularCategory.SelectedItem = "Electrolyte" Then
            electrolyte()
        ElseIf comboParticularCategory.SelectedItem = "Enzyme" Then
            enzyme()
        ElseIf comboParticularCategory.SelectedItem = "Hematology" Then
            hematology()
        ElseIf comboParticularCategory.SelectedItem = "Hepatitis" Then
            hepatitis()
        ElseIf comboParticularCategory.SelectedItem = "Hormones" Then
            hormones()
        ElseIf comboParticularCategory.SelectedItem = "Other Services" Then
            otherServices()
        ElseIf comboParticularCategory.SelectedItem = "Radiology" Then
            radiology()
        ElseIf comboParticularCategory.SelectedItem = "Thyroid Function Test" Then
            thyroidFunctionTest()
        ElseIf comboParticularCategory.SelectedItem = "Tumor Marker" Then
            tumorMarker()
        ElseIf comboParticularCategory.SelectedItem = "Urine Test" Then
            urineTest()
        ElseIf comboParticularCategory.SelectedItem = "Ampule" Then
            ampule()
        ElseIf comboParticularCategory.SelectedItem = "Vial" Then
            vial()
        ElseIf comboParticularCategory.SelectedItem = "Supplies" Then
            supplies()
        End If
    End Sub
    Private Sub bacteriology()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("SELECT [Bacteriology_Name] FROM [BACTERIOLOGY]", con)
        da.Fill(dt)

        For Each myRow In dt.Rows
            comboParticularItem.Items.Add(myRow.Item(0))
            row += 0
        Next
    End Sub

    Private Sub electrolyte()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("SELECT [Electrolyte_Name] FROM [ELECTROLYTE]", con)
        da.Fill(dt)

        For Each myRow In dt.Rows
            comboParticularItem.Items.Add(myRow.Item(0))
            row += 0
        Next
    End Sub

    Private Sub enzyme()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("SELECT [Enzyme_Name] FROM [ENZYME]", con)
        da.Fill(dt)

        For Each myRow In dt.Rows
            comboParticularItem.Items.Add(myRow.Item(0))
            row += 0
        Next
    End Sub

    Private Sub hematology()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("SELECT [Hematology_Name] FROM [HEMATOLOGY]", con)
        da.Fill(dt)

        For Each myRow In dt.Rows
            comboParticularItem.Items.Add(myRow.Item(0))
            row += 0
        Next
    End Sub


    Private Sub hepatitis()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("SELECT [Hepatitis_Name] FROM [HEPATITIS]", con)
        da.Fill(dt)

        For Each myRow In dt.Rows
            comboParticularItem.Items.Add(myRow.Item(0))
            row += 0
        Next
    End Sub

    Private Sub hormones()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("SELECT [Hormones_Name] FROM [HORMONES]", con)
        da.Fill(dt)

        For Each myRow In dt.Rows
            comboParticularItem.Items.Add(myRow.Item(0))
            row += 0
        Next
    End Sub

    Private Sub otherServices()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("SELECT [Other_Services_Name] FROM [OTHER_SERVICES]", con)
        da.Fill(dt)

        For Each myRow In dt.Rows
            comboParticularItem.Items.Add(myRow.Item(0))
            row += 0
        Next
    End Sub

    Private Sub radiology()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("SELECT [Radiology_Name] FROM [RADIOLOGY]", con)
        da.Fill(dt)

        For Each myRow In dt.Rows
            comboParticularItem.Items.Add(myRow.Item(0))
            row += 0
        Next
    End Sub

    Private Sub thyroidFunctionTest()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("SELECT [Thyroid_Name] FROM [THYROID_FUNCTION_TEST]", con)
        da.Fill(dt)

        For Each myRow In dt.Rows
            comboParticularItem.Items.Add(myRow.Item(0))
            row += 0
        Next
    End Sub

    Private Sub tumorMarker()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("SELECT [Tumor_Marker_Name] FROM [TUMOR_MARKER]", con)
        da.Fill(dt)

        For Each myRow In dt.Rows
            comboParticularItem.Items.Add(myRow.Item(0))
            row += 0
        Next
    End Sub

    Private Sub urineTest()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("SELECT [Urine_Test_Name] FROM [URINE_TEST]", con)
        da.Fill(dt)

        For Each myRow In dt.Rows
            comboParticularItem.Items.Add(myRow.Item(0))
            row += 0
        Next
    End Sub

    Private Sub ampule()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("SELECT [Ampule_Name] FROM [AMPULE]", con)
        da.Fill(dt)

        For Each myRow In dt.Rows
            comboParticularItem.Items.Add(myRow.Item(0))
            row += 0
        Next
    End Sub

    Private Sub vial()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("SELECT [Vial_Name] FROM [VIAL]", con)
        da.Fill(dt)

        For Each myRow In dt.Rows
            comboParticularItem.Items.Add(myRow.Item(0))
            row += 0
        Next
    End Sub

    Private Sub supplies()
        ds.Tables.Add(dt)
        da = New OleDbDataAdapter("SELECT [Supply_Name] FROM [SUPPLIES]", con)
        da.Fill(dt)

        For Each myRow In dt.Rows
            comboParticularItem.Items.Add(myRow.Item(0))
            row += 0
        Next
    End Sub

    Private Sub comboParticularItem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comboParticularItem.SelectedIndexChanged

        con2.ConnectionString = source
        con2.Open()

        If comboParticularCategory.Text = "Bacteriology" Then
            query = "SELECT * FROM [BACTERIOLOGY] WHERE [Bacteriology_Name]='" & comboParticularItem.Text & "'"
            pricey = "Bacteriology_Price"
            getPrice()
        ElseIf comboParticularCategory.Text = "Electrolyte" Then
            query = "SELECT * FROM [ELECTROLYTE] WHERE [Electrolyte_Name]='" & comboParticularItem.Text & "'"
            pricey = "Electrolyte_Price"
            getPrice()
        ElseIf comboParticularCategory.Text = "Enzyme" Then
            query = "SELECT * FROM [ENZYME] WHERE [Enzyme_Name]='" & comboParticularItem.Text & "'"
            pricey = "Enzyme_Price"
            getPrice()
        ElseIf comboParticularCategory.Text = "Hematology" Then
            query = "SELECT * FROM [HEMATOLOGY] WHERE [Hematology_Name]='" & comboParticularItem.Text & "'"
            pricey = "Hematology_Price"
            getPrice()
        ElseIf comboParticularCategory.Text = "Hepatitis" Then
            query = "SELECT * FROM [HEPATITIS] WHERE [Hepatitis_Name]='" & comboParticularItem.Text & "'"
            pricey = "Hepatitis_Price"
            getPrice()
        ElseIf comboParticularCategory.Text = "Hormones" Then
            query = "SELECT * FROM [HORMONES] WHERE [Hormones_Name]='" & comboParticularItem.Text & "'"
            pricey = "Hormones_Price"
            getPrice()
        ElseIf comboParticularCategory.Text = "Other Services" Then
            query = "SELECT * FROM [OTHER SERVICES] WHERE [Other_Services_Name]='" & comboParticularItem.Text & "'"
            pricey = "Other_Services_Price"
            getPrice()
        ElseIf comboParticularCategory.Text = "Radiology" Then
            query = "SELECT * FROM [RADIOLOGY] WHERE [Radiology_Name]='" & comboParticularItem.Text & "'"
            pricey = "Radiology_Price"
            getPrice()
        ElseIf comboParticularCategory.Text = "Thyroid Function Test" Then
            query = "SELECT * FROM [THYROID_FUNCTION_TEST] WHERE [Thyroid_Name]='" & comboParticularItem.Text & "'"
            pricey = "Thyroid_Price"
            getPrice()
        ElseIf comboParticularCategory.Text = "Tumor Marker" Then
            query = "SELECT * FROM [TUMOR_MARKER] WHERE [Tumor_Marker_Name]='" & comboParticularItem.Text & "'"
            pricey = "Tumor_Marker_Price"
            getPrice()
        ElseIf comboParticularCategory.Text = "Urine Test" Then
            query = "SELECT * FROM [URINE_TEST] WHERE [Urine_Test_Name]='" & comboParticularItem.Text & "'"
            pricey = "Urine_Test_Price"
            getPrice()
        ElseIf comboParticularCategory.Text = "Ampule" Then
            query = "SELECT * FROM [AMPULE] WHERE [Ampule_Name]='" & comboParticularItem.Text & "'"
            pricey = "Ampule_Price"
            getPrice()
        ElseIf comboParticularCategory.Text = "Vial" Then
            query = "SELECT * FROM [VIAL] WHERE [Vial_Name]='" & comboParticularItem.Text & "'"
            pricey = "Vial_Price"
            getPrice()
        ElseIf comboParticularCategory.Text = "Supplies" Then
            query = "SELECT * FROM [SUPPLIES] WHERE [Supply_Name]='" & comboParticularItem.Text & "'"
            pricey = "Supply_Price"
            getPrice()
        End If

        con2.Close()
    End Sub

    Private Sub getPrice()
        Dim command As OleDbCommand
        Dim reader As OleDbDataReader

        command = New OleDbCommand(query, con2)
        reader = command.ExecuteReader

        While reader.Read
            txtPrice.Text = reader(pricey)
        End While
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class