Public Class frmBillingManagement
    Private Sub btnSelectPatient_Click(sender As Object, e As EventArgs) Handles btnSelectPatient.Click
        frmBillingPatient.Show()
    End Sub

    Private Sub frmBillingManagement_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        frmServicesProducts.Show()
    End Sub
End Class
