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
            this.SuspendLayout();
            // 
            // btn_cerca
            // 
            this.btn_cerca.Location = new System.Drawing.Point(54, 173);
            this.btn_cerca.Name = "btn_cerca";
            this.btn_cerca.Size = new System.Drawing.Size(132, 23);
            this.btn_cerca.TabIndex = 0;
            this.btn_cerca.Text = "visualizza la cronologia";
            this.btn_cerca.UseVisualStyleBackColor = true;
            // 
            // btn_minuti
            // 
            this.btn_minuti.Location = new System.Drawing.Point(204, 173);
            this.btn_minuti.Name = "btn_minuti";
            this.btn_minuti.Size = new System.Drawing.Size(123, 23);
            this.btn_minuti.TabIndex = 1;
            this.btn_minuti.Text = "visualizza minuti totali";
            this.btn_minuti.UseVisualStyleBackColor = true;
            this.btn_minuti.Click += new System.EventHandler(this.btn_minuti_Click);
            // 
            // btn_crea
            // 
            this.btn_crea.Location = new System.Drawing.Point(204, 81);
            this.btn_crea.Name = "btn_crea";
            this.btn_crea.Size = new System.Drawing.Size(75, 23);
            this.btn_crea.TabIndex = 2;
            this.btn_crea.Text = "crea SIM";
            this.btn_crea.UseVisualStyleBackColor = true;
            this.btn_crea.Click += new System.EventHandler(this.btn_crea_Click);
            // 
            // btn_filtra
            // 
            this.btn_filtra.Location = new System.Drawing.Point(375, 173);
            this.btn_filtra.Name = "btn_filtra";
            this.btn_filtra.Size = new System.Drawing.Size(103, 23);
            this.btn_filtra.TabIndex = 3;
            this.btn_filtra.Text = "filtra per numero";
            this.btn_filtra.UseVisualStyleBackColor = true;
            // 
            // btn_ricarica
            // 
            this.btn_ricarica.Location = new System.Drawing.Point(333, 81);
            this.btn_ricarica.Name = "btn_ricarica";
            this.btn_ricarica.Size = new System.Drawing.Size(75, 23);
            this.btn_ricarica.TabIndex = 4;
            this.btn_ricarica.Text = "ricarica";
            this.btn_ricarica.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 450);
            this.Controls.Add(this.btn_ricarica);
            this.Controls.Add(this.btn_filtra);
            this.Controls.Add(this.btn_crea);
            this.Controls.Add(this.btn_minuti);
            this.Controls.Add(this.btn_cerca);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cerca;
        private System.Windows.Forms.Button btn_minuti;
        private System.Windows.Forms.Button btn_crea;
        private System.Windows.Forms.Button btn_filtra;
        private System.Windows.Forms.Button btn_ricarica;
    }
}

