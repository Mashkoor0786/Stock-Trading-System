Imports System.Data.SqlClient
Imports System.IO
Public Class Inventory
    Public Sub PurchaseLoad()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt2 As New DataTable
        con = New SqlConnection(Register.Con_String)
        con.Open()
        cmd.Parameters.Clear()
        cmd.Dispose()
        cmd.Connection = con
        cmd.CommandText = "Select Stock_ID, Purchased_Quantity, Purchased_Price, Total_Price from Purchased where E_Mail=@ReadMail"
        cmd.Parameters.Add("@ReadMail", SqlDbType.VarChar, 50).Value = UserProfile.mail.Text
        da.SelectCommand = cmd
        da.Fill(dt2)
        PurchasedGrid.DataSource = dt2
        con.Close()
    End Sub
    Public Sub SoldLoad()
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt2 As New DataTable
        con = New SqlConnection(Register.Con_String)
        con.Open()
        cmd.Parameters.Clear()
        cmd.Dispose()
        cmd.Connection = con
        cmd.CommandText = "Select Stock_ID, Sold_Quantity, Sold_Price, Total_Price, Profit_Loss from Sold where E_Mail=@ReadMail"
        cmd.Parameters.Add("@ReadMail", SqlDbType.VarChar, 50).Value = UserProfile.mail.Text
        da.SelectCommand = cmd
        da.Fill(dt2)
        SoldGrid.DataSource = dt2
        con.Close()
    End Sub

    Private Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Refresh()
        SoldGrid.Refresh()
        PurchasedGrid.Refresh()
        PurchaseLoad()
        SoldLoad()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Me.Refresh()
        BuyStock.Show()
        Me.Close()
        BuyStock.ReadBalance()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Refresh()
        SellStock.Show()
        Me.Close()
    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Hide()
        UserProfile.Refresh()
        UserProfile.Show()
    End Sub
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Me.Hide()
        Stocks.Refresh()
        Stocks.Show()
    End Sub
    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        Me.Hide()
        BuyStock.Refresh()
        BuyStock.Show()
    End Sub
    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        Me.Hide()
        SellStock.Refresh()
        SellStock.Show()
    End Sub
    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        Me.Refresh()
        SoldGrid.Refresh()
        PurchasedGrid.Refresh()
    End Sub

End Class