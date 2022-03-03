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
        }

        private void Grid_Detail_Comp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Frm_Detail_Competition_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = bdd.ConnectionBD();

            conn.Open();

            string sqlDetailComp = "SELECT NUM_COMPETITION, NUM_CLUB, DATE_COMPETITION FROM competition";
            MySqlCommand cmdDetailComp = new MySqlCommand(sqlDetailComp, conn);
            MySqlDataReader readerDetailComp = cmdDetailComp.ExecuteReader();

            while (readerDetailComp.Read())
            {
                string NUM_COMPETITION = (readerDetailComp["NUM_COMPETITION"].ToString());
                string NUM_CLUB = (readerDetailComp["NUM_CLUB"].ToString());
                string DATE_COMPETITION = (readerDetailComp["DATE_COMPETITION"].ToString());

                Grid_Detail_Comp.Rows.Add(NUM_COMPETITION, NUM_CLUB, DATE_COMPETITION);
            }
            conn.Close();
        }
    }
}
