using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XF.ControlesBasicos.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConfigPage : ContentPage
    {
        public ConfigPage()
        {
            InitializeComponent();
        }

        private void SwitchCell_OnChanged(object sender, ToggledEventArgs e)
        {
            input_email.Text = "";
            input_email.IsEnabled = e.Value;
        }
    }
}