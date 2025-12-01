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
    public partial class FrmGestionFournisseurs : Form
    {
        public Cursor CurseurAvant;
        public FrmGestionFournisseurs()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmGestionFournisseurs_Load(object sender, EventArgs e)
        {
            GestionBoutique.seConnecter();
            dgvListeFournisseurs.DataSource = GestionFournisseurs.getTuplesByFournisseur();
            GestionInterface.coloriserDataGrid(dgvListeFournisseurs);

            // Affiche le nom de l'utilisateur connecté dans le titre du formulaire
            this.Text = $"Gestion de fournisseur ... - Connecté en tant que : {MysqlConfig.UTILISATEUR}";

            btnAjouterFournisseur.MouseEnter += Bouton_MouseEnter;
            btnAjouterFournisseur.MouseLeave += Bouton_MouseLeave;
            btnModifierFournisseur.MouseEnter += Bouton_MouseEnter;
            btnModifierFournisseur.MouseLeave += Bouton_MouseLeave;
            btnSupprimerFournisseur.MouseEnter += Bouton_MouseEnter;
            btnSupprimerFournisseur.MouseLeave += Bouton_MouseLeave;

            EffacerContenuTextBoxFournisseur();
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

        private void lignedecommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmGestionLignedecommandes Formulaire = new FrmGestionLignedecommandes();
            Formulaire.Show();
        }

        private void produitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmGestionProduits Formulaire = new FrmGestionProduits();
            Formulaire.Show();
        }
        #endregion

        private void btnAjouterFournisseur_Click(object sender, EventArgs e)
        {
            // Récupérer les valeurs des champs
            string nom = txtBoxNomFournisseur.Text;
            string rue = txtBoxRueFournisseur.Text;
            int codePostal = Convert.ToInt32(txtBoxCPFournisseur.Text);
            string ville = txtBoxVilleFournisseur.Text;
            string tel = txtBoxTelFournisseur.Text;
            string email = txtBoxEmailFournisseur.Text;

            // Appeler votre méthode btnAjouter_Click avec les valeurs récupérées
            GestionFournisseurs.ajouterByFournisseur(nom, rue, codePostal, ville, tel, email);
            dgvListeFournisseurs.DataSource = GestionFournisseurs.getTuplesByFournisseur();
            MessageBox.Show("Le produit a été ajouter avec succès.");
        }

        private void btnModifierFournisseur_Click(object sender, EventArgs e)
        {
            if (dgvListeFournisseurs.SelectedRows.Count > 0)
            {
                // Récupérer les valeurs des champs
                int id = Convert.ToInt32(dgvListeFournisseurs.SelectedRows[0].Cells["id"].Value);
                string nom = txtBoxNomFournisseur.Text;
                string rue = txtBoxRueFournisseur.Text;
                int codePostal = Convert.ToInt32(txtBoxCPFournisseur.Text);
                string ville = txtBoxVilleFournisseur.Text;
                string tel = txtBoxTelFournisseur.Text;
                string email = txtBoxEmailFournisseur.Text;

                GestionFournisseurs.modifierByFournisseur(id, nom, rue, codePostal, ville, tel, email);
                dgvListeFournisseurs.DataSource = GestionFournisseurs.getTuplesByFournisseur();
                MessageBox.Show("Le produit a été modifier avec succès.");
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un produit à modifier.");
            }
        }

        private void btnSupprimerFournisseur_Click(object sender, EventArgs e)
        {
            if (dgvListeFournisseurs.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvListeFournisseurs.SelectedRows[0].Cells["id"].Value);

                foreach (DataGridViewRow item in dgvListeFournisseurs.SelectedRows)
                {
                    dgvListeFournisseurs.Rows.Remove(item);
                }

                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer ce produit ?", "Confirmation de suppresion", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    GestionFournisseurs.supprimerByFournisseur(id);
                    dgvListeFournisseurs.DataSource = GestionFournisseurs.getTuplesByFournisseur();
                    MessageBox.Show("Le produit a été supprimé avec succès.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un produit à supprimer.");
            }
        }

        #region méthodes

        private void EffacerContenuTextBoxFournisseur()
        {
            // Efface le contenu de chaque TextBox
            txtBoxNomFournisseur.Text = string.Empty;
            txtBoxRueFournisseur.Text = string.Empty;
            txtBoxVilleFournisseur.Text = string.Empty;
            txtBoxCPFournisseur.Text = string.Empty;
            txtBoxTelFournisseur.Text = string.Empty;
            txtBoxEmailFournisseur.Text = string.Empty;
        }

        public void Bouton_MouseEnter(object sender, EventArgs e)
        {
            // Changez le curseur de la souris lorsqu'elle survole un bouton
            Cursor = Cursors.Hand; // Vous pouvez également utiliser d'autres types de curseurs selon vos besoins
        }
        public void Bouton_MouseLeave(object sender, EventArgs e)
        {
            // Rétablissez le curseur précédent lorsque la souris quitte le bouton
            Cursor = CurseurAvant;
        }

        #endregion

        private void txtBoxRechercherFournisseur_TextChanged(object sender, EventArgs e)
        {
            string recherche = txtBoxRechercherFournisseur.Text.ToLower(); // Convertir la recherche en minuscules pour une correspondance insensible à la casse
            DataGridViewRowCollection rows = dgvListeFournisseurs.Rows;

            // Parcourir chaque ligne du DataGridView
            foreach (DataGridViewRow row in rows)
            {
                // Vérifier si le texte de recherche est trouvé dans une des cellules de la ligne
                bool found = false;
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(recherche))
                    {
                        found = true;
                        break;
                    }
                }

                // Si le texte de recherche est trouvé dans une des cellules de la ligne, déplacer cette ligne en haut
                if (found)
                {
                    row.Selected = true; // Sélectionner la ligne
                    dgvListeFournisseurs.CurrentCell = row.Cells[0]; // Définir la cellule sélectionnée sur la première cellule de la ligne
                    dgvListeFournisseurs.FirstDisplayedScrollingRowIndex = row.Index; // Faire défiler le DataGridView pour afficher la ligne sélectionnée
                    break;
                }
            }
        }

        private void dgvListeFournisseurs_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                // Récupérer les valeurs des colonnes du client sélectionné dans le DataGridView
                DataGridViewRow row = dgvListeFournisseurs.CurrentRow;
                if (row != null)
                {
                    string nom = row.Cells["Nom"].Value.ToString();
                    string rue = row.Cells["Rue"].Value.ToString();
                    int codePostal = Convert.ToInt32(row.Cells["CodePostal"].Value);
                    string ville = row.Cells["Ville"].Value.ToString();
                    string tel = row.Cells["Tel"].Value.ToString();
                    string email = row.Cells["Email"].Value.ToString();

                    // Afficher les données du client dans les TextBox correspondantes
                    txtBoxNomFournisseur.Text = nom;
                    txtBoxRueFournisseur.Text = rue;
                    txtBoxCPFournisseur.Text = codePostal.ToString();
                    txtBoxVilleFournisseur.Text = ville;
                    txtBoxTelFournisseur.Text = tel;
                    txtBoxEmailFournisseur.Text = email;
                }
            }
            catch (Exception)
            {

            }
        }

        private void gestionCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionDeLaCommande Formulaire = new FrmGestionDeLaCommande();
            Formulaire.Show();
        }
    }
}
