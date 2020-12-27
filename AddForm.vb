Public Class AddForm
	Private udfunc As New UDFunction()
	Private eventId As Integer

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
	Private Sub clear()
		Try
			txtName.Text = ""
			txtStuID.Text = ""
			txtICNum.Text = ""
			comProgCode.SelectedIndex = 0
		Catch ex As Exception
			MessageBox.Show(
				ex.Message,
				"Exception Message",
				MessageBoxButtons.OK,
				MessageBoxIcon.Error)
		End Try
	End Sub
	Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
		Close()
	End Sub

	Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
		Try
			If String.IsNullOrEmpty(txtName.Text) Or String.IsNullOrEmpty(txtStuID.Text) Or String.IsNullOrEmpty(txtICNum.Text) Then
				MessageBox.Show(
					"Form is not completed!",
					"Alert",
					MessageBoxButtons.OK,
					MessageBoxIcon.Exclamation)
			Else
				If udfunc.InsertParticipant(txtName.Text, CInt(txtStuID.Text), txtICNum.Text, comProgCode.SelectedValue, eventId) Then
					MessageBox.Show(
					"Participant Successfully Added.",
					"Process Completed",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information)
					clear()
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

	Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Try
			udfunc.DbConn()
			comProgCode.DataSource = udfunc.SelectAll("program")
			comProgCode.ValueMember = "program_code"
			comProgCode.DisplayMember = "program_name"
		Catch ex As Exception
			MessageBox.Show(ex.Message)
		End Try
	End Sub

	Private Sub TxtICNum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtICNum.KeyPress
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