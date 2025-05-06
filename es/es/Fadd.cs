using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es
{
    public partial class Fadd : Form
    {
        public string numero { get; set; }
        public int durata { get; set; }
        DialogResult dr { get; set; }
        public Fadd()
        {
            InitializeComponent();
        }

        private void btn_c_Click(object sender, EventArgs e)
        {
            try
            {
                durata = Int32.Parse(txt_d.Text);
                numero = textBox3.Text;
                if (string.IsNullOrWhiteSpace(numero))
                {
                    MessageBox.Show("Inserire un numero valido.");
                    return;
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Inserire un valore numerico valido per la durata.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
