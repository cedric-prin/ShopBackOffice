namespace prin_boutique
{
    partial class FrmConnexion
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
            this.lblConnexion = new System.Windows.Forms.Label();
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.lblMdp = new System.Windows.Forms.Label();
            this.btnConnexion = new System.Windows.Forms.Button();
            this.txtBoxIdentifiant = new System.Windows.Forms.TextBox();
            this.txtBoxMdp = new System.Windows.Forms.TextBox();
            this.pnlConnexion = new System.Windows.Forms.Panel();
            this.pnlConnexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConnexion
            // 
            this.lblConnexion.AutoSize = true;
            this.lblConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnexion.ForeColor = System.Drawing.Color.White;
            this.lblConnexion.Location = new System.Drawing.Point(98, 17);
            this.lblConnexion.Name = "lblConnexion";
            this.lblConnexion.Size = new System.Drawing.Size(124, 25);
            this.lblConnexion.TabIndex = 0;
            this.lblConnexion.Text = "Connexion";
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdentifiant.ForeColor = System.Drawing.Color.White;
            this.lblIdentifiant.Location = new System.Drawing.Point(57, 86);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(59, 13);
            this.lblIdentifiant.TabIndex = 1;
            this.lblIdentifiant.Text = "Identifiant :";
            // 
            // lblMdp
            // 
            this.lblMdp.AutoSize = true;
            this.lblMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMdp.ForeColor = System.Drawing.Color.White;
            this.lblMdp.Location = new System.Drawing.Point(57, 150);
            this.lblMdp.Name = "lblMdp";
            this.lblMdp.Size = new System.Drawing.Size(82, 13);
            this.lblMdp.TabIndex = 2;
            this.lblMdp.Text = "Mots de passe :";
            // 
            // btnConnexion
            // 
            this.btnConnexion.Location = new System.Drawing.Point(72, 234);
            this.btnConnexion.Name = "btnConnexion";
            this.btnConnexion.Size = new System.Drawing.Size(163, 29);
            this.btnConnexion.TabIndex = 3;
            this.btnConnexion.Text = "Connexion";
            this.btnConnexion.UseVisualStyleBackColor = true;
            this.btnConnexion.Click += new System.EventHandler(this.btnConnexion_Click);
            // 
            // txtBoxIdentifiant
            // 
            this.txtBoxIdentifiant.Location = new System.Drawing.Point(60, 116);
            this.txtBoxIdentifiant.Name = "txtBoxIdentifiant";
            this.txtBoxIdentifiant.Size = new System.Drawing.Size(191, 20);
            this.txtBoxIdentifiant.TabIndex = 4;
            // 
            // txtBoxMdp
            // 
            this.txtBoxMdp.Location = new System.Drawing.Point(60, 178);
            this.txtBoxMdp.Name = "txtBoxMdp";
            this.txtBoxMdp.Size = new System.Drawing.Size(191, 20);
            this.txtBoxMdp.TabIndex = 5;
            // 
            // pnlConnexion
            // 
            this.pnlConnexion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlConnexion.Controls.Add(this.lblConnexion);
            this.pnlConnexion.Location = new System.Drawing.Point(-7, -1);
            this.pnlConnexion.Name = "pnlConnexion";
            this.pnlConnexion.Size = new System.Drawing.Size(317, 61);
            this.pnlConnexion.TabIndex = 6;
            // 
            // FrmConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(0)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(305, 288);
            this.Controls.Add(this.pnlConnexion);
            this.Controls.Add(this.txtBoxMdp);
            this.Controls.Add(this.txtBoxIdentifiant);
            this.Controls.Add(this.btnConnexion);
            this.Controls.Add(this.lblMdp);
            this.Controls.Add(this.lblIdentifiant);
            this.Name = "FrmConnexion";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.FrmConnexion_Load);
            this.pnlConnexion.ResumeLayout(false);
            this.pnlConnexion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConnexion;
        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Label lblMdp;
        private System.Windows.Forms.Button btnConnexion;
        private System.Windows.Forms.TextBox txtBoxIdentifiant;
        private System.Windows.Forms.TextBox txtBoxMdp;
        private System.Windows.Forms.Panel pnlConnexion;
    }
}