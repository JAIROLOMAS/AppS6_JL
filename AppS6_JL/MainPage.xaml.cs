using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppS6_JL
{
    public partial class MainPage : ContentPage
    {
       public MainPage()
        {
            InitializeComponent();
        }


        private void btnIngresar_Clicked(object sender, EventArgs e)
        {
            try {

                WebClient cliente = new WebClient();
                var parametros = new System.Collections.Specialized.NameValueCollection();

                parametros.Add("codigo", txtCodigo.Text);
                parametros.Add("nombre", txtNombre.Text);
                parametros.Add("apellido", txtApellido.Text);
                parametros.Add("edad", txtEdad.Text);
               

                cliente.UploadValues("http://192.168.1.8/moviles/post.php", "POST", parametros);
                DisplayAlert("alerta", "Datos Ingresados Correctamente", "ok");
          
            }
            catch (Exception ex)
            {
               DisplayAlert("alerta", "Error"+ ex.Message, "ok");

            }

        }

        private void btnRegresar_Clicked(object sender, EventArgs e)
        {
               //permite abrir la ventana dos
                Navigation.PushAsync(new MainPage());
                  

        }

        private void btnActualizar_Clicked(object sender, EventArgs e)
        {
             //permite abrir la ventana dos
                Navigation.PushAsync(new Actualizar());
                      
        }

        private void btnEliminar_Clicked(object sender, EventArgs e)
        {
            try
            {

                WebClient cliente = new WebClient();
                var parametros = new System.Collections.Specialized.NameValueCollection();

                parametros.Add("codigo", txtCodigo.Text);
               

                cliente.UploadValues("http://192.168.1.8/moviles/post.php ? codigo= " + Int32.Parse(txtCodigo.Text), "DELETE", parametros);
                 DisplayAlert("alerta", "Datos Eliminados Correctamente", "ok");

            }
            catch (Exception ex)
            {
                 DisplayAlert("alerta", "Error" + ex.Message, "ok");

            }


        }
    }
}
