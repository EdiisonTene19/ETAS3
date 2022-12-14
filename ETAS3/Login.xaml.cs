using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ETAS3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {

            string usuario = "Edison";
            string contraseña = "12345";

            if(usuario == txtUsuario.Text && contraseña == txtpassword.Text)
            {
                Navigation.PushAsync(new Principal(usuario));
            }
            else
            {
                DisplayAlert("ALERTA", "Usuario/Contraseña Incorrectos", "Cerrar");
            }


        }
    }
}