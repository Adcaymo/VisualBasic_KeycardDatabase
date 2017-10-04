Public Class frmHistory

    Private keycardList As List(Of Keycard)

    Private Sub frmHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgKeycards.DataSource = Nothing
        dgKeycards.Columns.Clear()
        keycardList = KeycardDB.PopulateHistoryForm(Convert.ToInt32(frmResidents.Tag))
        Me.LoadMasterForm()
    End Sub

    Private Sub LoadMasterForm()
        dgKeycards.ColumnCount = 6
        dgKeycards.Columns(0).Name = "Card Number"
        dgKeycards.Columns(1).Name = "Resident ID"
        dgKeycards.Columns(2).Name = "Issue Date"
        dgKeycards.Columns(3).Name = "Is Active"
        dgKeycards.Columns(4).Name = "Is Default"
        dgKeycards.Columns(5).Name = "Amount"

        For Each keycard As Keycard In keycardList
            dgKeycards.Rows.Add(keycard.CardNumber, keycard.ResidentId, keycard.IssueDate,
                                keycard.IsActive, keycard.IsDefault, keycard.Amount)
        Next
    End Sub
End Class