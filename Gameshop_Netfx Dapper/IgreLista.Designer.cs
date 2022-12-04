namespace Gameshop_Netfx_Dapper
{
    partial class IgreLista
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbNovi = new System.Windows.Forms.ToolStripButton();
            this.tsbUredi = new System.Windows.Forms.ToolStripButton();
            this.tsbObrisi = new System.Windows.Forms.ToolStripButton();
            this.dgvIgre = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgre)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNovi,
            this.tsbUredi,
            this.tsbObrisi});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(955, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbNovi
            // 
            this.tsbNovi.Image = global::Gameshop_Netfx_Dapper.Properties.Resources.novi;
            this.tsbNovi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNovi.Name = "tsbNovi";
            this.tsbNovi.Size = new System.Drawing.Size(64, 28);
            this.tsbNovi.Text = "Novi";
            this.tsbNovi.Click += new System.EventHandler(this.tsbNovi_Click);
            // 
            // tsbUredi
            // 
            this.tsbUredi.Image = global::Gameshop_Netfx_Dapper.Properties.Resources.edit;
            this.tsbUredi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUredi.Name = "tsbUredi";
            this.tsbUredi.Size = new System.Drawing.Size(69, 28);
            this.tsbUredi.Text = "Uredi";
            this.tsbUredi.Click += new System.EventHandler(this.tsbUredi_Click);
            // 
            // tsbObrisi
            // 
            this.tsbObrisi.Image = global::Gameshop_Netfx_Dapper.Properties.Resources.delete;
            this.tsbObrisi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbObrisi.Name = "tsbObrisi";
            this.tsbObrisi.Size = new System.Drawing.Size(72, 28);
            this.tsbObrisi.Text = "Obriši";
            this.tsbObrisi.Click += new System.EventHandler(this.tsbObrisi_Click);
            // 
            // dgvIgre
            // 
            this.dgvIgre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvIgre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIgre.Location = new System.Drawing.Point(12, 30);
            this.dgvIgre.Name = "dgvIgre";
            this.dgvIgre.RowHeadersWidth = 51;
            this.dgvIgre.RowTemplate.Height = 24;
            this.dgvIgre.Size = new System.Drawing.Size(931, 483);
            this.dgvIgre.TabIndex = 1;
            // 
            // IgreLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 525);
            this.Controls.Add(this.dgvIgre);
            this.Controls.Add(this.toolStrip1);
            this.Name = "IgreLista";
            this.Text = "Unos igara";
            this.Load += new System.EventHandler(this.IgreLista_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIgre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNovi;
        private System.Windows.Forms.ToolStripButton tsbUredi;
        private System.Windows.Forms.ToolStripButton tsbObrisi;
        private System.Windows.Forms.DataGridView dgvIgre;
    }
}