using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Calculadora_Simple
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

        private void btnSuma_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumeroUno.Text) || string.IsNullOrEmpty(txtNumeroDos.Text))
            {
                MessageBox.Show("Por favor, ingrese ambos números.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            double numeroUno = double.Parse(txtNumeroUno.Text);
            double numeroDos = double.Parse(txtNumeroDos.Text);

            lblResultado.Text = $"Resultado: {numeroUno + numeroDos}";


        }

        private void btnResta_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumeroUno.Text) || string.IsNullOrEmpty(txtNumeroDos.Text))
            {
                MessageBox.Show("Por favor, ingrese ambos números.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            double numeroUno = double.Parse(txtNumeroUno.Text);
            double numeroDos = double.Parse(txtNumeroDos.Text);

            lblResultado.Text = $"Resultado: {numeroUno - numeroDos}";

        }

        private void btnMultiplicacion_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumeroUno.Text) || string.IsNullOrEmpty(txtNumeroDos.Text))
            {
                MessageBox.Show("Por favor, ingrese ambos números.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            double numeroUno = double.Parse(txtNumeroUno.Text);
            double numeroDos = double.Parse(txtNumeroDos.Text);

            lblResultado.Text = $"Resultado: {(numeroUno * numeroDos):F2}";

        }

        private void btnDivision_Click(object sender, RoutedEventArgs e)
        {
            if (int.Parse(txtNumeroDos.Text) == 0)
            {
                MessageBox.Show("No se puede dividir entre cero.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }


            double numeroUno = double.Parse(txtNumeroUno.Text);
            double numeroDos = double.Parse(txtNumeroDos.Text);


            lblResultado.Text = $"Resultado: {(numeroUno / numeroDos):F2}";
        }
    }
}
