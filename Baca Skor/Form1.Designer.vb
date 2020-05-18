<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labelRerata = New System.Windows.Forms.Label()
        Me.tombolBaca = New System.Windows.Forms.Button()
        Me.tombolKeluar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rerata Ujian:"
        '
        'labelRerata
        '
        Me.labelRerata.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.labelRerata.Location = New System.Drawing.Point(89, 21)
        Me.labelRerata.Name = "labelRerata"
        Me.labelRerata.Size = New System.Drawing.Size(183, 23)
        Me.labelRerata.TabIndex = 1
        '
        'tombolBaca
        '
        Me.tombolBaca.Location = New System.Drawing.Point(16, 72)
        Me.tombolBaca.Name = "tombolBaca"
        Me.tombolBaca.Size = New System.Drawing.Size(114, 30)
        Me.tombolBaca.TabIndex = 2
        Me.tombolBaca.Text = "Baca Skor"
        Me.tombolBaca.UseVisualStyleBackColor = True
        '
        'tombolKeluar
        '
        Me.tombolKeluar.Location = New System.Drawing.Point(158, 72)
        Me.tombolKeluar.Name = "tombolKeluar"
        Me.tombolKeluar.Size = New System.Drawing.Size(114, 30)
        Me.tombolKeluar.TabIndex = 3
        Me.tombolKeluar.Text = "Keluar"
        Me.tombolKeluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 121)
        Me.Controls.Add(Me.tombolKeluar)
        Me.Controls.Add(Me.tombolBaca)
        Me.Controls.Add(Me.labelRerata)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Skor Ujian"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents labelRerata As System.Windows.Forms.Label
    Friend WithEvents tombolBaca As System.Windows.Forms.Button
    Friend WithEvents tombolKeluar As System.Windows.Forms.Button

End Class
