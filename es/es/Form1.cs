using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es
{
    public partial class Form1 : Form
    {
        Csim sim;
        public Form1()
        {
            InitializeComponent();
            btn_crea.Visible = true;
            btn_add.Visible = false;
            btn_cerca.Visible = false;
            btn_filtra.Visible = false;
            btn_minuti.Visible = false;
            btn_ricarica.Visible = false;
        }

        private void btn_minuti_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sim.totale_minuti());
        }

        private void btn_crea_Click(object sender, EventArgs e)
        {
            using (Fcrea crea = new Fcrea())
            {
                crea.ShowDialog();
                if (crea.DialogResult == DialogResult.OK)
                {

                    sim = new Csim(crea.numero, crea.credito);
                }
            }
            btn_crea.Visible = false;
            btn_add.Visible = true;
            btn_cerca.Visible = true;
            btn_filtra.Visible = true;
            btn_minuti.Visible = true;
            btn_ricarica.Visible = true;
        }


        private void btn_filtra_Click(object sender, EventArgs e)
        {
            try
            {
                string numero;
                using (Fcerca cerca = new Fcerca(sim))
                {
                    cerca.ShowDialog();
                    if (cerca.DialogResult == DialogResult.OK)
                    {
                        numero = cerca.numero;
                        cerca.filtr(sim, numero);
                        cerca.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message);
            }
        }




        private void btn_cerca_Click(object sender, EventArgs e)
        {
            try
            {
                using (Fcerca cr = new Fcerca(sim))
                {
                    cr.vedi(sim);
                    cr.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message);
            }
        }




        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                using (Fadd add = new Fadd())
                {
                    if (add.ShowDialog() == DialogResult.OK)
                    {
                        Ctel tel = new Ctel(add.numero, add.durata);
                        sim.addCtel(tel);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errore: " + ex.Message);
            }
        }

        private void btn_ricarica_Click(object sender, EventArgs e)
        {
            using (Fcrea crea = new Fcrea())
            {
                crea.ShowDialog();
                if (crea.DialogResult == DialogResult.OK)
                {
                    sim.saldo += crea.credito;
                }
                
            }
        }
    }
}
