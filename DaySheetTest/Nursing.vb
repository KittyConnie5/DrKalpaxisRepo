Imports System.Web
Public Class Nursing
    Dim mintSave As Integer = 0
    Dim DB As New ClassDB
    Dim Val As New ClassValidate

    Dim strCT As String
    Dim strCTAddress As String
    Dim strCTCity As String
    Dim strCTPhone As String
    Dim strCTState As String
    Dim strCTZip As String

    Dim strMD As String
    Dim strMDAddress As String
    Dim strMDCity As String
    Dim strMDState As String
    Dim strMDZip As String
    Dim strMDPhone As String
    Dim strMDNPI As String

    Dim strNH As String
    Dim strNHAddress As String
    Dim strNHCity As String
    Dim strNHZip As String
    Dim strNHState As String

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        If txtMD.Enabled = True Then
            ClearForm()
        Else
            MessageBox.Show("Please enter edit mode to clear or edit form.")
            Exit Sub
        End If
    End Sub

    Public Sub ClearForm()
        txtCT.Clear()
        txtCTAddress.Clear()
        txtCTCity.Clear()
        txtCTPhone.Clear()
        txtCTState.SelectedIndex = 0
        txtCTZip.Clear()

        txtMD.Clear()
        txtMDAddress.Clear()
        txtMDCity.Clear()
        ddlMDState.SelectedIndex = 0
        txtMDZip.Clear()
        txtMDPhone.Clear()
        txtMDNPI.Clear()

        txtNH.Clear()
        txtNHAddress.Clear()
        txtNHCity.Clear()
        txtNHZip.Clear()
        ddlNHState.SelectedIndex = 0

    End Sub
    Public Sub DisableForm()
        'disable textboxes
        txtCT.Enabled = False
        txtCTAddress.Enabled = False
        txtCTCity.Enabled = False
        txtCTPhone.Enabled = False
        txtCTState.Enabled = False
        txtCTZip.Enabled = False

        txtMD.Enabled = False
        txtMDAddress.Enabled = False
        txtMDCity.Enabled = False
        ddlMDState.Enabled = False
        txtMDZip.Enabled = False
        txtMDPhone.Enabled = False
        txtMDNPI.Enabled = False

        txtNH.Enabled = False
        txtNHAddress.Enabled = False
        txtNHCity.Enabled = False
        txtNHZip.Enabled = False
        ddlNHState.Enabled = False

    End Sub

    Public Sub EnableForm()
        'enable textboxes
        txtCT.Enabled = True
        txtCTAddress.Enabled = True
        txtCTCity.Enabled = True
        txtCTPhone.Enabled = True
        txtCTState.Enabled = True
        txtCTZip.Enabled = True

        txtMD.Enabled = True
        txtMDAddress.Enabled = True
        txtMDCity.Enabled = True
        ddlMDState.Enabled = True
        txtMDZip.Enabled = True
        txtMDPhone.Enabled = True
        txtMDNPI.Enabled = True


        txtNH.Enabled = True
        txtNHAddress.Enabled = True
        txtNHCity.Enabled = True
        txtNHZip.Enabled = True
        ddlNHState.Enabled = True

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Validate
        'alpha-numeric Fields
        If Val.CheckAlphaNumeric(txtMD.Text) = False Then
            MessageBox.Show("Main Doctor must be alpha-numeric")
            Exit Sub
        End If
        'If Val.CheckAlphaNumeric(txtMDAddress.Text) = False Then
        '    MessageBox.Show("Main Doctor Address must be alpha-numeric.  If you are trying to add an apartment number or Suite, please use 'Apt' or 'Suite'.")
        '    Exit Sub
        'End If
        If Val.CheckAlphaNumeric(txtNH.Text) = False Then
            MessageBox.Show("Nursing Home must be alpha-numeric")
            Exit Sub
        End If
        'If Val.CheckAlphaNumeric(txtNHAddress.Text) = False Then
        '    MessageBox.Show("Nursing Home Address must be alpha-numeric.  If you are trying to add an apartment number or Suite, please use 'Apt' or 'Suite'.")
        '    Exit Sub
        'End If
        If Val.CheckAlphaNumeric(txtCT.Text) = False Then
            MessageBox.Show("Care Taker must be alpha-numeric")
            Exit Sub
        End If
        'If Val.CheckAlphaNumeric(txtCTAddress.Text) = False Then
        '    MessageBox.Show("Care Taker Address must be alpha-numeric.  If you are trying to add an apartment number or Suite, please use 'Apt' or 'Suite'.")
        '    Exit Sub
        'End If

        'Numeric Fields
        If Val.CheckIntegerSubstring(txtMDZip.Text) = False Then
            MessageBox.Show("Zip code must be numeric")
            Exit Sub
        End If
        If Val.CheckIntegerSubstring(txtNHZip.Text) = False Then
            MessageBox.Show("Zip code must be numeric")
            Exit Sub
        End If
        If Val.CheckIntegerSubstring(txtCTZip.Text) = False Then
            MessageBox.Show("Zip code must be numeric")
            Exit Sub
        End If
        If Val.CheckIntegerSubstring(txtMDPhone.Text) = False Then
            MessageBox.Show("Phone number must be numeric")
            Exit Sub
        End If
        If Val.CheckIntegerSubstring(txtCTPhone.Text) = False Then
            MessageBox.Show("Phone number must be numeric")
            Exit Sub
        End If
        If Val.CheckIntegerSubstring(txtMDNPI.Text) = False Then
            MessageBox.Show("Main Doctor NPI number must be numeric")
            Exit Sub
        End If


        If txtCTPhone.Text <> "" Then
            If Len(txtCTPhone.Text) < 9 Then
                MessageBox.Show("Financial executor phone must be at least nine numbers.")
                Exit Sub
            End If
        End If

        If txtMDPhone.Text <> "" Then
            If Len(txtMDPhone.Text) < 9 Then
                MessageBox.Show("Main doctor phone must be at least nine numbers.")
                Exit Sub
            End If
        End If

        If txtCTZip.Text <> "" Then
            If Len(txtCTZip.Text) < 5 Then
                MessageBox.Show("Finacial executor zip code must be at least 5 numbers.")
                Exit Sub
            End If
        End If

        If txtMDZip.Text <> "" Then
            If Len(txtMDZip.Text) < 5 Then
                MessageBox.Show("Main doctor zip code must be at least 5 numbers.")
                Exit Sub
            End If
        End If

        If txtNHZip.Text <> "" Then
            If Len(txtNHZip.Text) < 5 Then
                MessageBox.Show("Nursing home zip code must be at least 5 numbers.")
                Exit Sub
            End If
        End If

        'Letter Fields
        If Val.CheckLetterSubstring(txtMDCity.Text) = False Then
            MessageBox.Show("City must contain only letters")
            Exit Sub
        End If
        If Val.CheckLetterSubstring(txtCTCity.Text) = False Then
            MessageBox.Show("City must contain only letters")
            Exit Sub
        End If
        If Val.CheckLetterSubstring(txtNHCity.Text) = False Then
            MessageBox.Show("City must contain only letters")
            Exit Sub
        End If

        Dim CTPhone As String
        CTPhone = txtCTPhone.Text

        Dim intpatientID As String
        intpatientID = NewPatient.mintPaitentID

        If txtMD.Text <> "" Then
            strMD = txtMD.Text
        End If

        If txtMDAddress.Text <> "" Then
            strMDAddress = txtMDAddress.Text
        End If

        If txtMDCity.Text <> "" Then
            strMDCity = txtMDCity.Text
        End If

        If txtMDNPI.Text <> "" Then
            strMDnpi = txtMDNPI.Text
        End If

        If txtMDPhone.Text <> "" Then
            strMDPhone = txtMDPhone.Text
        End If

        If txtMDZip.Text <> "" Then
            strMDZip = txtMDZip.Text
        End If

        If ddlMDState.SelectedItem <> "" Then
            strMDState = ddlMDState.SelectedItem.ToString
        End If

        If txtCT.Text <> "" Then
            strCT = txtCT.Text
        End If

        If txtCTAddress.Text <> "" Then
            strCTAddress = txtCTAddress.Text
        End If

        If txtCTCity.Text <> "" Then
            strCTCity = txtCTCity.Text
        End If

        If txtCTPhone.Text <> "" Then
            strCTPhone = txtCTPhone.Text
        End If

        If txtCTZip.Text <> "" Then
            strCTZip = txtCTZip.Text
        End If

        If txtCTState.SelectedItem <> "" Then
            strNHState = txtCTState.SelectedItem.ToString
        End If

        If txtNH.Text <> "" Then
            strNH = txtNH.Text
        End If

        If txtNHAddress.Text <> "" Then
            strNHAddress = txtNHAddress.Text
        End If

        If txtNHCity.Text <> "" Then
            strNHCity = txtNHCity.Text
        End If

        If txtNHZip.Text <> "" Then
            strNHZip = txtNHZip.Text
        End If

        If ddlNHState.SelectedItem <> "" Then
            strNHState = ddlNHState.SelectedItem.ToString
        End If

            If mintSave = 0 Then
                'Insert into DB
                DB.AddNursing(strMD, strMDAddress, strMDCity, strMDState, strMDZip, strMDPhone, strMDNPI, strNH, strNHAddress, strNHCity, strNHState, strNHZip, strCT, strCTAddress, strCTCity, strCTState, strCTZip, strCTPhone, intpatientID.ToString)
            Else
            DB.UpdateNursing(strMD, strMDAddress, strMDCity, strMDState, strMDZip, strMDPhone, strMDNPI, strNH, strNHAddress, strNHCity, strNHState, strNHZip, strCT, strCTAddress, strCTCity, strCTState, strCTZip, strCTPhone, intpatientID.ToString)
            End If

        'Insert into DB
        'DB.AddNursing(txtMD.Text, txtMDAddress.Text, txtMDCity.Text, ddlMDState.SelectedItem.ToString, txtMDZip.Text, txtMDPhone.Text, txtMDNPI.Text, txtNH.Text, txtNHAddress.Text, txtNHCity.Text, ddlNHState.SelectedItem.ToString, txtNHZip.Text, txtCT.Text, txtCTAddress.Text, txtCTCity.Text, txtCTState.SelectedItem.ToString, txtCTZip.Text, CTPhone, intpatientID)

        MessageBox.Show("Nursing Home Information successfully saved!")
        NewPatient.Enabled = True
        mintSave += 1
        DisableForm()

    End Sub

    Private Sub Nursing_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
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
                NewPatient.Enabled = True
            Else
                'dont close
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub Nursing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DB.SelectQuery("SELECT * FROM tblPatient", "tblPatient")
        txtPatientID.Text = NewPatient.mintPaitentID
        txtPatientID.Visible = False
        EnableForm()
        mintSave = 0

        'fill variables
        strCT = 0
        strCTAddress = 0
        strCTCity = 0
        strCTPhone = 0
        strCTState = 0
        strCTZip = 0

        strMD = 0
        strMDAddress = 0
        strMDCity = 0
        strMDState = 0
        strMDZip = 0
        strMDPhone = 0
        strMDNPI = 0

        strNH = 0
        strNHAddress = 0
        strNHCity = 0
        strNHZip = 0
        strNHState = 0
    End Sub

    Private Sub btnEdit_Click(sender As System.Object, e As System.EventArgs) Handles btnEdit.Click
        EnableForm()
    End Sub
End Class