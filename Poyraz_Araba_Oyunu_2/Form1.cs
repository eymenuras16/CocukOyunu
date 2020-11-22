using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poyraz_Araba_Oyunu_2
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tebrikler Doğru Cevap !");
            button7.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yanlış Cevap :( Lütfen Tekrar Deneyin");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yanlış Cevap :( Lütfen Tekrar Deneyin");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yanlış Cevap :( Lütfen Tekrar Deneyin");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yanlış Cevap :( Lütfen Tekrar Deneyin");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yanlış Cevap :( Lütfen Tekrar Deneyin");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 yeni = new Form2();
            yeni.Show();
            this.Close();
        }
    }
}
