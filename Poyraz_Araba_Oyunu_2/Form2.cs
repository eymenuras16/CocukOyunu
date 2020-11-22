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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yanlış Cevap :( Lütfen Tekrar Deneyin");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tebrikler Doğru Cevap !");
            button5.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yanlış Cevap :( Lütfen Tekrar Deneyin");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yanlış Cevap :( Lütfen Tekrar Deneyin");
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            button5.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 yeni2 = new Form3();
            yeni2.Show();
            this.Close();
        }
    }
}
