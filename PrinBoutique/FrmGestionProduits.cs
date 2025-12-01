using GestionBD;
using GestionBD.MySQL;
using PrinBoutique;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace prin_boutique
{
    public partial class FrmGestionProduits : Form
    {
        public Cursor CurseurAvant;
        public FrmGestionProduits()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmGestionProduits_Load(object sender, EventArgs e)
        {
            GestionBoutique.seConnecter();
            dgvListeProduits.DataSource = GestionProduits.getTuplesByProduits();
            GestionInterface.coloriserDataGrid(dgvListeProduits);

            btnAjouterProduits.MouseEnter += Bouton_MouseEnter;
            btnAjouterProduits.MouseLeave += Bouton_MouseLeave;
            btnModifierProduits.MouseEnter += Bouton_MouseEnter;
            btnModifierProduits.MouseLeave += Bouton_MouseLeave;
            btnSupprimerProduits.MouseEnter += Bouton_MouseEnter;
            btnSupprimerProduits.MouseLeave += Bouton_MouseLeave;

            EffacerContenuTextBoxProduits();
            this.Text = $"Gestion des produits - Connecté en tant que : {MysqlConfig.UTILISATEUR}";
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

        private void lignedecommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmGestionLignedecommandes Formulaire = new FrmGestionLignedecommandes();
            Formulaire.Show();
        }
        #endregion

        private void dgvListeProduits_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                // Récupérer les valeurs des colonnes du client sélectionné dans le DataGridView
                DataGridViewRow row = dgvListeProduits.CurrentRow;
                if (row != null)
                {
                    string nom = row.Cells["Nom"].Value.ToString();
                    string description = row.Cells["Description"].Value.ToString();
                    float prix = Convert.ToSingle(row.Cells["Prix"].Value);
                    string image = row.Cells["Image"].Value.ToString();
                    int idCategorie = Convert.ToInt32(row.Cells["IdCategorie"].Value);
                    int idFournisseur = Convert.ToInt32(row.Cells["IdFournisseur"].Value);

                    // Afficher les données du client dans les TextBox correspondantes
                    txtBoxNomProduit.Text = nom;
                    txtBoxDescription.Text = description;
                    string prixAsString = prix.ToString();
                    txtBoxPrix.Text = prixAsString;
                    txtBoxImage.Text = image;
                    string idCategorieAsString = idCategorie.ToString();
                    txtBoxidCategorie.Text = idCategorieAsString;
                    string idFournisseurAsString = idFournisseur.ToString();
                    txtBoxidFournisseur.Text = idFournisseurAsString;
                }
            }
            catch (Exception)
            {

            }
        }

        private void btnAjouterProduits_Click(object sender, EventArgs e)
        {
            // Récupérer les valeurs des champs
            string nom = txtBoxNomProduit.Text;
            string description = txtBoxDescription.Text;
            float prix = Convert.ToSingle(txtBoxPrix.Text);
            string image = txtBoxImage.Text;
            int idCategorie = Convert.ToInt32(txtBoxidCategorie.Text);
            int idFournisseur = Convert.ToInt32(txtBoxidFournisseur.Text);

            // Appeler votre méthode btnAjouter_Click avec les valeurs récupérées
            GestionProduits.ajouterByProduits(nom, description, prix, image, idCategorie, idFournisseur);
            dgvListeProduits.DataSource = GestionProduits.getTuplesByProduits();
            MessageBox.Show("Le produit a été ajouter avec succès.");
        }

        private void btnModifierProduits_Click(object sender, EventArgs e)
        {
            if (dgvListeProduits.SelectedRows.Count > 0)
            {
                // Récupérer les valeurs des champs
                int id = Convert.ToInt32(dgvListeProduits.SelectedRows[0].Cells["id"].Value);
                string nom = txtBoxNomProduit.Text;
                string description = txtBoxDescription.Text;
                float prix = Convert.ToSingle(txtBoxPrix.Text);
                string image = txtBoxImage.Text;
                int idCategorie = Convert.ToInt32(txtBoxidCategorie.Text);
                int idFournisseur = Convert.ToInt32(txtBoxidFournisseur.Text);

                GestionProduits.modifierByProduits(id, nom, description, prix, image, idCategorie, idFournisseur);
                dgvListeProduits.DataSource = GestionProduits.getTuplesByProduits();
                MessageBox.Show("Le produit a été modifier avec succès.");
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un produit à modifier.");
            }
        }

        private void btnSupprimerProduits_Click(object sender, EventArgs e)
        {
            if (dgvListeProduits.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvListeProduits.SelectedRows[0].Cells["id"].Value);

                foreach (DataGridViewRow item in dgvListeProduits.SelectedRows)
                {
                    dgvListeProduits.Rows.Remove(item);
                }

                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer ce produit ?", "Confirmation de suppresion", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    GestionProduits.supprimerByProduits(id);
                    dgvListeProduits.DataSource = GestionProduits.getTuplesByProduits();
                    MessageBox.Show("Le produit a été supprimé avec succès.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un produit à supprimer.");
            }
        }
        private void EffacerContenuTextBoxProduits()
        {
            // Efface le contenu de chaque TextBox
            txtBoxNomProduit.Text = string.Empty;
            txtBoxDescription.Text = string.Empty;
            txtBoxPrix.Text = string.Empty;
            txtBoxImage.Text = string.Empty;
            txtBoxidCategorie.Text = string.Empty;
            txtBoxidFournisseur.Text = string.Empty;
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

        private void txtBoxRechercherProduit_TextChanged(object sender, EventArgs e)
        {
            string recherche = txtBoxRechercherProduit.Text.ToLower(); // Convertir la recherche en minuscules pour une correspondance insensible à la casse
            DataGridViewRowCollection rows = dgvListeProduits.Rows;

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
                    dgvListeProduits.CurrentCell = row.Cells[0]; // Définir la cellule sélectionnée sur la première cellule de la ligne
                    dgvListeProduits.FirstDisplayedScrollingRowIndex = row.Index; // Faire défiler le DataGridView pour afficher la ligne sélectionnée
                    break;
                }
            }
        }

        private void gestionCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionDeLaCommande Formulaire = new FrmGestionDeLaCommande();
            Formulaire.Show();
        }
    }
}
