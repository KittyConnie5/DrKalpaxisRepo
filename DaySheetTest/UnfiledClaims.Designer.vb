<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnfiledClaims
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
        Me.gvUnfiled = New System.Windows.Forms.DataGridView()
        Me.TblPatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KalpaxisDBDataSet = New DaySheetTest.KalpaxisDBDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TblPatientTableAdapter = New DaySheetTest.KalpaxisDBDataSetTableAdapters.tblPatientTableAdapter()
        Me.btnFileClaim = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        CType(Me.gvUnfiled, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KalpaxisDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gvUnfiled
        '
        Me.gvUnfiled.AllowUserToAddRows = False
        Me.gvUnfiled.AllowUserToDeleteRows = False
        Me.gvUnfiled.AllowUserToResizeColumns = False
        Me.gvUnfiled.AllowUserToResizeRows = False
        Me.gvUnfiled.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.gvUnfiled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gvUnfiled.Location = New System.Drawing.Point(16, 96)
        Me.gvUnfiled.Margin = New System.Windows.Forms.Padding(4)
        Me.gvUnfiled.Name = "gvUnfiled"
        Me.gvUnfiled.ReadOnly = True
        Me.gvUnfiled.RowTemplate.Height = 24
        Me.gvUnfiled.Size = New System.Drawing.Size(1099, 756)
        Me.gvUnfiled.TabIndex = 0
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(467, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(203, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Unfiled Claims"
        '
        'TblPatientTableAdapter
        '
        Me.TblPatientTableAdapter.ClearBeforeFill = True
        '
        'btnFileClaim
        '
        Me.btnFileClaim.BackgroundImage = Global.DaySheetTest.My.Resources.Resources.File_Claim
        Me.btnFileClaim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnFileClaim.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFileClaim.Location = New System.Drawing.Point(893, 5)
        Me.btnFileClaim.Margin = New System.Windows.Forms.Padding(4)
        Me.btnFileClaim.Name = "btnFileClaim"
        Me.btnFileClaim.Size = New System.Drawing.Size(107, 82)
        Me.btnFileClaim.TabIndex = 9
        Me.btnFileClaim.Text = "File Claim"
        Me.btnFileClaim.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFileClaim.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnFileClaim.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.BackgroundImage = Global.DaySheetTest.My.Resources.Resources.Home
        Me.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(1008, 4)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(4)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(107, 84)
        Me.btnHome.TabIndex = 10
        Me.btnHome.Text = "Home"
        Me.btnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'UnfiledClaims
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1137, 865)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.btnFileClaim)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.gvUnfiled)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "UnfiledClaims"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unfiled Claims"
        CType(Me.gvUnfiled, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KalpaxisDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gvUnfiled As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents KalpaxisDBDataSet As DaySheetTest.KalpaxisDBDataSet
    Friend WithEvents TblPatientBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPatientTableAdapter As DaySheetTest.KalpaxisDBDataSetTableAdapters.tblPatientTableAdapter
    Friend WithEvents btnFileClaim As System.Windows.Forms.Button
    Friend WithEvents btnHome As System.Windows.Forms.Button
End Class
