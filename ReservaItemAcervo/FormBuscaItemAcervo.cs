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
    public partial class FormBuscaItemAcervo : Form
    {
        public string codItem { get; private set; }

        public string devolucao { get; set; }

        public FormBuscaItemAcervo()
        {
            InitializeComponent();
        }

        private void FormBuscaItemAcervo_Load(object sender, EventArgs e)
        {
            InitializeTable();
        }

        public void carregaTextBox()
        {
            codItem = txtCodItem.Text;
            this.Close();
        }

        private void InitializeTable()
        {
            dtgDadosItemAcervo.Rows.Clear();

            if(devolucao == "Devolver")
            {
                using (SqlConnection connection = DaoConnection.GetConexao())
                {
                    ItemAcervoDAO dao = new ItemAcervoDAO(connection);
                    List<ItemAcervoModel> itensAcervos = dao.GetItensAcervosDevolver();
                    foreach (ItemAcervoModel itemAcervo in itensAcervos)
                    {
                        DataGridViewRow row = dtgDadosItemAcervo.Rows[dtgDadosItemAcervo.Rows.Add()];
                        row.Cells[colCodItemAcervo.Index].Value = itemAcervo.CodItem;
                        row.Cells[colNomeItemAcervo.Index].Value = itemAcervo.NomeItem;
                        row.Cells[colNumExemplar.Index].Value = itemAcervo.NumExemplar;
                    }
                }
            } else
            {
                using (SqlConnection connection = DaoConnection.GetConexao())
                {
                    ItemAcervoDAO dao = new ItemAcervoDAO(connection);
                    List<ItemAcervoModel> itensAcervos = dao.GetItensAcervos();
                    foreach (ItemAcervoModel itemAcervo in itensAcervos)
                    {
                        DataGridViewRow row = dtgDadosItemAcervo.Rows[dtgDadosItemAcervo.Rows.Add()];
                        row.Cells[colCodItemAcervo.Index].Value = itemAcervo.CodItem;
                        row.Cells[colNomeItemAcervo.Index].Value = itemAcervo.NomeItem;
                        row.Cells[colNumExemplar.Index].Value = itemAcervo.NumExemplar;
                    }
                }
            }        
        }

        private void dtgDadosItemAcervo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.ColumnIndex > -1)
            {
                txtNomeItemAcervo.Text = dtgDadosItemAcervo.Rows[e.RowIndex].Cells[colNomeItemAcervo.Index].Value + "";
                txtCodItem.Text = dtgDadosItemAcervo.Rows[e.RowIndex].Cells[colCodItemAcervo.Index].Value + "";
            }
            carregaTextBox();
        }

        private void txtNomeItemAcervo_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtNomeItemAcervo.Text.Trim();

            foreach (DataGridViewRow row in dtgDadosItemAcervo.Rows)
            {
                string nomeAutor = row.Cells[colNomeItemAcervo.Index].Value.ToString().Trim();
                bool exibir = nomeAutor.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0;
                row.Visible = exibir;
            }
        }
    }
}
