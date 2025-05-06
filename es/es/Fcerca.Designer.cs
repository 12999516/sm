namespace es
{
    partial class Fcerca
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
            this.txt_num = new System.Windows.Forms.TextBox();
            this.btn_cerca = new System.Windows.Forms.Button();
            this.lbl_cerca = new System.Windows.Forms.Label();
            this.lbl_chia = new System.Windows.Forms.Label();
            this.dtg_tel = new System.Windows.Forms.DataGridView();
            this.clm1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_tel)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_num
            // 
            this.txt_num.Location = new System.Drawing.Point(8, 36);
            this.txt_num.Name = "txt_num";
            this.txt_num.Size = new System.Drawing.Size(209, 22);
            this.txt_num.TabIndex = 1;
            // 
            // btn_cerca
            // 
            this.btn_cerca.Location = new System.Drawing.Point(247, 12);
            this.btn_cerca.Name = "btn_cerca";
            this.btn_cerca.Size = new System.Drawing.Size(103, 71);
            this.btn_cerca.TabIndex = 2;
            this.btn_cerca.Text = "button1";
            this.btn_cerca.UseVisualStyleBackColor = true;
            this.btn_cerca.Click += new System.EventHandler(this.btn_cerca_Click);
            // 
            // lbl_cerca
            // 
            this.lbl_cerca.BackColor = System.Drawing.Color.Gold;
            this.lbl_cerca.Location = new System.Drawing.Point(5, 12);
            this.lbl_cerca.Name = "lbl_cerca";
            this.lbl_cerca.Size = new System.Drawing.Size(212, 21);
            this.lbl_cerca.TabIndex = 3;
            this.lbl_cerca.Text = "scrivi il numero da cercare";
            // 
            // lbl_chia
            // 
            this.lbl_chia.BackColor = System.Drawing.Color.Gold;
            this.lbl_chia.Location = new System.Drawing.Point(5, 61);
            this.lbl_chia.Name = "lbl_chia";
            this.lbl_chia.Size = new System.Drawing.Size(212, 23);
            this.lbl_chia.TabIndex = 4;
            this.lbl_chia.Text = "chiamate con questo numero";
            // 
            // dtg_tel
            // 
            this.dtg_tel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_tel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm1,
            this.clm2});
            this.dtg_tel.Location = new System.Drawing.Point(12, 89);
            this.dtg_tel.Name = "dtg_tel";
            this.dtg_tel.RowHeadersVisible = false;
            this.dtg_tel.RowHeadersWidth = 51;
            this.dtg_tel.RowTemplate.Height = 24;
            this.dtg_tel.Size = new System.Drawing.Size(466, 155);
            this.dtg_tel.TabIndex = 5;
            // 
            // clm1
            // 
            this.clm1.FillWeight = 75F;
            this.clm1.HeaderText = "numero chiamato";
            this.clm1.MinimumWidth = 6;
            this.clm1.Name = "clm1";
            this.clm1.Width = 250;
            // 
            // clm2
            // 
            this.clm2.HeaderText = "durata in secondi";
            this.clm2.MinimumWidth = 6;
            this.clm2.Name = "clm2";
            this.clm2.Width = 250;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(575, 341);
            this.panel1.TabIndex = 6;
            // 
            // Fcerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 337);
            this.Controls.Add(this.dtg_tel);
            this.Controls.Add(this.lbl_chia);
            this.Controls.Add(this.lbl_cerca);
            this.Controls.Add(this.btn_cerca);
            this.Controls.Add(this.txt_num);
            this.Controls.Add(this.panel1);
            this.Name = "Fcerca";
            this.Text = "Fcerca";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_tel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_num;
        private System.Windows.Forms.Button btn_cerca;
        private System.Windows.Forms.Label lbl_cerca;
        private System.Windows.Forms.Label lbl_chia;
        private System.Windows.Forms.DataGridView dtg_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm2;
        private System.Windows.Forms.Panel panel1;
    }
}