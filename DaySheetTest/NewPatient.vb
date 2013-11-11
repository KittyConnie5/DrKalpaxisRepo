Imports System.Web

Public Class NewPatient
    Public mintPaitentID As Integer
    Dim Val As New ClassValidate
    Dim DB As New ClassDB
    Dim intEmployerID As Integer
    Dim mintNumberOfRelatives As Integer
    Dim mintSave As Integer = 0


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        If txtPatFN.Enabled = True Then
            ClearForm()
        Else
            MessageBox.Show("Please enter edit mode to clear or edit form.")
            Exit Sub
        End If
    End Sub

    Public Sub ClearForm()
        'Clear Patient Info Textboxes
        txtPatFN.Clear()
        txtPatLN.Clear()
        txtPatAddress.Clear()
        txtPatCity.Clear()
        ddlPatState.SelectedIndex = 0
        txtPatZip.Clear()
        txtPatPhone.Clear()
        ddlMonth.SelectedIndex = 0
        ddlDay.SelectedIndex = 0
        ddlYear.SelectedIndex = 0
        txtPatSSN.Clear()
        txtPatDriversLis.Clear()
        ddlGender.SelectedIndex = 0

        'Clear Comments box
        rtbComments.Clear()
    End Sub

    Public Sub DisableForm()
        'Disable Patient Info Textboxes
        txtPatFN.Enabled = False
        txtPatLN.Enabled = False
        txtPatAddress.Enabled = False
        txtPatCity.Enabled = False
        ddlPatState.Enabled = False
        txtPatZip.Enabled = False
        txtPatPhone.Enabled = False
        ddlMonth.Enabled = False
        ddlDay.Enabled = False
        ddlYear.Enabled = False
        txtPatSSN.Enabled = False
        txtPatDriversLis.Enabled = False
        ddlGender.Enabled = False

        'Disable Comments box
        rtbComments.Enabled = False
    End Sub

    Public Sub EnableForm()
        'Enable Patient Info Textboxes
        txtPatFN.Enabled = True
        txtPatLN.Enabled = True
        txtPatAddress.Enabled = True
        txtPatCity.Enabled = True
        ddlPatState.Enabled = True
        txtPatZip.Enabled = True
        txtPatPhone.Enabled = True
        ddlMonth.Enabled = True
        ddlDay.Enabled = True
        ddlYear.Enabled = True
        txtPatSSN.Enabled = True
        txtPatDriversLis.Enabled = True
        ddlGender.Enabled = True

        'Enable Comments box
        rtbComments.Enabled = True
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Get ride of apostrophes
        txtPatFN.Text.Replace("'", "")
        txtPatLN.Text.Replace("'", "")
        txtPatAddress.Text.Replace("'", "")
        txtPatCity.Text.Replace("'", "")
        rtbComments.Text.Replace("'", "")

        'trim text of spaces
        RTrim(txtPatFN.Text)
        RTrim(txtPatLN.Text)
        RTrim(txtPatCity.Text)

        'Validate
        'All letter fields
        If Val.CheckLetterSubstring(txtPatFN.Text) = False Then
            MessageBox.Show("First name must contain only letters")
            Exit Sub
        End If
        If Val.CheckLetterSubstring(txtPatLN.Text) = False Then
            MessageBox.Show("Last name must contain only letters")
            Exit Sub
        End If
        If Val.CheckLetterSubstring(txtPatCity.Text) = False Then
            MessageBox.Show("City name must contain only letters")
            Exit Sub
        End If

        'Zipcodes
        If Val.checkzipcode(txtPatZip.Text) = False Then
            MessageBox.Show("Zip code must be numeric")
            Exit Sub
        End If

        If Len(txtPatZip.Text) < 5 Then
            MessageBox.Show("Nearest relative zip code must be at least 5 numbers.")
            Exit Sub
        End If

        'Phone numbers
        If Val.CheckPhone(txtPatPhone.Text) = False Then
            MessageBox.Show("Phone number must be numeric")
            Exit Sub
        End If


        If Len(txtPatPhone.Text) < 9 Then
            MessageBox.Show("Spouse phone must be at least 9 numbers.")
            Exit Sub
        End If


        'SSN
        If Val.CheckSSN(txtPatSSN.Text) = False Then
            MessageBox.Show("Social Security Number must be numeric")
            Exit Sub
        End If

        'Drivers license
        If Val.CheckIntegerSubstring(txtPatDriversLis.Text) = False Then
            MessageBox.Show("Drivers License No must be numeric")
            Exit Sub
        End If

        'Alpha-numeric fields
        'If Val.CheckAlphaNumeric(txtPatAddress.Text) = False Then
        '    MessageBox.Show("Address must be alpha-numeric. If you are trying to add an apartment number or Suite, please use 'Apt' or 'Suite'.")
        '    Exit Sub
        'End If

        If Val.CheckComments(rtbComments.Text) = False Then
            MessageBox.Show("Comments must not contain any special characters")
            Exit Sub
        End If

        'Required Fields
        If txtPatFN.Text = "" Then
            MessageBox.Show("Please enter patient's first name")
            Exit Sub
        End If
        If txtPatLN.Text = "" Then
            MessageBox.Show("Please enter patient's last name")
            Exit Sub
        End If
        If ddlGender.SelectedIndex = 0 Then
            MessageBox.Show("Please enter patient's gender")
            Exit Sub
        End If
        If txtPatAddress.Text = "" Then
            MessageBox.Show("Please enter patient's address")
            Exit Sub
        End If
        If txtPatCity.Text = "" Then
            MessageBox.Show("Please enter patient's city")
            Exit Sub
        End If
        If ddlPatState.SelectedIndex = 0 Then
            MessageBox.Show("Please enter patient's state")
            Exit Sub
        End If
        If txtPatZip.Text = "" Then
            MessageBox.Show("Please enter patient's zip code")
            Exit Sub
        End If
        If txtPatPhone.Text = "" Then
            MessageBox.Show("Please enter patient's phone number")
            Exit Sub
        End If
        If ddlMonth.SelectedIndex = 0 Then
            MessageBox.Show("Please enter patient's birth month")
            Exit Sub
        End If
        If ddlDay.SelectedIndex = 0 Then
            MessageBox.Show("Please enter patient's birth day")
            Exit Sub
        End If
        If ddlYear.SelectedIndex = 0 Then
            MessageBox.Show("Please enter patient's birth year")
            Exit Sub
        End If

        If txtPatSSN.Text <> "" Then
            If Len(txtPatSSN.Text) < 9 Then
                MessageBox.Show("Please enter nine numbers for patient social security number.")
                Exit Sub
            End If
        End If

        'Add Patient to database
        If mintSave = 0 Then
            'Connie Meng 11/10/13, added "tostring" to the comments text box
            DB.AddNewPatient(txtPatFN.Text, txtPatLN.Text, txtPatAddress.Text, txtPatZip.Text, txtPatPhone.Text, ddlMonth.SelectedItem.ToString & "/" & ddlDay.SelectedItem.ToString & "/" & ddlYear.SelectedItem.ToString, txtPatDriversLis.Text, txtPatSSN.Text, ddlGender.SelectedItem.ToString, txtPatCity.Text, ddlPatState.SelectedItem.ToString, rtbComments.Text.ToString, mintNumberOfRelatives, intEmployerID)
            MessageBox.Show(txtPatFN.Text & " " & txtPatLN.Text & " has been added to the database!", "Patient Added!", MessageBoxButtons.OK)
            mintSave += 1
            DisableForm()
        Else
            'Connie 11/7/2013
            'Patient ID has 3 subtracted from it when doing edits, by adding 3 it will update correctly
            DB.UpdatePatientInfo(txtPatFN.Text, txtPatLN.Text, txtPatAddress.Text, txtPatZip.Text, txtPatPhone.Text, ddlMonth.SelectedItem.ToString & "/" & ddlDay.SelectedItem.ToString & "/" & ddlYear.SelectedItem.ToString, txtPatDriversLis.Text, txtPatSSN.Text, ddlGender.SelectedItem.ToString, txtPatCity.Text, ddlPatState.SelectedItem.ToString, rtbComments.Text.ToString, mintPaitentID + 3)
            MessageBox.Show(txtPatFN.Text & " " & txtPatLN.Text & "'s record has been updated!", "Patient Updated!", MessageBoxButtons.OK)
            mintSave += 1
            DisableForm()
        End If


    End Sub

    Private Sub NewPatient_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If mintSave = 0 Then
            Dim strmsg As String
            Dim strtitle As String
            Dim strstyle As MsgBoxStyle
            Dim strresponse As MsgBoxResult
            strmsg = "Are you sure you want to exit without saving?"   ' Define message.
            strstyle = MsgBoxStyle.DefaultButton2 Or _
               MsgBoxStyle.Critical Or MsgBoxStyle.YesNo
            strtitle = "Nursing Home Information"   ' Define title.
            ' Display message.
            strresponse = MsgBox(strmsg, strstyle, strtitle)
            If strresponse = MsgBoxResult.Yes Then   ' User chose Yes.
                ' close without saving
                ClearForm()
                Home.Show()
            Else
                'dont close
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub NewPatient_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtPatFN.Focus()
        ddlDay.SelectedIndex = 0
        ddlGender.SelectedIndex = 0
        ddlMonth.SelectedIndex = 0
        ddlPatState.SelectedIndex = 0
        ddlYear.SelectedIndex = 0
        mintSave = 0
        mintPaitentID = 0


        'Determine what Patient ID will be for FK
        DB.SelectQuery("SELECT * FROM tblPatient", "tblPatient")
        Dim intRowCount As Integer = DB.CountDataset.Tables("tblPatient").Rows.Count
        Dim intNumberOfPatients As Integer

        If intRowCount = 0 Then
            intNumberOfPatients = 0
        Else
            intNumberOfPatients = DB.CountDataset.Tables("tblPatient").Rows.Count + 1
        End If

        mintPaitentID = intNumberOfPatients

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
        Home.Show()
    End Sub

    Private Sub lnkNursing_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkNursing.LinkClicked
        'check for patient record
        If mintSave = 0 Then
            MessageBox.Show("Please fill out and save the initial patient information first!")
            Exit Sub
        Else
            Nursing.Show()
            Me.Enabled = False
            btnEdit.Enabled = True
        End If
    End Sub

    Private Sub lnkInsurance_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkInsurance.LinkClicked
        'check for patient record
        If mintSave = 0 Then
            MessageBox.Show("Please fill out and save the initial patient information first!")
            Exit Sub
        Else
            NewPatientInsurance.Show()
            Me.Enabled = False
            btnEdit.Enabled = True
        End If
    End Sub

    Private Sub lnkContact_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkContact.LinkClicked
        'check for patient record
        If mintSave = 0 Then
            MessageBox.Show("Please fill out and save the initial patient information first!")
            Exit Sub
        Else
            NewPatientEmployer.Show()
            Me.Enabled = False
            btnEdit.Enabled = True
        End If
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        EnableForm()
    End Sub
End Class