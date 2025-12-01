namespace prin_boutique
{
    partial class FrmDemarrage
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
            this.menuStripDemarrage = new System.Windows.Forms.MenuStrip();
            this.categorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lignedecommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlAccueil = new System.Windows.Forms.Panel();
            this.lblAccueil = new System.Windows.Forms.Label();
            this.gestionCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripDemarrage.SuspendLayout();
            this.pnlAccueil.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripDemarrage
            // 
            this.menuStripDemarrage.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripDemarrage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categorieToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.commandeToolStripMenuItem,
            this.fournisseurToolStripMenuItem,
            this.lignedecommandeToolStripMenuItem,
            this.produitToolStripMenuItem,
            this.gestionCommandeToolStripMenuItem});
            this.menuStripDemarrage.Location = new System.Drawing.Point(0, 0);
            this.menuStripDemarrage.Name = "menuStripDemarrage";
            this.menuStripDemarrage.Size = new System.Drawing.Size(1193, 28);
            this.menuStripDemarrage.TabIndex = 0;
            this.menuStripDemarrage.Text = "menuStrip1";
            // 
            // categorieToolStripMenuItem
            // 
            this.categorieToolStripMenuItem.Name = "categorieToolStripMenuItem";
            this.categorieToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.categorieToolStripMenuItem.Text = "&Categorie";
            this.categorieToolStripMenuItem.Click += new System.EventHandler(this.categorieToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.clientToolStripMenuItem.Text = "&Client";
            this.clientToolStripMenuItem.Click += new System.EventHandler(this.clientToolStripMenuItem_Click);
            // 
            // commandeToolStripMenuItem
            // 
            this.commandeToolStripMenuItem.Name = "commandeToolStripMenuItem";
            this.commandeToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.commandeToolStripMenuItem.Text = "&Commande";
            this.commandeToolStripMenuItem.Click += new System.EventHandler(this.commandeToolStripMenuItem_Click);
            // 
            // fournisseurToolStripMenuItem
            // 
            this.fournisseurToolStripMenuItem.Name = "fournisseurToolStripMenuItem";
            this.fournisseurToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.fournisseurToolStripMenuItem.Text = "&Fournisseur";
            this.fournisseurToolStripMenuItem.Click += new System.EventHandler(this.fournisseurToolStripMenuItem_Click);
            // 
            // lignedecommandeToolStripMenuItem
            // 
            this.lignedecommandeToolStripMenuItem.Name = "lignedecommandeToolStripMenuItem";
            this.lignedecommandeToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.lignedecommandeToolStripMenuItem.Text = "&Lignedecommande";
            this.lignedecommandeToolStripMenuItem.Click += new System.EventHandler(this.lignedecommandeToolStripMenuItem_Click);
            // 
            // produitToolStripMenuItem
            // 
            this.produitToolStripMenuItem.Name = "produitToolStripMenuItem";
            this.produitToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.produitToolStripMenuItem.Text = "&Produit";
            this.produitToolStripMenuItem.Click += new System.EventHandler(this.produitToolStripMenuItem_Click);
            // 
            // pnlAccueil
            // 
            this.pnlAccueil.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlAccueil.Controls.Add(this.lblAccueil);
            this.pnlAccueil.Location = new System.Drawing.Point(-9, 30);
            this.pnlAccueil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlAccueil.Name = "pnlAccueil";
            this.pnlAccueil.Size = new System.Drawing.Size(1213, 96);
            this.pnlAccueil.TabIndex = 1;
            this.pnlAccueil.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlAccueil_Paint);
            // 
            // lblAccueil
            // 
            this.lblAccueil.AutoSize = true;
            this.lblAccueil.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccueil.ForeColor = System.Drawing.Color.White;
            this.lblAccueil.Location = new System.Drawing.Point(513, 17);
            this.lblAccueil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccueil.Name = "lblAccueil";
            this.lblAccueil.Size = new System.Drawing.Size(181, 54);
            this.lblAccueil.TabIndex = 2;
            this.lblAccueil.Text = "Accueil";
            // 
            // gestionCommandeToolStripMenuItem
            // 
            this.gestionCommandeToolStripMenuItem.Name = "gestionCommandeToolStripMenuItem";
            this.gestionCommandeToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.gestionCommandeToolStripMenuItem.Text = "Gestion Commande";
            this.gestionCommandeToolStripMenuItem.Click += new System.EventHandler(this.gestionCommandeToolStripMenuItem_Click);
            // 
            // FrmDemarrage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1193, 636);
            this.Controls.Add(this.pnlAccueil);
            this.Controls.Add(this.menuStripDemarrage);
            this.MainMenuStrip = this.menuStripDemarrage;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmDemarrage";
            this.Text = "Acceuil";
            this.menuStripDemarrage.ResumeLayout(false);
            this.menuStripDemarrage.PerformLayout();
            this.pnlAccueil.ResumeLayout(false);
            this.pnlAccueil.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripDemarrage;
        private System.Windows.Forms.ToolStripMenuItem categorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lignedecommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitToolStripMenuItem;
        private System.Windows.Forms.Panel pnlAccueil;
        private System.Windows.Forms.Label lblAccueil;
        private System.Windows.Forms.ToolStripMenuItem gestionCommandeToolStripMenuItem;
    }
}