Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Register
    Public Con_String As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\visual\LatestProject\UserDB.mdf;Integrated Security=True;Connect Timeout=30"
    Public Sub Wallet()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = Con_String
        con.Open()
        cmd.Connection = con
        cmd.CommandText = "Insert into balance(e_mail, Amount) values(@mail, 0)"
        cmd.Parameters.Add("@mail", SqlDbType.VarChar, 50).Value = mail.Text
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        con.ConnectionString = Con_String
        con.Open()
        Dim regex As Regex = New Regex("^[a-z0-9](\.?[a-z0-9]){3,}@gmail|@hotmail|@outlook\.com$")
        Dim isValid As Boolean = regex.IsMatch(mail.Text.Trim)
        Try
            If (fname.Text = "" Or lname.Text = "" Or dob.Text = "" Or gender.Text = "" Or phone.Text = "" Or mail.Text = "" Or aadhaar.Text = "" Or pan.Text = "" Or pass.Text = "") Then
                MessageBox.Show("Please Enter all the Details")
            Else
                If Not isValid Then
                    MessageBox.Show("Invalid Email.")
                    mail.Clear()
                ElseIf (pass.Text <> cnfpass.Text) Then
                    MessageBox.Show("Password Missmatch")
                    pass.Clear()
                    cnfpass.Clear()
                Else
                    cmd = New SqlCommand("Insert into userDB(F_Name, L_Name, DOB, Gender, Phone, E_Mail, Aadhaar, Pan, Password) values(' " & fname.Text & " ', ' " & lname.Text & " ', ' " & dob.Text & " ', ' " & gender.Text & " ', ' " & phone.Text & " ', ' " & mail.Text & " ', ' " & aadhaar.Text & " ', ' " & pan.Text & " ', ' " & pass.Text & " ')", con)
                    cmd.ExecuteNonQuery()
                    Wallet()
                    MsgBox("Registration Completed Successfully. Happy Trading.", MsgBoxStyle.Information, "Success")
                    Me.Hide()
                    Login.Show()
                    fname.Clear()
                    lname.Clear()
                    phone.Clear()
                    mail.Clear()
                    aadhaar.Clear()
                    pan.Clear()
                    pass.Clear()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Data Already Registered. Try Different Mail ID.")
        End Try
        con.Close()
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Hide()
        Welcome.Show()
    End Sub
End Class