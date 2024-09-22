<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Doctor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Doctor))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Teacher_RadioButton = New System.Windows.Forms.RadioButton()
        Me.Student_RadioButton = New System.Windows.Forms.RadioButton()
        Me.clear_btn = New System.Windows.Forms.Button()
        Me.srch_hos_id_btn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pat_id_txt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.add_record_btn = New System.Windows.Forms.Button()
        Me.doc_record_txt = New System.Windows.Forms.TextBox()
        Me.assDocGridView1 = New System.Windows.Forms.DataGridView()
        Me.loadDoc_patient = New System.Windows.Forms.Button()
        Me.doc_id_txt = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.patientGridView2 = New System.Windows.Forms.DataGridView()
        Me.logout_btn = New System.Windows.Forms.Button()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.assDocGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.patientGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(555, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DOCTOR"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Teacher_RadioButton)
        Me.GroupBox1.Controls.Add(Me.Student_RadioButton)
        Me.GroupBox1.Controls.Add(Me.clear_btn)
        Me.GroupBox1.Controls.Add(Me.srch_hos_id_btn)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.pat_id_txt)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.add_record_btn)
        Me.GroupBox1.Controls.Add(Me.doc_record_txt)
        Me.GroupBox1.Controls.Add(Me.assDocGridView1)
        Me.GroupBox1.Controls.Add(Me.loadDoc_patient)
        Me.GroupBox1.Controls.Add(Me.doc_id_txt)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(37, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(639, 632)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ASSIGNED PATIENT"
        '
        'Teacher_RadioButton
        '
        Me.Teacher_RadioButton.AutoSize = True
        Me.Teacher_RadioButton.Location = New System.Drawing.Point(313, 152)
        Me.Teacher_RadioButton.Name = "Teacher_RadioButton"
        Me.Teacher_RadioButton.Size = New System.Drawing.Size(111, 32)
        Me.Teacher_RadioButton.TabIndex = 12
        Me.Teacher_RadioButton.TabStop = True
        Me.Teacher_RadioButton.Text = "TEACHER"
        Me.Teacher_RadioButton.UseVisualStyleBackColor = True
        '
        'Student_RadioButton
        '
        Me.Student_RadioButton.AutoSize = True
        Me.Student_RadioButton.Location = New System.Drawing.Point(145, 152)
        Me.Student_RadioButton.Name = "Student_RadioButton"
        Me.Student_RadioButton.Size = New System.Drawing.Size(111, 32)
        Me.Student_RadioButton.TabIndex = 11
        Me.Student_RadioButton.TabStop = True
        Me.Student_RadioButton.Text = "STUDENT"
        Me.Student_RadioButton.UseVisualStyleBackColor = True
        '
        'clear_btn
        '
        Me.clear_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.clear_btn.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.clear_btn.Location = New System.Drawing.Point(534, 552)
        Me.clear_btn.Name = "clear_btn"
        Me.clear_btn.Size = New System.Drawing.Size(92, 67)
        Me.clear_btn.TabIndex = 10
        Me.clear_btn.Text = "CLEAR"
        Me.clear_btn.UseVisualStyleBackColor = False
        '
        'srch_hos_id_btn
        '
        Me.srch_hos_id_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.srch_hos_id_btn.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.srch_hos_id_btn.Location = New System.Drawing.Point(534, 194)
        Me.srch_hos_id_btn.Name = "srch_hos_id_btn"
        Me.srch_hos_id_btn.Size = New System.Drawing.Size(92, 34)
        Me.srch_hos_id_btn.TabIndex = 9
        Me.srch_hos_id_btn.Text = "SEARCH"
        Me.srch_hos_id_btn.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(192, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(254, 33)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "PATIENT INFORMATION"
        '
        'pat_id_txt
        '
        Me.pat_id_txt.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.pat_id_txt.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.pat_id_txt.Location = New System.Drawing.Point(330, 194)
        Me.pat_id_txt.Name = "pat_id_txt"
        Me.pat_id_txt.Size = New System.Drawing.Size(153, 34)
        Me.pat_id_txt.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(74, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 28)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "PATIENT HOSPITAL ID"
        '
        'add_record_btn
        '
        Me.add_record_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.add_record_btn.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.add_record_btn.Location = New System.Drawing.Point(534, 467)
        Me.add_record_btn.Name = "add_record_btn"
        Me.add_record_btn.Size = New System.Drawing.Size(92, 67)
        Me.add_record_btn.TabIndex = 5
        Me.add_record_btn.Text = "SAVE RECORD"
        Me.add_record_btn.UseVisualStyleBackColor = False
        '
        'doc_record_txt
        '
        Me.doc_record_txt.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.doc_record_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.doc_record_txt.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.doc_record_txt.Location = New System.Drawing.Point(3, 390)
        Me.doc_record_txt.Multiline = True
        Me.doc_record_txt.Name = "doc_record_txt"
        Me.doc_record_txt.Size = New System.Drawing.Size(494, 229)
        Me.doc_record_txt.TabIndex = 4
        '
        'assDocGridView1
        '
        Me.assDocGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.assDocGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.assDocGridView1.Location = New System.Drawing.Point(7, 232)
        Me.assDocGridView1.Name = "assDocGridView1"
        Me.assDocGridView1.ReadOnly = True
        Me.assDocGridView1.RowTemplate.Height = 25
        Me.assDocGridView1.Size = New System.Drawing.Size(626, 134)
        Me.assDocGridView1.TabIndex = 3
        '
        'loadDoc_patient
        '
        Me.loadDoc_patient.BackColor = System.Drawing.SystemColors.ControlLight
        Me.loadDoc_patient.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.loadDoc_patient.Location = New System.Drawing.Point(498, 38)
        Me.loadDoc_patient.Name = "loadDoc_patient"
        Me.loadDoc_patient.Size = New System.Drawing.Size(128, 60)
        Me.loadDoc_patient.TabIndex = 2
        Me.loadDoc_patient.Text = "LOAD PATIENTS"
        Me.loadDoc_patient.UseVisualStyleBackColor = False
        '
        'doc_id_txt
        '
        Me.doc_id_txt.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.doc_id_txt.Font = New System.Drawing.Font("Segoe Print", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.doc_id_txt.Location = New System.Drawing.Point(203, 36)
        Me.doc_id_txt.Name = "doc_id_txt"
        Me.doc_id_txt.Size = New System.Drawing.Size(153, 34)
        Me.doc_id_txt.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 28)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "DOCTOR'S ID"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.patientGridView2)
        Me.GroupBox2.Location = New System.Drawing.Point(727, 29)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(552, 632)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ALL PATIENT"
        '
        'patientGridView2
        '
        Me.patientGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.patientGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.patientGridView2.Location = New System.Drawing.Point(24, 38)
        Me.patientGridView2.Name = "patientGridView2"
        Me.patientGridView2.ReadOnly = True
        Me.patientGridView2.RowTemplate.Height = 25
        Me.patientGridView2.Size = New System.Drawing.Size(504, 579)
        Me.patientGridView2.TabIndex = 4
        '
        'logout_btn
        '
        Me.logout_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.logout_btn.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.logout_btn.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.logout_btn.Location = New System.Drawing.Point(40, 667)
        Me.logout_btn.Name = "logout_btn"
        Me.logout_btn.Size = New System.Drawing.Size(92, 42)
        Me.logout_btn.TabIndex = 11
        Me.logout_btn.Text = "LOGOUT"
        Me.logout_btn.UseVisualStyleBackColor = False
        '
        'close_btn
        '
        Me.close_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.close_btn.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.close_btn.ForeColor = System.Drawing.Color.Red
        Me.close_btn.Location = New System.Drawing.Point(142, 667)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(92, 42)
        Me.close_btn.TabIndex = 12
        Me.close_btn.Text = "CLOSE"
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'Doctor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 28.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1338, 721)
        Me.ControlBox = False
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.logout_btn)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Doctor"
        Me.Text = "DOCTOR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.assDocGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.patientGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents doc_record_txt As TextBox
    Friend WithEvents assDocGridView1 As DataGridView
    Friend WithEvents loadDoc_patient As Button
    Friend WithEvents doc_id_txt As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents patientGridView2 As DataGridView
    Friend WithEvents add_record_btn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents pat_id_txt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents srch_hos_id_btn As Button
    Friend WithEvents clear_btn As Button
    Friend WithEvents logout_btn As Button
    Friend WithEvents close_btn As Button
    Friend WithEvents Teacher_RadioButton As RadioButton
    Friend WithEvents Student_RadioButton As RadioButton
End Class
