﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace cheapApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

         async void ShowListPage(object sender, EventArgs e)
         {
             await Navigation.PushAsync(new ShowListPage());
         }
        
    }
}
