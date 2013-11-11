Public Class Login
    Dim DB As New ClassDB
    Private Sub lnkPasswordChange_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkPasswordChange.LinkClicked
        ChangePassword.Show()
        Me.Enabled = False
    End Sub

    Private Sub Login_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.Enabled = True
        txtUsername.Focus()
    End Sub

    Private Sub btnLogin_Click(sender As System.Object, e As System.EventArgs) Handles btnLogin.Click
        If DB.CheckLogin(txtusername.text, txtpassword.text) = False Then
            MessageBox.Show("Please enter a correct password and username.")
            Exit Sub
        Else
            Home.Show()
            Me.Hide()
        End If
    End Sub
End Class