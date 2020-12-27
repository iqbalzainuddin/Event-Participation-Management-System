Public Class AttendForm
	Private udfunc As New UDFunction()
	Private eventID As Integer

	Public Sub SetEventID(ByVal Id As Integer)
		Try
			eventID = Id
		Catch ex As Exception
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
		End Try
	End Sub
	Private Sub Clear()
		txtStuID.Text = ""
	End Sub
	Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
		Close()
	End Sub

	Private Sub BtnAttend_Click(sender As Object, e As EventArgs) Handles btnAttend.Click
		Try
			If udfunc.Attend(eventID, CInt(txtStuID.Text)) Then
				MessageBox.Show(
					"Attendance Verified.",
					"Process Completed",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information)
				Clear()
			End If
		Catch ex As Exception
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
		End Try
	End Sub

	Private Sub TxtStuID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtStuID.KeyPress
		Try
			If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) Then
				e.Handled = True
			End If
		Catch ex As Exception
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
		End Try
	End Sub
End Class