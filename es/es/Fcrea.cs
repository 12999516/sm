using System;
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
            numero = txt_numero.Text;
            credito = Int32.Parse(txt_credito.Text);
            dr = DialogResult.OK;
            Close();
        }

        /*private void btn_aggiungi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar)) || !(char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }*/

        private void txt_credito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar == ',' && ((TextBox)sender).Text.Contains(",")) &&!(char.IsDigit(e.KeyChar)) && !(char.IsControl(e.KeyChar)))
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
    }
}
