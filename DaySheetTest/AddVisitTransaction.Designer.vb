<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddVisitTransaction
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
        Me.components = New System.ComponentModel.Container()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtReceiptNo = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtCheckNo = New System.Windows.Forms.TextBox()
        Me.lblSuggested = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtCheck = New System.Windows.Forms.TextBox()
        Me.txtCredit = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPreviousBal = New System.Windows.Forms.TextBox()
        Me.ddlCPT = New System.Windows.Forms.ComboBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCurrentBalance = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAdjustment = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCash = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCharge = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtAuthorization = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnAddCPTCode = New System.Windows.Forms.Button()
        Me.btnManualCPT = New System.Windows.Forms.Button()
        Me.lbCPT = New System.Windows.Forms.ListView()
        Me.dtpVisit = New System.Windows.Forms.DateTimePicker()
        Me.TblInsuranceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KalpaxisDBDataSet7 = New DaySheetTest.KalpaxisDBDataSet7()
        Me.TblInsuranceTableAdapter = New DaySheetTest.KalpaxisDBDataSet7TableAdapters.tblInsuranceTableAdapter()
        Me.btnCharge = New System.Windows.Forms.Button()
        Me.cbInsurance = New System.Windows.Forms.ComboBox()
        Me.TblInsuranceBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KalpaxisDBDataSet8 = New DaySheetTest.KalpaxisDBDataSet8()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lvManual = New System.Windows.Forms.ListView()
        Me.GetInsuranceToolStrip = New System.Windows.Forms.ToolStrip()
        Me.PatientIDToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.PatientIDToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.GetInsuranceToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.TblInsuranceTableAdapter1 = New DaySheetTest.KalpaxisDBDataSet8TableAdapters.tblInsuranceTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtReceipt = New System.Windows.Forms.TextBox()
        Me.label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.PatientIDToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.PatientIDToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        CType(Me.TblInsuranceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KalpaxisDBDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInsuranceBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KalpaxisDBDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GetInsuranceToolStrip.SuspendLayout()
        Me.FillByToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(-81, -55)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(114, 17)
        Me.Label20.TabIndex = 89
        Me.Label20.Text = "Receipt Number:"
        '
        'txtReceiptNo
        '
        Me.txtReceiptNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptNo.Location = New System.Drawing.Point(93, -58)
        Me.txtReceiptNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReceiptNo.MaxLength = 6
        Me.txtReceiptNo.Name = "txtReceiptNo"
        Me.txtReceiptNo.Size = New System.Drawing.Size(257, 23)
        Me.txtReceiptNo.TabIndex = 47
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(386, 573)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 17)
        Me.Label18.TabIndex = 87
        Me.Label18.Text = "Check #"
        '
        'txtCheckNo
        '
        Me.txtCheckNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckNo.Location = New System.Drawing.Point(453, 573)
        Me.txtCheckNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCheckNo.MaxLength = 5
        Me.txtCheckNo.Name = "txtCheckNo"
        Me.txtCheckNo.Size = New System.Drawing.Size(101, 23)
        Me.txtCheckNo.TabIndex = 65
        '
        'lblSuggested
        '
        Me.lblSuggested.AutoSize = True
        Me.lblSuggested.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuggested.Location = New System.Drawing.Point(353, 162)
        Me.lblSuggested.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSuggested.Name = "lblSuggested"
        Me.lblSuggested.Size = New System.Drawing.Size(0, 17)
        Me.lblSuggested.TabIndex = 86
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(136, 580)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 17)
        Me.Label16.TabIndex = 83
        Me.Label16.Text = "Check:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(136, 548)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 17)
        Me.Label15.TabIndex = 82
        Me.Label15.Text = "Credit:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(139, 513)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(44, 17)
        Me.Label14.TabIndex = 81
        Me.Label14.Text = "Cash:"
        '
        'txtCheck
        '
        Me.txtCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheck.Location = New System.Drawing.Point(193, 573)
        Me.txtCheck.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCheck.MaxLength = 10
        Me.txtCheck.Name = "txtCheck"
        Me.txtCheck.Size = New System.Drawing.Size(147, 23)
        Me.txtCheck.TabIndex = 64
        '
        'txtCredit
        '
        Me.txtCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCredit.Location = New System.Drawing.Point(193, 541)
        Me.txtCredit.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCredit.MaxLength = 10
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Size = New System.Drawing.Size(147, 23)
        Me.txtCredit.TabIndex = 62
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(57, 643)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 17)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Previous Balance:"
        '
        'txtPreviousBal
        '
        Me.txtPreviousBal.Enabled = False
        Me.txtPreviousBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreviousBal.Location = New System.Drawing.Point(193, 637)
        Me.txtPreviousBal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPreviousBal.MaxLength = 10
        Me.txtPreviousBal.Name = "txtPreviousBal"
        Me.txtPreviousBal.Size = New System.Drawing.Size(257, 23)
        Me.txtPreviousBal.TabIndex = 72
        '
        'ddlCPT
        '
        Me.ddlCPT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlCPT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ddlCPT.FormattingEnabled = True
        Me.ddlCPT.Items.AddRange(New Object() {"99215", "99214", "99213", "99212", "99211", "99205", "99204", "99203", "99202", "99201", "92250", "92083", "92015", "92014", "92012", "92004", "92002", "76514", "68040", "66821", "09926"})
        Me.ddlCPT.Location = New System.Drawing.Point(224, 264)
        Me.ddlCPT.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlCPT.Name = "ddlCPT"
        Me.ddlCPT.Size = New System.Drawing.Size(138, 25)
        Me.ddlCPT.TabIndex = 56
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(274, 714)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(73, 28)
        Me.btnClear.TabIndex = 77
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(355, 714)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(73, 28)
        Me.btnCancel.TabIndex = 78
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(192, 714)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(73, 28)
        Me.btnSubmit.TabIndex = 75
        Me.btnSubmit.Text = "Save"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(-21, -90)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 17)
        Me.Label12.TabIndex = 76
        Me.Label12.Text = "Patient ID:"
        '
        'txtPatientID
        '
        Me.txtPatientID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPatientID.Location = New System.Drawing.Point(93, -92)
        Me.txtPatientID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPatientID.MaxLength = 10
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.ReadOnly = True
        Me.txtPatientID.Size = New System.Drawing.Size(257, 23)
        Me.txtPatientID.TabIndex = 46
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(-1, -151)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(147, 17)
        Me.Label11.TabIndex = 73
        Me.Label11.Text = "Add New Transaction:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(56, 209)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 17)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "Insurance Used:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(66, 676)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 17)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Current Balance:"
        '
        'txtCurrentBalance
        '
        Me.txtCurrentBalance.Enabled = False
        Me.txtCurrentBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentBalance.Location = New System.Drawing.Point(193, 674)
        Me.txtCurrentBalance.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCurrentBalance.MaxLength = 10
        Me.txtCurrentBalance.Name = "txtCurrentBalance"
        Me.txtCurrentBalance.Size = New System.Drawing.Size(257, 23)
        Me.txtCurrentBalance.TabIndex = 74
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(98, 610)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 17)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Adjustment:"
        '
        'txtAdjustment
        '
        Me.txtAdjustment.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdjustment.Location = New System.Drawing.Point(193, 605)
        Me.txtAdjustment.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAdjustment.MaxLength = 10
        Me.txtAdjustment.Name = "txtAdjustment"
        Me.txtAdjustment.Size = New System.Drawing.Size(257, 23)
        Me.txtAdjustment.TabIndex = 70
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(64, 515)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 17)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Payment:"
        '
        'txtCash
        '
        Me.txtCash.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCash.Location = New System.Drawing.Point(193, 509)
        Me.txtCash.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCash.MaxLength = 10
        Me.txtCash.Name = "txtCash"
        Me.txtCash.Size = New System.Drawing.Size(147, 23)
        Me.txtCash.TabIndex = 60
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(109, 464)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 17)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Charge:"
        '
        'txtCharge
        '
        Me.txtCharge.Enabled = False
        Me.txtCharge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCharge.Location = New System.Drawing.Point(192, 458)
        Me.txtCharge.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCharge.MaxLength = 10
        Me.txtCharge.Name = "txtCharge"
        Me.txtCharge.Size = New System.Drawing.Size(257, 23)
        Me.txtCharge.TabIndex = 59
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(91, 272)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "CPT Code:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 167)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 17)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "Date of Transaction:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(70, 71)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 17)
        Me.Label3.TabIndex = 91
        Me.Label3.Text = "Patient Name:"
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientName.Location = New System.Drawing.Point(221, 86)
        Me.lblPatientName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(0, 17)
        Me.lblPatientName.TabIndex = 92
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(183, 9)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(305, 32)
        Me.Label19.TabIndex = 93
        Me.Label19.Text = "Add Visit Transaction"
        '
        'txtAuthorization
        '
        Me.txtAuthorization.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthorization.Location = New System.Drawing.Point(453, 537)
        Me.txtAuthorization.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAuthorization.MaxLength = 10
        Me.txtAuthorization.Name = "txtAuthorization"
        Me.txtAuthorization.Size = New System.Drawing.Size(101, 23)
        Me.txtAuthorization.TabIndex = 216
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(348, 541)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(103, 17)
        Me.Label17.TabIndex = 215
        Me.Label17.Text = "Authorization #"
        '
        'btnAddCPTCode
        '
        Me.btnAddCPTCode.Location = New System.Drawing.Point(370, 264)
        Me.btnAddCPTCode.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddCPTCode.Name = "btnAddCPTCode"
        Me.btnAddCPTCode.Size = New System.Drawing.Size(126, 25)
        Me.btnAddCPTCode.TabIndex = 217
        Me.btnAddCPTCode.Text = "Add"
        Me.btnAddCPTCode.UseVisualStyleBackColor = True
        '
        'btnManualCPT
        '
        Me.btnManualCPT.Location = New System.Drawing.Point(504, 264)
        Me.btnManualCPT.Margin = New System.Windows.Forms.Padding(4)
        Me.btnManualCPT.Name = "btnManualCPT"
        Me.btnManualCPT.Size = New System.Drawing.Size(126, 25)
        Me.btnManualCPT.TabIndex = 218
        Me.btnManualCPT.Text = "Manual CPT"
        Me.btnManualCPT.UseVisualStyleBackColor = True
        '
        'lbCPT
        '
        Me.lbCPT.Location = New System.Drawing.Point(191, 364)
        Me.lbCPT.Margin = New System.Windows.Forms.Padding(4)
        Me.lbCPT.Name = "lbCPT"
        Me.lbCPT.Size = New System.Drawing.Size(275, 41)
        Me.lbCPT.TabIndex = 219
        Me.lbCPT.UseCompatibleStateImageBehavior = False
        '
        'dtpVisit
        '
        Me.dtpVisit.Location = New System.Drawing.Point(225, 162)
        Me.dtpVisit.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpVisit.Name = "dtpVisit"
        Me.dtpVisit.Size = New System.Drawing.Size(265, 22)
        Me.dtpVisit.TabIndex = 221
        '
        'TblInsuranceBindingSource
        '
        Me.TblInsuranceBindingSource.DataMember = "tblInsurance"
        Me.TblInsuranceBindingSource.DataSource = Me.KalpaxisDBDataSet7
        '
        'KalpaxisDBDataSet7
        '
        Me.KalpaxisDBDataSet7.DataSetName = "KalpaxisDBDataSet7"
        Me.KalpaxisDBDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblInsuranceTableAdapter
        '
        Me.TblInsuranceTableAdapter.ClearBeforeFill = True
        '
        'btnCharge
        '
        Me.btnCharge.Location = New System.Drawing.Point(484, 364)
        Me.btnCharge.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCharge.Name = "btnCharge"
        Me.btnCharge.Size = New System.Drawing.Size(100, 32)
        Me.btnCharge.TabIndex = 224
        Me.btnCharge.Text = "Charge"
        Me.btnCharge.UseVisualStyleBackColor = True
        '
        'cbInsurance
        '
        Me.cbInsurance.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblInsuranceBindingSource1, "InsuranceName", True))
        Me.cbInsurance.DataSource = Me.TblInsuranceBindingSource1
        Me.cbInsurance.DisplayMember = "InsuranceName"
        Me.cbInsurance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbInsurance.FormattingEnabled = True
        Me.cbInsurance.Location = New System.Drawing.Point(225, 209)
        Me.cbInsurance.Name = "cbInsurance"
        Me.cbInsurance.Size = New System.Drawing.Size(265, 24)
        Me.cbInsurance.TabIndex = 225
        Me.cbInsurance.ValueMember = "InsuranceName"
        '
        'TblInsuranceBindingSource1
        '
        Me.TblInsuranceBindingSource1.DataMember = "tblInsurance"
        Me.TblInsuranceBindingSource1.DataSource = Me.KalpaxisDBDataSet8
        '
        'KalpaxisDBDataSet8
        '
        Me.KalpaxisDBDataSet8.DataSetName = "KalpaxisDBDataSet8"
        Me.KalpaxisDBDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(224, 71)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(264, 22)
        Me.txtName.TabIndex = 226
        '
        'lvManual
        '
        Me.lvManual.Location = New System.Drawing.Point(192, 406)
        Me.lvManual.Margin = New System.Windows.Forms.Padding(4)
        Me.lvManual.Name = "lvManual"
        Me.lvManual.Size = New System.Drawing.Size(275, 44)
        Me.lvManual.TabIndex = 227
        Me.lvManual.UseCompatibleStateImageBehavior = False
        '
        'GetInsuranceToolStrip
        '
        Me.GetInsuranceToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatientIDToolStripLabel, Me.PatientIDToolStripTextBox, Me.GetInsuranceToolStripButton})
        Me.GetInsuranceToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.GetInsuranceToolStrip.Name = "GetInsuranceToolStrip"
        Me.GetInsuranceToolStrip.Size = New System.Drawing.Size(628, 27)
        Me.GetInsuranceToolStrip.TabIndex = 228
        Me.GetInsuranceToolStrip.Text = "GetInsuranceToolStrip"
        Me.GetInsuranceToolStrip.Visible = False
        '
        'PatientIDToolStripLabel
        '
        Me.PatientIDToolStripLabel.Name = "PatientIDToolStripLabel"
        Me.PatientIDToolStripLabel.Size = New System.Drawing.Size(73, 24)
        Me.PatientIDToolStripLabel.Text = "PatientID:"
        '
        'PatientIDToolStripTextBox
        '
        Me.PatientIDToolStripTextBox.Name = "PatientIDToolStripTextBox"
        Me.PatientIDToolStripTextBox.Size = New System.Drawing.Size(100, 27)
        '
        'GetInsuranceToolStripButton
        '
        Me.GetInsuranceToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.GetInsuranceToolStripButton.Name = "GetInsuranceToolStripButton"
        Me.GetInsuranceToolStripButton.Size = New System.Drawing.Size(98, 24)
        Me.GetInsuranceToolStripButton.Text = "GetInsurance"
        '
        'TblInsuranceTableAdapter1
        '
        Me.TblInsuranceTableAdapter1.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 121)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 17)
        Me.Label2.TabIndex = 230
        Me.Label2.Text = "Receipt Number:"
        '
        'txtReceipt
        '
        Me.txtReceipt.Location = New System.Drawing.Point(224, 116)
        Me.txtReceipt.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReceipt.MaxLength = 6
        Me.txtReceipt.Name = "txtReceipt"
        Me.txtReceipt.Size = New System.Drawing.Size(261, 22)
        Me.txtReceipt.TabIndex = 229
        '
        'label21
        '
        Me.label21.AutoSize = True
        Me.label21.Location = New System.Drawing.Point(100, 419)
        Me.label21.Name = "label21"
        Me.label21.Size = New System.Drawing.Size(85, 17)
        Me.label21.TabIndex = 231
        Me.label21.Text = "Manual CPT"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(109, 379)
        Me.Label22.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 17)
        Me.Label22.TabIndex = 232
        Me.Label22.Text = "CPT Code"
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatientIDToolStripLabel1, Me.PatientIDToolStripTextBox1, Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(620, 27)
        Me.FillByToolStrip.TabIndex = 233
        Me.FillByToolStrip.Text = "FillByToolStrip"
        Me.FillByToolStrip.Visible = False
        '
        'PatientIDToolStripLabel1
        '
        Me.PatientIDToolStripLabel1.Name = "PatientIDToolStripLabel1"
        Me.PatientIDToolStripLabel1.Size = New System.Drawing.Size(73, 24)
        Me.PatientIDToolStripLabel1.Text = "PatientID:"
        '
        'PatientIDToolStripTextBox1
        '
        Me.PatientIDToolStripTextBox1.Name = "PatientIDToolStripTextBox1"
        Me.PatientIDToolStripTextBox1.Size = New System.Drawing.Size(100, 27)
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(48, 24)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(12, 324)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(629, 23)
        Me.Label13.TabIndex = 234
        Me.Label13.Text = "* Charge button sums CPT Code amount.  It can only be clicked ONCE for the entire" & _
    " transaction. *"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(501, 116)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(13, 17)
        Me.Label23.TabIndex = 235
        Me.Label23.Text = "*"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.ForeColor = System.Drawing.Color.Red
        Me.Label24.Location = New System.Drawing.Point(472, 400)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(13, 17)
        Me.Label24.TabIndex = 236
        Me.Label24.Text = "*"
        '
        'AddVisitTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.ClientSize = New System.Drawing.Size(638, 754)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.label21)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtReceipt)
        Me.Controls.Add(Me.GetInsuranceToolStrip)
        Me.Controls.Add(Me.lvManual)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.cbInsurance)
        Me.Controls.Add(Me.btnCharge)
        Me.Controls.Add(Me.dtpVisit)
        Me.Controls.Add(Me.lbCPT)
        Me.Controls.Add(Me.btnManualCPT)
        Me.Controls.Add(Me.btnAddCPTCode)
        Me.Controls.Add(Me.txtAuthorization)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lblPatientName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.txtReceiptNo)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtCheckNo)
        Me.Controls.Add(Me.lblSuggested)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtCheck)
        Me.Controls.Add(Me.txtCredit)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPreviousBal)
        Me.Controls.Add(Me.ddlCPT)
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
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AddVisitTransaction"
        CType(Me.TblInsuranceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KalpaxisDBDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInsuranceBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KalpaxisDBDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GetInsuranceToolStrip.ResumeLayout(False)
        Me.GetInsuranceToolStrip.PerformLayout()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtReceiptNo As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtCheckNo As System.Windows.Forms.TextBox
    Friend WithEvents lblSuggested As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCheck As System.Windows.Forms.TextBox
    Friend WithEvents txtCredit As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPreviousBal As System.Windows.Forms.TextBox
    Friend WithEvents ddlCPT As System.Windows.Forms.ComboBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPatientID As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCurrentBalance As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAdjustment As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCash As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCharge As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblPatientName As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtAuthorization As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents btnAddCPTCode As System.Windows.Forms.Button
    Friend WithEvents btnManualCPT As System.Windows.Forms.Button
    Friend WithEvents lbCPT As System.Windows.Forms.ListView
    Friend WithEvents dtpVisit As System.Windows.Forms.DateTimePicker
    Friend WithEvents KalpaxisDBDataSet7 As DaySheetTest.KalpaxisDBDataSet7
    Friend WithEvents TblInsuranceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblInsuranceTableAdapter As DaySheetTest.KalpaxisDBDataSet7TableAdapters.tblInsuranceTableAdapter
    Friend WithEvents btnCharge As System.Windows.Forms.Button
    Friend WithEvents cbInsurance As System.Windows.Forms.ComboBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lvManual As System.Windows.Forms.ListView
    Friend WithEvents KalpaxisDBDataSet8 As DaySheetTest.KalpaxisDBDataSet8
    Friend WithEvents TblInsuranceBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblInsuranceTableAdapter1 As DaySheetTest.KalpaxisDBDataSet8TableAdapters.tblInsuranceTableAdapter
    Friend WithEvents GetInsuranceToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents PatientIDToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents PatientIDToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents GetInsuranceToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtReceipt As System.Windows.Forms.TextBox
    Friend WithEvents label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents FillByToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents PatientIDToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents PatientIDToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
End Class
