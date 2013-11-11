Public Class AddPatientPaymentTransaction
    Dim DB As New ClassDB
    Dim Valid As New ClassValidate
    Dim Calc As New ClassCalculation
    Dim mintsave As Integer
    Dim mintPatientID As Integer
    Dim decBalance As Decimal
    Dim decCharge As Decimal
    Dim decAdj As Decimal
    Dim decCheck As Decimal
    Dim decCredit As Decimal
    Dim decTotal As Decimal
    Dim decCash As Decimal
    Dim strFName As String
    Dim strLName As String
    Dim decPreviousBal As Decimal
    Dim intCheckNo As Integer
    Dim strAuthorizationNo As Integer
    Dim datPaymentDate As Date
    Dim NumberOfRows As Integer
    Dim datDayofTransaction As Date

    Public Sub ClearForm()
        lblPatientName.Text = ""
        dtpPaymentDate.Text = ""
        txtCheck.Text = ""
        txtCheckNo.Text = ""
        'txtCurrentBalance.Text = ""
        'txtPreviousBal.Text = ""
        txtAdjustment.Text = ""
        txtAuthorization.Text = ""
        txtCash.Text = ""
        txtCheck.Text = ""
        txtCheckNo.Text = ""
        txtCredit.Text = ""
        txtCredit.Text = ""
        'txtCurrentBalance.Text = ""
        'txtPreviousBal.Text = ""
    End Sub

 

    Private Sub btnCancel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel2.Click
        Me.Close()
        AddTransactionSelection.EnableButtons()
    End Sub

    Private Sub btnClear1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear1.Click
        ClearForm()
    End Sub

    Private Sub txtAdjustment_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAdjustment.TextChanged
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


    Private Sub btnSave1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave1.Click
        'validate
        If txtCredit.Text <> "" Then
            If Valid.CheckMoney(txtCredit.Text) = False Then
                MessageBox.Show("Please enter only numbers and a decimal point for credit.")
                Exit Sub
            Else
            End If
        End If

        If txtCash.Text <> "" Then
            If Valid.CheckMoney(txtCash.Text) = False Then
                MessageBox.Show("Please enter only numbers and a decimal point for cash.")
                Exit Sub
            End If
        End If

        If txtAdjustment.Text <> "" Then
            If Valid.CheckMoney(txtAdjustment.Text) = False Then
                MessageBox.Show("Please enter only numbers and a decimal point for adjustment.")
                Exit Sub
            End If
        End If

        If txtAuthorization.Text <> "" Then
            If Valid.CheckAlphaNumeric(txtAuthorization.Text) = False Then
                MessageBox.Show("Please enter only numbers and letters for authorization number.")
                Exit Sub
            End If
        End If

        If txtCredit.Text <> "" Then
            If Valid.CheckMoney(txtCredit.Text) = False Then
                MessageBox.Show("Please enter only numbers and a decimal point for credit.")
                Exit Sub
            End If
        End If

        If txtCheck.Text <> "" Then
            If Valid.CheckMoney(txtCheck.Text) = False Then
                MessageBox.Show("Please enter only numbers and a decimal point for check.")
                Exit Sub
            End If
        End If

        If txtCheckNo.Text <> "" Then
            If Valid.CheckIntegerSubstring(txtCheckNo.Text) = False Then
                MessageBox.Show("Please enter only numbers for check number.")
                Exit Sub
            End If
        End If

        If dtpPaymentDate.Text = "" Then
            MessageBox.Show("Please enter a date.")
            Exit Sub
        End If

        If Today < CDate(dtpPaymentDate.Text) Then
            MessageBox.Show("Payment date cannot be in the future.")
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

        If txtCheck.Text <> "" Then
            decCheck = CDec(txtCheck.Text)
        Else
            decCheck = 0
        End If

        If Len(txtAuthorization.Text) > 10 And txtCredit.Text <> "" Then
            MessageBox.Show("Please only enter less than 10 numbers and letters in authorization.")
            Exit Sub
        End If

        'If txtCurrentBalance.Text <> "" Then
        '    decBalance = CDec(txtCurrentBalance.Text)
        'Else
        '    decBalance = 0
        'End If

        If txtCash.Text <> "" Then
            deccash = CDec(txtCash.Text)
        Else
            decCash = 0
        End If

        If txtCredit.Text <> "" And txtAuthorization.Text = "" Then
            MessageBox.Show("Please add authorization number.")
            Exit Sub
        End If

        If txtCheck.Text <> "" And txtCheckNo.Text = "" Then
            MessageBox.Show("Please add check number.")
            Exit Sub
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
            strAuthorizationNo = txtAuthorization.ToString
        Else
            strAuthorizationNo = 0
        End If



        decTotal = decBalance - (decAdj + decCheck + decCredit + decCash)

        txtPreviousBal.Text = decBalance.ToString

        txtCurrentBalance.Text = decTotal.ToString

        datPaymentDate = CDate(dtpPaymentDate.Text)

        'DB.SelectQuery("SELECT * FROM tblInsurance WHERE PatientID = '" & mintPatientID.ToString & "' AND InsuranceName like '" & ddlInsurance.SelectedItem.ToString & "'", "tblInsurance")

        'Dim intInsuranceID As Integer = (CInt(DB.CountDataset.Tables("tblInsurance").Rows(0).Item("InsuranceID")))

        'save
        DB.AddNewPatientTransaction(strFName, strLName, datPaymentDate, mintPatientID, decCredit, strAuthorizationNo, decCash, decCheck, intCheckNo, decTotal, decBalance, decAdj)
        mintsave += 1
        MessageBox.Show("Patient payment successful!")
        Me.Close()
        AddTransactionSelection.EnableButtons()
        'Refresh the patient ledger
        PatientLedger.btnRefresh.PerformClick()
    End Sub

    Private Sub AddPatientPaymentTransaction_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If mintsave = 0 Then
            Dim strmsg As String
            Dim strtitle As String
            Dim strstyle As MsgBoxStyle
            Dim strresponse As MsgBoxResult
            strmsg = "Are you sure you want to exit without saving?"   ' Define message.
            strstyle = MsgBoxStyle.DefaultButton2 Or _
               MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
            strtitle = "Patient Payment"   ' Define title.
            ' Display message.
            strresponse = MsgBox(strmsg, strstyle, strtitle)
            If strresponse = MsgBoxResult.Yes Then   ' User chose Yes.
                ' close without saving
                'ClearForm()
                AddTransactionSelection.Enabled = True
                AddTransactionSelection.EnableButtons()
                AddTransactionSelection.Show()
                PatientLedger.Refresh()
                'Me.Hide()
            Else
                'dont close
                e.Cancel = True
            End If
        End If
    End Sub
    Private Sub AddPatientPaymentTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'clear
        ClearForm()
        mintPatientID = PatientLedger.intPatientID

  

        'get name
        'DB.SelectCertainPatient("SELECT * FROM tblPatient WHERE PatientID = '" & mintPatientID & "'")
        'Dim strName As String
        'strName = CStr(DB.PatientDataset.Tables("tblPatient").Rows(0).Item("FirstName") & " " & DB.PatientDataset.Tables("tblPatient").Rows(0).Item("LastName"))
        'txtName.Text = strName
        'lblPatientName1.Text = PatientLedger.lblFirstLast.Text


        'get Patient ID from previous form
        mintPatientID = PatientLedger.intPatientID
        Dim lngID As Long
        lngID = Convert.ToInt64(mintPatientID)

        'get name from the DB
        Dim strQuery As String = "SELECT tblPatient.[FirstName], tblPatient.[LastName] FROM tblPatient WHERE tblPatient.[PatientID] = " & lngID
        DB.SelectQuery(strQuery, "tblPatient")
        'put name into Firstname + Lastname format
        strFName = DB.CountDataset.Tables("tblPatient").Rows(0)(0)
        strLName = DB.CountDataset.Tables("tblPatient").Rows(0)(1)
        'output name in textbox
        txtName.Text = strFName + " " + strLName


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

        EnableForm()

    End Sub


    Public Sub DisableForm()
        txtAdjustment.Enabled = False
        txtAuthorization.Enabled = False
        txtCash.Enabled = False
        txtCheck.Enabled = False
        txtCheckNo.Enabled = False
        txtCredit.Enabled = False
        'txtCurrentBalance.Enabled = False
        'txtPreviousBal.Enabled = False
        dtpPaymentDate.Enabled = False

    End Sub
    Public Sub EnableForm()
        txtAdjustment.Enabled = True
        txtAuthorization.Enabled = True
        txtCash.Enabled = True
        txtCheck.Enabled = True
        txtCheckNo.Enabled = True
        txtCredit.Enabled = True
        'txtCurrentBalance.Enabled = True
        'txtPreviousBal.Enabled = True
        dtpPaymentDate.Enabled = True
        
    End Sub
End Class