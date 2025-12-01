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
    public partial class FrmGestionCategories : Form
    {
        public Cursor CurseurAvant;
        public FrmGestionCategories()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmGestionCategories_Load(object sender, EventArgs e)
        {
            GestionBoutique.seConnecter();
            dgvListeCategories.DataSource = GestionCategories.getTuplesByCategories();
            GestionInterface.coloriserDataGrid(dgvListeCategories);

            btnAjouterCategorie.MouseEnter += Bouton_MouseEnter;
            btnAjouterCategorie.MouseLeave += Bouton_MouseLeave;
            btnModifierCategorie.MouseEnter += Bouton_MouseEnter;
            btnModifierCategorie.MouseLeave += Bouton_MouseLeave;
            btnSupprimerCategorie.MouseEnter += Bouton_MouseEnter;
            btnSupprimerCategorie.MouseLeave += Bouton_MouseLeave;

            EffacerContenuTextBoxCategories();
            this.Text = $"Gestion des catégories - Connecté en tant que : {MysqlConfig.UTILISATEUR}";
        }

        

        private void btnAjouterCategorie_Click(object sender, EventArgs e)
        {
            // Récupérer les valeurs des champs
            string libelle = txtBoxLibelle.Text;

            // Appeler votre méthode btnAjouter_Click avec les valeurs récupérées
            GestionCategories.ajouterByCategories(libelle);
            dgvListeCategories.DataSource = GestionCategories.getTuplesByCategories();
            MessageBox.Show("La catégorie a été ajouter avec succès.");
        }

        private void btnModifierCategorie_Click(object sender, EventArgs e)
        {
            if (dgvListeCategories.SelectedRows.Count > 0)
            {
                // Récupérer les valeurs des champs
                int id = Convert.ToInt32(dgvListeCategories.SelectedRows[0].Cells["id"].Value);
                string libelle = txtBoxLibelle.Text;

                GestionCategories.modifierByCategories(id, libelle);
                dgvListeCategories.DataSource = GestionCategories.getTuplesByCategories();
                MessageBox.Show("La catégorie a été modifier avec succès.");
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une catégorie à modifier.");
            }
        }

        private void btnSupprimerCategorie_Click(object sender, EventArgs e)
        {
            if (dgvListeCategories.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvListeCategories.SelectedRows[0].Cells["id"].Value);

                foreach (DataGridViewRow item in dgvListeCategories.SelectedRows)
                {
                    dgvListeCategories.Rows.Remove(item);
                }

                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer cette catégorie ?", "Confirmation de suppresion", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    GestionCategories.supprimerByCategories(id);
                    dgvListeCategories.DataSource = GestionCategories.getTuplesByCategories();
                    MessageBox.Show("La catégorie a été supprimé avec succès.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une catégorie à supprimer.");
            }
        }

        #region ouvrir

        private void commandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmGestionCommandes Formulaire = new FrmGestionCommandes();
            Formulaire.Show();
        }

        private void fournisseurToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmGestionClients Formulaire = new FrmGestionClients();
            Formulaire.Show();
        }
        #endregion

        private void dgvListeCategories_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                // Récupérer les valeurs des colonnes du client sélectionné dans le DataGridView
                DataGridViewRow row = dgvListeCategories.CurrentRow;
                if (row != null)
                {
                    string libelle = row.Cells["Libelle"].Value.ToString();
                    // Afficher les données du client dans les TextBox correspondantes
                    txtBoxLibelle.Text = libelle;
                }
            }
            catch (Exception)
            {

            }
        }

        private void EffacerContenuTextBoxCategories()
        {
            // Efface le contenu de chaque TextBox
            txtBoxLibelle.Text = string.Empty;
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

        private void txtBoxRechercherCategorie_TextChanged(object sender, EventArgs e)
        {
            string recherche = txtBoxRechercherCategorie.Text.ToLower(); // Convertir la recherche en minuscules pour une correspondance insensible à la casse
            DataGridViewRowCollection rows = dgvListeCategories.Rows;

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
                    dgvListeCategories.CurrentCell = row.Cells[0]; // Définir la cellule sélectionnée sur la première cellule de la ligne
                    dgvListeCategories.FirstDisplayedScrollingRowIndex = row.Index; // Faire défiler le DataGridView pour afficher la ligne sélectionnée
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
