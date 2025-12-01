using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prin_boutique
{
    internal class GestionInterface
    {
        public static void remplirComboBox(ComboBox maComboBox, DataTable maDataTable, string displayMember, string valueMember)
        {
            maComboBox.DataSource = maDataTable;
            maComboBox.DisplayMember = displayMember;
            maComboBox.ValueMember = valueMember;
        }

        public static void coloriserDataGrid(DataGridView monDataDridView)
        {
            monDataDridView.DefaultCellStyle.Font = new Font("Bahnschrift Light", 9);
            monDataDridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(108, 99, 255);
            monDataDridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        public static bool isChaineValide(string chaine)
        {
            Regex myRegex;
            myRegex = new Regex("[a-zA-Z]");

            return myRegex.IsMatch(chaine); // retourne true ou false selon la vérification
        }
    }
}
