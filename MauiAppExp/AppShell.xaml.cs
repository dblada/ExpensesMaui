using MauiAppExp.Views;

namespace MauiAppExp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            // tutaj mogę zarejestrować trasy
            //Routing.RegisterRoute("transakcje", typeof(TransactionPage));
        }
    }
}
