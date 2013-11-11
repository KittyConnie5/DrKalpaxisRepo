<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddTransactionSelection
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnInsurancePayment = New System.Windows.Forms.Button()
        Me.btnWriteOff = New System.Windows.Forms.Button()
        Me.btnPatientPayment = New System.Windows.Forms.Button()
        Me.btnVisitTransaction = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(179, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(348, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Add Transaction Selection"
        '
        'btnInsurancePayment
        '
        Me.btnInsurancePayment.Image = Global.DaySheetTest.My.Resources.Resources.Insurance_Icon2
        Me.btnInsurancePayment.Location = New System.Drawing.Point(372, 57)
        Me.btnInsurancePayment.Margin = New System.Windows.Forms.Padding(4)
        Me.btnInsurancePayment.Name = "btnInsurancePayment"
        Me.btnInsurancePayment.Size = New System.Drawing.Size(145, 132)
        Me.btnInsurancePayment.TabIndex = 3
        Me.btnInsurancePayment.Text = "Insurance Payment"
        Me.btnInsurancePayment.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnInsurancePayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnInsurancePayment.UseVisualStyleBackColor = True
        '
        'btnWriteOff
        '
        Me.btnWriteOff.Image = Global.DaySheetTest.My.Resources.Resources.Write_Off_Icon
        Me.btnWriteOff.Location = New System.Drawing.Point(538, 57)
        Me.btnWriteOff.Margin = New System.Windows.Forms.Padding(4)
        Me.btnWriteOff.Name = "btnWriteOff"
        Me.btnWriteOff.Size = New System.Drawing.Size(145, 132)
        Me.btnWriteOff.TabIndex = 2
        Me.btnWriteOff.Text = "Write Off"
        Me.btnWriteOff.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnWriteOff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnWriteOff.UseVisualStyleBackColor = True
        '
        'btnPatientPayment
        '
        Me.btnPatientPayment.Image = Global.DaySheetTest.My.Resources.Resources.Patient_Icon
        Me.btnPatientPayment.Location = New System.Drawing.Point(201, 57)
        Me.btnPatientPayment.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPatientPayment.Name = "btnPatientPayment"
        Me.btnPatientPayment.Size = New System.Drawing.Size(145, 132)
        Me.btnPatientPayment.TabIndex = 1
        Me.btnPatientPayment.Text = "Patient Payment"
        Me.btnPatientPayment.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPatientPayment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnPatientPayment.UseVisualStyleBackColor = True
        '
        'btnVisitTransaction
        '
        Me.btnVisitTransaction.Image = Global.DaySheetTest.My.Resources.Resources.Visit_Icon
        Me.btnVisitTransaction.Location = New System.Drawing.Point(32, 57)
        Me.btnVisitTransaction.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVisitTransaction.Name = "btnVisitTransaction"
        Me.btnVisitTransaction.Size = New System.Drawing.Size(145, 132)
        Me.btnVisitTransaction.TabIndex = 0
        Me.btnVisitTransaction.Text = " Visit"
        Me.btnVisitTransaction.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVisitTransaction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnVisitTransaction.UseVisualStyleBackColor = True
        '
        'AddTransactionSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 210)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnInsurancePayment)
        Me.Controls.Add(Me.btnWriteOff)
        Me.Controls.Add(Me.btnPatientPayment)
        Me.Controls.Add(Me.btnVisitTransaction)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "AddTransactionSelection"
        Me.Text = "AddTransactionSelection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVisitTransaction As System.Windows.Forms.Button
    Friend WithEvents btnPatientPayment As System.Windows.Forms.Button
    Friend WithEvents btnWriteOff As System.Windows.Forms.Button
    Friend WithEvents btnInsurancePayment As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
