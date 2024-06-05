using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arac
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string urunadi;
            int urunfiyat, kdv1, kdv2, kdv3, kdv4;
            urunadi = textBox1.Text;
            urunfiyat = Convert.ToInt16(textBox2.Text);
            kdv1 = 8;
            kdv2 = 18;
            kdv1 = (urunfiyat+(urunfiyat * 8) / 100);
            kdv2 = (urunfiyat+(urunfiyat* 18) / 100);
            listBox1.Items.Add("%8 kdvli fiyat: "+kdv1+"\n"+" %18 kdvli fiyat: "+kdv2);
        }
    }
}
