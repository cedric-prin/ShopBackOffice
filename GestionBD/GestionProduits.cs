using GestionBD.MySQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBD
{
    public class GestionProduits
    {
        /// <summary>
        /// Retourne la liste de tous les clients
        /// </summary>
        /// <returns></returns>
        public static DataTable getTuplesByProduits()
        {
            return GestionBoutique.getTuplesRequeteSelect("select * from produit", "TousLesProduits");
        }
          
        /// <summary>
        /// Retourne le nombre de clients
        /// </summary>
        /// <returns></returns>
        public static int getNbTuplesByProduits()
        {
            return Convert.ToInt16(GestionBoutique.getResultatRequeteScalaire("select count(*) from produit"));
        }

        /// <summary>
        /// Ajoute un client
        /// </summary>
        /// <param name="nom">Nom du client</param>
        /// <param name="description">Prénom du client</param>
        /// <param name="prix">Rue du client</param>
        /// <param name="image">Rue du client</param>
        /// <param name="idCategorie">Code postal du client</param>
        /// <param name="idFournisseur">Ville du client</param>
        public static void ajouterByProduits(string nom, string description, float prix, string image, int idCategorie, int idFournisseur)
        {
            GestionBoutique.executerRequeteAction("INSERT INTO commande (nom, description, prix, image, idCategorie, idFournisseur) VALUES ('" + nom + "','" + description + "', '" + prix + "', '" + image + "', '" + idCategorie + "' , '" + idFournisseur + "')");
        }

        /// <summary>
        /// Modifie les informations d'un client
        /// </summary>
        /// <param name="nom">Nom du client</param>
        /// <param name="description">Prénom du client</param>
        /// <param name="prix">Rue du client</param>
        /// <param name="image">Rue du client</param>
        /// <param name="idCategorie">Code postal du client</param>
        /// <param name="idFournisseur">Ville du client</param>
        public static void modifierByProduits(int id, string nom, string description, float prix, string image,  int idCategorie, int idFournisseur)
        {
            GestionBoutique.executerRequeteAction("UPDATE Produit SET nom = '" + nom + "',description = '" + description + "',prix = '" + prix + "',image = '" + image + "', idCategorie =" + idCategorie + ",idFournisseur='" + idFournisseur + "' WHERE id = " + id);
        }

        /// <summary>
        /// Supprime un client
        /// </summary>
        /// <param name="id">Identifiant du client à supprimer</param>
        public static void supprimerByProduits(int id)
        {
            // Remarque : Si l'on veut que la suppression supprime aussi les commandes et lignesCommandes associées
            // Il faut alors ajouter sur les clés étrangères "ON DELETE CASCADE"

            GestionBoutique.executerRequeteAction("DELETE FROM produit WHERE id = " + id);
        }

        /// <summary>
        /// Retourne un produit par son id
        /// </summary>
        public static DataTable getTupleById(object idProduit)
        {
            return MySQL.GestionBoutique.getTuplesRequeteSelect($"SELECT * FROM produit WHERE id = {idProduit}", "ProduitById");
        }
    }
}
