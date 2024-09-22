<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin_form
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin_form))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.stud_update_btn = New System.Windows.Forms.Button()
        Me.stud_save_btn = New System.Windows.Forms.Button()
        Me.stud_status_combo = New System.Windows.Forms.ComboBox()
        Me.stud_sex_combo = New System.Windows.Forms.ComboBox()
        Me.stud_lname_txt = New System.Windows.Forms.TextBox()
        Me.stud_address_txt = New System.Windows.Forms.TextBox()
        Me.stud_age_txt = New System.Windows.Forms.TextBox()
        Me.stud_contact_txt = New System.Windows.Forms.TextBox()
        Me.stud_email_txt = New System.Windows.Forms.TextBox()
        Me.stud_fname_txt = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.stud_delete_btn = New System.Windows.Forms.Button()
        Me.stud_search_btn = New System.Windows.Forms.Button()
        Me.stud_id_txt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.student_grid = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.teach_update_btn = New System.Windows.Forms.Button()
        Me.teach_save_btn = New System.Windows.Forms.Button()
        Me.teach_status_combo = New System.Windows.Forms.ComboBox()
        Me.teach_sex_combo = New System.Windows.Forms.ComboBox()
        Me.teach_lname_txt = New System.Windows.Forms.TextBox()
        Me.teach_address_txt = New System.Windows.Forms.TextBox()
        Me.teach_contact_txt = New System.Windows.Forms.TextBox()
        Me.teach_email_txt = New System.Windows.Forms.TextBox()
        Me.teach_fname_txt = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.teach_delete_btn = New System.Windows.Forms.Button()
        Me.teach_search_btn = New System.Windows.Forms.Button()
        Me.teach_id_txt = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.teacher_grid = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.user_pword_txt = New System.Windows.Forms.TextBox()
        Me.user_cPword_txt = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.user_update_btn = New System.Windows.Forms.Button()
        Me.user_save_btn = New System.Windows.Forms.Button()
        Me.user_utype_combo = New System.Windows.Forms.ComboBox()
        Me.user_lname_txt = New System.Windows.Forms.TextBox()
        Me.user_username_txt = New System.Windows.Forms.TextBox()
        Me.user_contact_txt = New System.Windows.Forms.TextBox()
        Me.user_email_txt = New System.Windows.Forms.TextBox()
        Me.user_fname_txt = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.user_delete_btn = New System.Windows.Forms.Button()
        Me.user_search_btn = New System.Windows.Forms.Button()
        Me.user_id_txt = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.User_grid = New System.Windows.Forms.DataGridView()
        Me.refresh_btn = New System.Windows.Forms.Button()
        Me.logout_btn = New System.Windows.Forms.Button()
        Me.close_btn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.student_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.teacher_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.User_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox1.Controls.Add(Me.stud_update_btn)
        Me.GroupBox1.Controls.Add(Me.stud_save_btn)
        Me.GroupBox1.Controls.Add(Me.stud_status_combo)
        Me.GroupBox1.Controls.Add(Me.stud_sex_combo)
        Me.GroupBox1.Controls.Add(Me.stud_lname_txt)
        Me.GroupBox1.Controls.Add(Me.stud_address_txt)
        Me.GroupBox1.Controls.Add(Me.stud_age_txt)
        Me.GroupBox1.Controls.Add(Me.stud_contact_txt)
        Me.GroupBox1.Controls.Add(Me.stud_email_txt)
        Me.GroupBox1.Controls.Add(Me.stud_fname_txt)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.stud_delete_btn)
        Me.GroupBox1.Controls.Add(Me.stud_search_btn)
        Me.GroupBox1.Controls.Add(Me.stud_id_txt)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.student_grid)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1295, 175)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "STUDENT"
        '
        'stud_update_btn
        '
        Me.stud_update_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.stud_update_btn.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.stud_update_btn.ForeColor = System.Drawing.SystemColors.MenuText
        Me.stud_update_btn.Location = New System.Drawing.Point(1040, 133)
        Me.stud_update_btn.Name = "stud_update_btn"
        Me.stud_update_btn.Size = New System.Drawing.Size(81, 36)
        Me.stud_update_btn.TabIndex = 22
        Me.stud_update_btn.Text = "UPDATE"
        Me.stud_update_btn.UseVisualStyleBackColor = False
        '
        'stud_save_btn
        '
        Me.stud_save_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.stud_save_btn.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.stud_save_btn.ForeColor = System.Drawing.SystemColors.MenuText
        Me.stud_save_btn.Location = New System.Drawing.Point(953, 133)
        Me.stud_save_btn.Name = "stud_save_btn"
        Me.stud_save_btn.Size = New System.Drawing.Size(81, 36)
        Me.stud_save_btn.TabIndex = 21
        Me.stud_save_btn.Text = "SAVE"
        Me.stud_save_btn.UseVisualStyleBackColor = False
        '
        'stud_status_combo
        '
        Me.stud_status_combo.BackColor = System.Drawing.SystemColors.ControlDark
        Me.stud_status_combo.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.stud_status_combo.ForeColor = System.Drawing.SystemColors.MenuText
        Me.stud_status_combo.FormattingEnabled = True
        Me.stud_status_combo.Items.AddRange(New Object() {"MARRIED", "SINGLE"})
        Me.stud_status_combo.Location = New System.Drawing.Point(1193, 68)
        Me.stud_status_combo.Name = "stud_status_combo"
        Me.stud_status_combo.Size = New System.Drawing.Size(92, 29)
        Me.stud_status_combo.TabIndex = 7
        '
        'stud_sex_combo
        '
        Me.stud_sex_combo.BackColor = System.Drawing.SystemColors.ControlDark
        Me.stud_sex_combo.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.stud_sex_combo.ForeColor = System.Drawing.SystemColors.MenuText
        Me.stud_sex_combo.FormattingEnabled = True
        Me.stud_sex_combo.Items.AddRange(New Object() {"M", "F"})
        Me.stud_sex_combo.Location = New System.Drawing.Point(1155, 33)
        Me.stud_sex_combo.Name = "stud_sex_combo"
        Me.stud_sex_combo.Size = New System.Drawing.Size(48, 29)
        Me.stud_sex_combo.TabIndex = 5
        '
        'stud_lname_txt
        '
        Me.stud_lname_txt.BackColor = System.Drawing.SystemColors.ControlDark
        Me.stud_lname_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.stud_lname_txt.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.stud_lname_txt.ForeColor = System.Drawing.SystemColors.MenuText
        Me.stud_lname_txt.Location = New System.Drawing.Point(1004, 68)
        Me.stud_lname_txt.Name = "stud_lname_txt"
        Me.stud_lname_txt.Size = New System.Drawing.Size(117, 29)
        Me.stud_lname_txt.TabIndex = 3
        '
        'stud_address_txt
        '
        Me.stud_address_txt.BackColor = System.Drawing.SystemColors.ControlDark
        Me.stud_address_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.stud_address_txt.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.stud_address_txt.ForeColor = System.Drawing.SystemColors.MenuText
        Me.stud_address_txt.Location = New System.Drawing.Point(1004, 103)
        Me.stud_address_txt.Name = "stud_address_txt"
        Me.stud_address_txt.Size = New System.Drawing.Size(117, 29)
        Me.stud_address_txt.TabIndex = 4
        '
        'stud_age_txt
        '
        Me.stud_age_txt.BackColor = System.Drawing.SystemColors.ControlDark
        Me.stud_age_txt.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.stud_age_txt.ForeColor = System.Drawing.SystemColors.MenuText
        Me.stud_age_txt.Location = New System.Drawing.Point(1237, 33)
        Me.stud_age_txt.Name = "stud_age_txt"
        Me.stud_age_txt.Size = New System.Drawing.Size(48, 29)
        Me.stud_age_txt.TabIndex = 6
        '
        'stud_contact_txt
        '
        Me.stud_contact_txt.BackColor = System.Drawing.SystemColors.ControlDark
        Me.stud_contact_txt.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.stud_contact_txt.ForeColor = System.Drawing.SystemColors.MenuText
        Me.stud_contact_txt.Location = New System.Drawing.Point(1193, 102)
        Me.stud_contact_txt.Name = "stud_contact_txt"
        Me.stud_contact_txt.Size = New System.Drawing.Size(96, 29)
        Me.stud_contact_txt.TabIndex = 8
        '
        'stud_email_txt
        '
        Me.stud_email_txt.BackColor = System.Drawing.SystemColors.ControlDark
        Me.stud_email_txt.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.stud_email_txt.ForeColor = System.Drawing.SystemColors.MenuText
        Me.stud_email_txt.Location = New System.Drawing.Point(1173, 131)
        Me.stud_email_txt.Name = "stud_email_txt"
        Me.stud_email_txt.Size = New System.Drawing.Size(117, 29)
        Me.stud_email_txt.TabIndex = 9
        '
        'stud_fname_txt
        '
        Me.stud_fname_txt.BackColor = System.Drawing.SystemColors.ControlDark
        Me.stud_fname_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.stud_fname_txt.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.stud_fname_txt.ForeColor = System.Drawing.SystemColors.MenuText
        Me.stud_fname_txt.Location = New System.Drawing.Point(1004, 33)
        Me.stud_fname_txt.Name = "stud_fname_txt"
        Me.stud_fname_txt.Size = New System.Drawing.Size(117, 29)
        Me.stud_fname_txt.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(1127, 132)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 21)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "EMAIL"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(1127, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 21)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "CONTACT"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(1127, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 21)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "STATUS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(1204, 36)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 21)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "AGE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(1122, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 21)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "SEX"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(931, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 21)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "ADDRESS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(931, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "L-NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(931, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "F-NAME"
        '
        'stud_delete_btn
        '
        Me.stud_delete_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.stud_delete_btn.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.stud_delete_btn.ForeColor = System.Drawing.SystemColors.MenuText
        Me.stud_delete_btn.Location = New System.Drawing.Point(546, 133)
        Me.stud_delete_btn.Name = "stud_delete_btn"
        Me.stud_delete_btn.Size = New System.Drawing.Size(81, 36)
        Me.stud_delete_btn.TabIndex = 4
        Me.stud_delete_btn.Text = "DELETE"
        Me.stud_delete_btn.UseVisualStyleBackColor = False
        '
        'stud_search_btn
        '
        Me.stud_search_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.stud_search_btn.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.stud_search_btn.ForeColor = System.Drawing.SystemColors.MenuText
        Me.stud_search_btn.Location = New System.Drawing.Point(459, 133)
        Me.stud_search_btn.Name = "stud_search_btn"
        Me.stud_search_btn.Size = New System.Drawing.Size(81, 36)
        Me.stud_search_btn.TabIndex = 3
        Me.stud_search_btn.Text = "SEARCH"
        Me.stud_search_btn.UseVisualStyleBackColor = False
        '
        'stud_id_txt
        '
        Me.stud_id_txt.BackColor = System.Drawing.SystemColors.ControlDark
        Me.stud_id_txt.ForeColor = System.Drawing.SystemColors.MenuText
        Me.stud_id_txt.Location = New System.Drawing.Point(227, 135)
        Me.stud_id_txt.Name = "stud_id_txt"
        Me.stud_id_txt.Size = New System.Drawing.Size(226, 36)
        Me.stud_id_txt.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(110, 138)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "STUDENT ID"
        '
        'student_grid
        '
        Me.student_grid.AllowUserToAddRows = False
        Me.student_grid.AllowUserToDeleteRows = False
        Me.student_grid.AllowUserToOrderColumns = True
        Me.student_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.student_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.student_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.student_grid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.student_grid.Location = New System.Drawing.Point(6, 33)
        Me.student_grid.Name = "student_grid"
        Me.student_grid.ReadOnly = True
        Me.student_grid.RowTemplate.Height = 25
        Me.student_grid.Size = New System.Drawing.Size(923, 94)
        Me.student_grid.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(555, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "ADMIN"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox2.Controls.Add(Me.teach_update_btn)
        Me.GroupBox2.Controls.Add(Me.teach_save_btn)
        Me.GroupBox2.Controls.Add(Me.teach_status_combo)
        Me.GroupBox2.Controls.Add(Me.teach_sex_combo)
        Me.GroupBox2.Controls.Add(Me.teach_lname_txt)
        Me.GroupBox2.Controls.Add(Me.teach_address_txt)
        Me.GroupBox2.Controls.Add(Me.teach_contact_txt)
        Me.GroupBox2.Controls.Add(Me.teach_email_txt)
        Me.GroupBox2.Controls.Add(Me.teach_fname_txt)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.teach_delete_btn)
        Me.GroupBox2.Controls.Add(Me.teach_search_btn)
        Me.GroupBox2.Controls.Add(Me.teach_id_txt)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.teacher_grid)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox2.Location = New System.Drawing.Point(31, 255)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1295, 175)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TEACHER"
        '
        'teach_update_btn
        '
        Me.teach_update_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.teach_update_btn.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.teach_update_btn.ForeColor = System.Drawing.SystemColors.MenuText
        Me.teach_update_btn.Location = New System.Drawing.Point(1040, 133)
        Me.teach_update_btn.Name = "teach_update_btn"
        Me.teach_update_btn.Size = New System.Drawing.Size(81, 36)
        Me.teach_update_btn.TabIndex = 22
        Me.teach_update_btn.Text = "UPDATE"
        Me.teach_update_btn.UseVisualStyleBackColor = False
        '
        'teach_save_btn
        '
        Me.teach_save_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.teach_save_btn.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.teach_save_btn.ForeColor = System.Drawing.SystemColors.MenuText
        Me.teach_save_btn.Location = New System.Drawing.Point(953, 133)
        Me.teach_save_btn.Name = "teach_save_btn"
        Me.teach_save_btn.Size = New System.Drawing.Size(81, 36)
        Me.teach_save_btn.TabIndex = 21
        Me.teach_save_btn.Text = "SAVE"
        Me.teach_save_btn.UseVisualStyleBackColor = False
        '
        'teach_status_combo
        '
        Me.teach_status_combo.BackColor = System.Drawing.SystemColors.ControlDark
        Me.teach_status_combo.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.teach_status_combo.ForeColor = System.Drawing.SystemColors.MenuText
        Me.teach_status_combo.FormattingEnabled = True
        Me.teach_status_combo.Items.AddRange(New Object() {"MARRIED", "SINGLE"})
        Me.teach_status_combo.Location = New System.Drawing.Point(1193, 68)
        Me.teach_status_combo.Name = "teach_status_combo"
        Me.teach_status_combo.Size = New System.Drawing.Size(92, 29)
        Me.teach_status_combo.TabIndex = 6
        '
        'teach_sex_combo
        '
        Me.teach_sex_combo.BackColor = System.Drawing.SystemColors.ControlDark
        Me.teach_sex_combo.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.teach_sex_combo.ForeColor = System.Drawing.SystemColors.MenuText
        Me.teach_sex_combo.FormattingEnabled = True
        Me.teach_sex_combo.Items.AddRange(New Object() {"M", "F"})
        Me.teach_sex_combo.Location = New System.Drawing.Point(1237, 38)
        Me.teach_sex_combo.Name = "teach_sex_combo"
        Me.teach_sex_combo.Size = New System.Drawing.Size(48, 29)
        Me.teach_sex_combo.TabIndex = 5
        '
        'teach_lname_txt
        '
        Me.teach_lname_txt.BackColor = System.Drawing.SystemColors.ControlDark
        Me.teach_lname_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teach_lname_txt.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.teach_lname_txt.ForeColor = System.Drawing.SystemColors.MenuText
        Me.teach_lname_txt.Location = New System.Drawing.Point(1004, 68)
        Me.teach_lname_txt.Name = "teach_lname_txt"
        Me.teach_lname_txt.Size = New System.Drawing.Size(117, 29)
        Me.teach_lname_txt.TabIndex = 3
        '
        'teach_address_txt
        '
        Me.teach_address_txt.BackColor = System.Drawing.SystemColors.ControlDark
        Me.teach_address_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teach_address_txt.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.teach_address_txt.ForeColor = System.Drawing.SystemColors.MenuText
        Me.teach_address_txt.Location = New System.Drawing.Point(1004, 103)
        Me.teach_address_txt.Name = "teach_address_txt"
        Me.teach_address_txt.Size = New System.Drawing.Size(117, 29)
        Me.teach_address_txt.TabIndex = 4
        '
        'teach_contact_txt
        '
        Me.teach_contact_txt.BackColor = System.Drawing.SystemColors.ControlDark
        Me.teach_contact_txt.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.teach_contact_txt.ForeColor = System.Drawing.SystemColors.MenuText
        Me.teach_contact_txt.Location = New System.Drawing.Point(1193, 102)
        Me.teach_contact_txt.Name = "teach_contact_txt"
        Me.teach_contact_txt.Size = New System.Drawing.Size(96, 29)
        Me.teach_contact_txt.TabIndex = 7
        '
        'teach_email_txt
        '
        Me.teach_email_txt.BackColor = System.Drawing.SystemColors.ControlDark
        Me.teach_email_txt.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.teach_email_txt.ForeColor = System.Drawing.SystemColors.MenuText
        Me.teach_email_txt.Location = New System.Drawing.Point(1173, 131)
        Me.teach_email_txt.Name = "teach_email_txt"
        Me.teach_email_txt.Size = New System.Drawing.Size(117, 29)
        Me.teach_email_txt.TabIndex = 8
        '
        'teach_fname_txt
        '
        Me.teach_fname_txt.BackColor = System.Drawing.SystemColors.ControlDark
        Me.teach_fname_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.teach_fname_txt.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.teach_fname_txt.ForeColor = System.Drawing.SystemColors.MenuText
        Me.teach_fname_txt.Location = New System.Drawing.Point(1004, 33)
        Me.teach_fname_txt.Name = "teach_fname_txt"
        Me.teach_fname_txt.Size = New System.Drawing.Size(117, 29)
        Me.teach_fname_txt.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label11.Location = New System.Drawing.Point(1127, 132)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 21)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "EMAIL"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label12.Location = New System.Drawing.Point(1127, 103)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 21)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "CONTACT"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label13.Location = New System.Drawing.Point(1127, 73)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 21)
        Me.Label13.TabIndex = 10
        Me.Label13.Text = "STATUS"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label15.Location = New System.Drawing.Point(1122, 38)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 21)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "SEX"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label16.Location = New System.Drawing.Point(931, 106)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 21)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "ADDRESS"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label17.Location = New System.Drawing.Point(931, 71)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 21)
        Me.Label17.TabIndex = 6
        Me.Label17.Text = "L-NAME"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label18.Location = New System.Drawing.Point(931, 36)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(63, 21)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "F-NAME"
        '
        'teach_delete_btn
        '
        Me.teach_delete_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.teach_delete_btn.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.teach_delete_btn.ForeColor = System.Drawing.SystemColors.MenuText
        Me.teach_delete_btn.Location = New System.Drawing.Point(546, 133)
        Me.teach_delete_btn.Name = "teach_delete_btn"
        Me.teach_delete_btn.Size = New System.Drawing.Size(81, 36)
        Me.teach_delete_btn.TabIndex = 4
        Me.teach_delete_btn.Text = "DELETE"
        Me.teach_delete_btn.UseVisualStyleBackColor = False
        '
        'teach_search_btn
        '
        Me.teach_search_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.teach_search_btn.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.teach_search_btn.ForeColor = System.Drawing.SystemColors.MenuText
        Me.teach_search_btn.Location = New System.Drawing.Point(459, 133)
        Me.teach_search_btn.Name = "teach_search_btn"
        Me.teach_search_btn.Size = New System.Drawing.Size(81, 36)
        Me.teach_search_btn.TabIndex = 3
        Me.teach_search_btn.Text = "SEARCH"
        Me.teach_search_btn.UseVisualStyleBackColor = False
        '
        'teach_id_txt
        '
        Me.teach_id_txt.BackColor = System.Drawing.SystemColors.ControlDark
        Me.teach_id_txt.ForeColor = System.Drawing.SystemColors.MenuText
        Me.teach_id_txt.Location = New System.Drawing.Point(227, 135)
        Me.teach_id_txt.Name = "teach_id_txt"
        Me.teach_id_txt.Size = New System.Drawing.Size(226, 36)
        Me.teach_id_txt.TabIndex = 1
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label19.Location = New System.Drawing.Point(110, 138)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(117, 28)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "TEACHER ID"
        '
        'teacher_grid
        '
        Me.teacher_grid.AllowUserToAddRows = False
        Me.teacher_grid.AllowUserToDeleteRows = False
        Me.teacher_grid.AllowUserToOrderColumns = True
        Me.teacher_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.teacher_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.teacher_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.teacher_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.teacher_grid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.teacher_grid.Location = New System.Drawing.Point(6, 33)
        Me.teacher_grid.Name = "teacher_grid"
        Me.teacher_grid.ReadOnly = True
        Me.teacher_grid.RowTemplate.Height = 25
        Me.teacher_grid.Size = New System.Drawing.Size(923, 94)
        Me.teacher_grid.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.GroupBox3.Controls.Add(Me.user_pword_txt)
        Me.GroupBox3.Controls.Add(Me.user_cPword_txt)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.user_update_btn)
        Me.GroupBox3.Controls.Add(Me.user_save_btn)
        Me.GroupBox3.Controls.Add(Me.user_utype_combo)
        Me.GroupBox3.Controls.Add(Me.user_lname_txt)
        Me.GroupBox3.Controls.Add(Me.user_username_txt)
        Me.GroupBox3.Controls.Add(Me.user_contact_txt)
        Me.GroupBox3.Controls.Add(Me.user_email_txt)
        Me.GroupBox3.Controls.Add(Me.user_fname_txt)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.user_delete_btn)
        Me.GroupBox3.Controls.Add(Me.user_search_btn)
        Me.GroupBox3.Controls.Add(Me.user_id_txt)
        Me.GroupBox3.Controls.Add(Me.Label26)
        Me.GroupBox3.Controls.Add(Me.User_grid)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox3.Location = New System.Drawing.Point(31, 479)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1295, 175)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "USER"
        '
        'user_pword_txt
        '
        Me.user_pword_txt.BackColor = System.Drawing.SystemColors.ControlDark
        Me.user_pword_txt.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.user_pword_txt.ForeColor = System.Drawing.SystemColors.MenuText
        Me.user_pword_txt.Location = New System.Drawing.Point(1182, 29)
        Me.user_pword_txt.Name = "user_pword_txt"
        Me.user_pword_txt.Size = New System.Drawing.Size(110, 29)
        Me.user_pword_txt.TabIndex = 6
        Me.user_pword_txt.UseSystemPasswordChar = True
        '
        'user_cPword_txt
        '
        Me.user_cPword_txt.BackColor = System.Drawing.SystemColors.ControlDark
        Me.user_cPword_txt.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.user_cPword_txt.ForeColor = System.Drawing.SystemColors.MenuText
        Me.user_cPword_txt.Location = New System.Drawing.Point(1004, 141)
        Me.user_cPword_txt.Name = "user_cPword_txt"
        Me.user_cPword_txt.Size = New System.Drawing.Size(117, 29)
        Me.user_cPword_txt.TabIndex = 5
        Me.user_cPword_txt.UseSystemPasswordChar = True
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label27.Location = New System.Drawing.Point(891, 145)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(115, 19)
        Me.Label27.TabIndex = 23
        Me.Label27.Text = "CONFIRM P.WORD"
        '
        'user_update_btn
        '
        Me.user_update_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.user_update_btn.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.user_update_btn.ForeColor = System.Drawing.SystemColors.MenuText
        Me.user_update_btn.Location = New System.Drawing.Point(810, 133)
        Me.user_update_btn.Name = "user_update_btn"
        Me.user_update_btn.Size = New System.Drawing.Size(81, 36)
        Me.user_update_btn.TabIndex = 22
        Me.user_update_btn.Text = "UPDATE"
        Me.user_update_btn.UseVisualStyleBackColor = False
        '
        'user_save_btn
        '
        Me.user_save_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.user_save_btn.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.user_save_btn.ForeColor = System.Drawing.SystemColors.MenuText
        Me.user_save_btn.Location = New System.Drawing.Point(723, 133)
        Me.user_save_btn.Name = "user_save_btn"
        Me.user_save_btn.Size = New System.Drawing.Size(81, 36)
        Me.user_save_btn.TabIndex = 21
        Me.user_save_btn.Text = "SAVE"
        Me.user_save_btn.UseVisualStyleBackColor = False
        '
        'user_utype_combo
        '
        Me.user_utype_combo.AutoCompleteCustomSource.AddRange(New String() {"ADMIN", "DOCTOR", "NURSE"})
        Me.user_utype_combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.user_utype_combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.user_utype_combo.BackColor = System.Drawing.SystemColors.ControlDark
        Me.user_utype_combo.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.user_utype_combo.ForeColor = System.Drawing.SystemColors.MenuText
        Me.user_utype_combo.FormattingEnabled = True
        Me.user_utype_combo.Items.AddRange(New Object() {"ADMIN", "DOCTOR", "NURSE"})
        Me.user_utype_combo.Location = New System.Drawing.Point(1199, 68)
        Me.user_utype_combo.Name = "user_utype_combo"
        Me.user_utype_combo.Size = New System.Drawing.Size(92, 29)
        Me.user_utype_combo.TabIndex = 7
        '
        'user_lname_txt
        '
        Me.user_lname_txt.BackColor = System.Drawing.SystemColors.ControlDark
        Me.user_lname_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.user_lname_txt.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.user_lname_txt.ForeColor = System.Drawing.SystemColors.MenuText
        Me.user_lname_txt.Location = New System.Drawing.Point(1004, 68)
        Me.user_lname_txt.Name = "user_lname_txt"
        Me.user_lname_txt.Size = New System.Drawing.Size(117, 29)
        Me.user_lname_txt.TabIndex = 3
        '
        'user_username_txt
        '
        Me.user_username_txt.BackColor = System.Drawing.SystemColors.ControlDark
        Me.user_username_txt.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.user_username_txt.ForeColor = System.Drawing.SystemColors.MenuText
        Me.user_username_txt.Location = New System.Drawing.Point(1004, 103)
        Me.user_username_txt.Name = "user_username_txt"
        Me.user_username_txt.Size = New System.Drawing.Size(117, 29)
        Me.user_username_txt.TabIndex = 4
        '
        'user_contact_txt
        '
        Me.user_contact_txt.BackColor = System.Drawing.SystemColors.ControlDark
        Me.user_contact_txt.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.user_contact_txt.ForeColor = System.Drawing.SystemColors.MenuText
        Me.user_contact_txt.Location = New System.Drawing.Point(1193, 102)
        Me.user_contact_txt.Name = "user_contact_txt"
        Me.user_contact_txt.Size = New System.Drawing.Size(96, 29)
        Me.user_contact_txt.TabIndex = 8
        '
        'user_email_txt
        '
        Me.user_email_txt.BackColor = System.Drawing.SystemColors.ControlDark
        Me.user_email_txt.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.user_email_txt.ForeColor = System.Drawing.SystemColors.MenuText
        Me.user_email_txt.Location = New System.Drawing.Point(1173, 131)
        Me.user_email_txt.Name = "user_email_txt"
        Me.user_email_txt.Size = New System.Drawing.Size(117, 29)
        Me.user_email_txt.TabIndex = 9
        '
        'user_fname_txt
        '
        Me.user_fname_txt.BackColor = System.Drawing.SystemColors.ControlDark
        Me.user_fname_txt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.user_fname_txt.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.user_fname_txt.ForeColor = System.Drawing.SystemColors.MenuText
        Me.user_fname_txt.Location = New System.Drawing.Point(1004, 33)
        Me.user_fname_txt.Name = "user_fname_txt"
        Me.user_fname_txt.Size = New System.Drawing.Size(117, 29)
        Me.user_fname_txt.TabIndex = 2
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label14.Location = New System.Drawing.Point(1127, 132)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 21)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "EMAIL"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label20.Location = New System.Drawing.Point(1127, 103)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 21)
        Me.Label20.TabIndex = 11
        Me.Label20.Text = "CONTACT"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label21.Location = New System.Drawing.Point(1122, 73)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(81, 21)
        Me.Label21.TabIndex = 10
        Me.Label21.Text = "USER TYPE"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label22.Location = New System.Drawing.Point(1122, 38)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(62, 21)
        Me.Label22.TabIndex = 8
        Me.Label22.Text = "P.WORD"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label23.Location = New System.Drawing.Point(930, 106)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(77, 19)
        Me.Label23.TabIndex = 7
        Me.Label23.Text = "USERNAME"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label24.Location = New System.Drawing.Point(931, 71)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(64, 21)
        Me.Label24.TabIndex = 6
        Me.Label24.Text = "L-NAME"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label25.Location = New System.Drawing.Point(931, 36)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(63, 21)
        Me.Label25.TabIndex = 5
        Me.Label25.Text = "F-NAME"
        '
        'user_delete_btn
        '
        Me.user_delete_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.user_delete_btn.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.user_delete_btn.ForeColor = System.Drawing.SystemColors.MenuText
        Me.user_delete_btn.Location = New System.Drawing.Point(546, 133)
        Me.user_delete_btn.Name = "user_delete_btn"
        Me.user_delete_btn.Size = New System.Drawing.Size(81, 36)
        Me.user_delete_btn.TabIndex = 4
        Me.user_delete_btn.Text = "DELETE"
        Me.user_delete_btn.UseVisualStyleBackColor = False
        '
        'user_search_btn
        '
        Me.user_search_btn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.user_search_btn.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.user_search_btn.ForeColor = System.Drawing.SystemColors.MenuText
        Me.user_search_btn.Location = New System.Drawing.Point(459, 133)
        Me.user_search_btn.Name = "user_search_btn"
        Me.user_search_btn.Size = New System.Drawing.Size(81, 36)
        Me.user_search_btn.TabIndex = 3
        Me.user_search_btn.Text = "SEARCH"
        Me.user_search_btn.UseVisualStyleBackColor = False
        '
        'user_id_txt
        '
        Me.user_id_txt.BackColor = System.Drawing.SystemColors.ControlDark
        Me.user_id_txt.ForeColor = System.Drawing.SystemColors.MenuText
        Me.user_id_txt.Location = New System.Drawing.Point(227, 135)
        Me.user_id_txt.Name = "user_id_txt"
        Me.user_id_txt.Size = New System.Drawing.Size(226, 36)
        Me.user_id_txt.TabIndex = 1
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label26.Location = New System.Drawing.Point(140, 138)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(81, 28)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "USER ID"
        '
        'User_grid
        '
        Me.User_grid.AllowUserToAddRows = False
        Me.User_grid.AllowUserToDeleteRows = False
        Me.User_grid.AllowUserToOrderColumns = True
        Me.User_grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.User_grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlDark
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.User_grid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.User_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.User_grid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.User_grid.Location = New System.Drawing.Point(6, 33)
        Me.User_grid.Name = "User_grid"
        Me.User_grid.ReadOnly = True
        Me.User_grid.RowTemplate.Height = 25
        Me.User_grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.User_grid.Size = New System.Drawing.Size(923, 94)
        Me.User_grid.TabIndex = 0
        '
        'refresh_btn
        '
        Me.refresh_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.refresh_btn.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.refresh_btn.ForeColor = System.Drawing.SystemColors.Control
        Me.refresh_btn.Location = New System.Drawing.Point(31, 673)
        Me.refresh_btn.Name = "refresh_btn"
        Me.refresh_btn.Size = New System.Drawing.Size(98, 36)
        Me.refresh_btn.TabIndex = 5
        Me.refresh_btn.Text = "REFRESH"
        Me.refresh_btn.UseVisualStyleBackColor = False
        '
        'logout_btn
        '
        Me.logout_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.logout_btn.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.logout_btn.ForeColor = System.Drawing.SystemColors.Control
        Me.logout_btn.Location = New System.Drawing.Point(135, 673)
        Me.logout_btn.Name = "logout_btn"
        Me.logout_btn.Size = New System.Drawing.Size(98, 36)
        Me.logout_btn.TabIndex = 6
        Me.logout_btn.Text = "LOGOUT"
        Me.logout_btn.UseVisualStyleBackColor = False
        '
        'close_btn
        '
        Me.close_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.close_btn.Font = New System.Drawing.Font("Segoe Print", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.close_btn.ForeColor = System.Drawing.Color.Red
        Me.close_btn.Location = New System.Drawing.Point(239, 673)
        Me.close_btn.Name = "close_btn"
        Me.close_btn.Size = New System.Drawing.Size(98, 36)
        Me.close_btn.TabIndex = 7
        Me.close_btn.Text = "CLOSE"
        Me.close_btn.UseVisualStyleBackColor = False
        '
        'admin_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1338, 721)
        Me.ControlBox = False
        Me.Controls.Add(Me.close_btn)
        Me.Controls.Add(Me.logout_btn)
        Me.Controls.Add(Me.refresh_btn)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "admin_form"
        Me.Text = "ADMIN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.student_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.teacher_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.User_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents stud_id_txt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents student_grid As DataGridView
    Friend WithEvents stud_search_btn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents stud_update_btn As Button
    Friend WithEvents stud_save_btn As Button
    Friend WithEvents stud_status_combo As ComboBox
    Friend WithEvents stud_sex_combo As ComboBox
    Friend WithEvents stud_lname_txt As TextBox
    Friend WithEvents stud_address_txt As TextBox
    Friend WithEvents stud_age_txt As TextBox
    Friend WithEvents stud_contact_txt As TextBox
    Friend WithEvents stud_email_txt As TextBox
    Friend WithEvents stud_fname_txt As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents stud_delete_btn As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents teach_update_btn As Button
    Friend WithEvents teach_save_btn As Button
    Friend WithEvents teach_status_combo As ComboBox
    Friend WithEvents teach_sex_combo As ComboBox
    Friend WithEvents teach_lname_txt As TextBox
    Friend WithEvents teach_address_txt As TextBox
    Friend WithEvents teach_contact_txt As TextBox
    Friend WithEvents teach_email_txt As TextBox
    Friend WithEvents teach_fname_txt As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents teach_delete_btn As Button
    Friend WithEvents teach_search_btn As Button
    Friend WithEvents teach_id_txt As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents teacher_grid As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label27 As Label
    Friend WithEvents user_update_btn As Button
    Friend WithEvents user_save_btn As Button
    Friend WithEvents user_utype_combo As ComboBox
    Friend WithEvents user_lname_txt As TextBox
    Friend WithEvents user_username_txt As TextBox
    Friend WithEvents user_contact_txt As TextBox
    Friend WithEvents user_email_txt As TextBox
    Friend WithEvents user_fname_txt As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents user_delete_btn As Button
    Friend WithEvents user_search_btn As Button
    Friend WithEvents user_id_txt As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents User_grid As DataGridView
    Friend WithEvents user_pword_txt As TextBox
    Friend WithEvents user_cPword_txt As TextBox
    Friend WithEvents refresh_btn As Button
    Friend WithEvents logout_btn As Button
    Friend WithEvents close_btn As Button
End Class
