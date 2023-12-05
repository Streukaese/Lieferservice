namespace Lieferservice
{
    partial class Hauptfenster
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewArtikel = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.buttonHinzufuegen = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelArtikel = new System.Windows.Forms.Label();
            this.labelBestelluebersicht = new System.Windows.Forms.Label();
            this.buttonAbbrechen = new System.Windows.Forms.Button();
            this.buttonAbsenden = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtikel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewArtikel
            // 
            this.dataGridViewArtikel.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridViewArtikel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArtikel.Location = new System.Drawing.Point(12, 56);
            this.dataGridViewArtikel.Name = "dataGridViewArtikel";
            this.dataGridViewArtikel.RowHeadersWidth = 51;
            this.dataGridViewArtikel.RowTemplate.Height = 24;
            this.dataGridViewArtikel.Size = new System.Drawing.Size(342, 429);
            this.dataGridViewArtikel.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(464, 56);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(587, 429);
            this.dataGridView2.TabIndex = 1;
            // 
            // buttonHinzufuegen
            // 
            this.buttonHinzufuegen.BackColor = System.Drawing.Color.Salmon;
            this.buttonHinzufuegen.Location = new System.Drawing.Point(360, 110);
            this.buttonHinzufuegen.Name = "buttonHinzufuegen";
            this.buttonHinzufuegen.Size = new System.Drawing.Size(98, 90);
            this.buttonHinzufuegen.TabIndex = 2;
            this.buttonHinzufuegen.Text = "Hinzufügen";
            this.buttonHinzufuegen.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.OliveDrab;
            this.button2.Location = new System.Drawing.Point(1057, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 90);
            this.button2.TabIndex = 3;
            this.button2.Text = "Gesamtpreis anzeigen";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // labelArtikel
            // 
            this.labelArtikel.AutoSize = true;
            this.labelArtikel.Location = new System.Drawing.Point(228, 26);
            this.labelArtikel.Name = "labelArtikel";
            this.labelArtikel.Size = new System.Drawing.Size(44, 16);
            this.labelArtikel.TabIndex = 4;
            this.labelArtikel.Text = "Artikel";
            // 
            // labelBestelluebersicht
            // 
            this.labelBestelluebersicht.AutoSize = true;
            this.labelBestelluebersicht.Location = new System.Drawing.Point(703, 26);
            this.labelBestelluebersicht.Name = "labelBestelluebersicht";
            this.labelBestelluebersicht.Size = new System.Drawing.Size(105, 16);
            this.labelBestelluebersicht.TabIndex = 5;
            this.labelBestelluebersicht.Text = " Bestellübersicht";
            // 
            // buttonAbbrechen
            // 
            this.buttonAbbrechen.BackColor = System.Drawing.Color.Salmon;
            this.buttonAbbrechen.Location = new System.Drawing.Point(360, 348);
            this.buttonAbbrechen.Name = "buttonAbbrechen";
            this.buttonAbbrechen.Size = new System.Drawing.Size(98, 90);
            this.buttonAbbrechen.TabIndex = 6;
            this.buttonAbbrechen.Text = "Abbrechen";
            this.buttonAbbrechen.UseVisualStyleBackColor = false;
            // 
            // buttonAbsenden
            // 
            this.buttonAbsenden.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonAbsenden.Location = new System.Drawing.Point(1057, 348);
            this.buttonAbsenden.Name = "buttonAbsenden";
            this.buttonAbsenden.Size = new System.Drawing.Size(98, 90);
            this.buttonAbsenden.TabIndex = 7;
            this.buttonAbsenden.Text = "Bestellung Abschließen";
            this.buttonAbsenden.UseVisualStyleBackColor = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(360, 239);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(98, 22);
            this.numericUpDown1.TabIndex = 8;
            // 
            // Hauptfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1161, 497);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.buttonAbsenden);
            this.Controls.Add(this.buttonAbbrechen);
            this.Controls.Add(this.labelBestelluebersicht);
            this.Controls.Add(this.labelArtikel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonHinzufuegen);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridViewArtikel);
            this.Name = "Hauptfenster";
            this.Text = "Bestell Formular";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArtikel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewArtikel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonHinzufuegen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelArtikel;
        private System.Windows.Forms.Label labelBestelluebersicht;
        private System.Windows.Forms.Button buttonAbbrechen;
        private System.Windows.Forms.Button buttonAbsenden;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

