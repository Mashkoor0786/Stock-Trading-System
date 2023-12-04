Imports System.Data.SqlClient
Imports System.IO
Public Class UserProfile
    Public amt As Integer = 0
    Public con As New SqlConnection
    Public cmd As New SqlCommand
    Public Reader As SqlDataReader
    Public MailPara As String
    Public Sub Profile()
        F_Name.Text = Login.Reader("F_Name")
        L_Name.Text = Login.Reader("L_Name")
        gender.Text = Login.Reader("Gender")
        dob.Text = Login.Reader("DOB")
        phone.Text = Login.Reader("Phone")
        mail.Text = Login.Reader("E_Mail")
        aadhaar.Text = Login.Reader("Aadhaar")
        pan.Text = Login.Reader("Pan")
    End Sub
    Public Sub AccountBalance()
        Dim intValue As Integer
        If Integer.TryParse(amount.Text, intValue) AndAlso intValue > 0 Then
            amt += Int(amount.Text)
            balance.Text = amt
        Else
            MessageBox.Show("Please Enter an Amount.")
        End If
    End Sub
    Public Sub ReadBalance()
        con = New SqlConnection(Register.Con_String)
        con.Open()
        'cmd.Parameters.Clear()
        'cmd.Dispose()
        cmd.Connection = con
        cmd.CommandText = "Select * from balance where e_mail = @mail"
        cmd.Parameters.Add("@mail", SqlDbType.VarChar, 50).Value = MailPara
        Reader = cmd.ExecuteReader
        Reader.Read()
        balance.Text = Reader("Amount")
        amt = Int(balance.Text)
        con.Close()
    End Sub
    Public Sub UpdateBalance()
        con = New SqlConnection(Register.Con_String)
        con.Open()
        cmd.Connection = con
        cmd.Parameters.Clear()
        cmd.CommandText = "update balance set Amount = @amt where e_mail = @mail"
        cmd.Parameters.Add("@amt", SqlDbType.Int).Value = Int(balance.Text)
        cmd.Parameters.Add("@mail", SqlDbType.VarChar, 50).Value = Login.mail.Text
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Private Sub UserProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MailPara = Login.mail.Text
        Profile()
        ReadBalance()
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim Alert As DialogResult
        Alert = MessageBox.Show("Are you Sure Want to log out ?", "confirmation", MessageBoxButtons.YesNo)
        If Alert = DialogResult.Yes Then
            Me.Close()
            MessageBox.Show("Sucessfully Logged Out")
            Welcome.Show()
        End If
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        If Val(balance.Text) > 0 Then
            Me.Hide()
            Stocks.Show()
        Else
            MessageBox.Show("Amount Should be added first.")
        End If
    End Sub
    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click
        AccountBalance()
        UpdateBalance()
        amount.Clear()
    End Sub
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Refresh()
    End Sub
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Me.Hide()
        Stocks.Refresh()
        Stocks.Show()
    End Sub
    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        If Val(balance.Text) > 0 Then
            Me.Hide()
            BuyStock.Refresh()
            BuyStock.Show()
        Else
            MessageBox.Show("Amount Should be added first.")
        End If
    End Sub
    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        Me.Hide()
        SellStock.Refresh()
        SellStock.Show()
    End Sub
    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        Me.Hide()
        Inventory.Refresh()
        Inventory.Show()
    End Sub
End Class