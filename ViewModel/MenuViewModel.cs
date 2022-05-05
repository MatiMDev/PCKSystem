using PCKSystem.View;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace PCKSystem.ViewModel
{
    internal class MenuViewModel
    {
        public ICommand AddCardCommand { get; }

        public MenuViewModel()
        {
            AddCardCommand = new Command(AddNewCard);
        }

        async void AddNewCard()
        {
            await Application.Current.MainPage.Navigation.PushAsync(new AddCardView());
        }
    }
}
