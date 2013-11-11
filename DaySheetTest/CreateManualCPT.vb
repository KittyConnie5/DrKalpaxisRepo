Public Class CreateManualCPT
    Dim Valid As New ClassValidate
    Dim mintSave As Integer = 0
    Dim decCharge As Decimal
    Dim decTotalCharge As Decimal
    Dim decCPT As Decimal
    Dim decTotal As Decimal
    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        txtManualAmount.Text = ""
        txtManualCPTCode.Text = ""
    End Sub

    Private Sub btnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnSubmit.Click
        'validate
        If txtManualAmount.Text = "" Then
            MessageBox.Show("Please enter an amount to charge.")
            Exit Sub
        End If

        If txtManualCPTCode.Text = "" Then
            MessageBox.Show("Please enter a CPT code.")
            Exit Sub
        End If

        If Valid.CheckMoney(txtManualAmount.Text) = False Then
            MessageBox.Show("Please use only numbers and decimals in Amount.")
            Exit Sub
        End If

        If Valid.CheckMoney(txtManualCPTCode.Text) = False Then
            MessageBox.Show("Please use only numbers and decimals in CPT code.")
            Exit Sub
        End If

        'save
        'add cpt
        decCPT = CDec(txtManualCPTCode.Text)
        AddVisitTransaction.lvManual.Items.Add(decCPT)

        'add cost
        decCharge = CDec(txtManualAmount.Text)

        If AddVisitTransaction.txtCharge.Text <> "" Then
            decTotalCharge = CDec(AddVisitTransaction.txtCharge.Text)
        Else
            decTotalCharge = 0
        End If

        decTotal = decTotalCharge + decCharge

        AddVisitTransaction.txtCharge.Text = decTotal.ToString

        'success
        MessageBox.Show("CPT Code and Amount successfully added to transaction!")
        mintSave += 1
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


    Private Sub CreateManualCPT_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If mintSave = 0 Then
            Dim strmsg As String
            Dim strtitle As String
            Dim strstyle As MsgBoxStyle
            Dim strresponse As MsgBoxResult
            strmsg = "Are you sure you want to exit without submitting?"   ' Define message.
            strstyle = MsgBoxStyle.DefaultButton2 Or _
               MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
            strtitle = "Manual CPT Code"   ' Define title.
            ' Display message.
            strresponse = MsgBox(strmsg, strstyle, strtitle)
            If strresponse = MsgBoxResult.Yes Then   ' User chose Yes.
                ' close without saving
                'ClearForm()
                AddVisitTransaction.Enabled = True
                AddVisitTransaction.EnableForm()
                AddVisitTransaction.Show()
                Me.Hide()
            Else
                'dont close
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub CreateManualCPT_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class