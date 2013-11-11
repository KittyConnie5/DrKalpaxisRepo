Public Class AddInsurancePaymentTransaction
    Dim DB As New ClassDB
    Dim Valid As New ClassValidate
    Dim Calc As New ClassCalculation
    Dim mintsave As Integer
    Dim mintPatientID As Integer
    Dim datDateofTransaction As Date
    Dim decBalance As Decimal
    Dim decCharge As Decimal
    Dim decAdj As Decimal
    Dim decCheck As Decimal
    Dim decCredit As Decimal
    Dim decTotal As Decimal
    Dim strFName As String
    Dim strLName As String
    Dim datPaymentDate As Date
    Dim intInsuranceID As Integer
    Dim decPreviousBal As Decimal
    Dim intCheckNo As Integer
    Dim intAuthorizationNo As Integer
    Dim NumOfRows As Integer
    Public Sub ClearForm()
        'code added by OLIVIA
        lblPatientName.Text = ""
        dtpPaymentDate.Text = ""
        dtpTransactionDate.Text = ""
        ddlInsurance.Text = ""
        txtCheck.Text = ""
        txtCheckNo.Text = ""
        'txtCurrentBalance.Text = ""
        'txtPreviousBal.Text = ""

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        'Call sub to clear the form
        ClearForm()
    End Sub
    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        'validate
        'validate - ADDED BY OLIVIA

        If txtCheck.Text = "" Then
            MessageBox.Show("Please enter an amount for check.")
            Exit Sub
        End If

        If txtCheck.Text <> "" Then
            If Valid.CheckMoney(txtCheck.Text) = False Then
                MessageBox.Show("Please enter only numbers and a decimal point.")
                Exit Sub
            End If
        End If

        If txtCheckNo.Text <> "" Then
            If Valid.CheckIntegerSubstring(txtCheckNo.Text) = False Then
                MessageBox.Show("Please enter only numbers.")
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

        If dtpTransactionDate.Text = "" Then
            MessageBox.Show("Please enter a date.")
            Exit Sub
        End If

        If Today < CDate(dtpTransactionDate.Text) Then
            MessageBox.Show("Transaction date cannot be in the future.")
            Exit Sub
        End If

        If txtCheck.Text <> "" And txtCheckNo.Text = "" Then
            MessageBox.Show("Please add check number.")
            Exit Sub
        End If

        'add

        If txtCheckNo.Text <> "" Then
            intCheckNo = CInt(txtCheckNo.Text)
        Else
            intCheckNo = 0
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

        If txtCheck.Text <> "" And txtCheckNo.Text = "" Then
            MessageBox.Show("Please add check number.")
            Exit Sub
        End If

        decTotal = decBalance - decCheck

        datDateofTransaction = CDate(dtpTransactionDate.Text)

        datPaymentDate = CDate(dtpPaymentDate.Text)

        DB.SelectQuery("SELECT InsuranceID FROM tblInsurance WHERE PatientID = '" & mintPatientID.ToString & "'", "tblInsurance")

        If DB.CountDataset.Tables("tblInsurance").Rows.Count <> 0 Then
            intInsuranceID = (CInt(DB.CountDataset.Tables("tblInsurance").Rows(0).Item("InsuranceID")))
        End If

        txtCurrentBalance.Text = decTotal.ToString
        txtPreviousBal.Text = decBalance.ToString

        'save
        DB.AddNewInsuranceTransaction(strFName, strLName, datDateofTransaction, datPaymentDate, intInsuranceID, decCheck, intCheckNo, decTotal, decBalance, mintPatientID)
        mintsave += 1
        MessageBox.Show("Insurance payment successful!")
        Me.Close()
        AddTransactionSelection.EnableButtons()
        'Refresh the patient ledger
        PatientLedger.btnRefresh.PerformClick()
    End Sub
    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'Close the form
        'CODE ADDED BY OLIVIA
        Me.Close()
        AddTransactionSelection.EnableButtons()
    End Sub

    Private Sub AddInsurancePaymentTransaction_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If mintsave = 0 Then
            Dim strmsg As String
            Dim strtitle As String
            Dim strstyle As MsgBoxStyle
            Dim strresponse As MsgBoxResult
            strmsg = "Are you sure you want to exit without saving?"   ' Define message.
            strstyle = MsgBoxStyle.DefaultButton2 Or _
               MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
            strtitle = "Insurance Payment"   ' Define title.
            ' Display message.
            strresponse = MsgBox(strmsg, strstyle, strtitle)
            If strresponse = MsgBoxResult.Yes Then   ' User chose Yes.
                ' close without saving
                'ClearForm()
                AddTransactionSelection.Enabled = True
                AddTransactionSelection.EnableButtons()
                PatientLedger.Refresh()
            Else
                'dont close
                e.Cancel = True
            End If
        End If
    End Sub
    ' Private Sub AddInsurancePaymentTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    ' mintsave = 0
    'End Sub

    Private Sub AddInsurancePaymentTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KalpaxisDBDataSet11.tblInsurance' table. You can move, or remove it, as needed.
        Me.TblInsuranceTableAdapter2.Fill(Me.KalpaxisDBDataSet11.tblInsurance)

        'clear
        ClearForm()
        txtCheck.Focus()
        'TODO: This line of code loads data into the 'KalpaxisDBDataSet9.tblInsurance' table. You can move, or remove it, as needed.
        'Me.TblInsuranceTableAdapter1.Fill(Me.KalpaxisDBDataSet9.tblInsurance)
        'TODO: This line of code loads data into the 'KalpaxisDBDataSet8.tblInsurance' table. You can move, or remove it, as needed.
        'Me.TblInsuranceTableAdapter.Fill(Me.KalpaxisDBDataSet8.tblInsurance)
        mintPatientID = PatientLedger.intPatientID
        DB.GetPreviousBalance(mintPatientID)

        'get name
        'DB.SelectCertainPatient("SELECT * FROM tblPatient WHERE PatientID = '" & mintPatientID & "'")
        'Dim strName As String
        'strName = CStr(DB.PatientDataset.Tables("tblPatient").Rows(0).Item("FirstName") & " " & DB.PatientDataset.Tables("tblPatient").Rows(0).Item("LastName"))
        'txtName.Text = strName
        'lblPatientName.Text = PatientLedger.lblFirstLast.Text

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
        NumOfRows = ((DB.CountDataset.Tables("tblTransaction").Rows.Count) - 1)
        If NumOfRows = -1 Then
            decBalance = 0
            decPreviousBal = 0
        Else

            If IsDBNull(DB.CountDataset.Tables("tblTransaction").Rows(NumOfRows).Item("CurrentBal")) = False Then
                decBalance = CDec(DB.CountDataset.Tables("tblTransaction").Rows(NumOfRows).Item("CurrentBal"))
            Else
                decBalance = 0
            End If


            If IsDBNull(DB.CountDataset.Tables("tblTransaction").Rows(NumOfRows).Item("PrevBal")) = False Then
                decPreviousBal = CDec(DB.CountDataset.Tables("tblTransaction").Rows(NumOfRows).Item("PrevBal"))
            Else
                decPreviousBal = 0
            End If
        End If

        txtCurrentBalance.Text = decBalance.ToString
        txtPreviousBal.Text = decPreviousBal.ToString

        PatientIDToolStripTextBox.Text = lngID.ToString
        FillBy3ToolStripButton.PerformClick()

        EnableForm()

    End Sub


    Public Sub DisableForm()
        txtCheck.Enabled = False
        txtCheckNo.Enabled = False
        'txtCurrentBalance.Enabled = False
        'txtPreviousBal.Enabled = False
        ddlInsurance.Enabled = False
        dtpPaymentDate.Enabled = True
        dtpTransactionDate.Enabled = True
    End Sub

    Public Sub EnableForm()
        txtCheck.Enabled = True
        'txtCurrentBalance.Enabled = True
        'txtPreviousBal.Enabled = True
        txtCheckNo.Enabled = True
        ddlInsurance.Enabled = True
        dtpPaymentDate.Enabled = True
        dtpTransactionDate.Enabled = True

    End Sub

    Private Sub FillBy3ToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles FillBy3ToolStripButton.Click
        Try
            Me.TblInsuranceTableAdapter.FillBy3(Me.KalpaxisDBDataSet8.tblInsurance, PatientIDToolStripTextBox.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class