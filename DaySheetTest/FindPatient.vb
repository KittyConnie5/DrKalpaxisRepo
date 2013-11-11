Public Class FindPatient
    Public intPatientID As Integer
    Dim DB As New ClassDB
    Dim Val As New ClassValidate
    Dim strLastname As String
    Dim strFirstname As String
    Dim strQuery As String
    Public mintPatientID As Integer

    Private Sub FindPatient_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Home.Show()
    End Sub
    Private Sub All_Patients_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtLastName.Text = ""
        txtPatientID.Text = ""
        txtFirstName.Text = ""
        mintPatientID = 0
        txtFirstName.Focus()
    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        Home.Show()
        Me.Close()
    End Sub

    Private Sub FirstName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFirstName.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

              If Val.CheckLetterSubstring(txtFirstName.Text) = False Or Val.CheckLetterSubstring(txtLastName.Text) = False Then
                MessageBox.Show("Please use only letters in first and last name.")
                Exit Sub
            End If

            'firstname
            If txtLastName.Text = "" Then
                ' DB.SelectQuery("SELECT * FROM tblPatient WHERE Active = 'T' AND NursingID is Null AND Lastname like '" & txtLastName.Text & "' AND DateOfBirth like '" & dtDOB.Text & "'", "tblPatient")
                strFirstname = txtFirstName.Text + "%"
                DB.SelectQuery("SELECT * FROM tblPatient WHERE FirstName like '" & strFirstname & "'", "tblPatient")
                If DB.CountDataset.Tables("tblPatient").Rows.Count = 1 Then
                    intPatientID = CInt(DB.CountDataset.Tables("tblPatient").Rows(0).Item("PatientID"))

                    txtPatientID.Text = intPatientID.ToString
                    mintPatientID = intPatientID
                    PatientLedger.Show()
                    Me.Hide()
                ElseIf DB.CountDataset.Tables("tblPatient").Rows.Count > 1 Then
                    MultiplePatients.LoadInfo()
                    MultiplePatients.Show()
                    txtPatientID.Text = ""
                    Me.Hide()
                Else
                    MessageBox.Show("No record exists.")
                    Exit Sub
                End If

                'lastname
            ElseIf txtFirstName.Text = "" Then
                strLastname = txtLastName.Text + "%"
                DB.SelectQuery("SELECT * FROM tblPatient WHERE Lastname like '" & strLastname & "'", "tblPatient")
                If DB.CountDataset.Tables("tblPatient").Rows.Count = 1 Then
                    intPatientID = CInt(DB.CountDataset.Tables("tblPatient").Rows(0).Item("PatientID"))

                    txtPatientID.Text = intPatientID.ToString
                    mintPatientID = intPatientID
                    PatientLedger.Show()
                    Me.Hide()
                ElseIf DB.CountDataset.Tables("tblPatient").Rows.Count > 1 Then
                    MultiplePatients.LoadInfo()
                    MultiplePatients.Show()
                    txtPatientID.Text = ""
                    Me.Hide()
                Else
                    MessageBox.Show("No record exists.")
                    Exit Sub
                End If
            Else
                'first and lastname
                strLastname = txtLastName.Text + "%"
                strFirstname = txtFirstName.Text + "%"

                'strQuery = "SELECT * FROM tblPatient WHERE tblPatient.[LastName] LIKE '" & strLastname & "' AND tblPatient.[FirstName] LIKE '" & strFirstname & "'"
                DB.SelectQuery("SELECT * FROM tblPatient WHERE tblPatient.[LastName] LIKE '" & strLastname & "' AND tblPatient.[FirstName] LIKE '" & strFirstname & "'", "tblPatient")
                If DB.CountDataset.Tables("tblPatient").Rows.Count = 1 Then
                    intPatientID = CInt(DB.CountDataset.Tables("tblPatient").Rows(0).Item("PatientID"))

                    txtPatientID.Text = intPatientID.ToString
                    mintPatientID = intPatientID
                    PatientLedger.Show()
                    Me.Hide()
                ElseIf DB.CountDataset.Tables("tblPatient").Rows.Count > 1 Then
                    MultiplePatients.LoadInfo()
                    MultiplePatients.Show()
                    txtPatientID.Text = ""
                    Me.Hide()
                Else
                    MessageBox.Show(txtFirstName.Text & " " & txtLastName.Text & " does not exist.")
                    Exit Sub
                End If
            End If

            'This tells the system not to process the key, as you've already taken care of it
            e.Handled = True
        End If

    End Sub

    Private Sub LastName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLastName.KeyPress

        If e.KeyChar = Convert.ToChar(Keys.Enter) Then

        If Val.CheckLetterSubstring(txtFirstName.Text) = False Or Val.CheckLetterSubstring(txtLastName.Text) = False Then
                MessageBox.Show("Please use only letters in first and last name.")
                Exit Sub
            End If

            'firstname
            If txtLastName.Text = "" Then
                ' DB.SelectQuery("SELECT * FROM tblPatient WHERE Active = 'T' AND NursingID is Null AND Lastname like '" & txtLastName.Text & "' AND DateOfBirth like '" & dtDOB.Text & "'", "tblPatient")
                strFirstname = txtFirstName.Text + "%"
                DB.SelectQuery("SELECT * FROM tblPatient WHERE FirstName like '" & strFirstname & "'", "tblPatient")
                If DB.CountDataset.Tables("tblPatient").Rows.Count = 1 Then
                    intPatientID = CInt(DB.CountDataset.Tables("tblPatient").Rows(0).Item("PatientID"))

                    txtPatientID.Text = intPatientID.ToString
                    mintPatientID = intPatientID
                    PatientLedger.Show()
                    Me.Hide()
                ElseIf DB.CountDataset.Tables("tblPatient").Rows.Count > 1 Then
                    MultiplePatients.LoadInfo()
                    MultiplePatients.Show()
                    txtPatientID.Text = ""
                    Me.Hide()
                Else
                    MessageBox.Show("No record exists.")
                    Exit Sub
                End If

                'lastname
            ElseIf txtFirstName.Text = "" Then
                strLastname = txtLastName.Text + "%"
                DB.SelectQuery("SELECT * FROM tblPatient WHERE Lastname like '" & strLastname & "'", "tblPatient")
                If DB.CountDataset.Tables("tblPatient").Rows.Count = 1 Then
                    intPatientID = CInt(DB.CountDataset.Tables("tblPatient").Rows(0).Item("PatientID"))

                    txtPatientID.Text = intPatientID.ToString
                    mintPatientID = intPatientID
                    PatientLedger.Show()
                    Me.Hide()
                ElseIf DB.CountDataset.Tables("tblPatient").Rows.Count > 1 Then
                    MultiplePatients.LoadInfo()
                    MultiplePatients.Show()
                    txtPatientID.Text = ""
                    Me.Hide()
                Else
                    MessageBox.Show("No record exists.")
                    Exit Sub
                End If
            Else
                'first and lastname
                strLastname = txtLastName.Text + "%"
                strFirstname = txtFirstName.Text + "%"

                'strQuery = "SELECT * FROM tblPatient WHERE tblPatient.[LastName] LIKE '" & strLastname & "' AND tblPatient.[FirstName] LIKE '" & strFirstname & "'"
                DB.SelectQuery("SELECT * FROM tblPatient WHERE tblPatient.[LastName] LIKE '" & strLastname & "' AND tblPatient.[FirstName] LIKE '" & strFirstname & "'", "tblPatient")
                If DB.CountDataset.Tables("tblPatient").Rows.Count = 1 Then
                    intPatientID = CInt(DB.CountDataset.Tables("tblPatient").Rows(0).Item("PatientID"))

                    txtPatientID.Text = intPatientID.ToString
                    mintPatientID = intPatientID
                    PatientLedger.Show()
                    Me.Hide()
                ElseIf DB.CountDataset.Tables("tblPatient").Rows.Count > 1 Then
                    MultiplePatients.LoadInfo()
                    MultiplePatients.Show()
                    txtPatientID.Text = ""
                    Me.Hide()
                Else
                    MessageBox.Show(txtFirstName.Text & " " & txtLastName.Text & " does not exist.")
                    Exit Sub
                End If
            End If
            e.Handled = True
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        'Validate inputs
        'If txtFirstName.Text = "" Then
        '    MessageBox.Show("First name is required")
        '    Exit Sub
        'End If
        'If txtLastName.Text = "" Then
        '    MessageBox.Show("Last name is required")
        '    Exit Sub
        'End If
        If Val.CheckLetterSubstring(txtFirstName.Text) = False Or Val.CheckLetterSubstring(txtLastName.Text) = False Then
            MessageBox.Show("Please use only letters in first and last name.")
            Exit Sub
        End If

        'firstname
        If txtLastName.Text = "" Then
            ' DB.SelectQuery("SELECT * FROM tblPatient WHERE Active = 'T' AND NursingID is Null AND Lastname like '" & txtLastName.Text & "' AND DateOfBirth like '" & dtDOB.Text & "'", "tblPatient")
            strFirstname = txtFirstName.Text + "%"
            DB.SelectQuery("SELECT * FROM tblPatient WHERE FirstName like '" & strFirstname & "'", "tblPatient")
            If DB.CountDataset.Tables("tblPatient").Rows.Count = 1 Then
                intPatientID = CInt(DB.CountDataset.Tables("tblPatient").Rows(0).Item("PatientID"))
                txtPatientID.Text = intPatientID.ToString
                mintPatientID = intPatientID
                PatientLedger.Show()
                Me.Hide()
            ElseIf DB.CountDataset.Tables("tblPatient").Rows.Count > 1 Then
                MultiplePatients.LoadInfo()
                MultiplePatients.Show()
                txtPatientID.Text = ""
                Me.Hide()
            Else
                MessageBox.Show("No record exists.")
                Exit Sub
            End If

            'lastname
        ElseIf txtFirstName.Text = "" Then
            strLastname = txtLastName.Text + "%"
            DB.SelectQuery("SELECT * FROM tblPatient WHERE Lastname like '" & strLastname & "'", "tblPatient")
            If DB.CountDataset.Tables("tblPatient").Rows.Count = 1 Then
                intPatientID = CInt(DB.CountDataset.Tables("tblPatient").Rows(0).Item("PatientID"))

                txtPatientID.Text = intPatientID.ToString
                mintPatientID = intPatientID
                PatientLedger.Show()
                Me.Hide()
            ElseIf DB.CountDataset.Tables("tblPatient").Rows.Count > 1 Then
                MultiplePatients.LoadInfo()
                MultiplePatients.Show()
                txtPatientID.Text = ""
                Me.Hide()
            Else
                MessageBox.Show("No record exists.")
                Exit Sub
            End If
        Else
            'first and lastname
            strLastname = txtLastName.Text + "%"
            strFirstname = txtFirstName.Text + "%"

            'strQuery = "SELECT * FROM tblPatient WHERE tblPatient.[LastName] LIKE '" & strLastname & "' AND tblPatient.[FirstName] LIKE '" & strFirstname & "'"
            DB.SelectQuery("SELECT * FROM tblPatient WHERE tblPatient.[LastName] LIKE '" & strLastname & "' AND tblPatient.[FirstName] LIKE '" & strFirstname & "'", "tblPatient")
            If DB.CountDataset.Tables("tblPatient").Rows.Count = 1 Then
                intPatientID = CInt(DB.CountDataset.Tables("tblPatient").Rows(0).Item("PatientID"))

                txtPatientID.Text = intPatientID.ToString
                mintPatientID = intPatientID
                PatientLedger.Show()
                Me.Hide()
            ElseIf DB.CountDataset.Tables("tblPatient").Rows.Count > 1 Then
                MultiplePatients.LoadInfo()
                MultiplePatients.Show()
                txtPatientID.Text = ""
                Me.Hide()
            Else
                MessageBox.Show(txtFirstName.Text & " " & txtLastName.Text & " does not exist.")
                Exit Sub
            End If
        End If

        'DB.SelectQuery("SELECT * FROM tblPatient WHERE Lastname like '" & txtLastName.Text & "' AND DateOfBirth like '" & dtDOB.Text & "'", "tblPatient")
        'If DB.CountDataset.Tables("tblPatient").Rows.Count = 1 Then
        '    txtPatientID.Text = DB.CountDataset.Tables("tblPatient").Rows(0).Item("PatientID").ToString
        '    PatientLedger.Show()
        '    Me.Hide()
        'ElseIf DB.CountDataset.Tables("tblPatient").Rows.Count > 1 Then
        '    MultiplePatients.Show()
        '    Me.Hide()
        'Else
        '    MessageBox.Show("Patient with LAST NAME " & txtLastName.Text & " and DATE OF BIRTH " & dtDOB.Text & " does not exist.")
        '    Exit Sub
        'End If

    End Sub
End Class