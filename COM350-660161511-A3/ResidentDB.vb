Imports System.Data.SqlClient

Public Class ResidentDB

    Public Shared Function GetResidents() As List(Of Resident)
        Dim residentList As New List(Of Resident)
        Dim sqlQuery As String =
            "SELECT ResidentId, FirstName, LastName, Address, City, State, ZipCode, DateEntered " &
            "FROM Resident"
        Using sqlConnection As SqlConnection = ColemanDevDB.GetConnection()
            sqlConnection.Open()
            Using sqlCommand As SqlCommand = New SqlCommand(sqlQuery, sqlConnection)
                sqlCommand.CommandType = CommandType.Text
                Dim reader As SqlDataReader = sqlCommand.ExecuteReader()
                While reader.Read()
                    Dim resident As New Resident
                    resident.ResidentId = Convert.ToInt32(reader("ResidentId"))
                    resident.FirstName = reader("FirstName").ToString
                    resident.LastName = reader("LastName").ToString
                    resident.Address = reader("Address").ToString
                    resident.City = reader("City").ToString
                    resident.State = reader("State").ToString
                    resident.ZipCode = reader("ZipCode").ToString
                    'resident.DateEntered = CDate(reader("DateEntered"))
                    resident.DateEntered = Convert.ToDateTime(reader("DateEntered"))
                    residentList.Add(resident)
                End While
                reader.Close()
            End Using
        End Using
        Return residentList
    End Function

    Public Shared Function UpdateResident(oldResident As Resident,
            newResident As Resident) As Boolean
        Dim sqlQuery As String =
            "UPDATE Resident SET " &
            "FirstName = @NewFirstName, " &
            "LastName = @NewLastName, " &
            "Address = @NewAddress, " &
            "City = @NewCity, " &
            "State = @NewState, " &
            "ZipCode = @NewZipCode, " &
            "DateEntered = @NewDateEntered " &
            "WHERE ResidentId = @OldResidentId " &
            "AND FirstName = @OldFirstName " &
            "AND LastName = @OldLastName " &
            "AND Address = @OldAddress " &
            "AND City = @OldCity " &
            "AND State = @OldState " &
            "AND ZipCode = @OldZipCode " &
            "AND DateEntered = @OldDateEntered"
        Using sqlConnection As SqlConnection = ColemanDevDB.GetConnection
            sqlConnection.Open()
            Using sqlCommand As SqlCommand = New SqlCommand(sqlQuery, sqlConnection)
                sqlCommand.Parameters.Add("@OldFirstName", SqlDbType.VarChar, 32).Value = oldResident.FirstName
                sqlCommand.Parameters.Add("@OldLastName", SqlDbType.VarChar, 32).Value = oldResident.LastName
                sqlCommand.Parameters.Add("@OldAddress", SqlDbType.VarChar, 255).Value = oldResident.Address
                sqlCommand.Parameters.Add("@OldCity", SqlDbType.VarChar, 64).Value = oldResident.City
                sqlCommand.Parameters.Add("@OldState", SqlDbType.VarChar, 2).Value = oldResident.State
                sqlCommand.Parameters.Add("@OldZipCode", SqlDbType.VarChar, 12).Value = oldResident.ZipCode
                sqlCommand.Parameters.Add("@OldDateEntered", SqlDbType.DateTime).Value = oldResident.DateEntered
                sqlCommand.Parameters.Add("@OldResidentId", SqlDbType.Int).Value = oldResident.ResidentId
                sqlCommand.Parameters.Add("@NewFirstName", SqlDbType.VarChar, 32).Value = newResident.FirstName
                sqlCommand.Parameters.Add("@NewLastName", SqlDbType.VarChar, 32).Value = newResident.LastName
                sqlCommand.Parameters.Add("@NewAddress", SqlDbType.VarChar, 255).Value = newResident.Address
                sqlCommand.Parameters.Add("@NewCity", SqlDbType.VarChar, 64).Value = newResident.City
                sqlCommand.Parameters.Add("@NewState", SqlDbType.VarChar, 2).Value = newResident.State
                sqlCommand.Parameters.Add("@NewZipCode", SqlDbType.VarChar, 12).Value = newResident.ZipCode
                sqlCommand.Parameters.Add("@NewDateEntered", SqlDbType.DateTime).Value = newResident.DateEntered
                If sqlCommand.ExecuteNonQuery() > 0 Then
                    Return True
                End If
            End Using
        End Using
        Return False
    End Function

    Public Shared Function AddResident(resident As Resident) As Integer
        Dim sqlQuery As String =
            "INSERT INTO Resident " &
            "(FirstName, LastName, Address, City, State, ZipCode, DateEntered) " &
            "VALUES (@FirstName, @LastName, @Address, @City, @State, @ZipCode, @DateEntered); " &
            "SELECT SCOPE_IDENTITY() AS ResidentId"
        Using sqlConnection As SqlConnection = ColemanDevDB.GetConnection
            sqlConnection.Open()
            Using sqlCommand As SqlCommand = New SqlCommand(sqlQuery, sqlConnection)
                sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar, 32).Value = resident.FirstName
                sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar, 32).Value = resident.LastName
                sqlCommand.Parameters.Add("@Address", SqlDbType.VarChar, 255).Value = resident.Address
                sqlCommand.Parameters.Add("@City", SqlDbType.VarChar, 64).Value = resident.City
                sqlCommand.Parameters.Add("@State", SqlDbType.VarChar, 2).Value = resident.State
                sqlCommand.Parameters.Add("@ZipCode", SqlDbType.VarChar, 12).Value = resident.ZipCode
                sqlCommand.Parameters.Add("@DateEntered", SqlDbType.DateTime).Value = resident.DateEntered
                Return Convert.ToInt32(sqlCommand.ExecuteScalar())
            End Using
        End Using
    End Function

End Class
