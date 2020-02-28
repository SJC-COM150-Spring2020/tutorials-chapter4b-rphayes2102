<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exercise3
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.grpUpgrades = New System.Windows.Forms.GroupBox()
        Me.btnClick = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.chkMemory = New System.Windows.Forms.CheckBox()
        Me.chkDrive = New System.Windows.Forms.CheckBox()
        Me.chkMouse = New System.Windows.Forms.CheckBox()
        Me.chkKeyboard = New System.Windows.Forms.CheckBox()
        Me.chkWeb = New System.Windows.Forms.CheckBox()
        Me.chkSurge = New System.Windows.Forms.CheckBox()
        Me.chkWarranty = New System.Windows.Forms.CheckBox()
        Me.lstOut = New System.Windows.Forms.ListBox()
        Me.grpUpgrades.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(58, 84)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(445, 65)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Computer Options"
        '
        'grpUpgrades
        '
        Me.grpUpgrades.Controls.Add(Me.chkWarranty)
        Me.grpUpgrades.Controls.Add(Me.chkSurge)
        Me.grpUpgrades.Controls.Add(Me.chkWeb)
        Me.grpUpgrades.Controls.Add(Me.chkKeyboard)
        Me.grpUpgrades.Controls.Add(Me.chkMouse)
        Me.grpUpgrades.Controls.Add(Me.chkDrive)
        Me.grpUpgrades.Controls.Add(Me.chkMemory)
        Me.grpUpgrades.Location = New System.Drawing.Point(69, 208)
        Me.grpUpgrades.Name = "grpUpgrades"
        Me.grpUpgrades.Size = New System.Drawing.Size(795, 360)
        Me.grpUpgrades.TabIndex = 1
        Me.grpUpgrades.TabStop = False
        Me.grpUpgrades.Text = "Choose Your Upgrades"
        '
        'btnClick
        '
        Me.btnClick.BackColor = System.Drawing.Color.Salmon
        Me.btnClick.FlatAppearance.BorderSize = 0
        Me.btnClick.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClick.Font = New System.Drawing.Font("Segoe UI Semibold", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClick.ForeColor = System.Drawing.Color.White
        Me.btnClick.Location = New System.Drawing.Point(69, 605)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(795, 91)
        Me.btnClick.TabIndex = 2
        Me.btnClick.Text = "Select Upgrades"
        Me.btnClick.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Silver
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Segoe UI Semibold", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClear.Location = New System.Drawing.Point(69, 962)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(200, 73)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Silver
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Segoe UI Semibold", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.Location = New System.Drawing.Point(665, 962)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(199, 73)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'chkMemory
        '
        Me.chkMemory.AutoSize = True
        Me.chkMemory.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMemory.Location = New System.Drawing.Point(46, 69)
        Me.chkMemory.Name = "chkMemory"
        Me.chkMemory.Size = New System.Drawing.Size(259, 41)
        Me.chkMemory.TabIndex = 0
        Me.chkMemory.Text = "Memory Upgrade"
        Me.chkMemory.UseVisualStyleBackColor = True
        '
        'chkDrive
        '
        Me.chkDrive.AutoSize = True
        Me.chkDrive.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkDrive.Location = New System.Drawing.Point(46, 135)
        Me.chkDrive.Name = "chkDrive"
        Me.chkDrive.Size = New System.Drawing.Size(249, 41)
        Me.chkDrive.TabIndex = 1
        Me.chkDrive.Text = "Large Hard Drive"
        Me.chkDrive.UseVisualStyleBackColor = True
        '
        'chkMouse
        '
        Me.chkMouse.AutoSize = True
        Me.chkMouse.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkMouse.Location = New System.Drawing.Point(46, 200)
        Me.chkMouse.Name = "chkMouse"
        Me.chkMouse.Size = New System.Drawing.Size(234, 41)
        Me.chkMouse.TabIndex = 2
        Me.chkMouse.Text = "Wireless Mouse"
        Me.chkMouse.UseVisualStyleBackColor = True
        '
        'chkKeyboard
        '
        Me.chkKeyboard.AutoSize = True
        Me.chkKeyboard.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkKeyboard.Location = New System.Drawing.Point(46, 268)
        Me.chkKeyboard.Name = "chkKeyboard"
        Me.chkKeyboard.Size = New System.Drawing.Size(268, 41)
        Me.chkKeyboard.TabIndex = 3
        Me.chkKeyboard.Text = "Wireless Keyboard"
        Me.chkKeyboard.UseVisualStyleBackColor = True
        '
        'chkWeb
        '
        Me.chkWeb.AutoSize = True
        Me.chkWeb.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWeb.Location = New System.Drawing.Point(444, 69)
        Me.chkWeb.Name = "chkWeb"
        Me.chkWeb.Size = New System.Drawing.Size(164, 41)
        Me.chkWeb.TabIndex = 4
        Me.chkWeb.Text = "Web Cam"
        Me.chkWeb.UseVisualStyleBackColor = True
        '
        'chkSurge
        '
        Me.chkSurge.AutoSize = True
        Me.chkSurge.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSurge.Location = New System.Drawing.Point(444, 135)
        Me.chkSurge.Name = "chkSurge"
        Me.chkSurge.Size = New System.Drawing.Size(233, 41)
        Me.chkSurge.TabIndex = 5
        Me.chkSurge.Text = "Surge Protector"
        Me.chkSurge.UseVisualStyleBackColor = True
        '
        'chkWarranty
        '
        Me.chkWarranty.AutoSize = True
        Me.chkWarranty.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkWarranty.Location = New System.Drawing.Point(444, 200)
        Me.chkWarranty.Name = "chkWarranty"
        Me.chkWarranty.Size = New System.Drawing.Size(273, 41)
        Me.chkWarranty.TabIndex = 6
        Me.chkWarranty.Text = "Extended Warranty"
        Me.chkWarranty.UseVisualStyleBackColor = True
        '
        'lstOut
        '
        Me.lstOut.FormattingEnabled = True
        Me.lstOut.ItemHeight = 25
        Me.lstOut.Location = New System.Drawing.Point(69, 731)
        Me.lstOut.Name = "lstOut"
        Me.lstOut.Size = New System.Drawing.Size(795, 179)
        Me.lstOut.TabIndex = 5
        '
        'Exercise3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(956, 1118)
        Me.Controls.Add(Me.lstOut)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnClick)
        Me.Controls.Add(Me.grpUpgrades)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "Exercise3"
        Me.Text = "Working with Checkboxes"
        Me.grpUpgrades.ResumeLayout(False)
        Me.grpUpgrades.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents grpUpgrades As GroupBox
    Friend WithEvents btnClick As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents chkWarranty As CheckBox
    Friend WithEvents chkSurge As CheckBox
    Friend WithEvents chkWeb As CheckBox
    Friend WithEvents chkKeyboard As CheckBox
    Friend WithEvents chkMouse As CheckBox
    Friend WithEvents chkDrive As CheckBox
    Friend WithEvents chkMemory As CheckBox
    Friend WithEvents lstOut As ListBox
End Class
