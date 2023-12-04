Imports System.Data.SqlClient
Imports System.IO
Public Class SellStock
    'Declarations
    Public con = New SqlConnection(Register.Con_String)
    Public cmd As New SqlCommand
    Public Reader As SqlDataReader
    Public Qty As Integer
    Dim CurrQty As Integer
    Dim ustock As String
    Dim urent As String
    Dim StockName As String
    Dim PStock As String
    Dim PrevStockQty, CurrStockQty As String
    Dim UpdateReference As String

    'Functions For Sale before Sold Button Click Event
    Public Sub PurchasedStock()
        StocksToSale.Items.Clear()
        Sell_Qty.Items.Clear()
        con.Open()
        cmd.Parameters.Clear()
        cmd.Dispose()
        cmd.Connection = con
        cmd.CommandText = "select * from Purchased where E_Mail=@ReadMail"
        cmd.Parameters.Add("@ReadMail", SqlDbType.VarChar, 50).Value = UserProfile.mail.Text
        Reader = cmd.ExecuteReader
        Do While Reader.Read
            StocksToSale.Items.Add(Reader("Stock_ID"))
        Loop
        con.Close()
    End Sub
    Public Sub ReadQty()
        Sell_Qty.Items.Clear()
        con.Open()
        cmd.Parameters.Clear()
        cmd.Dispose()
        cmd.Connection = con
        cmd.CommandText = "select * from Purchased where Stock_ID=@Stk_ID "
        cmd.Parameters.Add("@Stk_ID", SqlDbType.VarChar).Value = StocksToSale.SelectedItem
        Reader = cmd.ExecuteReader
        Do While Reader.Read
            Dim i As Integer = 0
            Qty = Int(Reader("Purchased_Quantity"))
            While (i < Qty)
                Sell_Qty.Items.Add(i + 1)
                i += 1
            End While
            Sell_Qty.SelectedIndex = 0
        Loop
        con.Close()
    End Sub
    Public Sub CurrentSellValue()
        Dim CurrentValue As Integer
        CurrentValue = Int((100 * Rnd()) + 50)
        SellValue.Text = CurrentValue
    End Sub
    Public Sub TotalStocksValue()
        TotalSellValue.Text = Val(SellValue.Text) * Val(Sell_Qty.Text)
    End Sub
    Public Sub Gain_Loss()
        Dim Profit As Integer
        Dim Loss As Integer
        Dim PrevValue As Integer
        con.Open()
        cmd.Parameters.Clear()
        cmd.Dispose()
        cmd.Connection = con
        cmd.CommandText = "select * from Purchased where Stock_ID=@Stk_ID "
        cmd.Parameters.Add("@Stk_ID", SqlDbType.VarChar).Value = StocksToSale.SelectedItem
        Reader = cmd.ExecuteReader
        Reader.Read()
        PrevValue = Reader("Purchased_Price")
        con.Close()
        If Val(SellValue.Text) > PrevValue Then
            Profit = Val(SellValue.Text) - PrevValue
            GainLoss.Text = String.Concat("+ ", Profit)
        Else
            Loss = PrevValue - Val(SellValue.Text)
            GainLoss.Text = String.Concat("- ", Loss)
        End If
        con.Close()
    End Sub

    'Functions For Sale after Sold Button Click Event
    Public Sub SoldStocks()
        con.Open()
        cmd.Parameters.Clear()
        cmd.Dispose()
        cmd.CommandText = "Insert into Sold(Stock_ID, F_Name, L_Name, E_Mail, Sold_Quantity, Sold_Price, Total_Price, Profit_Loss, Exchange_Time, Exchange_Date) values(@StockID, @FName, @LName, @EMail, @Sold_Quantity, @Sold_Price, @Total_Price,@ProfitLoss, @Time, @Date)"
        cmd.Parameters.Add("@StockID", SqlDbType.VarChar, 50).Value = UpdateReference
        cmd.Parameters.Add("@FName", SqlDbType.VarChar, 50).Value = UserProfile.F_Name.Text
        cmd.Parameters.Add("@LName", SqlDbType.VarChar, 50).Value = UserProfile.L_Name.Text
        cmd.Parameters.Add("@EMail", SqlDbType.VarChar, 50).Value = UserProfile.mail.Text
        cmd.Parameters.Add("@Sold_Quantity", SqlDbType.Int).Value = Val(Sell_Qty.Text)
        cmd.Parameters.Add("@Sold_Price", SqlDbType.Int).Value = Val(SellValue.Text)
        cmd.Parameters.Add("@Total_Price", SqlDbType.Int).Value = Val(TotalSellValue.Text)
        cmd.Parameters.Add("@ProfitLoss", SqlDbType.Int).Value = Val(GainLoss.Text)
        cmd.Parameters.Add("@Time", SqlDbType.Time).Value = System.DateTime.Now.ToString("HH:mm:ss")
        cmd.Parameters.Add("@Date", SqlDbType.Date).Value = System.DateTime.Now.Date
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub
    Public Sub CallingStock()
        StockName = StocksToSale.SelectedItem
        UpdateReference = StockName
        PStock = Val(Qty)
        If StockName.Contains("HDFC") Then
            ustock = "HDFC"
        ElseIf StockName.Contains("RELIANCE") Then
            ustock = "RELIANCE"
        ElseIf StockName.Contains("ICICI") Then
            ustock = "ICICI"
        ElseIf StockName.Contains("TCS") Then
            ustock = "TCS"
        ElseIf StockName.Contains("HUL") Then
            ustock = "HUL"
        ElseIf StockName.Contains("INFOSYS") Then
            ustock = "INFOSYS"
        ElseIf StockName.Contains("KOTAK") Then
            ustock = "KOTAK"
        End If
    End Sub
    Public Sub ReplaceReference()
        CurrQty = (Qty - Int(Sell_Qty.Text))
        PrevStockQty = String.Concat(ustock, PStock)
        CurrStockQty = String.Concat(ustock, CurrQty)
        'MessageBox.Show(PrevStockQty + vbCrLf + CurrStockQty)
        UpdateReference = UpdateReference.Replace(PrevStockQty, CurrStockQty)
        'MessageBox.Show(UpdateReference)
    End Sub
    Public Sub UpdateQtyAfterSold()
        con = New SqlConnection(Register.Con_String)
        con.Open()
        cmd.Connection = con
        cmd.Parameters.Clear()
        cmd.Dispose()
        If Val(Sell_Qty.Text) < Qty Then
            cmd.CommandText = "update Purchased set Purchased_Quantity = @UpdatedQuantity, Stock_ID =@StokID where Stock_ID= @StkID"
            cmd.Parameters.Add("@UpdatedQuantity", SqlDbType.Int).Value = Val(CurrQty)
            cmd.Parameters.Add("@StokID", SqlDbType.VarChar, 50).Value = UpdateReference
            cmd.Parameters.Add("@StkID", SqlDbType.VarChar, 50).Value = StocksToSale.SelectedItem
            cmd.ExecuteNonQuery()
        ElseIf Val(Sell_Qty.Text) = Qty Then
            cmd.CommandText = "Delete from Purchased where Stock_ID = @DelStkID"
            cmd.Parameters.Add("@DelStkID", SqlDbType.VarChar, 50).Value = StocksToSale.SelectedItem
            cmd.ExecuteNonQuery()
        Else
            MessageBox.Show("Invalid Task")
        End If
        con.Close()
    End Sub
    Public Sub UpdateBalanceAfterSold()
        Dim UpdateWallet As Integer
        Dim DA As New SqlDataAdapter
        UpdateWallet = Val(UserProfile.balance.Text) + Val(TotalSellValue.Text)
        con = New SqlConnection(Register.Con_String)
        con.Open()
        cmd.Connection = con
        cmd.Parameters.Clear()
        cmd.Dispose()
        cmd.CommandText = "update balance set Amount = @UpdatedWallet where e_mail = @mail"
        cmd.Parameters.Add("@UpdatedWallet", SqlDbType.Int).Value = Val(UpdateWallet)
        cmd.Parameters.Add("@mail", SqlDbType.VarChar, 50).Value = Login.mail.Text
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    ' Private Functions
    Private Sub SellStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PurchasedStock()
        SellTimer.Stop()
    End Sub
    Private Sub SellTimer_Tick(sender As Object, e As EventArgs) Handles SellTimer.Tick
        Randomize()
        CurrentSellValue()
        TotalStocksValue()
        Gain_Loss()
    End Sub
    Private Sub StocksToSale_SelectedIndexChanged(sender As Object, e As EventArgs) Handles StocksToSale.SelectedIndexChanged
        'SoldStock()
        Sell_Qty.Items.Clear()
        SellTimer.Start()
        ReadQty()
        SellGraph.MdiParent = Me
        SellGraph.Show()
        SellGraph.Location = New Point(50, 195)
        Threading.Thread.Sleep(100)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        SellTimer.Stop()
        CallingStock()
        ReplaceReference()
        SoldStocks()
        UpdateBalanceAfterSold()
        UpdateQtyAfterSold()
        MessageBox.Show("Transaction Done Successfully")
        Me.Refresh()
        PurchasedStock()
        Me.Hide()
        Inventory.Refresh()
        Inventory.Show()
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
        Me.Refresh()
    End Sub
    Private Sub IconButton5_Click(sender As Object, e As EventArgs) Handles IconButton5.Click
        Me.Hide()
        Inventory.Refresh()
        Inventory.Show()
    End Sub
End Class