<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Exercise2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblChooseSize = New System.Windows.Forms.Label()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.lstSelection = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'lblChooseSize
        '
        Me.lblChooseSize.AutoSize = True
        Me.lblChooseSize.Font = New System.Drawing.Font("Segoe UI", 13.875!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChooseSize.Location = New System.Drawing.Point(54, 71)
        Me.lblChooseSize.Name = "lblChooseSize"
        Me.lblChooseSize.Size = New System.Drawing.Size(356, 50)
        Me.lblChooseSize.TabIndex = 0
        Me.lblChooseSize.Text = "Choose a Soda Size"
        '
        'btnSelect
        '
        Me.btnSelect.BackColor = System.Drawing.Color.Gold
        Me.btnSelect.FlatAppearance.BorderSize = 0
        Me.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSelect.Font = New System.Drawing.Font("Segoe UI Semibold", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelect.Location = New System.Drawing.Point(63, 546)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(209, 60)
        Me.btnSelect.TabIndex = 1
        Me.btnSelect.Text = "Selection"
        Me.btnSelect.UseVisualStyleBackColor = False
        '
        'lstSelection
        '
        Me.lstSelection.FormattingEnabled = True
        Me.lstSelection.ItemHeight = 25
        Me.lstSelection.Location = New System.Drawing.Point(460, 195)
        Me.lstSelection.Name = "lstSelection"
        Me.lstSelection.Size = New System.Drawing.Size(396, 329)
        Me.lstSelection.TabIndex = 2
        '
        'Exercise2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(936, 700)
        Me.Controls.Add(Me.lstSelection)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.lblChooseSize)
        Me.Name = "Exercise2"
        Me.Text = "Working with GroupBoxes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblChooseSize As Label
    Friend WithEvents btnSelect As Button
    Friend WithEvents lstSelection As ListBox
End Class
