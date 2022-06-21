using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WartoscBiezacaNaLokacie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double do_uzyskania;
            double oprocentowanie;
            double liczba_lat;
            double inflacja;
            double wynik;
            try
            {
                do_uzyskania = Convert.ToDouble(textBox1.Text);
                oprocentowanie = Convert.ToDouble(textBox2.Text);
                liczba_lat = Convert.ToDouble(textBox3.Text);
                inflacja = Convert.ToDouble(textBox4.Text);
            }
            catch
            {
                do_uzyskania = 0;
                oprocentowanie = 0;
                liczba_lat = 0;
                inflacja = 0;
            }
            wynik = do_uzyskania / Math.Pow((((double)oprocentowanie - inflacja)/100+1) , liczba_lat);
            textBox5.Text = Convert.ToString(Math.Round((double) wynik, 2));
        }
    }
}
