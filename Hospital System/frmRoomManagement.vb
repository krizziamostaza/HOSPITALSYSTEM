Public Class frmRoomManagement

    Dim con As New OleDb.OleDbConnection
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim dbSource As String

    Private Sub frmRoomManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dbSource = source
        con.ConnectionString = dbSource
        con.Open()

        roomList()
        con.Close()
    End Sub

    Private Sub roomList()
        ds.Tables.Add(dt)

        Dim da As New OleDb.OleDbDataAdapter("Select * from ROOM", con)
        da.Fill(dt)

        Dim myRow As DataRow
        For Each myRow In dt.Rows
            listRoom.Items.Add(myRow.Item(0))
            listRoom.Items(listRoom.Items.Count - 1).SubItems.Add(myRow.Item(1))
            listRoom.Items(listRoom.Items.Count - 1).SubItems.Add(myRow.Item(2))
        Next
    End Sub


End Class
