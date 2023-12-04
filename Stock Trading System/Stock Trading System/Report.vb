Public Class Report
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click

    End Sub
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Me.Hide()
        UserProfile.Show()
    End Sub
    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        Me.Hide()
        Stocks.Show()
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