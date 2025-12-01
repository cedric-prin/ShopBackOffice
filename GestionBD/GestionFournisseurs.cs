using GestionBD.MySQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBD
{
    public class GestionFournisseurs
    {
        /// <summary>
        /// Retourne la liste de tous les clients
        /// </summary>
        /// <returns></returns>
        public static DataTable getTuplesByFournisseur()
        {
            return GestionBoutique.getTuplesRequeteSelect("select * from fournisseur", "ToutLesFournisseurs");
        }

        /// <summary>
        /// Retourne le nombre de clients
        /// </summary>
        /// <returns></returns>
        public static int getNbTuplesByFournisseur()
        {
            return Convert.ToInt16(GestionBoutique.getResultatRequeteScalaire("select count(*) from fournisseur"));
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
        public static void ajouterByFournisseur(string nom, string rue, int codePostal, string ville, string tel, string email)
        {
            GestionBoutique.executerRequeteAction("INSERT INTO fournisseur (nom, rue, codePostal, ville, tel, email) VALUES ('" + nom + "', '" + rue + "', '" + codePostal + "', '" + ville + "' , '" + tel + "' , '" + email + "')");
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
        public static void modifierByFournisseur(int id, string nom, string rue, int codePostal, string ville, string tel, string email)
        {
            GestionBoutique.executerRequeteAction("UPDATE Produit SET nom = '" + nom + "',rue = '" + rue + "',codePostal = '" + codePostal + "', ville =" + ville + ",tel='" + tel  + ",email='" + email + "' WHERE id = " + id);
        }

        /// <summary>
        /// Supprime un client
        /// </summary>
        /// <param name="id">Identifiant du client à supprimer</param>
        public static void supprimerByFournisseur(int id)
        {
            // Remarque : Si l'on veut que la suppression supprime aussi les commandes et lignesCommandes associées
            // Il faut alors ajouter sur les clés étrangères "ON DELETE CASCADE"

            GestionBoutique.executerRequeteAction("DELETE FROM fournisseur WHERE id = " + id);
        }
    }
}
