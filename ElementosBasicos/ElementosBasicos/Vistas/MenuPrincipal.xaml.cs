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
        public IList<MComidas> Comidas { get; private set; }
        public MenuPrincipal()
        {
            InitializeComponent();
            Comidas = new List<MComidas>();
            Comidas.Add(new MComidas
            {
                Nombre = "Tortilla",
                Imagen = "angulo.png"
            });
            Comidas.Add(new MComidas
            {
                Nombre = "Patatas bravas",
                Imagen = "angulo.png"
            });
            Comidas.Add(new MComidas
            {
                Nombre = "Tarjetas",
                Imagen = "tarjeta.png"
            });
            BindingContext = this;
        }
    }
}