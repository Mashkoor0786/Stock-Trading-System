<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.fname = New System.Windows.Forms.TextBox()
        Me.lname = New System.Windows.Forms.TextBox()
        Me.phone = New System.Windows.Forms.TextBox()
        Me.mail = New System.Windows.Forms.TextBox()
        Me.aadhaar = New System.Windows.Forms.TextBox()
        Me.pan = New System.Windows.Forms.TextBox()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.cnfpass = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dob = New System.Windows.Forms.DateTimePicker()
        Me.gender = New System.Windows.Forms.ComboBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2ShadowForm1 = New Guna.UI2.WinForms.Guna2ShadowForm(Me.components)
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button2 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 20.0!)
        Me.Label1.Location = New System.Drawing.Point(331, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(338, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Stock Exchange Account Creation"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(72, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(547, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(72, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "DOB"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(547, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Gender"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(72, 257)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Phone No."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(72, 324)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Aadhaar No."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(547, 320)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "PAN No."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label9.Location = New System.Drawing.Point(547, 250)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 18)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "E-Mail ID"
        '
        'fname
        '
        Me.fname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fname.Location = New System.Drawing.Point(209, 125)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(229, 26)
        Me.fname.TabIndex = 9
        '
        'lname
        '
        Me.lname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.lname.Location = New System.Drawing.Point(710, 121)
        Me.lname.Name = "lname"
        Me.lname.Size = New System.Drawing.Size(234, 26)
        Me.lname.TabIndex = 10
        '
        'phone
        '
        Me.phone.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.phone.Location = New System.Drawing.Point(209, 250)
        Me.phone.MaxLength = 10
        Me.phone.Name = "phone"
        Me.phone.Size = New System.Drawing.Size(234, 26)
        Me.phone.TabIndex = 11
        '
        'mail
        '
        Me.mail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.mail.Location = New System.Drawing.Point(710, 246)
        Me.mail.Name = "mail"
        Me.mail.Size = New System.Drawing.Size(234, 26)
        Me.mail.TabIndex = 12
        Me.mail.Text = "sample@gmail.com"
        Me.mail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'aadhaar
        '
        Me.aadhaar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.aadhaar.Location = New System.Drawing.Point(209, 316)
        Me.aadhaar.MaxLength = 16
        Me.aadhaar.Name = "aadhaar"
        Me.aadhaar.Size = New System.Drawing.Size(234, 26)
        Me.aadhaar.TabIndex = 13
        Me.aadhaar.Text = "Enter 16 digit UID Number"
        Me.aadhaar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pan
        '
        Me.pan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.pan.Location = New System.Drawing.Point(710, 316)
        Me.pan.MaxLength = 10
        Me.pan.Name = "pan"
        Me.pan.Size = New System.Drawing.Size(234, 26)
        Me.pan.TabIndex = 14
        Me.pan.Text = "Enter Pan Card Number"
        Me.pan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pass
        '
        Me.pass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.pass.Location = New System.Drawing.Point(209, 388)
        Me.pass.Name = "pass"
        Me.pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pass.Size = New System.Drawing.Size(234, 26)
        Me.pass.TabIndex = 15
        Me.pass.Tag = ""
        Me.pass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cnfpass
        '
        Me.cnfpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cnfpass.Location = New System.Drawing.Point(710, 384)
        Me.cnfpass.Name = "cnfpass"
        Me.cnfpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.cnfpass.Size = New System.Drawing.Size(234, 26)
        Me.cnfpass.TabIndex = 16
        Me.cnfpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label10.Location = New System.Drawing.Point(72, 392)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 18)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Password"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.Label11.Location = New System.Drawing.Point(547, 388)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(137, 18)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Confirm Password"
        '
        'dob
        '
        Me.dob.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.dob.Location = New System.Drawing.Point(209, 184)
        Me.dob.Name = "dob"
        Me.dob.Size = New System.Drawing.Size(229, 26)
        Me.dob.TabIndex = 19
        '
        'gender
        '
        Me.gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.gender.FormattingEnabled = True
        Me.gender.Items.AddRange(New Object() {"---Select---", "MALE", "FEMALE", "OTHER"})
        Me.gender.Location = New System.Drawing.Point(710, 180)
        Me.gender.Name = "gender"
        Me.gender.Size = New System.Drawing.Size(234, 28)
        Me.gender.TabIndex = 20
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.CheckBox1.Location = New System.Drawing.Point(393, 466)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(255, 22)
        Me.CheckBox1.TabIndex = 21
        Me.CheckBox1.Text = "I accept all Terms and Conditions"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2ShadowForm1
        '
        Me.Guna2ShadowForm1.TargetForm = Me
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox2)
        Me.Guna2Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1026, 39)
        Me.Guna2Panel1.TabIndex = 24
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.White
        Me.Guna2ControlBox2.HoverState.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(921, 9)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.ShadowDecoration.Parent = Me.Guna2ControlBox2
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(31, 22)
        Me.Guna2ControlBox2.TabIndex = 2
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.White
        Me.Guna2ControlBox1.HoverState.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(970, 9)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.ShadowDecoration.Parent = Me.Guna2ControlBox1
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(31, 22)
        Me.Guna2ControlBox1.TabIndex = 1
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BorderRadius = 17
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.Black
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(200, 511)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(161, 36)
        Me.Guna2Button1.TabIndex = 25
        Me.Guna2Button1.Text = "Register"
        '
        'Guna2Button2
        '
        Me.Guna2Button2.Animated = True
        Me.Guna2Button2.AutoRoundedCorners = True
        Me.Guna2Button2.BorderRadius = 17
        Me.Guna2Button2.CheckedState.Parent = Me.Guna2Button2
        Me.Guna2Button2.CustomImages.Parent = Me.Guna2Button2
        Me.Guna2Button2.FillColor = System.Drawing.Color.Black
        Me.Guna2Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Guna2Button2.ForeColor = System.Drawing.Color.White
        Me.Guna2Button2.HoverState.Parent = Me.Guna2Button2
        Me.Guna2Button2.Location = New System.Drawing.Point(687, 511)
        Me.Guna2Button2.Name = "Guna2Button2"
        Me.Guna2Button2.ShadowDecoration.Parent = Me.Guna2Button2
        Me.Guna2Button2.Size = New System.Drawing.Size(161, 36)
        Me.Guna2Button2.TabIndex = 26
        Me.Guna2Button2.Text = "Cancel"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1026, 585)
        Me.Controls.Add(Me.Guna2Button2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.gender)
        Me.Controls.Add(Me.dob)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cnfpass)
        Me.Controls.Add(Me.pass)
        Me.Controls.Add(Me.pan)
        Me.Controls.Add(Me.aadhaar)
        Me.Controls.Add(Me.mail)
        Me.Controls.Add(Me.phone)
        Me.Controls.Add(Me.lname)
        Me.Controls.Add(Me.fname)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Register"
        Me.Text = "Stock Trading Management"
        Me.Guna2Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents fname As TextBox
    Friend WithEvents lname As TextBox
    Friend WithEvents phone As TextBox
    Friend WithEvents mail As TextBox
    Friend WithEvents aadhaar As TextBox
    Friend WithEvents pan As TextBox
    Friend WithEvents pass As TextBox
    Friend WithEvents cnfpass As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dob As DateTimePicker
    Friend WithEvents gender As ComboBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Guna2ShadowForm1 As Guna.UI2.WinForms.Guna2ShadowForm
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button2 As Guna.UI2.WinForms.Guna2Button
End Class
