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
    public partial class PageVzod : ContentPage
    {
        public PageVzod()
        {
            InitializeComponent();
        }

        private void Vxod_Clicked(object sender, EventArgs e)
        {
            if ((Number_phone.Text == "01") && (Password.Text == "123"))
            {
                Navigation.PushAsync(new PageGlavForm());
            }
            else
            {
                DisplayAlert("Ошибка!", "Неверные данные", "Повторить еще раз");
            }
        }
    }
}