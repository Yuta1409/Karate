using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PROJET_PPE2._1_KARATE
{
    public partial class Frm_Modifier_Supprimer : Form
    {
        public Frm_Modifier_Supprimer()
        {
            InitializeComponent();
        }

        private void Frm_Modifier_Supprimer_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = bdd.ConnectionBD();
            conn.Open();

            string sqlInscription = "SELECT NUM_COMPETITION,NUM_LICENCE,NOTE_GLOBALE FROM inscription";
            MySqlCommand cmdInscription = new MySqlCommand(sqlInscription, conn);
            MySqlDataReader readerInscription = cmdInscription.ExecuteReader();

            while (readerInscription.Read())
            {
                string NUM_COMPETITION = (readerInscription["NUM_COMPETITION"].ToString());
                string NUM_LICENCE = (readerInscription["NUM_LICENCE"].ToString());
                string NOTE_GLOBALE = (readerInscription["NOTE_GLOBALE"].ToString());

                Grid_Modifier_Supprimer.Rows.Add(NUM_COMPETITION, NUM_LICENCE, NOTE_GLOBALE);
            }
            conn.Close();
        }

        private void Cmd_Modifier_Click(object sender, EventArgs e)
        {
            
        }

        private void Cmd_Sup_Click(object sender, EventArgs e)
        {

        }
    }
}
