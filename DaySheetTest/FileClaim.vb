Option Strict On


Public Class FileClaim
    Dim mintsave As Integer
    Dim DB As New ClassDB
    Dim Val As New ClassValidate

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click

        'Declarations: Variables
        Dim datDate As Date = CDate(calDate.Text)

        'Inputs: Validate
        If txtReceipt.Text = "" Then
            MessageBox.Show("Receipt Number is required.")
            Exit Sub
        End If
        If Val.CheckIntegerSubstring(txtReceipt.Text) = False Then
            MessageBox.Show("Receipt Number must be numerical.")
            Exit Sub
        End If
        'Changes made by: Kate Onofrey 4/10/13
        If txtReceipt.Text.Length < 5 Then
            MessageBox.Show("Receipt Number must be at least 5 digits.")
            Exit Sub
        End If
        If calDate.Text = "" Then
            MessageBox.Show("Date is required.")
            Exit Sub
        End If
        If Today < datDate Then
            MessageBox.Show("Cannot File a Claim for a date in the future.")
            Exit Sub
        End If

        'Perform select query
        DB.SecondarySelectQuery("SELECT * FROM tblTransaction WHERE RefDate IS NOT NULL and ReceiptNumber = " & txtReceipt.Text, "tblTransaction")
        'If the claim has already been filed...
        If DB.SecondaryCountDataset.Tables("tblTransaction").Rows.Count <> 0 Then
            If mintsave = 0 Then
                Dim strmsg As String
                Dim strtitle As String
                Dim strstyle As MsgBoxStyle
                Dim strresponse As MsgBoxResult
                strmsg = "You are about to overwrite a claim. Would you like to proceed?"   ' Define message.
                strstyle = MsgBoxStyle.DefaultButton2 Or _
                   MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
                strtitle = "File Claim"   ' Define title.
                ' Display message.
                strresponse = MsgBox(strmsg, strstyle, strtitle)
                If strresponse = MsgBoxResult.Yes Then   ' User chose Yes.
                    ' File Claim
                    DB.FileClaim(txtReceipt.Text, datDate)
                    'Show Success Msg
                    MessageBox.Show("Claim submitted.")
                    mintsave += 1
                Else
                    ' close
                    Me.Show()
                    txtReceipt.Focus()
                End If
            End If
        Else
            'File Claim
            DB.FileClaim(txtReceipt.Text, datDate)
            'Show Success Msg
            MessageBox.Show("Claim submitted.")
            mintsave += 1
        End If


    End Sub
    Public Sub LoadForm()
        'Make sure that the form is clear
        calDate.Text = ""
        txtReceipt.Text = ""
        txtReceipt.Focus()
        mintsave = 0
    End Sub
    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        'Show Home form and hide current form
        Home.Show()
        Me.Hide()
    End Sub
    'Changes made my Kate Onofrey April 14, 2013
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Hide current form, show Unfiled Claims form, and load the sub to display information on unfiled claims form
        UnfiledClaims.LoadTrans()
        UnfiledClaims.Show()
        Me.Hide()

    End Sub

    Private Sub FileClaim_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Home.Show()
    End Sub

    Private Sub FileClaim_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        LoadForm()
    End Sub
End Class