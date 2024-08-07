<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCategoriesList
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gunaGridCategories = New Guna.UI.WinForms.GunaDataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAddCat = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.GunaAdvenceButton1 = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Panel1.SuspendLayout()
        CType(Me.gunaGridCategories, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Categories"
        '
        'gunaGridCategories
        '
        Me.gunaGridCategories.AllowUserToAddRows = False
        Me.gunaGridCategories.AllowUserToDeleteRows = False
        Me.gunaGridCategories.AllowUserToResizeColumns = False
        Me.gunaGridCategories.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.gunaGridCategories.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.gunaGridCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.gunaGridCategories.BackgroundColor = System.Drawing.Color.White
        Me.gunaGridCategories.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.gunaGridCategories.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gunaGridCategories.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(195, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gunaGridCategories.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.gunaGridCategories.ColumnHeadersHeight = 27
        Me.gunaGridCategories.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gunaGridCategories.DefaultCellStyle = DataGridViewCellStyle3
        Me.gunaGridCategories.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gunaGridCategories.EnableHeadersVisualStyles = False
        Me.gunaGridCategories.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gunaGridCategories.Location = New System.Drawing.Point(0, 144)
        Me.gunaGridCategories.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gunaGridCategories.Name = "gunaGridCategories"
        Me.gunaGridCategories.ReadOnly = True
        Me.gunaGridCategories.RowHeadersVisible = False
        Me.gunaGridCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gunaGridCategories.Size = New System.Drawing.Size(1559, 936)
        Me.gunaGridCategories.TabIndex = 1
        Me.gunaGridCategories.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.gunaGridCategories.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.gunaGridCategories.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.gunaGridCategories.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.gunaGridCategories.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.gunaGridCategories.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.gunaGridCategories.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.gunaGridCategories.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gunaGridCategories.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(195, Byte), Integer))
        Me.gunaGridCategories.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.gunaGridCategories.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gunaGridCategories.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.gunaGridCategories.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.gunaGridCategories.ThemeStyle.HeaderStyle.Height = 27
        Me.gunaGridCategories.ThemeStyle.ReadOnly = True
        Me.gunaGridCategories.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.gunaGridCategories.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.gunaGridCategories.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gunaGridCategories.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.gunaGridCategories.ThemeStyle.RowsStyle.Height = 22
        Me.gunaGridCategories.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.SystemColors.Control
        Me.gunaGridCategories.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.HeaderText = "#"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.Width = 42
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "ID"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column2.Visible = False
        Me.Column2.Width = 48
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "CATEGORY"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'btnAddCat
        '
        Me.btnAddCat.AnimationHoverSpeed = 0.07!
        Me.btnAddCat.AnimationSpeed = 0.03!
        Me.btnAddCat.BaseColor = System.Drawing.Color.LightSlateGray
        Me.btnAddCat.BorderColor = System.Drawing.Color.LightSlateGray
        Me.btnAddCat.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnAddCat.CheckedBorderColor = System.Drawing.Color.Gray
        Me.btnAddCat.CheckedForeColor = System.Drawing.Color.White
        Me.btnAddCat.CheckedImage = Nothing
        Me.btnAddCat.CheckedLineColor = System.Drawing.Color.Gray
        Me.btnAddCat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddCat.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAddCat.FocusedColor = System.Drawing.Color.Empty
        Me.btnAddCat.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCat.ForeColor = System.Drawing.Color.White
        Me.btnAddCat.Image = Nothing
        Me.btnAddCat.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnAddCat.LineColor = System.Drawing.Color.DarkGray
        Me.btnAddCat.Location = New System.Drawing.Point(1196, 81)
        Me.btnAddCat.Name = "btnAddCat"
        Me.btnAddCat.OnHoverBaseColor = System.Drawing.Color.DarkGray
        Me.btnAddCat.OnHoverBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddCat.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAddCat.OnHoverImage = Nothing
        Me.btnAddCat.OnHoverLineColor = System.Drawing.Color.DarkGray
        Me.btnAddCat.OnPressedColor = System.Drawing.Color.DarkGray
        Me.btnAddCat.Size = New System.Drawing.Size(170, 55)
        Me.btnAddCat.TabIndex = 2
        Me.btnAddCat.Text = "Add Category"
        Me.btnAddCat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaAdvenceButton1
        '
        Me.GunaAdvenceButton1.AnimationHoverSpeed = 0.07!
        Me.GunaAdvenceButton1.AnimationSpeed = 0.03!
        Me.GunaAdvenceButton1.BaseColor = System.Drawing.Color.LightSlateGray
        Me.GunaAdvenceButton1.BorderColor = System.Drawing.Color.LightSlateGray
        Me.GunaAdvenceButton1.CheckedBaseColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.CheckedBorderColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.CheckedForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.CheckedImage = Nothing
        Me.GunaAdvenceButton1.CheckedLineColor = System.Drawing.Color.Gray
        Me.GunaAdvenceButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaAdvenceButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaAdvenceButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaAdvenceButton1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaAdvenceButton1.ForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.Image = Nothing
        Me.GunaAdvenceButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaAdvenceButton1.LineColor = System.Drawing.Color.DarkGray
        Me.GunaAdvenceButton1.Location = New System.Drawing.Point(1381, 81)
        Me.GunaAdvenceButton1.Name = "GunaAdvenceButton1"
        Me.GunaAdvenceButton1.OnHoverBaseColor = System.Drawing.Color.DarkGray
        Me.GunaAdvenceButton1.OnHoverBorderColor = System.Drawing.Color.DarkGray
        Me.GunaAdvenceButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaAdvenceButton1.OnHoverImage = Nothing
        Me.GunaAdvenceButton1.OnHoverLineColor = System.Drawing.Color.DarkGray
        Me.GunaAdvenceButton1.OnPressedColor = System.Drawing.Color.DarkGray
        Me.GunaAdvenceButton1.Size = New System.Drawing.Size(170, 55)
        Me.GunaAdvenceButton1.TabIndex = 3
        Me.GunaAdvenceButton1.Text = "Refresh"
        Me.GunaAdvenceButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FormCategoriesList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1559, 1080)
        Me.ControlBox = False
        Me.Controls.Add(Me.GunaAdvenceButton1)
        Me.Controls.Add(Me.btnAddCat)
        Me.Controls.Add(Me.gunaGridCategories)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormCategoriesList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.gunaGridCategories, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents gunaGridCategories As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents btnAddCat As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents GunaAdvenceButton1 As Guna.UI.WinForms.GunaAdvenceButton
End Class
