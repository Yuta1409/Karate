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
    public partial class Frm_InscriptionMembre : Form
    {
        public Frm_InscriptionMembre()
        {
            InitializeComponent();
        }


        private void Cmd_Ajouter_Click(object sender, EventArgs e)
        {
            
        }

        private void Grid_Membre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Frm_InscriptionMembre_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = bdd.ConnectionBD();
            conn.Open();

            string sqlMembre = "SELECT NUM_LICENCE,NUM_CLUB, NOM_MEMBRE, PRENOM_MEMBRE FROM membre";
            MySqlCommand cmdMembre = new MySqlCommand(sqlMembre, conn);
            MySqlDataReader readerMembre = cmdMembre.ExecuteReader();

            while (readerMembre.Read())
            {
                string NUM_LICENCE = (readerMembre["NUM_LICENCE"].ToString());
                string NUM_CLUB = (readerMembre["NUM_CLUB"].ToString());
                string NOM_MEMBRE = (readerMembre["NOM_MEMBRE"].ToString());
                string PRENOM_MEMBRE = (readerMembre["PRENOM_MEMBRE"].ToString());

                Grid_Membre.Rows.Add(NUM_LICENCE, NUM_CLUB, NOM_MEMBRE, PRENOM_MEMBRE);
            }
            conn.Close();

            conn.Open();
            string sqlComp = "SELECT NUM_COMPETITION, NUM_CLUB FROM competition";
            MySqlCommand cmdComp = new MySqlCommand(sqlComp, conn);
            MySqlDataReader readerComp = cmdComp.ExecuteReader();

            while (readerComp.Read())
            {
                string NUM_COMPETITION = (readerComp["NUM_COMPETITION"].ToString());
                string NUM_CLUB = (readerComp["NUM_CLUB"].ToString());

                Grid_Comp.Rows.Add(NUM_COMPETITION, NUM_CLUB);

            }
            conn.Close();
        }
    }
}
