Option Strict On

Imports System.Data.OleDb
Imports System.IO


Public Class ClassDB
    'Declare module level variables
    Dim mdbConn As OleDbConnection
    '//// CHANGE CONNECTION STRING HERE ----->
    '//// Change after Source=<insert your source here>;
    'Dim mstrConnection As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=C:\Users\Lindsay\Desktop\374Project\DaySheetTest\KalpaxisDB.accdb;"
    Dim mstrConnection As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Directory.GetCurrentDirectory() + "\KalpaxisDB.accdb;"
    Dim cmd As OleDbCommand
    Dim mDataReader As OleDbDataReader
    Dim mDataAdapter As OleDbDataAdapter
    Dim mDatasetPatient As New DataSet
    Dim mDatasetSpouse As New DataSet
    Dim mDatasetCount As New DataSet
    Dim mDatasetSecondaryCount As New DataSet
    Dim mDatasetTertiaryCount As New DataSet
    Dim mDatasetQuaternaryCount As New DataSet
    Dim mDatasetQuinaryCount As New DataSet
    Dim mDatasetSenaryCount As New DataSet
    Dim mstrQuery As String
    Dim mDatasetInsurance As New DataSet
    Dim mDatasetLogin As New DataSet
    Dim dbView As DataView
    Dim dbCPTView As DataView

    'Define public Read-Only property
    Public ReadOnly Property CountDataset() As DataSet
        Get
            'Return Dataset
            Return mDatasetCount
        End Get
    End Property

    Public ReadOnly Property View As DataView
        Get
            'Return Dataset
            Return dbView
        End Get
    End Property

    Public ReadOnly Property CPTView As DataView
        Get
            'Return Dataset
            Return dbCPTView
        End Get
    End Property

    Public ReadOnly Property LoginDataset() As DataSet
        Get
            'Return Dataset
            Return mDatasetLogin
        End Get
    End Property

    Public ReadOnly Property SecondaryCountDataset() As DataSet
        Get
            'Return Dataset
            Return mDatasetSecondaryCount
        End Get
    End Property

    Public ReadOnly Property TertiaryCountDataset() As DataSet
        Get
            'Return Dataset
            Return mDatasetTertiaryCount
        End Get
    End Property

    Public ReadOnly Property QuaternaryCountDataset() As DataSet
        Get
            'Return Dataset
            Return mDatasetQuaternaryCount
        End Get
    End Property
    Public ReadOnly Property QuinaryCountDataset() As DataSet
        Get
            'Return Dataset
            Return mDatasetQuinaryCount
        End Get
    End Property
    Public ReadOnly Property SenaryCountDataset() As DataSet
        Get
            'Return Dataset
            Return mDatasetSenaryCount
        End Get
    End Property

    Public ReadOnly Property PatientDataset() As DataSet
        Get
            'Return Dataset
            Return mDatasetPatient
        End Get
    End Property

    Public ReadOnly Property SpouseDataset() As DataSet
        Get
            'Return Dataset
            Return mDatasetSpouse
        End Get
    End Property

    Public ReadOnly Property InsuranceDataset() As DataSet
        Get
            'Return Dataset
            Return mDatasetInsurance
        End Get
    End Property

    'Select Query to count rows

    Public Sub SelectQuery(ByVal strQuery As String, ByVal strTableName As String)
        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(strQuery, mdbConn)

            'open the connection and dataset
            mdbConn.Open()

            'clear dataset before filling
            mDatasetCount.Clear()

            'fill dataset
            mDataAdapter.Fill(mDatasetCount, strTableName)

            'close the connection
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception("Query is " & strQuery.ToString & "Error is " & ex.Message)
        End Try
    End Sub


    'Select Query to count secondary rows
    Public Sub SecondarySelectQuery(ByVal strQuery As String, ByVal strTableName As String)
        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(strQuery, mdbConn)

            'open the connection and dataset
            mdbConn.Open()

            'clear dataset before filling
            mDatasetSecondaryCount.Clear()

            'fill dataset
            mDataAdapter.Fill(mDatasetSecondaryCount, strTableName)

            'close the connection
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception("Query is " & strQuery.ToString & "Error is " & ex.Message)
        End Try
    End Sub

    'Select Query to count secondary rows
    Public Sub TertiarySelectQuery(ByVal strQuery As String, ByVal strTableName As String)
        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(strQuery, mdbConn)

            'open the connection and dataset
            mdbConn.Open()

            'clear dataset before filling
            mDatasetTertiaryCount.Clear()

            'fill dataset
            mDataAdapter.Fill(mDatasetTertiaryCount, strTableName)

            'close the connection
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception("Query is " & strQuery.ToString & "Error is " & ex.Message)
        End Try
    End Sub

    'Select Query to count secondary rows
    Public Sub QuaternarySelectQuery(ByVal strQuery As String, ByVal strTableName As String)
        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(strQuery, mdbConn)

            'open the connection and dataset
            mdbConn.Open()

            'clear dataset before filling
            mDatasetQuaternaryCount.Clear()

            'fill dataset
            mDataAdapter.Fill(mDatasetQuaternaryCount, strTableName)

            'close the connection
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception("Query is " & strQuery.ToString & "Error is " & ex.Message)
        End Try
    End Sub
    Public Sub QuinarySelectQuery(ByVal strQuery As String, ByVal strTableName As String)
        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(strQuery, mdbConn)

            'open the connection and dataset
            mdbConn.Open()

            'clear dataset before filling
            mDatasetQuinaryCount.Clear()

            'fill dataset
            mDataAdapter.Fill(mDatasetQuinaryCount, strTableName)

            'close the connection
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception("Query is " & strQuery.ToString & "Error is " & ex.Message)
        End Try
    End Sub
    Public Sub SenarySelectQuery(ByVal strQuery As String, ByVal strTableName As String)
        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(strQuery, mdbConn)

            'open the connection and dataset
            mdbConn.Open()

            'clear dataset before filling
            mDatasetSenaryCount.Clear()

            'fill dataset
            mDataAdapter.Fill(mDatasetSenaryCount, strTableName)

            'close the connection
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception("Query is " & strQuery.ToString & "Error is " & ex.Message)
        End Try
    End Sub

    Public Sub SelectCertainPatient(ByVal strQuery As String)
        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(strQuery, mdbConn)

            'open the connection and dataset
            mdbConn.Open()

            'clear dataset before filling
            mDatasetPatient.Clear()

            'fill dataset
            mDataAdapter.Fill(mDatasetPatient, "tblPatient")

            'close the connection
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception("Query is " & strQuery.ToString & "Error is " & ex.Message)
        End Try
    End Sub

    Public Sub SelectCertainSpouse(ByVal strQuery As String)
        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(strQuery, mdbConn)

            'open the connection and dataset
            mdbConn.Open()

            'clear dataset before filling
            mDatasetSpouse.Clear()

            'fill dataset
            mDataAdapter.Fill(mDatasetSpouse, "tblSpouse")

            'close the connection
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception("Query is " & strQuery.ToString & "Error is " & ex.Message)
        End Try
    End Sub

    Public Sub AddNewPatient(ByVal strFirstName As String, ByVal strLastName As String, ByVal strAddress As String, ByVal strZip As String, ByVal strPhone As String, ByVal strDateOfBirth As String, ByVal strLicense As String, ByVal strSSN As String, ByVal strGender As String, ByVal strCity As String, ByVal strState As String, ByVal strComment As String, ByVal strRelativeID As String, ByVal intEmployerID As Integer)
        mstrQuery = "INSERT INTO tblPatient (FirstName, LastName, Address, Zip, Phone, DateOfBirth, License, SSN, Gender, City, State, Comment, RelativeID, EmployerID) VALUES ('" & strFirstName & "', '" & strLastName & "', '" & strAddress & "', '" & strZip & "', '" & strPhone & "', '" & strDateOfBirth & "', '" & strLicense & "', '" & strSSN & "', '" & strGender & "', '" & strCity & "', '" & strState & "', '" & strComment & "','" & intEmployerID & "','" & strRelativeID & "');"

        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(mstrQuery, mdbConn)

            'open connecton
            mdbConn.Open()

            'execute command
            mDataAdapter.SelectCommand.ExecuteNonQuery()

            'close connection
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception("Error is " & ex.Message)
        End Try
    End Sub

    Public Sub AddNewSpouse(ByVal strFirstName As String, ByVal strLastName As String, ByVal strGender As String, ByVal strPhone As String, ByVal intPatientID As Integer, ByVal intEmployerID As Integer)
        mstrQuery = "INSERT INTO tblSpouse (FirstName, LastName, Gender, Phone, PatientID, EmployerID) VALUES ('" & strFirstName & "', '" & strLastName & "', '" & strGender & "', '" & strPhone & "', " & intPatientID & ", '" & intEmployerID & "');"

        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(mstrQuery, mdbConn)

            'open connecton
            mdbConn.Open()

            'execute command
            mDataAdapter.SelectCommand.ExecuteNonQuery()

            'close connection
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception("Error is " & ex.Message)
        End Try
    End Sub

    Public Sub AddNewRelative(ByVal strFirstName As String, ByVal strLastName As String, ByVal strRelation As String, ByVal strAddress As String, ByVal strCity As String, ByVal strState As String, ByVal strZip As String, ByVal strPhone As String)
        mstrQuery = "INSERT INTO tblRelative (FirstName, LastName, Relation, Address, City, State, Zip, Phone) VALUES ('" & strFirstName & "', '" & strLastName & "', '" & strRelation & "', '" & strAddress & "', '" & strCity & "', '" & strState & "', '" & strZip & "', '" & strPhone & "');"

        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(mstrQuery, mdbConn)

            'open connecton
            mdbConn.Open()

            'execute command
            mDataAdapter.SelectCommand.ExecuteNonQuery()

            'close connection
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception("Error is " & ex.Message)
        End Try
    End Sub

    Public Sub AddInsurance(ByVal strInsuranceName As String, ByVal strIDNumber As String, ByVal strGroupNumber As String, ByVal strAddress As String, ByVal strCity As String, ByVal strState As String, ByVal strZip As String, ByVal strPhone As String, ByVal strPatientID As String, ByVal strType As String)
        mstrQuery = "INSERT INTO tblInsurance (InsuranceName, IDNumber, GroupNumber, Address, City, State, Zip, Phone, PatientID, Type) VALUES ('" & strInsuranceName & "', '" & strIDNumber & "', '" & strGroupNumber & "', '" & strAddress & "', '" & strCity & "', '" & strState & "', '" & strZip & "', '" & strPhone & "', '" & strPatientID & "', '" & strType & "');"

        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(mstrQuery, mdbConn)

            'open connecton
            mdbConn.Open()

            'execute command
            mDataAdapter.SelectCommand.ExecuteNonQuery()

            'close connection
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception("Error is " & ex.Message)
        End Try
    End Sub

    Public Sub AddEmployer(ByVal strEmployer As String, ByVal strAddress As String, ByVal strCity As String, ByVal strState As String, ByVal strZip As String, ByVal strPhone As String, ByVal intEmployerID As Integer)
        mstrQuery = "INSERT INTO tblEmployer (EmpName, Address, City, State, Zip, Phone, EmployerID) VALUES ('" & strEmployer & "', '" & strAddress & "', '" & strCity & "', '" & strState & "', '" & strZip & "', '" & strPhone & "', '" & intEmployerID & "');"
        ' Public Sub AddEmployer(ByVal strEmployer As String, ByVal strAddress As String, ByVal strCity As String, ByVal strState As String, ByVal strZip As String, ByVal strPhone As String)
        ' mstrQuery = "INSERT INTO tblEmployer (EmpName, Address, City, State, Zip, Phone) VALUES ('" & strEmployer & "', '" & strAddress & "', '" & strCity & "', '" & strState & "', '" & strZip & "', '" & strPhone & "');"

        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(mstrQuery, mdbConn)

            'open connecton
            mdbConn.Open()

            'execute command
            mDataAdapter.SelectCommand.ExecuteNonQuery()

            'close connection
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception("Error is " & ex.Message)
        End Try
    End Sub

    ' Public Sub AddNewTransaction(ByVal intPatientID As Integer, ByVal strDateOfTransaction As Date, ByVal strDateClaimFiled As Date, ByVal intInsuranceID As Integer, ByVal strDescription As String, ByVal intCharge As Double, ByVal intPayments As Double, ByVal intCash As Double, ByVal intAdjustment As Double, ByVal intCurrentBalance As Double)
    ' mstrQuery = "INSERT INTO tblTransaction (PatientID, TransDate, RefDate, InsuranceID, Description, Charge, Payments, Cash, Adjustments, CurrentBal) VALUES ('" & intPatientID & "', '" & strDateOfTransaction & "', '" & strDateClaimFiled & "', '" & intInsuranceID & "', '" & strDescription & "', '" & intCharge & "', '" & intPayments & "', '" & intCash & "', '" & intAdjustment & "', '" & intCurrentBalance & "');"
    Public Sub AddNewTransaction(ByVal strFirstName As String, ByVal strLastName As String, ByVal intPatientID As Integer, ByVal strDateOfTransaction As Date, ByVal intInsuranceID As Integer, ByVal decCharge As Decimal, ByVal strAuthorizationNO As String, ByVal decCash As Decimal, ByVal decCheck As Decimal, ByVal intCheckNo As Integer, ByVal decAdjustment As Decimal, ByVal decCurrentBalance As Decimal, ByVal decPrevBal As Decimal, ByVal intReceipt As Integer, ByVal decCredit As Decimal)
        mstrQuery = "INSERT INTO tblTransaction (FirstName, LastName, PatientID, TransDate, InsuranceID, Charge, AuthorizationNo, Cash, [Check], CheckNo, Credit, Adjustments, CurrentBal, PrevBal, ReceiptNumber) VALUES ('" & strFirstName & "', '" & strLastName & "', '" & intPatientID & "', '" & strDateOfTransaction & "', '" & intInsuranceID & "', '" & decCharge & "', '" & strAuthorizationNO & "', '" & decCash & "', '" & decCheck & "', '" & intCheckNo & "', '" & decCredit & "', '" & decAdjustment & "', '" & decCurrentBalance & "', '" & decPrevBal & "', '" & intReceipt & "');"
        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(mstrQuery, mdbConn)

            'open connecton
            mdbConn.Open()

            'execute command
            mDataAdapter.SelectCommand.ExecuteNonQuery()

            'close connection
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception("Error is " & ex.Message)
        End Try
    End Sub

    Public Sub AddNewInsuranceTransaction(ByVal strFirstName As String, ByVal strLastName As String, ByVal datDateOfTransaction As Date, ByVal datPaymentDate As Date, ByVal intInsuranceID As Integer, ByVal decCheck As Decimal, ByVal intCheckNo As Integer, ByVal decCurrentBalance As Decimal, ByVal decPrevBal As Decimal, ByVal intPatientID As Integer)
        mstrQuery = "INSERT INTO tblTransaction (FirstName, LastName, TransDate, RefDate, PatientID, InsuranceID, [Check], CheckNo, CurrentBal, PrevBal) VALUES ('" & strFirstName & "', '" & strLastName & "', '" & datDateOfTransaction & "', '" & datPaymentDate & "', '" & intPatientID & "', '" & intInsuranceID & "', '" & decCheck & "', '" & intCheckNo & "', '" & decCurrentBalance & "', '" & decPrevBal & "');"
        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(mstrQuery, mdbConn)

            'open connecton
            mdbConn.Open()

            'execute command
            mDataAdapter.SelectCommand.ExecuteNonQuery()

            'close connection
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception("Error is " & ex.Message)
        End Try
    End Sub

    Public Sub AddNewPatientTransaction(ByVal strFirstName As String, ByVal strLastName As String, ByVal datDateOfTransaction As Date, ByVal intPatientID As Integer, ByVal decCredit As Decimal, ByVal strAuthorizationNo As String, ByVal decCash As Decimal, ByVal decCheck As Decimal, ByVal intCheckNo As Integer, ByVal decCurrentBalance As Decimal, ByVal decPrevBal As Decimal, ByVal decAdjustments As Decimal)
        mstrQuery = "INSERT INTO tblTransaction (FirstName, LastName, TransDate, PatientID, Credit, AuthorizationNo, Cash, [Check], CheckNo, CurrentBal, PrevBal, Adjustments) VALUES ('" & strFirstName & "', '" & strLastName & "', '" & datDateOfTransaction & "', '" & intPatientID & "', '" & decCredit & "', '" & strAuthorizationNo & "', '" & decCash & "', '" & decCheck & "', '" & intCheckNo & "', '" & decCurrentBalance & "', '" & decPrevBal & "', '" & decAdjustments & "');"
        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(mstrQuery, mdbConn)

            'open connecton
            mdbConn.Open()

            'execute command
            mDataAdapter.SelectCommand.ExecuteNonQuery()

            'close connection
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception("Error is " & ex.Message)
        End Try
    End Sub

    Public Sub AddWriteOffTransaction(ByVal strFirstName As String, ByVal strLastName As String, ByVal datDateOfTransaction As Date, ByVal intPatientID As Integer, ByVal decWriteOff As Decimal, ByVal decCurrentBalance As Decimal, ByVal decPrevBal As Decimal)
        mstrQuery = "INSERT INTO tblTransaction (FirstName, LastName, TransDate, PatientID, WriteOff, CurrentBal, PrevBal) VALUES ('" & strFirstName & "', '" & strLastName & "', '" & datDateOfTransaction & "', '" & intPatientID & "', '" & decWriteOff & "', '" & decCurrentBalance & "', '" & decPrevBal & "');"
        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(mstrQuery, mdbConn)

            'open connecton
            mdbConn.Open()

            'execute command
            mDataAdapter.SelectCommand.ExecuteNonQuery()

            'close connection
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception("Error is " & ex.Message)
        End Try
    End Sub

    Public Sub AddNewTransactionNoRef(ByVal strFirstName As String, ByVal strLastName As String, ByVal intPatientID As Integer, ByVal strDateOfTransaction As Date, ByVal intInsuranceID As Integer, ByVal strDescription As String, ByVal intCharge As Double, ByVal intPayments As Double, ByVal intCash As Double, ByVal intCheck As Double, ByVal intAdjustment As Double, ByVal intCurrentBalance As Double, ByVal intPrevBal As Double, ByVal intReceipt As Integer, ByVal NeedToFile As String)
        mstrQuery = "INSERT INTO tblTransaction (FirstName, LastName, PatientID, TransDate, InsuranceID, Description, Charge, Payments, Cash, [Check], Adjustments, CurrentBal, PrevBal, Receipt, NeedToFile) VALUES ('" & strFirstName & "', '" & strLastName & "', '" & intPatientID & "', '" & strDateOfTransaction & "', '" & intInsuranceID & "', '" & strDescription & "', '" & intCharge & "', '" & intPayments & "', '" & intCash & "', '" & intCheck & "', '" & intAdjustment & "', '" & intCurrentBalance & "', '" & intPrevBal & "', '" & intReceipt & "', '" & NeedToFile & "');"
        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(mstrQuery, mdbConn)

            'open connecton
            mdbConn.Open()

            'execute command
            mDataAdapter.SelectCommand.ExecuteNonQuery()

            'close connection
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception("Error is " & ex.Message)
        End Try
    End Sub

    Public Sub AddNursing(ByVal strMD As String, ByVal strMDAddress As String, ByVal strMDCity As String, ByVal strMDState As String, ByVal strMDZip As String, ByVal strMDPhone As String, ByVal strMDNPI As String, ByVal strNH As String, ByVal strNHAddress As String, ByVal strNHCity As String, ByVal strNHState As String, ByVal strNHZip As String, ByVal strCT As String, ByVal strCTAddress As String, ByVal strCTCity As String, ByVal strCTState As String, ByVal strCTZip As String, ByVal strCTPhone As String, ByVal strPatientID As String)
        mstrQuery = "INSERT INTO tblNursing (MainDoctor, MainDoctorAddress, MainDoctorCity, MainDoctorState, MainDoctorZip, MainDoctorPhone, MainDoctorNPI, NursingHome, NursingHomeAddress, NursingHomeCity, NursingHomeState, NursingHomeZip, CareTaker, CareTakerAddress, CareTakerCity, CareTakerState, CareTakerZip, CareTakerPhone, PatientID) VALUES ('" & strMD & "', '" & strMDAddress & "', '" & strMDCity & "', '" & strMDState & "', '" & strMDZip & "', '" & strMDPhone & "', '" & strMDNPI & "', '" & strNH & "', '" & strNHAddress & "', '" & strNHCity & "', '" & strNHState & "', '" & strNHZip & "', '" & strCT & "', '" & strCTAddress & "', '" & strCTCity & "', '" & strCTState & "', '" & strCTZip & "', '" & strCTPhone & "', '" & strPatientID & "');"

        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(mstrQuery, mdbConn)

            'open connecton
            mdbConn.Open()

            'execute command
            mDataAdapter.SelectCommand.ExecuteNonQuery()

            'close connection
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception("Error is " & ex.Message)
        End Try
    End Sub

    Public Sub UpdateNursing(ByVal strMD As String, ByVal strMDAddress As String, ByVal strMDCity As String, ByVal strMDState As String, ByVal strMDZip As String, ByVal strMDPhone As String, ByVal strMDNPI As String, ByVal strNH As String, ByVal strNHAddress As String, ByVal strNHCity As String, ByVal strNHState As String, ByVal strNHZip As String, ByVal strCT As String, ByVal strCTAddress As String, ByVal strCTCity As String, ByVal strCTState As String, ByVal strCTZip As String, ByVal strCTPhone As String, ByVal intPatientID As Integer)

        mstrQuery = "UPDATE tblNursing SET MainDoctor = '" & strMD & "', MainDoctorAddress = '" & strMDAddress & "', MainDoctorCity = '" & strMDCity & "', MainDoctorState = '" & strMDState & "', MainDoctorZip = '" & strMDZip & "', MainDoctorPhone = '" & strMDPhone & "', MainDoctorNPI = '" & strMDNPI & "', NursingHome = '" & strNH & "', NursingHomeAddress = '" & strNHAddress & "', NursingHomeCity = '" & strNHCity & "', NursingHomeState = '" & strNHState & "', NursingHomeZip = '" & strNHZip & "', CareTaker = '" & strCT & "', CareTakerAddress = '" & strCTAddress & "', CareTakerCity = '" & strCTCity & "', CareTakerState = '" & strCTState & "', CareTakerZip = '" & strCTZip & "', CareTakerPhone = '" & strCTPhone & "' WHERE PatientID = " & intPatientID

        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(mstrQuery, mdbConn)

            'open connecton
            mdbConn.Open()

            'execute command
            mDataAdapter.SelectCommand.ExecuteNonQuery()

            'close connection
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception("Error is " & ex.Message)
        End Try

    End Sub

    'Public Sub UpdatePatientInfo(ByVal strFirstName As String, ByVal strLastName As String, ByVal strAddress As String, ByVal strZip As String, ByVal strPhone As String, ByVal strDateOfBirth As String, ByVal strLicense As String, ByVal strSSN As String, ByVal strGender As String, ByVal strCity As String, ByVal strState As String, ByVal strComment As String, ByVal intPatientID As Integer)

    Public Sub UpdatePatientInfo(ByVal strFirstName As String, ByVal strLastName As String, ByVal strAddress As String, ByVal strZip As String, ByVal strPhone As String, ByVal strDateOfBirth As String, ByVal strLicense As String, ByVal strSSN As String, ByVal strGender As String, ByVal strCity As String, ByVal strState As String, ByVal strComment As String, ByVal intPAtientID As Integer)
        'mstrQuery = "UPDATE tblPatient SET FirstName = '" & strFirstName & "', LastName = '" & strLastName & "', Address = '" & strAddress & "', Zip = '" & strZip & "', Phone = '" & strPhone & "', DateOfBirth = '" & strDateOfBirth & "', License = '" & strLicense & "', SSN = '" & strSSN & "', Gender = '" & strGender & "', City = '" & strCity & "', State '" & strState & "', Comment = '" & strComment & "' WHERE PatientID = " & intPAtientID
        mstrQuery = "UPDATE tblPatient SET FirstName = '" & strFirstName & "', LastName = '" & strLastName & "', Address = '" & strAddress & "', City = '" & strCity & "', State = '" & strState & "', Zip = '" & strZip & "', Phone = '" & strPhone & "', DateOfBirth = '" & strDateOfBirth & "', License = '" & strLicense & "', SSN = '" & strSSN & "', Gender = '" & strGender & "', Comment = '" & strComment & "' WHERE PatientID = " & intPAtientID

        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(mstrQuery, mdbConn)

            'open connecton
            mdbConn.Open()

            'execute command
            mDataAdapter.SelectCommand.ExecuteNonQuery()

            'close connection
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception("Error is " & ex.Message)
        End Try
    End Sub

    Public Sub UpdateEmployerInfo(ByVal strEmployer As String, ByVal strAddress As String, ByVal strCity As String, ByVal strState As String, ByVal strZip As String, ByVal strPhone As String, ByVal intEmployerID As Integer)
        mstrQuery = "UPDATE tblEmployer SET EmpName = '" & strEmployer & "', Address = '" & strAddress & "', City = '" & strCity & "',  State = '" & strState & "', Zip = '" & strZip & "', Phone = '" & strPhone & "' WHERE EmployerID = " & intEmployerID & ";"
        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(mstrQuery, mdbConn)

            'open connecton
            mdbConn.Open()

            'execute command
            mDataAdapter.SelectCommand.ExecuteNonQuery()

            'close connection
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception("Error is " & ex.Message)
        End Try
    End Sub

    Public Sub UpdateSpouseEmployerInfo(ByVal strEmployer As String, ByVal strAddress As String, ByVal strCity As String, ByVal strState As String, ByVal strZip As String, ByVal intEmployerID As Integer)
        mstrQuery = "UPDATE tblEmployer SET EmpName = '" & strEmployer & "', Address = '" & strAddress & "', City = '" & strCity & "', State = '" & strState & "', Zip = '" & strZip & "' WHERE EmployerID = " & intEmployerID & ";"
        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(mstrQuery, mdbConn)

            'open connecton
            mdbConn.Open()

            'execute command
            mDataAdapter.SelectCommand.ExecuteNonQuery()

            'close connection
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception("Error is " & ex.Message)
        End Try
    End Sub

    Public Sub UpdateSpouseInfo(ByVal strFN As String, ByVal strLN As String, ByVal strPhone As String, ByVal intPatientID As Integer)
        mstrQuery = "UPDATE tblSpouse SET FirstName = '" & strFN & "', LastName = '" & strLN & "', Phone = '" & strPhone & "' WHERE PatientID = " & intPatientID & ";"
        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(mstrQuery, mdbConn)

            'open connecton
            mdbConn.Open()

            'execute command
            mDataAdapter.SelectCommand.ExecuteNonQuery()

            'close connection
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception("Error is " & ex.Message)
        End Try
    End Sub

    Public Sub UpdateInsuranceInfo(ByVal strProvider As String, ByVal strIDnumber As String, ByVal strGrpNumber As String, ByVal strAddress As String, ByVal strPhone As String, ByVal strCity As String, ByVal strState As String, ByVal strPatientID As String, ByVal strZip As String, ByVal strType As String)
        mstrQuery = "UPDATE tblInsurance SET InsuranceName = '" & strProvider & "', IDNumber = '" & strIDnumber & "', GroupNumber = '" & strGrpNumber & "', Address = '" & strAddress & "', City = '" & strCity & "', State = '" & strState & "', Zip = '" & strZip & "', Phone = '" & strPhone & "', Type = '" & strType & "' WHERE PatientID = '" & strPatientID & "';"
        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(mstrQuery, mdbConn)

            'open connecton
            mdbConn.Open()

            'execute command
            mDataAdapter.SelectCommand.ExecuteNonQuery()

            'close connection
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception("Error is " & ex.Message)
        End Try
    End Sub
    Public Sub UpdateRelativeInfo(ByVal strFN As String, ByVal strLN As String, ByVal strRelation As String, ByVal strAddress As String, ByVal strPhone As String, ByVal strCity As String, ByVal strState As String, ByVal intRelationID As Integer, ByVal strZip As String)
        mstrQuery = "UPDATE tblRelative SET FirstName = '" & strFN & "', LastName = '" & strLN & "', Relation = '" & strRelation & "', Address = '" & strAddress & "', City = '" & strCity & "', State = '" & strState & "', Zip = '" & strZip & "', Phone = '" & strPhone & "' WHERE RelativeID = " & intRelationID & ";"
        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(mstrQuery, mdbConn)

            'open connecton
            mdbConn.Open()

            'execute command
            mDataAdapter.SelectCommand.ExecuteNonQuery()

            'close connection
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception("Error is " & ex.Message)
        End Try
    End Sub

    'Public Sub FileClaim(ByVal intReceipt As Integer, ByVal strDate As String)
    '    mstrQuery = "UPDATE tblTransaction SET RefDate = '" & strDate & "' WHERE Receipt = " & intReceipt
    '    Try
    '        'define data connection and data adapter
    '        mdbConn = New OleDbConnection(mstrConnection)
    '        mDataAdapter = New OleDbDataAdapter(mstrQuery, mdbConn)

    '        'open connecton
    '        mdbConn.Open()

    '        'execute command
    '        mDataAdapter.SelectCommand.ExecuteNonQuery()

    '        'close connection
    '        mdbConn.Close()
    '    Catch ex As Exception
    '        Throw New Exception("Error is " & ex.Message)
    '    End Try
    'End Sub

    Public Sub AddEmployerID(ByVal strEmpID As String, ByVal intPatientID As Integer)
        mstrQuery = "UPDATE tblPatient SET EmployerID = " & strEmpID & " WHERE PatientID = " & intPatientID & ";"
        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(mstrQuery, mdbConn)

            'open connecton
            mdbConn.Open()

            'execute command
            mDataAdapter.SelectCommand.ExecuteNonQuery()

            'close connection
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception("Error is " & ex.Message)
        End Try
    End Sub

    Public Sub AddRelativeID(ByVal strRelativeID As String, ByVal intPatientID As Integer)
        mstrQuery = "UPDATE tblPatient SET RelativeID = " & strRelativeID & " WHERE PatientID = " & intPatientID & ";"
        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(mstrQuery, mdbConn)

            'open connecton
            mdbConn.Open()

            'execute command
            mDataAdapter.SelectCommand.ExecuteNonQuery()

            'close connection
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception("Error is " & ex.Message)
        End Try
    End Sub

    Public Sub FindPatient(ByVal intPatientID As Integer)
        mstrQuery = "SELECT * FROM tblTransaction WHERE PatientID = " & intPatientID
        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(mstrQuery, mdbConn)

            'open connecton
            mdbConn.Open()

            'execute command
            mDataAdapter.SelectCommand.ExecuteNonQuery()

            'close connection
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception("Error is " & ex.Message)
        End Try
    End Sub

    Public Sub GetPreviousBalance(ByVal intPatientID As Integer)
        mstrQuery = "SELECT * FROM tblTransaction WHERE PatientID = " & intPatientID
        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(mstrQuery, mdbConn)

            'open connecton
            mdbConn.Open()

            'execute command
            mDataAdapter.SelectCommand.ExecuteNonQuery()

            'fill dataset
            mDataAdapter.Fill(mDatasetCount, "tblTransaction")

            'close connection
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception("Error is " & ex.Message)
        End Try

    End Sub

    'Public Sub GetInsurance(ByVal strpatientID As String)
    '    mstrQuery = "SELECT * FROM tblInsurance WHERE PatientID = " & strpatientID
    '    Try
    '        'define data connection and data adapter
    '        mdbConn = New OleDbConnection(mstrConnection)
    '        mDataAdapter = New OleDbDataAdapter(mstrQuery, mdbConn)

    '        'open connecton
    '        mdbConn.Open()

    '        'execute command
    '        mDataAdapter.SelectCommand.ExecuteNonQuery()

    '        'fill dataset
    '        mDataAdapter.Fill(mDatasetInsurance, "tblInsurance")

    '    Catch ex As Exception
    '        Throw New Exception("Error is " & ex.Message)
    '    End Try
    'End Sub

    Public Function CheckLogin(ByVal strUsername As String, ByVal strPassword As String) As Boolean
        mstrQuery = "SELECT * FROM tblLogin WHERE Username = '" & strUsername & "' AND Password = '" & strPassword & "'"
        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(mstrQuery, mdbConn)

            'open connecton
            mdbConn.Open()

            'execute command
            mDataAdapter.SelectCommand.ExecuteNonQuery()

            'fill dataset
            mDataAdapter.Fill(mDatasetLogin, "tblLogin")

        Catch ex As Exception
            Throw New Exception("Error is " & ex.Message)
        End Try

        If LoginDataset.Tables("tblLogin").Rows.Count = 0 Then
            Return False
        End If

        Dim strDataUsername As String
        strDataUsername = LoginDataset.Tables("tblLogin").Rows(0).Item("Username").ToString

        Dim strDataPassword As String
        strDataPassword = LoginDataset.Tables("tblLogin").Rows(0).Item("Password").ToString

        If strDataUsername <> strUsername Then
            Return False
        Else
            If strDataPassword <> strPassword Then
                Return False
            Else
                Return True
            End If
        End If

    End Function

    Public Function CheckOldPassword(ByVal strPassword As String) As Boolean
        mstrQuery = "SELECT * FROM tblLogin"
        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(mstrQuery, mdbConn)

            'open connecton
            mdbConn.Open()

            'execute command
            mDataAdapter.SelectCommand.ExecuteNonQuery()

            'fill dataset
            mDataAdapter.Fill(mDatasetLogin, "tblLogin")

        Catch ex As Exception
            Throw New Exception("Error is " & ex.Message)
        End Try


        Dim strDataPassword As String
        strDataPassword = LoginDataset.Tables("tblLogin").Rows(0).Item("Password").ToString

        If strDataPassword <> strPassword Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Sub UpdatePassword(ByVal strPassword As String)
        mstrQuery = "UPDATE tblLogin SET [Password] = '" & strPassword & "'"

        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(mstrQuery, mdbConn)

            'open connecton
            mdbConn.Open()

            'execute command
            mDataAdapter.SelectCommand.ExecuteNonQuery()

            'fill dataset
            mDataAdapter.Fill(mDatasetLogin, "tblLogin")

            'close connection
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception("Error is " & ex.Message)
        End Try
    End Sub

    Public Sub GetPatientEmployer(ByVal intpatientID As Integer)
        mstrQuery = "SELECT EmployerID FROM tblPatient WHERE PatientID = '" & intpatientID & "'"
        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(mstrQuery, mdbConn)

            'open connecton
            mdbConn.Open()

            'execute command
            mDataAdapter.SelectCommand.ExecuteNonQuery()

            'fill dataset
            mDataAdapter.Fill(mDatasetCount, "tblPatient")

        Catch ex As Exception
            Throw New Exception("Error is " & ex.Message)
        End Try
    End Sub
    Public Sub GetInsurance(ByVal intPatientID As Integer)

        mstrQuery = "SELECT InsuranceName FROM tblInsurance WHERE PatientID = '" & intPatientID & "' GROUP BY InsuranceName"
        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(mstrQuery, mdbConn)

            'open connecton
            mdbConn.Open()

            'execute command
            mDataAdapter.SelectCommand.ExecuteNonQuery()

            'fill dataset
            mDataAdapter.Fill(mDatasetInsurance, "tblInsurance")

        Catch ex As Exception
            Throw New Exception("Error is " & ex.Message)
        End Try

        dbView = New DataView(InsuranceDataset.Tables("tblInsurance"))
        dbView.Sort = "InsuranceName DESC"
    End Sub

    Public Sub GetTop20()

        mstrQuery = "SELECT * FROM tblFeeSchedule WHERE Top20 = 'T'"
        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(mstrQuery, mdbConn)

            'open connecton
            mdbConn.Open()

            'execute command
            mDataAdapter.SelectCommand.ExecuteNonQuery()

            'fill dataset
            mDataAdapter.Fill(mDatasetCount, "tblFeeSchedule")

        Catch ex As Exception
            Throw New Exception("Error is " & ex.Message)
        End Try

        'dbCPTView = New DataView(CountDataset.Tables("tblFeeSchedule").rows.item("CPT Code")
        'dbCPTView.Sort = "CPT Code DESC"
    End Sub

    Public Sub GetPatientName(ByVal strPatientID As String)
        mstrQuery = "SELECT Firstname + ' ' + Lastname AS Name FROM tblPatient WHERE PatientID = '" & strPatientID & "'"
        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(mstrQuery, mdbConn)

            'open connecton
            mdbConn.Open()

            'execute command
            mDataAdapter.SelectCommand.ExecuteNonQuery()

            'fill dataset
            mDataAdapter.Fill(mDatasetPatient, "tblPatient")

        Catch ex As Exception
            Throw New Exception("Error is " & ex.Message)
        End Try
    End Sub

    Public Function GetCPT(ByVal strCPT As String) As Boolean
        mstrQuery = "SELECT * FROM tblFeeSchedule WHERE CPTCode = '" & strCPT & "'"
        If CountDataset.Tables("tblFeeSchedule").Rows.Count <> 0 Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Sub GetCharge(ByVal strCPT As String)
        mstrQuery = "SELECT * FROM tblFeeSchedule WHERE CPTCode = '" & strCPT & "'"
        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(mstrQuery, mdbConn)

            'open connecton
            mdbConn.Open()

            'execute command
            mDataAdapter.SelectCommand.ExecuteNonQuery()

            'fill dataset
            mDataAdapter.Fill(mDatasetPatient, "tblPatient")

        Catch ex As Exception
            Throw New Exception("Error is " & ex.Message)
        End Try
    End Sub

    Public Sub FileClaim(ByVal strReceipt As String, ByVal datDate As Date)
        mstrQuery = "UPDATE tblTransaction SET RefDate = '" & datDate & "' WHERE ReceiptNumber = " & strReceipt
        Try
            'define data connection and data adapter
            mdbConn = New OleDbConnection(mstrConnection)
            mDataAdapter = New OleDbDataAdapter(mstrQuery, mdbConn)

            'open connecton
            mdbConn.Open()

            'execute command
            mDataAdapter.SelectCommand.ExecuteNonQuery()

            'close connection
            mdbConn.Close()
        Catch ex As Exception
            Throw New Exception("Error is " & ex.Message)
        End Try
    End Sub

End Class
