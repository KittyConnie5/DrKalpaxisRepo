Imports System.Web
Public Class NewPatientEmployer
    Dim Val As New ClassValidate
    Dim DB As New ClassDB
    Dim mintNumberOfRelatives As Integer
    Dim intNumberOfPatients As Integer
    Dim mintEmployerSave As Integer = 0

    Private Sub btnSave_Click(sender As System.Object, e As System.EventArgs) Handles btnSave.Click

        'check
        'remove apostrophes
        txtEmployer.Text.Replace("'", "")
        txtPatEmpAddress.Text.Replace("'", "")
        txtNRCity.Text.Replace("'", "")
        txtNRfirstname.Text.Replace("'", "")
        txtNRlastname.Text.Replace("'", "")
        txtNRRelation.Text.Replace("'", "")
        txtNRAddress.Text.Replace("'", "")
        txtNRCity.Text.Replace("'", "")
        txtSpouseFN.Text.Replace("'", "")
        txtSpouseLN.Text.Replace("'", "")
        txtSpouseEmp.Text.Replace("'", "")
        txtSpouseEmpAddress.Text.Replace("'", "")
        txtSpouseEmpCity.Text.Replace("'", "")

        'trim text of spaces
        RTrim(txtEmployer.Text)
        RTrim(txtPatEmpAddress.Text)
        RTrim(txtEmpCity.Text)
        RTrim(txtNRfirstname.Text)
        RTrim(txtNRlastname.Text)
        RTrim(txtNRRelation.Text)
        RTrim(txtNRAddress.Text)
        RTrim(txtNRCity.Text)
        RTrim(txtSpouseFN.Text)
        RTrim(txtSpouseLN.Text)
        RTrim(txtSpouseEmp.Text)
        RTrim(txtSpouseEmpAddress.Text)
        RTrim(txtSpouseEmpCity.Text)

        Dim intPatientID As Integer
        intPatientID = NewPatient.mintPaitentID
        'validate
        'Connie Meng 11/10/13 Changed validation from 9 to 10
        If Val.CheckLetterSubstring(txtNRfirstname.Text) = False Then
            MessageBox.Show("First name must contain only letters")
            Exit Sub
        End If
        If Val.CheckLetterSubstring(txtNRlastname.Text) = False Then
            MessageBox.Show("Last name must contain only letters")
            Exit Sub
        End If
        If Val.CheckLetterSubstring(txtNRCity.Text) = False Then
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

        'Zip Codes
        If Val.checkzipcode(txtNRZip.Text) = False Then
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

        If txtEmpZip.Text <> "" Then
            If Len(txtEmpZip.Text) < 5 Then
                MessageBox.Show("Employer zip code must be at least 5 numbers.")
                Exit Sub
            End If
        End If

        If txtSpouseEmpZip.Text <> "" Then
            If Len(txtSpouseEmpZip.Text) < 5 Then
                MessageBox.Show("Spouse zip code must be at least 5 numbers.")
                Exit Sub
            End If
        End If

        If txtNRZip.Text <> "" Then
            If Len(txtNRZip.Text) < 5 Then
                MessageBox.Show("Nearest relative zip code must be at least 5 numbers.")
                Exit Sub
            End If
        End If

        If txtEmpPhone.Text <> "" Then
            If Len(txtEmpPhone.Text) < 10 Then
                MessageBox.Show("Employer phone must be at least 9 numbers.")
                Exit Sub
            End If
        End If

        If txtSpouseEmpPhone.Text <> "" Then
            If Len(txtSpouseEmpPhone.Text) < 10 Then
                MessageBox.Show("Spouse phone must be at least 9 numbers.")
                Exit Sub
            End If
        End If

        If txtNRPhone.Text <> "" Then
            If Len(txtNRPhone.Text) < 10 Then
                MessageBox.Show("Nearest relative phone must be at least 10 numbers.")
                Exit Sub
            End If
        End If

        'Phones
        If Val.CheckPhone(txtEmpPhone.Text) = False Then
            MessageBox.Show("Phone number must be numeric")
            Exit Sub
        End If
        If Val.CheckPhone(txtNRPhone.Text) = False Then
            MessageBox.Show("Phone number must be numberic")
            Exit Sub
        End If
        If Val.CheckPhone(txtSpouseEmpPhone.Text) = False Then
            MessageBox.Show("Phone number must be numberic")
            Exit Sub
        End If

        'Address
        'If Val.CheckAlphaNumeric(txtPatEmpAddress.Text) = False Then
        '    MessageBox.Show("Address must be alpha-numeric. If you are trying to add an apartment number or Suite, please use 'Apt' or 'Suite'.")
        '    Exit Sub
        'End If
        'If Val.CheckAlphaNumeric(txtNRAddress.Text) = False Then
        '    MessageBox.Show("Address must be alpha-numeric. If you are trying to add an apartment number or Suite, please use 'Apt' or 'Suite'.")
        '    Exit Sub
        'End If
        If Val.CheckAlphaNumeric(txtEmployer.Text) = False Then
            MessageBox.Show("Employer name must be alpha-numeric.")
            Exit Sub
        End If
        If Val.CheckAlphaNumeric(txtSpouseEmp.Text) = False Then
            MessageBox.Show("Employer name must be alpha-numeric.")
            Exit Sub
        End If
        'If Val.CheckAlphaNumeric(txtSpouseEmpAddress.Text) = False Then
        '    MessageBox.Show("Address must be alpha-numeric. If you are trying to add an apartment number or Suite, please use 'Apt' or 'Suite'.")
        '    Exit Sub
        'End If

        'save
        'Add Employer to database
        'see if employer already exists, if it does, use that empID

        Dim intEmployerID As Integer
        If txtEmployer.Text <> "" Then
            DB.SelectQuery("SELECT * FROM tblEmployer WHERE EmpName LIKE '" & txtEmployer.Text & "%'", "tblEmployer")
            If DB.CountDataset.Tables("tblEmployer").Rows.Count = 0 Then
                'See if emp info is filled out
                If txtEmployer.Text = "" Then
                    intEmployerID = 0
                Else
                    'add the employer info
                    DB.SecondarySelectQuery("SELECT * FROM tblEmployer", "tblEmployer")
                    'increment employer ID
                    intEmployerID = DB.SecondaryCountDataset.Tables("tblEmployer").Rows.Count + 1
                    'Add employer if fields are filled out
                    If txtEmployer.Text <> "" Then
                        DB.AddEmployer(txtEmployer.Text, txtPatEmpAddress.Text, txtEmpCity.Text, ddlEmpState.SelectedItem.ToString, txtEmpZip.Text, txtEmpPhone.Text, intEmployerID)
                        'DB.AddEmployer(txtEmployer.Text, txtPatEmpAddress.Text, txtEmpCity.Text, ddlEmpState.SelectedItem.ToString, txtEmpZip.Text, txtEmpPhone.Text)
                    End If
                End If
            Else
                'See if emp info is filled out
                If txtEmployer.Text = "" Then
                    intEmployerID = 0
                Else
                    'don't add new empoyler, just point patient to that empID
                    intEmployerID = CInt(DB.CountDataset.Tables("tblEmployer").Rows(0).Item("EmployerID").ToString)
                End If
            End If
        End If

        'If IsNothing(intEmployerID) = True Then
        If mintEmployerSave <> 0 Then
            DB.UpdateEmployerInfo(txtEmployer.Text, txtPatEmpAddress.Text, txtEmpCity.Text, ddlEmpState.SelectedItem.ToString, txtEmpZip.Text, txtEmpPhone.Text, intEmployerID)
        End If

        DB.AddEmployerID(intEmployerID.ToString, intPatientID + 3)

        'End If
        'Add Nearest Relative to database if filled out
        If txtNRfirstname.Text <> "" Then
            If mintEmployerSave = 0 Then
                DB.AddNewRelative(txtNRfirstname.Text, txtNRlastname.Text, txtNRRelation.Text, txtNRAddress.Text, txtNRCity.Text, ddlNRstate.SelectedItem.ToString, txtNRZip.Text, txtNRPhone.Text)
            Else
                DB.UpdateRelativeInfo(txtNRfirstname.Text, txtNRlastname.Text, txtNRRelation.Text, txtNRAddress.Text, txtNRPhone.Text, txtNRCity.Text, ddlNRstate.SelectedItem.ToString, mintNumberOfRelatives, txtNRZip.Text)
            End If
        End If

        'Spouse Employer - establish empID
        Dim intSpouseEmployerID As Integer
        DB.SelectQuery("SELECT * FROM tblEmployer WHERE EmpName LIKE '" & txtSpouseEmp.Text & "%'", "tblEmployer")
        If DB.CountDataset.Tables("tblEmployer").Rows.Count = 0 Then
            DB.SecondarySelectQuery("SELECT * FROM tblEmployer", "tblEmployer")
            'increment employer ID
            intSpouseEmployerID = DB.SecondaryCountDataset.Tables("tblEmployer").Rows.Count + 1
            'Add Spouse Employer info to database if filled out
            If txtSpouseEmp.Text <> "" Then
                DB.AddEmployer(txtSpouseEmp.Text, txtSpouseEmpAddress.Text, txtSpouseEmpCity.Text, ddlSpouseEmpState.SelectedItem.ToString, txtSpouseEmpZip.Text, txtSpouseEmpPhone.Text, intSpouseEmployerID)
                'DB.AddEmployer(txtSpouseEmp.Text, txtSpouseEmpAddress.Text, txtSpouseEmpCity.Text, ddlSpouseEmpState.SelectedItem.ToString, txtSpouseEmpZip.Text, txtSpouseEmpPhone.Text)
            End If
        Else
            'don't add new employer, just point patient to that empID
            intSpouseEmployerID = CInt(DB.CountDataset.Tables("tblEmployer").Rows(0).Item("EmployerID"))
        End If

        'Add Spouse to database if filled out
        If txtSpouseFN.Text <> "" Then
            If mintEmployerSave = 0 Then
                DB.AddNewSpouse(txtSpouseFN.Text, txtSpouseLN.Text, ddlSpouseGender.SelectedItem.ToString, txtSpouseEmpPhone.Text, intPatientID + 3, intSpouseEmployerID)
            Else
                DB.UpdateSpouseInfo(txtSpouseFN.Text, txtSpouseLN.Text, txtSpouseEmpPhone.Text, intPatientID + 3)
                DB.UpdateSpouseEmployerInfo(txtSpouseEmp.Text, txtSpouseEmpAddress.Text, txtSpouseEmpCity.Text, ddlSpouseEmpState.SelectedItem.ToString, txtSpouseEmpZip.Text, intSpouseEmployerID)
            End If
        End If


        'Establish Relative ID

        DB.SelectQuery("SELECT * FROM tblRelative", "tblRelative")
        If DB.CountDataset.Tables("tblRelative").Rows.Count = 0 Then
            If txtNRfirstname.Text = "" Then
                mintNumberOfRelatives = 0
            Else
                mintNumberOfRelatives = DB.CountDataset.Tables("tblRelative").Rows.Count + 1
            End If
        End If
        DB.AddRelativeID(mintNumberOfRelatives, intPatientID)


        'close
        If txtEmployer.Text = "" And txtSpouseFN.Text = "" And txtNRfirstname.Text = "" Then
            MessageBox.Show("No additional information saved because no information was entered.")
        Else
            MessageBox.Show("Additional Contact Information successfully saved!")
            NewPatient.Enabled = True
            DisableForm()
            mintEmployerSave += 1
        End If

    End Sub

    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub NewPatientEmployer_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If mintEmployerSave = 0 Then
            Dim strmsg As String
            Dim strtitle As String
            Dim strstyle As MsgBoxStyle
            Dim strresponse As MsgBoxResult
            strmsg = "Are you sure you want to exit without saving?"   ' Define message.
            strstyle = MsgBoxStyle.DefaultButton2 Or _
               MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
            strtitle = "Additional Contact Information"   ' Define title.
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

    Private Sub NewPatientEmployer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ddlEmpState.SelectedIndex = 0
        ddlNRstate.SelectedIndex = 0
        ddlSpouseEmpState.SelectedIndex = 0
        ddlSpouseGender.SelectedIndex = 0
        EnableForm()
        mintEmployerSave = 0
    End Sub

    Public Sub ClearForm()
        'Clear Nearest Relative Textboxes
        txtNRfirstname.Clear()
        txtNRlastname.Clear()
        txtNRAddress.Clear()
        txtNRRelation.Clear()
        txtNRCity.Clear()
        ddlNRstate.SelectedIndex = 0
        txtNRZip.Clear()
        txtNRPhone.Clear()

        'Clear EmployerTextboxes
        txtEmployer.Clear()
        txtPatEmpAddress.Clear()
        txtEmpCity.Clear()
        ddlEmpState.SelectedIndex = 0
        txtEmpZip.Clear()
        txtEmpPhone.Clear()

        'Clear Spouse Textboxes
        txtSpouseFN.Clear()
        txtSpouseLN.Clear()
        txtSpouseEmp.Clear()
        txtSpouseEmpAddress.Clear()
        txtSpouseEmpCity.Clear()
        ddlSpouseEmpState.SelectedIndex = 0
        txtSpouseEmpZip.Clear()
        txtSpouseEmpPhone.Clear()
    End Sub

    Public Sub DisableForm()
        'Disable Nearest Relative Textboxes
        txtNRfirstname.Enabled = False
        txtNRlastname.Enabled = False
        txtNRAddress.Enabled = False
        txtNRRelation.Enabled = False
        txtNRCity.Enabled = False
        ddlNRstate.Enabled = False
        txtNRZip.Enabled = False
        txtNRPhone.Enabled = False

        'Disable EmployerTextboxes
        txtEmployer.Enabled = False
        txtPatEmpAddress.Enabled = False
        txtEmpCity.Enabled = False
        ddlEmpState.Enabled = False
        txtEmpZip.Enabled = False
        txtEmpPhone.Enabled = False

        'Disable Spouse Textboxes
        txtSpouseFN.Enabled = False
        txtSpouseLN.Enabled = False
        txtSpouseEmp.Enabled = False
        txtSpouseEmpAddress.Enabled = False
        txtSpouseEmpCity.Enabled = False
        ddlSpouseEmpState.Enabled = False
        txtSpouseEmpZip.Enabled = False
        txtSpouseEmpPhone.Enabled = False
        'Connie Meng 11/10/13 Disable spouse gender DDL
        ddlSpouseGender.Enabled = False
    End Sub

    Public Sub EnableForm()
        'Enable Nearest Relative Textboxes
        txtNRfirstname.Enabled = True
        txtNRlastname.Enabled = True
        txtNRAddress.Enabled = True
        txtNRRelation.Enabled = True
        txtNRCity.Enabled = True
        ddlNRstate.Enabled = True
        txtNRZip.Enabled = True
        txtNRPhone.Enabled = True

        'Enable EmployerTextboxes
        txtEmployer.Enabled = True
        txtPatEmpAddress.Enabled = True
        txtEmpCity.Enabled = True
        ddlEmpState.Enabled = True
        txtEmpZip.Enabled = True
        txtEmpPhone.Enabled = True

        'Enable Spouse Textboxes
        txtSpouseFN.Enabled = True
        txtSpouseLN.Enabled = True
        txtSpouseEmp.Enabled = True
        txtSpouseEmpAddress.Enabled = True
        txtSpouseEmpCity.Enabled = True
        ddlSpouseEmpState.Enabled = True
        txtSpouseEmpZip.Enabled = True
        txtSpouseEmpPhone.Enabled = True
        'Connie Meng 11/10/13 reenabled gender ddl
        ddlSpouseGender.Enabled = True
    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        If txtEmployer.Enabled = True Then
            ClearForm()
        Else
            MessageBox.Show("Please enter edit mode to clear or edit form.")
            Exit Sub
        End If
    End Sub

    Private Sub ConfirmClose()
        If mintEmployerSave = 0 Then
            Dim strmsg As String
            Dim strtitle As String
            Dim strstyle As MsgBoxStyle
            Dim strresponse As MsgBoxResult
            strmsg = "Are you sure you want to exit without saving?"   ' Define message.
            strstyle = MsgBoxStyle.DefaultButton2 Or _
               MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
            strtitle = "Additional Contact Information"   ' Define title.
            ' Display message.
            strresponse = MsgBox(strmsg, strstyle, strtitle)
            If strresponse = MsgBoxResult.Yes Then   ' User chose Yes.
                ' close without saving
                ClearForm()
                Me.Close()
                NewPatient.Enabled = True

            Else
                ' return to form to save

            End If
        Else
            Me.Close()
        End If
    End Sub

    'Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs)
    '    EnableForm()
    'End Sub


    Private Sub btnEdit_Click_1(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        EnableForm()
    End Sub
End Class