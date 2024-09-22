Imports System.Data.SqlClient
Public Class admin_form
    Private Sub student_LoadDataInGrid()
        Dim cmd As New SqlCommand("select * from student", con)
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        sda.Fill(dt)
        student_grid.DataSource = dt
    End Sub
    Private Sub teacher_LoadDataInGrid()
        Dim cmd As New SqlCommand("select * from teacher", con)
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        sda.Fill(dt)
        teacher_grid.DataSource = dt
    End Sub
    Private Sub user_LoadDataInGrid()
        Dim cmd As New SqlCommand("select * FROM USER_VIEW ", con)
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        sda.Fill(dt)
        User_grid.DataSource = dt
    End Sub
    Private Sub admin_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'student_LoadDataInGrid()
        'teacher_LoadDataInGrid()
        'user_LoadDataInGrid()
    End Sub

    Private Sub stud_search_btn_Click(sender As Object, e As EventArgs) Handles stud_search_btn.Click
        Dim studId As String = stud_id_txt.Text
        Dim cmd As New SqlCommand("select * from student where Student_id = '" & studId & "'", con)
        Dim result As DialogResult
        If studId = String.Empty Then
            result = MessageBox.Show("ENTER STUDENT ID", "WARNING", MessageBoxButtons.OKCancel)
            While result = DialogResult.Cancel
                result = MessageBox.Show("ENTER STUDENT ID", "WARNING", MessageBoxButtons.OKCancel)
                a.Show()
            End While

        Else
            con.Open()
            Dim sda As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            sda.Fill(dt)
            student_grid.DataSource = dt
            con.Close()

        End If
    End Sub

    Private Sub stud_delete_btn_Click(sender As Object, e As EventArgs) Handles stud_delete_btn.Click
        Dim studId As String = stud_id_txt.Text
        Dim cmd As New SqlCommand(" delete from student where Student_id = '" & studId & "' ", con)
        Dim result As DialogResult
        If studId = String.Empty Then
            result = MessageBox.Show("ENTER USER ID", "WARNING", MessageBoxButtons.OKCancel)
            While result = DialogResult.Cancel
                result = MessageBox.Show("ENTER USER ID", "WARNING", MessageBoxButtons.OKCancel)
                a.Show()
            End While
        Else
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            student_LoadDataInGrid()
        End If
    End Sub

    Private Sub stud_save_btn_Click(sender As Object, e As EventArgs) Handles stud_save_btn.Click
        Dim Fname As String = stud_fname_txt.Text
        Dim Lname As String = stud_lname_txt.Text
        Dim Address As String = stud_address_txt.Text
        Dim sex As String = stud_sex_combo.SelectedItem
        Dim Status As String = stud_status_combo.SelectedItem
        Dim Age As String = stud_age_txt.Text
        Dim Email As String = stud_email_txt.Text
        Dim contact As String = stud_contact_txt.Text
        Dim result As DialogResult
        If stud_fname_txt.Text = String.Empty Or stud_lname_txt.Text = String.Empty Or stud_address_txt.Text = String.Empty Or
                stud_sex_combo.SelectedIndex = -1 Or stud_status_combo.SelectedIndex = -1 Or Age = String.Empty Or
                stud_email_txt.Text = String.Empty Or contact = String.Empty Then

            result = MessageBox.Show("IMCOMPLETE ENTRY, CHECK ENTRY", "NOTICE!!!!", MessageBoxButtons.OKCancel)
            While result = DialogResult.Cancel
                result = MessageBox.Show("ENTER USER ID", "WARNING", MessageBoxButtons.OKCancel)
                a.Show()
            End While

        Else

            con.Open()
            Dim cmd As SqlCommand = New SqlCommand("insert into student (Fname,Lname,Address,Sex,Status,Age,Email,contact) values('" & Fname & "','" & Lname & "','" & Address & "','" & sex & "',
                                               '" & Status & "','" & Age & "','" & Email & "','" & contact & "')", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Record successfully saved")
            con.Close()
            stud_fname_txt.Text = ""
            stud_lname_txt.Text = ""
            stud_address_txt.Text = ""
            stud_sex_combo.ResetText()
            stud_status_combo.ResetText()
            stud_age_txt.Text = ""
            stud_email_txt.Text = ""
            stud_contact_txt.Text = ""
            student_LoadDataInGrid()
            con.Close()
        End If
    End Sub

    Private Sub stud_update_btn_Click(sender As Object, e As EventArgs) Handles stud_update_btn.Click
        Dim studId As String = stud_id_txt.Text
        Dim Fname As String = stud_fname_txt.Text
        Dim Lname As String = stud_lname_txt.Text
        Dim Address As String = stud_address_txt.Text
        Dim sex As String = stud_sex_combo.SelectedItem
        Dim Status As String = stud_status_combo.SelectedItem
        Dim Age As String = stud_age_txt.Text
        Dim Email As String = stud_email_txt.Text
        Dim contact As String = stud_contact_txt.Text
        Dim result As DialogResult
        If studId = String.Empty Or stud_fname_txt.Text = String.Empty Or stud_lname_txt.Text = String.Empty Or stud_address_txt.Text = String.Empty Or
                stud_sex_combo.SelectedIndex = -1 Or stud_status_combo.SelectedIndex = -1 Or Age = String.Empty Or
                stud_email_txt.Text = String.Empty Or contact = String.Empty Then
            result = MessageBox.Show("ENTER STUDENT DETAILS", "WARNING", MessageBoxButtons.OKCancel)
            While result = DialogResult.Cancel
                result = MessageBox.Show("ENTER STUDENT DEAILS", "WARNING", MessageBoxButtons.OKCancel)
                a.Show()
            End While
        Else
            con.Open()
            Dim cmd As New SqlCommand(" update student set Fname = '" & Fname & "', Lname = '" & Lname & "', Address = '" & Address & "', Sex = '" & sex & "', Status = '" & Status & "', Age = '" & Convert.ToInt32(Age) & "', Email = '" & Email & "', contact = '" & Convert.ToInt32(contact) & "' 
            where Student_id = '" & Convert.ToInt32(studId) & "'", con)
            cmd.ExecuteNonQuery()
            MessageBox.Show("RECORD UPDATED", "NOTICE!!!!")
            con.Close()

            stud_fname_txt.Text = ""
            stud_lname_txt.Text = ""
            stud_address_txt.Text = ""
            stud_sex_combo.ResetText()
            stud_status_combo.ResetText()
            stud_age_txt.Text = ""
            stud_email_txt.Text = ""
            stud_contact_txt.Text = ""
            student_LoadDataInGrid()
        End If
    End Sub

    Private Sub teach_search_btn_Click(sender As Object, e As EventArgs) Handles teach_search_btn.Click
        Dim Teacher_id As String = teach_id_txt.Text
        Dim result As DialogResult
        If Teacher_id = String.Empty Then
            result = MessageBox.Show("ENTER TEACHER ID", "WARNING", MessageBoxButtons.OKCancel)
            While result = DialogResult.Cancel
                result = MessageBox.Show("ENTER TEACHER ID", "WARNING", MessageBoxButtons.OKCancel)
                a.Show()
            End While
        Else
            con.Open()
            Dim cmd As New SqlCommand(" select * from teacher where Teacher_id = '" & Teacher_id & "'", con)
            Dim sda As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            sda.Fill(dt)
            teacher_grid.DataSource = dt
            con.Close()
        End If
    End Sub

    Private Sub teach_delete_btn_Click(sender As Object, e As EventArgs) Handles teach_delete_btn.Click
        Dim teach_id As String = teach_id_txt.Text
        Dim cmd As New SqlCommand("delete from teacher where Teacher_id = '" & teach_id & "'", con)
        Dim result As DialogResult
        If teach_id = String.Empty Then
            result = MessageBox.Show("ENTER USER ID", "WARNING", MessageBoxButtons.OKCancel)
            While result = DialogResult.Cancel
                result = MessageBox.Show("ENTER USER ID", "WARNING", MessageBoxButtons.OKCancel)
                a.Show()
            End While
        Else
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            teacher_LoadDataInGrid()
        End If
    End Sub

    Private Sub teach_save_btn_Click(sender As Object, e As EventArgs) Handles teach_save_btn.Click
        Dim Fname As String = teach_fname_txt.Text
        Dim Lname As String = teach_lname_txt.Text
        Dim Address As String = teach_address_txt.Text
        Dim sex As String = teach_sex_combo.SelectedItem
        Dim Status As String = teach_status_combo.SelectedItem
        Dim Email As String = teach_email_txt.Text
        Dim contact As String = teach_contact_txt.Text
        Dim result As DialogResult

        If Fname = String.Empty Or Lname = String.Empty Or Address = String.Empty Or teach_sex_combo.SelectedIndex = -1 Or teach_status_combo.SelectedIndex = -1 Or Email = String.Empty Or contact = String.Empty Then

            result = MessageBox.Show("IMCOMPLETE ENTRY, CHECK ENTRY", "NOTICE!!!!", MessageBoxButtons.OKCancel)
            While result = DialogResult.Cancel
                result = MessageBox.Show("ENTER TEACHER ID", "WARNING", MessageBoxButtons.OKCancel)
                a.Show()
            End While
        Else
            Dim cmd As New SqlCommand("insert into teacher (Fname, Lname, Address, Sex, Status, Email, contact) values('" & Fname & "','" & Lname & "','" & Address & "','" & sex & "',
        '" & Status & "','" & Email & "','" & contact & "') ", con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()

            teach_fname_txt.Text = ""
            teach_lname_txt.Text = ""
            teach_address_txt.Text = ""
            teach_status_combo.ResetText()
            teach_sex_combo.ResetText()
            teach_email_txt.Text = ""
            teach_contact_txt.Text = ""
            teacher_LoadDataInGrid()
        End If
    End Sub

    Private Sub teach_update_btn_Click(sender As Object, e As EventArgs) Handles teach_update_btn.Click
        Dim Teach_id As String = teach_id_txt.Text
        Dim Fname As String = teach_fname_txt.Text
        Dim Lname As String = teach_lname_txt.Text
        Dim Address As String = teach_address_txt.Text
        Dim sex As String = teach_sex_combo.SelectedItem
        Dim Status As String = teach_status_combo.SelectedItem
        Dim Email As String = teach_email_txt.Text
        Dim contact As String = teach_contact_txt.Text
        Dim result As DialogResult
        If Teach_id = String.Empty Or Fname = String.Empty Or Lname = String.Empty Or Address = String.Empty Or teach_sex_combo.SelectedIndex = -1 Or teach_status_combo.SelectedIndex = -1 Or Email = String.Empty Or contact = String.Empty Then
            result = MessageBox.Show("ENTER TEACHER DETAILS", "WARNING", MessageBoxButtons.OKCancel)
            While result = DialogResult.Cancel
                result = MessageBox.Show("ENTER TEACHER DETAILS", "WARNING", MessageBoxButtons.OKCancel)
                a.Show()
            End While
        Else
            con.Open()
            Dim cmd As New SqlCommand("update teacher set Fname = '" & Fname & "',Lname = '" & Lname & "',Address = '" & Address & "',Sex = '" & sex & "', Status = '" & Status & "',Email = '" & Email & "',contact = '" & contact & "'
            where Teacher_id = '" & Teach_id & "'", con)
            cmd.ExecuteNonQuery()
            con.Close()
            teacher_LoadDataInGrid()
            teach_fname_txt.Text = ""
            teach_lname_txt.Text = ""
            teach_address_txt.Text = ""
            teach_status_combo.ResetText()
            teach_sex_combo.ResetText()
            teach_email_txt.Text = ""
            teach_contact_txt.Text = ""
        End If
    End Sub

    Private Sub user_update_btn_Click(sender As Object, e As EventArgs) Handles user_update_btn.Click
        Dim Id_number As String = user_id_txt.Text
        Dim User_Fname As String = user_fname_txt.Text
        Dim User_Lname As String = user_lname_txt.Text
        Dim UserName As String = user_username_txt.Text
        Dim Password As String = user_pword_txt.Text
        Dim conPassword As String = user_cPword_txt.Text
        Dim Account_type As String = user_utype_combo.SelectedItem
        Dim Contact As String = user_contact_txt.Text
        Dim Email As String = user_email_txt.Text
        Dim result As DialogResult
        If Id_number = String.Empty Or User_Fname = String.Empty Or User_Lname = String.Empty Or UserName = String.Empty Or Password = String.Empty Or
                Account_type = String.Empty Or Contact = String.Empty Or Email = String.Empty Then
            result = MessageBox.Show("ENTER USER ID", "WARNING", MessageBoxButtons.OKCancel)
            While result = DialogResult.Cancel
                result = MessageBox.Show("ENTER USER ID", "WARNING", MessageBoxButtons.OKCancel)
                a.Show()
            End While
        Else
            If Password <> conPassword Then
                MessageBox.Show("PASSWORD ERROR ", "WARNING ")
                a.Show()
            Else
                con.Open()
                Dim cmd As New SqlCommand(" update User_Account set  User_Fname = '" & User_Fname & "',User_Lname = '" & User_Lname & "', UserName = '" & UserName & "',Password = '" & Password & "',
                Account_type= '" & Account_type & "', Contact = '" & Contact & "', Email = '" & Email & "' where Id_number = '" & Id_number & "'", con)
                cmd.ExecuteNonQuery()
                con.Close()
                user_LoadDataInGrid()

                user_fname_txt.Text = ""
                user_lname_txt.Text = ""
                user_username_txt.Text = ""
                user_pword_txt.Text = ""
                user_cPword_txt.Text = ""
                user_utype_combo.ResetText()
                user_contact_txt.Text = ""
                user_email_txt.Text = ""
            End If
        End If
    End Sub

    Private Sub user_save_btn_Click(sender As Object, e As EventArgs) Handles user_save_btn.Click
        Dim User_Fname As String = user_fname_txt.Text
        Dim User_Lname As String = user_lname_txt.Text
        Dim UserName As String = user_username_txt.Text
        Dim Password As String = user_pword_txt.Text
        Dim conPassword As String = user_cPword_txt.Text
        Dim Account_type As String = user_utype_combo.SelectedItem
        Dim Contact As String = user_contact_txt.Text
        Dim Email As String = user_email_txt.Text
        Dim result As DialogResult

        If User_Fname = String.Empty Or User_Lname = String.Empty Or UserName = String.Empty Or Password = String.Empty Or user_utype_combo.SelectedIndex = -1 Or Email = String.Empty Or Contact = String.Empty Then

            result = MessageBox.Show("IMCOMPLETE ENTRY, CHECK ENTRY", "NOTICE!!!!", MessageBoxButtons.OKCancel)
            While result = DialogResult.Cancel
                result = MessageBox.Show("ENTER TEACHER ID", "WARNING", MessageBoxButtons.OKCancel)
                a.Show()
            End While

        Else
            If Password <> conPassword Then
                MessageBox.Show("PASSWORD ERROR ", "WARNING ")
                a.Show()
            Else
                con.Open()
                Dim cmd As New SqlCommand(" insert into User_Account values('" & User_Fname & "','" & User_Lname & "',
                '" & UserName & "', '" & Password & "', '" & Account_type & "','" & Contact & "', '" & Email & "')", con)
                cmd.ExecuteNonQuery()
                user_LoadDataInGrid()
                con.Close()

                user_fname_txt.Text = ""
                user_lname_txt.Text = ""
                user_username_txt.Text = ""
                user_pword_txt.Text = ""
                user_cPword_txt.Text = ""
                user_utype_combo.ResetText()
                user_contact_txt.Text = ""
                user_email_txt.Text = ""
            End If
        End If
    End Sub

    Private Sub user_delete_btn_Click(sender As Object, e As EventArgs) Handles user_delete_btn.Click
        Dim Id_number As String = user_id_txt.Text
        Dim cmd As New SqlCommand(" delete from User_Account where Id_number = '" & Id_number & "'", con)
        Dim result As DialogResult
        If Id_number = 0 Then
            result = MessageBox.Show("ENTER USER ID", "WARNING", MessageBoxButtons.OKCancel)
            While result = DialogResult.Cancel
                result = MessageBox.Show("ENTER USER ID", "WARNING", MessageBoxButtons.OKCancel)
                a.Show()
            End While
        Else
            con.Open()
            cmd.ExecuteNonQuery()
            user_LoadDataInGrid()
            con.Close()
        End If
    End Sub

    Private Sub user_search_btn_Click(sender As Object, e As EventArgs) Handles user_search_btn.Click
        Dim Id_number As String = user_id_txt.Text
        Dim result As DialogResult
        If Id_number = String.Empty Then
            result = MessageBox.Show("ENTER USER ID", "WARNING", MessageBoxButtons.OKCancel)
            While result = DialogResult.Cancel
                result = MessageBox.Show("ENTER USER ID", "WARNING", MessageBoxButtons.OKCancel)
                a.Show()
            End While

        Else
            con.Open()
            Dim cmd As New SqlCommand("select Id_number, User_Fname, User_Lname, Account_type, Contact, Email from User_Account where Id_number = '" & Id_number & "'", con)
            Dim sda As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            sda.Fill(dt)
            User_grid.DataSource = dt
            con.Close()
        End If
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        Dim result As DialogResult
        Dim result_1 As DialogResult
        result = MessageBox.Show("DO YOU WANT TO CLOSE?", "WARNING!!!!", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            result_1 = MessageBox.Show("LOGGING OUT FIRST", "CLOSING.......", MessageBoxButtons.OKCancel)
            If result_1 = DialogResult.Cancel Then
                a.Show()
            Else
                Dim pause As Long = 1000000000
                Dim start As Long = 0
                Dim start1 As Long = 0
                MessageBox.Show("PLEASE WAIT!!!!")
                While start < pause
                    start += 1
                End While
                wel.Show()
                Me.Hide()
                MessageBox.Show("PLEASE WAIT!!!!")
                While start1 < pause
                    start1 += 1
                End While
                End
            End If
        End If

    End Sub

    Private Sub logout_btn_Click(sender As Object, e As EventArgs) Handles logout_btn.Click
        Dim result As DialogResult
        Dim pause As Long = 1000000000
        Dim start As Long = 0
        result = MessageBox.Show("DO YOU WANT TO LOGOUT", "WARNING!!!!", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            a.Show()
        Else
            MessageBox.Show("PLEASE WAIT")
            While start < pause
                start += 1
            End While
            wel.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub refresh_btn_Click(sender As Object, e As EventArgs) Handles refresh_btn.Click
        student_LoadDataInGrid()
        teacher_LoadDataInGrid()
        user_LoadDataInGrid()
        user_id_txt.Text = ""
        user_fname_txt.Text = ""
        user_lname_txt.Text = ""
        user_username_txt.Text = ""
        user_pword_txt.Text = ""
        user_cPword_txt.Text = ""
        user_utype_combo.ResetText()
        user_contact_txt.Text = ""
        user_email_txt.Text = ""
        teach_id_txt.Text = ""
        teach_fname_txt.Text = ""
        teach_lname_txt.Text = ""
        teach_address_txt.Text = ""
        teach_status_combo.ResetText()
        teach_sex_combo.ResetText()
        teach_email_txt.Text = ""
        teach_contact_txt.Text = ""
        stud_id_txt.Text = ""
        stud_fname_txt.Text = ""
        stud_lname_txt.Text = ""
        stud_address_txt.Text = ""
        stud_sex_combo.ResetText()
        stud_status_combo.ResetText()
        stud_age_txt.Text = ""
        stud_email_txt.Text = ""
        stud_contact_txt.Text = ""
    End Sub
End Class