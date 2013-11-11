Public Class MultiplePatients
    Dim strLastname As String
    Dim strFirstname As String
    Dim DB As New ClassDB
    Public intPatientID As Integer
    Dim datDOB1 As Date
    Dim datDOB2 As Date
    Dim datDOB3 As Date
    Dim datDOB4 As Date
    Dim datDOB5 As Date
    Public Sub ClearForm()
        'clear everything
        txtPatID1.Text = ""
        txtPatFN1.Text = ""
        txtLN1.Text = ""
        txtGender1.Text = ""
        txtPhone1.Text = ""
        txtDOB1.Text = ""

        txtPatID2.Text = ""
        txtPatFN2.Text = ""
        txtLN2.Text = ""
        txtGender2.Text = ""
        txtPhone2.Text = ""
        txtDOB2.Text = ""

        txtPatID3.Text = ""
        txtPatFN3.Text = ""
        txtLN3.Text = ""
        txtGender3.Text = ""
        txtPhone3.Text = ""
        txtDOB3.Text = ""

        txtPatID4.Text = ""
        txtPatFN4.Text = ""
        txtLN4.Text = ""
        txtGender4.Text = ""
        txtPhone4.Text = ""
        txtDOB4.Text = ""

        txtPatID5.Text = ""
        txtPatFN5.Text = ""
        txtLN5.Text = ""
        txtGender5.Text = ""
        txtPhone5.Text = ""
        txtDOB5.Text = ""

        txtPatientID.Text = ""

    End Sub

    Public Sub SetFormToNormal()
        txtPatFN3.Visible = False
        txtPatFN4.Visible = False
        txtPatFN5.Visible = False

        txtPatID3.Visible = False
        txtPatID4.Visible = False
        txtPatID5.Visible = False

        txtLN3.Visible = False
        txtLN4.Visible = False
        txtLN5.Visible = False

        txtGender3.Visible = False
        txtGender4.Visible = False
        txtGender5.Visible = False

        txtPhone3.Visible = False
        txtPhone4.Visible = False
        txtPhone5.Visible = False

        txtDOB3.Visible = False
        txtDOB4.Visible = False
        txtDOB5.Visible = False

        btn3.Visible = False
        btn4.Visible = False
        btn5.Visible = False
    End Sub

    Public Sub LoadInfo()
        ClearForm()
        SetFormToNormal()
        'Load patient info
        strLastname = FindPatient.txtLastName.Text + "%"
        strFirstname = FindPatient.txtFirstName.Text + "%"
        If FindPatient.txtLastName.Text = "" Then
            DB.SelectQuery("SELECT * FROM tblPatient WHERE FirstName like '" & strFirstname & "'", "tblPatient")
        ElseIf FindPatient.txtFirstName.Text = "" Then
            DB.SelectQuery("SELECT * FROM tblPatient WHERE Lastname like '" & strLastname & "'", "tblPatient")
        Else
            DB.SelectQuery("SELECT * FROM tblPatient WHERE tblPatient.[LastName] LIKE '" & strLastname & "' AND tblPatient.[FirstName] LIKE '" & strFirstname & "'", "tblPatient")
        End If


        ' DB.SelectQuery("SELECT * FROM tblPatient WHERE LastName LIKE '" & FindPatient.txtLastName.Text & "' AND FirstName LIKE '" & FindPatient.txtFirstName.Text & "'", "tblPatient")

        If DB.CountDataset.Tables("tblPatient").Rows.Count >= 2 Then
            txtPatID1.Text = DB.CountDataset.Tables("tblPatient").Rows(0).Item("PatientID").ToString
            txtPatFN1.Text = DB.CountDataset.Tables("tblPatient").Rows(0).Item("FirstName").ToString
            txtLN1.Text = DB.CountDataset.Tables("tblPatient").Rows(0).Item("LastName").ToString
            txtGender1.Text = DB.CountDataset.Tables("tblPatient").Rows(0).Item("Gender").ToString
            txtPhone1.Text = DB.CountDataset.Tables("tblPatient").Rows(0).Item("Phone").ToString
            datDOB1 = DB.CountDataset.Tables("tblPatient").Rows(0).Item("DateOfBirth").ToString
            txtDOB1.Text = datDOB1.ToString

            txtPatID2.Text = DB.CountDataset.Tables("tblPatient").Rows(1).Item("PatientID").ToString
            txtPatFN2.Text = DB.CountDataset.Tables("tblPatient").Rows(1).Item("FirstName").ToString
            txtLN2.Text = DB.CountDataset.Tables("tblPatient").Rows(1).Item("LastName").ToString
            txtGender2.Text = DB.CountDataset.Tables("tblPatient").Rows(1).Item("Gender").ToString
            txtPhone2.Text = DB.CountDataset.Tables("tblPatient").Rows(1).Item("Phone").ToString
            datDOB2 = DB.CountDataset.Tables("tblPatient").Rows(1).Item("DateOfBirth").ToString
            txtDOB2.Text = datDOB2.ToString
        End If

        If DB.CountDataset.Tables("tblPatient").Rows.Count >= 3 Then
            txtPatID3.Visible = True
            txtPatFN3.Visible = True
            txtLN3.Visible = True
            txtGender3.Visible = True
            txtPhone3.Visible = True
            txtDOB3.Visible = True
            btn3.Visible = True

            txtPatID3.Text = DB.CountDataset.Tables("tblPatient").Rows(2).Item("PatientID").ToString
            txtPatFN3.Text = DB.CountDataset.Tables("tblPatient").Rows(2).Item("FirstName").ToString
            txtLN3.Text = DB.CountDataset.Tables("tblPatient").Rows(2).Item("LastName").ToString
            txtGender3.Text = DB.CountDataset.Tables("tblPatient").Rows(2).Item("Gender").ToString
            txtPhone3.Text = DB.CountDataset.Tables("tblPatient").Rows(2).Item("Phone").ToString
            datDOB3 = DB.CountDataset.Tables("tblPatient").Rows(2).Item("DateOfBirth").ToString
            txtDOB3.Text = datDOB3.ToString
        End If

        If DB.CountDataset.Tables("tblPatient").Rows.Count >= 4 Then
            txtPatID4.Visible = True
            txtPatFN4.Visible = True
            txtLN4.Visible = True
            txtGender4.Visible = True
            txtPhone4.Visible = True
            txtDOB4.Visible = True
            btn4.Visible = True

            txtPatID4.Text = DB.CountDataset.Tables("tblPatient").Rows(3).Item("PatientID").ToString
            txtPatFN4.Text = DB.CountDataset.Tables("tblPatient").Rows(3).Item("FirstName").ToString
            txtLN4.Text = DB.CountDataset.Tables("tblPatient").Rows(3).Item("LastName").ToString
            txtGender4.Text = DB.CountDataset.Tables("tblPatient").Rows(3).Item("Gender").ToString
            txtPhone4.Text = DB.CountDataset.Tables("tblPatient").Rows(3).Item("Phone").ToString
            datDOB4 = DB.CountDataset.Tables("tblPatient").Rows(3).Item("DateOfBirth").ToString
            txtDOB4.Text = datDOB4.ToString
        End If

        If DB.CountDataset.Tables("tblPatient").Rows.Count >= 5 Then
            txtPatID5.Visible = True
            txtPatFN5.Visible = True
            txtLN5.Visible = True
            txtGender5.Visible = True
            txtPhone5.Visible = True
            txtDOB5.Visible = True
            btn5.Visible = True

            txtPatID5.Text = DB.CountDataset.Tables("tblPatient").Rows(4).Item("PatientID").ToString
            txtPatFN5.Text = DB.CountDataset.Tables("tblPatient").Rows(4).Item("FirstName").ToString
            txtLN5.Text = DB.CountDataset.Tables("tblPatient").Rows(4).Item("LastName").ToString
            txtGender5.Text = DB.CountDataset.Tables("tblPatient").Rows(4).Item("Gender").ToString
            txtPhone5.Text = DB.CountDataset.Tables("tblPatient").Rows(4).Item("Phone").ToString
            datDOB5 = DB.CountDataset.Tables("tblPatient").Rows(4).Item("DateOfBirth").ToString
            txtDOB5.Text = datDOB5.ToString
        End If
    End Sub

    Private Sub MultiplePatients_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Home.Show()
    End Sub

    Private Sub MultiplePatients_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadInfo()
    End Sub

    Private Sub b_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b.Click
        txtPatientID.Text = txtPatID1.Text
        intPatientID = CInt(txtPatID1.Text)
        PatientLedger.LoadPatientInfo()
        PatientLedger.Show()
        'FindPatient.intPatientID = txtPatientID.Text
        Me.Hide()
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        txtPatientID.Text = txtPatID2.Text
        intPatientID = CInt(txtPatID2.Text)
        PatientLedger.LoadPatientInfo()
        PatientLedger.Show()
        'FindPatient.intPatientID = txtPatientID.Text
        Me.Hide()
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        txtPatientID.Text = txtPatID3.Text
        intPatientID = CInt(txtPatID3.Text)
        PatientLedger.LoadPatientInfo()
        PatientLedger.Show()
        'FindPatient.intPatientID = txtPatientID.Text
        Me.Hide()
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        txtPatientID.Text = txtPatID4.Text
        intPatientID = txtPatientID.Text
        PatientLedger.LoadPatientInfo()
        PatientLedger.Show()
        'FindPatient.intPatientID = txtPatientID.Text
        Me.Hide()
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        txtPatientID.Text = txtPatID5.Text
        intPatientID = txtPatientID.Text
        PatientLedger.LoadPatientInfo()
        PatientLedger.Show()
        'FindPatient.intPatientID = txtPatientID.Text
        Me.Hide()
    End Sub
End Class