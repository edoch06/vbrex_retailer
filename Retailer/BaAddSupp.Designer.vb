<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaAddSupp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BaAddSupp))
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.CustomGroupBox3 = New Retailer.CustomGroupBox
        Me.btn_next = New System.Windows.Forms.Button
        Me.btn_save = New System.Windows.Forms.Button
        Me.btn_cancel = New System.Windows.Forms.Button
        Me.CustomGroupBox2 = New Retailer.CustomGroupBox
        Me.txt_website = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txt_email = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txt_fax = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txt_postalcode = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txt_county = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txt_city = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txt_phno = New System.Windows.Forms.TextBox
        Me.txt_phcode = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txt_nationality = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txt_id = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txt_address = New System.Windows.Forms.TextBox
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
        Me.CustomGroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomGroupBox3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.CustomGroupBox3.Controls.Add(Me.btn_next)
        Me.CustomGroupBox3.Controls.Add(Me.btn_save)
        Me.CustomGroupBox3.Controls.Add(Me.btn_cancel)
        Me.CustomGroupBox3.Location = New System.Drawing.Point(5, 265)
        Me.CustomGroupBox3.Name = "CustomGroupBox3"
        Me.CustomGroupBox3.Size = New System.Drawing.Size(818, 39)
        Me.CustomGroupBox3.TabIndex = 20
        Me.CustomGroupBox3.TabStop = False
        '
        'btn_next
        '
        Me.btn_next.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btn_next.Location = New System.Drawing.Point(493, 10)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(97, 23)
        Me.btn_next.TabIndex = 18
        Me.btn_next.Text = "Save && Next"
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btn_save.Location = New System.Drawing.Point(596, 10)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(97, 23)
        Me.btn_save.TabIndex = 17
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.btn_cancel.Location = New System.Drawing.Point(699, 10)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(97, 23)
        Me.btn_cancel.TabIndex = 16
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'CustomGroupBox2
        '
        Me.CustomGroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CustomGroupBox2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.CustomGroupBox2.Controls.Add(Me.txt_website)
        Me.CustomGroupBox2.Controls.Add(Me.Label10)
        Me.CustomGroupBox2.Controls.Add(Me.txt_email)
        Me.CustomGroupBox2.Controls.Add(Me.Label11)
        Me.CustomGroupBox2.Controls.Add(Me.txt_fax)
        Me.CustomGroupBox2.Controls.Add(Me.Label12)
        Me.CustomGroupBox2.Controls.Add(Me.txt_postalcode)
        Me.CustomGroupBox2.Controls.Add(Me.Label9)
        Me.CustomGroupBox2.Controls.Add(Me.txt_county)
        Me.CustomGroupBox2.Controls.Add(Me.Label8)
        Me.CustomGroupBox2.Controls.Add(Me.txt_city)
        Me.CustomGroupBox2.Controls.Add(Me.Label7)
        Me.CustomGroupBox2.Controls.Add(Me.txt_phno)
        Me.CustomGroupBox2.Controls.Add(Me.txt_phcode)
        Me.CustomGroupBox2.Controls.Add(Me.Label6)
        Me.CustomGroupBox2.Controls.Add(Me.txt_nationality)
        Me.CustomGroupBox2.Controls.Add(Me.Label5)
        Me.CustomGroupBox2.Controls.Add(Me.txt_id)
        Me.CustomGroupBox2.Controls.Add(Me.Label3)
        Me.CustomGroupBox2.Controls.Add(Me.txt_address)
        Me.CustomGroupBox2.Controls.Add(Me.Label1)
        Me.CustomGroupBox2.Controls.Add(Me.txt_name)
        Me.CustomGroupBox2.Controls.Add(Me.Label4)
        Me.CustomGroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.CustomGroupBox2.Location = New System.Drawing.Point(5, 6)
        Me.CustomGroupBox2.Name = "CustomGroupBox2"
        Me.CustomGroupBox2.Size = New System.Drawing.Size(818, 253)
        Me.CustomGroupBox2.TabIndex = 17
        Me.CustomGroupBox2.TabStop = False
        Me.CustomGroupBox2.Text = "Supplier Details  "
        '
        'txt_website
        '
        Me.txt_website.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_website.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txt_website.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_website.Location = New System.Drawing.Point(536, 136)
        Me.txt_website.Name = "txt_website"
        Me.txt_website.Size = New System.Drawing.Size(275, 21)
        Me.txt_website.TabIndex = 56
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(420, 138)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 18)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "Website"
        '
        'txt_email
        '
        Me.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txt_email.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_email.Location = New System.Drawing.Point(536, 109)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(275, 21)
        Me.txt_email.TabIndex = 54
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(420, 111)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 18)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "Email"
        '
        'txt_fax
        '
        Me.txt_fax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_fax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_fax.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_fax.Location = New System.Drawing.Point(536, 82)
        Me.txt_fax.Name = "txt_fax"
        Me.txt_fax.Size = New System.Drawing.Size(275, 21)
        Me.txt_fax.TabIndex = 52
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(420, 84)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(28, 18)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Fax"
        '
        'txt_postalcode
        '
        Me.txt_postalcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_postalcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_postalcode.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_postalcode.Location = New System.Drawing.Point(536, 55)
        Me.txt_postalcode.Name = "txt_postalcode"
        Me.txt_postalcode.Size = New System.Drawing.Size(275, 21)
        Me.txt_postalcode.TabIndex = 50
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(420, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 18)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Postal Code"
        '
        'txt_county
        '
        Me.txt_county.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_county.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_county.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_county.Location = New System.Drawing.Point(536, 28)
        Me.txt_county.Name = "txt_county"
        Me.txt_county.Size = New System.Drawing.Size(275, 21)
        Me.txt_county.TabIndex = 48
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(420, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 18)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "County"
        '
        'txt_city
        '
        Me.txt_city.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_city.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_city.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_city.Location = New System.Drawing.Point(132, 202)
        Me.txt_city.Name = "txt_city"
        Me.txt_city.Size = New System.Drawing.Size(275, 21)
        Me.txt_city.TabIndex = 46
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(14, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 18)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "City"
        '
        'txt_phno
        '
        Me.txt_phno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_phno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_phno.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_phno.Location = New System.Drawing.Point(234, 175)
        Me.txt_phno.Name = "txt_phno"
        Me.txt_phno.Size = New System.Drawing.Size(173, 21)
        Me.txt_phno.TabIndex = 44
        '
        'txt_phcode
        '
        Me.txt_phcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_phcode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_phcode.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_phcode.Location = New System.Drawing.Point(132, 175)
        Me.txt_phcode.Name = "txt_phcode"
        Me.txt_phcode.Size = New System.Drawing.Size(96, 21)
        Me.txt_phcode.TabIndex = 43
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(14, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 18)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "Phone No"
        '
        'txt_nationality
        '
        Me.txt_nationality.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_nationality.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nationality.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_nationality.Location = New System.Drawing.Point(132, 148)
        Me.txt_nationality.Name = "txt_nationality"
        Me.txt_nationality.Size = New System.Drawing.Size(275, 21)
        Me.txt_nationality.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(14, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 18)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Nationality"
        '
        'txt_id
        '
        Me.txt_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_id.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_id.Location = New System.Drawing.Point(132, 55)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(275, 21)
        Me.txt_id.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(14, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 18)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Supplier PIN / ID  *"
        '
        'txt_address
        '
        Me.txt_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_address.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_address.Location = New System.Drawing.Point(132, 82)
        Me.txt_address.Multiline = True
        Me.txt_address.Name = "txt_address"
        Me.txt_address.Size = New System.Drawing.Size(275, 60)
        Me.txt_address.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(14, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 18)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Address"
        '
        'txt_name
        '
        Me.txt_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_name.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_name.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txt_name.Location = New System.Drawing.Point(132, 28)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(275, 21)
        Me.txt_name.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(14, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 18)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Supplier Name *"
        '
        'BaAddSupp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(828, 310)
        Me.Controls.Add(Me.CustomGroupBox3)
        Me.Controls.Add(Me.CustomGroupBox2)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BaAddSupp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Supplier"
        Me.CustomGroupBox3.ResumeLayout(False)
        Me.CustomGroupBox2.ResumeLayout(False)
        Me.CustomGroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents CustomGroupBox2 As Retailer.CustomGroupBox
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents CustomGroupBox3 As Retailer.CustomGroupBox
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents txt_city As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_phno As System.Windows.Forms.TextBox
    Friend WithEvents txt_phcode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_nationality As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_address As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_website As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_fax As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_postalcode As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_county As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
