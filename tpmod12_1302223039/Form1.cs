using System;

namespace tpmod12_1302223039
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string CariTandaBilangan(int a)
        {
            if (a < 0)
            {
                return "Negatif";
            }
            else if (a > 0)
            {
                return "Positif";
            }
            else
            {
                return "Nol";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input;
            if (int.TryParse(textBox1.Text, out input))
            {
                // Panggil metode CariTandaBilangan dari class Utility
                string hasil = Class1.CariTandaBilangan(input);

                // Tampilkan hasil di labelOutput
                label1.Text = hasil;
            }
            else
            {
                // Jika input tidak valid, tampilkan pesan error
                label1.Text = "Masukkan angka yang valid.";
            }

        }
    }
}
