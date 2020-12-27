<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.txtPin = New System.Windows.Forms.TextBox()
		Me.btnLogin = New System.Windows.Forms.Button()
		Me.btnClose = New System.Windows.Forms.Button()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.ForeColor = System.Drawing.Color.Cyan
		Me.Label1.Location = New System.Drawing.Point(126, 162)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(173, 25)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Enter 6-Digit PIN"
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = Global.Event_Participation_Management_System.My.Resources.Resources.movie
		Me.PictureBox1.Location = New System.Drawing.Point(150, 41)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(119, 104)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 1
		Me.PictureBox1.TabStop = False
		'
		'txtPin
		'
		Me.txtPin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtPin.Location = New System.Drawing.Point(118, 201)
		Me.txtPin.MaxLength = 6
		Me.txtPin.Name = "txtPin"
		Me.txtPin.Size = New System.Drawing.Size(193, 28)
		Me.txtPin.TabIndex = 2
		Me.txtPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtPin.UseSystemPasswordChar = True
		'
		'btnLogin
		'
		Me.btnLogin.BackColor = System.Drawing.Color.Cyan
		Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnLogin.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnLogin.Location = New System.Drawing.Point(61, 269)
		Me.btnLogin.Name = "btnLogin"
		Me.btnLogin.Size = New System.Drawing.Size(151, 30)
		Me.btnLogin.TabIndex = 3
		Me.btnLogin.Text = "Login"
		Me.btnLogin.UseVisualStyleBackColor = False
		'
		'btnClose
		'
		Me.btnClose.BackColor = System.Drawing.Color.Cyan
		Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlText
		Me.btnClose.Location = New System.Drawing.Point(218, 269)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(151, 30)
		Me.btnClose.TabIndex = 4
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = False
		'
		'LoginForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.Event_Participation_Management_System.My.Resources.Resources.background
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(421, 336)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.btnLogin)
		Me.Controls.Add(Me.txtPin)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Label1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MaximizeBox = False
		Me.Name = "LoginForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Login"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents txtPin As TextBox
	Friend WithEvents btnLogin As Button
	Friend WithEvents btnClose As Button
End Class
