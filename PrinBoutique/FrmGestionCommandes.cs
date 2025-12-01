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
    public partial class FrmGestionCommandes : Form
    {

        #region Champs

        public Cursor CurseurAvant;
        public FrmGestionCommandes()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        #endregion

        #region méthodes évennement

        private void FrmGestionCommandes_Load(object sender, EventArgs e)
        {
            GestionBoutique.seConnecter();
            dgvListeCommandes.DataSource = GestionCommandes.getTuplesByCommandes();
            GestionInterface.coloriserDataGrid(dgvListeCommandes);

            btnAjouterCommande.MouseEnter += Bouton_MouseEnter;
            btnAjouterCommande.MouseLeave += Bouton_MouseLeave;
            btnModifierCommande.MouseEnter += Bouton_MouseEnter;
            btnModifierCommande.MouseLeave += Bouton_MouseLeave;
            btnSupprimerCommande.MouseEnter += Bouton_MouseEnter;
            btnSupprimerCommande.MouseLeave += Bouton_MouseLeave;

            EffacerContenuTextBoxCommandes();
            this.Text = $"Gestion des commandes - Connecté en tant que : {MysqlConfig.UTILISATEUR}";
        }

        private void dgvListeCommandes_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                // Récupérer les valeurs des colonnes du client sélectionné dans le DataGridView
                DataGridViewRow row = dgvListeCommandes.CurrentRow;
                if (row != null)
                {
                    string date = row.Cells["date"].Value.ToString();
                    int idClient = Convert.ToInt32(row.Cells["idClient"].Value);

                    // Afficher les données du client dans les TextBox correspondantes
                    txtBoxDate.Text = date;
                    string idClientAsString = idClient.ToString();
                    txtBoxidClient.Text = idClientAsString;
                }
            }
            catch (Exception)
            {

            }
        }
    
        private void btnAjouterCommandes_Click(object sender, EventArgs e)
        {
            DateTime date = DateTime.Parse(txtBoxDate.Text);
            int idClient = int.Parse(txtBoxidClient.Text);

            // Appeler votre méthode btnAjouter_Click avec les valeurs récupérées
            GestionCommandes.ajouterByCommandes(date, idClient);
            dgvListeCommandes.DataSource = GestionCommandes.getTuplesByCommandes();
            MessageBox.Show("La commande a été ajouter avec succès.");
        }

        private void btnModifierCommandes_Click(object sender, EventArgs e)
        {
            if (dgvListeCommandes.SelectedRows.Count > 0)
            {
                // Récupérer les valeurs des champs
                int id = Convert.ToInt32(dgvListeCommandes.SelectedRows[0].Cells["id"].Value);
                DateTime date = DateTime.Parse(txtBoxDate.Text);
                int idClient = int.Parse(txtBoxidClient.Text);

                GestionCommandes.modifierByCommandes(id, date, idClient);
                dgvListeCommandes.DataSource = GestionCommandes.getTuplesByCommandes();
                MessageBox.Show("La commande a été modifier avec succès.");
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une commande à modifier.");
            }
        }

        private void btnSupprimerCommandes_Click(object sender, EventArgs e)
        {
            if (dgvListeCommandes.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvListeCommandes.SelectedRows[0].Cells["id"].Value);

                foreach (DataGridViewRow item in dgvListeCommandes.SelectedRows)
                {
                    dgvListeCommandes.Rows.Remove(item);
                }

                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer cette commande ?", "Confirmation de suppresion", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    GestionCommandes.supprimerByCommandes(id);
                    dgvListeCommandes.DataSource = GestionCommandes.getTuplesByCommandes();
                    MessageBox.Show("La commande a été supprimé avec succès.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une commande à supprimer.");
            }
        }
        

        private void txtBoxRechercherCommande_TextChanged(object sender, EventArgs e)
        {
            string recherche = txtBoxRechercherCommande.Text.ToLower(); // Convertir la recherche en minuscules pour une correspondance insensible à la casse
            DataGridViewRowCollection rows = dgvListeCommandes.Rows;

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
                    dgvListeCommandes.CurrentCell = row.Cells[0]; // Définir la cellule sélectionnée sur la première cellule de la ligne
                    dgvListeCommandes.FirstDisplayedScrollingRowIndex = row.Index; // Faire défiler le DataGridView pour afficher la ligne sélectionnée
                    break;
                }
            }
        }

#endregion

        #region méthodes

        private void EffacerContenuTextBoxCommandes()
        {
            // Efface le contenu de chaque TextBox
            txtBoxDate.Text = string.Empty;
            txtBoxidClient.Text = string.Empty;
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

        private void produitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmGestionProduits Formulaire = new FrmGestionProduits();
            Formulaire.Show();
        }
        #endregion


        private void gestionCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionDeLaCommande Formulaire = new FrmGestionDeLaCommande();
            Formulaire.Show();
        }
    }
}
