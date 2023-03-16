using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ElementosBasicos.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Tarjeta : ContentPage
	{
		public Tarjeta ()
		{
			InitializeComponent ();
		}

        private void btnVolver_Clicked(object sender, EventArgs e)
        {
			Navigation.PopAsync ();
        }
    }
}