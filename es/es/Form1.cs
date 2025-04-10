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
    public partial class Form1 : Form
    {
        Csim sim;
        public Form1()
        {
            InitializeComponent();
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
                if(DialogResult == DialogResult.OK)
                {
                    sim = new Csim(crea.numero, crea.credito);
                }
            }
            btn_crea.Visible = false;
        }
    }
}
