using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Geoquiz
{
    public class Database
    {
        private MySqlConnection dbConnection;

        public Database()
        {
            try
            {
                dbConnection = new MySqlConnection("SERVER=localhost; DATABASE=quiz; UID=root; PASSWORD=root; SSLMODE = NONE;");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public List<Player> getPlayersFromDB()
        {
            List<Player> lp = new List<Player>();

            MySqlCommand comm = dbConnection.CreateCommand();
            comm.CommandText = "SELECT * FROM player;";

            dbConnection.Open();
            MySqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                lp.Add(new Player(
                    reader.GetInt32(0), // id
                    reader.GetString(1), // pname
                    reader.IsDBNull(2) ? 0 : reader.GetInt32(2) // highscore
                ));
            }

            reader.Close();
            dbConnection.Close();

            return lp;
        }

        public List<Geo> getGeoFromDB()
        {
            List<Geo> lg = new List<Geo>();

            MySqlCommand comm = dbConnection.CreateCommand();
            comm.CommandText = "SELECT * FROM geo;";

            dbConnection.Open();
            MySqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                lg.Add(new Geo(
                    reader.GetInt32(0), // id
                    reader.GetString(1), // country
                    reader.GetString(2), // capital
                    reader.GetString(3) // flag link
                ));
            }

            reader.Close();
            dbConnection.Close();

            return lg;
        }

        public void saveNewPlayer(string pname)
        {
            MySqlCommand comm = dbConnection.CreateCommand();
            comm.CommandText = $"INSERT INTO player (pname) VALUES (@pname);";
            MySqlParameter pnameParam = new MySqlParameter("@pname", MySqlDbType.VarChar, 40);
            pnameParam.Value = pname;
            comm.Parameters.Add(pnameParam);

            dbConnection.Open();
            comm.Prepare();
            comm.ExecuteNonQuery();
            dbConnection.Close();
        }

        public void saveNewHighscore(string id, string highscore)
        {
            MySqlCommand comm = dbConnection.CreateCommand();
            comm.CommandText = $"UPDATE player SET highscore = @highscore WHERE id = @id;";
            MySqlParameter highscoreParam = new MySqlParameter("@highscore", MySqlDbType.Int32);
            MySqlParameter idParam = new MySqlParameter("@id", MySqlDbType.Int32);
            highscoreParam.Value = highscore;
            idParam.Value = id;
            comm.Parameters.Add(highscoreParam);
            comm.Parameters.Add(idParam);

            dbConnection.Open();
            comm.Prepare();
            comm.ExecuteNonQuery();
            dbConnection.Close();
        }
    }
}
