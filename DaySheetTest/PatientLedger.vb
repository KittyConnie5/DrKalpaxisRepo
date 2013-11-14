Public Class PatientLedger

    Dim Val As New ClassValidate
    Dim DB As New ClassDB
    Public intPatientID As Integer
    Dim intNumOfRows As Integer
    Dim intload As Integer
    Dim intEmployerID As Integer
    Dim intRelativeID As Integer
    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        'Open home form and hide this one
        Home.Show()
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        chkActive.Enabled = False

        'Get ride of apostrophes
        txtEmployer.Text.Replace("'", "")
        txtEmployer.Text.Replace("'", "")
        txtNRcity.Text.Replace("'", "")
        txtNRFirstName.Text.Replace("'", "")
        txtNRLastName.Text.Replace("'", "")
        txtNRRelation.Text.Replace("'", "")
        txtNRAddress.Text.Replace("'", "")
        txtNRcity.Text.Replace("'", "")
        txtPriInsName.Text.Replace("'", "")
        txtSecInsName.Text.Replace("'", "")
        txtTerInsName.Text.Replace("'", "")
        txtPriInsAddress.Text.Replace("'", "")
        txtTerInsAddress.Text.Replace("'", "")
        txtSecInsAddress.Text.Replace("'", "")
        txtPriInsCity.Text.Replace("'", "")
        txtSecInsCity.Text.Replace("'", "")
        txtTerInsCity.Text.Replace("'", "")
        txtSpouseFN.Text.Replace("'", "")
        txtSpouseLN.Text.Replace("'", "")
        txtSpouseEmp.Text.Replace("'", "")
        txtSpouseEmpCity.Text.Replace("'", "")
        rtbComments.Text.Replace("'", "")

        'trim text of spaces
        RTrim(txtEmployer.Text)
        RTrim(txtEmpCity.Text)
        RTrim(txtNRFirstName.Text)
        RTrim(txtNRLastName.Text)
        RTrim(txtNRRelation.Text)
        RTrim(txtNRAddress.Text)
        RTrim(txtNRcity.Text)
        RTrim(txtPriInsName.Text)
        RTrim(txtPriInsID.Text)
        RTrim(txtPriInsGroupNo.Text)
        RTrim(txtPriInsAddress.Text)
        RTrim(txtPriInsCity.Text)
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
        RTrim(txtSpouseFN.Text)
        RTrim(txtSpouseLN.Text)
        RTrim(txtSpouseEmp.Text)
        RTrim(txtSpouseEmpAddress.Text)
        RTrim(txtSpouseEmpCity.Text)


        'Validate
        'All letter fields
        If Val.CheckLetterSubstring(txtNRFirstName.Text) = False Then
            MessageBox.Show("First name must contain only letters")
            Exit Sub
        End If
        If Val.CheckLetterSubstring(txtNRLastName.Text) = False Then
            MessageBox.Show("Last name must contain only letters")
            Exit Sub
        End If
        If Val.CheckLetterSubstring(txtNRcity.Text) = False Then
            MessageBox.Show("City name must contain only letters")
            Exit Sub
        End If
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
        If Val.CheckLetterSubstring(txtPriInsCity.Text) = False Then
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
        If Val.CheckLetterSubstring(txtSpouseFN.Text) = False Then
            MessageBox.Show("First name must contain only letters")
            Exit Sub
        End If
        If Val.CheckLetterSubstring(txtSpouseLN.Text) = False Then
            MessageBox.Show("Last name must contain only letters")
            Exit Sub
        End If
        If Val.CheckLetterSubstring(txtSpouseEmpCity.Text) = False Then
            MessageBox.Show("City name must contain only letters")
            Exit Sub
        End If
        If Val.CheckLetterSubstring(txtNRRelation.Text) = False Then
            MessageBox.Show("Nearest Relative relationship must contain only letters")
            Exit Sub
        End If

        'Zipcodes
        If Val.checkzipcode(txtNRzip.Text) = False Then
            MessageBox.Show("Zip code must be numeric")
            Exit Sub
        End If
        If Val.checkzipcode(txtPriInsZip.Text) = False Then
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
        If Val.checkzipcode(txtSpouseEmpZip.Text) = False Then
            MessageBox.Show("Zip code must be numeric")
            Exit Sub
        End If
        If Val.checkzipcode(txtEmpZip.Text) = False Then
            MessageBox.Show("Zip code must be numeric")
            Exit Sub
        End If

        'Phone numbers
        If Val.CheckPhone(txtEmpPhone.Text) = False Then
            MessageBox.Show("Phone number must be numberic")
            Exit Sub
        End If
        If Val.CheckPhone(txtNRphone.Text) = False Then
            MessageBox.Show("Phone number must be numberic")
            Exit Sub
        End If
        If Val.CheckPhone(txtPriInsPhone.Text) = False Then
            MessageBox.Show("Phone number must be numberic")
            Exit Sub
        End If
        If Val.CheckPhone(txtSecInsPhone.Text) = False Then
            MessageBox.Show("Phone number must be numberic")
            Exit Sub
        End If
        If Val.CheckPhone(txtTerInsPhone.Text) = False Then
            MessageBox.Show("Phone number must be numberic")
            Exit Sub
        End If
        If Val.CheckPhone(txtSpouseEmpPhone.Text) = False Then
            MessageBox.Show("Phone number must be numberic")
            Exit Sub
        End If

        'SSN
        If Val.CheckSSN(txtSSN.Text) = False Then
            MessageBox.Show("Social Security Number must be numeric")
            Exit Sub
        End If

        'Drivers license
        If Val.CheckIntegerSubstring(txtDriversLiscense.Text) = False Then
            MessageBox.Show("Drivers License No must be numeric")
            Exit Sub
        End If

        'Alpha-numeric fields
        If Val.CheckAlphaNumeric(txtEmployer.Text) = False Then
            MessageBox.Show("Address must be alpha-numeric")
            Exit Sub
        End If
        If Val.CheckAlphaNumeric(txtNRAddress.Text) = False Then
            MessageBox.Show("Address must be alpha-numeric")
            Exit Sub
        End If
        If Val.CheckAlphaNumeric(txtPriInsAddress.Text) = False Then
            MessageBox.Show("Address must be alpha-numeric")
            Exit Sub
        End If
        If Val.CheckAlphaNumeric(txtSecInsAddress.Text) = False Then
            MessageBox.Show("Address must be alpha-numeric")
            Exit Sub
        End If
        If Val.CheckAlphaNumeric(txtTerInsAddress.Text) = False Then
            MessageBox.Show("Address must be alpha-numeric")
            Exit Sub
        End If
        If Val.CheckAlphaNumeric(txtEmployer.Text) = False Then
            MessageBox.Show("Employer name must be alpha-numeric")
            Exit Sub
        End If
        If Val.CheckAlphaNumeric(txtSpouseEmp.Text) = False Then
            MessageBox.Show("Employer name must be alpha-numeric")
            Exit Sub
        End If
        If Val.CheckComments(rtbComments.Text.ToString) = False Then
            MessageBox.Show("Comments must not contain any special characters")
            Exit Sub
        End If
        If Val.CheckAlphaNumeric(txtPriInsID.Text) = False Then
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
        If Val.CheckAlphaNumeric(txtPriInsGroupNo.Text) = False Then
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

        'Required Fields
        If ddlGender.SelectedIndex = 0 Then
            MessageBox.Show("Please enter patient's gender")
            Exit Sub
        End If
       
        If txtTelephone.Text = "" Then
            MessageBox.Show("Please enter patient's phone number")
            Exit Sub
        End If
        If txtDOB.Text = "" Then
            MessageBox.Show("Please enter patient's date of birth")
            Exit Sub
        End If

        'Required Insurance Info    
        If txtPriInsName.Text <> "" And txtPriInsName.Text <> " " Then
            'Make sure ID# and Group# are entered
            If txtPriInsID.Text = "" Or txtPriInsID.Text = " " Then
                MessageBox.Show("Please enter ID# for Primary Insurance Provider")
                Exit Sub
            End If
            'If txtPriInsGroupNo.Text = "" Or txtPriInsGroupNo.Text = " " Then
            '    MessageBox.Show("Please enter Group# for Primary Insurance Provider")
            '    Exit Sub
            'End If
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

        'Set form back to normal
        SetFormToNormal()

        'Declare PatientID
        If FindPatient.txtPatientID.Text = "" Then
            intPatientID = Convert.ToInt32(MultiplePatients.txtPatientID.Text)
        Else
            intPatientID = FindPatient.mintPatientID
        End If

        'Active Status
        Dim strActive As String
        If chkActive.Checked = True Then
            strActive = "T"
        Else
            strActive = "F"
        End If

        'Employer
        If txtEmployer.Text <> "" Then
            'get employer id
            DB.SelectQuery("SELECT EmployerID FROM tblPatient WHERE PatientID = " & intPatientID, "tblPatient")
            'temporarily commented out
            If 1 = 0 Then 'DB.CountDataset.Tables("tblPatient").Rows.Count > 0 Then
                '    intEmployerID = DB.CountDataset.Tables("tblPatient").Rows(0).Item("EmployerID")
                '    DB.UpdateEmployerInfo(txtEmployer.Text, txtEmpAddress.Text, txtEmpCity.Text, ddlEmpState.SelectedItem.ToString, txtEmpZip.Text, txtEmpPhone.Text, intEmployerID)
            Else
                'Connie Meng, 11/10/13, realized there is no provisions if it does not have a preexisting employer, previously did nothing  
                'Based code off of that under NewPatientEmployer
                'check
                'remove apostrophes
                txtEmployer.Text.Replace("'", "")

                'trim text of spaces
                RTrim(txtEmployer.Text)
                RTrim(txtEmpCity.Text)

                'check
                'remove apostrophes
                txtEmployer.Text.Replace("'", "")

                'trim text of spaces
                RTrim(txtEmployer.Text)
                RTrim(txtEmpCity.Text)

                Dim intPatientID As Integer
                intPatientID = Me.intPatientID
                'validate

                If Val.CheckLetterSubstring(txtEmpCity.Text) = False Then
                    MessageBox.Show("City name must contain only letters")
                    Exit Sub
                End If
                'Zip Codes
                If Val.checkzipcode(txtEmpZip.Text) = False Then
                    MessageBox.Show("Zip code must be numeric")
                    Exit Sub
                End If

                If txtEmpZip.Text <> "" Then
                    If Len(txtEmpZip.Text) < 5 Then
                        MessageBox.Show("Employer zip code must be at least 5 numbers.")
                        Exit Sub
                    End If
                End If

                If txtEmpPhone.Text <> "" Then
                    If Len(txtEmpPhone.Text) < 10 Then
                        MessageBox.Show("Employer phone must be at least 10 numbers.")
                        Exit Sub
                    End If
                End If

                'Phones
                If Val.CheckPhone(txtEmpPhone.Text) = False Then
                    MessageBox.Show("Phone number must be numeric")
                    Exit Sub
                End If

                If Val.CheckAlphaNumeric(txtEmployer.Text) = False Then
                    MessageBox.Show("Employer name must be alpha-numeric.")
                    Exit Sub
                End If

                'save
                'Add Employer to database

                Dim intEmployerID As Integer
                DB.SecondarySelectQuery("SELECT * FROM tblEmployer", "tblEmployer")
                intEmployerID = DB.SecondaryCountDataset.Tables("tblEmployer").Rows.Count + 1
                'If IsNothing(intEmployerID) = True Then
                'If mintEmployerSave <> 0 Then
                '    DB.UpdateEmployerInfo(txtEmployer.Text, txtPatEmpAddress.Text, txtEmpCity.Text, ddlEmpState.SelectedItem.ToString, txtEmpZip.Text, txtEmpPhone.Text, intEmployerID)
                'End If
                'Testing msgbox, uncomment to see what it is putting in
                'MsgBox(txtEmployer.Text + " " + txtEmpAddress.Text + " " + txtEmpCity.Text + " " + ddlEmpState.SelectedItem.ToString + " " + txtEmpZip.Text + " " + txtEmpPhone.Text + " " + intEmployerID.ToString)

                DB.AddEmployer(txtEmployer.Text, txtEmpAddress.Text, txtEmpCity.Text, ddlEmpState.SelectedItem.ToString, txtEmpZip.Text, txtEmpPhone.Text, intEmployerID)
                DB.AddEmployerID(intEmployerID.ToString, intPatientID + 3)
            End If
            MessageBox.Show(txtPatFN.Text & " " & txtPatLN.Text & "'s record has been updated!", "Patient Updated!", MessageBoxButtons.OK)
        Else
            'do nothing
        End If

        'Spouse
        'delete if exists and spouse info is blank
        DB.SelectQuery("SELECT * FROM tblSpouse WHERE PatientID = " & intPatientID, "tblSpouse")
        If DB.CountDataset.Tables("tblSpouse").Rows.Count = 0 Then
            'spouse does not exist
            If txtSpouseFN.Text <> "" Then
                'get emp id & add spouse employer
                Dim intSpouseEmpID As Integer
                If txtSpouseEmp.Text = "" Then
                    intSpouseEmpID = 0
                Else
                    DB.SecondarySelectQuery("SELECT * FROM tblEmployer", "tblEmployer")
                    intSpouseEmpID = DB.SecondaryCountDataset.Tables("tblEmployer").Rows.Count + 1
                    'add employer
                    DB.AddEmployer(txtSpouseEmp.Text, txtSpouseEmpAddress.Text, txtSpouseEmpCity.Text, ddlSpouseEmpState.SelectedItem.ToString, txtSpouseEmpZip.Text, txtSpouseEmpPhone.Text, intSpouseEmpID)
                End If
                'Connie Meng 11/10/13 added validation for selecting spouses gender, should we default this to the opposite of the patient?
                If ddlSpouseGender.SelectedIndex = 0 Then
                    MsgBox("Please select the spouse's gender")
                    Exit Sub
                End If
                'add spouse
                DB.AddNewSpouse(txtSpouseFN.Text, txtSpouseLN.Text, ddlSpouseGender.SelectedItem.ToString, txtSpouseEmpPhone.Text, intPatientID, intSpouseEmpID)
            Else
                'do nothing
            End If
        ElseIf DB.CountDataset.Tables("tblSpouse").Rows.Count >= 1 Then
            'spouse already exists
            If txtSpouseFN.Text = "" Then
                'delete spouse
                DB.SelectQuery("DELETE FROM tblSpouse WHERE PatientID = " & intPatientID, "tblSpouse")
            Else
                'update spouse info
                DB.UpdateSpouseInfo(txtSpouseFN.Text, txtSpouseLN.Text, txtSpouseEmpPhone.Text, intPatientID)
                'update spouse employer info
                If txtSpouseEmp.Text <> "" Then
                    DB.SecondarySelectQuery("SELECT * FROM tblEmployer", "tblEmployer")
                    Dim intSpouseEmpID As Integer = DB.SecondaryCountDataset.Tables("tblEmployer").Rows.Count + 1
                    DB.UpdateSpouseEmployerInfo(txtSpouseEmp.Text, txtSpouseEmpAddress.Text, txtSpouseEmpCity.Text, ddlSpouseEmpState.SelectedItem.ToString, txtSpouseEmpZip.Text, intSpouseEmpID)
                End If
            End If
        End If

        'Insurance 1
        'if already exists, update, otherwise add new insurance
        DB.SelectQuery("SELECT * FROM tblInsurance WHERE PatientID = '" & intPatientID.ToString & "' AND Type = '1'", "tblInsurance")
        If DB.CountDataset.Tables("tblInsurance").Rows.Count = 0 Then
            'no insurance exists, add insurance
            If txtPriInsName.Text = "" Then
                'do nothing
            Else
                DB.AddInsurance(txtPriInsName.Text, txtPriInsID.Text, txtPriInsGroupNo.Text, txtPriInsAddress.Text, txtPriInsCity.Text, ddlPriInsState.SelectedItem.ToString, txtPriInsZip.Text, txtPriInsPhone.Text, intPatientID.ToString, "1")
            End If
        Else
            'insurance already exists, update insurance
            If txtPriInsName.Text = "" Then
                'delete insurance
                DB.SelectQuery("DELETE FROM tblInsurance WHERE PatientID = '" & intPatientID.ToString & "' AND Type = '1'", "tblInsurance")
            Else
                'update insurance
                DB.UpdateInsuranceInfo(txtPriInsName.Text, txtPriInsID.Text, txtPriInsGroupNo.Text, txtPriInsAddress.Text, txtPriInsPhone.Text, txtPriInsCity.Text, ddlPriInsState.SelectedItem.ToString, intPatientID.ToString, txtPriInsZip.Text, "1")
            End If

        End If

        'Insurance 2
        'if already exists, update, otherwise add new insurance
        DB.SelectQuery("SELECT * FROM tblInsurance WHERE PatientID = '" & intPatientID.ToString & "' AND Type = '2'", "tblInsurance")
        If DB.CountDataset.Tables("tblInsurance").Rows.Count = 0 Then
            'no insurance exists, add insurance
            If txtSecInsName.Text = "" Then
                'do nothing
            Else
                DB.AddInsurance(txtSecInsName.Text, txtSecInsID.Text, txtSecInsGroupNo.Text, txtSecInsAddress.Text, txtSecInsCity.Text, ddlSecInsState.SelectedItem.ToString, txtSecInsZip.Text, txtSecInsPhone.Text, intPatientID.ToString, "2")
            End If
        Else
            'insurance already exists, update insurance
            If txtSecInsName.Text = "" Then
                'delete insurance
                DB.SelectQuery("DELETE FROM tblInsurance WHERE PatientID = '" & intPatientID.ToString & "' AND Type = '2'", "tblInsurance")
            Else
                'update insurance
                DB.UpdateInsuranceInfo(txtSecInsName.Text, txtSecInsID.Text, txtSecInsGroupNo.Text, txtSecInsAddress.Text, txtSecInsPhone.Text, txtSecInsCity.Text, ddlSecInsState.SelectedItem.ToString, intPatientID.ToString, txtSecInsZip.Text, "2")
            End If
        End If

        'Insurance 3
        'if already exists, update, otherwise add new insurance
        DB.SelectQuery("SELECT * FROM tblInsurance WHERE PatientID = '" & intPatientID.ToString & "' AND Type = '3'", "tblInsurance")
        If DB.CountDataset.Tables("tblInsurance").Rows.Count = 0 Then
            'no insurance exists, add insurance
            If txtTerInsName.Text = "" Then
                'do nothing
            Else
                DB.AddInsurance(txtTerInsName.Text, txtTerInsID.Text, txtTerInsGroupNo.Text, txtTerInsAddress.Text, txtTerInsCity.Text, ddlTerInsState.SelectedItem.ToString, txtTerInsZip.Text, txtTerInsPhone.Text, intPatientID.ToString, "3")
            End If
        Else
            'insurance already exists, update insurance
            If txtTerInsName.Text = "" Then
                'delete insurance
                DB.SelectQuery("DELETE FROM tblInsurance WHERE PatientID = '" & intPatientID.ToString & "' AND Type = '3'", "tblInsurance")
            Else
                'update insurance
                DB.UpdateInsuranceInfo(txtTerInsName.Text, txtTerInsID.Text, txtTerInsGroupNo.Text, txtTerInsAddress.Text, txtTerInsPhone.Text, txtTerInsCity.Text, ddlTerInsState.SelectedItem.ToString, intPatientID.ToString, txtTerInsZip.Text, "3")
            End If
        End If

        'Nearest Relative
        'see if text is input
        If txtNRFirstName.Text <> "" Then
            'get relative id
            DB.SelectQuery("SELECT RelativeID FROM tblPatient WHERE PatientID = " & intPatientID, "tblPatient")
            If DB.CountDataset.Tables("tblPatient").Rows(0).Item("RelativeID") = 0 Then
                'add relative
                DB.AddNewRelative(txtNRFirstName.Text, txtNRLastName.Text, txtNRRelation.Text, txtNRAddress.Text, txtNRcity.Text, ddlNRState.SelectedItem.ToString, txtNRzip.Text, txtNRphone.Text)
                'update RelativeID on tblPatient
                DB.TertiarySelectQuery("SELECT * FROM tblRelative", "tblRelative")
                Dim intRelativeID As Integer = DB.TertiaryCountDataset.Tables("tblRelative").Rows.Count
                DB.SecondarySelectQuery("UPDATE tblPatient SET RelativeID = " & intRelativeID & " WHERE PatientID = " & intPatientID, "tblPatient")
            Else
                intrelativeid = DB.CountDataset.Tables("tblPatient").Rows(0).Item("RelativeID")
                If txtNRFirstName.Text <> "" Then
                    DB.UpdateRelativeInfo(txtNRFirstName.Text, txtNRLastName.Text, txtNRRelation.Text, txtNRAddress.Text, txtNRphone.Text, txtNRcity.Text, ddlNRState.SelectedItem.ToString, intRelativeID, txtNRzip.Text)
                Else
                    'do nothing
                End If
            End If
        End If

        'input changes to DB
        DB.UpdatePatientInfo(txtPatFN.Text, txtPatLN.Text, txtPatAddress.Text, txtPatZip.Text, txtTelephone.Text, txtDOB.Text, txtDriversLiscense.Text, txtSSN.Text, ddlGender.SelectedItem.ToString, txtPatCity.Text, ddlPatState.SelectedItem.ToString, rtbComments.Text.ToString, intPatientID)

    End Sub

    Public Sub SetFormToNormal()
        'Make textboxes Read-Only
        txtPatAddress.Enabled = False
        txtPatFN.Enabled = False
        txtPatLN.Enabled = False
        txtPatCity.Enabled = False
        txtPatZip.Enabled = False
        ddlPatState.Enabled = False

        chkActive.Enabled = False
        ddlGender.Enabled = False
        txtTelephone.ReadOnly = True
        txtSpouseFN.ReadOnly = True
        txtSpouseLN.ReadOnly = True
        txtDOB.ReadOnly = True
        txtSSN.ReadOnly = True
        txtDriversLiscense.ReadOnly = True

        txtEmployer.ReadOnly = True
        txtEmpAddress.ReadOnly = True
        txtEmpCity.ReadOnly = True
        txtEmpZip.ReadOnly = True
        txtEmpPhone.ReadOnly = True
        ddlEmpState.Enabled = False

        txtSpouseEmp.ReadOnly = True
        txtSpouseEmpAddress.ReadOnly = True
        txtSpouseEmpCity.ReadOnly = True
        txtSpouseEmpZip.ReadOnly = True
        txtSpouseEmpPhone.ReadOnly = True
        ddlSpouseEmpState.Enabled = False
        ddlSpouseGender.Enabled = False

        txtNRFirstName.ReadOnly = True
        txtNRLastName.ReadOnly = True
        txtNRRelation.ReadOnly = True
        txtNRAddress.ReadOnly = True
        txtNRcity.ReadOnly = True
        txtNRzip.ReadOnly = True
        txtNRphone.ReadOnly = True
        ddlNRState.Enabled = False

        txtProService.ReadOnly = True
        txtProServiceCity.ReadOnly = True
        txtProServiceZip.ReadOnly = True
        txtProServicePhone.ReadOnly = True
        ddlProServiceState.Enabled = False

        txtPriInsName.ReadOnly = True
        txtPriInsID.ReadOnly = True
        txtPriInsGroupNo.ReadOnly = True
        txtPriInsAddress.ReadOnly = True
        txtPriInsCity.ReadOnly = True
        txtPriInsZip.ReadOnly = True
        txtPriInsPhone.ReadOnly = True
        ddlPriInsState.Enabled = False

        txtSecInsName.ReadOnly = True
        txtSecInsID.ReadOnly = True
        txtSecInsGroupNo.ReadOnly = True
        txtSecInsAddress.ReadOnly = True
        txtSecInsCity.ReadOnly = True
        txtSecInsZip.ReadOnly = True
        txtSecInsPhone.ReadOnly = True
        ddlSecInsState.Enabled = False

        txtTerInsName.ReadOnly = True
        txtTerInsID.ReadOnly = True
        txtTerInsGroupNo.ReadOnly = True
        txtTerInsAddress.ReadOnly = True
        txtTerInsCity.ReadOnly = True
        txtTerInsZip.ReadOnly = True
        txtTerInsZip.ReadOnly = True
        txtTerInsPhone.ReadOnly = True
        ddlTerInsState.Enabled = False

        rtbComments.ReadOnly = True
        ddlGender.Enabled = False
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        'Make textboxes editible
        txtPatAddress.Enabled = True
        txtPatFN.Enabled = True
        txtPatLN.Enabled = True
        txtPatCity.Enabled = True
        txtPatZip.Enabled = True
        ddlPatState.Enabled = True

        chkActive.Enabled = True

        ddlGender.Enabled = True
        txtTelephone.ReadOnly = False
        txtSpouseFN.ReadOnly = False
        txtSpouseLN.ReadOnly = False
        txtDOB.ReadOnly = False
        txtSSN.ReadOnly = False
        txtDriversLiscense.ReadOnly = False

        txtEmployer.ReadOnly = False
        txtEmpAddress.ReadOnly = False
        txtEmpCity.ReadOnly = False
        txtEmpZip.ReadOnly = False
        txtEmpPhone.ReadOnly = False
        ddlEmpState.Enabled = True

        txtSpouseEmp.ReadOnly = False
        txtSpouseEmpAddress.ReadOnly = False
        txtSpouseEmpCity.ReadOnly = False
        txtSpouseEmpZip.ReadOnly = False
        txtSpouseEmpPhone.ReadOnly = False
        ddlSpouseEmpState.Enabled = True
        ddlSpouseGender.Enabled = True

        txtNRFirstName.ReadOnly = False
        txtNRLastName.ReadOnly = False
        txtNRRelation.ReadOnly = False
        txtNRAddress.ReadOnly = False
        txtNRcity.ReadOnly = False
        txtNRzip.ReadOnly = False
        txtNRphone.ReadOnly = False
        ddlNRState.Enabled = True

        txtProService.ReadOnly = False
        txtProServiceCity.ReadOnly = False
        txtProServiceZip.ReadOnly = False
        txtProServicePhone.ReadOnly = False
        ddlProServiceState.Enabled = True

        txtPriInsName.ReadOnly = False
        txtPriInsID.ReadOnly = False
        txtPriInsGroupNo.ReadOnly = False
        txtPriInsAddress.ReadOnly = False
        txtPriInsCity.ReadOnly = False
        txtPriInsZip.ReadOnly = False
        txtPriInsPhone.ReadOnly = False
        ddlPriInsState.Enabled = True

        txtSecInsName.ReadOnly = False
        txtSecInsID.ReadOnly = False
        txtSecInsGroupNo.ReadOnly = False
        txtSecInsAddress.ReadOnly = False
        txtSecInsCity.ReadOnly = False
        txtSecInsZip.ReadOnly = False
        txtSecInsPhone.ReadOnly = False
        ddlSecInsState.Enabled = True

        txtTerInsName.ReadOnly = False
        txtTerInsID.ReadOnly = False
        txtTerInsGroupNo.ReadOnly = False
        txtTerInsAddress.ReadOnly = False
        txtTerInsCity.ReadOnly = False
        txtTerInsZip.ReadOnly = False
        txtTerInsZip.ReadOnly = False
        txtTerInsPhone.ReadOnly = False
        ddlTerInsState.Enabled = True

        rtbComments.ReadOnly = False
        ddlGender.Enabled = True
    End Sub

    Private Sub ClearForm()
        'clear
        txtPatAddress.Text = ""
        txtPatFN.Text = ""
        txtPatLN.Text = ""
        txtPatCity.Text = ""
        txtPatZip.Text = ""
        ddlPatState.SelectedIndex = 0

        DB.CountDataset.Clear()
        ddlGender.SelectedIndex = 0
        txtTelephone.Text = ""
        txtSpouseFN.Text = ""
        txtSpouseLN.Text = ""
        txtDOB.Text = ""
        txtSSN.Text = ""
        txtDriversLiscense.Text = ""

        txtEmployer.Text = ""
        txtEmpAddress.Text = ""
        txtEmpCity.Text = ""
        txtEmpZip.Text = ""
        txtEmpPhone.Text = ""
        ddlEmpState.SelectedIndex = 0

        txtSpouseEmp.Text = ""
        txtSpouseEmpAddress.Text = ""
        txtSpouseEmpCity.Text = ""
        txtSpouseEmpZip.Text = ""
        txtSpouseEmpPhone.Text = ""
        ddlSpouseEmpState.Text = ""
        ddlSpouseGender.Text = ""

        txtNRFirstName.Text = ""
        txtNRLastName.Text = ""
        txtNRRelation.Text = ""
        txtNRAddress.Text = ""
        txtNRcity.Text = ""
        txtNRzip.Text = ""
        txtNRphone.Text = ""
        ddlNRState.SelectedIndex = 0

        txtProService.Text = ""
        txtProServiceCity.Text = ""
        txtProServiceZip.Text = ""
        txtProServicePhone.Text = ""
        ddlProServiceState.SelectedIndex = 0

        txtPriInsName.Text = ""
        txtPriInsID.Text = ""
        txtPriInsGroupNo.Text = ""
        txtPriInsAddress.Text = ""
        txtPriInsCity.Text = ""
        txtPriInsZip.Text = ""
        txtPriInsPhone.Text = ""
        ddlPriInsState.SelectedIndex = 0

        txtSecInsName.Text = ""
        txtSecInsID.Text = ""
        txtSecInsGroupNo.Text = ""
        txtSecInsAddress.Text = ""
        txtSecInsCity.Text = ""
        txtSecInsZip.Text = ""
        txtSecInsPhone.Text = ""
        ddlSecInsState.SelectedIndex = 0

        txtTerInsName.Text = ""
        txtTerInsID.Text = ""
        txtTerInsGroupNo.Text = ""
        txtTerInsAddress.Text = ""
        txtTerInsCity.Text = ""
        txtTerInsZip.Text = ""
        txtTerInsZip.Text = ""
        txtTerInsPhone.Text = ""
        ddlTerInsState.SelectedIndex = 0

        rtbComments.Clear()
        ddlGender.SelectedIndex = 0
    End Sub

    Private Sub PatientLedger_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Home.Show()
        DB.CountDataset.Clear()
        TblTransactionTableAdapter = Nothing
        intPatientID = 0

        Me.Hide()
    End Sub

    Public Sub PatientLedger_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KalpaxisDBDataSet10.tblTransaction' table. You can move, or remove it, as needed.
        ClearForm()
        Me.TblTransactionTableAdapter.Fill(Me.KalpaxisDBDataSet10.tblTransaction)
        LoadPatientInfo()
        LoadTransactions()
    End Sub

    Public Sub LoadTransactions()
        'DB.SelectQuery("SELECT TransDate AS [Date], RefDate AS [Reference Date], Description, ROUND(Charge, 2) AS Charge, ROUND(Credit, 2) AS Credit, ROUND(Cash, 2) AS Cash, ROUND(Check, 2) AS Check, ROUND(Adjustments, 2) AS Adjustment, ROUND(CurrentBal, 2) AS [Current Balance], ROUND(PrevBal, 2) AS [Previous Balance], ReceiptNumber FROM tblTransaction WHERE PatientID = " & intPatientID, "tblTransaction")
        'gvTransactions.DataSource = DB.CountDataset.Tables("tblTransaction")

        'Set cell size
        'gvTransactions.Columns(0).Width = 90
        'gvTransactions.Columns(1).Width = 90
        'gvTransactions.Columns(2).Width = 70
        'gvTransactions.Columns(3).Width = 50
        'gvTransactions.Columns(4).Width = 50
        'gvTransactions.Columns(5).Width = 60
        'gvTransactions.Columns(6).Width = 50
        'gvTransactions.Columns(7).Width = 50
        'gvTransactions.Columns(8).Width = 50
        'gvTransactions.Columns(9).Width = 50

        'Format Cells
            gvTransactions.Columns("Charge").DefaultCellStyle.Format = "c"
            gvTransactions.Columns("Credit").DefaultCellStyle.Format = "c"
            gvTransactions.Columns("Cash").DefaultCellStyle.Format = "c"
            gvTransactions.Columns("Check").DefaultCellStyle.Format = "c"
            gvTransactions.Columns("Adjustment").DefaultCellStyle.Format = "c"
            gvTransactions.Columns("Current Balance").DefaultCellStyle.Format = "c"
            gvTransactions.Columns("Previous Balance").DefaultCellStyle.Format = "c"
     

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'Connie Meng 11/13
        FindPatient.Show()
        Me.Close()
    End Sub

    Public Sub LoadPatientInfo()
        'Declare PatientID
        ClearForm()
        If FindPatient.txtPatientID.Text = "" Then
            intPatientID = MultiplePatients.intPatientID
        Else
            intPatientID = CInt(FindPatient.mintPatientID)
        End If

        'DB.GetPatientRecord(intPatientID)
        PatientIDToolStripTextBox.Text = intPatientID.ToString
        FillByToolStripButton.PerformClick()

        'Get Patient Info
        DB.SelectCertainPatient("SELECT * FROM tblPatient WHERE PatientID = " & intPatientID)
        'Fill textboxes
        'lblLASTFIRST.Text = DB.PatientDataset.Tables("tblPatient").Rows(0).Item("LastName").toupper.ToString & ", " & DB.PatientDataset.Tables("tblPatient").Rows(0).Item("FirstName").toupper.ToString
        'lblFirstLast.Text = DB.PatientDataset.Tables("tblPatient").Rows(0).Item("FirstName").ToString & " " & DB.PatientDataset.Tables("tblPatient").Rows(0).Item("LastName").ToString
        'lblAddress.Text = DB.PatientDataset.Tables("tblPatient").Rows(0).Item("Address").ToString
        'lblCityStateZip.Text = DB.PatientDataset.Tables("tblPatient").Rows(0).Item("City").ToString & ", " & DB.PatientDataset.Tables("tblPatient").Rows(0).Item("State").ToString & " " & DB.PatientDataset.Tables("tblPatient").Rows(0).Item("Zip").ToString

        txtPatFN.Text = DB.PatientDataset.Tables("tblPatient").Rows(0).Item("FirstName").ToString
        txtPatLN.Text = DB.PatientDataset.Tables("tblPatient").Rows(0).Item("LastName").ToString
        txtPatAddress.Text = DB.PatientDataset.Tables("tblPatient").Rows(0).Item("Address").ToString
        txtPatCity.Text = DB.PatientDataset.Tables("tblPatient").Rows(0).Item("City").ToString
        txtPatZip.Text = DB.PatientDataset.Tables("tblPatient").Rows(0).Item("Zip").ToString
        ddlPatState.SelectedItem = DB.PatientDataset.Tables("tblPatient").Rows(0).Item("State").ToString

        'Dob
        Dim strDOB As String
        strDOB = DB.PatientDataset.Tables("tblPatient").Rows(0).Item("DateOfBirth").ToString
        txtDOB.Text = Convert.ToDateTime(strDOB)
        ddlGender.SelectedItem = DB.PatientDataset.Tables("tblPatient").Rows(0).Item("Gender").toupper.ToString
        txtTelephone.Text = DB.PatientDataset.Tables("tblPatient").Rows(0).Item("Phone").ToString
        txtSSN.Text = DB.PatientDataset.Tables("tblPatient").Rows(0).Item("SSN").ToString
        txtDriversLiscense.Text = DB.PatientDataset.Tables("tblPatient").Rows(0).Item("License").ToString
        rtbComments.Text = DB.PatientDataset.Tables("tblPatient").Rows(0).Item("Comment").ToString
        txtPatientID.Text = intPatientID.ToString
        If DB.PatientDataset.Tables("tblPatient").Rows(0).Item("Active").ToString = "T" Then
            chkActive.Checked = True
        Else
            chkActive.Checked = False
        End If


        'Get Spouse Info 
        DB.SelectQuery("SELECT * FROM tblSpouse WHERE PatientID = " & intPatientID, "tblSpouse")
        'Fill Textboxes if spouse exists
        If DB.CountDataset.Tables("tblSpouse").Rows.Count <> 0 Then
            Dim intSpouseEmployerID As Integer = DB.CountDataset.Tables("tblSpouse").Rows(0).Item("EmployerID")
            txtSpouseFN.Text = DB.CountDataset.Tables("tblSpouse").Rows(0).Item("FirstName").ToString
            txtSpouseLN.Text = DB.CountDataset.Tables("tblSpouse").Rows(0).Item("LastName").ToString
            ddlSpouseGender.SelectedItem = DB.CountDataset.Tables("tblSpouse").Rows(0).Item("Gender").ToString
            txtSpouseEmpPhone.Text = DB.CountDataset.Tables("tblSpouse").Rows(0).Item("Phone").ToString
            'Employer Info
            DB.SelectQuery("SELECT * FROM tblEmployer WHERE EmployerID = " & intSpouseEmployerID, "tblEmployer")
            txtSpouseEmp.Text = DB.CountDataset.Tables("tblEmployer").Rows(0).Item("EmpName").ToString
            txtSpouseEmpAddress.Text = DB.CountDataset.Tables("tblEmployer").Rows(0).Item("Address").ToString
            txtSpouseEmpCity.Text = DB.CountDataset.Tables("tblEmployer").Rows(0).Item("City").ToString
            ddlSpouseEmpState.SelectedItem = DB.CountDataset.Tables("tblEmployer").Rows(0).Item("State").ToString
            txtSpouseEmpZip.Text = DB.CountDataset.Tables("tblEmployer").Rows(0).Item("Zip").ToString
        Else
            'Don't fill textboxes
        End If

        DB.SelectQuery("SELECT EmployerID FROM tblPatient WHERE PatientID = " & intPatientID, "tblPatient")

        'DB.GetPatientEmployer(intPatientID)
        Dim intEmployerID As Integer = DB.CountDataset.Tables("tblPatient").Rows(0).Item("EmployerID")

        If intEmployerID <> 0 Then

            'If DB.CountDataset.Tables("tblPatient").Rows(0).Item("EmployerID") = "" Then
            'no employer

            'Get Employer Info
            DB.SecondarySelectQuery("SELECT * FROM tblEmployer WHERE EmployerID = " & intEmployerID, "tblEmployer")
            'Fill Textboxes
            txtEmployer.Text = DB.SecondaryCountDataset.Tables("tblEmployer").Rows(0).Item("EmpName").ToString
            txtEmpAddress.Text = DB.SecondaryCountDataset.Tables("tblEmployer").Rows(0).Item("Address").ToString
            txtEmpCity.Text = DB.SecondaryCountDataset.Tables("tblEmployer").Rows(0).Item("City").ToString
            ddlEmpState.SelectedItem = DB.SecondaryCountDataset.Tables("tblEmployer").Rows(0).Item("State").ToString
            txtEmpZip.Text = DB.SecondaryCountDataset.Tables("tblEmployer").Rows(0).Item("Zip").ToString
            txtEmpPhone.Text = DB.SecondaryCountDataset.Tables("tblEmployer").Rows(0).Item("Phone").ToString
        End If


        'Get Primary Insurance Info
        'DB.CountDataset.Clear()
        DB.SelectQuery("SELECT * FROM tblInsurance WHERE PatientID = '" & intPatientID & "' AND Type = '1'", "tblInsurance")
        'Fill Textboxes if primary insurance info exists
        If DB.CountDataset.Tables("tblInsurance").Rows.Count = 1 Then
            txtPriInsName.Text = DB.CountDataset.Tables("tblInsurance").Rows(0).Item("InsuranceName").ToString
            txtPriInsID.Text = DB.CountDataset.Tables("tblInsurance").Rows(0).Item("IDNumber").ToString
            txtPriInsGroupNo.Text = DB.CountDataset.Tables("tblInsurance").Rows(0).Item("GroupNumber").ToString
            txtPriInsAddress.Text = DB.CountDataset.Tables("tblInsurance").Rows(0).Item("Address").ToString
            txtPriInsCity.Text = DB.CountDataset.Tables("tblInsurance").Rows(0).Item("City").ToString
            ddlPriInsState.SelectedItem = DB.CountDataset.Tables("tblInsurance").Rows(0).Item("State").ToString
            txtPriInsZip.Text = DB.CountDataset.Tables("tblInsurance").Rows(0).Item("Zip").ToString
            txtPriInsPhone.Text = DB.CountDataset.Tables("tblInsurance").Rows(0).Item("Phone").ToString
        Else
            'Dont fill textboxes
        End If

        'Get Secondary Insurance Info
        DB.SelectQuery("SELECT * FROM tblInsurance WHERE PatientID = '" & intPatientID & "' AND Type = '2'", "tblInsurance")
        'Fill Textboxes if secondary insurance exists
        If DB.CountDataset.Tables("tblInsurance").Rows.Count = 1 Then
            txtSecInsName.Text = DB.CountDataset.Tables("tblInsurance").Rows(0).Item("InsuranceName").ToString
            txtSecInsID.Text = DB.CountDataset.Tables("tblInsurance").Rows(0).Item("IDNumber").ToString
            txtSecInsGroupNo.Text = DB.CountDataset.Tables("tblInsurance").Rows(0).Item("GroupNumber").ToString
            txtSecInsAddress.Text = DB.CountDataset.Tables("tblInsurance").Rows(0).Item("Address").ToString
            txtSecInsCity.Text = DB.CountDataset.Tables("tblInsurance").Rows(0).Item("City").ToString
            ddlSecInsState.SelectedItem = DB.CountDataset.Tables("tblInsurance").Rows(0).Item("State").ToString
            txtSecInsZip.Text = DB.CountDataset.Tables("tblInsurance").Rows(0).Item("Zip").ToString
            txtSecInsPhone.Text = DB.CountDataset.Tables("tblInsurance").Rows(0).Item("Phone").ToString
        Else
            'Dont fill textboxes
        End If

        'Get Tertiary Insurance Info
        DB.SelectQuery("SELECT * FROM tblInsurance WHERE PatientID = '" & intPatientID & "' AND Type = '3'", "tblInsurance")
        'Fill Textboxes if tertiary insurance exists
        If DB.CountDataset.Tables("tblInsurance").Rows.Count = 1 Then
            txtTerInsName.Text = DB.CountDataset.Tables("tblInsurance").Rows(0).Item("InsuranceName").ToString
            txtTerInsID.Text = DB.CountDataset.Tables("tblInsurance").Rows(0).Item("IDNumber").ToString
            txtTerInsGroupNo.Text = DB.CountDataset.Tables("tblInsurance").Rows(0).Item("GroupNumber").ToString
            txtTerInsAddress.Text = DB.CountDataset.Tables("tblInsurance").Rows(0).Item("Address").ToString
            txtTerInsCity.Text = DB.CountDataset.Tables("tblInsurance").Rows(0).Item("City").ToString
            ddlTerInsState.SelectedItem = DB.CountDataset.Tables("tblInsurance").Rows(0).Item("State").ToString
            txtTerInsZip.Text = DB.CountDataset.Tables("tblInsurance").Rows(0).Item("Zip").ToString
            txtTerInsPhone.Text = DB.CountDataset.Tables("tblInsurance").Rows(0).Item("Phone").ToString
        Else
            'Dont fill textboxes
        End If

        DB.SelectQuery("SELECT RelativeID FROM tblPatient WHERE PatientID = " & intPatientID, "tblPatient")
        Dim intRelativeID As Integer = CInt(DB.CountDataset.Tables("tblPatient").Rows(0).Item("RelativeID"))
        If intRelativeID <> 0 Then

            'Check to see that patient has a relative
            If intRelativeID <> 0 Then
                'Get Nearest Relative Info
                DB.SecondarySelectQuery("SELECT * FROM tblRelative WHERE RelativeID = " & intRelativeID, "tblRelative")
                'Fill Textboxes
                txtNRFirstName.Text = DB.SecondaryCountDataset.Tables("tblRelative").Rows(0).Item("FirstName").ToString
                txtNRLastName.Text = DB.SecondaryCountDataset.Tables("tblRelative").Rows(0).Item("LastName").ToString
                txtNRRelation.Text = DB.SecondaryCountDataset.Tables("tblRelative").Rows(0).Item("Relation").ToString
                txtNRAddress.Text = DB.SecondaryCountDataset.Tables("tblRelative").Rows(0).Item("Address").ToString
                txtNRcity.Text = DB.SecondaryCountDataset.Tables("tblRelative").Rows(0).Item("City").ToString
                ddlNRState.SelectedItem = DB.SecondaryCountDataset.Tables("tblRelative").Rows(0).Item("State").ToString
                txtNRzip.Text = DB.SecondaryCountDataset.Tables("tblRelative").Rows(0).Item("Zip").ToString
                txtNRphone.Text = DB.SecondaryCountDataset.Tables("tblRelative").Rows(0).Item("Phone").ToString
            End If
        End If

        'Calculate Total
        DB.SecondarySelectQuery("SELECT ROUND(CurrentBal, 2) AS CurrentBal FROM tblTransaction WHERE PatientID = " & intPatientID, "tblTransaction")
        DB.GetPreviousBalance(intPatientID)
        intNumOfRows = (DB.CountDataset.Tables("tblTransaction").Rows.Count - 1)

        If DB.SecondaryCountDataset.Tables("tblTransaction").Rows.Count = 0 Then
            txtTotalCurrentBalance.Text = 0
        Else
            txtTotalCurrentBalance.Text = DB.CountDataset.Tables("tblTransaction").Rows(intNumOfRows).Item("CurrentBal").ToString
        End If
    End Sub

    Private Sub btnAddTransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddTransaction.Click
        AddTransactionSelection.Show()
    End Sub

    Private Sub FillByToolStripButton_Click(sender As System.Object, e As System.EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.TblTransactionTableAdapter.FillBy(Me.KalpaxisDBDataSet10.tblTransaction, New System.Nullable(Of Integer)(CType(PatientIDToolStripTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        ClearForm()
        DB.SelectQuery("SELECT * FROM tblTransaction WHERE PatientID = " & intPatientID, "tblTransaction")
        gvTransactions.DataSource = DB.CountDataset.Tables("tblTransaction")
        Me.TblTransactionTableAdapter.Fill(Me.KalpaxisDBDataSet10.tblTransaction)
    End Sub

End Class
