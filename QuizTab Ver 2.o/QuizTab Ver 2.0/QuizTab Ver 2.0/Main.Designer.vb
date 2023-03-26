<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lb_qt = New System.Windows.Forms.Label
        Me.btn_logout = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.panel_mq = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btn_enter1 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        Me.panel_mq.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.SpringGreen
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.lb_qt)
        Me.Panel1.Controls.Add(Me.btn_logout)
        Me.Panel1.Location = New System.Drawing.Point(-2, -2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(940, 103)
        Me.Panel1.TabIndex = 1
        '
        'lb_qt
        '
        Me.lb_qt.AutoSize = True
        Me.lb_qt.Font = New System.Drawing.Font("Segoe Condensed", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_qt.ForeColor = System.Drawing.Color.Black
        Me.lb_qt.Location = New System.Drawing.Point(31, 35)
        Me.lb_qt.Name = "lb_qt"
        Me.lb_qt.Size = New System.Drawing.Size(95, 31)
        Me.lb_qt.TabIndex = 0
        Me.lb_qt.Text = "QuizTab"
        '
        'btn_logout
        '
        Me.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_logout.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_logout.ForeColor = System.Drawing.Color.Black
        Me.btn_logout.Location = New System.Drawing.Point(799, 35)
        Me.btn_logout.Name = "btn_logout"
        Me.btn_logout.Size = New System.Drawing.Size(95, 31)
        Me.btn_logout.TabIndex = 2
        Me.btn_logout.Text = "Log out"
        Me.btn_logout.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(21, 117)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 46)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Add new question"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Location = New System.Drawing.Point(21, 182)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 46)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Manage question"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.Button3.FlatAppearance.BorderSize = 2
        Me.Button3.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.Black
        Me.Button3.Location = New System.Drawing.Point(21, 249)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(134, 51)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "View question detail"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button4.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.Button4.FlatAppearance.BorderSize = 2
        Me.Button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(21, 318)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(136, 46)
        Me.Button4.TabIndex = 2
        Me.Button4.Text = "all student"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'panel_mq
        '
        Me.panel_mq.BackColor = System.Drawing.Color.Honeydew
        Me.panel_mq.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panel_mq.Controls.Add(Me.Panel4)
        Me.panel_mq.Controls.Add(Me.Label4)
        Me.panel_mq.Controls.Add(Me.Label1)
        Me.panel_mq.Controls.Add(Me.btn_enter1)
        Me.panel_mq.Location = New System.Drawing.Point(512, 150)
        Me.panel_mq.Name = "panel_mq"
        Me.panel_mq.Size = New System.Drawing.Size(211, 225)
        Me.panel_mq.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Save or Print"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(11, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Make Quiz"
        '
        'btn_enter1
        '
        Me.btn_enter1.BackColor = System.Drawing.Color.White
        Me.btn_enter1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_enter1.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.btn_enter1.FlatAppearance.BorderSize = 2
        Me.btn_enter1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray
        Me.btn_enter1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen
        Me.btn_enter1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_enter1.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enter1.ForeColor = System.Drawing.Color.Black
        Me.btn_enter1.Location = New System.Drawing.Point(16, 173)
        Me.btn_enter1.Name = "btn_enter1"
        Me.btn_enter1.Size = New System.Drawing.Size(79, 35)
        Me.btn_enter1.TabIndex = 3
        Me.btn_enter1.Text = "Enter"
        Me.btn_enter1.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.Color.Lime
        Me.Button5.FlatAppearance.BorderSize = 2
        Me.Button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SpringGreen
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Font = New System.Drawing.Font("Segoe Condensed", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(21, 378)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(136, 46)
        Me.Button5.TabIndex = 2
        Me.Button5.Text = "Result"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BackgroundImage = Global.QuizTab_Ver_2._0.My.Resources.Resources.folder_plus_icon_128857
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel4.Location = New System.Drawing.Point(16, 15)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(83, 61)
        Me.Panel4.TabIndex = 0
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MintCream
        Me.ClientSize = New System.Drawing.Size(934, 436)
        Me.ControlBox = False
        Me.Controls.Add(Me.panel_mq)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panel_mq.ResumeLayout(False)
        Me.panel_mq.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_logout As System.Windows.Forms.Button
    Friend WithEvents lb_qt As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents panel_mq As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_enter1 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button

End Class
