using System;
using System.Windows;
using System.Windows.Controls;

namespace ПР1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnCalculateClick(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = double.Parse(inputTextBox1.Text);
                double y = double.Parse(inputTextBox2.Text);
                double result = 0;

                if (shRadioButton.IsChecked == true)
                {
                    result = Math.Sinh(x);
                }
                else if (x2RadioButton.IsChecked == true)
                {
                    result = Math.Pow(x, 2);
                }
                else if (exRadioButton.IsChecked == true)
                {
                    result = Math.Exp(x);
                }
                else
                {
                    MessageBox.Show("Выберите функцию!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                resultTextBox.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректные числовые значения!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void OnClearClick(object sender, RoutedEventArgs e)
        {
            inputTextBox1.Clear();
            inputTextBox2.Clear();
            resultTextBox.Clear();
            shRadioButton.IsChecked = false;
            x2RadioButton.IsChecked = false;
            exRadioButton.IsChecked = false;
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var result = MessageBox.Show("Вы уверены, что хотите закрыть приложение?", "Подтверждение", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.No)
            {
                e.Cancel = true;
            }
        }
    }
    
}