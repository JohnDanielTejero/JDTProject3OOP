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
        Me.LoginUsername = New System.Windows.Forms.TextBox()
        Me.LoginPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LoginToRegister = New System.Windows.Forms.LinkLabel()
        Me.LoginSubmit = New System.Windows.Forms.Button()
        Me.LoginCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LoginUsername
        '
        Me.LoginUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginUsername.Location = New System.Drawing.Point(206, 68)
        Me.LoginUsername.Name = "LoginUsername"
        Me.LoginUsername.Size = New System.Drawing.Size(205, 29)
        Me.LoginUsername.TabIndex = 0
        '
        'LoginPassword
        '
        Me.LoginPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginPassword.Location = New System.Drawing.Point(206, 125)
        Me.LoginPassword.Name = "LoginPassword"
        Me.LoginPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.LoginPassword.Size = New System.Drawing.Size(205, 29)
        Me.LoginPassword.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(76, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'LoginToRegister
        '
        Me.LoginToRegister.AutoSize = True
        Me.LoginToRegister.BackColor = System.Drawing.Color.Transparent
        Me.LoginToRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LoginToRegister.Location = New System.Drawing.Point(203, 157)
        Me.LoginToRegister.Name = "LoginToRegister"
        Me.LoginToRegister.Size = New System.Drawing.Size(196, 16)
        Me.LoginToRegister.TabIndex = 4
        Me.LoginToRegister.TabStop = True
        Me.LoginToRegister.Text = "Not Yet Registered? Click Here."
        '
        'LoginSubmit
        '
        Me.LoginSubmit.Location = New System.Drawing.Point(206, 202)
        Me.LoginSubmit.Name = "LoginSubmit"
        Me.LoginSubmit.Size = New System.Drawing.Size(97, 38)
        Me.LoginSubmit.TabIndex = 5
        Me.LoginSubmit.Text = "Ok"
        Me.LoginSubmit.UseVisualStyleBackColor = True
        '
        'LoginCancel
        '
        Me.LoginCancel.Location = New System.Drawing.Point(309, 202)
        Me.LoginCancel.Name = "LoginCancel"
        Me.LoginCancel.Size = New System.Drawing.Size(99, 38)
        Me.LoginCancel.TabIndex = 6
        Me.LoginCancel.Text = "Cancel"
        Me.LoginCancel.UseVisualStyleBackColor = True
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(468, 355)
        Me.Controls.Add(Me.LoginCancel)
        Me.Controls.Add(Me.LoginSubmit)
        Me.Controls.Add(Me.LoginToRegister)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LoginPassword)
        Me.Controls.Add(Me.LoginUsername)
        Me.DoubleBuffered = True
        Me.Name = "LoginForm"
        Me.Text = "LoginForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LoginUsername As TextBox
    Friend WithEvents LoginPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LoginToRegister As LinkLabel
    Friend WithEvents LoginSubmit As Button
    Friend WithEvents LoginCancel As Button
End Class
