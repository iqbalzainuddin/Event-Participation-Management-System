Public Class LoginForm
	Private UDfunc As New UDFunction()
	Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
		If UDfunc.Login(txtPin.Text) Then
			Hide()
			MainForm.Show()
		End If
	End Sub

	Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		ClearPin()
	End Sub

	Public Sub ClearPin()
		txtPin.Clear()
	End Sub

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
		Try
			Application.Exit()
		Catch ex As Exception
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
		End Try
	End Sub

	Private Sub txtPin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPin.KeyPress
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