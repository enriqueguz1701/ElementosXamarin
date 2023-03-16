using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Rg.Plugins.Popup.Services;

namespace ElementosBasicos.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Alerta : ContentPage
	{
		public Alerta ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
			PopupNavigation.Instance.PushAsync(new AlertaNumero1());
        }
    }
}