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

namespace prin_boutique
{
    public partial class FrmDemarrage : Form
    {
        public Cursor CurseurAvant;
        public FrmDemarrage()
        {
            InitializeComponent();
            this.FormClosed += FrmDemarrage_FormClosed;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmDemarrage_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Arrête l'exécution de l'application lorsque le formulaire FrmDemarrage est fermé
            Application.Exit();
        }

        private void FrmDemarrage_Load(object sender, EventArgs e)
        {
            this.Text = $"Accueil - Connecté en tant que : {MysqlConfig.UTILISATEUR}";
        }

        #region ouvrir

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionClients Formulaire = new FrmGestionClients(); 
            Formulaire.Show();
        }

        private void categorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionCategories Formulaire = new FrmGestionCategories();
            Formulaire.Show();
        }

        private void commandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionCommandes Formulaire = new FrmGestionCommandes();
            Formulaire.Show();
        }

        private void fournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionFournisseurs Formulaire = new FrmGestionFournisseurs();
            Formulaire.Show();
        }

        private void lignedecommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionLignedecommandes Formulaire = new FrmGestionLignedecommandes();
            Formulaire.Show();
        }

        private void produitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionProduits Formulaire = new FrmGestionProduits();
            Formulaire.Show();
        }
        #endregion

        private void pnlAccueil_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gestionCommandeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionDeLaCommande Formulaire = new FrmGestionDeLaCommande();
            Formulaire.Show();
        }
    }
}
