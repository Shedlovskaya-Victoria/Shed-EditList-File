using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Shed_EditList_File
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
        private void ToFlowersPage(object sender, EventArgs e)
        {
            App.Current.MainPage.Navigation.PushAsync(new FlowersPage());
        }
    }
}
