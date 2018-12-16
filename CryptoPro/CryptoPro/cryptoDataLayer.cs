using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CryptoPro
{
    class cryptoDataLayer
    {
        private OleDbConnection conn;
        private OleDbCommand comm;
        private OleDbDataReader cryptoReader;

        public cryptoDataLayer()
        {
            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Crypto_Watch1.accdb";
            conn = new OleDbConnection(connString);
            // conn.Open();
        }

        public List<Watching> getWatchListDatabase()
        {
            List<Watching> savedCryptos = new List<Watching>();

            try
            {
                conn.Open();

                string selectC = "SELECT * FROM watch";

                comm = new OleDbCommand(selectC, conn);

                cryptoReader = comm.ExecuteReader(CommandBehavior.CloseConnection);

                while (cryptoReader.Read())
                {
                    string id = cryptoReader["ID"].ToString();
                    string name = cryptoReader["Cname"].ToString();
                    string tick = cryptoReader["Ticker"].ToString();
                    string WPrice = cryptoReader["WPrice"].ToString();
                    string desc = cryptoReader["Description"].ToString();

                    Watching w = new Watching(int.Parse(id), name, tick, Double.Parse(WPrice), desc);

                    savedCryptos.Add(w);

                }
            }
            catch(OleDbException)
            {
                MessageBox.Show("An error has occured. The program will now close", "Error");
                Application.Exit();
            }
            
            conn.Close();

            return savedCryptos;

        } // end getwatchlist

        public void deleteWatching(Watching w)
        {
            conn.Open();

            string delC = "DELETE FROM watch WHERE TICKER=?";

            comm = new OleDbCommand(delC, conn);

            OleDbParameter paramID = new OleDbParameter("TICKER", w.CryptoTick1);

            comm.Parameters.Add(paramID);

            comm.ExecuteNonQuery();

            conn.Close();
        }

        public void addToWatching(Watching w)
        {
            
            conn.Open();

            string insertW = "INSERT INTO watch (Cname, Ticker, Wprice) VALUES (?,?,?)";

            comm = new OleDbCommand(insertW, conn);

            OleDbParameter param1 = new OleDbParameter("Cname", w.CryptoName1);
            OleDbParameter param2 = new OleDbParameter("Ticker", w.CryptoTick1);
            OleDbParameter param3 = new OleDbParameter("Wprice", w.WatchPrice1);

            comm.Parameters.Add(param1);
            comm.Parameters.Add(param2);
            comm.Parameters.Add(param3);

            comm.ExecuteNonQuery();

            conn.Close();

        }

        public void editWatching(Watching w)
        {
            conn.Open();

            string updateW = "UPDATE watch SET Description=? WHERE ID=?";

            comm = new OleDbCommand(updateW, conn);

            OleDbParameter paramDesc = new OleDbParameter("Description", w.Description1);
            OleDbParameter paramID = new OleDbParameter("ID", w.CID);

            comm.Parameters.Add(paramDesc);
            comm.Parameters.Add(paramID);

            comm.ExecuteNonQuery();

            conn.Close();
        }


    }
}
