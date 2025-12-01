namespace prin_boutique
{
    partial class FrmGestionCommandes
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
            this.menuStripCommandes = new System.Windows.Forms.MenuStrip();
            this.categorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lignedecommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlCommande = new System.Windows.Forms.Panel();
            this.lblGestionCommande = new System.Windows.Forms.Label();
            this.dgvListeCommandes = new System.Windows.Forms.DataGridView();
            this.btnSupprimerCommande = new System.Windows.Forms.Button();
            this.btnModifierCommande = new System.Windows.Forms.Button();
            this.btnAjouterCommande = new System.Windows.Forms.Button();
            this.txtBoxidClient = new System.Windows.Forms.TextBox();
            this.txtBoxDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRechercherCommande = new System.Windows.Forms.Label();
            this.txtBoxRechercherCommande = new System.Windows.Forms.TextBox();
            this.gestionCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripCommandes.SuspendLayout();
            this.pnlCommande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeCommandes)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripCommandes
            // 
            this.menuStripCommandes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripCommandes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categorieToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.commandeToolStripMenuItem,
            this.fournisseurToolStripMenuItem,
            this.lignedecommandeToolStripMenuItem,
            this.produitToolStripMenuItem,
            this.gestionCommandeToolStripMenuItem});
            this.menuStripCommandes.Location = new System.Drawing.Point(0, 0);
            this.menuStripCommandes.Name = "menuStripCommandes";
            this.menuStripCommandes.Size = new System.Drawing.Size(1011, 28);
            this.menuStripCommandes.TabIndex = 0;
            this.menuStripCommandes.Text = "menuStrip1";
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
            this.commandeToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.commandeToolStripMenuItem.Name = "commandeToolStripMenuItem";
            this.commandeToolStripMenuItem.Size = new System.Drawing.Size(100, 24);
            this.commandeToolStripMenuItem.Text = "&Commande";
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
            // pnlCommande
            // 
            this.pnlCommande.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlCommande.Controls.Add(this.lblGestionCommande);
            this.pnlCommande.Location = new System.Drawing.Point(-8, 30);
            this.pnlCommande.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCommande.Name = "pnlCommande";
            this.pnlCommande.Size = new System.Drawing.Size(1081, 98);
            this.pnlCommande.TabIndex = 1;
            // 
            // lblGestionCommande
            // 
            this.lblGestionCommande.AutoSize = true;
            this.lblGestionCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionCommande.ForeColor = System.Drawing.Color.White;
            this.lblGestionCommande.Location = new System.Drawing.Point(315, 18);
            this.lblGestionCommande.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGestionCommande.Name = "lblGestionCommande";
            this.lblGestionCommande.Size = new System.Drawing.Size(455, 54);
            this.lblGestionCommande.TabIndex = 0;
            this.lblGestionCommande.Text = "Gestion Commande";
            // 
            // dgvListeCommandes
            // 
            this.dgvListeCommandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeCommandes.Location = new System.Drawing.Point(16, 149);
            this.dgvListeCommandes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListeCommandes.Name = "dgvListeCommandes";
            this.dgvListeCommandes.RowHeadersWidth = 51;
            this.dgvListeCommandes.Size = new System.Drawing.Size(481, 372);
            this.dgvListeCommandes.TabIndex = 2;
            this.dgvListeCommandes.CurrentCellChanged += new System.EventHandler(this.dgvListeCommandes_CurrentCellChanged);
            // 
            // btnSupprimerCommande
            // 
            this.btnSupprimerCommande.BackColor = System.Drawing.Color.Red;
            this.btnSupprimerCommande.Location = new System.Drawing.Point(796, 372);
            this.btnSupprimerCommande.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimerCommande.Name = "btnSupprimerCommande";
            this.btnSupprimerCommande.Size = new System.Drawing.Size(139, 44);
            this.btnSupprimerCommande.TabIndex = 26;
            this.btnSupprimerCommande.Text = "Supprimer";
            this.btnSupprimerCommande.UseVisualStyleBackColor = false;
            this.btnSupprimerCommande.Click += new System.EventHandler(this.btnSupprimerCommandes_Click);
            // 
            // btnModifierCommande
            // 
            this.btnModifierCommande.BackColor = System.Drawing.Color.Silver;
            this.btnModifierCommande.Location = new System.Drawing.Point(796, 265);
            this.btnModifierCommande.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifierCommande.Name = "btnModifierCommande";
            this.btnModifierCommande.Size = new System.Drawing.Size(139, 44);
            this.btnModifierCommande.TabIndex = 25;
            this.btnModifierCommande.Text = "Modifier";
            this.btnModifierCommande.UseVisualStyleBackColor = false;
            this.btnModifierCommande.Click += new System.EventHandler(this.btnModifierCommandes_Click);
            // 
            // btnAjouterCommande
            // 
            this.btnAjouterCommande.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAjouterCommande.ForeColor = System.Drawing.Color.Black;
            this.btnAjouterCommande.Location = new System.Drawing.Point(796, 149);
            this.btnAjouterCommande.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouterCommande.Name = "btnAjouterCommande";
            this.btnAjouterCommande.Size = new System.Drawing.Size(139, 44);
            this.btnAjouterCommande.TabIndex = 24;
            this.btnAjouterCommande.Text = "Ajouter";
            this.btnAjouterCommande.UseVisualStyleBackColor = false;
            this.btnAjouterCommande.Click += new System.EventHandler(this.btnAjouterCommandes_Click);
            // 
            // txtBoxidClient
            // 
            this.txtBoxidClient.Location = new System.Drawing.Point(537, 297);
            this.txtBoxidClient.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxidClient.Name = "txtBoxidClient";
            this.txtBoxidClient.Size = new System.Drawing.Size(132, 22);
            this.txtBoxidClient.TabIndex = 27;
            // 
            // txtBoxDate
            // 
            this.txtBoxDate.Location = new System.Drawing.Point(537, 206);
            this.txtBoxDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxDate.Name = "txtBoxDate";
            this.txtBoxDate.Size = new System.Drawing.Size(132, 22);
            this.txtBoxDate.TabIndex = 28;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(537, 174);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(52, 17);
            this.lblDate.TabIndex = 29;
            this.lblDate.Text = "Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(533, 265);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "idClient :";
            // 
            // lblRechercherCommande
            // 
            this.lblRechercherCommande.AutoSize = true;
            this.lblRechercherCommande.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechercherCommande.ForeColor = System.Drawing.Color.White;
            this.lblRechercherCommande.Location = new System.Drawing.Point(533, 354);
            this.lblRechercherCommande.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRechercherCommande.Name = "lblRechercherCommande";
            this.lblRechercherCommande.Size = new System.Drawing.Size(96, 17);
            this.lblRechercherCommande.TabIndex = 40;
            this.lblRechercherCommande.Text = "Recherche :";
            // 
            // txtBoxRechercherCommande
            // 
            this.txtBoxRechercherCommande.Location = new System.Drawing.Point(537, 383);
            this.txtBoxRechercherCommande.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxRechercherCommande.Name = "txtBoxRechercherCommande";
            this.txtBoxRechercherCommande.Size = new System.Drawing.Size(204, 22);
            this.txtBoxRechercherCommande.TabIndex = 39;
            this.txtBoxRechercherCommande.TextChanged += new System.EventHandler(this.txtBoxRechercherCommande_TextChanged);
            // 
            // gestionCommandeToolStripMenuItem
            // 
            this.gestionCommandeToolStripMenuItem.Name = "gestionCommandeToolStripMenuItem";
            this.gestionCommandeToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.gestionCommandeToolStripMenuItem.Text = "Gestion Commande";
            this.gestionCommandeToolStripMenuItem.Click += new System.EventHandler(this.gestionCommandeToolStripMenuItem_Click);
            // 
            // FrmGestionCommandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1011, 542);
            this.Controls.Add(this.lblRechercherCommande);
            this.Controls.Add(this.txtBoxRechercherCommande);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtBoxDate);
            this.Controls.Add(this.txtBoxidClient);
            this.Controls.Add(this.btnSupprimerCommande);
            this.Controls.Add(this.btnModifierCommande);
            this.Controls.Add(this.btnAjouterCommande);
            this.Controls.Add(this.dgvListeCommandes);
            this.Controls.Add(this.pnlCommande);
            this.Controls.Add(this.menuStripCommandes);
            this.MainMenuStrip = this.menuStripCommandes;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGestionCommandes";
            this.Text = "Gestion de commandes ...";
            this.Load += new System.EventHandler(this.FrmGestionCommandes_Load);
            this.menuStripCommandes.ResumeLayout(false);
            this.menuStripCommandes.PerformLayout();
            this.pnlCommande.ResumeLayout(false);
            this.pnlCommande.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeCommandes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripCommandes;
        private System.Windows.Forms.ToolStripMenuItem categorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lignedecommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitToolStripMenuItem;
        private System.Windows.Forms.Panel pnlCommande;
        private System.Windows.Forms.Label lblGestionCommande;
        private System.Windows.Forms.DataGridView dgvListeCommandes;
        private System.Windows.Forms.Button btnSupprimerCommande;
        private System.Windows.Forms.Button btnModifierCommande;
        private System.Windows.Forms.Button btnAjouterCommande;
        private System.Windows.Forms.TextBox txtBoxidClient;
        private System.Windows.Forms.TextBox txtBoxDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRechercherCommande;
        private System.Windows.Forms.TextBox txtBoxRechercherCommande;
        private System.Windows.Forms.ToolStripMenuItem gestionCommandeToolStripMenuItem;
    }
}