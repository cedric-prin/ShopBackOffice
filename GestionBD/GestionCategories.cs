using GestionBD.MySQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBD.MySQL
{
    public class GestionCategories
    {
        public static DataTable getTuplesByCategories()
        {
            return GestionBoutique.getTuplesRequeteSelect("select * from categorie", "ToutesLesCategories");
        }

        public static DataTable getPatronymesByCategories()
        {
            return GestionBoutique.getTuplesRequeteSelect("SELECT id, CONCAT(UPPER(nom),' ',libelle) AS Patronyme FROM categorie", "TousLesPatronymesCategorie");
        }

        /// <summary>
        /// Retourne le nombre de clients
        /// </summary>
        /// <returns></returns>
        public static int getNbTuplesByCategories()
        {
            return Convert.ToInt16(GestionBoutique.getResultatRequeteScalaire("select count(*) from categorie"));
        }

        /// <summary>
        /// Ajoute un client
        /// </summary>
        /// <param name="libelle">Nom de la categorie</param>
        public static void ajouterByCategories(string libelle)
        {
            GestionBoutique.executerRequeteAction("INSERT INTO categorie (libelle) VALUES ('" + libelle + "')");
        }

        /// <summary>
        /// Modifie les informations d'un client
        /// </summary>
        /// <param name="id">Identifiant du client à modifier</param>
        /// <param name="libelle">Nom du client à modifier</param>
        public static void modifierByCategories(int id, string libelle)
        {
            GestionBoutique.executerRequeteAction("UPDATE categorie SET libelle = '" + libelle + "' WHERE id = " + id);
        }

        /// <summary>
        /// Supprime un client
        /// </summary>
        /// <param name="id">Identifiant du client à supprimer</param>
        public static void supprimerByCategories(int id)
        {
            // Remarque : Si l'on veut que la suppression supprime aussi les commandes et lignesCommandes associées
            // Il faut alors ajouter sur les clés étrangères "ON DELETE CASCADE"

            GestionBoutique.executerRequeteAction("DELETE FROM categorie WHERE id = " + id);
        }
    }
}
