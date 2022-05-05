﻿using PCKSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PCKSystem.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddCardView : ContentPage
    {
        public AddCardView()
        {
            InitializeComponent();
            BindingContext = new AddCardViewModel();
        }
    }
}