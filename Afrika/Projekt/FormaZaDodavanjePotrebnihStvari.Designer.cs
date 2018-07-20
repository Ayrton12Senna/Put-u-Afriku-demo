namespace Projekt
{
    partial class FormaZaDodavanjePotrebnihStvari
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
            this.components = new System.ComponentModel.Container();
            this.odaberiStoZelisDodatiComboBox = new System.Windows.Forms.ComboBox();
            this.popisPredmetaLabel = new System.Windows.Forms.Label();
            this.cijenaLabel = new System.Windows.Forms.Label();
            this.kolicinaTextbox = new System.Windows.Forms.TextBox();
            this.gumbZaDodavanjePredmeta = new System.Windows.Forms.Button();
            this.unesiStoTiJePotrebnoTextbox = new System.Windows.Forms.TextBox();
            this.bazaProjektaDataSet1 = new Projekt.BazaProjektaDataSet();
            this.predmetiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.predmetiTableAdapter = new Projekt.BazaProjektaDataSetTableAdapters.PredmetiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bazaProjektaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // odaberiStoZelisDodatiComboBox
            // 
            this.odaberiStoZelisDodatiComboBox.FormattingEnabled = true;
            this.odaberiStoZelisDodatiComboBox.Location = new System.Drawing.Point(12, 15);
            this.odaberiStoZelisDodatiComboBox.Name = "odaberiStoZelisDodatiComboBox";
            this.odaberiStoZelisDodatiComboBox.Size = new System.Drawing.Size(121, 21);
            this.odaberiStoZelisDodatiComboBox.TabIndex = 0;
            this.odaberiStoZelisDodatiComboBox.SelectedIndexChanged += new System.EventHandler(this.odaberiStoZelisDodatiComboBox_SelectedIndexChanged);
            // 
            // popisPredmetaLabel
            // 
            this.popisPredmetaLabel.AutoSize = true;
            this.popisPredmetaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.popisPredmetaLabel.Location = new System.Drawing.Point(8, 79);
            this.popisPredmetaLabel.Name = "popisPredmetaLabel";
            this.popisPredmetaLabel.Size = new System.Drawing.Size(14, 20);
            this.popisPredmetaLabel.TabIndex = 4;
            this.popisPredmetaLabel.Text = " ";
            // 
            // cijenaLabel
            // 
            this.cijenaLabel.AutoSize = true;
            this.cijenaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.cijenaLabel.Location = new System.Drawing.Point(8, 110);
            this.cijenaLabel.Name = "cijenaLabel";
            this.cijenaLabel.Size = new System.Drawing.Size(59, 20);
            this.cijenaLabel.TabIndex = 5;
            this.cijenaLabel.Text = "Cijena";
            this.cijenaLabel.Visible = false;
            // 
            // kolicinaTextbox
            // 
            this.kolicinaTextbox.Location = new System.Drawing.Point(94, 112);
            this.kolicinaTextbox.Name = "kolicinaTextbox";
            this.kolicinaTextbox.Size = new System.Drawing.Size(60, 20);
            this.kolicinaTextbox.TabIndex = 6;
            this.kolicinaTextbox.Visible = false;
            // 
            // gumbZaDodavanjePredmeta
            // 
            this.gumbZaDodavanjePredmeta.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.gumbZaDodavanjePredmeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.gumbZaDodavanjePredmeta.Location = new System.Drawing.Point(12, 151);
            this.gumbZaDodavanjePredmeta.Name = "gumbZaDodavanjePredmeta";
            this.gumbZaDodavanjePredmeta.Size = new System.Drawing.Size(117, 28);
            this.gumbZaDodavanjePredmeta.TabIndex = 7;
            this.gumbZaDodavanjePredmeta.Text = "Dodaj";
            this.gumbZaDodavanjePredmeta.UseVisualStyleBackColor = true;
            this.gumbZaDodavanjePredmeta.Click += new System.EventHandler(this.gumbZaDodavanjePredmeta_Click);
            // 
            // unesiStoTiJePotrebnoTextbox
            // 
            this.unesiStoTiJePotrebnoTextbox.Location = new System.Drawing.Point(94, 81);
            this.unesiStoTiJePotrebnoTextbox.Name = "unesiStoTiJePotrebnoTextbox";
            this.unesiStoTiJePotrebnoTextbox.Size = new System.Drawing.Size(60, 20);
            this.unesiStoTiJePotrebnoTextbox.TabIndex = 8;
            // 
            // bazaProjektaDataSet1
            // 
            this.bazaProjektaDataSet1.DataSetName = "BazaProjektaDataSet";
            this.bazaProjektaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // predmetiBindingSource
            // 
            this.predmetiBindingSource.DataMember = "Predmeti";
            this.predmetiBindingSource.DataSource = this.bazaProjektaDataSet1;
            // 
            // predmetiTableAdapter
            // 
            this.predmetiTableAdapter.ClearBeforeFill = true;
            // 
            // FormaZaDodavanjePotrebnihStvari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.unesiStoTiJePotrebnoTextbox);
            this.Controls.Add(this.gumbZaDodavanjePredmeta);
            this.Controls.Add(this.kolicinaTextbox);
            this.Controls.Add(this.cijenaLabel);
            this.Controls.Add(this.popisPredmetaLabel);
            this.Controls.Add(this.odaberiStoZelisDodatiComboBox);
            this.Name = "FormaZaDodavanjePotrebnihStvari";
            this.Text = "Dodaj što ti je potrebno";
            this.Load += new System.EventHandler(this.FormaZaDodavanjePotrebnihStvari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bazaProjektaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.predmetiBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox odaberiStoZelisDodatiComboBox;
        private System.Windows.Forms.Label popisPredmetaLabel;
        private System.Windows.Forms.Label cijenaLabel;
        private System.Windows.Forms.TextBox kolicinaTextbox;
        private System.Windows.Forms.Button gumbZaDodavanjePredmeta;
        private System.Windows.Forms.TextBox unesiStoTiJePotrebnoTextbox;
        private System.Windows.Forms.ListBox listBox1;
        private BazaProjektaDataSet bazaProjektaDataSet;
        private System.Windows.Forms.BindingSource bazaProjektaDataSetBindingSource;
        private BazaProjektaDataSet bazaProjektaDataSet1;
        private System.Windows.Forms.BindingSource predmetiBindingSource;
        private BazaProjektaDataSetTableAdapters.PredmetiTableAdapter predmetiTableAdapter;
    }
}