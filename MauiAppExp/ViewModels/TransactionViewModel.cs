using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MauiAppExp.Helpers;

namespace MauiAppExp.ViewModels
{
    public class TransactionViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _username;
        public string Username
        {
            get => _username;
            set
            {
                if (_username != value)
                {
                    _username = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Username)));
                }
            }
        }

        public ICommand LoginCommand { get; }

        public TransactionViewModel()
        {
            LoginCommand = new RelayCommand(Login);
        }

        private void Login()
        {
            // Tu możesz dodać logikę logowania
            Console.WriteLine($"Logowanie użytkownika: {Username}");

            Shell.Current.GoToAsync("//start");
        }
    }
}
