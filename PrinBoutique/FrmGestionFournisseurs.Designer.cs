namespace prin_boutique
{
    partial class FrmGestionFournisseurs
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
            this.menuStripFournisseurs = new System.Windows.Forms.MenuStrip();
            this.categorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lignedecommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlFournisseur = new System.Windows.Forms.Panel();
            this.lblGestionFournisseur = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSupprimerFournisseur = new System.Windows.Forms.Button();
            this.btnModifierFournisseur = new System.Windows.Forms.Button();
            this.btnAjouterFournisseur = new System.Windows.Forms.Button();
            this.lblTelFournisseur = new System.Windows.Forms.Label();
            this.lblVilleFournisseur = new System.Windows.Forms.Label();
            this.lblCPFournisseur = new System.Windows.Forms.Label();
            this.lblRueFournisseur = new System.Windows.Forms.Label();
            this.lblEmailFournisseur = new System.Windows.Forms.Label();
            this.lblNomFournisseur = new System.Windows.Forms.Label();
            this.txtBoxTelFournisseur = new System.Windows.Forms.TextBox();
            this.txtBoxVilleFournisseur = new System.Windows.Forms.TextBox();
            this.txtBoxCPFournisseur = new System.Windows.Forms.TextBox();
            this.txtBoxRueFournisseur = new System.Windows.Forms.TextBox();
            this.txtBoxEmailFournisseur = new System.Windows.Forms.TextBox();
            this.txtBoxNomFournisseur = new System.Windows.Forms.TextBox();
            this.dgvListeFournisseurs = new System.Windows.Forms.DataGridView();
            this.lblRechercherFournisseur = new System.Windows.Forms.Label();
            this.txtBoxRechercherFournisseur = new System.Windows.Forms.TextBox();
            this.menuStripFournisseurs.SuspendLayout();
            this.pnlFournisseur.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeFournisseurs)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripFournisseurs
            // 
            this.menuStripFournisseurs.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripFournisseurs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categorieToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.commandeToolStripMenuItem,
            this.fournisseurToolStripMenuItem,
            this.lignedecommandeToolStripMenuItem,
            this.produitToolStripMenuItem,
            this.gestionCommandeToolStripMenuItem});
            this.menuStripFournisseurs.Location = new System.Drawing.Point(0, 0);
            this.menuStripFournisseurs.Name = "menuStripFournisseurs";
            this.menuStripFournisseurs.Size = new System.Drawing.Size(1077, 28);
            this.menuStripFournisseurs.TabIndex = 0;
            this.menuStripFournisseurs.Text = "menuStrip1";
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
            this.fournisseurToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.fournisseurToolStripMenuItem.Name = "fournisseurToolStripMenuItem";
            this.fournisseurToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.fournisseurToolStripMenuItem.Text = "&Fournisseur";
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
            // pnlFournisseur
            // 
            this.pnlFournisseur.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlFournisseur.Controls.Add(this.lblGestionFournisseur);
            this.pnlFournisseur.Controls.Add(this.label1);
            this.pnlFournisseur.Location = new System.Drawing.Point(-9, 30);
            this.pnlFournisseur.Margin = new System.Windows.Forms.Padding(4);
            this.pnlFournisseur.Name = "pnlFournisseur";
            this.pnlFournisseur.Size = new System.Drawing.Size(1088, 94);
            this.pnlFournisseur.TabIndex = 1;
            // 
            // lblGestionFournisseur
            // 
            this.lblGestionFournisseur.AutoSize = true;
            this.lblGestionFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionFournisseur.ForeColor = System.Drawing.Color.White;
            this.lblGestionFournisseur.Location = new System.Drawing.Point(305, 18);
            this.lblGestionFournisseur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGestionFournisseur.Name = "lblGestionFournisseur";
            this.lblGestionFournisseur.Size = new System.Drawing.Size(446, 54);
            this.lblGestionFournisseur.TabIndex = 1;
            this.lblGestionFournisseur.Text = "Gestion Fournisseur";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btnSupprimerFournisseur
            // 
            this.btnSupprimerFournisseur.BackColor = System.Drawing.Color.Red;
            this.btnSupprimerFournisseur.Location = new System.Drawing.Point(921, 570);
            this.btnSupprimerFournisseur.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimerFournisseur.Name = "btnSupprimerFournisseur";
            this.btnSupprimerFournisseur.Size = new System.Drawing.Size(139, 44);
            this.btnSupprimerFournisseur.TabIndex = 44;
            this.btnSupprimerFournisseur.Text = "Supprimer";
            this.btnSupprimerFournisseur.UseVisualStyleBackColor = false;
            this.btnSupprimerFournisseur.Click += new System.EventHandler(this.btnSupprimerFournisseur_Click);
            // 
            // btnModifierFournisseur
            // 
            this.btnModifierFournisseur.BackColor = System.Drawing.Color.Silver;
            this.btnModifierFournisseur.Location = new System.Drawing.Point(921, 497);
            this.btnModifierFournisseur.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifierFournisseur.Name = "btnModifierFournisseur";
            this.btnModifierFournisseur.Size = new System.Drawing.Size(139, 44);
            this.btnModifierFournisseur.TabIndex = 43;
            this.btnModifierFournisseur.Text = "Modifier";
            this.btnModifierFournisseur.UseVisualStyleBackColor = false;
            this.btnModifierFournisseur.Click += new System.EventHandler(this.btnModifierFournisseur_Click);
            // 
            // btnAjouterFournisseur
            // 
            this.btnAjouterFournisseur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAjouterFournisseur.ForeColor = System.Drawing.Color.Black;
            this.btnAjouterFournisseur.Location = new System.Drawing.Point(921, 423);
            this.btnAjouterFournisseur.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouterFournisseur.Name = "btnAjouterFournisseur";
            this.btnAjouterFournisseur.Size = new System.Drawing.Size(139, 44);
            this.btnAjouterFournisseur.TabIndex = 42;
            this.btnAjouterFournisseur.Text = "Ajouter";
            this.btnAjouterFournisseur.UseVisualStyleBackColor = false;
            this.btnAjouterFournisseur.Click += new System.EventHandler(this.btnAjouterFournisseur_Click);
            // 
            // lblTelFournisseur
            // 
            this.lblTelFournisseur.AutoSize = true;
            this.lblTelFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelFournisseur.ForeColor = System.Drawing.Color.White;
            this.lblTelFournisseur.Location = new System.Drawing.Point(477, 438);
            this.lblTelFournisseur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelFournisseur.Name = "lblTelFournisseur";
            this.lblTelFournisseur.Size = new System.Drawing.Size(41, 17);
            this.lblTelFournisseur.TabIndex = 57;
            this.lblTelFournisseur.Text = "Tel :";
            // 
            // lblVilleFournisseur
            // 
            this.lblVilleFournisseur.AutoSize = true;
            this.lblVilleFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVilleFournisseur.ForeColor = System.Drawing.Color.White;
            this.lblVilleFournisseur.Location = new System.Drawing.Point(264, 438);
            this.lblVilleFournisseur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVilleFournisseur.Name = "lblVilleFournisseur";
            this.lblVilleFournisseur.Size = new System.Drawing.Size(49, 17);
            this.lblVilleFournisseur.TabIndex = 56;
            this.lblVilleFournisseur.Text = "Ville :";
            // 
            // lblCPFournisseur
            // 
            this.lblCPFournisseur.AutoSize = true;
            this.lblCPFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFournisseur.ForeColor = System.Drawing.Color.White;
            this.lblCPFournisseur.Location = new System.Drawing.Point(264, 532);
            this.lblCPFournisseur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCPFournisseur.Name = "lblCPFournisseur";
            this.lblCPFournisseur.Size = new System.Drawing.Size(100, 17);
            this.lblCPFournisseur.TabIndex = 55;
            this.lblCPFournisseur.Text = "CodePostal :";
            // 
            // lblRueFournisseur
            // 
            this.lblRueFournisseur.AutoSize = true;
            this.lblRueFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRueFournisseur.ForeColor = System.Drawing.Color.White;
            this.lblRueFournisseur.Location = new System.Drawing.Point(48, 532);
            this.lblRueFournisseur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRueFournisseur.Name = "lblRueFournisseur";
            this.lblRueFournisseur.Size = new System.Drawing.Size(47, 17);
            this.lblRueFournisseur.TabIndex = 54;
            this.lblRueFournisseur.Text = "Rue :";
            // 
            // lblEmailFournisseur
            // 
            this.lblEmailFournisseur.AutoSize = true;
            this.lblEmailFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailFournisseur.ForeColor = System.Drawing.Color.White;
            this.lblEmailFournisseur.Location = new System.Drawing.Point(477, 535);
            this.lblEmailFournisseur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailFournisseur.Name = "lblEmailFournisseur";
            this.lblEmailFournisseur.Size = new System.Drawing.Size(57, 17);
            this.lblEmailFournisseur.TabIndex = 53;
            this.lblEmailFournisseur.Text = "Email :";
            // 
            // lblNomFournisseur
            // 
            this.lblNomFournisseur.AutoSize = true;
            this.lblNomFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomFournisseur.ForeColor = System.Drawing.Color.White;
            this.lblNomFournisseur.Location = new System.Drawing.Point(48, 437);
            this.lblNomFournisseur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomFournisseur.Name = "lblNomFournisseur";
            this.lblNomFournisseur.Size = new System.Drawing.Size(50, 17);
            this.lblNomFournisseur.TabIndex = 52;
            this.lblNomFournisseur.Text = "Nom :";
            // 
            // txtBoxTelFournisseur
            // 
            this.txtBoxTelFournisseur.Location = new System.Drawing.Point(481, 470);
            this.txtBoxTelFournisseur.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxTelFournisseur.Name = "txtBoxTelFournisseur";
            this.txtBoxTelFournisseur.Size = new System.Drawing.Size(132, 22);
            this.txtBoxTelFournisseur.TabIndex = 51;
            // 
            // txtBoxVilleFournisseur
            // 
            this.txtBoxVilleFournisseur.Location = new System.Drawing.Point(268, 470);
            this.txtBoxVilleFournisseur.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxVilleFournisseur.Name = "txtBoxVilleFournisseur";
            this.txtBoxVilleFournisseur.Size = new System.Drawing.Size(132, 22);
            this.txtBoxVilleFournisseur.TabIndex = 50;
            // 
            // txtBoxCPFournisseur
            // 
            this.txtBoxCPFournisseur.Location = new System.Drawing.Point(268, 564);
            this.txtBoxCPFournisseur.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxCPFournisseur.Name = "txtBoxCPFournisseur";
            this.txtBoxCPFournisseur.Size = new System.Drawing.Size(132, 22);
            this.txtBoxCPFournisseur.TabIndex = 49;
            // 
            // txtBoxRueFournisseur
            // 
            this.txtBoxRueFournisseur.Location = new System.Drawing.Point(52, 564);
            this.txtBoxRueFournisseur.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxRueFournisseur.Name = "txtBoxRueFournisseur";
            this.txtBoxRueFournisseur.Size = new System.Drawing.Size(132, 22);
            this.txtBoxRueFournisseur.TabIndex = 48;
            // 
            // txtBoxEmailFournisseur
            // 
            this.txtBoxEmailFournisseur.Location = new System.Drawing.Point(481, 564);
            this.txtBoxEmailFournisseur.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxEmailFournisseur.Name = "txtBoxEmailFournisseur";
            this.txtBoxEmailFournisseur.Size = new System.Drawing.Size(132, 22);
            this.txtBoxEmailFournisseur.TabIndex = 47;
            // 
            // txtBoxNomFournisseur
            // 
            this.txtBoxNomFournisseur.Location = new System.Drawing.Point(52, 470);
            this.txtBoxNomFournisseur.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxNomFournisseur.Name = "txtBoxNomFournisseur";
            this.txtBoxNomFournisseur.Size = new System.Drawing.Size(132, 22);
            this.txtBoxNomFournisseur.TabIndex = 46;
            // 
            // dgvListeFournisseurs
            // 
            this.dgvListeFournisseurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeFournisseurs.Location = new System.Drawing.Point(16, 132);
            this.dgvListeFournisseurs.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListeFournisseurs.Name = "dgvListeFournisseurs";
            this.dgvListeFournisseurs.RowHeadersWidth = 51;
            this.dgvListeFournisseurs.Size = new System.Drawing.Size(1044, 271);
            this.dgvListeFournisseurs.TabIndex = 45;
            this.dgvListeFournisseurs.CurrentCellChanged += new System.EventHandler(this.dgvListeFournisseurs_CurrentCellChanged);
            // 
            // lblRechercherFournisseur
            // 
            this.lblRechercherFournisseur.AutoSize = true;
            this.lblRechercherFournisseur.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechercherFournisseur.ForeColor = System.Drawing.Color.White;
            this.lblRechercherFournisseur.Location = new System.Drawing.Point(668, 442);
            this.lblRechercherFournisseur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRechercherFournisseur.Name = "lblRechercherFournisseur";
            this.lblRechercherFournisseur.Size = new System.Drawing.Size(96, 17);
            this.lblRechercherFournisseur.TabIndex = 59;
            this.lblRechercherFournisseur.Text = "Recherche :";
            // 
            // txtBoxRechercherFournisseur
            // 
            this.txtBoxRechercherFournisseur.Location = new System.Drawing.Point(672, 470);
            this.txtBoxRechercherFournisseur.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxRechercherFournisseur.Name = "txtBoxRechercherFournisseur";
            this.txtBoxRechercherFournisseur.Size = new System.Drawing.Size(204, 22);
            this.txtBoxRechercherFournisseur.TabIndex = 58;
            this.txtBoxRechercherFournisseur.TextChanged += new System.EventHandler(this.txtBoxRechercherFournisseur_TextChanged);
            // 
            // FrmGestionFournisseurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1077, 634);
            this.Controls.Add(this.lblRechercherFournisseur);
            this.Controls.Add(this.txtBoxRechercherFournisseur);
            this.Controls.Add(this.lblTelFournisseur);
            this.Controls.Add(this.lblVilleFournisseur);
            this.Controls.Add(this.lblCPFournisseur);
            this.Controls.Add(this.lblRueFournisseur);
            this.Controls.Add(this.lblEmailFournisseur);
            this.Controls.Add(this.lblNomFournisseur);
            this.Controls.Add(this.txtBoxTelFournisseur);
            this.Controls.Add(this.txtBoxVilleFournisseur);
            this.Controls.Add(this.txtBoxCPFournisseur);
            this.Controls.Add(this.txtBoxRueFournisseur);
            this.Controls.Add(this.txtBoxEmailFournisseur);
            this.Controls.Add(this.txtBoxNomFournisseur);
            this.Controls.Add(this.dgvListeFournisseurs);
            this.Controls.Add(this.btnSupprimerFournisseur);
            this.Controls.Add(this.btnModifierFournisseur);
            this.Controls.Add(this.btnAjouterFournisseur);
            this.Controls.Add(this.pnlFournisseur);
            this.Controls.Add(this.menuStripFournisseurs);
            this.MainMenuStrip = this.menuStripFournisseurs;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGestionFournisseurs";
            this.Text = "Gestion de fournisseur ...";
            this.Load += new System.EventHandler(this.FrmGestionFournisseurs_Load);
            this.menuStripFournisseurs.ResumeLayout(false);
            this.menuStripFournisseurs.PerformLayout();
            this.pnlFournisseur.ResumeLayout(false);
            this.pnlFournisseur.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeFournisseurs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripFournisseurs;
        private System.Windows.Forms.ToolStripMenuItem categorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lignedecommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitToolStripMenuItem;
        private System.Windows.Forms.Panel pnlFournisseur;
        private System.Windows.Forms.Label lblGestionFournisseur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSupprimerFournisseur;
        private System.Windows.Forms.Button btnModifierFournisseur;
        private System.Windows.Forms.Button btnAjouterFournisseur;
        private System.Windows.Forms.Label lblTelFournisseur;
        private System.Windows.Forms.Label lblVilleFournisseur;
        private System.Windows.Forms.Label lblCPFournisseur;
        private System.Windows.Forms.Label lblRueFournisseur;
        private System.Windows.Forms.Label lblEmailFournisseur;
        private System.Windows.Forms.Label lblNomFournisseur;
        private System.Windows.Forms.TextBox txtBoxTelFournisseur;
        private System.Windows.Forms.TextBox txtBoxVilleFournisseur;
        private System.Windows.Forms.TextBox txtBoxCPFournisseur;
        private System.Windows.Forms.TextBox txtBoxRueFournisseur;
        private System.Windows.Forms.TextBox txtBoxEmailFournisseur;
        private System.Windows.Forms.TextBox txtBoxNomFournisseur;
        private System.Windows.Forms.DataGridView dgvListeFournisseurs;
        private System.Windows.Forms.Label lblRechercherFournisseur;
        private System.Windows.Forms.TextBox txtBoxRechercherFournisseur;
        private System.Windows.Forms.ToolStripMenuItem gestionCommandeToolStripMenuItem;
    }
}