<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Change
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
        Me.Ubah = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Ubah
        '
        Me.Ubah.Location = New System.Drawing.Point(197, 227)
        Me.Ubah.Name = "Ubah"
        Me.Ubah.Size = New System.Drawing.Size(75, 23)
        Me.Ubah.TabIndex = 0
        Me.Ubah.Text = "Change"
        Me.Ubah.UseVisualStyleBackColor = True
        '
        'Change
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Ubah)
        Me.Name = "Change"
        Me.Text = "Mengubah BackColor"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Ubah As System.Windows.Forms.Button

End Class
