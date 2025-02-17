using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asalsayilistele
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1 - 5000 arasindaki asal sayilarin listelenmesi
            int sayac;

            for (int i = 2; i < 5000; i++)
            {
                sayac = 0;
                for(int j = 2; j < i; j++)
                {
                    if(i %  j == 0)
                    {
                        sayac++;
                    }
                }
                if(sayac == 0)
                {
                    listBox1.Items.Add(i.ToString());
                }
            }
        }
    }
}
