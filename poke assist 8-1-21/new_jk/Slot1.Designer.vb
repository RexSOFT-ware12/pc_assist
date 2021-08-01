<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Slot1
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
        Me.Houseing2 = New System.Windows.Forms.Panel()
        Me.Pin1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Houseing2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Houseing2
        '
        Me.Houseing2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Houseing2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Houseing2.Controls.Add(Me.Pin1)
        Me.Houseing2.Location = New System.Drawing.Point(170, 325)
        Me.Houseing2.Margin = New System.Windows.Forms.Padding(2)
        Me.Houseing2.Name = "Houseing2"
        Me.Houseing2.Size = New System.Drawing.Size(765, 108)
        Me.Houseing2.TabIndex = 0
        '
        'Pin1
        '
        Me.Pin1.BackColor = System.Drawing.Color.DimGray
        Me.Pin1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pin1.Location = New System.Drawing.Point(75, 21)
        Me.Pin1.Name = "Pin1"
        Me.Pin1.Size = New System.Drawing.Size(39, 35)
        Me.Pin1.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(244, 192)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 131)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Slot1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Houseing2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Slot1"
        Me.Text = "Slot1"
        Me.Houseing2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Houseing2 As Panel
    Friend WithEvents Pin1 As Label
    Friend WithEvents Label1 As Label
End Class
