using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTareaSemana2IzaAlexander
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Loging : ContentPage
    {
        public Loging()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            string nombreUsuario = "";
            string mensaje = validarIngreso(txtUser.Text, txtPassword.Text);
            if (mensaje != "")
            {
                await DisplayAlert("Error de validación", mensaje, "Continuar");
            }
            else
            {
                nombreUsuario = txtUser.Text;
                await Navigation.PushAsync(new MainPage());
            }
        }
        private string validarIngreso(string usuario, string clave)
        {
            string mensaje = "";
            if (usuario != "estudiante2022")
            {
                mensaje = "Usuario incorrecto !";
            }
            else if (clave != "uisrael2022")
            {
                mensaje = "Clave incorrecta !";
            }
            return mensaje;
        }
    }
}