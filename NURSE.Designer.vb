<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NurseForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NurseForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.get_btn = New System.Windows.Forms.Button()
        Me.pat_Lname_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pat_Fname_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pat_hospId_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.teacher_CheckBox = New System.Windows.Forms.CheckBox()
        Me.student_CheckBox = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.smoke_combo = New System.Windows.Forms.ComboBox()
        Me.alcohol_combo = New System.Windows.Forms.ComboBox()
        Me.exercise_combo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.appointment_loadDataInGrid = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.doctor_txt = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.pat_reason_txt = New System.Windows.Forms.TextBox()
        Me.DoctorGridView1 = New System.Windows.Forms.DataGridView()
        Me.create_Appointment_btn = New System.Windows.Forms.Button()
        Me.update_Appointment_btn = New System.Windows.Forms.Button()
        Me.logout_btn = New System.Windows.Forms.Button()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.appointment_loadDataInGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DoctorGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.get_btn)
        Me.GroupBox1.Controls.Add(Me.pat_Lname_txt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.pat_Fname_txt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.pat_hospId_txt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.teacher_CheckBox)
        Me.GroupBox1.Controls.Add(Me.student_CheckBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(61, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(379, 229)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PATIENT DETAILS"
        '
        'get_btn
        '
        Me.get_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.get_btn.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.get_btn.Location = New System.Drawing.Point(294, 85)
        Me.get_btn.Name = "get_btn"
        Me.get_btn.Size = New System.Drawing.Size(75, 126)
        Me.get_btn.TabIndex = 8
        Me.get_btn.Text = "GET INFO"
        Me.get_btn.UseVisualStyleBackColor = False
        '
        'pat_Lname_txt
        '
        Me.pat_Lname_txt.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.pat_Lname_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.pat_Lname_txt.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pat_Lname_txt.Location = New System.Drawing.Point(91, 177)
        Me.pat_Lname_txt.Name = "pat_Lname_txt"
        Me.pat_Lname_txt.Size = New System.Drawing.Size(198, 34)
        Me.pat_Lname_txt.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(6, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 26)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "L-NAME"
        '
        'pat_Fname_txt
        '
        Me.pat_Fname_txt.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.pat_Fname_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.pat_Fname_txt.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pat_Fname_txt.Location = New System.Drawing.Point(91, 128)
        Me.pat_Fname_txt.Name = "pat_Fname_txt"
        Me.pat_Fname_txt.Size = New System.Drawing.Size(198, 34)
        Me.pat_Fname_txt.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(6, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 26)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "F-NAME"
        '
        'pat_hospId_txt
        '
        Me.pat_hospId_txt.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.pat_hospId_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.pat_hospId_txt.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pat_hospId_txt.Location = New System.Drawing.Point(91, 80)
        Me.pat_hospId_txt.Name = "pat_hospId_txt"
        Me.pat_hospId_txt.Size = New System.Drawing.Size(198, 34)
        Me.pat_hospId_txt.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(6, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 26)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "HOSP. ID."
        '
        'teacher_CheckBox
        '
        Me.teacher_CheckBox.AutoSize = True
        Me.teacher_CheckBox.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.teacher_CheckBox.Location = New System.Drawing.Point(224, 39)
        Me.teacher_CheckBox.Name = "teacher_CheckBox"
        Me.teacher_CheckBox.Size = New System.Drawing.Size(106, 30)
        Me.teacher_CheckBox.TabIndex = 1
        Me.teacher_CheckBox.Text = "TEACHER"
        Me.teacher_CheckBox.UseVisualStyleBackColor = True
        '
        'student_CheckBox
        '
        Me.student_CheckBox.AutoSize = True
        Me.student_CheckBox.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.student_CheckBox.Location = New System.Drawing.Point(57, 36)
        Me.student_CheckBox.Name = "student_CheckBox"
        Me.student_CheckBox.Size = New System.Drawing.Size(107, 30)
        Me.student_CheckBox.TabIndex = 0
        Me.student_CheckBox.Text = "STUDENT"
        Me.student_CheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.smoke_combo)
        Me.GroupBox2.Controls.Add(Me.alcohol_combo)
        Me.GroupBox2.Controls.Add(Me.exercise_combo)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(61, 336)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(295, 182)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PATIENT ACTIVITIES"
        '
        'smoke_combo
        '
        Me.smoke_combo.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.smoke_combo.FormattingEnabled = True
        Me.smoke_combo.Items.AddRange(New Object() {"YES", "NO"})
        Me.smoke_combo.Location = New System.Drawing.Point(224, 127)
        Me.smoke_combo.Name = "smoke_combo"
        Me.smoke_combo.Size = New System.Drawing.Size(53, 36)
        Me.smoke_combo.TabIndex = 9
        '
        'alcohol_combo
        '
        Me.alcohol_combo.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.alcohol_combo.FormattingEnabled = True
        Me.alcohol_combo.Items.AddRange(New Object() {"YES", "NO"})
        Me.alcohol_combo.Location = New System.Drawing.Point(224, 82)
        Me.alcohol_combo.Name = "alcohol_combo"
        Me.alcohol_combo.Size = New System.Drawing.Size(53, 36)
        Me.alcohol_combo.TabIndex = 8
        '
        'exercise_combo
        '
        Me.exercise_combo.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.exercise_combo.FormattingEnabled = True
        Me.exercise_combo.Items.AddRange(New Object() {"YES", "NO"})
        Me.exercise_combo.Location = New System.Drawing.Point(224, 39)
        Me.exercise_combo.Name = "exercise_combo"
        Me.exercise_combo.Size = New System.Drawing.Size(53, 36)
        Me.exercise_combo.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(6, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 26)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "SMOKE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(6, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 26)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ALCOHOL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(6, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 26)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "EXERCISE"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.appointment_loadDataInGrid)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox3.Location = New System.Drawing.Point(61, 546)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(919, 163)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "APPOINTMENTS"
        '
        'appointment_loadDataInGrid
        '
        Me.appointment_loadDataInGrid.AllowUserToAddRows = False
        Me.appointment_loadDataInGrid.AllowUserToDeleteRows = False
        Me.appointment_loadDataInGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.appointment_loadDataInGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.appointment_loadDataInGrid.Location = New System.Drawing.Point(6, 23)
        Me.appointment_loadDataInGrid.Name = "appointment_loadDataInGrid"
        Me.appointment_loadDataInGrid.ReadOnly = True
        Me.appointment_loadDataInGrid.RowTemplate.Height = 25
        Me.appointment_loadDataInGrid.Size = New System.Drawing.Size(905, 134)
        Me.appointment_loadDataInGrid.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.doctor_txt)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.pat_reason_txt)
        Me.GroupBox4.Controls.Add(Me.DoctorGridView1)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox4.Location = New System.Drawing.Point(531, 82)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(449, 438)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "REASON TO SEE DOCTOR"
        '
        'doctor_txt
        '
        Me.doctor_txt.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.doctor_txt.Location = New System.Drawing.Point(202, 235)
        Me.doctor_txt.Name = "doctor_txt"
        Me.doctor_txt.Size = New System.Drawing.Size(198, 36)
        Me.doctor_txt.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(54, 237)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 26)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "ASSIGN.DOCTOR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(172, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 26)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "DETAILS"
        '
        'pat_reason_txt
        '
        Me.pat_reason_txt.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.pat_reason_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.pat_reason_txt.Location = New System.Drawing.Point(7, 70)
        Me.pat_reason_txt.Multiline = True
        Me.pat_reason_txt.Name = "pat_reason_txt"
        Me.pat_reason_txt.Size = New System.Drawing.Size(434, 139)
        Me.pat_reason_txt.TabIndex = 1
        '
        'DoctorGridView1
        '
        Me.DoctorGridView1.AllowUserToAddRows = False
        Me.DoctorGridView1.AllowUserToDeleteRows = False
        Me.DoctorGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DoctorGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DoctorGridView1.Location = New System.Drawing.Point(7, 293)
        Me.DoctorGridView1.Name = "DoctorGridView1"
        Me.DoctorGridView1.ReadOnly = True
        Me.DoctorGridView1.RowTemplate.Height = 25
        Me.DoctorGridView1.Size = New System.Drawing.Size(434, 134)
        Me.DoctorGridView1.TabIndex = 0
        '
        'create_Appointment_btn
        '
        Me.create_Appointment_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.create_Appointment_btn.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.create_Appointment_btn.Location = New System.Drawing.Point(1027, 113)
        Me.create_Appointment_btn.Name = "create_Appointment_btn"
        Me.create_Appointment_btn.Size = New System.Drawing.Size(125, 47)
        Me.create_Appointment_btn.TabIndex = 4
        Me.create_Appointment_btn.Text = "CREATE"
        Me.create_Appointment_btn.UseVisualStyleBackColor = False
        '
        'update_Appointment_btn
        '
        Me.update_Appointment_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.update_Appointment_btn.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.update_Appointment_btn.Location = New System.Drawing.Point(1027, 211)
        Me.update_Appointment_btn.Name = "update_Appointment_btn"
        Me.update_Appointment_btn.Size = New System.Drawing.Size(125, 47)
        Me.update_Appointment_btn.TabIndex = 5
        Me.update_Appointment_btn.Text = "UPDATE"
        Me.update_Appointment_btn.UseVisualStyleBackColor = False
        '
        'logout_btn
        '
        Me.logout_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.logout_btn.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.logout_btn.ForeColor = System.Drawing.SystemColors.Control
        Me.logout_btn.Location = New System.Drawing.Point(1027, 314)
        Me.logout_btn.Name = "logout_btn"
        Me.logout_btn.Size = New System.Drawing.Size(125, 51)
        Me.logout_btn.TabIndex = 7
        Me.logout_btn.Text = "LOGOUT"
        Me.logout_btn.UseVisualStyleBackColor = False
        '
        'close_btn
        '
        Me.close_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.close_btn.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.close_btn.ForeColor = System.Drawing.Color.Red
        Me.close_btn.Location = New System.Drawing.Point(1027, 421)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(129, 51)
        Me.close_btn.TabIndex = 8
        Me.close_btn.Text = "CLOSE"
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'NurseForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1338, 721)
        Me.ControlBox = False
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.logout_btn)
        Me.Controls.Add(Me.update_Appointment_btn)
        Me.Controls.Add(Me.create_Appointment_btn)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "NurseForm"
        Me.Text = "NURSE FORM"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.appointment_loadDataInGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DoctorGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pat_hospId_txt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents teacher_CheckBox As CheckBox
    Friend WithEvents student_CheckBox As CheckBox
    Friend WithEvents pat_Lname_txt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents pat_Fname_txt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents get_btn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents smoke_combo As ComboBox
    Friend WithEvents alcohol_combo As ComboBox
    Friend WithEvents exercise_combo As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents appointment_loadDataInGrid As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents doctor_txt As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents pat_reason_txt As TextBox
    Friend WithEvents DoctorGridView1 As DataGridView
    Friend WithEvents create_Appointment_btn As Button
    Friend WithEvents update_Appointment_btn As Button
    Friend WithEvents logout_btn As Button
    Friend WithEvents close_btn As Button
End Class
