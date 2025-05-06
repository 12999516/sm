namespace es
{
    partial class Fadd
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
            this.txt_d = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_c = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_n = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_d
            // 
            this.txt_d.Location = new System.Drawing.Point(49, 137);
            this.txt_d.Name = "txt_d";
            this.txt_d.Size = new System.Drawing.Size(123, 22);
            this.txt_d.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(49, 48);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(123, 22);
            this.textBox3.TabIndex = 2;
            // 
            // btn_c
            // 
            this.btn_c.Location = new System.Drawing.Point(49, 200);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(123, 49);
            this.btn_c.TabIndex = 3;
            this.btn_c.Text = "aggiungi telefonata";
            this.btn_c.UseVisualStyleBackColor = true;
            this.btn_c.Click += new System.EventHandler(this.btn_c_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(46, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "durata in secondi";
            // 
            // lbl_n
            // 
            this.lbl_n.Location = new System.Drawing.Point(46, 22);
            this.lbl_n.Name = "lbl_n";
            this.lbl_n.Size = new System.Drawing.Size(126, 23);
            this.lbl_n.TabIndex = 5;
            this.lbl_n.Text = "numero chiamato";
            // 
            // Fadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 279);
            this.Controls.Add(this.lbl_n);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_c);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txt_d);
            this.Name = "Fadd";
            this.Text = "Fadd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_d;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_n;
    }
}