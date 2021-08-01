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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtlp = New System.Windows.Forms.TextBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPre = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1028, 121)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(440, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        Me.Label2.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 121)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 488)
        Me.Panel2.TabIndex = 1
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(44, 269)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(113, 81)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Part Selection"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(44, 155)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(113, 81)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Start Mode"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtlp)
        Me.Panel3.Controls.Add(Me.btnNext)
        Me.Panel3.Controls.Add(Me.btnPre)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(200, 485)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(828, 124)
        Me.Panel3.TabIndex = 2
        '
        'txtlp
        '
        Me.txtlp.Location = New System.Drawing.Point(745, 43)
        Me.txtlp.Name = "txtlp"
        Me.txtlp.Size = New System.Drawing.Size(100, 20)
        Me.txtlp.TabIndex = 7
        Me.txtlp.Visible = False
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(445, 16)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(113, 81)
        Me.btnNext.TabIndex = 6
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        Me.btnNext.Visible = False
        '
        'btnPre
        '
        Me.btnPre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPre.Location = New System.Drawing.Point(189, 16)
        Me.btnPre.Name = "btnPre"
        Me.btnPre.Size = New System.Drawing.Size(113, 81)
        Me.btnPre.TabIndex = 5
        Me.btnPre.Text = "Previous"
        Me.btnPre.UseVisualStyleBackColor = True
        Me.btnPre.Visible = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(200, 121)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(828, 364)
        Me.Panel4.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "POKE ASSISTANT"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents txtlp As TextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPre As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
End Class
