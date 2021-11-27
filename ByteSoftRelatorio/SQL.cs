using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByteSoftRelatorio
{
    class SQL
    {
        public static int numeroLinhas;
        public static void CarregarDataGrid(string QUERY, DataGridView dgv)
        {
            SQLiteDataAdapter da1 = new SQLiteDataAdapter(QUERY, Conexao.Conectar(Conexao.Local));
            DataTable dt1 = new DataTable();
            try
            {
                dgv.DataSource = null;
                da1.Fill(dt1);
                dgv.DataSource = dt1;
                Conexao.Desconectar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void CriarTabelaTemp()
        {
            ///APOS FAZER LEITURA DO ARQUIVO, ELE CONECTA NO BANCO DE DADOS E ARMAZENDA TODAS INFORMACOES EM UM LOOP FOREACH
            using (var cmd = new SQLiteCommand(Conexao.Conectar(Conexao.Local)))
            {
                cmd.CommandText = "CREATE TABLE DADOSTEMP(Id INTEGER PRIMARY KEY AUTOINCREMENT, Codigo INT, Operador VARCHAR(100), Loja Varchar(20), CanceladoQTD INT, CanceladoRS DECIMAL(5,2), EstornadoQTD INT, EstornadoRS DECIMAL(5,2), DevolvidoQTD INT, DevolvidoRS DECIMAL(5,2), FinalizadoQTD INT, FinalizadoRS DECIMAL(5,2));";
                cmd.ExecuteNonQuery();
            };
        }
        public static void ComboBox(string QUERY, ComboBox comboBox, string VALUE, string DISPLAY)
        {
            using (SQLiteDataAdapter da = new SQLiteDataAdapter(QUERY, Conexao.Conectar(Conexao.Local)))
            { 
                DataTable dt = new DataTable();
                try
                {
                    da.Fill(dt);
                    comboBox.DataSource = null;
                    comboBox.DataSource = dt;
                    comboBox.ValueMember = VALUE;
                    comboBox.DisplayMember = DISPLAY;
                    comboBox.SelectedIndex = -1;
                    //Conexao.Desconectar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }            
            }
        }
        public static void LimparBanco()
        {
            ///APOS FAZER LEITURA DO ARQUIVO, ELE CONECTA NO BANCO DE DADOS E ARMAZENDA TODAS INFORMACOES EM UM LOOP FOREACH
            using (var cmd = new SQLiteCommand(Conexao.Conectar(Conexao.Local)))
            {
                cmd.CommandText = "delete from resultado where codigo > 0;";
                cmd.ExecuteNonQuery();
            };
        }
        public static void StyleGridResultado(DataGridView dgv)
        {
            if (dgv.DataSource != null) ///Column1
            {
                dgv.Columns["Column1"].Visible = true;
                dgv.Columns["Column1"].DisplayIndex = 0;
                dgv.Columns["Column1"].HeaderText = "";
                dgv.Columns["Column1"].Width = 10;
                dgv.Columns["Column1"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgv.Columns["Column1"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dgv.Columns["Codigo"].Visible = true;
                dgv.Columns["Codigo"].DisplayIndex = 1;
                dgv.Columns["Codigo"].HeaderText = "Usuário";
                dgv.Columns["Codigo"].MinimumWidth = 20;
                dgv.Columns["Codigo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgv.Columns["Codigo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                dgv.Columns["Operador"].Visible = true;
                dgv.Columns["Operador"].DisplayIndex = 2;
                dgv.Columns["Operador"].HeaderText = "Operador";
                dgv.Columns["Operador"].Width = 20;
                dgv.Columns["Operador"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgv.Columns["Loja"].Visible = true;
                dgv.Columns["Loja"].DisplayIndex = 3;
                dgv.Columns["Loja"].HeaderText = "Loja";
                dgv.Columns["Loja"].Width = 50;
                dgv.Columns["Loja"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgv.Columns["Loja"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgv.Columns["CanceladoQTD"].Visible = true;
                dgv.Columns["CanceladoQTD"].DisplayIndex = 4;
                dgv.Columns["CanceladoQTD"].HeaderText = "Cancelado";
                dgv.Columns["CanceladoQTD"].Width = 60;
                dgv.Columns["CanceladoQTD"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgv.Columns["CanceladoQTD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgv.Columns["EstornadoQTD"].Visible = true;
                dgv.Columns["EstornadoQTD"].DisplayIndex = 5;
                dgv.Columns["EstornadoQTD"].HeaderText = "Estornado";
                dgv.Columns["EstornadoQTD"].Width = 60;
                dgv.Columns["EstornadoQTD"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgv.Columns["EstornadoQTD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgv.Columns["DevolvidoQTD"].Visible = true;
                dgv.Columns["DevolvidoQTD"].DisplayIndex = 6;
                dgv.Columns["DevolvidoQTD"].HeaderText = "Devolvido";
                dgv.Columns["DevolvidoQTD"].Width = 60;
                dgv.Columns["DevolvidoQTD"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgv.Columns["DevolvidoQTD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgv.Columns["FinalizadoQTD"].Visible = true;
                dgv.Columns["FinalizadoQTD"].DisplayIndex = 7;
                dgv.Columns["FinalizadoQTD"].HeaderText = "Finalizado";
                dgv.Columns["FinalizadoQTD"].Width = 60;
                dgv.Columns["FinalizadoQTD"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgv.Columns["FinalizadoQTD"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                dgv.Columns["Cancelamento"].Visible = true;
                dgv.Columns["Cancelamento"].DisplayIndex = 8;
                dgv.Columns["Cancelamento"].HeaderText = "Percentual %";
                dgv.Columns["Cancelamento"].Width = 75;
                dgv.Columns["Cancelamento"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgv.Columns["Cancelamento"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                foreach (DataGridViewRow dataRow in dgv.Rows)
                {
                    if (Convert.ToDecimal(dataRow.Cells["Cancelamento"].Value.ToString()) <= 3) { dataRow.Cells["Column1"].Value = Properties.Resources.status0; };
                    if (Convert.ToDecimal(dataRow.Cells["Cancelamento"].Value.ToString()) > 3) { dataRow.Cells["Column1"].Value = Properties.Resources.status3; };
                    if (Convert.ToDecimal(dataRow.Cells["Cancelamento"].Value.ToString()) == 0) { dataRow.Cells["Column1"].Value = Properties.Resources.status4; };
                    //if (dataRow.Cells["Cancelamento"].Value.ToString() == "2") { dataRow.Cells["Column1"].Value = Properties.Resources.bloqueado; };
                    //if (dataRow.Cells["Cancelamento"].Value.ToString() == "3") { dataRow.Cells["Column1"].Value = Properties.Resources.negado; };
                }
            }
        }
    }
}
