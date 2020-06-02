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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int a;
        int b;
        int total;
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void GetValues()
        {
            try
            {
                a = Convert.ToInt32(tbxFirstNum.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            try
            {
                b = Convert.ToInt32(tbxSecondNum.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void Add(object sender, RoutedEventArgs e)
        {
            GetValues();
            //Add the two numbers
            
            total = a + b;

            lblResult.Content = total.ToString();
        }

        private void Substract(object sender, RoutedEventArgs e)
        {
            GetValues();
            //Substacts the two numbers
            total = a - b;

            lblResult.Content = total.ToString();
        }

        private void Multiply(object sender, RoutedEventArgs e)
        {
            GetValues();
            //Multiplies the two numbers
            total = a * b;

            lblResult.Content = total.ToString();
        }

        private void Divide(object sender, RoutedEventArgs e)
        {
            GetValues();
            //Divides the two numbers
            try
            {
                total = a / b;
            }
            catch (Exception)
            {

                MessageBox.Show("Divider cannot be zero");
            }

            lblResult.Content = total.ToString();
        }
    }
}
