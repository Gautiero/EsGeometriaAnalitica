namespace Prog_GeometriaAnalitica
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
            this.btn_puntoM_2p = new System.Windows.Forms.Button();
            this.btn_distanza_2p = new System.Windows.Forms.Button();
            this.btn_rettaPassante_2p = new System.Windows.Forms.Button();
            this.btn_circ_3p = new System.Windows.Forms.Button();
            this.btn_distanzaRettaPunto = new System.Windows.Forms.Button();
            this.lbl_ris = new System.Windows.Forms.Label();
            this.txt_ris = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblScala = new System.Windows.Forms.Label();
            this.txtScala = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_puntoM_2p
            // 
            this.btn_puntoM_2p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_puntoM_2p.Location = new System.Drawing.Point(284, 7);
            this.btn_puntoM_2p.Name = "btn_puntoM_2p";
            this.btn_puntoM_2p.Size = new System.Drawing.Size(130, 23);
            this.btn_puntoM_2p.TabIndex = 8;
            this.btn_puntoM_2p.Text = "Punto Medio";
            this.btn_puntoM_2p.UseVisualStyleBackColor = false;
            this.btn_puntoM_2p.Click += new System.EventHandler(this.btn_puntoM_2p_Click);
            // 
            // btn_distanza_2p
            // 
            this.btn_distanza_2p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_distanza_2p.Location = new System.Drawing.Point(148, 7);
            this.btn_distanza_2p.Name = "btn_distanza_2p";
            this.btn_distanza_2p.Size = new System.Drawing.Size(130, 23);
            this.btn_distanza_2p.TabIndex = 9;
            this.btn_distanza_2p.Text = "Distanza";
            this.btn_distanza_2p.UseVisualStyleBackColor = false;
            this.btn_distanza_2p.Click += new System.EventHandler(this.btn_distanza_2p_Click);
            // 
            // btn_rettaPassante_2p
            // 
            this.btn_rettaPassante_2p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_rettaPassante_2p.Location = new System.Drawing.Point(12, 7);
            this.btn_rettaPassante_2p.Name = "btn_rettaPassante_2p";
            this.btn_rettaPassante_2p.Size = new System.Drawing.Size(130, 23);
            this.btn_rettaPassante_2p.TabIndex = 10;
            this.btn_rettaPassante_2p.Text = "Retta Passante";
            this.btn_rettaPassante_2p.UseVisualStyleBackColor = false;
            this.btn_rettaPassante_2p.Click += new System.EventHandler(this.btn_rettaPassante_2p_Click);
            // 
            // btn_circ_3p
            // 
            this.btn_circ_3p.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_circ_3p.Location = new System.Drawing.Point(556, 7);
            this.btn_circ_3p.Name = "btn_circ_3p";
            this.btn_circ_3p.Size = new System.Drawing.Size(130, 23);
            this.btn_circ_3p.TabIndex = 11;
            this.btn_circ_3p.Text = "Circ. passante 3p";
            this.btn_circ_3p.UseVisualStyleBackColor = false;
            // 
            // btn_distanzaRettaPunto
            // 
            this.btn_distanzaRettaPunto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_distanzaRettaPunto.Location = new System.Drawing.Point(420, 7);
            this.btn_distanzaRettaPunto.Name = "btn_distanzaRettaPunto";
            this.btn_distanzaRettaPunto.Size = new System.Drawing.Size(130, 23);
            this.btn_distanzaRettaPunto.TabIndex = 12;
            this.btn_distanzaRettaPunto.Text = "Dist. tra Punto e Retta";
            this.btn_distanzaRettaPunto.UseVisualStyleBackColor = false;
            this.btn_distanzaRettaPunto.Click += new System.EventHandler(this.btn_distanzaRettaPunto_Click);
            // 
            // lbl_ris
            // 
            this.lbl_ris.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ris.AutoSize = true;
            this.lbl_ris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbl_ris.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ris.Location = new System.Drawing.Point(597, 295);
            this.lbl_ris.Name = "lbl_ris";
            this.lbl_ris.Size = new System.Drawing.Size(51, 13);
            this.lbl_ris.TabIndex = 13;
            this.lbl_ris.Text = "Risultato:";
            // 
            // txt_ris
            // 
            this.txt_ris.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ris.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txt_ris.Location = new System.Drawing.Point(557, 311);
            this.txt_ris.Multiline = true;
            this.txt_ris.Name = "txt_ris";
            this.txt_ris.Size = new System.Drawing.Size(133, 33);
            this.txt_ris.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 362);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.Resize += new System.EventHandler(this.panel1_Resize);
            // 
            // lblScala
            // 
            this.lblScala.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblScala.AutoSize = true;
            this.lblScala.Location = new System.Drawing.Point(553, 188);
            this.lblScala.Name = "lblScala";
            this.lblScala.Size = new System.Drawing.Size(75, 13);
            this.lblScala.TabIndex = 16;
            this.lblScala.Text = "Imposta scala:";
            // 
            // txtScala
            // 
            this.txtScala.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtScala.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtScala.Location = new System.Drawing.Point(634, 185);
            this.txtScala.Name = "txtScala";
            this.txtScala.ReadOnly = true;
            this.txtScala.Size = new System.Drawing.Size(52, 20);
            this.txtScala.TabIndex = 17;
            this.txtScala.Text = "10";
            this.txtScala.TextChanged += new System.EventHandler(this.txtGrandezza_TextChanged);
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBar1.Location = new System.Drawing.Point(556, 207);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 45);
            this.trackBar1.TabIndex = 19;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(707, 412);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.txtScala);
            this.Controls.Add(this.lblScala);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_ris);
            this.Controls.Add(this.lbl_ris);
            this.Controls.Add(this.btn_distanzaRettaPunto);
            this.Controls.Add(this.btn_circ_3p);
            this.Controls.Add(this.btn_rettaPassante_2p);
            this.Controls.Add(this.btn_distanza_2p);
            this.Controls.Add(this.btn_puntoM_2p);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_puntoM_2p;
        private System.Windows.Forms.Button btn_distanza_2p;
        private System.Windows.Forms.Button btn_rettaPassante_2p;
        private System.Windows.Forms.Button btn_circ_3p;
        private System.Windows.Forms.Button btn_distanzaRettaPunto;
        private System.Windows.Forms.Label lbl_ris;
        private System.Windows.Forms.TextBox txt_ris;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblScala;
        private System.Windows.Forms.TextBox txtScala;
        private System.Windows.Forms.TrackBar trackBar1;
    }
}

