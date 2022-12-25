using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lazy
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NachForm : ContentPage
    {
        public NachForm()
        {
            InitializeComponent();
        }
        private void VxodButton_Clicked_1(object sender, EventArgs e)
        {
           Navigation.PushAsync(new PageVzod());
            //bt_Reg.IsVisible = false;
        }
    }
}