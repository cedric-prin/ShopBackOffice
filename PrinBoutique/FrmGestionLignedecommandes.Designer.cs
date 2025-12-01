namespace prin_boutique
{
    partial class FrmGestionLignedecommandes
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
            this.menuStripLignedecommandes = new System.Windows.Forms.MenuStrip();
            this.categorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lignedecommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLignedecommande = new System.Windows.Forms.Panel();
            this.lblLignedecommande = new System.Windows.Forms.Label();
            this.lblRechecherLigneCommande = new System.Windows.Forms.Label();
            this.txtBoxRechercherLigneCommande = new System.Windows.Forms.TextBox();
            this.lblSousTotal = new System.Windows.Forms.Label();
            this.lblPrixUnitaire = new System.Windows.Forms.Label();
            this.lblIdProduit = new System.Windows.Forms.Label();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.lblIdCommande = new System.Windows.Forms.Label();
            this.txtBoxSousTotal = new System.Windows.Forms.TextBox();
            this.txtBoxPrixUnitaire = new System.Windows.Forms.TextBox();
            this.txtBoxIdProduit = new System.Windows.Forms.TextBox();
            this.txtBoxQuantite = new System.Windows.Forms.TextBox();
            this.txtBoxIdCommande = new System.Windows.Forms.TextBox();
            this.btnSupprimerLigneCommande = new System.Windows.Forms.Button();
            this.btnModifierLigneCommande = new System.Windows.Forms.Button();
            this.btnAjouterLigneCommande = new System.Windows.Forms.Button();
            this.dgvLigneCommande = new System.Windows.Forms.DataGridView();
            this.menuStripLignedecommandes.SuspendLayout();
            this.pnlLignedecommande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLigneCommande)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripLignedecommandes
            // 
            this.menuStripLignedecommandes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripLignedecommandes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categorieToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.commandeToolStripMenuItem,
            this.fournisseurToolStripMenuItem,
            this.lignedecommandeToolStripMenuItem,
            this.produitToolStripMenuItem,
            this.gestionCommandeToolStripMenuItem});
            this.menuStripLignedecommandes.Location = new System.Drawing.Point(0, 0);
            this.menuStripLignedecommandes.Name = "menuStripLignedecommandes";
            this.menuStripLignedecommandes.Size = new System.Drawing.Size(883, 28);
            this.menuStripLignedecommandes.TabIndex = 0;
            this.menuStripLignedecommandes.Text = "menuStrip1";
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
            this.lignedecommandeToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.lignedecommandeToolStripMenuItem.Name = "lignedecommandeToolStripMenuItem";
            this.lignedecommandeToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.lignedecommandeToolStripMenuItem.Text = "&Lignedecommande";
            // 
            // produitToolStripMenuItem
            // 
            this.produitToolStripMenuItem.Name = "produitToolStripMenuItem";
            this.produitToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.produitToolStripMenuItem.Text = "&Produit";
            this.produitToolStripMenuItem.Click += new System.EventHandler(this.produitToolStripMenuItem_Click);
            // 
            // gestionCommandeToolStripMenuItem
            // 
            this.gestionCommandeToolStripMenuItem.Name = "gestionCommandeToolStripMenuItem";
            this.gestionCommandeToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.gestionCommandeToolStripMenuItem.Text = "Gestion Commande";
            this.gestionCommandeToolStripMenuItem.Click += new System.EventHandler(this.gestionCommandeToolStripMenuItem_Click);
            // 
            // pnlLignedecommande
            // 
            this.pnlLignedecommande.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlLignedecommande.Controls.Add(this.lblLignedecommande);
            this.pnlLignedecommande.Location = new System.Drawing.Point(-12, 30);
            this.pnlLignedecommande.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLignedecommande.Name = "pnlLignedecommande";
            this.pnlLignedecommande.Size = new System.Drawing.Size(1212, 95);
            this.pnlLignedecommande.TabIndex = 1;
            // 
            // lblLignedecommande
            // 
            this.lblLignedecommande.AutoSize = true;
            this.lblLignedecommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLignedecommande.ForeColor = System.Drawing.Color.White;
            this.lblLignedecommande.Location = new System.Drawing.Point(122, 21);
            this.lblLignedecommande.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLignedecommande.Name = "lblLignedecommande";
            this.lblLignedecommande.Size = new System.Drawing.Size(629, 54);
            this.lblLignedecommande.TabIndex = 0;
            this.lblLignedecommande.Text = "Gestion Ligne de Commande";
            // 
            // lblRechecherLigneCommande
            // 
            this.lblRechecherLigneCommande.AutoSize = true;
            this.lblRechecherLigneCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechecherLigneCommande.ForeColor = System.Drawing.Color.White;
            this.lblRechecherLigneCommande.Location = new System.Drawing.Point(453, 533);
            this.lblRechecherLigneCommande.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRechecherLigneCommande.Name = "lblRechecherLigneCommande";
            this.lblRechecherLigneCommande.Size = new System.Drawing.Size(96, 17);
            this.lblRechecherLigneCommande.TabIndex = 43;
            this.lblRechecherLigneCommande.Text = "Recherche :";
            // 
            // txtBoxRechercherLigneCommande
            // 
            this.txtBoxRechercherLigneCommande.Location = new System.Drawing.Point(457, 565);
            this.txtBoxRechercherLigneCommande.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxRechercherLigneCommande.Name = "txtBoxRechercherLigneCommande";
            this.txtBoxRechercherLigneCommande.Size = new System.Drawing.Size(224, 22);
            this.txtBoxRechercherLigneCommande.TabIndex = 42;
            this.txtBoxRechercherLigneCommande.TextChanged += new System.EventHandler(this.txtBoxRechercherLigneCommande_TextChanged);
            // 
            // lblSousTotal
            // 
            this.lblSousTotal.AutoSize = true;
            this.lblSousTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSousTotal.ForeColor = System.Drawing.Color.White;
            this.lblSousTotal.Location = new System.Drawing.Point(453, 439);
            this.lblSousTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSousTotal.Name = "lblSousTotal";
            this.lblSousTotal.Size = new System.Drawing.Size(96, 17);
            this.lblSousTotal.TabIndex = 40;
            this.lblSousTotal.Text = "Sous Total :";
            // 
            // lblPrixUnitaire
            // 
            this.lblPrixUnitaire.AutoSize = true;
            this.lblPrixUnitaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrixUnitaire.ForeColor = System.Drawing.Color.White;
            this.lblPrixUnitaire.Location = new System.Drawing.Point(240, 533);
            this.lblPrixUnitaire.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrixUnitaire.Name = "lblPrixUnitaire";
            this.lblPrixUnitaire.Size = new System.Drawing.Size(107, 17);
            this.lblPrixUnitaire.TabIndex = 38;
            this.lblPrixUnitaire.Text = "Prix Unitaire :";
            // 
            // lblIdProduit
            // 
            this.lblIdProduit.AutoSize = true;
            this.lblIdProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdProduit.ForeColor = System.Drawing.Color.White;
            this.lblIdProduit.Location = new System.Drawing.Point(24, 533);
            this.lblIdProduit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdProduit.Name = "lblIdProduit";
            this.lblIdProduit.Size = new System.Drawing.Size(83, 17);
            this.lblIdProduit.TabIndex = 37;
            this.lblIdProduit.Text = "IdProduit :";
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantite.ForeColor = System.Drawing.Color.White;
            this.lblQuantite.Location = new System.Drawing.Point(240, 443);
            this.lblQuantite.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(80, 17);
            this.lblQuantite.TabIndex = 36;
            this.lblQuantite.Text = "Quantite :";
            // 
            // lblIdCommande
            // 
            this.lblIdCommande.AutoSize = true;
            this.lblIdCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCommande.ForeColor = System.Drawing.Color.White;
            this.lblIdCommande.Location = new System.Drawing.Point(24, 438);
            this.lblIdCommande.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdCommande.Name = "lblIdCommande";
            this.lblIdCommande.Size = new System.Drawing.Size(110, 17);
            this.lblIdCommande.TabIndex = 35;
            this.lblIdCommande.Text = "IdCommande :";
            // 
            // txtBoxSousTotal
            // 
            this.txtBoxSousTotal.Location = new System.Drawing.Point(457, 471);
            this.txtBoxSousTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSousTotal.Name = "txtBoxSousTotal";
            this.txtBoxSousTotal.Size = new System.Drawing.Size(132, 22);
            this.txtBoxSousTotal.TabIndex = 33;
            // 
            // txtBoxPrixUnitaire
            // 
            this.txtBoxPrixUnitaire.Location = new System.Drawing.Point(244, 565);
            this.txtBoxPrixUnitaire.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPrixUnitaire.Name = "txtBoxPrixUnitaire";
            this.txtBoxPrixUnitaire.Size = new System.Drawing.Size(132, 22);
            this.txtBoxPrixUnitaire.TabIndex = 31;
            // 
            // txtBoxIdProduit
            // 
            this.txtBoxIdProduit.Location = new System.Drawing.Point(28, 565);
            this.txtBoxIdProduit.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxIdProduit.Name = "txtBoxIdProduit";
            this.txtBoxIdProduit.Size = new System.Drawing.Size(132, 22);
            this.txtBoxIdProduit.TabIndex = 30;
            // 
            // txtBoxQuantite
            // 
            this.txtBoxQuantite.Location = new System.Drawing.Point(244, 471);
            this.txtBoxQuantite.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxQuantite.Name = "txtBoxQuantite";
            this.txtBoxQuantite.Size = new System.Drawing.Size(132, 22);
            this.txtBoxQuantite.TabIndex = 29;
            // 
            // txtBoxIdCommande
            // 
            this.txtBoxIdCommande.Location = new System.Drawing.Point(28, 471);
            this.txtBoxIdCommande.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxIdCommande.Name = "txtBoxIdCommande";
            this.txtBoxIdCommande.Size = new System.Drawing.Size(132, 22);
            this.txtBoxIdCommande.TabIndex = 28;
            // 
            // btnSupprimerLigneCommande
            // 
            this.btnSupprimerLigneCommande.BackColor = System.Drawing.Color.Red;
            this.btnSupprimerLigneCommande.Location = new System.Drawing.Point(732, 553);
            this.btnSupprimerLigneCommande.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimerLigneCommande.Name = "btnSupprimerLigneCommande";
            this.btnSupprimerLigneCommande.Size = new System.Drawing.Size(139, 44);
            this.btnSupprimerLigneCommande.TabIndex = 27;
            this.btnSupprimerLigneCommande.Text = "Supprimer";
            this.btnSupprimerLigneCommande.UseVisualStyleBackColor = false;
            this.btnSupprimerLigneCommande.Click += new System.EventHandler(this.btnSupprimerLigneCommande_Click);
            // 
            // btnModifierLigneCommande
            // 
            this.btnModifierLigneCommande.BackColor = System.Drawing.Color.Silver;
            this.btnModifierLigneCommande.Location = new System.Drawing.Point(732, 489);
            this.btnModifierLigneCommande.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifierLigneCommande.Name = "btnModifierLigneCommande";
            this.btnModifierLigneCommande.Size = new System.Drawing.Size(139, 44);
            this.btnModifierLigneCommande.TabIndex = 26;
            this.btnModifierLigneCommande.Text = "Modifier";
            this.btnModifierLigneCommande.UseVisualStyleBackColor = false;
            this.btnModifierLigneCommande.Click += new System.EventHandler(this.btnModifierLigneCommande_Click);
            // 
            // btnAjouterLigneCommande
            // 
            this.btnAjouterLigneCommande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAjouterLigneCommande.ForeColor = System.Drawing.Color.Black;
            this.btnAjouterLigneCommande.Location = new System.Drawing.Point(732, 421);
            this.btnAjouterLigneCommande.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouterLigneCommande.Name = "btnAjouterLigneCommande";
            this.btnAjouterLigneCommande.Size = new System.Drawing.Size(139, 44);
            this.btnAjouterLigneCommande.TabIndex = 25;
            this.btnAjouterLigneCommande.Text = "Ajouter";
            this.btnAjouterLigneCommande.UseVisualStyleBackColor = false;
            this.btnAjouterLigneCommande.Click += new System.EventHandler(this.btnAjouterLigneCommande_Click);
            // 
            // dgvLigneCommande
            // 
            this.dgvLigneCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLigneCommande.Location = new System.Drawing.Point(13, 133);
            this.dgvLigneCommande.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLigneCommande.Name = "dgvLigneCommande";
            this.dgvLigneCommande.RowHeadersWidth = 51;
            this.dgvLigneCommande.Size = new System.Drawing.Size(858, 271);
            this.dgvLigneCommande.TabIndex = 24;
            this.dgvLigneCommande.CurrentCellChanged += new System.EventHandler(this.dgvLigneCommande_CurrentCellChanged);
            // 
            // FrmGestionLignedecommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(883, 613);
            this.Controls.Add(this.lblRechecherLigneCommande);
            this.Controls.Add(this.txtBoxRechercherLigneCommande);
            this.Controls.Add(this.lblSousTotal);
            this.Controls.Add(this.lblPrixUnitaire);
            this.Controls.Add(this.lblIdProduit);
            this.Controls.Add(this.lblQuantite);
            this.Controls.Add(this.lblIdCommande);
            this.Controls.Add(this.txtBoxSousTotal);
            this.Controls.Add(this.txtBoxPrixUnitaire);
            this.Controls.Add(this.txtBoxIdProduit);
            this.Controls.Add(this.txtBoxQuantite);
            this.Controls.Add(this.txtBoxIdCommande);
            this.Controls.Add(this.btnSupprimerLigneCommande);
            this.Controls.Add(this.btnModifierLigneCommande);
            this.Controls.Add(this.btnAjouterLigneCommande);
            this.Controls.Add(this.dgvLigneCommande);
            this.Controls.Add(this.pnlLignedecommande);
            this.Controls.Add(this.menuStripLignedecommandes);
            this.MainMenuStrip = this.menuStripLignedecommandes;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGestionLignedecommandes";
            this.Text = "Gestion de Ligne de commandes ...";
            this.Load += new System.EventHandler(this.FrmGestionLignedecommandes_Load);
            this.menuStripLignedecommandes.ResumeLayout(false);
            this.menuStripLignedecommandes.PerformLayout();
            this.pnlLignedecommande.ResumeLayout(false);
            this.pnlLignedecommande.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLigneCommande)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripLignedecommandes;
        private System.Windows.Forms.ToolStripMenuItem categorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lignedecommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitToolStripMenuItem;
        private System.Windows.Forms.Panel pnlLignedecommande;
        private System.Windows.Forms.Label lblLignedecommande;
        private System.Windows.Forms.ToolStripMenuItem gestionCommandeToolStripMenuItem;
        private System.Windows.Forms.Label lblRechecherLigneCommande;
        private System.Windows.Forms.TextBox txtBoxRechercherLigneCommande;
        private System.Windows.Forms.Label lblSousTotal;
        private System.Windows.Forms.Label lblPrixUnitaire;
        private System.Windows.Forms.Label lblIdProduit;
        private System.Windows.Forms.Label lblQuantite;
        private System.Windows.Forms.Label lblIdCommande;
        private System.Windows.Forms.TextBox txtBoxSousTotal;
        private System.Windows.Forms.TextBox txtBoxPrixUnitaire;
        private System.Windows.Forms.TextBox txtBoxIdProduit;
        private System.Windows.Forms.TextBox txtBoxQuantite;
        private System.Windows.Forms.TextBox txtBoxIdCommande;
        private System.Windows.Forms.Button btnSupprimerLigneCommande;
        private System.Windows.Forms.Button btnModifierLigneCommande;
        private System.Windows.Forms.Button btnAjouterLigneCommande;
        private System.Windows.Forms.DataGridView dgvLigneCommande;
    }
}