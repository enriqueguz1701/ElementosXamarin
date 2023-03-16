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
	public partial class FechaHora : ContentPage
	{
		public FechaHora ()
		{
			InitializeComponent ();
		}

        private void dpFecha_DateSelected(object sender, DateChangedEventArgs e)
        {
			lbResultadoFecha.Text = dpFecha.Date.ToString("dd/MM/yyyy");
        }

        private void tpHora_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
			lbResultadoHora.Text = tpHora.Time.ToString();
        }
    }
}