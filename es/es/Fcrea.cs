﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es
{
    public partial class Fcrea : Form
    {
        public string numero { get; set; }
        public int credito { get; set; }
        DialogResult dr { get; set; }
        public Fcrea()
        {
            InitializeComponent();
        }

        private void btn_aggiungi_Click(object sender, EventArgs e)
        {
            try
            {
                
                numero = txt_numero.Text;
                credito = int.Parse(txt_credito.Text);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Inserire un valore numerico valido per il credito.");
            }
        }

        private void txt_credito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(((e.KeyChar == ',' && ((TextBox)sender).Text.Contains(","))) &&(!(char.IsDigit(e.KeyChar)) && !(char.IsControl(e.KeyChar))))
            {
                e.Handled = true;
            }
        }

        private void txt_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void Fcrea_Load(object sender, EventArgs e)
        {

        }

        private void txt_numero_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_credito_Click(object sender, EventArgs e)
        {

        }

        private void txt_credito_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_numero_Click(object sender, EventArgs e)
        {

        }
    }
}
