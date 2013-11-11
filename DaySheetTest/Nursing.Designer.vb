<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nursing
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Nursing))
        Me.txtMD = New System.Windows.Forms.TextBox()
        Me.txtMDAddress = New System.Windows.Forms.TextBox()
        Me.txtMDCity = New System.Windows.Forms.TextBox()
        Me.ddlMDState = New System.Windows.Forms.ComboBox()
        Me.txtMDZip = New System.Windows.Forms.TextBox()
        Me.txtMDPhone = New System.Windows.Forms.TextBox()
        Me.txtMDNPI = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtNHZip = New System.Windows.Forms.TextBox()
        Me.ddlNHState = New System.Windows.Forms.ComboBox()
        Me.txtNHCity = New System.Windows.Forms.TextBox()
        Me.txtNHAddress = New System.Windows.Forms.TextBox()
        Me.txtNH = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtCTPhone = New System.Windows.Forms.TextBox()
        Me.txtCTZip = New System.Windows.Forms.TextBox()
        Me.txtCTState = New System.Windows.Forms.ComboBox()
        Me.txtCTCity = New System.Windows.Forms.TextBox()
        Me.txtCTAddress = New System.Windows.Forms.TextBox()
        Me.txtCT = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtMD
        '
        Me.txtMD.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMD.Location = New System.Drawing.Point(131, 88)
        Me.txtMD.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMD.MaxLength = 50
        Me.txtMD.Name = "txtMD"
        Me.txtMD.Size = New System.Drawing.Size(373, 25)
        Me.txtMD.TabIndex = 0
        '
        'txtMDAddress
        '
        Me.txtMDAddress.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMDAddress.Location = New System.Drawing.Point(131, 120)
        Me.txtMDAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMDAddress.MaxLength = 50
        Me.txtMDAddress.Name = "txtMDAddress"
        Me.txtMDAddress.Size = New System.Drawing.Size(373, 25)
        Me.txtMDAddress.TabIndex = 1
        '
        'txtMDCity
        '
        Me.txtMDCity.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMDCity.Location = New System.Drawing.Point(131, 152)
        Me.txtMDCity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMDCity.MaxLength = 50
        Me.txtMDCity.Name = "txtMDCity"
        Me.txtMDCity.Size = New System.Drawing.Size(101, 25)
        Me.txtMDCity.TabIndex = 2
        '
        'ddlMDState
        '
        Me.ddlMDState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlMDState.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlMDState.FormattingEnabled = True
        Me.ddlMDState.Items.AddRange(New Object() {"--", "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI"})
        Me.ddlMDState.Location = New System.Drawing.Point(290, 151)
        Me.ddlMDState.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlMDState.Name = "ddlMDState"
        Me.ddlMDState.Size = New System.Drawing.Size(57, 25)
        Me.ddlMDState.TabIndex = 3
        '
        'txtMDZip
        '
        Me.txtMDZip.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMDZip.Location = New System.Drawing.Point(402, 153)
        Me.txtMDZip.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMDZip.MaxLength = 5
        Me.txtMDZip.Name = "txtMDZip"
        Me.txtMDZip.Size = New System.Drawing.Size(103, 25)
        Me.txtMDZip.TabIndex = 4
        '
        'txtMDPhone
        '
        Me.txtMDPhone.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMDPhone.Location = New System.Drawing.Point(131, 184)
        Me.txtMDPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMDPhone.MaxLength = 10
        Me.txtMDPhone.Name = "txtMDPhone"
        Me.txtMDPhone.Size = New System.Drawing.Size(373, 25)
        Me.txtMDPhone.TabIndex = 5
        '
        'txtMDNPI
        '
        Me.txtMDNPI.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMDNPI.Location = New System.Drawing.Point(131, 216)
        Me.txtMDNPI.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMDNPI.MaxLength = 10
        Me.txtMDNPI.Name = "txtMDNPI"
        Me.txtMDNPI.Size = New System.Drawing.Size(373, 25)
        Me.txtMDNPI.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 94)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 17)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Main Doctor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(63, 126)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(91, 158)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 17)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "City"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(242, 157)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 17)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "State"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(367, 158)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 17)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Zip"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(73, 190)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 17)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Phone"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(34, 220)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(84, 17)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "NPI Number"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(367, 351)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 17)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "Zip"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(242, 350)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 17)
        Me.Label11.TabIndex = 38
        Me.Label11.Text = "State"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(91, 351)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(31, 17)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "City"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(63, 319)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 17)
        Me.Label13.TabIndex = 36
        Me.Label13.Text = "Address"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(10, 288)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(98, 17)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "Nursing Home"
        '
        'txtNHZip
        '
        Me.txtNHZip.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNHZip.Location = New System.Drawing.Point(402, 346)
        Me.txtNHZip.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNHZip.MaxLength = 5
        Me.txtNHZip.Name = "txtNHZip"
        Me.txtNHZip.Size = New System.Drawing.Size(103, 25)
        Me.txtNHZip.TabIndex = 11
        '
        'ddlNHState
        '
        Me.ddlNHState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlNHState.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlNHState.FormattingEnabled = True
        Me.ddlNHState.Items.AddRange(New Object() {"--", "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI"})
        Me.ddlNHState.Location = New System.Drawing.Point(290, 344)
        Me.ddlNHState.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlNHState.Name = "ddlNHState"
        Me.ddlNHState.Size = New System.Drawing.Size(57, 25)
        Me.ddlNHState.TabIndex = 10
        '
        'txtNHCity
        '
        Me.txtNHCity.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNHCity.Location = New System.Drawing.Point(131, 345)
        Me.txtNHCity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNHCity.MaxLength = 50
        Me.txtNHCity.Name = "txtNHCity"
        Me.txtNHCity.Size = New System.Drawing.Size(101, 25)
        Me.txtNHCity.TabIndex = 9
        '
        'txtNHAddress
        '
        Me.txtNHAddress.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNHAddress.Location = New System.Drawing.Point(131, 313)
        Me.txtNHAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNHAddress.MaxLength = 50
        Me.txtNHAddress.Name = "txtNHAddress"
        Me.txtNHAddress.Size = New System.Drawing.Size(373, 25)
        Me.txtNHAddress.TabIndex = 8
        '
        'txtNH
        '
        Me.txtNH.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNH.Location = New System.Drawing.Point(131, 281)
        Me.txtNH.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNH.MaxLength = 50
        Me.txtNH.Name = "txtNH"
        Me.txtNH.Size = New System.Drawing.Size(373, 25)
        Me.txtNH.TabIndex = 7
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(73, 519)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(49, 17)
        Me.Label16.TabIndex = 54
        Me.Label16.Text = "Phone"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(367, 487)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(28, 17)
        Me.Label17.TabIndex = 53
        Me.Label17.Text = "Zip"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(242, 485)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(41, 17)
        Me.Label18.TabIndex = 52
        Me.Label18.Text = "State"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(91, 487)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(31, 17)
        Me.Label19.TabIndex = 51
        Me.Label19.Text = "City"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(63, 455)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(60, 17)
        Me.Label20.TabIndex = 50
        Me.Label20.Text = "Address"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(0, 424)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(123, 17)
        Me.Label21.TabIndex = 49
        Me.Label21.Text = "Financial Executor"
        '
        'txtCTPhone
        '
        Me.txtCTPhone.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCTPhone.Location = New System.Drawing.Point(131, 512)
        Me.txtCTPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCTPhone.MaxLength = 10
        Me.txtCTPhone.Name = "txtCTPhone"
        Me.txtCTPhone.Size = New System.Drawing.Size(373, 25)
        Me.txtCTPhone.TabIndex = 17
        '
        'txtCTZip
        '
        Me.txtCTZip.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCTZip.Location = New System.Drawing.Point(402, 482)
        Me.txtCTZip.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCTZip.MaxLength = 5
        Me.txtCTZip.Name = "txtCTZip"
        Me.txtCTZip.Size = New System.Drawing.Size(103, 25)
        Me.txtCTZip.TabIndex = 16
        '
        'txtCTState
        '
        Me.txtCTState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtCTState.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCTState.FormattingEnabled = True
        Me.txtCTState.Items.AddRange(New Object() {"--", "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI"})
        Me.txtCTState.Location = New System.Drawing.Point(290, 479)
        Me.txtCTState.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCTState.Name = "txtCTState"
        Me.txtCTState.Size = New System.Drawing.Size(57, 25)
        Me.txtCTState.TabIndex = 15
        '
        'txtCTCity
        '
        Me.txtCTCity.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCTCity.Location = New System.Drawing.Point(131, 480)
        Me.txtCTCity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCTCity.MaxLength = 50
        Me.txtCTCity.Name = "txtCTCity"
        Me.txtCTCity.Size = New System.Drawing.Size(101, 25)
        Me.txtCTCity.TabIndex = 14
        '
        'txtCTAddress
        '
        Me.txtCTAddress.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCTAddress.Location = New System.Drawing.Point(131, 448)
        Me.txtCTAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCTAddress.MaxLength = 50
        Me.txtCTAddress.Name = "txtCTAddress"
        Me.txtCTAddress.Size = New System.Drawing.Size(373, 25)
        Me.txtCTAddress.TabIndex = 13
        '
        'txtCT
        '
        Me.txtCT.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCT.Location = New System.Drawing.Point(131, 416)
        Me.txtCT.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCT.MaxLength = 50
        Me.txtCT.Name = "txtCT"
        Me.txtCT.Size = New System.Drawing.Size(373, 25)
        Me.txtCT.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(79, 46)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(467, 25)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Additional Information for Nursing Home Patient"
        '
        'btnClear
        '
        Me.btnClear.BackgroundImage = Global.DaySheetTest.My.Resources.Resources.Clear
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClear.Location = New System.Drawing.Point(529, 324)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(60, 55)
        Me.btnClear.TabIndex = 19
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = Global.DaySheetTest.My.Resources.Resources.Cancel
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Red
        Me.btnCancel.Location = New System.Drawing.Point(529, 455)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(60, 55)
        Me.btnCancel.TabIndex = 20
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.Location = New System.Drawing.Point(529, 88)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(60, 55)
        Me.btnSave.TabIndex = 18
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtPatientID
        '
        Me.txtPatientID.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtPatientID.Enabled = False
        Me.txtPatientID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPatientID.Location = New System.Drawing.Point(12, 9)
        Me.txtPatientID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.Size = New System.Drawing.Size(80, 22)
        Me.txtPatientID.TabIndex = 56
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(538, 383)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(41, 17)
        Me.Label29.TabIndex = 69
        Me.Label29.Text = "Clear"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(538, 514)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(43, 17)
        Me.Label28.TabIndex = 68
        Me.Label28.Text = "Close"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(538, 150)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(40, 17)
        Me.Label26.TabIndex = 67
        Me.Label26.Text = "Save"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(538, 267)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 17)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Edit"
        '
        'btnEdit
        '
        Me.btnEdit.BackgroundImage = Global.DaySheetTest.My.Resources.Resources.Edi
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEdit.Location = New System.Drawing.Point(531, 204)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(58, 58)
        Me.btnEdit.TabIndex = 70
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Nursing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 559)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.txtPatientID)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtCTPhone)
        Me.Controls.Add(Me.txtCTZip)
        Me.Controls.Add(Me.txtCTState)
        Me.Controls.Add(Me.txtCTCity)
        Me.Controls.Add(Me.txtCTAddress)
        Me.Controls.Add(Me.txtCT)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtNHZip)
        Me.Controls.Add(Me.ddlNHState)
        Me.Controls.Add(Me.txtNHCity)
        Me.Controls.Add(Me.txtNHAddress)
        Me.Controls.Add(Me.txtNH)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtMDNPI)
        Me.Controls.Add(Me.txtMDPhone)
        Me.Controls.Add(Me.txtMDZip)
        Me.Controls.Add(Me.ddlMDState)
        Me.Controls.Add(Me.txtMDCity)
        Me.Controls.Add(Me.txtMDAddress)
        Me.Controls.Add(Me.txtMD)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Nursing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nursing"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMD As System.Windows.Forms.TextBox
    Friend WithEvents txtMDAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtMDCity As System.Windows.Forms.TextBox
    Friend WithEvents ddlMDState As System.Windows.Forms.ComboBox
    Friend WithEvents txtMDZip As System.Windows.Forms.TextBox
    Friend WithEvents txtMDPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtMDNPI As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtNHZip As System.Windows.Forms.TextBox
    Friend WithEvents ddlNHState As System.Windows.Forms.ComboBox
    Friend WithEvents txtNHCity As System.Windows.Forms.TextBox
    Friend WithEvents txtNHAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtNH As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtCTPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtCTZip As System.Windows.Forms.TextBox
    Friend WithEvents txtCTState As System.Windows.Forms.ComboBox
    Friend WithEvents txtCTCity As System.Windows.Forms.TextBox
    Friend WithEvents txtCTAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtCT As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtPatientID As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnEdit As System.Windows.Forms.Button
End Class
