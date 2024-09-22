Imports System.Data.SqlClient
Module Module1
    Public con As New SqlConnection("Data Source=Michael;Initial Catalog=LIMKOKWING_SYSTEM;Integrated Security=True")
    Public wel As New welcome_form
    Public a As New admin_form
    Public n As New NurseForm
    Public d As New Doctor
End Module
