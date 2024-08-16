namespace CashRegister2024;

public partial class CashRegister : ContentPage
{
	public CashRegister()
	{
		InitializeComponent();
        lblDate.Text = DateTime.Now.ToString();
    }
}