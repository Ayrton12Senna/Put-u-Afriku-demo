namespace Projekt
{
    partial class BoljiSvijet
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
            this.Naslov = new System.Windows.Forms.Label();
            this.predmetiListbox = new System.Windows.Forms.ListBox();
            this.popisPredmetaLabel = new System.Windows.Forms.Label();
            this.dodajURuksak = new System.Windows.Forms.Button();
            this.ruksakLabel = new System.Windows.Forms.Label();
            this.ruksakListBox = new System.Windows.Forms.ListBox();
            this.ponesiRuksak = new System.Windows.Forms.Button();
            this.dobavljaciListboxLabel = new System.Windows.Forms.Label();
            this.dobavljaciListbox = new System.Windows.Forms.ListBox();
            this.cijenaPutaLabel = new System.Windows.Forms.Label();
            this.cijenaPutaValue = new System.Windows.Forms.Label();
            this.dodajUListu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Naslov
            // 
            this.Naslov.AutoSize = true;
            this.Naslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Naslov.Location = new System.Drawing.Point(14, 13);
            this.Naslov.Name = "Naslov";
            this.Naslov.Size = new System.Drawing.Size(196, 37);
            this.Naslov.TabIndex = 0;
            this.Naslov.Text = "Put u Afriku";
            // 
            // predmetiListbox
            // 
            this.predmetiListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.predmetiListbox.FormattingEnabled = true;
            this.predmetiListbox.ItemHeight = 20;
            this.predmetiListbox.Location = new System.Drawing.Point(22, 87);
            this.predmetiListbox.Name = "predmetiListbox";
            this.predmetiListbox.Size = new System.Drawing.Size(353, 164);
            this.predmetiListbox.TabIndex = 1;
            // 
            // popisPredmetaLabel
            // 
            this.popisPredmetaLabel.AutoSize = true;
            this.popisPredmetaLabel.Location = new System.Drawing.Point(18, 64);
            this.popisPredmetaLabel.Name = "popisPredmetaLabel";
            this.popisPredmetaLabel.Size = new System.Drawing.Size(80, 20);
            this.popisPredmetaLabel.TabIndex = 2;
            this.popisPredmetaLabel.Text = "Predmeti";
            // 
            // dodajURuksak
            // 
            this.dodajURuksak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajURuksak.Location = new System.Drawing.Point(381, 149);
            this.dodajURuksak.Name = "dodajURuksak";
            this.dodajURuksak.Size = new System.Drawing.Size(198, 39);
            this.dodajURuksak.TabIndex = 3;
            this.dodajURuksak.Text = "Dodaj u ruksak ->";
            this.dodajURuksak.UseVisualStyleBackColor = false;
            this.dodajURuksak.Click += new System.EventHandler(this.dodajURuksak_Click);
            // 
            // ruksakLabel
            // 
            this.ruksakLabel.AutoSize = true;
            this.ruksakLabel.Location = new System.Drawing.Point(581, 64);
            this.ruksakLabel.Name = "ruksakLabel";
            this.ruksakLabel.Size = new System.Drawing.Size(69, 20);
            this.ruksakLabel.TabIndex = 5;
            this.ruksakLabel.Text = "Ruksak";
            // 
            // ruksakListBox
            // 
            this.ruksakListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ruksakListBox.FormattingEnabled = true;
            this.ruksakListBox.ItemHeight = 20;
            this.ruksakListBox.Location = new System.Drawing.Point(585, 87);
            this.ruksakListBox.Name = "ruksakListBox";
            this.ruksakListBox.Size = new System.Drawing.Size(353, 164);
            this.ruksakListBox.TabIndex = 4;
            // 
            // ponesiRuksak
            // 
            this.ponesiRuksak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ponesiRuksak.Location = new System.Drawing.Point(851, 257);
            this.ponesiRuksak.Name = "ponesiRuksak";
            this.ponesiRuksak.Size = new System.Drawing.Size(87, 39);
            this.ponesiRuksak.TabIndex = 6;
            this.ponesiRuksak.Text = "Ponesi";
            this.ponesiRuksak.UseVisualStyleBackColor = true;
            this.ponesiRuksak.Click += new System.EventHandler(this.ponesiRuksak_Click);
            // 
            // dobavljaciListboxLabel
            // 
            this.dobavljaciListboxLabel.AutoSize = true;
            this.dobavljaciListboxLabel.Location = new System.Drawing.Point(18, 290);
            this.dobavljaciListboxLabel.Name = "dobavljaciListboxLabel";
            this.dobavljaciListboxLabel.Size = new System.Drawing.Size(91, 20);
            this.dobavljaciListboxLabel.TabIndex = 8;
            this.dobavljaciListboxLabel.Text = "Dobavljači";
            // 
            // dobavljaciListbox
            // 
            this.dobavljaciListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dobavljaciListbox.FormattingEnabled = true;
            this.dobavljaciListbox.ItemHeight = 20;
            this.dobavljaciListbox.Location = new System.Drawing.Point(22, 313);
            this.dobavljaciListbox.Name = "dobavljaciListbox";
            this.dobavljaciListbox.Size = new System.Drawing.Size(353, 164);
            this.dobavljaciListbox.TabIndex = 7;
            // 
            // cijenaPutaLabel
            // 
            this.cijenaPutaLabel.AutoSize = true;
            this.cijenaPutaLabel.Location = new System.Drawing.Point(581, 290);
            this.cijenaPutaLabel.Name = "cijenaPutaLabel";
            this.cijenaPutaLabel.Size = new System.Drawing.Size(105, 20);
            this.cijenaPutaLabel.TabIndex = 9;
            this.cijenaPutaLabel.Text = "Cijena puta:";
            // 
            // cijenaPutaValue
            // 
            this.cijenaPutaValue.AutoSize = true;
            this.cijenaPutaValue.Location = new System.Drawing.Point(735, 290);
            this.cijenaPutaValue.Name = "cijenaPutaValue";
            this.cijenaPutaValue.Size = new System.Drawing.Size(68, 20);
            this.cijenaPutaValue.TabIndex = 10;
            this.cijenaPutaValue.Text = "0.00 kn";
            // 
            // dodajUListu
            // 
            this.dodajUListu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dodajUListu.Location = new System.Drawing.Point(395, 341);
            this.dodajUListu.Name = "dodajUListu";
            this.dodajUListu.Size = new System.Drawing.Size(145, 48);
            this.dodajUListu.TabIndex = 11;
            this.dodajUListu.Text = "Dodaj potrebno";
            this.dodajUListu.UseVisualStyleBackColor = true;
            this.dodajUListu.Click += new System.EventHandler(this.dodajUListu_Click);
            // 
            // BoljiSvijet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 431);
            this.Controls.Add(this.dodajUListu);
            this.Controls.Add(this.cijenaPutaValue);
            this.Controls.Add(this.cijenaPutaLabel);
            this.Controls.Add(this.dobavljaciListboxLabel);
            this.Controls.Add(this.dobavljaciListbox);
            this.Controls.Add(this.ponesiRuksak);
            this.Controls.Add(this.ruksakLabel);
            this.Controls.Add(this.ruksakListBox);
            this.Controls.Add(this.dodajURuksak);
            this.Controls.Add(this.popisPredmetaLabel);
            this.Controls.Add(this.predmetiListbox);
            this.Controls.Add(this.Naslov);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BoljiSvijet";
            this.Text = "Put u Afriku";
            this.Load += new System.EventHandler(this.BoljiSvijet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Naslov;
        private System.Windows.Forms.Button dodajURuksak;
        private System.Windows.Forms.Label ruksakLabel;
        private System.Windows.Forms.ListBox ruksakListBox;
        private System.Windows.Forms.Button ponesiRuksak;
        private System.Windows.Forms.Label dobavljaciListboxLabel;
        private System.Windows.Forms.Label cijenaPutaLabel;
        private System.Windows.Forms.Label cijenaPutaValue;
        private System.Windows.Forms.Button dodajUListu;
        public System.Windows.Forms.Label popisPredmetaLabel;
        public System.Windows.Forms.ListBox predmetiListbox;
        public System.Windows.Forms.ListBox dobavljaciListbox;
    }
}

