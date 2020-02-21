<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SklCombo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCp = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLvl = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.idCombo = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label1.Location = New System.Drawing.Point(48, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 39)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "School"
        '
        'SklCombo
        '
        Me.SklCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.SklCombo.FormattingEnabled = True
        Me.SklCombo.Location = New System.Drawing.Point(292, 99)
        Me.SklCombo.Name = "SklCombo"
        Me.SklCombo.Size = New System.Drawing.Size(425, 46)
        Me.SklCombo.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label3.Location = New System.Drawing.Point(48, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 39)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cellphone"
        '
        'txtCp
        '
        Me.txtCp.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.txtCp.Location = New System.Drawing.Point(292, 236)
        Me.txtCp.Name = "txtCp"
        Me.txtCp.Size = New System.Drawing.Size(425, 45)
        Me.txtCp.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label4.Location = New System.Drawing.Point(48, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 39)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label5.Location = New System.Drawing.Point(48, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(213, 39)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "School Level"
        '
        'txtLvl
        '
        Me.txtLvl.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.txtLvl.Location = New System.Drawing.Point(292, 167)
        Me.txtLvl.Name = "txtLvl"
        Me.txtLvl.Size = New System.Drawing.Size(425, 45)
        Me.txtLvl.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label2.Location = New System.Drawing.Point(48, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 39)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "ID"
        '
        'idCombo
        '
        Me.idCombo.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.idCombo.FormattingEnabled = True
        Me.idCombo.Location = New System.Drawing.Point(292, 39)
        Me.idCombo.Name = "idCombo"
        Me.idCombo.Size = New System.Drawing.Size(425, 46)
        Me.idCombo.TabIndex = 15
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.idCombo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtLvl)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCp)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SklCombo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents SklCombo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCp As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtLvl As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents idCombo As ComboBox
End Class
