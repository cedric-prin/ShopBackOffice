using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using GestionBD.MySQL;
using Microsoft.Win32;

namespace GestionBD
{
    public class GestionPS
    {
        #region Gestion des Produits

        public static DataTable getDetailsProduits()
        {
            return GestionBoutique.executerRequeteSelect("Call '_selectDetailsProduits'", "DétailsProduits");
        }

        public static void supprimerProduit(int idProduit)
        {
            GestionBoutique.executerRequeteAction("Call '_deleteProduitsById'('" + idProduit + "')");
        }

        #endregion

        #region Gestion des Commandes

        public static double getNBCommandesByClient_PS(int idClient) 
        {
            return GestionBoutique.executerRequeteScalaire("CALL '_selectNbCommandesByClient_PS'('" + idClient + "')");
        }

        public static double getNBCommandesByClient_FS(int idClient)
        {
            return GestionBoutique.executerRequeteScalaire("SELECT _selectNbCommandesByClient_FS('" + idClient + "')");
        }

        #endregion

    }
}