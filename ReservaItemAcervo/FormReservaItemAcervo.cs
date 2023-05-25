using CadastroItemDoAcervo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            btnLimpar.Enabled = false;
        }

        public void CarregaFormBuscaItemAcervo()
        {
            FormBuscaItemAcervo formBuscaItemAcervo = new FormBuscaItemAcervo();
            formBuscaItemAcervo.devolucao = cbxTipoMovimento.Text;
            formBuscaItemAcervo.ShowDialog();
            txtCodItem.Text = formBuscaItemAcervo.codItem;
            
        }

        public void CarregaFormBuscaLeitor()
        {
            FormBuscaLeitor formBuscaLeitor = new FormBuscaLeitor();
            formBuscaLeitor.ShowDialog();

            txtCodLeitor.Text = formBuscaLeitor.codLeitor;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = DaoConnection.GetConexao())
                {
                    ReservaDAO dao = new ReservaDAO(connection);

                    bool verificaCampos = dao.VerificaCampos(new ReservaModel()
                    {
                        DataReserva = dtpDataReserva.Value.Date.ToString(),
                        PrazoReserva = dtpDataDevolucao.Value.Date.ToString()
                    }, new ItemAcervoModel()
                    {
                        CodItem = txtCodItem.Text,
                        NomeItem = txtNomeItem.Text,
                        NumExemplar = txtNumExemplar.Text,
                        TipoItem = txtTipoItem.Text,
                        Localizacao = txtLocalizacao.Text
                    }, new LeitorModel()
                    {
                        CodLeitor = txtCodLeitor.Text,
                        NomeLeitor = txtNomeLeitor.Text
                    });

                    if (verificaCampos)
                    {
                        string movimento = cbxTipoMovimento.Text;
                        bool verificaEmprestimo = dao.VerificaEmprestimo(new ItemAcervoModel()
                        {
                            CodItem = txtCodItem.Text
                        }, new ReservaModel()
                        {
                            TipoMovimento = movimento
                        });

                        if (verificaEmprestimo)
                        {
                            dao.Salvar(new ReservaModel()
                            {
                                DataReserva = dtpDataReserva.Value.Date.ToString(),
                                PrazoReserva = dtpDataDevolucao.Value.Date.ToString(),
                                TipoMovimento = cbxTipoMovimento.Text
                            }, new ItemAcervoModel()
                            {
                                CodItem = txtCodItem.Text,
                                NomeItem = txtNomeItem.Text,
                                NumExemplar = txtNumExemplar.Text,
                                TipoItem = txtTipoItem.Text,
                                Localizacao = txtLocalizacao.Text,
                                StatusItem = cbxStatusItem.Text
                            }, new LeitorModel()
                            {
                                CodLeitor = txtCodLeitor.Text,
                                NomeLeitor = txtNomeLeitor.Text
                            });

                            dao.AtualizaItemAcervo(new ItemAcervoModel()
                            {
                                StatusItem = cbxStatusItem.Text,
                                CodItem = txtCodItem.Text
                            });

                            if (movimento == "Devolver")
                            {
                                MessageBox.Show("Item do acervo Devolvido!");
                            }
                            else if (movimento == "Empréstimo")
                            {
                                MessageBox.Show("Empréstimo realizado com sucesso!");
                            }
                            else
                            {
                                MessageBox.Show("Reserva realizada com sucesso!");
                            }
                            limparForm();
                        }
                    }
                }
                InitializeTable();  
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Houve um problema ao realizar a reserva!\n{ex.Message}");
            }
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
                    row.Cells[colDataReserva.Index].Value = reserva.DataReserva.Substring(0, 10);
                    row.Cells[colDataRetorno.Index].Value = reserva.PrazoReserva.Substring(0, 10);
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
            btnLimpar.Enabled = true;
            btnSalvar.Enabled = false;
            cbxTipoMovimento.Enabled = false;
            dtpDataReserva.Enabled = false;
            dtpDataDevolucao.Enabled = false;
            txtCodItem.ReadOnly = true;
            txtCodLeitor.ReadOnly = true;
            btnBuscarItem.Enabled = false;
            btnBuscarLeitor.Enabled = false;
        }

        private void txtCodLeitor_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                ReservaDAO dao = new ReservaDAO(connection);

                txtNomeLeitor.Text = dao.GetNomeLeitor(new LeitorModel()
                {
                    CodLeitor = txtCodLeitor.Text
                });
            }
        }

        private void txtCodItem_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection connection = DaoConnection.GetConexao())
            {
                ReservaDAO dao = new ReservaDAO(connection);

                txtNomeItem.Text = dao.GetNomeItem(new ItemAcervoModel()
                {
                    CodItem = txtCodItem.Text
                });

                txtNumExemplar.Text = dao.GetNumExemplar(new ItemAcervoModel()
                 {
                     CodItem = txtCodItem.Text
                 });

                txtTipoItem.Text = dao.GetTipoItem(new ItemAcervoModel()
                {
                    CodItem = txtCodItem.Text
                });

                txtLocalizacao.Text = dao.GetLocalizacao(new ItemAcervoModel()
                {
                    CodItem = txtCodItem.Text
                });
            }
        }

        private void btnBuscarItem_Click(object sender, EventArgs e)
        {
            CarregaFormBuscaItemAcervo();
        }

        private void btnBuscarLeitor_Click(object sender, EventArgs e)
        {
            CarregaFormBuscaLeitor();
        }

        private void cbxTipoMovimento_TextChanged(object sender, EventArgs e)
        {
            if (cbxTipoMovimento.Text == "Reservar")
            {
                cbxStatusItem.SelectedIndex = 1;
            } else if (cbxTipoMovimento.Text == "Empréstimo")
            {
                cbxStatusItem.SelectedIndex = 2;
            } else
            {
                cbxStatusItem.SelectedIndex = 0;
            }
        }

        private void txtCodItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void txtCodLeitor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && !(e.KeyChar == (char)Keys.Space))
            {
                e.Handled = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparForm();
            btnLimpar.Enabled = false;
            btnSalvar.Enabled = true;
            cbxTipoMovimento.Enabled = true;
            dtpDataReserva.Enabled = true;
            dtpDataDevolucao.Enabled = true;
            txtCodItem.ReadOnly = false;
            txtCodLeitor.ReadOnly = false;
            btnBuscarItem.Enabled = true;
            btnBuscarLeitor.Enabled = true;
        }
    }
}
