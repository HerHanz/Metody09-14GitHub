﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metody09_14GitHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = double.Parse(textBox3.Text);
                double x1, x2, d;
                Vypocty.Diskriminant(a, b, c, out x1, out x2, out d);
                if (d < 0) MessageBox.Show("Rovnice nema reseni v R");
                else if (d > 0) MessageBox.Show("Koren x1 je: " + x1 + " a koren x2 je: " + x2);
                else MessageBox.Show("Rovnice ma jedno dvojnasobne reseni " + x1);

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = textBox4.Text;
            int cifsoucet = 0;
            int lichsoucet = 0;
            int sudcifra = 0;
            if (Vypocty.ObsahujeCislici(a, out cifsoucet, out lichsoucet, out sudcifra)) 
            {
                MessageBox.Show("Obsahuje cislici");
                MessageBox.Show("Ciferny soucet je"+cifsoucet);
                MessageBox.Show("Ciferny soucet lich"+lichsoucet);
                MessageBox.Show("CIferny couset sud cisel je" +sudcifra);

            }
            else MessageBox.Show("Neobsahuje cifru");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string a = textBox5.Text;
            string UpravenyRetezec = " " ;
            MessageBox.Show("Pocetslov je" + Vypocty.PocetSlov1(a,out  UpravenyRetezec));






        }
    }
}
