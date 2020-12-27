Imports MySql.Data.MySqlClient

Public Class UDFunction
	Private mySqlConn As MySqlConnection
	Private Query As String
	Private Command As MySqlCommand
	Private Reader As MySqlDataReader
	Private Adapter As MySqlDataAdapter
	Private Dt As DataTable
	Private Ds As DataSet
	Public Sub DbConn()
		Try
			mySqlConn = New MySqlConnection
			mySqlConn.ConnectionString = "server=localhost; userid=root; password=mY8iN6O@0105; database=participation"
			mySqlConn.Open()
		Catch ex As Exception
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
		End Try
	End Sub

	Public Sub DBClose()
		If Reader.HasRows() Then
			Reader.Close()
		End If
		mySqlConn.Close()
	End Sub

	Public Function SelectAll(ByVal table As String) As DataTable
		Try
			DbConn()
			Query = $"select * from {table}"
			Command = New MySqlCommand(Query, mySqlConn)
			Reader = Command.ExecuteReader
			Dt = New DataTable
			Dt.Load(Reader)
			DBClose()

			Return Dt
		Catch ex As Exception
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
			Return Nothing
		End Try
	End Function
	Public Function SelectAllbyEvent(ByVal table As String, ByVal id As Integer) As DataTable
		Try
			DbConn()
			Query = $"select par_name,par_matrixno,par_icnum,program_code,par_attend from {table} where event_id={id}"
			Command = New MySqlCommand(Query, mySqlConn)
			Reader = Command.ExecuteReader
			Dt = New DataTable
			Dt.Load(Reader)
			DBClose()

			Return Dt
		Catch ex As Exception
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
			Return Nothing
		End Try
	End Function
	Public Function CountTotalParticipant(ByVal table As String, ByVal id As Integer) As Integer
		Try
			DbConn()
			Query = $"select par_name,par_matrixno,par_icnum,program_code,par_attend from {table} where event_id={id}"
			Command = New MySqlCommand(Query, mySqlConn)
			Reader = Command.ExecuteReader
			Dt = New DataTable
			Dt.Load(Reader)
			DBClose()

			Return Dt.Rows.Count
		Catch ex As Exception
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
			Return Nothing
		End Try
	End Function
	Public Function CountTotalAttend(ByVal table As String, ByVal id As Integer) As Integer
		Try
			DbConn()
			Query = $"select par_name,par_matrixno,par_icnum,program_code,par_attend from {table} where event_id={id} and par_attend='YES'"
			Command = New MySqlCommand(Query, mySqlConn)
			Reader = Command.ExecuteReader
			Dt = New DataTable
			Dt.Load(Reader)
			DBClose()

			Return Dt.Rows.Count
		Catch ex As Exception
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
			Return Nothing
		End Try
	End Function
	Public Function CountTotalAbsent(ByVal table As String, ByVal id As Integer) As Integer
		Try
			DbConn()
			Query = $"select par_name,par_matrixno,par_icnum,program_code,par_attend from {table} where event_id={id} and par_attend='NO'"
			Command = New MySqlCommand(Query, mySqlConn)
			Reader = Command.ExecuteReader
			Dt = New DataTable
			Dt.Load(Reader)
			DBClose()

			Return Dt.Rows.Count
		Catch ex As Exception
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
			Return Nothing
		End Try
	End Function
	Public Function InsertEvent(ByVal eventName As String) As Boolean
		Try
			DbConn()
			Query = $"INSERT INTO events(event_name) VALUES ('{eventName}')"
			Command = New MySqlCommand(Query, mySqlConn)
			Command.ExecuteNonQuery()
			'DBClose()

			Return True
		Catch ex As Exception
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
			Return False
		End Try
	End Function

	Public Function InsertParticipant(ByVal name As String, ByVal matrix As Integer, ByVal ic As String, ByVal code As String, ByVal eventID As Integer) As Boolean
		Try
			DbConn()
			Query = $"select * from participant where par_matrixno={matrix} or par_icnum={ic} and event_id={eventID}"
			Command = New MySqlCommand(Query, mySqlConn)
			Reader = Command.ExecuteReader

			If Reader.HasRows Then
				DBClose()
				MessageBox.Show(
				"IC Number/Student ID have been registered for this event.",
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Exclamation)

				Return False
			Else
				DBClose()
				DbConn()
				Query = $"INSERT INTO participant(par_name, par_matrixno, par_icnum, program_code, event_id) VALUES ('{name}', '{matrix}', '{ic}', '{code}', '{eventID}')"
				Command = New MySqlCommand(Query, mySqlConn)
				Command.ExecuteNonQuery()

				Return True
			End If
		Catch ex As Exception
			DBClose()
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
			Return False
		End Try
	End Function

	Public Function Attend(ByVal eventID As Integer, ByVal matrix As Integer) As Boolean
		Try
			DbConn()
			Query = $"select * from participant where par_matrixno={matrix} and event_id={eventID}"
			Command = New MySqlCommand(Query, mySqlConn)
			Reader = Command.ExecuteReader

			If Reader.HasRows Then
				DBClose()
				DbConn()
				Query = $"UPDATE participant SET par_attend='YES' WHERE par_matrixno={matrix} and event_id={eventID}"
				Command = New MySqlCommand(Query, mySqlConn)
				Command.ExecuteNonQuery()

				Return True
			Else
				DBClose()
				MessageBox.Show(
				"IC Number/Student ID is not registered for this event.",
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Exclamation)

				Return False
			End If
		Catch ex As Exception
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
			Return False
		End Try
	End Function
	Public Function EndEvent(ByVal eventID As Integer) As Boolean
		Try
			DbConn()
			Query = $"select * from events where event_id={eventID}"
			Command = New MySqlCommand(Query, mySqlConn)
			Reader = Command.ExecuteReader

			If Reader.HasRows Then
				DBClose()
				DbConn()
				Query = $"UPDATE events SET event_end='YES' WHERE event_id={eventID}"
				Command = New MySqlCommand(Query, mySqlConn)
				Command.ExecuteNonQuery()

				Return True
			Else
				DBClose()
				MessageBox.Show(
				"Unexpected Error Has Occured.",
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Exclamation)

				Return False
			End If
		Catch ex As Exception
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
			Return False
		End Try
	End Function
	Public Function CheckEventEnd(ByVal id As Integer) As Boolean
		Try
			DbConn()
			Query = $"select * from events where event_id={id} and event_end='NO'"
			Command = New MySqlCommand(Query, mySqlConn)
			Reader = Command.ExecuteReader
			Dt = New DataTable
			Dt.Load(Reader)
			DBClose()

			If Dt.Rows.Count = 0 Then
				Return True
			Else
				Return False
			End If
		Catch ex As Exception
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
			Return True
		End Try
	End Function

	Public Function DeleteEvent(ByVal eventId As Integer) As Boolean
		Try
			DbConn()
			Query = $"DELETE FROM events WHERE event_id={eventId}"
			Command = New MySqlCommand(Query, mySqlConn)
			Command.ExecuteNonQuery()

			Query = $"DELETE FROM participant WHERE event_id={eventId}"
			Command = New MySqlCommand(Query, mySqlConn)
			Command.ExecuteNonQuery()

			Return True
		Catch ex As Exception
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
			Return False
		End Try
	End Function

	Public Function Login(ByVal pin As String) As Boolean
		Try
			DbConn()
			Query = $"select * from pin where pin={pin}"
			Command = New MySqlCommand(Query, mySqlConn)
			Reader = Command.ExecuteReader

			If Reader.HasRows Then
				DBClose()
				Return True
			Else
				DBClose()
				MessageBox.Show(
						"Wrong Pin",
						"Error Message",
						MessageBoxButtons.OK,
						MessageBoxIcon.Exclamation)
				Return False
			End If
		Catch ex As Exception
			DBClose()
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
			Return False
		End Try
	End Function
	Public Function ChangePIN(ByVal old As String, ByVal newPin As String) As Boolean
		Try
			DbConn()
			Query = $"select * from pin where pin={old}"
			Command = New MySqlCommand(Query, mySqlConn)
			Reader = Command.ExecuteReader

			If Reader.HasRows Then
				DBClose()
				DbConn()
				Query = $"UPDATE pin SET pin={newPin} WHERE pin={old}"
				Command = New MySqlCommand(Query, mySqlConn)
				Command.ExecuteNonQuery()

				Return True
			Else
				DBClose()
				MessageBox.Show(
				"Wrong Current PIN.",
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Exclamation)

				Return False
			End If
		Catch ex As Exception
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
			Return False
		End Try
	End Function
End Class
