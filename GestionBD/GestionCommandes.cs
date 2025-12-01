using GestionBD.MySQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionBD
{
    public class GestionCommandes
    {
        /// <summary>
        /// Retourne la liste de tous les clients
        /// </summary>
        /// <returns></returns>
        public static DataTable getTuplesByCommandes()
        {
            return GestionBoutique.getTuplesRequeteSelect("select * from commande", "ToutesLesCommandes");
        }

        /// <summary>
        /// Retourne le nombre de clients
        /// </summary>
        /// <returns></returns>
        public static int getNbTuplesByCommandes()
        {
            return Convert.ToInt16(GestionBoutique.getResultatRequeteScalaire("select count(*) from commande"));
        }

        /// <summary>
        /// Ajoute un client
        /// </summary>
        /// <param name="date">Nom du client</param>
        /// <param name="idClient">Prénom du client</param>
        public static void ajouterByCommandes(DateTime date, int idClient)
        {
            GestionBoutique.executerRequeteAction("INSERT INTO commande (date, idClient) VALUES ('" + date + "','" + idClient + "')");
        }

        /// <summary>
        /// Modifie les informations d'un client
        /// </summary>
        /// <param name="id">Identifiant du client à modifier</param>
        /// <param name="date">Nom du client à modifier</param>
        /// <param name="idClient">Prénom du client à modifier</param>
        public static void modifierByCommandes(int id, DateTime date, int idClient)
        {
            GestionBoutique.executerRequeteAction("UPDATE commande SET date = '" + date + "',idClient = '" + idClient + "' WHERE id = " + id);
        }

        /// <summary>
        /// Supprime un client
        /// </summary>
        /// <param name="id">Identifiant du client à supprimer</param>
        public static void supprimerByCommandes(int id)
        {
            // Remarque : Si l'on veut que la suppression supprime aussi les commandes et lignesCommandes associées
            // Il faut alors ajouter sur les clés étrangères "ON DELETE CASCADE"

            GestionBoutique.executerRequeteAction("DELETE FROM commande WHERE id = " + id);
        }

        /// <summary>
        /// Ajoute une commande et retourne son id auto-incrémenté (adapté à la structure de la base de données)
        /// </summary>
        public static int ajouterEtRecupererId(string date, int idClient, decimal sousTotal, string moyPaiement, int idLivraison)
        {
            string requete = $"INSERT INTO commande (date, idClient, sousTotal, moyPaiement, idLivraison) VALUES ('{date}', {idClient}, {sousTotal.ToString(System.Globalization.CultureInfo.InvariantCulture)}, '{moyPaiement}', {idLivraison})";
            MySQL.GestionBoutique.executerRequeteAction(requete);
            // Récupère le dernier id inséré
            return Convert.ToInt32(MySQL.GestionBoutique.getResultatRequeteScalaire("SELECT MAX(id) FROM commande"));
        }

        /// <summary>
        /// Appelle la procédure stockée AddCommande pour insérer une commande
        /// </summary>
        public static void AjouterCommandeViaProc(DateTime date, int idClient, decimal sousTotal, string moyPaiement, int idLivraison)
        {
            GestionBoutique.seConnecter();
            using (var cmd = new MySqlCommand("AddCommande", GestionBoutique.maConnexion))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@p_date", date);
                cmd.Parameters.AddWithValue("@p_idClient", idClient);
                cmd.Parameters.AddWithValue("@p_sousTotal", sousTotal);
                cmd.Parameters.AddWithValue("@p_moyPaiement", moyPaiement);
                cmd.Parameters.AddWithValue("@p_idLivraison", idLivraison);
                cmd.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Appelle la fonction stockée CalculerTotalCommande et retourne le total pour une commande donnée
        /// </summary>
        public static decimal AppelerFonctionCalculerTotalCommande(int idCommande)
        {
            GestionBoutique.seConnecter();
            using (var cmd = new MySqlCommand("SELECT CalculerTotalCommande(@idCmd)", GestionBoutique.maConnexion))
            {
                cmd.Parameters.AddWithValue("@idCmd", idCommande);
                object result = cmd.ExecuteScalar();
                return result != null && result != DBNull.Value ? Convert.ToDecimal(result) : 0;
            }
        }

        /// <summary>
        /// Retourne les logs d'ajout de commande (table log_commandes, alimentée par le trigger)
        /// </summary>
        public static DataTable GetLogsCommandes()
        {
            GestionBoutique.seConnecter();
            using (var cmd = new MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM log_commandes ORDER BY dateAjout DESC", GestionBoutique.maConnexion))
            {
                using (var adapter = new MySql.Data.MySqlClient.MySqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
    }
}