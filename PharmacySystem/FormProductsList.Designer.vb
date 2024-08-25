<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProductsList
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gunaGridProducts = New Guna.UI.WinForms.GunaDataGridView()
        Me.btnRefresh = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnAddProduct = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.gunaGridProducts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1559, 68)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Products"
        '
        'gunaGridProducts
        '
        Me.gunaGridProducts.AllowUserToAddRows = False
        Me.gunaGridProducts.AllowUserToDeleteRows = False
        Me.gunaGridProducts.AllowUserToResizeColumns = False
        Me.gunaGridProducts.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.gunaGridProducts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.gunaGridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gunaGridProducts.BackgroundColor = System.Drawing.Color.White
        Me.gunaGridProducts.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gunaGridProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(195, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(195, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gunaGridProducts.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.gunaGridProducts.ColumnHeadersHeight = 27
        Me.gunaGridProducts.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Edit, Me.Delete})
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gunaGridProducts.DefaultCellStyle = DataGridViewCellStyle6
        Me.gunaGridProducts.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gunaGridProducts.EnableHeadersVisualStyles = False
        Me.gunaGridProducts.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gunaGridProducts.Location = New System.Drawing.Point(0, 139)
        Me.gunaGridProducts.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gunaGridProducts.MultiSelect = False
        Me.gunaGridProducts.Name = "gunaGridProducts"
        Me.gunaGridProducts.ReadOnly = True
        Me.gunaGridProducts.RowHeadersVisible = False
        Me.gunaGridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gunaGridProducts.Size = New System.Drawing.Size(1559, 941)
        Me.gunaGridProducts.TabIndex = 3
        Me.gunaGridProducts.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.gunaGridProducts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.gunaGridProducts.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.gunaGridProducts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.gunaGridProducts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.gunaGridProducts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.gunaGridProducts.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.gunaGridProducts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gunaGridProducts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gunaGridProducts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.gunaGridProducts.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gunaGridProducts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.gunaGridProducts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.gunaGridProducts.ThemeStyle.HeaderStyle.Height = 27
        Me.gunaGridProducts.ThemeStyle.ReadOnly = True
        Me.gunaGridProducts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.gunaGridProducts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.[Single]
        Me.gunaGridProducts.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gunaGridProducts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.gunaGridProducts.ThemeStyle.RowsStyle.Height = 22
        Me.gunaGridProducts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.gunaGridProducts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
        '
        'btnRefresh
        '
        Me.btnRefresh.AnimationHoverSpeed = 0.07!
        Me.btnRefresh.AnimationSpeed = 0.03!
        Me.btnRefresh.BaseColor = System.Drawing.Color.LightSlateGray
        Me.btnRefresh.BorderColor = System.Drawing.Color.LightSlateGray
        Me.btnRefresh.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnRefresh.CheckedBorderColor = System.Drawing.Color.Gray
        Me.btnRefresh.CheckedForeColor = System.Drawing.Color.White
        Me.btnRefresh.CheckedImage = Nothing
        Me.btnRefresh.CheckedLineColor = System.Drawing.Color.Gray
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRefresh.FocusedColor = System.Drawing.Color.Empty
        Me.btnRefresh.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.White
        Me.btnRefresh.Image = Nothing
        Me.btnRefresh.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnRefresh.LineColor = System.Drawing.Color.DarkGray
        Me.btnRefresh.Location = New System.Drawing.Point(1388, 76)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.OnHoverBaseColor = System.Drawing.Color.DarkGray
        Me.btnRefresh.OnHoverBorderColor = System.Drawing.Color.DarkGray
        Me.btnRefresh.OnHoverForeColor = System.Drawing.Color.White
        Me.btnRefresh.OnHoverImage = Nothing
        Me.btnRefresh.OnHoverLineColor = System.Drawing.Color.DarkGray
        Me.btnRefresh.OnPressedColor = System.Drawing.Color.DarkGray
        Me.btnRefresh.Size = New System.Drawing.Size(170, 55)
        Me.btnRefresh.TabIndex = 10
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAddProduct
        '
        Me.btnAddProduct.AnimationHoverSpeed = 0.07!
        Me.btnAddProduct.AnimationSpeed = 0.03!
        Me.btnAddProduct.BaseColor = System.Drawing.Color.LightSlateGray
        Me.btnAddProduct.BorderColor = System.Drawing.Color.LightSlateGray
        Me.btnAddProduct.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnAddProduct.CheckedBorderColor = System.Drawing.Color.Gray
        Me.btnAddProduct.CheckedForeColor = System.Drawing.Color.White
        Me.btnAddProduct.CheckedImage = Nothing
        Me.btnAddProduct.CheckedLineColor = System.Drawing.Color.Gray
        Me.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddProduct.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAddProduct.FocusedColor = System.Drawing.Color.Empty
        Me.btnAddProduct.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProduct.ForeColor = System.Drawing.Color.White
        Me.btnAddProduct.Image = Nothing
        Me.btnAddProduct.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAddProduct.LineColor = System.Drawing.Color.DarkGray
        Me.btnAddProduct.Location = New System.Drawing.Point(1168, 76)
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.OnHoverBaseColor = System.Drawing.Color.DarkGray
        Me.btnAddProduct.OnHoverBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddProduct.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAddProduct.OnHoverImage = Nothing
        Me.btnAddProduct.OnHoverLineColor = System.Drawing.Color.DarkGray
        Me.btnAddProduct.OnPressedColor = System.Drawing.Color.DarkGray
        Me.btnAddProduct.Size = New System.Drawing.Size(213, 55)
        Me.btnAddProduct.TabIndex = 9
        Me.btnAddProduct.Text = "Add Product"
        Me.btnAddProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "#"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.Width = 43
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "ID"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column2.Visible = False
        Me.Column2.Width = 49
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "BARCODE"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "BRAND NAME"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column4.Width = 134
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "GENERIC NAME"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column5.Width = 145
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "CLASSIFICATION"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column6.Width = 151
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "TYPE"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column7.Width = 68
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column8.HeaderText = "FORMULATION"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column8.Width = 142
        '
        'Column9
        '
        Me.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column9.HeaderText = "RE-ORDER"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column9.Width = 109
        '
        'Column10
        '
        Me.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column10.HeaderText = "PRICE"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column10.Width = 75
        '
        'Column11
        '
        Me.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column11.HeaderText = "STOCK ON HAND"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column11.Width = 157
        '
        'Edit
        '
        Me.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Edit.HeaderText = ""
        Me.Edit.Image = Global.PharmacySystem.My.Resources.Resources.pencildatagrid
        Me.Edit.Name = "Edit"
        Me.Edit.ReadOnly = True
        Me.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Edit.Width = 5
        '
        'Delete
        '
        Me.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Delete.HeaderText = ""
        Me.Delete.Image = Global.PharmacySystem.My.Resources.Resources.closedatagrid
        Me.Delete.Name = "Delete"
        Me.Delete.ReadOnly = True
        Me.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Delete.Width = 5
        '
        'FormProductsList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1559, 1080)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnAddProduct)
        Me.Controls.Add(Me.gunaGridProducts)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormProductsList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.gunaGridProducts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents gunaGridProducts As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents btnRefresh As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnAddProduct As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Edit As DataGridViewImageColumn
    Friend WithEvents Delete As DataGridViewImageColumn
End Class
