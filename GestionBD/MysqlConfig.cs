using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionBD.MySQL //Exemple de nom de namespace bien approprié pour ranger la classe
{
    public static class MysqlConfig
    {
        public const string SERVEUR = "localhost";
        public const string BASE = "prin_boutique";//A adapter bien entendu...
        public static string UTILISATEUR = "root";
        public static string MOT_DE_PASSE = "";
    }
}