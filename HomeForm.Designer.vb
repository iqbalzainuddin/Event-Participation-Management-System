<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeForm
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeForm))
		Me.btnEndEvent = New System.Windows.Forms.Button()
		Me.btnDelEvent = New System.Windows.Forms.Button()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.btnAddPart = New System.Windows.Forms.Button()
		Me.btnAttendance = New System.Windows.Forms.Button()
		Me.btnInfo = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'btnEndEvent
		'
		Me.btnEndEvent.BackColor = System.Drawing.Color.Cyan
		Me.btnEndEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnEndEvent.Location = New System.Drawing.Point(211, 401)
		Me.btnEndEvent.Name = "btnEndEvent"
		Me.btnEndEvent.Size = New System.Drawing.Size(120, 28)
		Me.btnEndEvent.TabIndex = 0
		Me.btnEndEvent.Text = "End Event"
		Me.btnEndEvent.UseVisualStyleBackColor = False
		'
		'btnDelEvent
		'
		Me.btnDelEvent.BackColor = System.Drawing.Color.Cyan
		Me.btnDelEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnDelEvent.Location = New System.Drawing.Point(337, 401)
		Me.btnDelEvent.Name = "btnDelEvent"
		Me.btnDelEvent.Size = New System.Drawing.Size(120, 28)
		Me.btnDelEvent.TabIndex = 1
		Me.btnDelEvent.Text = "Delete Event"
		Me.btnDelEvent.UseVisualStyleBackColor = False
		'
		'btnClose
		'
		Me.btnClose.BackColor = System.Drawing.Color.Cyan
		Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnClose.Location = New System.Drawing.Point(463, 401)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(120, 28)
		Me.btnClose.TabIndex = 2
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = False
		'
		'btnAddPart
		'
		Me.btnAddPart.BackgroundImage = Global.Event_Participation_Management_System.My.Resources.Resources.add
		Me.btnAddPart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnAddPart.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnAddPart.ForeColor = System.Drawing.Color.Cyan
		Me.btnAddPart.Location = New System.Drawing.Point(49, 81)
		Me.btnAddPart.Name = "btnAddPart"
		Me.btnAddPart.Size = New System.Drawing.Size(229, 229)
		Me.btnAddPart.TabIndex = 3
		Me.btnAddPart.Text = "Add Participant"
		Me.btnAddPart.UseVisualStyleBackColor = True
		'
		'btnAttendance
		'
		Me.btnAttendance.BackgroundImage = Global.Event_Participation_Management_System.My.Resources.Resources.attend
		Me.btnAttendance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnAttendance.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnAttendance.ForeColor = System.Drawing.Color.Cyan
		Me.btnAttendance.Location = New System.Drawing.Point(284, 81)
		Me.btnAttendance.Name = "btnAttendance"
		Me.btnAttendance.Size = New System.Drawing.Size(229, 229)
		Me.btnAttendance.TabIndex = 4
		Me.btnAttendance.Text = "Attendance"
		Me.btnAttendance.UseVisualStyleBackColor = True
		'
		'btnInfo
		'
		Me.btnInfo.BackgroundImage = Global.Event_Participation_Management_System.My.Resources.Resources.info
		Me.btnInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.btnInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnInfo.ForeColor = System.Drawing.Color.Cyan
		Me.btnInfo.Location = New System.Drawing.Point(519, 81)
		Me.btnInfo.Name = "btnInfo"
		Me.btnInfo.Size = New System.Drawing.Size(229, 229)
		Me.btnInfo.TabIndex = 5
		Me.btnInfo.Text = "Participation Information"
		Me.btnInfo.UseVisualStyleBackColor = True
		'
		'Label1
		'
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.Cyan
		Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label1.Location = New System.Drawing.Point(48, 31)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(700, 24)
		Me.Label1.TabIndex = 6
		Me.Label1.Text = "<Event Name>"
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'HomeForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.Event_Participation_Management_System.My.Resources.Resources.background
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.btnInfo)
		Me.Controls.Add(Me.btnAttendance)
		Me.Controls.Add(Me.btnAddPart)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.btnDelEvent)
		Me.Controls.Add(Me.btnEndEvent)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "HomeForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Event Participation Manager"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents btnEndEvent As Button
	Friend WithEvents btnDelEvent As Button
	Friend WithEvents btnClose As Button
	Friend WithEvents btnAddPart As Button
	Friend WithEvents btnAttendance As Button
	Friend WithEvents btnInfo As Button
	Friend WithEvents Label1 As Label
End Class
