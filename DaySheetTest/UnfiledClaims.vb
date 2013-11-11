Option Strict On

Public Class UnfiledClaims

    Dim DB As New ClassDB

    Private Sub UnfiledClaims_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        FileClaim.Show()
    End Sub
    Private Sub NoRefDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'KalpaxisDBDataSet.tblPatient' table. You can move, or remove it, as needed. **Note from Spring 2013: We did not use this.
        Me.TblPatientTableAdapter.Fill(Me.KalpaxisDBDataSet.tblPatient)
        LoadTrans()

    End Sub
    'Changes made by: Kate Onofrey. *Date sort added
    Public Sub LoadTrans()

        'Select query that inputs data into the table on the form.
        DB.SelectQuery("SELECT FirstName + ' ' + LastName AS [Name], TransDate AS [Date], Charge, Cash, Credit, Check, Adjustments, CurrentBal AS [Current Balance], PrevBal AS [Previous Balance], ReceiptNumber FROM tblTransaction WHERE RefDate is Null AND NeedToFile IS NULL ORDER BY [TransDate] Asc", "tblTransaction")
        gvUnfiled.DataSource = DB.CountDataset.Tables("tblTransaction")

        If DB.CountDataset.Tables("tblTransaction").Rows.Count = 0 Then
            MessageBox.Show("No unfiled claims found.")
            Exit Sub
        End If

        'Format Cells
        gvUnfiled.Columns("Charge").DefaultCellStyle.Format = "c"
        gvUnfiled.Columns("Check").DefaultCellStyle.Format = "c"
        gvUnfiled.Columns("Credit").DefaultCellStyle.Format = "c"
        gvUnfiled.Columns("Cash").DefaultCellStyle.Format = "c"
        gvUnfiled.Columns("Adjustments").DefaultCellStyle.Format = "c"
        gvUnfiled.Columns("Current Balance").DefaultCellStyle.Format = "c"
        gvUnfiled.Columns("Previous Balance").DefaultCellStyle.Format = "c"



    End Sub
    'Changes made by: Kate Onofrey on April 14, 2013
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFileClaim.Click

        'Show File Claim form and hide current form
        FileClaim.Show()
        Me.Hide()

    End Sub
    'Changes made by: Kate Onofrey on April 14, 2013
    Private Sub btnHome_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click

        'Show Home form and hide current form
        Me.Hide()
        Home.Show()

    End Sub
End Class