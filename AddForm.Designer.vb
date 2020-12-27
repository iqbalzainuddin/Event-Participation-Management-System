<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddForm
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddForm))
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.txtName = New System.Windows.Forms.TextBox()
		Me.txtStuID = New System.Windows.Forms.TextBox()
		Me.txtICNum = New System.Windows.Forms.TextBox()
		Me.comProgCode = New System.Windows.Forms.ComboBox()
		Me.btnAdd = New System.Windows.Forms.Button()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.ForeColor = System.Drawing.Color.Cyan
		Me.Label1.Location = New System.Drawing.Point(50, 46)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(53, 17)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Name: "
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.ForeColor = System.Drawing.Color.Cyan
		Me.Label2.Location = New System.Drawing.Point(50, 77)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(82, 17)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "IC Number: "
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.ForeColor = System.Drawing.Color.Cyan
		Me.Label3.Location = New System.Drawing.Point(50, 108)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(82, 17)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Student ID: "
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.ForeColor = System.Drawing.Color.Cyan
		Me.Label4.Location = New System.Drawing.Point(50, 139)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(74, 17)
		Me.Label4.TabIndex = 3
		Me.Label4.Text = "Program : "
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.ForeColor = System.Drawing.Color.Cyan
		Me.Label5.Location = New System.Drawing.Point(22, 18)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(175, 17)
		Me.Label5.TabIndex = 4
		Me.Label5.Text = "Enter Student's Details"
		'
		'txtName
		'
		Me.txtName.AcceptsTab = True
		Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.txtName.Location = New System.Drawing.Point(165, 43)
		Me.txtName.Name = "txtName"
		Me.txtName.Size = New System.Drawing.Size(362, 22)
		Me.txtName.TabIndex = 5
		'
		'txtStuID
		'
		Me.txtStuID.AcceptsTab = True
		Me.txtStuID.Location = New System.Drawing.Point(165, 105)
		Me.txtStuID.MaxLength = 10
		Me.txtStuID.Name = "txtStuID"
		Me.txtStuID.Size = New System.Drawing.Size(362, 22)
		Me.txtStuID.TabIndex = 7
		'
		'txtICNum
		'
		Me.txtICNum.AcceptsTab = True
		Me.txtICNum.Location = New System.Drawing.Point(165, 74)
		Me.txtICNum.MaxLength = 12
		Me.txtICNum.Name = "txtICNum"
		Me.txtICNum.Size = New System.Drawing.Size(362, 22)
		Me.txtICNum.TabIndex = 6
		'
		'comProgCode
		'
		Me.comProgCode.FormattingEnabled = True
		Me.comProgCode.Items.AddRange(New Object() {"CS110", "AT110", "CS230", "CS245", "CS246", "CS251", "CS253", "AT220"})
		Me.comProgCode.Location = New System.Drawing.Point(163, 136)
		Me.comProgCode.Name = "comProgCode"
		Me.comProgCode.Size = New System.Drawing.Size(364, 24)
		Me.comProgCode.TabIndex = 8
		'
		'btnAdd
		'
		Me.btnAdd.BackColor = System.Drawing.Color.Cyan
		Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnAdd.Location = New System.Drawing.Point(168, 196)
		Me.btnAdd.Name = "btnAdd"
		Me.btnAdd.Size = New System.Drawing.Size(120, 28)
		Me.btnAdd.TabIndex = 9
		Me.btnAdd.Text = "Add"
		Me.btnAdd.UseVisualStyleBackColor = False
		'
		'btnClose
		'
		Me.btnClose.BackColor = System.Drawing.Color.Cyan
		Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnClose.Location = New System.Drawing.Point(303, 196)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(120, 28)
		Me.btnClose.TabIndex = 10
		Me.btnClose.Text = "Close"
		Me.btnClose.UseVisualStyleBackColor = False
		'
		'AddForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackgroundImage = Global.Event_Participation_Management_System.My.Resources.Resources.background
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(581, 236)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.btnAdd)
		Me.Controls.Add(Me.comProgCode)
		Me.Controls.Add(Me.txtICNum)
		Me.Controls.Add(Me.txtStuID)
		Me.Controls.Add(Me.txtName)
		Me.Controls.Add(Me.Label5)
		Me.Controls.Add(Me.Label4)
		Me.Controls.Add(Me.Label3)
		Me.Controls.Add(Me.Label2)
		Me.Controls.Add(Me.Label1)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Name = "AddForm"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Add Participant"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents txtName As TextBox
	Friend WithEvents txtStuID As TextBox
	Friend WithEvents txtICNum As TextBox
	Friend WithEvents comProgCode As ComboBox
	Friend WithEvents btnAdd As Button
	Friend WithEvents btnClose As Button
End Class
