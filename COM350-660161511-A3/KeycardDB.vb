Imports System.Data.SqlClient

Public Class KeycardDB

    Public Shared Function PopulateHistoryForm(residentId As Integer) As List(Of Keycard)
        Dim keycardList As New List(Of Keycard)
        Dim sqlQuery As String =
            "SELECT CardNumber, ResidentId, IssueDate, IsActive, IsDefault, Amount " &
            "FROM Keycard " &
            "WHERE ResidentId = @ResidentId"
        Using sqlConnection As SqlConnection = ColemanDevDB.GetConnection()
            sqlConnection.Open()
            Using sqlCommand As SqlCommand = New SqlCommand(sqlQuery, sqlConnection)
                sqlCommand.Parameters.Add("@ResidentId", SqlDbType.Int).Value = residentId
                Dim reader As SqlDataReader = sqlCommand.ExecuteReader()
                While reader.Read()
                    Dim keycard As New Keycard
                    keycard.CardNumber = reader("CardNumber").ToString
                    keycard.ResidentId = Convert.ToInt32(reader("ResidentId"))
                    keycard.IssueDate = Convert.ToDateTime(reader("IssueDate"))
                    keycard.IsActive = Convert.ToBoolean(reader("IsActive"))
                    keycard.IsDefault = Convert.ToBoolean(reader("IsDefault"))
                    keycard.Amount = Convert.ToDecimal(reader("Amount"))
                    keycardList.Add(keycard)
                End While
                reader.Close()
            End Using
        End Using
        Return keycardList
    End Function

    Public Shared Function GenerateNewKeycards(resident As Resident) As Keycard
        Dim keycardList As List(Of Keycard) = GetKeycardList()
        Dim newKeycard As New Keycard
        Dim generatedCardNumber As String = GenerateCardNumber()

        'generate unique card number
        For Each keycard In keycardList
            If keycard.CardNumber = generatedCardNumber Then
                generatedCardNumber = GenerateCardNumber()
            Else
                Exit For
            End If
        Next

        newKeycard.CardNumber = generatedCardNumber
        newKeycard.ResidentId = resident.ResidentId
        newKeycard.IssueDate = DateTime.Today
        newKeycard.IsActive = True
        newKeycard.IsDefault = True
        newKeycard.Amount = 0D
        Return newKeycard
    End Function

    Private Shared Function GenerateCardNumber() As String
        Dim chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim stringChars = New Char(7) {}
        Dim random = New Random()

        For i As Integer = 0 To stringChars.Length - 1
            stringChars(i) = chars(random.[Next](chars.Length))
        Next

        Return New [String](stringChars)
    End Function

    Private Shared Function GetKeycardList() As List(Of Keycard)
        Dim keycardList As New List(Of Keycard)
        Dim sqlQuery As String =
            "SELECT CardNumber, ResidentId, IssueDate, IsActive, IsDefault, Amount " &
            "FROM Keycard"
        Using sqlConnection As SqlConnection = ColemanDevDB.GetConnection()
            sqlConnection.Open()
            Using sqlCommand As SqlCommand = New SqlCommand(sqlQuery, sqlConnection)
                sqlCommand.CommandType = CommandType.Text
                Dim reader As SqlDataReader = sqlCommand.ExecuteReader()
                While reader.Read()
                    Dim keycard As New Keycard
                    keycard.CardNumber = reader("CardNumber").ToString
                    keycard.ResidentId = Convert.ToInt32(reader("ResidentId"))
                    keycard.IssueDate = Convert.ToDateTime(reader("IssueDate"))
                    keycard.IsActive = Convert.ToBoolean(reader("IsActive"))
                    keycard.IsDefault = Convert.ToBoolean(reader("IsDefault"))
                    keycard.Amount = Convert.ToDecimal(reader("Amount"))
                    keycardList.Add(keycard)
                End While
                reader.Close()
            End Using
        End Using
        Return keycardList
    End Function

    Public Shared Function AddKeycard(keycard As Keycard, residentId As Integer) As Boolean
        Dim sqlQuery As String =
            "INSERT INTO Keycard " &
            "(CardNumber, ResidentId, IssueDate, IsActive, IsDefault, Amount) " &
            "VALUES (@CardNumber, @ResidentId, @IssueDate, @IsActive, @IsDefault, @Amount)"

        Using sqlConnection As SqlConnection = ColemanDevDB.GetConnection
            sqlConnection.Open()
            Using sqlCommand As SqlCommand = New SqlCommand(sqlQuery, sqlConnection)
                sqlCommand.Parameters.Add("@CardNumber", SqlDbType.VarChar, 12).Value = keycard.CardNumber
                sqlCommand.Parameters.Add("@ResidentId", SqlDbType.Int).Value = residentId
                sqlCommand.Parameters.Add("@IssueDate", SqlDbType.DateTime).Value = keycard.IssueDate
                sqlCommand.Parameters.Add("@IsActive", SqlDbType.Bit).Value = keycard.IsActive
                sqlCommand.Parameters.Add("@IsDefault", SqlDbType.Bit).Value = keycard.IsDefault
                sqlCommand.Parameters.Add("@Amount", SqlDbType.Decimal).Value = keycard.Amount
                If sqlCommand.ExecuteNonQuery() > 0 Then
                    Return True
                End If
            End Using
        End Using
        Return False
    End Function

End Class
