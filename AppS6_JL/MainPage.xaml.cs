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
        //private const string Url = "http:///192.168.1.4/moviles/post.php";
       // private readonly HttpClient client = new HttpClient();
       // private ObservableCollection<AppS6_JL.Ws.Datos> _post;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            try {

                WebClient cliente = new WebClient();
                var parametros = new System.Collections.Specialized.NameValueCollection();

                parametros.Add("codigo", txtCodigo.Text);
                parametros.Add("nombre", txtNombre.Text);
                parametros.Add("apellido", txtApellido.Text);
                parametros.Add("edad", txtEdad.Text);
               

                cliente.UploadValues("http://192.168.1.5/moviles/post.php", "POST", parametros);
                await DisplayAlert("alerta", "Dato Ingresadocorrectamente", "ok");
          
            }
            catch (Exception ex)
            {
              await DisplayAlert("alerta", "Error"+ ex.Message, "ok");

            }

        }

        private async void btnRegresar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage ());

        }
    }
}
