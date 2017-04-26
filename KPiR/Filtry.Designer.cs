namespace KPiR
{
    partial class Filtry
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
            this.dataGridViewKonta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonZatwierdz = new System.Windows.Forms.Button();
            this.buttonAllKonta = new System.Windows.Forms.Button();
            this.buttonAnuluj = new System.Windows.Forms.Button();
            this.buttonFiltrStop = new System.Windows.Forms.Button();
            this.buttonNoKonta = new System.Windows.Forms.Button();
            this.buttonNoKoord = new System.Windows.Forms.Button();
            this.buttonAllKoord = new System.Windows.Forms.Button();
            this.dataGridViewKoord = new System.Windows.Forms.DataGridView();
            this.dataGridViewAkcje = new System.Windows.Forms.DataGridView();
            this.buttonNoAkcje = new System.Windows.Forms.Button();
            this.buttonAllAkcje = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKonta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKoord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAkcje)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewKonta
            // 
            this.dataGridViewKonta.AllowUserToAddRows = false;
            this.dataGridViewKonta.AllowUserToDeleteRows = false;
            this.dataGridViewKonta.AllowUserToResizeColumns = false;
            this.dataGridViewKonta.AllowUserToResizeRows = false;
            this.dataGridViewKonta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKonta.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataGridViewKonta.Location = new System.Drawing.Point(12, 36);
            this.dataGridViewKonta.MultiSelect = false;
            this.dataGridViewKonta.Name = "dataGridViewKonta";
            this.dataGridViewKonta.RowTemplate.Height = 24;
            this.dataGridViewKonta.Size = new System.Drawing.Size(324, 212);
            this.dataGridViewKonta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(128, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Wybierz Konta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wybierz Koordynatorów";
            // 
            // buttonZatwierdz
            // 
            this.buttonZatwierdz.Location = new System.Drawing.Point(522, 472);
            this.buttonZatwierdz.Name = "buttonZatwierdz";
            this.buttonZatwierdz.Size = new System.Drawing.Size(147, 70);
            this.buttonZatwierdz.TabIndex = 6;
            this.buttonZatwierdz.Text = "Zatwierdź";
            this.buttonZatwierdz.UseVisualStyleBackColor = true;
            this.buttonZatwierdz.Click += new System.EventHandler(this.buttonZatwierdz_Click);
            // 
            // buttonAllKonta
            // 
            this.buttonAllKonta.Location = new System.Drawing.Point(353, 35);
            this.buttonAllKonta.Name = "buttonAllKonta";
            this.buttonAllKonta.Size = new System.Drawing.Size(81, 57);
            this.buttonAllKonta.TabIndex = 7;
            this.buttonAllKonta.Text = "Zaznacz wszystkie";
            this.buttonAllKonta.UseVisualStyleBackColor = true;
            this.buttonAllKonta.Click += new System.EventHandler(this.buttonAllKonta_Click);
            // 
            // buttonAnuluj
            // 
            this.buttonAnuluj.Location = new System.Drawing.Point(710, 472);
            this.buttonAnuluj.Name = "buttonAnuluj";
            this.buttonAnuluj.Size = new System.Drawing.Size(147, 70);
            this.buttonAnuluj.TabIndex = 8;
            this.buttonAnuluj.Text = "Anuluj";
            this.buttonAnuluj.UseVisualStyleBackColor = true;
            this.buttonAnuluj.Click += new System.EventHandler(this.buttonAnuluj_Click);
            // 
            // buttonFiltrStop
            // 
            this.buttonFiltrStop.Location = new System.Drawing.Point(574, 409);
            this.buttonFiltrStop.Name = "buttonFiltrStop";
            this.buttonFiltrStop.Size = new System.Drawing.Size(240, 57);
            this.buttonFiltrStop.TabIndex = 9;
            this.buttonFiltrStop.Text = "Wyczyść wszystkie filtry";
            this.buttonFiltrStop.UseVisualStyleBackColor = true;
            this.buttonFiltrStop.Click += new System.EventHandler(this.buttonFiltrStop_Click);
            // 
            // buttonNoKonta
            // 
            this.buttonNoKonta.Location = new System.Drawing.Point(353, 127);
            this.buttonNoKonta.Name = "buttonNoKonta";
            this.buttonNoKonta.Size = new System.Drawing.Size(81, 57);
            this.buttonNoKonta.TabIndex = 10;
            this.buttonNoKonta.Text = "Odznacz wszystkie";
            this.buttonNoKonta.UseVisualStyleBackColor = true;
            this.buttonNoKonta.Click += new System.EventHandler(this.buttonNoKonta_Click);
            // 
            // buttonNoKoord
            // 
            this.buttonNoKoord.Location = new System.Drawing.Point(360, 409);
            this.buttonNoKoord.Name = "buttonNoKoord";
            this.buttonNoKoord.Size = new System.Drawing.Size(81, 57);
            this.buttonNoKoord.TabIndex = 14;
            this.buttonNoKoord.Text = "Odznacz wszystkie";
            this.buttonNoKoord.UseVisualStyleBackColor = true;
            this.buttonNoKoord.Click += new System.EventHandler(this.buttonNoKoord_Click);
            // 
            // buttonAllKoord
            // 
            this.buttonAllKoord.Location = new System.Drawing.Point(360, 317);
            this.buttonAllKoord.Name = "buttonAllKoord";
            this.buttonAllKoord.Size = new System.Drawing.Size(81, 57);
            this.buttonAllKoord.TabIndex = 13;
            this.buttonAllKoord.Text = "Zaznacz wszystkie";
            this.buttonAllKoord.UseVisualStyleBackColor = true;
            this.buttonAllKoord.Click += new System.EventHandler(this.buttonAllKoord_Click);
            // 
            // dataGridViewKoord
            // 
            this.dataGridViewKoord.AllowUserToAddRows = false;
            this.dataGridViewKoord.AllowUserToDeleteRows = false;
            this.dataGridViewKoord.AllowUserToResizeColumns = false;
            this.dataGridViewKoord.AllowUserToResizeRows = false;
            this.dataGridViewKoord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKoord.Location = new System.Drawing.Point(12, 317);
            this.dataGridViewKoord.MultiSelect = false;
            this.dataGridViewKoord.Name = "dataGridViewKoord";
            this.dataGridViewKoord.RowTemplate.Height = 24;
            this.dataGridViewKoord.Size = new System.Drawing.Size(324, 212);
            this.dataGridViewKoord.TabIndex = 15;
            // 
            // dataGridViewAkcje
            // 
            this.dataGridViewAkcje.AllowUserToAddRows = false;
            this.dataGridViewAkcje.AllowUserToDeleteRows = false;
            this.dataGridViewAkcje.AllowUserToResizeColumns = false;
            this.dataGridViewAkcje.AllowUserToResizeRows = false;
            this.dataGridViewAkcje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAkcje.Location = new System.Drawing.Point(502, 36);
            this.dataGridViewAkcje.MultiSelect = false;
            this.dataGridViewAkcje.Name = "dataGridViewAkcje";
            this.dataGridViewAkcje.RowTemplate.Height = 24;
            this.dataGridViewAkcje.Size = new System.Drawing.Size(326, 338);
            this.dataGridViewAkcje.TabIndex = 20;
            // 
            // buttonNoAkcje
            // 
            this.buttonNoAkcje.Location = new System.Drawing.Point(845, 127);
            this.buttonNoAkcje.Name = "buttonNoAkcje";
            this.buttonNoAkcje.Size = new System.Drawing.Size(81, 57);
            this.buttonNoAkcje.TabIndex = 19;
            this.buttonNoAkcje.Text = "Odznacz wszystkie";
            this.buttonNoAkcje.UseVisualStyleBackColor = true;
            this.buttonNoAkcje.Click += new System.EventHandler(this.buttonNoAkcje_Click);
            // 
            // buttonAllAkcje
            // 
            this.buttonAllAkcje.Location = new System.Drawing.Point(845, 36);
            this.buttonAllAkcje.Name = "buttonAllAkcje";
            this.buttonAllAkcje.Size = new System.Drawing.Size(81, 57);
            this.buttonAllAkcje.TabIndex = 18;
            this.buttonAllAkcje.Text = "Zaznacz wszystkie";
            this.buttonAllAkcje.UseVisualStyleBackColor = true;
            this.buttonAllAkcje.Click += new System.EventHandler(this.buttonAllAkcje_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(622, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Wybierz akcje";
            // 
            // Filtry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 565);
            this.Controls.Add(this.dataGridViewAkcje);
            this.Controls.Add(this.buttonNoAkcje);
            this.Controls.Add(this.buttonAllAkcje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewKoord);
            this.Controls.Add(this.buttonNoKoord);
            this.Controls.Add(this.buttonAllKoord);
            this.Controls.Add(this.buttonNoKonta);
            this.Controls.Add(this.buttonFiltrStop);
            this.Controls.Add(this.buttonAnuluj);
            this.Controls.Add(this.buttonAllKonta);
            this.Controls.Add(this.buttonZatwierdz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewKonta);
            this.Name = "Filtry";
            this.Text = "Filtry";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Filtry_FormClosing);
            this.Load += new System.EventHandler(this.Filtry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKonta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKoord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAkcje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewKonta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonZatwierdz;
        private System.Windows.Forms.Button buttonAllKonta;
        private System.Windows.Forms.Button buttonAnuluj;
        private System.Windows.Forms.Button buttonFiltrStop;
        private System.Windows.Forms.Button buttonNoKonta;
        private System.Windows.Forms.Button buttonNoKoord;
        private System.Windows.Forms.Button buttonAllKoord;
        private System.Windows.Forms.DataGridView dataGridViewKoord;
        private System.Windows.Forms.DataGridView dataGridViewAkcje;
        private System.Windows.Forms.Button buttonNoAkcje;
        private System.Windows.Forms.Button buttonAllAkcje;
        private System.Windows.Forms.Label label2;
    }
}