<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddInsurancePaymentTransaction
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
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblPatientName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtCheckNo = New System.Windows.Forms.TextBox()
        Me.lblSuggested = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCheck = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPreviousBal = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCurrentBalance = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpPaymentDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpTransactionDate = New System.Windows.Forms.DateTimePicker()
        Me.ddlInsurance = New System.Windows.Forms.ComboBox()
        Me.TblInsuranceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KalpaxisDBDataSet8 = New DaySheetTest.KalpaxisDBDataSet8()
        Me.TblInsuranceBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KalpaxisDBDataSet8BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblInsuranceBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KalpaxisDBDataSet11 = New DaySheetTest.KalpaxisDBDataSet11()
        Me.TblInsuranceBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KalpaxisDBDataSet9 = New DaySheetTest.KalpaxisDBDataSet9()
        Me.TblInsuranceTableAdapter = New DaySheetTest.KalpaxisDBDataSet8TableAdapters.tblInsuranceTableAdapter()
        Me.TblInsuranceTableAdapter1 = New DaySheetTest.KalpaxisDBDataSet9TableAdapters.tblInsuranceTableAdapter()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.TblInsuranceTableAdapter2 = New DaySheetTest.KalpaxisDBDataSet11TableAdapters.tblInsuranceTableAdapter()
        Me.FillBy3ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.PatientIDToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.PatientIDToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillBy3ToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.TblInsuranceBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.TblInsuranceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KalpaxisDBDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInsuranceBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KalpaxisDBDataSet8BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInsuranceBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KalpaxisDBDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInsuranceBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KalpaxisDBDataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillBy3ToolStrip.SuspendLayout()
        CType(Me.TblInsuranceBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(96, 25)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(472, 32)
        Me.Label19.TabIndex = 134
        Me.Label19.Text = "Add Insurance Payment Transaction"
        '
        'lblPatientName
        '
        Me.lblPatientName.AutoSize = True
        Me.lblPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatientName.Location = New System.Drawing.Point(327, 106)
        Me.lblPatientName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPatientName.Name = "lblPatientName"
        Me.lblPatientName.Size = New System.Drawing.Size(0, 17)
        Me.lblPatientName.TabIndex = 133
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(140, 91)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 17)
        Me.Label3.TabIndex = 132
        Me.Label3.Text = "Patient Name:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(461, 329)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 17)
        Me.Label18.TabIndex = 130
        Me.Label18.Text = "Check #"
        '
        'txtCheckNo
        '
        Me.txtCheckNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheckNo.Location = New System.Drawing.Point(528, 329)
        Me.txtCheckNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCheckNo.MaxLength = 5
        Me.txtCheckNo.Name = "txtCheckNo"
        Me.txtCheckNo.Size = New System.Drawing.Size(76, 23)
        Me.txtCheckNo.TabIndex = 112
        '
        'lblSuggested
        '
        Me.lblSuggested.AutoSize = True
        Me.lblSuggested.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuggested.Location = New System.Drawing.Point(441, 226)
        Me.lblSuggested.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSuggested.Name = "lblSuggested"
        Me.lblSuggested.Size = New System.Drawing.Size(0, 17)
        Me.lblSuggested.TabIndex = 129
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(245, 325)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(47, 17)
        Me.Label16.TabIndex = 128
        Me.Label16.Text = "Check"
        '
        'txtCheck
        '
        Me.txtCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCheck.Location = New System.Drawing.Point(303, 325)
        Me.txtCheck.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCheck.MaxLength = 10
        Me.txtCheck.Name = "txtCheck"
        Me.txtCheck.Size = New System.Drawing.Size(147, 23)
        Me.txtCheck.TabIndex = 111
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(123, 363)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 17)
        Me.Label9.TabIndex = 124
        Me.Label9.Text = "Previous Balance:"
        '
        'txtPreviousBal
        '
        Me.txtPreviousBal.Enabled = False
        Me.txtPreviousBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreviousBal.Location = New System.Drawing.Point(303, 361)
        Me.txtPreviousBal.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPreviousBal.MaxLength = 10
        Me.txtPreviousBal.Name = "txtPreviousBal"
        Me.txtPreviousBal.Size = New System.Drawing.Size(257, 23)
        Me.txtPreviousBal.TabIndex = 117
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(287, 449)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(73, 28)
        Me.btnClear.TabIndex = 122
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(368, 449)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(73, 28)
        Me.btnCancel.TabIndex = 123
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(205, 449)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(73, 28)
        Me.btnSubmit.TabIndex = 120
        Me.btnSubmit.Text = "Save"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(67, -26)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 23)
        Me.Label12.TabIndex = 121
        Me.Label12.Text = "Patient ID:"
        '
        'txtPatientID
        '
        Me.txtPatientID.Location = New System.Drawing.Point(181, -28)
        Me.txtPatientID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPatientID.MaxLength = 10
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.ReadOnly = True
        Me.txtPatientID.Size = New System.Drawing.Size(257, 22)
        Me.txtPatientID.TabIndex = 94
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(87, -87)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(306, 32)
        Me.Label11.TabIndex = 118
        Me.Label11.Text = "Add New Transaction:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(125, 186)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 17)
        Me.Label10.TabIndex = 114
        Me.Label10.Text = "Insurance Used:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(136, 409)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(114, 17)
        Me.Label8.TabIndex = 113
        Me.Label8.Text = "Current Balance:"
        '
        'txtCurrentBalance
        '
        Me.txtCurrentBalance.Enabled = False
        Me.txtCurrentBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCurrentBalance.Location = New System.Drawing.Point(303, 406)
        Me.txtCurrentBalance.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCurrentBalance.MaxLength = 10
        Me.txtCurrentBalance.Name = "txtCurrentBalance"
        Me.txtCurrentBalance.Size = New System.Drawing.Size(257, 23)
        Me.txtCurrentBalance.TabIndex = 119
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(171, 325)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 17)
        Me.Label6.TabIndex = 108
        Me.Label6.Text = "Payment:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(147, 277)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 17)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Payment For:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 135)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 17)
        Me.Label1.TabIndex = 96
        Me.Label1.Text = "Date of Transaction:"
        '
        'dtpPaymentDate
        '
        Me.dtpPaymentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpPaymentDate.Location = New System.Drawing.Point(303, 277)
        Me.dtpPaymentDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpPaymentDate.Name = "dtpPaymentDate"
        Me.dtpPaymentDate.Size = New System.Drawing.Size(265, 23)
        Me.dtpPaymentDate.TabIndex = 135
        '
        'dtpTransactionDate
        '
        Me.dtpTransactionDate.Location = New System.Drawing.Point(303, 135)
        Me.dtpTransactionDate.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpTransactionDate.Name = "dtpTransactionDate"
        Me.dtpTransactionDate.Size = New System.Drawing.Size(265, 22)
        Me.dtpTransactionDate.TabIndex = 138
        '
        'ddlInsurance
        '
        Me.ddlInsurance.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.TblInsuranceBindingSource, "InsuranceName", True))
        Me.ddlInsurance.DataSource = Me.TblInsuranceBindingSource4
        Me.ddlInsurance.DisplayMember = "InsuranceName"
        Me.ddlInsurance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlInsurance.FormattingEnabled = True
        Me.ddlInsurance.Location = New System.Drawing.Point(303, 182)
        Me.ddlInsurance.Margin = New System.Windows.Forms.Padding(4)
        Me.ddlInsurance.Name = "ddlInsurance"
        Me.ddlInsurance.Size = New System.Drawing.Size(160, 24)
        Me.ddlInsurance.TabIndex = 139
        Me.ddlInsurance.ValueMember = "InsuranceName"
        '
        'TblInsuranceBindingSource
        '
        Me.TblInsuranceBindingSource.DataMember = "tblInsurance"
        Me.TblInsuranceBindingSource.DataSource = Me.KalpaxisDBDataSet8
        '
        'KalpaxisDBDataSet8
        '
        Me.KalpaxisDBDataSet8.DataSetName = "KalpaxisDBDataSet8"
        Me.KalpaxisDBDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblInsuranceBindingSource4
        '
        Me.TblInsuranceBindingSource4.DataMember = "tblInsurance"
        Me.TblInsuranceBindingSource4.DataSource = Me.KalpaxisDBDataSet8BindingSource
        '
        'KalpaxisDBDataSet8BindingSource
        '
        Me.KalpaxisDBDataSet8BindingSource.DataSource = Me.KalpaxisDBDataSet8
        Me.KalpaxisDBDataSet8BindingSource.Position = 0
        '
        'TblInsuranceBindingSource2
        '
        Me.TblInsuranceBindingSource2.DataMember = "tblInsurance"
        Me.TblInsuranceBindingSource2.DataSource = Me.KalpaxisDBDataSet11
        '
        'KalpaxisDBDataSet11
        '
        Me.KalpaxisDBDataSet11.DataSetName = "KalpaxisDBDataSet11"
        Me.KalpaxisDBDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblInsuranceBindingSource1
        '
        Me.TblInsuranceBindingSource1.DataMember = "tblInsurance"
        Me.TblInsuranceBindingSource1.DataSource = Me.KalpaxisDBDataSet9
        '
        'KalpaxisDBDataSet9
        '
        Me.KalpaxisDBDataSet9.DataSetName = "KalpaxisDBDataSet9"
        Me.KalpaxisDBDataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblInsuranceTableAdapter
        '
        Me.TblInsuranceTableAdapter.ClearBeforeFill = True
        '
        'TblInsuranceTableAdapter1
        '
        Me.TblInsuranceTableAdapter1.ClearBeforeFill = True
        '
        'txtName
        '
        Me.txtName.Enabled = False
        Me.txtName.Location = New System.Drawing.Point(303, 91)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(265, 22)
        Me.txtName.TabIndex = 233
        '
        'TblInsuranceTableAdapter2
        '
        Me.TblInsuranceTableAdapter2.ClearBeforeFill = True
        '
        'FillBy3ToolStrip
        '
        Me.FillBy3ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatientIDToolStripLabel, Me.PatientIDToolStripTextBox, Me.FillBy3ToolStripButton})
        Me.FillBy3ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillBy3ToolStrip.Name = "FillBy3ToolStrip"
        Me.FillBy3ToolStrip.Size = New System.Drawing.Size(627, 27)
        Me.FillBy3ToolStrip.TabIndex = 234
        Me.FillBy3ToolStrip.Text = "FillBy3ToolStrip"
        Me.FillBy3ToolStrip.Visible = False
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
        'FillBy3ToolStripButton
        '
        Me.FillBy3ToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillBy3ToolStripButton.Name = "FillBy3ToolStripButton"
        Me.FillBy3ToolStripButton.Size = New System.Drawing.Size(56, 24)
        Me.FillBy3ToolStripButton.Text = "FillBy3"
        '
        'TblInsuranceBindingSource3
        '
        Me.TblInsuranceBindingSource3.DataMember = "tblInsurance"
        Me.TblInsuranceBindingSource3.DataSource = Me.KalpaxisDBDataSet8BindingSource
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(575, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 17)
        Me.Label2.TabIndex = 235
        Me.Label2.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(470, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 17)
        Me.Label5.TabIndex = 236
        Me.Label5.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(575, 283)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 17)
        Me.Label7.TabIndex = 237
        Me.Label7.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(611, 333)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 17)
        Me.Label13.TabIndex = 238
        Me.Label13.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(450, 330)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 17)
        Me.Label14.TabIndex = 239
        Me.Label14.Text = "*"
        '
        'AddInsurancePaymentTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(627, 502)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FillBy3ToolStrip)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.ddlInsurance)
        Me.Controls.Add(Me.dtpTransactionDate)
        Me.Controls.Add(Me.dtpPaymentDate)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.lblPatientName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtCheckNo)
        Me.Controls.Add(Me.lblSuggested)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtCheck)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPreviousBal)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtPatientID)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCurrentBalance)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AddInsurancePaymentTransaction"
        Me.Text = "AddInsurancePaymentTransaction"
        CType(Me.TblInsuranceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KalpaxisDBDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInsuranceBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KalpaxisDBDataSet8BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInsuranceBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KalpaxisDBDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInsuranceBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KalpaxisDBDataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillBy3ToolStrip.ResumeLayout(False)
        Me.FillBy3ToolStrip.PerformLayout()
        CType(Me.TblInsuranceBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblPatientName As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtCheckNo As System.Windows.Forms.TextBox
    Friend WithEvents lblSuggested As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtCheck As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPreviousBal As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtPatientID As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCurrentBalance As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpPaymentDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpTransactionDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ddlInsurance As System.Windows.Forms.ComboBox
    Friend WithEvents KalpaxisDBDataSet8BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents KalpaxisDBDataSet8 As DaySheetTest.KalpaxisDBDataSet8
    Friend WithEvents TblInsuranceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblInsuranceTableAdapter As DaySheetTest.KalpaxisDBDataSet8TableAdapters.tblInsuranceTableAdapter
    Friend WithEvents KalpaxisDBDataSet9 As DaySheetTest.KalpaxisDBDataSet9
    Friend WithEvents TblInsuranceBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblInsuranceTableAdapter1 As DaySheetTest.KalpaxisDBDataSet9TableAdapters.tblInsuranceTableAdapter
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents KalpaxisDBDataSet11 As DaySheetTest.KalpaxisDBDataSet11
    Friend WithEvents TblInsuranceBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents TblInsuranceTableAdapter2 As DaySheetTest.KalpaxisDBDataSet11TableAdapters.tblInsuranceTableAdapter
    Friend WithEvents FillBy3ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents PatientIDToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents PatientIDToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillBy3ToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblInsuranceBindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents TblInsuranceBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
