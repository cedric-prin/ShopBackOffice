using GestionBD;
using GestionBD.MySQL;
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
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace PrinBoutique
{
    public partial class FrmGestionDeLaCommande : Form
    {
        public FrmGestionDeLaCommande()
        {
            InitializeComponent();
        }

        private void FrmGestionDeLaCommande_Load(object sender, EventArgs e)
        {
            // Recharge la liste des clients à chaque ouverture
            DataTable dtClients = GestionClients.getPatronymesByClients();
            comboBoxClient.DataSource = dtClients;
            comboBoxClient.DisplayMember = "Patronyme"; // Affiche "NOM Prénom"
            comboBoxClient.ValueMember = "id"; // Utilise l'id comme valeur
            if (comboBoxClient.Items.Count > 0)
                comboBoxClient.SelectedIndex = 0;

            // Récupère la liste des produits
            DataTable dtProduits = GestionProduits.getTuplesByProduits();
            comboBoxProduit.DataSource = dtProduits;
            comboBoxProduit.DisplayMember = "nom"; // Affiche le nom du produit
            comboBoxProduit.ValueMember = "id"; // Utilise l'id comme valeur
            if (comboBoxProduit.Items.Count > 0)
                comboBoxProduit.SelectedIndex = 0;

            // Initialisation du NumericUpDown
            numUpQte.Minimum = 1;
            numUpQte.Value = 1;

            dataGridViewLigneDeCommandes.DataSource = GestionLigneDeCommandes.getLesLigneCommandes();
            dataGridViewCommande.DataSource = GestionCommandes.getTuplesByCommandes();

            this.Text = $"Gestion de Commande - Connecté en tant que : {MysqlConfig.UTILISATEUR}";
        }

        private void comboBoxClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int idClient;
                if (comboBoxClient.SelectedValue is DataRowView drvClient)
                    idClient = Convert.ToInt32(drvClient["id"]);
                else
                    idClient = Convert.ToInt32(comboBoxClient.SelectedValue);
                DataTable dtClient = GestionClients.getTupleByIdClients(idClient);

                if (dtClient.Rows.Count > 0)
                {
                    DataRow leClient = dtClient.Rows[0];
                    txtBoxNom.Text = leClient["nom"].ToString();
                    txtBoxPrenom.Text = leClient["prenom"].ToString();
                    txtBoxID.Text = leClient["id"].ToString(); // Affiche l'ID du client
                }
                else
                {
                    txtBoxNom.Text = "";
                    txtBoxPrenom.Text = "";
                    txtBoxID.Text = "";
                }
            }
            catch (Exception)
            {
                // Gère l'exception si besoin
            }
        }

        // Méthode centrale pour actualiser le prix total
        private void ActualiserPrixTotal()
        {
            if (decimal.TryParse(txtBoxPrixUnitaire.Text.Replace('.', ','), out decimal prixUnitaire))
            {
                int quantite = (int)numUpQte.Value;
                decimal total = prixUnitaire * quantite;
                txtBoxPrixTotal.Text = total.ToString("F2");
            }
            else
            {
                txtBoxPrixTotal.Text = "";
            }
        }

        private void comboBoxProduit_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxProduit.SelectedValue == null)
                    return;

                int idProduit;
                if (comboBoxProduit.SelectedValue is DataRowView drvProduit)
                    idProduit = Convert.ToInt32(drvProduit["id"]);
                else
                    idProduit = Convert.ToInt32(comboBoxProduit.SelectedValue);
                DataTable dtProduit = GestionProduits.getTupleById(idProduit);

                if (dtProduit.Rows.Count > 0)
                {
                    DataRow leProduit = dtProduit.Rows[0];

                    // Affiche le prix unitaire
                    txtBoxPrixUnitaire.Text = leProduit["prix"].ToString();
                }
                else
                {
                    txtBoxPrixUnitaire.Text = "";
                }
                // Actualise le prix total automatiquement
                ActualiserPrixTotal();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur : " + ex.Message);
            }
        }

        // Cette méthode doit être la seule reliée à l'événement ValueChanged du NumericUpDown
        public void numUpQte_ValueChanged(object sender, EventArgs e)
        {
            ActualiserPrixTotal();
        }

        private void btnAjouterCommande_Click(object sender, EventArgs e)
        {
            try
            {
                int idClient;
                if (comboBoxClient.SelectedValue is DataRowView drvClient)
                    idClient = Convert.ToInt32(drvClient["id"]);
                else
                    idClient = Convert.ToInt32(comboBoxClient.SelectedValue);
                DateTime date = DateTime.Now;
                int idProduit;
                if (comboBoxProduit.SelectedValue is DataRowView drvProduit)
                    idProduit = Convert.ToInt32(drvProduit["id"]);
                else
                    idProduit = Convert.ToInt32(comboBoxProduit.SelectedValue);
                int quantite = (int)numUpQte.Value;

                decimal prixUnitaire;
                if (!decimal.TryParse(txtBoxPrixUnitaire.Text.Replace('.', ','), out prixUnitaire))
                {
                    MessageBox.Show("Le prix unitaire n'est pas valide !");
                    return;
                }

                decimal sousTotal = prixUnitaire * quantite;
                string moyPaiement = "CB";
                int idLivraison = 1; // valeur par défaut

                // Vérification que l'id client existe
                var dtClientCheck = GestionClients.getTupleByIdClients(idClient);
                if (dtClientCheck.Rows.Count == 0)
                {
                    MessageBox.Show("Le client sélectionné n'existe pas !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int idCommande = GestionCommandes.ajouterEtRecupererId(
                    date.ToString("yyyy-MM-dd HH:mm:ss"),
                    idClient,
                    sousTotal,
                    moyPaiement,
                    idLivraison
                );

                // Ajout de la ligne de commande
                GestionLigneDeCommandes.ajouter(idCommande, idProduit, quantite, prixUnitaire);

                // MessageBox de test pour vérifier les valeurs
                MessageBox.Show($"Ajout ligne : idCommande={idCommande}, idProduit={idProduit}, quantite={quantite}, prixUnitaire={prixUnitaire}");

                // Rafraîchit l'affichage des lignes de commande
                dataGridViewLigneDeCommandes.DataSource = GestionLigneDeCommandes.getLesLigneCommandes();

                MessageBox.Show("Commande et ligne ajoutées !");
                dataGridViewCommande.DataSource = GestionCommandes.getTuplesByCommandes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout de la ligne de commande : " + ex.Message);
            }
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            dataGridViewLigneDeCommandes.DataSource = GestionLigneDeCommandes.getLesLigneCommandes();
            dataGridViewCommande.DataSource = GestionCommandes.getTuplesByCommandes();
        }

        private void btnSuprimerLigneDeCommandes_Click(object sender, EventArgs e)
        {
            if (dataGridViewLigneDeCommandes.SelectedRows.Count > 0)
            {
                // Récupère les identifiants de la ligne sélectionnée
                int idCommande = Convert.ToInt32(dataGridViewLigneDeCommandes.SelectedRows[0].Cells["idcommande"].Value);
                int idProduit = Convert.ToInt32(dataGridViewLigneDeCommandes.SelectedRows[0].Cells["idproduit"].Value);

                DialogResult result = MessageBox.Show(
                    "Voulez-vous vraiment supprimer cette ligne de commande ?",
                    "Confirmation de suppression",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Appel à la méthode de suppression
                    GestionLigneDeCommandes.supprimer(idCommande, idProduit);
                    // Rafraîchit l'affichage
                    dataGridViewLigneDeCommandes.DataSource = GestionLigneDeCommandes.getLesLigneCommandes();
                    MessageBox.Show("Ligne de commande supprimée avec succès !");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne à supprimer.");
            }
        }

        private void btnSupprimerCommande_Click(object sender, EventArgs e)
        {
            if (dataGridViewCommande.SelectedRows.Count > 0)
            {
                // Récupère l'identifiant de la commande sélectionnée
                int idCommande = Convert.ToInt32(dataGridViewCommande.SelectedRows[0].Cells["id"].Value);

                DialogResult result = MessageBox.Show(
                    "Voulez-vous vraiment supprimer cette commande ?\nToutes les lignes associées seront supprimées.",
                    "Confirmation de suppression",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Appel à la méthode de suppression
                    GestionCommandes.supprimerByCommandes(idCommande);
                    // Rafraîchit l'affichage
                    dataGridViewCommande.DataSource = GestionCommandes.getTuplesByCommandes();
                    dataGridViewLigneDeCommandes.DataSource = GestionLigneDeCommandes.getLesLigneCommandes();
                    MessageBox.Show("Commande supprimée avec succès !");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une commande à supprimer.");
            }
        }

        private void btnRecapCmd_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewCommande.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Veuillez sélectionner une commande à récapituler.");
                    return;
                }

                int idCommande = Convert.ToInt32(dataGridViewCommande.SelectedRows[0].Cells["id"].Value);
                DataTable dtCommande = GestionCommandes.getTuplesByCommandes();
                DataRow commande = dtCommande.Select("id = " + idCommande)[0];
                DataTable dtLignes = GestionLigneDeCommandes.getLesLigneCommandes();
                DataRow[] lignes = dtLignes.Select("idCommande = " + idCommande);

                // Chemin du PDF à générer
                string chemin = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"BonCommande_{idCommande}.pdf");

                // Création du document PDF
                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(chemin, FileMode.Create));
                doc.Open();

                // Titre et infos commande
                doc.Add(new Paragraph("Bon de Commande"));
                doc.Add(new Paragraph($"Commande n° {commande["id"]} - Date : {commande["date"]}"));
                doc.Add(new Paragraph($"Client : {commande["idClient"]} - Sous-total : {commande["sousTotal"]}"));
                doc.Add(new Paragraph($"Mode de paiement : {commande["moyPaiement"]}"));
                doc.Add(new Paragraph($"Livraison n° : {commande["idLivraison"]}"));
                doc.Add(new Paragraph(" "));

                // Tableau des lignes de commande
                PdfPTable table = new PdfPTable(4);
                table.AddCell("Produit (ID)");
                table.AddCell("Quantité");
                table.AddCell("Prix unitaire");
                table.AddCell("Sous-total");

                foreach (DataRow ligne in lignes)
                {
                    table.AddCell(ligne["idProduit"].ToString());
                    table.AddCell(ligne["quantite"].ToString());
                    table.AddCell(ligne["prixUnitaire"].ToString());
                    table.AddCell(ligne["sousTotal"].ToString());
                }

                doc.Add(table);
                doc.Add(new Paragraph(" "));
                doc.Close();

                MessageBox.Show($"PDF généré sur le bureau : {chemin}", "Récapitulatif PDF");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur dans le récapitulatif PDF : " + ex.Message);
            }
        }
    }
}
