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
            Form Cmd_Ajouter = new Frm_Inscription_Ajout();
            Cmd_Ajouter.ShowDialog();
        }
        private void Frm_InscriptionMembre_Load(object sender, EventArgs e)
        {
           
        }
        private void Cmd_Modif_Sup_Click(object sender, EventArgs e)
        {
            Form Cmd_Modif_Sup = new Frm_Modifier_Supprimer();
            Cmd_Modif_Sup.ShowDialog();
        }

        private void Cmd_Detail_Click(object sender, EventArgs e)
        {
            Form Cmd_Detail = new Frm_Detail_Competition();
            Cmd_Detail.ShowDialog();
        }
    }
}
