<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Front
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
        Me.lb_qt1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btn_register = New System.Windows.Forms.Button
        Me.btn_login = New System.Windows.Forms.Button
        Me.lb_qt = New System.Windows.Forms.Label
        Me.lb_t = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lb_qt1
        '
        Me.lb_qt1.AutoSize = True
        Me.lb_qt1.BackColor = System.Drawing.Color.Transparent
        Me.lb_qt1.Font = New System.Drawing.Font("Segoe Condensed", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_qt1.ForeColor = System.Drawing.Color.ForestGreen
        Me.lb_qt1.Location = New System.Drawing.Point(388, 242)
        Me.lb_qt1.Name = "lb_qt1"
        Me.lb_qt1.Size = New System.Drawing.Size(140, 46)
        Me.lb_qt1.TabIndex = 5
        Me.lb_qt1.Text = "QuizTab"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SpringGreen
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btn_register)
        Me.Panel1.Controls.Add(Me.btn_login)
        Me.Panel1.Controls.Add(Me.lb_qt)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(919, 103)
        Me.Panel1.TabIndex = 4
        '
        'btn_register
        '
        Me.btn_register.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_register.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_register.ForeColor = System.Drawing.Color.White
        Me.btn_register.Location = New System.Drawing.Point(607, 34)
        Me.btn_register.Name = "btn_register"
        Me.btn_register.Size = New System.Drawing.Size(138, 31)
        Me.btn_register.TabIndex = 3
        Me.btn_register.Text = "Register"
        Me.btn_register.UseVisualStyleBackColor = True
        '
        'btn_login
        '
        Me.btn_login.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_login.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(751, 34)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(138, 31)
        Me.btn_login.TabIndex = 3
        Me.btn_login.Text = "Log in"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'lb_qt
        '
        Me.lb_qt.AutoSize = True
        Me.lb_qt.Font = New System.Drawing.Font("Segoe Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_qt.ForeColor = System.Drawing.Color.White
        Me.lb_qt.Location = New System.Drawing.Point(23, 34)
        Me.lb_qt.Name = "lb_qt"
        Me.lb_qt.Size = New System.Drawing.Size(95, 31)
        Me.lb_qt.TabIndex = 0
        Me.lb_qt.Text = "QuizTab"
        '
        'lb_t
        '
        Me.lb_t.AutoSize = True
        Me.lb_t.BackColor = System.Drawing.Color.Transparent
        Me.lb_t.Font = New System.Drawing.Font("Segoe Condensed", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_t.ForeColor = System.Drawing.Color.ForestGreen
        Me.lb_t.Location = New System.Drawing.Point(278, 302)
        Me.lb_t.Name = "lb_t"
        Me.lb_t.Size = New System.Drawing.Size(367, 24)
        Me.lb_t.TabIndex = 6
        Me.lb_t.Text = "A simple quiz system for educational purposes."
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Honeydew
        Me.Button1.BackgroundImage = Global.QuizTab_Ver_2._0.My.Resources.Resources.log_out_icon_icons_com_50106
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(859, 444)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 37)
        Me.Button1.TabIndex = 7
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Front
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(917, 487)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lb_qt1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lb_t)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Front"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lb_qt1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_login As System.Windows.Forms.Button
    Friend WithEvents lb_qt As System.Windows.Forms.Label
    Friend WithEvents lb_t As System.Windows.Forms.Label
    Friend WithEvents btn_register As System.Windows.Forms.Button
End Class
