using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByteSoftRelatorio
{
    class Conexao
    {
        public static string Local { get; set; } = System.AppDomain.CurrentDomain.BaseDirectory.ToString() + "Dados.db"; ///System.AppDomain.CurrentDomain.BaseDirectory.ToString();

        public static SQLiteConnection con = new SQLiteConnection();
        public static SQLiteConnection Conectar(string LOCAL)
        {
            con = new SQLiteConnection(@"Data Source=" + LOCAL + ";Version = 3; FailIfMissing = False", true);
            con.Open();
            return con;
        }

        public static void Desconectar()
        {
            try
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                    con.Dispose();
                }

                con.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Metodo desconectar");
            }
        }
    }
}
