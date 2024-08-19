<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdateBrand
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
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClear = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnUpdateBrand = New Guna.UI.WinForms.GunaAdvenceButton()
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
        Me.Panel1.Size = New System.Drawing.Size(401, 49)
        Me.Panel1.TabIndex = 3
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
        Me.btnCloseForm.Location = New System.Drawing.Point(354, 5)
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
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Update Brand"
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(7, 137)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(0, 21)
        Me.lblID.TabIndex = 15
        Me.lblID.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 21)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Brand"
        '
        'btnClear
        '
        Me.btnClear.AnimationHoverSpeed = 0.07!
        Me.btnClear.AnimationSpeed = 0.03!
        Me.btnClear.BaseColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnClear.BorderColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnClear.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnClear.CheckedBorderColor = System.Drawing.Color.Gray
        Me.btnClear.CheckedForeColor = System.Drawing.Color.White
        Me.btnClear.CheckedImage = Nothing
        Me.btnClear.CheckedLineColor = System.Drawing.Color.Gray
        Me.btnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnClear.FocusedColor = System.Drawing.Color.Empty
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Image = Nothing
        Me.btnClear.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnClear.LineColor = System.Drawing.Color.DarkGray
        Me.btnClear.Location = New System.Drawing.Point(276, 119)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.OnHoverBaseColor = System.Drawing.Color.DarkGray
        Me.btnClear.OnHoverBorderColor = System.Drawing.Color.DarkGray
        Me.btnClear.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClear.OnHoverImage = Nothing
        Me.btnClear.OnHoverLineColor = System.Drawing.Color.DarkGray
        Me.btnClear.OnPressedColor = System.Drawing.Color.DarkGray
        Me.btnClear.Size = New System.Drawing.Size(112, 41)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Revert"
        Me.btnClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnUpdateBrand
        '
        Me.btnUpdateBrand.AnimationHoverSpeed = 0.07!
        Me.btnUpdateBrand.AnimationSpeed = 0.03!
        Me.btnUpdateBrand.BaseColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnUpdateBrand.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnUpdateBrand.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnUpdateBrand.CheckedBorderColor = System.Drawing.Color.Gray
        Me.btnUpdateBrand.CheckedForeColor = System.Drawing.Color.White
        Me.btnUpdateBrand.CheckedImage = Nothing
        Me.btnUpdateBrand.CheckedLineColor = System.Drawing.Color.Gray
        Me.btnUpdateBrand.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateBrand.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnUpdateBrand.FocusedColor = System.Drawing.Color.Empty
        Me.btnUpdateBrand.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateBrand.ForeColor = System.Drawing.Color.White
        Me.btnUpdateBrand.Image = Nothing
        Me.btnUpdateBrand.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnUpdateBrand.LineColor = System.Drawing.Color.DarkGray
        Me.btnUpdateBrand.Location = New System.Drawing.Point(158, 119)
        Me.btnUpdateBrand.Name = "btnUpdateBrand"
        Me.btnUpdateBrand.OnHoverBaseColor = System.Drawing.Color.DarkGray
        Me.btnUpdateBrand.OnHoverBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateBrand.OnHoverForeColor = System.Drawing.Color.White
        Me.btnUpdateBrand.OnHoverImage = Nothing
        Me.btnUpdateBrand.OnHoverLineColor = System.Drawing.Color.DarkGray
        Me.btnUpdateBrand.OnPressedColor = System.Drawing.Color.DarkGray
        Me.btnUpdateBrand.Size = New System.Drawing.Size(112, 41)
        Me.btnUpdateBrand.TabIndex = 12
        Me.btnUpdateBrand.Text = "Update"
        Me.btnUpdateBrand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBrand
        '
        '
        '
        '
        Me.txtBrand.CustomButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrand.CustomButton.Image = Nothing
        Me.txtBrand.CustomButton.Location = New System.Drawing.Point(349, 1)
        Me.txtBrand.CustomButton.Name = ""
        Me.txtBrand.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtBrand.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtBrand.CustomButton.TabIndex = 1
        Me.txtBrand.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtBrand.CustomButton.UseSelectable = True
        Me.txtBrand.CustomButton.Visible = False
        Me.txtBrand.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtBrand.Lines = New String(-1) {}
        Me.txtBrand.Location = New System.Drawing.Point(11, 78)
        Me.txtBrand.MaxLength = 32767
        Me.txtBrand.Name = "txtBrand"
        Me.txtBrand.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtBrand.PromptText = "Brand"
        Me.txtBrand.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtBrand.SelectedText = ""
        Me.txtBrand.SelectionLength = 0
        Me.txtBrand.SelectionStart = 0
        Me.txtBrand.ShortcutsEnabled = True
        Me.txtBrand.Size = New System.Drawing.Size(377, 29)
        Me.txtBrand.TabIndex = 16
        Me.txtBrand.UseSelectable = True
        Me.txtBrand.WaterMark = "Brand"
        Me.txtBrand.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtBrand.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'FormUpdateBrand
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(401, 171)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtBrand)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnUpdateBrand)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormUpdateBrand"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCloseForm As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label1 As Label
    Friend WithEvents lblID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClear As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnUpdateBrand As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents txtBrand As MetroFramework.Controls.MetroTextBox
End Class
