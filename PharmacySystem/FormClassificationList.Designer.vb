<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormClassificationList
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
        Me.btnAddCat = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnRefresh = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.btnCloseForm = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edit = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Delete = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.gunaGridCategories, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.btnCloseForm)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1551, 49)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Classification List"
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
        Me.gunaGridCategories.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(195, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(195, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gunaGridCategories.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.gunaGridCategories.ColumnHeadersHeight = 27
        Me.gunaGridCategories.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Edit, Me.Delete})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.gunaGridCategories.DefaultCellStyle = DataGridViewCellStyle3
        Me.gunaGridCategories.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gunaGridCategories.EnableHeadersVisualStyles = False
        Me.gunaGridCategories.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.gunaGridCategories.Location = New System.Drawing.Point(0, 120)
        Me.gunaGridCategories.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gunaGridCategories.MultiSelect = False
        Me.gunaGridCategories.Name = "gunaGridCategories"
        Me.gunaGridCategories.ReadOnly = True
        Me.gunaGridCategories.RowHeadersVisible = False
        Me.gunaGridCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.gunaGridCategories.Size = New System.Drawing.Size(1551, 850)
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
        Me.gunaGridCategories.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.gunaGridCategories.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gunaGridCategories.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.gunaGridCategories.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.gunaGridCategories.ThemeStyle.HeaderStyle.Height = 27
        Me.gunaGridCategories.ThemeStyle.ReadOnly = True
        Me.gunaGridCategories.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.gunaGridCategories.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.[Single]
        Me.gunaGridCategories.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gunaGridCategories.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.gunaGridCategories.ThemeStyle.RowsStyle.Height = 22
        Me.gunaGridCategories.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.Silver
        Me.gunaGridCategories.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White
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
        Me.btnAddCat.Location = New System.Drawing.Point(1160, 57)
        Me.btnAddCat.Name = "btnAddCat"
        Me.btnAddCat.OnHoverBaseColor = System.Drawing.Color.DarkGray
        Me.btnAddCat.OnHoverBorderColor = System.Drawing.Color.DarkGray
        Me.btnAddCat.OnHoverForeColor = System.Drawing.Color.White
        Me.btnAddCat.OnHoverImage = Nothing
        Me.btnAddCat.OnHoverLineColor = System.Drawing.Color.DarkGray
        Me.btnAddCat.OnPressedColor = System.Drawing.Color.DarkGray
        Me.btnAddCat.Size = New System.Drawing.Size(213, 55)
        Me.btnAddCat.TabIndex = 2
        Me.btnAddCat.Text = "Add Classification"
        Me.btnAddCat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.btnRefresh.Location = New System.Drawing.Point(1380, 57)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.OnHoverBaseColor = System.Drawing.Color.DarkGray
        Me.btnRefresh.OnHoverBorderColor = System.Drawing.Color.DarkGray
        Me.btnRefresh.OnHoverForeColor = System.Drawing.Color.White
        Me.btnRefresh.OnHoverImage = Nothing
        Me.btnRefresh.OnHoverLineColor = System.Drawing.Color.DarkGray
        Me.btnRefresh.OnPressedColor = System.Drawing.Color.DarkGray
        Me.btnRefresh.Size = New System.Drawing.Size(170, 55)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewImageColumn1.HeaderText = ""
        Me.DataGridViewImageColumn1.Image = Global.PharmacySystem.My.Resources.Resources.pencildatagrid
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.ReadOnly = True
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewImageColumn1.Width = 5
        '
        'DataGridViewImageColumn2
        '
        Me.DataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewImageColumn2.HeaderText = ""
        Me.DataGridViewImageColumn2.Image = Global.PharmacySystem.My.Resources.Resources.closedatagrid
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        Me.DataGridViewImageColumn2.ReadOnly = True
        Me.DataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridViewImageColumn2.Width = 5
        '
        'btnCloseForm
        '
        Me.btnCloseForm.AnimationHoverSpeed = 0.07!
        Me.btnCloseForm.AnimationSpeed = 0.03!
        Me.btnCloseForm.BaseColor = System.Drawing.Color.Transparent
        Me.btnCloseForm.BorderColor = System.Drawing.Color.Transparent
        Me.btnCloseForm.CheckedBaseColor = System.Drawing.Color.Transparent
        Me.btnCloseForm.CheckedBorderColor = System.Drawing.Color.Transparent
        Me.btnCloseForm.CheckedForeColor = System.Drawing.Color.Transparent
        Me.btnCloseForm.CheckedImage = Nothing
        Me.btnCloseForm.CheckedLineColor = System.Drawing.Color.Transparent
        Me.btnCloseForm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCloseForm.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnCloseForm.FocusedColor = System.Drawing.Color.Empty
        Me.btnCloseForm.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseForm.ForeColor = System.Drawing.Color.White
        Me.btnCloseForm.Image = Global.PharmacySystem.My.Resources.Resources.delete
        Me.btnCloseForm.ImageSize = New System.Drawing.Size(22, 22)
        Me.btnCloseForm.LineColor = System.Drawing.Color.Transparent
        Me.btnCloseForm.Location = New System.Drawing.Point(1504, 6)
        Me.btnCloseForm.Name = "btnCloseForm"
        Me.btnCloseForm.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btnCloseForm.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnCloseForm.OnHoverForeColor = System.Drawing.Color.Transparent
        Me.btnCloseForm.OnHoverImage = Global.PharmacySystem.My.Resources.Resources.delete__1_
        Me.btnCloseForm.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.btnCloseForm.OnPressedColor = System.Drawing.Color.Transparent
        Me.btnCloseForm.Size = New System.Drawing.Size(41, 38)
        Me.btnCloseForm.TabIndex = 4
        Me.btnCloseForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
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
        Me.Column3.HeaderText = "CLASSIFICATION NAME"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
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
        'FormClassificationList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1551, 970)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnAddCat)
        Me.Controls.Add(Me.gunaGridCategories)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormClassificationList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.gunaGridCategories, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents gunaGridCategories As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents btnAddCat As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnRefresh As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents btnCloseForm As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Edit As DataGridViewImageColumn
    Friend WithEvents Delete As DataGridViewImageColumn
End Class
