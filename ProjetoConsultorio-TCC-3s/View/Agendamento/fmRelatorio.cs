using Microsoft.Office.Interop.Excel;
using ProjetoTCC2020.BUS;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ProjetoTCC2020.Agendamento
{
    public partial class fmRelatorio : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = DESKTOP-9IUVQQE\SQLEXPRESS;Initial Catalog=Cadastro;Integrated Security=True");


        public fmRelatorio()
        {
            InitializeComponent();
            cbRelStatusConsulta.SelectedIndex = 0;

        }

        private void lbAgDtFim_Click(object sender, EventArgs e)
        {

        }

        private void btAgCanc_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbAgPesquisa_Enter(object sender, EventArgs e)
        {

        }

        private void btAgExportar_Click_1(object sender, EventArgs e)
        {
            string Linhas = gridRel.Rows.Count.ToString();
            int QtdLinhas = Convert.ToInt32(Linhas);
            if(QtdLinhas == 0)
            {
                MessageBox.Show("É necessário ter um relatório gerado");
                return;
            }
            pnPb.Visible = true;
           
            //pbAg.Value = Convert.ToInt32(QtdLinhas);

            pbAg.Maximum = Convert.ToInt32(Linhas);
            pbAg.Minimum = 0;

            for (var i = 0; i < Convert.ToInt32(Linhas); i++)
            {
                pbAg.Value = (i + 1);
            }

            if (pbAg.Value == pbAg.Maximum)
            {

                SaveFileDialog salvar = new SaveFileDialog();

                Excel.Application App;
                Workbook WorkBook;
                Worksheet WorkSheet;
                object misValue = System.Reflection.Missing.Value;

                App = new Excel.Application();

                WorkBook = App.Workbooks.Add(misValue);
                WorkSheet = (Worksheet)WorkBook.Worksheets.get_Item(1);
                int i = 0;
                int j = 0;

                App.Visible = false;

                string[] headers = new string[9]{"Data", "Status", "Início", "Fim" , "Cliente",
                    "Serviço", "Doutor", "Funcionário","Motivo Cancelamento"};


                for (i = 0; i <= gridRel.RowCount - 1; i++)
                {
                    for (j = 0; j <= gridRel.ColumnCount - 1; j++)
                    {
                        WorkSheet.Cells[1, j + 1] = headers[j];

                        DataGridViewCell cell = gridRel[j, i];
                        WorkSheet.Cells[i + 2, j + 1] = cell.Value;
                    }
                }
                salvar.Filter = "Arquivo do Excel *.xls | *.xls";
                salvar.FileName = "Agenda-Exportada";

                if (salvar.ShowDialog() == DialogResult.OK)
                {
                    WorkBook.SaveAs(salvar.FileName, XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    WorkBook.Close(true, misValue, misValue);
                    App.Quit();
                    MessageBox.Show("Exportado com sucesso!");
                }

                pnPb.Visible = false;
            }
        }

        private void btRelBuscar_Click(object sender, EventArgs e)
        {
            GridRelatorio();
        }

        private void GridRelatorio()
        {
            int indexConsulta = 0;
            //DateTime DataIni;
            //DateTime DataFim;
            //
            //DataIni = dtRelIni.Value;
            //DataFim = dtRelFinal.Value;

            string DataIni;
            string DataFim;

            DataIni = dtRelIni.Value.ToString("dd/MM/yyyy");
            DataFim = dtRelFinal.Value.ToString("dd/MM/yyyy");

            if (cbRelStatusConsulta.SelectedIndex == 0)
            {
                indexConsulta = 0;
            }
            else if (cbRelStatusConsulta.SelectedIndex == 1)
            {
                indexConsulta = 1;
            }
            else if (cbRelStatusConsulta.SelectedIndex == 2)
            {
                indexConsulta = 2;
            }
            else if (cbRelStatusConsulta.SelectedIndex == 3)
            {
                indexConsulta = 3;
            }

            AgendamentoBUS agendamentoBUS = new AgendamentoBUS();
            gridRel.DataSource = agendamentoBUS.SearchReport(indexConsulta, DataIni, DataFim);

            foreach (DataGridViewColumn column in gridRel.Columns)
            {
                if (column.DataPropertyName == "Data")
                    column.Width = 70;
                if (column.DataPropertyName == "Status")
                    column.Width = 85;
                if (column.DataPropertyName == "Serviço")
                    column.Width = 100;
                if (column.DataPropertyName == "Cliente")
                    column.Width = 120;
                if (column.DataPropertyName == "Doutor")
                    column.Width = 100;
                if (column.DataPropertyName == "Funcionário")
                    column.Width = 110;
                if (column.DataPropertyName == "Inicio")
                    column.Width = 50;
                if (column.DataPropertyName == "Fim")
                    column.Width = 50;
                else
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            gridRel.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridRel.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            gridRel.Refresh();
        }
    }
}
