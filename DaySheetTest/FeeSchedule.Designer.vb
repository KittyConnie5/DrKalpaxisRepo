<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FeeSchedule
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TblFeeScheduleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KalpaxisDBDataSet5 = New DaySheetTest.KalpaxisDBDataSet5()
        Me.TblFeeScheduleTableAdapter = New DaySheetTest.KalpaxisDBDataSet5TableAdapters.tblFeeScheduleTableAdapter()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCPT = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCPT = New System.Windows.Forms.Button()
        Me.btnDescription = New System.Windows.Forms.Button()
        Me.lblCPTwarning = New System.Windows.Forms.Label()
        Me.lblDescriptionwarning = New System.Windows.Forms.Label()
        Me.btnMostCommon = New System.Windows.Forms.Button()
        Me.btnShowAll = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblFeeScheduleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KalpaxisDBDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(45, 154)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(746, 561)
        Me.DataGridView1.TabIndex = 0
        '
        'TblFeeScheduleBindingSource
        '
        Me.TblFeeScheduleBindingSource.DataMember = "tblFeeSchedule"
        Me.TblFeeScheduleBindingSource.DataSource = Me.KalpaxisDBDataSet5
        '
        'KalpaxisDBDataSet5
        '
        Me.KalpaxisDBDataSet5.DataSetName = "KalpaxisDBDataSet5"
        Me.KalpaxisDBDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblFeeScheduleTableAdapter
        '
        Me.TblFeeScheduleTableAdapter.ClearBeforeFill = True
        '
        'btnHome
        '
        Me.btnHome.BackgroundImage = Global.DaySheetTest.My.Resources.Resources.Home
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHome.Location = New System.Drawing.Point(760, 13)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(65, 60)
        Me.btnHome.TabIndex = 1
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(317, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fee Schedule"
        '
        'txtCPT
        '
        Me.txtCPT.CausesValidation = False
        Me.txtCPT.Location = New System.Drawing.Point(123, 70)
        Me.txtCPT.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCPT.Name = "txtCPT"
        Me.txtCPT.Size = New System.Drawing.Size(132, 22)
        Me.txtCPT.TabIndex = 3
        '
        'txtDescription
        '
        Me.txtDescription.CausesValidation = False
        Me.txtDescription.Location = New System.Drawing.Point(123, 109)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(132, 22)
        Me.txtDescription.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 74)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "CPT Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 109)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Description"
        '
        'btnCPT
        '
        Me.btnCPT.Location = New System.Drawing.Point(258, 69)
        Me.btnCPT.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCPT.Name = "btnCPT"
        Me.btnCPT.Size = New System.Drawing.Size(89, 28)
        Me.btnCPT.TabIndex = 8
        Me.btnCPT.Text = "Search"
        Me.btnCPT.UseVisualStyleBackColor = True
        '
        'btnDescription
        '
        Me.btnDescription.Location = New System.Drawing.Point(258, 106)
        Me.btnDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDescription.Name = "btnDescription"
        Me.btnDescription.Size = New System.Drawing.Size(89, 28)
        Me.btnDescription.TabIndex = 9
        Me.btnDescription.Text = "Search"
        Me.btnDescription.UseVisualStyleBackColor = True
        '
        'lblCPTwarning
        '
        Me.lblCPTwarning.AutoSize = True
        Me.lblCPTwarning.Location = New System.Drawing.Point(119, 100)
        Me.lblCPTwarning.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCPTwarning.Name = "lblCPTwarning"
        Me.lblCPTwarning.Size = New System.Drawing.Size(0, 17)
        Me.lblCPTwarning.TabIndex = 10
        '
        'lblDescriptionwarning
        '
        Me.lblDescriptionwarning.AutoSize = True
        Me.lblDescriptionwarning.Location = New System.Drawing.Point(123, 142)
        Me.lblDescriptionwarning.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescriptionwarning.Name = "lblDescriptionwarning"
        Me.lblDescriptionwarning.Size = New System.Drawing.Size(0, 17)
        Me.lblDescriptionwarning.TabIndex = 11
        '
        'btnMostCommon
        '
        Me.btnMostCommon.Location = New System.Drawing.Point(481, 100)
        Me.btnMostCommon.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMostCommon.Name = "btnMostCommon"
        Me.btnMostCommon.Size = New System.Drawing.Size(125, 28)
        Me.btnMostCommon.TabIndex = 12
        Me.btnMostCommon.Text = "Most Common"
        Me.btnMostCommon.UseVisualStyleBackColor = True
        '
        'btnShowAll
        '
        Me.btnShowAll.Location = New System.Drawing.Point(624, 100)
        Me.btnShowAll.Margin = New System.Windows.Forms.Padding(4)
        Me.btnShowAll.Name = "btnShowAll"
        Me.btnShowAll.Size = New System.Drawing.Size(123, 28)
        Me.btnShowAll.TabIndex = 13
        Me.btnShowAll.Text = "Show All"
        Me.btnShowAll.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(770, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 17)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Home"
        '
        'FeeSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(838, 841)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnShowAll)
        Me.Controls.Add(Me.btnMostCommon)
        Me.Controls.Add(Me.lblDescriptionwarning)
        Me.Controls.Add(Me.lblCPTwarning)
        Me.Controls.Add(Me.btnDescription)
        Me.Controls.Add(Me.btnCPT)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.txtCPT)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FeeSchedule"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fee Schedule"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblFeeScheduleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KalpaxisDBDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents KalpaxisDBDataSet5 As DaySheetTest.KalpaxisDBDataSet5
    Friend WithEvents TblFeeScheduleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblFeeScheduleTableAdapter As DaySheetTest.KalpaxisDBDataSet5TableAdapters.tblFeeScheduleTableAdapter
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCPT As System.Windows.Forms.TextBox
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCPT As System.Windows.Forms.Button
    Friend WithEvents btnDescription As System.Windows.Forms.Button
    Friend WithEvents lblCPTwarning As System.Windows.Forms.Label
    Friend WithEvents lblDescriptionwarning As System.Windows.Forms.Label
    Friend WithEvents btnMostCommon As System.Windows.Forms.Button
    Friend WithEvents btnShowAll As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
