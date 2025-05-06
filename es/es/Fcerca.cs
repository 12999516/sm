using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es
{
    public partial class Fcerca : Form
    {

        public string numero { get; set; }
        DialogResult dr { get; set; }

        

        private Csim sim;

            
        public Fcerca(Csim sim)
        {
            this.sim = sim;
            InitializeComponent();
        }

            



        public Fcerca()
        {
            InitializeComponent();
        }

        


        private void btn_cerca_Click(object sender, EventArgs e)
        {
            numero = txt_num.Text;
            if (string.IsNullOrWhiteSpace(numero))
            {
                MessageBox.Show("Inserisci un numero valido per cercare.");
                return;
            }

            filtr(sim, numero);
        }








        public void filtr(Csim sim, string numero)
        {

            set();
            dtg_tel.DataSource = sim.cerca(numero);

            /*try
            {
                set();

                List<Ctel> num = new List<Ctel>();
                for (int i = 0; i < sim.telefonate.Count; i++)
                {
                    if (sim.telefonate[i].num == numero)
                    {
                        num.Add(sim.telefonate[i]);
                    }
                }

                dtg_tel.DataSource = num;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Si è verificato un errore: {ex.Message}");
                MessageBox.Show("Non ci sono chiamate da visualizzare.");
            }*/
            
        }


        public void vedi(Csim sim)
        {
            try
            {
                set();
                dtg_tel.DataSource = sim.telefonate;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Si è verificato un errore: {ex.Message}");
                MessageBox.Show("Non ci sono chiamate da visualizzare.");
            }
                

        }

        private void set()
        {
            dtg_tel.AutoGenerateColumns = false;
            dtg_tel.Columns.Clear();

            DataGridViewTextBoxColumn clm_numero = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "num",
                HeaderText = "Numero Chiamato",
                Width = 200
            };
            dtg_tel.Columns.Add(clm_numero);

            DataGridViewTextBoxColumn clm_dur = new DataGridViewTextBoxColumn
            {
                DataPropertyName = "durata",
                HeaderText = "Durata in Secondi",
                Width = 150
            };
            dtg_tel.Columns.Add(clm_dur);
        }
        
    }
}





