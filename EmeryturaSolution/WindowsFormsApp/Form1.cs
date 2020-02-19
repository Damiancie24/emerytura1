using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOblicz_Click(object sender, EventArgs e)
        {
            string imie = TextBoxImie.Text;
            string nazwisko = textBoxNazwisko.Text;
            int wiek = int.Parse(textBoxWiek.Text);

            if(wiek >= 67)
            {
                labelWynik.Text = "Jestes emerytem";
            }
            else
            {
                labelWynik.Text = $"Do emerytury zostalo Ci {67 - wiek} lat";
            }
        }
    }
}
