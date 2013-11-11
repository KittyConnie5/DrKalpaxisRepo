<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddTransaction
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
        Me.txtDateOfTransaction = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDateClaimFiled = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCharge = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAdjustment = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCurrentBalance = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnTodayDateOfTrans = New System.Windows.Forms.Button()
        Me.btnTodayDateClaimFiled = New System.Windows.Forms.Button()
        Me.ddlDescription = New System.Windows.Forms.ComboBox()
        Me.ddlInsurance = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPreviousBal = New System.Windows.Forms.TextBox()
        Me.txtAdjPercent = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCredit = New System.Windows.Forms.TextBox()
        Me.txtCheck = New System.Windows.Forms.TextBox()
        Me.txtDirectDeposit = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSuggested = New System.Windows.Forms.Label()
        Me.txtCheckNo = New System.Windows.Forms.TextBox()
        Me.txtDirectNo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtReceiptNo = New System.Windows.Forms.TextBox()
        Me.chkClaim = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'txtDateOfTransaction
        '
        Me.txtDateOfTransaction.Location = New System.Drawing.Point(261, 169)
        Me.txtDateOfTransaction.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDateOfTransaction.MaxLength = 10
        Me.txtDateOfTransaction.Name = "txtDateOfTransaction"
        Me.txtDateOfTransaction.Size = New System.Drawing.Size(257, 22)
        Me.txtDateOfTransaction.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 171)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date of Transaction:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(80, 209)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Date Claim Filed:"
        '
        'txtDateClaimFiled
        '
        Me.txtDateClaimFiled.Location = New System.Drawing.Point(261, 207)
        Me.txtDateClaimFiled.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDateClaimFiled.MaxLength = 10
        Me.txtDateClaimFiled.Name = "txtDateClaimFiled"
        Me.txtDateClaimFiled.Size = New System.Drawing.Size(257, 22)
        Me.txtDateClaimFiled.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(131, 308)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Description:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(168, 348)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 23)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Charge:"
        '
        'txtCharge
        '
        Me.txtCharge.Location = New System.Drawing.Point(261, 346)
        Me.txtCharge.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCharge.MaxLength = 10
        Me.txtCharge.Name = "txtCharge"
        Me.txtCharge.Size = New System.Drawing.Size(257, 22)
        Me.txtCharge.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(156, 385)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 23)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Payment:"
        '
        'txtCash
        '
        Me.txtCash.Location = New System.Drawing.Point(261, 383)
        Me.txtCash.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCash.MaxLength = 10
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(147, 22)
        Me.txtCash.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(135, 512)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(113, 23)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Adjustment:"
        '
        'txtAdjustment
        '
        Me.txtAdjustment.Location = New System.Drawing.Point(261, 512)
        Me.txtAdjustment.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAdjustment.MaxLength = 10
        Me.txtAdjustment.Name = "txtAdjustment"
        Me.txtAdjustment.Size = New System.Drawing.Size(180, 22)
        Me.txtAdjustment.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(88, 583)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(157, 23)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Current Balance:"
        '
        'txtCurrentBalance
        '
        Me.txtCurrentBalance.Location = New System.Drawing.Point(261, 581)
        Me.txtCurrentBalance.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCurrentBalance.MaxLength = 10
        Me.txtCurrentBalance.Name = "txtCurrentBalance"
        Me.txtCurrentBalance.Size = New System.Drawing.Size(257, 22)
        Me.txtCurrentBalance.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(95, 268)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(152, 23)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Insurance Used:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(167, 36)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(306, 32)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Add New Transaction:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(147, 97)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 23)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "Patient ID:"
        '
        'txtPatientID
        '
        Me.txtPatientID.Location = New System.Drawing.Point(261, 95)
        Me.txtPatientID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPatientID.MaxLength = 10
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.ReadOnly = True
        Me.txtPatientID.Size = New System.Drawing.Size(257, 22)
        Me.txtPatientID.TabIndex = 0
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(373, 633)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(73, 28)
        Me.btnSubmit.TabIndex = 20
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(520, 633)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(73, 28)
        Me.btnCancel.TabIndex = 22
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(447, 633)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(73, 28)
        Me.btnClear.TabIndex = 21
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnTodayDateOfTrans
        '
        Me.btnTodayDateOfTrans.Location = New System.Drawing.Point(529, 170)
        Me.btnTodayDateOfTrans.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTodayDateOfTrans.Name = "btnTodayDateOfTrans"
        Me.btnTodayDateOfTrans.Size = New System.Drawing.Size(64, 28)
        Me.btnTodayDateOfTrans.TabIndex = 3
        Me.btnTodayDateOfTrans.Text = "Today"
        Me.btnTodayDateOfTrans.UseVisualStyleBackColor = True
        '
        'btnTodayDateClaimFiled
        '
        Me.btnTodayDateClaimFiled.Location = New System.Drawing.Point(529, 208)
        Me.btnTodayDateClaimFiled.Margin = New System.Windows.Forms.Padding(4)
        Me.btnTodayDateClaimFiled.Name = "btnTodayDateClaimFiled"
        Me.btnTodayDateClaimFiled.Size = New System.Drawing.Size(64, 28)
        Me.btnTodayDateClaimFiled.TabIndex = 5
        Me.btnTodayDateClaimFiled.Text = "Today"
        Me.btnTodayDateClaimFiled.UseVisualStyleBackColor = True
        '
        'ddlDescription
        '
        Me.ddlDescription.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlDescription.FormattingEnabled = True
        Me.ddlDescription.Items.AddRange(New Object() {"--Select--", "09926", "09926", "11440", "15823", "37609", "65093", "65101", "65103", "65205", "65210", "65222", "65285", "65300", "65420", "65430", "65710", "65730", "65760", "65850", "65855", "65870", "65875", "66020", "66250", "66625", "66761", "66821", "66840", "66920", "66983", "66984", "66985", "66986", "67005", "67010", "67210", "67228", "67312", "67505", "67515", "67800", "67801", "67820", "67825", "67840", "67875", "67904", "67916", "67930", "67935", "68020", "68040", "68100", "68110", "68115", "68320", "68700", "68720", "68761", "68820", "76511", "76512", "76514", "76519", "87205", "92002", "92004", "92012", "92014", "92015", "92018", "92020", "92060", "92070", "92081", "92082", "92083", "92100", "92140", "92225", "92230", "92235", "92250", "92285", "92286", "92310", "92311", "92326", "92358", "92392", "99070", "99071", "99201", "99202", "99203", "99204", "99205", "99211", "99212", "99213", "99214", "99215", "99241", "99242", "99243", "99244", "99245", "99251", "99252", "99253", "99254", "99255", "99261", "99262", "99263", "99271", "99272", "99273", "99274", "99275", "99283", "99284", "99284", "99304", "99305", "99306", "99307", "99308", "99309", "99310", "15823-50", "15823-78", "76519-26", "A4263"})
        Me.ddlDescription.Location = New System.Drawing.Point(263, 305)
        Me.ddlDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlDescription.Name = "ddlDescription"
        Me.ddlDescription.Size = New System.Drawing.Size(145, 24)
        Me.ddlDescription.TabIndex = 7
        '
        'ddlInsurance
        '
        Me.ddlInsurance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlInsurance.FormattingEnabled = True
        Me.ddlInsurance.Items.AddRange(New Object() {"--Select--", "Default", "BCBS", "UHC", "WC", "MC"})
        Me.ddlInsurance.Location = New System.Drawing.Point(261, 265)
        Me.ddlInsurance.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlInsurance.Name = "ddlInsurance"
        Me.ddlInsurance.Size = New System.Drawing.Size(257, 24)
        Me.ddlInsurance.TabIndex = 6
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(75, 546)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(167, 23)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Previous Balance:"
        '
        'txtPreviousBal
        '
        Me.txtPreviousBal.Location = New System.Drawing.Point(261, 544)
        Me.txtPreviousBal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPreviousBal.MaxLength = 10
        Me.txtPreviousBal.Name = "txtPreviousBal"
        Me.txtPreviousBal.Size = New System.Drawing.Size(257, 22)
        Me.txtPreviousBal.TabIndex = 18
        '
        'txtAdjPercent
        '
        Me.txtAdjPercent.Location = New System.Drawing.Point(451, 512)
        Me.txtAdjPercent.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAdjPercent.MaxLength = 10
        Me.txtAdjPercent.Name = "txtAdjPercent"
        Me.txtAdjPercent.Size = New System.Drawing.Size(68, 22)
        Me.txtAdjPercent.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(517, 517)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(20, 17)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "%"
        '
        'txtCredit
        '
        Me.txtCredit.Location = New System.Drawing.Point(261, 415)
        Me.txtCredit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCredit.MaxLength = 10
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Size = New System.Drawing.Size(147, 22)
        Me.txtCredit.TabIndex = 11
        '
        'txtCheck
        '
        Me.txtCheck.Location = New System.Drawing.Point(261, 447)
        Me.txtCheck.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCheck.MaxLength = 10
        Me.txtCheck.Name = "txtCheck"
        Me.txtCheck.Size = New System.Drawing.Size(147, 22)
        Me.txtCheck.TabIndex = 12
        '
        'txtDirectDeposit
        '
        Me.txtDirectDeposit.Location = New System.Drawing.Point(263, 478)
        Me.txtDirectDeposit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDirectDeposit.MaxLength = 10
        Me.txtDirectDeposit.Name = "txtDirectDeposit"
        Me.txtDirectDeposit.Size = New System.Drawing.Size(147, 22)
        Me.txtDirectDeposit.TabIndex = 14
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(416, 390)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 16)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Cash"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(416, 418)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 16)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Credit"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(416, 450)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(48, 16)
        Me.Label16.TabIndex = 34
        Me.Label16.Text = "Check"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(416, 481)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 16)
        Me.Label17.TabIndex = 35
        Me.Label17.Text = "Direct Deposit"
        '
        'txtDescription
        '
        Me.txtDescription.Location = New System.Drawing.Point(447, 305)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(67, 22)
        Me.txtDescription.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(417, 309)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(21, 17)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "or"
        '
        'lblSuggested
        '
        Me.lblSuggested.AutoSize = True
        Me.lblSuggested.Location = New System.Drawing.Point(521, 350)
        Me.lblSuggested.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSuggested.Name = "lblSuggested"
        Me.lblSuggested.Size = New System.Drawing.Size(0, 17)
        Me.lblSuggested.TabIndex = 38
        '
        'txtCheckNo
        '
        Me.txtCheckNo.Location = New System.Drawing.Point(475, 447)
        Me.txtCheckNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCheckNo.MaxLength = 10
        Me.txtCheckNo.Name = "txtCheckNo"
        Me.txtCheckNo.Size = New System.Drawing.Size(76, 22)
        Me.txtCheckNo.TabIndex = 13
        '
        'txtDirectNo
        '
        Me.txtDirectNo.Location = New System.Drawing.Point(520, 478)
        Me.txtDirectNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDirectNo.MaxLength = 10
        Me.txtDirectNo.Name = "txtDirectNo"
        Me.txtDirectNo.Size = New System.Drawing.Size(72, 22)
        Me.txtDirectNo.TabIndex = 15
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(553, 450)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(60, 16)
        Me.Label18.TabIndex = 41
        Me.Label18.Text = "Check #"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(596, 481)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(60, 16)
        Me.Label19.TabIndex = 42
        Me.Label19.Text = "Check #"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(87, 132)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(157, 23)
        Me.Label20.TabIndex = 44
        Me.Label20.Text = "Receipt Number:"
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.Location = New System.Drawing.Point(261, 129)
        Me.txtReceiptNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReceiptNo.MaxLength = 6
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(257, 22)
        Me.txtReceiptNo.TabIndex = 1
        '
        'chkClaim
        '
        Me.chkClaim.AutoSize = True
        Me.chkClaim.Location = New System.Drawing.Point(263, 238)
        Me.chkClaim.Margin = New System.Windows.Forms.Padding(4)
        Me.chkClaim.Name = "chkClaim"
        Me.chkClaim.Size = New System.Drawing.Size(304, 21)
        Me.chkClaim.TabIndex = 45
        Me.chkClaim.Text = "This transaction does not need a claim filed"
        Me.chkClaim.UseVisualStyleBackColor = True
        '
        'AddTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 678)
        Me.Controls.Add(Me.chkClaim)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtReceiptNo)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtDirectNo)
        Me.Controls.Add(Me.txtCheckNo)
        Me.Controls.Add(Me.lblSuggested)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtDirectDeposit)
        Me.Controls.Add(Me.txtCheck)
        Me.Controls.Add(Me.txtCredit)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtAdjPercent)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPreviousBal)
        Me.Controls.Add(Me.ddlInsurance)
        Me.Controls.Add(Me.ddlDescription)
        Me.Controls.Add(Me.btnTodayDateClaimFiled)
        Me.Controls.Add(Me.btnTodayDateOfTrans)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtPatientID)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCurrentBalance)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtAdjustment)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCash)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCharge)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDateClaimFiled)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDateOfTransaction)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AddTransaction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Transaction"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtDateOfTransaction As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDateClaimFiled As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCharge As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAdjustment As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCurrentBalance As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPatientID As System.Windows.Forms.TextBox
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnTodayDateOfTrans As System.Windows.Forms.Button
    Friend WithEvents btnTodayDateClaimFiled As System.Windows.Forms.Button
    Friend WithEvents ddlDescription As System.Windows.Forms.ComboBox
    Friend WithEvents ddlInsurance As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPreviousBal As System.Windows.Forms.TextBox
    Friend WithEvents txtAdjPercent As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCredit As System.Windows.Forms.TextBox
    Friend WithEvents txtCheck As System.Windows.Forms.TextBox
    Friend WithEvents txtDirectDeposit As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblSuggested As System.Windows.Forms.Label
    Friend WithEvents txtCheckNo As System.Windows.Forms.TextBox
    Friend WithEvents txtDirectNo As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtReceiptNo As System.Windows.Forms.TextBox
    Friend WithEvents chkClaim As System.Windows.Forms.CheckBox
End Class
