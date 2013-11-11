Option Strict On

Public Class AddTransaction
    Dim intPatientID As Integer
    Dim DB As New ClassDB
    Dim Val As New ClassValidate


    Private Sub AddTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadDefaults()

        'intPatientID = FindPatient.txtPatientID
    End Sub

    Public Sub LoadDefaults()
        ClearForm()
        ' LoadDDL()
        ddlDescription.SelectedIndex = 0

        'Checkbox
        chkClaim.Checked = False

        'Get ID
        txtPatientID.Text = PatientLedger.txtPatientID.Text

        'Get Previous Balance
        DB.SelectQuery("SELECT * FROM tblTransaction WHERE PatientID = " & CInt(PatientLedger.txtPatientID.Text), "tblTransaction")
        Dim NumberOfRows As Integer = DB.CountDataset.Tables("tblTransaction").Rows.Count
        If DB.CountDataset.Tables("tblTransaction").Rows.Count = 0 Then
            txtPreviousBal.Text = "0"
        Else
            txtPreviousBal.Text = DB.CountDataset.Tables("tblTransaction").Rows(NumberOfRows - 1).Item("CurrentBal").ToString
            'If DB.CountDataset.Tables("tblTransaction").Rows(0).Item("PrevBal") Is DBNull.Value Then
            '    txtPreviousBal.Text = "0"
            'End If
        End If
    End Sub

    'Public Sub LoadDDL()
    '    DB.SelectQuery("SELECT * FROM tblFeeSchedule", "tblFeeSchedule")
    '    ddlDescription.DataSource = DB.CountDataset.Tables("tblFeeSchedule")
    '    ddlDescription.DisplayMember = "CPT Code"
    '    ddlDescription.ValueMember = "CPT Code"
    'End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Public Sub ClearForm()
        txtDateOfTransaction.Text = ""
        txtDateClaimFiled.Text = ""
        txtCharge.Text = ""
        txtCash.Text = ""
        txtAdjustment.Text = ""
        txtCurrentBalance.Text = ""
        txtPreviousBal.Text = ""
        txtAdjPercent.Text = ""
        txtCredit.Text = ""
        txtCheck.Text = ""
        txtDirectDeposit.Text = ""
        ddlDescription.SelectedIndex = 0
        ddlInsurance.SelectedIndex = 0
        lblSuggested.Text = ""
        txtDescription.Text = ""
        txtReceiptNo.Text = ""
        txtCheckNo.Text = ""
        txtDirectNo.Text = ""

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        ClearForm()
        PatientLedger.Show()
        Me.Hide()
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        'Validate
        'Date of Transaction
        If txtDateOfTransaction.Text = "" Then
            MessageBox.Show("Please enter Date of Transaction")
            Exit Sub
        End If
        If Val.CheckIntegerSubstring(txtDateOfTransaction.Text.Substring(0, 2)) = False Then
            MessageBox.Show("Please put Date of Transaction in MM/DD/YYYY format")
            Exit Sub
        End If
        If txtDateOfTransaction.Text.Substring(2, 1) <> "/" Then
            MessageBox.Show("Please put Date of Transaction in MM/DD/YYYY format")
            Exit Sub
        End If
        If Val.CheckIntegerSubstring(txtDateOfTransaction.Text.Substring(3, 2)) = False Then
            MessageBox.Show("Please put Date of Transaction in MM/DD/YYYY format")
            Exit Sub
        End If
        If txtDateOfTransaction.Text.Substring(5, 1) <> "/" Then
            MessageBox.Show("Please put Date of Transaction in MM/DD/YYYY format")
            Exit Sub
        End If
        If Val.CheckIntegerSubstring(txtDateOfTransaction.Text.Substring(6, 4)) = False Then
            MessageBox.Show("Please put Date of Transaction in MM/DD/YYYY format")
            Exit Sub
        End If
        'Date Claim Filed
        If txtDateClaimFiled.Text <> "" Then
            If Val.CheckIntegerSubstring(txtDateClaimFiled.Text.Substring(0, 2)) = False Then
                MessageBox.Show("Please put Date Claim Filed in MM/DD/YYYY format")
                Exit Sub
            End If
            If txtDateClaimFiled.Text.Substring(2, 1) <> "/" Then
                MessageBox.Show("Please put Date Claim Filed in MM/DD/YYYY format")
                Exit Sub
            End If
            If Val.CheckIntegerSubstring(txtDateClaimFiled.Text.Substring(3, 2)) = False Then
                MessageBox.Show("Please put Date Claim Filed in MM/DD/YYYY format")
                Exit Sub
            End If
            If txtDateClaimFiled.Text.Substring(5, 1) <> "/" Then
                MessageBox.Show("Please put Date Claim Filed in MM/DD/YYYY format")
                Exit Sub
            End If
            If Val.CheckIntegerSubstring(txtDateClaimFiled.Text.Substring(6, 4)) = False Then
                MessageBox.Show("Please put Date Claim Filed in MM/DD/YYYY format")
                Exit Sub
            End If
        End If
        'Insurance used
        If ddlInsurance.SelectedIndex = 0 Then
            MessageBox.Show("Please enter Insurance")
            Exit Sub
        End If
        'Description
        If ddlDescription.SelectedIndex = 0 And txtDescription.Text = "" Then
            MessageBox.Show("Please enter Description")
            Exit Sub
        End If
        'Money 
        If txtCharge.Text <> "" Then
            If Val.CheckMoney(txtCharge.Text) = False Then
                MessageBox.Show("Please put Charge in XXX.XX format")
                Exit Sub
            End If
        End If
        If txtCash.Text <> "" Then
            If Val.CheckMoney(txtCash.Text) = False Then
                MessageBox.Show("Please put Cash Amount in XXX.XX format")
                Exit Sub
            End If
        End If
        If txtCheck.Text <> "" Then
            If Val.CheckMoney(txtCheck.Text) = False Then
                MessageBox.Show("Please put Check Amount in XXX.XX format")
                Exit Sub
            End If
        End If
        If txtCredit.Text <> "" Then
            If Val.CheckMoney(txtCredit.Text) = False Then
                MessageBox.Show("Please put Credit Amount in XXX.XX format")
                Exit Sub
            End If
        End If
        If txtDirectDeposit.Text <> "" Then
            If Val.CheckMoney(txtDirectDeposit.Text) = False Then
                MessageBox.Show("Please put Direct Deposit Amount in XXX.XX format")
                Exit Sub
            End If
        End If
        If txtAdjustment.Text <> "" Then
            If Val.CheckMoney(txtAdjustment.Text) = False Then
                MessageBox.Show("Please put Adjustment Amount in XXX.XX format")
                Exit Sub
            End If
        End If
        If txtAdjPercent.Text <> "" Then
            If Val.CheckMoney(txtAdjPercent.Text) = False Then
                MessageBox.Show("Please put Adjustment Percent in XX.X format")
                Exit Sub
            End If
        End If
        'Receipt No
        If txtReceiptNo.Text <> "" Then
            If Val.CheckIntegerSubstring(txtReceiptNo.Text) = False Then
                MessageBox.Show("Receipt Number must be numeric")
                Exit Sub
            End If
        End If
        'Check #
        If txtCheck.Text <> "" Then
            If txtCheckNo.Text = "" Then
                MessageBox.Show("Check # is required if patient paid by check")
                Exit Sub
            End If
            If Val.CheckIntegerSubstring(txtCheckNo.Text) = False Then
                MessageBox.Show("Check # must be numerical")
                Exit Sub
            End If
        End If
        'Deposit #
        If txtDirectDeposit.Text <> "" Then
            If txtDirectNo.Text = "" Then
                MessageBox.Show("Check # is required if patient paid by check")
                Exit Sub
            End If
            If Val.CheckIntegerSubstring(txtDirectNo.Text) = False Then
                MessageBox.Show("Check # must be numerical")
                Exit Sub
            End If
        End If
        'If left blank, set to zero
        If txtCash.Text = "" Then
            txtCash.Text = "0"
        End If
        If txtCheck.Text = "" Then
            txtCheck.Text = "0"
        End If
        If txtCredit.Text = "" Then
            txtCredit.Text = "0"
        End If
        If txtDirectDeposit.Text = "" Then
            txtDirectDeposit.Text = "0"
        End If
        If txtAdjustment.Text = "" Then
            txtAdjustment.Text = "0"
        End If
        If txtAdjPercent.Text = "" Then
            txtAdjPercent.Text = "0"
        End If
        If txtCurrentBalance.Text = "" Then
            txtCurrentBalance.Text = "0"
        End If
        If txtCharge.Text = "" Then
            txtCharge.Text = "0"
        End If
        'Format
        If txtCharge.Text.Contains(".") Then
            'do nothing
        Else
            txtCharge.AppendText(".00")
        End If

        If txtCash.Text.Contains(".") Then
            'do nothing
        Else
            txtCash.AppendText(".00")
        End If

        If txtCheck.Text.Contains(".") Then
            'do nothing
        Else
            txtCheck.AppendText(".00")
        End If

        If txtCredit.Text.Contains(".") Then
            'do nothing
        Else
            txtCredit.AppendText(".00")
        End If

        If txtDirectDeposit.Text.Contains(".") Then
            'do nothing
        Else
            txtDirectDeposit.AppendText(".00")
        End If
        'If txtAdjustment.Text.Contains(".") Then
        '    'do nothing
        'Else
        '    txtAdjustment.AppendText(".00")
        'End If



        'Get procedure ID
        Dim intProcedureID As Integer
        DB.SelectQuery("SELECT ID FROM tblFeeSchedule WHERE [CPT Code] like '" & txtDescription.Text & "'", "tblFeeSchedule")
        If DB.CountDataset.Tables("tblFeeSchedule").Rows.Count = 0 Then
            intProcedureID = 0
        Else
            intProcedureID = Convert.ToInt32(DB.CountDataset.Tables("tblFeeSchedule").Rows(0).Item("ID"))
        End If



        Dim intCharge As Double = Convert.ToDouble(txtCharge.Text)
        Dim intCash As Double = Convert.ToDouble(txtCash.Text)
        Dim intCredit As Double = Convert.ToDouble(txtCredit.Text)
        Dim intCheck As Double = Convert.ToDouble(txtCheck.Text)
        Dim intDirectDeposit As Double = Convert.ToDouble(txtDirectDeposit.Text)
        Dim intAdj As Double = Convert.ToDouble(txtAdjustment.Text)
        Dim intCurrentBalance As Double = Convert.ToDouble(txtCurrentBalance.Text)
        Dim DateOfTransaction As Date = Convert.ToDateTime(txtDateOfTransaction.Text)
        Dim DateClaimFiled As Date
        If txtDateClaimFiled.Text <> "" Then
            DateClaimFiled = Convert.ToDateTime(txtDateClaimFiled.Text)
        End If
        Dim intPatientID As Integer = Convert.ToInt32(txtPatientID.Text)
        Dim intPreviousBal As Double = Convert.ToDouble(txtPreviousBal.Text)
        Dim intReceipt As Integer
        If txtReceiptNo.Text <> "" Then
            intReceipt = Convert.ToInt32(txtReceiptNo.Text)
        Else
            intReceipt = 0
        End If
        Dim intPayments As Double


        'Get insurance ID
        Dim intinsuranceID As Integer
        If ddlInsurance.SelectedIndex > 1 Then
            DB.SelectQuery("SELECT * FROM tblInsurance WHERE PatientID = '" & intPatientID.ToString & "' AND InsuranceName like '" & ddlInsurance.SelectedItem.ToString & "'", "tblInsurance")
            If DB.CountDataset.Tables("tblInsurance").Rows.Count = 0 Then
                MessageBox.Show("This patient does not have " & ddlInsurance.SelectedItem.ToString & " stored as their insurance. Add " & ddlInsurance.SelectedItem.ToString & " to this patient's file before continuing.")
                Exit Sub
            Else
                intinsuranceID = (CInt(DB.CountDataset.Tables("tblInsurance").Rows(0).Item("InsuranceID")))
            End If
        Else
            intinsuranceID = 0
        End If

        'Calculate Current Balance
        DB.SelectQuery("SELECT * FROM tblTransaction WHERE PatientID = " & intPatientID, "tblTransaction")
        Dim intNumOfTransactions As Integer = DB.CountDataset.Tables("tblTransaction").Rows.Count
        If DB.CountDataset.Tables("tblTransaction").Rows.Count = 0 Then
            intCurrentBalance = 0
        Else
            intCurrentBalance = CDbl(DB.CountDataset.Tables("tblTransaction").Rows(intNumOfTransactions - 1).Item("CurrentBal"))
        End If


        intCurrentBalance = intCurrentBalance + intCharge - intCash - intCheck - intCredit - intDirectDeposit - intAdj
        txtCurrentBalance.Text = intCurrentBalance.ToString

        'Calculate Payments
        intPayments = intCash + intCheck + intCredit + intDirectDeposit

        'Add Transaction
        'If txtDateClaimFiled.Text = "" Then
        '    If chkClaim.Checked = True Then
        '        DB.AddNewTransactionNoRef(strfname, intPatientID, DateOfTransaction, intinsuranceID, txtDescription.Text, intCharge, intPayments, intCash, intCheck, intAdj, intCurrentBalance, intPreviousBal, intReceipt, "N")
        '    Else
        '        DB.AddNewTransactionNoRef(intPatientID, DateOfTransaction, intinsuranceID, txtDescription.Text, intCharge, intPayments, intCash, intCheck, intAdj, intCurrentBalance, intPreviousBal, intReceipt, "Y")
        '    End If
        'Else
        '    'DB.AddNewTransaction(intPatientID, DateOfTransaction, DateClaimFiled, intinsuranceID, txtDescription.Text, intCharge, intPayments, intCash, intCheck, intAdj, intCurrentBalance, intPreviousBal, intReceipt)
        'End If

        'reload patient ledger transaction grid        
        PatientLedger.LoadTransactions()
        PatientLedger.Show()
        Me.Hide()

    End Sub

    Private Sub btnTodayDateOfTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTodayDateOfTrans.Click
        txtDateOfTransaction.Text = DateTime.Today.ToString("MM/dd/yyyy")
    End Sub

    Private Sub btnTodayDateClaimFiled_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTodayDateClaimFiled.Click
        txtDateClaimFiled.Text = DateTime.Today.ToString("MM/dd/yyyy")
    End Sub

    Private Sub txtAdjustment_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdjustment.TextChanged
        'Calculate Percentage
        If txtAdjustment.Text <> "" Then
            If txtCharge.Text = "" Then
                txtCharge.Text = "0"
            End If
            If txtCharge.Text = "0" Then
                txtAdjPercent.Text = "0"
            Else
                txtAdjPercent.Text = CStr(CDbl(txtAdjustment.Text) / CDbl(txtCharge.Text) * 100)
            End If
        End If

    End Sub

    Private Sub txtAdjPercent_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdjPercent.TextChanged
        'Calculate Adjustment
        If txtAdjPercent.Text <> "" Then
            If txtCharge.Text = "" Then
                txtCharge.Text = "0"
            End If
            If txtCharge.Text = "0" Then
                txtAdjustment.Text = "0"
            Else
                txtAdjustment.Text = CStr((CDbl(txtCharge.Text) * CDbl(txtAdjPercent.Text) / 100))
            End If

        End If
    End Sub

    Private Sub ddlDescription_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlDescription.SelectedIndexChanged
        txtDescription.Text = ddlDescription.SelectedItem.ToString
        'Suggested PRice
        If ddlInsurance.SelectedIndex <> 0 And ddlDescription.SelectedIndex <> 0 Then
            DB.SelectQuery("SELECT * FROM tblFeeSchedule WHERE [CPT Code] like '" & txtDescription.Text & "'", "tblFeeSchedule")
            lblSuggested.Text = "Suggested: $" & DB.CountDataset.Tables("tblFeeSchedule").Rows(0).Item(ddlInsurance.SelectedItem.ToString).ToString
        End If
    End Sub

    Private Sub ddlInsurance_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ddlInsurance.SelectedIndexChanged

    End Sub
End Class