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

                Grid_Inscrip.Rows.Add(NUM_COMPETITION, NUM_LICENCE, NOTE_GLOBALE);
            }
            conn.Close();
        }
        private void Cmd_Sup_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = bdd.ConnectionBD();
            conn.Open();

            string sqlSup = "DELETE FROM inscription WHERE NUM_LICENCE = @NUM_LICENCE AND NUM_COMPETITION = @NUM_COMPETITION";
            MySqlCommand cmdSup = new MySqlCommand(sqlSup, conn);
            string numLicence = Grid_Inscrip.SelectedRows[0].Cells[1].Value.ToString();
            cmdSup.Parameters.AddWithValue("@NUM_LICENCE", numLicence);
            string numCompetition = Grid_Inscrip.SelectedRows[0].Cells[0].Value.ToString();
            cmdSup.Parameters.AddWithValue("@NUM_COMPETITION", numCompetition);
            cmdSup.ExecuteNonQuery();
            MessageBox.Show("L'inscription à bien était Supprimer !");

            Grid_Inscrip.Rows.Clear();

            string sqlSupprimer = "SELECT NUM_COMPETITION,NUM_LICENCE,NOTE_GLOBALE FROM inscription";
            MySqlCommand cmdSupprimer = new MySqlCommand(sqlSupprimer, conn);
            MySqlDataReader readerSupprimer = cmdSupprimer.ExecuteReader();
            while (readerSupprimer.Read())
            {
                string NUM_COMPETITION = (readerSupprimer["NUM_COMPETITION"].ToString());
                string NUM_LICENCE = (readerSupprimer["NUM_LICENCE"].ToString());
                string NOTE_GLOBALE = (readerSupprimer["NOTE_GLOBALE"].ToString());

                Grid_Inscrip.Rows.Add(NUM_COMPETITION, NUM_LICENCE, NOTE_GLOBALE);
            }
            conn.Close();
        }

        private void Cmd_Modifier_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = bdd.ConnectionBD();
            conn.Open();


            int ligne = Grid_Inscrip.CurrentCell.RowIndex;
            int numCompet = Convert.ToInt16(Grid_Inscrip[0, ligne].Value);
            string numLicence = Grid_Inscrip[1, ligne].Value.ToString();
            string sqlUpdate = "UPDATE inscription SET NUM_COMPETITION=@numCompet WHERE NUM_COMPETITION = @numCompetition AND NUM_LICENCE = @numLicence";

            MySqlCommand cmdUpdate = new MySqlCommand(sqlUpdate, conn);

            cmdUpdate.Parameters.AddWithValue("numCompetition", numCompet);
            cmdUpdate.Parameters.AddWithValue("numLicence", numLicence);
            cmdUpdate.Parameters.AddWithValue("numCompet", int.Parse(txtInscrip.Text));

            MessageBox.Show(numCompet.ToString());
            MessageBox.Show(numLicence.ToString());
            cmdUpdate.ExecuteNonQuery();

            Grid_Inscrip.Rows.Clear();

            string sqlSelect = "SELECT NUM_COMPETITION,NUM_LICENCE,NOTE_GLOBALE FROM inscription";
            MySqlCommand cmdSelect = new MySqlCommand(sqlSelect, conn);
            MySqlDataReader readerSelect = cmdSelect.ExecuteReader();
            while (readerSelect.Read())
            {
                string NUM_COMPETITION = (readerSelect["NUM_COMPETITION"].ToString());
                string NUM_LICENCE = (readerSelect["NUM_LICENCE"].ToString());
                string NOTE_GLOBALE = (readerSelect["NOTE_GLOBALE"].ToString());

                Grid_Inscrip.Rows.Add(NUM_COMPETITION, NUM_LICENCE, NOTE_GLOBALE);
            }
            conn.Close();


        }
    }
}
