Public Class ChangePassword
    Dim DB As New ClassDB
    Dim Valid As New ClassValidate
    Private Sub btnCancel_Click(sender As System.Object, e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub btnSubmit_Click(sender As System.Object, e As System.EventArgs) Handles btnSubmit.Click
        'check old password
        If DB.CheckOldPassword(txtOldPassword.Text) = False Then
            MessageBox.Show("Please enter a correct old password.")
            Exit Sub
        End If

        'check new password matches
        If txtNewPassword.Text <> txtRetypeNewPassword.Text Then
            MessageBox.Show("Please make sure both new passwords match.")
            Exit Sub
        End If

        'validate alphanumeric
        If Valid.CheckAlphaNumeric(txtNewPassword.Text) = False Then
            MessageBox.Show("Please only use letters and numbers in the password.")
            Exit Sub
        End If

        'Save
        Dim strPassword As String
        strPassword = txtNewPassword.Text
        DB.UpdatePassword(strPassword)
        MessageBox.Show("Password successfully changed!")
        Login.Enabled = True
        Login.Show()
        Login.BringToFront()
        Me.Hide()

    End Sub

    Private Sub ChangePassword_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Login.Enabled = True
        Login.Show()
        Login.BringToFront()
    End Sub

    Private Sub ChangePassword_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtOldPassword.Focus()
    End Sub
End Class