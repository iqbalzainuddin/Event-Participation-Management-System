<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InfoForm
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InfoForm))
		Me.dgvParticipantList = New System.Windows.Forms.DataGridView()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.lblTotalParticipant = New System.Windows.Forms.Label()
		Me.lblAttend = New System.Windows.Forms.Label()
		Me.lblAbsent = New System.Windows.Forms.Label()
		CType(Me.dgvParticipantList, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'dgvParticipantList
		'
		Me.dgvParticipantList.AllowUserToAddRows = False
		Me.dgvParticipantList.AllowUserToDeleteRows = False
		Me.dgvParticipantList.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.dgvParticipantList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.dgvParticipantList.Location = New System.Drawing.Point(41, 46)
		Me.dgvParticipantList.Name = "dgvParticipantList"
		Me.dgvParticipantList.ReadOnly = True
		Me.dgvParticipantList.RowHeadersWidth = 51
		Me.dgvParticipantList.RowTemplate.Height = 24
		Me.dgvParticipantList.Size = New System.Drawing.Size(914, 328)
		Me.dgvParticipantList.TabIndex = 1
		'
		'btnClose
		'
		Me.btnClose.BackColor = System.Drawing.Color.Cyan
		Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnClose.Location = New System.Drawing.Point(432, 507)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(162, 30)
		Me.btnClose.TabIndex = 2
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = False
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.Cyan
		Me.Label1.Location = New System.Drawing.Point(685, 390)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(128, 17)
		Me.Label1.TabIndex = 3
		Me.Label1.Text = "Total Participant"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.ForeColor = System.Drawing.Color.Cyan
		Me.Label2.Location = New System.Drawing.Point(716, 424)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(97, 17)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Total Attend"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.ForeColor = System.Drawing.Color.Cyan
		Me.Label3.Location = New System.Drawing.Point(713, 458)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(100, 17)
		Me.Label3.TabIndex = 5
		Me.Label3.Text = "Total Absent"
		'
		'lblTotalParticipant
		'
		Me.lblTotalParticipant.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblTotalParticipant.Location = New System.Drawing.Point(819, 389)
		Me.lblTotalParticipant.Name = "lblTotalParticipant"
		Me.lblTotalParticipant.Size = New System.Drawing.Size(110, 25)
		Me.lblTotalParticipant.TabIndex = 6
		'
		'lblAttend
		'
		Me.lblAttend.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblAttend.Location = New System.Drawing.Point(819, 423)
		Me.lblAttend.Name = "lblAttend"
		Me.lblAttend.Size = New System.Drawing.Size(110, 25)
		Me.lblAttend.TabIndex = 7
		'
		'lblAbsent
		'
		Me.lblAbsent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.lblAbsent.Location = New System.Drawing.Point(819, 457)
		Me.lblAbsent.Name = "lblAbsent"
		Me.lblAbsent.Size = New System.Drawing.Size(110, 25)
		Me.lblAbsent.TabIndex = 8
		'
		'InfoForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.Event_Participation_Management_System.My.Resources.Resources.background
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(991, 549)
		Me.Controls.Add(Me.lblAbsent)
		Me.Controls.Add(Me.lblAttend)
		Me.Controls.Add(Me.lblTotalParticipant)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.dgvParticipantList)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "InfoForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Participation Information"
		CType(Me.dgvParticipantList, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents dgvParticipantList As DataGridView
	Friend WithEvents btnClose As Button
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents lblTotalParticipant As Label
	Friend WithEvents lblAttend As Label
	Friend WithEvents lblAbsent As Label
End Class
