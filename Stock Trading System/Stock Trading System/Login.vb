Imports System.Data.SqlClient
Public Class Login
    Public cmd As New SqlCommand
    Public Reader As SqlDataReader
    Public con As New SqlConnection
    Public mailID As String
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        con.ConnectionString = Register.Con_String
        con.Open()
        Dim grant As String = "Select * from userDB where E_Mail = ' " & mail.Text & " ' And Password = ' " & password.Text & " ' "
        cmd = New SqlCommand(grant, con)
        Reader = cmd.ExecuteReader
        If Reader.Read Then
            MessageBox.Show("Authentication Successful")
            mailID = mail.Text
            Me.Hide()
            UserProfile.Show()
        Else
            MessageBox.Show("Unauthorize Access")
            password.Clear()
        End If
        Reader.Close()
        con.Close()
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Application.Exit()
    End Sub
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        Me.Hide()
        Register.Show()
    End Sub
End Class