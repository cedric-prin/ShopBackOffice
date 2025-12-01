namespace prin_boutique
{
    partial class FrmGestionCategories
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
            this.menuStripCategorie = new System.Windows.Forms.MenuStrip();
            this.categorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lignedecommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGestionCategorie = new System.Windows.Forms.Label();
            this.pnlCategorie = new System.Windows.Forms.Panel();
            this.lblLibelle = new System.Windows.Forms.Label();
            this.txtBoxLibelle = new System.Windows.Forms.TextBox();
            this.btnSupprimerCategorie = new System.Windows.Forms.Button();
            this.btnModifierCategorie = new System.Windows.Forms.Button();
            this.btnAjouterCategorie = new System.Windows.Forms.Button();
            this.dgvListeCategories = new System.Windows.Forms.DataGridView();
            this.lblRechercherCategorie = new System.Windows.Forms.Label();
            this.txtBoxRechercherCategorie = new System.Windows.Forms.TextBox();
            this.menuStripCategorie.SuspendLayout();
            this.pnlCategorie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeCategories)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripCategorie
            // 
            this.menuStripCategorie.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripCategorie.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categorieToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.commandeToolStripMenuItem,
            this.fournisseurToolStripMenuItem,
            this.lignedecommandeToolStripMenuItem,
            this.produitToolStripMenuItem,
            this.gestionCommandeToolStripMenuItem});
            this.menuStripCategorie.Location = new System.Drawing.Point(0, 0);
            this.menuStripCategorie.Name = "menuStripCategorie";
            this.menuStripCategorie.Size = new System.Drawing.Size(842, 28);
            this.menuStripCategorie.TabIndex = 0;
            this.menuStripCategorie.Text = "menuStripCategorie";
            // 
            // categorieToolStripMenuItem
            // 
            this.categorieToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.categorieToolStripMenuItem.Name = "categorieToolStripMenuItem";
            this.categorieToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.categorieToolStripMenuItem.Text = "&Categorie";
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
            // gestionCommandeToolStripMenuItem
            // 
            this.gestionCommandeToolStripMenuItem.Name = "gestionCommandeToolStripMenuItem";
            this.gestionCommandeToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.gestionCommandeToolStripMenuItem.Text = "Gestion Commande";
            this.gestionCommandeToolStripMenuItem.Click += new System.EventHandler(this.gestionCommandeToolStripMenuItem_Click);
            // 
            // lblGestionCategorie
            // 
            this.lblGestionCategorie.AutoSize = true;
            this.lblGestionCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionCategorie.ForeColor = System.Drawing.Color.White;
            this.lblGestionCategorie.Location = new System.Drawing.Point(211, 19);
            this.lblGestionCategorie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGestionCategorie.Name = "lblGestionCategorie";
            this.lblGestionCategorie.Size = new System.Drawing.Size(417, 54);
            this.lblGestionCategorie.TabIndex = 1;
            this.lblGestionCategorie.Text = "Gestion Catégorie";
            // 
            // pnlCategorie
            // 
            this.pnlCategorie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCategorie.Controls.Add(this.lblGestionCategorie);
            this.pnlCategorie.Location = new System.Drawing.Point(-11, 30);
            this.pnlCategorie.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCategorie.Name = "pnlCategorie";
            this.pnlCategorie.Size = new System.Drawing.Size(853, 96);
            this.pnlCategorie.TabIndex = 2;
            // 
            // lblLibelle
            // 
            this.lblLibelle.AutoSize = true;
            this.lblLibelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibelle.ForeColor = System.Drawing.Color.White;
            this.lblLibelle.Location = new System.Drawing.Point(379, 188);
            this.lblLibelle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLibelle.Name = "lblLibelle";
            this.lblLibelle.Size = new System.Drawing.Size(66, 17);
            this.lblLibelle.TabIndex = 31;
            this.lblLibelle.Text = "Libelle :";
            // 
            // txtBoxLibelle
            // 
            this.txtBoxLibelle.Location = new System.Drawing.Point(383, 222);
            this.txtBoxLibelle.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxLibelle.Name = "txtBoxLibelle";
            this.txtBoxLibelle.Size = new System.Drawing.Size(132, 22);
            this.txtBoxLibelle.TabIndex = 24;
            // 
            // btnSupprimerCategorie
            // 
            this.btnSupprimerCategorie.BackColor = System.Drawing.Color.Red;
            this.btnSupprimerCategorie.Location = new System.Drawing.Point(579, 401);
            this.btnSupprimerCategorie.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimerCategorie.Name = "btnSupprimerCategorie";
            this.btnSupprimerCategorie.Size = new System.Drawing.Size(139, 44);
            this.btnSupprimerCategorie.TabIndex = 23;
            this.btnSupprimerCategorie.Text = "Supprimer";
            this.btnSupprimerCategorie.UseVisualStyleBackColor = false;
            this.btnSupprimerCategorie.Click += new System.EventHandler(this.btnSupprimerCategorie_Click);
            // 
            // btnModifierCategorie
            // 
            this.btnModifierCategorie.BackColor = System.Drawing.Color.Silver;
            this.btnModifierCategorie.Location = new System.Drawing.Point(579, 277);
            this.btnModifierCategorie.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifierCategorie.Name = "btnModifierCategorie";
            this.btnModifierCategorie.Size = new System.Drawing.Size(139, 44);
            this.btnModifierCategorie.TabIndex = 22;
            this.btnModifierCategorie.Text = "Modifier";
            this.btnModifierCategorie.UseVisualStyleBackColor = false;
            this.btnModifierCategorie.Click += new System.EventHandler(this.btnModifierCategorie_Click);
            // 
            // btnAjouterCategorie
            // 
            this.btnAjouterCategorie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAjouterCategorie.ForeColor = System.Drawing.Color.Black;
            this.btnAjouterCategorie.Location = new System.Drawing.Point(579, 149);
            this.btnAjouterCategorie.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouterCategorie.Name = "btnAjouterCategorie";
            this.btnAjouterCategorie.Size = new System.Drawing.Size(139, 44);
            this.btnAjouterCategorie.TabIndex = 21;
            this.btnAjouterCategorie.Text = "Ajouter";
            this.btnAjouterCategorie.UseVisualStyleBackColor = false;
            this.btnAjouterCategorie.Click += new System.EventHandler(this.btnAjouterCategorie_Click);
            // 
            // dgvListeCategories
            // 
            this.dgvListeCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeCategories.Location = new System.Drawing.Point(16, 149);
            this.dgvListeCategories.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListeCategories.Name = "dgvListeCategories";
            this.dgvListeCategories.RowHeadersWidth = 51;
            this.dgvListeCategories.Size = new System.Drawing.Size(355, 297);
            this.dgvListeCategories.TabIndex = 32;
            this.dgvListeCategories.CurrentCellChanged += new System.EventHandler(this.dgvListeCategories_CurrentCellChanged);
            // 
            // lblRechercherCategorie
            // 
            this.lblRechercherCategorie.AutoSize = true;
            this.lblRechercherCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechercherCategorie.ForeColor = System.Drawing.Color.White;
            this.lblRechercherCategorie.Location = new System.Drawing.Point(379, 326);
            this.lblRechercherCategorie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRechercherCategorie.Name = "lblRechercherCategorie";
            this.lblRechercherCategorie.Size = new System.Drawing.Size(96, 17);
            this.lblRechercherCategorie.TabIndex = 40;
            this.lblRechercherCategorie.Text = "Recherche :";
            // 
            // txtBoxRechercherCategorie
            // 
            this.txtBoxRechercherCategorie.Location = new System.Drawing.Point(383, 357);
            this.txtBoxRechercherCategorie.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxRechercherCategorie.Name = "txtBoxRechercherCategorie";
            this.txtBoxRechercherCategorie.Size = new System.Drawing.Size(177, 22);
            this.txtBoxRechercherCategorie.TabIndex = 39;
            this.txtBoxRechercherCategorie.TextChanged += new System.EventHandler(this.txtBoxRechercherCategorie_TextChanged);
            // 
            // FrmGestionCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(842, 460);
            this.Controls.Add(this.lblRechercherCategorie);
            this.Controls.Add(this.txtBoxRechercherCategorie);
            this.Controls.Add(this.dgvListeCategories);
            this.Controls.Add(this.lblLibelle);
            this.Controls.Add(this.txtBoxLibelle);
            this.Controls.Add(this.btnSupprimerCategorie);
            this.Controls.Add(this.btnModifierCategorie);
            this.Controls.Add(this.btnAjouterCategorie);
            this.Controls.Add(this.pnlCategorie);
            this.Controls.Add(this.menuStripCategorie);
            this.MainMenuStrip = this.menuStripCategorie;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGestionCategories";
            this.Text = "Gestion de catégories ...";
            this.Load += new System.EventHandler(this.FrmGestionCategories_Load);
            this.menuStripCategorie.ResumeLayout(false);
            this.menuStripCategorie.PerformLayout();
            this.pnlCategorie.ResumeLayout(false);
            this.pnlCategorie.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeCategories)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripCategorie;
        private System.Windows.Forms.ToolStripMenuItem categorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lignedecommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitToolStripMenuItem;
        private System.Windows.Forms.Label lblGestionCategorie;
        private System.Windows.Forms.Panel pnlCategorie;
        private System.Windows.Forms.Label lblLibelle;
        private System.Windows.Forms.TextBox txtBoxLibelle;
        private System.Windows.Forms.Button btnSupprimerCategorie;
        private System.Windows.Forms.Button btnModifierCategorie;
        private System.Windows.Forms.Button btnAjouterCategorie;
        private System.Windows.Forms.DataGridView dgvListeCategories;
        private System.Windows.Forms.Label lblRechercherCategorie;
        private System.Windows.Forms.TextBox txtBoxRechercherCategorie;
        private System.Windows.Forms.ToolStripMenuItem gestionCommandeToolStripMenuItem;
    }
}