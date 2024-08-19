<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormFormulationEntry
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCloseForm = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.txtFormulation = New MetroFramework.Controls.MetroTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClear = New Guna.UI.WinForms.GunaAdvenceButton()
        Me.btnSaveFormulation = New Guna.UI.WinForms.GunaAdvenceButton()
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
        Me.Panel1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Formulation Entry"
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
        Me.txtFormulation.Location = New System.Drawing.Point(12, 80)
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
        Me.txtFormulation.TabIndex = 22
        Me.txtFormulation.UseSelectable = True
        Me.txtFormulation.WaterMark = "Formulation"
        Me.txtFormulation.WaterMarkColor = System.Drawing.Color.FromArgb(CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer), CType(CType(109, Byte), Integer))
        Me.txtFormulation.WaterMarkFont = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 56)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 21)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Formulation"
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
        Me.btnClear.Location = New System.Drawing.Point(277, 121)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.OnHoverBaseColor = System.Drawing.Color.DarkGray
        Me.btnClear.OnHoverBorderColor = System.Drawing.Color.DarkGray
        Me.btnClear.OnHoverForeColor = System.Drawing.Color.White
        Me.btnClear.OnHoverImage = Nothing
        Me.btnClear.OnHoverLineColor = System.Drawing.Color.DarkGray
        Me.btnClear.OnPressedColor = System.Drawing.Color.DarkGray
        Me.btnClear.Size = New System.Drawing.Size(112, 41)
        Me.btnClear.TabIndex = 20
        Me.btnClear.Text = "Clear"
        Me.btnClear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSaveFormulation
        '
        Me.btnSaveFormulation.AnimationHoverSpeed = 0.07!
        Me.btnSaveFormulation.AnimationSpeed = 0.03!
        Me.btnSaveFormulation.BaseColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnSaveFormulation.BorderColor = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(207, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btnSaveFormulation.CheckedBaseColor = System.Drawing.Color.Gray
        Me.btnSaveFormulation.CheckedBorderColor = System.Drawing.Color.Gray
        Me.btnSaveFormulation.CheckedForeColor = System.Drawing.Color.White
        Me.btnSaveFormulation.CheckedImage = Nothing
        Me.btnSaveFormulation.CheckedLineColor = System.Drawing.Color.Gray
        Me.btnSaveFormulation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveFormulation.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnSaveFormulation.FocusedColor = System.Drawing.Color.Empty
        Me.btnSaveFormulation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveFormulation.ForeColor = System.Drawing.Color.White
        Me.btnSaveFormulation.Image = Nothing
        Me.btnSaveFormulation.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnSaveFormulation.LineColor = System.Drawing.Color.DarkGray
        Me.btnSaveFormulation.Location = New System.Drawing.Point(158, 121)
        Me.btnSaveFormulation.Name = "btnSaveFormulation"
        Me.btnSaveFormulation.OnHoverBaseColor = System.Drawing.Color.DarkGray
        Me.btnSaveFormulation.OnHoverBorderColor = System.Drawing.Color.DarkGray
        Me.btnSaveFormulation.OnHoverForeColor = System.Drawing.Color.White
        Me.btnSaveFormulation.OnHoverImage = Nothing
        Me.btnSaveFormulation.OnHoverLineColor = System.Drawing.Color.DarkGray
        Me.btnSaveFormulation.OnPressedColor = System.Drawing.Color.DarkGray
        Me.btnSaveFormulation.Size = New System.Drawing.Size(112, 41)
        Me.btnSaveFormulation.TabIndex = 19
        Me.btnSaveFormulation.Text = "Save"
        Me.btnSaveFormulation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FormFormulationEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(401, 171)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtFormulation)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSaveFormulation)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormFormulationEntry"
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
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClear As Guna.UI.WinForms.GunaAdvenceButton
    Friend WithEvents btnSaveFormulation As Guna.UI.WinForms.GunaAdvenceButton
End Class
