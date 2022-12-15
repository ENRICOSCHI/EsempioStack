namespace EsempioStack1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPop = new System.Windows.Forms.Button();
            this.btnPush = new System.Windows.Forms.Button();
            this.txtCilindrata = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTarga = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStampa = new System.Windows.Forms.Label();
            this.btPrint = new System.Windows.Forms.Button();
            this.txtStampa = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPop);
            this.groupBox1.Controls.Add(this.btnPush);
            this.groupBox1.Controls.Add(this.txtCilindrata);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTarga);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(72, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 287);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuova Automobile";
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(201, 191);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(88, 47);
            this.btnPop.TabIndex = 5;
            this.btnPop.Text = "Rimuovi";
            this.btnPop.UseVisualStyleBackColor = true;
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(33, 191);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(88, 47);
            this.btnPush.TabIndex = 4;
            this.btnPush.Text = "Aggiungi";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            // 
            // txtCilindrata
            // 
            this.txtCilindrata.Location = new System.Drawing.Point(189, 109);
            this.txtCilindrata.Name = "txtCilindrata";
            this.txtCilindrata.Size = new System.Drawing.Size(100, 22);
            this.txtCilindrata.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cilindrata";
            // 
            // txtTarga
            // 
            this.txtTarga.Location = new System.Drawing.Point(120, 46);
            this.txtTarga.Name = "txtTarga";
            this.txtTarga.Size = new System.Drawing.Size(169, 22);
            this.txtTarga.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Targa";
            // 
            // lblStampa
            // 
            this.lblStampa.AutoSize = true;
            this.lblStampa.Location = new System.Drawing.Point(105, 359);
            this.lblStampa.Name = "lblStampa";
            this.lblStampa.Size = new System.Drawing.Size(37, 16);
            this.lblStampa.TabIndex = 1;
            this.lblStampa.Text = "label";
            // 
            // btPrint
            // 
            this.btPrint.Location = new System.Drawing.Point(307, 294);
            this.btPrint.Name = "btPrint";
            this.btPrint.Size = new System.Drawing.Size(88, 47);
            this.btPrint.TabIndex = 6;
            this.btPrint.Text = "Stampa";
            this.btPrint.UseVisualStyleBackColor = true;
            this.btPrint.Click += new System.EventHandler(this.btPrint_Click);
            // 
            // txtStampa
            // 
            this.txtStampa.Location = new System.Drawing.Point(307, 359);
            this.txtStampa.Name = "txtStampa";
            this.txtStampa.Size = new System.Drawing.Size(100, 22);
            this.txtStampa.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 450);
            this.Controls.Add(this.txtStampa);
            this.Controls.Add(this.btPrint);
            this.Controls.Add(this.lblStampa);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.TextBox txtCilindrata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTarga;
        private System.Windows.Forms.Label lblStampa;
        private System.Windows.Forms.Button btPrint;
        private System.Windows.Forms.TextBox txtStampa;
    }
}

