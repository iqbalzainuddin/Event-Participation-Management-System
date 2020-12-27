Public Class ChangePWForm
	Private UDfunc As New UDFunction()
	Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
		Close()
	End Sub

	Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
		Try
			If UDfunc.ChangePIN(txtCurrent.Text, txtNew.Text) Then
				MessageBox.Show(
					"PIN Changed.",
					"Process Completed",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information)
				Close()
			End If
		Catch ex As Exception
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
		End Try
	End Sub

	Private Sub txtCurrent_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCurrent.KeyPress
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

	Private Sub txtNew_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNew.KeyPress
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