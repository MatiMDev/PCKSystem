using PCKSystem.Model;
using PCKSystem.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PCKSystem.ViewModel
{
    internal class LoginViewModel : INotifyPropertyChanged
    {
        public User loginData;
        string username;
        string password;

        public event PropertyChangedEventHandler PropertyChanged;
        public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(Login);
        }

        public string Username
        {
            get { return username;  }
            set { username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        public string Password
        {
            get { return password; }
            set { password = value;
                OnPropertyChanged(nameof(Password));
                }
        }

        protected internal void OnPropertyChanged(string username)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(username));
        }

        bool CheckCredentials()
        {
            if(LoginCommand.CanExecute(this))
            {
                foreach (var item in new Users().UsersList)
                {
                    if (item.Username == username && item.Password == password)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        async void Login()
        {
            if (CheckCredentials())
            {
                Debug.WriteLine("Test");
                await Application.Current.MainPage.Navigation.PushAsync(new MenuView());
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Nieprawidłowe dane", "Wprowadzone dane są nieprawidłowe", "Ok");
            }
        }
    }
}
