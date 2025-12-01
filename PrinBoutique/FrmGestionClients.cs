using GestionBD.MySQL;
using PrinBoutique;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace prin_boutique
{
    public partial class FrmGestionClients : System.Windows.Forms.Form
    {

        #region Champs

        public Cursor CurseurAvant;
        public FrmGestionClients()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        #endregion


        #region méthodes évennement
        private void FrmGestionClients_Load(object sender, EventArgs e)
        {
            GestionBoutique.seConnecter();
            dgvListeClients.DataSource = GestionClients.getTuplesByClients();
            GestionInterface.coloriserDataGrid(dgvListeClients);

            btnAjouterClient.MouseEnter += Bouton_MouseEnter;
            btnAjouterClient.MouseLeave += Bouton_MouseLeave;
            btnModifierClient.MouseEnter += Bouton_MouseEnter;
            btnModifierClient.MouseLeave += Bouton_MouseLeave;
            btnSupprimerClient.MouseEnter += Bouton_MouseEnter;
            btnSupprimerClient.MouseLeave += Bouton_MouseLeave;

            EffacerContenuTextBoxClients();
            this.Text = $"Gestion des clients - Connecté en tant que : {MysqlConfig.UTILISATEUR}";
        }

        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            if (ValiderSaisie()) // Si la saisie est valide
            {
                // Récupérer les valeurs des champs
                string nom = txtBoxNom.Text;
                string prenom = txtBoxPrenom.Text;
                string rue = txtBoxRue.Text;
                string codePostal = txtBoxCP.Text;
                string ville = txtBoxVille.Text;
                string tel = txtBoxTel.Text;
                string email = txtBoxEmail.Text;

                // Appeler votre méthode btnAjouter_Click avec les valeurs récupérées
                GestionClients.ajouterByClients(nom, prenom, rue, codePostal, ville, tel, email);
                dgvListeClients.DataSource = GestionClients.getTuplesByClients();
                MessageBox.Show("Le client a été ajouté avec succès.");
            }
        }

        private void btnModifierClient_Click(object sender, EventArgs e)
        {
            if (dgvListeClients.SelectedRows.Count > 0)
            {
                if (ValiderSaisie()) // Si la saisie est valide
                {
                    // Récupérer les valeurs des champs
                    int id = Convert.ToInt32(dgvListeClients.SelectedRows[0].Cells["id"].Value);
                    string nom = txtBoxNom.Text;
                    string prenom = txtBoxPrenom.Text;
                    string rue = txtBoxRue.Text;
                    int codePostal = Convert.ToInt32(txtBoxCP.Text);
                    string ville = txtBoxVille.Text;
                    string tel = txtBoxTel.Text;
                    string email = txtBoxEmail.Text;

                    GestionClients.modifierByClients(id, nom, prenom, rue, codePostal, ville, tel, email);
                    dgvListeClients.DataSource = GestionClients.getTuplesByClients();
                    MessageBox.Show("Le client a été modifié avec succès.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un client à modifier.");
            }
        }

        private void btnSupprimerClient_Click(object sender, EventArgs e)
        {
            if (dgvListeClients.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dgvListeClients.SelectedRows[0].Cells["id"].Value);

                foreach (DataGridViewRow item in dgvListeClients.SelectedRows)
                {
                    dgvListeClients.Rows.Remove(item);
                }

                DialogResult result = MessageBox.Show("Voulez-vous vraiment supprimer ce client ?", "Confirmation de suppresion", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes) 
                {
                    GestionClients.supprimerByClients(id);
                    dgvListeClients.DataSource = GestionClients.getTuplesByClients();
                    MessageBox.Show("Le client a été supprimé avec succès.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un client à supprimer.");
            }
        }

        private void dgvListeClients_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                // Récupérer les valeurs des colonnes du client sélectionné dans le DataGridView
                DataGridViewRow row = dgvListeClients.CurrentRow;
                if (row != null)
                {
                    string nom = row.Cells["Nom"].Value.ToString();
                    string prenom = row.Cells["Prenom"].Value.ToString();
                    string rue = row.Cells["Rue"].Value.ToString();
                    int codePostal = Convert.ToInt32(row.Cells["CodePostal"].Value);
                    string ville = row.Cells["Ville"].Value.ToString();
                    string tel = row.Cells["Tel"].Value.ToString();
                    string email = row.Cells["Email"].Value.ToString();

                    // Afficher les données du client dans les TextBox correspondantes
                    txtBoxNom.Text = nom;
                    txtBoxPrenom.Text = prenom;
                    txtBoxRue.Text = rue;
                    txtBoxCP.Text = codePostal.ToString();
                    txtBoxVille.Text = ville;
                    txtBoxTel.Text = tel;
                    txtBoxEmail.Text = email;
                }
            }
            catch (Exception)
            {

            }
        }

        #endregion

        #region méthodes

        private void EffacerContenuTextBoxClients()
        {
            // Efface le contenu de chaque TextBox
            txtBoxNom.Text = string.Empty;
            txtBoxPrenom.Text = string.Empty;
            txtBoxRue.Text = string.Empty;
            txtBoxCP.Text = string.Empty;
            txtBoxVille.Text = string.Empty;
            txtBoxTel.Text = string.Empty;
            txtBoxEmail.Text = string.Empty;
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

        public bool ValiderSaisie()
        {
            // Vérifier le nom : pas de chiffres, et ne doit pas être vide
            string nom = txtBoxNom.Text;
            if (string.IsNullOrEmpty(nom) || !Regex.IsMatch(nom, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Le nom doit être valide (lettres seulement).");
                return false;
            }

            // Vérifier le prénom : pas de chiffres, et ne doit pas être vide
            string prenom = txtBoxPrenom.Text;
            if (string.IsNullOrEmpty(prenom) || !Regex.IsMatch(prenom, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Le prénom doit être valide (lettres seulement).");
                return false;
            }

            // Vérifier le code postal : 5 chiffres uniquement
            string codePostal = txtBoxCP.Text;
            if (string.IsNullOrEmpty(codePostal) || !Regex.IsMatch(codePostal, @"^\d{5}$"))
            {
                MessageBox.Show("Le code postal doit être constitué de 5 chiffres.");
                return false;
            }

            // Vérifier la ville : pas de chiffres, et ne doit pas être vide
            string ville = txtBoxVille.Text;
            if (string.IsNullOrEmpty(ville) || !Regex.IsMatch(ville, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("La ville doit être valide (lettres seulement).");
                return false;
            }

            // Vérifier le téléphone : format standard (ex: 0123456789)
            string tel = txtBoxTel.Text;
            if (string.IsNullOrEmpty(tel) || !Regex.IsMatch(tel, @"^\d{10}$"))
            {
                MessageBox.Show("Le numéro de téléphone doit comporter exactement 10 chiffres.");
                return false;
            }

            // Vérifier l'email : format standard d'un email
            string email = txtBoxEmail.Text;
            if (string.IsNullOrEmpty(email) || !Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("L'email n'est pas valide.");
                return false;
            }

            return true;
        }

        #endregion

        #region ouvrir

        private void categorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmGestionCategories Formulaire = new FrmGestionCategories();
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

        private void ligneCommandeToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void txtBoxRechercherClient_TextChanged(object sender, EventArgs e)
        {
            string recherche = txtBoxRechercherClient.Text.ToLower(); // Convertir la recherche en minuscules pour une correspondance insensible à la casse
            DataGridViewRowCollection rows = dgvListeClients.Rows;

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
                    dgvListeClients.CurrentCell = row.Cells[0]; // Définir la cellule sélectionnée sur la première cellule de la ligne
                    dgvListeClients.FirstDisplayedScrollingRowIndex = row.Index; // Faire défiler le DataGridView pour afficher la ligne sélectionnée
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