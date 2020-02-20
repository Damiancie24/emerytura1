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

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string imie = TextBoxImie.Text;
            string nazwisko = TextBoxNazwisko.Text;
            int wiek = int.Parse(TextBoxWiek.Text);

            if(wiek > 67)
            {
              TextBoxWynik.Text = "Jestes emerytem!";

            }
            else
            {
              TextBoxWynik.Text = $"Do emerytury pozostalo Ci {67 - wiek} lat";
            }

        }
    }
}
