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


namespace lakyletet
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Tx2.Clear();
            Tx1.Clear();
            Lb0.Content = "0";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
              Lb0.Content = double.Parse(Tx1.Text) + double.Parse(Tx2.Text);      
            }
            catch(FormatException)
            {
                MessageBox.Show("Иди за учебником математики,неуч");
                Tx2.Clear();
                Tx1.Clear();
                Lb0.Content = "0";
            }
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
            Lb0.Content = double.Parse(Tx1.Text) - double.Parse(Tx2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Иди за учебником математики,неуч");
                Tx2.Clear();
                Tx1.Clear();
                Lb0.Content = "0";
            }
            
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            try
            {
Lb0.Content = double.Parse(Tx1.Text) * double.Parse(Tx2.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Иди за учебником математики,неуч");
                Tx2.Clear();
                Tx1.Clear();
                Lb0.Content = "0";
            }
            
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            try
            {
Lb0.Content = double.Parse(Tx1.Text) + 0.1;
            }
            catch (FormatException)
            {
                MessageBox.Show("Иди за учебником математики,неуч");
                Tx2.Clear();
                Tx1.Clear();
                Lb0.Content = "0";
            }
            
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            try
            {
Lb0.Content = Math.Sin(Convert.ToDouble(Tx1.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Иди за учебником математики,неуч");
                Tx2.Clear();
                Tx1.Clear();
                Lb0.Content = "0";
            }
            
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            try
            {
Lb0.Content = Math.Pow(Convert.ToDouble(Tx1.Text), 2);
            }
            catch (FormatException)
            {
                MessageBox.Show("Иди за учебником математики,неуч");
                Tx2.Clear();
                Tx1.Clear();
                Lb0.Content = "0";
            }
            
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            try
            {
Lb0.Content = Math.Cos(Convert.ToDouble(Tx1.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Иди за учебником математики,неуч");
                Tx2.Clear();
                Tx1.Clear();
                Lb0.Content = "0";
            }
            
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            try
            {
            Lb0.Content = Math.Log(Convert.ToDouble(Tx1.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Иди за учебником математики,неуч");
                Tx2.Clear();
                Tx1.Clear();
                Lb0.Content = "0";
            }

        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            try
            {
            Lb0.Content= Math.Pow(Convert.ToDouble(Tx1.Text), 1/Convert.ToDouble(Tx2.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Иди за учебником математики,неуч");
                Tx2.Clear();
                Tx1.Clear();
                Lb0.Content = "0";
            }

        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            try
            {
Lb0.Content = Math.Sqrt(Convert.ToDouble(Tx1.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Иди за учебником математики,неуч");
                Tx2.Clear();
                Tx1.Clear();
                Lb0.Content = "0";
            }
            
        }

        private void Tx1_TextChanged(object sender, TextChangedEventArgs e)
        {
           

        }

        private void Tx1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = "1234567890,".IndexOf(e.Text) < 0;
        }
    }
}
