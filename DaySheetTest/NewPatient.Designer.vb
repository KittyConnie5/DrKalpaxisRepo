<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewPatient
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NewPatient))
        Me.txtPatFN = New System.Windows.Forms.TextBox()
        Me.txtPatPhone = New System.Windows.Forms.TextBox()
        Me.txtPatSSN = New System.Windows.Forms.TextBox()
        Me.txtPatDriversLis = New System.Windows.Forms.TextBox()
        Me.txtPatAddress = New System.Windows.Forms.TextBox()
        Me.txtPatCity = New System.Windows.Forms.TextBox()
        Me.txtPatZip = New System.Windows.Forms.TextBox()
        Me.txtPatLN = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.gbPatient = New System.Windows.Forms.GroupBox()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.ddlMonth = New System.Windows.Forms.ComboBox()
        Me.ddlDay = New System.Windows.Forms.ComboBox()
        Me.ddlYear = New System.Windows.Forms.ComboBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.ddlGender = New System.Windows.Forms.ComboBox()
        Me.ddlPatState = New System.Windows.Forms.ComboBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.rtbComments = New System.Windows.Forms.RichTextBox()
        Me.Comments = New System.Windows.Forms.Label()
        Me.lnkNursing = New System.Windows.Forms.LinkLabel()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lnkInsurance = New System.Windows.Forms.LinkLabel()
        Me.lnkContact = New System.Windows.Forms.LinkLabel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.gbPatient.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPatFN
        '
        Me.txtPatFN.Location = New System.Drawing.Point(168, 35)
        Me.txtPatFN.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPatFN.MaxLength = 35
        Me.txtPatFN.Name = "txtPatFN"
        Me.txtPatFN.Size = New System.Drawing.Size(288, 22)
        Me.txtPatFN.TabIndex = 0
        '
        'txtPatPhone
        '
        Me.txtPatPhone.Location = New System.Drawing.Point(168, 160)
        Me.txtPatPhone.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPatPhone.MaxLength = 10
        Me.txtPatPhone.Name = "txtPatPhone"
        Me.txtPatPhone.Size = New System.Drawing.Size(288, 22)
        Me.txtPatPhone.TabIndex = 7
        '
        'txtPatSSN
        '
        Me.txtPatSSN.Location = New System.Drawing.Point(168, 210)
        Me.txtPatSSN.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPatSSN.MaxLength = 9
        Me.txtPatSSN.Name = "txtPatSSN"
        Me.txtPatSSN.Size = New System.Drawing.Size(288, 22)
        Me.txtPatSSN.TabIndex = 11
        '
        'txtPatDriversLis
        '
        Me.txtPatDriversLis.Location = New System.Drawing.Point(168, 235)
        Me.txtPatDriversLis.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPatDriversLis.MaxLength = 8
        Me.txtPatDriversLis.Name = "txtPatDriversLis"
        Me.txtPatDriversLis.Size = New System.Drawing.Size(288, 22)
        Me.txtPatDriversLis.TabIndex = 12
        '
        'txtPatAddress
        '
        Me.txtPatAddress.Location = New System.Drawing.Point(168, 109)
        Me.txtPatAddress.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPatAddress.MaxLength = 100
        Me.txtPatAddress.Name = "txtPatAddress"
        Me.txtPatAddress.Size = New System.Drawing.Size(288, 22)
        Me.txtPatAddress.TabIndex = 3
        '
        'txtPatCity
        '
        Me.txtPatCity.Location = New System.Drawing.Point(168, 134)
        Me.txtPatCity.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPatCity.MaxLength = 45
        Me.txtPatCity.Name = "txtPatCity"
        Me.txtPatCity.Size = New System.Drawing.Size(79, 22)
        Me.txtPatCity.TabIndex = 4
        '
        'txtPatZip
        '
        Me.txtPatZip.Location = New System.Drawing.Point(381, 134)
        Me.txtPatZip.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPatZip.MaxLength = 5
        Me.txtPatZip.Name = "txtPatZip"
        Me.txtPatZip.Size = New System.Drawing.Size(75, 22)
        Me.txtPatZip.TabIndex = 6
        '
        'txtPatLN
        '
        Me.txtPatLN.Location = New System.Drawing.Point(168, 60)
        Me.txtPatLN.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPatLN.MaxLength = 35
        Me.txtPatLN.Name = "txtPatLN"
        Me.txtPatLN.Size = New System.Drawing.Size(288, 22)
        Me.txtPatLN.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "First Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(91, 112)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(354, 139)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(28, 17)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Zip"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 239)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Drivers License No"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(247, 140)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 17)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "State"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(76, 63)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(76, 17)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Last Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(79, 164)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 17)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "Telephone"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(66, 188)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(87, 17)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Date of Birth"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(120, 137)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(31, 17)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "City"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(240, 888)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 22)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "Label18"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(37, 214)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(123, 17)
        Me.Label19.TabIndex = 36
        Me.Label19.Text = "Social Security No"
        '
        'gbPatient
        '
        Me.gbPatient.Controls.Add(Me.Label71)
        Me.gbPatient.Controls.Add(Me.Label70)
        Me.gbPatient.Controls.Add(Me.Label69)
        Me.gbPatient.Controls.Add(Me.Label68)
        Me.gbPatient.Controls.Add(Me.Label67)
        Me.gbPatient.Controls.Add(Me.Label66)
        Me.gbPatient.Controls.Add(Me.Label65)
        Me.gbPatient.Controls.Add(Me.ddlMonth)
        Me.gbPatient.Controls.Add(Me.ddlDay)
        Me.gbPatient.Controls.Add(Me.ddlYear)
        Me.gbPatient.Controls.Add(Me.Label44)
        Me.gbPatient.Controls.Add(Me.ddlGender)
        Me.gbPatient.Controls.Add(Me.ddlPatState)
        Me.gbPatient.Controls.Add(Me.Label2)
        Me.gbPatient.Controls.Add(Me.Label6)
        Me.gbPatient.Controls.Add(Me.Label14)
        Me.gbPatient.Controls.Add(Me.txtPatFN)
        Me.gbPatient.Controls.Add(Me.txtPatPhone)
        Me.gbPatient.Controls.Add(Me.txtPatSSN)
        Me.gbPatient.Controls.Add(Me.txtPatDriversLis)
        Me.gbPatient.Controls.Add(Me.txtPatAddress)
        Me.gbPatient.Controls.Add(Me.txtPatCity)
        Me.gbPatient.Controls.Add(Me.txtPatZip)
        Me.gbPatient.Controls.Add(Me.txtPatLN)
        Me.gbPatient.Controls.Add(Me.Label1)
        Me.gbPatient.Controls.Add(Me.Label10)
        Me.gbPatient.Controls.Add(Me.Label3)
        Me.gbPatient.Controls.Add(Me.Label11)
        Me.gbPatient.Controls.Add(Me.Label19)
        Me.gbPatient.Controls.Add(Me.Label12)
        Me.gbPatient.Controls.Add(Me.Label5)
        Me.gbPatient.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbPatient.Location = New System.Drawing.Point(13, 96)
        Me.gbPatient.Name = "gbPatient"
        Me.gbPatient.Size = New System.Drawing.Size(479, 274)
        Me.gbPatient.TabIndex = 47
        Me.gbPatient.TabStop = False
        Me.gbPatient.Text = "Patient Information"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.ForeColor = System.Drawing.Color.Red
        Me.Label71.Location = New System.Drawing.Point(459, 189)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(13, 17)
        Me.Label71.TabIndex = 70
        Me.Label71.Text = "*"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.ForeColor = System.Drawing.Color.Red
        Me.Label70.Location = New System.Drawing.Point(459, 168)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(13, 17)
        Me.Label70.TabIndex = 69
        Me.Label70.Text = "*"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.ForeColor = System.Drawing.Color.Red
        Me.Label69.Location = New System.Drawing.Point(459, 142)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(13, 17)
        Me.Label69.TabIndex = 68
        Me.Label69.Text = "*"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.ForeColor = System.Drawing.Color.Red
        Me.Label68.Location = New System.Drawing.Point(459, 115)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(13, 17)
        Me.Label68.TabIndex = 67
        Me.Label68.Text = "*"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.ForeColor = System.Drawing.Color.Red
        Me.Label67.Location = New System.Drawing.Point(459, 91)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(13, 17)
        Me.Label67.TabIndex = 66
        Me.Label67.Text = "*"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.ForeColor = System.Drawing.Color.Red
        Me.Label66.Location = New System.Drawing.Point(459, 68)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(13, 17)
        Me.Label66.TabIndex = 65
        Me.Label66.Text = "*"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.ForeColor = System.Drawing.Color.Red
        Me.Label65.Location = New System.Drawing.Point(459, 39)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(13, 17)
        Me.Label65.TabIndex = 64
        Me.Label65.Text = "*"
        '
        'ddlMonth
        '
        Me.ddlMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlMonth.ForeColor = System.Drawing.Color.Black
        Me.ddlMonth.FormattingEnabled = True
        Me.ddlMonth.Items.AddRange(New Object() {"--", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12"})
        Me.ddlMonth.Location = New System.Drawing.Point(171, 185)
        Me.ddlMonth.Name = "ddlMonth"
        Me.ddlMonth.Size = New System.Drawing.Size(88, 24)
        Me.ddlMonth.TabIndex = 8
        '
        'ddlDay
        '
        Me.ddlDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlDay.ForeColor = System.Drawing.Color.Black
        Me.ddlDay.FormattingEnabled = True
        Me.ddlDay.Items.AddRange(New Object() {"--", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.ddlDay.Location = New System.Drawing.Point(268, 185)
        Me.ddlDay.Name = "ddlDay"
        Me.ddlDay.Size = New System.Drawing.Size(88, 24)
        Me.ddlDay.TabIndex = 9
        '
        'ddlYear
        '
        Me.ddlYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlYear.ForeColor = System.Drawing.Color.Black
        Me.ddlYear.FormattingEnabled = True
        Me.ddlYear.Items.AddRange(New Object() {"--", "2012", "2011", "2010", "2009", "2008", "2007", "2006", "2005", "2004", "2003", "2002", "2001", "2000", "1999", "1998", "1997", "1996", "1995", "1994", "1993", "1992", "1991", "1990", "1989", "1988", "1987", "1986", "1985", "1984", "1983", "1982", "1981", "1980", "1979", "1978", "1977", "1976", "1975", "1974", "1973", "1972", "1971", "1970", "1969", "1968", "1967", "1966", "1965", "1964", "1963", "1962", "1961", "1960", "1959", "1958", "1957", "1956", "1955", "1954", "1953", "1952", "1951", "1950", "1949", "1948", "1947", "1946", "1945", "1944", "1943", "1942", "1941", "1940", "1939", "1938", "1937", "1936", "1935", "1934", "1933", "1932", "1931", "1930", "1929", "1928", "1927", "1926", "1925", "1924", "1923", "1922", "1921", "1920", "1919", "1918", "1917", "1916", "1915", "1914", "1913", "1912", "1911", "1910", "1909", "1908", "1907", "1906", "1905", "1904", "1903", "1902", "1901", "1900"})
        Me.ddlYear.Location = New System.Drawing.Point(365, 185)
        Me.ddlYear.Name = "ddlYear"
        Me.ddlYear.Size = New System.Drawing.Size(88, 24)
        Me.ddlYear.TabIndex = 10
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(94, 87)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(56, 17)
        Me.Label44.TabIndex = 39
        Me.Label44.Text = "Gender"
        '
        'ddlGender
        '
        Me.ddlGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlGender.FormattingEnabled = True
        Me.ddlGender.Items.AddRange(New Object() {"--", "M", "F"})
        Me.ddlGender.Location = New System.Drawing.Point(168, 84)
        Me.ddlGender.Name = "ddlGender"
        Me.ddlGender.Size = New System.Drawing.Size(288, 24)
        Me.ddlGender.TabIndex = 2
        '
        'ddlPatState
        '
        Me.ddlPatState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlPatState.ForeColor = System.Drawing.Color.Black
        Me.ddlPatState.FormattingEnabled = True
        Me.ddlPatState.Items.AddRange(New Object() {"--", "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI"})
        Me.ddlPatState.Location = New System.Drawing.Point(295, 134)
        Me.ddlPatState.Name = "ddlPatState"
        Me.ddlPatState.Size = New System.Drawing.Size(52, 24)
        Me.ddlPatState.TabIndex = 5
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(195, 28)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(236, 33)
        Me.Label25.TabIndex = 51
        Me.Label25.Text = "Add New Patient"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(543, 116)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(40, 17)
        Me.Label26.TabIndex = 56
        Me.Label26.Text = "Save"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(542, 498)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(43, 17)
        Me.Label28.TabIndex = 58
        Me.Label28.Text = "Close"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(541, 367)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(41, 17)
        Me.Label29.TabIndex = 59
        Me.Label29.Text = "Clear"
        '
        'rtbComments
        '
        Me.rtbComments.Location = New System.Drawing.Point(13, 480)
        Me.rtbComments.MaxLength = 255
        Me.rtbComments.Name = "rtbComments"
        Me.rtbComments.Size = New System.Drawing.Size(479, 81)
        Me.rtbComments.TabIndex = 54
        Me.rtbComments.Text = ""
        '
        'Comments
        '
        Me.Comments.AutoSize = True
        Me.Comments.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Comments.Location = New System.Drawing.Point(13, 455)
        Me.Comments.Name = "Comments"
        Me.Comments.Size = New System.Drawing.Size(74, 17)
        Me.Comments.TabIndex = 62
        Me.Comments.Text = "Comments"
        '
        'lnkNursing
        '
        Me.lnkNursing.AutoSize = True
        Me.lnkNursing.Location = New System.Drawing.Point(342, 29)
        Me.lnkNursing.Name = "lnkNursing"
        Me.lnkNursing.Size = New System.Drawing.Size(98, 17)
        Me.lnkNursing.TabIndex = 63
        Me.lnkNursing.TabStop = True
        Me.lnkNursing.Text = "Nursing Home"
        '
        'btnClear
        '
        Me.btnClear.BackgroundImage = Global.DaySheetTest.My.Resources.Resources.Clear
        Me.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClear.Location = New System.Drawing.Point(535, 306)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(58, 58)
        Me.btnClear.TabIndex = 57
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackgroundImage = Global.DaySheetTest.My.Resources.Resources.Cancel
        Me.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCancel.Font = New System.Drawing.Font("Comic Sans MS", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.ForeColor = System.Drawing.Color.Red
        Me.btnCancel.Location = New System.Drawing.Point(535, 437)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(58, 58)
        Me.btnCancel.TabIndex = 58
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.btnSave.BackgroundImage = CType(resources.GetObject("btnSave.BackgroundImage"), System.Drawing.Image)
        Me.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSave.Location = New System.Drawing.Point(535, 55)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(58, 58)
        Me.btnSave.TabIndex = 56
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lnkInsurance)
        Me.GroupBox1.Controls.Add(Me.lnkContact)
        Me.GroupBox1.Controls.Add(Me.lnkNursing)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 376)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(478, 64)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Additional Information"
        '
        'lnkInsurance
        '
        Me.lnkInsurance.AutoSize = True
        Me.lnkInsurance.Location = New System.Drawing.Point(216, 29)
        Me.lnkInsurance.Name = "lnkInsurance"
        Me.lnkInsurance.Size = New System.Drawing.Size(70, 17)
        Me.lnkInsurance.TabIndex = 65
        Me.lnkInsurance.TabStop = True
        Me.lnkInsurance.Text = "Insurance"
        '
        'lnkContact
        '
        Me.lnkContact.AutoSize = True
        Me.lnkContact.Location = New System.Drawing.Point(16, 29)
        Me.lnkContact.Name = "lnkContact"
        Me.lnkContact.Size = New System.Drawing.Size(147, 17)
        Me.lnkContact.TabIndex = 64
        Me.lnkContact.TabStop = True
        Me.lnkContact.Text = "Employer and Spouse"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(542, 241)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 17)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Edit"
        '
        'btnEdit
        '
        Me.btnEdit.BackgroundImage = Global.DaySheetTest.My.Resources.Resources.Edi
        Me.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnEdit.Location = New System.Drawing.Point(535, 180)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(58, 58)
        Me.btnEdit.TabIndex = 70
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'NewPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 571)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Comments)
        Me.Controls.Add(Me.rtbComments)
        Me.Controls.Add(Me.Label29)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.gbPatient)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "NewPatient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add New Patient"
        Me.gbPatient.ResumeLayout(False)
        Me.gbPatient.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPatFN As System.Windows.Forms.TextBox
    Friend WithEvents txtPatPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtPatSSN As System.Windows.Forms.TextBox
    Friend WithEvents txtPatDriversLis As System.Windows.Forms.TextBox
    Friend WithEvents txtPatAddress As System.Windows.Forms.TextBox
    Friend WithEvents txtPatCity As System.Windows.Forms.TextBox
    Friend WithEvents txtPatZip As System.Windows.Forms.TextBox
    Friend WithEvents txtPatLN As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents gbPatient As System.Windows.Forms.GroupBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents rtbComments As System.Windows.Forms.RichTextBox
    Friend WithEvents Comments As System.Windows.Forms.Label
    Friend WithEvents ddlPatState As System.Windows.Forms.ComboBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents ddlGender As System.Windows.Forms.ComboBox
    Friend WithEvents ddlMonth As System.Windows.Forms.ComboBox
    Friend WithEvents ddlDay As System.Windows.Forms.ComboBox
    Friend WithEvents ddlYear As System.Windows.Forms.ComboBox
    Friend WithEvents lnkNursing As System.Windows.Forms.LinkLabel
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lnkInsurance As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkContact As System.Windows.Forms.LinkLabel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnEdit As System.Windows.Forms.Button
End Class
