<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistrationForm))
        Me.RegisterSubmit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RegisterAddress = New System.Windows.Forms.TextBox()
        Me.RegisterName = New System.Windows.Forms.TextBox()
        Me.RegisterPhone = New System.Windows.Forms.TextBox()
        Me.RegisterPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RegisterSubmit
        '
        Me.RegisterSubmit.Location = New System.Drawing.Point(205, 233)
        Me.RegisterSubmit.Name = "RegisterSubmit"
        Me.RegisterSubmit.Size = New System.Drawing.Size(200, 38)
        Me.RegisterSubmit.TabIndex = 4
        Me.RegisterSubmit.Text = "Register"
        Me.RegisterSubmit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 24)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Customer Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 24)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Customer Name"
        '
        'RegisterAddress
        '
        Me.RegisterAddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterAddress.Location = New System.Drawing.Point(205, 83)
        Me.RegisterAddress.Name = "RegisterAddress"
        Me.RegisterAddress.Size = New System.Drawing.Size(200, 29)
        Me.RegisterAddress.TabIndex = 1
        '
        'RegisterName
        '
        Me.RegisterName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterName.Location = New System.Drawing.Point(205, 31)
        Me.RegisterName.Name = "RegisterName"
        Me.RegisterName.Size = New System.Drawing.Size(200, 29)
        Me.RegisterName.TabIndex = 0
        '
        'RegisterPhone
        '
        Me.RegisterPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterPhone.Location = New System.Drawing.Point(205, 135)
        Me.RegisterPhone.Name = "RegisterPhone"
        Me.RegisterPhone.Size = New System.Drawing.Size(200, 29)
        Me.RegisterPhone.TabIndex = 2
        '
        'RegisterPass
        '
        Me.RegisterPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegisterPass.Location = New System.Drawing.Point(205, 187)
        Me.RegisterPass.Name = "RegisterPass"
        Me.RegisterPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.RegisterPass.Size = New System.Drawing.Size(200, 29)
        Me.RegisterPass.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 24)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Phone Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(99, 187)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 24)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Password"
        '
        'RegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(414, 402)
        Me.Controls.Add(Me.RegisterSubmit)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RegisterPass)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RegisterPhone)
        Me.Controls.Add(Me.RegisterAddress)
        Me.Controls.Add(Me.RegisterName)
        Me.DoubleBuffered = True
        Me.Name = "RegistrationForm"
        Me.Text = "RegistrationForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RegisterSubmit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RegisterAddress As TextBox
    Friend WithEvents RegisterName As TextBox
    Friend WithEvents RegisterPhone As TextBox
    Friend WithEvents RegisterPass As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
