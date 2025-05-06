namespace es
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_cerca = new System.Windows.Forms.Button();
            this.btn_minuti = new System.Windows.Forms.Button();
            this.btn_crea = new System.Windows.Forms.Button();
            this.btn_filtra = new System.Windows.Forms.Button();
            this.btn_ricarica = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.pnl_sfonfo = new System.Windows.Forms.Panel();
            this.pnl_riga = new System.Windows.Forms.Panel();
            this.lbl_nome = new System.Windows.Forms.Label();
            this.pnl_sfonfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_cerca
            // 
            this.btn_cerca.Location = new System.Drawing.Point(14, 147);
            this.btn_cerca.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cerca.Name = "btn_cerca";
            this.btn_cerca.Size = new System.Drawing.Size(176, 28);
            this.btn_cerca.TabIndex = 0;
            this.btn_cerca.Text = "visualizza la cronologia";
            this.btn_cerca.UseVisualStyleBackColor = true;
            this.btn_cerca.Click += new System.EventHandler(this.btn_cerca_Click);
            // 
            // btn_minuti
            // 
            this.btn_minuti.Location = new System.Drawing.Point(264, 111);
            this.btn_minuti.Margin = new System.Windows.Forms.Padding(4);
            this.btn_minuti.Name = "btn_minuti";
            this.btn_minuti.Size = new System.Drawing.Size(176, 28);
            this.btn_minuti.TabIndex = 1;
            this.btn_minuti.Text = "visualizza minuti totali";
            this.btn_minuti.UseVisualStyleBackColor = true;
            this.btn_minuti.Click += new System.EventHandler(this.btn_minuti_Click);
            // 
            // btn_crea
            // 
            this.btn_crea.Location = new System.Drawing.Point(214, 39);
            this.btn_crea.Margin = new System.Windows.Forms.Padding(4);
            this.btn_crea.Name = "btn_crea";
            this.btn_crea.Size = new System.Drawing.Size(100, 28);
            this.btn_crea.TabIndex = 2;
            this.btn_crea.Text = "crea SIM";
            this.btn_crea.UseVisualStyleBackColor = true;
            this.btn_crea.Click += new System.EventHandler(this.btn_crea_Click);
            // 
            // btn_filtra
            // 
            this.btn_filtra.Location = new System.Drawing.Point(14, 111);
            this.btn_filtra.Margin = new System.Windows.Forms.Padding(4);
            this.btn_filtra.Name = "btn_filtra";
            this.btn_filtra.Size = new System.Drawing.Size(176, 28);
            this.btn_filtra.TabIndex = 3;
            this.btn_filtra.Text = "filtra per numero";
            this.btn_filtra.UseVisualStyleBackColor = true;
            this.btn_filtra.Click += new System.EventHandler(this.btn_filtra_Click);
            // 
            // btn_ricarica
            // 
            this.btn_ricarica.Location = new System.Drawing.Point(349, 39);
            this.btn_ricarica.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ricarica.Name = "btn_ricarica";
            this.btn_ricarica.Size = new System.Drawing.Size(100, 28);
            this.btn_ricarica.TabIndex = 4;
            this.btn_ricarica.Text = "ricarica";
            this.btn_ricarica.UseVisualStyleBackColor = true;
            this.btn_ricarica.Click += new System.EventHandler(this.btn_ricarica_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(264, 149);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(176, 26);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "aggiungi una telefonata";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pnl_sfonfo
            // 
            this.pnl_sfonfo.BackColor = System.Drawing.Color.Gold;
            this.pnl_sfonfo.Controls.Add(this.lbl_nome);
            this.pnl_sfonfo.Controls.Add(this.btn_filtra);
            this.pnl_sfonfo.Controls.Add(this.btn_ricarica);
            this.pnl_sfonfo.Controls.Add(this.btn_add);
            this.pnl_sfonfo.Controls.Add(this.pnl_riga);
            this.pnl_sfonfo.Controls.Add(this.btn_crea);
            this.pnl_sfonfo.Controls.Add(this.btn_minuti);
            this.pnl_sfonfo.Controls.Add(this.btn_cerca);
            this.pnl_sfonfo.Location = new System.Drawing.Point(-1, 1);
            this.pnl_sfonfo.Name = "pnl_sfonfo";
            this.pnl_sfonfo.Size = new System.Drawing.Size(472, 201);
            this.pnl_sfonfo.TabIndex = 6;
            // 
            // pnl_riga
            // 
            this.pnl_riga.BackColor = System.Drawing.Color.White;
            this.pnl_riga.Location = new System.Drawing.Point(3, 74);
            this.pnl_riga.Name = "pnl_riga";
            this.pnl_riga.Size = new System.Drawing.Size(469, 10);
            this.pnl_riga.TabIndex = 0;
            // 
            // lbl_nome
            // 
            this.lbl_nome.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nome.Location = new System.Drawing.Point(34, 28);
            this.lbl_nome.Name = "lbl_nome";
            this.lbl_nome.Size = new System.Drawing.Size(156, 43);
            this.lbl_nome.TabIndex = 7;
            this.lbl_nome.Text = "888SIM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 203);
            this.Controls.Add(this.pnl_sfonfo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnl_sfonfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cerca;
        private System.Windows.Forms.Button btn_minuti;
        private System.Windows.Forms.Button btn_crea;
        private System.Windows.Forms.Button btn_filtra;
        private System.Windows.Forms.Button btn_ricarica;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel pnl_sfonfo;
        private System.Windows.Forms.Panel pnl_riga;
        private System.Windows.Forms.Label lbl_nome;
    }
}

