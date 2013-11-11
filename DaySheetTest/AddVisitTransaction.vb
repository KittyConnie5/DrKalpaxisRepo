Imports System.Text.RegularExpressions
Public Class AddVisitTransaction
    Dim DB As New ClassDB
    Dim Valid As New ClassValidate
    Dim Calc As New ClassCalculation
    Dim mintsave As Integer
    Dim mintPatientID As Integer
    Dim decBalance As Integer
    Dim decCharge As Decimal
    Dim decAdj As Decimal
    Dim decCheck As Decimal
    Dim decCredit As Decimal
    Dim decTotal As Decimal
    Dim decCash As Decimal
    Dim strcleanCPT As String
    Dim strFName As String
    Dim strLName As String
    Dim intInsuranceID As Integer
    Dim decPreviousBal As Decimal
    Dim intCheckNo As Integer
    Dim strAuthorizationNo As String
    Dim NumberOfRows As Integer
    Dim decCurrentCharge As Decimal
    Dim intChargeCount As Integer = 0

    Private Sub AddVisitTransaction_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If mintsave = 0 Then
            Dim strmsg As String
            Dim strtitle As String
            Dim strstyle As MsgBoxStyle
            Dim strresponse As MsgBoxResult
            strmsg = "Are you sure you want to exit without saving?"   ' Define message.
            strstyle = MsgBoxStyle.DefaultButton2 Or _
               MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
            strtitle = "Visit Payment"   ' Define title.
            ' Display message.
            strresponse = MsgBox(strmsg, strstyle, strtitle)
            If strresponse = MsgBoxResult.Yes Then   ' User chose Yes.
                ' close without saving
                'ClearForm()
                AddTransactionSelection.Enabled = True
                AddTransactionSelection.EnableButtons()
                AddTransactionSelection.Show()
                'PatientLedger.Refresh()
                Me.Hide()
            Else
                'dont close
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub AddVisitTransaction_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'clear
        ClearForm()
        EnableForm()

        'TODO: This line of code loads data into the 'KalpaxisDBDataSet8.tblInsurance' table. You can move, or remove it, as needed.

        Me.TblInsuranceTableAdapter1.GetInsurance(Me.KalpaxisDBDataSet8.tblInsurance, mintPatientID)
        Me.TblInsuranceTableAdapter1.Fill(Me.KalpaxisDBDataSet8.tblInsurance)
        
        'TODO: This line of code loads data into the 'KalpaxisDBDataSet7.tblInsurance' table. You can move, or remove it, as needed.
        Me.TblInsuranceTableAdapter.Fill(Me.KalpaxisDBDataSet7.tblInsurance)
        mintsave = 0
        intChargeCount = 0

        'get Patient ID from previous form
        mintPatientID = PatientLedger.intPatientID
        Dim lngID As Long
        lngID = Convert.ToInt64(mintPatientID)

        PatientIDToolStripTextBox1.Text = lngID.ToString
        FillByToolStripButton.PerformClick()
        'get name from the DB
        Dim strQuery As String = "SELECT tblPatient.[FirstName], tblPatient.[LastName] FROM tblPatient WHERE tblPatient.[PatientID] = " & lngID
        DB.SelectQuery(strQuery, "tblPatient")
        'put name into Firstname + Lastname format
        strFName = DB.CountDataset.Tables("tblPatient").Rows(0)(0)
        strLName = DB.CountDataset.Tables("tblPatient").Rows(0)(1)
        'output name in textbox
        txtName.Text = strFName + " " + strLName

        'get balance
        DB.GetPreviousBalance(lngID)
        NumberOfRows = ((DB.CountDataset.Tables("tblTransaction").Rows.Count) - 1)
        If NumberOfRows = -1 Then
            decBalance = 0
            decPreviousBal = 0
        Else

            If IsDBNull(DB.CountDataset.Tables("tblTransaction").Rows(NumberOfRows).Item("CurrentBal")) = False Then
                decBalance = CDec(DB.CountDataset.Tables("tblTransaction").Rows(NumberOfRows).Item("CurrentBal"))
            Else
                decBalance = 0
            End If


            If IsDBNull(DB.CountDataset.Tables("tblTransaction").Rows(NumberOfRows).Item("PrevBal")) = False Then
                decPreviousBal = CDec(DB.CountDataset.Tables("tblTransaction").Rows(NumberOfRows).Item("PrevBal"))
            Else
                decPreviousBal = 0
            End If
        End If

        txtPreviousBal.Text = decPreviousBal.ToString
        txtCurrentBalance.Text = decBalance.ToString

        txtReceipt.Focus()
        'get insurance
        'DB.GetInsurance(mintPatientID)
        'cbInsurance.DisplayMember = "InsuranceName"
        'cbInsurance.DataSource = DB.View
        'cbInsurance.SelectedIndex = 0
        'Dim strPrimary As String = PatientLedger.txtPriInsName.Text
        'Dim strSecondary As String = PatientLedger.txtSecInsName.Text
        'Dim strTertiary As String = PatientLedger.txtTerInsName.Text
        'cbInsurance.Items.Add(strPrimary)
        'cbInsurance.Items.Add(strSecondary)
        'cbInsurance.Items.Add(strTertiary)

        'get name
        'DB.SelectCertainPatient("SELECT * FROM tblPatient WHERE PatientID = '" & mintPatientID & "'")
        'Dim strName As String
        ''strName = CStr(DB.PatientDataset.Tables("tblPatient").Rows(0).Item("FirstName") & " " & DB.PatientDataset.Tables("tblPatient").Rows(0).Item("LastName"))
        ''txtName.Text = strName
        'DB.SelectCertainPatient("SELECT * FROM tblPatient WHERE PatientID = '" & mintPatientID & "'")
        'strName = DB.PatientDataset.Tables("tblPatient").Rows(0).Item("FirstName").ToString & " " & DB.PatientDataset.Tables("tblPatient").Rows(0).Item("LastName").ToString
        'txtName.Text = strName
        'EnableForm()

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        AddTransactionSelection.EnableButtons()

    End Sub


    Private Sub btnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnSubmit.Click
        'validate
        If dtpVisit.Text = "" Then
            MessageBox.Show("Please enter a date.")
            Exit Sub
        End If

        If Today < CDate(dtpVisit.Text) Then
            MessageBox.Show("Transaction date cannot be in the future.")
            Exit Sub
        End If


        If txtCharge.Text <> "" Then
            If Valid.CheckMoney(txtCharge.Text) = False Then
                MessageBox.Show("Please enter only numbers and a decimal point for Charge.")
                Exit Sub
            End If
        End If

        If txtCash.Text <> "" Then
            If Valid.CheckMoney(txtCash.Text) = False Then
                MessageBox.Show("Please enter only numbers and a decimal point for Cash.")
                Exit Sub
            End If
        End If

        If txtAdjustment.Text <> "" Then
            If Valid.CheckMoney(txtAdjustment.Text) = False Then
                MessageBox.Show("Please enter only numbers and a decimal point for Adjustment.")
                Exit Sub
            End If
        End If

        If txtAuthorization.Text <> "" Then
            If Valid.CheckAlphaNumeric(txtAuthorization.Text) = False Then
                MessageBox.Show("Please enter only numbers and letters for Authorization.")
                Exit Sub
            End If
        End If

        If txtCredit.Text <> "" Then
            If Valid.CheckMoney(txtCredit.Text) = False Then
                MessageBox.Show("Please enter only numbers and a decimal point for Credit.")
                Exit Sub
            End If
        End If

        If txtCheck.Text <> "" Then
            If Valid.CheckIntegerSubstring(txtCheck.Text) = False Then
                MessageBox.Show("Please enter only numbers and a decimal point for Check.")
                Exit Sub
            End If
        End If

        If txtCheckNo.Text <> "" Then
            If Valid.CheckIntegerSubstring(txtCheckNo.Text) = False Then
                MessageBox.Show("Please enter only numbers for Check Number.")
                Exit Sub
            End If
        End If

        If txtCharge.Text = "" Then
            MessageBox.Show("Please enter a CPT code to charge a patient.")
            Exit Sub
        End If

        If txtReceipt.Text <> "" Then
            If Valid.CheckIntegerSubstring(txtReceipt.Text) = False Then
                MessageBox.Show("Please use only numbers for receipt number.")
                Exit Sub
            End If
        Else
            MessageBox.Show("Please enter a receipt number.")
            Exit Sub
        End If

        If txtCredit.Text <> "" And txtAuthorization.Text = "" Then
            MessageBox.Show("Please add authorization number.")
            Exit Sub
        End If

        If txtCheck.Text <> "" And txtCheckNo.Text = "" Then
            MessageBox.Show("Please add check number.")
            Exit Sub
        End If

        'Perform select query
        DB.SecondarySelectQuery("SELECT * FROM tblTransaction WHERE ReceiptNumber = " & txtReceipt.Text, "tblTransaction")

        If DB.SecondaryCountDataset.Tables("tblTransaction").Rows.Count <> 0 Then
            MessageBox.Show("Please enter a unique receipt number.")
            Exit Sub
        End If

        'add
        If txtAdjustment.Text <> "" Then
            decAdj = CDec(txtAdjustment.Text)
        Else
            decAdj = 0
        End If

        If txtCredit.Text <> "" Then
            decCredit = CDec(txtCredit.Text)
        Else
            decCredit = 0
        End If

        If txtCash.Text <> "" Then
            decCash = CDec(txtCash.Text)
        Else
            decCredit = 0
        End If

        If txtCheck.Text <> "" Then
            decCheck = CDec(txtCheck.Text)
        Else
            decCheck = 0
        End If

        If txtCurrentBalance.Text <> "" Then
            decBalance = CDec(txtCurrentBalance.Text)
        Else
            decBalance = 0
        End If

        If txtPreviousBal.Text <> "" Then
            decPreviousBal = CDec(txtPreviousBal.Text)
        Else
            decPreviousBal = 0
        End If

        If txtCheckNo.Text <> "" Then
            intCheckNo = CInt(txtCheckNo.Text)
        Else
            intCheckNo = 0
        End If

        If txtAuthorization.Text <> "" Then
            strAuthorizationNo = txtAuthorization.Text
        Else
            strAuthorizationNo = 0
        End If

        decCharge = CDec(txtCharge.Text)

        decTotal = (decBalance + decCharge) - decAdj - decCheck - decCredit - decCash

        txtPreviousBal.Text = decBalance.ToString

        txtCurrentBalance.Text = decTotal.ToString

        Dim datDateofTransaction As Date = CDate(dtpVisit.Text)


        DB.SelectQuery("SELECT InsuranceID FROM tblInsurance WHERE PatientID = '" & mintPatientID.ToString & "'", "tblInsurance")

        If DB.CountDataset.Tables("tblInsurance").Rows.Count <> 0 Then
            intInsuranceID = (CInt(DB.CountDataset.Tables("tblInsurance").Rows(0).Item("InsuranceID")))
        End If

        Dim intReceipt As Integer = CInt(txtReceipt.Text)

        'save
        DB.AddNewTransaction(strFName, strLName, mintPatientID, datDateofTransaction, intInsuranceID, decCharge, strAuthorizationNo, decCash, decCheck, intCheckNo, decAdj, decTotal, decBalance, intReceipt, decCredit)
        mintsave += 1
        MessageBox.Show("Transaction successful!")
        Me.Close()
        AddTransactionSelection.EnableButtons()
        PatientLedger.Show()
    'Refresh the patient ledger
        PatientLedger.btnRefresh.PerformClick()
    End Sub

    Public Sub ClearForm()
        cbInsurance.ResetText()
        txtAdjustment.Text = ""
        txtAuthorization.Text = ""
        txtCash.Text = ""
        txtCharge.Text = ""
        txtCheck.Text = ""
        txtCheckNo.Text = ""
        txtCredit.Text = ""
        txtCredit.Text = ""
        txtReceipt.Text = ""
        'txtCurrentBalance.Text = ""
        'txtPatientID.Text = ""
        'txtPreviousBal.Text = ""
        txtReceiptNo.Text = ""
        lbCPT.Clear()
        lvManual.Clear()
        intChargeCount = 0
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub btnAddCPTCode_Click(sender As System.Object, e As System.EventArgs) Handles btnAddCPTCode.Click
        'add item
        If ddlCPT.SelectedItem <> "" Then
            lbCPT.Items.Add(ddlCPT.SelectedItem.ToString)
        Else
            MessageBox.Show("Please choose a CPT Code.")
            Exit Sub
        End If

    End Sub

    Private Sub txtAdjustment_TextChanged(sender As Object, e As System.EventArgs) Handles txtAdjustment.TextChanged
        'percentage of current balance that is adjusted
        Dim decAdjust As Decimal
        If Valid.CheckMoney(txtAdjustment.Text) = False Then
            MessageBox.Show("Please enter only numbers and a decimal point for adjustment")
            Exit Sub
        End If
        If txtAdjustment.Text <> "" Then
            decAdjust = CDec(txtAdjustment.Text)
        End If
    End Sub

    'Private Sub txtAdjPercent_TextChanged(sender As Object, e As System.EventArgs) Handles txtAdjPercent.TextChanged
    '    'percentage of current balance that is adjusted
    '    Dim decbalance As Decimal = CDec(txtCurrentBalance.Text)
    '    Dim decAdjpercent As Decimal
    '    If txtAdjPercent.Text <> "" Then
    '        decAdjpercent = ((CDec(txtAdjPercent.Text)) / 100)
    '    End If

    '    txtAdjustment.Text = (decbalance * decAdjpercent).tostring
    'End Sub

    Private Sub btnManualCPT_Click(sender As System.Object, e As System.EventArgs) Handles btnManualCPT.Click
        CreateManualCPT.Show()
        'DisableForm()
    End Sub

    Public Sub DisableForm()
        cbInsurance.Enabled = False
        'txtAdjPercent.Enabled = False
        txtAdjustment.Enabled = False
        txtAuthorization.Enabled = False
        txtCash.Enabled = False
        'txtCharge.Enabled = False
        txtCheck.Enabled = False
        txtCheckNo.Enabled = False
        txtCredit.Enabled = False
        'txtCurrentBalance.Enabled = False
        'txtPreviousBal.Enabled = False
        txtReceiptNo.Enabled = False
        lbCPT.Enabled = False
        lvManual.Enabled = False
    End Sub
    Public Sub EnableForm()
        cbInsurance.Enabled = True
        'txtAdjPercent.Enabled = False
        txtAdjustment.Enabled = True
        txtAuthorization.Enabled = True
        txtCash.Enabled = True
        'txtCharge.Enabled = True
        txtCheck.Enabled = True
        txtCheckNo.Enabled = True
        txtCredit.Enabled = True
        'txtCurrentBalance.Enabled = True
        'txtPreviousBal.Enabled = True
        txtReceiptNo.Enabled = True
        lbCPT.Enabled = True
        lvManual.Enabled = True
    End Sub

    'Private Sub btnCharge_Click(sender As System.Object, e As System.EventArgs) Handles btnCharge.Click
    '    'loop through cpt codes and add amount to charge
    '    If lbCPT.Items.Count <> 0 Then
    '        'get index of lb
    '        Dim intCPTCount As Integer = lbCPT.Items.Count
    '        Dim strItem As String = cbInsurance.SelectedItem.ToString
    '        If strItem <> "" Then
    '            For i = 0 To (intCPTCount - 1)
    '                strcleanCPT = Regex.Replace(lbCPT.Items(i).ToString, "[^0-9\./]", "").ToString

    '                DB.SelectQuery("SELECT * FROM tblFeeSchedule WHERE CPTCode = " & strcleanCPT, "tblFeeSchedule")
    '                'DataGridView1.DataSource = DB.CountDataset.Tables("tblFeeSchedule")
    '                'DB.GetCharge(strcleanCPT)
    '                'Dim decCharge As Decimal = CDec(DB.CountDataset.Tables("tblFeeSchedule").Rows(0).Item(cbInsurance.SelectedItem.ToString))
    '                'txtCharge.Text += decCharge.ToString
    '                'End If
    '            Next
    '        Else
    '            For i = 0 To (intCPTCount - 1)
    '                strcleanCPT = Regex.Replace(lbCPT.Items(i).ToString, "[^0-9\./]", "")
    '                'If DB.GetCPT(strcleanCPT) = True Then
    '                'DB.SelectQuery("SELECT Default FROM tblFeeSchedule WHERE CPTCode = '" & strcleanCPT & "'", "tblFeeSchedule")
    '                DB.GetCharge(strcleanCPT)
    '                Dim decCharge As Decimal = CDec(DB.CountDataset.Tables("tblFeeSchedule").Rows(0).Item("Default"))
    '                txtCharge.Text += decCharge.ToString
    '                'End If
    '            Next
    '        End If
    '    Else
    '        MessageBox.Show("Please enter a CPT code to charge a patient.")
    '        Exit Sub
    '    End If
    'End Sub

    Private Sub btnCharge_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCharge.Click
        'loop through cpt codes and add amount to charge
        If intChargeCount <> 0 Then
            MessageBox.Show("The charge button can only be pressed once. Please clear the form to start the transaction over or add the CPT code and amount manually.")
            Exit Sub
        End If

        Dim intCPTCount As Integer = lbCPT.Items.Count
        Dim decTotal As Decimal
        If lbCPT.Items.Count <> 0 Then
            'get index of lb

            For i = 0 To (intCPTCount - 1)
                DB.SelectQuery("SELECT InsuranceID FROM tblInsurance WHERE PatientID = '" & mintPatientID & "'", "tblInsurance")
                If DB.CountDataset.Tables("tblInsurance").Rows.Count <> 0 Then



                    strcleanCPT = Regex.Replace(lbCPT.Items(i).ToString, "[^0-9\./]", "").ToString
                    DB.SelectQuery("SELECT * FROM tblFeeSchedule WHERE tblFeeSchedule.[CPT Code] = '" & strcleanCPT & "'", "tblFeeSchedule")
                    'if the user selected BCBS as insurance
                    If cbInsurance.SelectedItem.ToString = "BCBS" Then

                        'if the DB returns a BCBS price
                        If IsDBNull(DB.CountDataset.Tables("tblFeeSchedule").Rows(0).Item("BCBS")) = False Then
                            'then add the BCBS price
                            Dim decCharge As Decimal = CDec(DB.CountDataset.Tables("tblFeeSchedule").Rows(0).Item("BCBS"))
                            decTotal += decCharge
                        Else
                            'find the default price (without insurance)
                            If IsDBNull(DB.CountDataset.Tables("tblFeeSchedule").Rows(0).Item("Default")) = False Then
                                'then keep a total of the charges
                                Dim decCharge As Decimal = CDec(DB.CountDataset.Tables("tblFeeSchedule").Rows(0).Item("Default"))
                                decTotal += decCharge
                            Else
                                'If there is no default price, then message
                                MessageBox.Show("There is no charge associated with this CPT code.")
                                'Exit Sub
                                decTotal += 0
                            End If

                        End If


                        'if the user selected UHC as insurance
                    ElseIf cbInsurance.SelectedItem.ToString = "UHC" Then
                        'if the DB returns a UHC price
                        If IsDBNull(DB.CountDataset.Tables("tblFeeSchedule").Rows(0).Item("UHC")) = False Then
                            'then add the UHC price
                            Dim decCharge As Decimal = CDec(DB.CountDataset.Tables("tblFeeSchedule").Rows(0).Item("UHC"))
                            decTotal += decCharge
                        Else
                            'find the default price (without insurance)
                            If IsDBNull(DB.CountDataset.Tables("tblFeeSchedule").Rows(0).Item("Default")) = False Then
                                'then keep a total of the charges
                                Dim decCharge As Decimal = CDec(DB.CountDataset.Tables("tblFeeSchedule").Rows(0).Item("Default"))
                                decTotal += decCharge
                            Else
                                'If there is no default price, then message
                                MessageBox.Show("There is no charge associated with this CPT code.")
                                'Exit Sub
                                decTotal += 0
                            End If
                        End If

                        'if the user selected WC as insurance
                    ElseIf cbInsurance.SelectedItem.ToString = "WC" Then
                        'if the DB returns a WC price
                        If IsDBNull(DB.CountDataset.Tables("tblFeeSchedule").Rows(0).Item("WC")) = False Then
                            'then add the WC price
                            Dim decCharge As Decimal = CDec(DB.CountDataset.Tables("tblFeeSchedule").Rows(0).Item("WC"))
                            decTotal += decCharge
                        Else
                            'find the default price (without insurance)
                            If IsDBNull(DB.CountDataset.Tables("tblFeeSchedule").Rows(0).Item("Default")) = False Then
                                'then keep a total of the charges
                                Dim decCharge As Decimal = CDec(DB.CountDataset.Tables("tblFeeSchedule").Rows(0).Item("Default"))
                                decTotal += decCharge
                            Else
                                'If there is no default price, then message
                                MessageBox.Show("There is no charge associated with this CPT code.")
                                'Exit Sub
                                decTotal += 0
                            End If
                        End If

                        'if the user selected MC as insurance
                    ElseIf cbInsurance.SelectedItem.ToString = "MC" Then
                        'if the DB returns a MC price
                        If IsDBNull(DB.CountDataset.Tables("tblFeeSchedule").Rows(0).Item("MC")) = False Then
                            'then add the MC price
                            Dim decCharge As Decimal = CDec(DB.CountDataset.Tables("tblFeeSchedule").Rows(0).Item("MC"))
                            decTotal += decCharge
                        Else
                            'find the default price (without insurance)
                            If IsDBNull(DB.CountDataset.Tables("tblFeeSchedule").Rows(0).Item("Default")) = False Then
                                'then keep a total of the charges
                                Dim decCharge As Decimal = CDec(DB.CountDataset.Tables("tblFeeSchedule").Rows(0).Item("Default"))
                                decTotal += decCharge
                            Else
                                'If there is no default price, then message
                                MessageBox.Show("There is no charge associated with this CPT code.")
                                'Exit Sub
                                decTotal += 0
                            End If
                        End If

                    Else
                        'if the user did not select any insurance
                        Dim strcleanCPT As String
                        strcleanCPT = Regex.Replace(lbCPT.Items(i).ToString, "[^0-9\./]", "").ToString
                        DB.SelectQuery("SELECT tblFeeSchedule.[Default] FROM tblFeeSchedule WHERE tblFeeSchedule.[CPT Code] = '" & strcleanCPT & "'", "tblFeeSchedule")
                        Dim dblCharge As Double
                        If IsDBNull(DB.CountDataset.Tables("tblFeeSchedule").Rows(0).Item("Default")) = False Then
                            dblCharge = DB.CountDataset.Tables("tblFeeSchedule").Rows(0).Item("Default")
                            decTotal += dblCharge

                        Else
                            'If there is no default price, then message
                            MessageBox.Show("There is no charge associated with this CPT code.")
                            'Exit Sub
                            decTotal += 0
                        End If
                    End If

                Else
                    Dim strcleanCPT As String
                    strcleanCPT = Regex.Replace(lbCPT.Items(i).ToString, "[^0-9\./]", "").ToString
                    DB.SelectQuery("SELECT tblFeeSchedule.[Default] FROM tblFeeSchedule WHERE tblFeeSchedule.[CPT Code] = '" & strcleanCPT & "'", "tblFeeSchedule")
                    Dim dblCharge As Double
                    If IsDBNull(DB.CountDataset.Tables("tblFeeSchedule").Rows(0).Item("Default")) = False Then
                        dblCharge = DB.CountDataset.Tables("tblFeeSchedule").Rows(0).Item("Default")
                        decTotal += dblCharge

                    Else
                        'If there is no default price, then message
                        MessageBox.Show("There is no charge associated with this CPT code.")
                        'Exit Sub
                        decTotal += 0
                    End If
                End If
            Next
        Else
            MessageBox.Show("Please enter a CPT code to charge a patient.")
        End If

        If txtCharge.Text <> "" Then
            decCurrentCharge = CDec(txtCharge.Text)
        Else
            decCurrentCharge = 0
        End If

        txtCharge.Text = (decTotal + decCurrentCharge).ToString
        intChargeCount += 1
    End Sub

    'Private Sub GetInsuranceToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles GetInsuranceToolStripButton.Click
    '    Try
    '        Me.TblInsuranceTableAdapter1.GetInsurance(Me.KalpaxisDBDataSet8.tblInsurance, PatientIDToolStripTextBox.Text)
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub

    Private Sub FillByToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.TblInsuranceTableAdapter1.FillBy(Me.KalpaxisDBDataSet8.tblInsurance, PatientIDToolStripTextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub lbCPT_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lbCPT.SelectedIndexChanged

    End Sub
End Class