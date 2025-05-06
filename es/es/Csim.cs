using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace es
{
    public class Csim
    {
        private string num;
        public int saldo { get; set; }
        public List<Ctel> telefonate;

        public Csim()
        {
            num = "000000";
            saldo = 0;
            telefonate = new List<Ctel>();
        }

        public Csim(string num, int saldo)
        {
            this.num = num;
            this.saldo = saldo;
            telefonate = new List<Ctel>();
        }

        public void addCtel(Ctel ct)
        {
            telefonate.Add(ct);
        }

        public List<Ctel> cerca(string num)
        {
            List<Ctel> tel_con_num = new List<Ctel>();
                for (int i = 0; i < telefonate.Count; i++)
            {
                if (telefonate[i].num == num)
                {
                    tel_con_num.Add(telefonate[i]);
                }
            }
            return tel_con_num;
        }

        public string totale_minuti()
        {
            int totale = 0;
            for (int i = 0; i < telefonate.Count; i++)
            {
                totale += telefonate[i].durata;
            }
            totale = totale / 60;
            return $"il totale trascorso in delle chiamate è di {totale} minuti/o";
        }

        public string info()
        {
            string tele = $"il numero {num} ha un saldo di {saldo} euro\n\r";
            for (int i = 0; i < telefonate.Count; i++)
            {
                tele += telefonate[i].informazioni() + "\n\r";
            }

            return tele;
        }
    }
}
