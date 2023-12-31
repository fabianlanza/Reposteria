﻿Imports System.Data.SqlClient

Module Conexion
    'LAPTOP-S8ASBQKS
    'DESKTOP-AND27IO\SQL
    Public connect As New SqlConnection("Data Source=DESKTOP-AND27IO\SQL;Initial Catalog=SistemaPasteleria;Integrated Security=True")

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
            MessageBox.Show("Unable to load data: " & ex.Message)
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



    Public Sub UpdateTable(query As String)

        Using cmd As New SqlCommand(query, connect)
            Try
                OpenConnection()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            Finally
                CloseConnection()
            End Try
        End Using

    End Sub


    Public Sub ResetIdentity(table As String, column As String)

        Try
            Using cmd As New SqlCommand($"DBCC CHECKIDENT ('{table}', RESEED, 0)", connect)
                OpenConnection()
                cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MessageBox.Show("Error resetting identity: " & ex.Message)
        Finally
            CloseConnection()
        End Try
    End Sub






End Module