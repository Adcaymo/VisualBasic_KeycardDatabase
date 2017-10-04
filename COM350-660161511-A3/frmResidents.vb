Imports System.IO

Public Class frmResidents

    Private residentList As List(Of Resident)
    Private stateList As List(Of State)
    Private selectedResident As Resident

    Private Sub frmResidents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        residentList = ResidentDB.GetResidents()
        Me.LoadStateComboBox()
        Me.LoadMasterForm()
        dgResidents.ClearSelection()
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Dim historyForm As New frmHistory
        Try
            Me.Tag = selectedResident.ResidentId
            frmHistory.ShowDialog()
        Catch ex As NullReferenceException
            MessageBox.Show("Please select a resident.")
        End Try
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If dgResidents.SelectedCells.Count = 1 Then 'updates resident data
            Dim updatedResident As Resident = GetDetailData() 'get updated data
            Dim residentUpdated As Boolean = ResidentDB.UpdateResident(selectedResident, updatedResident)
            If residentUpdated Then
                dgResidents.Rows.Clear() 'clear master form
                residentList = ResidentDB.GetResidents()
                Me.LoadMasterForm()
                MessageBox.Show("Resident successfully updated.")
            Else
                MessageBox.Show("Unable to update resident.")
            End If
        ElseIf dgResidents.SelectedCells.Count = 0 Then 'adds new resident
            If ValidateDetailFields() Then
                Dim residentId As Integer = ResidentDB.AddResident(GetDetailData())
                If residentId > 0 Then
                    KeycardDB.AddKeycard(KeycardDB.GenerateNewKeycards(GetDetailData()), residentId)
                    KeycardDB.AddKeycard(KeycardDB.GenerateNewKeycards(GetDetailData()), residentId)
                    dgResidents.Rows.Clear() 'clear datagridview for updated table
                    residentList = ResidentDB.GetResidents() 'get updated table
                    Me.LoadMasterForm() 'reload datagridview with updated table
                    MessageBox.Show("Resident successfully added.")
                Else
                    MessageBox.Show("Unable to add resident.")
                End If
            Else
                MessageBox.Show("Input fields must have data.")
            End If

        End If
    End Sub

    Private Sub dgResidents_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgResidents.CellClick
        If e.RowIndex = -1 Then
            Exit Sub
        End If

        ' get resident id associated with row
        Dim dgResidentId As Integer = Convert.ToInt32(dgResidents.Item(0, e.RowIndex).Value)

        ' populate detail form
        For Each resident As Resident In residentList
            If resident.ResidentId = dgResidentId Then
                txtFirstName.Text = resident.FirstName
                txtLastName.Text = resident.LastName
                txtAddress.Text = resident.Address
                txtCity.Text = resident.City
                cboState.Text = resident.State
                txtZipCode.Text = resident.ZipCode
                dtpCalendar.Text = resident.DateEntered.ToString
                selectedResident = resident
                Exit For
            End If
        Next
    End Sub

    Private Sub btnClearFields_Click(sender As Object, e As EventArgs) Handles btnClearFields.Click
        dgResidents.ClearSelection()
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtAddress.Text = ""
        txtCity.Text = ""
        cboState.Text = ""
        cboState.SelectedIndex = -1
        txtZipCode.Text = ""
        dtpCalendar.Text = ""
    End Sub

    'helper functions
    Private Sub LoadMasterForm()
        dgResidents.ColumnCount = 3
        dgResidents.Columns(0).Name = "Resident ID"
        dgResidents.Columns(1).Name = "First Name"
        dgResidents.Columns(2).Name = "Last Name"

        ' populate master form
        For Each resident As Resident In residentList
            dgResidents.Rows.Add(resident.ResidentId, resident.FirstName, resident.LastName)
        Next
    End Sub

    Private Sub LoadStateComboBox()
        Dim path As String = "..\..\states.txt"
        Dim statesList As New List(Of State)
        Try
            Dim textIn As New StreamReader(
                New FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
            Do While textIn.Peek <> -1
                Dim row As String = textIn.ReadLine
                Dim columns() As String = row.Split(CChar(","))
                Dim state As New State
                state.StateAbbr = columns(0)
                state.StateName = columns(1)
                statesList.Add(state)
            Loop
            textIn.Close()
        Catch ex As FileNotFoundException
            MessageBox.Show(path & " not found.", "File Not Found")
        Catch ex As DirectoryNotFoundException
            MessageBox.Show("Directory not found.")
        Catch ex As IOException
            MessageBox.Show(ex.Message, "IOException")
        End Try

        cboState.DataSource = statesList
        cboState.DisplayMember = "StateAbbr"
        cboState.ValueMember = "StateName"
    End Sub

    Private Function GetDetailData() As Resident
        Dim resident As New Resident
        resident.FirstName = txtFirstName.Text
        resident.LastName = txtLastName.Text
        resident.Address = txtAddress.Text
        resident.City = txtCity.Text
        resident.State = cboState.Text
        resident.ZipCode = txtZipCode.Text
        resident.DateEntered = Convert.ToDateTime(dtpCalendar.Text)
        Return resident
    End Function

    Private Function ValidateDetailFields() As Boolean
        If txtFirstName.Text = "" AndAlso
           txtLastName.Text = "" AndAlso
           txtAddress.Text = "" AndAlso
           txtCity.Text = "" AndAlso
           cboState.Text = "" AndAlso
           txtZipCode.Text = "" AndAlso
           dtpCalendar.Text = "" Then

            Return False
        Else
            Return True
        End If
    End Function

End Class
