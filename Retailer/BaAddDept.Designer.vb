<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaAddDept
    Inherits DevComponents.DotNetBar.Office2007Form

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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BaAddDept))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.CustomGroupBox3 = New Retailer.CustomGroupBox
        Me.btn_next = New System.Windows.Forms.Button
        Me.btn_save = New System.Windows.Forms.Button
        Me.btn_cancel = New System.Windows.Forms.Button
        Me.CustomGroupBox2 = New Retailer.CustomGroupBox
        Me.txt_code = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txt_descrip = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txt_name = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.CustomGroupBox3.SuspendLayout()
        Me.CustomGroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer)))
        '
        'CustomGroupBox3
        '
        Me.CustomGroupBox3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.CustomGroupBox3.Controls.Add(Me.btn_next)
        Me.CustomGroupBox3.Controls.Add(Me.btn_save)
        Me.CustomGroupBox3.Controls.Add(Me.btn_cancel)
        Me.CustomGroupBox3.Location = New System.Drawing.Point(5, 175)
        Me.CustomGroupBox3.Name = "CustomGroupBox3"
        Me.CustomGroupBox3.Size = New System.Drawing.Size(448, 39)
        Me.CustomGroupBox3.TabIndex = 20
        Me.CustomGroupBox3.TabStop = False
        '
        'btn_next
        '
        Me.btn_next.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btn_next.Location = New System.Drawing.Point(130, 10)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(97, 23)
        Me.btn_next.TabIndex = 18
        Me.btn_next.Text = "Save && Next"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btn_save.Location = New System.Drawing.Point(233, 10)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(97, 23)
        Me.btn_save.TabIndex = 17
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btn_cancel.Location = New System.Drawing.Point(336, 10)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(97, 23)
        Me.btn_cancel.TabIndex = 16
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'CustomGroupBox2
        '
        Me.CustomGroupBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.CustomGroupBox2.Controls.Add(Me.txt_code)
        Me.CustomGroupBox2.Controls.Add(Me.Label2)
        Me.CustomGroupBox2.Controls.Add(Me.txt_descrip)
        Me.CustomGroupBox2.Controls.Add(Me.Label1)
        Me.CustomGroupBox2.Controls.Add(Me.txt_name)
        Me.CustomGroupBox2.Controls.Add(Me.Label4)
        Me.CustomGroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.CustomGroupBox2.Location = New System.Drawing.Point(5, 6)
        Me.CustomGroupBox2.Name = "CustomGroupBox2"
        Me.CustomGroupBox2.Size = New System.Drawing.Size(448, 163)
        Me.CustomGroupBox2.TabIndex = 17
        Me.CustomGroupBox2.TabStop = False
        Me.CustomGroupBox2.Text = "Department Details  "
        '
        'txt_code
        '
        Me.txt_code.BackColor = System.Drawing.Color.White
        Me.txt_code.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_code.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_code.Location = New System.Drawing.Point(159, 44)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(275, 21)
        Me.txt_code.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(17, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 18)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Department Code *"
        '
        'txt_descrip
        '
        Me.txt_descrip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_descrip.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descrip.Location = New System.Drawing.Point(159, 71)
        Me.txt_descrip.Multiline = True
        Me.txt_descrip.Name = "txt_descrip"
        Me.txt_descrip.Size = New System.Drawing.Size(275, 78)
        Me.txt_descrip.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(17, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 18)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Description"
        '
        'txt_name
        '
        Me.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_name.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_name.Location = New System.Drawing.Point(158, 17)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(275, 21)
        Me.txt_name.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(16, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 18)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Department Name *"
        '
        'BaAddDept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(458, 220)
        Me.Controls.Add(Me.CustomGroupBox3)
        Me.Controls.Add(Me.CustomGroupBox2)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BaAddDept"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Departments"
        Me.CustomGroupBox3.ResumeLayout(False)
        Me.CustomGroupBox2.ResumeLayout(False)
        Me.CustomGroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents CustomGroupBox2 As Retailer.CustomGroupBox
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents txt_descrip As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CustomGroupBox3 As Retailer.CustomGroupBox
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents txt_code As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_next As System.Windows.Forms.Button
End Class
