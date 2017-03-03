Imports System.Data.OleDb
Public Class frmPatientManagement
    Dim con As New OleDb.OleDbConnection

    Dim sql As String
    Dim inc As Integer
    Dim maxRows As Integer
    Dim dbSource As String
    Dim ds As New DataSet
    Dim dt1 As New DataTable
    Dim dt2 As New DataTable
    Dim da As OleDb.OleDbDataAdapter
    Dim myRow As DataRow
    Dim cmd As New OleDbCommand
    Dim cn As OleDbConnection
    Dim dr As OleDbDataReader
    Dim max As Integer
    Private Sub frmPatientManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dbSource = source
        con.ConnectionString = dbSource
        con.Open()
        sql = "SELECT * FROM PATIENT"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "PATIENT")
        cn = New OleDbConnection(source)
        cn.Open()
        cmd = New OleDbCommand("SELECT [Patient_ID] from PATIENT", cn)
        dr = cmd.ExecuteReader

        roomList()
        patientRecords()

        While dr.Read()
            txtPatientID.Text = dr(maxRows)
        End While
        max = txtPatientID.Text
        txtPatientID.Text = max + 1
        txtPatientID2.Text = max + 1
        tabAddPatient.Select()
        con.Close()

        maxRows = ds.Tables("PATIENT").Rows.Count
    End Sub


    Private Sub patientRecords()

        ds.Tables.Add(dt1)
        Dim da As New OleDb.OleDbDataAdapter("Select * from PATIENT  ORDER by [Patient_ID]", con)
        da.Fill(dt1)

        Dim myRow As DataRow
        For Each myRow In dt1.Rows
            listPatientMaster.Items.Add(myRow.Item(0))
            listPatientMaster.Items(listPatientMaster.Items.Count - 1).SubItems.Add(myRow.Item(1))
            listPatientMaster.Items(listPatientMaster.Items.Count - 1).SubItems.Add(myRow.Item(2))
            listPatientMaster.Items(listPatientMaster.Items.Count - 1).SubItems.Add(myRow.Item(10))
            listPatientMaster.Items(listPatientMaster.Items.Count - 1).SubItems.Add(myRow.Item(9))
        Next
    End Sub

    Private Sub roomList()
        ds.Tables.Add(dt2)

        Dim da As New OleDb.OleDbDataAdapter("Select * from ROOM", con)
        da.Fill(dt2)

        Dim myRow As DataRow
        For Each myRow In dt2.Rows
            listRoom.Items.Add(myRow.Item(0))
            listRoom.Items(listRoom.Items.Count - 1).SubItems.Add(myRow.Item(1))
            listRoom.Items(listRoom.Items.Count - 1).SubItems.Add(myRow.Item(2))
        Next
    End Sub
    Private Sub btnAddPatient_Click(sender As Object, e As EventArgs) Handles btnAddPatient.Click

        Dim cb As New OleDb.OleDbCommandBuilder(da)
        Dim dsNewRow As DataRow

        dsNewRow = ds.Tables("PATIENT").NewRow()
        dsNewRow.Item("Patient_ID") = txtPatientID2.Text
        dsNewRow.Item("Patient_LastName") = txtLastName.Text
        dsNewRow.Item("Patient_FirstName") = txtFirstName.Text
        dsNewRow.Item("Patient_MiddleName") = txtMiddleName.Text
        dsNewRow.Item("Patient_FathersName") = txtFathersName.Text
        dsNewRow.Item("Patient_MothersName") = txtMothersName.Text
        dsNewRow.Item("Patient_Birthday") = txtBirthday.Text
        dsNewRow.Item("Patient_BirthPlace") = txtBirthPlace.Text
        dsNewRow.Item("Patient_Gender") = txtGender.Text
        dsNewRow.Item("Patient_CivilStatus") = txtCivilStatus.Text
        dsNewRow.Item("Patient_Religion") = txtReligion.Text
        dsNewRow.Item("Patient_BloodGroup") = txtBloodGroup.Text

        dsNewRow.Item("Patient_Address") = txtAddress.Text
        dsNewRow.Item("Patient_PhoneNumber1") = txtPhoneNumber1.Text
        dsNewRow.Item("Patient_PhoneNumber2") = txtPhoneNumber2.Text
        dsNewRow.Item("Patient_InsuranceCompany") = txtInsuranceCompany1.Text

        ds.Tables("PATIENT").Rows.Add(dsNewRow)

        da.Update(ds, "PATIENT")

        MsgBox("Successfully added")

        txtLastName.Clear()
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtFathersName.Clear()
        txtMothersName.Clear()
        txtBirthday.Clear()
        txtBirthPlace.Clear()
        txtGender.Clear()
        txtCivilStatus.Clear()
        txtReligion.Clear()
        txtBloodGroup.Clear()

        txtAddress.Clear()
        txtPhoneNumber1.Clear()
        txtPhoneNumber2.Clear()
        txtInsuranceCompany1.Clear()
    End Sub

End Class
