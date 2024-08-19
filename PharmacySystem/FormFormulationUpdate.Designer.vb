<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFormulationUpdate
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
        Me.txtFormulation = New MetroFramework.Controls.MetroTextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRevert = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnUpdateFormulation = New Guna.UI.WinForms.GunaAdvenceButton()
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
        Me.Panel1.TabIndex = 5
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
        Me.btnCloseForm.Location = New System.Drawing.Point(355, 5)
        Me.btnCloseForm.Name = "btnCloseForm"
        Me.btnCloseForm.OnHoverBaseColor = System.Drawing.Color.Transparent
        Me.btnCloseForm.OnHoverBorderColor = System.Drawing.Color.Transparent
        Me.btnCloseForm.OnHoverForeColor = System.Drawing.Color.Transparent
        Me.btnCloseForm.OnHoverImage = Global.PharmacySystem.My.Resources.Resources.delete__1_
        Me.btnCloseForm.OnHoverLineColor = System.Drawing.Color.Transparent
        Me.btnCloseForm.OnPressedColor = System.Drawing.Color.Transparent
        Me.btnCloseForm.Size = New System.Drawing.Size(41, 38)
        Me.btnCloseForm.TabIndex = 3
        Me.btnCloseForm.Text = "0"
        Me.btnCloseForm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Update Formulation"
        '
        'txtFormulation
        '
        '
        '
        '
        Me.txtFormulation.CustomButton.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFormulation.CustomButton.Image = Nothing
        Me.txtFormulation.CustomButton.Location = New System.Drawing.Point(349, 1)
        Me.txtFormulation.CustomButton.Name = ""
        Me.txtFormulation.CustomButton.Size = New System.Drawing.Size(27, 27)
        Me.txtFormulation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue
        Me.txtFormulation.CustomButton.TabIndex = 1
        Me.txtFormulation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light
        Me.txtFormulation.CustomButton.UseSelectable = True
        Me.txtFormulation.CustomButton.Visible = False
        Me.txtFormulation.FontSize = MetroFramework.MetroTextBoxSize.Medium
        Me.txtFormulation.Lines = New String(-1) {}
        Me.txtFormulation.Location = New System.Drawing.Point(13, 82)
        Me.txtFormulation.MaxLength = 32767
        Me.txtFormulation.Name = "txtFormulation"
        Me.txtFormulation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtFormulation.PromptText = "Formulation"
        Me.txtFormulation.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.txtFormulation.SelectedText = ""
        Me.txtFormulation.SelectionLength = 0
        Me.txtFormulation.SelectionStart = 0
        Me.txtFormulation.ShortcutsEnabled = True
        Me.txtFormulation.Size = New System.Drawing.Size(377, 29)
        Me.txtFormulation.TabIndex = 24
        Me.txtFormulation.UseSelectable = True
        Me.txtFormulation.WaterMark = "Formulation"
        Me.txtFormulation.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFormulation.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblID.Location = New System.Drawing.Point(12, 143)
        Me.lblID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(0, 21)
        Me.lblID.TabIndex = 23
        Me.lblID.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 21)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Formulation"
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
        Me.btnRevert.Location = New System.Drawing.Point(278, 123)
        Me.btnRevert.Name = "btnRevert"
        Me.btnRevert.OnHoverBaseColor = System.Drawing.Color.DarkGray
        Me.btnRevert.OnHoverBorderColor = System.Drawing.Color.DarkGray
        Me.btnRevert.OnHoverForeColor = System.Drawing.Color.White
        Me.btnRevert.OnHoverImage = Nothing
        Me.btnRevert.OnHoverLineColor = System.Drawing.Color.DarkGray
        Me.btnRevert.OnPressedColor = System.Drawing.Color.DarkGray
        Me.btnRevert.Size = New System.Drawing.Size(112, 41)
        Me.btnRevert.TabIndex = 21
        Me.btnRevert.Text = "Revert"
        Me.btnRevert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnUpdateFormulation
        '
        Me.btnUpdateFormulation.AnimationHoverSpeed = 0.07!
        Me.btnUpdateFormulation.AnimationSpeed = 0.03!
        Me.btnUpdateFormulation.BaseColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnUpdateFormulation.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnUpdateFormulation.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnUpdateFormulation.CheckedBorderColor = System.Drawing.Color.Gray
        Me.btnUpdateFormulation.CheckedForeColor = System.Drawing.Color.White
        Me.btnUpdateFormulation.CheckedImage = Nothing
        Me.btnUpdateFormulation.CheckedLineColor = System.Drawing.Color.Gray
        Me.btnUpdateFormulation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnUpdateFormulation.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnUpdateFormulation.FocusedColor = System.Drawing.Color.Empty
        Me.btnUpdateFormulation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateFormulation.ForeColor = System.Drawing.Color.White
        Me.btnUpdateFormulation.Image = Nothing
        Me.btnUpdateFormulation.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnUpdateFormulation.LineColor = System.Drawing.Color.DarkGray
        Me.btnUpdateFormulation.Location = New System.Drawing.Point(159, 123)
        Me.btnUpdateFormulation.Name = "btnUpdateFormulation"
        Me.btnUpdateFormulation.OnHoverBaseColor = System.Drawing.Color.DarkGray
        Me.btnUpdateFormulation.OnHoverBorderColor = System.Drawing.Color.DarkGray
        Me.btnUpdateFormulation.OnHoverForeColor = System.Drawing.Color.White
        Me.btnUpdateFormulation.OnHoverImage = Nothing
        Me.btnUpdateFormulation.OnHoverLineColor = System.Drawing.Color.DarkGray
        Me.btnUpdateFormulation.OnPressedColor = System.Drawing.Color.DarkGray
        Me.btnUpdateFormulation.Size = New System.Drawing.Size(112, 41)
        Me.btnUpdateFormulation.TabIndex = 20
        Me.btnUpdateFormulation.Text = "Update"
        Me.btnUpdateFormulation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FormFormulationUpdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(401, 171)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtFormulation)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnRevert)
        Me.Controls.Add(Me.btnUpdateFormulation)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormFormulationUpdate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnCloseForm As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFormulation As MetroFramework.Controls.MetroTextBox
    Friend WithEvents lblID As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRevert As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnUpdateFormulation As Guna.UI.WinForms.GunaAdvenceButton
End Class
