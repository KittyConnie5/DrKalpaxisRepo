Public Class AddWriteOffTransaction
    Dim DB As New ClassDB
    Dim Valid As New ClassValidate
    Dim Calc As New ClassCalculation
    Dim mintsave As Integer
    Dim mintPatientID As Integer
    Dim decBalance As Decimal
    Dim decTotal As Decimal
    Dim decWriteOff As Decimal
    Dim strFName As String
    Dim strLName As String
    Dim decPreviousBal As Decimal
    Dim NumberOfRows As Integer
    'CODE ADDED BY OLIVIA

    Public Sub ClearForm()

        txtWriteOff.Text = ""
        lblPatient.Text = ""
        'txtCurrentBalance.Text = ""
        'txtPreviousBal.Text = ""

    End Sub

    Private Sub btnWriteOffCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWriteOffCancel.Click
        Me.Close()
        AddTransactionSelection.EnableButtons()
    End Sub

    Private Sub btnClear1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear1.Click
        ClearForm()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'validate
        If dtpDateofTransaction.Text = "" Then
            MessageBox.Show("Please enter a date.")
            Exit Sub
        End If

        If Today < CDate(dtpDateofTransaction.Text) Then
            MessageBox.Show("Transaction date cannot be in the future.")
            Exit Sub
        End If

        'add
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

        If txtWriteOff.Text <> "" Then
            decWriteOff = CDec(txtWriteOff.Text)
        Else
            decWriteOff = 0
        End If

        If txtWriteOff.Text = "" Then
            MessageBox.Show("Please enter a number in Write Off Amount.")
            Exit Sub
        End If

        If Valid.CheckMoney(txtWriteOff.Text) = False Then
            MessageBox.Show("Please enter only number and a decimal point in Write Off Amount.")
            Exit Sub
        End If

        decWriteOff = CDec(txtWriteOff.Text)

        decTotal = decBalance - decWriteOff

        txtCurrentBalance.Text = decTotal.ToString
        txtPreviousBal.Text = decBalance.ToString

        Dim datDateofTransaction As Date = CDate(dtpDateofTransaction.Text)

        'save
        DB.AddWriteOffTransaction(strFName, strLName, datDateofTransaction, mintPatientID, decWriteOff, decTotal, decBalance)
        mintsave += 1
        MessageBox.Show("Write Off Successful!")
        Me.Close()
        AddTransactionSelection.EnableButtons()
        'Refresh the patient ledger
        PatientLedger.btnRefresh.PerformClick()
    End Sub

    Private Sub AddWriteOffTransaction_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If mintsave = 0 Then
            Dim strmsg As String
            Dim strtitle As String
            Dim strstyle As MsgBoxStyle
            Dim strresponse As MsgBoxResult
            strmsg = "Are you sure you want to exit without saving?"   ' Define message.
            strstyle = MsgBoxStyle.DefaultButton2 Or _
               MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
            strtitle = "Write Off"   ' Define title.
            ' Display message.
            strresponse = MsgBox(strmsg, strstyle, strtitle)
            If strresponse = MsgBoxResult.Yes Then   ' User chose Yes.
                ' close without saving
                'ClearForm()
                AddTransactionSelection.Enabled = True
                AddTransactionSelection.EnableButtons()
            Else
                'dont close
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub AddWriteOffTransaction_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'clear
        ClearForm()

        mintPatientID = PatientLedger.intPatientID

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

        EnableForm()

    End Sub


    Public Sub DisableForm()
        txtWriteOff.Enabled = False
        'txtCurrentBalance.Enabled = False
        'txtPreviousBal.Enabled = False
        dtpDateofTransaction.Enabled = False

    End Sub
    Public Sub EnableForm()

        txtWriteOff.Enabled = True
        'txtCurrentBalance.Enabled = True
        'txtPreviousBal.Enabled = True
        dtpDateofTransaction.Enabled = True

    End Sub
End Class