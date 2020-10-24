using System;
using System.Windows;
using System.Windows.Controls;


namespace UD02_Ejercicio02
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OperadorTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            char operador = String.IsNullOrEmpty(operadorTextBox.Text) || operadorTextBox.Text.Length > 1 ? ' ' : operadorTextBox.Text[0];

            calcularBoton.IsEnabled = operador == '+' || operador == '-' || operador == '*' || operador == '/';
        }

        private void CalcularBoton_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                double numero1 = double.Parse(operando1TextBox.Text);
                double numero2 = double.Parse(operando2TextBox.Text);
                char operador = operadorTextBox.Text[0];

                switch (operador)
                {
                    case '+':
                        resultadoTextBox.Text = $"{numero1 + numero2}";
                        break;
                    case '-':
                        resultadoTextBox.Text = $"{numero1 - numero2}";
                        break;
                    case '*':
                        resultadoTextBox.Text = $"{numero1 * numero2}";
                        break;
                    case '/':
                        resultadoTextBox.Text = $"{numero1 / numero2}";
                        break;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Los operandos deben ser números.");
            }
        }

        private void LimpiarBoton_Click(object sender, RoutedEventArgs e)
        {
            resultadoTextBox.Text = "";
            operando1TextBox.Text = "";
            operando2TextBox.Text = "";
            operadorTextBox.Text = "";
            calcularBoton.IsEnabled = false;

        }

    }
}
