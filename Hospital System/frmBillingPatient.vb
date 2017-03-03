Public Class frmBillingPatient
    Dim con As New OleDb.OleDbConnection

    Dim sql As String
    Dim inc As Integer
    Dim maxRows As Integer
    Dim dbSource As String
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim myRow As DataRow

    Dim patientID As String
    Dim patientFirstName As String
    Dim patientLastName As String
    Dim patientFullName As String

    Private Sub frmBillingPatient1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.ConnectionString = source
        con.Open()
        showPatientRecords()
        con.Close()

    End Sub

    Private Sub showPatientRecords()

        ds.Tables.Add(dt)

        Dim da As New OleDb.OleDbDataAdapter("Select * from PATIENT", con)
        da.Fill(dt)

        Dim myRow As DataRow
        For Each myRow In dt.Rows
            patientListView.Items.Add(myRow.Item(0))
            patientListView.Items(patientListView.Items.Count - 1).SubItems.Add(myRow.Item(1))
            patientListView.Items(patientListView.Items.Count - 1).SubItems.Add(myRow.Item(2))
        Next
    End Sub

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        patientID = patientListView.FocusedItem.SubItems(0).Text
        patientFirstName = patientListView.FocusedItem.SubItems(2).Text
        patientLastName = patientListView.FocusedItem.SubItems(1).Text

        frmMain.bMgmt.txtPatientID.Text = patientID.ToString
        frmMain.bMgmt.txtPatientName.Text = patientFirstName + " " + patientLastName
        frmMain.bMgmt.txtDate.Text = dateTime
        Me.Close()
    End Sub
End Class