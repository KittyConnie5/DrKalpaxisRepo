Imports System.Web
Public Class Home

    Dim DB As New ClassDB

    Private Sub btnNewPatient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewPatient.Click
        NewPatient.Show()
        NewPatient.ClearForm()
        Me.Hide()
    End Sub

    Private Sub btnSearchPatients_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchPatients.Click
        FindPatient.txtLastName.Text = ""
        FindPatient.txtFirstName.Text = ""
        FindPatient.txtPatientID.Text = ""
        FindPatient.Show()
        Me.Hide()
    End Sub

    Private Sub btnReports_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReports.Click
        DB.SelectQuery("SELECT * FROM tblFeeSchedule", "tblFeeSchedule")
        FeeSchedule.DataGridView1.DataSource = DB.CountDataset.Tables("tblFeeSchedule")
        FeeSchedule.Show()
        Me.Hide()
    End Sub

    Private Sub btnLedger_Click(sender As System.Object, e As System.EventArgs) Handles btnLedger.Click
        DaySheet.Show()
        Me.Hide()
    End Sub

    Private Sub btnFileClaim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFileClaim.Click
        FileClaim.LoadForm()
        FileClaim.Show()
        Me.Hide()
    End Sub

    Private Sub Home_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub
End Class