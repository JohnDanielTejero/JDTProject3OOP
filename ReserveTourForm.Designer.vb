<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReserveTourForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReserveTourForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReserveTours = New System.Windows.Forms.ListBox()
        Me.ReserveDays = New System.Windows.Forms.Panel()
        Me.Register14 = New System.Windows.Forms.RadioButton()
        Me.Register7 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ReserveDate = New System.Windows.Forms.DateTimePicker()
        Me.TotalCost = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ReservePax = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PricePerPax = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ReserveCostTotal = New System.Windows.Forms.Label()
        Me.ReserveSubmit = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservePayment = New System.Windows.Forms.ComboBox()
        Me.ReserveDays.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "List of Tours:"
        '
        'ReserveTours
        '
        Me.ReserveTours.FormattingEnabled = True
        Me.ReserveTours.Location = New System.Drawing.Point(16, 87)
        Me.ReserveTours.Name = "ReserveTours"
        Me.ReserveTours.Size = New System.Drawing.Size(120, 95)
        Me.ReserveTours.TabIndex = 1
        '
        'ReserveDays
        '
        Me.ReserveDays.BackColor = System.Drawing.Color.Transparent
        Me.ReserveDays.Controls.Add(Me.Register14)
        Me.ReserveDays.Controls.Add(Me.Register7)
        Me.ReserveDays.Controls.Add(Me.Label2)
        Me.ReserveDays.Location = New System.Drawing.Point(142, 46)
        Me.ReserveDays.Name = "ReserveDays"
        Me.ReserveDays.Size = New System.Drawing.Size(128, 136)
        Me.ReserveDays.TabIndex = 2
        '
        'Register14
        '
        Me.Register14.AutoSize = True
        Me.Register14.BackColor = System.Drawing.Color.Transparent
        Me.Register14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Register14.Location = New System.Drawing.Point(7, 76)
        Me.Register14.Name = "Register14"
        Me.Register14.Size = New System.Drawing.Size(94, 28)
        Me.Register14.TabIndex = 5
        Me.Register14.TabStop = True
        Me.Register14.Text = "14 Days"
        Me.Register14.UseVisualStyleBackColor = False
        '
        'Register7
        '
        Me.Register7.AutoSize = True
        Me.Register7.BackColor = System.Drawing.Color.Transparent
        Me.Register7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Register7.Location = New System.Drawing.Point(7, 42)
        Me.Register7.Name = "Register7"
        Me.Register7.Size = New System.Drawing.Size(84, 28)
        Me.Register7.TabIndex = 4
        Me.Register7.TabStop = True
        Me.Register7.Text = "7 Days"
        Me.Register7.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "No of Days:"
        '
        'ReserveDate
        '
        Me.ReserveDate.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReserveDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReserveDate.Location = New System.Drawing.Point(194, 251)
        Me.ReserveDate.Name = "ReserveDate"
        Me.ReserveDate.Size = New System.Drawing.Size(333, 29)
        Me.ReserveDate.TabIndex = 7
        '
        'TotalCost
        '
        Me.TotalCost.AutoSize = True
        Me.TotalCost.BackColor = System.Drawing.Color.Transparent
        Me.TotalCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalCost.Location = New System.Drawing.Point(66, 208)
        Me.TotalCost.Name = "TotalCost"
        Me.TotalCost.Size = New System.Drawing.Size(122, 24)
        Me.TotalCost.TabIndex = 38
        Me.TotalCost.Text = "Num Of Pax"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 298)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(176, 24)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Mode Of Payment"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(92, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 24)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Dep Date"
        '
        'ReservePax
        '
        Me.ReservePax.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReservePax.Location = New System.Drawing.Point(194, 205)
        Me.ReservePax.Name = "ReservePax"
        Me.ReservePax.Size = New System.Drawing.Size(333, 29)
        Me.ReservePax.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(276, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 24)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Cost Per Pax"
        '
        'PricePerPax
        '
        Me.PricePerPax.AutoSize = True
        Me.PricePerPax.BackColor = System.Drawing.Color.Transparent
        Me.PricePerPax.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PricePerPax.Location = New System.Drawing.Point(412, 158)
        Me.PricePerPax.Name = "PricePerPax"
        Me.PricePerPax.Size = New System.Drawing.Size(42, 24)
        Me.PricePerPax.TabIndex = 38
        Me.PricePerPax.Text = "N/A"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(85, 343)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 24)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Total Cost"
        '
        'ReserveCostTotal
        '
        Me.ReserveCostTotal.AutoSize = True
        Me.ReserveCostTotal.BackColor = System.Drawing.Color.Transparent
        Me.ReserveCostTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReserveCostTotal.Location = New System.Drawing.Point(190, 343)
        Me.ReserveCostTotal.Name = "ReserveCostTotal"
        Me.ReserveCostTotal.Size = New System.Drawing.Size(42, 24)
        Me.ReserveCostTotal.TabIndex = 38
        Me.ReserveCostTotal.Text = "N/A"
        '
        'ReserveSubmit
        '
        Me.ReserveSubmit.Location = New System.Drawing.Point(194, 381)
        Me.ReserveSubmit.Name = "ReserveSubmit"
        Me.ReserveSubmit.Size = New System.Drawing.Size(330, 38)
        Me.ReserveSubmit.TabIndex = 9
        Me.ReserveSubmit.Text = "Reserve"
        Me.ReserveSubmit.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AccountToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(600, 33)
        Me.MenuStrip1.TabIndex = 41
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AccountToolStripMenuItem
        '
        Me.AccountToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AccountToolStripMenuItem.Name = "AccountToolStripMenuItem"
        Me.AccountToolStripMenuItem.Size = New System.Drawing.Size(98, 29)
        Me.AccountToolStripMenuItem.Text = "Account"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(89, 29)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ReservePayment
        '
        Me.ReservePayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ReservePayment.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReservePayment.FormattingEnabled = True
        Me.ReservePayment.Items.AddRange(New Object() {"Debit", "Credit"})
        Me.ReservePayment.Location = New System.Drawing.Point(195, 300)
        Me.ReservePayment.Name = "ReservePayment"
        Me.ReservePayment.Size = New System.Drawing.Size(332, 32)
        Me.ReservePayment.TabIndex = 42
        '
        'ReserveTourForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(600, 510)
        Me.Controls.Add(Me.ReservePayment)
        Me.Controls.Add(Me.ReserveSubmit)
        Me.Controls.Add(Me.ReserveDate)
        Me.Controls.Add(Me.ReserveCostTotal)
        Me.Controls.Add(Me.PricePerPax)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TotalCost)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ReservePax)
        Me.Controls.Add(Me.ReserveDays)
        Me.Controls.Add(Me.ReserveTours)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ReserveTourForm"
        Me.Text = "ReserveTourForm"
        Me.ReserveDays.ResumeLayout(False)
        Me.ReserveDays.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ReserveTours As ListBox
    Friend WithEvents ReserveDays As Panel
    Friend WithEvents Register14 As RadioButton
    Friend WithEvents Register7 As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents ReserveDate As DateTimePicker
    Friend WithEvents TotalCost As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ReservePax As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PricePerPax As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ReserveCostTotal As Label
    Friend WithEvents ReserveSubmit As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents AccountToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReservePayment As ComboBox
End Class
