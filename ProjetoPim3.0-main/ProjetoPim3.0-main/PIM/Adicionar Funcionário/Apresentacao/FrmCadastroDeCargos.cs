﻿using DesktopPim;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adicionar_Funcionário
{
    public partial class FrmCadCargo : Form
    {
        public FrmCadCargo()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPróximo_Click(object sender, EventArgs e)
        {
            FrmMenu FrmMenu = new FrmMenu();
            FrmMenu.Show();
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmMenu FrmMenu = new FrmMenu();
            FrmMenu.Show();
            this.Hide();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                
                if (control is TextBox)
                {
                    
                    ((TextBox)control).Clear();
                }
            }
        }
    }
}
