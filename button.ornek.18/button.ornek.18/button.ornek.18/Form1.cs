using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button.ornek._18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            
            
            
            
           
        }

        private void btnHesapla_Click_1(object sender, EventArgs e)
        {
            int sayi1,sayi2;
            sayi1 = Convert.ToInt32(txtSayi1.Text);
            sayi2 = Convert.ToInt32(txtSayi2.Text);

            if (sayi1 > sayi2) 
            {
                MessageBox.Show("1. Sayı daha büyüktür.");
            }
            else if (sayi2 > sayi1)
            {
                MessageBox.Show("2. sayı daha büyüktür.");
            }
            else
            {
                MessageBox.Show("2 sayı birbirine eşittir.");
            }

        }   
            
      
    }
}
