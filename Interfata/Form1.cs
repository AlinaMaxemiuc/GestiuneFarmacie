﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AngajatiFarmacie;
using StocareMedicamente;
using AdministrareFarmacie;
using System.Configuration;
using System.IO;


//form principal


namespace Interfata
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
      

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
      
        private void btnAfiseaza_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAfisMed_Click(object sender, EventArgs e)
        {
            Form f4 = new Form4();
            f4.ShowDialog();
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            Form f3 = new Form3();
            f3.ShowDialog();
        }

        private void btnSalvMed_Click(object sender, EventArgs e)
        {
            Form f5 = new Form5();
            f5.ShowDialog();
        }
    }
}
