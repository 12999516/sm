namespace es
{
    partial class Fcrea
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_credito = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.btn_aggiungi = new System.Windows.Forms.Button();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_credito = new System.Windows.Forms.TextBox();
            this.pnl_linea1 = new System.Windows.Forms.Panel();
            this.pnl_sfondo = new System.Windows.Forms.Panel();
            this.pnl_linea2 = new System.Windows.Forms.Panel();
            this.pnl_sfondo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_credito
            // 
            this.lbl_credito.BackColor = System.Drawing.Color.Gold;
            this.lbl_credito.Location = new System.Drawing.Point(144, 166);
            this.lbl_credito.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_credito.Name = "lbl_credito";
            this.lbl_credito.Size = new System.Drawing.Size(133, 28);
            this.lbl_credito.TabIndex = 0;
            this.lbl_credito.Text = "credito da inserire";
            this.lbl_credito.Click += new System.EventHandler(this.lbl_credito_Click);
            // 
            // lbl_numero
            // 
            this.lbl_numero.Location = new System.Drawing.Point(144, 22);
            this.lbl_numero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(133, 28);
            this.lbl_numero.TabIndex = 1;
            this.lbl_numero.Text = "numero di telefono";
            this.lbl_numero.Click += new System.EventHandler(this.lbl_numero_Click);
            // 
            // btn_aggiungi
            // 
            this.btn_aggiungi.Location = new System.Drawing.Point(147, 240);
            this.btn_aggiungi.Margin = new System.Windows.Forms.Padding(4);
            this.btn_aggiungi.Name = "btn_aggiungi";
            this.btn_aggiungi.Size = new System.Drawing.Size(100, 28);
            this.btn_aggiungi.TabIndex = 3;
            this.btn_aggiungi.Text = "aggiungi";
            this.btn_aggiungi.UseVisualStyleBackColor = true;
            this.btn_aggiungi.Click += new System.EventHandler(this.btn_aggiungi_Click);
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(145, 70);
            this.txt_numero.Margin = new System.Windows.Forms.Padding(4);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(132, 22);
            this.txt_numero.TabIndex = 4;
            this.txt_numero.TextChanged += new System.EventHandler(this.txt_numero_TextChanged);
            this.txt_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numero_KeyPress);
            // 
            // txt_credito
            // 
            this.txt_credito.Location = new System.Drawing.Point(145, 128);
            this.txt_credito.Margin = new System.Windows.Forms.Padding(4);
            this.txt_credito.Name = "txt_credito";
            this.txt_credito.Size = new System.Drawing.Size(128, 22);
            this.txt_credito.TabIndex = 5;
            this.txt_credito.TextChanged += new System.EventHandler(this.txt_credito_TextChanged);
            this.txt_credito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_credito_KeyPress);
            // 
            // pnl_linea1
            // 
            this.pnl_linea1.BackColor = System.Drawing.Color.White;
            this.pnl_linea1.Location = new System.Drawing.Point(3, 99);
            this.pnl_linea1.Name = "pnl_linea1";
            this.pnl_linea1.Size = new System.Drawing.Size(424, 10);
            this.pnl_linea1.TabIndex = 6;
            // 
            // pnl_sfondo
            // 
            this.pnl_sfondo.BackColor = System.Drawing.Color.Gold;
            this.pnl_sfondo.Controls.Add(this.pnl_linea2);
            this.pnl_sfondo.Controls.Add(this.txt_numero);
            this.pnl_sfondo.Controls.Add(this.lbl_numero);
            this.pnl_sfondo.Controls.Add(this.pnl_linea1);
            this.pnl_sfondo.Location = new System.Drawing.Point(0, 0);
            this.pnl_sfondo.Name = "pnl_sfondo";
            this.pnl_sfondo.Size = new System.Drawing.Size(430, 282);
            this.pnl_sfondo.TabIndex = 0;
            // 
            // pnl_linea2
            // 
            this.pnl_linea2.BackColor = System.Drawing.Color.White;
            this.pnl_linea2.Location = new System.Drawing.Point(3, 210);
            this.pnl_linea2.Name = "pnl_linea2";
            this.pnl_linea2.Size = new System.Drawing.Size(424, 10);
            this.pnl_linea2.TabIndex = 7;
            // 
            // Fcrea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 281);
            this.Controls.Add(this.txt_credito);
            this.Controls.Add(this.btn_aggiungi);
            this.Controls.Add(this.lbl_credito);
            this.Controls.Add(this.pnl_sfondo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Fcrea";
            this.Text = "Fcrea";
            this.Load += new System.EventHandler(this.Fcrea_Load);
            this.pnl_sfondo.ResumeLayout(false);
            this.pnl_sfondo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_credito;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Button btn_aggiungi;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_credito;
        private System.Windows.Forms.Panel pnl_linea1;
        private System.Windows.Forms.Panel pnl_sfondo;
        private System.Windows.Forms.Panel pnl_linea2;
    }
}