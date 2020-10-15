using ProjetoTCC2020.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoTCC2020.View.Agendamento
{
    public partial class fmHorariosDisp : Form
    {
        public fmHorariosDisp()
        {
            InitializeComponent();
        }

        private void dtPesqData_ValueChanged(object sender, EventArgs e)
        {
            GridHorarios();
        }

        private void fmHorariosDisp_Load(object sender, EventArgs e)
        {
            GridHorarios();
        }

        private void GridHorarios()
        {
            AgendamentoBUS agendamentoBUS = new AgendamentoBUS();
            dgHorarios.DataSource = agendamentoBUS.SearchAllStartTimes(dtPesqData.Value);

            foreach (DataGridViewColumn column in dgHorarios.Columns)
            {
                if (column.Index == 1)
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            dgHorarios.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgHorarios.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgHorarios.Update();
        }
    }
}
