﻿Public Class Stocks
    Private Sub Stocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CPtimer.Start()
    End Sub
    Private Sub CPTimer_Tick(sender As Object, e As EventArgs) Handles CPtimer.Tick
        Randomize()
        Dim hdfc As Integer
        Dim reliance As Integer
        Dim icici As Integer
        Dim tcs As Integer
        Dim hul As Integer
        Dim infosys As Integer
        Dim kotak As Integer
        hdfc = Int((100 * Rnd()) + 75)
        reliance = Int((100 * Rnd()) + 80)
        icici = Int((100 * Rnd()) + 65)
        tcs = Int((100 * Rnd()) + 70)
        hul = Int((100 * Rnd()) + 50)
        infosys = Int((100 * Rnd()) + 60)
        kotak = Int((100 * Rnd()) + 55)
        hdfcCP.Text = Val(hdfc)
        relianceCP.Text = Val(reliance)
        iciciCP.Text = Val(icici)
        tcsCP.Text = Val(tcs)
        hulCP.Text = Val(hul)
        infosysCP.Text = Val(infosys)
        kotakCP.Text = Val(kotak)
    End Sub
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        BuyStock.Show()
        Me.Hide()
    End Sub
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Inventory.Show()
        Me.Hide()
    End Sub
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Hide()
        UserProfile.Show()
    End Sub
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Me.Refresh()
    End Sub
    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click
        Me.Hide()
        BuyStock.Show()
    End Sub
    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        Me.Hide()
        SellStock.Show()
    End Sub
    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        Me.Hide()
        Inventory.Show()
    End Sub
End Class