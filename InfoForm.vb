Public Class InfoForm
	Private UdFunc As New UDFunction()
	Private EventID As Integer
	Public Sub SetEventID(ByVal Id As Integer)
		EventID = Id
	End Sub
	Private Sub Loading()
		With dgvParticipantList
			.DataSource = UdFunc.SelectAllbyEvent("participant", EventID)
			.Columns(0).HeaderText = "Name"
			.Columns(0).Width = 320
			.Columns(1).HeaderText = "Student ID"
			.Columns(2).HeaderText = "IC Number"
			.Columns(3).HeaderText = "Program Code"
			.Columns(3).Width = 60
			.Columns(4).HeaderText = "Attend?"
			.Columns(4).Width = 50
		End With

		With lblTotalParticipant
			.Text = UdFunc.CountTotalParticipant("participant", EventID)
			.TextAlign = ContentAlignment.MiddleCenter
		End With

		With lblAttend
			.Text = UdFunc.CountTotalAttend("participant", EventID)
			.TextAlign = ContentAlignment.MiddleCenter
		End With

		With lblAbsent
			.Text = UdFunc.CountTotalAbsent("participant", EventID)
			.TextAlign = ContentAlignment.MiddleCenter
		End With
	End Sub
	Private Sub InfoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Loading()
	End Sub

	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
		Close()
	End Sub
End Class