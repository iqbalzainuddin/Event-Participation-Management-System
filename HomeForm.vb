Public Class HomeForm
	Private eventId As Integer
	Private InfoForm As New InfoForm()
	Private UdFunc As New UDFunction()
	Public Sub Loading()
		Try
			If UdFunc.CheckEventEnd(eventId) Then
				btnAddPart.Enabled = False
				btnAttendance.Enabled = False
				btnEndEvent.Enabled = False
			Else
				btnAddPart.Enabled = True
				btnAttendance.Enabled = True
				btnEndEvent.Enabled = True
			End If
		Catch ex As Exception
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
		End Try
	End Sub
	Public Sub SetEventID(ByVal id As Integer)
		Try
			eventId = id
		Catch ex As Exception
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
		End Try
	End Sub
	Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
		Try
			Hide()
			MainForm.Visible = True
		Catch ex As Exception
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
		End Try
	End Sub

	Private Sub BtnDelEvent_Click(sender As Object, e As EventArgs) Handles btnDelEvent.Click
		Try
			If UdFunc.DeleteEvent(eventId) Then
				MessageBox.Show(
						"Event Deleted.",
						"Process Completed",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information)

				Hide()
				MainForm.loadback()
				MainForm.Visible = True
				MainForm.loadback()
			End If
		Catch ex As Exception
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
		End Try
	End Sub

	Private Sub BtnEndEvent_Click(sender As Object, e As EventArgs) Handles btnEndEvent.Click
		Try
			If UdFunc.EndEvent(eventId) Then
				MessageBox.Show(
						"Event Ended.",
						"Process Completed",
						MessageBoxButtons.OK,
						MessageBoxIcon.Information)
				Loading()
			End If
		Catch ex As Exception
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
		End Try
	End Sub

	Private Sub BtnAddPart_Click(sender As Object, e As EventArgs) Handles btnAddPart.Click
		Try
			AddForm.SetEventID(eventId)
			AddForm.ShowDialog()
		Catch ex As Exception
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
		End Try
	End Sub

	Private Sub BtnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click
		Try
			AttendForm.SetEventID(eventId)
			AttendForm.ShowDialog()
		Catch ex As Exception
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
		End Try
	End Sub

	Private Sub BtnInfo_Click(sender As Object, e As EventArgs) Handles btnInfo.Click
		Try
			InfoForm.SetEventID(eventId)
			InfoForm.ShowDialog()
		Catch ex As Exception
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
		End Try
	End Sub

	Private Sub HomeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Loading()
	End Sub
End Class