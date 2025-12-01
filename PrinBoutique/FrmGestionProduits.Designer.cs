namespace prin_boutique
{
    partial class FrmGestionProduits
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
            this.menuStripProduits = new System.Windows.Forms.MenuStrip();
            this.categorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lignedecommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlProduit = new System.Windows.Forms.Panel();
            this.lblProduit = new System.Windows.Forms.Label();
            this.lblidCategorie = new System.Windows.Forms.Label();
            this.lblidFournisseur = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.lblPrix = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblNomProduit = new System.Windows.Forms.Label();
            this.txtBoxidCategorie = new System.Windows.Forms.TextBox();
            this.txtBoxidFournisseur = new System.Windows.Forms.TextBox();
            this.txtBoxImage = new System.Windows.Forms.TextBox();
            this.txtBoxPrix = new System.Windows.Forms.TextBox();
            this.txtBoxDescription = new System.Windows.Forms.TextBox();
            this.txtBoxNomProduit = new System.Windows.Forms.TextBox();
            this.btnSupprimerProduits = new System.Windows.Forms.Button();
            this.btnModifierProduits = new System.Windows.Forms.Button();
            this.btnAjouterProduits = new System.Windows.Forms.Button();
            this.dgvListeProduits = new System.Windows.Forms.DataGridView();
            this.txtBoxRechercherProduit = new System.Windows.Forms.TextBox();
            this.lblRechercherProduit = new System.Windows.Forms.Label();
            this.menuStripProduits.SuspendLayout();
            this.pnlProduit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeProduits)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripProduits
            // 
            this.menuStripProduits.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripProduits.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categorieToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.commandeToolStripMenuItem,
            this.fournisseurToolStripMenuItem,
            this.lignedecommandeToolStripMenuItem,
            this.produitToolStripMenuItem,
            this.gestionCommandeToolStripMenuItem});
            this.menuStripProduits.Location = new System.Drawing.Point(0, 0);
            this.menuStripProduits.Name = "menuStripProduits";
            this.menuStripProduits.Size = new System.Drawing.Size(1065, 28);
            this.menuStripProduits.TabIndex = 0;
            this.menuStripProduits.Text = "menuStrip1";
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
            this.produitToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.produitToolStripMenuItem.Name = "produitToolStripMenuItem";
            this.produitToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.produitToolStripMenuItem.Text = "&Produit";
            // 
            // gestionCommandeToolStripMenuItem
            // 
            this.gestionCommandeToolStripMenuItem.Name = "gestionCommandeToolStripMenuItem";
            this.gestionCommandeToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.gestionCommandeToolStripMenuItem.Text = "Gestion Commande";
            this.gestionCommandeToolStripMenuItem.Click += new System.EventHandler(this.gestionCommandeToolStripMenuItem_Click);
            // 
            // pnlProduit
            // 
            this.pnlProduit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlProduit.Controls.Add(this.lblProduit);
            this.pnlProduit.Location = new System.Drawing.Point(-11, 30);
            this.pnlProduit.Margin = new System.Windows.Forms.Padding(4);
            this.pnlProduit.Name = "pnlProduit";
            this.pnlProduit.Size = new System.Drawing.Size(1087, 85);
            this.pnlProduit.TabIndex = 1;
            // 
            // lblProduit
            // 
            this.lblProduit.AutoSize = true;
            this.lblProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduit.ForeColor = System.Drawing.Color.White;
            this.lblProduit.Location = new System.Drawing.Point(437, 15);
            this.lblProduit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProduit.Name = "lblProduit";
            this.lblProduit.Size = new System.Drawing.Size(178, 54);
            this.lblProduit.TabIndex = 0;
            this.lblProduit.Text = "Produit";
            // 
            // lblidCategorie
            // 
            this.lblidCategorie.AutoSize = true;
            this.lblidCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidCategorie.ForeColor = System.Drawing.Color.White;
            this.lblidCategorie.Location = new System.Drawing.Point(456, 447);
            this.lblidCategorie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblidCategorie.Name = "lblidCategorie";
            this.lblidCategorie.Size = new System.Drawing.Size(101, 17);
            this.lblidCategorie.TabIndex = 36;
            this.lblidCategorie.Text = "idCategorie :";
            // 
            // lblidFournisseur
            // 
            this.lblidFournisseur.AutoSize = true;
            this.lblidFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblidFournisseur.ForeColor = System.Drawing.Color.White;
            this.lblidFournisseur.Location = new System.Drawing.Point(456, 537);
            this.lblidFournisseur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblidFournisseur.Name = "lblidFournisseur";
            this.lblidFournisseur.Size = new System.Drawing.Size(117, 17);
            this.lblidFournisseur.TabIndex = 35;
            this.lblidFournisseur.Text = "idFournisseur :";
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImage.ForeColor = System.Drawing.Color.White;
            this.lblImage.Location = new System.Drawing.Point(243, 537);
            this.lblImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(61, 17);
            this.lblImage.TabIndex = 34;
            this.lblImage.Text = "Image :";
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrix.ForeColor = System.Drawing.Color.White;
            this.lblPrix.Location = new System.Drawing.Point(27, 537);
            this.lblPrix.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(45, 17);
            this.lblPrix.TabIndex = 33;
            this.lblPrix.Text = "Prix :";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.White;
            this.lblDescription.Location = new System.Drawing.Point(243, 447);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 17);
            this.lblDescription.TabIndex = 32;
            this.lblDescription.Text = "Description :";
            // 
            // lblNomProduit
            // 
            this.lblNomProduit.AutoSize = true;
            this.lblNomProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomProduit.ForeColor = System.Drawing.Color.White;
            this.lblNomProduit.Location = new System.Drawing.Point(27, 442);
            this.lblNomProduit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomProduit.Name = "lblNomProduit";
            this.lblNomProduit.Size = new System.Drawing.Size(50, 17);
            this.lblNomProduit.TabIndex = 31;
            this.lblNomProduit.Text = "Nom :";
            // 
            // txtBoxidCategorie
            // 
            this.txtBoxidCategorie.Location = new System.Drawing.Point(460, 475);
            this.txtBoxidCategorie.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxidCategorie.Name = "txtBoxidCategorie";
            this.txtBoxidCategorie.Size = new System.Drawing.Size(132, 22);
            this.txtBoxidCategorie.TabIndex = 29;
            // 
            // txtBoxidFournisseur
            // 
            this.txtBoxidFournisseur.Location = new System.Drawing.Point(460, 569);
            this.txtBoxidFournisseur.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxidFournisseur.Name = "txtBoxidFournisseur";
            this.txtBoxidFournisseur.Size = new System.Drawing.Size(132, 22);
            this.txtBoxidFournisseur.TabIndex = 28;
            // 
            // txtBoxImage
            // 
            this.txtBoxImage.Location = new System.Drawing.Point(247, 569);
            this.txtBoxImage.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxImage.Name = "txtBoxImage";
            this.txtBoxImage.Size = new System.Drawing.Size(132, 22);
            this.txtBoxImage.TabIndex = 27;
            // 
            // txtBoxPrix
            // 
            this.txtBoxPrix.Location = new System.Drawing.Point(31, 569);
            this.txtBoxPrix.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPrix.Name = "txtBoxPrix";
            this.txtBoxPrix.Size = new System.Drawing.Size(132, 22);
            this.txtBoxPrix.TabIndex = 26;
            // 
            // txtBoxDescription
            // 
            this.txtBoxDescription.Location = new System.Drawing.Point(247, 475);
            this.txtBoxDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxDescription.Name = "txtBoxDescription";
            this.txtBoxDescription.Size = new System.Drawing.Size(132, 22);
            this.txtBoxDescription.TabIndex = 25;
            // 
            // txtBoxNomProduit
            // 
            this.txtBoxNomProduit.Location = new System.Drawing.Point(31, 475);
            this.txtBoxNomProduit.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxNomProduit.Name = "txtBoxNomProduit";
            this.txtBoxNomProduit.Size = new System.Drawing.Size(132, 22);
            this.txtBoxNomProduit.TabIndex = 24;
            // 
            // btnSupprimerProduits
            // 
            this.btnSupprimerProduits.BackColor = System.Drawing.Color.Red;
            this.btnSupprimerProduits.Location = new System.Drawing.Point(896, 549);
            this.btnSupprimerProduits.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimerProduits.Name = "btnSupprimerProduits";
            this.btnSupprimerProduits.Size = new System.Drawing.Size(139, 44);
            this.btnSupprimerProduits.TabIndex = 23;
            this.btnSupprimerProduits.Text = "Supprimer";
            this.btnSupprimerProduits.UseVisualStyleBackColor = false;
            this.btnSupprimerProduits.Click += new System.EventHandler(this.btnSupprimerProduits_Click);
            // 
            // btnModifierProduits
            // 
            this.btnModifierProduits.BackColor = System.Drawing.Color.Silver;
            this.btnModifierProduits.Location = new System.Drawing.Point(896, 489);
            this.btnModifierProduits.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifierProduits.Name = "btnModifierProduits";
            this.btnModifierProduits.Size = new System.Drawing.Size(139, 44);
            this.btnModifierProduits.TabIndex = 22;
            this.btnModifierProduits.Text = "Modifier";
            this.btnModifierProduits.UseVisualStyleBackColor = false;
            this.btnModifierProduits.Click += new System.EventHandler(this.btnModifierProduits_Click);
            // 
            // btnAjouterProduits
            // 
            this.btnAjouterProduits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAjouterProduits.ForeColor = System.Drawing.Color.Black;
            this.btnAjouterProduits.Location = new System.Drawing.Point(896, 427);
            this.btnAjouterProduits.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouterProduits.Name = "btnAjouterProduits";
            this.btnAjouterProduits.Size = new System.Drawing.Size(139, 44);
            this.btnAjouterProduits.TabIndex = 21;
            this.btnAjouterProduits.Text = "Ajouter";
            this.btnAjouterProduits.UseVisualStyleBackColor = false;
            this.btnAjouterProduits.Click += new System.EventHandler(this.btnAjouterProduits_Click);
            // 
            // dgvListeProduits
            // 
            this.dgvListeProduits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeProduits.Location = new System.Drawing.Point(16, 137);
            this.dgvListeProduits.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListeProduits.Name = "dgvListeProduits";
            this.dgvListeProduits.RowHeadersWidth = 51;
            this.dgvListeProduits.Size = new System.Drawing.Size(1033, 271);
            this.dgvListeProduits.TabIndex = 20;
            this.dgvListeProduits.CurrentCellChanged += new System.EventHandler(this.dgvListeProduits_CurrentCellChanged);
            // 
            // txtBoxRechercherProduit
            // 
            this.txtBoxRechercherProduit.Location = new System.Drawing.Point(648, 475);
            this.txtBoxRechercherProduit.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxRechercherProduit.Name = "txtBoxRechercherProduit";
            this.txtBoxRechercherProduit.Size = new System.Drawing.Size(204, 22);
            this.txtBoxRechercherProduit.TabIndex = 37;
            this.txtBoxRechercherProduit.TextChanged += new System.EventHandler(this.txtBoxRechercherProduit_TextChanged);
            // 
            // lblRechercherProduit
            // 
            this.lblRechercherProduit.AutoSize = true;
            this.lblRechercherProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechercherProduit.ForeColor = System.Drawing.Color.White;
            this.lblRechercherProduit.Location = new System.Drawing.Point(644, 447);
            this.lblRechercherProduit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRechercherProduit.Name = "lblRechercherProduit";
            this.lblRechercherProduit.Size = new System.Drawing.Size(96, 17);
            this.lblRechercherProduit.TabIndex = 38;
            this.lblRechercherProduit.Text = "Recherche :";
            // 
            // FrmGestionProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1065, 630);
            this.Controls.Add(this.lblRechercherProduit);
            this.Controls.Add(this.txtBoxRechercherProduit);
            this.Controls.Add(this.lblidCategorie);
            this.Controls.Add(this.lblidFournisseur);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblNomProduit);
            this.Controls.Add(this.txtBoxidCategorie);
            this.Controls.Add(this.txtBoxidFournisseur);
            this.Controls.Add(this.txtBoxImage);
            this.Controls.Add(this.txtBoxPrix);
            this.Controls.Add(this.txtBoxDescription);
            this.Controls.Add(this.txtBoxNomProduit);
            this.Controls.Add(this.btnSupprimerProduits);
            this.Controls.Add(this.btnModifierProduits);
            this.Controls.Add(this.btnAjouterProduits);
            this.Controls.Add(this.dgvListeProduits);
            this.Controls.Add(this.pnlProduit);
            this.Controls.Add(this.menuStripProduits);
            this.MainMenuStrip = this.menuStripProduits;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGestionProduits";
            this.Text = "Gestion de Produits ...";
            this.Load += new System.EventHandler(this.FrmGestionProduits_Load);
            this.menuStripProduits.ResumeLayout(false);
            this.menuStripProduits.PerformLayout();
            this.pnlProduit.ResumeLayout(false);
            this.pnlProduit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeProduits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripProduits;
        private System.Windows.Forms.ToolStripMenuItem categorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lignedecommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitToolStripMenuItem;
        private System.Windows.Forms.Panel pnlProduit;
        private System.Windows.Forms.Label lblProduit;
        private System.Windows.Forms.Label lblidCategorie;
        private System.Windows.Forms.Label lblidFournisseur;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblNomProduit;
        private System.Windows.Forms.TextBox txtBoxidCategorie;
        private System.Windows.Forms.TextBox txtBoxidFournisseur;
        private System.Windows.Forms.TextBox txtBoxImage;
        private System.Windows.Forms.TextBox txtBoxPrix;
        private System.Windows.Forms.TextBox txtBoxDescription;
        private System.Windows.Forms.TextBox txtBoxNomProduit;
        private System.Windows.Forms.Button btnSupprimerProduits;
        private System.Windows.Forms.Button btnModifierProduits;
        private System.Windows.Forms.Button btnAjouterProduits;
        private System.Windows.Forms.DataGridView dgvListeProduits;
        private System.Windows.Forms.TextBox txtBoxRechercherProduit;
        private System.Windows.Forms.Label lblRechercherProduit;
        private System.Windows.Forms.ToolStripMenuItem gestionCommandeToolStripMenuItem;
    }
}