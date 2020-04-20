using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppIMC
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalcIMC : ContentPage
    {
        double peso, altura;
        string resultado;
        public CalcIMC()
        {
            InitializeComponent();
            peso = 0;
            altura = 0;
            resultado = "";
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double imc;

            if (!double.TryParse(txtAltura.Text, out altura))
            {
                DisplayAlert("Error", "Informe uma altura valida", "Fechar");
            }

            if (!double.TryParse(txtPeso.Text, out peso))
            {
                DisplayAlert("Error", "Informe um peso valido", "Fechar");
            }

            imc = peso * (altura * altura);

            if (imc < 18.5)
            {

                resultado = "Abaixo do peso";

            }
            else if (imc >= 18.5 && imc < 24.9)
            {

                resultado = "Peso normal";

            }
            else if (imc >= 25 && imc < 29.9)
            {

                resultado = "Sobrepeso";

            }
            else if (imc >= 30 && imc < 34.9)
            {

                resultado = "Obesidade grau 1";

            }
            else if (imc >= 35 && imc < 39.9)
            {

                resultado = "Obesidade grau 2";

            }
            else
            {

                resultado = "Obesidade grau 3";

            }

            DisplayAlert("Resuldado", $"IMC: {resultado}", "Fechar");

            vAltura.Text = $"Altura calculada: {altura}";
            vPeso.Text = $"Peso calculada: {peso}";
            vIMC.Text = $"Resultado: {resultado}";
        }
    }
}