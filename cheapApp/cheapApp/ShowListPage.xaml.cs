using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace cheapApp
{
    public partial class ShowListPage : ContentPage
    {
        public ShowListPage()
        {
            InitializeComponent();
        }

        async void AddPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddPage());
            //await Navigation.PopAsync();
        }
    }
}
