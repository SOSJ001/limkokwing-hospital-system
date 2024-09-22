<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class welcome_form
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(welcome_form))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timer_label = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.login_btn = New System.Windows.Forms.Button()
        Me.wf_password_txt = New System.Windows.Forms.TextBox()
        Me.wf_username_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(355, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 47)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WELCOME"
        '
        'Timer1
        '
        '
        'timer_label
        '
        Me.timer_label.AutoSize = True
        Me.timer_label.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.timer_label.Location = New System.Drawing.Point(861, 638)
        Me.timer_label.Name = "timer_label"
        Me.timer_label.Size = New System.Drawing.Size(111, 47)
        Me.timer_label.TabIndex = 1
        Me.timer_label.Text = "TIMER"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.login_btn)
        Me.GroupBox1.Controls.Add(Me.wf_password_txt)
        Me.GroupBox1.Controls.Add(Me.wf_username_txt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(212, 132)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(577, 349)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LOGIN"
        '
        'login_btn
        '
        Me.login_btn.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.login_btn.Location = New System.Drawing.Point(109, 292)
        Me.login_btn.Name = "login_btn"
        Me.login_btn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.login_btn.Size = New System.Drawing.Size(105, 36)
        Me.login_btn.TabIndex = 8
        Me.login_btn.Text = "LOGIN"
        Me.login_btn.UseVisualStyleBackColor = True
        '
        'wf_password_txt
        '
        Me.wf_password_txt.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.wf_password_txt.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.wf_password_txt.Location = New System.Drawing.Point(203, 169)
        Me.wf_password_txt.Name = "wf_password_txt"
        Me.wf_password_txt.Size = New System.Drawing.Size(297, 45)
        Me.wf_password_txt.TabIndex = 7
        Me.wf_password_txt.UseSystemPasswordChar = True
        '
        'wf_username_txt
        '
        Me.wf_username_txt.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.wf_username_txt.Font = New System.Drawing.Font("Segoe Print", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.wf_username_txt.Location = New System.Drawing.Point(203, 102)
        Me.wf_username_txt.Name = "wf_username_txt"
        Me.wf_username_txt.Size = New System.Drawing.Size(297, 45)
        Me.wf_username_txt.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(7, 164)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 47)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PASSWORD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(7, 97)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0, 10, 10, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 47)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "USERNAME"
        '
        'close_btn
        '
        Me.close_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.close_btn.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.close_btn.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.close_btn.Location = New System.Drawing.Point(1221, 12)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.close_btn.Size = New System.Drawing.Size(105, 36)
        Me.close_btn.TabIndex = 9
        Me.close_btn.Text = "CLOSE"
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Location = New System.Drawing.Point(197, 86)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(990, 556)
        Me.Panel1.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(518, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(348, 47)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "TO GROUP 7 PROJECT"
        '
        'welcome_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(1338, 721)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.timer_label)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "welcome_form"
        Me.Text = "WELCOME FORM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents timer_label As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents login_btn As Button
    Friend WithEvents wf_password_txt As TextBox
    Friend WithEvents wf_username_txt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents close_btn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
End Class
