Imports System.Data.SqlClient
Public Class welcome_form
    Private Sub login_btn_Click(sender As Object, e As EventArgs) Handles login_btn.Click
        Dim UserName As String = wf_username_txt.Text
        Dim Password As String = wf_password_txt.Text
        'Dim cmd As New SqlCommand("select * from User_Account where UserName='" & wf_username_txt.Text & "' and Password='" & wf_password_txt.Text & "' ", con)
        'con.Close()
        'con.Open()
        'Dim sda As SqlDataAdapter = New SqlDataAdapter(cmd)
        'Dim dt As DataTable = New DataTable()
        'sda.Fill(dt)
        'If UserName <> String.Empty Or Password <> String.Empty Then
        '    If dt.Rows.Count = 0 Then
        '        MessageBox.Show("USER DETAILS DOES NOT EXIST", "ERROR")
        '    ElseIf (dt.Rows(0)("Account_type") = "Administrator") Then
        '        a.Show()
        '        Me.Hide()
        '        MessageBox.Show("WELCOME " + dt.Rows(0)(5))
        '    ElseIf (dt.Rows(0)("Account_type") = "ADMIN") Then
        '        a.Show()
        '        Me.Hide()
        '        MessageBox.Show("WELCOME " + dt.Rows(0)(5))
        '    ElseIf (dt.Rows(0)("Account_type") = "NURSE") Then
        '        n.Show()
        '        Me.Hide()
        '        MessageBox.Show("WELCOME " + dt.Rows(0)(5))
        '    ElseIf (dt.Rows(0)("Account_type") = "DOCTOR") Then
        '        d.Show()
        '        Me.Hide()
        '        MessageBox.Show("WELCOME " + dt.Rows(0)(5))
        '    Else
        '        MessageBox.Show("INVALID ENTERY", "WARNING!!! CONTACT ADMIN", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    End If

        'Else
        '    MessageBox.Show("ENTER PASSWORD OR USERNAME", "WARNING!!! ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    wel.Show()
        'End If
        'con.Close()
        n.Show()
        Me.Hide()
        wf_username_txt.Text = ""
        wf_password_txt.Text = ""
    End Sub

    Private Sub close_btn_Click(sender As Object, e As EventArgs) Handles close_btn.Click
        End
    End Sub

    Private Sub welcome_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timer_label.Text = DateAndTime.Today & " | " & TimeOfDay
    End Sub


End Class
