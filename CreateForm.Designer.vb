<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateForm
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateForm))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtNewEvent = New System.Windows.Forms.TextBox()
		Me.btnCreate = New System.Windows.Forms.Button()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.ForeColor = System.Drawing.Color.Cyan
		Me.Label1.Location = New System.Drawing.Point(48, 24)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(127, 17)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Enter Event Name:"
		'
		'txtNewEvent
		'
		Me.txtNewEvent.Location = New System.Drawing.Point(181, 21)
		Me.txtNewEvent.Name = "txtNewEvent"
		Me.txtNewEvent.Size = New System.Drawing.Size(319, 22)
		Me.txtNewEvent.TabIndex = 1
		'
		'btnCreate
		'
		Me.btnCreate.BackColor = System.Drawing.Color.Cyan
		Me.btnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCreate.Location = New System.Drawing.Point(164, 63)
		Me.btnCreate.Name = "btnCreate"
		Me.btnCreate.Size = New System.Drawing.Size(120, 28)
		Me.btnCreate.TabIndex = 2
		Me.btnCreate.Text = "Create"
		Me.btnCreate.UseVisualStyleBackColor = False
		'
		'btnCancel
		'
		Me.btnCancel.BackColor = System.Drawing.Color.Cyan
		Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCancel.Location = New System.Drawing.Point(290, 63)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(120, 28)
		Me.btnCancel.TabIndex = 3
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = False
		'
		'CreateForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.Event_Participation_Management_System.My.Resources.Resources.background
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(563, 103)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.btnCreate)
		Me.Controls.Add(Me.txtNewEvent)
		Me.Controls.Add(Me.Label1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "CreateForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Create New Event"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents txtNewEvent As TextBox
	Friend WithEvents btnCreate As Button
	Friend WithEvents btnCancel As Button
End Class
