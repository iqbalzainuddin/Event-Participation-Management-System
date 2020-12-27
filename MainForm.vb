Public Class MainForm
	Private HomeForm As New HomeForm()
	Private udfunc As New UDFunction()
	Private LoginForm As New LoginForm()
	Public Sub loadback()
		Try
			ComboBoxEvent.DataSource = udfunc.SelectAll("events")
			ComboBoxEvent.ValueMember = "event_id"
			ComboBoxEvent.DisplayMember = "event_name"

			radNewEvent.Checked = True

		Catch ex As Exception
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
		End Try
	End Sub
	Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
		Try
			If radNewEvent.Checked Then
				CreateForm.ShowDialog()
			ElseIf radExistEvent.Checked Then
				If IsNothing(ComboBoxEvent.SelectedItem) Then
					MessageBox.Show("No Event in Database!!",
						"Alert",
						MessageBoxButtons.OK,
						MessageBoxIcon.Exclamation)
				Else
					HomeForm.SetEventID(ComboBoxEvent.SelectedValue)
					HomeForm.Loading()
					HomeForm.Label1.Text = ComboBoxEvent.Text
					HomeForm.Show()
					Hide()
				End If
			End If
		Catch ex As Exception
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
		End Try
	End Sub

	'Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
	'	Try
	'		udfunc.DBClose()
	'		Close()
	'	Catch ex As Exception
	'		MessageBox.Show(
	'			ex.Message,
	'			"Exception Message",
	'			MessageBoxButtons.OK,
	'			MessageBoxIcon.Error)
	'	End Try
	'End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Try
			loadback()
		Catch ex As Exception
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
		End Try
	End Sub
	Private Sub RadExistEvent_CheckedChanged(sender As Object, e As EventArgs) Handles radExistEvent.CheckedChanged
		Try
			ComboBoxEvent.Enabled = True
		Catch ex As Exception
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
		End Try
	End Sub

	Private Sub RadNewEvent_CheckedChanged(sender As Object, e As EventArgs) Handles radNewEvent.CheckedChanged
		Try
			ComboBoxEvent.Enabled = False
		Catch ex As Exception
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
		End Try
	End Sub

	Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
		loadback()
	End Sub

	Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
		Try
			Close()
			LoginForm.Visible = True
			LoginForm.ClearPin()
		Catch ex As Exception
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
		End Try
	End Sub

	Private Sub ChangePasswordToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ChangePasswordToolStripMenuItem1.Click
		ChangePWForm.ShowDialog()
	End Sub
End Class
