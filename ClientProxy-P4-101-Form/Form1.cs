using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientProxy_P4_101_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            ServiceReference1.MatematikaClient obj = new ServiceReference1.MatematikaClient();
            double hasilTambah = obj.Tambah(1, 2);
            label1.Text ="1 + 2 = "+ hasilTambah; //Add label1.Text + var hasilTambah
            //Console.WriteLine("1 + 2 = " + hasilTambah);
            double hasilKurang = obj.Kurang(3, 2);
            label2.Text = "3 - 2 = " + hasilKurang; //Add label2.Text + var hasilKurang
            //Console.WriteLine("3 - 2 = " + hasilKurang);
            double hasilKali = obj.Kali(2, 2);
            label3.Text = "2 x 2 = " + hasilKali; //Add label3.Text + var hasilKali
            //Console.WriteLine("2 x 2 = " + hasilKali);
            double hasilBagi = obj.Bagi(2, 2);
            label4.Text = "2 : 2 = " + hasilBagi; //Add label4.Text + var hasilBagi
            //Console.WriteLine("2 / 2 = " + hasilBagi);

            ServiceReference1.Koordinat a = new
            ServiceReference1.Koordinat();
            ServiceReference1.Koordinat b = new
            ServiceReference1.Koordinat();
            a.X = 7;
            a.Y = 8;

            b.X = 5;
            b.Y = 6;
            double selisihX = a.X - b.X;
            double selisihY = a.Y - b.Y;
            double jarak = Math.Sqrt(Math.Pow(selisihX, 2) +
            Math.Pow(selisihY, 2));
            label5.Text = "Hasil Koordinat = " + jarak; //Add label5.Text + var jarak
            //Console.WriteLine("Hasil Koordinat " + jarak);
            Console.ReadLine(); 
        }
    }
}
