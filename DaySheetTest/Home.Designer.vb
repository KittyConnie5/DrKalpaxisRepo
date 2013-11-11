<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Me.btnFileClaim = New System.Windows.Forms.Button()
        Me.btnSearchPatients = New System.Windows.Forms.Button()
        Me.btnLedger = New System.Windows.Forms.Button()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.btnNewPatient = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnFileClaim
        '
        Me.btnFileClaim.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFileClaim.Image = Global.DaySheetTest.My.Resources.Resources.File_Claim
        Me.btnFileClaim.Location = New System.Drawing.Point(892, 60)
        Me.btnFileClaim.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnFileClaim.Name = "btnFileClaim"
        Me.btnFileClaim.Size = New System.Drawing.Size(200, 171)
        Me.btnFileClaim.TabIndex = 4
        Me.btnFileClaim.Text = "File Claim"
        Me.btnFileClaim.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFileClaim.UseVisualStyleBackColor = True
        '
        'btnSearchPatients
        '
        Me.btnSearchPatients.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchPatients.Image = Global.DaySheetTest.My.Resources.Resources.FindPatient
        Me.btnSearchPatients.Location = New System.Drawing.Point(268, 60)
        Me.btnSearchPatients.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSearchPatients.Name = "btnSearchPatients"
        Me.btnSearchPatients.Size = New System.Drawing.Size(200, 171)
        Me.btnSearchPatients.TabIndex = 1
        Me.btnSearchPatients.Text = "Find Patient"
        Me.btnSearchPatients.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSearchPatients.UseVisualStyleBackColor = True
        '
        'btnLedger
        '
        Me.btnLedger.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLedger.Image = Global.DaySheetTest.My.Resources.Resources.DaySheet
        Me.btnLedger.Location = New System.Drawing.Point(684, 60)
        Me.btnLedger.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLedger.Name = "btnLedger"
        Me.btnLedger.Size = New System.Drawing.Size(200, 171)
        Me.btnLedger.TabIndex = 3
        Me.btnLedger.Text = "Day Sheet"
        Me.btnLedger.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLedger.UseVisualStyleBackColor = True
        '
        'btnReports
        '
        Me.btnReports.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReports.Image = Global.DaySheetTest.My.Resources.Resources.FeeSchedule
        Me.btnReports.Location = New System.Drawing.Point(476, 60)
        Me.btnReports.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(200, 171)
        Me.btnReports.TabIndex = 2
        Me.btnReports.Text = "Fee Schedule"
        Me.btnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'btnNewPatient
        '
        Me.btnNewPatient.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewPatient.Image = Global.DaySheetTest.My.Resources.Resources.AddPatient
        Me.btnNewPatient.Location = New System.Drawing.Point(59, 60)
        Me.btnNewPatient.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnNewPatient.Name = "btnNewPatient"
        Me.btnNewPatient.Size = New System.Drawing.Size(201, 171)
        Me.btnNewPatient.TabIndex = 0
        Me.btnNewPatient.Text = "New Patient"
        Me.btnNewPatient.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNewPatient.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1155, 298)
        Me.Controls.Add(Me.btnFileClaim)
        Me.Controls.Add(Me.btnSearchPatients)
        Me.Controls.Add(Me.btnLedger)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnNewPatient)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnNewPatient As System.Windows.Forms.Button
    Friend WithEvents btnReports As System.Windows.Forms.Button
    Friend WithEvents btnLedger As System.Windows.Forms.Button
    Friend WithEvents btnSearchPatients As System.Windows.Forms.Button
    Friend WithEvents btnFileClaim As System.Windows.Forms.Button
End Class
