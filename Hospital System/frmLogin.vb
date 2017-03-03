Imports System.Data.OleDb
Public Class frmLogin

    Dim con As New OleDb.OleDbConnection

    Dim sql As String
    Dim inc As Integer
    Dim maxRows As Integer
    Dim dbSource As String
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim myRow As DataRow

    Public username

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim connection As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\HospitalSystem\HospitalDatabase.accdb")
        Dim command As New OleDbCommand("SELECT * FROM [USER] WHERE Username = ? AND Password = ?", connection)

        Dim usernameParam As New OleDbParameter("Username", Me.txtUsername.Text)
        Dim passwordParam As New OleDbParameter("Password", Me.txtPassword.Text)


        command.Parameters.Add(usernameParam)
        command.Parameters.Add(passwordParam)

        command.Connection.Open()
        Dim reader As OleDbDataReader = command.ExecuteReader()
        If reader.HasRows Then
            MessageBox.Show("Login successful")
            username = txtUsername.Text
            frmMain.Show()
            Me.Close()
        Else
            MessageBox.Show("Invalid login")
            txtPassword.Text = ""
            txtPassword.Focus()
        End If

    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub
End Class