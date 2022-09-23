using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practika4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            if (Swit.IsToggled == false)
            {
                Body.IsEnabled = false;
            }
            else
            {
                Body.IsEnabled = true;
            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (Zima.IsChecked == true) DisplayAlert("Месяца", "Декабрь, Январь, Февраль", "Ок");
            if (Vesna.IsChecked == true) DisplayAlert("Месяца", "Март, Апрель, Май", "Ок");
            if (Leto.IsChecked == true) DisplayAlert("Месяца", "Июнь, Июль, Август", "Ок");
            if (Osen.IsChecked == true) DisplayAlert("Месяца", "Сентябрь, Октябрь, Ноябрь", "Ок");
        }
    }
}