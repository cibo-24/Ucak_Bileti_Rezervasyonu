using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ucak_Bilet_Rezervasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: " + comboBox1.Text + " - " + comboBox2.Text);
            listBox1.Items.Add("Tarih: " + dateTimePicker1.Text + " - " + "Saat: " + maskedTextBox1.Text);
            listBox1.Items.Add("Ad Soyad: " + textBox1.Text);
            listBox1.Items.Add("T.C: " + maskedTextBox2.Text);
            listBox1.Items.Add("Telefon: " + maskedTextBox3.Text);
            MessageBox.Show("Bir Ömür Boyu Mutluluklar");


        }
    }
}
