<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AplikasiLatihan
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
        Me.nameLabel = New System.Windows.Forms.Label()
        Me.nameText = New System.Windows.Forms.TextBox()
        Me.infoLabel = New System.Windows.Forms.Label()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.infoText = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lenghtLabel = New System.Windows.Forms.Label()
        Me.showButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'nameLabel
        '
        Me.nameLabel.AutoSize = True
        Me.nameLabel.Location = New System.Drawing.Point(22, 25)
        Me.nameLabel.Name = "nameLabel"
        Me.nameLabel.Size = New System.Drawing.Size(35, 13)
        Me.nameLabel.TabIndex = 0
        Me.nameLabel.Text = "Nama"
        '
        'nameText
        '
        Me.nameText.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nameText.Location = New System.Drawing.Point(87, 18)
        Me.nameText.Name = "nameText"
        Me.nameText.Size = New System.Drawing.Size(467, 20)
        Me.nameText.TabIndex = 1
        '
        'infoLabel
        '
        Me.infoLabel.AutoSize = True
        Me.infoLabel.Location = New System.Drawing.Point(22, 51)
        Me.infoLabel.Name = "infoLabel"
        Me.infoLabel.Size = New System.Drawing.Size(62, 13)
        Me.infoLabel.TabIndex = 3
        Me.infoLabel.Text = "Keterangan"
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.Location = New System.Drawing.Point(479, 263)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(75, 23)
        Me.OKButton.TabIndex = 4
        Me.OKButton.Text = "OK"
        Me.OKButton.UseVisualStyleBackColor = True
        '
        'infoText
        '
        Me.infoText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.infoText.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.infoText.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.infoText.ForeColor = System.Drawing.SystemColors.Info
        Me.infoText.Location = New System.Drawing.Point(88, 51)
        Me.infoText.Multiline = True
        Me.infoText.Name = "infoText"
        Me.infoText.ReadOnly = True
        Me.infoText.Size = New System.Drawing.Size(466, 123)
        Me.infoText.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 191)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Panjang Nama ="
        '
        'lenghtLabel
        '
        Me.lenghtLabel.AutoSize = True
        Me.lenghtLabel.Location = New System.Drawing.Point(94, 191)
        Me.lenghtLabel.Name = "lenghtLabel"
        Me.lenghtLabel.Size = New System.Drawing.Size(13, 13)
        Me.lenghtLabel.TabIndex = 7
        Me.lenghtLabel.Text = "0"
        '
        'showButton
        '
        Me.showButton.Location = New System.Drawing.Point(398, 263)
        Me.showButton.Name = "showButton"
        Me.showButton.Size = New System.Drawing.Size(75, 23)
        Me.showButton.TabIndex = 8
        Me.showButton.Text = "Show"
        Me.showButton.UseVisualStyleBackColor = True
        '
        'AplikasiLatihan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(578, 301)
        Me.Controls.Add(Me.showButton)
        Me.Controls.Add(Me.lenghtLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.infoText)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.infoLabel)
        Me.Controls.Add(Me.nameText)
        Me.Controls.Add(Me.nameLabel)
        Me.Name = "AplikasiLatihan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Aplikasi Latihan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nameLabel As System.Windows.Forms.Label
    Friend WithEvents nameText As System.Windows.Forms.TextBox
    Friend WithEvents infoLabel As System.Windows.Forms.Label
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents infoText As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lenghtLabel As System.Windows.Forms.Label
    Friend WithEvents showButton As System.Windows.Forms.Button

End Class
