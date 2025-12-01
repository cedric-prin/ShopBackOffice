namespace prin_boutique
{
    partial class FrmGestionClients
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvListeClients = new System.Windows.Forms.DataGridView();
            this.btnAjouterClient = new System.Windows.Forms.Button();
            this.btnModifierClient = new System.Windows.Forms.Button();
            this.btnSupprimerClient = new System.Windows.Forms.Button();
            this.menuStripClients = new System.Windows.Forms.MenuStrip();
            this.catégorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fournisseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ligneCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionCommandeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.txtBoxPrenom = new System.Windows.Forms.TextBox();
            this.txtBoxRue = new System.Windows.Forms.TextBox();
            this.txtBoxCP = new System.Windows.Forms.TextBox();
            this.txtBoxVille = new System.Windows.Forms.TextBox();
            this.txtBoxTel = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblRue = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.lblVille = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblGestionClients = new System.Windows.Forms.Label();
            this.pnlClient = new System.Windows.Forms.Panel();
            this.txtBoxRechercherClient = new System.Windows.Forms.TextBox();
            this.lblRechecherClient = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeClients)).BeginInit();
            this.menuStripClients.SuspendLayout();
            this.pnlClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListeClients
            // 
            this.dgvListeClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeClients.Location = new System.Drawing.Point(16, 149);
            this.dgvListeClients.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListeClients.Name = "dgvListeClients";
            this.dgvListeClients.RowHeadersWidth = 51;
            this.dgvListeClients.Size = new System.Drawing.Size(1164, 271);
            this.dgvListeClients.TabIndex = 0;
            this.dgvListeClients.CurrentCellChanged += new System.EventHandler(this.dgvListeClients_CurrentCellChanged);
            // 
            // btnAjouterClient
            // 
            this.btnAjouterClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAjouterClient.ForeColor = System.Drawing.Color.Black;
            this.btnAjouterClient.Location = new System.Drawing.Point(1041, 439);
            this.btnAjouterClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnAjouterClient.Name = "btnAjouterClient";
            this.btnAjouterClient.Size = new System.Drawing.Size(139, 44);
            this.btnAjouterClient.TabIndex = 2;
            this.btnAjouterClient.Text = "Ajouter";
            this.btnAjouterClient.UseVisualStyleBackColor = false;
            this.btnAjouterClient.Click += new System.EventHandler(this.btnAjouterClient_Click);
            // 
            // btnModifierClient
            // 
            this.btnModifierClient.BackColor = System.Drawing.Color.Silver;
            this.btnModifierClient.Location = new System.Drawing.Point(1041, 507);
            this.btnModifierClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnModifierClient.Name = "btnModifierClient";
            this.btnModifierClient.Size = new System.Drawing.Size(139, 44);
            this.btnModifierClient.TabIndex = 3;
            this.btnModifierClient.Text = "Modifier";
            this.btnModifierClient.UseVisualStyleBackColor = false;
            this.btnModifierClient.Click += new System.EventHandler(this.btnModifierClient_Click);
            // 
            // btnSupprimerClient
            // 
            this.btnSupprimerClient.BackColor = System.Drawing.Color.Red;
            this.btnSupprimerClient.Location = new System.Drawing.Point(1041, 571);
            this.btnSupprimerClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnSupprimerClient.Name = "btnSupprimerClient";
            this.btnSupprimerClient.Size = new System.Drawing.Size(139, 44);
            this.btnSupprimerClient.TabIndex = 4;
            this.btnSupprimerClient.Text = "Supprimer";
            this.btnSupprimerClient.UseVisualStyleBackColor = false;
            this.btnSupprimerClient.Click += new System.EventHandler(this.btnSupprimerClient_Click);
            // 
            // menuStripClients
            // 
            this.menuStripClients.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripClients.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catégorieToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.commandeToolStripMenuItem,
            this.fournisseurToolStripMenuItem,
            this.ligneCommandeToolStripMenuItem,
            this.produitToolStripMenuItem,
            this.gestionCommandeToolStripMenuItem});
            this.menuStripClients.Location = new System.Drawing.Point(0, 0);
            this.menuStripClients.Name = "menuStripClients";
            this.menuStripClients.Size = new System.Drawing.Size(1196, 28);
            this.menuStripClients.TabIndex = 5;
            this.menuStripClients.Text = "menuStrip1";
            // 
            // catégorieToolStripMenuItem
            // 
            this.catégorieToolStripMenuItem.Name = "catégorieToolStripMenuItem";
            this.catégorieToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.catégorieToolStripMenuItem.Text = "&Categorie";
            this.catégorieToolStripMenuItem.Click += new System.EventHandler(this.categorieToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.BackColor = System.Drawing.Color.DarkGray;
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.clientToolStripMenuItem.Text = "&Client";
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
            // ligneCommandeToolStripMenuItem
            // 
            this.ligneCommandeToolStripMenuItem.Name = "ligneCommandeToolStripMenuItem";
            this.ligneCommandeToolStripMenuItem.Size = new System.Drawing.Size(151, 24);
            this.ligneCommandeToolStripMenuItem.Text = "&Lignedecommande";
            this.ligneCommandeToolStripMenuItem.Click += new System.EventHandler(this.ligneCommandeToolStripMenuItem_Click);
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
            // txtBoxNom
            // 
            this.txtBoxNom.Location = new System.Drawing.Point(31, 487);
            this.txtBoxNom.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(132, 22);
            this.txtBoxNom.TabIndex = 6;
            // 
            // txtBoxPrenom
            // 
            this.txtBoxPrenom.Location = new System.Drawing.Point(247, 487);
            this.txtBoxPrenom.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxPrenom.Name = "txtBoxPrenom";
            this.txtBoxPrenom.Size = new System.Drawing.Size(132, 22);
            this.txtBoxPrenom.TabIndex = 7;
            // 
            // txtBoxRue
            // 
            this.txtBoxRue.Location = new System.Drawing.Point(31, 581);
            this.txtBoxRue.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxRue.Name = "txtBoxRue";
            this.txtBoxRue.Size = new System.Drawing.Size(132, 22);
            this.txtBoxRue.TabIndex = 8;
            // 
            // txtBoxCP
            // 
            this.txtBoxCP.Location = new System.Drawing.Point(247, 581);
            this.txtBoxCP.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxCP.Name = "txtBoxCP";
            this.txtBoxCP.Size = new System.Drawing.Size(132, 22);
            this.txtBoxCP.TabIndex = 9;
            // 
            // txtBoxVille
            // 
            this.txtBoxVille.Location = new System.Drawing.Point(460, 581);
            this.txtBoxVille.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxVille.Name = "txtBoxVille";
            this.txtBoxVille.Size = new System.Drawing.Size(132, 22);
            this.txtBoxVille.TabIndex = 10;
            // 
            // txtBoxTel
            // 
            this.txtBoxTel.Location = new System.Drawing.Point(460, 487);
            this.txtBoxTel.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxTel.Name = "txtBoxTel";
            this.txtBoxTel.Size = new System.Drawing.Size(132, 22);
            this.txtBoxTel.TabIndex = 11;
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(659, 487);
            this.txtBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(341, 22);
            this.txtBoxEmail.TabIndex = 12;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.ForeColor = System.Drawing.Color.White;
            this.lblNom.Location = new System.Drawing.Point(27, 454);
            this.lblNom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(50, 17);
            this.lblNom.TabIndex = 13;
            this.lblNom.Text = "Nom :";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrenom.ForeColor = System.Drawing.Color.White;
            this.lblPrenom.Location = new System.Drawing.Point(243, 459);
            this.lblPrenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(73, 17);
            this.lblPrenom.TabIndex = 14;
            this.lblPrenom.Text = "Prenom :";
            // 
            // lblRue
            // 
            this.lblRue.AutoSize = true;
            this.lblRue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRue.ForeColor = System.Drawing.Color.White;
            this.lblRue.Location = new System.Drawing.Point(27, 549);
            this.lblRue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRue.Name = "lblRue";
            this.lblRue.Size = new System.Drawing.Size(47, 17);
            this.lblRue.TabIndex = 15;
            this.lblRue.Text = "Rue :";
            // 
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCP.ForeColor = System.Drawing.Color.White;
            this.lblCP.Location = new System.Drawing.Point(243, 549);
            this.lblCP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(100, 17);
            this.lblCP.TabIndex = 16;
            this.lblCP.Text = "CodePostal :";
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVille.ForeColor = System.Drawing.Color.White;
            this.lblVille.Location = new System.Drawing.Point(456, 549);
            this.lblVille.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(49, 17);
            this.lblVille.TabIndex = 17;
            this.lblVille.Text = "Ville :";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTel.ForeColor = System.Drawing.Color.White;
            this.lblTel.Location = new System.Drawing.Point(456, 455);
            this.lblTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(41, 17);
            this.lblTel.TabIndex = 18;
            this.lblTel.Text = "Tel :";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(655, 454);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 17);
            this.lblEmail.TabIndex = 19;
            this.lblEmail.Text = "Email :";
            // 
            // lblGestionClients
            // 
            this.lblGestionClients.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblGestionClients.AutoSize = true;
            this.lblGestionClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionClients.ForeColor = System.Drawing.Color.White;
            this.lblGestionClients.Location = new System.Drawing.Point(431, 20);
            this.lblGestionClients.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGestionClients.Name = "lblGestionClients";
            this.lblGestionClients.Size = new System.Drawing.Size(330, 54);
            this.lblGestionClients.TabIndex = 20;
            this.lblGestionClients.Text = "Gestion Client";
            // 
            // pnlClient
            // 
            this.pnlClient.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlClient.Controls.Add(this.lblGestionClients);
            this.pnlClient.Location = new System.Drawing.Point(-9, 30);
            this.pnlClient.Margin = new System.Windows.Forms.Padding(4);
            this.pnlClient.Name = "pnlClient";
            this.pnlClient.Size = new System.Drawing.Size(1216, 96);
            this.pnlClient.TabIndex = 21;
            // 
            // txtBoxRechercherClient
            // 
            this.txtBoxRechercherClient.Location = new System.Drawing.Point(659, 581);
            this.txtBoxRechercherClient.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxRechercherClient.Name = "txtBoxRechercherClient";
            this.txtBoxRechercherClient.Size = new System.Drawing.Size(224, 22);
            this.txtBoxRechercherClient.TabIndex = 22;
            this.txtBoxRechercherClient.TextChanged += new System.EventHandler(this.txtBoxRechercherClient_TextChanged);
            // 
            // lblRechecherClient
            // 
            this.lblRechecherClient.AutoSize = true;
            this.lblRechecherClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRechecherClient.ForeColor = System.Drawing.Color.White;
            this.lblRechecherClient.Location = new System.Drawing.Point(655, 549);
            this.lblRechecherClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRechecherClient.Name = "lblRechecherClient";
            this.lblRechecherClient.Size = new System.Drawing.Size(96, 17);
            this.lblRechecherClient.TabIndex = 23;
            this.lblRechecherClient.Text = "Recherche :";
            // 
            // FrmGestionClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(1196, 634);
            this.Controls.Add(this.lblRechecherClient);
            this.Controls.Add(this.txtBoxRechercherClient);
            this.Controls.Add(this.pnlClient);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.lblRue);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.txtBoxTel);
            this.Controls.Add(this.txtBoxVille);
            this.Controls.Add(this.txtBoxCP);
            this.Controls.Add(this.txtBoxRue);
            this.Controls.Add(this.txtBoxPrenom);
            this.Controls.Add(this.txtBoxNom);
            this.Controls.Add(this.btnSupprimerClient);
            this.Controls.Add(this.btnModifierClient);
            this.Controls.Add(this.btnAjouterClient);
            this.Controls.Add(this.dgvListeClients);
            this.Controls.Add(this.menuStripClients);
            this.MainMenuStrip = this.menuStripClients;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmGestionClients";
            this.Text = "Gestion de clients...";
            this.Load += new System.EventHandler(this.FrmGestionClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeClients)).EndInit();
            this.menuStripClients.ResumeLayout(false);
            this.menuStripClients.PerformLayout();
            this.pnlClient.ResumeLayout(false);
            this.pnlClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListeClients;
        private System.Windows.Forms.Button btnAjouterClient;
        private System.Windows.Forms.Button btnModifierClient;
        private System.Windows.Forms.Button btnSupprimerClient;
        private System.Windows.Forms.MenuStrip menuStripClients;
        private System.Windows.Forms.ToolStripMenuItem catégorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fournisseurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ligneCommandeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produitToolStripMenuItem;
        private System.Windows.Forms.TextBox txtBoxNom;
        private System.Windows.Forms.TextBox txtBoxPrenom;
        private System.Windows.Forms.TextBox txtBoxRue;
        private System.Windows.Forms.TextBox txtBoxCP;
        private System.Windows.Forms.TextBox txtBoxVille;
        private System.Windows.Forms.TextBox txtBoxTel;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblRue;
        private System.Windows.Forms.Label lblCP;
        private System.Windows.Forms.Label lblVille;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGestionClients;
        private System.Windows.Forms.Panel pnlClient;
        private System.Windows.Forms.TextBox txtBoxRechercherClient;
        private System.Windows.Forms.Label lblRechecherClient;
        private System.Windows.Forms.ToolStripMenuItem gestionCommandeToolStripMenuItem;
    }
}

