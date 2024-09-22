Imports System.Data.SqlClient
Public Class NurseForm
    Private Sub loadUser_data()
        Dim cmd As New SqlCommand(" select * from Hospital_DOCTORS", con)
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        sda.Fill(dt)
        DoctorGridView1.DataSource = dt
    End Sub
    Private Sub load_record()
        Dim cmd As New SqlCommand("select * from Hospital_Daily_Record", con)
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        sda.Fill(dt)
        appointment_loadDataInGrid.DataSource = dt
    End Sub
    Private Sub get_btn_Click(sender As Object, e As EventArgs) Handles get_btn.Click
        Dim id As String = pat_hospId_txt.Text
        Dim result As DialogResult
        If student_CheckBox.Checked = True And teacher_CheckBox.Checked = True Then
            MessageBox.Show("Student's AND Teacher's CHECKBOX Cannot be checked", "UNCHECK A CHECKBOX", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf student_CheckBox.Checked = True And pat_hospId_txt.Text <> String.Empty Then
            Dim cmd As New SqlCommand("select * from student where Student_id = '" & Convert.ToInt32(id) & "'", con)
            Dim sda As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            sda.Fill(dt)
            con.Open()
            If dt.Rows.Count = 0 Then
                MessageBox.Show("HOSPITAL RECORD DOES NOT EXIST!!!!", "VISIT LIMKOKWING REGISTERY")
                n.Show()
            ElseIf dt.Rows(0)(0) = Convert.ToInt32(id) Then
                pat_Fname_txt.Text = dt.Rows(0)(1).ToString
                pat_Lname_txt.Text = dt.Rows(0)(2).ToString
            End If
            con.Close()
        ElseIf teacher_CheckBox.Checked = True And pat_hospId_txt.Text <> String.Empty Then
            Dim cmd As New SqlCommand("select * from teacher where Teacher_id = '" & Convert.ToInt32(id) & "'", con)
            Dim sda As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            sda.Fill(dt)
            con.Open()
            If dt.Rows.Count = 0 Then
                MessageBox.Show("HOSPITAL RECORD DOES NOT EXIST!!!!", "VISIT LIMKOKWING REGISTERY")
                n.Show()
                con.Close()
            ElseIf dt.Rows(0)(0) = Convert.ToInt32(id) Then
                pat_Fname_txt.Text = dt.Rows(0)(1).ToString
                pat_Lname_txt.Text = dt.Rows(0)(2).ToString
            End If
        Else
            Do
                result = MessageBox.Show("PLEASE CONFIRM THE CHECKBOX OR HOSPITAL ID", "ERROR GETTING DETAILS", MessageBoxButtons.OKCancel)

            Loop Until result = DialogResult.OK

        End If
    End Sub

    Private Sub NurseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load_record()
        'loadUser_data()
    End Sub

    Private Sub create_Appointment_btn_Click(sender As Object, e As EventArgs) Handles create_Appointment_btn.Click
        Dim id As String = pat_hospId_txt.Text
        Dim Fname As String = pat_Fname_txt.Text
        Dim Lname As String = pat_Lname_txt.Text
        Dim Exercise As String = exercise_combo.SelectedItem
        Dim Alcohol As String = alcohol_combo.SelectedItem
        Dim smoke As String = smoke_combo.SelectedItem
        Dim reason As String = pat_reason_txt.Text
        Dim user_id As String = doctor_txt.Text
        Dim result As DialogResult
        Dim cmdT As New SqlCommand("insert into Hospital_table (Patient_Fname, Patient_Lname, Exercises, Smoke, Alcohol, Reason, Teacher_id, user_id)
                values ('" & Fname & "','" & Lname & "','" & Exercise & "','" & smoke & "','" & Alcohol & "','" & reason & "', '" & id & "','" & user_id & "') ", con)
        Dim cmdS As New SqlCommand("insert into Hospital_table (Patient_Fname, Patient_Lname, Exercises, Smoke, Alcohol, Reason, Student_id, user_id)
                values ('" & Fname & "','" & Lname & "','" & Exercise & "','" & smoke & "','" & Alcohol & "','" & reason & "', '" & id & "','" & user_id & "') ", con)
        If id = String.Empty Or Fname = String.Empty Or Lname = String.Empty Or exercise_combo.SelectedIndex = -1 Or alcohol_combo.SelectedIndex = -1 Or smoke_combo.SelectedIndex = -1 Or reason = String.Empty Or user_id = String.Empty Then
            result = MessageBox.Show("INCOMPLETE ENTRY, CHECK ENTRY", "NOTICE!!!!", MessageBoxButtons.OKCancel)
            While result = DialogResult.Cancel
                result = MessageBox.Show("INCOMPLETE ENTERY", "WARNING", MessageBoxButtons.OKCancel)
                n.Show()
            End While
        ElseIf student_CheckBox.Checked = True Then
            con.Open()
            cmdS.ExecuteNonQuery()
            MessageBox.Show("SUCESSFULLY CREATED", "NOTICE")
            load_record()
            con.Close()
            pat_hospId_txt.Text = ""
            pat_Fname_txt.Text = ""
            exercise_combo.ResetText()
            alcohol_combo.ResetText()
            smoke_combo.ResetText()
            pat_reason_txt.Text = ""
            doctor_txt.Text = ""
        ElseIf teacher_CheckBox.Checked = True Then
            con.Close()
            con.Open()
            cmdT.ExecuteNonQuery()
            MessageBox.Show("SUCESSFULLY CREATED", "NOTICE")
            load_record()
            con.Close()
            pat_hospId_txt.Text = ""
            pat_Fname_txt.Text = ""
            pat_Lname_txt.Text = ""
            exercise_combo.ResetText()
            alcohol_combo.ResetText()
            smoke_combo.ResetText()
            pat_reason_txt.Text = ""
            doctor_txt.Text = ""
            student_CheckBox.Checked = False
            teacher_CheckBox.Checked = False
        End If

    End Sub

    Private Sub update_Appointment_btn_Click(sender As Object, e As EventArgs) Handles update_Appointment_btn.Click
        Dim id As String = pat_hospId_txt.Text
        Dim Fname As String = pat_Fname_txt.Text
        Dim Lname As String = pat_Lname_txt.Text
        Dim Exercise As String = exercise_combo.SelectedItem
        Dim Alcohol As String = alcohol_combo.SelectedItem
        Dim smoke As String = smoke_combo.SelectedItem
        Dim reason As String = pat_reason_txt.Text
        Dim user_id As String = doctor_txt.Text
        Dim cmdT As New SqlCommand("update Hospital_table set  Exercises = '" & Exercise & "', Smoke = '" & smoke & "', Alcohol = '" & Alcohol & "', Reason = '" & reason & "', user_id = '" & user_id & "', Teacher_id = '" & id & "' WHERE Teacher_id = '" & id & "'", con)
        Dim result As DialogResult
        Dim cmdS As New SqlCommand("update Hospital_table set  Exercises = '" & Exercise & "', Smoke = '" & smoke & "', Alcohol = '" & Alcohol & "', Reason = '" & reason & "', user_id = '" & user_id & "', Student_id = '" & id & "' WHERE Student_id = '" & id & "'", con)
        If id = String.Empty Or Fname = String.Empty Or Lname = String.Empty Or exercise_combo.SelectedIndex = -1 Or alcohol_combo.SelectedIndex = -1 Or smoke_combo.SelectedIndex = -1 Or reason = String.Empty Or user_id = String.Empty Then
            result = MessageBox.Show("INCOMPLETE ENTRY, CHECK ENTRY", "NOTICE!!!!", MessageBoxButtons.OKCancel)
            While result = DialogResult.Cancel
                result = MessageBox.Show("INCOMPLETE ENTERY", "WARNING", MessageBoxButtons.OKCancel)
                n.Show()
            End While
        ElseIf teacher_CheckBox.Checked = True Then
            con.Close()
            con.Open()
            cmdT.ExecuteNonQuery()
            MessageBox.Show("SUCESSFULLY CREATED", "NOTICE")
            load_record()
            con.Close()
            pat_hospId_txt.Text = ""
            pat_Fname_txt.Text = ""
            exercise_combo.ResetText()
            alcohol_combo.ResetText()
            smoke_combo.ResetText()
            pat_reason_txt.Text = ""
            doctor_txt.Text = ""
        ElseIf student_CheckBox.Checked = True Then
            con.Open()
            cmdS.ExecuteNonQuery()
            MessageBox.Show("SUCESSFULLY CREATED", "NOTICE")
            load_record()
            con.Close()
            pat_hospId_txt.Text = ""
            pat_Fname_txt.Text = ""
            exercise_combo.ResetText()
            alcohol_combo.ResetText()
            smoke_combo.ResetText()
            pat_reason_txt.Text = ""
            doctor_txt.Text = ""
        Else
            MessageBox.Show("PLEASE CHECK Student Checkbox or Teacher Checkbox", "NOTICE!!!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub logout_btn_Click(sender As Object, e As EventArgs) Handles logout_btn.Click
        Dim result As DialogResult
        Dim pause As Long = 1000000000
        Dim start As Long = 0
        result = MessageBox.Show("DO YOU WANT TO LOGOUT", "WARNING!!!!", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            n.Show()
        Else
            MessageBox.Show("PLEASE WAIT")
            While start < pause
                start += 1
            End While
            wel.Show()
            Me.Hide()
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

    Private Sub DoctorGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DoctorGridView1.CellContentDoubleClick
        Dim i As Integer = DoctorGridView1.CurrentRow.Index
        doctor_txt.Text = DoctorGridView1.Item(0, i).Value

    End Sub

End Class