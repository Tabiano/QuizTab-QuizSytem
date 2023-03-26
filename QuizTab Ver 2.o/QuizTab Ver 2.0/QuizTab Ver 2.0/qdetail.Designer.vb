<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class qdetail
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.cb_mc = New System.Windows.Forms.CheckBox
        Me.cb_timer = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.btn_close = New System.Windows.Forms.Button
        Me.btn_update = New System.Windows.Forms.Button
        Me.gb_id = New System.Windows.Forms.GroupBox
        Me.lb_date = New System.Windows.Forms.Label
        Me.txt_id = New System.Windows.Forms.TextBox
        Me.btn_create = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl_pass = New System.Windows.Forms.Label
        Me.lbl_qb = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_name = New System.Windows.Forms.Label
        Me.txt_pass = New System.Windows.Forms.TextBox
        Me.txt_qname = New System.Windows.Forms.TextBox
        Me.txt_sub = New System.Windows.Forms.TextBox
        Me.Panel1.SuspendLayout()
        Me.gb_id.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Controls.Add(Me.cb_mc)
        Me.Panel1.Controls.Add(Me.cb_timer)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.btn_close)
        Me.Panel1.Controls.Add(Me.btn_update)
        Me.Panel1.Controls.Add(Me.gb_id)
        Me.Panel1.Controls.Add(Me.btn_create)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lbl_pass)
        Me.Panel1.Controls.Add(Me.lbl_qb)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.lbl_name)
        Me.Panel1.Controls.Add(Me.txt_pass)
        Me.Panel1.Controls.Add(Me.txt_qname)
        Me.Panel1.Controls.Add(Me.txt_sub)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(405, 575)
        Me.Panel1.TabIndex = 1
        '
        'cb_mc
        '
        Me.cb_mc.AutoSize = True
        Me.cb_mc.Font = New System.Drawing.Font("Microsoft New Tai Lue", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_mc.Location = New System.Drawing.Point(20, 430)
        Me.cb_mc.Name = "cb_mc"
        Me.cb_mc.Size = New System.Drawing.Size(150, 25)
        Me.cb_mc.TabIndex = 12
        Me.cb_mc.Text = "Multiple Choice"
        Me.cb_mc.UseVisualStyleBackColor = True
        '
        'cb_timer
        '
        Me.cb_timer.Font = New System.Drawing.Font("Microsoft New Tai Lue", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_timer.FormattingEnabled = True
        Me.cb_timer.Items.AddRange(New Object() {"5 min", "10 min", "30 min"})
        Me.cb_timer.Location = New System.Drawing.Point(24, 353)
        Me.cb_timer.Name = "cb_timer"
        Me.cb_timer.Size = New System.Drawing.Size(253, 28)
        Me.cb_timer.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Snow
        Me.Label7.Location = New System.Drawing.Point(21, 384)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(215, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "*If you don't want timer leave the field blank."
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Tomato
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_close.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_close.Location = New System.Drawing.Point(23, 500)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(97, 47)
        Me.btn_close.TabIndex = 2
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'btn_update
        '
        Me.btn_update.BackColor = System.Drawing.Color.Silver
        Me.btn_update.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_update.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(128, 500)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(97, 47)
        Me.btn_update.TabIndex = 3
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = False
        '
        'gb_id
        '
        Me.gb_id.Controls.Add(Me.lb_date)
        Me.gb_id.Controls.Add(Me.txt_id)
        Me.gb_id.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gb_id.Location = New System.Drawing.Point(265, 27)
        Me.gb_id.Name = "gb_id"
        Me.gb_id.Size = New System.Drawing.Size(125, 67)
        Me.gb_id.TabIndex = 2
        Me.gb_id.TabStop = False
        Me.gb_id.Text = "ID:"
        '
        'lb_date
        '
        Me.lb_date.AutoSize = True
        Me.lb_date.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_date.Location = New System.Drawing.Point(57, 12)
        Me.lb_date.Name = "lb_date"
        Me.lb_date.Size = New System.Drawing.Size(32, 17)
        Me.lb_date.TabIndex = 11
        Me.lb_date.Text = "Date"
        '
        'txt_id
        '
        Me.txt_id.Enabled = False
        Me.txt_id.Location = New System.Drawing.Point(6, 32)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(109, 23)
        Me.txt_id.TabIndex = 0
        '
        'btn_create
        '
        Me.btn_create.BackColor = System.Drawing.Color.SpringGreen
        Me.btn_create.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_create.Font = New System.Drawing.Font("Microsoft New Tai Lue", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_create.Location = New System.Drawing.Point(235, 500)
        Me.btn_create.Name = "btn_create"
        Me.btn_create.Size = New System.Drawing.Size(97, 47)
        Me.btn_create.TabIndex = 4
        Me.btn_create.Text = "Create"
        Me.btn_create.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(16, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "*You can always edit details later."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(21, 288)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(197, 26)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "*In able to be accessible, you should set" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " password to you'r quiz."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft New Tai Lue", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 235)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Password:"
        '
        'lbl_pass
        '
        Me.lbl_pass.AutoSize = True
        Me.lbl_pass.Font = New System.Drawing.Font("Microsoft New Tai Lue", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_pass.Location = New System.Drawing.Point(20, 330)
        Me.lbl_pass.Name = "lbl_pass"
        Me.lbl_pass.Size = New System.Drawing.Size(54, 20)
        Me.lbl_pass.TabIndex = 6
        Me.lbl_pass.Text = "Timer:"
        '
        'lbl_qb
        '
        Me.lbl_qb.AutoSize = True
        Me.lbl_qb.Font = New System.Drawing.Font("Microsoft New Tai Lue", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_qb.Location = New System.Drawing.Point(14, 27)
        Me.lbl_qb.Name = "lbl_qb"
        Me.lbl_qb.Size = New System.Drawing.Size(127, 27)
        Me.lbl_qb.TabIndex = 0
        Me.lbl_qb.Text = "Quiz Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft New Tai Lue", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Subject:"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Microsoft New Tai Lue", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(20, 169)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(90, 20)
        Me.lbl_name.TabIndex = 4
        Me.lbl_name.Text = "Quiz Name:"
        '
        'txt_pass
        '
        Me.txt_pass.Font = New System.Drawing.Font("Microsoft New Tai Lue", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_pass.Location = New System.Drawing.Point(24, 258)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(254, 27)
        Me.txt_pass.TabIndex = 7
        '
        'txt_qname
        '
        Me.txt_qname.Font = New System.Drawing.Font("Microsoft New Tai Lue", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qname.Location = New System.Drawing.Point(24, 192)
        Me.txt_qname.Name = "txt_qname"
        Me.txt_qname.Size = New System.Drawing.Size(254, 27)
        Me.txt_qname.TabIndex = 5
        '
        'txt_sub
        '
        Me.txt_sub.Font = New System.Drawing.Font("Microsoft New Tai Lue", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_sub.Location = New System.Drawing.Point(24, 129)
        Me.txt_sub.Name = "txt_sub"
        Me.txt_sub.Size = New System.Drawing.Size(254, 27)
        Me.txt_sub.TabIndex = 5
        '
        'qdetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SpringGreen
        Me.ClientSize = New System.Drawing.Size(414, 580)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "qdetail"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gb_id.ResumeLayout(False)
        Me.gb_id.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cb_mc As System.Windows.Forms.CheckBox
    Friend WithEvents cb_timer As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents gb_id As System.Windows.Forms.GroupBox
    Friend WithEvents lb_date As System.Windows.Forms.Label
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents btn_create As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_pass As System.Windows.Forms.Label
    Friend WithEvents lbl_qb As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents txt_sub As System.Windows.Forms.TextBox
    Friend WithEvents txt_qname As System.Windows.Forms.TextBox
End Class
