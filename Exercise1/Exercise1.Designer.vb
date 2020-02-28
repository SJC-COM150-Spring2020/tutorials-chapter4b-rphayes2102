<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Exercise1
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
        Me.lblHello = New System.Windows.Forms.Label()
        Me.btnHello = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHello
        '
        Me.lblHello.AutoSize = True
        Me.lblHello.Font = New System.Drawing.Font("Segoe Script", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHello.Location = New System.Drawing.Point(184, 176)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(358, 159)
        Me.lblHello.TabIndex = 0
        Me.lblHello.Text = "Hello!"
        '
        'btnHello
        '
        Me.btnHello.BackColor = System.Drawing.Color.Teal
        Me.btnHello.FlatAppearance.BorderSize = 0
        Me.btnHello.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHello.Font = New System.Drawing.Font("Segoe UI Semibold", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHello.ForeColor = System.Drawing.Color.White
        Me.btnHello.Location = New System.Drawing.Point(283, 399)
        Me.btnHello.Name = "btnHello"
        Me.btnHello.Size = New System.Drawing.Size(173, 62)
        Me.btnHello.TabIndex = 1
        Me.btnHello.Text = "Say Hi!"
        Me.btnHello.UseVisualStyleBackColor = False
        '
        'Exercise1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(742, 660)
        Me.Controls.Add(Me.btnHello)
        Me.Controls.Add(Me.lblHello)
        Me.Name = "Exercise1"
        Me.Text = "Visbility Exercise"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHello As Label
    Friend WithEvents btnHello As Button
End Class
