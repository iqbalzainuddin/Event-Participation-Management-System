<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttendForm
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AttendForm))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.txtStuID = New System.Windows.Forms.TextBox()
		Me.btnAttend = New System.Windows.Forms.Button()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.ForeColor = System.Drawing.Color.Cyan
		Me.Label1.Location = New System.Drawing.Point(23, 39)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(120, 17)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Enter Student ID: "
		'
		'txtStuID
		'
		Me.txtStuID.Location = New System.Drawing.Point(149, 36)
		Me.txtStuID.MaxLength = 10
		Me.txtStuID.Name = "txtStuID"
		Me.txtStuID.Size = New System.Drawing.Size(168, 22)
		Me.txtStuID.TabIndex = 1
		'
		'btnAttend
		'
		Me.btnAttend.BackColor = System.Drawing.Color.Cyan
		Me.btnAttend.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnAttend.Location = New System.Drawing.Point(48, 90)
		Me.btnAttend.Name = "btnAttend"
		Me.btnAttend.Size = New System.Drawing.Size(120, 28)
		Me.btnAttend.TabIndex = 2
		Me.btnAttend.Text = "Attend"
		Me.btnAttend.UseVisualStyleBackColor = False
		'
		'btnClose
		'
		Me.btnClose.BackColor = System.Drawing.Color.Cyan
		Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnClose.Location = New System.Drawing.Point(183, 90)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(120, 28)
		Me.btnClose.TabIndex = 3
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = False
		'
		'AttendForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.Event_Participation_Management_System.My.Resources.Resources.background
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(350, 130)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.btnAttend)
		Me.Controls.Add(Me.txtStuID)
		Me.Controls.Add(Me.Label1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "AttendForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Attendance"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents txtStuID As TextBox
	Friend WithEvents btnAttend As Button
	Friend WithEvents btnClose As Button
End Class
