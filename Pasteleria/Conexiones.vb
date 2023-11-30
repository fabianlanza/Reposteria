Imports System.Data.SqlClient

Module Conexion
    'LAPTOP-S8ASBQKS
    'DESKTOP-AND27IO\SQL
    Public connect As New SqlConnection("Data Source=LAPTOP-S8ASBQKS;Initial Catalog=SistemaPasteleria;Integrated Security=True")

    Sub OpenConnection()
        If connect.State = 0 Then
            connect.Open()
        End If
    End Sub

    Sub CloseConnection()
        If connect.State = 1 Then
            connect.Close()
        End If
    End Sub



    Public Sub LoadData(dgv As DataGridView, table As String)

        Try
            OpenConnection()
            Dim cmd As New SqlCommand("Select * from " & table, connect)
            Dim da As New SqlDataAdapter()
            da.SelectCommand = cmd
            Dim dt As New DataTable()
            da.Fill(dt)
            dgv.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Unable to load data")
        Finally
            CloseConnection()
        End Try

    End Sub


    Public Sub InsertIntoTable(table As String, values As String)
        Dim query As String = $"Insert into {table} values ({values})"

        Using cmd As New SqlCommand(query, connect)
            Try
                OpenConnection()

                Dim paramValues() As String = values.Split(",")

                For i As Integer = 0 To paramValues.Length - 1
                    cmd.Parameters.AddWithValue($"@param{i}", paramValues(i).Trim())
                Next

                ' Execute the query with parameters
                cmd.CommandText = query
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error inserting data: " & ex.Message)
            Finally
                CloseConnection()
            End Try
        End Using
    End Sub




    '-------!!-----

    Public Sub DeleteFromTable(table As String, condition As String, value As String)
        Dim query As String = $"Delete From {table} where {condition} = {value}"

        Using cmd As New SqlCommand(query, connect)
            Try
                OpenConnection()
                cmd.ExecuteNonQuery()

            Catch ex As Exception
                MessageBox.Show("Error inserting data: " & ex.Message)
            Finally
                CloseConnection()
            End Try
        End Using

    End Sub







    'Public Sub ModificarDatos(table As String, newValue1 As String, newValue2 As String, newValue3 As String, employeeId As String)



    'Dim query As String = $"UPDATE {table} SET Column1 = @newValue1, Column2 = @newValue2, Column3 = @newValue3 WHERE EmployeeIDColumn = @employeeId"


    'Using cmd As New SqlCommand(query, connect)
    '       cmd.Parameters.AddWithValue("@newValue1", newValue1)
    '      cmd.Parameters.AddWithValue("@newValue2", newValue2)
    '     cmd.Parameters.AddWithValue("@newValue3", newValue3)
    '    cmd.Parameters.AddWithValue("@employeeId", employeeId)

    'Try
    '            connect.Open()
    '            cmd.ExecuteNonQuery()
    'Catch ex As Exception
    '           MessageBox.Show("Error updating data: " & ex.Message)
    'Finally
    '           connect.Close()
    'End Try
    'End Using
    'End Sub



    '------------Jared------------
    Public Sub UpdateTable(table As String, column As String, value As String, condition As String)

        Dim query As String = $"UPDATE {table} SET {column} = {value} WHERE {condition}"

        Using cmd As New SqlCommand(query, connect)
            'cmd.Parameters.AddWithValue("@newValue1", newValue1)
            'cmd.Parameters.AddWithValue("@newValue2", newValue2)
            'cmd.Parameters.AddWithValue("@newValue3", newValue3)
            'cmd.Parameters.AddWithValue("@employeeId", column)

            Try
                OpenConnection()

                Dim paramCol() As String = column.Split(",")
                For i As Integer = 0 To paramCol.Length - 1
                    cmd.Parameters.AddWithValue($"@param{i}", paramCol(i).Trim())
                Next

                Dim paramValue() As String = value.Split(",")
                For i As Integer = 0 To paramValue.Length - 1
                    cmd.Parameters.AddWithValue($"@param{i}", paramValue(i).Trim())
                Next


                cmd.CommandText = query
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error updating data: " & ex.Message)
            Finally
                CloseConnection()
            End Try
        End Using
    End Sub






End Module