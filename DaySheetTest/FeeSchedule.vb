Public Class FeeSchedule

    Dim DB As New ClassDB

    Private Sub FeeSchedule_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Home.Show()
    End Sub

    Private Sub FeeSchedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Megan Cain edit
        'Load Fee Schedule
        DB.SelectQuery("SELECT tblFeeSchedule.[CPT Code], tblFeeSchedule.[Description], tblFeeSchedule.[Default], tblFeeSchedule.[BCBS], tblFeeSchedule.[UHC], tblFeeSchedule.[WC], tblFeeSchedule.[MC]  FROM tblFeeSchedule WHERE tblFeeSchedule.[Common] = True", "tblFeeSchedule")
        DataGridView1.DataSource = DB.CountDataset.Tables("tblFeeSchedule")
    End Sub

    Private Sub btnHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHome.Click
        Home.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    'Megan Cain addition
    Private Sub btnCPT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCPT.Click
        'clear form
        lblCPTwarning.Text = ""
        lblDescriptionwarning.Text = ""

        'Validate inputs
        If txtCPT.Text = "" Then
            lblCPTwarning.Text = "Please enter a five-digit number."
            'MessageBox.Show("Please enter a five-digit number.")
            Exit Sub
        End If

        If IsNumeric(txtCPT.Text) = False Then
            lblCPTwarning.Text = "Please enter a five-digit number."
            Exit Sub
        End If

        If txtCPT.Text > 99999 And txtCPT.Text < 0 Then
            lblCPTwarning.Text = "Please enter a five-digit number."
            Exit Sub
        End If

        Dim strCPT As String
        strCPT = txtCPT.Text

        If strCPT.Length <> 5 Then
            lblCPTwarning.Text = "Please enter a five-digit number."
            Exit Sub
        End If

        DB.SelectQuery("SELECT tblFeeSchedule.[CPT Code], tblFeeSchedule.[Description], tblFeeSchedule.[Default], tblFeeSchedule.[BCBS], tblFeeSchedule.[UHC], tblFeeSchedule.[WC], tblFeeSchedule.[MC]  FROM tblFeeSchedule WHERE tblFeeSchedule.[CPT Code] = '" & strCPT & "'", "tblFeeSchedule")
        DataGridView1.DataSource = DB.CountDataset.Tables("tblFeeSchedule")
    End Sub
    'Megan Cain addition
    Private Sub btnDescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDescription.Click
        'clear form
        lblCPTwarning.Text = ""
        lblDescriptionwarning.Text = ""

        'Validate inputs
        If txtDescription.Text = "" Then
            lblDescriptionwarning.Text = "Please enter a description."
            'MessageBox.Show("Please enter a description.")
            Exit Sub
        End If

        '
        Dim strDescription As String
        strDescription = "%" + txtDescription.Text + "%"
        DB.SelectQuery("SELECT tblFeeSchedule.[CPT Code], tblFeeSchedule.[Description], tblFeeSchedule.[Default], tblFeeSchedule.[BCBS], tblFeeSchedule.[UHC], tblFeeSchedule.[WC], tblFeeSchedule.[MC]  FROM tblFeeSchedule WHERE tblFeeSchedule.[Description] LIKE '" & strDescription & "'", "tblFeeSchedule")
        DataGridView1.DataSource = DB.CountDataset.Tables("tblFeeSchedule")

    End Sub

    Private Sub btnMostCommon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMostCommon.Click
        DB.SelectQuery("SELECT tblFeeSchedule.[CPT Code], tblFeeSchedule.[Description], tblFeeSchedule.[Default], tblFeeSchedule.[BCBS], tblFeeSchedule.[UHC], tblFeeSchedule.[WC], tblFeeSchedule.[MC]  FROM tblFeeSchedule WHERE tblFeeSchedule.[Common] = True", "tblFeeSchedule")
        DataGridView1.DataSource = DB.CountDataset.Tables("tblFeeSchedule")
    End Sub

    Private Sub btnShowAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAll.Click
        DB.SelectQuery("SELECT tblFeeSchedule.[CPT Code], tblFeeSchedule.[Description], tblFeeSchedule.[Default], tblFeeSchedule.[BCBS], tblFeeSchedule.[UHC], tblFeeSchedule.[WC], tblFeeSchedule.[MC]  FROM tblFeeSchedule", "tblFeeSchedule")
        DataGridView1.DataSource = DB.CountDataset.Tables("tblFeeSchedule")
    End Sub
End Class