namespace PrinBoutique
{
    partial class FrmGestionDeLaCommande
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
            this.numUpQte = new System.Windows.Forms.NumericUpDown();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.comboBoxProduit = new System.Windows.Forms.ComboBox();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.grpBoxInfoClient = new System.Windows.Forms.GroupBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            this.txtBoxPrenom = new System.Windows.Forms.TextBox();
            this.txtBoxNom = new System.Windows.Forms.TextBox();
            this.grpBoxLigneDeCommande = new System.Windows.Forms.GroupBox();
            this.dataGridViewLigneDeCommandes = new System.Windows.Forms.DataGridView();
            this.btnSuprimerLigneDeCommandes = new System.Windows.Forms.Button();
            this.grpBoxCommande = new System.Windows.Forms.GroupBox();
            this.dataGridViewCommande = new System.Windows.Forms.DataGridView();
            this.btnSupprimerCommande = new System.Windows.Forms.Button();
            this.grpBoxProduit = new System.Windows.Forms.GroupBox();
            this.lblPrixTotal = new System.Windows.Forms.Label();
            this.lblPrixUnitaire = new System.Windows.Forms.Label();
            this.lblQuantite = new System.Windows.Forms.Label();
            this.btnAjouterCommande = new System.Windows.Forms.Button();
            this.txtBoxPrixTotal = new System.Windows.Forms.TextBox();
            this.txtBoxPrixUnitaire = new System.Windows.Forms.TextBox();
            this.btnActualiser = new System.Windows.Forms.Button();
            this.btnRecapCmd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpQte)).BeginInit();
            this.grpBoxInfoClient.SuspendLayout();
            this.grpBoxLigneDeCommande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLigneDeCommandes)).BeginInit();
            this.grpBoxCommande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommande)).BeginInit();
            this.grpBoxProduit.SuspendLayout();
            this.SuspendLayout();
            // 
            // numUpQte
            // 
            this.numUpQte.Location = new System.Drawing.Point(93, 66);
            this.numUpQte.Name = "numUpQte";
            this.numUpQte.Size = new System.Drawing.Size(143, 22);
            this.numUpQte.TabIndex = 0;
            this.numUpQte.ValueChanged += new System.EventHandler(this.numUpQte_ValueChanged);
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(19, 30);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(121, 24);
            this.comboBoxClient.TabIndex = 1;
            this.comboBoxClient.SelectedIndexChanged += new System.EventHandler(this.comboBoxClient_SelectedIndexChanged);
            // 
            // comboBoxProduit
            // 
            this.comboBoxProduit.FormattingEnabled = true;
            this.comboBoxProduit.Location = new System.Drawing.Point(13, 21);
            this.comboBoxProduit.Name = "comboBoxProduit";
            this.comboBoxProduit.Size = new System.Drawing.Size(223, 24);
            this.comboBoxProduit.TabIndex = 2;
            this.comboBoxProduit.SelectedIndexChanged += new System.EventHandler(this.comboBoxProduit_SelectedIndexChanged);
            // 
            // txtBoxID
            // 
            this.txtBoxID.Location = new System.Drawing.Point(199, 30);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(117, 22);
            this.txtBoxID.TabIndex = 3;
            // 
            // grpBoxInfoClient
            // 
            this.grpBoxInfoClient.Controls.Add(this.lblPrenom);
            this.grpBoxInfoClient.Controls.Add(this.lblNom);
            this.grpBoxInfoClient.Controls.Add(this.lblId);
            this.grpBoxInfoClient.Controls.Add(this.txtBoxPrenom);
            this.grpBoxInfoClient.Controls.Add(this.comboBoxClient);
            this.grpBoxInfoClient.Controls.Add(this.txtBoxNom);
            this.grpBoxInfoClient.Controls.Add(this.txtBoxID);
            this.grpBoxInfoClient.Location = new System.Drawing.Point(25, 24);
            this.grpBoxInfoClient.Name = "grpBoxInfoClient";
            this.grpBoxInfoClient.Size = new System.Drawing.Size(905, 93);
            this.grpBoxInfoClient.TabIndex = 4;
            this.grpBoxInfoClient.TabStop = false;
            this.grpBoxInfoClient.Text = "Information client";
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(515, 34);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(60, 16);
            this.lblPrenom.TabIndex = 9;
            this.lblPrenom.Text = "Prénom :";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(338, 32);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 16);
            this.lblNom.TabIndex = 8;
            this.lblNom.Text = "Nom :";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(167, 32);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(26, 16);
            this.lblId.TabIndex = 7;
            this.lblId.Text = "ID :";
            // 
            // txtBoxPrenom
            // 
            this.txtBoxPrenom.Location = new System.Drawing.Point(581, 30);
            this.txtBoxPrenom.Name = "txtBoxPrenom";
            this.txtBoxPrenom.Size = new System.Drawing.Size(117, 22);
            this.txtBoxPrenom.TabIndex = 6;
            // 
            // txtBoxNom
            // 
            this.txtBoxNom.Location = new System.Drawing.Point(386, 29);
            this.txtBoxNom.Name = "txtBoxNom";
            this.txtBoxNom.Size = new System.Drawing.Size(117, 22);
            this.txtBoxNom.TabIndex = 5;
            // 
            // grpBoxLigneDeCommande
            // 
            this.grpBoxLigneDeCommande.Controls.Add(this.dataGridViewLigneDeCommandes);
            this.grpBoxLigneDeCommande.Controls.Add(this.btnSuprimerLigneDeCommandes);
            this.grpBoxLigneDeCommande.Location = new System.Drawing.Point(306, 123);
            this.grpBoxLigneDeCommande.Name = "grpBoxLigneDeCommande";
            this.grpBoxLigneDeCommande.Size = new System.Drawing.Size(739, 227);
            this.grpBoxLigneDeCommande.TabIndex = 5;
            this.grpBoxLigneDeCommande.TabStop = false;
            this.grpBoxLigneDeCommande.Text = "Lignes de commandes";
            // 
            // dataGridViewLigneDeCommandes
            // 
            this.dataGridViewLigneDeCommandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLigneDeCommandes.Location = new System.Drawing.Point(20, 21);
            this.dataGridViewLigneDeCommandes.Name = "dataGridViewLigneDeCommandes";
            this.dataGridViewLigneDeCommandes.RowHeadersWidth = 51;
            this.dataGridViewLigneDeCommandes.RowTemplate.Height = 24;
            this.dataGridViewLigneDeCommandes.Size = new System.Drawing.Size(699, 156);
            this.dataGridViewLigneDeCommandes.TabIndex = 1;
            // 
            // btnSuprimerLigneDeCommandes
            // 
            this.btnSuprimerLigneDeCommandes.Location = new System.Drawing.Point(328, 183);
            this.btnSuprimerLigneDeCommandes.Name = "btnSuprimerLigneDeCommandes";
            this.btnSuprimerLigneDeCommandes.Size = new System.Drawing.Size(105, 33);
            this.btnSuprimerLigneDeCommandes.TabIndex = 0;
            this.btnSuprimerLigneDeCommandes.Text = "Supprimer";
            this.btnSuprimerLigneDeCommandes.UseVisualStyleBackColor = true;
            this.btnSuprimerLigneDeCommandes.Click += new System.EventHandler(this.btnSuprimerLigneDeCommandes_Click);
            // 
            // grpBoxCommande
            // 
            this.grpBoxCommande.Controls.Add(this.dataGridViewCommande);
            this.grpBoxCommande.Controls.Add(this.btnSupprimerCommande);
            this.grpBoxCommande.Location = new System.Drawing.Point(25, 356);
            this.grpBoxCommande.Name = "grpBoxCommande";
            this.grpBoxCommande.Size = new System.Drawing.Size(886, 190);
            this.grpBoxCommande.TabIndex = 6;
            this.grpBoxCommande.TabStop = false;
            this.grpBoxCommande.Text = "Commande";
            // 
            // dataGridViewCommande
            // 
            this.dataGridViewCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCommande.Location = new System.Drawing.Point(17, 21);
            this.dataGridViewCommande.Name = "dataGridViewCommande";
            this.dataGridViewCommande.RowHeadersWidth = 51;
            this.dataGridViewCommande.RowTemplate.Height = 24;
            this.dataGridViewCommande.Size = new System.Drawing.Size(752, 153);
            this.dataGridViewCommande.TabIndex = 9;
            // 
            // btnSupprimerCommande
            // 
            this.btnSupprimerCommande.Location = new System.Drawing.Point(775, 82);
            this.btnSupprimerCommande.Name = "btnSupprimerCommande";
            this.btnSupprimerCommande.Size = new System.Drawing.Size(105, 31);
            this.btnSupprimerCommande.TabIndex = 8;
            this.btnSupprimerCommande.Text = "Supprimer";
            this.btnSupprimerCommande.UseVisualStyleBackColor = true;
            this.btnSupprimerCommande.Click += new System.EventHandler(this.btnSupprimerCommande_Click);
            // 
            // grpBoxProduit
            // 
            this.grpBoxProduit.Controls.Add(this.lblPrixTotal);
            this.grpBoxProduit.Controls.Add(this.lblPrixUnitaire);
            this.grpBoxProduit.Controls.Add(this.lblQuantite);
            this.grpBoxProduit.Controls.Add(this.btnAjouterCommande);
            this.grpBoxProduit.Controls.Add(this.txtBoxPrixTotal);
            this.grpBoxProduit.Controls.Add(this.txtBoxPrixUnitaire);
            this.grpBoxProduit.Controls.Add(this.comboBoxProduit);
            this.grpBoxProduit.Controls.Add(this.numUpQte);
            this.grpBoxProduit.Location = new System.Drawing.Point(25, 123);
            this.grpBoxProduit.Name = "grpBoxProduit";
            this.grpBoxProduit.Size = new System.Drawing.Size(250, 227);
            this.grpBoxProduit.TabIndex = 7;
            this.grpBoxProduit.TabStop = false;
            this.grpBoxProduit.Text = "Produit";
            // 
            // lblPrixTotal
            // 
            this.lblPrixTotal.AutoSize = true;
            this.lblPrixTotal.Location = new System.Drawing.Point(16, 151);
            this.lblPrixTotal.Name = "lblPrixTotal";
            this.lblPrixTotal.Size = new System.Drawing.Size(68, 16);
            this.lblPrixTotal.TabIndex = 12;
            this.lblPrixTotal.Text = "prix Total :";
            // 
            // lblPrixUnitaire
            // 
            this.lblPrixUnitaire.AutoSize = true;
            this.lblPrixUnitaire.Location = new System.Drawing.Point(16, 109);
            this.lblPrixUnitaire.Name = "lblPrixUnitaire";
            this.lblPrixUnitaire.Size = new System.Drawing.Size(77, 16);
            this.lblPrixUnitaire.TabIndex = 11;
            this.lblPrixUnitaire.Text = "prix Unitaire";
            // 
            // lblQuantite
            // 
            this.lblQuantite.AutoSize = true;
            this.lblQuantite.Location = new System.Drawing.Point(16, 66);
            this.lblQuantite.Name = "lblQuantite";
            this.lblQuantite.Size = new System.Drawing.Size(62, 16);
            this.lblQuantite.TabIndex = 10;
            this.lblQuantite.Text = "Quantité :";
            // 
            // btnAjouterCommande
            // 
            this.btnAjouterCommande.Location = new System.Drawing.Point(19, 185);
            this.btnAjouterCommande.Name = "btnAjouterCommande";
            this.btnAjouterCommande.Size = new System.Drawing.Size(217, 29);
            this.btnAjouterCommande.TabIndex = 5;
            this.btnAjouterCommande.Text = "Ajouter la commande";
            this.btnAjouterCommande.UseVisualStyleBackColor = true;
            this.btnAjouterCommande.Click += new System.EventHandler(this.btnAjouterCommande_Click);
            // 
            // txtBoxPrixTotal
            // 
            this.txtBoxPrixTotal.Location = new System.Drawing.Point(122, 147);
            this.txtBoxPrixTotal.Name = "txtBoxPrixTotal";
            this.txtBoxPrixTotal.Size = new System.Drawing.Size(100, 22);
            this.txtBoxPrixTotal.TabIndex = 4;
            // 
            // txtBoxPrixUnitaire
            // 
            this.txtBoxPrixUnitaire.Location = new System.Drawing.Point(122, 105);
            this.txtBoxPrixUnitaire.Name = "txtBoxPrixUnitaire";
            this.txtBoxPrixUnitaire.Size = new System.Drawing.Size(100, 22);
            this.txtBoxPrixUnitaire.TabIndex = 3;
            // 
            // btnActualiser
            // 
            this.btnActualiser.Location = new System.Drawing.Point(943, 413);
            this.btnActualiser.Name = "btnActualiser";
            this.btnActualiser.Size = new System.Drawing.Size(92, 26);
            this.btnActualiser.TabIndex = 8;
            this.btnActualiser.Text = "Actualiser";
            this.btnActualiser.UseVisualStyleBackColor = true;
            this.btnActualiser.Click += new System.EventHandler(this.btnActualiser_Click);
            // 
            // btnRecapCmd
            // 
            this.btnRecapCmd.Location = new System.Drawing.Point(943, 481);
            this.btnRecapCmd.Name = "btnRecapCmd";
            this.btnRecapCmd.Size = new System.Drawing.Size(92, 26);
            this.btnRecapCmd.TabIndex = 9;
            this.btnRecapCmd.Text = "Récapitulatif";
            this.btnRecapCmd.UseVisualStyleBackColor = true;
            this.btnRecapCmd.Click += new System.EventHandler(this.btnRecapCmd_Click);
            // 
            // FrmGestionDeLaCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 558);
            this.Controls.Add(this.btnRecapCmd);
            this.Controls.Add(this.btnActualiser);
            this.Controls.Add(this.grpBoxProduit);
            this.Controls.Add(this.grpBoxCommande);
            this.Controls.Add(this.grpBoxLigneDeCommande);
            this.Controls.Add(this.grpBoxInfoClient);
            this.Name = "FrmGestionDeLaCommande";
            this.Text = "FrmGestionDeLaCommande";
            this.Load += new System.EventHandler(this.FrmGestionDeLaCommande_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpQte)).EndInit();
            this.grpBoxInfoClient.ResumeLayout(false);
            this.grpBoxInfoClient.PerformLayout();
            this.grpBoxLigneDeCommande.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLigneDeCommandes)).EndInit();
            this.grpBoxCommande.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCommande)).EndInit();
            this.grpBoxProduit.ResumeLayout(false);
            this.grpBoxProduit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.NumericUpDown numUpQte;
        internal System.Windows.Forms.ComboBox comboBoxClient;
        internal System.Windows.Forms.ComboBox comboBoxProduit;
        internal System.Windows.Forms.TextBox txtBoxID;
        internal System.Windows.Forms.GroupBox grpBoxInfoClient;
        internal System.Windows.Forms.TextBox txtBoxPrenom;
        internal System.Windows.Forms.TextBox txtBoxNom;
        internal System.Windows.Forms.GroupBox grpBoxLigneDeCommande;
        internal System.Windows.Forms.GroupBox grpBoxCommande;
        internal System.Windows.Forms.GroupBox grpBoxProduit;
        internal System.Windows.Forms.TextBox txtBoxPrixUnitaire;
        internal System.Windows.Forms.Label lblPrenom;
        internal System.Windows.Forms.Label lblNom;
        internal System.Windows.Forms.Label lblId;
        internal System.Windows.Forms.DataGridView dataGridViewLigneDeCommandes;
        internal System.Windows.Forms.Button btnSuprimerLigneDeCommandes;
        internal System.Windows.Forms.DataGridView dataGridViewCommande;
        internal System.Windows.Forms.Button btnSupprimerCommande;
        internal System.Windows.Forms.Label lblPrixTotal;
        internal System.Windows.Forms.Label lblPrixUnitaire;
        internal System.Windows.Forms.Label lblQuantite;
        internal System.Windows.Forms.Button btnAjouterCommande;
        internal System.Windows.Forms.TextBox txtBoxPrixTotal;
        internal System.Windows.Forms.Button btnActualiser;
        internal System.Windows.Forms.Button btnRecapCmd;
    }
}