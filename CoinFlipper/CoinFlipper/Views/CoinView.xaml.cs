using CoinFlipper.ViewModel;

namespace CoinFlipper.Views;

public partial class CoinView : ContentPage
{
	public CoinView()
	{
		InitializeComponent();
		BindingContext = new CoinViewModel();
	}
}