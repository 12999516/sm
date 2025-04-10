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
            this.SuspendLayout();
            // 
            // lbl_credito
            // 
            this.lbl_credito.Location = new System.Drawing.Point(257, 226);
            this.lbl_credito.Name = "lbl_credito";
            this.lbl_credito.Size = new System.Drawing.Size(100, 23);
            this.lbl_credito.TabIndex = 0;
            this.lbl_credito.Text = "credito da inserire";
            // 
            // lbl_numero
            // 
            this.lbl_numero.Location = new System.Drawing.Point(257, 62);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(100, 23);
            this.lbl_numero.TabIndex = 1;
            this.lbl_numero.Text = "numero di telefono";
            // 
            // btn_aggiungi
            // 
            this.btn_aggiungi.Location = new System.Drawing.Point(260, 396);
            this.btn_aggiungi.Name = "btn_aggiungi";
            this.btn_aggiungi.Size = new System.Drawing.Size(75, 23);
            this.btn_aggiungi.TabIndex = 3;
            this.btn_aggiungi.Text = "aggiungi";
            this.btn_aggiungi.UseVisualStyleBackColor = true;
            this.btn_aggiungi.Click += new System.EventHandler(this.btn_aggiungi_Click);

            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(257, 88);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(100, 20);
            this.txt_numero.TabIndex = 4;
            this.txt_numero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_numero_KeyPress);
            // 
            // txt_credito
            // 
            this.txt_credito.Location = new System.Drawing.Point(260, 252);
            this.txt_credito.Name = "txt_credito";
            this.txt_credito.Size = new System.Drawing.Size(97, 20);
            this.txt_credito.TabIndex = 5;
            this.txt_credito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_credito_KeyPress);
            // 
            // Fcrea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_credito);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.btn_aggiungi);
            this.Controls.Add(this.lbl_numero);
            this.Controls.Add(this.lbl_credito);
            this.Name = "Fcrea";
            this.Text = "Fcrea";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_credito;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.Button btn_aggiungi;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_credito;
    }
}