<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DaySheet
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
        Me.btnSubmitbyDate = New System.Windows.Forms.Button()
        Me.btnShowToday = New System.Windows.Forms.Button()
        Me.TblTransactionBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblTransactionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.gvDaySheet = New System.Windows.Forms.DataGridView()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.ddlmonth = New System.Windows.Forms.ComboBox()
        Me.ddlyear = New System.Windows.Forms.ComboBox()
        Me.btnShowAll = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtChargeTotal = New System.Windows.Forms.TextBox()
        Me.txtPaymentTotal = New System.Windows.Forms.TextBox()
        Me.txtTotalRec = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.gbProofofPosting = New System.Windows.Forms.GroupBox()
        CType(Me.TblTransactionBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTransactionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvDaySheet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbProofofPosting.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSubmitbyDate
        '
        Me.btnSubmitbyDate.Location = New System.Drawing.Point(739, 43)
        Me.btnSubmitbyDate.Name = "btnSubmitbyDate"
        Me.btnSubmitbyDate.Size = New System.Drawing.Size(75, 23)
        Me.btnSubmitbyDate.TabIndex = 30
        Me.btnSubmitbyDate.Text = "Submit"
        Me.btnSubmitbyDate.UseVisualStyleBackColor = True
        '
        'btnShowToday
        '
        Me.btnShowToday.Location = New System.Drawing.Point(55, 53)
        Me.btnShowToday.Name = "btnShowToday"
        Me.btnShowToday.Size = New System.Drawing.Size(161, 23)
        Me.btnShowToday.TabIndex = 36
        Me.btnShowToday.Text = "Show Today's Transactions"
        Me.btnShowToday.UseVisualStyleBackColor = True
        '
        'TblTransactionBindingSource1
        '
        Me.TblTransactionBindingSource1.DataMember = "tblTransaction"
        '
        'TblTransactionBindingSource
        '
        Me.TblTransactionBindingSource.DataMember = "tblTransaction"
        '
        'gvDaySheet
        '
        Me.gvDaySheet.AllowUserToAddRows = False
        Me.gvDaySheet.AllowUserToDeleteRows = False
        Me.gvDaySheet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvDaySheet.Location = New System.Drawing.Point(26, 107)
        Me.gvDaySheet.Name = "gvDaySheet"
        Me.gvDaySheet.ReadOnly = True
        Me.gvDaySheet.Size = New System.Drawing.Size(1244, 386)
        Me.gvDaySheet.TabIndex = 34
        '
        'btnHome
        '
        Me.btnHome.BackgroundImage = Global.DaySheetTest.My.Resources.Resources.Home
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHome.Location = New System.Drawing.Point(1221, 11)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(49, 49)
        Me.btnHome.TabIndex = 37
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(460, 53)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(42, 13)
        Me.Label34.TabIndex = 42
        Me.Label34.Text = "Month"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(603, 53)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(33, 13)
        Me.Label35.TabIndex = 43
        Me.Label35.Text = "Year"
        '
        'ddlmonth
        '
        Me.ddlmonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlmonth.FormattingEnabled = True
        Me.ddlmonth.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.ddlmonth.Location = New System.Drawing.Point(503, 45)
        Me.ddlmonth.Name = "ddlmonth"
        Me.ddlmonth.Size = New System.Drawing.Size(94, 21)
        Me.ddlmonth.TabIndex = 44
        '
        'ddlyear
        '
        Me.ddlyear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlyear.FormattingEnabled = True
        Me.ddlyear.Items.AddRange(New Object() {"2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020"})
        Me.ddlyear.Location = New System.Drawing.Point(638, 45)
        Me.ddlyear.Name = "ddlyear"
        Me.ddlyear.Size = New System.Drawing.Size(95, 21)
        Me.ddlyear.TabIndex = 45
        '
        'btnShowAll
        '
        Me.btnShowAll.Location = New System.Drawing.Point(55, 24)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(161, 23)
        Me.btnShowAll.TabIndex = 52
        Me.btnShowAll.Text = "Show All Transactions"
        Me.btnShowAll.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Total Receivables"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Total Payments"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total Charges"
        '
        'txtChargeTotal
        '
        Me.txtChargeTotal.Location = New System.Drawing.Point(184, 23)
        Me.txtChargeTotal.Name = "txtChargeTotal"
        Me.txtChargeTotal.ReadOnly = True
        Me.txtChargeTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtChargeTotal.TabIndex = 1
        '
        'txtPaymentTotal
        '
        Me.txtPaymentTotal.Location = New System.Drawing.Point(184, 45)
        Me.txtPaymentTotal.Name = "txtPaymentTotal"
        Me.txtPaymentTotal.ReadOnly = True
        Me.txtPaymentTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtPaymentTotal.TabIndex = 2
        '
        'txtTotalRec
        '
        Me.txtTotalRec.Location = New System.Drawing.Point(184, 68)
        Me.txtTotalRec.Name = "txtTotalRec"
        Me.txtTotalRec.ReadOnly = True
        Me.txtTotalRec.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalRec.TabIndex = 2
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(171, 26)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(13, 13)
        Me.Label17.TabIndex = 27
        Me.Label17.Text = "$"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(171, 48)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(13, 13)
        Me.Label18.TabIndex = 28
        Me.Label18.Text = "$"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(170, 71)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(13, 13)
        Me.Label19.TabIndex = 28
        Me.Label19.Text = "$"
        '
        'gbProofofPosting
        '
        Me.gbProofofPosting.Controls.Add(Me.Label19)
        Me.gbProofofPosting.Controls.Add(Me.Label18)
        Me.gbProofofPosting.Controls.Add(Me.Label17)
        Me.gbProofofPosting.Controls.Add(Me.txtTotalRec)
        Me.gbProofofPosting.Controls.Add(Me.txtPaymentTotal)
        Me.gbProofofPosting.Controls.Add(Me.txtChargeTotal)
        Me.gbProofofPosting.Controls.Add(Me.Label1)
        Me.gbProofofPosting.Controls.Add(Me.Label2)
        Me.gbProofofPosting.Controls.Add(Me.Label3)
        Me.gbProofofPosting.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbProofofPosting.Location = New System.Drawing.Point(468, 516)
        Me.gbProofofPosting.Name = "gbProofofPosting"
        Me.gbProofofPosting.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.gbProofofPosting.Size = New System.Drawing.Size(293, 97)
        Me.gbProofofPosting.TabIndex = 31
        Me.gbProofofPosting.TabStop = False
        Me.gbProofofPosting.Text = "Account Receivables"
        '
        'DaySheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1229, 689)
        Me.Controls.Add(Me.btnShowAll)
        Me.Controls.Add(Me.ddlyear)
        Me.Controls.Add(Me.ddlmonth)
        Me.Controls.Add(Me.Label35)
        Me.Controls.Add(Me.Label34)
        Me.Controls.Add(Me.btnSubmitbyDate)
        Me.Controls.Add(Me.btnShowToday)
        Me.Controls.Add(Me.gvDaySheet)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.gbProofofPosting)
        Me.Name = "DaySheet"
        Me.Text = "Day Sheet"
        CType(Me.TblTransactionBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTransactionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvDaySheet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbProofofPosting.ResumeLayout(False)
        Me.gbProofofPosting.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSubmitbyDate As System.Windows.Forms.Button
    Friend WithEvents btnShowToday As System.Windows.Forms.Button
    Friend WithEvents TblTransactionBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblTransactionBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents gvDaySheet As System.Windows.Forms.DataGridView
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents ddlmonth As System.Windows.Forms.ComboBox
    Friend WithEvents ddlyear As System.Windows.Forms.ComboBox
    Friend WithEvents btnShowAll As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtChargeTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtPaymentTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalRec As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents gbProofofPosting As System.Windows.Forms.GroupBox
End Class
