using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppS6_JL
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Actualizar : ContentPage
    {
        public Actualizar()
        {
            InitializeComponent();
        }

        private async void btnActualizarDatos_Clicked(object sender, EventArgs e)
        {
            try
            {

                WebClient cliente = new WebClient();
                var parametros1 = new System.Collections.Specialized.NameValueCollection();

                parametros1.Add("codigo", txtCodigoActualizar.Text);
                parametros1.Add("nombre", txtNombreActualizar.Text);
                parametros1.Add("apellido", txtApellidoActualizar.Text);
                parametros1.Add("edad", txtEdadActualizar.Text);


                cliente.UploadValues("http://192.168.1.5/moviles/post.php ? codigo= " + Int32.Parse(txtCodigoActualizar.Text) + "&" + "nombre=" + txtNombreActualizar.Text + "&" + "apellido=" + txtApellidoActualizar.Text + "&" + "edad=" + Int32.Parse(txtEdadActualizar), "PUT", parametros1);

                await DisplayAlert("alerta", "Dato Ingresadocorrectamente", "ok");

            }
            catch (Exception ex)
            {
                await DisplayAlert("alerta", "Error" + ex.Message, "ok");

            }

        }
    }
}