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
    public partial class Frm_Detail_Competition : Form
    {
        public Frm_Detail_Competition()
        {
            InitializeComponent();

            MySqlConnection conn = bdd.ConnectionBD();
            conn.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT NUM_COMPETITION FROM competition", conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["NUM_COMPETITION"]);
            }
        }

        private void Grid_Detail_Comp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Frm_Detail_Competition_Load(object sender, EventArgs e)
        {
           

        }

        private void CmdDetail_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Grid_Recherche.Rows.Clear();
            MySqlConnection conn = bdd.ConnectionBD();
            conn.Open();
            MySqlCommand oui = new MySqlCommand("SELECT NUM_COMPETITION,NUM_LICENCE,NOTE_GLOBALE FROM inscription WHERE NUM_COMPETITION = @param", conn);
            oui.Parameters.AddWithValue("@param", comboBox1.Text);
            MySqlDataReader non = oui.ExecuteReader();
            while (non.Read())
            {
                string NUM_COMPETITION = (non["NUM_COMPETITION"].ToString());
                string NUM_LICENCE = (non["NUM_LICENCE"].ToString());
                string NOTE_GLOBALE = (non["NOTE_GLOBALE"].ToString());

                Grid_Recherche.Rows.Add(NUM_COMPETITION, NUM_LICENCE, NOTE_GLOBALE);
            }
            conn.Close();
        }
    }
}
