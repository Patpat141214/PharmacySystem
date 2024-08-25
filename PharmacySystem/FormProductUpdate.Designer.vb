<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormProductUpdate
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCloseForm = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtQty = New MetroFramework.Controls.MetroTextBox()
        Me.txtPrice = New MetroFramework.Controls.MetroTextBox()
        Me.lblIDForm = New System.Windows.Forms.Label()
        Me.lblIDType = New System.Windows.Forms.Label()
        Me.lblIDClass = New System.Windows.Forms.Label()
        Me.lblIDGeneric = New System.Windows.Forms.Label()
        Me.lblIDBrand = New System.Windows.Forms.Label()
        Me.btnRevert = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnUpdateProduct = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.txtReorder = New MetroFramework.Controls.MetroTextBox()
        Me.txtFormulation = New MetroFramework.Controls.MetroTextBox()
        Me.txtType = New MetroFramework.Controls.MetroTextBox()
        Me.txtClassification = New MetroFramework.Controls.MetroTextBox()
        Me.txtGeneric = New MetroFramework.Controls.MetroTextBox()
        Me.txtBarcode = New MetroFramework.Controls.MetroTextBox()
        Me.txtBrand = New MetroFramework.Controls.MetroTextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnCloseForm)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(588, 49)
        Me.Panel1.TabIndex = 4
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
        Me.btnCloseForm.Location = New System.Drawing.Point(542, 5)
        Me.btnCloseForm.Name = "btnCloseForm"
        Me.btnCloseForm.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btnCloseForm.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnCloseForm.OnHoverForeColor = System.Drawing.Color.Transparent
        Me.btnCloseForm.OnHoverImage = Global.PharmacySystem.My.Resources.Resources.delete__1_
        Me.btnCloseForm.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.btnCloseForm.OnPressedColor = System.Drawing.Color.Transparent
        Me.btnCloseForm.Size = New System.Drawing.Size(41, 38)
        Me.btnCloseForm.TabIndex = 3
        Me.btnCloseForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Update Product"
        '
        'txtQty
        '
        '
        '
        '
        Me.txtQty.CustomButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQty.CustomButton.Image = Nothing
        Me.txtQty.CustomButton.Location = New System.Drawing.Point(534, 1)
        Me.txtQty.CustomButton.Name = ""
        Me.txtQty.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtQty.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtQty.CustomButton.TabIndex = 1
        Me.txtQty.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtQty.CustomButton.UseSelectable = True
        Me.txtQty.CustomButton.Visible = False
        Me.txtQty.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtQty.Lines = New String(-1) {}
        Me.txtQty.Location = New System.Drawing.Point(12, 408)
        Me.txtQty.MaxLength = 32767
        Me.txtQty.Name = "txtQty"
        Me.txtQty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtQty.PromptText = "Initial Qty"
        Me.txtQty.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtQty.SelectedText = ""
        Me.txtQty.SelectionLength = 0
        Me.txtQty.SelectionStart = 0
        Me.txtQty.ShortcutsEnabled = True
        Me.txtQty.Size = New System.Drawing.Size(562, 29)
        Me.txtQty.TabIndex = 44
        Me.txtQty.UseSelectable = True
        Me.txtQty.WaterMark = "Initial Qty"
        Me.txtQty.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtQty.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtPrice
        '
        '
        '
        '
        Me.txtPrice.CustomButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.CustomButton.Image = Nothing
        Me.txtPrice.CustomButton.Location = New System.Drawing.Point(534, 1)
        Me.txtPrice.CustomButton.Name = ""
        Me.txtPrice.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtPrice.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtPrice.CustomButton.TabIndex = 1
        Me.txtPrice.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtPrice.CustomButton.UseSelectable = True
        Me.txtPrice.CustomButton.Visible = False
        Me.txtPrice.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtPrice.Lines = New String(-1) {}
        Me.txtPrice.Location = New System.Drawing.Point(12, 373)
        Me.txtPrice.MaxLength = 32767
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtPrice.PromptText = "Price"
        Me.txtPrice.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtPrice.SelectedText = ""
        Me.txtPrice.SelectionLength = 0
        Me.txtPrice.SelectionStart = 0
        Me.txtPrice.ShortcutsEnabled = True
        Me.txtPrice.Size = New System.Drawing.Size(562, 29)
        Me.txtPrice.TabIndex = 43
        Me.txtPrice.UseSelectable = True
        Me.txtPrice.WaterMark = "Price"
        Me.txtPrice.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtPrice.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lblIDForm
        '
        Me.lblIDForm.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDForm.Location = New System.Drawing.Point(573, 252)
        Me.lblIDForm.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIDForm.Name = "lblIDForm"
        Me.lblIDForm.Size = New System.Drawing.Size(15, 21)
        Me.lblIDForm.TabIndex = 42
        '
        'lblIDType
        '
        Me.lblIDType.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDType.Location = New System.Drawing.Point(573, 217)
        Me.lblIDType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIDType.Name = "lblIDType"
        Me.lblIDType.Size = New System.Drawing.Size(15, 21)
        Me.lblIDType.TabIndex = 41
        '
        'lblIDClass
        '
        Me.lblIDClass.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDClass.Location = New System.Drawing.Point(573, 181)
        Me.lblIDClass.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIDClass.Name = "lblIDClass"
        Me.lblIDClass.Size = New System.Drawing.Size(15, 21)
        Me.lblIDClass.TabIndex = 40
        '
        'lblIDGeneric
        '
        Me.lblIDGeneric.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDGeneric.Location = New System.Drawing.Point(573, 147)
        Me.lblIDGeneric.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIDGeneric.Name = "lblIDGeneric"
        Me.lblIDGeneric.Size = New System.Drawing.Size(15, 21)
        Me.lblIDGeneric.TabIndex = 39
        '
        'lblIDBrand
        '
        Me.lblIDBrand.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIDBrand.Location = New System.Drawing.Point(573, 113)
        Me.lblIDBrand.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIDBrand.Name = "lblIDBrand"
        Me.lblIDBrand.Size = New System.Drawing.Size(15, 21)
        Me.lblIDBrand.TabIndex = 38
        '
        'btnRevert
        '
        Me.btnRevert.AnimationHoverSpeed = 0.07!
        Me.btnRevert.AnimationSpeed = 0.03!
        Me.btnRevert.BaseColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnRevert.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnRevert.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnRevert.CheckedBorderColor = System.Drawing.Color.Gray
        Me.btnRevert.CheckedForeColor = System.Drawing.Color.White
        Me.btnRevert.CheckedImage = Nothing
        Me.btnRevert.CheckedLineColor = System.Drawing.Color.Gray
        Me.btnRevert.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRevert.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnRevert.FocusedColor = System.Drawing.Color.Empty
        Me.btnRevert.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRevert.ForeColor = System.Drawing.Color.White
        Me.btnRevert.Image = Nothing
        Me.btnRevert.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnRevert.LineColor = System.Drawing.Color.DarkGray
        Me.btnRevert.Location = New System.Drawing.Point(297, 592)
        Me.btnRevert.Name = "btnRevert"
        Me.btnRevert.OnHoverBaseColor = System.Drawing.Color.DarkGray
        Me.btnRevert.OnHoverBorderColor = System.Drawing.Color.DarkGray
        Me.btnRevert.OnHoverForeColor = System.Drawing.Color.White
        Me.btnRevert.OnHoverImage = Nothing
        Me.btnRevert.OnHoverLineColor = System.Drawing.Color.DarkGray
        Me.btnRevert.OnPressedColor = System.Drawing.Color.DarkGray
        Me.btnRevert.Size = New System.Drawing.Size(112, 41)
        Me.btnRevert.TabIndex = 37
        Me.btnRevert.Text = "Revert"
        Me.btnRevert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnUpdateProduct
        '
        Me.btnUpdateProduct.AnimationHoverSpeed = 0.07!
        Me.btnUpdateProduct.AnimationSpeed = 0.03!
        Me.btnUpdateProduct.BaseColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnUpdateProduct.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnUpdateProduct.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnUpdateProduct.CheckedBorderColor = System.Drawing.Color.Gray
        Me.btnUpdateProduct.CheckedForeColor = System.Drawing.Color.White
        Me.btnUpdateProduct.CheckedImage = Nothing
        Me.btnUpdateProduct.CheckedLineColor = System.Drawing.Color.Gray
        Me.btnUpdateProduct.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateProduct.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnUpdateProduct.FocusedColor = System.Drawing.Color.Empty
        Me.btnUpdateProduct.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateProduct.ForeColor = System.Drawing.Color.White
        Me.btnUpdateProduct.Image = Nothing
        Me.btnUpdateProduct.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnUpdateProduct.LineColor = System.Drawing.Color.DarkGray
        Me.btnUpdateProduct.Location = New System.Drawing.Point(178, 592)
        Me.btnUpdateProduct.Name = "btnUpdateProduct"
        Me.btnUpdateProduct.OnHoverBaseColor = System.Drawing.Color.DarkGray
        Me.btnUpdateProduct.OnHoverBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateProduct.OnHoverForeColor = System.Drawing.Color.White
        Me.btnUpdateProduct.OnHoverImage = Nothing
        Me.btnUpdateProduct.OnHoverLineColor = System.Drawing.Color.DarkGray
        Me.btnUpdateProduct.OnPressedColor = System.Drawing.Color.DarkGray
        Me.btnUpdateProduct.Size = New System.Drawing.Size(112, 41)
        Me.btnUpdateProduct.TabIndex = 36
        Me.btnUpdateProduct.Text = "Update"
        Me.btnUpdateProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtReorder
        '
        '
        '
        '
        Me.txtReorder.CustomButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReorder.CustomButton.Image = Nothing
        Me.txtReorder.CustomButton.Location = New System.Drawing.Point(534, 1)
        Me.txtReorder.CustomButton.Name = ""
        Me.txtReorder.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtReorder.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtReorder.CustomButton.TabIndex = 1
        Me.txtReorder.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtReorder.CustomButton.UseSelectable = True
        Me.txtReorder.CustomButton.Visible = False
        Me.txtReorder.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtReorder.Lines = New String(-1) {}
        Me.txtReorder.Location = New System.Drawing.Point(12, 338)
        Me.txtReorder.MaxLength = 32767
        Me.txtReorder.Name = "txtReorder"
        Me.txtReorder.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReorder.PromptText = "Re-Order Level"
        Me.txtReorder.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtReorder.SelectedText = ""
        Me.txtReorder.SelectionLength = 0
        Me.txtReorder.SelectionStart = 0
        Me.txtReorder.ShortcutsEnabled = True
        Me.txtReorder.Size = New System.Drawing.Size(562, 29)
        Me.txtReorder.TabIndex = 35
        Me.txtReorder.UseSelectable = True
        Me.txtReorder.WaterMark = "Re-Order Level"
        Me.txtReorder.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtReorder.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtFormulation
        '
        '
        '
        '
        Me.txtFormulation.CustomButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFormulation.CustomButton.Image = Nothing
        Me.txtFormulation.CustomButton.Location = New System.Drawing.Point(534, 1)
        Me.txtFormulation.CustomButton.Name = ""
        Me.txtFormulation.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtFormulation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFormulation.CustomButton.TabIndex = 1
        Me.txtFormulation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFormulation.CustomButton.UseSelectable = True
        Me.txtFormulation.CustomButton.Visible = False
        Me.txtFormulation.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtFormulation.Lines = New String(-1) {}
        Me.txtFormulation.Location = New System.Drawing.Point(12, 303)
        Me.txtFormulation.MaxLength = 32767
        Me.txtFormulation.Name = "txtFormulation"
        Me.txtFormulation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFormulation.PromptText = "Formulation"
        Me.txtFormulation.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFormulation.SelectedText = ""
        Me.txtFormulation.SelectionLength = 0
        Me.txtFormulation.SelectionStart = 0
        Me.txtFormulation.ShortcutsEnabled = True
        Me.txtFormulation.Size = New System.Drawing.Size(562, 29)
        Me.txtFormulation.TabIndex = 34
        Me.txtFormulation.UseSelectable = True
        Me.txtFormulation.WaterMark = "Formulation"
        Me.txtFormulation.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFormulation.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtType
        '
        '
        '
        '
        Me.txtType.CustomButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtType.CustomButton.Image = Nothing
        Me.txtType.CustomButton.Location = New System.Drawing.Point(534, 1)
        Me.txtType.CustomButton.Name = ""
        Me.txtType.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtType.CustomButton.TabIndex = 1
        Me.txtType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtType.CustomButton.UseSelectable = True
        Me.txtType.CustomButton.Visible = False
        Me.txtType.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtType.Lines = New String(-1) {}
        Me.txtType.Location = New System.Drawing.Point(12, 268)
        Me.txtType.MaxLength = 32767
        Me.txtType.Name = "txtType"
        Me.txtType.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtType.PromptText = "Type"
        Me.txtType.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtType.SelectedText = ""
        Me.txtType.SelectionLength = 0
        Me.txtType.SelectionStart = 0
        Me.txtType.ShortcutsEnabled = True
        Me.txtType.Size = New System.Drawing.Size(562, 29)
        Me.txtType.TabIndex = 33
        Me.txtType.UseSelectable = True
        Me.txtType.WaterMark = "Type"
        Me.txtType.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtType.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtClassification
        '
        '
        '
        '
        Me.txtClassification.CustomButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClassification.CustomButton.Image = Nothing
        Me.txtClassification.CustomButton.Location = New System.Drawing.Point(534, 1)
        Me.txtClassification.CustomButton.Name = ""
        Me.txtClassification.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtClassification.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtClassification.CustomButton.TabIndex = 1
        Me.txtClassification.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtClassification.CustomButton.UseSelectable = True
        Me.txtClassification.CustomButton.Visible = False
        Me.txtClassification.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtClassification.Lines = New String(-1) {}
        Me.txtClassification.Location = New System.Drawing.Point(12, 233)
        Me.txtClassification.MaxLength = 32767
        Me.txtClassification.Name = "txtClassification"
        Me.txtClassification.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtClassification.PromptText = "Classification"
        Me.txtClassification.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtClassification.SelectedText = ""
        Me.txtClassification.SelectionLength = 0
        Me.txtClassification.SelectionStart = 0
        Me.txtClassification.ShortcutsEnabled = True
        Me.txtClassification.Size = New System.Drawing.Size(562, 29)
        Me.txtClassification.TabIndex = 32
        Me.txtClassification.UseSelectable = True
        Me.txtClassification.WaterMark = "Classification"
        Me.txtClassification.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtClassification.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtGeneric
        '
        '
        '
        '
        Me.txtGeneric.CustomButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGeneric.CustomButton.Image = Nothing
        Me.txtGeneric.CustomButton.Location = New System.Drawing.Point(534, 1)
        Me.txtGeneric.CustomButton.Name = ""
        Me.txtGeneric.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtGeneric.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtGeneric.CustomButton.TabIndex = 1
        Me.txtGeneric.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtGeneric.CustomButton.UseSelectable = True
        Me.txtGeneric.CustomButton.Visible = False
        Me.txtGeneric.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtGeneric.Lines = New String(-1) {}
        Me.txtGeneric.Location = New System.Drawing.Point(12, 198)
        Me.txtGeneric.MaxLength = 32767
        Me.txtGeneric.Name = "txtGeneric"
        Me.txtGeneric.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtGeneric.PromptText = "Generic Name"
        Me.txtGeneric.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtGeneric.SelectedText = ""
        Me.txtGeneric.SelectionLength = 0
        Me.txtGeneric.SelectionStart = 0
        Me.txtGeneric.ShortcutsEnabled = True
        Me.txtGeneric.Size = New System.Drawing.Size(562, 29)
        Me.txtGeneric.TabIndex = 31
        Me.txtGeneric.UseSelectable = True
        Me.txtGeneric.WaterMark = "Generic Name"
        Me.txtGeneric.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtGeneric.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtBarcode
        '
        '
        '
        '
        Me.txtBarcode.CustomButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBarcode.CustomButton.Image = Nothing
        Me.txtBarcode.CustomButton.Location = New System.Drawing.Point(534, 1)
        Me.txtBarcode.CustomButton.Name = ""
        Me.txtBarcode.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtBarcode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBarcode.CustomButton.TabIndex = 1
        Me.txtBarcode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBarcode.CustomButton.UseSelectable = True
        Me.txtBarcode.CustomButton.Visible = False
        Me.txtBarcode.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtBarcode.Lines = New String(-1) {}
        Me.txtBarcode.Location = New System.Drawing.Point(12, 100)
        Me.txtBarcode.MaxLength = 32767
        Me.txtBarcode.Name = "txtBarcode"
        Me.txtBarcode.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBarcode.PromptText = "Barcode"
        Me.txtBarcode.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBarcode.SelectedText = ""
        Me.txtBarcode.SelectionLength = 0
        Me.txtBarcode.SelectionStart = 0
        Me.txtBarcode.ShortcutsEnabled = True
        Me.txtBarcode.Size = New System.Drawing.Size(562, 29)
        Me.txtBarcode.TabIndex = 29
        Me.txtBarcode.UseSelectable = True
        Me.txtBarcode.WaterMark = "Barcode"
        Me.txtBarcode.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBarcode.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'txtBrand
        '
        '
        '
        '
        Me.txtBrand.CustomButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrand.CustomButton.Image = Nothing
        Me.txtBrand.CustomButton.Location = New System.Drawing.Point(534, 1)
        Me.txtBrand.CustomButton.Name = ""
        Me.txtBrand.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtBrand.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBrand.CustomButton.TabIndex = 1
        Me.txtBrand.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBrand.CustomButton.UseSelectable = True
        Me.txtBrand.CustomButton.Visible = False
        Me.txtBrand.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtBrand.Lines = New String(-1) {}
        Me.txtBrand.Location = New System.Drawing.Point(12, 163)
        Me.txtBrand.MaxLength = 32767
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBrand.PromptText = "Brand Name"
        Me.txtBrand.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBrand.SelectedText = ""
        Me.txtBrand.SelectionLength = 0
        Me.txtBrand.SelectionStart = 0
        Me.txtBrand.ShortcutsEnabled = True
        Me.txtBrand.Size = New System.Drawing.Size(562, 29)
        Me.txtBrand.TabIndex = 30
        Me.txtBrand.UseSelectable = True
        Me.txtBrand.WaterMark = "Brand Name"
        Me.txtBrand.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBrand.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'FormProductUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(588, 645)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtQty)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.lblIDForm)
        Me.Controls.Add(Me.lblIDType)
        Me.Controls.Add(Me.lblIDClass)
        Me.Controls.Add(Me.lblIDGeneric)
        Me.Controls.Add(Me.lblIDBrand)
        Me.Controls.Add(Me.btnRevert)
        Me.Controls.Add(Me.btnUpdateProduct)
        Me.Controls.Add(Me.txtReorder)
        Me.Controls.Add(Me.txtFormulation)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.txtClassification)
        Me.Controls.Add(Me.txtGeneric)
        Me.Controls.Add(Me.txtBrand)
        Me.Controls.Add(Me.txtBarcode)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormProductUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCloseForm As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtQty As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtPrice As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblIDForm As Label
    Friend WithEvents lblIDType As Label
    Friend WithEvents lblIDClass As Label
    Friend WithEvents lblIDGeneric As Label
    Friend WithEvents lblIDBrand As Label
    Friend WithEvents btnRevert As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnUpdateProduct As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents txtReorder As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtFormulation As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtType As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtClassification As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtGeneric As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtBarcode As MetroFramework.Controls.MetroTextBox
    Friend WithEvents txtBrand As MetroFramework.Controls.MetroTextBox
End Class
