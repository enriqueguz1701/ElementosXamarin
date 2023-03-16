using ElementosBasicos.Modelo;
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
    public partial class MenuPrincipal : ContentPage
    {
        public IList<MComidas> Opciones { get; private set; }
        public MenuPrincipal()
        {
            InitializeComponent();
            Opciones = new List<MComidas>();
            Opciones.Add(new MComidas
            {
                Nombre = "Imagen Circular",
                Imagen = "circulo.png"
            });
            Opciones.Add(new MComidas
            {
                Nombre = "Alertas",
                Imagen = "advertencia.png"
            });
            Opciones.Add(new MComidas
            {
                Nombre = "Tarjetas",
                Imagen = "tarjeta.png"
            });
            Opciones.Add(new MComidas
            {
                Nombre = "Fechas",
                Imagen = "calendario.png"
            });
            BindingContext = this;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            MComidas seleccion = e.Item as MComidas;
            if(seleccion.Nombre == "Tarjetas")
            {
                Navigation.PushAsync(new Tarjeta());
            }
            if(seleccion.Nombre == "Alertas")
            {
                Navigation.PushAsync(new Alerta());
            }
            if (seleccion.Nombre == "Imagen Circular")
            {
                Navigation.PushAsync(new ImagenCircular());
            }
            if (seleccion.Nombre == "Fechas")
            {
                Navigation.PushAsync(new FechaHora());
            }
        }
    }
}