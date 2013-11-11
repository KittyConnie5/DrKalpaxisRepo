<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewPatientInsurance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewPatientInsurance))
        Me.gbTertiaryInsurance = New System.Windows.Forms.GroupBox()
        Me.txtTerInsName = New System.Windows.Forms.TextBox()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.ddlTerInsState = New System.Windows.Forms.ComboBox()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.Label58 = New System.Windows.Forms.Label()
        Me.txtTerInsZip = New System.Windows.Forms.TextBox()
        Me.txtTerInsPhone = New System.Windows.Forms.TextBox()
        Me.txtTerInsGroupNo = New System.Windows.Forms.TextBox()
        Me.txtTerInsCity = New System.Windows.Forms.TextBox()
        Me.txtTerInsAddress = New System.Windows.Forms.TextBox()
        Me.txtTerInsID = New System.Windows.Forms.TextBox()
        Me.gbSecondaryInsurance = New System.Windows.Forms.GroupBox()
        Me.txtSecInsName = New System.Windows.Forms.TextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.ddlSecInsState = New System.Windows.Forms.ComboBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.txtSecInsZip = New System.Windows.Forms.TextBox()
        Me.txtSecInsPhone = New System.Windows.Forms.TextBox()
        Me.txtSecInsGroupNo = New System.Windows.Forms.TextBox()
        Me.txtSecInsCity = New System.Windows.Forms.TextBox()
        Me.txtSecInsAddress = New System.Windows.Forms.TextBox()
        Me.txtSecInsID = New System.Windows.Forms.TextBox()
        Me.gbPrimaryInsurance = New System.Windows.Forms.GroupBox()
        Me.txtPriInsName = New System.Windows.Forms.TextBox()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.ddlInsState = New System.Windows.Forms.ComboBox()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txtClaimsZip = New System.Windows.Forms.TextBox()
        Me.txtClaimsPhone = New System.Windows.Forms.TextBox()
        Me.txtInsGroup = New System.Windows.Forms.TextBox()
        Me.txtClaimsCity = New System.Windows.Forms.TextBox()
        Me.txtClaimsAddress = New System.Windows.Forms.TextBox()
        Me.txtInsuranceID = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnSecondary = New System.Windows.Forms.Button()
        Me.btnTertiary = New System.Windows.Forms.Button()
        Me.gbTertiaryInsurance.SuspendLayout()
        Me.gbSecondaryInsurance.SuspendLayout()
        Me.gbPrimaryInsurance.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbTertiaryInsurance
        '
        Me.gbTertiaryInsurance.Controls.Add(Me.txtTerInsName)
        Me.gbTertiaryInsurance.Controls.Add(Me.Label61)
        Me.gbTertiaryInsurance.Controls.Add(Me.ddlTerInsState)
        Me.gbTertiaryInsurance.Controls.Add(Me.Label52)
        Me.gbTertiaryInsurance.Controls.Add(Me.Label53)
        Me.gbTertiaryInsurance.Controls.Add(Me.Label54)
        Me.gbTertiaryInsurance.Controls.Add(Me.Label55)
        Me.gbTertiaryInsurance.Controls.Add(Me.Label56)
        Me.gbTertiaryInsurance.Controls.Add(Me.Label57)
        Me.gbTertiaryInsurance.Controls.Add(Me.Label58)
        Me.gbTertiaryInsurance.Controls.Add(Me.txtTerInsZip)
        Me.gbTertiaryInsurance.Controls.Add(Me.txtTerInsPhone)
        Me.gbTertiaryInsurance.Controls.Add(Me.txtTerInsGroupNo)
        Me.gbTertiaryInsurance.Controls.Add(Me.txtTerInsCity)
        Me.gbTertiaryInsurance.Controls.Add(Me.txtTerInsAddress)
        Me.gbTertiaryInsurance.Controls.Add(Me.txtTerInsID)
        Me.gbTertiaryInsurance.Location = New System.Drawing.Point(30, 418)
        Me.gbTertiaryInsurance.Name = "gbTertiaryInsurance"
        Me.gbTertiaryInsurance.Size = New System.Drawing.Size(455, 154)
        Me.gbTertiaryInsurance.TabIndex = 55
        Me.gbTertiaryInsurance.TabStop = False
        Me.gbTertiaryInsurance.Text = "Tertiary Insurance"
        Me.gbTertiaryInsurance.Visible = False
        '
        'txtTerInsName
        '
        Me.txtTerInsName.Location = New System.Drawing.Point(96, 20)
        Me.txtTerInsName.MaxLength = 45
        Me.txtTerInsName.Name = "txtTerInsName"
        Me.txtTerInsName.Size = New System.Drawing.Size(350, 22)
        Me.txtTerInsName.TabIndex = 0
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Location = New System.Drawing.Point(28, 25)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(61, 17)
        Me.Label61.TabIndex = 28
        Me.Label61.Text = "Provider"
        '
        'ddlTerInsState
        '
        Me.ddlTerInsState.BackColor = System.Drawing.SystemColors.Window
        Me.ddlTerInsState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlTerInsState.FormattingEnabled = True
        Me.ddlTerInsState.Items.AddRange(New Object() {"--", "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI"})
        Me.ddlTerInsState.Location = New System.Drawing.Point(280, 98)
        Me.ddlTerInsState.Name = "ddlTerInsState"
        Me.ddlTerInsState.Size = New System.Drawing.Size(52, 24)
        Me.ddlTerInsState.TabIndex = 5
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(22, 126)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(121, 17)
        Me.Label52.TabIndex = 13
        Me.Label52.Text = "Claims Telephone"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(35, 76)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(105, 17)
        Me.Label53.TabIndex = 12
        Me.Label53.Text = "Claims Address"
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(63, 101)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(76, 17)
        Me.Label54.TabIndex = 11
        Me.Label54.Text = "Claims City"
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.Location = New System.Drawing.Point(237, 102)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(41, 17)
        Me.Label55.TabIndex = 10
        Me.Label55.Text = "State"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(338, 102)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(28, 17)
        Me.Label56.TabIndex = 9
        Me.Label56.Text = "Zip"
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Location = New System.Drawing.Point(221, 50)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(102, 17)
        Me.Label57.TabIndex = 8
        Me.Label57.Text = "Group Number"
        '
        'Label58
        '
        Me.Label58.AutoSize = True
        Me.Label58.Location = New System.Drawing.Point(12, 50)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(75, 17)
        Me.Label58.TabIndex = 7
        Me.Label58.Text = "ID Number"
        '
        'txtTerInsZip
        '
        Me.txtTerInsZip.Location = New System.Drawing.Point(371, 98)
        Me.txtTerInsZip.MaxLength = 5
        Me.txtTerInsZip.Name = "txtTerInsZip"
        Me.txtTerInsZip.Size = New System.Drawing.Size(75, 22)
        Me.txtTerInsZip.TabIndex = 6
        '
        'txtTerInsPhone
        '
        Me.txtTerInsPhone.Location = New System.Drawing.Point(152, 123)
        Me.txtTerInsPhone.MaxLength = 11
        Me.txtTerInsPhone.Name = "txtTerInsPhone"
        Me.txtTerInsPhone.Size = New System.Drawing.Size(294, 22)
        Me.txtTerInsPhone.TabIndex = 7
        '
        'txtTerInsGroupNo
        '
        Me.txtTerInsGroupNo.Location = New System.Drawing.Point(328, 47)
        Me.txtTerInsGroupNo.MaxLength = 15
        Me.txtTerInsGroupNo.Name = "txtTerInsGroupNo"
        Me.txtTerInsGroupNo.Size = New System.Drawing.Size(118, 22)
        Me.txtTerInsGroupNo.TabIndex = 2
        '
        'txtTerInsCity
        '
        Me.txtTerInsCity.Location = New System.Drawing.Point(152, 98)
        Me.txtTerInsCity.MaxLength = 45
        Me.txtTerInsCity.Name = "txtTerInsCity"
        Me.txtTerInsCity.Size = New System.Drawing.Size(79, 22)
        Me.txtTerInsCity.TabIndex = 4
        '
        'txtTerInsAddress
        '
        Me.txtTerInsAddress.Location = New System.Drawing.Point(152, 73)
        Me.txtTerInsAddress.MaxLength = 100
        Me.txtTerInsAddress.Name = "txtTerInsAddress"
        Me.txtTerInsAddress.Size = New System.Drawing.Size(294, 22)
        Me.txtTerInsAddress.TabIndex = 3
        '
        'txtTerInsID
        '
        Me.txtTerInsID.Location = New System.Drawing.Point(96, 47)
        Me.txtTerInsID.MaxLength = 15
        Me.txtTerInsID.Name = "txtTerInsID"
        Me.txtTerInsID.Size = New System.Drawing.Size(121, 22)
        Me.txtTerInsID.TabIndex = 1
        '
        'gbSecondaryInsurance
        '
        Me.gbSecondaryInsurance.Controls.Add(Me.txtSecInsName)
        Me.gbSecondaryInsurance.Controls.Add(Me.Label60)
        Me.gbSecondaryInsurance.Controls.Add(Me.ddlSecInsState)
        Me.gbSecondaryInsurance.Controls.Add(Me.Label45)
        Me.gbSecondaryInsurance.Controls.Add(Me.Label46)
        Me.gbSecondaryInsurance.Controls.Add(Me.Label47)
        Me.gbSecondaryInsurance.Controls.Add(Me.Label48)
        Me.gbSecondaryInsurance.Controls.Add(Me.Label49)
        Me.gbSecondaryInsurance.Controls.Add(Me.Label50)
        Me.gbSecondaryInsurance.Controls.Add(Me.Label51)
        Me.gbSecondaryInsurance.Controls.Add(Me.txtSecInsZip)
        Me.gbSecondaryInsurance.Controls.Add(Me.txtSecInsPhone)
        Me.gbSecondaryInsurance.Controls.Add(Me.txtSecInsGroupNo)
        Me.gbSecondaryInsurance.Controls.Add(Me.txtSecInsCity)
        Me.gbSecondaryInsurance.Controls.Add(Me.txtSecInsAddress)
        Me.gbSecondaryInsurance.Controls.Add(Me.txtSecInsID)
        Me.gbSecondaryInsurance.Location = New System.Drawing.Point(30, 258)
        Me.gbSecondaryInsurance.Name = "gbSecondaryInsurance"
        Me.gbSecondaryInsurance.Size = New System.Drawing.Size(455, 154)
        Me.gbSecondaryInsurance.TabIndex = 54
        Me.gbSecondaryInsurance.TabStop = False
        Me.gbSecondaryInsurance.Text = "Secondary Insurance"
        Me.gbSecondaryInsurance.Visible = False
        '
        'txtSecInsName
        '
        Me.txtSecInsName.Location = New System.Drawing.Point(99, 20)
        Me.txtSecInsName.MaxLength = 45
        Me.txtSecInsName.Name = "txtSecInsName"
        Me.txtSecInsName.Size = New System.Drawing.Size(350, 22)
        Me.txtSecInsName.TabIndex = 0
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Location = New System.Drawing.Point(28, 25)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(61, 17)
        Me.Label60.TabIndex = 26
        Me.Label60.Text = "Provider"
        '
        'ddlSecInsState
        '
        Me.ddlSecInsState.BackColor = System.Drawing.SystemColors.Window
        Me.ddlSecInsState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlSecInsState.FormattingEnabled = True
        Me.ddlSecInsState.Items.AddRange(New Object() {"--", "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI"})
        Me.ddlSecInsState.Location = New System.Drawing.Point(283, 98)
        Me.ddlSecInsState.Name = "ddlSecInsState"
        Me.ddlSecInsState.Size = New System.Drawing.Size(52, 24)
        Me.ddlSecInsState.TabIndex = 6
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(25, 126)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(121, 17)
        Me.Label45.TabIndex = 13
        Me.Label45.Text = "Claims Telephone"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(38, 76)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(105, 17)
        Me.Label46.TabIndex = 12
        Me.Label46.Text = "Claims Address"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(66, 101)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(76, 17)
        Me.Label47.TabIndex = 11
        Me.Label47.Text = "Claims City"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(240, 102)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(41, 17)
        Me.Label48.TabIndex = 10
        Me.Label48.Text = "State"
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(341, 102)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(28, 17)
        Me.Label49.TabIndex = 9
        Me.Label49.Text = "Zip"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(224, 50)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(102, 17)
        Me.Label50.TabIndex = 2
        Me.Label50.Text = "Group Number"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Location = New System.Drawing.Point(15, 50)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(75, 17)
        Me.Label51.TabIndex = 7
        Me.Label51.Text = "ID Number"
        '
        'txtSecInsZip
        '
        Me.txtSecInsZip.Location = New System.Drawing.Point(374, 98)
        Me.txtSecInsZip.MaxLength = 5
        Me.txtSecInsZip.Name = "txtSecInsZip"
        Me.txtSecInsZip.Size = New System.Drawing.Size(75, 22)
        Me.txtSecInsZip.TabIndex = 7
        '
        'txtSecInsPhone
        '
        Me.txtSecInsPhone.Location = New System.Drawing.Point(155, 123)
        Me.txtSecInsPhone.MaxLength = 11
        Me.txtSecInsPhone.Name = "txtSecInsPhone"
        Me.txtSecInsPhone.Size = New System.Drawing.Size(294, 22)
        Me.txtSecInsPhone.TabIndex = 8
        '
        'txtSecInsGroupNo
        '
        Me.txtSecInsGroupNo.Location = New System.Drawing.Point(331, 47)
        Me.txtSecInsGroupNo.MaxLength = 15
        Me.txtSecInsGroupNo.Name = "txtSecInsGroupNo"
        Me.txtSecInsGroupNo.Size = New System.Drawing.Size(118, 22)
        Me.txtSecInsGroupNo.TabIndex = 3
        '
        'txtSecInsCity
        '
        Me.txtSecInsCity.Location = New System.Drawing.Point(155, 98)
        Me.txtSecInsCity.MaxLength = 45
        Me.txtSecInsCity.Name = "txtSecInsCity"
        Me.txtSecInsCity.Size = New System.Drawing.Size(79, 22)
        Me.txtSecInsCity.TabIndex = 5
        '
        'txtSecInsAddress
        '
        Me.txtSecInsAddress.Location = New System.Drawing.Point(155, 73)
        Me.txtSecInsAddress.MaxLength = 100
        Me.txtSecInsAddress.Name = "txtSecInsAddress"
        Me.txtSecInsAddress.Size = New System.Drawing.Size(294, 22)
        Me.txtSecInsAddress.TabIndex = 4
        '
        'txtSecInsID
        '
        Me.txtSecInsID.Location = New System.Drawing.Point(99, 47)
        Me.txtSecInsID.MaxLength = 15
        Me.txtSecInsID.Name = "txtSecInsID"
        Me.txtSecInsID.Size = New System.Drawing.Size(121, 22)
        Me.txtSecInsID.TabIndex = 1
        '
        'gbPrimaryInsurance
        '
        Me.gbPrimaryInsurance.Controls.Add(Me.txtPriInsName)
        Me.gbPrimaryInsurance.Controls.Add(Me.Label62)
        Me.gbPrimaryInsurance.Controls.Add(Me.ddlInsState)
        Me.gbPrimaryInsurance.Controls.Add(Me.Label41)
        Me.gbPrimaryInsurance.Controls.Add(Me.Label40)
        Me.gbPrimaryInsurance.Controls.Add(Me.Label39)
        Me.gbPrimaryInsurance.Controls.Add(Me.Label38)
        Me.gbPrimaryInsurance.Controls.Add(Me.Label37)
        Me.gbPrimaryInsurance.Controls.Add(Me.Label36)
        Me.gbPrimaryInsurance.Controls.Add(Me.Label35)
        Me.gbPrimaryInsurance.Controls.Add(Me.txtClaimsZip)
        Me.gbPrimaryInsurance.Controls.Add(Me.txtClaimsPhone)
        Me.gbPrimaryInsurance.Controls.Add(Me.txtInsGroup)
        Me.gbPrimaryInsurance.Controls.Add(Me.txtClaimsCity)
        Me.gbPrimaryInsurance.Controls.Add(Me.txtClaimsAddress)
        Me.gbPrimaryInsurance.Controls.Add(Me.txtInsuranceID)
        Me.gbPrimaryInsurance.Location = New System.Drawing.Point(30, 98)
        Me.gbPrimaryInsurance.Name = "gbPrimaryInsurance"
        Me.gbPrimaryInsurance.Size = New System.Drawing.Size(455, 154)
        Me.gbPrimaryInsurance.TabIndex = 53
        Me.gbPrimaryInsurance.TabStop = False
        Me.gbPrimaryInsurance.Text = "Primary Insurance"
        '
        'txtPriInsName
        '
        Me.txtPriInsName.Location = New System.Drawing.Point(96, 16)
        Me.txtPriInsName.MaxLength = 45
        Me.txtPriInsName.Name = "txtPriInsName"
        Me.txtPriInsName.Size = New System.Drawing.Size(350, 22)
        Me.txtPriInsName.TabIndex = 0
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(28, 21)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(61, 17)
        Me.Label62.TabIndex = 30
        Me.Label62.Text = "Provider"
        '
        'ddlInsState
        '
        Me.ddlInsState.BackColor = System.Drawing.SystemColors.Window
        Me.ddlInsState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlInsState.FormattingEnabled = True
        Me.ddlInsState.Items.AddRange(New Object() {"--", "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI"})
        Me.ddlInsState.Location = New System.Drawing.Point(280, 96)
        Me.ddlInsState.Name = "ddlInsState"
        Me.ddlInsState.Size = New System.Drawing.Size(52, 24)
        Me.ddlInsState.TabIndex = 5
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(22, 126)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(121, 17)
        Me.Label41.TabIndex = 13
        Me.Label41.Text = "Claims Telephone"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(35, 72)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(105, 17)
        Me.Label40.TabIndex = 12
        Me.Label40.Text = "Claims Address"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(63, 97)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(76, 17)
        Me.Label39.TabIndex = 11
        Me.Label39.Text = "Claims City"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(237, 98)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(41, 17)
        Me.Label38.TabIndex = 10
        Me.Label38.Text = "State"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(338, 98)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(28, 17)
        Me.Label37.TabIndex = 9
        Me.Label37.Text = "Zip"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(221, 46)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(102, 17)
        Me.Label36.TabIndex = 8
        Me.Label36.Text = "Group Number"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(12, 46)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(75, 17)
        Me.Label35.TabIndex = 7
        Me.Label35.Text = "ID Number"
        '
        'txtClaimsZip
        '
        Me.txtClaimsZip.Location = New System.Drawing.Point(371, 97)
        Me.txtClaimsZip.MaxLength = 5
        Me.txtClaimsZip.Name = "txtClaimsZip"
        Me.txtClaimsZip.Size = New System.Drawing.Size(75, 22)
        Me.txtClaimsZip.TabIndex = 6
        '
        'txtClaimsPhone
        '
        Me.txtClaimsPhone.Location = New System.Drawing.Point(152, 123)
        Me.txtClaimsPhone.MaxLength = 11
        Me.txtClaimsPhone.Name = "txtClaimsPhone"
        Me.txtClaimsPhone.Size = New System.Drawing.Size(294, 22)
        Me.txtClaimsPhone.TabIndex = 7
        '
        'txtInsGroup
        '
        Me.txtInsGroup.Location = New System.Drawing.Point(328, 43)
        Me.txtInsGroup.MaxLength = 15
        Me.txtInsGroup.Name = "txtInsGroup"
        Me.txtInsGroup.Size = New System.Drawing.Size(118, 22)
        Me.txtInsGroup.TabIndex = 2
        '
        'txtClaimsCity
        '
        Me.txtClaimsCity.Location = New System.Drawing.Point(152, 94)
        Me.txtClaimsCity.MaxLength = 45
        Me.txtClaimsCity.Name = "txtClaimsCity"
        Me.txtClaimsCity.Size = New System.Drawing.Size(79, 22)
        Me.txtClaimsCity.TabIndex = 4
        '
        'txtClaimsAddress
        '
        Me.txtClaimsAddress.Location = New System.Drawing.Point(152, 69)
        Me.txtClaimsAddress.MaxLength = 100
        Me.txtClaimsAddress.Name = "txtClaimsAddress"
        Me.txtClaimsAddress.Size = New System.Drawing.Size(294, 22)
        Me.txtClaimsAddress.TabIndex = 3
        '
        'txtInsuranceID
        '
        Me.txtInsuranceID.Location = New System.Drawing.Point(96, 43)
        Me.txtInsuranceID.MaxLength = 15
        Me.txtInsuranceID.Name = "txtInsuranceID"
        Me.txtInsuranceID.Size = New System.Drawing.Size(121, 22)
        Me.txtInsuranceID.TabIndex = 1
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(42, 23)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(487, 32)
        Me.Label25.TabIndex = 56
        Me.Label25.Text = "New Patient - Insurance Information"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(517, 395)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(41, 17)
        Me.Label29.TabIndex = 65
        Me.Label29.Text = "Clear"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(516, 511)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(43, 17)
        Me.Label28.TabIndex = 64
        Me.Label28.Text = "Close"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(517, 152)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(40, 17)
        Me.Label26.TabIndex = 61
        Me.Label26.Text = "Save"
        '
        'btnClear
        '
        Me.btnClear.BackgroundImage = Global.DaySheetTest.My.Resources.Resources.Clear
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClear.Location = New System.Drawing.Point(509, 332)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(58, 58)
        Me.btnClear.TabIndex = 62
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = Global.DaySheetTest.My.Resources.Resources.Cancel
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Red
        Me.btnCancel.Location = New System.Drawing.Point(509, 450)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(58, 58)
        Me.btnCancel.TabIndex = 63
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.Location = New System.Drawing.Point(509, 91)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(58, 58)
        Me.btnSave.TabIndex = 60
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(516, 280)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 17)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Edit"
        '
        'btnEdit
        '
        Me.btnEdit.BackgroundImage = Global.DaySheetTest.My.Resources.Resources.Edi
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEdit.Location = New System.Drawing.Point(509, 217)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(58, 58)
        Me.btnEdit.TabIndex = 70
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnSecondary
        '
        Me.btnSecondary.Location = New System.Drawing.Point(157, 58)
        Me.btnSecondary.Name = "btnSecondary"
        Me.btnSecondary.Size = New System.Drawing.Size(91, 39)
        Me.btnSecondary.TabIndex = 72
        Me.btnSecondary.Text = "Secondary"
        Me.btnSecondary.UseVisualStyleBackColor = True
        '
        'btnTertiary
        '
        Me.btnTertiary.Location = New System.Drawing.Point(327, 58)
        Me.btnTertiary.Name = "btnTertiary"
        Me.btnTertiary.Size = New System.Drawing.Size(100, 39)
        Me.btnTertiary.TabIndex = 73
        Me.btnTertiary.Text = "Tertiary"
        Me.btnTertiary.UseVisualStyleBackColor = True
        '
        'NewPatientInsurance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 583)
        Me.Controls.Add(Me.btnTertiary)
        Me.Controls.Add(Me.btnSecondary)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.gbTertiaryInsurance)
        Me.Controls.Add(Me.gbSecondaryInsurance)
        Me.Controls.Add(Me.gbPrimaryInsurance)
        Me.Name = "NewPatientInsurance"
        Me.Text = "New Patient - Insurance"
        Me.gbTertiaryInsurance.ResumeLayout(False)
        Me.gbTertiaryInsurance.PerformLayout()
        Me.gbSecondaryInsurance.ResumeLayout(False)
        Me.gbSecondaryInsurance.PerformLayout()
        Me.gbPrimaryInsurance.ResumeLayout(False)
        Me.gbPrimaryInsurance.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbTertiaryInsurance As System.Windows.Forms.GroupBox
    Friend WithEvents txtTerInsName As System.Windows.Forms.TextBox
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents ddlTerInsState As System.Windows.Forms.ComboBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents txtTerInsZip As System.Windows.Forms.TextBox
    Friend WithEvents txtTerInsPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtTerInsGroupNo As System.Windows.Forms.TextBox
    Friend WithEvents txtTerInsCity As System.Windows.Forms.TextBox
    Friend WithEvents txtTerInsAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtTerInsID As System.Windows.Forms.TextBox
    Friend WithEvents gbSecondaryInsurance As System.Windows.Forms.GroupBox
    Friend WithEvents txtSecInsName As System.Windows.Forms.TextBox
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents ddlSecInsState As System.Windows.Forms.ComboBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents txtSecInsZip As System.Windows.Forms.TextBox
    Friend WithEvents txtSecInsPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtSecInsGroupNo As System.Windows.Forms.TextBox
    Friend WithEvents txtSecInsCity As System.Windows.Forms.TextBox
    Friend WithEvents txtSecInsAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtSecInsID As System.Windows.Forms.TextBox
    Friend WithEvents gbPrimaryInsurance As System.Windows.Forms.GroupBox
    Friend WithEvents txtPriInsName As System.Windows.Forms.TextBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents ddlInsState As System.Windows.Forms.ComboBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtClaimsZip As System.Windows.Forms.TextBox
    Friend WithEvents txtClaimsPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtInsGroup As System.Windows.Forms.TextBox
    Friend WithEvents txtClaimsCity As System.Windows.Forms.TextBox
    Friend WithEvents txtClaimsAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtInsuranceID As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnSecondary As System.Windows.Forms.Button
    Friend WithEvents btnTertiary As System.Windows.Forms.Button
End Class
