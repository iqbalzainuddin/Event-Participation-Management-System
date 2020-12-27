<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePWForm
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePWForm))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtCurrent = New System.Windows.Forms.TextBox()
		Me.txtNew = New System.Windows.Forms.TextBox()
		Me.btnChange = New System.Windows.Forms.Button()
		Me.btnCancel = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.ForeColor = System.Drawing.Color.Cyan
		Me.Label1.Location = New System.Drawing.Point(181, 43)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(81, 17)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Current PIN"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.ForeColor = System.Drawing.Color.Cyan
		Me.Label2.Location = New System.Drawing.Point(191, 100)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(61, 17)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "New PIN"
		'
		'txtCurrent
		'
		Me.txtCurrent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
		Me.txtCurrent.Location = New System.Drawing.Point(123, 63)
		Me.txtCurrent.MaxLength = 6
		Me.txtCurrent.Name = "txtCurrent"
		Me.txtCurrent.Size = New System.Drawing.Size(202, 23)
		Me.txtCurrent.TabIndex = 2
		Me.txtCurrent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtCurrent.UseSystemPasswordChar = True
		'
		'txtNew
		'
		Me.txtNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
		Me.txtNew.Location = New System.Drawing.Point(122, 119)
		Me.txtNew.MaxLength = 6
		Me.txtNew.Name = "txtNew"
		Me.txtNew.Size = New System.Drawing.Size(202, 23)
		Me.txtNew.TabIndex = 3
		Me.txtNew.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtNew.UseSystemPasswordChar = True
		'
		'btnChange
		'
		Me.btnChange.BackColor = System.Drawing.Color.Cyan
		Me.btnChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnChange.Location = New System.Drawing.Point(100, 178)
		Me.btnChange.Name = "btnChange"
		Me.btnChange.Size = New System.Drawing.Size(118, 30)
		Me.btnChange.TabIndex = 4
		Me.btnChange.Text = "Change"
		Me.btnChange.UseVisualStyleBackColor = False
		'
		'btnCancel
		'
		Me.btnCancel.BackColor = System.Drawing.Color.Cyan
		Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnCancel.Location = New System.Drawing.Point(234, 178)
		Me.btnCancel.Name = "btnCancel"
		Me.btnCancel.Size = New System.Drawing.Size(118, 30)
		Me.btnCancel.TabIndex = 5
		Me.btnCancel.Text = "Cancel"
		Me.btnCancel.UseVisualStyleBackColor = False
		'
		'ChangePWForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.Event_Participation_Management_System.My.Resources.Resources.background
		Me.ClientSize = New System.Drawing.Size(446, 230)
		Me.Controls.Add(Me.btnCancel)
		Me.Controls.Add(Me.btnChange)
		Me.Controls.Add(Me.txtNew)
		Me.Controls.Add(Me.txtCurrent)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "ChangePWForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
		Me.Text = "Change PIN"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents txtCurrent As TextBox
	Friend WithEvents txtNew As TextBox
	Friend WithEvents btnChange As Button
	Friend WithEvents btnCancel As Button
End Class
