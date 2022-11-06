using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtomasyonOrn2
{
    public partial class Form1 : Form
    {
        market market = new market();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            marketurun marketurun = new marketurun();

            string[] kelime1 = { "A", "S", "D", "F", "G", "H", "J", "K", "L", "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "Z", "X", "C", "V", "B", "N", "M" };
            string[] kelime2 = { "A", "S", "D", "F", "G", "H", "J", "K", "L", "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "Z", "X", "C", "V", "B", "N", "M" };
            string[] kelime3 = { "A", "S", "D", "F", "G", "H", "J", "K", "L", "Q", "W", "E", "R", "T", "Y", "U", "I", "O", "P", "Z", "X", "C", "V", "B", "N", "M" };
            Random RandomString = new Random();

            int s1, s2, s3, s4, s5;

            s1 = RandomString.Next(0, kelime1.Length);
            s2 = RandomString.Next(0, kelime2.Length);
            s3 = RandomString.Next(0, kelime3.Length);
            s4 = RandomString.Next(0, 10);
            s5 = RandomString.Next(0, 10);


            label1.Text = kelime1[s1].ToString() + kelime2[s2].ToString() + s5.ToString() + kelime3[s3].ToString() + s4.ToString();

            marketurun.ID = market.marketurunıd;
            market.marketurunıd += 1;
            marketurun.Ad = textBox1.Text;
            marketurun.Fiyat = Convert.ToDouble(textBox2.Text);
            marketurun.katagori = comboBox1.SelectedItem.ToString();
            marketurun.barkod = label1.Text;
            market.urunler.Add(marketurun);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = market.urunler;






        }
    }
}
