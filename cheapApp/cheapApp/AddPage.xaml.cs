using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace cheapApp
{
    public partial class AddPage : ContentPage
    {
        public AddPage()
        {
            InitializeComponent();
        }

        async void CommitProduct(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
