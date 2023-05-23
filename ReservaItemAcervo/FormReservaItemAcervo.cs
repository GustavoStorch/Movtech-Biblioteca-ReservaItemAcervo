using CadastroItemDoAcervo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReservaItemAcervo
{
    public partial class FormReservaItemAcervo : Form
    {
        public FormReservaItemAcervo()
        {
            InitializeComponent();
        }

        private void FormReservaItemAcervo_Load(object sender, EventArgs e)
        {
            InitializeTable();
            limparForm();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        public void limparForm()
        {
            txtCodItem.Text = String.Empty;
            cbxTipoMovimento.SelectedIndex = -1;
            txtNomeItem.Text = String.Empty;
            txtNumExemplar.Text = String.Empty;
            txtTipoItem.Text = String.Empty;
            txtLocalizacao.Text = String.Empty;
            txtCodLeitor.Text = String.Empty;
            txtNomeLeitor.Text = String.Empty;
            dtpDataReserva.Text = String.Empty;
            dtpDataDevolucao.Text = String.Empty;
            cbxStatusItem.SelectedIndex = -1;
        }

        private void InitializeTable()
        {
            dtgDadosReserva.Rows.Clear();
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                ReservaDAO dao = new ReservaDAO(connection);
                List<ReservaModel> reservas = dao.GetReservas();
                foreach (ReservaModel reserva in reservas)
                {
                    DataGridViewRow row = dtgDadosReserva.Rows[dtgDadosReserva.Rows.Add()];
                    row.Cells[colCoditem.Index].Value = reserva.ItemAcervoModel.CodItem;
                    row.Cells[colStatusItem.Index].Value = reserva.ItemAcervoModel.StatusItem;
                    row.Cells[colNumExemplar.Index].Value = reserva.ItemAcervoModel.NumExemplar;
                    row.Cells[colNomeItem.Index].Value = reserva.ItemAcervoModel.NomeItem;
                    row.Cells[colTipoItem.Index].Value = reserva.ItemAcervoModel.TipoItem;
                    row.Cells[colLocalizacao.Index].Value = reserva.ItemAcervoModel.Localizacao;
                    row.Cells[colCodLeitor.Index].Value = reserva.LeitorModel.CodLeitor;
                    row.Cells[colNomeLeitor.Index].Value = reserva.LeitorModel.NomeLeitor;
                    row.Cells[colDataReserva.Index].Value = reserva.DataReserva;
                    row.Cells[colDataRetorno.Index].Value = reserva.PrazoReserva;
                    row.Cells[colEncerrar.Index].Value = reserva.Encerrar;
                    row.Cells[colTipoMovimento.Index].Value = reserva.TipoMovimento;
                }
            }
        }

        private void dtgDadosReserva_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtCodItem.Text = dtgDadosReserva.Rows[e.RowIndex].Cells[colCoditem.Index].Value + "";
                txtNomeItem.Text = dtgDadosReserva.Rows[e.RowIndex].Cells[colNomeItem.Index].Value + "";
                txtNumExemplar.Text = dtgDadosReserva.Rows[e.RowIndex].Cells[colNumExemplar.Index].Value + "";
                cbxStatusItem.Text = dtgDadosReserva.Rows[e.RowIndex].Cells[colStatusItem.Index].Value + "";
                txtTipoItem.Text = dtgDadosReserva.Rows[e.RowIndex].Cells[colTipoItem.Index].Value + "";
                txtLocalizacao.Text = dtgDadosReserva.Rows[e.RowIndex].Cells[colLocalizacao.Index].Value + "";
                txtCodLeitor.Text = dtgDadosReserva.Rows[e.RowIndex].Cells[colCodLeitor.Index].Value + "";
                txtNomeLeitor.Text = dtgDadosReserva.Rows[e.RowIndex].Cells[colNomeLeitor.Index].Value + "";
                dtpDataReserva.Text = dtgDadosReserva.Rows[e.RowIndex].Cells[colDataReserva.Index].Value + "";
                dtpDataDevolucao.Text = dtgDadosReserva.Rows[e.RowIndex].Cells[colDataRetorno.Index].Value + "";
                cbxTipoMovimento.Text = dtgDadosReserva.Rows[e.RowIndex].Cells[colTipoMovimento.Index].Value + "";
            }
        }
    }
}
