<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btnRefresh = New System.Windows.Forms.Button()
		Me.btnStart = New System.Windows.Forms.Button()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.radNewEvent = New System.Windows.Forms.RadioButton()
		Me.radExistEvent = New System.Windows.Forms.RadioButton()
		Me.lblSelectEvent = New System.Windows.Forms.Label()
		Me.ComboBoxEvent = New System.Windows.Forms.ComboBox()
		Me.btnLogout = New System.Windows.Forms.Button()
		Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
		Me.ChangePasswordToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
		Me.MenuStrip2.SuspendLayout()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.Cyan
		Me.Label1.Location = New System.Drawing.Point(36, 50)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(283, 25)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Event Participation Manager"
		'
		'btnRefresh
		'
		Me.btnRefresh.BackColor = System.Drawing.Color.Cyan
		Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Bold)
		Me.btnRefresh.Location = New System.Drawing.Point(27, 266)
		Me.btnRefresh.Name = "btnRefresh"
		Me.btnRefresh.Size = New System.Drawing.Size(249, 28)
		Me.btnRefresh.TabIndex = 1
		Me.btnRefresh.Text = "Refresh After Create Event"
		Me.btnRefresh.UseVisualStyleBackColor = False
		'
		'btnStart
		'
		Me.btnStart.BackColor = System.Drawing.Color.Cyan
		Me.btnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnStart.Location = New System.Drawing.Point(433, 266)
		Me.btnStart.Name = "btnStart"
		Me.btnStart.Size = New System.Drawing.Size(120, 28)
		Me.btnStart.TabIndex = 3
		Me.btnStart.Text = "Start"
		Me.btnStart.UseVisualStyleBackColor = False
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.ForeColor = System.Drawing.Color.Cyan
		Me.Label2.Location = New System.Drawing.Point(78, 88)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(198, 17)
		Me.Label2.TabIndex = 4
		Me.Label2.Text = "Select one option to start with:"
		'
		'radNewEvent
		'
		Me.radNewEvent.AutoSize = True
		Me.radNewEvent.BackColor = System.Drawing.Color.Transparent
		Me.radNewEvent.ForeColor = System.Drawing.Color.Cyan
		Me.radNewEvent.Location = New System.Drawing.Point(112, 118)
		Me.radNewEvent.Name = "radNewEvent"
		Me.radNewEvent.Size = New System.Drawing.Size(142, 21)
		Me.radNewEvent.TabIndex = 5
		Me.radNewEvent.TabStop = True
		Me.radNewEvent.Text = "Create New Event"
		Me.radNewEvent.UseVisualStyleBackColor = False
		'
		'radExistEvent
		'
		Me.radExistEvent.AutoSize = True
		Me.radExistEvent.BackColor = System.Drawing.Color.Transparent
		Me.radExistEvent.ForeColor = System.Drawing.Color.Cyan
		Me.radExistEvent.Location = New System.Drawing.Point(112, 154)
		Me.radExistEvent.Name = "radExistEvent"
		Me.radExistEvent.Size = New System.Drawing.Size(172, 21)
		Me.radExistEvent.TabIndex = 6
		Me.radExistEvent.TabStop = True
		Me.radExistEvent.Text = "Manage Existing Event"
		Me.radExistEvent.UseVisualStyleBackColor = False
		'
		'lblSelectEvent
		'
		Me.lblSelectEvent.AutoSize = True
		Me.lblSelectEvent.BackColor = System.Drawing.Color.Transparent
		Me.lblSelectEvent.ForeColor = System.Drawing.Color.Cyan
		Me.lblSelectEvent.Location = New System.Drawing.Point(140, 178)
		Me.lblSelectEvent.Name = "lblSelectEvent"
		Me.lblSelectEvent.Size = New System.Drawing.Size(91, 17)
		Me.lblSelectEvent.TabIndex = 7
		Me.lblSelectEvent.Text = "Select Event:"
		'
		'ComboBoxEvent
		'
		Me.ComboBoxEvent.BackColor = System.Drawing.SystemColors.MenuText
		Me.ComboBoxEvent.Enabled = False
		Me.ComboBoxEvent.ForeColor = System.Drawing.Color.Cyan
		Me.ComboBoxEvent.FormattingEnabled = True
		Me.ComboBoxEvent.Location = New System.Drawing.Point(143, 198)
		Me.ComboBoxEvent.Name = "ComboBoxEvent"
		Me.ComboBoxEvent.Size = New System.Drawing.Size(424, 24)
		Me.ComboBoxEvent.TabIndex = 8
		'
		'btnLogout
		'
		Me.btnLogout.BackColor = System.Drawing.Color.Cyan
		Me.btnLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLogout.Location = New System.Drawing.Point(559, 266)
		Me.btnLogout.Name = "btnLogout"
		Me.btnLogout.Size = New System.Drawing.Size(120, 28)
		Me.btnLogout.TabIndex = 9
		Me.btnLogout.Text = "Logout"
		Me.btnLogout.UseVisualStyleBackColor = False
		'
		'MenuStrip2
		'
		Me.MenuStrip2.BackColor = System.Drawing.SystemColors.ControlText
		Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangePasswordToolStripMenuItem1})
		Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip2.Name = "MenuStrip2"
		Me.MenuStrip2.Size = New System.Drawing.Size(691, 30)
		Me.MenuStrip2.TabIndex = 11
		Me.MenuStrip2.Text = "MenuStrip2"
		'
		'ChangePasswordToolStripMenuItem1
		'
		Me.ChangePasswordToolStripMenuItem1.ForeColor = System.Drawing.Color.Cyan
		Me.ChangePasswordToolStripMenuItem1.Name = "ChangePasswordToolStripMenuItem1"
		Me.ChangePasswordToolStripMenuItem1.Size = New System.Drawing.Size(100, 26)
		Me.ChangePasswordToolStripMenuItem1.Text = "Change PIN"
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
		Me.BackgroundImage = Global.Event_Participation_Management_System.My.Resources.Resources.background
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(691, 305)
		Me.Controls.Add(Me.btnLogout)
		Me.Controls.Add(Me.ComboBoxEvent)
		Me.Controls.Add(Me.lblSelectEvent)
		Me.Controls.Add(Me.radExistEvent)
		Me.Controls.Add(Me.radNewEvent)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.btnStart)
		Me.Controls.Add(Me.btnRefresh)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.MenuStrip2)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "MainForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Event Participation Manager"
		Me.MenuStrip2.ResumeLayout(False)
		Me.MenuStrip2.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents btnRefresh As Button
	Friend WithEvents btnStart As Button
	Friend WithEvents Label2 As Label
	Friend WithEvents radNewEvent As RadioButton
	Friend WithEvents radExistEvent As RadioButton
	Friend WithEvents lblSelectEvent As Label
	Friend WithEvents ComboBoxEvent As ComboBox
	Friend WithEvents btnLogout As Button
	Friend WithEvents MenuStrip2 As MenuStrip
	Friend WithEvents ChangePasswordToolStripMenuItem1 As ToolStripMenuItem
End Class
