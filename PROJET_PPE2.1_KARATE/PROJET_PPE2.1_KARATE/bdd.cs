using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace PROJET_PPE2._1_KARATE
{
    class bdd
    {
        public static MySqlConnection ConnectionBD()
        {   
            //Création a chaîne de conenction
            string connectingString = "SERVER=localhost; DATABASE=karate; UID=root; PASSWORD=";
            MySqlConnection conn = new MySqlConnection(connectingString);
            return conn;
        }

    }
}
