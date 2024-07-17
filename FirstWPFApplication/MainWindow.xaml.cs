using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace FirstWPFApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double ultimoValor, resultado;

        public MainWindow()
        {
            InitializeComponent();

            btnClear.Click += BtnClear_Click;
            btnNegative.Click += BtnNegative_Click;
        }

        private void BtnNegative_Click(object sender, RoutedEventArgs e)
        {
             if (lblResult.Content.ToString() != "0") // Se o visor for diferente de 0, adiciona o sinal de negativo
            {
                if (lblResult.Content.ToString().Contains("-")) // Se o visor já tiver o sinal de negativo, remove
                {
                    lblResult.Content = lblResult.Content.ToString().Remove(0, 1); // Remove o sinal de negativo do visor
                }
                else
                {
                    lblResult.Content = "-" + lblResult.Content; // Adiciona o sinal de negativo
                }
            }
        }

        private void BtnClear_Click(object sender, RoutedEventArgs e)
        {
            lblResult.Content = "0"; // Limpa o visor
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            AdicionarNumero(btn0.Content.ToString()); // Adiciona o número 0
        }
        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            AdicionarNumero(btn1.Content.ToString()); // Adiciona o número 1
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            AdicionarNumero(btn2.Content.ToString()); // Adiciona o número 2
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            AdicionarNumero(btn3.Content.ToString());   // Adiciona o número 3
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            AdicionarNumero(btn4.Content.ToString());   // Adiciona o número 4
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            AdicionarNumero(btn5.Content.ToString());   // Adiciona o número 5
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            AdicionarNumero(btn6.Content.ToString());   // Adiciona o número 6
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            AdicionarNumero(btn7.Content.ToString());   // Adiciona o número 7
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            AdicionarNumero(btn8.Content.ToString()); // Adiciona o número 8
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            AdicionarNumero(btn9.Content.ToString()); // Adiciona o número 9
        }

 
        // =========================================================================================================================================metodos

        private void AdicionarNumero(string numero) // Adiciona o número no visor
        {
            if (lblResult.Content.ToString() == "0") // Se o visor estiver com 0, substitui pelo número
            {
                lblResult.Content = numero;
            }
            else
            {
                lblResult.Content += numero;
            }
        }
    }
}