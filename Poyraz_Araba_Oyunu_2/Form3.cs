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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\C# Program Kaynakları\\kedi.mp3";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\C# Program Kaynakları\\arı.mp3";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\C# Program Kaynakları\\kopek.mp3";
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\C# Program Kaynakları\\at.mp3";
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "C:\\Users\\eymen\\OneDrive\\Masaüstü\\C# Program Kaynakları\\ınek.mp3";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 yeni3 = new Form4();
            yeni3.Show();
            this.Close();
        }
    }
}
