using GestionBD;
using GestionBD.MySQL;
using PrinBoutique;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace prin_boutique
{
    public partial class FrmGestionLignedecommandes : Form
    {
        public Cursor CurseurAvant;
        public FrmGestionLignedecommandes()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmGestionLignedecommandes_Load(object sender, EventArgs e)
        {
            GestionBoutique.seConnecter();
            dgvLigneCommande.DataSource = GestionLigneDeCommandes.getLesLigneCommandes();
            dgvLigneCommande.AutoGenerateColumns = true;
            GestionInterface.coloriserDataGrid(dgvLigneCommande);

            // Affiche le nom de l'utilisateur connecté dans le titre du formulaire
            this.Text = $"Gestion de Ligne de commandes - Connecté en tant que : {MysqlConfig.UTILISATEUR}";

            btnAjouterLigneCommande.MouseEnter += Bouton_MouseEnter;
            btnAjouterLigneCommande.MouseLeave += Bouton_MouseLeave;
            btnModifierLigneCommande.MouseEnter += Bouton_MouseEnter;
            btnModifierLigneCommande.MouseLeave += Bouton_MouseLeave;
            btnSupprimerLigneCommande.MouseEnter += Bouton_MouseEnter;
            btnSupprimerLigneCommande.MouseLeave += Bouton_MouseLeave;

            EffacerContenuTextBoxLigneCommande();
        }

        #region ouvrir

        private void categorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmGestionCategories Formulaire = new FrmGestionCategories();
            Formulaire.Show();
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmGestionClients Formulaire = new FrmGestionClients();
            Formulaire.Show();
        }

        private void commandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmGestionCommandes Formulaire = new FrmGestionCommandes();
            Formulaire.Show();
        }

        private void fournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmGestionFournisseurs Formulaire = new FrmGestionFournisseurs();
            Formulaire.Show();
        }

        private void produitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmGestionProduits Formulaire = new FrmGestionProduits();
            Formulaire.Show();
        }
        private void gestionCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionDeLaCommande Formulaire = new FrmGestionDeLaCommande();
            Formulaire.Show();
        }

        #endregion

        private void btnAjouterLigneCommande_Click(object sender, EventArgs e)
        {
            try
            {
                int idCommande = Convert.ToInt32(txtBoxIdCommande.Text);
                int idProduit = Convert.ToInt32(txtBoxIdProduit.Text);
                int quantite = Convert.ToInt32(txtBoxQuantite.Text);
                decimal prixUnitaire = Convert.ToDecimal(txtBoxPrixUnitaire.Text.Replace('.', ','));

                GestionLigneDeCommandes.ajouter(idCommande, idProduit, quantite, prixUnitaire);
                dgvLigneCommande.DataSource = GestionLigneDeCommandes.getLesLigneCommandes();
                MessageBox.Show("La ligne de commande a été ajoutée avec succès.");
                EffacerContenuTextBoxLigneCommande();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout : " + ex.Message);
            }
        }

        private void btnModifierLigneCommande_Click(object sender, EventArgs e)
        {
            if (dgvLigneCommande.SelectedRows.Count > 0)
            {
                try
                {
                    int idCommande = Convert.ToInt32(txtBoxIdCommande.Text);
                    int idProduit = Convert.ToInt32(txtBoxIdProduit.Text);
                    int quantite = Convert.ToInt32(txtBoxQuantite.Text);
                    decimal prixUnitaire = Convert.ToDecimal(txtBoxPrixUnitaire.Text.Replace('.', ','));

                    // Supprimer l'ancienne ligne
                    GestionLigneDeCommandes.supprimer(idCommande, idProduit);
                    // Ajouter la nouvelle ligne
                    GestionLigneDeCommandes.ajouter(idCommande, idProduit, quantite, prixUnitaire);

                    dgvLigneCommande.DataSource = GestionLigneDeCommandes.getLesLigneCommandes();
                    MessageBox.Show("La ligne de commande a été modifiée avec succès.");
                    EffacerContenuTextBoxLigneCommande();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la modification : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne à modifier.");
            }
        }

        private void btnSupprimerLigneCommande_Click(object sender, EventArgs e)
        {
            if (dgvLigneCommande.SelectedRows.Count > 0)
            {
                try
                {
                    int idCommande = Convert.ToInt32(dgvLigneCommande.SelectedRows[0].Cells["idCommande"].Value);
                    int idProduit = Convert.ToInt32(dgvLigneCommande.SelectedRows[0].Cells["idProduit"].Value);

                    DialogResult result = MessageBox.Show(
                        "Voulez-vous vraiment supprimer cette ligne de commande ?",
                        "Confirmation de suppression",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        GestionLigneDeCommandes.supprimer(idCommande, idProduit);
                        dgvLigneCommande.DataSource = GestionLigneDeCommandes.getLesLigneCommandes();
                        MessageBox.Show("La ligne de commande a été supprimée avec succès.");
                        EffacerContenuTextBoxLigneCommande();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erreur lors de la suppression : " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne à supprimer.");
            }
        }

        private void dgvLigneCommande_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvLigneCommande.CurrentRow;
                if (row != null)
                {
                    txtBoxIdCommande.Text = row.Cells["idCommande"].Value.ToString();
                    txtBoxIdProduit.Text = row.Cells["idProduit"].Value.ToString();
                    txtBoxQuantite.Text = row.Cells["quantite"].Value.ToString();
                    txtBoxPrixUnitaire.Text = row.Cells["prixUnitaire"].Value.ToString();
                    txtBoxSousTotal.Text = row.Cells["sousTotal"].Value.ToString();
                }
            }
            catch (Exception)
            {
                // Ignorer les erreurs silencieusement
            }
        }

        private void txtBoxRechercherLigneCommande_TextChanged(object sender, EventArgs e)
        {
            string recherche = txtBoxRechercherLigneCommande.Text.ToLower();
            DataGridViewRowCollection rows = dgvLigneCommande.Rows;

            foreach (DataGridViewRow row in rows)
            {
                bool found = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(recherche))
                    {
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    row.Selected = true;
                    dgvLigneCommande.CurrentCell = row.Cells[0];
                    dgvLigneCommande.FirstDisplayedScrollingRowIndex = row.Index;
                    break;
                }
            }
        }

        #region méthodes utilitaires

        private void EffacerContenuTextBoxLigneCommande()
        {
            txtBoxIdCommande.Text = string.Empty;
            txtBoxIdProduit.Text = string.Empty;
            txtBoxQuantite.Text = string.Empty;
            txtBoxPrixUnitaire.Text = string.Empty;
            txtBoxSousTotal.Text = string.Empty;
        }

        public void Bouton_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        public void Bouton_MouseLeave(object sender, EventArgs e)
        {
            Cursor = CurseurAvant;
        }

        #endregion
    }
}
