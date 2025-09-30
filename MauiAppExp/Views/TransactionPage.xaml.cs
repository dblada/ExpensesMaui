using MauiAppExp.ViewModels;

namespace MauiAppExp.Views;

public partial class TransactionPage : ContentPage
{
	public TransactionPage()
	{
		InitializeComponent();
        BindingContext = new TransactionViewModel();
    }
}