Public Class AddTransactionSelection

    Private Sub btnVisitTransaction_Click(sender As System.Object, e As System.EventArgs) Handles btnVisitTransaction.Click
        AddVisitTransaction.Show()
        DisableButtons()
    End Sub

    Public Sub EnableButtons()
        btnVisitTransaction.Enabled = True
        btnPatientPayment.Enabled = True
        btnInsurancePayment.Enabled = True
        btnWriteOff.Enabled = True

    End Sub

    Public Sub DisableButtons()
        btnVisitTransaction.Enabled = False
        btnPatientPayment.Enabled = False
        btnInsurancePayment.Enabled = False
        btnWriteOff.Enabled = False

    End Sub

    Private Sub AddTransactionSelection_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        PatientLedger.Show()
        PatientLedger.Refresh()
    End Sub

    Private Sub AddTransactionSelection_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        EnableButtons()
    End Sub

    Private Sub btnPatientPayment_Click(sender As System.Object, e As System.EventArgs) Handles btnPatientPayment.Click
        DisableButtons()
        AddPatientPaymentTransaction.Show()
    End Sub

    Private Sub btnWriteOff_Click(sender As System.Object, e As System.EventArgs) Handles btnWriteOff.Click
        DisableButtons()
        AddWriteOffTransaction.Show()
    End Sub

    Private Sub btnInsurancePayment_Click(sender As System.Object, e As System.EventArgs) Handles btnInsurancePayment.Click
        DisableButtons()
        AddInsurancePaymentTransaction.Show()

    End Sub
End Class