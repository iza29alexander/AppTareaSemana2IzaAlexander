using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppTareaSemana2IzaAlexander
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            double ns1 = Convert.ToDouble(txtNs1.Text);
            double ex1 = Convert.ToDouble(txtExa1.Text);
            double ns2 = Convert.ToDouble(txtNs2.Text);
            double ex2 = Convert.ToDouble(txtExa2.Text);
            double notaP1 = Convert.ToDouble(txtNp1.Text);
            double notaP2 = Convert.ToDouble(txtNp2.Text);
            double notaFinal = Convert.ToDouble(txtNf.Text);
            



            if (ns1 > 10)
            {
                DisplayAlert("ERROR", "Nota de Seguimiento 1 Incorrecto", "Salir");
            }

            else if (ex1 > 10)
            {
                DisplayAlert("ERROR", "Nota de Examen 1 Incorrecto", "Salir");
            }
            else
            {
                notaP1 = (ns1 * 0.3) + (ex1 * 0.2);
                txtNp1.Text = notaP1.ToString();
            }

            if (ns2 > 10)
            {
                DisplayAlert("ERROR", "Nota de Seguimiento 2 Incorrecto", "Salir");
            }

            else if (ex2 > 10)
            {
                DisplayAlert("ERROR", "Nota de Examen 2 Incorrecto", "Salir");
            }
            else
            {
                notaP2 = (ns2 * 0.3) + (ex2 * 0.2);
                txtNp2.Text = notaP2.ToString();
            }

            notaFinal = notaP1 + notaP2;
            txtNf.Text = notaFinal.ToString();

            if(notaFinal >= 7)
            {
                DisplayAlert("ALERTA", "APROBADO CON UNA CALIFICACION DE:"+notaFinal, "Salir");
            }
            else if (notaFinal <5)
            {
                DisplayAlert("ALERTA", "EXAMEN COMPLEMENTARIO CON UNA CALIFICACION DE: "+notaFinal, "Salir");
            }
            else
            {
                DisplayAlert("ALERTA", "REPROBADO CON UNA CALIFICAION DE: "+notaFinal, "Salir");
            }
            


        }
    }
}
