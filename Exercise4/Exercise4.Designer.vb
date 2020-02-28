<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exercise4
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
        Me.lblSelection = New System.Windows.Forms.Label()
        Me.cboName = New System.Windows.Forms.ComboBox()
        Me.btnClick = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSelection
        '
        Me.lblSelection.AutoSize = True
        Me.lblSelection.Font = New System.Drawing.Font("Segoe UI Semibold", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelection.Location = New System.Drawing.Point(139, 83)
        Me.lblSelection.Name = "lblSelection"
        Me.lblSelection.Size = New System.Drawing.Size(350, 37)
        Me.lblSelection.TabIndex = 0
        Me.lblSelection.Text = "Please Make Your Selection"
        '
        'cboName
        '
        Me.cboName.Font = New System.Drawing.Font("Segoe UI", 10.125!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboName.FormattingEnabled = True
        Me.cboName.Location = New System.Drawing.Point(135, 142)
        Me.cboName.Name = "cboName"
        Me.cboName.Size = New System.Drawing.Size(368, 45)
        Me.cboName.TabIndex = 1
        '
        'btnClick
        '
        Me.btnClick.Location = New System.Drawing.Point(227, 230)
        Me.btnClick.Name = "btnClick"
        Me.btnClick.Size = New System.Drawing.Size(177, 45)
        Me.btnClick.TabIndex = 2
        Me.btnClick.Text = "Submit"
        Me.btnClick.UseVisualStyleBackColor = True
        '
        'Exercise4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(633, 370)
        Me.Controls.Add(Me.btnClick)
        Me.Controls.Add(Me.cboName)
        Me.Controls.Add(Me.lblSelection)
        Me.Name = "Exercise4"
        Me.Text = "Working with ComboBoxes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSelection As Label
    Friend WithEvents cboName As ComboBox
    Friend WithEvents btnClick As Button
End Class
