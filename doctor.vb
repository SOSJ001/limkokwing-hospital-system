Imports System.Data.SqlClient
Public Class Doctor
    Private Sub hospital_LoadDataInGrid()
        Dim cmd As New SqlCommand("select * from Hospital_Daily_Record", con)
        Dim sda As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        sda.Fill(dt)
        patientGridView2.DataSource = dt
    End Sub
    Private Sub logout_btn_Click(sender As Object, e As EventArgs) Handles logout_btn.Click
        Dim result As DialogResult
        Dim pause As Long = 1000000000
        Dim start As Long = 0
        result = MessageBox.Show("DO YOU WANT TO LOGOUT", "WARNING!!!!", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            d.Show()
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

    Private Sub loadDoc_patient_Click(sender As Object, e As EventArgs) Handles loadDoc_patient.Click
        Dim doc_id As String = doc_id_txt.Text
        Dim result As DialogResult

        If doc_id = String.Empty Then
            result = MessageBox.Show("LOAD DOCTOR ID TO SEE PATIENT", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
            While result = DialogResult.Cancel
                result = MessageBox.Show("LOAD DOCTOR ID TO SEE PATIENT", "WARNING", MessageBoxButtons.OKCancel, MessageBoxIcon.Error)
                d.Show()
            End While
        Else
            con.Open()
            Dim cmd As New SqlCommand(" SELECT * FROM LOAD_DOC_PATIENT WHERE Doctor_id = '" & doc_id & "' ", con)
            Dim sda As New SqlDataAdapter(cmd)
            Dim dt As New DataTable
            sda.Fill(dt)
            assDocGridView1.DataSource = dt
            MessageBox.Show("THESE ARE YOUR PATIENTS", "NOTICE!!!!")
            con.Close()
        End If



    End Sub

    Private Sub add_record_btn_Click(sender As Object, e As EventArgs) Handles add_record_btn.Click
        Dim id As String = pat_id_txt.Text
        Dim record As String = doc_record_txt.Text
        Dim result As DialogResult
        Dim cmdAddRecord As New SqlCommand("")
        Dim sda As New SqlDataAdapter(cmdAddRecord)

        If id = String.Empty Then
            result = MessageBox.Show("DOUBLE CLICK ON PATIENT NAME TO GET HOSPITAL ID OR SEARCH FOR HOSPITAL ID", "WARNING!!!!", MessageBoxButtons.OKCancel)
            While result = DialogResult.Cancel
                MessageBox.Show("DOUBLE CLICK ON PATIENT NAME TO GET HOSPITAL ID OR SEARCH FOR HOSPITAL ID", "WARNING!!!!", MessageBoxButtons.OKCancel)
                d.Show()
            End While
        Else
            Dim cmd As New SqlCommand("UPDATE Hospital_table set Reason = '" & record & "' WHERE Id_number = '" & id & "'", con)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("RECORD UPDATED", "UPDATE!!")
            hospital_LoadDataInGrid()
        End If
    End Sub

    Private Sub clear_btn_Click(sender As Object, e As EventArgs) Handles clear_btn.Click
        pat_id_txt.Text = ""
        doc_record_txt.Text = ""
    End Sub

    Private Sub srch_hos_id_btn_Click(sender As Object, e As EventArgs) Handles srch_hos_id_btn.Click
        Dim id As String = pat_id_txt.Text
        Dim cmdT As New SqlCommand("SELECT Patient_Fname,Patient_Lname,Exercises,Smoke,Alcohol,Reason FROM Hospital_table where Teacher_id = '" & id & "'", con)
        Dim sdaT As New SqlDataAdapter(cmdT)
        Dim cmdS As New SqlCommand("SELECT Patient_Fname,Patient_Lname,Exercises,Smoke,Alcohol,Reason FROM Hospital_table where Student_id = '" & id & "'", con)
        Dim sdaS As New SqlDataAdapter(cmdS)
        Dim dt As New DataTable
        If Student_RadioButton.Checked = False And Teacher_RadioButton.Checked = False Then
            MessageBox.Show("CHECK THE STUDENT OR TEACHER", "NOTICE!!!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            d.Show()
        ElseIf Student_RadioButton.Checked = True Then
            sdaS.Fill(dt)
            If dt.Rows.Count = 0 Then
                MessageBox.Show("NO APPOINTMENT")
            End If
        ElseIf Teacher_RadioButton.Checked = True Then
            sdaT.Fill(dt)
            If dt.Rows.Count = 0 Then
                MessageBox.Show("NO APPOINTMENT")
            End If
        ElseIf dt.Rows.Count = 0 Then
            MessageBox.Show("YOU HAVE NO APPOINTMENT WITH THIS PATIENT", "NOTICE!!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        assDocGridView1.DataSource = dt
    End Sub

    Private Sub Doctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'hospital_LoadDataInGrid()
    End Sub

    Private Sub patientGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        hospital_LoadDataInGrid()
    End Sub

    Private Sub assDocGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles assDocGridView1.CellContentDoubleClick
        Dim i As Integer = assDocGridView1.CurrentRow.Index
        doc_record_txt.Text = assDocGridView1.Item(6, i).Value
        pat_id_txt.Text = assDocGridView1.Item(0, i).Value
    End Sub
End Class