﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;





namespace Punto_Venta
{
    public partial class Login : Form
    {
        public Login()
        {
            Thread screen = new Thread(new ThreadStart(Splash));
            screen.Start();
            Thread.Sleep(8000);
            InitializeComponent();
            screen.Abort();
            InitializeComponent();

        }

        public void Splash()
        {

            Application.Run(new Splash());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Principal prin = new Principal();
            prin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}