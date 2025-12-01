using System;
using System.Data;

namespace GestionBD
{
    public class GestionLigneDeCommandes
    {
        /// <summary>
        /// Retourne toutes les lignes de commande
        /// </summary>
        public static DataTable getLesLigneCommandes()
        {
            return MySQL.GestionBoutique.getTuplesRequeteSelect("SELECT * FROM lignedecommande", "ToutesLesLignesDeCommande");
        }

        /// <summary>
        /// Retourne les lignes d'une commande spécifique
        /// </summary>
        public static DataTable getLignesByCommande(int idCommande)
        {
            return MySQL.GestionBoutique.getTuplesRequeteSelect(
                $"SELECT * FROM lignedecommande WHERE idCommande = {idCommande}",
                "LignesDeCommandeParCommande"
            );
        }

        /// <summary>
        /// Ajoute une ligne de commande
        /// </summary>
        public static void ajouter(int idCommande, int idProduit, int quantite, decimal prixUnitaire)
        {
            string requete = $"INSERT INTO lignedecommande (idCommande, idProduit, quantite, prixUnitaire) VALUES ({idCommande}, {idProduit}, {quantite}, {prixUnitaire.ToString(System.Globalization.CultureInfo.InvariantCulture)})";
            MySQL.GestionBoutique.executerRequeteAction(requete);
        }

        /// <summary>
        /// Supprime une ligne de commande
        /// </summary>
        public static void supprimer(int idCommande, int idProduit)
        {
            string requete = $"DELETE FROM lignedecommande WHERE idCommande = {idCommande} AND idProduit = {idProduit}";
            MySQL.GestionBoutique.executerRequeteAction(requete);
        }
    }
}
