Public Class CreateForm
	Private udfunc As New UDFunction()
	Private HomeForm As New HomeForm()
	Private MainForm As New MainForm()
	Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
		Close()
	End Sub

	Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
		Try
			If udfunc.InsertEvent(txtNewEvent.Text) Then
				MainForm.loadback()
				'MainForm.Hide()
				Close()
				'HomeForm.SetEventID
				'HomeForm.Label1.Text = txtNewEvent.Text
				'HomeForm.Show()
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