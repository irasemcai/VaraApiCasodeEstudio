using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace casoEstudioVaraApi2021
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int num = Int32.Parse(txtnumanimales.Text);
            

            Varamiento varamiento = new Varamiento(txtnombreinformante.Text, txttelefono.Text, txtordenanimal.Text, txtcondcionanimal.Text,
                num, true, false, txtsustrato.Text, txtvistoen.Text, txtfechaavistamiento.Text, txtpais.Text, txtestado.Text,
                txtciudad.Text, txtlocalidad.Text, txtlatitud.Text, txtlongitud.Text);
            string url = "http://ec2-3-137-222-34.us-east-2.compute.amazonaws.com/yo/varamientos";
            var client = new RestClient(url);
            RestRequest request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJmcmVzaCI6dHJ1ZSwiaWF0IjoxNjM3NDUyMzk4LCJqdGkiOiJjNzcxN2M3Yy04MTJhLTRkOTItYWZhMi04MzhkNTAxN2ZlNmEiLCJ0eXBlIjoiYWNjZXNzIiwic3ViIjoiYTRjYTZiZmYtNzVmNS00NGE4LTlkMDItYjcwOGQwZTkxZWFkIiwibmJmIjoxNjM3NDUyMzk4LCJleHAiOjE2Mzc0NzM5OTh9.0ys5MqmWy5V7ArbCg2wKC5CvzWmGnJFmyNgBgBWf5Zo");
            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", varamiento, ParameterType.RequestBody);


            try
            {
                
                IRestResponse response = client.Execute(request);
                MessageBox.Show(response.Content +" " + response.ResponseStatus + " " + response.StatusCode.ToString());
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtnombreinformante_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtcondcionanimal_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtordenanimal_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txttelefono_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtdireccion_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtnumanimales_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtobservaciones_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtsustrato_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtvistoen_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtfechaavistamiento_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtpais_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtestado_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtciudad_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtlocalidad_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtlatitud_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtlongitud_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtinfoadicional_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }

    public class Varamiento
    {

        public string nombreInformante;
        public string telefonoInformante;
        public string ordenAnimal;
        public string  condicionAnimal;
        public int  numeroAnimales;
        public bool facilAcceso;
        public bool   acantilado;
        public string sustrato;
        public string  primeraVezVisto;
        public string fechaAvistamiento;
        public string  pais;
        public string estado;
        public string ciudad;
        public string localidad;
        public string  latitud;
        public string longitud;

        public Varamiento(string nombreInformante, string telefonoInformante, string ordenAnimal, string condicionAnimal, int numeroAnimales, bool facilAcceso, bool acantilado, string sustrato, string primeraVezVisto, string fechaAvistamiento, string pais, string estado, string ciudad, string localidad, string latitud, string longitud)
        {
            this.nombreInformante = nombreInformante;
            this.telefonoInformante = telefonoInformante;
            this.ordenAnimal = ordenAnimal;
            this.condicionAnimal = condicionAnimal;
            this.numeroAnimales = numeroAnimales;
            this.facilAcceso = facilAcceso;
            this.acantilado = acantilado;
            this.sustrato = sustrato;
            this.primeraVezVisto = primeraVezVisto;
            this.fechaAvistamiento = fechaAvistamiento;
            this.pais = pais;
            this.estado = estado;
            this.ciudad = ciudad;
            this.localidad = localidad;
            this.latitud = latitud;
            this.longitud = longitud;
        }
    }
}
