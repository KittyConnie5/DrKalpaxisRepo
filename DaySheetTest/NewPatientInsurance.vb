Imports System.Web
Public Class NewPatientInsurance
    Dim Val As New ClassValidate
    Dim DB As New ClassDB
    Dim mintSave As Integer = 0
    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click
        'code
        'remove apostrophe
        txtPriInsName.Text.Replace("'", "")
        txtSecInsName.Text.Replace("'", "")
        txtTerInsName.Text.Replace("'", "")
        txtClaimsAddress.Text.Replace("'", "")
        txtTerInsAddress.Text.Replace("'", "")
        txtSecInsAddress.Text.Replace("'", "")
        txtClaimsCity.Text.Replace("'", "")
        txtSecInsCity.Text.Replace("'", "")
        txtTerInsCity.Text.Replace("'", "")

        'trim text of spaces
        RTrim(txtPriInsName.Text)
        RTrim(txtInsuranceID.Text)
        RTrim(txtInsGroup.Text)
        RTrim(txtClaimsAddress.Text)
        RTrim(txtClaimsCity.Text)
        RTrim(txtSecInsName.Text)
        RTrim(txtSecInsID.Text)
        RTrim(txtSecInsGroupNo.Text)
        RTrim(txtSecInsAddress.Text)
        RTrim(txtSecInsCity.Text)
        RTrim(txtTerInsName.Text)
        RTrim(txtTerInsID.Text)
        RTrim(txtTerInsGroupNo.Text)
        RTrim(txtTerInsAddress.Text)
        RTrim(txtTerInsCity.Text)

        'validate 
        If Val.CheckLetterSubstring(txtPriInsName.Text) = False Then
            MessageBox.Show("Insurance provider must contain only letters")
            Exit Sub
        End If
        If Val.CheckLetterSubstring(txtSecInsName.Text) = False Then
            MessageBox.Show("Insurance provider must contain only letters")
            Exit Sub
        End If
        If Val.CheckLetterSubstring(txtTerInsName.Text) = False Then
            MessageBox.Show("Insurance provider must contain only letters")
            Exit Sub
        End If
        If Val.CheckLetterSubstring(txtClaimsCity.Text) = False Then
            MessageBox.Show("City name must contain only letters")
            Exit Sub
        End If
        If Val.CheckLetterSubstring(txtSecInsCity.Text) = False Then
            MessageBox.Show("City name must contain only letters")
            Exit Sub
        End If
        If Val.CheckLetterSubstring(txtTerInsCity.Text) = False Then
            MessageBox.Show("City name must contain only letters")
            Exit Sub
        End If

        'Zip Codes
        If Val.checkzipcode(txtClaimsZip.Text) = False Then
            MessageBox.Show("Zip code must be numeric")
            Exit Sub
        End If
        If Val.checkzipcode(txtSecInsZip.Text) = False Then
            MessageBox.Show("Zip code must be numeric")
            Exit Sub
        End If
        If Val.checkzipcode(txtTerInsZip.Text) = False Then
            MessageBox.Show("Zip code must be numeric")
            Exit Sub
        End If

        If txtClaimsZip.Text <> "" Then
            If Len(txtClaimsZip.Text) < 5 Then
                MessageBox.Show("Primary insurance zip code must be at least 5 numbers.")
                Exit Sub
            End If
        End If

        If txtSecInsZip.Text <> "" Then
            If Len(txtSecInsZip.Text) < 5 Then
                MessageBox.Show("Secondary insurance zip code must be at least 5 numbers.")
                Exit Sub
            End If
        End If

        If txtTerInsZip.Text <> "" Then
            If Len(txtTerInsZip.Text) < 5 Then
                MessageBox.Show("Tertiary insurance zip code must be at least 5 numbers.")
                Exit Sub
            End If
        End If

        'Phone
        If Val.CheckPhone(txtClaimsPhone.Text) = False Then
            MessageBox.Show("Phone number must be numeric")
            Exit Sub
        End If
        If Val.CheckPhone(txtSecInsPhone.Text) = False Then
            MessageBox.Show("Phone number must be numeric")
            Exit Sub
        End If
        If Val.CheckPhone(txtTerInsPhone.Text) = False Then
            MessageBox.Show("Phone number must be numeric")
            Exit Sub
        End If

        'Connie Meng 11/10/13 changed 9 to 10
        If txtClaimsPhone.Text <> "" Then
            If Len(txtClaimsPhone.Text) < 10 Then
                MessageBox.Show("Primary insurance phone must be at least nine numbers.")
                Exit Sub
            End If
        End If

        If txtSecInsPhone.Text <> "" Then
            If Len(txtSecInsPhone.Text) < 10 Then
                MessageBox.Show("Secondary insurance phone must be at least nine numbers.")
                Exit Sub
            End If
        End If

        If txtTerInsPhone.Text <> "" Then
            If Len(txtTerInsPhone.Text) < 10 Then
                MessageBox.Show("Teritary insurance phone must be at least nine numbers.")
                Exit Sub
            End If
        End If

        'Address
        'If Val.CheckAlphaNumeric(txtClaimsAddress.Text) = False Then
        '    MessageBox.Show("Address must be alpha-numeric.  If you are trying to add an apartment number or Suite, please use 'Apt' or 'Suite'.")
        '    Exit Sub
        'End If
        'If Val.CheckAlphaNumeric(txtSecInsAddress.Text) = False Then
        '    MessageBox.Show("Address must be alpha-numeric.  If you are trying to add an apartment number or Suite, please use 'Apt' or 'Suite'.")
        '    Exit Sub
        'End If
        'If Val.CheckAlphaNumeric(txtTerInsAddress.Text) = False Then
        '    MessageBox.Show("Address must be alpha-numeric.  If you are trying to add an apartment number or Suite, please use 'Apt' or 'Suite'.")
        '    Exit Sub
        'End If

        'Insurance 
        If Val.CheckAlphaNumeric(txtInsuranceID.Text) = False Then
            MessageBox.Show("Insurance ID# must be alpha-numeric")
            Exit Sub
        End If
        If Val.CheckAlphaNumeric(txtSecInsID.Text) = False Then
            MessageBox.Show("Insurance ID# must be alpha-numeric")
            Exit Sub
        End If
        If Val.CheckAlphaNumeric(txtTerInsID.Text) = False Then
            MessageBox.Show("Insurance ID# must be alpha-numeric")
            Exit Sub
        End If
        If Val.CheckAlphaNumeric(txtInsGroup.Text) = False Then
            MessageBox.Show("Insurance Group# must be alpha-numeric")
            Exit Sub
        End If
        If Val.CheckAlphaNumeric(txtSecInsGroupNo.Text) = False Then
            MessageBox.Show("Insurance Group# must be alpha-numeric")
            Exit Sub
        End If
        If Val.CheckAlphaNumeric(txtTerInsGroupNo.Text) = False Then
            MessageBox.Show("Insurance Group# must be alpha-numeric")
            Exit Sub
        End If

        'Required Insurance Info    
        If txtPriInsName.Text = "" Then
            MessageBox.Show("Please enter the primary insurance provider.")
            Exit Sub
        End If
        If txtPriInsName.Text <> "" And txtPriInsName.Text <> " " Then
            'Make sure ID# and Group# are entered
            If txtInsuranceID.Text = "" Or txtInsuranceID.Text = " " Then
                MessageBox.Show("Please enter ID# for Primary Insurance Provider")
                Exit Sub
            End If
            'If txtInsGroup.Text = "" Or txtInsGroup.Text = " " Then
            '    MessageBox.Show("Please enter Group# for Primary Insurance Provider")
            '    Exit Sub
            'End If
        End If

        If btnSecondary.Enabled = False Then
            If txtSecInsName.Text = "" Then
                MessageBox.Show("Please enter secondary insurance provider.")
                Exit Sub
            End If
        End If

        If txtSecInsName.Text <> "" And txtSecInsName.Text <> " " Then
            'Make sure ID# and Group# are entered
            If txtSecInsID.Text = "" Or txtSecInsID.Text = " " Then
                MessageBox.Show("Please enter ID# for Secondary Insurance Provider")
                Exit Sub
            End If
            'If txtSecInsGroupNo.Text = "" Or txtSecInsGroupNo.Text = " " Then
            '    MessageBox.Show("Please enter Group# for Secondary Insurance Provider")
            '    Exit Sub
            'End If
        End If

        If btnTertiary.Enabled = False Then
            If txtTerInsName.Text = "" Then
                MessageBox.Show("Please enter tertiary insurance provider.")
                Exit Sub
            End If
        End If
        If txtTerInsName.Text <> "" And txtTerInsName.Text <> " " Then
            'Make sure ID# and Group# are entered
            If txtTerInsID.Text = "" Or txtTerInsID.Text = " " Then
                MessageBox.Show("Please enter ID# for Tertiary Insurance Provider")
                Exit Sub
            End If
            'If txtTerInsGroupNo.Text = "" Or txtTerInsGroupNo.Text = " " Then
            '    MessageBox.Show("Please enter Group# for Tertiary Insurance Provider")
            '    Exit Sub
            'End If
        End If

        Dim intPatientID As Integer
        intPatientID = NewPatient.mintPaitentID

        'save
        'Add Primary Insurance Info to database if filled out
        If txtPriInsName.Text <> "" Then
            If mintSave = 0 Then
                DB.AddInsurance(txtPriInsName.Text, txtInsuranceID.Text, txtInsGroup.Text, txtClaimsAddress.Text, txtClaimsCity.Text, ddlInsState.SelectedItem.ToString, txtClaimsZip.Text, txtClaimsPhone.Text, intPatientID, "1")
            Else
                DB.UpdateInsuranceInfo(txtPriInsName.Text, txtInsuranceID.Text, txtInsGroup.Text, txtClaimsAddress.Text, txtClaimsPhone.Text, txtClaimsCity.Text, ddlInsState.SelectedItem.ToString, intPatientID.ToString, txtClaimsZip.Text, "1")
            End If
        End If
        'Add Secondary Insurance Info to database if filled out
        If txtSecInsName.Text <> "" Then
            If mintSave = 0 Then
                DB.AddInsurance(txtSecInsName.Text, txtSecInsID.Text, txtSecInsGroupNo.Text, txtSecInsAddress.Text, txtSecInsCity.Text, ddlSecInsState.SelectedItem.ToString, txtSecInsZip.Text, txtSecInsPhone.Text, intPatientID, "2")
            Else
                DB.UpdateInsuranceInfo(txtSecInsName.Text, txtSecInsID.Text, txtSecInsGroupNo.Text, txtSecInsAddress.Text, txtSecInsCity.Text, ddlSecInsState.SelectedItem.ToString, txtSecInsZip.Text, txtSecInsPhone.Text, intPatientID, "2")
            End If
        End If


        'Add Tertiary Insurance Info to database if filled out
        If txtTerInsName.Text <> "" Then
            If mintSave = 0 Then
                DB.AddInsurance(txtTerInsName.Text, txtTerInsID.Text, txtTerInsGroupNo.Text, txtTerInsAddress.Text, txtTerInsCity.Text, ddlTerInsState.SelectedItem.ToString, txtTerInsZip.Text, txtTerInsPhone.Text, intPatientID, "3")
            Else
                DB.UpdateInsuranceInfo(txtTerInsName.Text, txtTerInsID.Text, txtTerInsGroupNo.Text, txtTerInsAddress.Text, txtTerInsCity.Text, ddlTerInsState.SelectedItem.ToString, txtTerInsZip.Text, txtTerInsPhone.Text, intPatientID, "3")
            End If
        End If


        'close
        MessageBox.Show("Insurance Information successfully saved!")
        NewPatient.Enabled = True
        DisableForm()
        mintSave += 1
    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub NewPatientInsurance_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If mintSave = 0 Then
            Dim strmsg As String
            Dim strtitle As String
            Dim strstyle As MsgBoxStyle
            Dim strresponse As MsgBoxResult
            strmsg = "Are you sure you want to exit without saving?"   ' Define message.
            strstyle = MsgBoxStyle.DefaultButton2 Or _
               MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
            strtitle = "Patient Insurance Information"   ' Define title.
            ' Display message.
            strresponse = MsgBox(strmsg, strstyle, strtitle)
            If strresponse = MsgBoxResult.Yes Then   ' User chose Yes.
                ' close without saving
                ClearForm()
                NewPatient.Enabled = True
            Else
                'dont close
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub NewPatientInsurance_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ddlInsState.SelectedIndex = 0
        ddlSecInsState.SelectedIndex = 0
        ddlTerInsState.SelectedIndex = 0
        mintSave = 0
        EnableForm()
        btnSecondary.Enabled = True
        btnTertiary.Enabled = True
    End Sub
    Public Sub ClearForm()
        'Clear Primary Insurance Textboxes
        txtPriInsName.Clear()
        txtInsuranceID.Clear()
        txtInsGroup.Clear()
        txtClaimsAddress.Clear()
        txtClaimsCity.Clear()
        ddlInsState.SelectedIndex = 0
        txtClaimsZip.Clear()
        txtClaimsPhone.Clear()

        'Clear Secondary Insurance Textboxes
        txtSecInsName.Clear()
        txtSecInsID.Clear()
        txtSecInsGroupNo.Clear()
        txtSecInsAddress.Clear()
        txtSecInsCity.Clear()
        ddlSecInsState.SelectedIndex = 0
        txtSecInsZip.Clear()
        txtSecInsPhone.Clear()

        'Clear Tertiary Insurance Textboxes
        txtTerInsName.Clear()
        txtTerInsID.Clear()
        txtTerInsGroupNo.Clear()
        txtTerInsAddress.Clear()
        txtTerInsCity.Clear()
        ddlTerInsState.SelectedIndex = 0
        txtTerInsZip.Clear()
        txtTerInsZip.Clear()
    End Sub

    Public Sub DisableForm()
        'Disable Primary Insurance Textboxes
        txtPriInsName.Enabled = False
        txtInsuranceID.Enabled = False
        txtInsGroup.Enabled = False
        txtClaimsAddress.Enabled = False
        txtClaimsCity.Enabled = False
        ddlInsState.Enabled = False
        txtClaimsZip.Enabled = False
        txtClaimsPhone.Enabled = False

        'Disable Secondary Insurance Textboxes
        txtSecInsName.Enabled = False
        txtSecInsID.Enabled = False
        txtSecInsGroupNo.Enabled = False
        txtSecInsAddress.Enabled = False
        txtSecInsCity.Enabled = False
        ddlSecInsState.Enabled = False
        txtSecInsZip.Enabled = False
        txtSecInsPhone.Enabled = False

        'Disable Tertiary Insurance Textboxes
        txtTerInsName.Enabled = False
        txtTerInsID.Enabled = False
        txtTerInsGroupNo.Enabled = False
        txtTerInsAddress.Enabled = False
        txtTerInsCity.Enabled = False
        ddlTerInsState.Enabled = False
        txtTerInsZip.Enabled = False
        txtTerInsZip.Enabled = False
    End Sub

    Public Sub EnableForm()
        'Enable Primary Insurance Textboxes
        txtPriInsName.Enabled = True
        txtInsuranceID.Enabled = True
        txtInsGroup.Enabled = True
        txtClaimsAddress.Enabled = True
        txtClaimsCity.Enabled = True
        ddlInsState.Enabled = True
        txtClaimsZip.Enabled = True
        txtClaimsPhone.Enabled = True

        'Enable Secondary Insurance Textboxes
        txtSecInsName.Enabled = True
        txtSecInsID.Enabled = True
        txtSecInsGroupNo.Enabled = True
        txtSecInsAddress.Enabled = True
        txtSecInsCity.Enabled = True
        ddlSecInsState.Enabled = True
        txtSecInsZip.Enabled = True
        txtSecInsPhone.Enabled = True

        'Enable Tertiary Insurance Textboxes
        txtTerInsName.Enabled = True
        txtTerInsID.Enabled = True
        txtTerInsGroupNo.Enabled = True
        txtTerInsAddress.Enabled = True
        txtTerInsCity.Enabled = True
        ddlTerInsState.Enabled = True
        txtTerInsZip.Enabled = True
        txtTerInsZip.Enabled = True
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        If txtPriInsName.Enabled = True Then
            ClearForm()
        Else
            MessageBox.Show("Please enter edit mode to clear or edit form.")
            Exit Sub
        End If
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        EnableForm()
    End Sub

    Private Sub btnSecondary_Click(sender As System.Object, e As System.EventArgs) Handles btnSecondary.Click
        If gbSecondaryInsurance.Visible = False Then
            gbSecondaryInsurance.Visible = True
        Else
            gbSecondaryInsurance.Visible = False
        End If

    End Sub

    Private Sub btnTertiary_Click(sender As System.Object, e As System.EventArgs) Handles btnTertiary.Click
        If gbTertiaryInsurance.Visible = False Then
            gbTertiaryInsurance.Visible = True
        Else
            gbTertiaryInsurance.Visible = False
        End If

    End Sub
End Class