using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Criticografo_LGLA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnGenderChanged(object sender, CheckedChangedEventArgs e)
        {
            
            if (Hom.IsChecked)
            {
                CambiarTextoYColor("Alto", "Feo", "Listo",
                                   "Extravagante", "Raro", "Grande", Color.Blue);
            }
            else if (Muj.IsChecked)
            {
                CambiarTextoYColor("Alta", "Fea", "Lista",
                                   "Elegante", "Rara", "Grande", Color.HotPink);
            }
        }

        private void CambiarTextoYColor(string alto, string feo, string listo,
                                        string extravagante, string raro, string grande, Color color)
        {
            
            LAlto.Text = alto;
            LFeo.Text = feo;
            LListo.Text = listo;
            LExtravagante.Text = extravagante;
            LRaro.Text = raro;
            LGrande.Text = grande;

            
            Alto.Color = color;
            Feo.Color = color;
            Listo.Color = color;
            Extravagante.Color = color;
            Raro.Color = color;
            Grande.Color = color;
        }

        private void Muj_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {

        }
        public void Criticar_btn (object sender, EventArgs e)
        {
            
            string nombre = Nombre.Text;

            
            string genero = Hom.IsChecked ? "Hombre" : "Mujer";

            
            List<string> caracteristicas = new List<string>();

            if (Alto.IsChecked)
                caracteristicas.Add("Alto");
            if (Listo.IsChecked)
                caracteristicas.Add("Listo");
            if (Raro.IsChecked)
                caracteristicas.Add("Raro");
            if (Feo.IsChecked)
                caracteristicas.Add("Feo");
            if (Extravagante.IsChecked)
                caracteristicas.Add("Extravagante");
            if (Grande.IsChecked)
                caracteristicas.Add("Grande");

            
            string mensaje = $"Nombre: {nombre}\nGénero: {genero}\nCaracterísticas: {string.Join(", ", caracteristicas)}";

            
            DisplayAlert("Datos de Crítica", mensaje, "OK");
        }
    }
}

