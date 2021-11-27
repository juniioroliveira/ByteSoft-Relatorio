using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByteSoftRelatorio
{
    public partial class Form1 : Form
    {
        public class Cliente
        {
            public string Codido { get; set; }
            public string Operador { get; set; }
            public string Loja { get; set; }
            public int CanceladoQTD { get; set; }
            public string CanceladoRS { get; set; }
            public int EstornadoQTD { get; set; }
            public string EstornadoRS { get; set; }
            public int DevolvidoQTD { get; set; }
            public string DevolvidoRS { get; set; }
            public int FinalizadoQTD { get; set; }
            public string FinalizadoRS { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime date1 = DateTime.Now;
            var date2 = "25/02/2021";

            int result = DateTime.Compare(date1, Convert.ToDateTime(date2));
            if (result == 1)
            {
                MessageBox.Show("Nova versão disponível! Entre em contato com o desenvolvedor");
                Application.Exit();
            }

            fSelecionar.SelectedIndex = 0;
        }

        
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnSELECIONAR.Text == "SELECIONAR ARQUIVO")
                {
                    OpenFileDialog openFile = new OpenFileDialog();
                    openFile.Filter = "txt files (*.txt)|*.txt|CSV Files (*.csv)|*.csv";
                    openFile.RestoreDirectory = true;
                    openFile.ShowDialog();

                    if (openFile.FileName != "")
                    {
                        SQL.numeroLinhas = System.IO.File.ReadAllLines(openFile.FileName).Length;
                        txtCaminhoArquivo.Text = openFile.FileName;
                    }


                }
                else if (btnSELECIONAR.Text == "PROCESSAR")
                {
                    bgwStyle.RunWorkerAsync();

                    ler();
                    txtCaminhoArquivo.Clear();

                    if (Application.OpenForms.OfType<Loading>().Count() > 0)
                    {
                        var Loading = Application.OpenForms["Loading"] as Loading;
                        Loading.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro!", "Verifique se o arquivo está aberto..");
            }
            
        }
        private void bgwStyle_DoWork(object sender, DoWorkEventArgs e)
        {
            Gif.Enabled = true;
            var loaging = new Loading();
            loaging.ShowDialog();
        }

        private void txtCaminhoArquivo_TextChanged(object sender, EventArgs e)
        {
            if (txtCaminhoArquivo.TextLength > 0) { btnSELECIONAR.Text = "PROCESSAR"; btnSELECIONAR.Image = Properties.Resources.icons8_processo_24; }
            else { btnSELECIONAR.Text = "SELECIONAR ARQUIVO"; btnSELECIONAR.Image = Properties.Resources.icons8_pasta_de_pesquisa_24; }
        }

        private void ler()
        {
            try
            {
                ///FAZ A LEITURA DO ARQUIVO SELECIONADO 
                string caminhoArquivo = txtCaminhoArquivo.Text;
                var consulta = from linha in File.ReadAllLines(caminhoArquivo)
                let clienteDados = linha.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries)
                select new Cliente()
                {
                    Codido = clienteDados[0],
                    Operador = clienteDados[1],
                    Loja = clienteDados[2],
                    CanceladoQTD = Convert.ToInt32(clienteDados[3]),
                    CanceladoRS = clienteDados[4],
                    EstornadoQTD = Convert.ToInt32(clienteDados[5]),
                    EstornadoRS = clienteDados[6],
                    DevolvidoQTD = Convert.ToInt32(clienteDados[7]),
                    DevolvidoRS = clienteDados[8],
                    FinalizadoQTD = Convert.ToInt32(clienteDados[9]),
                    FinalizadoRS = clienteDados[10],
                };


                ///APOS FAZER LEITURA DO ARQUIVO, ELE CONECTA NO BANCO DE DADOS E ARMAZENDA TODAS INFORMACOES EM UM LOOP FOREACH
                using (var cmd = new SQLiteCommand(Conexao.Conectar(Conexao.Local)))
                {                    
                    cmd.CommandText = "INSERT INTO RESULTADO (Codigo, Operador, Loja, CanceladoQTD, EstornadoQTD, DevolvidoQTD, FinalizadoQTD, Cancelamento) VALUES (@Codigo, @Operador, @Loja, @CanceladoQTD, @EstornadoQTD, @DevolvidoQTD,@FinalizadoQTD, @Cancelamento)";

                    foreach (var item in consulta)
                    {
                            Calcular.Porcentagem(item.CanceladoQTD, item.EstornadoQTD, item.DevolvidoQTD, item.FinalizadoQTD);

                            cmd.Parameters.AddWithValue("@Codigo", item.Codido);
                            cmd.Parameters.AddWithValue("@Operador", item.Operador);
                            cmd.Parameters.AddWithValue("@Loja", item.Loja);
                            cmd.Parameters.AddWithValue("@CanceladoQTD", item.CanceladoQTD);
                            //cmd.Parameters.AddWithValue("@CanceladoRS", item.CanceladoRS);
                            cmd.Parameters.AddWithValue("@EstornadoQTD", item.EstornadoQTD);
                            //cmd.Parameters.AddWithValue("@EstornadoRS", item.EstornadoRS);
                            cmd.Parameters.AddWithValue("@DevolvidoQTD", item.DevolvidoQTD);
                            //cmd.Parameters.AddWithValue("@DevolvidoRS", item.DevolvidoRS);
                            cmd.Parameters.AddWithValue("@FinalizadoQTD", item.FinalizadoQTD);
                            cmd.Parameters.AddWithValue("@Cancelamento", string.Format("Decimal {0:F4}", Calcular.Total));

                            cmd.ExecuteNonQuery();
                    }

                    ///CARREGAR DGV DE PALAVRAS CHAVE
                    SQL.CarregarDataGrid("SELECT * FROM RESULTADO;", DgvDados);
                    tabControl1.SelectedTab = VisualizarDados;

                    SQL.ComboBox("SELECT DISTINCT Loja FROM RESULTADO;", fLoja, "Loja", "Loja");

                };

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " Metodo insert");
            }
        }

        private void DgvDados_DataSourceChanged(object sender, EventArgs e)
        {
            ///CARREGAR DGV DE PALAVRAS CHAVE
            SQL.StyleGridResultado(DgvDados);
        }

        private void DgvDados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <= 0)
            {
                ///CARREGAR DGV DE PALAVRAS CHAVE
                SQL.StyleGridResultado(DgvDados);
            }
        }
        private void Novo_Click(object sender, EventArgs e)
        {
            SQL.LimparBanco();
            tabControl1.SelectedTab = SelecionarArquivo;

        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            ///CARREGAR DGV DE PALAVRAS CHAVE
            SQL.CarregarDataGrid("SELECT * FROM RESULTADO;", DgvDados);

            SQL.ComboBox("SELECT DISTINCT Loja FROM RESULTADO;", fLoja, "Loja", "Loja");
        }
        private void fSelecionar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (fSelecionar.SelectedIndex == 0)
            {
                SQL.CarregarDataGrid("SELECT * FROM RESULTADO;", DgvDados);
            }
            if (fSelecionar.SelectedIndex == 1)
            {
                SQL.CarregarDataGrid("SELECT * FROM RESULTADO ORDER BY Cancelamento DESC LIMIT 10;", DgvDados);
            }
            if (fSelecionar.SelectedIndex == 2)
            {
                SQL.CarregarDataGrid("SELECT * FROM RESULTADO WHERE Cancelamento > 0 ORDER BY Cancelamento ASC LIMIT 10;", DgvDados);
            }
            if (fSelecionar.SelectedIndex == 3)
            {
                SQL.CarregarDataGrid("SELECT * FROM RESULTADO WHERE Cancelamento > 3 ORDER BY Cancelamento;", DgvDados);
            }
            if (fSelecionar.SelectedIndex == 4)
            {
                SQL.CarregarDataGrid("SELECT * FROM RESULTADO WHERE Cancelamento < 3 AND Cancelamento > 0 ORDER BY Cancelamento;", DgvDados);
            }

            fLoja.SelectedIndex = -1;
        }

        private void txtFcep_TextChanged(object sender, EventArgs e)
        {
            if(fUsuario.TextLength > 0)
            SQL.CarregarDataGrid("SELECT * FROM RESULTADO WHERE Codigo = " + fUsuario.Text, DgvDados);
        }
        private void fOperador_TextChanged(object sender, EventArgs e)
        {
            if (fOperador.TextLength > 0)
                SQL.CarregarDataGrid("SELECT * FROM RESULTADO WHERE Operador LIKE '%" + fUsuario.Text + "%'", DgvDados);
        }

        private void fLoja_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SQL.CarregarDataGrid("SELECT * FROM RESULTADO WHERE Loja = " + fLoja.SelectedValue, DgvDados);
            fSelecionar.SelectedIndex = -1;
        }
        private void fLoja_TextChanged(object sender, EventArgs e)
        {
            //SQL.CarregarDataGrid("SELECT * FROM RESULTADO WHERE Loja = " + fLoja.SelectedValue, DgvDados);
            //fSelecionar.SelectedIndex = -1;
        }

        private void Visualizar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = VisualizarDados;
            ///CARREGAR DGV DE PALAVRAS CHAVE
            SQL.CarregarDataGrid("SELECT * FROM RESULTADO;", DgvDados);

            SQL.ComboBox("SELECT DISTINCT Loja FROM RESULTADO;", fLoja, "Loja", "Loja");
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Classificar();
        }
        private void rbACR_CheckedChanged(object sender, EventArgs e)
        {
            Classificar();
        }
        private void Classificar()
        {
            if (fClassificar.SelectedIndex == 0)
            {
                if (rbACR.Checked == true) { SQL.CarregarDataGrid("SELECT * FROM RESULTADO ORDER BY Codigo ASC ", DgvDados); } else { SQL.CarregarDataGrid("SELECT * FROM RESULTADO ORDER BY Codigo DESC ", DgvDados); }
            }
            if (fClassificar.SelectedIndex == 1)
            {
                if (rbACR.Checked == true) { SQL.CarregarDataGrid("SELECT * FROM RESULTADO ORDER BY Operador ASC ", DgvDados); } else { SQL.CarregarDataGrid("SELECT * FROM RESULTADO ORDER BY Operador DESC ", DgvDados); }
            }
            if (fClassificar.SelectedIndex == 2)
            {
                if (rbACR.Checked == true) { SQL.CarregarDataGrid("SELECT * FROM RESULTADO ORDER BY Loja ASC ", DgvDados); } else { SQL.CarregarDataGrid("SELECT * FROM RESULTADO ORDER BY Loja DESC ", DgvDados); }
            }
            if (fClassificar.SelectedIndex == 3)
            {
                if (rbACR.Checked == true) { SQL.CarregarDataGrid("SELECT * FROM RESULTADO ORDER BY CanceladoQTD ASC ", DgvDados); } else { SQL.CarregarDataGrid("SELECT * FROM RESULTADO ORDER BY CanceladoQTD DESC ", DgvDados); }
            }
            if (fClassificar.SelectedIndex == 4)
            {
                if (rbACR.Checked == true) { SQL.CarregarDataGrid("SELECT * FROM RESULTADO ORDER BY EstornadoQTD ASC ", DgvDados); } else { SQL.CarregarDataGrid("SELECT * FROM RESULTADO ORDER BY EstornadoQTD DESC ", DgvDados); }
            }
            if (fClassificar.SelectedIndex == 5)
            {
                if (rbACR.Checked == true) { SQL.CarregarDataGrid("SELECT * FROM RESULTADO ORDER BY DevolvidoQTD ASC ", DgvDados); } else { SQL.CarregarDataGrid("SELECT * FROM RESULTADO ORDER BY DevolvidoQTD DESC ", DgvDados); }
            }
            if (fClassificar.SelectedIndex == 6)
            {
                if (rbACR.Checked == true) { SQL.CarregarDataGrid("SELECT * FROM RESULTADO ORDER BY FinalizadoQTD ASC ", DgvDados); } else { SQL.CarregarDataGrid("SELECT * FROM RESULTADO ORDER BY FinalicadoQTD DESC ", DgvDados); }
            }
            if (fClassificar.SelectedIndex == 7)
            {
                if (rbACR.Checked == true) { SQL.CarregarDataGrid("SELECT * FROM RESULTADO ORDER BY Cancelamento ASC ", DgvDados); } else { SQL.CarregarDataGrid("SELECT * FROM RESULTADO ORDER BY Cancelamento DESC ", DgvDados); }
            }

        }

        private void ExportarExcel()
        {

            SaveFileDialog salvar = new SaveFileDialog(); // novo
            //SaveFileDialog;

            // define algumas propriedades da caixa salvar
            salvar.Title = "Exportar para Excel";
            salvar.Filter = "Arquivo do Excel *.xls | *.xls";
            salvar.ShowDialog(); // mostra

            if (salvar.FileName != "")
            {
                bgwStyle.RunWorkerAsync();
            
                Microsoft.Office.Interop.Excel.Application App; // Aplicação Excel
                Microsoft.Office.Interop.Excel.Workbook WorkBook; // Pasta
                Microsoft.Office.Interop.Excel.Worksheet WorkSheet; // Planilha
                object misValue = System.Reflection.Missing.Value;

                App = new Microsoft.Office.Interop.Excel.Application();
                WorkBook = App.Workbooks.Add(misValue);
                WorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)WorkBook.Worksheets.get_Item(1);
                int i = 0;
                int j = 0;

                // passa as celulas do DataGridView para a Pasta do Excel
                for (i = 0; i <= DgvDados.RowCount - 1; i++)
                {
                    for (j = 0; j <= DgvDados.ColumnCount - 1; j++)
                    {
                        DataGridViewCell cell = DgvDados[j, i];
                        WorkSheet.Cells[i + 1, j + 1] = cell.Value;
                    }
                }

                // salva o arquivo
                WorkBook.SaveAs(salvar.FileName, Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,

                Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                WorkBook.Close(true, misValue, misValue);
                App.Quit(); // encerra o excel

                if (Application.OpenForms.OfType<Loading>().Count() > 0)
                {
                    var Loading = Application.OpenForms["Loading"] as Loading;
                    Loading.Close();
                }

                MessageBox.Show("Exportado com sucesso!");
            }


        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            ExportarExcel();
        }

    }

   
}
