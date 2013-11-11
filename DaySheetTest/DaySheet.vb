'Imports System.Data.OleDb
Imports System.Text.RegularExpressions
Public Class DaySheet
    Dim Val As New ClassValidate
    Dim DB As New ClassDB
    Dim Calc As New ClassCalculation
    Dim intPatientID As Integer
    Dim strDate As Date

    Private Function PaymentsTotal() As Double


        Dim dblPayments As Double
        Dim i As Integer
        Dim decCredit As Decimal
        Dim decCheck As Decimal
        Dim decCash As Decimal
        For i = 0 To DB.CountDataset.Tables("tblTransaction").Rows.Count - 1
            If DB.CountDataset.Tables("tblTransaction").Rows(i)(10) Is Nothing OrElse IsDBNull(DB.CountDataset.Tables("tblTransaction").Rows(i)(10)) Then
                decCredit = 0
            Else
                decCredit = DB.CountDataset.Tables("tblTransaction").Rows(i)(10)
            End If
            If DB.CountDataset.Tables("tblTransaction").Rows(i)(7) Is Nothing OrElse IsDBNull(DB.CountDataset.Tables("tblTransaction").Rows(i)(7)) Then
                decCheck = 0
            Else
                decCheck = DB.CountDataset.Tables("tblTransaction").Rows(i)(7)
            End If

            If DB.CountDataset.Tables("tblTransaction").Rows(i)(9) Is Nothing OrElse IsDBNull(DB.CountDataset.Tables("tblTransaction").Rows(i)(9)) Then
                decCash = 0
            Else
                decCash = DB.CountDataset.Tables("tblTransaction").Rows(i)(9)
            End If

            dblPayments = dblPayments + decCheck + decCash + decCredit

        Next i

        Return dblPayments



    End Function

    Private Function ChargeTotal()

        Dim dblCharge As Double
        Dim i As Integer
        Dim decCharge As Decimal
        For i = 0 To DB.CountDataset.Tables("tblTransaction").Rows.Count - 1
            If DB.CountDataset.Tables("tblTransaction").Rows(i)(6) Is Nothing OrElse IsDBNull(DB.CountDataset.Tables("tblTransaction").Rows(i)(6)) Then
                decCharge = 0
            Else
                decCharge = DB.CountDataset.Tables("tblTransaction").Rows(i)(6)
            End If
            dblCharge = dblCharge + decCharge
        Next i
        Return dblCharge



    End Function

    Private Function TotalRecTotal()

        Dim dblTotalRecTotal As Double

        dblTotalRecTotal = ChargeTotal() - PaymentsTotal()


        Return dblTotalRecTotal
    End Function

    Private Sub btnSubmitbyDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmitbyDate.Click

        'If ddlmonth.Text(ddlmonth.SelectedItem) <> ddlmonth.SelectedItem() Then
        '    MessageBox.Show("Wrong")
        'End If


        'get month from combobox
        If ddlmonth.SelectedItem() Then
            Dim intMonth As New Integer
            intMonth = ddlmonth.SelectedItem()
            DB.SelectQuery("SELECT tblPatient.FirstName + ' ' + tblPatient.LastName AS Name,  tblTransaction.[ReceiptNumber] AS [Receipt Number], tblTransaction.[TransDate] AS [Transaction Date], tblTransaction.[RefDate] As [Reference Date], tblTransaction.[Adjustments], tblTransaction.[PatientID], tblTransaction.[Charge], tblTransaction.[Check], tblTransaction.[CheckNo] AS [Check Number], tblTransaction.[Cash], tblTransaction.[Credit], tblTransaction.[AuthorizationNo] AS [Authorization Number], tblTransaction.[CurrentBal] AS [Current Balance], tblTransaction.[PrevBal] As [Previous Balance], tblTransaction.[InsuranceID] AS [Insurance ID], tblTransaction.[WriteOff], tblTransaction.[NeedToFile] AS [Need to File]  FROM tblTransaction INNER JOIN tblPatient ON tblTransaction.PatientID = tblPatient.PatientID WHERE month( tblTransaction.[TransDate]) = " & intMonth & "", "tblTransaction")
            gvDaySheet.DataSource = DB.CountDataset.Tables("tblTransaction")
            'reset ddlmonth
            ddlmonth.SelectedIndex = -1

        End If

        'get year from combobox
        If ddlyear.SelectedItem() Then
            Dim intYear As New Integer
            intYear = ddlyear.SelectedItem()
            DB.SelectQuery("SELECT tblPatient.FirstName + ' ' + tblPatient.LastName AS Name,  tblTransaction.[ReceiptNumber] AS [Receipt Number], tblTransaction.[TransDate] AS [Transaction Date], tblTransaction.[RefDate] As [Reference Date], tblTransaction.[Adjustments], tblTransaction.[PatientID], tblTransaction.[Charge], tblTransaction.[Check], tblTransaction.[CheckNo] AS [Check Number], tblTransaction.[Cash], tblTransaction.[Credit], tblTransaction.[AuthorizationNo] AS [Authorization Number], tblTransaction.[CurrentBal] AS [Current Balance], tblTransaction.[PrevBal] As [Previous Balance], tblTransaction.[InsuranceID] AS [Insurance ID], tblTransaction.[WriteOff], tblTransaction.[NeedToFile] AS [Need to File]   FROM tblTransaction INNER JOIN tblPatient ON tblTransaction.PatientID = tblPatient.PatientID WHERE year( tblTransaction.[TransDate]) = " & intYear & "", "tblTransaction")
            gvDaySheet.DataSource = DB.CountDataset.Tables("tblTransaction")
            'reset ddlyear
            ddlyear.SelectedIndex = -1
        End If

        'get month and year
        If ddlmonth.SelectedItem And ddlyear.SelectedItem Then
            Dim intMonth As New Integer
            intMonth = ddlmonth.SelectedItem()
            Dim intYear As New Integer
            intYear = ddlyear.SelectedItem()
            DB.SelectQuery("SELECT tblPatient.FirstName + ' ' + tblPatient.LastName AS Name,  tblTransaction.[ReceiptNumber] AS [Receipt Number], tblTransaction.[TransDate] AS [Transaction Date], tblTransaction.[RefDate] As [Reference Date], tblTransaction.[Adjustments], tblTransaction.[PatientID], tblTransaction.[Charge], tblTransaction.[Check], tblTransaction.[CheckNo] AS [Check Number], tblTransaction.[Cash], tblTransaction.[Credit], tblTransaction.[AuthorizationNo] AS [Authorization Number], tblTransaction.[CurrentBal] AS [Current Balance], tblTransaction.[PrevBal] As [Previous Balance], tblTransaction.[InsuranceID] AS [Insurance ID], tblTransaction.[WriteOff], tblTransaction.[NeedToFile] AS [Need to File]  FROM tblTransaction INNER JOIN tblPatient ON tblTransaction.PatientID = tblPatient.PatientID WHERE month( tblTransaction.[TransDate]) = " & intMonth & " AND year(tblTransaction.[TransDate]) = " & intYear & "", "tblTransaction")
            gvDaySheet.DataSource = DB.CountDataset.Tables("tblTransaction")
            'reset ddl
            ddlmonth.SelectedIndex = -1
            ddlyear.SelectedIndex = -1
            Exit Sub
        End If

        'calulate total
        txtPaymentTotal.Text = PaymentsTotal()
        txtChargeTotal.Text = ChargeTotal()
        txtTotalRec.Text = TotalRecTotal()





        'Hide patient ID Column
        gvDaySheet.Columns("PatientID").Visible = False







        'If Val.CheckIntegerSubstring(ddlmonth.Text) = False Or ddlmonth.Text > 12 Or ddlmonth.Text < 1 Then
        '    MessageBox.Show("Please input a correct month number")
        '    Exit Sub
        'End If

        ' ''fill Proof of Posting
        ''DB.QuaternarySelectQuery("SELECT SUM(PrevBal) AS [Previous Balance], SUM(Charge) AS [Charge], SUM(Payments) + SUM(Adjustments) AS [PayAdj], SUM(CurrentBal) AS [Current Balance] FROM tblTransaction WHERE TransDate like '" & dtTransDate.Text & "'", "tblTransaction")
        ''fill textboxes if transactions exist
        'If DB.QuaternaryCountDataset.Tables("tblTransaction").Rows.Count <> 0 Then
        '    txtPrevBalTotal.Text = DB.QuaternaryCountDataset.Tables("tblTransaction").Rows(0).Item("Previous Balance").ToString
        '    txtChargeTotal1.Text = DB.QuaternaryCountDataset.Tables("tblTransaction").Rows(0).Item("Charge").ToString
        '    txtChargeTotal2.Text = DB.QuaternaryCountDataset.Tables("tblTransaction").Rows(0).Item("Charge").ToString
        '    txtPymtAdjs1.Text = DB.QuaternaryCountDataset.Tables("tblTransaction").Rows(0).Item("PayAdj").ToString
        '    txtPymtAdjs2.Text = DB.QuaternaryCountDataset.Tables("tblTransaction").Rows(0).Item("PayAdj").ToString
        '    lblCurrentBalTotal.Text = DB.QuaternaryCountDataset.Tables("tblTransaction").Rows(0).Item("Current Balance").ToString
        'Else
        '    Exit Sub
        'End If

        ''calculate SubTotal
        'If txtPrevBalTotal.Text <> "" Or txtChargeTotal1.Text <> "" Then
        '    Calc.CalculateSubTotal(Convert.ToDecimal(Me.txtPrevBalTotal.Text), Convert.ToDecimal(Me.txtChargeTotal1.Text))
        'Else
        '    Exit Sub
        'End If

        ''fill SubTotal textbox
        'Me.txtSubTotal1.Text = Calc.SubTotalAmount.ToString

        ''calculate Current Balance Total
        'If txtSubTotal1.Text <> "" Or txtPymtAdjs1.Text <> "" Then
        '    Calc.CalculateCurrentBalTotal(Convert.ToDecimal(Me.txtSubTotal1.Text), Convert.ToDecimal(Me.txtPymtAdjs1.Text))
        'Else
        '    Exit Sub
        'End If

        ''fill Current Balance Total textbox
        'Me.txtCurrentBalTotal.Text = Calc.CurrentBalAmount.ToString

        ''fill Accounts Receivable Control
        'DB.TertiarySelectQuery("SELECT SUM(CurrentBal) AS [Current Balance] FROM tblTransaction WHERE TransDate < #" & dtDate & "#", "tblTransaction")
        ''fill textboxes if transactions exist
        'If DB.TertiaryCountDataset.Tables("tblTransaction").Rows.Count <> 0 Then
        '    txtPrevDaysTotal.Text = DB.TertiaryCountDataset.Tables("tblTransaction").Rows(0).Item("Current Balance").ToString
        'Else
        '    Exit Sub
        'End If

        ''calculate SubTotal
        'If txtPrevDaysTotal.Text = "" Then
        '    txtPrevDaysTotal.Text = "0"
        'End If

        'If txtPrevDaysTotal.Text <> "" Or txtChargeTotal2.Text <> "" Then
        '    Calc.CalculateSubTotal(Convert.ToDecimal(Me.txtPrevDaysTotal.Text), Convert.ToDecimal(Me.txtChargeTotal2.Text))
        'Else
        '    Exit Sub
        'End If

        ''fill SubTotal textbox
        'Me.txtSubTotal2.Text = Calc.SubTotalAmount.ToString

        ''calculate Total Accts. Rec.
        'If txtSubTotal2.Text <> "" Or txtPymtAdjs2.Text <> "" Then
        '    Calc.CalculateAcctsRecTotal(Convert.ToDecimal(Me.txtSubTotal2.Text), Convert.ToDecimal(Me.txtPymtAdjs2.Text))
        'Else
        '    Exit Sub
        'End If

        ''fill total accts. rec. textbox 1
        'Me.txtTotalAcctsRec1.Text = Calc.TotalAcctsRec.ToString

        ''fill Accounts Receivable Proof
        'DB.QuinarySelectQuery("SELECT SUM(CurrentBal) AS [Current Balance] FROM tblTransaction WHERE TransDate < #" & FirstMonth & "#", "tblTransaction")
        'If DB.QuinaryCountDataset.Tables("tblTransaction").Rows.Count <> 0 Then
        '    txtFirstofMonth.Text = DB.QuinaryCountDataset.Tables("tblTransaction").Rows(0).Item("Current Balance").ToString
        'Else
        '    Exit Sub
        'End If

        ''fill Plus Charge Mo. to Date
        'Dim dtYear As Integer
        'Dim dtMonth As Integer
        'Dim dtDay As Integer

        'dtYear = dtDate.Year
        'dtMonth = dtDate.Month
        'dtDay = dtDate.Day

        'DB.SenarySelectQuery("SELECT SUM(Charge) AS [Total Charge], SUM(Payments) + SUM(Adjustments) AS [PayAdj] FROM (SELECT TransDate, Charge, Payments, Adjustments FROM tblTransaction WHERE (YEAR(TransDate) = '" & dtYear & "') AND (Month(TransDate) = '" & dtMonth & "') AND ((Day(TransDate) >= 1) AND (Day(Transdate) <= '" & dtDay & "')))", "tblTransaction")
        'If DB.SenaryCountDataset.Tables("tblTransaction").Rows.Count <> 0 Then
        '    txtChargeMoToDate.Text = DB.SenaryCountDataset.Tables("tblTransaction").Rows(0).Item("Total Charge").ToString
        '    txtPymtAdjs3.Text = DB.SenaryCountDataset.Tables("tblTransaction").Rows(0).Item("PayAdj").ToString
        'Else
        '    Exit Sub
        'End If



        ''calculate subtotal
        'If txtFirstofMonth.Text = "" Then
        '    txtFirstofMonth.Text = "0"
        'End If


        'If txtFirstofMonth.Text <> "" Or txtChargeMoToDate.Text <> "" Then
        '    Calc.CalculateSubTotal(Convert.ToDecimal(Me.txtFirstofMonth.Text), Convert.ToDecimal(Me.txtChargeMoToDate.Text))
        'Else
        '    Exit Sub
        'End If


        ''fill subtotal textbox
        'Me.txtSubTotal3.Text = Calc.SubTotalAmount.ToString

        ''calculate total accts. rec.
        'If txtSubTotal3.Text <> "" Or txtPymtAdjs3.Text <> "" Then
        '    Calc.CalculateAcctsRecTotal(Convert.ToDecimal(Me.txtSubTotal3.Text), Convert.ToDecimal(Me.txtPymtAdjs3.Text))
        'Else
        '    Exit Sub
        'End If

        ''fill total accts. rec. textbox 2
        'Me.txtTotalAcctsRec2.Text = Calc.TotalAcctsRec.ToString

    End Sub

    Private Sub btnShowToday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowToday.Click

        'Show Today's Transactions
        Dim datdate As Date
        datdate = Today.Date
        DB.SelectQuery("SELECT tblPatient.FirstName + ' ' + tblPatient.LastName AS Name,  tblTransaction.[ReceiptNumber] AS [Receipt Number], tblTransaction.[TransDate] AS [Transaction Date], tblTransaction.[RefDate] As [Reference Date], tblTransaction.[Adjustments], tblTransaction.[PatientID], tblTransaction.[Charge], tblTransaction.[Check], tblTransaction.[CheckNo] AS [Check Number], tblTransaction.[Cash], tblTransaction.[Credit], tblTransaction.[AuthorizationNo] AS [Authorization Number], tblTransaction.[CurrentBal] AS [Current Balance], tblTransaction.[PrevBal] As [Previous Balance], tblTransaction.[InsuranceID] AS [Insurance ID], tblTransaction.[WriteOff], tblTransaction.[NeedToFile] AS [Need to File]  FROM tblTransaction INNER JOIN tblPatient ON tblTransaction.PatientID = tblPatient.PatientID WHERE tblTransaction.[TransDate] = " & datdate & "", "tblTransaction")
        gvDaySheet.DataSource = DB.CountDataset.Tables("tblTransaction")

        'calulate total
        txtPaymentTotal.Text = PaymentsTotal()
        txtChargeTotal.Text = ChargeTotal()
        txtTotalRec.Text = TotalRecTotal()



        'Hide patient ID Column
        gvDaySheet.Columns("PatientID").Visible = False


        ''declare variables
        'Dim dtDate As Date

        ''get date
        'dtDate = dtTransDate.Text

        'show all transactions
        'DB.SelectQuery("SELECT TransDate AS [Date], Insurance AS [Reference], Charge, Payments, Adjustments, CurrentBal AS [Current Balance], PrevBal AS [Previous Balance], FirstName + ' ' + LastName AS [Name], Receipt AS [Receipt Number], Cash, Check, Credit, Deposit AS [Direct Deposit], Summary AS [Business Analysis Summaries] FROM tblTransaction", "tblTransaction")
        'DB.SelectQuery("SELECT * FROM tblTransaction", "tblTransaction")
        'gvDaySheet.DataSource = DB.CountDataset.Tables("tblTransaction")

        'Dim datDate As Date
        'datDate = Date.Today

        'datDate = CDate(Regex.Replace(datDate.ToString, "[^0-9\//]", ""))
        'trim datDate to only 2 month numbers

        'if month is blank then
        ' LIKE %'" & strYear & "'"

        'if month <> "" and year <> "" then
        'LIKE '" strMonth & "%'" AND 
        'gvDaySheet.DataSource = DB.CountDataset.Tables("tblTransaction")


        'Dim strName As String
        'If DB.CountDataset.Tables("tblTransaction").Rows.Count <> 0 Then
        '    strName = DB.CountDataset.Tables("tblTranaction").Rows.Item("PatientID").ToString
        'Else
        '    MessageBox.Show("Please select a correct date.")
        '    Exit Sub
        'End If
        'DB.SelectQuery("SELECT FirstName + ' ' + LastName as Name FROM tblPatient WHERE PatientID = '" & strName & "'", "tblPatient")

        'strName = DB.CountDataset.Tables("tblPatient").Rows.Item("Name").ToString

        'Dim col As New DataGridViewTextBoxColumn
        'col.DataPropertyName = "PropertyName"
        'col.HeaderText = "Name"
        'col.Name = "Name"
        'gvDaySheet.Columns.Add(col)

        'gvDaySheet.(DB.CountDataset.Tables("tblPatient").Rows.Item("Name").ToString)

        'Label33.Text = strName
    End Sub

    'Public Sub SetFormtoNormal()
    '    'Clear Proof of Posting
    '    txtPrevBalTotal.Text = ""
    '    txtChargeTotal1.Text = ""
    '    txtSubTotal1.Text = ""
    '    txtPymtAdjs1.Text = ""
    '    txtCurrentBalTotal.Text = ""

    '    'Clear Accounts Receivable Control
    '    txtPrevDaysTotal.Text = ""
    '    txtChargeTotal2.Text = ""
    '    txtSubTotal2.Text = ""
    '    txtPymtAdjs2.Text = ""
    '    txtTotalAcctsRec1.Text = ""

    '    'Clear Accounts Receivable Proof
    '    txtFirstofMonth.Text = ""
    '    txtChargeMoToDate.Text = ""
    '    txtSubTotal3.Text = ""
    '    txtPymtAdjs3.Text = ""
    '    txtTotalAcctsRec2.Text = ""

    'End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub DaySheet_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Home.Show()
        Me.Hide()
    End Sub



    Private Sub DaySheet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        'Get today's transaction
        Dim datdate As Date
        datdate = Today.Date
        DB.SelectQuery("SELECT tblPatient.FirstName + ' ' + tblPatient.LastName AS Name,  tblTransaction.[ReceiptNumber] AS [Receipt Number], tblTransaction.[TransDate] AS [Transaction Date], tblTransaction.[RefDate] As [Reference Date], tblTransaction.[Adjustments], tblTransaction.[PatientID], tblTransaction.[Charge], tblTransaction.[Check], tblTransaction.[CheckNo] AS [Check Number], tblTransaction.[Cash], tblTransaction.[Credit], tblTransaction.[AuthorizationNo] AS [Authorization Number], tblTransaction.[CurrentBal] AS [Current Balance], tblTransaction.[PrevBal] As [Previous Balance], tblTransaction.[InsuranceID] AS [Insurance ID], tblTransaction.[WriteOff], tblTransaction.[NeedToFile] AS [Need to File]  FROM tblTransaction INNER JOIN tblPatient ON tblTransaction.PatientID = tblPatient.PatientID WHERE tblTransaction.[TransDate] = " & datdate & "", "tblTransaction")
        gvDaySheet.DataSource = DB.CountDataset.Tables("tblTransaction")

        'Hide patient ID Column
        gvDaySheet.Columns("PatientID").Visible = False

        'calulate total
        txtPaymentTotal.Text = PaymentsTotal()
        txtChargeTotal.Text = ChargeTotal()
        txtTotalRec.Text = TotalRecTotal()




    End Sub

    Private Sub btnShowAll_Click(sender As System.Object, e As System.EventArgs) Handles btnShowAll.Click

        DB.SelectQuery("SELECT tblPatient.FirstName + ' ' + tblPatient.LastName AS Name,  tblTransaction.[ReceiptNumber] AS [Receipt Number], tblTransaction.[TransDate] AS [Transaction Date], tblTransaction.[RefDate] As [Reference Date], tblTransaction.[Adjustments], tblTransaction.[PatientID], tblTransaction.[Charge], tblTransaction.[Check], tblTransaction.[CheckNo] AS [Check Number], tblTransaction.[Cash], tblTransaction.[Credit], tblTransaction.[AuthorizationNo] AS [Authorization Number], tblTransaction.[CurrentBal] AS [Current Balance], tblTransaction.[PrevBal] As [Previous Balance], tblTransaction.[InsuranceID] AS [Insurance ID], tblTransaction.[WriteOff], tblTransaction.[NeedToFile] AS [Need to File]  FROM tblTransaction INNER JOIN tblPatient ON tblTransaction.PatientID = tblPatient.PatientID", "tblTransaction")
        gvDaySheet.DataSource = DB.CountDataset.Tables("tblTransaction")


        'Hide patient ID Column
        gvDaySheet.Columns("PatientID").Visible = False

        'calulate total
        txtPaymentTotal.Text = PaymentsTotal()
        txtChargeTotal.Text = ChargeTotal()
        txtTotalRec.Text = TotalRecTotal()


    End Sub
End Class

