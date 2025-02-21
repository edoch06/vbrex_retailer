<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Backend
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Backend))
        Me.Main0MenuStrip = New System.Windows.Forms.MenuStrip
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ImportStockMasterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ImportStockBOHToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EditMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.StockMastersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StockDepartmentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StockGroupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StockClassToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.StockSizeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.StockColorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.StockStyleToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.StockUoMToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.SuppliersMastersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ViewMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusBarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolsMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.WindowsMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.NewWindowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CascadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TileVerticalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TileHorizontalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CloseAllToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ArrangeIconsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DatabaseConnectionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.StyleManager1 = New DevComponents.DotNetBar.StyleManager(Me.components)
        Me.lbl_connect = New System.Windows.Forms.Label
        Me.Main0MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Main0MenuStrip
        '
        Me.Main0MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.EditMenu, Me.ViewMenu, Me.ToolsMenu, Me.WindowsMenu, Me.HelpMenu, Me.SettingsToolStripMenuItem})
        Me.Main0MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.Main0MenuStrip.MdiWindowListItem = Me.WindowsMenu
        Me.Main0MenuStrip.Name = "Main0MenuStrip"
        Me.Main0MenuStrip.Size = New System.Drawing.Size(911, 24)
        Me.Main0MenuStrip.TabIndex = 5
        Me.Main0MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportStockMasterToolStripMenuItem, Me.ImportStockBOHToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(37, 20)
        Me.FileMenu.Text = "&File"
        '
        'ImportStockMasterToolStripMenuItem
        '
        Me.ImportStockMasterToolStripMenuItem.Image = Global.Retailer.My.Resources.Resources.importc24
        Me.ImportStockMasterToolStripMenuItem.Name = "ImportStockMasterToolStripMenuItem"
        Me.ImportStockMasterToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ImportStockMasterToolStripMenuItem.Text = "&Import Stock Master"
        '
        'ImportStockBOHToolStripMenuItem
        '
        Me.ImportStockBOHToolStripMenuItem.Image = Global.Retailer.My.Resources.Resources.importc24
        Me.ImportStockBOHToolStripMenuItem.Name = "ImportStockBOHToolStripMenuItem"
        Me.ImportStockBOHToolStripMenuItem.Size = New System.Drawing.Size(181, 22)
        Me.ImportStockBOHToolStripMenuItem.Text = "&Import Stock BOH"
        '
        'EditMenu
        '
        Me.EditMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StockMastersToolStripMenuItem, Me.SuppliersMastersToolStripMenuItem, Me.SToolStripMenuItem})
        Me.EditMenu.Name = "EditMenu"
        Me.EditMenu.Size = New System.Drawing.Size(55, 20)
        Me.EditMenu.Text = "&Master"
        '
        'StockMastersToolStripMenuItem
        '
        Me.StockMastersToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StockDepartmentsToolStripMenuItem, Me.StockGroupToolStripMenuItem, Me.StockClassToolStripMenuItem1, Me.StockSizeToolStripMenuItem1, Me.StockColorToolStripMenuItem1, Me.StockStyleToolStripMenuItem1, Me.StockUoMToolStripMenuItem1})
        Me.StockMastersToolStripMenuItem.Image = Global.Retailer.My.Resources.Resources.goldbars24
        Me.StockMastersToolStripMenuItem.Name = "StockMastersToolStripMenuItem"
        Me.StockMastersToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.StockMastersToolStripMenuItem.Text = "&Stock Coding Masters"
        '
        'StockDepartmentsToolStripMenuItem
        '
        Me.StockDepartmentsToolStripMenuItem.Name = "StockDepartmentsToolStripMenuItem"
        Me.StockDepartmentsToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.StockDepartmentsToolStripMenuItem.Text = "&Stock Departments"
        '
        'StockGroupToolStripMenuItem
        '
        Me.StockGroupToolStripMenuItem.Name = "StockGroupToolStripMenuItem"
        Me.StockGroupToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.StockGroupToolStripMenuItem.Text = "&Stock Group"
        '
        'StockClassToolStripMenuItem1
        '
        Me.StockClassToolStripMenuItem1.Name = "StockClassToolStripMenuItem1"
        Me.StockClassToolStripMenuItem1.Size = New System.Drawing.Size(174, 22)
        Me.StockClassToolStripMenuItem1.Text = "&Stock Class"
        '
        'StockSizeToolStripMenuItem1
        '
        Me.StockSizeToolStripMenuItem1.Name = "StockSizeToolStripMenuItem1"
        Me.StockSizeToolStripMenuItem1.Size = New System.Drawing.Size(174, 22)
        Me.StockSizeToolStripMenuItem1.Text = "&Stock Size"
        '
        'StockColorToolStripMenuItem1
        '
        Me.StockColorToolStripMenuItem1.Name = "StockColorToolStripMenuItem1"
        Me.StockColorToolStripMenuItem1.Size = New System.Drawing.Size(174, 22)
        Me.StockColorToolStripMenuItem1.Text = "&Stock Color"
        '
        'StockStyleToolStripMenuItem1
        '
        Me.StockStyleToolStripMenuItem1.Name = "StockStyleToolStripMenuItem1"
        Me.StockStyleToolStripMenuItem1.Size = New System.Drawing.Size(174, 22)
        Me.StockStyleToolStripMenuItem1.Text = "&Stock Style"
        '
        'StockUoMToolStripMenuItem1
        '
        Me.StockUoMToolStripMenuItem1.Name = "StockUoMToolStripMenuItem1"
        Me.StockUoMToolStripMenuItem1.Size = New System.Drawing.Size(174, 22)
        Me.StockUoMToolStripMenuItem1.Text = "&Stock UoM"
        '
        'SuppliersMastersToolStripMenuItem
        '
        Me.SuppliersMastersToolStripMenuItem.Image = Global.Retailer.My.Resources.Resources.usergroups24
        Me.SuppliersMastersToolStripMenuItem.Name = "SuppliersMastersToolStripMenuItem"
        Me.SuppliersMastersToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.SuppliersMastersToolStripMenuItem.Text = "&Suppliers Masters"
        '
        'SToolStripMenuItem
        '
        Me.SToolStripMenuItem.Image = Global.Retailer.My.Resources.Resources.pricetagc24
        Me.SToolStripMenuItem.Name = "SToolStripMenuItem"
        Me.SToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.SToolStripMenuItem.Text = "&Taxes"
        '
        'ViewMenu
        '
        Me.ViewMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolBarToolStripMenuItem, Me.StatusBarToolStripMenuItem})
        Me.ViewMenu.Name = "ViewMenu"
        Me.ViewMenu.Size = New System.Drawing.Size(44, 20)
        Me.ViewMenu.Text = "&View"
        '
        'ToolBarToolStripMenuItem
        '
        Me.ToolBarToolStripMenuItem.Checked = True
        Me.ToolBarToolStripMenuItem.CheckOnClick = True
        Me.ToolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ToolBarToolStripMenuItem.Name = "ToolBarToolStripMenuItem"
        Me.ToolBarToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.ToolBarToolStripMenuItem.Text = "&Toolbar"
        '
        'StatusBarToolStripMenuItem
        '
        Me.StatusBarToolStripMenuItem.Checked = True
        Me.StatusBarToolStripMenuItem.CheckOnClick = True
        Me.StatusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.StatusBarToolStripMenuItem.Name = "StatusBarToolStripMenuItem"
        Me.StatusBarToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.StatusBarToolStripMenuItem.Text = "&Status Bar"
        '
        'ToolsMenu
        '
        Me.ToolsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.ToolsMenu.Name = "ToolsMenu"
        Me.ToolsMenu.Size = New System.Drawing.Size(48, 20)
        Me.ToolsMenu.Text = "&Tools"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.OptionsToolStripMenuItem.Text = "&Options"
        '
        'WindowsMenu
        '
        Me.WindowsMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewWindowToolStripMenuItem, Me.CascadeToolStripMenuItem, Me.TileVerticalToolStripMenuItem, Me.TileHorizontalToolStripMenuItem, Me.CloseAllToolStripMenuItem, Me.ArrangeIconsToolStripMenuItem})
        Me.WindowsMenu.Name = "WindowsMenu"
        Me.WindowsMenu.Size = New System.Drawing.Size(68, 20)
        Me.WindowsMenu.Text = "&Windows"
        '
        'NewWindowToolStripMenuItem
        '
        Me.NewWindowToolStripMenuItem.Name = "NewWindowToolStripMenuItem"
        Me.NewWindowToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.NewWindowToolStripMenuItem.Text = "&New Window"
        '
        'CascadeToolStripMenuItem
        '
        Me.CascadeToolStripMenuItem.Name = "CascadeToolStripMenuItem"
        Me.CascadeToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CascadeToolStripMenuItem.Text = "&Cascade"
        '
        'TileVerticalToolStripMenuItem
        '
        Me.TileVerticalToolStripMenuItem.Name = "TileVerticalToolStripMenuItem"
        Me.TileVerticalToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.TileVerticalToolStripMenuItem.Text = "Tile &Vertical"
        '
        'TileHorizontalToolStripMenuItem
        '
        Me.TileHorizontalToolStripMenuItem.Name = "TileHorizontalToolStripMenuItem"
        Me.TileHorizontalToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.TileHorizontalToolStripMenuItem.Text = "Tile &Horizontal"
        '
        'CloseAllToolStripMenuItem
        '
        Me.CloseAllToolStripMenuItem.Name = "CloseAllToolStripMenuItem"
        Me.CloseAllToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.CloseAllToolStripMenuItem.Text = "C&lose All"
        '
        'ArrangeIconsToolStripMenuItem
        '
        Me.ArrangeIconsToolStripMenuItem.Name = "ArrangeIconsToolStripMenuItem"
        Me.ArrangeIconsToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.ArrangeIconsToolStripMenuItem.Text = "&Arrange Icons"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.ToolStripSeparator8, Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(44, 20)
        Me.HelpMenu.Text = "&Help"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ContentsToolStripMenuItem.Text = "&Contents"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Image = CType(resources.GetObject("IndexToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IndexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Image = CType(resources.GetObject("SearchToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SearchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.SearchToolStripMenuItem.Text = "&Search"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(165, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.AboutToolStripMenuItem.Text = "&About ..."
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatabaseConnectionsToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.SettingsToolStripMenuItem.Text = "&Settings"
        '
        'DatabaseConnectionsToolStripMenuItem
        '
        Me.DatabaseConnectionsToolStripMenuItem.Image = Global.Retailer.My.Resources.Resources.connectc24
        Me.DatabaseConnectionsToolStripMenuItem.Name = "DatabaseConnectionsToolStripMenuItem"
        Me.DatabaseConnectionsToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.DatabaseConnectionsToolStripMenuItem.Text = "&Database Connections"
        '
        'StatusStrip
        '
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(911, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'StyleManager1
        '
        Me.StyleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2007Blue
        Me.StyleManager1.MetroColorParameters = New DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(154, Byte), Integer)))
        '
        'lbl_connect
        '
        Me.lbl_connect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_connect.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lbl_connect.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.lbl_connect.Location = New System.Drawing.Point(801, 436)
        Me.lbl_connect.Name = "lbl_connect"
        Me.lbl_connect.Size = New System.Drawing.Size(83, 13)
        Me.lbl_connect.TabIndex = 104
        Me.lbl_connect.Text = "Connected "
        Me.lbl_connect.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Backend
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 453)
        Me.Controls.Add(Me.lbl_connect)
        Me.Controls.Add(Me.Main0MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.DoubleBuffered = True
        Me.EnableGlass = False
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.Main0MenuStrip
        Me.Name = "Backend"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Retail Backend"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Main0MenuStrip.ResumeLayout(False)
        Me.Main0MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ArrangeIconsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CloseAllToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewWindowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CascadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileVerticalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TileHorizontalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Main0MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents EditMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusBarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StyleManager1 As DevComponents.DotNetBar.StyleManager
    Friend WithEvents ImportStockMasterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportStockBOHToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbl_connect As System.Windows.Forms.Label
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DatabaseConnectionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockMastersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockDepartmentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockGroupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockClassToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockSizeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockColorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockStyleToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockUoMToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuppliersMastersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
