using GestionBD.MySQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace prin_boutique
{
    public partial class FrmConnexion : Form
    {

        public Cursor CurseurAvant;

        public FrmConnexion()
        {
            InitializeComponent();
            this.FormClosed += FrmConnexion_FormClosed;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmConnexion_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Arrête l'exécution de l'application lorsque le formulaire FrmConnexion est fermé
            Application.Exit();
        }

        private void Connecter()
        {
            try
            {
                // Stocke l'utilisateur et le mot de passe dans MysqlConfig pour la session
                MysqlConfig.UTILISATEUR = txtBoxIdentifiant.Text;
                MysqlConfig.MOT_DE_PASSE = txtBoxMdp.Text;
                GestionBoutique.seConnecter("localhost", "prin_boutique", txtBoxIdentifiant.Text, txtBoxMdp.Text);
                FrmDemarrage formulaire = new FrmDemarrage();
                formulaire.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            Connecter();
        }
        private void FrmConnexion_Load(object sender, EventArgs e)
        {
            txtBoxIdentifiant.Select();

            this.KeyPreview = true;
            this.KeyDown += FrmConnexion_KeyDown;
            btnConnexion.MouseEnter += Bouton_MouseEnter;
            btnConnexion.MouseLeave += Bouton_MouseLeave;
        }

        private void FrmConnexion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Connecter();
            }
        }

        private void Bouton_MouseEnter(object sender, EventArgs e)
        {
            // Changez le curseur de la souris lorsqu'elle survole un bouton
            Cursor = Cursors.Hand; // Vous pouvez également utiliser d'autres types de curseurs selon vos besoins
        }

        private void Bouton_MouseLeave(object sender, EventArgs e)
        {
            // Rétablissez le curseur précédent lorsque la souris quitte le bouton
            Cursor = CurseurAvant;
        }
    }
}
