<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindPatient
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
        Me.TblPatientBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KalpaxisDBDataSet1 = New DaySheetTest.KalpaxisDBDataSet1()
        Me.TblPatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KalpaxisDBDataSet = New DaySheetTest.KalpaxisDBDataSet()
        Me.TblPatientTableAdapter = New DaySheetTest.KalpaxisDBDataSetTableAdapters.tblPatientTableAdapter()
        Me.TblPatientTableAdapter1 = New DaySheetTest.KalpaxisDBDataSet1TableAdapters.tblPatientTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.KalpaxisDBDataSet2 = New DaySheetTest.KalpaxisDBDataSet2()
        Me.TblPatientBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblPatientTableAdapter2 = New DaySheetTest.KalpaxisDBDataSet2TableAdapters.tblPatientTableAdapter()
        Me.KalpaxisDBDataSet3 = New DaySheetTest.KalpaxisDBDataSet3()
        Me.TblPatientBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblPatientTableAdapter3 = New DaySheetTest.KalpaxisDBDataSet3TableAdapters.tblPatientTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.TblPatientBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KalpaxisDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KalpaxisDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KalpaxisDBDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPatientBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KalpaxisDBDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPatientBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TblPatientBindingSource1
        '
        Me.TblPatientBindingSource1.DataMember = "tblPatient"
        Me.TblPatientBindingSource1.DataSource = Me.KalpaxisDBDataSet1
        '
        'KalpaxisDBDataSet1
        '
        Me.KalpaxisDBDataSet1.DataSetName = "KalpaxisDBDataSet1"
        Me.KalpaxisDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblPatientBindingSource
        '
        Me.TblPatientBindingSource.DataMember = "tblPatient"
        Me.TblPatientBindingSource.DataSource = Me.KalpaxisDBDataSet
        '
        'KalpaxisDBDataSet
        '
        Me.KalpaxisDBDataSet.DataSetName = "KalpaxisDBDataSet"
        Me.KalpaxisDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblPatientTableAdapter
        '
        Me.TblPatientTableAdapter.ClearBeforeFill = True
        '
        'TblPatientTableAdapter1
        '
        Me.TblPatientTableAdapter1.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 138)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Last Name:"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(195, 143)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(307, 22)
        Me.txtLastName.TabIndex = 1
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(511, 111)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(135, 57)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'KalpaxisDBDataSet2
        '
        Me.KalpaxisDBDataSet2.DataSetName = "KalpaxisDBDataSet2"
        Me.KalpaxisDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblPatientBindingSource2
        '
        Me.TblPatientBindingSource2.DataMember = "tblPatient"
        Me.TblPatientBindingSource2.DataSource = Me.KalpaxisDBDataSet2
        '
        'TblPatientTableAdapter2
        '
        Me.TblPatientTableAdapter2.ClearBeforeFill = True
        '
        'KalpaxisDBDataSet3
        '
        Me.KalpaxisDBDataSet3.DataSetName = "KalpaxisDBDataSet3"
        Me.KalpaxisDBDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblPatientBindingSource3
        '
        Me.TblPatientBindingSource3.DataMember = "tblPatient"
        Me.TblPatientBindingSource3.DataSource = Me.KalpaxisDBDataSet3
        '
        'TblPatientTableAdapter3
        '
        Me.TblPatientTableAdapter3.ClearBeforeFill = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(270, 33)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 32)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Find Patient"
        '
        'btnHome
        '
        Me.btnHome.BackgroundImage = Global.DaySheetTest.My.Resources.Resources.Home
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHome.Location = New System.Drawing.Point(645, 2)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(53, 49)
        Me.btnHome.TabIndex = 5
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'txtPatientID
        '
        Me.txtPatientID.BackColor = System.Drawing.SystemColors.Window
        Me.txtPatientID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPatientID.Location = New System.Drawing.Point(4, 2)
        Me.txtPatientID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.ReadOnly = True
        Me.txtPatientID.Size = New System.Drawing.Size(61, 15)
        Me.txtPatientID.TabIndex = 10
        Me.txtPatientID.Visible = False
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(195, 111)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(307, 22)
        Me.txtFirstName.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(79, 106)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 29)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "First Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(648, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Home"
        '
        'FindPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 187)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPatientID)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FindPatient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Find Patient"
        CType(Me.TblPatientBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KalpaxisDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KalpaxisDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KalpaxisDBDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPatientBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KalpaxisDBDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPatientBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents KalpaxisDBDataSet As DaySheetTest.KalpaxisDBDataSet
    Friend WithEvents TblPatientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPatientTableAdapter As DaySheetTest.KalpaxisDBDataSetTableAdapters.tblPatientTableAdapter
    Friend WithEvents KalpaxisDBDataSet1 As DaySheetTest.KalpaxisDBDataSet1
    Friend WithEvents TblPatientBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TblPatientTableAdapter1 As DaySheetTest.KalpaxisDBDataSet1TableAdapters.tblPatientTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents KalpaxisDBDataSet2 As DaySheetTest.KalpaxisDBDataSet2
    Friend WithEvents TblPatientBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents TblPatientTableAdapter2 As DaySheetTest.KalpaxisDBDataSet2TableAdapters.tblPatientTableAdapter
    Friend WithEvents KalpaxisDBDataSet3 As DaySheetTest.KalpaxisDBDataSet3
    Friend WithEvents TblPatientBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents TblPatientTableAdapter3 As DaySheetTest.KalpaxisDBDataSet3TableAdapters.tblPatientTableAdapter
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents txtPatientID As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
